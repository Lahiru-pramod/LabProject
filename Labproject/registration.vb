Imports System.Data
Imports System.Data.SqlClient

Public Class registration

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click, Label6.Click, Label7.Click, Label9.Click, Label8.Click, Label10.Click, lblcomment.Click

    End Sub

    Private Sub btnsignin_Click(sender As Object, e As EventArgs) Handles btnsignin.Click

        If (txtpassword.Text = txtpassword2.Text) Then
            Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-FN1F9VH;Initial Catalog=Librarydb;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[Admindata]([Firstname],[Lastname],[Age],[Gender],[Address],[Email],[Password] ,[RePassword]) VALUES('" + txtfname.Text + "','" + txtlname.Text + "','" + txtage.Text + "','" + cmbgender.SelectedItem.ToString() + "','" + txtadd.Text + "','" + txtemail.Text + "','" + txtpassword.Text + "','" + txtpassword2.Text + "')", con)
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("You have Register Successfully! and Go Back to the Sign in", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
        Else
            lblcomment.Text = "Password and Re-password are not matching..try again"
            Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-FN1F9VH;Initial Catalog=Librarydb;Integrated Security=True")
            Con.Close()

        End If

    End Sub

    Private Sub registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()



    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        login.Show()
        Me.Hide()





    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class