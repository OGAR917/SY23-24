Class MainWindow
    Dim usdollar As Decimal
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Decimal.TryParse(dollarTB.Text, usdollar)
        convertedTB.Text = USdollar * 1.07
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Decimal.TryParse(dollarTB.Text, usdollar)
        convertedTB.Text = usdollar * 0.0065
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        Decimal.TryParse(dollarTB.Text, usdollar)
        convertedTB.Text = usdollar * 1.24
    End Sub

    Private Sub Button_Click_3(sender As Object, e As RoutedEventArgs)
        Decimal.TryParse(dollarTB.Text, usdollar)
        convertedTB.Text = usdollar * 0.059
    End Sub

    Private Sub Button_Click_4(sender As Object, e As RoutedEventArgs)
        Decimal.TryParse(dollarTB.Text, usdollar)
        convertedTB.Text = usdollar * 0.73
    End Sub

    Private Sub Button_Click_5(sender As Object, e As RoutedEventArgs)
        Decimal.TryParse(dollarTB.Text, usdollar)
        convertedTB.Text = usdollar * 0.14
    End Sub

    Private Sub Button_Click_6(sender As Object, e As RoutedEventArgs)
        dollarTB.Text = ""
        convertedTB.Text = ""
    End Sub
End Class
