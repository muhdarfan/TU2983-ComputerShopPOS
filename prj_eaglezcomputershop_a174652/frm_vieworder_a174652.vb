Public Class frm_vieworder_a174652

    Private Sub OrderDetailForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrder()
        AddHandler cbox_order_list.SelectedIndexChanged, AddressOf cbox_order_list_SelectedIndexChanged
        RefreshData()
    End Sub

    Private Sub LoadOrder()
        Dim staffDT As DataTable = run_sql_query("SELECT FLD_ORDER_ID FROM TBL_ORDER_A174652")
        Dim comboSource As New Dictionary(Of String, String)()
        For Each row As DataRow In staffDT.Rows
            comboSource.Add(row("FLD_ORDER_ID"), String.Format("ODR{0:000}", row("FLD_ORDER_ID")))
        Next row

        cbox_order_list.DataSource = New BindingSource(comboSource, Nothing)
        cbox_order_list.DisplayMember = "Value"
        cbox_order_list.ValueMember = "Key"
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Close()
    End Sub
    Private Sub cbox_order_list_SelectedIndexChanged(sender As Object, e As EventArgs)
        RefreshData()
    End Sub

    Private Sub RefreshData()
        Try
            Dim orderDT As DataTable = run_sql_query("SELECT order.*, customer.*, TBL_STAFF_A174652.* FROM (TBL_CUSTOMER_A174652 AS customer INNER JOIN TBL_ORDER_A174652 AS [order] ON customer.FLD_CUSTOMER_ID = order.FLD_CUSTOMER_ID) INNER JOIN TBL_STAFF_A174652 ON order.FLD_STAFF_ID = TBL_STAFF_A174652.FLD_STAFF_ID WHERE order.FLD_ORDER_ID = " & cbox_order_list.SelectedValue)

            lbl_item_list.Text = ""
            lbl_item_qty.Text = ""
            lbl_item_subtotal.Text = ""
            lbl_item_unit_price.Text = ""
            lbl_total_price.Text = "0"
            lbl_order_id.Text = String.Format("ODR{0:000}", orderDT.Rows(0).Item("FLD_ORDER_ID"))
            lbl_order_date.Text = Format(orderDT.Rows(0).Item("FLD_ORDER_DATE"), "d MMM yyyy")

            lbl_staff.Text = String.Format("{1} (EMP{0:000})", orderDT.Rows(0).Item("TBL_STAFF_A174652.FLD_STAFF_ID"), orderDT.Rows(0).Item("FLD_STAFF_NAME"))
            lbl_cust_info.Text = String.Concat(New String() {orderDT.Rows(0).Item("FLD_CUSTOMER_NAME"), Environment.NewLine, orderDT.Rows(0).Item("FLD_CUSTOMER_ADDRESS").Replace(", ", "," & Environment.NewLine)})
            Dim purchaseDT As DataTable = run_sql_query("SELECT pro.FLD_PRODUCT_NAME, odr.FLD_PRODUCT_QTY, pro.FLD_PRICE, (odr.FLD_PRODUCT_QTY * pro.FLD_PRICE) AS SUBTOTAL FROM TBL_ORDERDETAILS_A174652 AS [odr] INNER JOIN TBL_PRODUCTS_A174652 AS [pro] ON odr.FLD_PRODUCT_ID = pro.FLD_PRODUCT_ID WHERE odr.FLD_ORDER_ID=" & cbox_order_list.SelectedValue & " ORDER BY pro.FLD_PRODUCT_NAME ASC")
            For Each row As DataRow In purchaseDT.Rows
                lbl_item_list.Text += row.Item("FLD_PRODUCT_NAME") + Environment.NewLine
                lbl_item_qty.Text += row.Item("FLD_PRODUCT_QTY").ToString() + Environment.NewLine
                lbl_item_unit_price.Text += String.Format("{0:0,0.00}", row.Item("FLD_PRICE")) + Environment.NewLine
                lbl_item_subtotal.Text += String.Format("{0:0,0.00}", row.Item("SUBTOTAL")) + Environment.NewLine
                'lbl_total_price.Text = String.Format("{0:0,0.00}", (Double.Parse(lbl_total_price.Text) + Double.Parse(row.Item("SUBTOTAL"))))
                lbl_total_price.Text = String.Format("{0:0.00}", (row.Item("SUBTOTAL") + Double.Parse(lbl_total_price.Text)))
            Next row
        Catch ex As Exception
            MsgBox("An error has been occured. Please contact administrator. Message:" & vbCrLf & vbCrLf & ex.Message)
        End Try

    End Sub
End Class