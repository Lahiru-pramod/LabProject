Public Class Books_returned

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Devision.Show()
        Me.Hide()

    End Sub

    Private Sub Books_returned_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class