<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Logs_master
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Logs_master))
        Me.reportPanel = New System.Windows.Forms.Panel()
        Me.ReportPanel2 = New System.Windows.Forms.Panel()
        Me.L_Dte_to = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.L_Dte_frm = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.L_sort = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.L_act = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.L_emp = New System.Windows.Forms.ComboBox()
        Me.GenReport = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LogList = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.lid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Emp_mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lrole = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Laction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Logdon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Logat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NavPanel = New System.Windows.Forms.Panel()
        Me.toPurchaseHistory = New Guna.UI2.WinForms.Guna2Button()
        Me.toSettings = New Guna.UI2.WinForms.Guna2Button()
        Me.toBillHistory = New Guna.UI2.WinForms.Guna2Button()
        Me.toDashBoard = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.toGenerateReport = New Guna.UI2.WinForms.Guna2Button()
        Me.toStockPurchase = New Guna.UI2.WinForms.Guna2Button()
        Me.toItemReturn = New Guna.UI2.WinForms.Guna2Button()
        Me.toBillMaker = New Guna.UI2.WinForms.Guna2Button()
        Me.toStockManager = New Guna.UI2.WinForms.Guna2Button()
        Me.reportPanel.SuspendLayout()
        Me.ReportPanel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.LogList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'reportPanel
        '
        Me.reportPanel.Controls.Add(Me.ReportPanel2)
        Me.reportPanel.Controls.Add(Me.L_sort)
        Me.reportPanel.Controls.Add(Me.Label5)
        Me.reportPanel.Controls.Add(Me.L_act)
        Me.reportPanel.Controls.Add(Me.Label6)
        Me.reportPanel.Controls.Add(Me.Label7)
        Me.reportPanel.Controls.Add(Me.L_emp)
        Me.reportPanel.Controls.Add(Me.GenReport)
        Me.reportPanel.Location = New System.Drawing.Point(257, 0)
        Me.reportPanel.Name = "reportPanel"
        Me.reportPanel.Size = New System.Drawing.Size(943, 102)
        Me.reportPanel.TabIndex = 121
        '
        'ReportPanel2
        '
        Me.ReportPanel2.Controls.Add(Me.L_Dte_to)
        Me.ReportPanel2.Controls.Add(Me.Label8)
        Me.ReportPanel2.Controls.Add(Me.L_Dte_frm)
        Me.ReportPanel2.Controls.Add(Me.Label10)
        Me.ReportPanel2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ReportPanel2.Location = New System.Drawing.Point(11, 13)
        Me.ReportPanel2.Name = "ReportPanel2"
        Me.ReportPanel2.Size = New System.Drawing.Size(370, 69)
        Me.ReportPanel2.TabIndex = 134
        '
        'L_Dte_to
        '
        Me.L_Dte_to.CustomFormat = "dd MMMM yyyy"
        Me.L_Dte_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.L_Dte_to.Location = New System.Drawing.Point(130, 37)
        Me.L_Dte_to.Name = "L_Dte_to"
        Me.L_Dte_to.Size = New System.Drawing.Size(226, 25)
        Me.L_Dte_to.TabIndex = 122
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(8, 8)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 19)
        Me.Label8.TabIndex = 121
        Me.Label8.Text = "Logged Between:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'L_Dte_frm
        '
        Me.L_Dte_frm.CustomFormat = "dd MMMM yyyy"
        Me.L_Dte_frm.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.L_Dte_frm.Location = New System.Drawing.Point(130, 6)
        Me.L_Dte_frm.Name = "L_Dte_frm"
        Me.L_Dte_frm.Size = New System.Drawing.Size(226, 25)
        Me.L_Dte_frm.TabIndex = 118
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(8, 40)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 19)
        Me.Label10.TabIndex = 115
        Me.Label10.Text = "And:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'L_sort
        '
        Me.L_sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.L_sort.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.L_sort.FormattingEnabled = True
        Me.L_sort.Items.AddRange(New Object() {"Date", "Employee", "Customer"})
        Me.L_sort.Location = New System.Drawing.Point(495, 70)
        Me.L_sort.Name = "L_sort"
        Me.L_sort.Size = New System.Drawing.Size(208, 25)
        Me.L_sort.TabIndex = 133
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(388, 73)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 19)
        Me.Label5.TabIndex = 131
        Me.Label5.Text = "Order by:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'L_act
        '
        Me.L_act.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.L_act.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.L_act.FormattingEnabled = True
        Me.L_act.Location = New System.Drawing.Point(495, 38)
        Me.L_act.Name = "L_act"
        Me.L_act.Size = New System.Drawing.Size(208, 25)
        Me.L_act.TabIndex = 132
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(388, 41)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 19)
        Me.Label6.TabIndex = 130
        Me.Label6.Text = "Action:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(388, 10)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 19)
        Me.Label7.TabIndex = 128
        Me.Label7.Text = "Of Employee:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'L_emp
        '
        Me.L_emp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.L_emp.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.L_emp.FormattingEnabled = True
        Me.L_emp.Location = New System.Drawing.Point(495, 7)
        Me.L_emp.Name = "L_emp"
        Me.L_emp.Size = New System.Drawing.Size(208, 25)
        Me.L_emp.TabIndex = 129
        '
        'GenReport
        '
        Me.GenReport.BorderColor = System.Drawing.Color.Transparent
        Me.GenReport.BorderRadius = 20
        Me.GenReport.BorderThickness = 2
        Me.GenReport.CustomizableEdges.BottomRight = False
        Me.GenReport.CustomizableEdges.TopLeft = False
        Me.GenReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GenReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GenReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GenReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GenReport.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GenReport.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.GenReport.ForeColor = System.Drawing.Color.White
        Me.GenReport.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GenReport.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GenReport.HoverState.FillColor = System.Drawing.Color.White
        Me.GenReport.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GenReport.Location = New System.Drawing.Point(793, 30)
        Me.GenReport.Name = "GenReport"
        Me.GenReport.Size = New System.Drawing.Size(149, 45)
        Me.GenReport.TabIndex = 117
        Me.GenReport.TabStop = False
        Me.GenReport.Text = "Show logs"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.LogList)
        Me.Panel3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Location = New System.Drawing.Point(257, 107)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(943, 585)
        Me.Panel3.TabIndex = 125
        '
        'LogList
        '
        Me.LogList.AllowUserToAddRows = False
        Me.LogList.AllowUserToDeleteRows = False
        Me.LogList.AllowUserToResizeColumns = False
        Me.LogList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.LogList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LogList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.LogList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.lid, Me.sid, Me.Emp_mail, Me.lrole, Me.Laction, Me.Logdon, Me.Logat})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LogList.DefaultCellStyle = DataGridViewCellStyle3
        Me.LogList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogList.GridColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.LogList.Location = New System.Drawing.Point(0, 0)
        Me.LogList.MultiSelect = False
        Me.LogList.Name = "LogList"
        Me.LogList.ReadOnly = True
        Me.LogList.RowHeadersVisible = False
        Me.LogList.RowTemplate.ReadOnly = True
        Me.LogList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LogList.Size = New System.Drawing.Size(941, 583)
        Me.LogList.TabIndex = 47
        Me.LogList.TabStop = False
        Me.LogList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin
        Me.LogList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.LogList.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.LogList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.LogList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.LogList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.LogList.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.LogList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.LogList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.LogList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.LogList.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.LogList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.LogList.ThemeStyle.HeaderStyle.Height = 23
        Me.LogList.ThemeStyle.ReadOnly = True
        Me.LogList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.LogList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.LogList.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LogList.ThemeStyle.RowsStyle.Height = 22
        Me.LogList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.LogList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'lid
        '
        Me.lid.DataPropertyName = "Log_id"
        Me.lid.HeaderText = "LogID"
        Me.lid.Name = "lid"
        Me.lid.ReadOnly = True
        Me.lid.Visible = False
        '
        'sid
        '
        Me.sid.DataPropertyName = "Log_sID"
        Me.sid.HeaderText = "Shopid"
        Me.sid.Name = "sid"
        Me.sid.ReadOnly = True
        Me.sid.Visible = False
        '
        'Emp_mail
        '
        Me.Emp_mail.DataPropertyName = "Log_Emp"
        Me.Emp_mail.FillWeight = 200.0!
        Me.Emp_mail.HeaderText = "Email-id of Empoyee"
        Me.Emp_mail.Name = "Emp_mail"
        Me.Emp_mail.ReadOnly = True
        '
        'lrole
        '
        Me.lrole.DataPropertyName = "Log_Role"
        Me.lrole.FillWeight = 75.0!
        Me.lrole.HeaderText = "Role Of Employee"
        Me.lrole.Name = "lrole"
        Me.lrole.ReadOnly = True
        '
        'Laction
        '
        Me.Laction.DataPropertyName = "Log_action"
        Me.Laction.FillWeight = 200.0!
        Me.Laction.HeaderText = "Log Action"
        Me.Laction.Name = "Laction"
        Me.Laction.ReadOnly = True
        '
        'Logdon
        '
        Me.Logdon.DataPropertyName = "Log_date"
        Me.Logdon.FillWeight = 50.0!
        Me.Logdon.HeaderText = "Log Date"
        Me.Logdon.Name = "Logdon"
        Me.Logdon.ReadOnly = True
        '
        'Logat
        '
        Me.Logat.DataPropertyName = "Log_time"
        Me.Logat.FillWeight = 50.0!
        Me.Logat.HeaderText = "Log Time"
        Me.Logat.Name = "Logat"
        Me.Logat.ReadOnly = True
        '
        'NavPanel
        '
        Me.NavPanel.Controls.Add(Me.toPurchaseHistory)
        Me.NavPanel.Controls.Add(Me.toSettings)
        Me.NavPanel.Controls.Add(Me.toBillHistory)
        Me.NavPanel.Controls.Add(Me.toDashBoard)
        Me.NavPanel.Controls.Add(Me.PictureBox1)
        Me.NavPanel.Controls.Add(Me.toGenerateReport)
        Me.NavPanel.Controls.Add(Me.toStockPurchase)
        Me.NavPanel.Controls.Add(Me.toItemReturn)
        Me.NavPanel.Controls.Add(Me.toBillMaker)
        Me.NavPanel.Controls.Add(Me.toStockManager)
        Me.NavPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.NavPanel.Location = New System.Drawing.Point(0, 0)
        Me.NavPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NavPanel.Name = "NavPanel"
        Me.NavPanel.Size = New System.Drawing.Size(260, 692)
        Me.NavPanel.TabIndex = 126
        '
        'toPurchaseHistory
        '
        Me.toPurchaseHistory.BackColor = System.Drawing.Color.Transparent
        Me.toPurchaseHistory.BorderColor = System.Drawing.Color.Transparent
        Me.toPurchaseHistory.BorderRadius = 20
        Me.toPurchaseHistory.BorderThickness = 2
        Me.toPurchaseHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.toPurchaseHistory.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toPurchaseHistory.CustomBorderThickness = New System.Windows.Forms.Padding(2)
        Me.toPurchaseHistory.CustomizableEdges.BottomRight = False
        Me.toPurchaseHistory.CustomizableEdges.TopLeft = False
        Me.toPurchaseHistory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toPurchaseHistory.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.toPurchaseHistory.DisabledState.FillColor = System.Drawing.Color.White
        Me.toPurchaseHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toPurchaseHistory.FillColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toPurchaseHistory.FocusedColor = System.Drawing.Color.Transparent
        Me.toPurchaseHistory.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.toPurchaseHistory.ForeColor = System.Drawing.Color.White
        Me.toPurchaseHistory.Location = New System.Drawing.Point(40, 484)
        Me.toPurchaseHistory.Name = "toPurchaseHistory"
        Me.toPurchaseHistory.Size = New System.Drawing.Size(180, 50)
        Me.toPurchaseHistory.TabIndex = 7
        Me.toPurchaseHistory.TabStop = False
        Me.toPurchaseHistory.Text = "Purchase History"
        '
        'toSettings
        '
        Me.toSettings.BackColor = System.Drawing.Color.Transparent
        Me.toSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.toSettings.BorderColor = System.Drawing.Color.Transparent
        Me.toSettings.BorderRadius = 24
        Me.toSettings.BorderThickness = 2
        Me.toSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.toSettings.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toSettings.CustomBorderThickness = New System.Windows.Forms.Padding(2)
        Me.toSettings.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toSettings.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.toSettings.DisabledState.FillColor = System.Drawing.Color.White
        Me.toSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toSettings.FillColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toSettings.FocusedColor = System.Drawing.Color.Transparent
        Me.toSettings.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.toSettings.ForeColor = System.Drawing.Color.White
        Me.toSettings.Image = Global.RentIt.My.Resources.Resources.Manage
        Me.toSettings.ImageSize = New System.Drawing.Size(40, 40)
        Me.toSettings.Location = New System.Drawing.Point(197, 34)
        Me.toSettings.Name = "toSettings"
        Me.toSettings.Size = New System.Drawing.Size(50, 50)
        Me.toSettings.TabIndex = 0
        Me.toSettings.TabStop = False
        '
        'toBillHistory
        '
        Me.toBillHistory.BackColor = System.Drawing.Color.Transparent
        Me.toBillHistory.BorderColor = System.Drawing.Color.Transparent
        Me.toBillHistory.BorderRadius = 20
        Me.toBillHistory.BorderThickness = 2
        Me.toBillHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.toBillHistory.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toBillHistory.CustomBorderThickness = New System.Windows.Forms.Padding(2)
        Me.toBillHistory.CustomizableEdges.BottomRight = False
        Me.toBillHistory.CustomizableEdges.TopLeft = False
        Me.toBillHistory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toBillHistory.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.toBillHistory.DisabledState.FillColor = System.Drawing.Color.White
        Me.toBillHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toBillHistory.FillColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toBillHistory.FocusedColor = System.Drawing.Color.Transparent
        Me.toBillHistory.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.toBillHistory.ForeColor = System.Drawing.Color.White
        Me.toBillHistory.Location = New System.Drawing.Point(40, 311)
        Me.toBillHistory.Name = "toBillHistory"
        Me.toBillHistory.Size = New System.Drawing.Size(180, 50)
        Me.toBillHistory.TabIndex = 4
        Me.toBillHistory.TabStop = False
        Me.toBillHistory.Text = "Bill History"
        '
        'toDashBoard
        '
        Me.toDashBoard.BackColor = System.Drawing.Color.Transparent
        Me.toDashBoard.BorderColor = System.Drawing.Color.Transparent
        Me.toDashBoard.BorderRadius = 20
        Me.toDashBoard.BorderThickness = 2
        Me.toDashBoard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.toDashBoard.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toDashBoard.CustomBorderThickness = New System.Windows.Forms.Padding(2)
        Me.toDashBoard.CustomizableEdges.BottomRight = False
        Me.toDashBoard.CustomizableEdges.TopLeft = False
        Me.toDashBoard.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toDashBoard.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.toDashBoard.DisabledState.FillColor = System.Drawing.Color.White
        Me.toDashBoard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toDashBoard.FillColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toDashBoard.FocusedColor = System.Drawing.Color.Transparent
        Me.toDashBoard.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.toDashBoard.ForeColor = System.Drawing.Color.White
        Me.toDashBoard.Location = New System.Drawing.Point(40, 137)
        Me.toDashBoard.Name = "toDashBoard"
        Me.toDashBoard.Size = New System.Drawing.Size(180, 50)
        Me.toDashBoard.TabIndex = 1
        Me.toDashBoard.TabStop = False
        Me.toDashBoard.Text = "Dashboard"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = Global.RentIt.My.Resources.Resources.logo1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(18, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 72)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'toGenerateReport
        '
        Me.toGenerateReport.BorderColor = System.Drawing.Color.Transparent
        Me.toGenerateReport.BorderRadius = 20
        Me.toGenerateReport.BorderThickness = 2
        Me.toGenerateReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.toGenerateReport.CustomizableEdges.BottomRight = False
        Me.toGenerateReport.CustomizableEdges.TopLeft = False
        Me.toGenerateReport.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toGenerateReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.toGenerateReport.DisabledState.FillColor = System.Drawing.Color.White
        Me.toGenerateReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toGenerateReport.FillColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toGenerateReport.FocusedColor = System.Drawing.Color.Transparent
        Me.toGenerateReport.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.toGenerateReport.ForeColor = System.Drawing.Color.White
        Me.toGenerateReport.Location = New System.Drawing.Point(40, 542)
        Me.toGenerateReport.Name = "toGenerateReport"
        Me.toGenerateReport.Size = New System.Drawing.Size(180, 49)
        Me.toGenerateReport.TabIndex = 8
        Me.toGenerateReport.TabStop = False
        Me.toGenerateReport.Text = "Generate Reports"
        '
        'toStockPurchase
        '
        Me.toStockPurchase.BorderColor = System.Drawing.Color.Transparent
        Me.toStockPurchase.BorderRadius = 20
        Me.toStockPurchase.BorderThickness = 2
        Me.toStockPurchase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.toStockPurchase.CustomizableEdges.BottomRight = False
        Me.toStockPurchase.CustomizableEdges.TopLeft = False
        Me.toStockPurchase.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toStockPurchase.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.toStockPurchase.DisabledState.FillColor = System.Drawing.Color.White
        Me.toStockPurchase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toStockPurchase.FillColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toStockPurchase.FocusedColor = System.Drawing.Color.Transparent
        Me.toStockPurchase.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.toStockPurchase.ForeColor = System.Drawing.Color.White
        Me.toStockPurchase.Location = New System.Drawing.Point(40, 427)
        Me.toStockPurchase.Name = "toStockPurchase"
        Me.toStockPurchase.Size = New System.Drawing.Size(180, 49)
        Me.toStockPurchase.TabIndex = 6
        Me.toStockPurchase.TabStop = False
        Me.toStockPurchase.Text = "Purchase entry"
        '
        'toItemReturn
        '
        Me.toItemReturn.BorderColor = System.Drawing.Color.Transparent
        Me.toItemReturn.BorderRadius = 20
        Me.toItemReturn.BorderThickness = 2
        Me.toItemReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.toItemReturn.CustomizableEdges.BottomRight = False
        Me.toItemReturn.CustomizableEdges.TopLeft = False
        Me.toItemReturn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toItemReturn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.toItemReturn.DisabledState.FillColor = System.Drawing.Color.White
        Me.toItemReturn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toItemReturn.FillColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toItemReturn.FocusedColor = System.Drawing.Color.Transparent
        Me.toItemReturn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.toItemReturn.ForeColor = System.Drawing.Color.White
        Me.toItemReturn.Location = New System.Drawing.Point(40, 369)
        Me.toItemReturn.Name = "toItemReturn"
        Me.toItemReturn.Size = New System.Drawing.Size(180, 49)
        Me.toItemReturn.TabIndex = 5
        Me.toItemReturn.TabStop = False
        Me.toItemReturn.Text = "Item Return"
        '
        'toBillMaker
        '
        Me.toBillMaker.BorderColor = System.Drawing.Color.Transparent
        Me.toBillMaker.BorderRadius = 20
        Me.toBillMaker.BorderThickness = 2
        Me.toBillMaker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.toBillMaker.CustomizableEdges.BottomRight = False
        Me.toBillMaker.CustomizableEdges.TopLeft = False
        Me.toBillMaker.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toBillMaker.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.toBillMaker.DisabledState.FillColor = System.Drawing.Color.White
        Me.toBillMaker.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toBillMaker.FillColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toBillMaker.FocusedColor = System.Drawing.Color.Transparent
        Me.toBillMaker.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.toBillMaker.ForeColor = System.Drawing.Color.White
        Me.toBillMaker.Location = New System.Drawing.Point(40, 253)
        Me.toBillMaker.Name = "toBillMaker"
        Me.toBillMaker.Size = New System.Drawing.Size(180, 50)
        Me.toBillMaker.TabIndex = 3
        Me.toBillMaker.TabStop = False
        Me.toBillMaker.Text = "Bill Maker"
        '
        'toStockManager
        '
        Me.toStockManager.BorderColor = System.Drawing.Color.Transparent
        Me.toStockManager.BorderRadius = 20
        Me.toStockManager.BorderThickness = 2
        Me.toStockManager.Cursor = System.Windows.Forms.Cursors.Hand
        Me.toStockManager.CustomizableEdges.BottomRight = False
        Me.toStockManager.CustomizableEdges.TopLeft = False
        Me.toStockManager.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toStockManager.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.toStockManager.DisabledState.FillColor = System.Drawing.Color.White
        Me.toStockManager.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toStockManager.FillColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.toStockManager.FocusedColor = System.Drawing.Color.Transparent
        Me.toStockManager.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.toStockManager.ForeColor = System.Drawing.Color.White
        Me.toStockManager.Location = New System.Drawing.Point(40, 195)
        Me.toStockManager.Name = "toStockManager"
        Me.toStockManager.Size = New System.Drawing.Size(180, 50)
        Me.toStockManager.TabIndex = 2
        Me.toStockManager.TabStop = False
        Me.toStockManager.Text = "Stock Manager"
        '
        'Logs_master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.NavPanel)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.reportPanel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Logs_master"
        Me.ShowIcon = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.reportPanel.ResumeLayout(False)
        Me.reportPanel.PerformLayout()
        Me.ReportPanel2.ResumeLayout(False)
        Me.ReportPanel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.LogList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavPanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents reportPanel As Panel
    Friend WithEvents GenReport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LogList As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lid As DataGridViewTextBoxColumn
    Friend WithEvents sid As DataGridViewTextBoxColumn
    Friend WithEvents Emp_mail As DataGridViewTextBoxColumn
    Friend WithEvents lrole As DataGridViewTextBoxColumn
    Friend WithEvents Laction As DataGridViewTextBoxColumn
    Friend WithEvents Logdon As DataGridViewTextBoxColumn
    Friend WithEvents Logat As DataGridViewTextBoxColumn
    Friend WithEvents L_sort As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents L_act As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents L_emp As ComboBox
    Friend WithEvents ReportPanel2 As Panel
    Friend WithEvents L_Dte_to As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents L_Dte_frm As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents NavPanel As Panel
    Friend WithEvents toPurchaseHistory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents toSettings As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents toBillHistory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents toDashBoard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents toGenerateReport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents toStockPurchase As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents toItemReturn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents toBillMaker As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents toStockManager As Guna.UI2.WinForms.Guna2Button
End Class
