Public Class frm_managestaff_a174652
    Dim CurrentID As String
    Private Sub frm_managestaff_a174652_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
    End Sub

    Private Sub grd_staff_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellEnter
        Dim current_row As Integer = grd_staff.CurrentRow.Index

        CurrentID = "EMP" & Integer.Parse(grd_staff(0, current_row).Value).ToString("000")
        txt_id.Text = CurrentID
        txt_name.Text = grd_staff(1, current_row).Value
        txt_phone.Text = grd_staff(2, current_row).Value
    End Sub

    Private Sub txt_phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_phone.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click
        Dim stmt As Boolean = run_sql_command("UPDATE TBL_STAFF_A174652 SET FLD_STAFF_NAME='" & txt_name.Text & "', FLD_STAFF_PHONE='" & txt_phone.Text & "' WHERE FLD_STAFF_ID=" & Integer.Parse(Mid(CurrentID, 4)))

        If stmt Then
            MsgBox("The staff """ & CurrentID & """ has been successfully updated.")
            RefreshData()
        End If
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        Dim delete_confirmation = MsgBox("Are you sure you want to delete staff """ & CurrentID & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_STAFF_A174652 WHERE FLD_STAFF_ID=" & Integer.Parse(Mid(CurrentID, 4)))
            Beep()
            MsgBox("The staff """ & CurrentID & """ has been successfully deleted.")

            RefreshData()
        End If
    End Sub

    Private Sub RefreshData()
        grd_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFF_A174652")
        grd_staff.Columns(0).HeaderText = "Employee ID"
        grd_staff.Columns(0).DefaultCellStyle.Format = "\EMP000"
        grd_staff.Columns(1).HeaderText = "Employee Name"
        grd_staff.Columns(2).HeaderText = "Employee Phone"
    End Sub

    Private Sub updateButton_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class