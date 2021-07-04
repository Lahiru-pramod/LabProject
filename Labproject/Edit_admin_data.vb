Imports System.Data
Imports System.Data.SqlClient

Public Class Edit_admin_data
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer

    Private Sub Edit_admin_data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=DESKTOP-FN1F9VH;Initial Catalog=Librarydb;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        disp_data()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from [dbo].[Admindata] where Email = '" + Txtsearch.Text + "' "
        MessageBox.Show("Are you sure REMOVE THIS ADMIN?", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        cmd.ExecuteNonQuery()
        disp_data()
        txtfname.Text = ""
        txtlname.Text = ""
        cmbgender.Text = ""
        txtage.Text = ""
        txtemail.Text = ""
        Txtadd.Text = ""


    End Sub

    Public Sub disp_data()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from [dbo].[Admindata]"
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
            cmd.CommandText = "select * from [dbo].[Admindata] where Email ='" + Txtsearch.Text + "'"
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)

            If (dt.Rows.Count > 0) Then

                Dim dr As SqlClient.SqlDataReader
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                While dr.Read
                    txtfname.Text = dr.GetString(0).ToString()
                    txtlname.Text = dr.GetString(1).ToString()
                    txtage.Text = dr.GetDouble(2)
                    cmbgender.Text = dr.GetString(3).ToString()
                    Txtadd.Text = dr.GetString(4).ToString()
                    txtemail.Text = dr.GetString(5).ToString()
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
End Class