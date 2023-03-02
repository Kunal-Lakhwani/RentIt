Public Class Dashboard

    Private IsNavigating As Boolean = False
    Private filterItemsView As DataView

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
                    InfoPage.Focus()
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

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Loads All items in stock to Items table
        'Initializes Public DataTable Itemstbl with data of all Items
        'This makes it easier to work in disconnected mode
        'Itemstbl located in DataShareAndMore Module
        Dim d As New daoclass
        Dim ds As New Data.DataSet
        ds = d.datasetfill("Select * from Items_master")
        Itemstbl = ds.Tables(0)

        'Initializes Private View with a copy of Itemstbl
        filterItemsView = Itemstbl.Copy().DefaultView
        itm_list_grid.DataSource = filterItemsView

        'Properly resizes Items grid to fill the screen
        itm_list_panel.Height = FilterPage.Height - filter_ctrl_panel.Height

    End Sub

    Private Sub filtrBtn_Click(sender As Object, e As EventArgs) Handles filtrBtn.Click
        Dim filterStr As String = ""
        If fltr_code_tb.Text <> "" Then
            filterStr = "i_code like '%" & fltr_code_tb.Text & "%'"
        End If
        If fltr_type_combo.SelectedIndex > 0 Then
            If filterStr <> "" Then
                filterStr &= " And "
            End If
            filterStr &= "i_type = '" & fltr_type_combo.Text & "'"
        End If
        If fltr_name_tb.Text <> "" Then
            If filterStr <> "" Then
                filterStr &= " And "
            End If
            filterStr &= "i_name like '%" & fltr_name_tb.Text & "%'"
        End If
        If fltr_rate_tb.Text <> "" AndAlso IsNumeric(fltr_rate_tb.Text) Then
            If filterStr <> "" Then
                filterStr &= " And "
            End If
            If fltr_rate_gt.Checked Then
                filterStr &= " i_rte > " & fltr_rate_tb.Text
            End If
            If fltr_rate_lt.Checked Then
                filterStr &= " i_rte < " & fltr_rate_tb.Text
            End If
        End If
        filterItemsView.RowFilter = filterStr
    End Sub

    Private Sub clrBtn_Click(sender As Object, e As EventArgs) Handles clrBtn.Click
        fltr_name_tb.Text = ""
        fltr_type_combo.SelectedIndex = 0
        fltr_rate_tb.Text = ""
        filterItemsView.RowFilter = ""
    End Sub

    Private Sub Dashboard_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        End
    End Sub
End Class