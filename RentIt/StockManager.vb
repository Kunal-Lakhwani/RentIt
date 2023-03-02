Imports System.Data.SqlClient
Imports Guna.UI2.WinForms
Public Class StockManager

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
                    itm_code_tb.Focus()
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

    Private Sub StockManager_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        End
    End Sub

    Private Sub populateItemType()
        Dim d As New daoclass
        Dim dr As SqlDataReader
        dr = d.getdata("Select distinct i_type from Items_master")
        fltr_type_combo.Items.Add("No Selection")
        While dr.Read
            itm_type_combo.Items.Add(dr.Item(0))
            fltr_type_combo.Items.Add(dr.Item(0))
        End While
    End Sub

    Private Sub itm_list_grid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles itm_list_grid.CellDoubleClick
        Manage_Filter.SelectedTab = ManagePage
        Dim rowIdx As Integer = itm_list_grid.CurrentCell.RowIndex
        itm_code_tb.ReadOnly = True
        itm_code_tb.Text = itm_list_grid.Item(itm_code_col.Name, rowIdx).Value
        itm_name_tb.Text = itm_list_grid.Item(itm_name_col.Name, rowIdx).Value
        itm_type_combo.SelectedIndex = itm_type_combo.FindString(itm_list_grid.Item(itm_type_col.Name, rowIdx).Value)
        itm_qty_tb.Text = itm_list_grid.Item(itm_qty_col.Name, rowIdx).Value
        itm_stk_tb.Text = itm_list_grid.Item(itm_stk_col.Name, rowIdx).Value
        itm_stk_tb.Text = itm_list_grid.Item(itm_stk_col.Name, rowIdx).Value
        itm_rate_tb.Text = itm_list_grid.Item(itm_rate_col.Name, rowIdx).Value
        QueryPanel.Enabled = True
    End Sub

    Private Sub refreshData()
        Dim d As New daoclass
        Dim ds As New Data.DataSet
        ds = d.datasetfill("Select * from Items_master")
        Itemstbl = ds.Tables(0)

        filterItemsView = Itemstbl.Copy().DefaultView
        itm_list_grid.DataSource = filterItemsView
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        If itm_name_tb.Text = "" Then
            itm_name_tb.BorderColor = Color.Red
            itm_name_tb.Focus()
            Exit Sub
        End If
        If itm_qty_tb.Text = "" OrElse Not IsNumeric(itm_qty_tb.Text) Then
            itm_qty_tb.BorderColor = Color.Red
            itm_qty_tb.Focus()
            Exit Sub
        End If
        If itm_stk_tb.Text = "" OrElse Not IsNumeric(itm_stk_tb.Text) Then
            itm_stk_tb.BorderColor = Color.Red
            itm_stk_tb.Focus()
            Exit Sub
        End If
        If itm_rate_tb.Text = "" OrElse Not IsNumeric(itm_rate_tb.Text) Then
            itm_rate_tb.BorderColor = Color.Red
            itm_rate_tb.Focus()
            Exit Sub
        End If
        Dim choice = MessageBox.Show("Update details of " & itm_code_tb.Text & "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If choice = 6 Then
            Dim dao As New daoclass
            Dim para(6), val(6) As String
            para = {"@nme", "@type", "@qty", "@stk", "@rte", "@code"}
            val = {itm_name_tb.Text, itm_type_combo.SelectedItem.ToString, itm_qty_tb.Text,
                    itm_stk_tb.Text, itm_rate_tb.Text, itm_code_tb.Text}

            Dim qry As String
            qry = "Update Items_master set i_name = @nme, i_type = @type, 
                    i_qty = @qty, i_in_stk = @stk, 
                    i_rte = @rte where i_code = @code"
            dao.editdata(qry, para, val)
            refreshData()
            clearSelections()
        Else
            MessageBox.Show("Update Cancelled", "Cancellation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub delBtn_Click(sender As Object, e As EventArgs) Handles delBtn.Click
        Dim dao As New daoclass
        dao.editdata("Delete from Items_master where i_code = @code", {"@code"}, {itm_code_tb.Text})
        refreshData()
        clearSelections()
    End Sub

    Private Sub clearSelections()
        itm_code_tb.ReadOnly = False
        itm_code_tb.Text = ""
        itm_name_tb.Text = ""
        itm_type_combo.SelectedIndex = -1
        itm_qty_tb.Text = ""
        itm_stk_tb.Text = ""
        itm_rate_tb.Text = ""
        QueryPanel.Enabled = False
    End Sub

    Private Sub filterBtn_Click(sender As Object, e As EventArgs) Handles filtrBtn.Click
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

    Private Sub StockManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshData()
    End Sub

End Class