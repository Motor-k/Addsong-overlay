<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tm = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.audb = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.hh = New System.Windows.Forms.TextBox()
        Me.mm = New System.Windows.Forms.TextBox()
        Me.ss = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Devbut = New System.Windows.Forms.Button()
        CType(Me.audb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Magenta
        Me.Label3.Location = New System.Drawing.Point(35, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Timer"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'tm
        '
        Me.tm.BackColor = System.Drawing.Color.Transparent
        Me.tm.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tm.ForeColor = System.Drawing.Color.Magenta
        Me.tm.Location = New System.Drawing.Point(12, 41)
        Me.tm.Name = "tm"
        Me.tm.Size = New System.Drawing.Size(133, 25)
        Me.tm.TabIndex = 5
        Me.tm.Text = "00:00:00"
        Me.tm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tm.Visible = False
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Magenta
        Me.Button1.Location = New System.Drawing.Point(138, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(16, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "x"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Magenta
        Me.Button2.Location = New System.Drawing.Point(116, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(16, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "-"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Magenta
        Me.Button3.Location = New System.Drawing.Point(39, 80)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(78, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Start"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'audb
        '
        Me.audb.Enabled = True
        Me.audb.Location = New System.Drawing.Point(24, 137)
        Me.audb.Name = "audb"
        Me.audb.OcxState = CType(resources.GetObject("audb.OcxState"), System.Windows.Forms.AxHost.State)
        Me.audb.Size = New System.Drawing.Size(121, 23)
        Me.audb.TabIndex = 11
        Me.audb.Visible = False
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Magenta
        Me.Button4.Location = New System.Drawing.Point(8, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(16, 23)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "♫"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'hh
        '
        Me.hh.Location = New System.Drawing.Point(32, 51)
        Me.hh.Name = "hh"
        Me.hh.Size = New System.Drawing.Size(27, 20)
        Me.hh.TabIndex = 13
        '
        'mm
        '
        Me.mm.Location = New System.Drawing.Point(65, 51)
        Me.mm.Name = "mm"
        Me.mm.Size = New System.Drawing.Size(27, 20)
        Me.mm.TabIndex = 14
        '
        'ss
        '
        Me.ss.Location = New System.Drawing.Point(98, 51)
        Me.ss.Name = "ss"
        Me.ss.Size = New System.Drawing.Size(27, 20)
        Me.ss.TabIndex = 15
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Black
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Magenta
        Me.Button5.Location = New System.Drawing.Point(35, 30)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(21, 19)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "HH"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Black
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Magenta
        Me.Button6.Location = New System.Drawing.Point(67, 30)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(21, 19)
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "M"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Black
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Magenta
        Me.Button7.Location = New System.Drawing.Point(100, 30)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(21, 19)
        Me.Button7.TabIndex = 18
        Me.Button7.Text = "S"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Devbut
        '
        Me.Devbut.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Devbut.FlatAppearance.BorderSize = 0
        Me.Devbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Devbut.ForeColor = System.Drawing.Color.Magenta
        Me.Devbut.Location = New System.Drawing.Point(1, 108)
        Me.Devbut.Name = "Devbut"
        Me.Devbut.Size = New System.Drawing.Size(153, 23)
        Me.Devbut.TabIndex = 19
        Me.Devbut.Text = "Developed by::Gustavo Bule"
        Me.Devbut.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(157, 132)
        Me.Controls.Add(Me.Devbut)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.ss)
        Me.Controls.Add(Me.mm)
        Me.Controls.Add(Me.hh)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.audb)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tm)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(157, 150)
        Me.Name = "Form2"
        Me.Opacity = 0.85R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form2"
        Me.TopMost = True
        CType(Me.audb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents tm As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents audb As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Button4 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents hh As TextBox
    Friend WithEvents mm As TextBox
    Friend WithEvents ss As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Devbut As Button
End Class
