<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployer
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
        Me.btnRegisterEmployee = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRegisterEmployee
        '
        Me.btnRegisterEmployee.Location = New System.Drawing.Point(21, 126)
        Me.btnRegisterEmployee.Name = "btnRegisterEmployee"
        Me.btnRegisterEmployee.Size = New System.Drawing.Size(110, 51)
        Me.btnRegisterEmployee.TabIndex = 5
        Me.btnRegisterEmployee.Text = "Register Employee"
        Me.btnRegisterEmployee.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Location = New System.Drawing.Point(149, 126)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(110, 51)
        Me.btnReports.TabIndex = 6
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'frmEmployer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = Global.CheckInManagement.My.Resources.Resources.checkineasylogo21
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(279, 221)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnRegisterEmployee)
        Me.Name = "frmEmployer"
        Me.Text = "frmEmployer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRegisterEmployee As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
End Class
