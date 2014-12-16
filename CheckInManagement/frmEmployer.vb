Public Class frmEmployer

    Private Sub btnRegisterEmployee_Click(sender As Object, e As EventArgs) Handles btnRegisterEmployee.Click
        frmRegisterEmployee.ShowDialog()

    End Sub


    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        frmReport.ShowDialog()

    End Sub
End Class