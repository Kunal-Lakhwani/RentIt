Imports System.Data.SqlClient
Public Class purchase_master

    'To perform disconnected database operations on Items_Master table
    Private DisconItemsDataset As New DataSet
    Private DisconItemsAdapter As SqlDataAdapter

    'To perform disconnected database operations on Purchase_Details table
    Private DisconPurchaseDataSet As New DataSet
    Private DisconPurchaseAdapter As New SqlDataAdapter

    Private UsedInvoiceNos As New List(Of String)
    Private VendorsDataSet As New DataSet

    Private InsertFlag As Boolean = True
    Private UpdateItmIndex As Integer = 0
    Private LockSupplierDetailsFlag As Boolean = False
    Private IsNavigating As Boolean = False


    Private Sub NavBtn_Enter(sender As Object, e As EventArgs) Handles toStockPurchase.Enter, toStockManager.Enter, toItemReturn.Enter, toGenerateReport.Enter, toDashBoard.Enter, toBillMaker.Enter, toBillHistory.Enter, toSettings.Enter, toPurchaseHistory.Enter
        btngotfocus(sender)
    End Sub

    Private Sub navBtn_Leave(sender As Object, e As EventArgs) Handles toStockPurchase.Leave, toStockManager.Leave, toItemReturn.Leave, toGenerateReport.Leave, toBillMaker.Leave, toBillHistory.Leave, toSettings.Leave, toPurchaseHistory.Leave
        btnlostfocus(sender)
    End Sub

    Private Sub toBillHistory_Click(sender As Object, e As EventArgs) Handles toBillHistory.Click
        BillHistory.Show()
        Me.Hide()
    End Sub

    Private Sub toGenerateReport_Click(sender As Object, e As EventArgs) Handles toGenerateReport.Click
        ReportPage.Show()
        Me.Hide()
    End Sub

    Private Sub toStockPurchase_Click(sender As Object, e As EventArgs) Handles toStockPurchase.Click
        purchaseMaster.Show()
        Me.Hide()
    End Sub

    Private Sub toItemReturn_Click(sender As Object, e As EventArgs) Handles toItemReturn.Click
        ItemReturn.Show()
        Me.Hide()
    End Sub

    Private Sub toBillMaker_Click(sender As Object, e As EventArgs) Handles toBillMaker.Click
        BillMaker.Show()
        Me.Hide()
    End Sub

    Private Sub toStockManager_Click(sender As Object, e As EventArgs) Handles toStockManager.Click
        stock.Show()
        Me.Hide()
    End Sub

    Private Sub toSettings_Click(sender As Object, e As EventArgs) Handles toSettings.Click
        AppSettings.Show()
        Me.Hide()
    End Sub

    Private Sub PageKeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        'The F2 key Is a shortcut key to go to the navigation panel
        'Pressing it once locks the focus inside the Navigation Panel
        'Pressing it again leaves the navigation panel And focuses on the
        'First Control of the form
        If e.KeyCode = Keys.F2 Then
            'Sets value of flag
            IsNavigating = Not IsNavigating
            If IsNavigating Then
                For Each ctrl In NavPanel.Controls
                    ctrl.TabStop = True
                Next
                toSettings.Focus()
            Else
                For Each ctrl In NavPanel.Controls
                    ctrl.TabStop = False
                    'Replace the Button with the first control of the form
                    InvNo.Focus()
                Next
            End If
        End If
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub NavPanel_Leave(sender As Object, e As EventArgs) Handles NavPanel.Leave
        If IsNavigating Then
            toSettings.Focus()
        End If
    End Sub

    Private Sub purchase_master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshDisconData()
        LoadInvoiceNos()
        LoadVendorData()
    End Sub

    Private Sub LoadInvoiceNos()
        UsedInvoiceNos.Clear()
        Dim d As New daoclass
        Dim re As SqlDataReader = d.getdata("Select p_invno from purchase_Master")
        While re.Read
            UsedInvoiceNos.Add(re.Item(0))
        End While
        d.closeconn()
    End Sub

    Private Sub LoadVendorData()
        Dim d As New daoclass
        VendorsDataSet = d.datasetfill("Select * from Vendor_Master")
        Dim autoSc As New AutoCompleteStringCollection()
        For i = 0 To VendorsDataSet.Tables(0).Rows.Count - 1
            autoSc.Add(VendorsDataSet.Tables(0).Rows(i)("ven_contact"))
        Next
        ven_cont.AutoCompleteCustomSource = autoSc
    End Sub

    Private Sub refreshDisconData()
        Dim d As New daoclass

        'Initialize DisconItemsDataset with table schema
        'And DisconItemsAdapter with insert and update command
        DisconItemsAdapter =
            New SqlDataAdapter("Select * from Items_master", d.getConnection())
        Dim Itmbuilder As New SqlCommandBuilder(DisconItemsAdapter)
        DisconItemsAdapter.InsertCommand = Itmbuilder.GetInsertCommand()
        DisconItemsAdapter.UpdateCommand = Itmbuilder.GetUpdateCommand()

        DisconItemsAdapter.Fill(DisconItemsDataset)

        'Initialize DisconPurchaseDataset with table schema
        'And DisconPurchaseAdapter with insert command
        DisconPurchaseAdapter = New SqlDataAdapter("Select * from Purchase_Details", d.getConnection())
        Dim Purbuilder As New SqlCommandBuilder(DisconPurchaseAdapter)
        DisconPurchaseAdapter.InsertCommand = Purbuilder.GetInsertCommand()

        DisconPurchaseAdapter.Fill(DisconPurchaseDataSet)

        'Remove database data from DisconPurchaseDataset
        'By doing this, The row Index of the dataset aligns with
        'The row index of the gridview, making deletion easier
        'Since we have given no delete command, database data will remain unchanged

        DisconPurchaseDataSet.Tables(0).Clear()

        'Give AutoComplete Sources to Item Code and Item Type fields
        Dim autoSourceItmCode As New AutoCompleteStringCollection()
        Dim autoSourceItmType As New AutoCompleteStringCollection()

        For i = 0 To DisconItemsDataset.Tables(0).Rows.Count - 1
            autoSourceItmCode.Add(DisconItemsDataset.Tables(0).Rows(i).Item(0))
            autoSourceItmType.Add(DisconItemsDataset.Tables(0).Rows(i).Item(2))
        Next

        It_code.AutoCompleteCustomSource = autoSourceItmCode
        It_type.AutoCompleteCustomSource = autoSourceItmType
    End Sub

    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles Insert.Click
        If blankvalidateitem() Then
            If InsertFlag Then
                'New Item
                Dim row As DataRow = DisconItemsDataset.Tables(0).NewRow()
                row("i_code") = It_code.Text
                row("i_name") = It_nme.Text
                row("i_type") = It_type.Text
                row("i_qty") = It_qty.Value
                row("i_in_stk") = It_qty.Value
                row("i_rte") = It_rte.Text

                DisconItemsDataset.Tables(0).Rows.Add(row)
            Else
                'Old Item stock update

                'Item Quantity value update
                DisconItemsDataset.Tables(0).Rows(UpdateItmIndex).Item(3) +=
                    It_qty.Value

                'Items in Stock value update
                DisconItemsDataset.Tables(0).Rows(UpdateItmIndex).Item(4) +=
                    It_qty.Value
            End If

            'Insert row in disconnected dataset
            Dim PurRow As DataRow = DisconPurchaseDataSet.Tables(0).NewRow()

            PurRow("pur_inv_no") = InvNo.Text
            PurRow("pur_it_Code") = It_code.Text
            PurRow("pur_it_qty") = It_qty.Value
            PurRow("pur_pc_Cst") = It_Pur_Cst.Text

            DisconPurchaseDataSet.Tables(0).Rows.Add(PurRow)

            PurchaseSubTotLbl.Text = Val(PurchaseSubTotLbl.Text) +
                (Val(It_Pur_Cst.Text) * It_qty.Value)

            PurchaseTotQtyLbl.Text = Val(PurchaseTotQtyLbl.Text) + It_qty.Value

            ItemDetails.Rows.Add(It_code.Text, It_nme.Text, It_qty.Text, It_Pur_Cst.Text)
            clear()
        End If
    End Sub

    Private Function blankvalidateitem() As Boolean
        If It_code.Text <> "" Then
            If It_nme.Text <> "" Then
                If It_Pur_Cst.Text <> "" Then
                    If It_rte.Text <> "" Then
                        Return True
                    Else
                        MessageBox.Show("Enter Item Rate")
                        It_rte.Focus()
                    End If
                End If
            Else
                MessageBox.Show("Enter Item Name")
                It_nme.Focus()
            End If
        Else
            MessageBox.Show("Enter Item Code")
            It_code.Focus()
        End If
        Return False
    End Function

    Private Sub clear(Optional ByVal clrall As Boolean = False)
        If clrall Then
            InvNo.Text = ""
            ven_nme.Text = ""
            ven_addr.Text = ""
            ven_cont.Text = ""
            ven_GST.Text = ""
            deb.Checked = False
            cred.Checked = False
            ven_cont.Text = ""
            InvNo.ReadOnly = False
            ven_cont.ReadOnly = False
            ven_nme.ReadOnly = False
            ven_addr.ReadOnly = False
            ven_GST.ReadOnly = False
            SupplierDetailsPanel.TabStop = True
            ItemDetails.Rows.Clear()
        End If
        It_code.Text = ""
        It_nme.Text = ""
        It_Pur_Cst.Text = ""
        It_nme.ReadOnly = False
        It_rte.Text = ""
        QtyActInfoLbl.Text = "Quantity"
        It_rte.ReadOnly = False
        It_type.Text = ""
        It_type.ReadOnly = False
        It_qty.Value = 1
        InsertFlag = True
    End Sub

    Private Sub Fin_Click(sender As Object, e As EventArgs) Handles Fin.Click
        Dim d As New daoclass
        Dim details As String = ""
        Dim i As Integer
        For i = 0 To ItemDetails.Rows.Count - 2
            details &= ItemDetails.Item(it_Code_col.Name, i).Value & ": " & ItemDetails.Item(it_qty_col.Name, i).Value & "pc at Rs. " & It_Pur_Cst.Text & " per pc<br>"
        Next
        details &= ItemDetails.Item(it_Code_col.Name, i).Value & ": " & ItemDetails.Item(it_qty_col.Name, i).Value & "pc at Rs. " & It_Pur_Cst.Text & " per pc"

        Dim dteStamp As New Date(Today.Ticks)
        Dim Values(10), ParameterNames(10) As String
        ParameterNames = {"@InvNo", "@vencont", "@dte", "@summary", "@qty", "@Subtot", "@GST", "@tot", "@mode"}

        Values = {
            InvNo.Text, ven_cont.Text, dteStamp.ToString("yyyy/MM/dd"), details,
            PurchaseTotQtyLbl.Text, PurchaseSubTotLbl.Text,
            PurchaseGST.Text, PurchaseTotLbl.Text, IIf(deb.Checked = True, "debit", "credit")
        }

        d.editdata(
            "Insert into purchase_Master 
            values(@InvNo, @vencont, @dte, @summary, @qty, @Subtot, @GST, @tot, @mode)",
            ParameterNames,
            Values
        )

        'Insert new items and update stock of old items
        DisconItemsAdapter.Update(DisconItemsDataset)

        'Insert new purchase details
        DisconPurchaseAdapter.Update(DisconPurchaseDataSet)


        'Showing Invoice Reciept
        Dim rept As New Purchase_Invoice_Print_Preview()
        rept.InvNo = InvNo.Text
        rept.PurchaseDate = dteStamp.ToString("dd/MM/yyyy")
        clear(clrall:=True)
    End Sub

    Private Sub purchase_master_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        End
    End Sub

    Private Sub It_code_LostFocus(sender As Object, e As EventArgs) Handles It_code.Leave
        For i = 0 To DisconItemsDataset.Tables(0).Rows.Count - 1
            If DisconItemsDataset.Tables(0).Rows(i).Item(0) = It_code.Text Then
                InsertFlag = False
                It_nme.Text = DisconItemsDataset.Tables(0).Rows(i).Item(1)
                It_type.Text = DisconItemsDataset.Tables(0).Rows(i).Item(2)
                It_rte.Text = DisconItemsDataset.Tables(0).Rows(i).Item(5)

                UpdateItmIndex = i

                QtyActInfoLbl.Text = "Quantity Increase"

                It_type.ReadOnly = True
                It_rte.ReadOnly = True
                It_nme.ReadOnly = True
                Exit For
            End If
        Next
        If InsertFlag Then
            It_type.Text = ""
            It_type.ReadOnly = False
            It_rte.Text = ""
            It_rte.ReadOnly = False
            It_nme.Text = ""
            It_nme.ReadOnly = False
        End If
    End Sub

    Private Sub It_code_GotFocus(sender As Object, e As EventArgs) Handles It_code.GotFocus
        If Not ven_cont.AutoCompleteCustomSource.Contains(ven_cont.Text) Then
            'Inserting new Vendor data into Vendor_Master
            Dim d As New daoclass
            'We replace vbCrLf with <br>
            'Now when we display it in crystal reports, we replace
            '<br> with ChrW(13) which gives newline char for crystal reports
            Dim vendorAddr As String = ven_addr.Text.Replace(vbCrLf, "<br>")

            d.editdata(
                        "Insert into Vendor_Master(ven_nme,ven_contact,ven_address,ven_GST_No)
                        values(@Name,@contact,@addr,@GSTNo)",
                        {"@Name", "@contact", "@addr", "@GSTNo"},
                        {ven_nme.Text, ven_cont.Text, vendorAddr, ven_GST.Text}
                    )
            LoadVendorData()
        End If
    End Sub

    Private Function blankvalidatesummary() As Boolean
        If InvNo.Text <> "" Then
            InvNo.BackColor = Color.White
            If ven_nme.Text <> "" Then
                ven_nme.BackColor = Color.White
                If ven_addr.Text <> "" Then
                    ven_addr.BackColor = Color.White
                    If ven_GST.Text <> "" Then
                        ven_GST.BackColor = Color.White
                        If deb.Checked OrElse cred.Checked Then
                            If ven_cont.Text <> "" Then
                                ven_cont.BackColor = Color.White
                                Return True
                            Else
                                ven_cont.BackColor = Color.Coral
                                ven_cont.Focus()
                            End If
                        Else
                            deb.Focus()
                        End If
                    Else
                        ven_GST.BackColor = Color.Coral
                        ven_GST.Focus()
                    End If
                Else
                    ven_addr.BackColor = Color.Coral
                    ven_addr.Focus()
                End If
            Else
                ven_nme.BackColor = Color.Coral
                ven_nme.Focus()
            End If
        Else
            InvNo.BackColor = Color.Coral
            InvNo.Focus()
        End If
        Return False
    End Function

    Private Sub ven_cont_Leave(sender As Object, e As EventArgs) Handles ven_cont.Leave
        'IndexOf returns index of given string in a collection.
        'If it does not exist, it returns -1
        Dim rowIdx As Integer = ven_cont.AutoCompleteCustomSource.IndexOf(ven_cont.Text)

        If rowIdx > -1 Then
            'If user has entered an existing Vendor Contact
            'Load all details of Vendor automatically
            Dim row As DataRow = VendorsDataSet.Tables(0).Rows(rowIdx)
            ven_nme.Text = row("ven_nme")
            ven_addr.Text = row("ven_address").ToString().Replace("<br>", vbCrLf)
            ven_GST.Text = row("ven_GST_No")
            ven_nme.ReadOnly = True
            ven_addr.ReadOnly = True
            ven_GST.ReadOnly = True
            deb.Focus()
        Else
            ven_nme.ReadOnly = False
            ven_addr.ReadOnly = False
            ven_GST.ReadOnly = False
            ven_nme.Text = ""
            ven_addr.Text = ""
            ven_GST.Text = ""
        End If
    End Sub

    Private Sub SupplierDetailsPanel_Leave(sender As Object, e As EventArgs) Handles SupplierDetailsPanel.Leave

        'LockSupplierDetailsFlag indicates wether Summary controls are locked or not

        If Not LockSupplierDetailsFlag Then
            'True if no blank fields, false otherwise
            If blankvalidatesummary() Then
                'Check for duplicate Invoice No.
                If UsedInvoiceNos.Contains(InvNo.Text) Then
                    MessageBox.Show(
                        "Duplicate Invoice number" & vbCrLf & "Invoice 
                with given number already registered. Please re-enter")
                    InvNo.Focus()
                    Exit Sub
                End If
                'Code unreachable if duplicate Invoice No.
                Dim choice As Integer =
                    MessageBox.Show(
                        "Lock current details?" & vbCrLf &
                        "You will be unable to change these details for this invoice later",
                        "Confirmation message",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question)
                If choice = 6 Then
                    InvNo.ReadOnly = True
                    ven_cont.ReadOnly = True
                    ven_nme.ReadOnly = True
                    ven_addr.ReadOnly = True
                    ven_GST.ReadOnly = True
                    SupplierDetailsPanel.TabStop = False
                    LockSupplierDetailsFlag = True
                Else
                    InvNo.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub PurchaseSubTotLbl_TextChanged(sender As Object, e As EventArgs) Handles PurchaseSubTotLbl.TextChanged
        If PurchaseGST.Text <> "" Then
            Dim SubtotVal As Integer = PurchaseSubTotLbl.Text
            Dim GSTPercent As Integer = PurchaseGST.Text
            PurchaseTotLbl.Text = SubtotVal + (SubtotVal * GSTPercent / 100)
        End If
    End Sub

    Private Sub SupplierDetailsPanel_Enter(sender As Object, e As EventArgs) Handles SupplierDetailsPanel.Enter
        If LockSupplierDetailsFlag Then
            It_code.Focus()
        End If
    End Sub
End Class