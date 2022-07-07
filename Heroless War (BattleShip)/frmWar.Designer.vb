<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblPlayScore = New System.Windows.Forms.Label
        Me.lblOppScore = New System.Windows.Forms.Label
        Me.lblRestart = New System.Windows.Forms.Label
        Me.lblWin = New System.Windows.Forms.Label
        Me.lblLose = New System.Windows.Forms.Label
        Me.lblstart = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblPlayScore
        '
        Me.lblPlayScore.AutoSize = True
        Me.lblPlayScore.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPlayScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPlayScore.ForeColor = System.Drawing.Color.White
        Me.lblPlayScore.Location = New System.Drawing.Point(177, 281)
        Me.lblPlayScore.Name = "lblPlayScore"
        Me.lblPlayScore.Size = New System.Drawing.Size(105, 15)
        Me.lblPlayScore.TabIndex = 0
        Me.lblPlayScore.Text = "Player Score:         0"
        Me.lblPlayScore.Visible = False
        '
        'lblOppScore
        '
        Me.lblOppScore.AutoSize = True
        Me.lblOppScore.BackColor = System.Drawing.Color.Transparent
        Me.lblOppScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOppScore.ForeColor = System.Drawing.Color.White
        Me.lblOppScore.Location = New System.Drawing.Point(662, 281)
        Me.lblOppScore.Name = "lblOppScore"
        Me.lblOppScore.Size = New System.Drawing.Size(123, 15)
        Me.lblOppScore.TabIndex = 1
        Me.lblOppScore.Text = "Opponent Score:         0"
        Me.lblOppScore.Visible = False
        '
        'lblRestart
        '
        Me.lblRestart.AutoSize = True
        Me.lblRestart.BackColor = System.Drawing.Color.Transparent
        Me.lblRestart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblRestart.ForeColor = System.Drawing.Color.White
        Me.lblRestart.Location = New System.Drawing.Point(404, 281)
        Me.lblRestart.Name = "lblRestart"
        Me.lblRestart.Size = New System.Drawing.Size(133, 15)
        Me.lblRestart.TabIndex = 2
        Me.lblRestart.Text = "Press N key for new game"
        Me.lblRestart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWin
        '
        Me.lblWin.AutoSize = True
        Me.lblWin.BackColor = System.Drawing.Color.Transparent
        Me.lblWin.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWin.ForeColor = System.Drawing.Color.White
        Me.lblWin.Location = New System.Drawing.Point(344, 171)
        Me.lblWin.Name = "lblWin"
        Me.lblWin.Size = New System.Drawing.Size(358, 38)
        Me.lblWin.TabIndex = 3
        Me.lblWin.Text = "Congratulations! You Win!!!"
        Me.lblWin.Visible = False
        '
        'lblLose
        '
        Me.lblLose.AutoSize = True
        Me.lblLose.BackColor = System.Drawing.Color.Transparent
        Me.lblLose.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLose.ForeColor = System.Drawing.Color.White
        Me.lblLose.Location = New System.Drawing.Point(177, 139)
        Me.lblLose.Name = "lblLose"
        Me.lblLose.Size = New System.Drawing.Size(425, 38)
        Me.lblLose.TabIndex = 4
        Me.lblLose.Text = "Sorry, You've lost. Try Again."
        Me.lblLose.Visible = False
        '
        'lblstart
        '
        Me.lblstart.AutoSize = True
        Me.lblstart.BackColor = System.Drawing.Color.Transparent
        Me.lblstart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblstart.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstart.ForeColor = System.Drawing.Color.White
        Me.lblstart.Location = New System.Drawing.Point(319, 87)
        Me.lblstart.Name = "lblstart"
        Me.lblstart.Size = New System.Drawing.Size(422, 78)
        Me.lblstart.TabIndex = 5
        Me.lblstart.Text = "Welcome to Heroless War `07" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "© Matt Wamboldt, 2007"
        Me.lblstart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmWar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.Heroless_War_07.My.Resources.Resources.stars
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 399)
        Me.Controls.Add(Me.lblstart)
        Me.Controls.Add(Me.lblLose)
        Me.Controls.Add(Me.lblWin)
        Me.Controls.Add(Me.lblRestart)
        Me.Controls.Add(Me.lblOppScore)
        Me.Controls.Add(Me.lblPlayScore)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmWar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPlayScore As System.Windows.Forms.Label
    Friend WithEvents lblOppScore As System.Windows.Forms.Label
    Friend WithEvents lblRestart As System.Windows.Forms.Label
    Friend WithEvents lblWin As System.Windows.Forms.Label
    Friend WithEvents lblLose As System.Windows.Forms.Label
    Friend WithEvents lblstart As System.Windows.Forms.Label

End Class
