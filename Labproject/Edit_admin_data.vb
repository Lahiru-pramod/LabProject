Public Class Edit_admin_data

    Private Sub Edit_admin_data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Devision.Show()
        Me.Hide()
    End Sub
End Class