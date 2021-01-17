<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_mainmenu_a174652
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mainmenu_a174652))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.orderBtn = New System.Windows.Forms.Button()
        Me.staffBtn = New System.Windows.Forms.Button()
        Me.productBtn = New System.Windows.Forms.Button()
        Me.customerBtn = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbl_time = New System.Windows.Forms.ToolStripStatusLabel()
        Me.customerPanel = New System.Windows.Forms.Panel()
        Me.listCustomerBtn = New System.Windows.Forms.Button()
        Me.manageCustomerBtn = New System.Windows.Forms.Button()
        Me.addCustomerBtn = New System.Windows.Forms.Button()
        Me.orderPanel = New System.Windows.Forms.Panel()
        Me.productPanel = New System.Windows.Forms.Panel()
        Me.listProductBtn = New System.Windows.Forms.Button()
        Me.manageProductBtn = New System.Windows.Forms.Button()
        Me.addProductBtn = New System.Windows.Forms.Button()
        Me.staffPanel = New System.Windows.Forms.Panel()
        Me.listStaffBtn = New System.Windows.Forms.Button()
        Me.manageStaffBtn = New System.Windows.Forms.Button()
        Me.staffAddBtn = New System.Windows.Forms.Button()
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.customerTimer = New System.Windows.Forms.Timer(Me.components)
        Me.productTimer = New System.Windows.Forms.Timer(Me.components)
        Me.staffTimer = New System.Windows.Forms.Timer(Me.components)
        Me.catalogProductButton = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.customerPanel.SuspendLayout()
        Me.orderPanel.SuspendLayout()
        Me.productPanel.SuspendLayout()
        Me.staffPanel.SuspendLayout()
        Me.mainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Bodoni MT", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_title.Location = New System.Drawing.Point(142, 12)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(254, 76)
        Me.lbl_title.TabIndex = 4
        Me.lbl_title.Text = "EagleZ Computer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shop"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'orderBtn
        '
        Me.orderBtn.BackColor = System.Drawing.Color.Transparent
        Me.orderBtn.Font = New System.Drawing.Font("Bahnschrift SemiLight", 14.25!)
        Me.orderBtn.Image = Global.EagleZ_Computer_Shop.My.Resources.Resources.document
        Me.orderBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.orderBtn.Location = New System.Drawing.Point(0, 0)
        Me.orderBtn.Name = "orderBtn"
        Me.orderBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.orderBtn.Size = New System.Drawing.Size(104, 64)
        Me.orderBtn.TabIndex = 3
        Me.orderBtn.Text = "Order"
        Me.orderBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.orderBtn.UseVisualStyleBackColor = False
        '
        'staffBtn
        '
        Me.staffBtn.BackColor = System.Drawing.Color.Transparent
        Me.staffBtn.Font = New System.Drawing.Font("Bahnschrift SemiLight", 14.25!)
        Me.staffBtn.Image = Global.EagleZ_Computer_Shop.My.Resources.Resources.group1
        Me.staffBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.staffBtn.Location = New System.Drawing.Point(0, 0)
        Me.staffBtn.Name = "staffBtn"
        Me.staffBtn.Size = New System.Drawing.Size(104, 64)
        Me.staffBtn.TabIndex = 2
        Me.staffBtn.Text = "Staff"
        Me.staffBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.staffBtn.UseVisualStyleBackColor = False
        '
        'productBtn
        '
        Me.productBtn.BackColor = System.Drawing.Color.Transparent
        Me.productBtn.Font = New System.Drawing.Font("Bahnschrift SemiLight", 14.25!)
        Me.productBtn.Image = Global.EagleZ_Computer_Shop.My.Resources.Resources.list
        Me.productBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.productBtn.Location = New System.Drawing.Point(0, 0)
        Me.productBtn.Name = "productBtn"
        Me.productBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.productBtn.Size = New System.Drawing.Size(104, 64)
        Me.productBtn.TabIndex = 1
        Me.productBtn.Text = "Product"
        Me.productBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.productBtn.UseVisualStyleBackColor = False
        '
        'customerBtn
        '
        Me.customerBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.customerBtn.BackColor = System.Drawing.Color.Transparent
        Me.customerBtn.Font = New System.Drawing.Font("Bahnschrift SemiLight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.customerBtn.Image = Global.EagleZ_Computer_Shop.My.Resources.Resources.user
        Me.customerBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.customerBtn.Location = New System.Drawing.Point(0, 0)
        Me.customerBtn.Name = "customerBtn"
        Me.customerBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.customerBtn.Size = New System.Drawing.Size(104, 64)
        Me.customerBtn.TabIndex = 0
        Me.customerBtn.Text = "Customer"
        Me.customerBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.customerBtn.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_time})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 419)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(904, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "Time"
        '
        'lbl_time
        '
        Me.lbl_time.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(33, 17)
        Me.lbl_time.Text = "Time"
        '
        'customerPanel
        '
        Me.customerPanel.Controls.Add(Me.listCustomerBtn)
        Me.customerPanel.Controls.Add(Me.manageCustomerBtn)
        Me.customerPanel.Controls.Add(Me.addCustomerBtn)
        Me.customerPanel.Controls.Add(Me.customerBtn)
        Me.customerPanel.Location = New System.Drawing.Point(52, 101)
        Me.customerPanel.MinimumSize = New System.Drawing.Size(104, 64)
        Me.customerPanel.Name = "customerPanel"
        Me.customerPanel.Size = New System.Drawing.Size(104, 64)
        Me.customerPanel.TabIndex = 7
        '
        'listCustomerBtn
        '
        Me.listCustomerBtn.Location = New System.Drawing.Point(0, 70)
        Me.listCustomerBtn.Name = "listCustomerBtn"
        Me.listCustomerBtn.Size = New System.Drawing.Size(104, 32)
        Me.listCustomerBtn.TabIndex = 7
        Me.listCustomerBtn.Text = "List"
        Me.listCustomerBtn.UseVisualStyleBackColor = True
        '
        'manageCustomerBtn
        '
        Me.manageCustomerBtn.Location = New System.Drawing.Point(0, 146)
        Me.manageCustomerBtn.Name = "manageCustomerBtn"
        Me.manageCustomerBtn.Size = New System.Drawing.Size(104, 32)
        Me.manageCustomerBtn.TabIndex = 2
        Me.manageCustomerBtn.Text = "Manage"
        Me.manageCustomerBtn.UseVisualStyleBackColor = True
        '
        'addCustomerBtn
        '
        Me.addCustomerBtn.Location = New System.Drawing.Point(0, 108)
        Me.addCustomerBtn.Name = "addCustomerBtn"
        Me.addCustomerBtn.Size = New System.Drawing.Size(104, 32)
        Me.addCustomerBtn.TabIndex = 1
        Me.addCustomerBtn.Text = "Add"
        Me.addCustomerBtn.UseVisualStyleBackColor = True
        '
        'orderPanel
        '
        Me.orderPanel.Controls.Add(Me.orderBtn)
        Me.orderPanel.Location = New System.Drawing.Point(162, 101)
        Me.orderPanel.MinimumSize = New System.Drawing.Size(104, 64)
        Me.orderPanel.Name = "orderPanel"
        Me.orderPanel.Size = New System.Drawing.Size(104, 64)
        Me.orderPanel.TabIndex = 8
        '
        'productPanel
        '
        Me.productPanel.Controls.Add(Me.catalogProductButton)
        Me.productPanel.Controls.Add(Me.listProductBtn)
        Me.productPanel.Controls.Add(Me.manageProductBtn)
        Me.productPanel.Controls.Add(Me.addProductBtn)
        Me.productPanel.Controls.Add(Me.productBtn)
        Me.productPanel.Location = New System.Drawing.Point(272, 101)
        Me.productPanel.MinimumSize = New System.Drawing.Size(104, 64)
        Me.productPanel.Name = "productPanel"
        Me.productPanel.Size = New System.Drawing.Size(104, 64)
        Me.productPanel.TabIndex = 9
        '
        'listProductBtn
        '
        Me.listProductBtn.Location = New System.Drawing.Point(0, 108)
        Me.listProductBtn.Name = "listProductBtn"
        Me.listProductBtn.Size = New System.Drawing.Size(104, 32)
        Me.listProductBtn.TabIndex = 9
        Me.listProductBtn.Text = "List"
        Me.listProductBtn.UseVisualStyleBackColor = True
        '
        'manageProductBtn
        '
        Me.manageProductBtn.Location = New System.Drawing.Point(0, 184)
        Me.manageProductBtn.Name = "manageProductBtn"
        Me.manageProductBtn.Size = New System.Drawing.Size(104, 32)
        Me.manageProductBtn.TabIndex = 8
        Me.manageProductBtn.Text = "Manage"
        Me.manageProductBtn.UseVisualStyleBackColor = True
        '
        'addProductBtn
        '
        Me.addProductBtn.Location = New System.Drawing.Point(0, 146)
        Me.addProductBtn.Name = "addProductBtn"
        Me.addProductBtn.Size = New System.Drawing.Size(104, 32)
        Me.addProductBtn.TabIndex = 7
        Me.addProductBtn.Text = "Add"
        Me.addProductBtn.UseVisualStyleBackColor = True
        '
        'staffPanel
        '
        Me.staffPanel.Controls.Add(Me.listStaffBtn)
        Me.staffPanel.Controls.Add(Me.manageStaffBtn)
        Me.staffPanel.Controls.Add(Me.staffAddBtn)
        Me.staffPanel.Controls.Add(Me.staffBtn)
        Me.staffPanel.Location = New System.Drawing.Point(382, 101)
        Me.staffPanel.MinimumSize = New System.Drawing.Size(104, 64)
        Me.staffPanel.Name = "staffPanel"
        Me.staffPanel.Size = New System.Drawing.Size(104, 64)
        Me.staffPanel.TabIndex = 10
        '
        'listStaffBtn
        '
        Me.listStaffBtn.Location = New System.Drawing.Point(0, 70)
        Me.listStaffBtn.Name = "listStaffBtn"
        Me.listStaffBtn.Size = New System.Drawing.Size(104, 32)
        Me.listStaffBtn.TabIndex = 10
        Me.listStaffBtn.Text = "List"
        Me.listStaffBtn.UseVisualStyleBackColor = True
        '
        'manageStaffBtn
        '
        Me.manageStaffBtn.Location = New System.Drawing.Point(0, 146)
        Me.manageStaffBtn.Name = "manageStaffBtn"
        Me.manageStaffBtn.Size = New System.Drawing.Size(104, 32)
        Me.manageStaffBtn.TabIndex = 9
        Me.manageStaffBtn.Text = "Manage"
        Me.manageStaffBtn.UseVisualStyleBackColor = True
        '
        'staffAddBtn
        '
        Me.staffAddBtn.Location = New System.Drawing.Point(0, 108)
        Me.staffAddBtn.Name = "staffAddBtn"
        Me.staffAddBtn.Size = New System.Drawing.Size(104, 32)
        Me.staffAddBtn.TabIndex = 8
        Me.staffAddBtn.Text = "Add"
        Me.staffAddBtn.UseVisualStyleBackColor = True
        '
        'mainPanel
        '
        Me.mainPanel.BackColor = System.Drawing.Color.Transparent
        Me.mainPanel.Controls.Add(Me.lbl_title)
        Me.mainPanel.Controls.Add(Me.orderPanel)
        Me.mainPanel.Controls.Add(Me.productPanel)
        Me.mainPanel.Controls.Add(Me.staffPanel)
        Me.mainPanel.Controls.Add(Me.customerPanel)
        Me.mainPanel.Location = New System.Drawing.Point(300, 60)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(546, 334)
        Me.mainPanel.TabIndex = 11
        '
        'customerTimer
        '
        Me.customerTimer.Interval = 40
        '
        'productTimer
        '
        Me.productTimer.Interval = 40
        '
        'staffTimer
        '
        Me.staffTimer.Interval = 40
        '
        'catalogProductButton
        '
        Me.catalogProductButton.Location = New System.Drawing.Point(0, 70)
        Me.catalogProductButton.Name = "catalogProductButton"
        Me.catalogProductButton.Size = New System.Drawing.Size(104, 32)
        Me.catalogProductButton.TabIndex = 10
        Me.catalogProductButton.Text = "Catalog"
        Me.catalogProductButton.UseVisualStyleBackColor = True
        '
        'frm_mainmenu_a174652
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(904, 441)
        Me.Controls.Add(Me.mainPanel)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_mainmenu_a174652"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EagleZ Computer Shop"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.customerPanel.ResumeLayout(False)
        Me.orderPanel.ResumeLayout(False)
        Me.productPanel.ResumeLayout(False)
        Me.staffPanel.ResumeLayout(False)
        Me.mainPanel.ResumeLayout(False)
        Me.mainPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents customerBtn As Button
    Friend WithEvents productBtn As Button
    Friend WithEvents staffBtn As Button
    Friend WithEvents orderBtn As Button
    Friend WithEvents lbl_title As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lbl_time As ToolStripStatusLabel
    Friend WithEvents customerPanel As Panel
    Friend WithEvents manageCustomerBtn As Button
    Friend WithEvents addCustomerBtn As Button
    Friend WithEvents orderPanel As Panel
    Friend WithEvents productPanel As Panel
    Friend WithEvents manageProductBtn As Button
    Friend WithEvents addProductBtn As Button
    Friend WithEvents staffPanel As Panel
    Friend WithEvents manageStaffBtn As Button
    Friend WithEvents staffAddBtn As Button
    Friend WithEvents listCustomerBtn As Button
    Friend WithEvents listProductBtn As Button
    Friend WithEvents listStaffBtn As Button
    Friend WithEvents mainPanel As Panel
    Friend WithEvents customerTimer As Timer
    Friend WithEvents productTimer As Timer
    Friend WithEvents staffTimer As Timer
    Friend WithEvents catalogProductButton As Button
End Class
