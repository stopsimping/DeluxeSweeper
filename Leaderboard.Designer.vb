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
        Me.btn_sort = New System.Windows.Forms.Button()
        Me.cb_players = New System.Windows.Forms.ComboBox()
        Me.lb_search = New System.Windows.Forms.Label()
        Me.btn_details = New System.Windows.Forms.Button()
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
        Me.lst_leaderboard.HorizontalScrollbar = True
        Me.lst_leaderboard.ItemHeight = 19
        Me.lst_leaderboard.Location = New System.Drawing.Point(201, 45)
        Me.lst_leaderboard.Name = "lst_leaderboard"
        Me.lst_leaderboard.Size = New System.Drawing.Size(492, 251)
        Me.lst_leaderboard.TabIndex = 2
        '
        'btn_sort
        '
        Me.btn_sort.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sort.Location = New System.Drawing.Point(343, 302)
        Me.btn_sort.Name = "btn_sort"
        Me.btn_sort.Size = New System.Drawing.Size(214, 23)
        Me.btn_sort.TabIndex = 3
        Me.btn_sort.Text = "Unknown state"
        Me.btn_sort.UseVisualStyleBackColor = True
        '
        'cb_players
        '
        Me.cb_players.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_players.FormattingEnabled = True
        Me.cb_players.Location = New System.Drawing.Point(12, 72)
        Me.cb_players.Name = "cb_players"
        Me.cb_players.Size = New System.Drawing.Size(183, 23)
        Me.cb_players.TabIndex = 4
        '
        'lb_search
        '
        Me.lb_search.AutoSize = True
        Me.lb_search.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_search.Location = New System.Drawing.Point(12, 50)
        Me.lb_search.Name = "lb_search"
        Me.lb_search.Size = New System.Drawing.Size(144, 19)
        Me.lb_search.TabIndex = 5
        Me.lb_search.Text = "Search by name:"
        '
        'btn_details
        '
        Me.btn_details.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_details.Location = New System.Drawing.Point(12, 101)
        Me.btn_details.Name = "btn_details"
        Me.btn_details.Size = New System.Drawing.Size(183, 23)
        Me.btn_details.TabIndex = 6
        Me.btn_details.Text = "Detailed Informations"
        Me.btn_details.UseVisualStyleBackColor = True
        '
        'Leaderboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 354)
        Me.Controls.Add(Me.btn_details)
        Me.Controls.Add(Me.lb_search)
        Me.Controls.Add(Me.cb_players)
        Me.Controls.Add(Me.btn_sort)
        Me.Controls.Add(Me.lst_leaderboard)
        Me.Controls.Add(Me.lb_scoreboard)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Leaderboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Leaderboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_scoreboard As Label
    Friend WithEvents lst_leaderboard As ListBox
    Friend WithEvents btn_sort As Button
    Friend WithEvents cb_players As ComboBox
    Friend WithEvents lb_search As Label
    Friend WithEvents btn_details As Button
End Class
