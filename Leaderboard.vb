Imports System
Imports System.IO

Public Class Leaderboard
    Private Sub Leaderboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Scores.LoadEntries()
        updateButton()
    End Sub

    Private Sub btn_sort_Click(sender As Object, e As EventArgs) Handles btn_sort.Click
        Scores.OrderByDesc = Not Scores.OrderByDesc
        updateButton()
        Scores.LoadEntries()
    End Sub

    Private Sub updateButton()
        If (Scores.OrderByDesc) Then
            btn_sort.Text = "Descending Order Scoreboard"
        Else
            btn_sort.Text = "Ascending Order Scoreboard"
        End If
    End Sub
End Class