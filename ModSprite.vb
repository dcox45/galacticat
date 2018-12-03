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
        Max.Speed.Y += gravity
        Max.Position.X += Max.Speed.X
        Max.Position.Y += Max.Speed.Y

        If Max.Position.Y > 200 Then
            Max.Position.Y = 200
            Max.Speed.Y = 0
        End If

        Max.mRectangle.X = Max.Position.X
        Max.mRectangle.Y = Max.Position.Y

    End Sub

    Public Sub MaxDraw()
        offG.DrawImage(Max.Picture, Max.mRectangle, 0, Max.CellTop, Max.CellWidth,
                       Max.CellHeight, System.Drawing.GraphicsUnit.Pixel)
    End Sub

    Public Sub AnimateMax()
        Max.CellTop += Max.CellHeight
        If Max.Speed.X > 0 And Max.Speed.Y = 0 Then
            If Max.CellTop > Max.CellHeight * 2 Then
                Max.CellTop = 0
            End If
        ElseIf Max.Speed.X < 0 And Max.Speed.Y = 0 Then
            If Max.CellTop < Max.CellHeight * 3 Or Max.CellTop > Max.CellHeight * 5 Then
                Max.CellTop = Max.CellHeight * 3
            End If
        ElseIf Max.Speed.X = 0 And Max.Speed.Y = 0 Then
            If Max.facingRight = True Then
                Max.CellTop = Max.CellHeight * 6
            Else
                Max.CellTop = Max.CellHeight * 7
            End If
        ElseIf Max.Speed.Y <> 0 Then
            If Max.facingRight = True Then
                Max.CellTop = Max.CellHeight * 8
            Else
                Max.CellTop = Max.CellHeight * 9
            End If
        End If
    End Sub

End Module
