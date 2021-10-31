Public Class Form4
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        x.Text = Me.Size.Width
        y.Text = Me.Size.Height
    End Sub
End Class