<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Me.x = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.y = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'x
        '
        Me.x.AutoSize = True
        Me.x.Location = New System.Drawing.Point(205, 240)
        Me.x.Name = "x"
        Me.x.Size = New System.Drawing.Size(12, 13)
        Me.x.TabIndex = 0
        Me.x.Text = "x"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'y
        '
        Me.y.AutoSize = True
        Me.y.Location = New System.Drawing.Point(243, 240)
        Me.y.Name = "y"
        Me.y.Size = New System.Drawing.Size(12, 13)
        Me.y.TabIndex = 1
        Me.y.Text = "y"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.y)
        Me.Controls.Add(Me.x)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents x As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents y As Label
End Class
