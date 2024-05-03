Imports System.IO
Imports Microsoft.Win32

Class MainWindow
    Dim grab1 As Color
    Dim grab2 As Color
    Private Sub DrawingCanvas_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingCanvas.MouseMove
        If shapelabel.Content = "Ellipse" Then
            Dim el As New Ellipse
            el.Width = widthSlider.Value
            el.Height = heightSlider.Value
            el.Fill = colorRect1.Fill
            Dim p As Point = Mouse.GetPosition(DrawingCanvas)
            Canvas.SetLeft(el, p.X)
            Canvas.SetTop(el, p.Y)
            If e.LeftButton = MouseButtonState.Pressed Then
                DrawingCanvas.Children.Add(el)
            End If
        End If
        If shapelabel.Content = "Rectangle" Then
            Dim el As New Rectangle
            el.Width = widthSlider.Value
            el.Height = heightSlider.Value
            el.Fill = colorRect1.Fill
            Dim p As Point = Mouse.GetPosition(DrawingCanvas)
            Canvas.SetLeft(el, p.X)
            Canvas.SetTop(el, p.Y)
            If e.LeftButton = MouseButtonState.Pressed Then
                DrawingCanvas.Children.Add(el)
            End If
        End If
    End Sub
    Public Sub ExportToPng(ByVal surface As Canvas)

        Dim sfd As New SaveFileDialog

        sfd.ShowDialog()

        If sfd.FileName Is Nothing Then Return

        Dim transform As Transform = surface.LayoutTransform

        surface.LayoutTransform = Nothing

        Dim size As Size = New Size(surface.Width, surface.Height)

        surface.Measure(size)

        surface.Arrange(New Rect(size))

        Dim renderBitmap As RenderTargetBitmap = New RenderTargetBitmap(CInt(size.Width), CInt(size.Height), 96.0R, 96.0R, PixelFormats.Pbgra32)

        renderBitmap.Render(surface)



        Using outStream As FileStream = New FileStream(sfd.FileName & ".png", FileMode.Create)

            Dim encoder As PngBitmapEncoder = New PngBitmapEncoder()

            encoder.Frames.Add(BitmapFrame.Create(renderBitmap))

            encoder.Save(outStream)

        End Using

        '

        surface.LayoutTransform = transform

        Canvas.SetLeft(DrawingCanvas, 650)

        Canvas.SetTop(DrawingCanvas, 434)

    End Sub
    Private Sub color1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles color1.MouseDown, color2.MouseDown, color3.MouseDown, color4.MouseDown
        colorRect1.Fill = sender.fill
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        DrawingCanvas.Children.RemoveRange(1, DrawingCanvas.Children.Count)
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        DrawingCanvas.Children.RemoveAt(DrawingCanvas.Children.Count - 1)
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        shapelabel.Content = sender.content
    End Sub

    Private Sub ellipseB_Click(sender As Object, e As RoutedEventArgs) Handles ellipseB.Click
        shapelabel.Content = sender.content
    End Sub

    Private Sub Button_Click_3(sender As Object, e As RoutedEventArgs)
        ExportToPng(DrawingCanvas)
    End Sub

    Private Sub color5_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles color5.MouseDown
        grab1 = Color.FromRgb(r.Value, g.Value, b.Value)
        sender.fill = New SolidColorBrush(grab1)
    End Sub

    Private Sub color6_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles color6.MouseDown
        grab2 = Color.FromRgb(r.Value, g.Value, b.Value)
        sender.fill = New SolidColorBrush(grab2)
    End Sub

    Private Sub angleSlider_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double)) Handles angleSlider.ValueChanged
        colorRect1.Fill = New LinearGradientBrush(grab1, grab2, angleSlider.Value)
    End Sub
End Class