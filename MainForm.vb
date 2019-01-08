Public Class MainForm
    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Max.state = NORMAL Or Max.state = REVIVE Then
            Max.state = NORMAL
            If e.KeyCode = Keys.Left Then
                Max.Speed.X = -Max.StartSpeed.X
                Max.facingRight = False
            End If

            If e.KeyCode = Keys.Right Then
                Max.Speed.X = Max.StartSpeed.X
                Max.facingRight = True
            End If

            If e.KeyCode = Keys.Up And Max.onFloor = True Then
                Max.Speed.Y = -Max.StartSpeed.Y
            End If
        End If



    End Sub

    Private Sub MainForm_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Then
            Max.Speed.X = 0
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim index As Integer

        Call LoadSprite(Max, "Galacticat.png", 15, 11, 17, 300, 380)
        Max.Speed.X = 0
        Max.state = NORMAL

        For index = 0 To NUMBADGUYS
            If index Mod 2 = 0 Then
                Call LoadSprite(Badguys(index), "Fangs.png", 10, 5, 17, 107, 40)
            Else
                Call LoadSprite(Badguys(index), "Fangs.png", 10, -5, 17, 528, 40)
            End If
        Next index

        Call LoadBackground()
        Call FloorSet()
        Call DrawScreenSet()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim index As Integer

        Call MoveSprite(Max)

        TimerCounter += 1
        NumMovingBadguys = TimerCounter / 50
        If NumMovingBadguys > NUMBADGUYS Then
            NumMovingBadguys = NUMBADGUYS
        End If

        For index = 0 To NumMovingBadguys
            Call MoveSprite(Badguys(index))
        Next


        Call MoveSprite(Badguys(0))
        Call AnimateMax()
        Call AnimateBadGuy()
        Call CheckKillMax()
        Call CheckKillBadguys()
        Call ReviveMax()
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
        Dim index As Integer
        g = picDrawOnScreen.CreateGraphics
        offG = Graphics.FromImage(imageOffScreen)

        Call BackgroundDraw()
        Call DrawSprite(Max)
        For index = 0 To NumMovingBadguys
            Call DrawSprite(Badguys(index))
        Next index


        g.DrawImage(imageOffScreen, 0, 0)
        g.Dispose()
        offG.Dispose()
    End Sub



End Class
