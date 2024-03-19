Public Class ProductControl
    Public Property ProductID As String
    Public Property ProductPrice As Decimal
    Public Property ProductImage As Image
    Public Property ProductCount As Integer

    Private Sub ProductControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IDLabel.Text = ProductID
        PriceLabel.Text = ProductPrice.ToString("c2")
        PictureBox1.Image = ProductImage
    End Sub
    Sub buy()
        If ProductCount > 0 Then
            ProductCount = ProductCount - 1
        End If
        If ProductCount = 0 Then
            PictureBox1.Image = Nothing
        End If
    End Sub
End Class
