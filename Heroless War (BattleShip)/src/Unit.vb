Public Class Unit
    Public Enum pieces
        Undefined = 0
        Cruiser = 1
        StarFortress = 2
        Fighter = 3
        Scout = 4
        BFS = 5
        Miss = 6
    End Enum
    Public Structure Type
        Dim Piece As pieces
        Dim Height As Integer
        Dim Width As Integer
        Dim BackColor As Color
        Dim Pen As Pen
        Dim exists As Boolean
        Dim vertical As Boolean
        Dim xPos As Integer
        Dim yPos As Integer
    End Structure
    Public Shared unitListing(6) As Type
    Public Shared opplisting(6) As Type

    Private Sub createplayunits()
        unitListing(0).Piece = pieces.Undefined
        unitListing(0).Height = 1
        unitListing(0).Width = 1
        unitListing(0).Pen = New Pen(Color.Black, 4)
        unitListing(0).BackColor = Color.FromArgb(210, 230, 230, 230)
        unitListing(1).Piece = pieces.Cruiser
        unitListing(1).Height = 2
        unitListing(1).Width = 1
        unitListing(1).Pen = New Pen(Color.Blue, 4)
        unitListing(1).BackColor = Color.FromArgb(210, 230, 30, 30)
        unitListing(1).exists = False
        unitListing(1).vertical = True
        unitListing(1).xPos = 0
        unitListing(1).yPos = 0
        unitListing(2).Piece = pieces.StarFortress
        unitListing(2).Height = 2
        unitListing(2).Width = 1
        unitListing(2).Pen = New Pen(Color.Red, 4)
        unitListing(2).BackColor = Color.FromArgb(210, 30, 230, 30)
        unitListing(2).exists = False
        unitListing(2).vertical = True
        unitListing(2).xPos = 0
        unitListing(2).yPos = 0
        unitListing(3).Piece = pieces.Fighter
        unitListing(3).Height = 3
        unitListing(3).Width = 1
        unitListing(3).Pen = New Pen(Color.AntiqueWhite, 4)
        unitListing(3).BackColor = Color.FromArgb(210, 30, 30, 230)
        unitListing(3).exists = False
        unitListing(3).vertical = True
        unitListing(3).xPos = 0
        unitListing(3).yPos = 0
        unitListing(4).Piece = pieces.Scout
        unitListing(4).Height = 4
        unitListing(4).Width = 1
        unitListing(4).Pen = New Pen(Color.BurlyWood, 4)
        unitListing(4).BackColor = Color.FromArgb(230, Color.Yellow.R, Color.Yellow.G, Color.Yellow.B)
        unitListing(4).exists = False
        unitListing(4).vertical = True
        unitListing(4).xPos = 0
        unitListing(4).yPos = 0
        unitListing(5).Piece = pieces.BFS
        unitListing(5).Height = 5
        unitListing(5).Width = 1
        unitListing(5).Pen = New Pen(Color.Cyan, 4)
        unitListing(5).BackColor = Color.FromArgb(230, 65, 129, 101)
        unitListing(5).exists = False
        unitListing(5).vertical = True
        unitListing(5).xPos = 0
        unitListing(5).yPos = 0
        unitListing(6).Piece = pieces.Miss
        unitListing(6).Height = 1
        unitListing(6).Width = 1
        unitListing(6).Pen = New Pen(Color.DarkSeaGreen, 4)
        unitListing(6).BackColor = Color.DeepPink
        unitListing(6).exists = False
        unitListing(6).vertical = True
        unitListing(6).xPos = 0
        unitListing(6).yPos = 0
    End Sub

    Private Sub createoppunits()
        oppListing(0).Piece = pieces.Undefined
        oppListing(0).Height = 1
        oppListing(0).Width = 1
        oppListing(0).Pen = New Pen(Color.Black, 4)
        oppListing(0).BackColor = Color.FromArgb(210, 230, 230, 230)
        oppListing(1).Piece = pieces.Cruiser
        oppListing(1).Height = 2
        oppListing(1).Width = 1
        oppListing(1).Pen = New Pen(Color.Blue, 4)
        oppListing(1).BackColor = Color.FromArgb(210, 230, 30, 30)
        oppListing(1).exists = False
        oppListing(1).vertical = True
        oppListing(1).xPos = 0
        oppListing(1).yPos = 0
        oppListing(2).Piece = pieces.StarFortress
        oppListing(2).Height = 2
        oppListing(2).Width = 1
        oppListing(2).Pen = New Pen(Color.Red, 4)
        oppListing(2).BackColor = Color.FromArgb(210, 30, 230, 30)
        oppListing(2).exists = False
        oppListing(2).vertical = True
        oppListing(2).xPos = 0
        oppListing(2).yPos = 0
        oppListing(3).Piece = pieces.Fighter
        oppListing(3).Height = 3
        oppListing(3).Width = 1
        oppListing(3).Pen = New Pen(Color.AntiqueWhite, 4)
        oppListing(3).BackColor = Color.FromArgb(210, 30, 30, 230)
        oppListing(3).exists = False
        oppListing(3).vertical = True
        oppListing(3).xPos = 0
        oppListing(3).yPos = 0
        oppListing(4).Piece = pieces.Scout
        oppListing(4).Height = 4
        oppListing(4).Width = 1
        oppListing(4).Pen = New Pen(Color.BurlyWood, 4)
        oppListing(4).BackColor = Color.FromArgb(230, Color.Yellow.R, Color.Yellow.G, Color.Yellow.B)
        oppListing(4).exists = False
        oppListing(4).vertical = True
        oppListing(4).xPos = 0
        oppListing(4).yPos = 0
        oppListing(5).Piece = pieces.BFS
        oppListing(5).Height = 5
        oppListing(5).Width = 1
        oppListing(5).Pen = New Pen(Color.Cyan, 4)
        oppListing(5).BackColor = Color.FromArgb(230, 65, 129, 101)
        opplisting(5).exists = False
        opplisting(5).vertical = True
        opplisting(5).xPos = 0
        opplisting(5).yPos = 0
    End Sub

    Public Sub New()
        createplayunits()
        createoppunits()
    End Sub
End Class