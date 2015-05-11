'Class for tiles
Public Class Tile
    Public x As Integer
    Public y As Integer
    Public img As String
    Public tile As Label

    Public Sub New(ByVal tempX As Integer, ByVal tempY As Integer, ByVal tempImg As String)
        x = tempX
        y = tempY
        img = tempImg
    End Sub
    Public Sub setup()
        tile = New Windows.Forms.Label
        tile.Visible = True
        tile.Image = Image.FromFile("Tile_0.png")
        tile.Left = x * 60
        tile.Left += (Form1.Width / 2) - 25
        tile.Top = y * 60
        tile.Top += (Form1.Height / 4)
        tile.Width = 60
        tile.Height = 60
    End Sub
    Public Sub display()
        Try
            tile.Image = Image.FromFile(img)
        Catch ex As Exception

        End Try
    End Sub
End Class
