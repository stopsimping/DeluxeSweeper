Imports System
Imports System.IO

Public Class Leaderboard
    Private Sub Leaderboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Encryption.Encrypt("save.msw")
        Try
            If (System.IO.File.Exists(Settings.saveFilePath)) Then
                For Each line As String In System.IO.File.ReadLines(Settings.saveFilePath)
                    Console.WriteLine(line)
                    ' add to the board
                Next
            End If
        Catch ex As Exception
            MsgBox("Cannot load scoreboard... putting your save.msw file in the same folder of the game!")
            Me.Close()
        End Try

    End Sub
End Class