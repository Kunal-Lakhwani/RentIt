Public Class Bill_History

    Private CustList As New DataTable
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
                    BillerName.Focus()
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

    Private Sub BillHistory_Load(sender As Object, e As EventArgs) Handles Me.Load
        DteFrom.MaxDate = Today
        DteTo.MaxDate = Today
        DteFrom.Value = Today.AddMonths(-1)
        LoadBillers()
        LoadCustomers()
    End Sub

    Private Sub LoadBillers()
        BillerName.Items.Add("All Billers")
        Dim d As New daoclass
        Dim ds As DataSet = d.datasetfill("Select distinct biller_nme from Bill_Master")
        For i = 0 To ds.Tables(0).Rows.Count - 1
            BillerName.Items.Add(ds.Tables(0).Rows(i)("biller_nme"))
        Next
        BillerName.SelectedIndex = 0
    End Sub

    Private Sub LoadCustomers()
        Dim d As New daoclass
        Dim ds As DataSet = d.datasetfill("Select c_contact,c_nme from Customer_master")
        CustList = ds.Tables(0)
        CustContact.Items.Add("All Customers")
        For i = 0 To CustList.Rows.Count - 1
            CustContact.Items.Add(CustList.Rows(i)("c_contact"))
        Next
        CustContact.SelectedIndex = 0
    End Sub

    Private Sub GenReport_Click(sender As Object, e As EventArgs) Handles GenReport.Click
        Dim d As New daoclass
        Dim qry As String = "Select * from Bill_Master"

        If DteFrom.Value = DteTo.Value Then
            qry &= " where b_Dte between '" & DteFrom.Value.ToString("yyyy/MM/dd") & "'"
        Else
            qry &= " where b_Dte between '" & DteFrom.Value.ToString("yyyy/MM/dd") & "' and '" &
               DteTo.Value.ToString("yyyy/MM/dd") & "'"
        End If
        If BillerName.Text <> "All Billers" Then
            qry &= " and biller_nme = '" & BillerName.Text & "'"
        End If
        If CustContact.Text <> "All Customers" Then
            qry &= " and cst_cont = " & CustContact.Text
        End If

        Dim ds As DataSet = d.datasetfill(qry)
        prevBills.DataSource = ds.Tables(0)
    End Sub

    Private Sub CustContact_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CustContact.SelectedIndexChanged
        If CustContact.SelectedIndex = 0 Then
            CustName.Text = ""
        Else
            CustName.Text = CustList.Rows(CustContact.SelectedIndex - 1)("c_nme")
        End If
    End Sub

    Private Sub prevBills_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles prevBills.CellDoubleClick
        Dim rowIdx As Integer = prevBills.CurrentRow.Index
        Dim billId As Integer = prevBills.Item(b_no.Name, rowIdx).Value
        Dim billDate As String = CType(prevBills.Item(b_date.Name, rowIdx).Value, Date).ToString("dd/MM/yyyy")
        Dim customerName As String = prevBills.Item(b_Cst_nme.Name, rowIdx).Value
        Dim customerContact As String = prevBills.Item(b_Cst_cont.Name, rowIdx).Value
        Dim subtot As String = prevBills.Item(b_Subtot.Name, rowIdx).Value
        Dim discount As String = prevBills.Item(b_Disc.Name, rowIdx).Value
        Dim Gtot As String = prevBills.Item(b_grandTot.Name, rowIdx).Value

        Dim report As New Bill_Print_Preview

        Dim qry As String =
                    "Select it.i_name,rent.* 
                    from Items_master it, Items_on_rent rent
                    where 
                    it.i_code = rent.i_code
                    And rent.i_bill_id = " & billId

        Dim d As New daoclass
        'dsReprt is a public dataset of DataShareAndMore Module
        'It is used as a dataset for Reports

        dsReprt = d.datasetfill(qry)

        report.ParamVals =
            {billId, billDate, customerName, customerContact,
            subtot, discount, Gtot}
        report.Show()
    End Sub

End Class