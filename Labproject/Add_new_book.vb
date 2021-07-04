Imports System.Data
Imports System.Data.SqlClient

Public Class Add_new_book

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Label6.Click, Label5.Click, Label4.Click, Label3.Click, Label8.Click, Label9.Click

    End Sub

    Private Sub Add_new_book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=DESKTOP-FN1F9VH;Initial Catalog=Librarydb;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        disp_data()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtauthor.TextChanged, txtcopies.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcat.SelectedIndexChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker.ValueChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged, txtfind.TextChanged

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-FN1F9VH;Initial Catalog=Librarydb;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[BookDetails]([Name],[Category],[Author],[PublishDate],[Copies]) VALUES('" + txtname.Text + "','" + cmbcat.SelectedItem.ToString() + "','" + txtauthor.Text + "','" + DateTimePicker.Text + "','" + txtcopies.Text + "')", con)
        con.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("You have successfully added book", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()
        disp_data()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Devision.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtname.Text = ""
        txtauthor.Text = ""
        txtcopies.Text = ""
        cmbcat.Text = ""





    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs)

    End Sub
    Public Sub disp_data()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from [dbo].[BookDetails]"
        cmd.ExecuteNonQuery()

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)

        DataGridView1.DataSource = dt


    End Sub

    Private Sub Btnfind_Click(sender As Object, e As EventArgs) Handles Btnfind.Click
        If txtfind.Text = "" Then
            MessageBox.Show("Please enter MemberNIC, what do you want to find", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from [dbo].[BookDetails] where Name ='" + txtfind.Text + "'"
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)

            If (dt.Rows.Count > 0) Then

                Dim dr As SqlClient.SqlDataReader
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                While dr.Read
                    txtname.Text = dr.GetString(1).ToString()
                    cmbcat.Text = dr.GetString(2).ToString()
                    txtauthor.Text = dr.GetString(3).ToString()
                    DateTimePicker.Text = dr.GetDateTime(4).Date()
                    txtcopies.Text = dr.GetInt32(5)
                End While
                con.Close()
            Else
                MessageBox.Show("No results found", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update [dbo].[BookDetails] set Name ='" + txtname.Text + "' , Category = '" + cmbcat.Text + "', Author = '" + txtauthor.Text + "', PublishDate ='" + DateTimePicker.Text + "', Copies='" + txtcopies.Text + "' where Name = '" + txtfind.Text + "'"
        MessageBox.Show("Are you Sure Edit this data?", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        cmd.ExecuteNonQuery()
        disp_data()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from [dbo].[BookDetails] where Name = '" + txtfind.Text + "'"
        MessageBox.Show("Do you want to DELETE this data?", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        cmd.ExecuteNonQuery()
        disp_data()
    End Sub
End Class