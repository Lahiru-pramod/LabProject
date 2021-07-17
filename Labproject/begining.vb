Public Class begining

    Private Sub begining_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value >= 100 Then
            Timer1.Stop()
            ProgressBar1.Value = 0
            Label1.Text = "LOADING COMPLEATED!"
            login.Show()
            Me.Hide()
        End If
        ProgressBar1.Value += 1
        Label1.Text = "PLEASE WAIT.... LOADING." & ProgressBar1.Value & "%"
    End Sub
End Class