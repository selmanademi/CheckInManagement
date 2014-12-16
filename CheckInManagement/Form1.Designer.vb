<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.btnEmployer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEmployee
        '
        Me.btnEmployee.Location = New System.Drawing.Point(54, 26)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(130, 64)
        Me.btnEmployee.TabIndex = 0
        Me.btnEmployee.Text = "Employee"
        Me.btnEmployee.UseVisualStyleBackColor = True
        '
        'btnEmployer
        '
        Me.btnEmployer.Location = New System.Drawing.Point(190, 26)
        Me.btnEmployer.Name = "btnEmployer"
        Me.btnEmployer.Size = New System.Drawing.Size(129, 64)
        Me.btnEmployer.TabIndex = 1
        Me.btnEmployer.Text = "Employer"
        Me.btnEmployer.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 115)
        Me.Controls.Add(Me.btnEmployer)
        Me.Controls.Add(Me.btnEmployee)
        Me.Name = "Form1"
        Me.Text = "Check-in Management System"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEmployee As System.Windows.Forms.Button
    Friend WithEvents btnEmployer As System.Windows.Forms.Button

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        frmEmployee.ShowDialog()

    End Sub

    Private Sub btnEmployer_Click(sender As Object, e As EventArgs) Handles btnEmployer.Click
        frmEmployer.ShowDialog()

    End Sub
End Class
