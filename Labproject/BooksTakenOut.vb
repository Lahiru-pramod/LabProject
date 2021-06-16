Imports System.Data
Imports System.Data.SqlClient


Public Class BooksTakenOut
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtnic.TextChanged

    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtmember.TextChanged

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged

    End Sub
    Private Sub BooksTakenOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=DESKTOP-FN1F9VH;Initial Catalog=Librarydb;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        disp_data()

        Me.CenterToScreen()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtname.Text = ""
        txtmember.Text = ""
        txtnic.Text = ""
        DateTimePicker1.Text = ""
        DateTimePicker2.Text = ""


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnok.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "INSERT INTO [dbo].[Books_taken_out]([Book_name],[Name_of_member],[MemberNIC],[DOI],[DOR]) VALUES('" + txtname.Text + "','" + txtmember.Text + "','" + txtnic.Text + "','" + DateTimePicker1.Text + "','" + DateTimePicker2.Text + "')"
        cmd.ExecuteNonQuery()

        disp_data()

        MessageBox.Show("You have successfully Added Record", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
      
    End Sub


    Public Sub disp_data()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from [dbo].[Books_taken_out]"
        cmd.ExecuteNonQuery()

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)

        DataGridView1.DataSource = dt


    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnupdate.Click

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update [dbo].[Books_taken_out] set Book_name ='" + txtname.Text + "' , Name_of_member= '" + txtmember.Text + "', MemberNIC = '" + txtnic.Text + "',DOI='" + DateTimePicker1.Text + "',DOR='" + DateTimePicker2.Text + "' where MemberNIC = '" + Txtsearch.Text + "' "
        cmd.ExecuteNonQuery()
        disp_data()



    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from [dbo].[Books_taken_out] where MemberNIC ='" + Txtsearch.Text + "'"
        cmd.ExecuteNonQuery()

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Dim dr As SqlClient.SqlDataReader
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        While dr.Read
            txtname.Text = dr.GetString(0).ToString()
            txtmember.Text = dr.GetString(1).ToString()
            txtnic.Text = dr.GetString(2).ToString()
            DateTimePicker1.Text = dr.GetDateTime(3).Date()
            DateTimePicker2.Text = dr.GetDateTime(4).Date()


        End While
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from [dbo].[Books_taken_out] where MemberNIC = '" + Txtsearch.Text + "' "
        cmd.ExecuteNonQuery()
        disp_data()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnbar.Click
        Txtsearch.Text = ""
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Devision.Show()
        Me.Hide()
    End Sub
End Class