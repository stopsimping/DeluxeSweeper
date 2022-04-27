Module Scores

    Structure PlayerEntry
        Private playerName As String
        Private lastDiscovered As Integer
        Private howManyDiscovered As Integer
        Private howManyGames As Integer
        Private cumulatedTime As Integer
    End Structure
    Public Sub LoadEntries()
        '" load the scoreboard
    End Sub
    Public Sub WriteNewEntry()
        Encryption.Write(saveFilePath, "new message")
    End Sub

    Public Sub loadScoreboard()
        Dim PText As String = Encryption.Decrypt(saveFilePath)
        ' affichger dans la list box et bien formaté
    End Sub
End Module
