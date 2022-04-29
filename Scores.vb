Module Scores
    Friend OrderByDesc As Boolean = True
    Friend Players As New Dictionary(Of String, PlayerEntry)
    Friend GlobalScoreboard As New List(Of GameRecord)
    'gros:15:10
    Structure PlayerEntry
        Friend playerName As String
        Friend lastDiscoveredAt As Integer
        Friend howManyCasesDiscovered As Integer
        Friend howManyGames As Integer
        Friend cumulatedTime As Integer
        Friend GameRecords As List(Of GameRecord)
    End Structure

    Structure GameRecord
        Friend lastDiscoveredAt As Integer
        Friend howManyCasesDiscovered As Integer
        Friend performedBy As String
    End Structure

    Public Function getBestGameForEachPlayer()
        Dim bestGames As New Dictionary(Of String, GameRecord)
        GlobalScoreboard = GlobalScoreboard.OrderByDescending(Function(x) x.howManyCasesDiscovered).ThenBy(Function(x) x.lastDiscoveredAt).ToList()

        For Each gr As GameRecord In GlobalScoreboard
            If Not (bestGames.ContainsKey(gr.performedBy)) Then
                bestGames.Add(gr.performedBy, gr)
            End If
        Next
        Return bestGames.Values.ToList
    End Function
    Public Sub LoadEntries()
        Try
            Players.Clear()
            GlobalScoreboard.Clear()
            Leaderboard.lst_leaderboard.Items.Clear()
            loadScoreboard()
        Catch ex As Exception
            MsgBox("Cannot load the scoreboard...")
            Leaderboard.Close()
        End Try

        'If (OrderByDesc) Then
        'GlobalScoreboard = GlobalScoreboard.OrderByDescending(Function(x) x.howManyCasesDiscovered).ThenBy(Function(x) x.lastDiscoveredAt).ToList()
        'Else
        'GlobalScoreboard = GlobalScoreboard.OrderBy(Function(x) x.howManyCasesDiscovered).ThenBy(Function(x) x.lastDiscoveredAt).ToList()
        'End If

        Dim bestGame As List(Of GameRecord) = getBestGameForEachPlayer()
        If (OrderByDesc) Then
            bestGame = bestGame.OrderByDescending(Function(x) x.howManyCasesDiscovered).ThenBy(Function(x) x.lastDiscoveredAt).ToList()
        Else
            bestGame = bestGame.OrderBy(Function(x) x.howManyCasesDiscovered).ThenBy(Function(x) x.lastDiscoveredAt).ToList()
        End If

        Try
            Dim place As Integer = 1
            For Each playerEntry As GameRecord In bestGame
                Dim rank As String
                If place = 1 Then
                    rank = "1st : "
                ElseIf place = 2 Then
                    rank = "2nd : "
                ElseIf place = 3 Then
                    rank = "3rd : "
                Else
                    rank = place & "th : "
                End If

                Leaderboard.lst_leaderboard.Items.Add(rank & playerEntry.performedBy & " has discovered " & playerEntry.howManyCasesDiscovered & " cases in " & playerEntry.lastDiscoveredAt & " seconds.")
                place += 1
            Next
        Catch e As Exception
            MsgBox(e.Message)
        End Try
    End Sub

    Public Sub WriteNewEntry(playerName As Integer, lastDiscoveredAt As Integer, howManyCasesDiscovered As Integer)
        Encryption.Write(saveFilePath, playerName & ":" & lastDiscoveredAt & ":" & howManyCasesDiscovered)
    End Sub

    Public Sub loadScoreboard()
        Leaderboard.lst_leaderboard.Refresh()
        Dim PText As String
        Try
            If (System.IO.File.Exists(Settings.saveFilePath)) Then
                PText = Encryption.Decrypt(saveFilePath)
            Else
                MsgBox("No file founded, cannot load the scoreboard !")
                Leaderboard.Close()
                Return
            End If

            For Each line As String In PText.Split(Environment.NewLine)
                Try
                    Dim data As String() = line.Split(":")
                    data(0) = Replace(data(0), vbLf, "") ' remove the line break

                    Console.WriteLine(data(0) + ":" + CStr(data(1)) + ":" + CStr(data(2)))
                    If data.Length <> 3 Then
                        MsgBox("Invalid entry for " + data(0))
                    End If
                    ' GameRecord template in the file : playerName:lastDiscoveredAt:howManyCasesDiscovered

                    If Not (Players.ContainsKey(data(0))) Then
                        Dim p As New PlayerEntry()
                        p.playerName = data(0)
                        p.lastDiscoveredAt = data(1)
                        p.cumulatedTime = data(1)
                        p.howManyCasesDiscovered = data(2)
                        p.howManyGames = 1

                        p.GameRecords = New List(Of GameRecord)
                        Dim gr As New GameRecord()
                        gr.lastDiscoveredAt = data(1)
                        gr.howManyCasesDiscovered = data(2)
                        gr.performedBy = data(0)
                        p.GameRecords.Add(gr)
                        GlobalScoreboard.Add(gr)

                        Players.Add(p.playerName, p)
                    Else
                        Dim tmp As PlayerEntry = Players.Item(data(0))
                        Players.Remove(data(0))
                        Dim gameRecord As New GameRecord

                        gameRecord.lastDiscoveredAt = data(1)
                        gameRecord.howManyCasesDiscovered = data(2)
                        gameRecord.performedBy = data(0)

                        tmp.cumulatedTime += gameRecord.lastDiscoveredAt
                        tmp.howManyCasesDiscovered += gameRecord.howManyCasesDiscovered
                        tmp.howManyGames += 1
                        tmp.GameRecords.Add(gameRecord)

                        GlobalScoreboard.Add(gameRecord)
                        Players.Add(data(0), tmp)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next
        Catch e As Exception

        End Try
    End Sub
End Module
