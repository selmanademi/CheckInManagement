Imports System.Data.SqlClient

Public Class frmEmployee

    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click


        'creating the connection
        Dim con As New SqlConnection
        con.ConnectionString = "Server=AJSHEN-PC\SQLEXPRESS;Database=Checkin-MS;User Id=sa; Password=database1"

        'creating a command object
        Dim cmd As New SqlCommand
        cmd.Connection = con

        cmd.CommandText = "SELECT COUNT(*) FROM Schedule WHERE username = @user and DATEPART(dd, startTime) = @day AND DATEPART(mm, startTime) = @month AND DATEPART(yy, startTime) = @year"
        cmd.Parameters.Add(New SqlParameter("@user", Session.Username))
        cmd.Parameters.Add(New SqlParameter("@day", DateTime.Now.Day))
        cmd.Parameters.Add(New SqlParameter("@month", DateTime.Now.Month))
        cmd.Parameters.Add(New SqlParameter("@year", DateTime.Now.Year))
        con.Open()
        If Not cmd.ExecuteScalar().ToString() = "0" Then
            MsgBox("You have already checked-in for today", MsgBoxStyle.Critical, "Check-in Completed!")
            con.Close()
            Return
        End If
        con.Close()

        cmd.Parameters.Clear()

        cmd.CommandText = "INSERT INTO SChedule (username, startTime) values (@user, @starttime)"
        cmd.Parameters.Add(New SqlParameter("@user", Session.Username))
        cmd.Parameters.Add(New SqlParameter("@starttime", DateTime.Now))

        con.Open()
        cmd.ExecuteNonQuery()
        MsgBox("You checked-in succesfully!", MsgBoxStyle.Information, "Success")
        con.Close()

        Dim startTime As Date = Now
        ' Run the process that is to be timed. 
        Dim runLength As Global.System.TimeSpan = Now.Subtract(startTime)
        Dim millisecs As Integer = runLength.Milliseconds


    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        Dim con As New SqlConnection
        con.ConnectionString = "Server=AJSHEN-PC\SQLEXPRESS;Database=Checkin-MS;User Id=sa; Password=database1"
        Dim cmd As New SqlCommand("SELECT [ID], username, startTime, endTime FROM Schedule where username=@username AND DATEPART(dd, startTime) = @day AND DATEPART(mm, startTime) = @month AND DATEPART(yy, startTime) = @year AND endTime IS Null", con)

        cmd.Parameters.Add(New SqlParameter("@username", Session.Username))
        cmd.Parameters.Add(New SqlParameter("@day", DateTime.Now.Day))
        cmd.Parameters.Add(New SqlParameter("@month", DateTime.Now.Month))
        cmd.Parameters.Add(New SqlParameter("@year", DateTime.Now.Year))
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        If dr.HasRows Then
            Dim id As Integer
            If dr.Read Then
                id = Convert.ToInt32(dr("ID"))
                'MsgBox("Ok " & id)
                con.Close()
            Else
                'MsgBox("Not Ok " & id)
                con.Close()
            End If
            cmd.CommandText = "UPDATE SChedule SET [endTime] = @endTime WHERE [ID]= @id"
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlParameter("@endTime", DateTime.Now))
            cmd.Parameters.Add(New SqlParameter("@id", id))
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Check-Out Completed Successfully !", MsgBoxStyle.Information, "Success")
            con.Close()
        Else
            'rast i vecante
            'nuk ka check in
            'todo
            con.Close()
            If IsThereExcuse() = False Then
                MsgBox("There is no check-in ! Do you want to add excuse ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "No Check-in!")
                If MsgBoxResult.Yes Then


                    cmd.Parameters.Clear()

                    cmd.CommandText = "INSERT INTO SChedule (username, startTime, endTime, excuse) values (@user, @starttime, @endtime, @excuse)"
                    cmd.Parameters.Add(New SqlParameter("@user", Session.Username))
                    cmd.Parameters.Add(New SqlParameter("@starttime", DateTime.Now))
                    cmd.Parameters.Add(New SqlParameter("@endtime", DateTime.Now))
                    cmd.Parameters.Add(New SqlParameter("@excuse", InputBox("Please Write short Justification", "Excuse Promt")))
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MsgBox("Excuse Added !", MsgBoxStyle.Information, "Success")
                Else
                    MsgBox("Excuse Canceled !", MsgBoxStyle.Information, "Canceled")
                End If

                Return
                con.Close()
            Else
                MsgBox("You have already checked-out for today!", MsgBoxStyle.Critical, "Check-out Completed")
                con.Close()
                Exit Sub
            End If
        End If
    End Sub
    Private Function IsThereExcuse() As Boolean
        Dim con2 As New SqlConnection
        con2.ConnectionString = "Server=AJSHEN-PC\SQLEXPRESS;Database=Checkin-MS;User Id=sa; Password=database1"
        Dim cmd2 As New SqlCommand("SELECT [ID], username, startTime, endTime FROM Schedule where username=@username AND DATEPART(dd, startTime) = @day AND DATEPART(mm, startTime) = @month AND DATEPART(yy, startTime) = @year AND DATEPART(dd, endTime) = @day AND DATEPART(mm, endTime) = @month AND DATEPART(yy, endTime) = @year", con2)

        cmd2.Parameters.Add(New SqlParameter("@username", Session.Username))
        cmd2.Parameters.Add(New SqlParameter("@day", DateTime.Now.Day))
        cmd2.Parameters.Add(New SqlParameter("@month", DateTime.Now.Month))
        cmd2.Parameters.Add(New SqlParameter("@year", DateTime.Now.Year))
        con2.Open()
        Dim dr2 As SqlDataReader = cmd2.ExecuteReader()
        If dr2.HasRows Then
            Return True
        Else
            Return False
        End If
        con2.Close()
    End Function
    Private Sub btnStatus_Click(sender As Object, e As EventArgs) Handles btnStatus.Click
        frmStatus.ShowDialog()

    End Sub

    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class