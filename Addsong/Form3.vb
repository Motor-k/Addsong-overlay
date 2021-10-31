Public Class Form3
    Dim meh As String = Now.Date
    Dim time As DateTime = DateTime.Now
    Dim format As String = "HH:mm"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim time As DateTime = DateTime.Now
        Dim format As String = "HH:mm"

        Timer1.Enabled = True
        My.Computer.Clipboard.SetText(time.ToString(format) & " H (LIS) : ")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim time As DateTime = DateTime.Now
        Dim format As String = "HH:mm"
        'Programmatically copy time

        My.Computer.Clipboard.SetText(time.ToString(format) & " H (LIS) : ")

    End Sub
End Class