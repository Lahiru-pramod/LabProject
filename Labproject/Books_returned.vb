Imports System.Data
Imports System.Data.SqlClient


Public Class Books_returned
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Devision.Show()
        Me.Hide()

    End Sub

    Private Sub Books_returned_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=DESKTOP-FN1F9VH;Initial Catalog=Librarydb;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        disp_data()
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        If txtname.Text = "" Or txtmember.Text = "" Or txtnic.Text = "" Or DateTimePicker1.Text = "" Or DateTimePicker2.Text = "" Then
            MessageBox.Show("Please! Fill-up all field", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO [dbo].[Books_returned]([Name_of_book],[Name_of_member],[MemberNIC],[DOI],[Return_date],[Fines]) VALUES('" + txtname.Text + "','" + txtmember.Text + "','" + txtnic.Text + "','" + DateTimePicker1.Text + "','" + DateTimePicker2.Text + "','" + txtfines.Text + "')"
            cmd.ExecuteNonQuery()

            disp_data()
            txtname.Text = ""
            txtmember.Text = ""
            txtnic.Text = ""
            DateTimePicker1.Text = ""
            DateTimePicker2.Text = ""
            txtfines.Text = ""
            MessageBox.Show("You have successfully Added Record", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()

        End If
    End Sub
    Public Sub disp_data()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from [dbo].[Books_returned]"
        cmd.ExecuteNonQuery()

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)

        DataGridView1.DataSource = dt


    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update [dbo].[Books_returned] set Name_of_book ='" + txtname.Text + "' , Name_of_member= '" + txtmember.Text + "', MemberNIC = '" + txtnic.Text + "',DOI='" + DateTimePicker1.Text + "',Return_date='" + DateTimePicker2.Text + "',Fines='" + txtfines.Text + "' where MemberNIC = '" + Txtsearch.Text + "' "
        cmd.ExecuteNonQuery()
        disp_data()
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
            cmd.CommandText = "select * from [dbo].[Books_returned] where MemberNIC ='" + Txtsearch.Text + "'"
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)

            If (dt.Rows.Count > 0) Then

                Dim dr As SqlClient.SqlDataReader
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                While dr.Read
                    txtname.Text = dr.GetString(0).ToString()
                    txtmember.Text = dr.GetString(1).ToString()
                    txtnic.Text = dr.GetString(2).ToString()
                    DateTimePicker1.Text = dr.GetDateTime(3).Date()
                    DateTimePicker2.Text = dr.GetDateTime(4).Date()
                    txtfines.Text = dr.GetInt32(5).ToString()

                End While
                con.Close()
            Else
                MessageBox.Show("No results found", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from [dbo].[Books_returned] where MemberNIC = '" + Txtsearch.Text + "' "
        cmd.ExecuteNonQuery()
        disp_data()
    End Sub

    Private Sub btnbar_Click(sender As Object, e As EventArgs) Handles btnbar.Click
        Txtsearch.Text = ""
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtname.Text = ""
        txtmember.Text = ""
        txtnic.Text = ""
        DateTimePicker1.Text = ""
        DateTimePicker2.Text = ""
        txtfines.Text = ""

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class