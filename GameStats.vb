Public Class GameStats
    Private Sub GameStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lb_sec.Text = GameCore.getTime()
        Me.lb_mineshowmany.Text = GameCore.getMines()
        Me.lb_dim.Text = CType(GameCore.getCols(), String) + "x" + CType(GameCore.getRows(), String)
        Me.lb_mines.Text = CType(getDiscoMines(), String)
        Me.lb_latest.Text = "at " + CType(GameCore.getLastDiscovered, String) + " secs"
    End Sub
    Private closeEvent As Boolean = False
    Private Sub GameStats_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Game.closeEventFromGameStatus = True
        Game.Close()
        Accueil.Show()
    End Sub


    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub
End Class