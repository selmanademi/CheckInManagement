<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee
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
        Me.btnCheckOut = New System.Windows.Forms.Button()
        Me.btnCheckIn = New System.Windows.Forms.Button()
        Me.btnStatus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCheckOut
        '
        Me.btnCheckOut.Location = New System.Drawing.Point(149, 150)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(100, 71)
        Me.btnCheckOut.TabIndex = 4
        Me.btnCheckOut.Text = "Check-OUT"
        Me.btnCheckOut.UseVisualStyleBackColor = True
        '
        'btnCheckIn
        '
        Me.btnCheckIn.Location = New System.Drawing.Point(29, 150)
        Me.btnCheckIn.Name = "btnCheckIn"
        Me.btnCheckIn.Size = New System.Drawing.Size(102, 71)
        Me.btnCheckIn.TabIndex = 3
        Me.btnCheckIn.Text = "Check-IN"
        Me.btnCheckIn.UseVisualStyleBackColor = True
        '
        'btnStatus
        '
        Me.btnStatus.Location = New System.Drawing.Point(104, 96)
        Me.btnStatus.Name = "btnStatus"
        Me.btnStatus.Size = New System.Drawing.Size(75, 34)
        Me.btnStatus.TabIndex = 5
        Me.btnStatus.Text = "My Status"
        Me.btnStatus.UseVisualStyleBackColor = True
        '
        'frmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = Global.CheckInManagement.My.Resources.Resources.checkineasylogo21
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(285, 255)
        Me.Controls.Add(Me.btnStatus)
        Me.Controls.Add(Me.btnCheckOut)
        Me.Controls.Add(Me.btnCheckIn)
        Me.Name = "frmEmployee"
        Me.Text = "frmEmployee"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCheckOut As System.Windows.Forms.Button
    Friend WithEvents btnCheckIn As System.Windows.Forms.Button
    Friend WithEvents btnStatus As System.Windows.Forms.Button
End Class
