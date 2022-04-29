<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Game
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game))
        Me.lb_username = New System.Windows.Forms.Label()
        Me.lb_player = New System.Windows.Forms.Label()
        Me.gb_gameinfos = New System.Windows.Forms.GroupBox()
        Me.lb_flagc = New System.Windows.Forms.Label()
        Me.lb_flag = New System.Windows.Forms.Label()
        Me.lb_time = New System.Windows.Forms.Label()
        Me.lb_timeleft = New System.Windows.Forms.Label()
        Me.p_cases = New System.Windows.Forms.Panel()
        Me.abandon = New System.Windows.Forms.Button()
        Me.pause = New System.Windows.Forms.Button()
        Me.sad = New DeluxeSweeper.InvisiblePB()
        Me.gameoverStatic = New DeluxeSweeper.InvisiblePB()
        Me.pb_pause = New DeluxeSweeper.InvisiblePB()
        Me.boom = New DeluxeSweeper.InvisiblePB()
        Me.gb_gameinfos.SuspendLayout()
        CType(Me.sad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gameoverStatic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_pause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.boom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb_username
        '
        Me.lb_username.AutoSize = True
        Me.lb_username.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_username.Location = New System.Drawing.Point(64, 17)
        Me.lb_username.Name = "lb_username"
        Me.lb_username.Size = New System.Drawing.Size(72, 18)
        Me.lb_username.TabIndex = 2
        Me.lb_username.Text = "USERNAME"
        '
        'lb_player
        '
        Me.lb_player.AutoSize = True
        Me.lb_player.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_player.Location = New System.Drawing.Point(6, 16)
        Me.lb_player.Name = "lb_player"
        Me.lb_player.Size = New System.Drawing.Size(64, 18)
        Me.lb_player.TabIndex = 3
        Me.lb_player.Text = "Player:"
        '
        'gb_gameinfos
        '
        Me.gb_gameinfos.BackColor = System.Drawing.Color.Transparent
        Me.gb_gameinfos.Controls.Add(Me.lb_flagc)
        Me.gb_gameinfos.Controls.Add(Me.lb_flag)
        Me.gb_gameinfos.Controls.Add(Me.lb_time)
        Me.gb_gameinfos.Controls.Add(Me.lb_timeleft)
        Me.gb_gameinfos.Controls.Add(Me.lb_username)
        Me.gb_gameinfos.Controls.Add(Me.lb_player)
        Me.gb_gameinfos.Location = New System.Drawing.Point(42, 22)
        Me.gb_gameinfos.Name = "gb_gameinfos"
        Me.gb_gameinfos.Size = New System.Drawing.Size(400, 50)
        Me.gb_gameinfos.TabIndex = 4
        Me.gb_gameinfos.TabStop = False
        Me.gb_gameinfos.Text = "Game Informations"
        '
        'lb_flagc
        '
        Me.lb_flagc.AutoSize = True
        Me.lb_flagc.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_flagc.Location = New System.Drawing.Point(213, 17)
        Me.lb_flagc.Name = "lb_flagc"
        Me.lb_flagc.Size = New System.Drawing.Size(32, 18)
        Me.lb_flagc.TabIndex = 7
        Me.lb_flagc.Text = "NBF"
        '
        'lb_flag
        '
        Me.lb_flag.AutoSize = True
        Me.lb_flag.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_flag.Location = New System.Drawing.Point(162, 16)
        Me.lb_flag.Name = "lb_flag"
        Me.lb_flag.Size = New System.Drawing.Size(56, 18)
        Me.lb_flag.TabIndex = 6
        Me.lb_flag.Text = "Flags:"
        '
        'lb_time
        '
        Me.lb_time.AutoSize = True
        Me.lb_time.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_time.Location = New System.Drawing.Point(354, 17)
        Me.lb_time.Name = "lb_time"
        Me.lb_time.Size = New System.Drawing.Size(40, 18)
        Me.lb_time.TabIndex = 5
        Me.lb_time.Text = "TIME"
        '
        'lb_timeleft
        '
        Me.lb_timeleft.AutoSize = True
        Me.lb_timeleft.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_timeleft.Location = New System.Drawing.Point(261, 17)
        Me.lb_timeleft.Name = "lb_timeleft"
        Me.lb_timeleft.Size = New System.Drawing.Size(88, 18)
        Me.lb_timeleft.TabIndex = 4
        Me.lb_timeleft.Text = "Time left:"
        '
        'p_cases
        '
        Me.p_cases.Location = New System.Drawing.Point(42, 78)
        Me.p_cases.Name = "p_cases"
        Me.p_cases.Size = New System.Drawing.Size(400, 400)
        Me.p_cases.TabIndex = 0
        '
        'abandon
        '
        Me.abandon.Location = New System.Drawing.Point(42, 483)
        Me.abandon.Name = "abandon"
        Me.abandon.Size = New System.Drawing.Size(195, 33)
        Me.abandon.TabIndex = 6
        Me.abandon.Text = "Abandon"
        Me.abandon.UseVisualStyleBackColor = True
        '
        'pause
        '
        Me.pause.Location = New System.Drawing.Point(247, 483)
        Me.pause.Name = "pause"
        Me.pause.Size = New System.Drawing.Size(195, 33)
        Me.pause.TabIndex = 8
        Me.pause.Text = "Pause"
        Me.pause.UseVisualStyleBackColor = True
        '
        'sad
        '
        Me.sad.Image = Global.DeluxeSweeper.My.Resources.Resources.sad
        Me.sad.Location = New System.Drawing.Point(58, 302)
        Me.sad.Name = "sad"
        Me.sad.Size = New System.Drawing.Size(362, 177)
        Me.sad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.sad.TabIndex = 11
        Me.sad.TabStop = False
        Me.sad.Visible = False
        '
        'gameoverStatic
        '
        Me.gameoverStatic.Image = Global.DeluxeSweeper.My.Resources.Resources.gameoverStatic
        Me.gameoverStatic.Location = New System.Drawing.Point(95, 160)
        Me.gameoverStatic.Name = "gameoverStatic"
        Me.gameoverStatic.Size = New System.Drawing.Size(301, 148)
        Me.gameoverStatic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.gameoverStatic.TabIndex = 10
        Me.gameoverStatic.TabStop = False
        Me.gameoverStatic.Visible = False
        '
        'pb_pause
        '
        Me.pb_pause.Image = Global.DeluxeSweeper.My.Resources.Resources.pause
        Me.pb_pause.Location = New System.Drawing.Point(0, 191)
        Me.pb_pause.Name = "pb_pause"
        Me.pb_pause.Size = New System.Drawing.Size(477, 177)
        Me.pb_pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_pause.TabIndex = 9
        Me.pb_pause.TabStop = False
        Me.pb_pause.Visible = False
        '
        'boom
        '
        Me.boom.Image = Global.DeluxeSweeper.My.Resources.Resources.boom
        Me.boom.Location = New System.Drawing.Point(-57, -71)
        Me.boom.Name = "boom"
        Me.boom.Size = New System.Drawing.Size(592, 740)
        Me.boom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.boom.TabIndex = 5
        Me.boom.TabStop = False
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(491, 528)
        Me.ControlBox = False
        Me.Controls.Add(Me.boom)
        Me.Controls.Add(Me.sad)
        Me.Controls.Add(Me.pause)
        Me.Controls.Add(Me.abandon)
        Me.Controls.Add(Me.gb_gameinfos)
        Me.Controls.Add(Me.gameoverStatic)
        Me.Controls.Add(Me.pb_pause)
        Me.Controls.Add(Me.p_cases)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Game"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game"
        Me.gb_gameinfos.ResumeLayout(False)
        Me.gb_gameinfos.PerformLayout()
        CType(Me.sad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gameoverStatic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_pause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.boom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lb_username As Label
    Friend WithEvents lb_player As Label
    Friend WithEvents gb_gameinfos As GroupBox
    Friend WithEvents lb_time As Label
    Friend WithEvents lb_timeleft As Label
    Friend WithEvents p_cases As Panel
    Friend WithEvents boom As InvisiblePB
    Friend WithEvents abandon As Button
    Friend WithEvents pause As Button
    Friend WithEvents pb_pause As InvisiblePB
    Friend WithEvents lb_flagc As Label
    Friend WithEvents lb_flag As Label
    Friend WithEvents gameoverStatic As InvisiblePB
    Friend WithEvents sad As InvisiblePB
End Class
