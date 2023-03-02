Public Class Reports

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
                    S_Dte_From.Focus()
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

    Private Sub Reports_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        End
    End Sub

    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Initializing Values
        Dim d As New daoclass

        Dim re As SqlClient.SqlDataReader = d.getdata("Select distinct biller_nme from Bill_master")
        S_biller.Items.Add("All Employees")
        While re.Read
            S_biller.Items.Add(re.Item(0))
        End While
        d.closeconn()
        re = d.getdata("Select distinct cst_cont from Bill_master")
        S_cst.Items.Add("All Customers")
        While re.Read
            S_cst.Items.Add(re.Item(0))
        End While
        d.closeconn()
        re = d.getdata("Select ven_contact from Vendor_Master")
        P_vendor.Items.Add("All Vendors")
        While re.Read
            P_vendor.Items.Add(re.Item(0))
        End While
        d.closeconn()
        P_vendor.SelectedIndex = 0
        P_sort.SelectedIndex = 0
        S_biller.SelectedIndex = 0
        S_cst.SelectedIndex = 0
        S_sort.SelectedIndex = 0
        P_Dte_From.Value = Today.AddMonths(-1)
        S_Dte_From.Value = Today.AddMonths(-1)

    End Sub

    Private Sub PurchaseReport_Click(sender As Object, e As EventArgs) Handles PurchaseReport.Click
        Dim d As New daoclass
        Dim rpt As Object = Nothing
        Dim qry As String = "Select v.*,p.* from Purchase_master p, Vendor_Master v 
                            where p.p_vendor_contact = v.ven_contact
                            And p.p_dte between '" & P_Dte_From.Value.ToString("yyyy/MM/dd") & "' And '" & P_Dte_To.Value.ToString("yyyy/MM/dd") & "'"

        If P_vendor.Text <> "All Vendors" Then
            qry &= " And p.p_vendor_contact = '" & P_vendor.Text & "'"
        End If
        Dim re1 As SqlClient.SqlDataReader = d.getdata(qry)
        Dim datadoesntexist As Boolean = True
        While re1.Read
            datadoesntexist = False
        End While
        d.closeconn()
        If datadoesntexist Then
            MessageBox.Show("No records available")
            Exit Sub
        End If
        dsReprt = d.datasetfill(qry)

        Dim rept As New Report_Viewer()
        rept.ReprtType = "Purchase"
        rept.OrderBy = P_sort.Text

        rept.Show()
    End Sub

    Private Sub SalesReport_Click(sender As Object, e As EventArgs) Handles SalesReport.Click
        Dim ds As New DataSet
        Dim d As New daoclass
        Dim qry As String = "Select * from Bill_Master where b_dte between '" & P_Dte_From.Value.ToString("yyyy/MM/dd") & "' And '" & P_Dte_To.Value.ToString("yyyy/MM/dd") & "'"
        If S_biller.Text <> "All Employees" Then
            qry &= " And biller_nme = '" & S_biller.Text & "'"
        End If
        If S_cst.Text <> "All Customers" Then
            qry &= " And cst_cont = " & S_cst.Text
        End If
        Dim re1 As SqlClient.SqlDataReader = d.getdata(qry)
        Dim datadoesntexist As Boolean = True
        While re1.Read
            datadoesntexist = False
        End While
        d.closeconn()
        If datadoesntexist Then
            MessageBox.Show("No records available")
            Exit Sub
        End If

        dsReprt = d.datasetfill(qry)

        Dim rept As New Report_Viewer()
        rept.ReprtType = "Sales"
        rept.OrderBy = S_sort.Text

        rept.Show()
    End Sub
End Class