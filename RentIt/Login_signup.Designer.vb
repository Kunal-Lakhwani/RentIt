<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login_signup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.usr_mail = New System.Windows.Forms.TextBox()
        Me.usr_pwd = New System.Windows.Forms.TextBox()
        Me.mail = New System.Windows.Forms.Label()
        Me.pwd = New System.Windows.Forms.Label()
        Me.title = New System.Windows.Forms.Label()
        Me.nme = New System.Windows.Forms.Label()
        Me.sh_nme = New System.Windows.Forms.TextBox()
        Me.sh_GST = New System.Windows.Forms.MaskedTextBox()
        Me.gst_no = New System.Windows.Forms.Label()
        Me.addr = New System.Windows.Forms.Label()
        Me.sh_addr = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.run_qry = New Guna.UI2.WinForms.Guna2Button()
        Me.toggler = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.sh_contact = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.usr_nme = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'usr_mail
        '
        Me.usr_mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.usr_mail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.usr_mail.Location = New System.Drawing.Point(124, 11)
        Me.usr_mail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.usr_mail.Name = "usr_mail"
        Me.usr_mail.Size = New System.Drawing.Size(202, 26)
        Me.usr_mail.TabIndex = 5
        '
        'usr_pwd
        '
        Me.usr_pwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.usr_pwd.Location = New System.Drawing.Point(124, 47)
        Me.usr_pwd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.usr_pwd.Name = "usr_pwd"
        Me.usr_pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.usr_pwd.Size = New System.Drawing.Size(203, 26)
        Me.usr_pwd.TabIndex = 6
        '
        'mail
        '
        Me.mail.AutoSize = True
        Me.mail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.mail.Location = New System.Drawing.Point(11, 14)
        Me.mail.Name = "mail"
        Me.mail.Size = New System.Drawing.Size(53, 20)
        Me.mail.TabIndex = 12
        Me.mail.Text = "E-Mail"
        '
        'pwd
        '
        Me.pwd.AutoSize = True
        Me.pwd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.pwd.Location = New System.Drawing.Point(11, 50)
        Me.pwd.Name = "pwd"
        Me.pwd.Size = New System.Drawing.Size(78, 20)
        Me.pwd.TabIndex = 15
        Me.pwd.Text = "Password"
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.title.Location = New System.Drawing.Point(216, 28)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(123, 36)
        Me.title.TabIndex = 16
        Me.title.Text = "Sign Up"
        Me.title.Visible = False
        '
        'nme
        '
        Me.nme.AutoSize = True
        Me.nme.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.nme.Location = New System.Drawing.Point(11, 12)
        Me.nme.Name = "nme"
        Me.nme.Size = New System.Drawing.Size(91, 20)
        Me.nme.TabIndex = 19
        Me.nme.Text = "Shop name"
        '
        'sh_nme
        '
        Me.sh_nme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sh_nme.Location = New System.Drawing.Point(124, 10)
        Me.sh_nme.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.sh_nme.Name = "sh_nme"
        Me.sh_nme.Size = New System.Drawing.Size(202, 26)
        Me.sh_nme.TabIndex = 0
        '
        'sh_GST
        '
        Me.sh_GST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sh_GST.Location = New System.Drawing.Point(124, 147)
        Me.sh_GST.Mask = "000000000000000"
        Me.sh_GST.Name = "sh_GST"
        Me.sh_GST.Size = New System.Drawing.Size(202, 26)
        Me.sh_GST.TabIndex = 2
        Me.sh_GST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gst_no
        '
        Me.gst_no.AutoSize = True
        Me.gst_no.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.gst_no.Location = New System.Drawing.Point(11, 150)
        Me.gst_no.Name = "gst_no"
        Me.gst_no.Size = New System.Drawing.Size(64, 20)
        Me.gst_no.TabIndex = 25
        Me.gst_no.Text = "GST no"
        '
        'addr
        '
        Me.addr.AutoSize = True
        Me.addr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.addr.Location = New System.Drawing.Point(11, 49)
        Me.addr.Name = "addr"
        Me.addr.Size = New System.Drawing.Size(68, 20)
        Me.addr.TabIndex = 24
        Me.addr.Text = "Address"
        '
        'sh_addr
        '
        Me.sh_addr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sh_addr.Location = New System.Drawing.Point(124, 46)
        Me.sh_addr.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.sh_addr.Multiline = True
        Me.sh_addr.Name = "sh_addr"
        Me.sh_addr.Size = New System.Drawing.Size(202, 88)
        Me.sh_addr.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.RentIt.My.Resources.Resources.logo1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(91, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(174, 61)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.run_qry)
        Me.Panel1.Controls.Add(Me.toggler)
        Me.Panel1.Controls.Add(Me.mail)
        Me.Panel1.Controls.Add(Me.usr_mail)
        Me.Panel1.Controls.Add(Me.usr_pwd)
        Me.Panel1.Controls.Add(Me.pwd)
        Me.Panel1.Location = New System.Drawing.Point(12, 349)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(352, 119)
        Me.Panel1.TabIndex = 27
        '
        'run_qry
        '
        Me.run_qry.BorderColor = System.Drawing.Color.Transparent
        Me.run_qry.BorderRadius = 20
        Me.run_qry.BorderThickness = 2
        Me.run_qry.CustomizableEdges.BottomRight = False
        Me.run_qry.CustomizableEdges.TopLeft = False
        Me.run_qry.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.run_qry.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.run_qry.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.run_qry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.run_qry.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.run_qry.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.run_qry.ForeColor = System.Drawing.Color.White
        Me.run_qry.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.run_qry.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.run_qry.HoverState.FillColor = System.Drawing.Color.White
        Me.run_qry.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.run_qry.Location = New System.Drawing.Point(235, 81)
        Me.run_qry.Name = "run_qry"
        Me.run_qry.Size = New System.Drawing.Size(114, 35)
        Me.run_qry.TabIndex = 7
        Me.run_qry.Text = "Sign Up"
        '
        'toggler
        '
        Me.toggler.BorderColor = System.Drawing.Color.Transparent
        Me.toggler.BorderRadius = 20
        Me.toggler.BorderThickness = 2
        Me.toggler.CustomizableEdges.BottomRight = False
        Me.toggler.CustomizableEdges.TopLeft = False
        Me.toggler.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.toggler.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.toggler.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.toggler.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.toggler.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toggler.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toggler.ForeColor = System.Drawing.Color.White
        Me.toggler.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toggler.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toggler.HoverState.FillColor = System.Drawing.Color.White
        Me.toggler.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toggler.Location = New System.Drawing.Point(79, 81)
        Me.toggler.Name = "toggler"
        Me.toggler.Size = New System.Drawing.Size(151, 35)
        Me.toggler.TabIndex = 6
        Me.toggler.Text = "Login instead"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.sh_contact)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.usr_nme)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.nme)
        Me.Panel2.Controls.Add(Me.sh_GST)
        Me.Panel2.Controls.Add(Me.sh_nme)
        Me.Panel2.Controls.Add(Me.gst_no)
        Me.Panel2.Controls.Add(Me.sh_addr)
        Me.Panel2.Controls.Add(Me.addr)
        Me.Panel2.Location = New System.Drawing.Point(12, 79)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(352, 264)
        Me.Panel2.TabIndex = 28
        '
        'sh_contact
        '
        Me.sh_contact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sh_contact.Location = New System.Drawing.Point(125, 186)
        Me.sh_contact.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.sh_contact.MaxLength = 10
        Me.sh_contact.Name = "sh_contact"
        Me.sh_contact.Size = New System.Drawing.Size(202, 26)
        Me.sh_contact.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(11, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Shop Contact"
        '
        'usr_nme
        '
        Me.usr_nme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.usr_nme.Location = New System.Drawing.Point(125, 226)
        Me.usr_nme.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.usr_nme.Name = "usr_nme"
        Me.usr_nme.Size = New System.Drawing.Size(202, 26)
        Me.usr_nme.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 228)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "User name"
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'Login_signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(377, 475)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Login_signup"
        Me.Opacity = 0R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents usr_mail As TextBox
    Friend WithEvents usr_pwd As TextBox
    Friend WithEvents mail As Label
    Friend WithEvents pwd As Label
    Friend WithEvents title As Label
    Friend WithEvents nme As Label
    Friend WithEvents sh_nme As TextBox
    Friend WithEvents sh_GST As MaskedTextBox
    Friend WithEvents gst_no As Label
    Friend WithEvents addr As Label
    Friend WithEvents sh_addr As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents toggler As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents run_qry As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents usr_nme As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents sh_contact As TextBox
    Friend WithEvents Label2 As Label
End Class
