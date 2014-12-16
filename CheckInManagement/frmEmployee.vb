Imports System.Data.SqlClient

Public Class frmEmployee

    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click
        'creating the connection
        Dim con As New SqlConnection
        con.ConnectionString = "Server=AJSHEN-PC\SQLEXPRESS;Database=Checkin-MS;User Id=sa; Password=database1"

        'creating a command object
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO SChedule (username, startTime) values (@user, @starttime)"
        cmd.Parameters.Add(New SqlParameter("@user", Session.Username))
        cmd.Parameters.Add(New SqlParameter("@starttime", DateTime.Now))
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        Dim con As New SqlConnection
        con.ConnectionString = "Server=AJSHEN-PC\SQLEXPRESS;Database=Checkin-MS;User Id=sa; Password=database1"

        'creating a command object
        Dim cmd As New SqlCommand
        cmd.Connection = con

        cmd.CommandText = "SELECT * FROM Schedule WHERE username=@username AND DATEPART(dd, startTime) = @day"
        cmd.Parameters.Add(New SqlParameter("@day", DateTime.Now.Day))
        cmd.Parameters.Add(New SqlParameter("@username", Session.Username))

        con.Open()
        Dim id As Integer

        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        If dr.HasRows = False Then
            'rast i vecante
            'nuk ka check in
            'todo
            Return
        End If
        dr.Read()
        id = Convert.ToInt32(dr("ID"))

        con.Close()


        cmd.CommandText = "UPDATE Schedule SET endtime=@et WHERE ID=@ID"
        cmd.Parameters.Clear()
        cmd.Parameters.Add(New SqlParameter("@et", DateTime.Now))
        cmd.Parameters.Add(New SqlParameter("@id", id))
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub btnStatus_Click(sender As Object, e As EventArgs) Handles btnStatus.Click
        frmStatus.ShowDialog()

    End Sub
End Class