Public Class GameSettings

    Private Sub GameSettings_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
    End Sub

    Private Sub GameSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lb_dim.Text = CType(gridSize, String) + "x" + CType(gridSize, String) + " grid"
        Me.lb_mines.Text = CType(mines, String) + " mines"
        Me.btn_timer.Checked = timerEnabled
        Me.btn_pause.Checked = EnablePause
        Me.tb_filePath.Text = saveFilePath
        savePath.SelectedPath = saveFilePath
    End Sub
    Private Sub tb_gridSize_Scroll(sender As Object, e As EventArgs) Handles tb_gridSize.Scroll
        Settings.gridSize = tb_gridSize.Value + (tb_gridSize.Value Mod 2)
        Me.lb_dim.Text = CType(gridSize, String) + "x" + CType(gridSize, String) + " grid"
        Me.sb_mines.Maximum = (gridSize * gridSize) - 1

        If (Me.sb_mines.Maximum > 64) Then
            Me.sb_mines.Maximum = 64
        End If

        If (Me.sb_mines.Value >= Me.sb_mines.Maximum) Then
            Settings.mines = sb_mines.Value
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

    Private Sub themeChange()
        ' blabla
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
        tb_filePath.Text = savePath.SelectedPath
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If (saveFilePath <> savePath.SelectedPath) Then
            saveFilePath = savePath.SelectedPath
        End If

        timerEnabled = btn_timer.Checked
        EnablePause = btn_pause.Checked
        MsgBox("Settings saved successfully!")
    End Sub
End Class