Public Class GameSettings
    Private Sub GameSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim enumColor As New KnownColor
        Dim Colors As Array = [Enum].GetValues(enumColor.GetType())
        cb_theme.DataSource = Colors

        Me.lb_dim.Text = CType(gridSize, String) + "x" + CType(gridSize, String) + " grid"
        Me.tb_gridSize.Value = Settings.gridSize

        If (gridSize * gridSize) - 1 > 64 Then
            Me.sb_mines.Maximum = 64
        Else
            Me.sb_mines.Maximum = (gridSize * gridSize) - 1
        End If

        Me.lb_mines.Text = CType(mines, String) + " mines"
        Me.sb_mines.Value = Settings.mines
        Me.btn_timer.Checked = timerEnabled
        Me.btn_pause.Checked = EnablePause
        Me.tb_filePath.Text = saveFilePath
        Me.lb_seconds.Text = CStr(seconds)
        Me.cb_deathsound.Checked = Settings.enableDeathsound
        Me.rb_win.Checked = Settings.alwaysWin
        Me.rb_lose.Checked = Settings.alwaysLose
        Me.savePath.SelectedPath = saveFilePath

        If (Not Settings.alwaysWin And Not Settings.alwaysLose) Then
            Me.rb_disable.Checked = True
        End If

        Me.cb_theme.SelectedIndex = Settings.defaultColorIndex
        Me.BackColor = theme
    End Sub
    Private Sub tb_gridSize_Scroll(sender As Object, e As EventArgs) Handles tb_gridSize.Scroll
        Settings.gridSize = tb_gridSize.Value + (tb_gridSize.Value Mod 2)
        If Settings.gridSize = 12 Or Settings.gridSize = 14 Then
            Settings.gridSize = 16
        End If
        Me.lb_dim.Text = CType(gridSize, String) + "x" + CType(gridSize, String) + " grid"
        Me.sb_mines.Maximum = (gridSize * gridSize) - 1

        If (Me.sb_mines.Maximum > 64) Then
            Me.sb_mines.Maximum = 64
        End If

        If (Me.sb_mines.Value >= Me.sb_mines.Maximum) Then
            Settings.mines = Me.sb_mines.Maximum
            Me.lb_mines.Text = CType(mines, String) + " mines"
        End If

    End Sub

    Private Sub sb_mines_Scroll(sender As Object, e As ScrollEventArgs) Handles sb_mines.Scroll
        Me.sb_mines.Maximum = (gridSize * gridSize) - 1

        If (Me.sb_mines.Maximum > 64) Then
            Me.sb_mines.Maximum = 64
        End If

        Settings.mines = sb_mines.Value Mod sb_mines.Maximum

        Me.lb_mines.Text = CType(mines, String) + " mines"
    End Sub

    Private Sub btn_pause_CheckedChanged(sender As Object, e As EventArgs) Handles btn_pause.CheckedChanged
        If (Me.btn_pause.Checked) Then
            Me.btn_timer.Checked = True
            Me.btn_timer.Enabled = False
        Else
            Me.btn_timer.Enabled = True
        End If
    End Sub

    Private Sub btn_savePath_Click(sender As Object, e As EventArgs) Handles btn_savePath.Click
        savePath.ShowDialog()
        tb_filePath.Text = savePath.SelectedPath + "\save.msw"
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        ' Basics Tab
        If [Enum].IsDefined(GetType(KnownColor), cb_theme.Text) Then
            Settings.theme = Color.FromName(cb_theme.Text)
            Settings.defaultColorIndex = Me.cb_theme.SelectedIndex
        End If

        For Each form As Form In My.Application.OpenForms
            form.BackColor = Settings.theme
        Next
        Settings.enableDeathsound = cb_deathsound.Checked

        ' Advanced Tab
        If (saveFilePath <> savePath.SelectedPath) Then
            saveFilePath = savePath.SelectedPath + "\save.msw"
        End If

        Settings.timerEnabled = btn_timer.Checked
        Settings.EnablePause = btn_pause.Checked
        Settings.animationEclatax = btn_animEclatax.Checked
        Settings.seconds = tb_seconds.Value

        ' Hack Tab
        Settings.alwaysWin = rb_win.Checked
        Settings.alwaysLose = rb_win.Checked

        If (rb_disable.Checked) Then
            Settings.alwaysWin = False
            Settings.alwaysLose = False
        End If

        MsgBox("Settings saved successfully!")
        Me.Close()
    End Sub

    Private Sub tb_seconds_Scroll(sender As Object, e As EventArgs) Handles tb_seconds.Scroll
        Me.lb_seconds.Text = CStr(tb_seconds.Value)
    End Sub

End Class