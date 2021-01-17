Public Class frm_manageproduct_a174652
    Dim CurrentID As String
    Private Sub frm_manageproduct_a174652_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadYear()
        RefreshData()
    End Sub

    Private Sub changePictureBtn_Click(sender As Object, e As EventArgs) Handles changePictureBtn.Click
        Try
            Using ofd As New OpenFileDialog
                Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

                ofd.InitialDirectory = mydesktop
                ofd.FileName = ""
                ofd.Filter = "PNG files (*.png)|*.png"

                If ofd.ShowDialog = DialogResult.OK Then
                    productPicBox.Image = SafeImageFromFile(ofd.FileName)
                    txt_picture.Text = ofd.FileName
                End If
            End Using
        Catch ex As Exception
            MsgBox("An error has been occured while trying to change picture. [Message: " & ex.Message & "]")
        End Try

    End Sub

    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click
        If txt_name.Text = Nothing Or txt_price.Text = Nothing Or txt_brand.Text = Nothing Or txt_socket.Text = Nothing Or txt_year.Text = Nothing Or txt_stock.Text = Nothing Then
            MsgBox("Please fill in the blanks.")
            Return
        End If

        Try
            Dim ID As Integer = Integer.Parse(Mid(CurrentID, 3))
            If txt_picture.Text = Nothing Then
                Dim confirmation = MsgBox("Do you want to save the product without an image?", MsgBoxStyle.YesNo)

                If confirmation = MsgBoxResult.No Then
                    Return
                Else
                    My.Computer.FileSystem.CopyFile("pictures\no-photo.png", "pictures\" & ID & ".png", True)
                End If
            ElseIf txt_picture.Text <> CurDir() & "\pictures\" & ID & ".png" Then
                My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & ID & ".png", True)
            End If

            Dim stmt As Boolean = run_sql_command("UPDATE TBL_PRODUCTS_A174652 SET FLD_PRODUCT_NAME='" & txt_name.Text & "', FLD_PRICE=" & txt_price.Text & ", FLD_BRAND='" & txt_brand.Text & "', FLD_SOCKET='" & txt_socket.Text & "', FLD_MANUFACTURED_YEAR=" & txt_year.Text & ", FLD_STOCK=" & txt_stock.Text & "  WHERE FLD_PRODUCT_ID=" & ID)
            If stmt Then
                MsgBox("`" & txt_name.Text & "` has been updated successfully.")
                RefreshData()
            End If
        Catch ex As Exception
            MsgBox("An error has been occurred. [Message: " & ex.Message & "]")
        End Try
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        Dim delete_confirmation = MsgBox("Are you sure you want to delete product """ & CurrentID & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then
            Try
                run_sql_command("DELETE FROM TBL_PRODUCTS_A174652 WHERE FLD_PRODUCT_ID=" & Integer.Parse(Mid(txt_id.Text, 3)))
                If My.Computer.FileSystem.FileExists("pictures\" & Integer.Parse(Mid(txt_id.Text, 3)) & ".png") Then
                    My.Computer.FileSystem.DeleteFile("pictures\" & Integer.Parse(Mid(txt_id.Text, 3)) & ".png")
                End If

                Beep()
                MsgBox("The product """ & CurrentID & """ has been deleted successfully.")

                RefreshData()
            Catch ex As Exception
                MsgBox("An error has been occurred. [Message: " & ex.Message & "]")
            End Try
        End If
    End Sub

    Private Sub txt_price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_price.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub txt_stock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_stock.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub grd_product_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles grd_product.CellEnter
        Try
            Dim currentRow = grd_product.CurrentRow.Index

            CurrentID = "MB" & Integer.Parse(grd_product(0, currentRow).Value).ToString("000")
            txt_id.Text = CurrentID
            txt_name.Text = grd_product(1, currentRow).Value
            txt_price.Text = grd_product(2, currentRow).Value
            txt_brand.Text = grd_product(3, currentRow).Value
            txt_socket.Text = grd_product(4, currentRow).Value
            txt_year.Text = grd_product(5, currentRow).Value
            txt_stock.Text = grd_product(6, currentRow).Value
            txt_picture.Text = CurDir() & "\pictures\" & Integer.Parse(grd_product(0, currentRow).Value) & ".png"
            productPicBox.Image = SafeImageFromFile("pictures\" & Integer.Parse(grd_product(0, currentRow).Value) & ".png")
        Catch img As System.IO.FileNotFoundException
            txt_picture.Text = ""
            productPicBox.Image = My.Resources.no_photo
        Catch ex As Exception
        End Try
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
End Class