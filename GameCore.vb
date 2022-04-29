
Module GameCore

    Private columns, rows As Integer
    Private mines As Integer
    Private gridMines(,) As Integer
    Private grid(,) As String
    Private time As Integer
    Private username As String
    Private lastDiscovered As Integer
    Private discoveredMines As Integer
    Private discoveredCases As Integer

    Private remainingFlags As Integer
    Private gameRunning As Boolean = False

    Private theme As Integer

    Sub Main()
        columns = Settings.gridSize ' Default : 8 
        rows = Settings.gridSize ' Default : 8
        mines = Settings.mines ' Default : 10
        theme = Settings.theme ' Default : Light (0) / Dark (1)
        time = Settings.seconds ' Default : 60 seconds
    End Sub

    Sub Init(gcolumns, grows, gmines, gtime, gusername)
        columns = gcolumns
        rows = grows
        mines = gmines
        time = gtime
        username = gusername
        gridMines = New Integer(0 To columns - 1, 0 To rows - 1) {}
        grid = New String(0 To columns - 1, 0 To rows - 1) {}

        remainingFlags = mines
        discoveredMines = 0
        discoveredCases = 0
        lastDiscovered = Settings.seconds
        Game.lb_flagc.Text = CType(remainingFlags, String)
        firstClick = True
        mineRevealedOrNotMineFlagged = False
        PlaceMines(gmines)
        UpdateNeightbours()

        Accueil.Hide()

        Game.gameoverStatic.Visible = False
        Game.sad.Visible = False
        Game.boom.Visible = False
        Game.Show()


        If (Settings.alwaysWin) Then
            h4ck4ut0r3s0l3r.autoResolve(True)
        ElseIf (Settings.alwaysLose) Then
            h4ck4ut0r3s0l3r.trollAlwaysLoose(True)
        End If

        Game.pause.Enabled = Settings.EnablePause
        Game.abandon.Enabled = True

        Console.WriteLine("------------------")

        For I As Integer = 0 To columns - 1
            For J As Integer = 0 To rows - 1
                Console.Write("{0} ", grid(I, J))
            Next
            Console.WriteLine()
        Next

    End Sub
    Public Sub changeGameRunning(status As Boolean)
        GameCore.gameRunning = status
    End Sub
    Public Function isGameRunning()
        Return GameCore.gameRunning
    End Function
    Public Function getUsername()
        If (username.Length > 12) Then
            Return username.Substring(0, 12)
        End If
        Return username
    End Function
    Public Function getCols()
        Return GameCore.columns
    End Function
    Public Function getRows()
        Return GameCore.rows
    End Function
    Public Function getDiscoMines()
        Return discoveredMines
    End Function
    Public Function getTime()
        Return time
    End Function

    Public Sub updateFlags(flags As Integer)
        remainingFlags = flags
        Game.lb_flagc.Text = CType(remainingFlags, String)
    End Sub
    Public Function getFlags()
        Return remainingFlags
    End Function
    Public Function getMines()
        Return mines
    End Function

    Public Function getLastDiscovered()
        Return lastDiscovered
    End Function

    Public WithEvents timer As New Timer

    Private remains As Integer

    Public Sub startTimer(sender As Object, e As EventArgs)
        timer.Interval = 1000
        remains = GameCore.getTime()

        If (Settings.timerEnabled) Then
            timer.Start()
        End If

        timer_Tick(sender, e)
    End Sub
    Private firstClick As Boolean
    Public Function hasPerformedFirstCLick()
        Return Not firstClick
    End Function
    Public Sub performFirstClick()
        firstClick = False
    End Sub
    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        Game.lb_time.Text = CType(remains - 1, String)
        If Not (firstClick) Then
            remains = remains - 1
            If (remains = 0) Then
                GameCore.timerEnded()
                timer.Stop()
            End If
        End If
    End Sub
    Private Sub RevealNeightbours(cell As Cell, index As Integer)
        If (cell.isFlagged And GameCore.isGameRunning) Then
            GameCore.updateFlags(GameCore.getFlags() + 1)
            Game.lb_flagc.Text = CStr(GameCore.getFlags())
        End If

        If (cell.getValue() <> "0" And cell.getValue <> "M" And Not cell.isRevealed()) Then
            ChangeCellContent(cell)
            Return
        End If

        If (cell.getValue() = "0" And cell.isRevealed()) Then
            For Each n As Neightbour In GetNeighbours(Math.Floor(index / rows), index Mod columns)
                Dim c As Cell = Game.p_cases.Controls.Item(getIndex(n))
                If (c.getValue() = "0" And Not c.isRevealed()) Then
                    ChangeCellContent(c)
                    RevealNeightbours(c, c.getIndex())
                ElseIf (c.getValue() <> "M" And Not c.isRevealed()) Then
                    ChangeCellContent(c)
                End If
            Next
        End If
    End Sub

    Private Function getIndex(n As Neightbour)
        Return ((n.c * columns) + n.r)
    End Function
    Sub DisplayGrid()
        Dim posLeft As Integer = 0 ' Btn pos
        Dim posTop As Integer = 0 ' Btn pos
        Dim GridSize As Integer = columns * rows ' How many buttons
        Dim Width As Integer = Game.p_cases.Width / columns ' Btn Width
        Dim Height As Integer = Game.p_cases.Height / rows ' Btn Height

        For I As Integer = 1 To GridSize

            If posLeft >= Game.p_cases.Width Then
                posLeft = 0
                posTop += Height
            End If

            Dim btn As New Cell

            btn.Text = ""
            btn.Left = posLeft
            btn.Top = posTop
            btn.Width = Width
            btn.Height = Height
            btn.Visible = True
            btn.ForeColor = Color.White
            btn.FlatAppearance.MouseOverBackColor = Color.White
            btn.FlatAppearance.MouseDownBackColor = Color.White
            btn.FlatAppearance.CheckedBackColor = Color.White

            ' Add the event to each button
            AddHandler btn.Click, AddressOf Game.OnButton_Click

            Game.p_cases.Controls.Add(btn)
            btn.setValue(grid(Math.Floor((I - 1) / columns), (I - 1) Mod (rows)))
            btn.setIndex(I - 1)

            posLeft += Width
        Next

    End Sub

    Private Sub PlaceMines(gmines As Integer)
        Dim placed = 0
        Randomize()

        Dim rand As Integer

        ' Init the Tab
        For I As Integer = 0 To columns - 1
            For J As Integer = 0 To rows - 1
                grid(I, J) = "0"
            Next
        Next

        While (Not placed > gmines)
            For I As Integer = 0 To columns - 1
                If (placed = gmines) Then
                    Return
                End If
                For J As Integer = 0 To rows - 1
                    If (placed = gmines) Then
                        Return
                    End If
                    If (Not gridMines(I, J) = 1) Then
                        rand = Int((100 * Rnd()))
                        If (rand > 98) Then
                            gridMines(I, J) = 1
                            grid(I, J) = "M" ' M for Mined
                            placed = placed + 1
                        Else
                            grid(I, J) = "0" '0' for Empty
                        End If
                    End If

                Next
            Next
        End While
    End Sub

    Class Neightbour
        Public c As Integer
        Public r As Integer
        Public Sub New(ByVal c As Integer, ByVal r As Integer)
            Me.c = c
            Me.r = r
        End Sub

#Disable Warning BC40005
        Public Function ToString()
#Enable Warning BC40005
            Return "(" + CType(c, String) + "," + CType(r, String) + ")"
        End Function
    End Class

    Private Function GetNeighbours(cc As Integer, cr As Integer)
        Dim Neightbours = New List(Of Neightbour)

        For c As Integer = (cc - 1) To (cc + 1)
            For r As Integer = (cr - 1) To (cr + 1)
                If (0 <= c And c < columns And 0 <= r And r < rows And (Not (c = cc) Or Not (r = cr))) Then
                    Neightbours.Add(New Neightbour(c, r))
                End If
            Next
        Next

        Return Neightbours
    End Function

    Private Sub UpdateNeightbours()
        For I As Integer = 0 To columns - 1
            For J As Integer = 0 To rows - 1
                For Each n As Neightbour In GetNeighbours(I, J)
                    If (grid(n.c, n.r) = "M" And Not grid(I, J) = "M") Then
                        grid(I, J) = CType(CType(grid(I, J), Integer) + 1, String)
                    End If
                Next
            Next
            Console.WriteLine()
        Next
    End Sub

    Private Sub GameLost()
        If (Not GameCore.isGameRunning()) Then
            GameCore.changeGameRunning(False)
            BoomAnimation()
            TimeOut(0.5)
            GameOverAnimation()
        End If
    End Sub

    Public Sub EndGame()
        If (GameCore.isGameRunning) Then
            GameCore.timer.Stop()
            GameCore.changeGameRunning(False)
            Game.abandon.Enabled = False
            Game.pause.Enabled = False

            Try
                Scores.newRecord(username, seconds - lastDiscovered, discoveredCases)
            Catch ex As Exception
                MsgBox(ex.Message & Environment.NewLine & "Cannot write the game into the scoreboard!")
            End Try

            If (GameCore.isGameWon()) Then
                GameStats.win.Visible = True
                For Each cell As Cell In Game.p_cases.Controls
                    ' And (cell.isFlagged Or Not cell.isFlagged)
                    If ((Not cell.isRevealed) And cell.getValue = "M") Then
                        cell.FlagIfNotDiscovered()
                    End If
                Next
            Else
                GameLost()
                Game.RevealAll()
                GameStats.lose.Visible = True
                TimeOut(2)
            End If
            GameStats.Show()
        End If
    End Sub

    Public Sub timerEnded()
        EndGame()
    End Sub

    Private mineRevealedOrNotMineFlagged
    Public Function isGameWon()
        discoveredMines = 0

        For Each cell As Cell In Game.p_cases.Controls
            If ((cell.isFlagged Or Not cell.isRevealed) And cell.getValue() <> "M") Or (cell.getValue = "M" And cell.isRevealed) Then
                mineRevealedOrNotMineFlagged = True
            End If
        Next

        For Each cell As Cell In Game.p_cases.Controls
            ' And (cell.isFlagged Or Not cell.isFlagged)
            If ((Not cell.isRevealed) And cell.getValue = "M" And (cell.isFlagged Or Not mineRevealedOrNotMineFlagged)) Then
                discoveredMines += 1
            ElseIf ((cell.isFlagged Or Not cell.isRevealed) And cell.getValue() <> "M") Or (cell.getValue = "M" And cell.isRevealed) Then
                mineRevealedOrNotMineFlagged = True
            End If
        Next

        Return (discoveredMines = mines) And Not mineRevealedOrNotMineFlagged
    End Function


    Private Sub CheckEverythingDiscovered()
        discoveredCases = 0

        For Each cell As Cell In Game.p_cases.Controls
            If (cell.isRevealed()) Then
                discoveredCases += 1
            End If
        Next

        If ((columns * rows) - mines = discoveredCases) Then
            EndGame()
        End If
    End Sub
    Private Sub BoomAnimation()
        Game.boom.Visible = True
        TimeOut(1.6)
        Game.boom.Visible = False
    End Sub

    Private Sub GameOverAnimation()
        Randomize()
        Dim Middle As New Point(Game.gameoverStatic.Location.X, Game.gameoverStatic.Location.Y)
        Dim poop As New Label()
        poop.Text = "poop"
        poop.Location = Middle
        ' Game.gameover pour le gif
        Game.gameoverStatic.Visible = True
        My.Computer.Audio.Play(My.Resources.img.death, AudioPlayMode.WaitToComplete)
        Game.sad.Visible = True

        If (Settings.animationEclatax) Then
            For J As Integer = 0 To 100
                For I As Integer = 0 To 10
                    Game.gameoverStatic.Height += CInt(Rnd())
                    Game.gameoverStatic.Width += CInt(Rnd())
                    If (Game.gameoverStatic.Location.X + CInt(Rnd()) > Game.p_cases.Location.X Or Game.gameoverStatic.Location.Y + CInt(Rnd()) > Game.p_cases.Location.Y) Then
                        Game.gameoverStatic.Location = New Point(Game.gameoverStatic.Location.X - 10, Game.gameoverStatic.Location.X - 10)
                    End If
                    TimeOut(0)
                Next

                For I As Integer = 0 To 10
                    Game.gameoverStatic.Height -= 5
                    Game.gameoverStatic.Width -= 5
                    Game.gameoverStatic.Location = New Point(Game.gameoverStatic.Location.X + 5, Game.gameoverStatic.Location.Y + 5)
                    TimeOut(0)
                Next
            Next

        Else
            Game.gameoverStatic.Visible = True
            Game.sad.Visible = True
            TimeOut(2)
            Game.gameoverStatic.Visible = False
            Game.sad.Visible = False
        End If
        TimeOut(0)
    End Sub

    Private Sub TimeOut(seconds As Double)
        Dim wait = Date.Now().AddSeconds(seconds)
        Do Until Date.Now() > wait
            Windows.Forms.Application.DoEvents()
        Loop
    End Sub

    Public Sub Reveal(cell As Cell, index As Integer)
        If (GameCore.isGameRunning()) Then
            If (cell.isRevealed()) Then
                Return
            End If
            cell.BackgroundImage = Nothing
            cell.setRevealed(True)
            ChangeCellContent(cell)
            RevealNeightbours(cell, index)
            CheckEverythingDiscovered()
        End If
    End Sub

    Friend Sub ChangeCellContent(cell As Cell)
        cell.Reveal()
        If (GameCore.isGameRunning()) Then
            lastDiscovered = GameCore.remains
            If (cell.getValue() = "M") Then
                EndGame()
            End If
        End If
    End Sub


    ' Throw an exception to quit the module
    Friend Sub QuitModule()
        Throw New Exception("Game exited")
    End Sub

End Module
