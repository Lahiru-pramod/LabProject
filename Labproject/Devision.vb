Public Class Devision

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub Devision_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Calculator.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Add_new_book.Show()
        Me.Hide()

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BooksTakenOut.Show()
        Me.Hide()
    End Sub
End Class