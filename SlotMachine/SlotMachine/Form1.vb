Imports System.Drawing.Text

Public Class Form1
    Dim WithEvents cs As New money

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Reelcontrol1.spin()
        Reelcontrol2.spin()
        Reelcontrol3.spin()
        Label1.Text = Reelcontrol1.itemValue
        Label2.Text = Reelcontrol2.itemValue
        Label3.Text = Reelcontrol3.itemValue
        Timer1.Enabled = True
        Label4.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs.insertdollar()
        Label4.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.insertfive()
        Label4.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.inserttwenty()
        Label4.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cs.inserthundred()
        Label4.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Reelcontrol1.itemValue
        Label2.Text = Reelcontrol2.itemValue
        Label3.Text = Reelcontrol3.itemValue
        Timer1.Enabled = False
        If Label1.Text = Reelcontrol1.itemValue And Label2.Text = Reelcontrol1.itemValue And Label3.Text = Reelcontrol1.itemValue Then
            cs.inserthundred()
        Else
            cs.remove()
        End If

    End Sub
End Class
