<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameStats
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameStats))
        Me.win = New DeluxeSweeper.InvisiblePB()
        Me.lose = New DeluxeSweeper.InvisiblePB()
        Me.stats = New System.Windows.Forms.Label()
        Me.lb_discomines = New System.Windows.Forms.Label()
        Me.lb_mines = New System.Windows.Forms.Label()
        Me.lb_latestdisco = New System.Windows.Forms.Label()
        Me.lb_latest = New System.Windows.Forms.Label()
        Me.lb_dimensions = New System.Windows.Forms.Label()
        Me.lb_dim = New System.Windows.Forms.Label()
        Me.lb_howmanymines = New System.Windows.Forms.Label()
        Me.lb_mineshowmany = New System.Windows.Forms.Label()
        Me.gb_gamesettings = New System.Windows.Forms.GroupBox()
        Me.lb_sec = New System.Windows.Forms.Label()
        Me.lb_seconds = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        CType(Me.win, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_gamesettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'win
        '
        Me.win.Image = Global.DeluxeSweeper.My.Resources.Resources.win1
        Me.win.Location = New System.Drawing.Point(65, 12)
        Me.win.Name = "win"
        Me.win.Size = New System.Drawing.Size(265, 114)
        Me.win.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.win.TabIndex = 2
        Me.win.TabStop = False
        Me.win.Visible = False
        '
        'lose
        '
        Me.lose.Image = Global.DeluxeSweeper.My.Resources.Resources.lose
        Me.lose.Location = New System.Drawing.Point(65, 12)
        Me.lose.Name = "lose"
        Me.lose.Size = New System.Drawing.Size(265, 114)
        Me.lose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.lose.TabIndex = 0
        Me.lose.TabStop = False
        Me.lose.Visible = False
        '
        'stats
        '
        Me.stats.AutoSize = True
        Me.stats.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stats.Location = New System.Drawing.Point(32, 129)
        Me.stats.Name = "stats"
        Me.stats.Size = New System.Drawing.Size(330, 22)
        Me.stats.TabIndex = 3
        Me.stats.Text = "Some Statistics about the game :"
        '
        'lb_discomines
        '
        Me.lb_discomines.AutoSize = True
        Me.lb_discomines.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_discomines.Location = New System.Drawing.Point(12, 271)
        Me.lb_discomines.Name = "lb_discomines"
        Me.lb_discomines.Size = New System.Drawing.Size(226, 24)
        Me.lb_discomines.TabIndex = 4
        Me.lb_discomines.Text = "Discovered mines :"
        '
        'lb_mines
        '
        Me.lb_mines.AutoSize = True
        Me.lb_mines.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_mines.Location = New System.Drawing.Point(231, 273)
        Me.lb_mines.Name = "lb_mines"
        Me.lb_mines.Size = New System.Drawing.Size(118, 24)
        Me.lb_mines.TabIndex = 5
        Me.lb_mines.Text = "MINECOUNT"
        '
        'lb_latestdisco
        '
        Me.lb_latestdisco.AutoSize = True
        Me.lb_latestdisco.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_latestdisco.Location = New System.Drawing.Point(12, 304)
        Me.lb_latestdisco.Name = "lb_latestdisco"
        Me.lb_latestdisco.Size = New System.Drawing.Size(226, 24)
        Me.lb_latestdisco.TabIndex = 6
        Me.lb_latestdisco.Text = "Latest Discovery :"
        '
        'lb_latest
        '
        Me.lb_latest.AutoSize = True
        Me.lb_latest.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_latest.Location = New System.Drawing.Point(230, 306)
        Me.lb_latest.Name = "lb_latest"
        Me.lb_latest.Size = New System.Drawing.Size(82, 24)
        Me.lb_latest.TabIndex = 7
        Me.lb_latest.Text = "LATEST"
        '
        'lb_dimensions
        '
        Me.lb_dimensions.AutoSize = True
        Me.lb_dimensions.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_dimensions.Location = New System.Drawing.Point(20, 22)
        Me.lb_dimensions.Name = "lb_dimensions"
        Me.lb_dimensions.Size = New System.Drawing.Size(108, 19)
        Me.lb_dimensions.TabIndex = 9
        Me.lb_dimensions.Text = "Dimensions:"
        '
        'lb_dim
        '
        Me.lb_dim.AutoSize = True
        Me.lb_dim.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_dim.Location = New System.Drawing.Point(125, 24)
        Me.lb_dim.Name = "lb_dim"
        Me.lb_dim.Size = New System.Drawing.Size(99, 19)
        Me.lb_dim.TabIndex = 10
        Me.lb_dim.Text = "COL * ROWS"
        '
        'lb_howmanymines
        '
        Me.lb_howmanymines.AutoSize = True
        Me.lb_howmanymines.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_howmanymines.Location = New System.Drawing.Point(20, 41)
        Me.lb_howmanymines.Name = "lb_howmanymines"
        Me.lb_howmanymines.Size = New System.Drawing.Size(144, 19)
        Me.lb_howmanymines.TabIndex = 11
        Me.lb_howmanymines.Text = "How many mines:"
        '
        'lb_mineshowmany
        '
        Me.lb_mineshowmany.AutoSize = True
        Me.lb_mineshowmany.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_mineshowmany.Location = New System.Drawing.Point(156, 43)
        Me.lb_mineshowmany.Name = "lb_mineshowmany"
        Me.lb_mineshowmany.Size = New System.Drawing.Size(54, 19)
        Me.lb_mineshowmany.TabIndex = 12
        Me.lb_mineshowmany.Text = "MINES"
        '
        'gb_gamesettings
        '
        Me.gb_gamesettings.Controls.Add(Me.lb_sec)
        Me.gb_gamesettings.Controls.Add(Me.lb_seconds)
        Me.gb_gamesettings.Controls.Add(Me.lb_dimensions)
        Me.gb_gamesettings.Controls.Add(Me.lb_mineshowmany)
        Me.gb_gamesettings.Controls.Add(Me.lb_dim)
        Me.gb_gamesettings.Controls.Add(Me.lb_howmanymines)
        Me.gb_gamesettings.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_gamesettings.Location = New System.Drawing.Point(12, 154)
        Me.gb_gamesettings.Name = "gb_gamesettings"
        Me.gb_gamesettings.Size = New System.Drawing.Size(359, 105)
        Me.gb_gamesettings.TabIndex = 13
        Me.gb_gamesettings.TabStop = False
        Me.gb_gamesettings.Text = "Game Settings"
        '
        'lb_sec
        '
        Me.lb_sec.AutoSize = True
        Me.lb_sec.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_sec.Location = New System.Drawing.Point(175, 61)
        Me.lb_sec.Name = "lb_sec"
        Me.lb_sec.Size = New System.Drawing.Size(72, 19)
        Me.lb_sec.TabIndex = 14
        Me.lb_sec.Text = "SECONDS"
        '
        'lb_seconds
        '
        Me.lb_seconds.AutoSize = True
        Me.lb_seconds.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_seconds.Location = New System.Drawing.Point(20, 60)
        Me.lb_seconds.Name = "lb_seconds"
        Me.lb_seconds.Size = New System.Drawing.Size(162, 19)
        Me.lb_seconds.TabIndex = 13
        Me.lb_seconds.Text = "How many seconds:"
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(152, 344)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(86, 26)
        Me.btn_exit.TabIndex = 14
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'GameStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 384)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.gb_gamesettings)
        Me.Controls.Add(Me.lb_latest)
        Me.Controls.Add(Me.lb_latestdisco)
        Me.Controls.Add(Me.lb_mines)
        Me.Controls.Add(Me.lb_discomines)
        Me.Controls.Add(Me.stats)
        Me.Controls.Add(Me.win)
        Me.Controls.Add(Me.lose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GameStats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stats"
        CType(Me.win, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_gamesettings.ResumeLayout(False)
        Me.gb_gamesettings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lose As InvisiblePB
    Friend WithEvents win As InvisiblePB
    Friend WithEvents stats As Label
    Friend WithEvents lb_discomines As Label
    Friend WithEvents lb_mines As Label
    Friend WithEvents lb_latestdisco As Label
    Friend WithEvents lb_latest As Label
    Friend WithEvents lb_dimensions As Label
    Friend WithEvents lb_dim As Label
    Friend WithEvents lb_howmanymines As Label
    Friend WithEvents lb_mineshowmany As Label
    Friend WithEvents gb_gamesettings As GroupBox
    Friend WithEvents lb_sec As Label
    Friend WithEvents lb_seconds As Label
    Friend WithEvents btn_exit As Button
End Class
