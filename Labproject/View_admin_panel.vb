Public Class View_admin_panel

    Private Sub View_admin_panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Devision.Show()
        Me.Hide()
    End Sub
End Class