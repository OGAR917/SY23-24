Public Class ClickerControl
    Dim c As New Clicker
    Public Property increment As Integer = 1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        c.increment = increment
        c.Click()
        TextBox1.Text = c.Count
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        c.reset()
        TextBox1.Text = c.Count
    End Sub
End Class
