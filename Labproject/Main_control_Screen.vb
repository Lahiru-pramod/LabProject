Public Class Main_control_Screen

    Private Sub Main_control_Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs)
        With Calculator
            .TopLevel = False
            Panel1.Controls.Add(Calculator)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class