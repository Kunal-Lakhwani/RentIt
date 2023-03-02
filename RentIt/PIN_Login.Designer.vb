<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PIN_Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PIN_Login))
        Me.run_qry = New Guna.UI2.WinForms.Guna2Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PINdefault = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Pin_Code = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.run_qry.Location = New System.Drawing.Point(117, 156)
        Me.run_qry.Name = "run_qry"
        Me.run_qry.Size = New System.Drawing.Size(114, 35)
        Me.run_qry.TabIndex = 93
        Me.run_qry.Text = "Login"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(7, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 25)
        Me.Label7.TabIndex = 122
        Me.Label7.Text = "PIN"
        '
        'PINdefault
        '
        Me.PINdefault.AutoSize = True
        Me.PINdefault.Location = New System.Drawing.Point(60, 123)
        Me.PINdefault.Name = "PINdefault"
        Me.PINdefault.Size = New System.Drawing.Size(167, 24)
        Me.PINdefault.TabIndex = 123
        Me.PINdefault.Text = "Set as default page"
        Me.PINdefault.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.RentIt.My.Resources.Resources.logo11
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(39, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(174, 61)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'Pin_Code
        '
        Me.Pin_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pin_Code.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Pin_Code.Location = New System.Drawing.Point(60, 83)
        Me.Pin_Code.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Pin_Code.MaxLength = 6
        Me.Pin_Code.Name = "Pin_Code"
        Me.Pin_Code.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.Pin_Code.Size = New System.Drawing.Size(159, 32)
        Me.Pin_Code.TabIndex = 133
        '
        'PIN_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(243, 194)
        Me.ControlBox = False
        Me.Controls.Add(Me.Pin_Code)
        Me.Controls.Add(Me.PINdefault)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.run_qry)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "PIN_Login"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents run_qry As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label7 As Label
    Friend WithEvents PINdefault As CheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Pin_Code As TextBox
End Class
