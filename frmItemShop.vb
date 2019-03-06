Public Class frmItemShop
    Private Sub BtnPortableMilk_Click(sender As Object, e As EventArgs) Handles BtnPortableMilk.Click
        If score >= 1000 Then


            Me.Close()
            MaxHasMilk = True
            MainForm.BackPackMilk.Visible = True
            score -= 1000
            MainForm.lblScore.Text = "Score:  " + score.ToString
            MainForm.Timer1.Start()
        End If

    End Sub

    Private Sub frmItemShop_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainForm.Timer1.Start()
    End Sub

End Class