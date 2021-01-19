Public Class frm_orderlist_a174652
    Private Sub OrderListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_order.DataSource = run_sql_query("SELECT * FROM TBL_ORDER_A174652")
        grd_order.Columns(0).HeaderText = "Order ID"
        grd_order.Columns(0).DefaultCellStyle.Format = "\ODR000"
        grd_order.Columns(1).HeaderText = "Customer ID"
        grd_order.Columns(1).DefaultCellStyle.Format = "\C000"
        grd_order.Columns(3).HeaderText = "Order Date"
        grd_order.Columns(2).HeaderText = "Staff ID"
        grd_order.Columns(2).DefaultCellStyle.Format = "\EMP000"
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Close()
    End Sub
End Class