Imports System.Data.SqlClient

Public Class frmLogin

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'creating the connection
        Dim con As New SqlConnection
        con.ConnectionString = "Server=AJSHEN-PC\SQLEXPRESS;Database=Checkin-MS;User Id=sa; Password=database1"

        'creating a command object
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "SELECT Username, IsAdmin from RegisterEmployee WHERE Username=@username AND Password=@password"


        cmd.Parameters.Add(New SqlParameter("@username", txtUsername.Text))
        cmd.Parameters.Add(New SqlParameter("@password", txtPassword.Text))




        Try
            con.Open()
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows = False Then
                MessageBox.Show("Invalid username / Password")
                Return
            End If
            dr.Read()
            Session.Username = dr("Username").ToString
            Session.IsAdmin = Convert.ToBoolean(dr("IsAdmin"))
            Me.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error connecting! Message:" + ex.Message)
            con.Close()

        End Try

        cmd.CommandText = " INSERT INTO Login (username) VALUES (@username)"

    End Sub

  

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class