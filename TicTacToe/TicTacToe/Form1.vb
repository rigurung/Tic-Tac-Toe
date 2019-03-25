Public Class Form1
    Dim player1, player2 As String

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If txtPlayer1.Text = "" Then
            player1 = "Player 1"
            player2 = "Player 2"

        Else
            player1 = txtPlayer1.Text
            player2 = txtPlayer2.Text
        End If

        txtPlayer1.Text = player1
        txtPlayer2.Text = player2
        Form2.Show()
    End Sub
End Class
