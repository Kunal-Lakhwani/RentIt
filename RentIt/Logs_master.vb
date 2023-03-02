Public Class Logs_master

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
                    L_Dte_frm.Focus()
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

    Private Sub GenReport_Click(sender As Object, e As EventArgs) Handles GenReport.Click
        Dim d As New daoclass
        Dim ds As DataSet
        Dim qry As String = "Select * from Logs_Master where Log_date >= '" & L_Dte_frm.Value.ToString("yyyy/MM/dd") & "' And Log_date <= '" & L_Dte_to.Value.ToString("yyyy/MM/dd") & "'"
        If L_emp.Text <> "All Employees" Then
            qry &= " And Log_Emp = '" & L_emp.Text & "'"
        End If
        If L_act.Text <> "All Actions" Then
            qry &= " And Log_action = '" & L_act.Text & "'"
        End If
        ds = d.datasetfill(qry)
        LogList.DataSource = ds.Tables(0)
        dsReprt = ds
    End Sub


    Private Sub Logs_master_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        End
    End Sub

    Private Sub Logs_master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim d As New daoclass
        Dim re As SqlClient.SqlDataReader = d.getdata("Select distinct Log_action from Logs_Master where")
        L_act.Items.Add("All Actions")
        While re.Read
            L_act.Items.Add(re.Item(0))
        End While
        d.closeconn()
        re = d.getdata("Select distinct Log_Emp from Logs_Master")
        L_emp.Items.Add("All Employees")
        While re.Read
            L_emp.Items.Add(re.Item(0))
        End While
        d.closeconn()
        L_emp.SelectedIndex = 0
        L_act.SelectedIndex = 0
        L_Dte_frm.Value = Today.AddMonths(-1)
    End Sub

End Class