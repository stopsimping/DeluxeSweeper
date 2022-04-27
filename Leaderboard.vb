Imports System
Imports System.IO

Public Class Leaderboard
    Private Sub Leaderboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Scores.LoadEntries()
    End Sub
End Class