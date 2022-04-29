Imports System
Imports System.IO

Public Class Leaderboard
    Private Sub Leaderboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = theme
        Scores.checkForSaveFile()
        Scores.LoadEntries()
        updateButton()
        loadNames()
    End Sub
    Private Sub loadNames()
        For Each name As String In Scores.Players.Keys
            If (Not Me.cb_players.Items.Contains(name)) Then
                Me.cb_players.Items.Add(name)
            End If
        Next
    End Sub

    Private Sub btn_sort_Click(sender As Object, e As EventArgs) Handles btn_sort.Click
        Scores.OrderByDesc = Not Scores.OrderByDesc
        updateButton()

        Dim items() As String = Me.lst_leaderboard.Items.Cast(Of String).Reverse.ToArray
        Me.lst_leaderboard.Items.Clear()
        Me.lst_leaderboard.Items.AddRange(items)
    End Sub

    Private Sub updateButton()
        If (Scores.OrderByDesc) Then
            btn_sort.Text = "Descending Order Scoreboard"
        Else
            btn_sort.Text = "Ascending Order Scoreboard"
        End If
    End Sub

    Private Sub cb_players_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_players.SelectedIndexChanged
        Me.lst_leaderboard.Items.Clear()
        Dim data = Players.Item(cb_players.Text).GameRecords.OrderByDescending(Function(x) x.howManyCasesDiscovered).ThenBy(Function(x) x.lastDiscoveredAt).ToList()
        For Each game As GameRecord In data
            Me.lst_leaderboard.Items.Add(game.performedBy & " has discovered " & game.howManyCasesDiscovered & " cases in " & game.lastDiscoveredAt & " seconds.")
        Next
    End Sub

    Private Sub btn_details_Click(sender As Object, e As EventArgs) Handles btn_details.Click
        If (Scores.Players.Count = 0 Or Not Scores.Players.ContainsKey(cb_players.Text)) Then
            MsgBox("No players registered at the moment, or player not found!")
            Return
        End If
        Dim player = Scores.Players.Item(cb_players.Text)
        Dim bestGame As GameRecord = bestGameFrom(cb_players.Text)
        MsgBox("Player name : " & player.playerName & Environment.NewLine &
               "- Best discovered cases number : " & bestGame.howManyCasesDiscovered & Environment.NewLine &
               "- Performed in : " & bestGame.lastDiscoveredAt & " seconds !" & Environment.NewLine &
               "- Cumulated time : " & player.cumulatedTime & " seconds !" & Environment.NewLine &
               "- Games played : " & player.howManyGames, vbQuestion + vbOKOnly, "Infos from : " & player.playerName)
    End Sub
End Class