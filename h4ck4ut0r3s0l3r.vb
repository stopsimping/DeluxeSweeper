Public Module h4ck4ut0r3s0l3r
    Public Sub autoResolve(enable As Boolean)
        If (enable) Then
            For Each cell As Cell In Game.p_cases.Controls
                If (cell.getValue <> "M") Then
                    Reveal(cell, Game.p_cases.Controls.IndexOf(cell))
                End If
            Next
        End If
    End Sub

    Friend Sub trollAlwaysLoose(enable As Boolean)
        If (enable) Then
            For Each cell As Cell In Game.p_cases.Controls
                If (cell.getValue = "M") Then
                    Reveal(cell, Game.p_cases.Controls.IndexOf(cell))
                End If
            Next
        End If
    End Sub
End Module
