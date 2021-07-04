Public Class Main_control_Screen

    Private Sub Main_control_Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs)
       
    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Label3.Click, Label4.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Add_new_member.Close()
        Edit_admin_data.Close()
        Add_new_book.Close()
        BooksTakenOut.Close()
        Calculator.Close()
        Edit_member_details.Close()

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
        Add_new_member.Close()
        Edit_admin_data.Close()
        Add_new_book.Close()
        Books_returned.Close()
        Calculator.Close()
        Edit_member_details.Close()

        With BooksTakenOut
            Panelmain.Controls.Clear()
            .TopLevel = False
            Panelmain.Controls.Add(BooksTakenOut)
            .BringToFront()
            .Show()



        End With
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panelmain.Paint

    End Sub

    Private Sub Btnaddnew_Click(sender As Object, e As EventArgs) Handles Btnaddnew.Click
        Add_new_member.Close()
        Edit_admin_data.Close()
        Books_returned.Close()
        BooksTakenOut.Close()
        Calculator.Close()
        Edit_member_details.Close()
        With Add_new_book
            .TopLevel = False
            Panelmain.Controls.Add(Add_new_book)
            .BringToFront()
            .Show()



        End With
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Edit_admin_data.Close()
        Add_new_book.Close()
        Books_returned.Close()
        BooksTakenOut.Close()
        Calculator.Close()
        Edit_member_details.Close()

        Dim newmember As New Form()
        Panelmain.Controls.Clear()
        Add_new_member.TopLevel = False
        Add_new_member.WindowState = FormWindowState.Maximized
        Add_new_member.Visible = True
        Panelmain.Controls.Add(Add_new_member)
        Add_new_member.Show()





    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Add_new_member.Close()
        Edit_admin_data.Close()
        Add_new_book.Close()
        Books_returned.Close()
        BooksTakenOut.Close()
        Calculator.Close()

        Dim newmember As New Form()
        Panelmain.Controls.Clear()
        Edit_member_details.TopLevel = False
        Edit_member_details.WindowState = FormWindowState.Maximized
        Edit_member_details.Visible = True
        Panelmain.Controls.Add(Edit_member_details)
        Edit_member_details.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Add_new_member.Close()
        Edit_admin_data.Close()
        Add_new_book.Close()
        Books_returned.Close()
        BooksTakenOut.Close()
        Edit_member_details.Close()
        With Calculator
            .TopLevel = False
            Panelmain.Controls.Add(Calculator)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Panelmain.Controls.Clear()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Add_new_member.Close()
        Add_new_book.Close()
        Books_returned.Close()
        BooksTakenOut.Close()
        Edit_member_details.Close()
        Calculator.Close()
        With Edit_admin_data
            .TopLevel = False
            Panelmain.Controls.Add(Edit_admin_data)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub
End Class