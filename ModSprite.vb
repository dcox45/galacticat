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

    End Structure

    Public Max As Sprite
    Public Const gravity As Integer = 1

    Public Sub LoadMax()
        Max.Picture = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\galacticat.png")
        Max.CellCount = 15
        Max.CellWidth = Max.Picture.Width
        Max.CellHeight = Max.Picture.Height / Max.CellCount
        Max.StartPosition.X = 200
        Max.StartPosition.Y = 200
        Max.Position.X = Max.StartPosition.X
        Max.Position.Y = Max.StartPosition.Y
        Max.Speed.X = 0
        Max.Speed.Y = 0
        Max.StartSpeed.X = 5
        Max.StartSpeed.Y = 17
        Max.facingRight = True

        Max.mRectangle.Width = Max.CellWidth
        Max.mRectangle.Height = Max.CellHeight
        Max.mRectangle.X = Max.Position.X
        Max.mRectangle.Y = Max.Position.Y
    End Sub

    Public Sub MoveMax()
        Max.Speed.Y = GetVerticalSpeed()
        Max.Position.X += Max.Speed.X
        Max.Position.Y += Max.Speed.Y

        Max.mRectangle.X = Max.Position.X
        Max.mRectangle.Y = Max.Position.Y

        If Max.Position.X > (650 + Max.CellWidth) Then
            Max.Position.X = 0 - Max.CellWidth
        ElseIf Max.Position.X + Max.CellWidth < 0 Then
            Max.Position.X = 650
        End If

    End Sub

    Public Sub MaxDraw()
        offG.DrawImage(Max.Picture, Max.mRectangle, 0, Max.CellTop, Max.CellWidth,
                       Max.CellHeight, System.Drawing.GraphicsUnit.Pixel)
    End Sub

    Public Sub AnimateMax()
        Max.CellTop += Max.CellHeight
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
    End Sub

    Public Function GetVerticalSpeed()
        Dim nextVStep As Integer
        nextVStep = Max.Speed.Y + gravity
        Dim index As Integer
        Max.onFloor = False
        For index = 0 To 7
            If Max.Position.X + Max.CellWidth > Floors(index).Left And Max.Position.X <
                    Floors(index).Right Then
                If nextVStep > 0 Then
                    If Max.Position.Y + Max.CellHeight <= Floors(index).Top Then
                        If Max.Position.Y + Max.CellHeight + nextVStep > Floors(index).Top Then
                            nextVStep = Floors(index).Top - (Max.Position.Y +
                                +Max.CellHeight)
                            Max.onFloor = True
                        End If
                    End If
                End If

                If nextVStep <= 0 Then
                    If Max.Position.Y >= Floors(index).Bottom Then
                        If Max.Position.Y + nextVStep < Floors(index).Bottom Then
                            nextVStep = Floors(index).Bottom - Max.Position.Y

                        End If
                    End If
                End If
            End If
        Next index
        Return nextVStep


    End Function

End Module
