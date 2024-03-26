Public Class Form2
    Dim count As Integer
    Dim count6 As Integer
    Dim count2 As Integer
    Dim count3 As Integer
    Dim count4 As Integer
    Dim count5 As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        count += 1
        TextBox2.Text = count
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        count2 += 1
        TextBox3.Text = count2
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        count3 += 1
        TextBox4.Text = count3
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        count4 += 1
        TextBox5.Text = count4
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        count5 += 1
        TextBox6.Text = count5
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        count6 += 1
        TextBox7.Text = count6
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox8.Text = (count * 138.34) + (count2 * 80.89) + (count3 * 90.99) + (count4 * 199.0) + (count5 * 68.89) + (count6 * 497.98)
        Label14.Visible = True
    End Sub
End Class