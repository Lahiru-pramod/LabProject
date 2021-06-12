Public Class Calculator
    Dim book As Integer
    Dim days As Integer

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click, Label4.Click, Label5.Click

    End Sub

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncal.Click

        book = txtbook.Text
        days = txtdays.Text

        Label5.Text = (days * 20) * book & ".00"

    End Sub

    Private Sub txtbook_TextChanged(sender As Object, e As EventArgs) Handles txtbook.TextChanged

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Label5.Text = ""
        txtbook.Text = ""
        txtdays.Text = ""

    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Devision.Show()
        Me.Hide()
    End Sub
End Class