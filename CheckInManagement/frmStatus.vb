Imports System.Data.SqlClient

Public Class frmStatus

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim con As New SqlConnection

        con.ConnectionString = "Server=AJSHEN-PC\SQLEXPRESS;Database=Checkin-MS;User Id=sa; Password=database1"

        Dim cmd As New SqlCommand

        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM Schedule WHERE username LIKE @username"

        cmd.Parameters.Add(New SqlParameter("@username", "%" + txtSearch.Text + "%"))

        Dim ds As New DataSet
        Dim adapter As New SqlDataAdapter(cmd)
        adapter.Fill(ds)

        grdStatus.DataSource = ds.Tables(0)
    End Sub

 
End Class