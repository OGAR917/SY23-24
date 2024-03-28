Public Class shelby
    Dim msrp As Integer = 153000
    Dim apr As Decimal
    Dim term As Integer
    Dim total As Decimal
    Private Sub hellcat_load(sender As Object, e As EventArgs) Handles MyBase.Load
        msrpL.Text = msrp.ToString("c2")
    End Sub
    Sub calPayment()
        Decimal.TryParse(aprTb.Text, apr)
        Integer.TryParse(termTb.Text, term)
        montlyPayTb.Text = (msrp * apr) / term.ToString("c2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        calPayment()
    End Sub
End Class