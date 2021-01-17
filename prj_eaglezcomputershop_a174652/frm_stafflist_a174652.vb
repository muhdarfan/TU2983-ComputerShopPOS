Public Class frm_stafflist_a174652
    Private Sub StaffListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFF_A174652")
        grd_staff.Columns(0).HeaderText = "Employee ID"
        grd_staff.Columns(0).DefaultCellStyle.Format = "\EMP000"
        grd_staff.Columns(1).HeaderText = "Employee Name"
        grd_staff.Columns(2).HeaderText = "Employee Phone"
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Close()
    End Sub
End Class