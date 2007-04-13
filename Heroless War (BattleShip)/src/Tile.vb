Imports System
Imports system.Drawing
Imports System.Drawing.Drawing2D

Public Class Tile
    Private graph As Graphics
    Private winHandle As IntPtr
    Private location As Point
    Private size As Size
    Private tilePen As Pen
    Private backcolor As Color
    Public Property tlocation() As Point
        Get
            Return location
        End Get
        Set(ByVal value As Point)
            location = value
        End Set
    End Property
    Public Sub New(ByVal defineSize As Size, ByVal defineLocation As Point, ByVal defineHandle As IntPtr, ByVal type As Unit.pieces)
        size = defineSize
        location = defineLocation
        winHandle = defineHandle
        tilePen = Unit.unitListing(type).Pen
        backcolor = Unit.unitListing(type).BackColor
    End Sub
    Public Sub redraw(ByVal type As Unit.pieces)
        tilePen = Unit.unitListing(type).Pen
        backcolor = Unit.unitListing(type).BackColor
        hide()
        show()
    End Sub
    Public Sub show()
        Dim rect As Rectangle
        rect = New Rectangle(New Point(location.X + 4, location.Y + 4), New Size(size.Width - 8, size.Height - 8))
        graph = Graphics.FromHwnd(winHandle)
        graph.DrawRectangle(tilePen, rect)
        graph.FillRectangle(New SolidBrush(backColor), rect)
    End Sub
    Public Sub hit()
        graph = Graphics.FromHwnd(winHandle)
        graph.DrawLine(tilePen, location.X + 4, location.Y + 4, location.X + grid.tsize.Width - 4, location.Y + grid.tsize.Height - 4)
        graph.DrawLine(tilePen, location.X + grid.tsize.Width - 4, location.Y + 4, location.X + 4, location.Y + grid.tsize.Height - 4)
    End Sub
    Public Sub hide()
        My.Forms.frmWar.Invalidate(New Rectangle(location, size))
        Application.DoEvents()
    End Sub
End Class