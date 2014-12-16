Imports System.Data.SqlClient

Public Class frmRegisterEmployee

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim con As New SqlConnection
        con.ConnectionString = "Server=AJSHEN-PC\SQLEXPRESS;Database=Checkin-MS;User Id=sa; Password=database1"

        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO RegisterEmployee(FirstName,LastName,Address,Email,Phone,Username,Password,Gender) VALUES(@FirstName,@LastName,@Address,@Email,@Phone,@Username,@Password, @Gender)"

        cmd.Parameters.Add(New SqlParameter("@FirstName", txtFirstName.Text))
        cmd.Parameters.Add(New SqlParameter("@LastName", txtLastName.Text))
        cmd.Parameters.Add(New SqlParameter("@Username", txtUsername.Text))
        cmd.Parameters.Add(New SqlParameter("@Password", txtPassword.Text))
        cmd.Parameters.Add(New SqlParameter("@Address", txtAddress.Text))       
        cmd.Parameters.Add(New SqlParameter("@Email", txtEmail.Text))
        cmd.Parameters.Add(New SqlParameter("@Phone", txtPhone.Text))

        If rdbMale.Checked Then

            cmd.Parameters.Add(New SqlParameter("@Gender", "M"))

        Else
            cmd.Parameters.Add(New SqlParameter("@Gender", "F"))

        End If


        Try
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Employee registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            MessageBox.Show("Employee was not registered! The error message was: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()

        End Try




    End Sub

End Class