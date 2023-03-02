<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class purchase_master
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(purchase_master))
        Me.SupplierDetailsPanel = New System.Windows.Forms.Panel()
        Me.ven_GST = New System.Windows.Forms.TextBox()
        Me.ven_cont = New System.Windows.Forms.TextBox()
        Me.cred = New System.Windows.Forms.RadioButton()
        Me.deb = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.InvNo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ven_nme = New System.Windows.Forms.TextBox()
        Me.ven_addr = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.It_Pur_Cst = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.It_type = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Fin = New Guna.UI2.WinForms.Guna2Button()
        Me.Insert = New Guna.UI2.WinForms.Guna2Button()
        Me.It_rte = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.It_code = New System.Windows.Forms.TextBox()
        Me.It_nme = New System.Windows.Forms.TextBox()
        Me.It_qty = New System.Windows.Forms.NumericUpDown()
        Me.QtyActInfoLbl = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PurchaseSubTotLbl = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ItemDetails = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.it_Code_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.it_name_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.it_qty_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.it_pur_Cst_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseTotLbl = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PurchaseGST = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PurchaseTotQtyLbl = New System.Windows.Forms.Label()
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
        Me.SupplierDetailsPanel.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.It_qty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.ItemDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SupplierDetailsPanel
        '
        Me.SupplierDetailsPanel.Controls.Add(Me.ven_GST)
        Me.SupplierDetailsPanel.Controls.Add(Me.ven_cont)
        Me.SupplierDetailsPanel.Controls.Add(Me.cred)
        Me.SupplierDetailsPanel.Controls.Add(Me.deb)
        Me.SupplierDetailsPanel.Controls.Add(Me.Label12)
        Me.SupplierDetailsPanel.Controls.Add(Me.InvNo)
        Me.SupplierDetailsPanel.Controls.Add(Me.Label6)
        Me.SupplierDetailsPanel.Controls.Add(Me.ven_nme)
        Me.SupplierDetailsPanel.Controls.Add(Me.ven_addr)
        Me.SupplierDetailsPanel.Controls.Add(Me.Label4)
        Me.SupplierDetailsPanel.Controls.Add(Me.Label3)
        Me.SupplierDetailsPanel.Controls.Add(Me.Label2)
        Me.SupplierDetailsPanel.Controls.Add(Me.Label1)
        Me.SupplierDetailsPanel.Location = New System.Drawing.Point(261, 0)
        Me.SupplierDetailsPanel.Name = "SupplierDetailsPanel"
        Me.SupplierDetailsPanel.Size = New System.Drawing.Size(605, 345)
        Me.SupplierDetailsPanel.TabIndex = 9
        '
        'ven_GST
        '
        Me.ven_GST.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ven_GST.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ven_GST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ven_GST.Location = New System.Drawing.Point(322, 235)
        Me.ven_GST.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ven_GST.MaxLength = 15
        Me.ven_GST.Name = "ven_GST"
        Me.ven_GST.Size = New System.Drawing.Size(221, 26)
        Me.ven_GST.TabIndex = 4
        '
        'ven_cont
        '
        Me.ven_cont.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ven_cont.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ven_cont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ven_cont.Location = New System.Drawing.Point(322, 68)
        Me.ven_cont.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ven_cont.MaxLength = 10
        Me.ven_cont.Name = "ven_cont"
        Me.ven_cont.Size = New System.Drawing.Size(221, 26)
        Me.ven_cont.TabIndex = 1
        '
        'cred
        '
        Me.cred.AutoSize = True
        Me.cred.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cred.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.cred.Location = New System.Drawing.Point(322, 305)
        Me.cred.Name = "cred"
        Me.cred.Size = New System.Drawing.Size(77, 28)
        Me.cred.TabIndex = 6
        Me.cred.TabStop = True
        Me.cred.Text = "Credit"
        Me.cred.UseVisualStyleBackColor = True
        '
        'deb
        '
        Me.deb.AutoSize = True
        Me.deb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.deb.Location = New System.Drawing.Point(322, 274)
        Me.deb.Name = "deb"
        Me.deb.Size = New System.Drawing.Size(71, 28)
        Me.deb.TabIndex = 5
        Me.deb.TabStop = True
        Me.deb.Text = "Debit"
        Me.deb.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(49, 235)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(146, 24)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Vendor GST No"
        '
        'InvNo
        '
        Me.InvNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InvNo.Location = New System.Drawing.Point(322, 35)
        Me.InvNo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.InvNo.Name = "InvNo"
        Me.InvNo.Size = New System.Drawing.Size(221, 26)
        Me.InvNo.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(51, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(222, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Purchase Payment Mode"
        '
        'ven_nme
        '
        Me.ven_nme.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ven_nme.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ven_nme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ven_nme.Location = New System.Drawing.Point(322, 102)
        Me.ven_nme.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ven_nme.Name = "ven_nme"
        Me.ven_nme.Size = New System.Drawing.Size(221, 26)
        Me.ven_nme.TabIndex = 2
        '
        'ven_addr
        '
        Me.ven_addr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ven_addr.Location = New System.Drawing.Point(322, 137)
        Me.ven_addr.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ven_addr.Multiline = True
        Me.ven_addr.Name = "ven_addr"
        Me.ven_addr.Size = New System.Drawing.Size(221, 88)
        Me.ven_addr.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(49, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Vendor Contact no"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(49, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Vendor Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(49, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Vendor Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(49, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Invoice No."
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.It_Pur_Cst)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.It_type)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Fin)
        Me.Panel4.Controls.Add(Me.Insert)
        Me.Panel4.Controls.Add(Me.It_rte)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.It_code)
        Me.Panel4.Controls.Add(Me.It_nme)
        Me.Panel4.Controls.Add(Me.It_qty)
        Me.Panel4.Controls.Add(Me.QtyActInfoLbl)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Location = New System.Drawing.Point(261, 349)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(605, 339)
        Me.Panel4.TabIndex = 10
        '
        'It_Pur_Cst
        '
        Me.It_Pur_Cst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.It_Pur_Cst.Location = New System.Drawing.Point(322, 178)
        Me.It_Pur_Cst.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.It_Pur_Cst.Name = "It_Pur_Cst"
        Me.It_Pur_Cst.Size = New System.Drawing.Size(221, 26)
        Me.It_Pur_Cst.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(51, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(198, 24)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Purchase Cost Per Pc."
        '
        'It_type
        '
        Me.It_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.It_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.It_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.It_type.Location = New System.Drawing.Point(322, 97)
        Me.It_type.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.It_type.Name = "It_type"
        Me.It_type.Size = New System.Drawing.Size(221, 26)
        Me.It_type.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(49, 97)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 24)
        Me.Label14.TabIndex = 101
        Me.Label14.Text = "Item Type"
        '
        'Fin
        '
        Me.Fin.BorderColor = System.Drawing.Color.Transparent
        Me.Fin.BorderRadius = 20
        Me.Fin.BorderThickness = 2
        Me.Fin.CustomizableEdges.BottomRight = False
        Me.Fin.CustomizableEdges.TopLeft = False
        Me.Fin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Fin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Fin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Fin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Fin.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Fin.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Fin.ForeColor = System.Drawing.Color.White
        Me.Fin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Fin.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Fin.HoverState.FillColor = System.Drawing.Color.White
        Me.Fin.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Fin.Location = New System.Drawing.Point(377, 269)
        Me.Fin.Name = "Fin"
        Me.Fin.Size = New System.Drawing.Size(145, 45)
        Me.Fin.TabIndex = 99
        Me.Fin.TabStop = False
        Me.Fin.Text = "Print"
        '
        'Insert
        '
        Me.Insert.BorderColor = System.Drawing.Color.Transparent
        Me.Insert.BorderRadius = 20
        Me.Insert.BorderThickness = 2
        Me.Insert.CustomizableEdges.BottomRight = False
        Me.Insert.CustomizableEdges.TopLeft = False
        Me.Insert.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Insert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Insert.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Insert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Insert.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Insert.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Insert.ForeColor = System.Drawing.Color.White
        Me.Insert.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Insert.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Insert.HoverState.FillColor = System.Drawing.Color.White
        Me.Insert.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Insert.Location = New System.Drawing.Point(55, 269)
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(145, 45)
        Me.Insert.TabIndex = 13
        Me.Insert.Text = "Insert"
        '
        'It_rte
        '
        Me.It_rte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.It_rte.Location = New System.Drawing.Point(322, 221)
        Me.It_rte.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.It_rte.Name = "It_rte"
        Me.It_rte.Size = New System.Drawing.Size(221, 26)
        Me.It_rte.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(51, 221)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 24)
        Me.Label10.TabIndex = 98
        Me.Label10.Text = "Rental Rate"
        '
        'It_code
        '
        Me.It_code.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.It_code.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.It_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.It_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.It_code.Location = New System.Drawing.Point(322, 19)
        Me.It_code.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.It_code.Name = "It_code"
        Me.It_code.Size = New System.Drawing.Size(221, 26)
        Me.It_code.TabIndex = 7
        '
        'It_nme
        '
        Me.It_nme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.It_nme.Location = New System.Drawing.Point(322, 58)
        Me.It_nme.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.It_nme.Name = "It_nme"
        Me.It_nme.Size = New System.Drawing.Size(221, 26)
        Me.It_nme.TabIndex = 8
        '
        'It_qty
        '
        Me.It_qty.Location = New System.Drawing.Point(322, 136)
        Me.It_qty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.It_qty.Name = "It_qty"
        Me.It_qty.Size = New System.Drawing.Size(71, 26)
        Me.It_qty.TabIndex = 10
        Me.It_qty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'QtyActInfoLbl
        '
        Me.QtyActInfoLbl.AutoSize = True
        Me.QtyActInfoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtyActInfoLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.QtyActInfoLbl.Location = New System.Drawing.Point(51, 136)
        Me.QtyActInfoLbl.Name = "QtyActInfoLbl"
        Me.QtyActInfoLbl.Size = New System.Drawing.Size(78, 24)
        Me.QtyActInfoLbl.TabIndex = 94
        Me.QtyActInfoLbl.Text = "Quantity"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(47, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 24)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "Item Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(47, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 24)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "Item Code"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label11.Location = New System.Drawing.Point(872, 586)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 26)
        Me.Label11.TabIndex = 95
        Me.Label11.Text = "Subtotal"
        '
        'PurchaseSubTotLbl
        '
        Me.PurchaseSubTotLbl.AutoSize = True
        Me.PurchaseSubTotLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.PurchaseSubTotLbl.Location = New System.Drawing.Point(1214, 586)
        Me.PurchaseSubTotLbl.Name = "PurchaseSubTotLbl"
        Me.PurchaseSubTotLbl.Size = New System.Drawing.Size(24, 26)
        Me.PurchaseSubTotLbl.TabIndex = 96
        Me.PurchaseSubTotLbl.Text = "0"
        Me.PurchaseSubTotLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.ItemDetails)
        Me.Panel3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Location = New System.Drawing.Point(873, 10)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(474, 541)
        Me.Panel3.TabIndex = 8
        '
        'ItemDetails
        '
        Me.ItemDetails.AllowUserToAddRows = False
        Me.ItemDetails.AllowUserToDeleteRows = False
        Me.ItemDetails.AllowUserToResizeColumns = False
        Me.ItemDetails.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ItemDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ItemDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ItemDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.it_Code_col, Me.it_name_col, Me.it_qty_col, Me.it_pur_Cst_col})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ItemDetails.DefaultCellStyle = DataGridViewCellStyle3
        Me.ItemDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemDetails.GridColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ItemDetails.Location = New System.Drawing.Point(0, 0)
        Me.ItemDetails.MultiSelect = False
        Me.ItemDetails.Name = "ItemDetails"
        Me.ItemDetails.ReadOnly = True
        Me.ItemDetails.RowHeadersVisible = False
        Me.ItemDetails.RowTemplate.ReadOnly = True
        Me.ItemDetails.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ItemDetails.Size = New System.Drawing.Size(472, 539)
        Me.ItemDetails.TabIndex = 47
        Me.ItemDetails.TabStop = False
        Me.ItemDetails.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin
        Me.ItemDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ItemDetails.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.ItemDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.ItemDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.ItemDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.ItemDetails.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.ItemDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ItemDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ItemDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ItemDetails.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.ItemDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.ItemDetails.ThemeStyle.HeaderStyle.Height = 23
        Me.ItemDetails.ThemeStyle.ReadOnly = True
        Me.ItemDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ItemDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ItemDetails.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ItemDetails.ThemeStyle.RowsStyle.Height = 22
        Me.ItemDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ItemDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'it_Code_col
        '
        Me.it_Code_col.HeaderText = "Item Code"
        Me.it_Code_col.Name = "it_Code_col"
        Me.it_Code_col.ReadOnly = True
        '
        'it_name_col
        '
        Me.it_name_col.FillWeight = 203.0457!
        Me.it_name_col.HeaderText = "Name"
        Me.it_name_col.Name = "it_name_col"
        Me.it_name_col.ReadOnly = True
        '
        'it_qty_col
        '
        Me.it_qty_col.FillWeight = 65.65144!
        Me.it_qty_col.HeaderText = "Qty."
        Me.it_qty_col.Name = "it_qty_col"
        Me.it_qty_col.ReadOnly = True
        '
        'it_pur_Cst_col
        '
        Me.it_pur_Cst_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.it_pur_Cst_col.HeaderText = "Purchase Cost Per pc."
        Me.it_pur_Cst_col.Name = "it_pur_Cst_col"
        Me.it_pur_Cst_col.ReadOnly = True
        Me.it_pur_Cst_col.Width = 136
        '
        'PurchaseTotLbl
        '
        Me.PurchaseTotLbl.AutoSize = True
        Me.PurchaseTotLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.PurchaseTotLbl.Location = New System.Drawing.Point(1214, 653)
        Me.PurchaseTotLbl.Name = "PurchaseTotLbl"
        Me.PurchaseTotLbl.Size = New System.Drawing.Size(24, 26)
        Me.PurchaseTotLbl.TabIndex = 99
        Me.PurchaseTotLbl.Text = "0"
        Me.PurchaseTotLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label13.Location = New System.Drawing.Point(872, 653)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(122, 26)
        Me.Label13.TabIndex = 98
        Me.Label13.Text = "Total Spent"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label9.Location = New System.Drawing.Point(872, 617)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 26)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "Tax"
        '
        'PurchaseGST
        '
        Me.PurchaseGST.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PurchaseGST.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.PurchaseGST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PurchaseGST.Location = New System.Drawing.Point(1219, 619)
        Me.PurchaseGST.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PurchaseGST.MaxLength = 18
        Me.PurchaseGST.Name = "PurchaseGST"
        Me.PurchaseGST.Size = New System.Drawing.Size(43, 26)
        Me.PurchaseGST.TabIndex = 101
        Me.PurchaseGST.TabStop = False
        Me.PurchaseGST.Text = "18"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label15.Location = New System.Drawing.Point(1262, 619)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 26)
        Me.Label15.TabIndex = 102
        Me.Label15.Text = "%"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label16.Location = New System.Drawing.Point(872, 554)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(146, 26)
        Me.Label16.TabIndex = 103
        Me.Label16.Text = "Total Quantity"
        '
        'PurchaseTotQtyLbl
        '
        Me.PurchaseTotQtyLbl.AutoSize = True
        Me.PurchaseTotQtyLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.PurchaseTotQtyLbl.Location = New System.Drawing.Point(1214, 554)
        Me.PurchaseTotQtyLbl.Name = "PurchaseTotQtyLbl"
        Me.PurchaseTotQtyLbl.Size = New System.Drawing.Size(24, 26)
        Me.PurchaseTotQtyLbl.TabIndex = 104
        Me.PurchaseTotQtyLbl.Text = "0"
        Me.PurchaseTotQtyLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.NavPanel.Size = New System.Drawing.Size(260, 688)
        Me.NavPanel.TabIndex = 105
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
        Me.toStockPurchase.Enabled = False
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
        'purchase_master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1358, 688)
        Me.Controls.Add(Me.NavPanel)
        Me.Controls.Add(Me.PurchaseTotQtyLbl)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.PurchaseGST)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PurchaseTotLbl)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PurchaseSubTotLbl)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.SupplierDetailsPanel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "purchase_master"
        Me.ShowIcon = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SupplierDetailsPanel.ResumeLayout(False)
        Me.SupplierDetailsPanel.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.It_qty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.ItemDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavPanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PurchaseSubTotLbl As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Fin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Insert As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents It_rte As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents It_code As TextBox
    Friend WithEvents It_nme As TextBox
    Friend WithEvents It_qty As NumericUpDown
    Friend WithEvents QtyActInfoLbl As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents SupplierDetailsPanel As Panel
    Friend WithEvents cred As RadioButton
    Friend WithEvents deb As RadioButton
    Friend WithEvents Label12 As Label
    Friend WithEvents InvNo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ven_nme As TextBox
    Friend WithEvents ven_addr As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ItemDetails As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents It_type As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ven_cont As TextBox
    Friend WithEvents It_Pur_Cst As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PurchaseTotLbl As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ven_GST As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PurchaseGST As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PurchaseTotQtyLbl As Label
    Friend WithEvents it_Code_col As DataGridViewTextBoxColumn
    Friend WithEvents it_name_col As DataGridViewTextBoxColumn
    Friend WithEvents it_qty_col As DataGridViewTextBoxColumn
    Friend WithEvents it_pur_Cst_col As DataGridViewTextBoxColumn
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
