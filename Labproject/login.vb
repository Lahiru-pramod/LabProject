Imports System.Data
Imports System.Data.SqlClient

Public Class login

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnsignin.Click

        Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-FN1F9VH;Initial Catalog=Librarydb;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM Admindata WHERE Email='" + txtuser.Text + "' AND Password ='" + txtpassword.Text + "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            Dashboard.Show()
            Me.Hide()
            txtuser.Text = ""
            txtpassword.Text = ""
        Else
            MessageBox.Show("Invalid User or Password", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If







    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End

    End Sub

    Private Sub btnreg_Click(sender As Object, e As EventArgs) Handles btnreg.Click
        registration.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged

    End Sub

    Private Sub txtuser_TextChanged(sender As Object, e As EventArgs) Handles txtuser.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class