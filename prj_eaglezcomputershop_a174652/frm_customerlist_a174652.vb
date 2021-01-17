Public Class frm_customerlist_a174652
    Private Sub CustomerListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_customer.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMER_A174652")
        grd_customer.Columns(0).HeaderText = "Customer ID"
        grd_customer.Columns(0).DefaultCellStyle.Format = "\C000"
        grd_customer.Columns(1).HeaderText = "Name"
        grd_customer.Columns(2).HeaderText = "Address"
        grd_customer.Columns(3).HeaderText = "Phone"
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Close()
    End Sub
End Class