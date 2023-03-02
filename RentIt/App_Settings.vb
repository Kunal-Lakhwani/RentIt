Public Class App_Settings

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
                    If User_type = "Admin" Then
                        sh_nme.Focus()
                    Else
                        Old_Pwd.Focus()
                    End If
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

    Private Sub Sveshop_Click(sender As Object, e As EventArgs) Handles Sveshop.Click
        Dim d As New daoclass
        Dim utype As String = ""
        Dim re As SqlClient.SqlDataReader
        re = d.getdata("Select E_role from user_master where E_mailID = '" & Admail.Text & "' and E_Pass_wrd = '" & Adpwd.Text & "'")
        While re.Read
            utype = re.Item(0)
        End While
        d.closeconn()
        If utype = "Admin" Then
            Dim p(4), v(4) As String
            p = {"@name", "@addr", "@cont", "@gst"}
            v = {sh_nme.Text, sh_addr.Text, sh_cont.Text, sh_GST.Text}
            d.editdata(
                "Update shop_master set shop_name = @name, 
                shop_address = @addr, shop_contact = @cont,Shop_gst_no = @gst",
                p, v)
            d.createlog("Updated shop details")
            settings_Load(sender, e)
        Else
            MessageBox.Show("Invalid Admin Credentials")
        End If
    End Sub

    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mail_lbl.Text = Emp_mailID

        'If There is no saved PIN
        If My.Settings.User_pin = "" Then
            Pin_Code_Old.Enabled = False
            'If There is a saved PIN
        Else
            Delacc.Visible = True
        End If
        'If User is Admin, Enable the Shop Detail Controls
        If User_type = "Admin" Then
            shset.Enabled = True
        End If
        'Load Shop Details
        Dim d As New daoclass
        Dim re As SqlClient.SqlDataReader
        re = d.getdata("Select * from shop_master")
        While re.Read
            sh_cont.Text = re.Item(0)
            sh_nme.Text = re.Item(0)
            sh_addr.Text = re.Item(1)
            sh_cont.Text = re.Item(2)
            sh_GST.Text = re.Item(3)
        End While
        d.closeconn()
    End Sub

    Private Sub settings_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        End
    End Sub

    Private Sub Sve_acc_Click(sender As Object, e As EventArgs) Handles Sve_acc.Click
        If Delacc.Visible Then
            'If Delacc is visible, it means that there is a User PIN saved
            If Pin_Code_Old.Text.Length = 6 AndAlso Pin_Code_New.Text.Length = 6 Then
                If Pin_Code_New.Text.Equals(Pin_Code_Old.Text) Then
                    If Val(Pin_Code_Old.Text) = decrypt(My.Settings.User_pin) Then
                        My.Settings.User_pin = encrypt(Pin_Code_New.Text)
                        My.Settings.Save()
                        MessageBox.Show("New PIN set")
                    Else
                        MessageBox.Show("Incorrect old PIN")
                        Pin_Code_Old.Focus()
                    End If
                End If
            Else
                MessageBox.Show("Please enter a full 6 digit PIN password")
                Pin_Code_Old.Focus()
            End If
        Else
            'No User PIN is saved
            Dim p(2), v(2) As String
            Dim d As New daoclass
            Dim e_mail As String = ""
            Dim obj As SqlClient.SqlDataReader
            'Checks If User is available
            p = {"@mail", "@pwd"}
            v = {mail_lbl.Text, Old_Pwd.Text}
            obj = d.getdata("Select E_mailID from user_master where E_mailID=@mail and e_Pass_wrd=@pwd", p, v)
            While obj.Read
                e_mail = obj.Item(0)
            End While
            d.closeconn()
            If e_mail <> "" Then
                'If Login credentials are valid then
                If Pin_Code_New.Text.Length = 6 Then
                    My.Settings.User_pin = encrypt(Pin_Code_New.Text)
                    My.Settings.Usr_mail = encrypt(mail_lbl.Text)
                    My.Settings.Usr_pwd = encrypt(Old_Pwd.Text)
                    My.Settings.Save()
                    MessageBox.Show("PIN for current user created")
                Else
                    MessageBox.Show("Please enter a full 6 digit PIN password")
                End If
            Else
                MessageBox.Show("Incorrect Password")
                Old_Pwd.Focus()
            End If
        End If
    End Sub

    Private Sub Delacc_Click(sender As Object, e As EventArgs) Handles Delacc.Click
        Dim confirm As Integer = MessageBox.Show(
                    "Delete User PIN?",
                    "Deletion confirmation", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)
        If confirm = 6 Then
            My.Settings.Reset()
            MessageBox.Show("PIN removed")
        End If
    End Sub

    Private Sub goToEmpManager_Click(sender As Object, e As EventArgs) Handles goToEmpManager.Click
        EmManager.Show()
        Me.Hide()
    End Sub

    Private Sub goToLogs_Click(sender As Object, e As EventArgs) Handles goToLogs.Click
        LogsViewer.Show()
        Me.Hide()
    End Sub

    Private Sub Change_Pwd_Click(sender As Object, e As EventArgs) Handles Change_Pwd.Click
        Dim d As New daoclass
        Dim areValidCreds As Boolean = False
        Dim re As SqlClient.SqlDataReader =
                d.getdata(
                qry:="Select * from user_master where E_mailID = @mail And E_pass_wrd = @pwd",
                p:={"@mail", "@pwd"},
                v:={mail_lbl.Text, Old_Pwd.Text})
        While re.Read
            areValidCreds = True
        End While
        If areValidCreds Then
            d.editdata(
                qry:="Update user_master set E_Pass_wrd = @newPwd 
                      where E_mailID = @mail And E_pass_wrd = @oldPwd",
                p:={"@newPwd", "@mail", "@oldPwd"},
                v:={New_pwd.Text, mail_lbl.Text, Old_Pwd.Text}
            )
            MessageBox.Show("Password Changed")
        Else
            MessageBox.Show("Invalid Password")
        End If
    End Sub
End Class