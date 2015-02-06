Imports System.Data.SqlClient

Public Class frmStatus

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim con As New SqlConnection

        con.ConnectionString = "Server=AJSHEN-PC\SQLEXPRESS;Database=Checkin-MS;User Id=sa; Password=database1"

        Dim cmd As New SqlCommand

        cmd.Connection = con
        cmd.CommandText = "SELECT S.username, F.startTime, DATEDIFF(minute, F.startTime, F.endTime) AS Planned, DATEDIFF(minute, S.startTime, S.endTime) AS Worked, DATEDIFF(minute, F.startTime, F.endTime) - DATEDIFF(minute, S.startTime, S.endTime) AS Difference FROM Schedule S, FixedSchedule F WHERE S.username = F.username AND S.username  LIKE @username"

        cmd.Parameters.Add(New SqlParameter("@username", "%" + txtSearch.Text + "%"))

        Dim ds As New DataSet
        Dim adapter As New SqlDataAdapter(cmd)
        adapter.Fill(ds)

        grdStatus.DataSource = ds.Tables(0)
    End Sub

 
    Private Sub grdStatus_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdStatus.CellContentClick

        ' Dim ds As New DataSet
        ' grdStatus.DataSource = ds

        'grdStatus.DataMember = "Authors_table"
        ' grdStatus.Rows[3].Cells[1].Style.BackColor = Color.Red    

        'Dim i As Integer

        'If grdStatus.Rows(e.RowIndex).Cells("Difference").Value Then

        ' End If
        'For Each cell As DataGridViewCell In grdStatus.Rows(e.RowIndex).Cells
        'cell.Style.BackColor = Color.Red
        '  Next

        ' For i As Integer = 0 To Me.grdStatus.Rows.Count - 1

        ' Next
        ' If Me.grdStatus.Rows(i).Cells("Difference").Value >= 90 Then
        'Me.grdStatus.Rows(i).Cells("Cell_to_Change").Style.BackColor = Color.Red
        ' End If


        ' grdStatus.Columns(0).DefaultCellStyle.BackColor = Color.Red

    End Sub
    Private Sub SetUpDataGridView()

        Me.Controls.Add(grdStatus)
        grdStatus.ColumnCount = 5

        With grdStatus.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Red
            .ForeColor = Color.White
            .Font = New Font(grdStatus.Font, FontStyle.Bold)
        End With


    End Sub

    Private Sub frmStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class