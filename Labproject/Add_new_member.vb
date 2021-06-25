Imports System.Data
Imports System.Data.SqlClient
Public Class Add_new_member

    Private Sub Add_new_member_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Devision.Show()
        Me.Hide()

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If (txtname.Text = "" Or txtnic.Text = "" Or txtadd.Text = "") Then
            MessageBox.Show("Please.. Fill All Fields", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-FN1F9VH;Initial Catalog=Librarydb;Integrated Security=True")
            con.Close()
        Else
           
            Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-FN1F9VH;Initial Catalog=Librarydb;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[New_member]([Name_of_member],[MemberNIC],[Gender],[Birth_date],[Position],[Address]) VALUES('" + txtname.Text + "','" + txtnic.Text + "','" + cmbgender.SelectedItem.ToString() + "','" + DateTimePicker1.Text + "','" + Cmbposition.SelectedItem.ToString() + "','" + txtadd.Text + "')", con)
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("You have successfully Registered member", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtname.Text = ""
            txtnic.Text = ""
            txtadd.Text = ""
            Cmbposition.Text = ""
            cmbgender.Text = ""
            DateTimePicker1.Text = ""
            con.Close()
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtname.Text = ""
        txtnic.Text = ""
        txtadd.Text = ""
        Cmbposition.Text = ""
        cmbgender.Text = ""
        DateTimePicker1.Text = ""

    End Sub
End Class