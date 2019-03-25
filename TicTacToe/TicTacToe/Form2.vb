Public Class Form2
    Dim player1 As String = Form1.txtPlayer1.Text
    Dim player2 As String = Form1.txtPlayer2.Text
    Dim countX As Integer = 0
    Dim countO As Integer = 0

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl1.Text = player1 + " : "
        lbl2.Text = player2 + " : "
        lblturnX.Visible = True
        lblturnO.Visible = False
    End Sub

    Private Sub check()
        If (btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X") Or _
     (btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X") Or _
     (btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X") Or _
     (btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X") Or _
     (btn3.Text = "X" And btn5.Text = "X" And btn7.Text = "X") Or _
     (btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X") Or _
     (btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X") Or _
     (btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X") Then
            MsgBox("Congratulation " + player1 + " , you won.")
            countX += 1
            lblscore1.Text = countX
            lbl1.Text = player1 + " : "
            lblStatus.Text = player1 + " won last round"

            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        ElseIf (btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O") Or _
        (btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O") Or _
        (btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O") Or _
        (btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O") Or _
        (btn3.Text = "O" And btn5.Text = "O" And btn7.Text = "O") Or _
        (btn3.Text = "O" And btn6.Text = "O" And btn9.Text = "O") Or _
        (btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O") Or _
        (btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O") Then
            MsgBox("Congratulation " + player2 + " , you won.")
            countO += 1
            lblscore2.Text = countO
            lbl2.Text = player2 + " : "
            lblStatus.Text = player2 + " won last round."

            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False

        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If (lblturnX.Visible = True) Then
            btn1.Text = "X"
            check()
            lblturnX.Visible = False
            lblturnO.Visible = True
        ElseIf (lblturnO.Visible = True) Then
            btn1.Text = "O"
            check()
            lblturnX.Visible = True
            lblturnO.Visible = False
        End If

        btn1.Enabled = False
    End Sub


    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If (lblturnX.Visible = True) Then
            btn2.Text = "X"
            check()
            lblturnX.Visible = False
            lblturnO.Visible = True
        ElseIf (lblturnO.Visible = True) Then
            btn2.Text = "O"
            check()
            lblturnX.Visible = True
            lblturnO.Visible = False
        End If
        btn2.Enabled = False
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If (lblturnX.Visible = True) Then
            btn3.Text = "X"
            check()
            lblturnX.Visible = False
            lblturnO.Visible = True
        ElseIf (lblturnO.Visible = True) Then
            btn3.Text = "O"
            check()
            lblturnX.Visible = True
            lblturnO.Visible = False
        End If
        btn3.Enabled = False
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If (lblturnX.Visible = True) Then
            btn4.Text = "X"
            check()
            lblturnX.Visible = False
            lblturnO.Visible = True
        ElseIf (lblturnO.Visible = True) Then
            btn4.Text = "O"
            check()
            lblturnX.Visible = True
            lblturnO.Visible = False
        End If
        btn4.Enabled = False
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If (lblturnX.Visible = True) Then
            btn5.Text = "X"
            check()
            lblturnX.Visible = False
            lblturnO.Visible = True
        ElseIf (lblturnO.Visible = True) Then
            btn5.Text = "O"
            check()
            lblturnX.Visible = True
            lblturnO.Visible = False
        End If
        btn5.Enabled = False
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If (lblturnX.Visible = True) Then
            btn6.Text = "X"
            check()
            lblturnX.Visible = False
            lblturnO.Visible = True
        ElseIf (lblturnO.Visible = True) Then
            btn6.Text = "O"
            check()
            lblturnX.Visible = True
            lblturnO.Visible = False
        End If
        btn6.Enabled = False
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If (lblturnX.Visible = True) Then
            btn7.Text = "X"
            check()
            lblturnX.Visible = False
            lblturnO.Visible = True
        ElseIf (lblturnO.Visible = True) Then
            btn7.Text = "O"
            check()
            lblturnX.Visible = True
            lblturnO.Visible = False
        End If
        btn7.Enabled = False
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If (lblturnX.Visible = True) Then
            btn8.Text = "X"
            check()
            lblturnX.Visible = False
            lblturnO.Visible = True
        ElseIf (lblturnO.Visible = True) Then
            btn8.Text = "O"
            check()
            lblturnX.Visible = True
            lblturnO.Visible = False
        End If
        btn8.Enabled = False
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If (lblturnX.Visible = True) Then
            btn9.Text = "X"
            check()
            lblturnX.Visible = False
            lblturnO.Visible = True
        ElseIf (lblturnO.Visible = True) Then
            btn9.Text = "O"
            check()
            lblturnX.Visible = True
            lblturnO.Visible = False
        End If
        btn9.Enabled = False
    End Sub


    Private Sub btnNewRound_Click(sender As Object, e As EventArgs) Handles btnNewRound.Click
        btn1.Text = ""
        btn2.Text = ""
        btn3.Text = ""
        btn4.Text = ""
        btn5.Text = ""
        btn6.Text = ""
        btn7.Text = ""
        btn7.Text = ""
        btn8.Text = ""
        btn9.Text = ""


        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        btn6.Enabled = True
        btn7.Enabled = True
        btn8.Enabled = True
        btn9.Enabled = True

    End Sub
End Class