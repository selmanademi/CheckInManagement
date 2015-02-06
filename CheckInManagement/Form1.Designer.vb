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
        Me.btnEmployer = New System.Windows.Forms.Button()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEmployer
        '
        Me.btnEmployer.Image = Global.CheckInManagement.My.Resources.Resources._1
        Me.btnEmployer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmployer.Location = New System.Drawing.Point(85, 84)
        Me.btnEmployer.Name = "btnEmployer"
        Me.btnEmployer.Size = New System.Drawing.Size(92, 64)
        Me.btnEmployer.TabIndex = 1
        Me.btnEmployer.Text = "Employer"
        Me.btnEmployer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEmployer.UseVisualStyleBackColor = True
        '
        'btnEmployee
        '
        Me.btnEmployee.Image = Global.CheckInManagement.My.Resources.Resources.m
        Me.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmployee.Location = New System.Drawing.Point(85, 171)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(93, 64)
        Me.btnEmployee.TabIndex = 0
        Me.btnEmployee.Text = "Employee"
        Me.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEmployee.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = Global.CheckInManagement.My.Resources.Resources.checkineasylogo21
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(269, 268)
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
