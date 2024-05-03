Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim d As Integer
        Dim m As Integer
        pic1.Opacity = 0
        pic2.Opacity = 0
        pic3.Opacity = 0
        pic4.Opacity = 0
        pic5.Opacity = 0
        pic6.Opacity = 0
        pic7.Opacity = 0
        pic8.Opacity = 0
        pic9.Opacity = 0
        pic10.Opacity = 0
        pic11.Opacity = 0
        pic12.Opacity = 0
        m = cal1.SelectedDate.Value.Month
        d = cal1.SelectedDate.Value.Day
        If m = 3 And d >= 21 Then
            pic1.Opacity = 100
            label1.Content = "Aries"
        End If
        If m = 4 And d <= 19 Then
            pic1.Opacity = 100
            label1.Content = "Aries"
        End If
        If m = 4 And d >= 20 Then
            pic2.Opacity = 100
            label1.Content = "Taurus"
        End If
        If m = 5 And d <= 20 Then
            pic2.Opacity = 100
            label1.Content = "Taurus"
        End If
        If m = 5 And d >= 21 Then
            pic3.Opacity = 100
            label1.Content = "Gemini"
        End If
        If m = 6 And d <= 20 Then
            pic3.Opacity = 100
            label1.Content = "Gemini"
        End If
        If m = 6 And d >= 21 Then
            pic4.Opacity = 100
            label1.Content = "Cancer"
        End If
        If m = 7 And d <= 22 Then
            pic4.Opacity = 100
            label1.Content = "Cancer"
        End If
        If m = 7 And d >= 23 Then
            pic5.Opacity = 100
            label1.Content = "Leo"
        End If
        If m = 8 And d <= 22 Then
            pic5.Opacity = 100
            label1.Content = "Leo"
        End If
        If m = 8 And d >= 23 Then
            pic6.Opacity = 100
            label1.Content = "Virgo"
        End If
        If m = 9 And d <= 22 Then
            pic6.Opacity = 100
            label1.Content = "Virgo"
        End If
        If m = 9 And d >= 23 Then
            pic7.Opacity = 100
            label1.Content = "Libra"
        End If
        If m = 10 And d <= 22 Then
            pic7.Opacity = 100
            label1.Content = "Libra"
        End If
        If m = 10 And d >= 23 Then
            pic8.Opacity = 100
            label1.Content = "Scorpio"
        End If
        If m = 11 And d <= 21 Then
            pic8.Opacity = 100
            label1.Content = "Scorpio"
        End If
        If m = 11 And d >= 22 Then
            pic9.Opacity = 100
            label1.Content = "Sagittarius"
        End If
        If m = 12 And d <= 21 Then
            pic9.Opacity = 100
            label1.Content = "Sagittarius"
        End If
        If m = 12 And d >= 22 Then
            pic10.Opacity = 100
            label1.Content = "Capricorn"
        End If
        If m = 1 And d <= 19 Then
            pic10.Opacity = 100
            label1.Content = "Capricorn"
        End If
        If m = 1 And d >= 20 Then
            pic11.Opacity = 100
            label1.Content = "Aquarius"
        End If
        If m = 2 And d <= 18 Then
            pic11.Opacity = 100
            label1.Content = "Aquarius"
        End If
        If m = 2 And d >= 19 Then
            pic12.Opacity = 100
            label1.Content = "Pisces"
        End If
        If m = 3 And d <= 20 Then
            pic12.Opacity = 100
            label1.Content = "Pisces"
        End If
    End Sub
End Class
