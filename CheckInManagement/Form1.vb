
Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim login As New frmLogin
        login.ShowDialog()

        While Session.Username = ""
            login.ShowDialog()
        End While

        If Session.IsAdmin Then
            btnEmployee.Visible = False
            btnEmployer.Visible = True
        Else
            btnEmployee.Visible = True
            btnEmployer.Visible = False
        End If
    End Sub
End Class