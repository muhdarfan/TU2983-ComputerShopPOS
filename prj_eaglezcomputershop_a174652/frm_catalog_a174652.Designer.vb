<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_catalog_a174652
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_catalog_a174652))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.productPicBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_stock = New System.Windows.Forms.Label()
        Me.lbl_year = New System.Windows.Forms.Label()
        Me.lbl_socket = New System.Windows.Forms.Label()
        Me.lbl_year_title = New System.Windows.Forms.Label()
        Me.lbl_stock_title = New System.Windows.Forms.Label()
        Me.lbl_socket_title = New System.Windows.Forms.Label()
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.lbl_brand_title = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lst_product = New System.Windows.Forms.ListBox()
        CType(Me.productPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Bodoni MT", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(12, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(238, 38)
        Me.lbl_title.TabIndex = 4
        Me.lbl_title.Text = "Product Catalog"
        '
        'productPicBox
        '
        Me.productPicBox.Image = Global.EagleZ_Computer_Shop.My.Resources.Resources.no_photo
        Me.productPicBox.Location = New System.Drawing.Point(592, 50)
        Me.productPicBox.Name = "productPicBox"
        Me.productPicBox.Size = New System.Drawing.Size(300, 200)
        Me.productPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.productPicBox.TabIndex = 6
        Me.productPicBox.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lbl_price)
        Me.GroupBox1.Controls.Add(Me.lbl_stock)
        Me.GroupBox1.Controls.Add(Me.lbl_year)
        Me.GroupBox1.Controls.Add(Me.lbl_socket)
        Me.GroupBox1.Controls.Add(Me.lbl_year_title)
        Me.GroupBox1.Controls.Add(Me.lbl_stock_title)
        Me.GroupBox1.Controls.Add(Me.lbl_socket_title)
        Me.GroupBox1.Controls.Add(Me.lbl_brand)
        Me.GroupBox1.Controls.Add(Me.lbl_brand_title)
        Me.GroupBox1.Location = New System.Drawing.Point(592, 322)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 151)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Information"
        '
        'lbl_price
        '
        Me.lbl_price.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(100, 16)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(100, 23)
        Me.lbl_price.TabIndex = 9
        Me.lbl_price.Text = "0.00"
        '
        'lbl_stock
        '
        Me.lbl_stock.AutoSize = True
        Me.lbl_stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_stock.Location = New System.Drawing.Point(171, 123)
        Me.lbl_stock.Name = "lbl_stock"
        Me.lbl_stock.Size = New System.Drawing.Size(31, 16)
        Me.lbl_stock.TabIndex = 8
        Me.lbl_stock.Text = "N/A"
        '
        'lbl_year
        '
        Me.lbl_year.AutoSize = True
        Me.lbl_year.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_year.Location = New System.Drawing.Point(171, 99)
        Me.lbl_year.Name = "lbl_year"
        Me.lbl_year.Size = New System.Drawing.Size(31, 16)
        Me.lbl_year.TabIndex = 7
        Me.lbl_year.Text = "N/A"
        '
        'lbl_socket
        '
        Me.lbl_socket.AutoSize = True
        Me.lbl_socket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_socket.Location = New System.Drawing.Point(171, 75)
        Me.lbl_socket.Name = "lbl_socket"
        Me.lbl_socket.Size = New System.Drawing.Size(31, 16)
        Me.lbl_socket.TabIndex = 6
        Me.lbl_socket.Text = "N/A"
        '
        'lbl_year_title
        '
        Me.lbl_year_title.AutoSize = True
        Me.lbl_year_title.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_year_title.Location = New System.Drawing.Point(6, 97)
        Me.lbl_year_title.Name = "lbl_year_title"
        Me.lbl_year_title.Size = New System.Drawing.Size(135, 19)
        Me.lbl_year_title.TabIndex = 5
        Me.lbl_year_title.Text = "Manufacturer Year"
        '
        'lbl_stock_title
        '
        Me.lbl_stock_title.AutoSize = True
        Me.lbl_stock_title.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_stock_title.Location = New System.Drawing.Point(6, 121)
        Me.lbl_stock_title.Name = "lbl_stock_title"
        Me.lbl_stock_title.Size = New System.Drawing.Size(47, 19)
        Me.lbl_stock_title.TabIndex = 4
        Me.lbl_stock_title.Text = "Stock"
        '
        'lbl_socket_title
        '
        Me.lbl_socket_title.AutoSize = True
        Me.lbl_socket_title.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_socket_title.Location = New System.Drawing.Point(6, 73)
        Me.lbl_socket_title.Name = "lbl_socket_title"
        Me.lbl_socket_title.Size = New System.Drawing.Size(55, 19)
        Me.lbl_socket_title.TabIndex = 3
        Me.lbl_socket_title.Text = "Socket"
        '
        'lbl_brand
        '
        Me.lbl_brand.AutoSize = True
        Me.lbl_brand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand.Location = New System.Drawing.Point(171, 51)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(31, 16)
        Me.lbl_brand.TabIndex = 2
        Me.lbl_brand.Text = "N/A"
        '
        'lbl_brand_title
        '
        Me.lbl_brand_title.AutoSize = True
        Me.lbl_brand_title.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand_title.Location = New System.Drawing.Point(6, 49)
        Me.lbl_brand_title.Name = "lbl_brand_title"
        Me.lbl_brand_title.Size = New System.Drawing.Size(50, 19)
        Me.lbl_brand_title.TabIndex = 1
        Me.lbl_brand_title.Text = "Brand"
        '
        'lbl_name
        '
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(592, 253)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(300, 66)
        Me.lbl_name.TabIndex = 0
        Me.lbl_name.Text = "Name"
        Me.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lst_product
        '
        Me.lst_product.FormattingEnabled = True
        Me.lst_product.Location = New System.Drawing.Point(19, 50)
        Me.lst_product.Name = "lst_product"
        Me.lst_product.Size = New System.Drawing.Size(567, 420)
        Me.lst_product.TabIndex = 8
        '
        'frm_catalog_a174652
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EagleZ_Computer_Shop.My.Resources.Resources.bg_app2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(904, 611)
        Me.Controls.Add(Me.lst_product)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.productPicBox)
        Me.Controls.Add(Me.lbl_title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_catalog_a174652"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EagleZ Computer Shop: Catalog"
        CType(Me.productPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_title As Label
    Friend WithEvents productPicBox As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_stock As Label
    Friend WithEvents lbl_year As Label
    Friend WithEvents lbl_socket As Label
    Friend WithEvents lbl_year_title As Label
    Friend WithEvents lbl_stock_title As Label
    Friend WithEvents lbl_socket_title As Label
    Friend WithEvents lbl_brand As Label
    Friend WithEvents lbl_brand_title As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lst_product As ListBox
End Class
