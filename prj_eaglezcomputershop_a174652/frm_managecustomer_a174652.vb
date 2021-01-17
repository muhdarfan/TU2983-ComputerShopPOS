Public Class frm_managecustomer_a174652
    Dim CurrentID As String
    Private Sub frm_managecustomer_a174652_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
    End Sub

    Private Sub grd_customer_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles grd_customer.CellEnter
        Dim currentRow = grd_customer.CurrentRow.Index

        CurrentID = "C" & Integer.Parse(grd_customer(0, currentRow).Value).ToString("000")
        txt_id.Text = CurrentID
        txt_name.Text = grd_customer(1, currentRow).Value
        txt_address.Text = grd_customer(2, currentRow).Value
        txt_phone.Text = grd_customer(3, currentRow).Value
    End Sub

    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click
        Dim stmt As Boolean = run_sql_command("UPDATE TBL_CUSTOMER_A174652 SET FLD_CUSTOMER_NAME='" & txt_name.Text & "', FLD_CUSTOMER_ADDRESS='" & String.Join(",", txt_address.Lines) & "', FLD_CUSTOMER_PHONE='" & txt_phone.Text & "' WHERE FLD_CUSTOMER_ID=" & Integer.Parse(Mid(CurrentID, 2)))

        If stmt Then
            MsgBox("The customer """ & CurrentID & """ has been successfully updated.")
            RefreshData()
        End If
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        Dim delete_confirmation = MsgBox("Are you sure you want to delete customer """ & CurrentID & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_CUSTOMER_A174652 WHERE FLD_CUSTOMER_ID=" & Integer.Parse(Mid(CurrentID, 2)))
            Beep()
            MsgBox("The customer """ & CurrentID & """ has been deleted successfully.")

            RefreshData()
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
End Class