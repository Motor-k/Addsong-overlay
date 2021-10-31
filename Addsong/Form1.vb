Imports System.IO

Public Class Form1
    Const WM_NCHITTEST As Integer = &H84
    Const HTCLIENT As Integer = &H1
    Const HTCAPTION As Integer = &H2
    Public x As Integer
    Public y As Integer

    Dim activ As Integer = 0
    Dim md As Integer = 0

    Dim patha As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

    'Dim folderpath As String = patha & "\Rockstar Games\GTA V\User Music"

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case WM_NCHITTEST
                MyBase.WndProc(m)
                If m.Result = HTCLIENT Then m.Result = HTCAPTION
            Case Else
                MyBase.WndProc(m)
        End Select
    End Sub

    Protected Overrides ReadOnly Property CreateParams As System.Windows.Forms.CreateParams
        Get
            Dim Cp As CreateParams = MyBase.CreateParams
            Cp.Style = (Cp.Style And &HFFDFFFFF)
            Return Cp
        End Get
    End Property

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim patas() As String = IO.Directory.GetFiles(patha & "\Rockstar Games\GTA V\User Music", "*.mp3*")

        'Dim fich As String
        'Randomize()

        'If System.IO.Directory.Exists(folderpath) Then

        '    For Each file As String In patas
        '        fich = Path.GetFileName(file)
        '        ListBox1.Items.Add(file)
        '        lb.Items.Add(fich)
        '    Next
        '    titl.Location = New Point(-2, 4)
        '    Try
        '        ListBox1.SelectedIndex = Int(Rnd() * ListBox1.Items.Count)
        '        audb.URL = ListBox1.SelectedItem
        '    Catch ex As Exception
        '        ListBox1.SelectedIndex = 0
        '        audb.URL = ListBox1.SelectedItem
        '    End Try
        'End If

        Me.Height = 75

        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Me.Height - 50
        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop
        audb.settings.volume = TrackBar1.Value
        Me.AllowDrop = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim time As DateTime = DateTime.Now
        Dim format As String = "HH:mm"
        Label2.Text = time.ToString(format)
        titl.Text = audb.currentMedia.name
        If titl.Width > 99 Then
            titl.Left -= 0.7
            If titl.Location.X = Panel1.Location.X - titl.Width Then
                titl.Location = New Point(Panel1.Width, 4)
            End If
        End If
        x = Me.Location.X
        y = Me.Location.Y
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If activ = 0 Then
            activ = 1
            audb.Ctlcontrols.pause()
            Button2.Text = "▶"
        ElseIf activ = 1 Then
            activ = 0
            audb.Ctlcontrols.play()
            Button2.Text = "❚❚"
        End If
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        audb.settings.volume = TrackBar1.Value
    End Sub

    Private Sub Form1_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        Dim result As String
        For Each way In files
            result = path.GetFileName(way)
            ListBox1.Items.Add(way)
            lb.Items.Add(result)
        Next
        titl.Location = New Point(-2, 4)
        ListBox1.SelectedIndex = 0
        audb.URL = ListBox1.SelectedItem
    End Sub

    Private Sub Form1_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub ttcp_Tick(sender As Object, e As EventArgs) Handles ttcp.Tick
        Randomize()

        Try
            ListBox1.SelectedIndex = Int(Rnd() * ListBox1.Items.Count)
        Catch ex As Exception
            ListBox1.SelectedIndex = 0
        End Try
        titl.Location = New Point(-2, 4)
        lb.SelectedIndex = ListBox1.SelectedIndex
        audb.URL = ListBox1.SelectedItem
        audb.Ctlcontrols.play()
        ttcp.Enabled = False
    End Sub
    Private Sub AxWindowsMediaPlayer1_PlayStateChange(ByVal sender As Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles audb.PlayStateChange
        If audb.playState = WMPLib.WMPPlayState.wmppsStopped Then
            ttcp.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ttcp.Enabled = True

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If md = 0 Then
            Me.Height = 150
            md = 1
        Else
            Me.Height = 75
            md = 0
        End If
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb.SelectedIndexChanged
        ListBox1.SelectedIndex = lb.SelectedIndex
        titl.Location = New Point(-2, 4)
        audb.URL = ListBox1.SelectedItem
        audb.Ctlcontrols.play()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()

        For Each ctrl As Control In Me.Controls
            If TypeOf (ctrl) Is Label Then
                ctrl.ForeColor = ColorDialog1.Color
            End If
        Next
        For Each ctrl As Control In Me.Controls
            If TypeOf (ctrl) Is Button Then
                ctrl.ForeColor = ColorDialog1.Color
            End If
        Next

        For Each ctrl As Control In Form2.Controls
            If TypeOf (ctrl) Is Label Then
                ctrl.ForeColor = ColorDialog1.Color
            End If
        Next
        For Each ctrl As Control In Form2.Controls
            If TypeOf (ctrl) Is Button Then
                ctrl.ForeColor = ColorDialog1.Color
            End If
        Next

        titl.ForeColor = ColorDialog1.Color
        lb.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub TimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimerToolStripMenuItem.Click
        Form2.Show()

    End Sub
End Class
