<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reports))
        Me.Guna2GroupBox3 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.P_vendor = New System.Windows.Forms.ComboBox()
        Me.P_sort = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.P_Dte_To = New System.Windows.Forms.DateTimePicker()
        Me.P_Dte_From = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PurchaseReport = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.S_cst = New System.Windows.Forms.ComboBox()
        Me.S_sort = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.S_biller = New System.Windows.Forms.ComboBox()
        Me.reportPanel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.S_Dte_To = New System.Windows.Forms.DateTimePicker()
        Me.S_Dte_From = New System.Windows.Forms.DateTimePicker()
        Me.HisLbl2 = New System.Windows.Forms.Label()
        Me.HisLbl3 = New System.Windows.Forms.Label()
        Me.SalesReport = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
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
        Me.Guna2GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.reportPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox3
        '
        Me.Guna2GroupBox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2GroupBox3.BorderRadius = 20
        Me.Guna2GroupBox3.Controls.Add(Me.Label11)
        Me.Guna2GroupBox3.Controls.Add(Me.P_vendor)
        Me.Guna2GroupBox3.Controls.Add(Me.P_sort)
        Me.Guna2GroupBox3.Controls.Add(Me.Label12)
        Me.Guna2GroupBox3.Controls.Add(Me.Panel1)
        Me.Guna2GroupBox3.Controls.Add(Me.PurchaseReport)
        Me.Guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2GroupBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Guna2GroupBox3.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox3.Location = New System.Drawing.Point(301, 340)
        Me.Guna2GroupBox3.Name = "Guna2GroupBox3"
        Me.Guna2GroupBox3.Size = New System.Drawing.Size(412, 291)
        Me.Guna2GroupBox3.TabIndex = 127
        Me.Guna2GroupBox3.Text = "Purchase Report"
        Me.Guna2GroupBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(46, 179)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 19)
        Me.Label11.TabIndex = 125
        Me.Label11.Text = "Grouped by:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'P_vendor
        '
        Me.P_vendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.P_vendor.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.P_vendor.FormattingEnabled = True
        Me.P_vendor.Location = New System.Drawing.Point(142, 144)
        Me.P_vendor.Name = "P_vendor"
        Me.P_vendor.Size = New System.Drawing.Size(208, 25)
        Me.P_vendor.TabIndex = 126
        '
        'P_sort
        '
        Me.P_sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.P_sort.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.P_sort.FormattingEnabled = True
        Me.P_sort.Items.AddRange(New Object() {"No Grouping", "Date", "Vendor"})
        Me.P_sort.Location = New System.Drawing.Point(142, 176)
        Me.P_sort.Name = "P_sort"
        Me.P_sort.Size = New System.Drawing.Size(208, 25)
        Me.P_sort.TabIndex = 124
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(46, 147)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 19)
        Me.Label12.TabIndex = 123
        Me.Label12.Text = "Vendor:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.P_Dte_To)
        Me.Panel1.Controls.Add(Me.P_Dte_From)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Panel1.Location = New System.Drawing.Point(39, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 93)
        Me.Panel1.TabIndex = 121
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(7, 5)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(113, 19)
        Me.Label14.TabIndex = 121
        Me.Label14.Text = "Bought Between:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'P_Dte_To
        '
        Me.P_Dte_To.Location = New System.Drawing.Point(103, 60)
        Me.P_Dte_To.Name = "P_Dte_To"
        Me.P_Dte_To.Size = New System.Drawing.Size(208, 25)
        Me.P_Dte_To.TabIndex = 119
        '
        'P_Dte_From
        '
        Me.P_Dte_From.Location = New System.Drawing.Point(103, 29)
        Me.P_Dte_From.Name = "P_Dte_From"
        Me.P_Dte_From.Size = New System.Drawing.Size(208, 25)
        Me.P_Dte_From.TabIndex = 118
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(7, 33)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 19)
        Me.Label15.TabIndex = 114
        Me.Label15.Text = "From Date:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(7, 65)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 19)
        Me.Label16.TabIndex = 115
        Me.Label16.Text = "To Date:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PurchaseReport
        '
        Me.PurchaseReport.BorderColor = System.Drawing.Color.Transparent
        Me.PurchaseReport.BorderRadius = 20
        Me.PurchaseReport.BorderThickness = 2
        Me.PurchaseReport.CustomizableEdges.BottomRight = False
        Me.PurchaseReport.CustomizableEdges.TopLeft = False
        Me.PurchaseReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.PurchaseReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.PurchaseReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.PurchaseReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.PurchaseReport.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.PurchaseReport.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.PurchaseReport.ForeColor = System.Drawing.Color.White
        Me.PurchaseReport.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.PurchaseReport.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.PurchaseReport.HoverState.FillColor = System.Drawing.Color.White
        Me.PurchaseReport.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.PurchaseReport.Location = New System.Drawing.Point(142, 235)
        Me.PurchaseReport.Name = "PurchaseReport"
        Me.PurchaseReport.Size = New System.Drawing.Size(208, 44)
        Me.PurchaseReport.TabIndex = 117
        Me.PurchaseReport.TabStop = False
        Me.PurchaseReport.Text = "Generate"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2GroupBox1.BorderRadius = 20
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.S_cst)
        Me.Guna2GroupBox1.Controls.Add(Me.S_sort)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.S_biller)
        Me.Guna2GroupBox1.Controls.Add(Me.reportPanel1)
        Me.Guna2GroupBox1.Controls.Add(Me.SalesReport)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(301, 27)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(412, 291)
        Me.Guna2GroupBox1.TabIndex = 122
        Me.Guna2GroupBox1.Text = "Sales Report"
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(46, 207)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 19)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "Grouped by:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'S_cst
        '
        Me.S_cst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_cst.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.S_cst.FormattingEnabled = True
        Me.S_cst.Location = New System.Drawing.Point(142, 172)
        Me.S_cst.Name = "S_cst"
        Me.S_cst.Size = New System.Drawing.Size(208, 25)
        Me.S_cst.TabIndex = 126
        '
        'S_sort
        '
        Me.S_sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_sort.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.S_sort.FormattingEnabled = True
        Me.S_sort.Items.AddRange(New Object() {"No Grouping", "Date", "Customer"})
        Me.S_sort.Location = New System.Drawing.Point(142, 204)
        Me.S_sort.Name = "S_sort"
        Me.S_sort.Size = New System.Drawing.Size(208, 25)
        Me.S_sort.TabIndex = 124
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(46, 175)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 19)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "Customer:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(46, 144)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 19)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Biller:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'S_biller
        '
        Me.S_biller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_biller.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.S_biller.FormattingEnabled = True
        Me.S_biller.Location = New System.Drawing.Point(142, 141)
        Me.S_biller.Name = "S_biller"
        Me.S_biller.Size = New System.Drawing.Size(208, 25)
        Me.S_biller.TabIndex = 122
        '
        'reportPanel1
        '
        Me.reportPanel1.Controls.Add(Me.Label2)
        Me.reportPanel1.Controls.Add(Me.S_Dte_To)
        Me.reportPanel1.Controls.Add(Me.S_Dte_From)
        Me.reportPanel1.Controls.Add(Me.HisLbl2)
        Me.reportPanel1.Controls.Add(Me.HisLbl3)
        Me.reportPanel1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.reportPanel1.Location = New System.Drawing.Point(39, 43)
        Me.reportPanel1.Name = "reportPanel1"
        Me.reportPanel1.Size = New System.Drawing.Size(325, 93)
        Me.reportPanel1.TabIndex = 121
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(7, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 19)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "Sold Between:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'S_Dte_To
        '
        Me.S_Dte_To.Location = New System.Drawing.Point(103, 60)
        Me.S_Dte_To.Name = "S_Dte_To"
        Me.S_Dte_To.Size = New System.Drawing.Size(208, 25)
        Me.S_Dte_To.TabIndex = 119
        '
        'S_Dte_From
        '
        Me.S_Dte_From.Location = New System.Drawing.Point(103, 29)
        Me.S_Dte_From.Name = "S_Dte_From"
        Me.S_Dte_From.Size = New System.Drawing.Size(208, 25)
        Me.S_Dte_From.TabIndex = 118
        '
        'HisLbl2
        '
        Me.HisLbl2.AutoSize = True
        Me.HisLbl2.BackColor = System.Drawing.Color.White
        Me.HisLbl2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.HisLbl2.Location = New System.Drawing.Point(7, 33)
        Me.HisLbl2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HisLbl2.Name = "HisLbl2"
        Me.HisLbl2.Size = New System.Drawing.Size(77, 19)
        Me.HisLbl2.TabIndex = 114
        Me.HisLbl2.Text = "From Date:"
        Me.HisLbl2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'HisLbl3
        '
        Me.HisLbl3.AutoSize = True
        Me.HisLbl3.BackColor = System.Drawing.Color.White
        Me.HisLbl3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.HisLbl3.Location = New System.Drawing.Point(7, 65)
        Me.HisLbl3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HisLbl3.Name = "HisLbl3"
        Me.HisLbl3.Size = New System.Drawing.Size(59, 19)
        Me.HisLbl3.TabIndex = 115
        Me.HisLbl3.Text = "To Date:"
        Me.HisLbl3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SalesReport
        '
        Me.SalesReport.BorderColor = System.Drawing.Color.Transparent
        Me.SalesReport.BorderRadius = 20
        Me.SalesReport.BorderThickness = 2
        Me.SalesReport.CustomizableEdges.BottomRight = False
        Me.SalesReport.CustomizableEdges.TopLeft = False
        Me.SalesReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.SalesReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.SalesReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.SalesReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SalesReport.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SalesReport.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.SalesReport.ForeColor = System.Drawing.Color.White
        Me.SalesReport.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SalesReport.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SalesReport.HoverState.FillColor = System.Drawing.Color.White
        Me.SalesReport.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SalesReport.Location = New System.Drawing.Point(142, 235)
        Me.SalesReport.Name = "SalesReport"
        Me.SalesReport.Size = New System.Drawing.Size(208, 44)
        Me.SalesReport.TabIndex = 117
        Me.SalesReport.TabStop = False
        Me.SalesReport.Text = "Generate"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(766, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(441, 662)
        Me.Panel2.TabIndex = 129
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.RentIt.My.Resources.Resources.navr_borderless
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(441, 662)
        Me.PictureBox2.TabIndex = 0
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
        Me.NavPanel.Size = New System.Drawing.Size(260, 662)
        Me.NavPanel.TabIndex = 130
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
        Me.toGenerateReport.Enabled = False
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
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1207, 662)
        Me.Controls.Add(Me.NavPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Guna2GroupBox3)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Reports"
        Me.ShowIcon = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2GroupBox3.ResumeLayout(False)
        Me.Guna2GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.reportPanel1.ResumeLayout(False)
        Me.reportPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavPanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents reportPanel1 As Panel
    Friend WithEvents S_Dte_To As DateTimePicker
    Friend WithEvents S_Dte_From As DateTimePicker
    Friend WithEvents HisLbl2 As Label
    Friend WithEvents HisLbl3 As Label
    Friend WithEvents SalesReport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents S_biller As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents S_sort As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents S_cst As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2GroupBox3 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents P_vendor As ComboBox
    Friend WithEvents P_sort As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents P_Dte_To As DateTimePicker
    Friend WithEvents P_Dte_From As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PurchaseReport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
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
