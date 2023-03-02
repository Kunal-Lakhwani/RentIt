<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bill_Maker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bill_Maker))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Digibill = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.itm_Lst_idx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_i_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_i_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_i_dur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_i_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_i_rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Disc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.IsNewCST = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Cust_manager = New System.Windows.Forms.Panel()
        Me.Custcontact = New System.Windows.Forms.TextBox()
        Me.CstOpBal = New System.Windows.Forms.Label()
        Me.Custname = New System.Windows.Forms.TextBox()
        Me.PrntBill = New Guna.UI2.WinForms.Guna2Button()
        Me.Ins_Itm = New Guna.UI2.WinForms.Guna2Button()
        Me.Itm_ttl = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Itm_nme = New System.Windows.Forms.TextBox()
        Me.Itm_qty = New System.Windows.Forms.NumericUpDown()
        Me.Itm_cst = New System.Windows.Forms.TextBox()
        Me.Itm_code = New System.Windows.Forms.ComboBox()
        Me.DateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.biller = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.From_Bal = New System.Windows.Forms.CheckBox()
        Me.Pay_now = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.NmeDisplay = New System.Windows.Forms.Label()
        Me.ContDisplay = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CnclBilling = New Guna.UI2.WinForms.Guna2Button()
        Me.SubTot = New System.Windows.Forms.Label()
        Me.GTot = New System.Windows.Forms.Label()
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
        Me.Panel3.SuspendLayout()
        CType(Me.Digibill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Cust_manager.SuspendLayout()
        CType(Me.Itm_qty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.biller.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Digibill)
        Me.Panel3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Location = New System.Drawing.Point(682, 66)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(330, 376)
        Me.Panel3.TabIndex = 7
        '
        'Digibill
        '
        Me.Digibill.AllowUserToAddRows = False
        Me.Digibill.AllowUserToDeleteRows = False
        Me.Digibill.AllowUserToResizeColumns = False
        Me.Digibill.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Digibill.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Digibill.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Digibill.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.itm_Lst_idx, Me.b_i_code, Me.b_i_name, Me.b_i_dur, Me.b_i_qty, Me.b_i_rate})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Digibill.DefaultCellStyle = DataGridViewCellStyle3
        Me.Digibill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Digibill.GridColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Digibill.Location = New System.Drawing.Point(0, 0)
        Me.Digibill.MultiSelect = False
        Me.Digibill.Name = "Digibill"
        Me.Digibill.ReadOnly = True
        Me.Digibill.RowHeadersVisible = False
        Me.Digibill.RowTemplate.ReadOnly = True
        Me.Digibill.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Digibill.Size = New System.Drawing.Size(328, 374)
        Me.Digibill.TabIndex = 47
        Me.Digibill.TabStop = False
        Me.Digibill.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin
        Me.Digibill.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Digibill.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Digibill.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Digibill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Digibill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Digibill.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Digibill.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Digibill.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Digibill.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Digibill.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Digibill.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Digibill.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Digibill.ThemeStyle.HeaderStyle.Height = 23
        Me.Digibill.ThemeStyle.ReadOnly = True
        Me.Digibill.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Digibill.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Digibill.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Digibill.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Digibill.ThemeStyle.RowsStyle.Height = 22
        Me.Digibill.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Digibill.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'itm_Lst_idx
        '
        Me.itm_Lst_idx.HeaderText = "List Index"
        Me.itm_Lst_idx.Name = "itm_Lst_idx"
        Me.itm_Lst_idx.ReadOnly = True
        Me.itm_Lst_idx.Visible = False
        '
        'b_i_code
        '
        Me.b_i_code.DataPropertyName = "i_code"
        Me.b_i_code.HeaderText = "Itm_code"
        Me.b_i_code.Name = "b_i_code"
        Me.b_i_code.ReadOnly = True
        Me.b_i_code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.b_i_code.ToolTipText = "Double Click an Item to remove it from Billing"
        Me.b_i_code.Visible = False
        '
        'b_i_name
        '
        Me.b_i_name.DataPropertyName = "i_nme"
        Me.b_i_name.FillWeight = 250.0!
        Me.b_i_name.HeaderText = "Name"
        Me.b_i_name.Name = "b_i_name"
        Me.b_i_name.ReadOnly = True
        Me.b_i_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'b_i_dur
        '
        Me.b_i_dur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.b_i_dur.DataPropertyName = "i_dur"
        Me.b_i_dur.FillWeight = 55.0!
        Me.b_i_dur.HeaderText = "Duration"
        Me.b_i_dur.Name = "b_i_dur"
        Me.b_i_dur.ReadOnly = True
        Me.b_i_dur.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.b_i_dur.ToolTipText = "Double Click an Item to remove it from Billing"
        Me.b_i_dur.Width = 73
        '
        'b_i_qty
        '
        Me.b_i_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.b_i_qty.DataPropertyName = "i_qty"
        Me.b_i_qty.FillWeight = 30.0!
        Me.b_i_qty.HeaderText = "Qty."
        Me.b_i_qty.Name = "b_i_qty"
        Me.b_i_qty.ReadOnly = True
        Me.b_i_qty.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.b_i_qty.ToolTipText = "Double Click an Item to remove it from Billing"
        Me.b_i_qty.Width = 30
        '
        'b_i_rate
        '
        Me.b_i_rate.DataPropertyName = "i_rte"
        Me.b_i_rate.FillWeight = 60.0!
        Me.b_i_rate.HeaderText = "Rate"
        Me.b_i_rate.Name = "b_i_rate"
        Me.b_i_rate.ReadOnly = True
        Me.b_i_rate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.b_i_rate.ToolTipText = "Double Click an Item to remove it from Billing"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(681, 483)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Discount"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(23, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 20)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Contact No"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(23, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 20)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Customer Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Disc
        '
        Me.Disc.BackColor = System.Drawing.Color.White
        Me.Disc.ForeColor = System.Drawing.Color.Black
        Me.Disc.Location = New System.Drawing.Point(835, 480)
        Me.Disc.Name = "Disc"
        Me.Disc.Size = New System.Drawing.Size(137, 26)
        Me.Disc.TabIndex = 5
        Me.Disc.TabStop = False
        Me.Disc.Text = "0"
        Me.Disc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(681, 517)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 20)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Grand Total"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(786, 517)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(18, 20)
        Me.Label17.TabIndex = 98
        Me.Label17.Text = "₹"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(681, 450)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 20)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "Sub Total"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(786, 450)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(18, 20)
        Me.Label16.TabIndex = 97
        Me.Label16.Text = "₹"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'IsNewCST
        '
        Me.IsNewCST.AutoSize = True
        Me.IsNewCST.BackColor = System.Drawing.Color.White
        Me.IsNewCST.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.IsNewCST.Location = New System.Drawing.Point(150, 3)
        Me.IsNewCST.Name = "IsNewCST"
        Me.IsNewCST.Size = New System.Drawing.Size(132, 24)
        Me.IsNewCST.TabIndex = 0
        Me.IsNewCST.Text = "New Customer"
        Me.IsNewCST.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(23, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 20)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "Customer Balance"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Cust_manager
        '
        Me.Cust_manager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cust_manager.Controls.Add(Me.Custcontact)
        Me.Cust_manager.Controls.Add(Me.CstOpBal)
        Me.Cust_manager.Controls.Add(Me.Custname)
        Me.Cust_manager.Controls.Add(Me.Label1)
        Me.Cust_manager.Controls.Add(Me.Label9)
        Me.Cust_manager.Controls.Add(Me.Label2)
        Me.Cust_manager.Controls.Add(Me.IsNewCST)
        Me.Cust_manager.Location = New System.Drawing.Point(267, 12)
        Me.Cust_manager.Name = "Cust_manager"
        Me.Cust_manager.Size = New System.Drawing.Size(403, 167)
        Me.Cust_manager.TabIndex = 1
        '
        'Custcontact
        '
        Me.Custcontact.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Custcontact.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Custcontact.BackColor = System.Drawing.Color.White
        Me.Custcontact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Custcontact.Location = New System.Drawing.Point(201, 34)
        Me.Custcontact.MaxLength = 10
        Me.Custcontact.Name = "Custcontact"
        Me.Custcontact.Size = New System.Drawing.Size(171, 26)
        Me.Custcontact.TabIndex = 1
        '
        'CstOpBal
        '
        Me.CstOpBal.AutoSize = True
        Me.CstOpBal.BackColor = System.Drawing.Color.White
        Me.CstOpBal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.CstOpBal.Location = New System.Drawing.Point(200, 118)
        Me.CstOpBal.Name = "CstOpBal"
        Me.CstOpBal.Size = New System.Drawing.Size(29, 20)
        Me.CstOpBal.TabIndex = 101
        Me.CstOpBal.Text = "----"
        Me.CstOpBal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Custname
        '
        Me.Custname.Location = New System.Drawing.Point(201, 77)
        Me.Custname.Name = "Custname"
        Me.Custname.Size = New System.Drawing.Size(171, 26)
        Me.Custname.TabIndex = 2
        '
        'PrntBill
        '
        Me.PrntBill.BorderColor = System.Drawing.Color.Transparent
        Me.PrntBill.BorderRadius = 20
        Me.PrntBill.BorderThickness = 2
        Me.PrntBill.CustomizableEdges.BottomRight = False
        Me.PrntBill.CustomizableEdges.TopLeft = False
        Me.PrntBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.PrntBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.PrntBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.PrntBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.PrntBill.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.PrntBill.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.PrntBill.ForeColor = System.Drawing.Color.White
        Me.PrntBill.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.PrntBill.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.PrntBill.HoverState.FillColor = System.Drawing.Color.White
        Me.PrntBill.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.PrntBill.Location = New System.Drawing.Point(276, 528)
        Me.PrntBill.Name = "PrntBill"
        Me.PrntBill.Size = New System.Drawing.Size(177, 52)
        Me.PrntBill.TabIndex = 115
        Me.PrntBill.TabStop = False
        Me.PrntBill.Text = "Print"
        '
        'Ins_Itm
        '
        Me.Ins_Itm.BorderColor = System.Drawing.Color.Transparent
        Me.Ins_Itm.BorderRadius = 20
        Me.Ins_Itm.BorderThickness = 2
        Me.Ins_Itm.CustomizableEdges.BottomRight = False
        Me.Ins_Itm.CustomizableEdges.TopLeft = False
        Me.Ins_Itm.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Ins_Itm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Ins_Itm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Ins_Itm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Ins_Itm.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Ins_Itm.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Ins_Itm.ForeColor = System.Drawing.Color.White
        Me.Ins_Itm.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Ins_Itm.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Ins_Itm.HoverState.FillColor = System.Drawing.Color.White
        Me.Ins_Itm.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Ins_Itm.Location = New System.Drawing.Point(259, 281)
        Me.Ins_Itm.Name = "Ins_Itm"
        Me.Ins_Itm.Size = New System.Drawing.Size(133, 42)
        Me.Ins_Itm.TabIndex = 106
        Me.Ins_Itm.Text = "Add Item"
        '
        'Itm_ttl
        '
        Me.Itm_ttl.AutoSize = True
        Me.Itm_ttl.BackColor = System.Drawing.Color.Transparent
        Me.Itm_ttl.Font = New System.Drawing.Font("Times New Roman", 15.0!)
        Me.Itm_ttl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Itm_ttl.Location = New System.Drawing.Point(237, 89)
        Me.Itm_ttl.Name = "Itm_ttl"
        Me.Itm_ttl.Size = New System.Drawing.Size(26, 22)
        Me.Itm_ttl.TabIndex = 114
        Me.Itm_ttl.Text = "/1"
        Me.Itm_ttl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(21, 209)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 20)
        Me.Label12.TabIndex = 113
        Me.Label12.Text = "Required on"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(21, 173)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 20)
        Me.Label11.TabIndex = 112
        Me.Label11.Text = "Booked on"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(21, 133)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 20)
        Me.Label10.TabIndex = 111
        Me.Label10.Text = "Rate per day"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(23, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 20)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Item Quantity"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(21, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "Item Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(23, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "Item code"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Itm_nme
        '
        Me.Itm_nme.BackColor = System.Drawing.Color.White
        Me.Itm_nme.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Itm_nme.Location = New System.Drawing.Point(201, 47)
        Me.Itm_nme.Name = "Itm_nme"
        Me.Itm_nme.Size = New System.Drawing.Size(171, 26)
        Me.Itm_nme.TabIndex = 4
        '
        'Itm_qty
        '
        Me.Itm_qty.BackColor = System.Drawing.Color.White
        Me.Itm_qty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Itm_qty.Location = New System.Drawing.Point(201, 87)
        Me.Itm_qty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Itm_qty.Name = "Itm_qty"
        Me.Itm_qty.ReadOnly = True
        Me.Itm_qty.Size = New System.Drawing.Size(33, 26)
        Me.Itm_qty.TabIndex = 5
        Me.Itm_qty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Itm_cst
        '
        Me.Itm_cst.BackColor = System.Drawing.Color.White
        Me.Itm_cst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Itm_cst.Location = New System.Drawing.Point(201, 129)
        Me.Itm_cst.Name = "Itm_cst"
        Me.Itm_cst.ReadOnly = True
        Me.Itm_cst.Size = New System.Drawing.Size(171, 26)
        Me.Itm_cst.TabIndex = 6
        Me.Itm_cst.TabStop = False
        '
        'Itm_code
        '
        Me.Itm_code.BackColor = System.Drawing.Color.White
        Me.Itm_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Itm_code.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Itm_code.FormattingEnabled = True
        Me.Itm_code.Location = New System.Drawing.Point(201, 7)
        Me.Itm_code.Name = "Itm_code"
        Me.Itm_code.Size = New System.Drawing.Size(171, 28)
        Me.Itm_code.TabIndex = 3
        '
        'DateTo
        '
        Me.DateTo.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.DateTo.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.DateTo.Location = New System.Drawing.Point(201, 205)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(171, 26)
        Me.DateTo.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(171, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 20)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "₹"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DateFrom
        '
        Me.DateFrom.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.DateFrom.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.DateFrom.Location = New System.Drawing.Point(201, 166)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(171, 26)
        Me.DateFrom.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(786, 483)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 20)
        Me.Label14.TabIndex = 100
        Me.Label14.Text = "₹ / %"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'biller
        '
        Me.biller.Controls.Add(Me.Itm_ttl)
        Me.biller.Controls.Add(Me.Label12)
        Me.biller.Controls.Add(Me.Itm_nme)
        Me.biller.Controls.Add(Me.Panel1)
        Me.biller.Controls.Add(Me.Label11)
        Me.biller.Controls.Add(Me.Itm_qty)
        Me.biller.Controls.Add(Me.Label10)
        Me.biller.Controls.Add(Me.Ins_Itm)
        Me.biller.Controls.Add(Me.Itm_cst)
        Me.biller.Controls.Add(Me.Label5)
        Me.biller.Controls.Add(Me.Itm_code)
        Me.biller.Controls.Add(Me.Label3)
        Me.biller.Controls.Add(Me.Label4)
        Me.biller.Controls.Add(Me.DateFrom)
        Me.biller.Controls.Add(Me.Label8)
        Me.biller.Controls.Add(Me.DateTo)
        Me.biller.Enabled = False
        Me.biller.Location = New System.Drawing.Point(268, 190)
        Me.biller.Name = "biller"
        Me.biller.Size = New System.Drawing.Size(402, 332)
        Me.biller.TabIndex = 99
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.From_Bal)
        Me.Panel1.Controls.Add(Me.Pay_now)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Location = New System.Drawing.Point(0, 237)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(402, 38)
        Me.Panel1.TabIndex = 125
        '
        'From_Bal
        '
        Me.From_Bal.AutoSize = True
        Me.From_Bal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.From_Bal.Location = New System.Drawing.Point(214, 7)
        Me.From_Bal.Name = "From_Bal"
        Me.From_Bal.Size = New System.Drawing.Size(178, 24)
        Me.From_Bal.TabIndex = 116
        Me.From_Bal.Text = "Deduct from Balance"
        Me.From_Bal.UseVisualStyleBackColor = True
        '
        'Pay_now
        '
        Me.Pay_now.AutoSize = True
        Me.Pay_now.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Pay_now.Location = New System.Drawing.Point(115, 7)
        Me.Pay_now.Name = "Pay_now"
        Me.Pay_now.Size = New System.Drawing.Size(89, 24)
        Me.Pay_now.TabIndex = 115
        Me.Pay_now.Text = "Pay Now"
        Me.Pay_now.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(23, 7)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 20)
        Me.Label19.TabIndex = 114
        Me.Label19.Text = "Paymode"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(687, 5)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(144, 20)
        Me.Label15.TabIndex = 120
        Me.Label15.Text = "Customer Name    :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(687, 40)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(146, 20)
        Me.Label18.TabIndex = 121
        Me.Label18.Text = "Customer Contact :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'NmeDisplay
        '
        Me.NmeDisplay.AutoSize = True
        Me.NmeDisplay.BackColor = System.Drawing.Color.White
        Me.NmeDisplay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.NmeDisplay.Location = New System.Drawing.Point(833, 5)
        Me.NmeDisplay.Name = "NmeDisplay"
        Me.NmeDisplay.Size = New System.Drawing.Size(49, 20)
        Me.NmeDisplay.TabIndex = 122
        Me.NmeDisplay.Text = "name"
        Me.NmeDisplay.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.NmeDisplay.Visible = False
        '
        'ContDisplay
        '
        Me.ContDisplay.AutoSize = True
        Me.ContDisplay.BackColor = System.Drawing.Color.White
        Me.ContDisplay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ContDisplay.Location = New System.Drawing.Point(833, 40)
        Me.ContDisplay.Name = "ContDisplay"
        Me.ContDisplay.Size = New System.Drawing.Size(99, 20)
        Me.ContDisplay.TabIndex = 123
        Me.ContDisplay.Text = "0000000000"
        Me.ContDisplay.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ContDisplay.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.RentIt.My.Resources.Resources.navr_borderless
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Location = New System.Drawing.Point(1018, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(352, 602)
        Me.PictureBox2.TabIndex = 127
        Me.PictureBox2.TabStop = False
        '
        'CnclBilling
        '
        Me.CnclBilling.BorderColor = System.Drawing.Color.Transparent
        Me.CnclBilling.BorderRadius = 20
        Me.CnclBilling.BorderThickness = 2
        Me.CnclBilling.CustomizableEdges.BottomRight = False
        Me.CnclBilling.CustomizableEdges.TopLeft = False
        Me.CnclBilling.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.CnclBilling.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.CnclBilling.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.CnclBilling.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.CnclBilling.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.CnclBilling.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.CnclBilling.ForeColor = System.Drawing.Color.White
        Me.CnclBilling.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.CnclBilling.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.CnclBilling.HoverState.FillColor = System.Drawing.Color.White
        Me.CnclBilling.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.CnclBilling.Location = New System.Drawing.Point(459, 528)
        Me.CnclBilling.Name = "CnclBilling"
        Me.CnclBilling.Size = New System.Drawing.Size(168, 52)
        Me.CnclBilling.TabIndex = 128
        Me.CnclBilling.TabStop = False
        Me.CnclBilling.Text = "Cancel Bill"
        '
        'SubTot
        '
        Me.SubTot.BackColor = System.Drawing.Color.White
        Me.SubTot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SubTot.Location = New System.Drawing.Point(837, 450)
        Me.SubTot.Name = "SubTot"
        Me.SubTot.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SubTot.Size = New System.Drawing.Size(135, 20)
        Me.SubTot.TabIndex = 129
        Me.SubTot.Text = "0000000"
        Me.SubTot.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GTot
        '
        Me.GTot.BackColor = System.Drawing.Color.White
        Me.GTot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GTot.Location = New System.Drawing.Point(837, 517)
        Me.GTot.Name = "GTot"
        Me.GTot.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GTot.Size = New System.Drawing.Size(135, 20)
        Me.GTot.TabIndex = 130
        Me.GTot.Text = "0000000"
        Me.GTot.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.NavPanel.Size = New System.Drawing.Size(260, 602)
        Me.NavPanel.TabIndex = 131
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
        Me.toBillMaker.Enabled = False
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
        'Bill_Maker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 602)
        Me.Controls.Add(Me.NavPanel)
        Me.Controls.Add(Me.GTot)
        Me.Controls.Add(Me.SubTot)
        Me.Controls.Add(Me.CnclBilling)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ContDisplay)
        Me.Controls.Add(Me.PrntBill)
        Me.Controls.Add(Me.NmeDisplay)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.biller)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Disc)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Cust_manager)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Name = "Bill_Maker"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        CType(Me.Digibill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Cust_manager.ResumeLayout(False)
        Me.Cust_manager.PerformLayout()
        CType(Me.Itm_qty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.biller.ResumeLayout(False)
        Me.biller.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavPanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Digibill As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Disc As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents IsNewCST As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Cust_manager As Panel
    Friend WithEvents PrntBill As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Ins_Itm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Itm_ttl As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Itm_nme As TextBox
    Friend WithEvents Itm_qty As NumericUpDown
    Friend WithEvents Itm_cst As TextBox
    Friend WithEvents Itm_code As ComboBox
    Friend WithEvents DateTo As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents DateFrom As DateTimePicker
    Friend WithEvents Custname As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents biller As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents NmeDisplay As Label
    Friend WithEvents ContDisplay As Label
    Friend WithEvents CstOpBal As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents Pay_now As CheckBox
    Friend WithEvents From_Bal As CheckBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents CnclBilling As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Custcontact As TextBox
    Friend WithEvents itm_Lst_idx As DataGridViewTextBoxColumn
    Friend WithEvents b_i_code As DataGridViewTextBoxColumn
    Friend WithEvents b_i_name As DataGridViewTextBoxColumn
    Friend WithEvents b_i_dur As DataGridViewTextBoxColumn
    Friend WithEvents b_i_qty As DataGridViewTextBoxColumn
    Friend WithEvents b_i_rate As DataGridViewTextBoxColumn
    Friend WithEvents SubTot As Label
    Friend WithEvents GTot As Label
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
