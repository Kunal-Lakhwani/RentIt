Public Class PIN_Login

    Private Sub PIN_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PINdefault.Checked = My.Settings.PIN_as_default
        BringToFront()
    End Sub

    Private Sub run_qry_Click(sender As Object, e As EventArgs) Handles run_qry.Click
        Dim check As Integer = Val(PIN_code.Text)
        Dim decr As String = decrypt(My.Settings.User_pin)
        If decr = check Then
            Dim p(2), v(2) As String
            Dim d As New daoclass
            Dim obj As SqlClient.SqlDataReader
            'Checks If User is available
            p = {"@mail", "@pwd"}
            v = {decrypt(My.Settings.Usr_mail), decrypt(My.Settings.Usr_pwd)}
            obj = d.getdata("Select * from user_master where E_mailID=@mail and e_Pass_wrd=@pwd", p, v)
            While obj.Read
                Emp_mailID = obj.Item(0)  'Saves employee mail ID in DataShareAndMore data member
                Emp_nme = obj.Item(1)     'Saves employee Name in DataShareAndMore data member
                User_type = obj.Item(3)   'Saves the role of user in DataShareAndMore data member
            End While
            d.closeconn()
            If User_type <> "" Then
                'If e-mail and password are correct
                MessageBox.Show("Welcome " & User_type & vbCrLf & "Enjoy our services")
                d.closeconn()
                d.createlog("Logged in using pin")
                dash.Show()
                Me.Hide()
            Else
                MessageBox.Show("Unable to find saved user." & vbCrLf & "User has either been deleted or cannot connect to databse")
            End If
        Else
            PIN_code.Text = Nothing
            PIN_code.Focus()
            PIN_code.BackColor = Color.Coral
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub run_qry_GotFocus(sender As Object, e As EventArgs) Handles run_qry.GotFocus
        btngotfocus(sender)
    End Sub

    Private Sub run_qry_LostFocus(sender As Object, e As EventArgs) Handles run_qry.LostFocus
        btnlostfocus(sender)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PIN_code.BackColor = Color.White
        Timer1.Enabled = False
    End Sub

    Private Sub PINdefault_CheckedChanged(sender As Object, e As EventArgs) Handles PINdefault.CheckedChanged
        My.Settings.PIN_as_default = PINdefault.Checked
        My.Settings.Save()
    End Sub
End Class