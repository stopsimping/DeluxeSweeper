Imports System.Windows.Forms
Imports System.Drawing
Public Class Cell
    Inherits Button

    Private index As Integer
    Private value As String
    Private flagged As Boolean = False
    Private revealed As Boolean = False
    Public Sub New()
        ' Not discovered
        Me.BackgroundImage = My.Resources.img.facingDown
        Me.BackgroundImageLayout = ImageLayout.Zoom
        Me.BackColor = Color.Lavender ' Au cas où
        Me.FlatStyle = Windows.Forms.FlatStyle.Flat
        Me.FlatAppearance.BorderColor = SystemColors.ControlDarkDark
        Me.FlatAppearance.MouseDownBackColor = Color.Cyan
        Me.FlatAppearance.MouseOverBackColor = Color.Green
        Me.Font = New Font("Consolas", 12, FontStyle.Regular)
        Me.ForeColor = Color.Black
        Me.Text = ""
        Me.TabStop = False
        Me.SetStyle(ControlStyles.Selectable, False)
        Me.Cursor = Cursors.Hand
    End Sub

    ' https://www.youtube.com/watch?v=SCed1acabpE

    Public Function getIndex()
        Return Me.index
    End Function

    Public Sub setIndex(id As Integer)
        Me.index = id
    End Sub

    Public Function isRevealed()
        Return revealed
    End Function

    Public Sub setRevealed(r As Boolean)
        Me.revealed = r
    End Sub

    Public Function getValue()
        Return Me.value
    End Function

    Public Sub setValue(newValue As String)
        Me.value = newValue
    End Sub

    Public Function isFlagged()
        Return flagged
    End Function

    Friend Sub FlagIfNotDiscovered()
        If (Me.getValue = "M" And Not Me.isRevealed()) Then
            Me.BackgroundImage = My.Resources.img.flagged
            Me.flagged = True
            GameCore.updateFlags(GameCore.getFlags() - 1) ' ???????????
        End If
    End Sub
    Friend Sub Flag_Cell(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Right Then
            If (Not Me.isRevealed) Then
                If (Not isFlagged() And GameCore.getFlags() > 0) Then
                    Me.BackgroundImage = My.Resources.img.flagged
                    Me.flagged = True
                    GameCore.updateFlags(GameCore.getFlags() - 1)
                ElseIf (isFlagged()) Then
                    Me.BackgroundImage = My.Resources.img.facingDown
                    Me.flagged = False
                    GameCore.updateFlags(GameCore.getFlags() + 1)
                End If
                Me.BackgroundImageLayout = ImageLayout.Zoom
            End If
            Game.lb_flagc.Text = GameCore.getFlags()
        End If
    End Sub

    Friend Sub Reveal()
        If (Not (GameCore.isGameRunning()) And (Me.isFlagged And Me.getValue <> "M") Or (Me.getValue() = "M" And Not Me.isFlagged)) Then
            Me.Image = My.Resources.img.cross.GetThumbnailImage(Me.Height / 3, Me.Width / 3, Nothing, IntPtr.Zero)
        End If

        If (Me.getValue() = "M") Then
            Me.BackColor = Color.FromArgb(1, 176, 184, 183)
            Me.BackgroundImage = My.Resources.img.mined
            Me.BackgroundImageLayout = ImageLayout.Zoom
        Else
            Me.ForeColor = Color.Transparent
            Me.BackgroundImage = My.Resources.img.ResourceManager.GetObject("_" + CType(Me.getValue(), String))
            Me.BackgroundImageLayout = ImageLayout.Zoom
        End If

        If (GameCore.isGameRunning) Then
            Me.setRevealed(True)
        End If
    End Sub

End Class
