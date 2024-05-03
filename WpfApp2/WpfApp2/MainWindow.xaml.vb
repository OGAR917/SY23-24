Class MainWindow
    Private Sub ccNum_TextChanged(sender As Object, e As TextChangedEventArgs) Handles ccNum.TextChanged
        If Not PayB Is Nothing Then
            If ccNum.Text Like "################" Then

                PayB.IsEnabled = True
            Else
                PayB.IsEnabled = False
            End If
        End If
    End Sub
    Private Sub cvcTb_TextChanged(sender As Object, e As TextChangedEventArgs) Handles cvcTb.TextChanged
        If cvcTb.Text Like "###" Then
            PayB.IsEnabled = True
        Else
            PayB.IsEnabled = False
        End If
    End Sub
    Private Sub dateTb_TextChanged(sender As Object, e As TextChangedEventArgs) Handles dateTb.TextChanged
        If dateTb.Text Like "##*##" Then
            PayB.IsEnabled = True
        Else
            PayB.IsEnabled = False
        End If
    End Sub

    Private Sub clearB_Click(sender As Object, e As RoutedEventArgs) Handles clearB.Click
        dateTb.Text = ""
        ccNum.Text = ""
        dateTb.Text = ""
        nameTb.Text = ""
        cvcTb.Text = ""
    End Sub

    Private Sub emailTb_TextChanged(sender As Object, e As TextChangedEventArgs) Handles emailTb.TextChanged
        If emailTb.Text Like "***************" Then
            PayB.IsEnabled = True
        Else
            PayB.IsEnabled = False
        End If
    End Sub
End Class
