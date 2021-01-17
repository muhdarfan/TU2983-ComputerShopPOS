<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertproduct_a174652
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insertproduct_a174652))
        Me.grd_product = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_picture = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_year = New System.Windows.Forms.ComboBox()
        Me.txt_socket = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_brand_lbl = New System.Windows.Forms.Label()
        Me.txt_stock = New System.Windows.Forms.TextBox()
        Me.lbl_stock_title = New System.Windows.Forms.Label()
        Me.txt_year_lbl = New System.Windows.Forms.Label()
        Me.changePictureBtn = New System.Windows.Forms.Button()
        Me.productPicBox = New System.Windows.Forms.PictureBox()
        Me.addButton = New System.Windows.Forms.Button()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_price_lbl = New System.Windows.Forms.Label()
        Me.txt_name_lbl = New System.Windows.Forms.Label()
        Me.txt_id_label = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.productPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_product
        '
        Me.grd_product.AllowUserToAddRows = False
        Me.grd_product.AllowUserToDeleteRows = False
        Me.grd_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_product.Location = New System.Drawing.Point(11, 50)
        Me.grd_product.MultiSelect = False
        Me.grd_product.Name = "grd_product"
        Me.grd_product.ReadOnly = True
        Me.grd_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd_product.Size = New System.Drawing.Size(594, 452)
        Me.grd_product.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txt_picture)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_year)
        Me.GroupBox1.Controls.Add(Me.txt_socket)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_price)
        Me.GroupBox1.Controls.Add(Me.txt_brand_lbl)
        Me.GroupBox1.Controls.Add(Me.txt_stock)
        Me.GroupBox1.Controls.Add(Me.lbl_stock_title)
        Me.GroupBox1.Controls.Add(Me.txt_year_lbl)
        Me.GroupBox1.Controls.Add(Me.changePictureBtn)
        Me.GroupBox1.Controls.Add(Me.productPicBox)
        Me.GroupBox1.Controls.Add(Me.addButton)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.txt_brand)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Controls.Add(Me.txt_price_lbl)
        Me.GroupBox1.Controls.Add(Me.txt_name_lbl)
        Me.GroupBox1.Controls.Add(Me.txt_id_label)
        Me.GroupBox1.Location = New System.Drawing.Point(611, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(530, 452)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Insert"
        '
        'txt_picture
        '
        Me.txt_picture.BackColor = System.Drawing.SystemColors.Control
        Me.txt_picture.Location = New System.Drawing.Point(352, 263)
        Me.txt_picture.Name = "txt_picture"
        Me.txt_picture.ReadOnly = True
        Me.txt_picture.Size = New System.Drawing.Size(150, 20)
        Me.txt_picture.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(279, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 18)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Picture"
        '
        'txt_year
        '
        Me.txt_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_year.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txt_year.FormattingEnabled = True
        Me.txt_year.IntegralHeight = False
        Me.txt_year.ItemHeight = 13
        Me.txt_year.Location = New System.Drawing.Point(103, 368)
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(150, 21)
        Me.txt_year.TabIndex = 4
        '
        'txt_socket
        '
        Me.txt_socket.Location = New System.Drawing.Point(352, 333)
        Me.txt_socket.Name = "txt_socket"
        Me.txt_socket.Size = New System.Drawing.Size(150, 20)
        Me.txt_socket.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(279, 332)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Socket"
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(352, 298)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(150, 20)
        Me.txt_price.TabIndex = 5
        '
        'txt_brand_lbl
        '
        Me.txt_brand_lbl.AutoSize = True
        Me.txt_brand_lbl.BackColor = System.Drawing.Color.Transparent
        Me.txt_brand_lbl.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_brand_lbl.Location = New System.Drawing.Point(22, 332)
        Me.txt_brand_lbl.Name = "txt_brand_lbl"
        Me.txt_brand_lbl.Size = New System.Drawing.Size(55, 18)
        Me.txt_brand_lbl.TabIndex = 27
        Me.txt_brand_lbl.Text = "Brand"
        '
        'txt_stock
        '
        Me.txt_stock.Location = New System.Drawing.Point(352, 368)
        Me.txt_stock.Name = "txt_stock"
        Me.txt_stock.Size = New System.Drawing.Size(150, 20)
        Me.txt_stock.TabIndex = 7
        '
        'lbl_stock_title
        '
        Me.lbl_stock_title.AutoSize = True
        Me.lbl_stock_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_stock_title.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_stock_title.Location = New System.Drawing.Point(279, 367)
        Me.lbl_stock_title.Name = "lbl_stock_title"
        Me.lbl_stock_title.Size = New System.Drawing.Size(52, 18)
        Me.lbl_stock_title.TabIndex = 23
        Me.lbl_stock_title.Text = "Stock"
        '
        'txt_year_lbl
        '
        Me.txt_year_lbl.AutoSize = True
        Me.txt_year_lbl.BackColor = System.Drawing.Color.Transparent
        Me.txt_year_lbl.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_year_lbl.Location = New System.Drawing.Point(23, 367)
        Me.txt_year_lbl.Name = "txt_year_lbl"
        Me.txt_year_lbl.Size = New System.Drawing.Size(44, 18)
        Me.txt_year_lbl.TabIndex = 22
        Me.txt_year_lbl.Text = "Year"
        '
        'changePictureBtn
        '
        Me.changePictureBtn.Location = New System.Drawing.Point(231, 225)
        Me.changePictureBtn.Name = "changePictureBtn"
        Me.changePictureBtn.Size = New System.Drawing.Size(120, 23)
        Me.changePictureBtn.TabIndex = 1
        Me.changePictureBtn.Text = "Change Picture"
        Me.changePictureBtn.UseVisualStyleBackColor = True
        '
        'productPicBox
        '
        Me.productPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.productPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.productPicBox.Image = Global.EagleZ_Computer_Shop.My.Resources.Resources.no_photo
        Me.productPicBox.Location = New System.Drawing.Point(141, 19)
        Me.productPicBox.Name = "productPicBox"
        Me.productPicBox.Size = New System.Drawing.Size(300, 200)
        Me.productPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.productPicBox.TabIndex = 19
        Me.productPicBox.TabStop = False
        '
        'addButton
        '
        Me.addButton.BackColor = System.Drawing.Color.Transparent
        Me.addButton.Location = New System.Drawing.Point(191, 410)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(150, 36)
        Me.addButton.TabIndex = 8
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = False
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(103, 298)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(150, 20)
        Me.txt_name.TabIndex = 2
        '
        'txt_brand
        '
        Me.txt_brand.Location = New System.Drawing.Point(103, 333)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(150, 20)
        Me.txt_brand.TabIndex = 3
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(103, 263)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(150, 20)
        Me.txt_id.TabIndex = 15
        '
        'txt_price_lbl
        '
        Me.txt_price_lbl.AutoSize = True
        Me.txt_price_lbl.BackColor = System.Drawing.Color.Transparent
        Me.txt_price_lbl.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price_lbl.Location = New System.Drawing.Point(279, 297)
        Me.txt_price_lbl.Name = "txt_price_lbl"
        Me.txt_price_lbl.Size = New System.Drawing.Size(47, 18)
        Me.txt_price_lbl.TabIndex = 14
        Me.txt_price_lbl.Text = "Price"
        '
        'txt_name_lbl
        '
        Me.txt_name_lbl.AutoSize = True
        Me.txt_name_lbl.BackColor = System.Drawing.Color.Transparent
        Me.txt_name_lbl.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name_lbl.Location = New System.Drawing.Point(23, 297)
        Me.txt_name_lbl.Name = "txt_name_lbl"
        Me.txt_name_lbl.Size = New System.Drawing.Size(55, 18)
        Me.txt_name_lbl.TabIndex = 13
        Me.txt_name_lbl.Text = "Name"
        '
        'txt_id_label
        '
        Me.txt_id_label.AutoSize = True
        Me.txt_id_label.BackColor = System.Drawing.Color.Transparent
        Me.txt_id_label.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_label.Location = New System.Drawing.Point(23, 262)
        Me.txt_id_label.Name = "txt_id_label"
        Me.txt_id_label.Size = New System.Drawing.Size(27, 18)
        Me.txt_id_label.TabIndex = 12
        Me.txt_id_label.Text = "ID"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Bodoni MT", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(12, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(191, 38)
        Me.lbl_title.TabIndex = 8
        Me.lbl_title.Text = "Add Product"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_insertproduct_a174652
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EagleZ_Computer_Shop.My.Resources.Resources.bg_app2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1164, 661)
        Me.Controls.Add(Me.grd_product)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_insertproduct_a174652"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EagleZ Computer Shop: Add New Product"
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.productPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grd_product As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents addButton As Button
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_price_lbl As Label
    Friend WithEvents txt_name_lbl As Label
    Friend WithEvents txt_id_label As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents changePictureBtn As Button
    Friend WithEvents productPicBox As PictureBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_brand_lbl As Label
    Friend WithEvents txt_stock As TextBox
    Friend WithEvents lbl_stock_title As Label
    Friend WithEvents txt_socket As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_year As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txt_picture As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_year_lbl As Label
End Class
