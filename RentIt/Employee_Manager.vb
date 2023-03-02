Public Class Employee_Manager

    Private isNavigating As Boolean = False


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
                    Emname.Focus()
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

    Private Sub ldata()
        Dim d As New daoclass
        Dim ds As New DataSet
        ds = d.datasetfill("Select * from user_master where E_mailID != '" & Emp_mailID & "'")
        DatagridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Del_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If blankvalidate() Then
            Dim d As New daoclass
            Dim v(1), p(1) As String
            p = {"@mail"}
            v = {emMail.Text}
            Dim IsAdmin As Boolean = AdminCheck()
            If IsAdmin Then
                If emMail.ReadOnly Then
                    Dim confirm = MessageBox.Show(
                        "Delete Employee account " & emMail.Text & "?",
                        "Deletion confirmation", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning)
                    If confirm = 6 Then
                        d.editdata("delete from user_master where E_mailID = 
                                    @mail", p, v)
                    Else
                        MessageBox.Show("Deletion cancelled")
                    End If
                Else
                    MessageBox.Show("Employee not selected" & vbCrLf &
                                    "Please select Employee from the table")
                End If
            Else
                MessageBox.Show("Admin password invalid")
                adm_pwd.Text = ""
                adm_pwd.Focus()
            End If
        End If
        clear()
        ldata()
    End Sub

    Private Sub clear()
        adm_pwd.Text = ""
        emMail.Text = ""
        EmPwd.Text = ""
        EmRole.Text = ""
        emMail.ReadOnly = False
    End Sub

    Private Sub closeall(sender As Object, e As EventArgs) Handles Me.Disposed
        End
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatagridView1.CellDoubleClick
        emMail.ReadOnly = True
        emMail.Text = DatagridView1.Item(mail.Name,
                                         DatagridView1.CurrentCell.RowIndex).Value
        EmPwd.Text = DatagridView1.Item(pass_word.Name,
                                        DatagridView1.CurrentCell.RowIndex).Value
        EmRole.Text = DatagridView1.Item(E_role.Name,
                                         DatagridView1.CurrentCell.RowIndex).Value
    End Sub

    Private Sub Me_Shown(sender As Object, e As EventArgs) Handles Me.Load
        ldata()
    End Sub

    Private Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Logo blue: Color.FromArgb(11, 36, 69)
        'Logo Red: Color.FromArgb(152, 6, 58)
        ldata()
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If blankvalidate() Then
            Dim d As New daoclass
            Dim v(2), p(2) As String
            Dim IsAdmin As Boolean = AdminCheck()
            If IsAdmin Then
                If Not emMail.ReadOnly Then
                    Dim confirm = MessageBox.Show("Insert new Employee account:" & vbCrLf & "Mail ID:" & emMail.Text & vbCrLf & "Role: " & vbCrLf & EmRole.Text & "?", "Insertion confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If confirm = 6 Then
                        ReDim p(5), v(5)
                        p = {"@mail", "@name", "@pwd", "@role"}
                        v = {emMail.Text, Emname.Text, EmPwd.Text, EmRole.Text}
                        d.editdata("insert into user_master values(@mail,@name,@pwd,@role)", p, v)
                    Else
                        MessageBox.Show("Insertion cancelled")
                    End If
                Else
                    Dim confirm = MessageBox.Show("Update Employee record?", "Update confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If confirm = 6 Then
                        ReDim p(3), v(3)
                        p = {"@nme", "@pwd", "@role", "@mail"}
                        v = {Emname.Text, EmPwd.Text, EmRole.Text, emMail.Text}
                        d.editdata("update user_master set E_name = @nme,E_Pass_wrd = @pwd, E_role = @role where E_mailID = @mail", p, v)
                    Else
                        MessageBox.Show("Update cancelled")
                    End If
                End If
            Else
                MessageBox.Show("Admin password invalid")
                adm_pwd.Text = ""
                adm_pwd.Focus()
            End If
        End If
        clear()
        ldata()
    End Sub

    Private Function AdminCheck() As Boolean
        Dim d As New daoclass
        Dim v(2), p(2) As String
        Dim IsAdmin As Boolean = False
        Dim obj As SqlClient.SqlDataReader
        'Checks If User is admin
        p = {"@mail", "@pwd"}
        v = {Emp_mailID, adm_pwd.Text}
        obj = d.getdata("Select e_role from user_master where E_mailID=@mail and e_Pass_wrd=@pwd", p, v)
        While obj.Read
            If obj.Item(0) = "Admin" Then
                IsAdmin = True
            End If
        End While
        d.closeconn()
        Return IsAdmin
    End Function

    Private Function blankvalidate() As Boolean
        If adm_pwd.Text <> "" Then
            If emMail.Text <> "" Then
                If EmPwd.Text <> "" Then
                    If EmRole.Text <> "" Then
                        Return True
                    Else
                        MessageBox.Show("Please select Employee Role")
                        EmRole.Focus()
                    End If
                Else
                    MessageBox.Show("Please enter Employee password")
                    EmPwd.Focus()
                End If
            Else
                MessageBox.Show("Please enter Employee mail ID")
                emMail.Focus()
            End If
        Else
            MessageBox.Show("Please enter Admin Password")
            adm_pwd.Focus()
        End If
        Return False
    End Function

    Private Sub Me_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        End
    End Sub

End Class