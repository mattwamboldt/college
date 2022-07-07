Public Class grid
    Private grSize As Size
    Private grLocation As Point
    Public Shared dimensions As Integer
    Private winHandle As IntPtr
    Public Shared tsize As Size
    Public tGrid(,) As Tile


    Public ReadOnly Property tilesize() As Size
        Get
            Return tsize
        End Get
    End Property

    Public Sub New(ByVal size As Size, ByVal location As Point, ByVal dimens As Integer, ByVal handle As IntPtr)
        grSize = size
        grLocation = location
        winHandle = handle
        tsize = New Size(CInt((grSize.Width / dimensions)), CInt((grSize.Height / dimensions)))
        ReDim tGrid(dimensions - 1, dimensions - 1)
        ReDim bDetect(dimensions - 1, dimensions - 1)
    End Sub
    Public bDetect(,) As Boolean

    Public Sub drawGrid(ByVal gridSize As Size, ByVal gridLocation As Point, ByVal handle As IntPtr, ByVal dimensions As Integer)
        For i As Integer = 0 To (tGrid.GetLength(0) - 1) Step +1
            For j As Integer = 0 To (tGrid.GetLength(1) - 1) Step +1
                tGrid(i, j) = New Tile(tsize, New Point((i * tsize.Width) + grLocation.X, (j * tsize.Height) + grLocation.Y), winHandle, 0)
                tGrid(i, j).show()
            Next
        Next
    End Sub

    Public Sub redraw(ByVal tilesx As Integer, ByVal tilesy As Integer, ByVal startindexx As Integer, ByVal startindexy As Integer, ByVal piece As Unit.pieces)
        For i As Integer = 0 To tilesx - 1 Step +1
            For j As Integer = 0 To tilesy - 1 Step +1
                tGrid(startindexx + i, startindexy + j).redraw(piece)
                If piece = Unit.pieces.Undefined Then
                    bDetect(startindexx + i, startindexy + j) = False
                Else
                    bDetect(startindexx + i, startindexy + j) = True
                End If
                Application.DoEvents()
            Next
        Next
    End Sub

    Public Function checktiles(ByVal index1 As Integer, ByVal index2 As Integer, ByVal piece As Unit.pieces, ByVal vertical As Boolean) As Boolean
        If vertical = True Then
            For i As Integer = 0 To Unit.unitListing(piece).Width - 1 Step +1
                For j As Integer = 0 To Unit.unitListing(piece).Height - 1 Step +1
                    If (index1 + i) >= dimensions Or (index2 + j) >= dimensions Then
                        Return False
                    ElseIf bDetect(index1 + i, index2 + j) = True Then
                        Return False
                    End If
                Next
            Next
        Else
            For i As Integer = 0 To Unit.unitListing(piece).Height - 1 Step +1
                For j As Integer = 0 To Unit.unitListing(piece).Width - 1 Step +1
                    If (index1 + i) >= dimensions Or (index2 + j) >= dimensions Then
                        Return False
                    ElseIf bDetect(index1 + i, index2 + j) = True Then
                        Return False
                    End If
                Next
            Next
        End If
        Return True
    End Function
    Public Sub changegrid(ByVal tilesx As Integer, ByVal tilesy As Integer, ByVal startindexx As Integer, ByVal startindexy As Integer, ByVal piece As Unit.pieces)
        For i As Integer = 0 To tilesx - 1 Step +1
            For j As Integer = 0 To tilesy - 1 Step +1       
                bDetect(startindexx + i, startindexy + j) = True
                tGrid(startindexx + i, startindexy + j) = New Tile(tsize, tGrid(startindexx + i, startindexy + j).tlocation, winHandle, piece)
                Application.DoEvents()
            Next
        Next
    End Sub
End Class