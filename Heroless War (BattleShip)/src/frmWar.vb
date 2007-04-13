Public Class frmWar
    Dim stile As Size
    Dim ltile As Point
    Dim scrGame As Scr_Manage
    Dim bloaded As Boolean
    Dim bdrawn As Boolean
    Dim cpiece As Unit.pieces


    Private Sub frmWar_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Space
                If bdrawn = False And bloaded = True Then
                    If scrGame.Rotate(cpiece, Unit.unitListing(cpiece).vertical) = True Then
                        Unit.unitListing(cpiece).vertical = Not Unit.unitListing(cpiece).vertical
                    End If
                End If
            Case Keys.N
                drawgrids()
                bloaded = True
            Case Keys.Enter
                If bdrawn = False And bloaded = True And checkunits() = True Then
                    bdrawn = True
                    lblRestart.Text = clickstring
                    lblRestart.Location = New Point(CInt((scrGame.scrSize.Width / 2) - (lblRestart.Width / 2)), lblPlayScore.Location.Y)
                    scrGame.randomizeOpp()
                End If
            Case Keys.Up
                If bdrawn = False And bloaded = True Then
                    scrGame.moveUp(cpiece, Unit.unitListing(cpiece).vertical)
                    Threading.Thread.Sleep(100)
                End If
            Case Keys.Down
                If bdrawn = False And bloaded = True Then
                    scrGame.moveDown(cpiece, Unit.unitListing(cpiece).vertical)
                    Threading.Thread.Sleep(100)
                End If
            Case Keys.Left
                If bdrawn = False And bloaded = True Then
                    scrGame.moveLeft(cpiece, Unit.unitListing(cpiece).vertical)
                    Threading.Thread.Sleep(100)
                End If
            Case Keys.Right
                If bdrawn = False And bloaded = True Then
                    scrGame.moveRight(cpiece, Unit.unitListing(cpiece).vertical)
                    Threading.Thread.Sleep(100)
                End If
            Case Keys.Escape
                Application.Exit()
            Case Keys.D1
                If bdrawn = False And bloaded = True Then
                    cpiece = Heroless_War_07.Unit.pieces.Cruiser
                    scrGame.nextPiece(cpiece)
                End If
            Case Keys.D2
                If bdrawn = False And bloaded = True Then
                    cpiece = Heroless_War_07.Unit.pieces.StarFortress
                    scrGame.nextPiece(cpiece)
                End If
            Case Keys.D3
                If bdrawn = False And bloaded = True Then
                    cpiece = Heroless_War_07.Unit.pieces.Fighter
                    scrGame.nextPiece(cpiece)
                End If
            Case Keys.D4
                If bdrawn = False And bloaded = True Then
                    cpiece = Heroless_War_07.Unit.pieces.Scout
                    scrGame.nextPiece(cpiece)
                End If
            Case Keys.D5
                If bdrawn = False And bloaded = True Then
                    cpiece = Heroless_War_07.Unit.pieces.BFS
                    scrGame.nextPiece(cpiece)
                End If
        End Select
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bdrawn = False
        bloaded = False
        grid.dimensions = 8
        scrGame = New Scr_Manage(Me.Handle)
        Me.Size = scrGame.scrSize
        Me.Location = scrGame.scrLocation
        cpiece = Heroless_War_07.Unit.pieces.Cruiser
        lblPlayScore.Location = New Point(CInt(scrGame.scrSize.Width / 4 - lblPlayScore.Width / 2), CInt(scrGame.scrSize.Width / 2 + ((scrGame.scrSize.Height - (scrGame.scrSize.Width / 2)) / 2 - lblPlayScore.Height / 2)))
        lblOppScore.Location = New Point(CInt((scrGame.scrSize.Width * 3 / 4) - lblOppScore.Width / 2), lblPlayScore.Location.Y)
        lblRestart.Location = New Point(CInt((scrGame.scrSize.Width / 2) - (lblRestart.Width / 2)), lblPlayScore.Location.Y)
        lblWin.Location = New Point(CInt((scrGame.scrSize.Width / 2) - (lblWin.Width / 2)), CInt((scrGame.scrSize.Height / 2) - (lblWin.Height / 2)))
        lblLose.Location = lblWin.Location
        setstring = lblRestart.Text & vbNewLine & "Press number keys to change pieces" & vbNewLine & "Press arrow keys to move, spacebar to rotate." & vbNewLine & " Press Enter while done placing pieces"
        clickstring = lblRestart.Text & vbNewLine & "Click opponent squares, first to 16 wins"
        lblstart.Location = New Point(CInt((scrGame.scrSize.Width / 2) - (lblstart.Width / 2)), CInt((scrGame.scrSize.Height / 2) - (lblstart.Height / 2)))
    End Sub
    Dim setstring As String
    Dim clickstring As String
    Private Sub drawgrids()
        bdrawn = False
        lblstart.Visible = False
        Invalidate()
        Application.DoEvents()
        lblPlayScore.Visible = False
        lblOppScore.Visible = False
        lblWin.Visible = False
        lblLose.Visible = False
        scrGame.drawPlayGrid()
        scrGame.drawOppGrid()
        Application.DoEvents()
        scrGame.restart()
        Application.DoEvents()
        scrGame.nextPiece(cpiece)
        lblPlayScore.Visible = True
        lblOppScore.Visible = True
        lblRestart.Text = setstring
        lblRestart.Location = New Point(CInt((scrGame.scrSize.Width / 2) - (lblRestart.Width / 2)), lblPlayScore.Location.Y)
    End Sub
    Private Sub frmWar_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If bloaded = True And bdrawn = True Then
                scrGame.detectClick(e.Location)
            End If
            If scrGame.playscore >= 16 Then
                Invalidate()
                lblWin.Visible = True
                bloaded = False
                lblRestart.Text = "Press N key for new game"
                lblRestart.Location = New Point(CInt((scrGame.scrSize.Width / 2) - (lblRestart.Width / 2)), lblPlayScore.Location.Y)
                scrGame.oppscore = 0
                scrGame.playscore = 0
            ElseIf scrGame.playscore > 9 Then
                lblPlayScore.Text = "Player Score:        " & scrGame.playscore
            Else
                lblPlayScore.Text = "Player Score:         " & scrGame.playscore
            End If
            If scrGame.oppscore >= 16 Then
                Invalidate()
                lblLose.Visible = True
                bloaded = False
                lblRestart.Text = "Press N key for new game"
                lblRestart.Location = New Point(CInt((scrGame.scrSize.Width / 2) - (lblRestart.Width / 2)), lblPlayScore.Location.Y)
                scrGame.oppscore = 0
                scrGame.playscore = 0
            ElseIf scrGame.oppscore > 9 Then
                lblOppScore.Text = "Opponent Score:        " & scrGame.oppscore
            Else
                lblOppScore.Text = "Opponent Score:         " & scrGame.oppscore
            End If
        End If
    End Sub
    Private Function checkunits() As Boolean
        For i As Integer = 1 To 5 Step +1
            If Unit.unitListing(i).exists = False Then
                Return False
            End If
        Next
        Return True
    End Function
End Class