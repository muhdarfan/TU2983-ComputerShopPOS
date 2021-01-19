Public Class frm_makeorder_a174652
    Dim sData As DataTable

    Private Sub frm_insertorder_a174652_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadCustomer()
        LoadStaff()
        LoadProduct()
        LoadHeader()
        GenerateOrResetOrderID()
    End Sub

    Private Sub btn_add_cart_Click(sender As Object, e As EventArgs) Handles btn_add_cart.Click
        For Each row As DataGridViewRow In grid_cart.Rows
            If row.Cells(0).Value = tb_order_id.Text And row.Cells(1).Value = lbl_product_id.Text Then
                Dim newQuantity As Integer = row.Cells(2).Value + box_quantity.Value

                If newQuantity <= lbl_product_stock.Text Then
                    row.Cells(2).Value = newQuantity
                    row.Cells(3).Value = FormatMoney(row.Cells(2).Value * lbl_product_price.Text)
                Else
                    MsgBox("Quantity reached stock limits.")
                End If

                Return
            End If
        Next

        grid_cart.Rows.Add(tb_order_id.Text, lbl_product_id.Text, box_quantity.Value, FormatMoney(lbl_product_price.Text * box_quantity.Value))
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If grid_cart.SelectedRows IsNot Nothing AndAlso grid_cart.SelectedRows.Count > 0 Then
            grid_cart.Rows.RemoveAt(grid_cart.SelectedRows(0).Index)
        Else
            MsgBox("Please select a product from the shopping cart to remove.")
        End If
    End Sub

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        If grid_cart.Rows.Count < 1 Then
            MsgBox("There is no item in your cart. Please add some before checking out...")
            Return
        End If

        Dim purchaseTransaction As OleDb.OleDbTransaction
        connection2.Open()
        purchaseTransaction = connection2.BeginTransaction

        Try
            Dim odrID As Integer = Integer.Parse(Mid(tb_order_id.Text, 4))
            Dim customerID As Integer = Integer.Parse(cb_customer.SelectedValue)
            Dim staffID As Integer = Integer.Parse(cb_staff.SelectedValue)


            ' Insert New Orders
            Dim orderWriter As New OleDb.OleDbCommand("INSERT INTO TBL_ORDER_A174652 VALUES ('" & odrID & "', " & customerID & ", " & staffID & ", NOW())", connection2, purchaseTransaction)
            orderWriter.ExecuteNonQuery()

            For Each row As DataGridViewRow In grid_cart.Rows
                Dim rOdrID = row.Cells(0).Value
                Dim productID = Integer.Parse(Mid(row.Cells(1).Value, 4))
                Dim qty = Integer.Parse(row.Cells(2).Value)
                Dim fprice = Double.Parse(Mid(row.Cells(3).Value, 3))

                orderWriter = New OleDb.OleDbCommand("INSERT INTO TBL_ORDERDETAILS_A174652 VALUES (" & odrID & ", " & productID & ", " & qty & ", " & fprice & ")", connection2, purchaseTransaction)
                orderWriter.ExecuteNonQuery()
            Next

            purchaseTransaction.Commit()
            MsgBox("Your order(s) has been successfully saved into our system. Thank you for purchasing!")
            ResetAll()
            GenerateOrResetOrderID()
        Catch ex As Exception
            Beep()

            MsgBox("An error has been occurred while proccessing your order(s). Message: " & vbCrLf & vbCrLf & ex.Message)
            purchaseTransaction.Rollback()
        Finally
            connection2.Close()
        End Try
    End Sub

    Private Sub lb_product_items_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_product_items.SelectedIndexChanged
        Try

            sData = run_sql_query("SELECT * FROM TBL_PRODUCTS_A174652 WHERE FLD_PRODUCT_ID=" & lb_product_items.SelectedValue & "")
            lbl_product_id.Text = String.Format("MB{0:000}", Integer.Parse(lb_product_items.SelectedValue))
            lbl_product_name.Text = sData.Rows(0).Item("FLD_PRODUCT_NAME")
            lbl_product_price.Text = String.Format("RM {0:0.00}", sData.Rows(0).Item("FLD_PRICE"))
            lbl_product_brand.Text = String.Format("{0} - {1}", sData.Rows(0).Item("FLD_BRAND"), sData.Rows(0).Item("FLD_SOCKET"))
            lbl_product_stock.Text = sData.Rows(0).Item("FLD_STOCK")
            lbl_product_year.Text = sData.Rows(0).Item("FLD_MANUFACTURED_YEAR")

            pic_product_picture.Image = SafeImageFromFile("pictures/" & lb_product_items.SelectedValue & ".png")

            box_quantity.Value = 1
            box_quantity.Maximum = sData.Rows(0).Item("FLD_STOCK")
            Calculate()
        Catch
        End Try
    End Sub

    Private Function FormatMoney(val As Integer) As String
        Return String.Format("RM {0:0.00}", val)
    End Function

    Private Sub Calculate()
        If sData IsNot Nothing AndAlso sData.Rows.Count > 0 Then
            Dim price As Integer = sData.Rows(0).Item("FLD_PRICE")

            lbl_subtotal.Text = String.Format("RM {0:0.00}", (price * box_quantity.Value))
        End If
    End Sub

    Private Sub RefreshTotal()
        Dim totalPrice As Integer = 0
        For Each row As DataGridViewRow In grid_cart.Rows
            totalPrice += row.Cells(3).Value
        Next
        lbl_cart_total.Text = FormatMoney(totalPrice)

        If grid_cart.Rows.Count > 0 Then
            btn_confirm.Enabled = True
        Else
            btn_confirm.Enabled = False
        End If
    End Sub

    Private Sub box_quantity_ValueChanged(sender As Object, e As EventArgs) Handles box_quantity.ValueChanged
        Calculate()
    End Sub


    Private Sub GenerateOrResetOrderID()
        Try
            Dim latestOrderID As String = run_sql_query("SELECT MAX(FLD_ORDER_ID) AS `OID` FROM TBL_ORDER_A174652").Rows(0).Item("OID")
            tb_order_id.Text = String.Format("ODR{0:000}", latestOrderID + 1)
        Catch ex As Exception
            tb_order_id.Text = "ODR001"
        End Try
    End Sub

    Private Sub LoadCustomer()
        Dim customerDT As DataTable = run_sql_query("SELECT * FROM TBL_CUSTOMER_A174652")
        Dim comboSource As New Dictionary(Of String, String)()
        For Each row As DataRow In customerDT.Rows
            comboSource.Add(row("FLD_CUSTOMER_ID"), String.Format("C{0:000} - {1}", row("FLD_CUSTOMER_ID"), row("FLD_CUSTOMER_NAME")))
        Next row

        cb_customer.DataSource = New BindingSource(comboSource, Nothing)
        cb_customer.DisplayMember = "Value"
        cb_customer.ValueMember = "Key"
    End Sub

    Private Sub LoadStaff()
        Dim staffDT As DataTable = run_sql_query("SELECT * FROM TBL_STAFF_A174652")
        Dim comboSource As New Dictionary(Of String, String)()
        For Each row As DataRow In staffDT.Rows
            comboSource.Add(row("FLD_STAFF_ID"), String.Format("EMP{0:000} - {1}", row("FLD_STAFF_ID"), row("FLD_STAFF_NAME")))
        Next row

        cb_staff.DataSource = New BindingSource(comboSource, Nothing)
        cb_staff.DisplayMember = "Value"
        cb_staff.ValueMember = "Key"
    End Sub

    Private Sub LoadProduct()
        lb_product_items.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A174652")
        lb_product_items.DisplayMember = "FLD_PRODUCT_NAME"
        lb_product_items.ValueMember = "FLD_PRODUCT_ID"
        lb_product_items.SelectedIndex = 0
    End Sub

    Private Sub LoadHeader()
        Dim cardHeaderDT As DataColumnCollection = run_sql_query("SELECT * FROM TBL_ORDERDETAILS_A174652").Columns
        For i = 0 To cardHeaderDT.Count - 1
            grid_cart.Columns.Add(cardHeaderDT(i).ColumnName, cardHeaderDT(i).ColumnName)
        Next
    End Sub

    Private Sub ResetAll()
        grid_cart.Rows.Clear()
        cb_customer.SelectedIndex = 0
        cb_staff.SelectedIndex = 0
        lb_product_items.SelectedItem = 0
        box_quantity.Value = box_quantity.Minimum

        lbl_cart_total.Text = "RM 0.00"
        lbl_subtotal.Text = "RM 0.00"

        lbl_product_id.Text = ""
        lbl_product_name.Text = ""
        lbl_product_price.Text = ""
        lbl_product_brand.Text = ""
        lbl_product_stock.Text = ""
        lbl_product_year.Text = ""
        pic_product_picture.Image = My.Resources.no_photo

    End Sub

    Private Sub tb_search_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_search.KeyUp
    End Sub

    Private Sub grid_cart_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles grid_cart.CellValueChanged
        RefreshTotal()
    End Sub

    Private Sub grid_cart_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles grid_cart.RowsAdded
        RefreshTotal()
    End Sub

    Private Sub grid_cart_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles grid_cart.RowsRemoved
        RefreshTotal()
    End Sub
End Class