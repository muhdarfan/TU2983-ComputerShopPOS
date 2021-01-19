Public Class frm_splashscreen_a174652
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel2.Width += 10
        If (Panel2.Width >= 620) Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub frm_splashscreen_a174652_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        Application.Exit()
    End Sub
End Class