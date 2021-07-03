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


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Label3.Click, Label4.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With Books_returned
            .TopLevel = False
            Panelmain.Controls.Add(Books_returned)
            .BringToFront()
            .Show()



        End With
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
   
    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click, Label7.Click, Label8.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnBTO.Click
        With BooksTakenOut
            .TopLevel = False
            Panelmain.Controls.Add(BooksTakenOut)
            .BringToFront()
            .Show()



        End With
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panelmain.Paint

    End Sub

    Private Sub Btnaddnew_Click(sender As Object, e As EventArgs) Handles Btnaddnew.Click
        With Add_new_book
            .TopLevel = False
            Panelmain.Controls.Add(Add_new_book)
            .BringToFront()
            .Show()



        End With
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        With Add_new_member
            .TopLevel = False
            Panelmain.Controls.Add(Add_new_member)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        With Edit_member_details
            .TopLevel = False
            Panelmain.Controls.Add(Edit_member_details)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class