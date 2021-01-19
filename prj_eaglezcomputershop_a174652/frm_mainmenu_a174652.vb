Public Class frm_mainmenu_a174652
    Dim cPanel As Integer = 64
    Dim pPanel As Integer = 64
    Dim sPanel As Integer = 64
    Dim oPanel As Integer = 64
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_time.Text = Date.Now.ToString("d MMM yyyy")
    End Sub

    Private Sub customerBtn_Click(sender As Object, e As EventArgs) Handles customerBtn.Click
        ClosePanel()
        customerTimer.Start()
    End Sub

    Private Sub productBtn_Click(sender As Object, e As EventArgs) Handles productBtn.Click
        ClosePanel()
        productTimer.Start()
    End Sub

    Private Sub staffBtn_Click(sender As Object, e As EventArgs) Handles staffBtn.Click
        ClosePanel()
        staffTimer.Start()
    End Sub

    Private Sub orderBtn_Click(sender As Object, e As EventArgs) Handles orderBtn.Click
        ClosePanel()
        orderTimer.Start()
    End Sub

    Private Sub listCustomerBtn_Click(sender As Object, e As EventArgs) Handles listCustomerBtn.Click
        Using customerForm As New frm_customerlist_a174652
            If customerForm.ShowDialog = DialogResult.OK Then
                customerForm.ShowDialog()
            Else
                customerForm.Close()
            End If
        End Using
    End Sub

    Private Sub addCustomerBtn_Click(sender As Object, e As EventArgs) Handles addCustomerBtn.Click
        frm_insertcustomer_a174652.ShowDialog()
    End Sub

    Private Sub manageCustomerBtn_Click(sender As Object, e As EventArgs) Handles manageCustomerBtn.Click
        frm_managecustomer_a174652.ShowDialog()
    End Sub

    Private Sub catalogProductButton_Click(sender As Object, e As EventArgs) Handles catalogProductButton.Click
        frm_catalog_a174652.ShowDialog()
    End Sub

    Private Sub listProductBtn_Click(sender As Object, e As EventArgs) Handles listProductBtn.Click
        frm_productlist_a174652.ShowDialog()
    End Sub

    Private Sub addProductBtn_Click(sender As Object, e As EventArgs) Handles addProductBtn.Click
        frm_insertproduct_a174652.ShowDialog()
    End Sub

    Private Sub manageProductBtn_Click(sender As Object, e As EventArgs) Handles manageProductBtn.Click
        frm_manageproduct_a174652.ShowDialog()
    End Sub

    Private Sub listStaffBtn_Click(sender As Object, e As EventArgs) Handles listStaffBtn.Click
        frm_stafflist_a174652.ShowDialog()
    End Sub

    Private Sub staffListBtn_Click(sender As Object, e As EventArgs) Handles staffAddBtn.Click
        frm_insertstaff_a174652.ShowDialog()
    End Sub

    Private Sub manageStaffBtn_Click(sender As Object, e As EventArgs) Handles manageStaffBtn.Click
        frm_managestaff_a174652.ShowDialog()
    End Sub

    Private Sub makeOrderBtn_Click(sender As Object, e As EventArgs) Handles makeOrderBtn.Click
        frm_makeorder_a174652.ShowDialog()
    End Sub

    Private Sub viewOrderBtn_Click(sender As Object, e As EventArgs) Handles viewOrderBtn.Click
        frm_vieworder_a174652.ShowDialog()
    End Sub

    Private Sub listOrderBtn_Click(sender As Object, e As EventArgs) Handles listOrderBtn.Click
        frm_orderlist_a174652.ShowDialog()
    End Sub
    Private Sub customerTimer_Tick(sender As Object, e As EventArgs) Handles customerTimer.Tick
        If customerPanel.Height > 180 Then
            customerTimer.Stop()
        Else
            Me.customerPanel.Size = New Size(Me.customerPanel.Size.Width, cPanel)
            cPanel += 70
        End If
    End Sub

    Private Sub productTimer_Tick(sender As Object, e As EventArgs) Handles productTimer.Tick
        If productPanel.Height > 220 Then
            productTimer.Stop()
        Else
            Me.productPanel.Size = New Size(Me.productPanel.Size.Width, pPanel)
            pPanel += 70
        End If
    End Sub

    Private Sub staffTimer_Tick(sender As Object, e As EventArgs) Handles staffTimer.Tick
        If staffPanel.Height > 180 Then
            staffTimer.Stop()
        Else
            Me.staffPanel.Size = New Size(Me.customerPanel.Size.Width, sPanel)
            sPanel += 70
        End If
    End Sub

    Private Sub orderTimer_Tick(sender As Object, e As EventArgs) Handles orderTimer.Tick
        If orderPanel.Height > 180 Then
            orderTimer.Stop()
        Else
            Me.orderPanel.Size = New Size(Me.orderPanel.Size.Width, oPanel)
            oPanel += 70
        End If
    End Sub

    Private Sub ClosePanel() Handles MyBase.Click, mainPanel.Click
        productTimer.Stop()
        customerTimer.Stop()
        staffTimer.Stop()
        orderTimer.Stop()

        productPanel.Size = productPanel.MinimumSize
        customerPanel.Size = customerPanel.MinimumSize
        staffPanel.Size = staffPanel.MinimumSize
        orderPanel.Size = orderPanel.MinimumSize
        pPanel = 64
        cPanel = 64
        sPanel = 64
        oPanel = 64
    End Sub

End Class
