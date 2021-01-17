Public Class frm_productlist_a174652
    Private Sub ProductListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_product.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A174652")
        grd_product.Columns(0).HeaderText = "Product ID"
        grd_product.Columns(0).DefaultCellStyle.Format = "\MB000"
        grd_product.Columns(1).HeaderText = "Name"
        grd_product.Columns(2).HeaderText = "Price"
        grd_product.Columns(3).HeaderText = "Brand"
        grd_product.Columns(4).HeaderText = "Socket"
        grd_product.Columns(5).HeaderText = "Mfg. Year"
        grd_product.Columns(6).HeaderText = "Stock"

    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Close()
    End Sub
End Class