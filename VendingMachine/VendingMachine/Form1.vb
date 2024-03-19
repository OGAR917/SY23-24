Public Class Form1
    Dim WithEvents cs As New CoinSlot
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.insertnickles()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cs.insertquarter()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs.insertdimes()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.insertdollars()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cs.coinreturn()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub cs_coinreturnevent(d As Integer, q As Integer, di As Integer, n As Integer) Handles cs.coinreturnevent
        If d > 0 Then
            DollarCoin.Visible = True
        Else
            DollarCoin.Visible = False
        End If
        If q > 0 Then
            QPB.Visible = True
        Else
            QPB.Visible = False
        End If
        If di > 0 Then
            DiPB.Visible = True
        Else
            DiPB.Visible = False
        End If
        If n > 0 Then
            NPB.Visible = True
        Else
            NPB.Visible = False
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Select Case IDTextBox.Text
            Case ProductControl1.ProductID
                cs.buy(ProductControl1)
            Case ProductControl2.ProductID
                cs.buy(ProductControl2)
            Case ProductControl3.ProductID
                cs.buy(ProductControl3)
            Case ProductControl4.ProductID
                cs.buy(ProductControl4)
            Case ProductControl5.ProductID
                cs.buy(ProductControl5)
            Case ProductControl6.ProductID
                cs.buy(ProductControl6)
            Case ProductControl7.ProductID
                cs.buy(ProductControl7)
            Case ProductControl8.ProductID
                cs.buy(ProductControl8)
            Case ProductControl9.ProductID
                cs.buy(ProductControl9)
            Case ProductControl10.ProductID
                cs.buy(ProductControl10)
            Case ProductControl11.ProductID
                cs.buy(ProductControl11)
            Case ProductControl12.ProductID
                cs.buy(ProductControl12)
            Case ProductControl13.ProductID
                cs.buy(ProductControl13)
            Case ProductControl14.ProductID
                cs.buy(ProductControl14)
            Case ProductControl15.ProductID
                cs.buy(ProductControl15)
            Case ProductControl16.ProductID
                cs.buy(ProductControl16)
            Case 2

            Case Else

        End Select
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub cs_buyevent(p As Image) Handles cs.buyevent
        ProductPicture.Image = p
    End Sub
End Class
