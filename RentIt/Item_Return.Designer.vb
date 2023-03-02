<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Item_Return
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Item_Return))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OverList = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Rented_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CstNme = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custContact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rented_iCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rented_Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rented_ret_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Overdcount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RentedList = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.rId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ccont = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iret = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SrchBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.reportPanel = New System.Windows.Forms.Panel()
        Me.DteOn = New System.Windows.Forms.DateTimePicker()
        Me.HisLbl2 = New System.Windows.Forms.Label()
        Me.Srchtxt = New System.Windows.Forms.TextBox()
        Me.SrchCat = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.Panel1.SuspendLayout()
        CType(Me.OverList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.RentedList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.reportPanel.SuspendLayout()
        Me.NavPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.OverList)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(318, 158)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(725, 229)
        Me.Panel1.TabIndex = 132
        '
        'OverList
        '
        Me.OverList.AllowUserToAddRows = False
        Me.OverList.AllowUserToDeleteRows = False
        Me.OverList.AllowUserToResizeColumns = False
        Me.OverList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.OverList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OverList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.OverList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Rented_id, Me.CstNme, Me.custContact, Me.Rented_iCode, Me.Rented_Qty, Me.Rented_ret_date, Me.Overdcount})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.OverList.DefaultCellStyle = DataGridViewCellStyle3
        Me.OverList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OverList.GridColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.OverList.Location = New System.Drawing.Point(0, 0)
        Me.OverList.MultiSelect = False
        Me.OverList.Name = "OverList"
        Me.OverList.ReadOnly = True
        Me.OverList.RowHeadersVisible = False
        Me.OverList.RowTemplate.ReadOnly = True
        Me.OverList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.OverList.Size = New System.Drawing.Size(723, 227)
        Me.OverList.TabIndex = 47
        Me.OverList.TabStop = False
        Me.OverList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin
        Me.OverList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.OverList.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.OverList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.OverList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.OverList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.OverList.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.OverList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.OverList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.OverList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.OverList.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OverList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.OverList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.OverList.ThemeStyle.HeaderStyle.Height = 23
        Me.OverList.ThemeStyle.ReadOnly = True
        Me.OverList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.OverList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.OverList.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OverList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.OverList.ThemeStyle.RowsStyle.Height = 22
        Me.OverList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.OverList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Rented_id
        '
        Me.Rented_id.DataPropertyName = "id"
        Me.Rented_id.HeaderText = "ID"
        Me.Rented_id.Name = "Rented_id"
        Me.Rented_id.ReadOnly = True
        Me.Rented_id.Visible = False
        '
        'CstNme
        '
        Me.CstNme.DataPropertyName = "cst_nme"
        Me.CstNme.FillWeight = 46.90355!
        Me.CstNme.HeaderText = "Customer Name"
        Me.CstNme.Name = "CstNme"
        Me.CstNme.ReadOnly = True
        '
        'custContact
        '
        Me.custContact.DataPropertyName = "Cst_cont"
        Me.custContact.FillWeight = 45.71109!
        Me.custContact.HeaderText = "Contact info"
        Me.custContact.Name = "custContact"
        Me.custContact.ReadOnly = True
        '
        'Rented_iCode
        '
        Me.Rented_iCode.DataPropertyName = "i_code"
        Me.Rented_iCode.FillWeight = 45.71109!
        Me.Rented_iCode.HeaderText = "Item Code"
        Me.Rented_iCode.Name = "Rented_iCode"
        Me.Rented_iCode.ReadOnly = True
        '
        'Rented_Qty
        '
        Me.Rented_Qty.DataPropertyName = "i_qty"
        Me.Rented_Qty.FillWeight = 41.13998!
        Me.Rented_Qty.HeaderText = "Qty."
        Me.Rented_Qty.Name = "Rented_Qty"
        Me.Rented_Qty.ReadOnly = True
        '
        'Rented_ret_date
        '
        Me.Rented_ret_date.DataPropertyName = "i_ret_dte"
        Me.Rented_ret_date.FillWeight = 45.71109!
        Me.Rented_ret_date.HeaderText = "Return date"
        Me.Rented_ret_date.Name = "Rented_ret_date"
        Me.Rented_ret_date.ReadOnly = True
        '
        'Overdcount
        '
        Me.Overdcount.FillWeight = 45.71109!
        Me.Overdcount.HeaderText = "Overdue for"
        Me.Overdcount.Name = "Overdcount"
        Me.Overdcount.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.RentedList)
        Me.Panel3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Location = New System.Drawing.Point(318, 431)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(725, 258)
        Me.Panel3.TabIndex = 133
        '
        'RentedList
        '
        Me.RentedList.AllowUserToAddRows = False
        Me.RentedList.AllowUserToDeleteRows = False
        Me.RentedList.AllowUserToResizeColumns = False
        Me.RentedList.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.RentedList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RentedList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.RentedList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.rId, Me.Cname, Me.Ccont, Me.iCode, Me.iQty, Me.iret})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RentedList.DefaultCellStyle = DataGridViewCellStyle6
        Me.RentedList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RentedList.GridColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.RentedList.Location = New System.Drawing.Point(0, 0)
        Me.RentedList.MultiSelect = False
        Me.RentedList.Name = "RentedList"
        Me.RentedList.ReadOnly = True
        Me.RentedList.RowHeadersVisible = False
        Me.RentedList.RowTemplate.ReadOnly = True
        Me.RentedList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RentedList.Size = New System.Drawing.Size(723, 256)
        Me.RentedList.TabIndex = 47
        Me.RentedList.TabStop = False
        Me.RentedList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin
        Me.RentedList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.RentedList.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.RentedList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.RentedList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.RentedList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.RentedList.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.RentedList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.RentedList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.RentedList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.RentedList.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RentedList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.RentedList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.RentedList.ThemeStyle.HeaderStyle.Height = 23
        Me.RentedList.ThemeStyle.ReadOnly = True
        Me.RentedList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.RentedList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.RentedList.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RentedList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RentedList.ThemeStyle.RowsStyle.Height = 22
        Me.RentedList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.RentedList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'rId
        '
        Me.rId.DataPropertyName = "id"
        Me.rId.HeaderText = "ID"
        Me.rId.Name = "rId"
        Me.rId.ReadOnly = True
        Me.rId.Visible = False
        '
        'Cname
        '
        Me.Cname.DataPropertyName = "cst_nme"
        Me.Cname.FillWeight = 46.90355!
        Me.Cname.HeaderText = "Customer Name"
        Me.Cname.Name = "Cname"
        Me.Cname.ReadOnly = True
        '
        'Ccont
        '
        Me.Ccont.DataPropertyName = "cst_cont"
        Me.Ccont.FillWeight = 46.90355!
        Me.Ccont.HeaderText = "Contact info"
        Me.Ccont.Name = "Ccont"
        Me.Ccont.ReadOnly = True
        '
        'iCode
        '
        Me.iCode.DataPropertyName = "i_code"
        Me.iCode.FillWeight = 46.90355!
        Me.iCode.HeaderText = "Item Code"
        Me.iCode.Name = "iCode"
        Me.iCode.ReadOnly = True
        '
        'iQty
        '
        Me.iQty.DataPropertyName = "i_qty"
        Me.iQty.FillWeight = 46.90355!
        Me.iQty.HeaderText = "Qty."
        Me.iQty.Name = "iQty"
        Me.iQty.ReadOnly = True
        '
        'iret
        '
        Me.iret.DataPropertyName = "i_ret_dte"
        Me.iret.FillWeight = 46.90355!
        Me.iret.HeaderText = "Return date"
        Me.iret.Name = "iret"
        Me.iret.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 25.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(319, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 39)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "Due date passed"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 25.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(319, 390)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(310, 39)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "Due date yet to arrive"
        '
        'SrchBtn
        '
        Me.SrchBtn.BorderColor = System.Drawing.Color.Transparent
        Me.SrchBtn.BorderRadius = 20
        Me.SrchBtn.BorderThickness = 2
        Me.SrchBtn.CustomizableEdges.BottomRight = False
        Me.SrchBtn.CustomizableEdges.TopLeft = False
        Me.SrchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.SrchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.SrchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.SrchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SrchBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SrchBtn.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.SrchBtn.ForeColor = System.Drawing.Color.White
        Me.SrchBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SrchBtn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SrchBtn.HoverState.FillColor = System.Drawing.Color.White
        Me.SrchBtn.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SrchBtn.Location = New System.Drawing.Point(745, 56)
        Me.SrchBtn.Name = "SrchBtn"
        Me.SrchBtn.Size = New System.Drawing.Size(137, 45)
        Me.SrchBtn.TabIndex = 143
        Me.SrchBtn.TabStop = False
        Me.SrchBtn.Text = "Search"
        '
        'reportPanel
        '
        Me.reportPanel.Controls.Add(Me.DteOn)
        Me.reportPanel.Controls.Add(Me.HisLbl2)
        Me.reportPanel.Enabled = False
        Me.reportPanel.Location = New System.Drawing.Point(314, 55)
        Me.reportPanel.Name = "reportPanel"
        Me.reportPanel.Size = New System.Drawing.Size(348, 50)
        Me.reportPanel.TabIndex = 148
        '
        'DteOn
        '
        Me.DteOn.Location = New System.Drawing.Point(123, 10)
        Me.DteOn.Name = "DteOn"
        Me.DteOn.Size = New System.Drawing.Size(215, 30)
        Me.DteOn.TabIndex = 118
        '
        'HisLbl2
        '
        Me.HisLbl2.AutoSize = True
        Me.HisLbl2.BackColor = System.Drawing.Color.White
        Me.HisLbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.HisLbl2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.HisLbl2.Location = New System.Drawing.Point(7, 13)
        Me.HisLbl2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HisLbl2.Name = "HisLbl2"
        Me.HisLbl2.Size = New System.Drawing.Size(91, 25)
        Me.HisLbl2.TabIndex = 114
        Me.HisLbl2.Text = "On Date:"
        Me.HisLbl2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Srchtxt
        '
        Me.Srchtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Srchtxt.Location = New System.Drawing.Point(745, 16)
        Me.Srchtxt.Name = "Srchtxt"
        Me.Srchtxt.Size = New System.Drawing.Size(219, 30)
        Me.Srchtxt.TabIndex = 147
        '
        'SrchCat
        '
        Me.SrchCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SrchCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.SrchCat.FormattingEnabled = True
        Me.SrchCat.Items.AddRange(New Object() {"Customer Contact", "Return date", "Item Code", "Bill No.", "All Items"})
        Me.SrchCat.Location = New System.Drawing.Point(437, 16)
        Me.SrchCat.Name = "SrchCat"
        Me.SrchCat.Size = New System.Drawing.Size(215, 33)
        Me.SrchCat.TabIndex = 146
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(658, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 25)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "Search:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(321, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 25)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "Search by:"
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
        Me.NavPanel.Size = New System.Drawing.Size(260, 701)
        Me.NavPanel.TabIndex = 149
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
        Me.toItemReturn.Enabled = False
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
        'Item_Return
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1370, 701)
        Me.Controls.Add(Me.NavPanel)
        Me.Controls.Add(Me.SrchBtn)
        Me.Controls.Add(Me.reportPanel)
        Me.Controls.Add(Me.Srchtxt)
        Me.Controls.Add(Me.SrchCat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 15.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Item_Return"
        Me.ShowIcon = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.OverList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.RentedList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.reportPanel.ResumeLayout(False)
        Me.reportPanel.PerformLayout()
        Me.NavPanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents OverList As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents RentedList As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SrchBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents reportPanel As Panel
    Friend WithEvents DteOn As DateTimePicker
    Friend WithEvents HisLbl2 As Label
    Friend WithEvents Srchtxt As TextBox
    Friend WithEvents SrchCat As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents rId As DataGridViewTextBoxColumn
    Friend WithEvents Cname As DataGridViewTextBoxColumn
    Friend WithEvents Ccont As DataGridViewTextBoxColumn
    Friend WithEvents iCode As DataGridViewTextBoxColumn
    Friend WithEvents iQty As DataGridViewTextBoxColumn
    Friend WithEvents iret As DataGridViewTextBoxColumn
    Friend WithEvents Rented_id As DataGridViewTextBoxColumn
    Friend WithEvents CstNme As DataGridViewTextBoxColumn
    Friend WithEvents custContact As DataGridViewTextBoxColumn
    Friend WithEvents Rented_iCode As DataGridViewTextBoxColumn
    Friend WithEvents Rented_Qty As DataGridViewTextBoxColumn
    Friend WithEvents Rented_ret_date As DataGridViewTextBoxColumn
    Friend WithEvents Overdcount As DataGridViewTextBoxColumn
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
