
Imports System.Data
Imports System.Data.SqlClient

Public Class Edit_member_details

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer

    Private Sub Edit_member_details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=DESKTOP-FN1F9VH;Initial Catalog=Librarydb;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        disp_data()

        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Devision.Show()
        Me.Hide()

    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update [dbo].[New_member] set Name_of_member ='" + txtname.Text + "' , MemberNIC= '" + txtnic.Text + "', Gender = '" + cmbgender.Text + "', Birth_date ='" + DateTimePicker1.Text + "', Position='" + cmbposition.Text + "', Address='" + txtadd.Text + "' where MemberNIC = '" + Txtsearch.Text + "' or Name_of_member= '" + Txtsearch.Text + "' "
        MessageBox.Show("Are you Sure Edit this data?", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        cmd.ExecuteNonQuery()
        disp_data()
    End Sub
    Public Sub disp_data()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from [dbo].[New_member]"
        cmd.ExecuteNonQuery()

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)

        DataGridView1.DataSource = dt


    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        If Txtsearch.Text = "" Then
            MessageBox.Show("Please enter MemberNIC, what do you want to find", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from [dbo].[New_member] where MemberNIC ='" + Txtsearch.Text + "' or Name_of_member ='" + Txtsearch.Text + "'"
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)

            If (dt.Rows.Count > 0) Then

                Dim dr As SqlClient.SqlDataReader
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                While dr.Read
                    txtname.Text = dr.GetString(0).ToString()
                    txtnic.Text = dr.GetString(1).ToString()
                    cmbgender.Text = dr.GetString(2).ToString()
                    DateTimePicker1.Text = dr.GetDateTime(3).Date()
                    cmbposition.Text = dr.GetString(4).ToString()
                    txtadd.Text = dr.GetString(5).ToString()
                End While
                con.Close()
            Else
                MessageBox.Show("No results found", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If
    End Sub

    Private Sub btnbar_Click(sender As Object, e As EventArgs) Handles btnbar.Click
        Txtsearch.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtname.Text = ""
        txtnic.Text = ""
        txtadd.Text = ""
        cmbposition.Text = ""
        cmbgender.Text = ""
        DateTimePicker1.Text = ""

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from [dbo].[New_member] where MemberNIC = '" + Txtsearch.Text + "' or Name_of_member ='" + Txtsearch.Text + "' "
        MessageBox.Show("Do you want to DELETE this data?", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        cmd.ExecuteNonQuery()
        disp_data()
    End Sub
End Class