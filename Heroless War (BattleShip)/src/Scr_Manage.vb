Imports System.Windows.Forms.Screen
Public Class Scr_Manage
    'read only properties that determine and make use of the screen
    Private gameSize As Size = Screen.PrimaryScreen.Bounds.Size
    Private gameLocation As Point = Screen.PrimaryScreen.Bounds.Location
    Private mClick As Point
    Private currentindex1 As Integer
    Private currentindex2 As Integer
    Private triedplay(,) As Boolean
    Private triedopp(,) As Boolean

    Public Property mLoc() As Point
        Get
            Return mClick
        End Get
        Set(ByVal value As Point)
            mClick = mLoc
        End Set
    End Property

    Public ReadOnly Property scrSize() As Size
        Get
            Return gameSize
        End Get
    End Property
    Public ReadOnly Property scrLocation() As Point
        Get
            Return gameLocation
        End Get
    End Property

    'Property to draw directly to the form
    Private winHandle As IntPtr
    Private gridarea As Size
    Private gridsize As Size
    Public spacer As Integer
    Public grOpp As grid
    Public grPlayer As grid
    Private units As Unit = New Unit
    Public Sub New(ByVal handle As IntPtr)
        ReDim triedplay(grid.dimensions - 1, grid.dimensions - 1)
        ReDim triedopp(grid.dimensions - 1, grid.dimensions - 1)
        winHandle = handle
        gridarea = New Size(CInt(gameSize.Width / 2), gameSize.Height)
        gridsize = New Size(CInt(gridarea.Width * 0.8), CInt(gridarea.Width * 0.8))
        spacer = CInt((gridarea.Width - gridsize.Width) / 2)
        units = New Unit
        currentindex1 = 0
        currentindex2 = 0
    End Sub
    Public Sub drawPlayGrid()
        Dim pLocation As Point

        pLocation = New Point(spacer, spacer)

        grPlayer = New grid(gridsize, pLocation, grid.dimensions, winHandle)

        grPlayer.drawGrid(gridsize, pLocation, winHandle, grid.dimensions)
    End Sub
    Public Sub drawOppGrid()
        Dim pLocation As Point
        pLocation = New Point(gridarea.Width + spacer, spacer)

        grOpp = New grid(gridsize, pLocation, grid.dimensions, winHandle)

        grOpp.drawGrid(gridsize, pLocation, winHandle, grid.dimensions)
    End Sub

    Public playscore As Integer

    Public Sub detectClick(ByVal mClick As Point)
        Dim hit1 As Integer
        Dim hit2 As Integer
        If mClick.X < gridarea.Width + gridsize.Width + spacer And mClick.Y < gridsize.Height + spacer Then
            hit1 = CInt(Math.Floor((mClick.X - spacer - gridarea.Width) / grid.tsize.Width))
            hit2 = CInt(Math.Floor((mClick.Y - spacer) / grid.tsize.Height))
            If hit1 >= 0 And hit1 < grid.dimensions And hit2 >= 0 And hit2 < grid.dimensions Then
                If grOpp.bDetect(hit1, hit2) = True And triedplay(hit1, hit2) = False Then
                    grOpp.tGrid(hit1, hit2).show()
                    triedplay(hit1, hit2) = True
                    playscore += 1
                    Application.DoEvents()
                ElseIf triedplay(hit1, hit2) = False Then
                    grOpp.tGrid(hit1, hit2) = New Tile(grid.tsize, grOpp.tGrid(hit1, hit2).tlocation, winHandle, Unit.pieces.Miss)
                    grOpp.tGrid(hit1, hit2).show()
                    triedplay(hit1, hit2) = True
                    opponentClick()
                    Application.DoEvents()
                End If
            End If
        End If
    End Sub
    'DONE
    Public Sub moveLeft(ByVal piece As Unit.pieces, ByVal bvertical As Boolean)
        If bvertical = True And currentindex1 >= 1 Then
            If grPlayer.checktiles(currentindex1 - 1, currentindex2, piece, bvertical) = True Then
                grPlayer.redraw(Unit.unitListing(piece).Width, Unit.unitListing(piece).Height, currentindex1, currentindex2, 0)
                currentindex1 -= 1
                grPlayer.redraw(Unit.unitListing(piece).Width, Unit.unitListing(piece).Height, currentindex1, currentindex2, piece)
            End If
        ElseIf currentindex1 >= 1 Then
            If grPlayer.checktiles(currentindex1 - 1, currentindex2, Unit.pieces.Undefined, bvertical) = True Then
                grPlayer.redraw(Unit.unitListing(piece).Height, Unit.unitListing(piece).Width, currentindex1, currentindex2, 0)
                currentindex1 -= 1
                grPlayer.redraw(Unit.unitListing(piece).Height, Unit.unitListing(piece).Width, currentindex1, currentindex2, piece)
            End If
        End If
        Unit.unitListing(piece).xPos = currentindex1
        Unit.unitListing(piece).yPos = currentindex2
    End Sub
    'DONE
    Public Sub moveRight(ByVal piece As Unit.pieces, ByVal bvertical As Boolean)
        If bvertical = True And currentindex1 <= (grid.dimensions - 1 - Unit.unitListing(piece).Width) Then
            If grPlayer.checktiles(currentindex1 + 1, currentindex2, piece, bvertical) = True Then
                grPlayer.redraw(Unit.unitListing(piece).Width, Unit.unitListing(piece).Height, currentindex1, currentindex2, 0)
                currentindex1 += 1
                grPlayer.redraw(Unit.unitListing(piece).Width, Unit.unitListing(piece).Height, currentindex1, currentindex2, piece)
            End If
        ElseIf currentindex1 <= (grid.dimensions - 1 - Unit.unitListing(piece).Height) Then
            If grPlayer.checktiles(currentindex1 + Unit.unitListing(piece).Height, currentindex2, Unit.pieces.Undefined, bvertical) = True Then
                grPlayer.redraw(Unit.unitListing(piece).Height, Unit.unitListing(piece).Width, currentindex1, currentindex2, 0)
                currentindex1 += 1
                grPlayer.redraw(Unit.unitListing(piece).Height, Unit.unitListing(piece).Width, currentindex1, currentindex2, piece)
            End If
        End If
        Unit.unitListing(piece).xPos = currentindex1
        Unit.unitListing(piece).yPos = currentindex2
    End Sub
    'DONE
    Public Sub moveUp(ByVal piece As Unit.pieces, ByVal bvertical As Boolean)
        If bvertical = True And currentindex2 >= 1 Then
            If grPlayer.checktiles(currentindex1, currentindex2 - 1, Unit.pieces.Undefined, bvertical) = True Then
                grPlayer.redraw(Unit.unitListing(piece).Width, Unit.unitListing(piece).Height, currentindex1, currentindex2, 0)
                currentindex2 -= 1
                grPlayer.redraw(Unit.unitListing(piece).Width, Unit.unitListing(piece).Height, currentindex1, currentindex2, piece)
            End If
        ElseIf currentindex2 >= 1 Then
            If grPlayer.checktiles(currentindex1, currentindex2 - 1, piece, bvertical) = True Then
                grPlayer.redraw(Unit.unitListing(piece).Height, Unit.unitListing(piece).Width, currentindex1, currentindex2, 0)
                currentindex2 -= 1
                grPlayer.redraw(Unit.unitListing(piece).Height, Unit.unitListing(piece).Width, currentindex1, currentindex2, piece)
            End If
        End If
        Unit.unitListing(piece).xPos = currentindex1
        Unit.unitListing(piece).yPos = currentindex2
    End Sub
    'DONE
    Public Sub moveDown(ByVal piece As Unit.pieces, ByVal bvertical As Boolean)
        If bvertical = True And currentindex2 <= (grid.dimensions - (Unit.unitListing(piece).Height + 1)) Then
            If grPlayer.checktiles(currentindex1, currentindex2 + Unit.unitListing(piece).Height, Unit.pieces.Undefined, bvertical) = True Then
                grPlayer.redraw(Unit.unitListing(piece).Width, Unit.unitListing(piece).Height, currentindex1, currentindex2, 0)
                currentindex2 += 1
                grPlayer.redraw(Unit.unitListing(piece).Width, Unit.unitListing(piece).Height, currentindex1, currentindex2, piece)
            End If
        ElseIf currentindex2 <= (grid.dimensions - 2) Then
            If grPlayer.checktiles(currentindex1, currentindex2 + Unit.unitListing(piece).Width, piece, bvertical) = True Then
                grPlayer.redraw(Unit.unitListing(piece).Height, Unit.unitListing(piece).Width, currentindex1, currentindex2, 0)
                currentindex2 += 1
                grPlayer.redraw(Unit.unitListing(piece).Height, Unit.unitListing(piece).Width, currentindex1, currentindex2, piece)
            End If
        End If
        Unit.unitListing(piece).xPos = currentindex1
        Unit.unitListing(piece).yPos = currentindex2
    End Sub
    'DONE
    Public Function Rotate(ByVal piece As Unit.pieces, ByVal bvertical As Boolean) As Boolean
        Dim checkpiece As Unit.pieces
        If piece <> Unit.pieces.StarFortress Then
            checkpiece = CType(piece - 1, Unit.pieces)
        Else
            checkpiece = Unit.pieces.Undefined
        End If
        If bvertical = True Then
            If currentindex1 > (grPlayer.tGrid.GetUpperBound(0) + 1 - Unit.unitListing(piece).Height) Then
                Return False
            ElseIf grPlayer.checktiles(currentindex1 + 1, currentindex2, checkpiece, Not bvertical) = False Then
                Return False
            Else

                grPlayer.redraw(Unit.unitListing(piece).Width, Unit.unitListing(piece).Height, currentindex1, currentindex2, 0)

                grPlayer.redraw(Unit.unitListing(piece).Height, Unit.unitListing(piece).Width, currentindex1, currentindex2, piece)
                Return True
            End If

        Else
            If currentindex2 > (grPlayer.tGrid.GetUpperBound(1) + 1 - Unit.unitListing(piece).Height) Then
                Return False
            ElseIf grPlayer.checktiles(currentindex1, currentindex2 + 1, checkpiece, Not bvertical) = False Then
                Return False
            Else
                grPlayer.redraw(Unit.unitListing(piece).Height, Unit.unitListing(piece).Width, currentindex1, currentindex2, 0)

                grPlayer.redraw(Unit.unitListing(piece).Width, Unit.unitListing(piece).Height, currentindex1, currentindex2, piece)
                Return True
            End If
        End If
    End Function
    Public Sub nextPiece(ByVal piece As Unit.pieces)
        If Unit.unitListing(piece).exists = True Then
            currentindex1 = Unit.unitListing(piece).xPos
            currentindex2 = Unit.unitListing(piece).yPos
        Else
            currentindex1 = 0
            currentindex2 = 0
            Do Until grPlayer.checktiles(currentindex1, currentindex2, piece, Unit.unitListing(piece).vertical) = True
                Do Until grPlayer.checktiles(currentindex1, currentindex2, piece, Unit.unitListing(piece).vertical) = True
                    currentindex1 += 1
                    If currentindex1 > (grid.dimensions - Unit.unitListing(piece).Width) Then
                        currentindex1 = 0
                        Exit Do
                    End If
                Loop
                If grPlayer.checktiles(currentindex1, currentindex2, piece, Unit.unitListing(piece).vertical) = True Then
                    Exit Do
                Else
                    currentindex2 += 1
                End If
            Loop
            Unit.unitListing(piece).exists = True
            Unit.unitListing(piece).xPos = currentindex1
            Unit.unitListing(piece).yPos = currentindex2
            grPlayer.redraw(Unit.unitListing(piece).Width, Unit.unitListing(piece).Height, currentindex1, currentindex2, piece)
        End If
    End Sub

    Public Sub randomizeOpp()
        Dim piece As Unit.pieces = Unit.pieces.Cruiser
        Dim oppdimen1 As Integer
        Dim oppdimen2 As Integer

        For i As Integer = CInt(piece) To CInt(Unit.pieces.BFS) Step +1
            Dim opprnd As Random = New Random(Date.Now.Millisecond)
            oppdimen1 = opprnd.Next(0, grid.dimensions)
            oppdimen2 = opprnd.Next(0, grid.dimensions)
            Unit.opplisting(i).vertical = CBool(Math.Round(opprnd.Next(1000, 5000) / 5000))
            Do Until grOpp.checktiles(oppdimen1, oppdimen2, Unit.opplisting(i).Piece, Unit.opplisting(i).vertical) = True
                opprnd = New Random(Date.Now.Millisecond)
                oppdimen1 = opprnd.Next(0, grid.dimensions)
                oppdimen2 = opprnd.Next(0, grid.dimensions)
                Unit.opplisting(i).vertical = CBool(Math.Round(opprnd.Next(1000, 5000) / 5000))
            Loop
            Unit.opplisting(i).xPos = oppdimen1
            Unit.opplisting(i).yPos = oppdimen2
            If Unit.opplisting(i).vertical = True Then
                grOpp.changegrid(Unit.opplisting(i).Width, Unit.opplisting(i).Height, oppdimen1, oppdimen2, Unit.opplisting(i).Piece)
            Else
                grOpp.changegrid(Unit.opplisting(i).Height, Unit.opplisting(i).Width, oppdimen1, oppdimen2, Unit.opplisting(i).Piece)
            End If
        Next
    End Sub
    Public oppscore As Integer
    Private Sub opponentClick()
        Dim miss As Boolean = False
        Do Until miss = True
            Dim hit1 As Integer
            Dim hit2 As Integer
            Dim opprnd As Random = New Random(Date.Now.Millisecond)
            hit1 = opprnd.Next(0, grid.dimensions)
            hit2 = opprnd.Next(0, grid.dimensions)
            Do Until triedopp(hit1, hit2) = False
                opprnd = New Random(Date.Now.Millisecond)
                hit1 = opprnd.Next(0, grid.dimensions)
                hit2 = opprnd.Next(0, grid.dimensions)
            Loop
            If grPlayer.bDetect(hit1, hit2) = True Then
                grPlayer.tGrid(hit1, hit2).hit()
                oppscore += 1
                triedopp(hit1, hit2) = True
                opprnd = New Random(Date.Now.Millisecond)
                Do Until miss = True
                    Select Case opprnd.Next(0, 4)
                        Case 0
                            hit1 -= 1
                        Case 2
                            hit1 += 1
                        Case 1
                            hit2 -= 1
                        Case Else
                            hit2 -= 1
                    End Select
                    If hit1 < 0 Then
                        hit1 += 2
                    ElseIf hit2 > grid.dimensions - 1 Then
                        hit2 -= 2
                    ElseIf hit2 < 0 Then
                        hit2 += 2
                    ElseIf hit1 > grid.dimensions - 1 Then
                        hit1 -= 2
                    End If
                    If grPlayer.bDetect(hit1, hit2) = True Then
                        grPlayer.tGrid(hit1, hit2).hit()
                        oppscore += 1
                        triedopp(hit1, hit2) = True
                    Else
                        miss = True
                        triedopp(hit1, hit2) = True
                        grPlayer.tGrid(hit1, hit2) = New Tile(grid.tsize, grPlayer.tGrid(hit1, hit2).tlocation, winHandle, Unit.pieces.Miss)
                        grPlayer.tGrid(hit1, hit2).show()
                    End If
                Loop

            Else
                grPlayer.tGrid(hit1, hit2) = New Tile(grid.tsize, grPlayer.tGrid(hit1, hit2).tlocation, winHandle, Unit.pieces.Miss)
                grPlayer.tGrid(hit1, hit2).show()
                miss = True
            End If
            triedopp(hit1, hit2) = True
        Loop
    End Sub

    Public Sub restart()
        For i As Integer = 0 To grid.dimensions - 1 Step +1
            For j As Integer = 0 To grid.dimensions - 1 Step +1
                grPlayer.bDetect(i, j) = False
                grOpp.bDetect(i, j) = False
            Next
        Next
        Dim thing As Unit = New Unit
    End Sub
End Class