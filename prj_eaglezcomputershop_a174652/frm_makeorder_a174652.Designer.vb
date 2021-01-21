<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_makeorder_a174652
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_makeorder_a174652))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lb_product_items = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cb_staff = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_order_id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_customer = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.grid_cart = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_product_stock = New System.Windows.Forms.Label()
        Me.lbl_product_year = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_product_brand = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_product_name = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_product_id = New System.Windows.Forms.Label()
        Me.lbl_product_price = New System.Windows.Forms.Label()
        Me.pic_product_picture = New System.Windows.Forms.PictureBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_cart_total = New System.Windows.Forms.Label()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.box_quantity = New System.Windows.Forms.NumericUpDown()
        Me.btn_add_cart = New System.Windows.Forms.Button()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_subtotal = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grid_cart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.pic_product_picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.box_quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lb_product_items)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 168)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(226, 341)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose Item"
        '
        'lb_product_items
        '
        Me.lb_product_items.Cursor = System.Windows.Forms.Cursors.Default
        Me.lb_product_items.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb_product_items.FormattingEnabled = True
        Me.lb_product_items.Location = New System.Drawing.Point(3, 16)
        Me.lb_product_items.Name = "lb_product_items"
        Me.lb_product_items.Size = New System.Drawing.Size(220, 322)
        Me.lb_product_items.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cb_staff)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.tb_order_id)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cb_customer)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(226, 150)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Information"
        '
        'cb_staff
        '
        Me.cb_staff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_staff.FormattingEnabled = True
        Me.cb_staff.Location = New System.Drawing.Point(72, 91)
        Me.cb_staff.Name = "cb_staff"
        Me.cb_staff.Size = New System.Drawing.Size(130, 21)
        Me.cb_staff.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Staff"
        '
        'tb_order_id
        '
        Me.tb_order_id.Enabled = False
        Me.tb_order_id.Location = New System.Drawing.Point(72, 19)
        Me.tb_order_id.Name = "tb_order_id"
        Me.tb_order_id.ReadOnly = True
        Me.tb_order_id.Size = New System.Drawing.Size(130, 20)
        Me.tb_order_id.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Order ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer"
        '
        'cb_customer
        '
        Me.cb_customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_customer.FormattingEnabled = True
        Me.cb_customer.Location = New System.Drawing.Point(72, 54)
        Me.cb_customer.Name = "cb_customer"
        Me.cb_customer.Size = New System.Drawing.Size(130, 21)
        Me.cb_customer.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btn_delete)
        Me.GroupBox3.Controls.Add(Me.grid_cart)
        Me.GroupBox3.Location = New System.Drawing.Point(600, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(292, 358)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cart"
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(109, 308)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 36)
        Me.btn_delete.TabIndex = 1
        Me.btn_delete.Text = "Delete Item"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'grid_cart
        '
        Me.grid_cart.AllowUserToAddRows = False
        Me.grid_cart.AllowUserToDeleteRows = False
        Me.grid_cart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_cart.Location = New System.Drawing.Point(6, 19)
        Me.grid_cart.MultiSelect = False
        Me.grid_cart.Name = "grid_cart"
        Me.grid_cart.ReadOnly = True
        Me.grid_cart.RowHeadersVisible = False
        Me.grid_cart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_cart.Size = New System.Drawing.Size(280, 283)
        Me.grid_cart.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox4.Controls.Add(Me.lbl_product_price)
        Me.GroupBox4.Controls.Add(Me.pic_product_picture)
        Me.GroupBox4.Location = New System.Drawing.Point(244, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(350, 385)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Product Information"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.01163!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.98837!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_product_stock, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_product_year, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_product_brand, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_product_name, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_product_id, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 162)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.03175!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.96825!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(344, 220)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 182)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 38)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Product Stock"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_product_stock
        '
        Me.lbl_product_stock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_product_stock.Location = New System.Drawing.Point(120, 182)
        Me.lbl_product_stock.Name = "lbl_product_stock"
        Me.lbl_product_stock.Size = New System.Drawing.Size(221, 38)
        Me.lbl_product_stock.TabIndex = 8
        Me.lbl_product_stock.Text = "0"
        Me.lbl_product_stock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_product_year
        '
        Me.lbl_product_year.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_product_year.Location = New System.Drawing.Point(120, 142)
        Me.lbl_product_year.Name = "lbl_product_year"
        Me.lbl_product_year.Size = New System.Drawing.Size(221, 40)
        Me.lbl_product_year.TabIndex = 7
        Me.lbl_product_year.Text = "Unknown"
        Me.lbl_product_year.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 40)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Product Mfg. Year"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_product_brand
        '
        Me.lbl_product_brand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_product_brand.Location = New System.Drawing.Point(120, 95)
        Me.lbl_product_brand.Name = "lbl_product_brand"
        Me.lbl_product_brand.Size = New System.Drawing.Size(221, 47)
        Me.lbl_product_brand.TabIndex = 5
        Me.lbl_product_brand.Text = "Unknown"
        Me.lbl_product_brand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 47)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Product Brand - Socket"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_product_name
        '
        Me.lbl_product_name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_product_name.Location = New System.Drawing.Point(120, 44)
        Me.lbl_product_name.Name = "lbl_product_name"
        Me.lbl_product_name.Size = New System.Drawing.Size(221, 51)
        Me.lbl_product_name.TabIndex = 3
        Me.lbl_product_name.Text = "Unknown"
        Me.lbl_product_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 51)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Product Name"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 44)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Product ID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_product_id
        '
        Me.lbl_product_id.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_product_id.Location = New System.Drawing.Point(120, 0)
        Me.lbl_product_id.Name = "lbl_product_id"
        Me.lbl_product_id.Size = New System.Drawing.Size(221, 44)
        Me.lbl_product_id.TabIndex = 1
        Me.lbl_product_id.Text = "Unknown"
        Me.lbl_product_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_product_price
        '
        Me.lbl_product_price.AutoSize = True
        Me.lbl_product_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_product_price.Location = New System.Drawing.Point(136, 122)
        Me.lbl_product_price.Name = "lbl_product_price"
        Me.lbl_product_price.Size = New System.Drawing.Size(79, 24)
        Me.lbl_product_price.TabIndex = 13
        Me.lbl_product_price.Text = "RM 0.00"
        '
        'pic_product_picture
        '
        Me.pic_product_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pic_product_picture.Image = Global.EagleZ_Computer_Shop.My.Resources.Resources.no_photo
        Me.pic_product_picture.Location = New System.Drawing.Point(125, 19)
        Me.pic_product_picture.Name = "pic_product_picture"
        Me.pic_product_picture.Size = New System.Drawing.Size(100, 100)
        Me.pic_product_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_product_picture.TabIndex = 0
        Me.pic_product_picture.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox6.Location = New System.Drawing.Point(600, 376)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(292, 133)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "GroupBox6"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_cart_total, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_confirm, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(286, 114)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 55)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_cart_total
        '
        Me.lbl_cart_total.AutoSize = True
        Me.lbl_cart_total.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_cart_total.Location = New System.Drawing.Point(146, 0)
        Me.lbl_cart_total.Name = "lbl_cart_total"
        Me.lbl_cart_total.Size = New System.Drawing.Size(137, 55)
        Me.lbl_cart_total.TabIndex = 1
        Me.lbl_cart_total.Text = "RM 0.00"
        Me.lbl_cart_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_confirm
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.btn_confirm, 2)
        Me.btn_confirm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_confirm.Enabled = False
        Me.btn_confirm.Location = New System.Drawing.Point(3, 58)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(280, 53)
        Me.btn_confirm.TabIndex = 3
        Me.btn_confirm.Text = "Confirm"
        Me.btn_confirm.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox5.Location = New System.Drawing.Point(244, 403)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(350, 106)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "GroupBox5"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.63953!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.36047!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel5, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(344, 87)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.box_quantity, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.btn_add_cart, 0, 2)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.10345!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.89655!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(150, 81)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 1)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 18)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Quantity"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'box_quantity
        '
        Me.box_quantity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.box_quantity.Location = New System.Drawing.Point(4, 23)
        Me.box_quantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.box_quantity.Name = "box_quantity"
        Me.box_quantity.Size = New System.Drawing.Size(142, 20)
        Me.box_quantity.TabIndex = 1
        Me.box_quantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btn_add_cart
        '
        Me.btn_add_cart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_add_cart.Location = New System.Drawing.Point(4, 48)
        Me.btn_add_cart.Name = "btn_add_cart"
        Me.btn_add_cart.Size = New System.Drawing.Size(142, 29)
        Me.btn_add_cart.TabIndex = 2
        Me.btn_add_cart.Text = "Add to Cart"
        Me.btn_add_cart.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label10, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.lbl_subtotal, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(159, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(182, 81)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(5, 2)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(172, 30)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "SUBTOTAL"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_subtotal
        '
        Me.lbl_subtotal.AutoSize = True
        Me.lbl_subtotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_subtotal.Location = New System.Drawing.Point(5, 34)
        Me.lbl_subtotal.Name = "lbl_subtotal"
        Me.lbl_subtotal.Size = New System.Drawing.Size(172, 45)
        Me.lbl_subtotal.TabIndex = 1
        Me.lbl_subtotal.Text = "RM 0.00"
        Me.lbl_subtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Bodoni MT", 24.0!)
        Me.Label13.Location = New System.Drawing.Point(27, 538)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(239, 38)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "MAKE ORDER"
        '
        'frm_makeorder_a174652
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EagleZ_Computer_Shop.My.Resources.Resources.bg_app2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(904, 671)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_makeorder_a174652"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EagleZ Computer Shop: Add Order"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.grid_cart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.pic_product_picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.box_quantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_customer As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_delete As Button
    Friend WithEvents grid_cart As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents pic_product_picture As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_product_year As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_product_brand As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_product_name As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_product_id As Label
    Friend WithEvents lbl_product_price As Label
    Friend WithEvents lb_product_items As ListBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_cart_total As Label
    Friend WithEvents btn_confirm As Button
    Friend WithEvents lbl_product_stock As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents box_quantity As NumericUpDown
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_subtotal As Label
    Friend WithEvents btn_add_cart As Button
    Friend WithEvents tb_order_id As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cb_staff As ComboBox
    Friend WithEvents Label13 As Label
End Class
