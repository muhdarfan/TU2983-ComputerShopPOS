Public Class frm_insertstaff_a174652
    Private Sub frm_insertstaff_a174652_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
        txt_id.Text = GenerateID()
    End Sub

    Private Sub txt_phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_phone.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Dim stmt As Boolean = run_sql_command("INSERT INTO TBL_STAFF_A174652 VALUES ('" & Mid(txt_id.Text, 4) & "','" & txt_name.Text & "','" & txt_phone.Text & "')")

        If (stmt) Then
            MsgBox("New staff has been added.")
            RefreshData()
            ClearForm()
        End If
    End Sub

    Private Sub RefreshData()
        grd_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFF_A174652")
        grd_staff.Columns(0).HeaderText = "Employee ID"
        grd_staff.Columns(0).DefaultCellStyle.Format = "\EMP000"
        grd_staff.Columns(1).HeaderText = "Employee Name"
        grd_staff.Columns(2).HeaderText = "Employee Phone"
    End Sub

    Private Sub ClearForm()
        txt_id.Text = GenerateID()
        txt_name.Text = ""
        txt_phone.Text = ""
    End Sub

    Private Function GenerateID() As String
        Dim lastID As String = run_sql_query("SELECT MAX(FLD_STAFF_ID) AS LASTID FROM TBL_STAFF_A174652").Rows(0).Item("LASTID")
        Return "EMP" & (lastID + 1).ToString("000")
    End Function

End Class