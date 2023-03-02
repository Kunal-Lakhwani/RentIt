Public Class Item_Return
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
                    SrchCat.Focus()
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

    Private Sub Item_Return_Shown(sender As Object, e As EventArgs) Handles Me.Load
        ldata()
        SrchCat.SelectedIndex = 4
    End Sub

    Private Sub ldata(Optional ByVal concat As String = "")
        Dim d As New daoclass
        Dim ds As DataSet
        Dim qr1, qr2 As String
        qr1 = "Select it.id, bi.cst_nme, bi.cst_cont, it.i_code,it.i_qty,it.i_ret_dte from Items_on_rent it,Bill_Master bi where it.i_ret_dte < '" & Today.ToString("yyyy-MM-dd") & "' And bi.b_id = it.i_bill_id And it.i_returned = 0" & IIf(concat <> "", " And " & concat & ";", ";")
        qr2 = "Select it.id, bi.cst_nme, bi.cst_cont, it.i_code, it.i_qty, it.i_ret_dte From Items_on_rent it, Bill_Master bi Where bi.b_id = it.i_bill_id And it.i_ret_dte > '" & Today.AddDays(-1).ToString("yyyy-MM-dd") & "' And it.i_returned = 0 " & IIf(concat <> "", " And " & concat & ";", ";")
        ds = d.datasetfill(qr1)
        OverList.DataSource = ds.Tables(0)
        ds = d.datasetfill(qr2)
        RentedList.DataSource = ds.Tables(0)
        For i = 0 To OverList.Rows.Count - 1
            OverList.Item(Overdcount.Name, i).Value = (Today - CDate(OverList.Item(Rented_ret_date.Name, i).Value)).TotalDays & " day(s)"
        Next
    End Sub

    Private Sub Item_returned(sender As Object, e As DataGridViewCellEventArgs) Handles RentedList.CellDoubleClick, OverList.CellDoubleClick
        Dim dao As New daoclass
        Dim re As SqlClient.SqlDataReader
        Dim dbqty As String = ""
        If sender.name = RentedList.Name Then
            Dim d As Integer = MessageBox.Show("Confirm return of item '" & RentedList.Item(iCode.Name, RentedList.CurrentCell.RowIndex).Value & "'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            If d = 6 Then
                dao.editdata("Update Items_on_rent set i_returned = 1 where id = " & CInt(RentedList.Item(rId.Name, RentedList.CurrentCell.RowIndex).Value))
                re = dao.getdata("Select i_in_stk from Items_master where i_code = '" & RentedList.Item(iCode.Name, RentedList.CurrentCell.RowIndex).Value & "'")
                While re.Read
                    dbqty = re.Item(0)
                End While
                dao.closeconn()
                dbqty += CInt(RentedList.Item(iQty.Name, RentedList.CurrentCell.RowIndex).Value)
                dao.editdata("Update Items_master set i_in_stk = " & dbqty & "where i_code = '" & RentedList.Item(iCode.Name, RentedList.CurrentCell.RowIndex).Value & "'")
            End If
        Else
            Dim d As Integer = MessageBox.Show("Confirm return of item '" & OverList.Item(Rented_iCode.Name, OverList.CurrentCell.RowIndex).Value & "'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            If d = 6 Then
                dao.editdata("Update Items_on_rent set i_returned = 2 where id = " & CInt(OverList.Item(Rented_id.Name, OverList.CurrentCell.RowIndex).Value))
                re = dao.getdata("Select i_in_stk from Items_master where i_code = '" & OverList.Item(Rented_iCode.Name, OverList.CurrentCell.RowIndex).Value & "'")
                While re.Read
                    dbqty = re.Item(0)
                End While
                dao.closeconn()
                dbqty += CInt(OverList.Item(Rented_Qty.Name, OverList.CurrentCell.RowIndex).Value)
                dao.editdata("Update Items_master set i_in_stk = " & dbqty & "where i_code = '" & OverList.Item(Rented_iCode.Name, OverList.CurrentCell.RowIndex).Value & "'")
            End If
        End If
        ldata()
    End Sub

    Public Sub End_This(sender As Object, e As EventArgs) Handles Me.Disposed
        End
    End Sub

    Private Sub SrchCat_SelectedIndexChanged(sender As Object, e As EventArgs)
        'If SrchCat.Text.StartsWith("Return date") Then
        '    reportPanel.Enabled = True
        '    Srchtxt.Enabled = False
        'Else
        '    reportPanel.Enabled = False
        '    Srchtxt.Enabled = True
        'End If
    End Sub

    Private Sub Srchtxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Srchtxt.KeyPress
        Dim d As New daoclass
        e.Handled = d.alphanuvalidate(e.KeyChar, e.KeyChar.GetHashCode)
    End Sub

    Private Sub SrchBtn_Click(sender As Object, e As EventArgs) Handles SrchBtn.Click
        Dim concat As String = ""
        Select Case SrchCat.SelectedIndex
            Case 0 'Customer Contact
                concat = "CAST(it.i_Cst_con as varchar(10)) like '" & Val(Srchtxt.Text) & "%'"
            Case 1 'Return date
                concat = "it.i_ret_dte = '" & DteOn.Value.ToString("yyyy-MM-dd") & "'"
            Case 2 'Item Code
                concat = "it.i_code like '" & Srchtxt.Text & "%'"
            Case 3 'Bill No.
                concat = "it.i_bill_id = " & Val(Srchtxt.Text)
        End Select
        ldata(concat)
    End Sub

    Private Sub SrchCat_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles SrchCat.SelectedIndexChanged
        If SrchCat.SelectedIndex = 1 Then
            reportPanel.Enabled = True
            Srchtxt.Enabled = False
        Else
            Srchtxt.Enabled = True
            reportPanel.Enabled = False
        End If
    End Sub

End Class