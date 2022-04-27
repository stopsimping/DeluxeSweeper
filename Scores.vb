Module Scores
    Private Players As New Dictionary(Of String, PlayerEntry)
    'gros:15:10056:545:44566
    Structure PlayerEntry
        Friend playerName As String
        Friend lastDiscovered As Integer
        Friend howManyDiscovered As Integer
        Friend howManyGames As Integer
        Friend cumulatedTime As Integer
    End Structure
    Public Sub LoadEntries()
        Try
            loadScoreboard()
        Catch ex As Exception
            MsgBox("Cannot load the scoreboard...")
            Leaderboard.Close()
        End Try

        Leaderboard.lst_leaderboard.ColumnWidth = 170
        Leaderboard.lst_leaderboard.MultiColumn = True
        Try
            For Each playerName As String In Players.Keys
                Dim p As PlayerEntry = Players.Item(playerName)
                Console.WriteLine(CStr(p.playerName) + " " + CStr(p.lastDiscovered))
                Leaderboard.lst_leaderboard.Items.Add(p.playerName & " " & p.lastDiscovered & " " & p.howManyDiscovered & " " & p.howManyGames & " " & p.cumulatedTime)
            Next
        Catch e As Exception
            MsgBox(e.Message)
        End Try
    End Sub
    Public Sub WriteNewEntry()
        Encryption.Write(saveFilePath, "new message")
    End Sub

    Public Sub loadScoreboard()
        Dim PText As String
        Try

            If (System.IO.File.Exists(Settings.saveFilePath)) Then
                PText = Encryption.Decrypt(saveFilePath)
            Else
                MsgBox("No file founded, cannot load the scoreboard !")
                Leaderboard.Close()
            End If

            For Each line As String In PText.Split(Environment.NewLine)
                Try
                    Dim data As String() = line.Split(":")
                    data(0) = Replace(data(0), vbLf, "") ' remove the line break

                    Console.WriteLine(data(0) + ":" + CStr(data(1)) + ":" + CStr(data(2)) + ":" + CStr(data(3)) + ":" + CStr(data(4)))
                    If data.Length <> 5 Then
                        MsgBox("Invalid entry for " + data(0))
                    End If
                    Dim p As New PlayerEntry()
                    p.playerName = data(0)
                    p.lastDiscovered = data(1)
                    p.howManyDiscovered = data(2)
                    p.howManyGames = data(3)
                    p.cumulatedTime = data(4)
                    If Not (Players.ContainsKey(p.playerName)) Then
                        Players.Add(p.playerName, p)
                    End If
                Catch ex As Exception
                    MsgBox("impossible --> Invalid Entry, file has been modified")
                End Try
            Next
        Catch e As Exception

        End Try
    End Sub
End Module
