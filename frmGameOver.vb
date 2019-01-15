Public Class frmGameOver

    Private Sub cmdYesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        Hide()
    End Sub

    Private Sub cmdNoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        quit = True
        Hide()
    End Sub


End Class