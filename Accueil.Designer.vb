<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Accueil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accueil))
        Me.cb_name = New System.Windows.Forms.ComboBox()
        Me.lb_name = New System.Windows.Forms.Label()
        Me.bt_start = New System.Windows.Forms.Button()
        Me.bt_quit = New System.Windows.Forms.Button()
        Me.btn_settings = New System.Windows.Forms.Button()
        Me.img_credits = New System.Windows.Forms.PictureBox()
        Me.bt_leaderboard = New System.Windows.Forms.Button()
        CType(Me.img_credits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cb_name
        '
        Me.cb_name.FormattingEnabled = True
        Me.cb_name.Location = New System.Drawing.Point(12, 116)
        Me.cb_name.Name = "cb_name"
        Me.cb_name.Size = New System.Drawing.Size(235, 21)
        Me.cb_name.TabIndex = 0
        Me.cb_name.Text = "Username"
        '
        'lb_name
        '
        Me.lb_name.AutoSize = True
        Me.lb_name.BackColor = System.Drawing.Color.Transparent
        Me.lb_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_name.Location = New System.Drawing.Point(49, 83)
        Me.lb_name.Name = "lb_name"
        Me.lb_name.Size = New System.Drawing.Size(165, 20)
        Me.lb_name.TabIndex = 1
        Me.lb_name.Text = "Enter your username :"
        '
        'bt_start
        '
        Me.bt_start.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_start.Location = New System.Drawing.Point(12, 143)
        Me.bt_start.Name = "bt_start"
        Me.bt_start.Size = New System.Drawing.Size(235, 57)
        Me.bt_start.TabIndex = 2
        Me.bt_start.Text = "Start a new game"
        Me.bt_start.UseVisualStyleBackColor = True
        '
        'bt_quit
        '
        Me.bt_quit.Location = New System.Drawing.Point(202, 12)
        Me.bt_quit.Name = "bt_quit"
        Me.bt_quit.Size = New System.Drawing.Size(45, 23)
        Me.bt_quit.TabIndex = 3
        Me.bt_quit.Text = "Quit"
        Me.bt_quit.UseVisualStyleBackColor = True
        '
        'btn_settings
        '
        Me.btn_settings.BackColor = System.Drawing.Color.Transparent
        Me.btn_settings.BackgroundImage = Global.DeluxeSweeper.My.Resources.Resources.settings
        Me.btn_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_settings.Location = New System.Drawing.Point(202, 35)
        Me.btn_settings.Name = "btn_settings"
        Me.btn_settings.Size = New System.Drawing.Size(45, 45)
        Me.btn_settings.TabIndex = 6
        Me.btn_settings.UseVisualStyleBackColor = False
        '
        'img_credits
        '
        Me.img_credits.BackgroundImage = Global.DeluxeSweeper.My.Resources.Resources.deluxesweeper
        Me.img_credits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.img_credits.Location = New System.Drawing.Point(63, 12)
        Me.img_credits.Name = "img_credits"
        Me.img_credits.Size = New System.Drawing.Size(133, 68)
        Me.img_credits.TabIndex = 5
        Me.img_credits.TabStop = False
        '
        'bt_leaderboard
        '
        Me.bt_leaderboard.BackgroundImage = Global.DeluxeSweeper.My.Resources.Resources.leaderboard
        Me.bt_leaderboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_leaderboard.Location = New System.Drawing.Point(12, 12)
        Me.bt_leaderboard.Name = "bt_leaderboard"
        Me.bt_leaderboard.Size = New System.Drawing.Size(45, 45)
        Me.bt_leaderboard.TabIndex = 4
        Me.bt_leaderboard.UseVisualStyleBackColor = True
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(259, 214)
        Me.Controls.Add(Me.btn_settings)
        Me.Controls.Add(Me.img_credits)
        Me.Controls.Add(Me.bt_leaderboard)
        Me.Controls.Add(Me.bt_quit)
        Me.Controls.Add(Me.bt_start)
        Me.Controls.Add(Me.lb_name)
        Me.Controls.Add(Me.cb_name)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Accueil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accueil"
        CType(Me.img_credits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cb_name As ComboBox
    Friend WithEvents lb_name As Label
    Friend WithEvents bt_start As Button
    Friend WithEvents bt_quit As Button
    Friend WithEvents bt_leaderboard As Button
    Friend WithEvents img_credits As PictureBox
    Friend WithEvents btn_settings As Button
End Class
