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
                Max.Speed.Y = -(Max.StartSpeed.Y + 12)
            End If

            If e.KeyCode = Keys.Space And Max.onFloor = True Then
                Call UseItemShop()
            End If

            If e.KeyCode = Keys.LShiftKey And Max.onFloor And MaxHasMilk = True Then
                Call UseItemShopMilk()
            End If
        End If
    End Sub

    Private Sub MainForm_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Then
            Max.Speed.X = 0
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        quit = False
        levelNumber = 1
        lblLevelNumber.Text = "Level: " + levelNumber.ToString
        Call ResetLevel()
        lblScore.Text = "Score: 0"
        BackPackMilk.Visible = False
        Call LoadBackground()
        Call FloorSet()
        Call DrawScreenSet()
        My.Computer.Audio.Play(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\sounds\ChillingMusic.wav",
                                                                                AudioPlayMode.BackgroundLoop)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim index As Integer

        If quit = True Then
            Me.Close()
        End If

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
        Call CheckMilkButton()
        Call ReviveMax()
        Call ScreenDraw()
        Call CheckGameOver()
        Call CheckYouWin()

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
        If quit = False Then
            g = picDrawOnScreen.CreateGraphics
            offG = Graphics.FromImage(imageOffScreen)

            Call BackgroundDraw()
            Call DrawSprite(Max)
            Call DrawSprite(ItemShop)


            If Milk.state = NORMAL Then
                Call DrawSprite(Milk)
            End If

            'If MaxHasMilk = True Then
            '    Call DrawSprite(ItemShopMilk)
            'End If

            For index = 0 To NumMovingBadguys
                Call DrawSprite(Badguys(index))
            Next index


            g.DrawImage(imageOffScreen, 0, 0)
            g.Dispose()
            offG.Dispose()

        End If

    End Sub

    Private Sub ResetLevel()
        Dim index As Integer
        quit = False
        score = 0

        Call LoadSprite(Max, "Galacticat.png", 15, 11, 17, 300, 380)
        Max.Speed.X = 0
        Max.state = NORMAL
        LivesLeft = 3

        Call LoadSprite(Milk, "milk.png", 1, 0, 0, 300, 300)
        Call LoadSprite(ItemShop, "shop.png", 1, 0, 0, 200, 60)

        For index = 0 To NUMBADGUYS
            If index Mod 2 = 0 Then
                Call LoadSprite(Badguys(index), "Fangs.png", 10, 5, 17, 107, 40)
            Else
                Call LoadSprite(Badguys(index), "Fangs.png", 10, -5, 17, 528, 40)
            End If
        Next index
        lblLives.Text = "Lives: "
        '+ LivesLeft.ToString
        TimerCounter = 0
        NumBadGuysKilled = 0
    End Sub

    Public Sub CheckGameOver()
        If Max.state = DEAD Then
            If LivesLeft <= 0 Then
                Timer1.Stop()
                frmGameOver.ShowDialog()
                If quit = True Then
                    Me.Close()
                End If
                levelNumber = 1
                lblLevelNumber.Text = "Level: " + levelNumber.ToString
                Call ResetLevel()
                Timer1.Start()
            End If
        End If
    End Sub

    Public Sub CheckYouWin()
        If NumBadGuysKilled > NUMBADGUYS Then
            Timer1.Stop()
            frmYouWin.ShowDialog()
            If quit = True Then
                Me.Close()
            End If
            levelNumber += 1
            lblLevelNumber.Text = "Level: " + levelNumber.ToString
            Call ResetLevel()
            Timer1.Start()
        End If
    End Sub

    Public Sub UseItemShop()

        If Collision(Max, ItemShop) Then
            Timer1.Stop()
            frmItemShop.ShowDialog()
        End If
    End Sub



End Class
