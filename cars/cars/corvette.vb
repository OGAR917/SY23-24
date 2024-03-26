Public Class corvette
    Dim msrp As Integer = 130000
    Private Sub corvette_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        msrpL.Text = msrp.ToString("c2")
    End Sub
End Class