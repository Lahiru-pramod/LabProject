Imports System.Data
Imports System.Data.SqlClient

Public Class Add_new_book

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Label6.Click, Label5.Click, Label4.Click, Label3.Click

    End Sub

    Private Sub Add_new_book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtauthor.TextChanged, txtcopies.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcat.SelectedIndexChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker.ValueChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-FN1F9VH;Initial Catalog=Librarydb;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[BookDetails]([Name],[Category],[Author],[PublishDate],[Copies]) VALUES('" + txtname.Text + "','" + cmbcat.SelectedItem.ToString() + "','" + txtauthor.Text + "','" + DateTimePicker.Text + "','" + txtcopies.Text + "')", con)
        con.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("You have successfully added book", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Devision.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtname.Text = ""
        txtauthor.Text = ""
        txtcopies.Text = ""
        cmbcat.Text = ""





    End Sub
End Class