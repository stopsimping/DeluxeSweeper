<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Leaderboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Leaderboard))
        Me.lb_scoreboard = New System.Windows.Forms.Label()
        Me.lst_leaderboard = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lb_scoreboard
        '
        Me.lb_scoreboard.AutoSize = True
        Me.lb_scoreboard.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_scoreboard.Location = New System.Drawing.Point(197, 18)
        Me.lb_scoreboard.Name = "lb_scoreboard"
        Me.lb_scoreboard.Size = New System.Drawing.Size(310, 24)
        Me.lb_scoreboard.TabIndex = 1
        Me.lb_scoreboard.Text = "DeluxeSweeper Leaderboard"
        '
        'lst_leaderboard
        '
        Me.lst_leaderboard.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_leaderboard.FormattingEnabled = True
        Me.lst_leaderboard.ItemHeight = 19
        Me.lst_leaderboard.Location = New System.Drawing.Point(201, 45)
        Me.lst_leaderboard.Name = "lst_leaderboard"
        Me.lst_leaderboard.Size = New System.Drawing.Size(473, 251)
        Me.lst_leaderboard.TabIndex = 2
        '
        'Leaderboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 354)
        Me.Controls.Add(Me.lst_leaderboard)
        Me.Controls.Add(Me.lb_scoreboard)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Leaderboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Leaderboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_scoreboard As Label
    Friend WithEvents lst_leaderboard As ListBox
End Class
