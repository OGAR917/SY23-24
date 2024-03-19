Public Class frmGame
    Dim movespeed As Integer = 15
    Dim isJumping As Boolean
    Dim coin As Integer
    Private Sub frmGame_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Start()
            Case Keys.Left
                tmrLeft.Start()
            Case Keys.Up
                tmrUp.Start()
                isJumping = True
        End Select
    End Sub

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        PlayerPB.Left += movespeed
    End Sub

    Private Sub frmGame_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Stop()
            Case Keys.Left
                tmrLeft.Stop()
            Case Keys.Up
                tmrUp.Stop()
                isJumping = False
        End Select
    End Sub

    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        PlayerPB.Left -= movespeed
    End Sub

    Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles tmrUp.Tick
        PlayerPB.Top -= movespeed
    End Sub
    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrGameLogic.Start()
    End Sub

    Private Sub tmrGameLogic_Tick(sender As Object, e As EventArgs) Handles tmrGameLogic.Tick
        If PlayerPB.Bounds.IntersectsWith(picGround.Bounds) Then
            tmrGravity.Stop()
        Else
            If isJumping = False Then
                tmrGravity.Start()
            End If
        End If

        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If PlayerPB.Bounds.IntersectsWith(b.Bounds) Then
                        tmrGravity.Stop()
                    End If
                End If
            End If
            If b.Tag = "restart" Then
                If PlayerPB.Bounds.IntersectsWith(b.Bounds) Then
                    PlayerPB.Location = New Point(13, 240)
                End If
            End If
            If b.Tag = "point" Then
                If b.Visible And PlayerPB.Bounds.IntersectsWith(b.Bounds) Then
                    b.Visible = False
                    coin += 1
                    scoreLabel.Text = coin
                End If
            End If
            If b.Tag = "gameover" Then
                If b.Visible And PlayerPB.Bounds.IntersectsWith(b.Bounds) Then
                    b.Visible = False
                    coin = 0
                    scoreLabel.Text = coin
                    tmrGameLogic.Stop()
                End If
            End If
        Next

    End Sub

    Private Sub tmrGravity_Tick(sender As Object, e As EventArgs) Handles tmrGravity.Tick
        PlayerPB.Top += movespeed
    End Sub
End Class
