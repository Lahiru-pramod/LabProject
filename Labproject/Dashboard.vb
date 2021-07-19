Public Class Dashboard

    Private Sub ExitFromSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitFromSystemToolStripMenuItem.Click
        End
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub MainDashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainDashboardToolStripMenuItem.Click
        With Main_control_Screen
            .TopLevel = False
            Panel1.Controls.Add(Main_control_Screen)
            .BringToFront()
            .Show()



        End With
    End Sub

    Private Sub LogoutFromSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutFromSystemToolStripMenuItem.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        Main_control_Screen.Close()
        MsgBox("This is a Library Management System. It has been made for HND RAD Assignment by me. I'am N.Lahiru Pramod De Silva (GAL-IT-2019-F-0005)", MsgBoxStyle.Information, "About project")
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class