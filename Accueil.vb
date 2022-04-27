Public Class Accueil
    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GameCore.Main() ' Load Default values
        checkForSaveFile()
        For Each name As String In Scores.Players.Keys
            Me.cb_name.Items.Add(name)
        Next
    End Sub

    Private Sub checkForSaveFile()
        Try
            If Not (System.IO.File.Exists(Settings.saveFilePath)) Then
                Dim file As IO.StreamWriter = System.IO.File.CreateText("save.msw")
                file.Close()
            End If
            Scores.loadScoreboard()
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub
    Private Sub Accueil_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.ExitThread()
    End Sub

    Private Sub bt_leaderboard_Click(sender As Object, e As EventArgs) Handles bt_leaderboard.Click
        ' Show the leaderboard
        Leaderboard.Show()
    End Sub

    Private Sub bt_quit_Click(sender As Object, e As EventArgs) Handles bt_quit.Click
        ' Exit the application
        Dim choice
        choice = MsgBox(" Do you really want to leave the app ?", vbYesNo, "Quit ?")
        If (choice = vbYes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub bt_start_Click(sender As Object, e As EventArgs) Handles bt_start.Click
        If (cb_name.Text.Length < 3) Then
            MsgBox("Your username must have 3 characters or more!", vbOKOnly, "Warning")
        ElseIf (cb_name.Text = "Username") Then
            MsgBox("Please enter a username !", vbOKOnly, "Warning")
        Else
            GameCore.Init(Settings.gridSize, Settings.gridSize, Settings.mines, Settings.seconds, cb_name.Text)
        End If
    End Sub

    Private Sub img_credits_Click(sender As Object, e As EventArgs) Handles img_credits.Click
        ' Show the credits form
        Credits.Show()
    End Sub

    Private Sub settings_Click(sender As Object, e As EventArgs) Handles btn_settings.Click
        GameSettings.Show()
    End Sub
End Class