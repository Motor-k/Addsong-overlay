Public Class Form2
    Const WM_NCHITTEST As Integer = &H84
    Const HTCLIENT As Integer = &H1
    Const HTCAPTION As Integer = &H2
    Dim eventDate As New DateTime
    Dim trypa As New DateTime
    Dim ts As New TimeSpan
    Dim format As String

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case WM_NCHITTEST
                MyBase.WndProc(m)
                If m.Result = HTCLIENT Then m.Result = HTCAPTION
            Case Else
                MyBase.WndProc(m)
        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            trypa = (Now.Hour & ":" & Now.Minute & ":" & Now.Second)
            ts = eventDate - trypa
            tm.Text = ts.Hours.ToString("D2") & ":" & ts.Minutes.ToString("D2") & ":" & ts.Seconds.ToString("D2") ' Hours remaining 

            If ts = TimeSpan.Zero Then
                Timer1.Enabled = False
                tm.Visible = False
                Button3.Enabled = True
                Button3.Visible = True
                hh.Visible = True
                mm.Visible = True
                ss.Visible = True
                Button5.Visible = True
                Button6.Visible = True
                Button7.Visible = True
                Me.Size = New Point(157, 132)
                tm.Location = New Point(12, 48)
                audb.Ctlcontrols.play()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Form1.x, Form1.y + 100)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        eventDate = (hh.Text & ":" & mm.Text & ":" & ss.Text)
        tm.Visible = True
        Button3.Visible = False
        Button3.Enabled = False
        hh.Visible = False
        mm.Visible = False
        ss.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Me.Size = New Point(157, 96)
        tm.Location = New Point(12, 41)
        Timer1.Enabled = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OpenFileDialog1.Title = "Escolha um ficheiro"


        OpenFileDialog1.InitialDirectory = "C:"

        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim strm As System.IO.Stream

        strm = OpenFileDialog1.OpenFile

        audb.URL = OpenFileDialog1.FileName

        If Not (strm Is Nothing) Then
            strm.Close()
        End If
    End Sub
End Class