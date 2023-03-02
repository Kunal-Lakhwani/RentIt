<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StockManager
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.WorkSpace = New System.Windows.Forms.Panel()
        Me.Manage_Filter = New Guna.UI2.WinForms.Guna2TabControl()
        Me.ManagePage = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.itm_name_tb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.itm_rate_tb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.itm_type_combo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.QueryPanel = New System.Windows.Forms.Panel()
        Me.delBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.updateBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.itm_qty_tb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.itm_stk_tb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.itm_code_tb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.FilterPage = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.fltr_code_tb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.clrBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.filtrBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.fltr_rate_lt = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.fltr_rate_gt = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.fltr_name_tb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.fltr_rate_tb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.fltr_type_combo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GridViewPanel = New System.Windows.Forms.Panel()
        Me.itm_list_grid = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.itm_code_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itm_name_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itm_type_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itm_qty_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itm_stk_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itm_rate_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
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
        Me.WorkSpace.SuspendLayout()
        Me.Manage_Filter.SuspendLayout()
        Me.ManagePage.SuspendLayout()
        Me.QueryPanel.SuspendLayout()
        Me.FilterPage.SuspendLayout()
        Me.GridViewPanel.SuspendLayout()
        CType(Me.itm_list_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WorkSpace
        '
        Me.WorkSpace.Controls.Add(Me.Manage_Filter)
        Me.WorkSpace.Controls.Add(Me.GridViewPanel)
        Me.WorkSpace.Location = New System.Drawing.Point(260, 0)
        Me.WorkSpace.Name = "WorkSpace"
        Me.WorkSpace.Size = New System.Drawing.Size(654, 625)
        Me.WorkSpace.TabIndex = 4
        '
        'Manage_Filter
        '
        Me.Manage_Filter.Controls.Add(Me.ManagePage)
        Me.Manage_Filter.Controls.Add(Me.FilterPage)
        Me.Manage_Filter.ItemSize = New System.Drawing.Size(180, 40)
        Me.Manage_Filter.Location = New System.Drawing.Point(0, 0)
        Me.Manage_Filter.Name = "Manage_Filter"
        Me.Manage_Filter.SelectedIndex = 0
        Me.Manage_Filter.Size = New System.Drawing.Size(914, 329)
        Me.Manage_Filter.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.Manage_Filter.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Manage_Filter.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Manage_Filter.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.Manage_Filter.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Manage_Filter.TabButtonIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.Manage_Filter.TabButtonIdleState.FillColor = System.Drawing.Color.White
        Me.Manage_Filter.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Manage_Filter.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Manage_Filter.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Manage_Filter.TabButtonSelectedState.BorderColor = System.Drawing.Color.Transparent
        Me.Manage_Filter.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Manage_Filter.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Manage_Filter.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.Manage_Filter.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Manage_Filter.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.Manage_Filter.TabIndex = 98
        Me.Manage_Filter.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Manage_Filter.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'ManagePage
        '
        Me.ManagePage.Controls.Add(Me.Label1)
        Me.ManagePage.Controls.Add(Me.itm_name_tb)
        Me.ManagePage.Controls.Add(Me.Label3)
        Me.ManagePage.Controls.Add(Me.itm_rate_tb)
        Me.ManagePage.Controls.Add(Me.itm_type_combo)
        Me.ManagePage.Controls.Add(Me.QueryPanel)
        Me.ManagePage.Controls.Add(Me.Label5)
        Me.ManagePage.Controls.Add(Me.Label6)
        Me.ManagePage.Controls.Add(Me.Label2)
        Me.ManagePage.Controls.Add(Me.itm_qty_tb)
        Me.ManagePage.Controls.Add(Me.itm_stk_tb)
        Me.ManagePage.Controls.Add(Me.Label4)
        Me.ManagePage.Controls.Add(Me.itm_code_tb)
        Me.ManagePage.Location = New System.Drawing.Point(4, 44)
        Me.ManagePage.Name = "ManagePage"
        Me.ManagePage.Padding = New System.Windows.Forms.Padding(3)
        Me.ManagePage.Size = New System.Drawing.Size(906, 281)
        Me.ManagePage.TabIndex = 0
        Me.ManagePage.Text = "Manage Stock"
        Me.ManagePage.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item Code:"
        '
        'itm_name_tb
        '
        Me.itm_name_tb.BorderColor = System.Drawing.Color.Black
        Me.itm_name_tb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.itm_name_tb.DefaultText = ""
        Me.itm_name_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.itm_name_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.itm_name_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.itm_name_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.itm_name_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.itm_name_tb.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.itm_name_tb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.itm_name_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.itm_name_tb.Location = New System.Drawing.Point(121, 59)
        Me.itm_name_tb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.itm_name_tb.Name = "itm_name_tb"
        Me.itm_name_tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.itm_name_tb.PlaceholderText = ""
        Me.itm_name_tb.SelectedText = ""
        Me.itm_name_tb.Size = New System.Drawing.Size(222, 36)
        Me.itm_name_tb.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(6, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Item Amount:"
        '
        'itm_rate_tb
        '
        Me.itm_rate_tb.BorderColor = System.Drawing.Color.Black
        Me.itm_rate_tb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.itm_rate_tb.DefaultText = ""
        Me.itm_rate_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.itm_rate_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.itm_rate_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.itm_rate_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.itm_rate_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.itm_rate_tb.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.itm_rate_tb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.itm_rate_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.itm_rate_tb.Location = New System.Drawing.Point(121, 237)
        Me.itm_rate_tb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.itm_rate_tb.Name = "itm_rate_tb"
        Me.itm_rate_tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.itm_rate_tb.PlaceholderText = ""
        Me.itm_rate_tb.SelectedText = ""
        Me.itm_rate_tb.Size = New System.Drawing.Size(222, 36)
        Me.itm_rate_tb.TabIndex = 95
        '
        'itm_type_combo
        '
        Me.itm_type_combo.BackColor = System.Drawing.Color.Transparent
        Me.itm_type_combo.BorderColor = System.Drawing.Color.Black
        Me.itm_type_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.itm_type_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.itm_type_combo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.itm_type_combo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.itm_type_combo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.itm_type_combo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.itm_type_combo.ItemHeight = 30
        Me.itm_type_combo.Location = New System.Drawing.Point(121, 103)
        Me.itm_type_combo.Name = "itm_type_combo"
        Me.itm_type_combo.Size = New System.Drawing.Size(222, 36)
        Me.itm_type_combo.TabIndex = 3
        '
        'QueryPanel
        '
        Me.QueryPanel.Controls.Add(Me.delBtn)
        Me.QueryPanel.Controls.Add(Me.updateBtn)
        Me.QueryPanel.Enabled = False
        Me.QueryPanel.Location = New System.Drawing.Point(391, 15)
        Me.QueryPanel.Name = "QueryPanel"
        Me.QueryPanel.Size = New System.Drawing.Size(169, 124)
        Me.QueryPanel.TabIndex = 94
        '
        'delBtn
        '
        Me.delBtn.BorderColor = System.Drawing.Color.Transparent
        Me.delBtn.BorderRadius = 20
        Me.delBtn.BorderThickness = 2
        Me.delBtn.CustomizableEdges.BottomRight = False
        Me.delBtn.CustomizableEdges.TopLeft = False
        Me.delBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.delBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.delBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.delBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.delBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.delBtn.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.delBtn.ForeColor = System.Drawing.Color.White
        Me.delBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.delBtn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.delBtn.HoverState.FillColor = System.Drawing.Color.White
        Me.delBtn.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.delBtn.Location = New System.Drawing.Point(11, 60)
        Me.delBtn.Name = "delBtn"
        Me.delBtn.Size = New System.Drawing.Size(145, 45)
        Me.delBtn.TabIndex = 93
        Me.delBtn.Text = "Delete"
        '
        'updateBtn
        '
        Me.updateBtn.BorderColor = System.Drawing.Color.Transparent
        Me.updateBtn.BorderRadius = 20
        Me.updateBtn.BorderThickness = 2
        Me.updateBtn.CustomizableEdges.BottomRight = False
        Me.updateBtn.CustomizableEdges.TopLeft = False
        Me.updateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.updateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.updateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.updateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.updateBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.updateBtn.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.updateBtn.ForeColor = System.Drawing.Color.White
        Me.updateBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.updateBtn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.updateBtn.HoverState.FillColor = System.Drawing.Color.White
        Me.updateBtn.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.updateBtn.Location = New System.Drawing.Point(10, 7)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(145, 45)
        Me.updateBtn.TabIndex = 92
        Me.updateBtn.Text = "Update"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(6, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Item Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(6, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 20)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "Item Rate:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Item Type:"
        '
        'itm_qty_tb
        '
        Me.itm_qty_tb.BorderColor = System.Drawing.Color.Black
        Me.itm_qty_tb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.itm_qty_tb.DefaultText = ""
        Me.itm_qty_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.itm_qty_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.itm_qty_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.itm_qty_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.itm_qty_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.itm_qty_tb.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.itm_qty_tb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.itm_qty_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.itm_qty_tb.Location = New System.Drawing.Point(121, 147)
        Me.itm_qty_tb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.itm_qty_tb.Name = "itm_qty_tb"
        Me.itm_qty_tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.itm_qty_tb.PlaceholderText = ""
        Me.itm_qty_tb.SelectedText = ""
        Me.itm_qty_tb.Size = New System.Drawing.Size(222, 36)
        Me.itm_qty_tb.TabIndex = 5
        '
        'itm_stk_tb
        '
        Me.itm_stk_tb.BorderColor = System.Drawing.Color.Black
        Me.itm_stk_tb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.itm_stk_tb.DefaultText = ""
        Me.itm_stk_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.itm_stk_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.itm_stk_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.itm_stk_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.itm_stk_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.itm_stk_tb.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.itm_stk_tb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.itm_stk_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.itm_stk_tb.Location = New System.Drawing.Point(121, 191)
        Me.itm_stk_tb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.itm_stk_tb.Name = "itm_stk_tb"
        Me.itm_stk_tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.itm_stk_tb.PlaceholderText = ""
        Me.itm_stk_tb.SelectedText = ""
        Me.itm_stk_tb.Size = New System.Drawing.Size(222, 36)
        Me.itm_stk_tb.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(6, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Items In Stock:"
        '
        'itm_code_tb
        '
        Me.itm_code_tb.BorderColor = System.Drawing.Color.Black
        Me.itm_code_tb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.itm_code_tb.DefaultText = ""
        Me.itm_code_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.itm_code_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.itm_code_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.itm_code_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.itm_code_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.itm_code_tb.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.itm_code_tb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.itm_code_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.itm_code_tb.Location = New System.Drawing.Point(121, 15)
        Me.itm_code_tb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.itm_code_tb.Name = "itm_code_tb"
        Me.itm_code_tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.itm_code_tb.PlaceholderText = ""
        Me.itm_code_tb.SelectedText = ""
        Me.itm_code_tb.Size = New System.Drawing.Size(222, 36)
        Me.itm_code_tb.TabIndex = 1
        '
        'FilterPage
        '
        Me.FilterPage.Controls.Add(Me.Label10)
        Me.FilterPage.Controls.Add(Me.fltr_code_tb)
        Me.FilterPage.Controls.Add(Me.clrBtn)
        Me.FilterPage.Controls.Add(Me.filtrBtn)
        Me.FilterPage.Controls.Add(Me.fltr_rate_lt)
        Me.FilterPage.Controls.Add(Me.fltr_rate_gt)
        Me.FilterPage.Controls.Add(Me.fltr_name_tb)
        Me.FilterPage.Controls.Add(Me.fltr_rate_tb)
        Me.FilterPage.Controls.Add(Me.fltr_type_combo)
        Me.FilterPage.Controls.Add(Me.Label7)
        Me.FilterPage.Controls.Add(Me.Label8)
        Me.FilterPage.Controls.Add(Me.Label9)
        Me.FilterPage.Location = New System.Drawing.Point(4, 44)
        Me.FilterPage.Name = "FilterPage"
        Me.FilterPage.Padding = New System.Windows.Forms.Padding(3)
        Me.FilterPage.Size = New System.Drawing.Size(906, 281)
        Me.FilterPage.TabIndex = 1
        Me.FilterPage.Text = "Search"
        Me.FilterPage.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(103, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 20)
        Me.Label10.TabIndex = 101
        Me.Label10.Text = "Item Code:"
        '
        'fltr_code_tb
        '
        Me.fltr_code_tb.BorderColor = System.Drawing.Color.Black
        Me.fltr_code_tb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fltr_code_tb.DefaultText = ""
        Me.fltr_code_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.fltr_code_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.fltr_code_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fltr_code_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fltr_code_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fltr_code_tb.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.fltr_code_tb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.fltr_code_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fltr_code_tb.Location = New System.Drawing.Point(218, 18)
        Me.fltr_code_tb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.fltr_code_tb.Name = "fltr_code_tb"
        Me.fltr_code_tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.fltr_code_tb.PlaceholderText = ""
        Me.fltr_code_tb.SelectedText = ""
        Me.fltr_code_tb.Size = New System.Drawing.Size(324, 35)
        Me.fltr_code_tb.TabIndex = 102
        '
        'clrBtn
        '
        Me.clrBtn.BorderColor = System.Drawing.Color.Transparent
        Me.clrBtn.BorderRadius = 20
        Me.clrBtn.BorderThickness = 2
        Me.clrBtn.CustomizableEdges.BottomRight = False
        Me.clrBtn.CustomizableEdges.TopLeft = False
        Me.clrBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.clrBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.clrBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.clrBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.clrBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.clrBtn.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.clrBtn.ForeColor = System.Drawing.Color.White
        Me.clrBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.clrBtn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.clrBtn.HoverState.FillColor = System.Drawing.Color.White
        Me.clrBtn.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.clrBtn.Location = New System.Drawing.Point(258, 219)
        Me.clrBtn.Name = "clrBtn"
        Me.clrBtn.Size = New System.Drawing.Size(145, 45)
        Me.clrBtn.TabIndex = 6
        Me.clrBtn.Text = "Clear Filter"
        '
        'filtrBtn
        '
        Me.filtrBtn.BorderColor = System.Drawing.Color.Transparent
        Me.filtrBtn.BorderRadius = 20
        Me.filtrBtn.BorderThickness = 2
        Me.filtrBtn.CustomizableEdges.BottomRight = False
        Me.filtrBtn.CustomizableEdges.TopLeft = False
        Me.filtrBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.filtrBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.filtrBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.filtrBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.filtrBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.filtrBtn.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.filtrBtn.ForeColor = System.Drawing.Color.White
        Me.filtrBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.filtrBtn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.filtrBtn.HoverState.FillColor = System.Drawing.Color.White
        Me.filtrBtn.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.filtrBtn.Location = New System.Drawing.Point(107, 219)
        Me.filtrBtn.Name = "filtrBtn"
        Me.filtrBtn.Size = New System.Drawing.Size(145, 45)
        Me.filtrBtn.TabIndex = 5
        Me.filtrBtn.Text = "Filter"
        '
        'fltr_rate_lt
        '
        Me.fltr_rate_lt.AutoSize = True
        Me.fltr_rate_lt.CheckedState.BorderColor = System.Drawing.Color.Black
        Me.fltr_rate_lt.CheckedState.BorderThickness = 0
        Me.fltr_rate_lt.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.fltr_rate_lt.CheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.fltr_rate_lt.CheckedState.InnerOffset = -4
        Me.fltr_rate_lt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.fltr_rate_lt.Location = New System.Drawing.Point(218, 180)
        Me.fltr_rate_lt.Name = "fltr_rate_lt"
        Me.fltr_rate_lt.Size = New System.Drawing.Size(97, 24)
        Me.fltr_rate_lt.TabIndex = 3
        Me.fltr_rate_lt.Text = "Less than"
        Me.fltr_rate_lt.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.fltr_rate_lt.UncheckedState.BorderThickness = 2
        Me.fltr_rate_lt.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.fltr_rate_lt.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'fltr_rate_gt
        '
        Me.fltr_rate_gt.AutoSize = True
        Me.fltr_rate_gt.Checked = True
        Me.fltr_rate_gt.CheckedState.BorderColor = System.Drawing.Color.Black
        Me.fltr_rate_gt.CheckedState.BorderThickness = 0
        Me.fltr_rate_gt.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.fltr_rate_gt.CheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.fltr_rate_gt.CheckedState.InnerOffset = -4
        Me.fltr_rate_gt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.fltr_rate_gt.Location = New System.Drawing.Point(218, 150)
        Me.fltr_rate_gt.Name = "fltr_rate_gt"
        Me.fltr_rate_gt.Size = New System.Drawing.Size(99, 24)
        Me.fltr_rate_gt.TabIndex = 2
        Me.fltr_rate_gt.TabStop = True
        Me.fltr_rate_gt.Text = "More than"
        Me.fltr_rate_gt.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.fltr_rate_gt.UncheckedState.BorderThickness = 2
        Me.fltr_rate_gt.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.fltr_rate_gt.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'fltr_name_tb
        '
        Me.fltr_name_tb.BorderColor = System.Drawing.Color.Black
        Me.fltr_name_tb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fltr_name_tb.DefaultText = ""
        Me.fltr_name_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.fltr_name_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.fltr_name_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fltr_name_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fltr_name_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fltr_name_tb.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.fltr_name_tb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.fltr_name_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fltr_name_tb.Location = New System.Drawing.Point(218, 63)
        Me.fltr_name_tb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.fltr_name_tb.Name = "fltr_name_tb"
        Me.fltr_name_tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.fltr_name_tb.PlaceholderText = ""
        Me.fltr_name_tb.SelectedText = ""
        Me.fltr_name_tb.Size = New System.Drawing.Size(328, 36)
        Me.fltr_name_tb.TabIndex = 0
        '
        'fltr_rate_tb
        '
        Me.fltr_rate_tb.BorderColor = System.Drawing.Color.Black
        Me.fltr_rate_tb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fltr_rate_tb.DefaultText = ""
        Me.fltr_rate_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.fltr_rate_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.fltr_rate_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fltr_rate_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fltr_rate_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fltr_rate_tb.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.fltr_rate_tb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.fltr_rate_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fltr_rate_tb.Location = New System.Drawing.Point(324, 161)
        Me.fltr_rate_tb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.fltr_rate_tb.Name = "fltr_rate_tb"
        Me.fltr_rate_tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.fltr_rate_tb.PlaceholderText = ""
        Me.fltr_rate_tb.SelectedText = ""
        Me.fltr_rate_tb.Size = New System.Drawing.Size(222, 35)
        Me.fltr_rate_tb.TabIndex = 4
        '
        'fltr_type_combo
        '
        Me.fltr_type_combo.BackColor = System.Drawing.Color.Transparent
        Me.fltr_type_combo.BorderColor = System.Drawing.Color.Black
        Me.fltr_type_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.fltr_type_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.fltr_type_combo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fltr_type_combo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fltr_type_combo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.fltr_type_combo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.fltr_type_combo.ItemHeight = 30
        Me.fltr_type_combo.Location = New System.Drawing.Point(218, 107)
        Me.fltr_type_combo.Name = "fltr_type_combo"
        Me.fltr_type_combo.Size = New System.Drawing.Size(328, 36)
        Me.fltr_type_combo.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(103, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 20)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "Item Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(103, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 20)
        Me.Label8.TabIndex = 100
        Me.Label8.Text = "Item Rate:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(103, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 20)
        Me.Label9.TabIndex = 96
        Me.Label9.Text = "Item Type:"
        '
        'GridViewPanel
        '
        Me.GridViewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GridViewPanel.Controls.Add(Me.itm_list_grid)
        Me.GridViewPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GridViewPanel.Location = New System.Drawing.Point(0, 327)
        Me.GridViewPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.GridViewPanel.Name = "GridViewPanel"
        Me.GridViewPanel.Size = New System.Drawing.Size(648, 292)
        Me.GridViewPanel.TabIndex = 13
        Me.GridViewPanel.TabStop = True
        '
        'itm_list_grid
        '
        Me.itm_list_grid.AllowUserToAddRows = False
        Me.itm_list_grid.AllowUserToDeleteRows = False
        Me.itm_list_grid.AllowUserToResizeColumns = False
        Me.itm_list_grid.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.itm_list_grid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.itm_list_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.itm_list_grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.itm_code_col, Me.itm_name_col, Me.itm_type_col, Me.itm_qty_col, Me.itm_stk_col, Me.itm_rate_col})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.itm_list_grid.DefaultCellStyle = DataGridViewCellStyle6
        Me.itm_list_grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.itm_list_grid.GridColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.itm_list_grid.Location = New System.Drawing.Point(0, 0)
        Me.itm_list_grid.MultiSelect = False
        Me.itm_list_grid.Name = "itm_list_grid"
        Me.itm_list_grid.ReadOnly = True
        Me.itm_list_grid.RowHeadersVisible = False
        Me.itm_list_grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.itm_list_grid.Size = New System.Drawing.Size(646, 290)
        Me.itm_list_grid.TabIndex = 45
        Me.itm_list_grid.TabStop = False
        Me.itm_list_grid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin
        Me.itm_list_grid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.itm_list_grid.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.itm_list_grid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.itm_list_grid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.itm_list_grid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.itm_list_grid.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.itm_list_grid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.itm_list_grid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.itm_list_grid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.itm_list_grid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.itm_list_grid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.itm_list_grid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.itm_list_grid.ThemeStyle.HeaderStyle.Height = 23
        Me.itm_list_grid.ThemeStyle.ReadOnly = True
        Me.itm_list_grid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.itm_list_grid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.itm_list_grid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.itm_list_grid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.itm_list_grid.ThemeStyle.RowsStyle.Height = 22
        Me.itm_list_grid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.itm_list_grid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'itm_code_col
        '
        Me.itm_code_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.itm_code_col.DataPropertyName = "i_code"
        Me.itm_code_col.Frozen = True
        Me.itm_code_col.HeaderText = "Item Code"
        Me.itm_code_col.Name = "itm_code_col"
        Me.itm_code_col.ReadOnly = True
        '
        'itm_name_col
        '
        Me.itm_name_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.itm_name_col.DataPropertyName = "i_name"
        Me.itm_name_col.Frozen = True
        Me.itm_name_col.HeaderText = "Name"
        Me.itm_name_col.Name = "itm_name_col"
        Me.itm_name_col.ReadOnly = True
        Me.itm_name_col.Width = 175
        '
        'itm_type_col
        '
        Me.itm_type_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.itm_type_col.DataPropertyName = "i_type"
        Me.itm_type_col.HeaderText = "Type"
        Me.itm_type_col.Name = "itm_type_col"
        Me.itm_type_col.ReadOnly = True
        Me.itm_type_col.Width = 150
        '
        'itm_qty_col
        '
        Me.itm_qty_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.itm_qty_col.DataPropertyName = "i_qty"
        Me.itm_qty_col.HeaderText = "Total Amt."
        Me.itm_qty_col.Name = "itm_qty_col"
        Me.itm_qty_col.ReadOnly = True
        Me.itm_qty_col.Width = 75
        '
        'itm_stk_col
        '
        Me.itm_stk_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.itm_stk_col.DataPropertyName = "i_in_stk"
        Me.itm_stk_col.HeaderText = "In Stock"
        Me.itm_stk_col.Name = "itm_stk_col"
        Me.itm_stk_col.ReadOnly = True
        Me.itm_stk_col.Width = 75
        '
        'itm_rate_col
        '
        Me.itm_rate_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.itm_rate_col.DataPropertyName = "i_rte"
        Me.itm_rate_col.HeaderText = "Rate"
        Me.itm_rate_col.Name = "itm_rate_col"
        Me.itm_rate_col.ReadOnly = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.RentIt.My.Resources.Resources.navr_borderless
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Location = New System.Drawing.Point(914, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(456, 625)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
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
        Me.NavPanel.Size = New System.Drawing.Size(260, 625)
        Me.NavPanel.TabIndex = 5
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
        Me.toStockManager.Enabled = False
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
        'StockManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1370, 625)
        Me.Controls.Add(Me.NavPanel)
        Me.Controls.Add(Me.WorkSpace)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "StockManager"
        Me.ShowIcon = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.WorkSpace.ResumeLayout(False)
        Me.Manage_Filter.ResumeLayout(False)
        Me.ManagePage.ResumeLayout(False)
        Me.ManagePage.PerformLayout()
        Me.QueryPanel.ResumeLayout(False)
        Me.FilterPage.ResumeLayout(False)
        Me.FilterPage.PerformLayout()
        Me.GridViewPanel.ResumeLayout(False)
        CType(Me.itm_list_grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavPanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents WorkSpace As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents itm_code_tb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents itm_type_combo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents itm_qty_tb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents itm_stk_tb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents itm_name_tb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GridViewPanel As Panel
    Friend WithEvents itm_list_grid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents delBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents updateBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents QueryPanel As Panel
    Friend WithEvents itm_rate_tb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents itm_code_col As DataGridViewTextBoxColumn
    Friend WithEvents itm_name_col As DataGridViewTextBoxColumn
    Friend WithEvents itm_type_col As DataGridViewTextBoxColumn
    Friend WithEvents itm_qty_col As DataGridViewTextBoxColumn
    Friend WithEvents itm_stk_col As DataGridViewTextBoxColumn
    Friend WithEvents itm_rate_col As DataGridViewTextBoxColumn
    Friend WithEvents Manage_Filter As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents ManagePage As TabPage
    Friend WithEvents FilterPage As TabPage
    Friend WithEvents fltr_rate_lt As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents fltr_rate_gt As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents fltr_name_tb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents fltr_rate_tb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents fltr_type_combo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents clrBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents filtrBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label10 As Label
    Friend WithEvents fltr_code_tb As Guna.UI2.WinForms.Guna2TextBox
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
