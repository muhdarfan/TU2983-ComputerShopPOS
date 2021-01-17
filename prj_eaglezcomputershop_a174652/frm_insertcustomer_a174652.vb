Public Class frm_insertcustomer_a174652
    Private Sub frm_addcustomer_a174652_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
        txt_id.Text = GenerateID()
    End Sub

    Private Sub txt_phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_phone.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Dim stmt As Boolean = run_sql_command("INSERT INTO TBL_CUSTOMER_A174652 VALUES ('" & Mid(txt_id.Text, 2) & "', '" & txt_name.Text & "', '" & String.Join(", ", txt_address.Lines) & "', '" & txt_phone.Text & "')")

        If stmt Then
            MsgBox("Successfully added new customer '" & txt_name.Text & "' to database.")
            RefreshData()
            ClearForm()
        End If
    End Sub

    Private Sub RefreshData()
        grd_customer.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMER_A174652")
        grd_customer.Columns(0).HeaderText = "Customer ID"
        grd_customer.Columns(0).DefaultCellStyle.Format = "\C000"
        grd_customer.Columns(1).HeaderText = "Name"
        grd_customer.Columns(2).HeaderText = "Address"
        grd_customer.Columns(3).HeaderText = "Phone"
    End Sub

    Private Function GenerateID() As String
        Dim lastID As String = run_sql_query("SELECT MAX(FLD_CUSTOMER_ID) AS LASTID FROM TBL_CUSTOMER_A174652").Rows(0).Item("LASTID")
        Return "C" & (lastID + 1).ToString("000")
    End Function

    Private Sub ClearForm()
        txt_id.Text = GenerateID()
        txt_name.Text = ""
        txt_address.Text = ""
        txt_phone.Text = ""
    End Sub
End Class