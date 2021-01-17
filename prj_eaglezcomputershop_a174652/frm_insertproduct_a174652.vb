Public Class frm_insertproduct_a174652
    Private Sub frm_insertproduct_a174652_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
        LoadYear()
        ClearForm()
    End Sub

    Private Sub changePictureBtn_Click(sender As Object, e As EventArgs) Handles changePictureBtn.Click
        Try
            Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

            OpenFileDialog1.InitialDirectory = mydesktop
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.Filter = "PNG files (*.png)|*.png"

            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                productPicBox.Image = SafeImageFromFile(OpenFileDialog1.FileName)
                txt_picture.Text = OpenFileDialog1.FileName
            End If
        Catch ex As Exception
            MsgBox("An error has been occured while trying to change picture. [Message: " & ex.Message & "]")
        End Try
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        If txt_name.Text = Nothing Or txt_price.Text = Nothing Or txt_brand.Text = Nothing Or txt_socket.Text = Nothing Or txt_year.Text = Nothing Or txt_stock.Text = Nothing Then
            MsgBox("Please fill in the blanks.")
            Return
        End If

        Try
            Dim ID As Integer = Integer.Parse(Mid(txt_id.Text, 3))
            If txt_picture.Text = Nothing Then
                Dim confirmation = MsgBox("Do you want to save the product without an image?", MsgBoxStyle.YesNo)

                If confirmation = MsgBoxResult.No Then
                    Return
                Else
                    My.Computer.FileSystem.CopyFile("pictures\no-photo.png", "pictures\" & ID & ".png", True)
                End If
            Else
                My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & ID & ".png", True)
            End If

            Dim stmt As Boolean = run_sql_command("INSERT INTO TBL_PRODUCTS_A174652 VALUES(" & ID & ", '" & txt_name.Text & "', " & txt_price.Text & ", '" & txt_brand.Text & "', '" & txt_socket.Text & "', " & txt_year.Text & ", " & txt_stock.Text & ")")
            If stmt Then
                MsgBox("`" & txt_name.Text & "` has been added successfully to the database.")
                RefreshData()
                ClearForm()
            ElseIf My.Computer.FileSystem.FileExists("pictures\" & ID & ".png") Then
                My.Computer.FileSystem.DeleteFile("pictures\" & ID & ".png")
            End If
        Catch ex As Exception
            MsgBox("An error has been occurred. [Message: " & ex.Message & "]")
        End Try
    End Sub

    Private Sub txt_price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_price.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub txt_stock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_stock.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub LoadYear()
        Dim startYear As Integer = 2010
        Dim currentYear As Integer = Date.Now.Year

        For i = 0 To (currentYear - startYear)
            txt_year.Items.Add(Date.Today.AddYears(-i).ToString("yyyy"))
        Next
    End Sub

    Private Sub RefreshData()
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

    Private Sub ClearForm()
        txt_id.Text = GenerateID()
        txt_picture.Text = ""
        txt_name.Text = ""
        txt_price.Text = ""
        txt_brand.Text = ""
        txt_socket.Text = ""
        txt_year.Text = ""
        txt_stock.Text = ""
        productPicBox.Image = My.Resources.no_photo
    End Sub

    Private Function GenerateID() As String
        Dim lastID As Integer = run_sql_query("SELECT MAX(FLD_PRODUCT_ID) AS LASTID FROM TBL_PRODUCTS_A174652").Rows(0).Item("LASTID") + 1
        Return "MB" & lastID.ToString("000")
    End Function
End Class