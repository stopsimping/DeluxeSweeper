<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GameSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameSettings))
        Me.tab_settings = New System.Windows.Forms.TabControl()
        Me.tb_basics = New System.Windows.Forms.TabPage()
        Me.btn_saveBasics = New System.Windows.Forms.Button()
        Me.lb_theme = New System.Windows.Forms.Label()
        Me.cb_theme = New System.Windows.Forms.ComboBox()
        Me.lb_mines = New System.Windows.Forms.Label()
        Me.sb_mines = New System.Windows.Forms.HScrollBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_dim = New System.Windows.Forms.Label()
        Me.grid_dim = New System.Windows.Forms.Label()
        Me.tb_gridSize = New System.Windows.Forms.TrackBar()
        Me.tb_advanced = New System.Windows.Forms.TabPage()
        Me.btn_animEclatax = New System.Windows.Forms.CheckBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_savePath = New System.Windows.Forms.Button()
        Me.tb_filePath = New System.Windows.Forms.TextBox()
        Me.lb_savePath = New System.Windows.Forms.Label()
        Me.gb_pauseAndtimer = New System.Windows.Forms.GroupBox()
        Me.lb_maxseconds = New System.Windows.Forms.Label()
        Me.lb_zero = New System.Windows.Forms.Label()
        Me.lb_seconds = New System.Windows.Forms.Label()
        Me.lb_howmanyseconds = New System.Windows.Forms.Label()
        Me.tb_seconds = New System.Windows.Forms.TrackBar()
        Me.btn_pause = New System.Windows.Forms.CheckBox()
        Me.btn_timer = New System.Windows.Forms.CheckBox()
        Me.tb_hack = New System.Windows.Forms.TabPage()
        Me.savePath = New System.Windows.Forms.FolderBrowserDialog()
        Me.tab_settings.SuspendLayout()
        Me.tb_basics.SuspendLayout()
        CType(Me.tb_gridSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tb_advanced.SuspendLayout()
        Me.gb_pauseAndtimer.SuspendLayout()
        CType(Me.tb_seconds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tab_settings
        '
        Me.tab_settings.Controls.Add(Me.tb_basics)
        Me.tab_settings.Controls.Add(Me.tb_advanced)
        Me.tab_settings.Controls.Add(Me.tb_hack)
        Me.tab_settings.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_settings.Location = New System.Drawing.Point(12, 19)
        Me.tab_settings.Name = "tab_settings"
        Me.tab_settings.SelectedIndex = 0
        Me.tab_settings.Size = New System.Drawing.Size(298, 297)
        Me.tab_settings.TabIndex = 1
        '
        'tb_basics
        '
        Me.tb_basics.Controls.Add(Me.btn_saveBasics)
        Me.tb_basics.Controls.Add(Me.lb_theme)
        Me.tb_basics.Controls.Add(Me.cb_theme)
        Me.tb_basics.Controls.Add(Me.lb_mines)
        Me.tb_basics.Controls.Add(Me.sb_mines)
        Me.tb_basics.Controls.Add(Me.Label4)
        Me.tb_basics.Controls.Add(Me.Label3)
        Me.tb_basics.Controls.Add(Me.Label2)
        Me.tb_basics.Controls.Add(Me.Label1)
        Me.tb_basics.Controls.Add(Me.lb_dim)
        Me.tb_basics.Controls.Add(Me.grid_dim)
        Me.tb_basics.Controls.Add(Me.tb_gridSize)
        Me.tb_basics.Location = New System.Drawing.Point(4, 24)
        Me.tb_basics.Name = "tb_basics"
        Me.tb_basics.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_basics.Size = New System.Drawing.Size(290, 269)
        Me.tb_basics.TabIndex = 0
        Me.tb_basics.Text = "Basics"
        Me.tb_basics.UseVisualStyleBackColor = True
        '
        'btn_saveBasics
        '
        Me.btn_saveBasics.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_saveBasics.Location = New System.Drawing.Point(111, 242)
        Me.btn_saveBasics.Name = "btn_saveBasics"
        Me.btn_saveBasics.Size = New System.Drawing.Size(75, 23)
        Me.btn_saveBasics.TabIndex = 12
        Me.btn_saveBasics.Text = "Save"
        Me.btn_saveBasics.UseVisualStyleBackColor = True
        '
        'lb_theme
        '
        Me.lb_theme.AutoSize = True
        Me.lb_theme.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_theme.Location = New System.Drawing.Point(6, 174)
        Me.lb_theme.Name = "lb_theme"
        Me.lb_theme.Size = New System.Drawing.Size(144, 19)
        Me.lb_theme.TabIndex = 11
        Me.lb_theme.Text = "Current theme :"
        '
        'cb_theme
        '
        Me.cb_theme.FormattingEnabled = True
        Me.cb_theme.Items.AddRange(New Object() {"Light", "Dark", "Eye Destroyer"})
        Me.cb_theme.Location = New System.Drawing.Point(154, 172)
        Me.cb_theme.Name = "cb_theme"
        Me.cb_theme.Size = New System.Drawing.Size(121, 23)
        Me.cb_theme.TabIndex = 10
        Me.cb_theme.Text = "Default (Light)"
        '
        'lb_mines
        '
        Me.lb_mines.AutoSize = True
        Me.lb_mines.Location = New System.Drawing.Point(234, 136)
        Me.lb_mines.Name = "lb_mines"
        Me.lb_mines.Size = New System.Drawing.Size(42, 15)
        Me.lb_mines.TabIndex = 9
        Me.lb_mines.Text = "MINES"
        '
        'sb_mines
        '
        Me.sb_mines.LargeChange = 2
        Me.sb_mines.Location = New System.Drawing.Point(127, 133)
        Me.sb_mines.Maximum = 16
        Me.sb_mines.Minimum = 1
        Me.sb_mines.Name = "sb_mines"
        Me.sb_mines.Size = New System.Drawing.Size(104, 16)
        Me.sb_mines.TabIndex = 8
        Me.sb_mines.Value = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Mine count : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(124, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "8"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(262, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "16"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "2"
        '
        'lb_dim
        '
        Me.lb_dim.AutoSize = True
        Me.lb_dim.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_dim.Location = New System.Drawing.Point(162, 43)
        Me.lb_dim.Name = "lb_dim"
        Me.lb_dim.Size = New System.Drawing.Size(99, 19)
        Me.lb_dim.TabIndex = 2
        Me.lb_dim.Text = "DIMENSIONS"
        '
        'grid_dim
        '
        Me.grid_dim.AutoSize = True
        Me.grid_dim.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_dim.Location = New System.Drawing.Point(6, 42)
        Me.grid_dim.Name = "grid_dim"
        Me.grid_dim.Size = New System.Drawing.Size(162, 19)
        Me.grid_dim.TabIndex = 1
        Me.grid_dim.Text = "Grid dimensions :"
        '
        'tb_gridSize
        '
        Me.tb_gridSize.BackColor = System.Drawing.Color.White
        Me.tb_gridSize.LargeChange = 2
        Me.tb_gridSize.Location = New System.Drawing.Point(6, 65)
        Me.tb_gridSize.Maximum = 16
        Me.tb_gridSize.Minimum = 2
        Me.tb_gridSize.Name = "tb_gridSize"
        Me.tb_gridSize.Size = New System.Drawing.Size(278, 45)
        Me.tb_gridSize.SmallChange = 2
        Me.tb_gridSize.TabIndex = 0
        Me.tb_gridSize.Value = 8
        '
        'tb_advanced
        '
        Me.tb_advanced.Controls.Add(Me.btn_animEclatax)
        Me.tb_advanced.Controls.Add(Me.btn_save)
        Me.tb_advanced.Controls.Add(Me.btn_savePath)
        Me.tb_advanced.Controls.Add(Me.tb_filePath)
        Me.tb_advanced.Controls.Add(Me.lb_savePath)
        Me.tb_advanced.Controls.Add(Me.gb_pauseAndtimer)
        Me.tb_advanced.Location = New System.Drawing.Point(4, 24)
        Me.tb_advanced.Name = "tb_advanced"
        Me.tb_advanced.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_advanced.Size = New System.Drawing.Size(290, 269)
        Me.tb_advanced.TabIndex = 1
        Me.tb_advanced.Text = "Advanced"
        Me.tb_advanced.UseVisualStyleBackColor = True
        '
        'btn_animEclatax
        '
        Me.btn_animEclatax.AutoSize = True
        Me.btn_animEclatax.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_animEclatax.Location = New System.Drawing.Point(6, 213)
        Me.btn_animEclatax.Name = "btn_animEclatax"
        Me.btn_animEclatax.Size = New System.Drawing.Size(244, 23)
        Me.btn_animEclatax.TabIndex = 14
        Me.btn_animEclatax.Text = "Animation éclatée au sol"
        Me.btn_animEclatax.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(111, 242)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 13
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_savePath
        '
        Me.btn_savePath.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_savePath.Location = New System.Drawing.Point(152, 157)
        Me.btn_savePath.Name = "btn_savePath"
        Me.btn_savePath.Size = New System.Drawing.Size(126, 23)
        Me.btn_savePath.TabIndex = 9
        Me.btn_savePath.Text = "Select file path"
        Me.btn_savePath.UseVisualStyleBackColor = True
        '
        'tb_filePath
        '
        Me.tb_filePath.Location = New System.Drawing.Point(6, 186)
        Me.tb_filePath.Name = "tb_filePath"
        Me.tb_filePath.ReadOnly = True
        Me.tb_filePath.Size = New System.Drawing.Size(278, 23)
        Me.tb_filePath.TabIndex = 8
        '
        'lb_savePath
        '
        Me.lb_savePath.AutoSize = True
        Me.lb_savePath.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_savePath.Location = New System.Drawing.Point(8, 157)
        Me.lb_savePath.Name = "lb_savePath"
        Me.lb_savePath.Size = New System.Drawing.Size(144, 19)
        Me.lb_savePath.TabIndex = 7
        Me.lb_savePath.Text = "Save file path:"
        '
        'gb_pauseAndtimer
        '
        Me.gb_pauseAndtimer.Controls.Add(Me.lb_maxseconds)
        Me.gb_pauseAndtimer.Controls.Add(Me.lb_zero)
        Me.gb_pauseAndtimer.Controls.Add(Me.lb_seconds)
        Me.gb_pauseAndtimer.Controls.Add(Me.lb_howmanyseconds)
        Me.gb_pauseAndtimer.Controls.Add(Me.tb_seconds)
        Me.gb_pauseAndtimer.Controls.Add(Me.btn_pause)
        Me.gb_pauseAndtimer.Controls.Add(Me.btn_timer)
        Me.gb_pauseAndtimer.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_pauseAndtimer.Location = New System.Drawing.Point(6, 6)
        Me.gb_pauseAndtimer.Name = "gb_pauseAndtimer"
        Me.gb_pauseAndtimer.Size = New System.Drawing.Size(278, 145)
        Me.gb_pauseAndtimer.TabIndex = 0
        Me.gb_pauseAndtimer.TabStop = False
        Me.gb_pauseAndtimer.Text = "Timers and Pause"
        '
        'lb_maxseconds
        '
        Me.lb_maxseconds.AutoSize = True
        Me.lb_maxseconds.Location = New System.Drawing.Point(240, 94)
        Me.lb_maxseconds.Name = "lb_maxseconds"
        Me.lb_maxseconds.Size = New System.Drawing.Size(36, 19)
        Me.lb_maxseconds.TabIndex = 6
        Me.lb_maxseconds.Text = "600"
        '
        'lb_zero
        '
        Me.lb_zero.AutoSize = True
        Me.lb_zero.Location = New System.Drawing.Point(17, 94)
        Me.lb_zero.Name = "lb_zero"
        Me.lb_zero.Size = New System.Drawing.Size(18, 19)
        Me.lb_zero.TabIndex = 5
        Me.lb_zero.Text = "0"
        '
        'lb_seconds
        '
        Me.lb_seconds.AutoSize = True
        Me.lb_seconds.Location = New System.Drawing.Point(177, 72)
        Me.lb_seconds.Name = "lb_seconds"
        Me.lb_seconds.Size = New System.Drawing.Size(72, 19)
        Me.lb_seconds.TabIndex = 4
        Me.lb_seconds.Text = "SECONDS"
        '
        'lb_howmanyseconds
        '
        Me.lb_howmanyseconds.AutoSize = True
        Me.lb_howmanyseconds.Location = New System.Drawing.Point(21, 72)
        Me.lb_howmanyseconds.Name = "lb_howmanyseconds"
        Me.lb_howmanyseconds.Size = New System.Drawing.Size(162, 19)
        Me.lb_howmanyseconds.TabIndex = 3
        Me.lb_howmanyseconds.Text = "How many seconds:"
        '
        'tb_seconds
        '
        Me.tb_seconds.Location = New System.Drawing.Point(36, 94)
        Me.tb_seconds.Maximum = 600
        Me.tb_seconds.Minimum = 5
        Me.tb_seconds.Name = "tb_seconds"
        Me.tb_seconds.Size = New System.Drawing.Size(204, 45)
        Me.tb_seconds.TabIndex = 2
        Me.tb_seconds.Value = 5
        '
        'btn_pause
        '
        Me.btn_pause.AutoSize = True
        Me.btn_pause.Checked = True
        Me.btn_pause.CheckState = System.Windows.Forms.CheckState.Checked
        Me.btn_pause.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pause.Location = New System.Drawing.Point(162, 30)
        Me.btn_pause.Name = "btn_pause"
        Me.btn_pause.Size = New System.Drawing.Size(110, 19)
        Me.btn_pause.TabIndex = 1
        Me.btn_pause.Text = "Enable Pause"
        Me.btn_pause.UseVisualStyleBackColor = True
        '
        'btn_timer
        '
        Me.btn_timer.AutoSize = True
        Me.btn_timer.Checked = True
        Me.btn_timer.CheckState = System.Windows.Forms.CheckState.Checked
        Me.btn_timer.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_timer.Location = New System.Drawing.Point(6, 30)
        Me.btn_timer.Name = "btn_timer"
        Me.btn_timer.Size = New System.Drawing.Size(110, 19)
        Me.btn_timer.TabIndex = 0
        Me.btn_timer.Text = "Enable Timer"
        Me.btn_timer.UseVisualStyleBackColor = True
        '
        'tb_hack
        '
        Me.tb_hack.Location = New System.Drawing.Point(4, 24)
        Me.tb_hack.Name = "tb_hack"
        Me.tb_hack.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_hack.Size = New System.Drawing.Size(290, 269)
        Me.tb_hack.TabIndex = 2
        Me.tb_hack.Text = "Hack"
        Me.tb_hack.UseVisualStyleBackColor = True
        '
        'savePath
        '
        Me.savePath.Description = "Save file path"
        Me.savePath.SelectedPath = "."
        '
        'GameSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 328)
        Me.Controls.Add(Me.tab_settings)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GameSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.tab_settings.ResumeLayout(False)
        Me.tb_basics.ResumeLayout(False)
        Me.tb_basics.PerformLayout()
        CType(Me.tb_gridSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tb_advanced.ResumeLayout(False)
        Me.tb_advanced.PerformLayout()
        Me.gb_pauseAndtimer.ResumeLayout(False)
        Me.gb_pauseAndtimer.PerformLayout()
        CType(Me.tb_seconds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab_settings As TabControl
    Friend WithEvents tb_basics As TabPage
    Friend WithEvents tb_advanced As TabPage
    Friend WithEvents tb_hack As TabPage
    Friend WithEvents lb_dim As Label
    Friend WithEvents grid_dim As Label
    Friend WithEvents tb_gridSize As TrackBar
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents sb_mines As HScrollBar
    Friend WithEvents lb_mines As Label
    Friend WithEvents lb_theme As Label
    Friend WithEvents cb_theme As ComboBox
    Friend WithEvents btn_saveBasics As Button
    Friend WithEvents gb_pauseAndtimer As GroupBox
    Friend WithEvents btn_pause As CheckBox
    Friend WithEvents btn_timer As CheckBox
    Friend WithEvents savePath As FolderBrowserDialog
    Friend WithEvents btn_savePath As Button
    Friend WithEvents tb_filePath As TextBox
    Friend WithEvents lb_savePath As Label
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_animEclatax As CheckBox
    Friend WithEvents lb_maxseconds As Label
    Friend WithEvents lb_zero As Label
    Friend WithEvents lb_seconds As Label
    Friend WithEvents lb_howmanyseconds As Label
    Friend WithEvents tb_seconds As TrackBar
End Class
