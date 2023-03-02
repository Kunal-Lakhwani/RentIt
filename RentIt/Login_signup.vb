Public Class Login_signup
    Private signinHeight As Integer = 475
    Private loginHeight As Integer = 210
    Private confirm As Boolean = False
    Private invalfield As New Object

    Private Sub Run_Click(sender As Object, e As EventArgs) Handles run_qry.Click
        If run_qry.Text = "Login" Then
            If usr_mail.Text <> "" Then
                If usr_pwd.Text <> "" Then
                    Dim p(2), v(2) As String
                    Dim d As New daoclass
                    Dim obj As SqlClient.SqlDataReader
                    'Checks If User is available
                    p = {"@mail", "@pwd"}
                    v = {usr_mail.Text, usr_pwd.Text}
                    obj = d.getdata("Select e_role,E_mailID,E_name from user_master where E_mailID=@mail and e_Pass_wrd=@pwd", p, v)
                    While obj.Read
                        'Initialize module data members
                        User_type = obj.Item(0)   'Stores the role of user
                        Emp_mailID = obj.Item(1)  'Stores mail ID of user
                        Emp_nme = obj.Item(2)     'Stores Name of user
                    End While
                    d.closeconn()
                    If User_type <> "" Then
                        'If e-mail and password are correct
                        MessageBox.Show("Welcome " + User_type + vbCrLf + "Enjoy our services")
                        d.closeconn()
                        d.createlog("Logged in")
                        dash.Show()
                        Hide()
                    Else
                        'If e-mail and/or password are in-correct
                        ReDim Preserve p(1), v(1)
                        obj = d.getdata("Select e_role from user_master where E_mailID=@mail", p, v)
                        'Checks if atleast user exists in user_master
                        While obj.Read
                            User_type = obj.Item(0)
                        End While
                        d.closeconn()
                        If User_type <> "" Then
                            'If user exists
                            MessageBox.Show("Enter correct password")
                            usr_pwd.Text = ""
                            usr_pwd.Focus()
                        Else
                            'If user does not exist
                            MessageBox.Show("User does not exist")
                            usr_pwd.Text = ""
                            usr_mail.Text = ""
                            usr_mail.Focus()
                        End If
                    End If
                Else
                    usr_pwd.BackColor = Color.Coral
                    invalfield = usr_pwd
                    Timer1.Enabled = True
                End If
            Else
                usr_mail.BackColor = Color.Coral
                invalfield = usr_mail
                Timer1.Enabled = True
            End If
        Else
            'Sign Up code
            If sh_nme.Text <> "" Then
                If sh_addr.Text <> "" Then
                    If sh_GST.MaskCompleted Then
                        If usr_nme.Text <> "" Then
                            If usr_mail.Text <> "" Then
                                If usr_pwd.Text <> "" Then
                                    Dim check_and_ID As String = ""
                                    Dim d As New daoclass
                                    Dim obj As SqlClient.SqlDataReader
                                    obj = d.getdata("Select * from user_master where E_mailID=@mail", {"@mail"}, {usr_mail.Text})
                                    'Checks if the email inputted already exists or not
                                    While obj.Read
                                        check_and_ID = obj.Item(0)
                                    End While
                                    d.closeconn()
                                    If check_and_ID <> "" Then
                                        'If E-mail exists
                                        MessageBox.Show("Given E-mail has already been registered")
                                    Else
                                        'If E-mail does not exist

                                        'Store Shop details in Shop_Master table
                                        Dim qry As String =
                                            "Insert into Shop_Master values(@contact,@nme,@GSTNo,@Addr)"

                                        '<br> is placeholder term.
                                        'It will be replaced in Reports with ChrW(13) which represents
                                        'Newline character
                                        Dim Address = sh_addr.Text.Replace(vbCrLf, "<br>")
                                        d.editdata(
                                            qry:=qry,
                                            p:={"@contact", "@nme", "@GSTNo", "@Addr"},
                                            v:={sh_contact.Text, sh_nme.Text, sh_GST.Text, Address}
                                        )

                                        Dim p(4), v(4) As String
                                        p = {"@mail", "@nme", "@pwd", "@eRole"}
                                        v = {usr_mail.Text, usr_nme.Text, usr_pwd.Text, "Admin"}
                                        'Inserts details for admin in user master
                                        d.editdata("Insert into user_master values(@mail,@nme,@pwd,@eRole)", p, v)
                                        MessageBox.Show("Account created... Moving to Log-In Screen")
                                        toggle(signup:=False)
                                        clear()
                                        usr_mail.Text = v(1)
                                        usr_pwd.Focus()
                                    End If
                                Else
                                    usr_pwd.BackColor = Color.Coral
                                    invalfield = usr_pwd
                                    Timer1.Enabled = True
                                End If
                            Else
                                usr_mail.BackColor = Color.Coral
                                invalfield = usr_mail
                                Timer1.Enabled = True
                            End If
                        Else
                            usr_nme.BackColor = Color.Coral
                            invalfield = usr_nme
                            Timer1.Enabled = True
                        End If
                    Else
                        sh_GST.BackColor = Color.Coral
                        invalfield = sh_GST
                        Timer1.Enabled = True
                    End If
                Else
                    sh_addr.BackColor = Color.Coral
                    invalfield = sh_addr
                    Timer1.Enabled = True
                End If
            Else
                sh_nme.BackColor = Color.Coral
                invalfield = sh_nme
                Timer1.Enabled = True
            End If
        End If
    End Sub

    Private Sub clear()
        sh_addr.Text = ""
        sh_GST.Text = ""
        usr_mail.Text = ""
        sh_nme.Text = ""
        usr_pwd.Text = ""
    End Sub

    Private Sub toggle(ByVal signup As Boolean)
        'Sign Up is true when form is in Sign up mode.
        Panel2.Visible = signup
        If signup Then
            Me.Height = signinHeight
            title.Text = "Sign Up"
            run_qry.Text = "Sign Up"
            toggler.Text = "&Log In instead"
            'controlname.location = new point(X_value, Y_value)
            'This changes the location of the control to the specified (x,y) point
            Panel1.Location = New Point(Panel1.Location.X, Panel1.Location.Y + 265)
            sh_nme.Focus()
        Else
            Me.Height = loginHeight
            title.Text = "Login"
            run_qry.Text = "Login"
            toggler.Text = "&Sign In instead"
            'controlname.location = new point(X_value, Y_value)
            'This changes the location of the control to the specified (x,y) point
            Panel1.Location = New Point(Panel1.Location.X, Panel1.Location.Y - 265)
            usr_mail.Focus()
        End If
    End Sub

    Private Sub page_toggle_Click(sender As Object, e As EventArgs) Handles toggler.Click
        clear()
        toggle(IIf(title.Text = "Sign Up", False, True))
        'Calls toggle(false) if user pressed 'login instead'
        'Calls toggle(true) if user pressed 'sign in instead'
    End Sub

    Private Sub txt_validation(sender As Object, e As KeyPressEventArgs) Handles sh_nme.KeyPress
        Dim d As New daoclass
        e.Handled = d.charvalidate(e.KeyChar, e.KeyChar.GetHashCode)
    End Sub

    Private Sub address_validation(sender As Object, e As KeyPressEventArgs) Handles sh_addr.KeyPress
        Dim d As New daoclass
        e.Handled = d.addressvalidate(e.KeyChar, e.KeyChar.GetHashCode)
    End Sub

    Private Sub mail_validation(sender As Object, e As KeyPressEventArgs) Handles usr_mail.KeyPress
        Dim d As New daoclass
        e.Handled = d.mailvalidate(e.KeyChar, e.KeyChar.GetHashCode)
    End Sub

    Private Sub password_validation(sender As Object, e As KeyPressEventArgs) Handles usr_pwd.KeyPress
        Dim d As New daoclass
        e.Handled = d.pwdvalidate(e.KeyChar, e.KeyChar.GetHashCode)
    End Sub

    Private Sub Login_signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Check if Shop data is loaded on Application startup.
        'If it is, admin user has been created already.
        'Only allow Login funcitonality in this case
        If ShopName <> "" Then
            toggle(signup:=False)
            toggler.Visible = False
        End If
    End Sub

    Private Sub run_qry_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar.GetHashCode = 851981 Then
            Run_Click(sender, e)
        End If
    End Sub

    Private Sub buttonFocus(sender As Object, e As EventArgs) Handles run_qry.GotFocus, toggler.GotFocus
        btngotfocus(sender)
    End Sub

    Private Sub buttonLostFocus(sender As Object, e As EventArgs) Handles run_qry.LostFocus, toggler.LostFocus
        btnlostfocus(sender)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        invalfield.Backcolor = Color.White
        invalfield.Focus()
        Timer1.Enabled = False
        invalfield = Nothing
    End Sub

    Private Sub Login_signup_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter AndAlso Not ActiveControl().Equals(sh_addr) Then
            e.SuppressKeyPress = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub Login_signup_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Check if User has saved PIN
        If My.Settings.User_pin <> 0 Then
            'Ask user if they want to login using PIN
            Dim choice As Integer =
                MessageBox.Show(
                    text:="A PIN for User " & My.Settings.Usr_mail & "has been detected," &
                            vbCrLf & " Login using PIN instead?",
                    caption:="Notice",
                    buttons:=MessageBoxButtons.YesNo,
                    icon:=MessageBoxIcon.Question)
            If choice = 6 Then
                Dim login As New PIN_Login
                login.Show()
                Hide()
                Exit Sub
            End If
        End If
        Me.Opacity = 100%
    End Sub
End Class