Public Class frmYouWin
    Private Sub cmdYesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        Hide()
    End Sub

    Private Sub cmdNoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        quit = True
        Hide()
    End Sub

    Private Sub frmYouWin_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        lblScoreFinal.Text = "Score:  " + score.ToString

    End Sub
End Class