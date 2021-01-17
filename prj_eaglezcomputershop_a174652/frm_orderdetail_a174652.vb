Public Class frm_orderdetail_a174652
    Private Sub OrderDetailForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_orderdetails.DataSource = run_sql_query("SELECT FLD_ORDER_ID AS `Order ID`, FLD_PRODUCT_ID AS `Product ID`, FLD_PRODUCT_QTY AS `Quantity` FROM TBL_ORDERDETAILS_A174652")
        grd_orderdetails.Columns(0).DefaultCellStyle.Format = "\OD000PQ"
        grd_orderdetails.Columns(0).DefaultCellStyle.Format = "\MB000"
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Close()
    End Sub
End Class