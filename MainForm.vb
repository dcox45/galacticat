Public Class MainForm
    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Left Then
            Max.Speed.X = -Max.StartSpeed.X
            Max.facingRight = False
        End If

        If e.KeyCode = Keys.Right Then
            Max.Speed.X = Max.StartSpeed.X
            Max.facingRight = True
        End If

        If e.KeyCode = Keys.Up Then
            Max.Speed.Y = -Max.StartSpeed.Y
        End If


    End Sub

    Private Sub MainForm_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Then
            Max.Speed.X = 0
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call LoadMax()
        Call LoadBackground()
        Call FloorSet()
        Call DrawScreenSet()


        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Call MoveMax()
        Call AnimateMax()
        Call ScreenDraw()

    End Sub

    Private Sub DrawScreenSet()
        imageOffScreen = backdrop.Picture.Clone
        picDrawOnScreen.Left = backdrop.Position.X
        picDrawOnScreen.Top = backdrop.Position.Y
        picDrawOnScreen.Width = backdrop.Width
        picDrawOnScreen.Height = backdrop.Height
    End Sub

    Private Sub ScreenDraw()
        g = picDrawOnScreen.CreateGraphics
        offG = Graphics.FromImage(imageOffScreen)

        Call BackgroundDraw()
        Call MaxDraw()

        g.DrawImage(imageOffScreen, 0, 0)
        g.Dispose()
        offG.Dispose()
    End Sub



End Class
