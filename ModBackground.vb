Module ModBackground
    Structure Background
        Dim Picture As Bitmap
        Dim Position As Point
        Dim Width As Integer
        Dim Height As Integer
    End Structure

    Structure Floor
        Dim Top As Integer
        Dim Bottom As Integer
        Dim Left As Integer
        Dim Right As Integer
    End Structure

    Public backdrop As Background
    Public g As Graphics
    Public offG As Graphics
    Public imageOffScreen As Image
    Public Const NumFloors As Integer = 7
    Public Floors(NumFloors) As Floor


    Public Sub LoadBackground()
        backdrop.Position.X = 0
        backdrop.Position.Y = 0

        backdrop.Picture = New Bitmap(IO.Path.GetDirectoryName(Application.ExecutablePath) &
                                 "\pics\bckgrnd.bmp")

        backdrop.Width = backdrop.Picture.Width
        backdrop.Height = backdrop.Picture.Height
    End Sub


    Public Sub BackgroundDraw()
        offG.DrawImage(backdrop.Picture, 0, 0)
    End Sub

    Public Sub FloorSet()
        Floors(0).Top = 415
        Floors(0).Bottom = 450
        Floors(0).Left = -50
        Floors(0).Right = 700

        Floors(1).Top = 320
        Floors(1).Bottom = 335
        Floors(1).Left = -50
        Floors(1).Right = 240

        Floors(2).Top = 320
        Floors(2).Bottom = 335
        Floors(2).Left = 405
        Floors(2).Right = 700

        Floors(3).Top = 218
        Floors(3).Bottom = 232
        Floors(3).Left = -50
        Floors(3).Right = 97

        Floors(4).Top = 204
        Floors(4).Bottom = 450
        Floors(4).Left = -50
        Floors(4).Right = 700

        Floors(5).Bottom = 204
        Floors(5).Left = 218
        Floors(5).Right = 165
        Floors(5).Top = 475

        Floors(6).Bottom = 96
        Floors(6).Left = 110
        Floors(6).Right = -50
        Floors(6).Top = 265

        Floors(7).Bottom = 96
        Floors(7).Left = 110
        Floors(7).Right = 380
        Floors(7).Top = 700



    End Sub

End Module
