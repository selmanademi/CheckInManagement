Imports System.Data.SqlClient


Public Class frmReport

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.ConnectionString = "Server=AJSHEN-PC\SQLEXPRESS;Database=Checkin-MS;User Id=sa; Password=database1"

        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM Schedule"

        Dim ds As New DataSet
        Dim adapter As New SqlDataAdapter(cmd)
        adapter.Fill(ds)

        cmbDay.DataSource = ds.Tables(0)
        cmbDay.ValueMember = "ID"
        cmbDay.DisplayMember = "username"


    End Sub


    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        cmd.Parameters.Clear()
        cmd.CommandText = "SELECT * FROM Schedule"

        cmd.Parameters.Add(New SqlParameter("@Day", cmbDay.SelectedValue))

        Dim adapter As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        adapter.Fill(ds)
        grdReport.DataSource = ds.Tables(0)

    End Sub
End Class