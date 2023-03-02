Imports System.Data.SqlClient
Public Class Bill_Maker

    Private isBilling As Boolean = False
    Private isNavigating As Boolean = False

    Private billID As Integer = 0
    Private totQty As Integer

    'Using RentedItemsAdapter and RentedItems, we perform datmanipulation in Disconnected mode.
    'Thus, only once the data is confirmed it is commited to the database

    Private RentedItemsAdapter As SqlDataAdapter
    Private RentedItems As New DataSet

    'List of all existing customers
    Private Cust_Lst As New DataSet

    'Used to Prefetch Item details to use in disconnected mode
    Private ItemsList As New DataTable

    Private DigiBillDataTable As New DataTable

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
            isNavigating = Not isNavigating
            If isNavigating Then
                For Each ctrl In NavPanel.Controls
                    ctrl.TabStop = True
                Next
                toSettings.Focus()
            Else
                For Each ctrl In NavPanel.Controls
                    ctrl.TabStop = False
                    'Replace the Button with the first control of the form
                    IsNewCST.Focus()
                Next
            End If
        End If
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub NavPanel_Leave(sender As Object, e As EventArgs) Handles NavPanel.Leave
        If isNavigating Then
            toSettings.Focus()
        End If
    End Sub

    Private Sub Me_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        End
    End Sub

    Private Sub LoadCustomers()
        Dim d As New daoclass
        Dim autoSource As New AutoCompleteStringCollection()
        Cust_Lst = d.datasetfill("Select * from Customer_master")
        For i = 0 To Cust_Lst.Tables(0).Rows.Count - 1
            autoSource.Add(Cust_Lst.Tables(0).Rows(i).Item(2).ToString())
        Next
        Custcontact.AutoCompleteCustomSource = autoSource
    End Sub

    Private Sub LoadItems()
        Dim d As New daoclass
        Dim ds As New DataSet
        ds = d.datasetfill("Select * from Items_master where i_in_stk > 0")
        ItemsList = ds.Tables(0)
        Itm_code.DataSource = ItemsList
        Itm_code.ValueMember = "i_code"
        Itm_code.DisplayMember = "i_code"
    End Sub

    Private Sub refreshDisconnectedData()
        Dim d As New daoclass

        RentedItemsAdapter = New SqlDataAdapter(
            "Select i_code,i_qty,i_rte,i_dur,i_req_dte,i_ret_dte,i_Cst_con,i_bill_id,i_returned 
            from Items_on_Rent",
            d.getConnection()
        )
        RentedItemsAdapter.InsertCommand = New SqlCommandBuilder(RentedItemsAdapter).GetInsertCommand(True)
        RentedItemsAdapter.Fill(RentedItems)
        RentedItems.Tables(0).Rows.Clear()

    End Sub

    Private Sub DateFrom_ValueChanged(sender As Object, e As EventArgs) Handles DateFrom.ValueChanged
        DateTo.MinDate = DateFrom.Value.AddDays(1)
    End Sub

    Private Sub Ins_Itm_Click(sender As Object, e As EventArgs) Handles Ins_Itm.Click
        If biller.Enabled Then
            Dim dcount As Integer = (DateTo.Value - DateFrom.Value).TotalDays
            Dim d As New daoclass
            SubTot.Text += Val(Itm_cst.Text) * Itm_qty.Value * dcount
            Dim discount As Integer = IIf(Disc.Text.EndsWith("%"), Val(SubTot.Text) * Val(Disc.Text) / 100, Val(Disc.Text))
            If isBilling Then

                Dim row As DataRow = RentedItems.Tables(0).NewRow
                Dim itmQty As Integer = Itm_qty.Value
                'Check wether same item is already in the bill
                'If so, merge the previous entry and this one
                For i = 0 To Digibill.Rows.Count - 1
                    'itm_Lst_idx has index of corresponding Item in Combobox
                    If Digibill.Item(itm_Lst_idx.Name, i).Value = Itm_code.SelectedIndex Then
                        'Update Item Quantity as sum of previous and current quantity
                        itmQty += Digibill.Item(b_i_qty.Name, i).Value
                        'Delete previous
                        Digibill.Rows.RemoveAt(i)
                        RentedItems.Tables(0).Rows.RemoveAt(i)
                        Exit For
                    End If
                Next

                row("i_code") = Itm_code.Text
                row("i_qty") = itmQty
                row("i_rte") = Itm_cst.Text
                row("i_dur") = dcount
                row("i_req_dte") = DateFrom.Value.ToString("yyyy-MM-dd")
                row("i_ret_dte") = DateTo.Value.ToString("yyyy-MM-dd")
                row("i_Cst_con") = Custcontact.Text
                row("i_bill_id") = billID
                row("i_returned") = 0
                RentedItems.Tables(0).Rows.Add(row)

                totQty += Itm_qty.Value
                'We Add the selectedIndex to the gridview so that it is easy
                'To update stock counts when deleting the item or merging the item
                Digibill.Rows.Add(Itm_code.SelectedIndex, Itm_code.Text, Itm_nme.Text, (dcount & " d."), itmQty, Itm_cst.Text)

                'Update Stock Counts of Items List
                ItemsList.Rows(Itm_code.SelectedIndex).Item(4) =
                    Val(ItemsList.Rows(Itm_code.SelectedIndex).Item(4)) - Itm_qty.Value
            End If
        End If
    End Sub

    Private Sub Disc_TextChanged(sender As Object, e As EventArgs) Handles Disc.TextChanged
        If Disc.Text.EndsWith("%") Then
            If Val(Disc.Text.TrimEnd("%")) > 100 Then
                Disc.Text = "100%"
            End If
            GTot.Text = Val(SubTot.Text) - (Val(SubTot.Text) * Val(Disc.Text) / 100)
        Else
            GTot.Text = Val(SubTot.Text) - Val(Disc.Text)
        End If
    End Sub

    Private Sub Item_code_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Itm_code.SelectedIndexChanged
        Try
            Itm_nme.Text = ItemsList.Rows(Itm_code.SelectedIndex).Item(1)
            Itm_qty.Maximum = ItemsList.Rows(Itm_code.SelectedIndex).Item(4)
            Itm_ttl.Text = "/" & ItemsList.Rows(Itm_code.SelectedIndex).Item(4)
            Itm_cst.Text = ItemsList.Rows(Itm_code.SelectedIndex).Item(5)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PrntBill_Click(sender As Object, e As EventArgs) Handles PrntBill.Click
        If Digibill.Rows.Count > 0 Then
            If Pay_now.Checked OrElse From_Bal.Checked Then
                Me.Cursor = Cursors.WaitCursor
                Dim d As New daoclass
                Dim paystr As String = ""
                If Pay_now.Checked Then
                    paystr = "deb"
                End If
                If From_Bal.Checked Then
                    If paystr <> "" Then
                        paystr &= " & cred"
                    Else
                        paystr = "cred"
                        d.update_Cust_Balance(Custcontact.Text, 0 - Val(GTot.Text))
                    End If
                End If

                'RentedItemsAdapter.Update(RentedItems) 
                'Inserts Records in Items_on_Rent automatically

                'Once data is inserted, the stock counts of respective Items in
                'Items Master are updated automatically by AFTER INSERT Trigger

                RentedItemsAdapter.Update(RentedItems)
                refreshDisconnectedData()

                'Update Bill Master table record of current bill to include
                'Grand total, discount, etc

                'Converts Rupees Discount to percentage
                Dim discount As Integer = IIf(Disc.Text.EndsWith("%"), Val(Disc.Text), Val(SubTot.Text) * Val(Disc.Text) / 100)
                d.editdata("Update Bill_Master set 
                            b_Itm_Qty = @Qty, b_subtot = @subtot, b_disc = @disc,
                            b_gtot = @gtot, b_paymode = @pay
                            where b_id = @bID",
                            {"@Qty", "@subtot", "@disc", "@gtot", "@pay", "@bID"},
                            {totQty, SubTot.Text, discount, GTot.Text, paystr, billID})

                isBilling = False
                'Update Customer table to include new value of previous discount

                'Initialize Val Array of Report to proper values
                'To display info
                Dim report As New Bill_Print_Preview

                Dim qry As String =
                    "Select it.i_name,rent.* 
                    from Items_master it, Items_on_rent rent
                    where 
                    it.i_code = rent.i_code
                    And rent.i_bill_id = " & billID

                'dsReprt is a public dataset of DataShareAndMore Module
                'It is used as a dataset for Reports

                dsReprt = d.datasetfill(qry)

                report.ParamVals =
                    {billID, Today.Date.ToString(), Custname.Text, Custcontact.Text,
                    SubTot.Text, discount, GTot.Text}
                report.Show()
                Cursor = Cursors.Default
                payment = 0
                ClearFields()
            Else
                MessageBox.Show("Please choose a payment mode")
            End If
        End If
    End Sub

    Private Sub CreateNewBill()
        If Not isBilling Then
            'By using SqlTransaction, we ensure that no matter how many billing stations
            'there are, there is never a data integrity clash between them,
            ' i.e. - Two billers generating bills at the same time and Biller2 reading the
            '        b_id of Biller1

            Dim d As New daoclass
            d.getConnection().Open()
            Dim transac As SqlTransaction
            Dim params() As String = {"@emName", "@CstName", "@CstContact", "@Dte"}
            Dim vals() As String = {Emp_nme, Custname.Text, Custcontact.Text, Today.ToString("yyyy-MM-dd")}
            Dim query As String = "Insert into Bill_Master(biller_nme,cst_nme,cst_cont,b_Itm_Qty,b_subtot,b_disc,b_gTot,b_Dte) values(@emName,@CstName,@CstContact,0,0,0,0,@Dte)"
            transac = d.getConnection().BeginTransaction()
            d.Transaceditdata(query, params, vals, transac)
            transac.Commit()
            'Read BillID of recently made Bill to insert into i_bill_id column of 
            'Items_on_rent

            Dim cmd As New SqlCommand("Select max(b_id) from Bill_Master", d.getConnection())
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            While dr.Read
                billID = dr.Item(0)
            End While
            d.closeconn()
            isBilling = True
        End If
    End Sub

    Private Sub ClearFields()
        Itm_code.DataSource = Nothing
        NavPanel.Enabled = True
        Itm_code.Text = ""
        Custcontact.Text = ""
        Custcontact.ReadOnly = False
        Custname.Text = ""
        Custname.ReadOnly = False
        CstOpBal.Text = ""
        Itm_nme.Text = ""
        Itm_cst.Text = ""
        ContDisplay.Text = ""
        NmeDisplay.Text = ""
        SubTot.Text = 0
        GTot.Text = 0
        Disc.Text = 0
        DateFrom.Value = Today
        Digibill.Rows.Clear()
        biller.Enabled = False
        IsNewCST.Focus()
        isBilling = False
        billID = 0
    End Sub

    Private Sub Custcontact_GotFocus(sender As Object, e As EventArgs) Handles Custcontact.GotFocus
        If Not IsNewCST.Checked Then
            Custname.ReadOnly = True
        Else
            Custname.ReadOnly = False
        End If
    End Sub

    Private Sub Cust_manager_Leave(sender As Object, e As EventArgs) Handles Cust_manager.Leave
        Custcontact.ReadOnly = True
        Custname.ReadOnly = True
        If Not IsNewCST.Checked Then
            NmeDisplay.Text = Custname.Text
            ContDisplay.Text = Custcontact.Text
            NmeDisplay.Visible = True
            ContDisplay.Visible = True
        End If
    End Sub

    Private Sub Bill_maker_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If isBilling Then
            e.Cancel = True
            MessageBox.Show("Cannot close until Billing is resolved")
        End If
    End Sub
    Private Sub Custname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Custname.KeyPress
        Dim d As New daoclass
        e.Handled = d.charvalidate(e.KeyChar, e.KeyChar.GetHashCode)
    End Sub

    Private Sub Custcontact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Custcontact.KeyPress
        Dim d As New daoclass
        e.Handled = d.numvalidate(e.KeyChar, e.KeyChar.GetHashCode)
    End Sub


    Private Sub buttonfocus(sender As Object, e As EventArgs) Handles PrntBill.GotFocus, Ins_Itm.GotFocus
        btngotfocus(sender)
    End Sub

    Private Sub buttonlostfocus(sender As Object, e As EventArgs) Handles PrntBill.LostFocus, Ins_Itm.LostFocus
        btnlostfocus(sender)
    End Sub

    Private Sub Bill_maker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SubTot.Text = 0
        GTot.Text = 0
        LoadCustomers()
        refreshDisconnectedData()
    End Sub

    Private Sub CnclBilling_Click(sender As Object, e As EventArgs) Handles CnclBilling.Click
        If isBilling Then
            Dim d As New daoclass
            d.editdata("Delete from Bill_Master where b_id = " & billID)
            isBilling = False
            ClearFields()
        End If
    End Sub

    Private Sub Custname_LostFocus(sender As Object, e As EventArgs) Handles Custname.LostFocus
        'If customer is a new Customer, perform validations and enter
        'Details into the database
        If IsNewCST.Checked Then
            Dim d As New daoclass
            If Custcontact.Text.Length = 10 Then
                'Loop through all customers and see if the given Customer contact
                'Already exists in the database
                For Each row As DataRow In Cust_Lst.Tables(0).Rows
                    If row.Item("c_contact") = Custcontact.Text Then
                        MessageBox.Show("Given Contact number is already registered." &
                            vbCrLf & "Please enter an unregistered contact number")
                        Custcontact.BackColor = Color.Coral
                        Custcontact.Focus()
                        Exit Sub
                    End If
                Next
                If Custname.Text <> "" Then
                    d.editdata("Insert into Customer_master(c_nme,c_contact,c_opBal,c_prev_Disc) values('" & Custname.Text & "'," & Custcontact.Text & ",0,0)")
                    d.createlog("A new customer was created")
                    CreateNewBill()
                    biller.Enabled = True
                    LoadCustomers()
                    NmeDisplay.Text = Custname.Text
                    ContDisplay.Text = Custcontact.Text
                    Custcontact.ReadOnly = True
                    Custname.ReadOnly = True
                    LoadItems()
                    Itm_code.Focus()
                Else
                    MessageBox.Show("Name cannot be blank")
                    Custname.Focus()
                End If
            Else
                MessageBox.Show("Contact number must be 10 digits long")
                Custcontact.BackColor = Color.Coral
                Custcontact.Focus()
            End If
        End If
    End Sub

    Private Sub Digibill_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Digibill.CellDoubleClick
        Dim rowIndex As Integer = Digibill.CurrentRow.Index
        Dim delItmNme As String = Digibill.Item(b_i_name.Name, rowIndex).Value
        Dim delItmQty As Integer = Digibill.Item(b_i_qty.Name, Digibill.CurrentCell.RowIndex).Value
        Dim delItmRte As String = Digibill.Item(b_i_rate.Name, rowIndex).Value
        Dim delItmDur As Integer = Val(Digibill.Item(b_i_dur.Name, Digibill.CurrentCell.RowIndex).Value.ToString.TrimEnd(" d."))
        Dim choice As Integer =
            MessageBox.Show(
                "Remove " & delItmNme & " from Bill?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

        'Yes selected:
        If choice = 6 Then

            'Update total quantity
            totQty -= delItmQty

            'Recalculating Subtotal
            SubTot.Text = Val(SubTot.Text) - (delItmQty * delItmDur * delItmRte)

            Dim itm_Qty_val = Digibill.Item(b_i_qty.Name, rowIndex).Value
            Dim itm_idx = Digibill.Item(itm_Lst_idx.Name, rowIndex).Value

            'Update Item List stock count
            ItemsList.Rows(itm_idx).Item(4) =
                Val(ItemsList.Rows(itm_idx).Item(4)) + itm_Qty_val

            'The amount and correspondence of rows in Bill Gridview
            'And Disconnected data table is always same
            'Therefore, Row Index of one points to the other

            RentedItems.Tables(0).Rows.RemoveAt(rowIndex)
            Digibill.Rows.RemoveAt(rowIndex)
        End If
    End Sub

    Private Sub Custcontact_Leave(sender As Object, e As EventArgs) Handles Custcontact.Leave
        If Not IsNewCST.Checked Then
            'If it is a returning customer fetch their details
            For Each row As DataRow In Cust_Lst.Tables(0).Rows
                If row("c_contact") = Custcontact.Text Then
                    Custname.Text = row("c_nme")
                    CstOpBal.Text = row("c_opBal")
                    Disc.Text = row("c_prev_Disc") & "%"
                    Exit For
                End If
            Next
            Custcontact.ReadOnly = True
            CreateNewBill()
            biller.Enabled = True
            Itm_code.Focus()
            LoadItems()
        End If
    End Sub

    Private Sub Disc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Disc.KeyPress
        Dim d As New daoclass
        '2424869 is hashcode for %
        e.Handled = d.numvalidate(e.KeyChar, e.KeyChar.GetHashCode) AndAlso e.KeyChar.GetHashCode <> 2424869
    End Sub

    Private Sub IsNewCST_Leave(sender As Object, e As EventArgs) Handles IsNewCST.Leave
        IsNewCST.BackColor = Color.White
        IsNewCST.ForeColor = Color.FromArgb(153, 6, 58)
    End Sub

    Private Sub IsNewCST_Enter(sender As Object, e As EventArgs) Handles IsNewCST.Enter
        IsNewCST.BackColor = Color.FromArgb(153, 6, 58)
        IsNewCST.ForeColor = Color.White
    End Sub
End Class