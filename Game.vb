Public Class Game

    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = theme
        lb_username.Text = GameCore.getUsername()
        GameCore.startTimer(sender, e)
        GameCore.changeGameRunning(True)
        GameCore.DisplayGrid()
    End Sub
    Friend closeEventFromGameStatus As Boolean = False
    Private Sub Game_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            GameCore.QuitModule()
        Catch ex As Exception
        End Try

        Accueil.Show()
    End Sub
    Friend Sub OnButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (GameCore.hasPerformedFirstCLick()) Then
            GameCore.performFirstClick()
        End If

        Dim btn As Cell
        btn = CType(sender, Cell)
        If (GameCore.isGameRunning()) Then
            GameCore.Reveal(btn, p_cases.Controls.IndexOf(btn))
        Else
            Beep()
        End If
    End Sub

    Public Sub RevealAll()
        For Each btn As Cell In p_cases.Controls
            If (btn.getValue = "M" Or btn.isFlagged) Then
                btn.Reveal()
            End If
        Next
    End Sub

    Private Sub abandon_Click(sender As Object, e As EventArgs) Handles abandon.Click
        Dim choice
        choice = MsgBox("Do you really want to abandon?", vbYesNo, "Abandon")
        If (choice = vbYes) Then
            EndGame()
        End If
    End Sub

    Private OnPause As Boolean = False
    Private Sub pause_Click(sender As Object, e As EventArgs) Handles pause.Click
        If Not (OnPause) Then
            GameCore.timer.Enabled = False
            pb_pause.Visible = True
            GameCore.changeGameRunning(False)
            OnPause = True
        Else
            GameCore.timer.Enabled = True
            pb_pause.Visible = False
            GameCore.changeGameRunning(True)
            OnPause = False
        End If
    End Sub

End Class