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
            Devision.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid User or Password", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If







    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Close()

    End Sub

    Private Sub btnreg_Click(sender As Object, e As EventArgs) Handles btnreg.Click
        registration.Show()
        Me.Hide()
    End Sub
End Class