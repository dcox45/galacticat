Module ModSprite

    Structure Sprite

        Dim Picture As Bitmap
        Dim CellWidth As Integer
        Dim CellHeight As Integer
        Dim CellCount As Integer
        Dim StartPosition As Point
        Dim Position As Point
        Dim Speed As Point
        Dim StartSpeed As Point
        Dim mRectangle As Rectangle
        Dim CellTop As Integer
        Dim facingRight As Boolean
        Dim onFloor As Boolean
        Dim radius As Integer
        Dim state As Integer 'the state of the sprite
        Dim timeflipped As Integer

    End Structure

    Public Const GRAVITY As Integer = 3
    Public NUMBADGUYS As Integer = 6
    Public Const NORMAL As Integer = 0
    Public Const DEAD As Integer = 1
    Public Const REVIVE As Integer = 2
    Public Const FLIP As Integer = 3

    Public Max As Sprite
    Public Badguys(NUMBADGUYS) As Sprite
    Public Milk As Sprite
    Public ItemShop As Sprite
    Public ItemShopMilk As Sprite

    'Public bckpckmilk As PictureBox

    Public NumMovingBadguys As Integer
    Public TimerCounter As Integer
    Public LivesLeft As Integer
    Public quit As Boolean
    Public levelNumber As Integer
    Public NumBadGuysKilled As Integer
    Public MaxHasMilk As Boolean

    Public score As Integer





    Public Sub LoadSprite(ByRef Guy As Sprite, ByVal picname As String, ByVal numCells As Integer,
                          ByVal xspeed As Integer, ByVal yspeed As Integer, ByVal xpos As Integer,
                          ByVal ypos As Integer)
        Guy.Picture = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) &
                                     "\pics\" + picname)
        Guy.CellCount = numCells
        Guy.CellWidth = Guy.Picture.Width
        Guy.CellHeight = Guy.Picture.Height / Guy.CellCount
        Guy.StartPosition.X = xpos
        Guy.StartPosition.Y = ypos
        Guy.Position.X = Guy.StartPosition.X
        Guy.Position.Y = Guy.StartPosition.Y
        Guy.Speed.X = xspeed
        Guy.Speed.Y = yspeed
        Guy.StartSpeed.X = xspeed
        Guy.StartSpeed.Y = yspeed
        Guy.facingRight = True
        Guy.state = NORMAL

        If Guy.CellWidth < Guy.CellHeight Then
            Guy.radius = Guy.CellWidth / 2
        Else
            Guy.radius = Guy.CellHeight / 2
        End If

        Guy.mRectangle.Width = Guy.CellWidth
        Guy.mRectangle.Height = Guy.CellHeight
        Guy.mRectangle.X = Guy.Position.X
        Guy.mRectangle.Y = Guy.Position.Y
    End Sub

    Public Sub MoveSprite(ByRef Guy As Sprite)
        Guy.Speed.Y = GetVerticalSpeed(Guy)
        Guy.Position.X += Guy.Speed.X
        Guy.Position.Y += Guy.Speed.Y

        Guy.mRectangle.X = Guy.Position.X
        Guy.mRectangle.Y = Guy.Position.Y

        If Guy.Position.X > (650 + Guy.CellWidth) Then
            Guy.Position.X = 0 - Guy.CellWidth
        ElseIf Guy.Position.X + Guy.CellWidth < 0 Then
            Guy.Position.X = 650
        End If

        If Guy.state <> DEAD Then
            'Loops around sides of screen
            If Guy.Position.X + Guy.CellWidth < 0 Then
                Guy.Position.X = 650
            ElseIf Guy.Position.X > 650 Then
                Guy.Position.X = 0 - Guy.CellWidth
            End If

            'Go through sides at bottom of screen and appear at the top of the screen
            If Guy.Position.X < 0 And Guy.Position.Y > 360 Then
                Guy.Position.X = 568 - Guy.CellWidth
                Guy.Position.Y = 20
            ElseIf Guy.Position.X > backdrop.Width And Guy.Position.Y > 360 Then
                Guy.Position.X = 80
                Guy.Position.Y = 20
            End If

        Else
            If Guy.Position.Y > 1000 Then
                Guy.Position.Y = 1000
                Guy.Position.X = 0

            End If
        End If

    End Sub

    Public Sub DrawSprite(ByRef Guy As Sprite)
        offG.DrawImage(Guy.Picture, Guy.mRectangle, 0, Guy.CellTop, Guy.CellWidth,
                       Guy.CellHeight, System.Drawing.GraphicsUnit.Pixel)
    End Sub

    Public Sub AnimateMax()
        Max.CellTop += Max.CellHeight
        If Max.state = NORMAL Then
            If Max.Speed.X > 0 And Max.onFloor = True Then
                If Max.CellTop > Max.CellHeight * 2 Then
                    Max.CellTop = 0
                End If
            ElseIf Max.Speed.X < 0 And Max.onFloor = True Then
                If Max.CellTop < Max.CellHeight * 3 Or Max.CellTop > Max.CellHeight * 5 Then
                    Max.CellTop = Max.CellHeight * 3
                End If
            ElseIf Max.Speed.X = 0 And Max.onFloor = True Then
                If Max.facingRight = True Then
                    Max.CellTop = Max.CellHeight * 6
                Else
                    Max.CellTop = Max.CellHeight * 7
                End If
            ElseIf Max.onFloor = False Then
                If Max.facingRight = True Then
                    Max.CellTop = Max.CellHeight * 8
                Else
                    Max.CellTop = Max.CellHeight * 9
                End If
            End If
        ElseIf Max.state = DEAD Then
            If Max.CellTop < Max.CellHeight * 12 Or Max.CellTop > Max.CellHeight * 13 Then
                Max.CellTop = Max.CellHeight * 12
            End If
        ElseIf Max.state = REVIVE Then
            Max.CellTop = Max.CellHeight * 14
        End If
    End Sub

    Public Sub AnimateBadGuy()
        Dim index As Integer

        For index = 0 To NumMovingBadguys

            Badguys(index).CellTop += Badguys(index).CellHeight
            If Badguys(index).state = NORMAL Then
                If Badguys(index).Speed.X >= 0 Then
                    If Badguys(index).CellTop > Badguys(index).CellHeight * 1 Then
                        Badguys(index).CellTop = 0
                    End If
                ElseIf Badguys(index).Speed.X < 0 Then
                    If Badguys(index).CellTop < Badguys(index).CellHeight * 2 Or Badguys(index).CellTop >
                        Badguys(index).CellHeight * 3 Then
                        Badguys(index).CellTop = Badguys(index).CellHeight * 2
                    End If
                End If
            ElseIf Badguys(index).state = FLIP Or Badguys(index).state = DEAD Then
                If Badguys(index).onFloor = False Then
                    If Badguys(index).CellTop < Badguys(index).CellHeight * 4 Or
                            Badguys(index).CellTop > Badguys(index).CellHeight * 7 Then
                        Badguys(index).CellTop = Badguys(index).CellHeight * 4
                    End If
                Else
                    If Badguys(index).CellTop < Badguys(index).CellHeight * 8 Or
                            Badguys(index).CellTop > Badguys(index).CellHeight * 9 Then
                        Badguys(index).CellTop = Badguys(index).CellHeight * 8
                    End If
                End If
            End If

        Next index
    End Sub

    Public Function GetVerticalSpeed(ByRef Guy As Sprite)
        Dim nextVStep As Integer
        Dim index As Integer

        nextVStep = Guy.Speed.Y + GRAVITY

        If Guy.state <> DEAD Then
            Guy.onFloor = False
            For index = 0 To 7
                If Guy.Position.X + Guy.CellWidth > Floors(index).Left And Guy.Position.X <
                    Floors(index).Right Then
                    If nextVStep > 0 Then
                        If Guy.Position.Y + Guy.CellHeight <= Floors(index).Top Then
                            If Guy.Position.Y + Guy.CellHeight + nextVStep > Floors(index).Top Then
                                nextVStep = Floors(index).Top - (Guy.Position.Y +
                                +Guy.CellHeight)
                                Guy.onFloor = True
                            End If
                        End If
                    End If

                    If nextVStep <= 0 Then
                        If Guy.Position.Y >= Floors(index).Bottom Then
                            If Guy.Position.Y + nextVStep < Floors(index).Bottom Then
                                nextVStep = Floors(index).Bottom - Guy.Position.Y

                            End If
                        End If
                    End If
                End If
            Next index
        End If
        Return nextVStep
    End Function

    Public Function Collision(ByVal Guy1 As Sprite, ByVal Guy2 As Sprite)
        Dim a As Integer
        Dim b As Integer
        Dim c As Double
        a = Guy1.Position.X - Guy2.Position.X
        b = Guy1.Position.Y - Guy2.Position.Y
        c = Math.Sqrt(a * a + b * b)
        If c < Guy1.radius + Guy2.radius Then
            Return True
        End If
        Return False
    End Function

    Public Sub CheckKillMax()
        Dim index As Integer
        For index = 0 To NumMovingBadguys
            If Collision(Max, Badguys(index)) = True And Max.state = NORMAL And
            Badguys(index).state = NORMAL Then
                Max.state = DEAD
                Max.Speed.X = 0
                Max.Speed.Y = -15
                LivesLeft -= 1
                MainForm.lblLives.Text = "Lives: " + LivesLeft.ToString

            End If
        Next index

        If LivesLeft = 3 Then
            MainForm.Heart0.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) &
                                     "\pics\heart.png")
            MainForm.Heart1.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) &
                                     "\pics\heart.png")
            MainForm.Heart2.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) &
                                     "\pics\heart.png")
        ElseIf LivesLeft = 2 Then
            MainForm.Heart0.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) &
                                     "\pics\heart.png")
            MainForm.Heart1.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) &
                                     "\pics\heart.png")
            MainForm.Heart2.Image = Nothing
        ElseIf LivesLeft = 1 Then
            MainForm.Heart0.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) &
                                     "\pics\heart.png")
            MainForm.Heart1.Image = Nothing
            MainForm.Heart2.Image = Nothing

        Else
            MainForm.Heart0.Image = Nothing
            MainForm.Heart1.Image = Nothing
            MainForm.Heart2.Image = Nothing

        End If
    End Sub

    Public Sub ReviveMax()
        If Max.state = DEAD And Max.Position.Y > backdrop.Height Then
            Max.state = REVIVE
            Max.Position.X = backdrop.Width / 2 - Max.CellWidth / 2
            Max.Position.Y = -50
            Max.Speed.Y = 0
        End If
        If Max.state = REVIVE And Max.Position.Y > 50 Then
            Max.Position.Y = 50
            Max.Speed.Y = 0
        End If
    End Sub

    Public Sub CheckKillBadguys()
        Dim index As Integer
        Dim shiftedMax As Sprite
        shiftedMax = Max
        shiftedMax.Position.Y -= 20
        For index = 0 To NumMovingBadguys
            If Badguys(index).onFloor And Badguys(index).state <> DEAD Then
                If Max.state = NORMAL And Collision(shiftedMax, Badguys(index)) Then
                    Badguys(index).state = FLIP
                    Badguys(index).timeflipped = 0
                    Badguys(index).Speed.X = 0
                    Badguys(index).Speed.Y = -20
                End If
            End If

            If Badguys(index).state = FLIP Then
                Badguys(index).timeflipped += 1
                If Badguys(index).timeflipped > 100 Then
                    Badguys(index).timeflipped = 0
                    Badguys(index).state = NORMAL
                    Badguys(index).Speed.X = Badguys(index).StartSpeed.X
                    Badguys(index).Speed.Y = Badguys(index).StartSpeed.Y
                End If
            End If

            If Max.state = NORMAL And Badguys(index).state = FLIP And Collision(Max,
                                                        Badguys(index)) = True Then
                score += (100 - Badguys(index).timeflipped)
                If score > 80 Then
                    score *= 2
                End If
                Badguys(index).state = DEAD
                Badguys(index).onFloor = False
                Badguys(index).Speed.X = Max.Speed.X
                Badguys(index).Speed.Y = -20
                MainForm.lblScore.Text = "Score:  " + score.ToString
                NumBadGuysKilled += 1
            End If
        Next index
    End Sub

    Public Sub CheckMilkButton()
        If Collision(Max, Milk) And Max.state <> DEAD And Milk.state = NORMAL And
        Max.Speed.Y < 0 Then
            Milk.state = DEAD
            Max.Speed.Y = Milk.Position.Y + Milk.CellWidth - Milk.Position.Y
            For index = 0 To NumMovingBadguys
                If Badguys(index).onFloor = True And Badguys(index).state <> DEAD Then
                    Badguys(index).state = FLIP
                    Badguys(index).Speed.X = 0
                    Badguys(index).Speed.Y = 0
                    Badguys(index).timeflipped = 0
                End If
            Next
        End If
    End Sub


    Public Sub UseItemShopMilk()
        MainForm.BackPackMilk.Left = Max.Position.X
        MainForm.BackPackMilk.Top = Max.Position.Y

    End Sub

End Module
