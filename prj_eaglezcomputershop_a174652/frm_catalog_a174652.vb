Public Class frm_catalog_a174652
    Private Sub frm_catalog_a174652_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load Data to Data Grid
        lst_product.DataSource = run_sql_query("SELECT FLD_PRODUCT_NAME FROM TBL_PRODUCTS_A174652 ORDER BY FLD_PRODUCT_ID ASC")
        lst_product.DisplayMember = "FLD_PRODUCT_NAME"

        SelectData(lst_product.Text)
    End Sub

    Private Sub lst_product_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_product.MouseClick
        SelectData(lst_product.Text)
    End Sub

    Private Sub SelectData(name As String)
        Try
            Dim ProductData As New DataTable
            ProductData = run_sql_query("SELECT * FROM TBL_PRODUCTS_A174652 WHERE FLD_PRODUCT_NAME = '" & name & "'")

            lbl_name.Text = ProductData.Rows(0).Item("FLD_PRODUCT_NAME")
            lbl_price.Text = "RM " & Integer.Parse(ProductData.Rows(0).Item("FLD_PRICE")).ToString("0.00")
            lbl_brand.Text = ProductData.Rows(0).Item("FLD_BRAND")
            lbl_socket.Text = ProductData.Rows(0).Item("FLD_SOCKET")
            lbl_year.Text = ProductData.Rows(0).Item("FLD_MANUFACTURED_YEAR")
            lbl_stock.Text = ProductData.Rows(0).Item("FLD_STOCK")
            productPicBox.Image = SafeImageFromFile("pictures/" & ProductData.Rows(0).Item("FLD_PRODUCT_ID") & ".png")
        Catch ex As System.IO.FileNotFoundException
            productPicBox.Image = My.Resources.no_photo
        Catch ex1 As Exception
            MsgBox("An error has been occurred. [Message: " & vbCrLf & vbCrLf & ex1.Message & "]")
        End Try
    End Sub
End Class