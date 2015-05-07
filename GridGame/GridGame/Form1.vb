Imports System.IO
Public Class Form1
    'Comment
    Public grid(9, 9) As Tile
    Dim hole(9, 9) As Tile
    Dim isRunning As Boolean = True
    Dim mouseImg As String = "Tile_0.png"
    Dim countI As Integer
    Dim player As Ball
    Dim countC As Integer
    Dim key As String
    Dim pic1 As Boolean = False
    Dim pic2 As Boolean = False
    Dim pic3 As Boolean = False
    Dim levelEditor As Boolean = False
    Dim level(12) As String
    Dim num As Integer
    Dim colorStat As String = "Purple"
    Dim playerPosX(12) As Integer
    Dim playerPosY(12) As Integer
    Dim restartLevel As Boolean
    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Space And levelEditor = False Then
            If player.key = "space" Then
                player.key = ""
            Else
                player.key = "space"
            End If
        End If
        If e.KeyValue = Keys.D1 Then
            num = InputBox("Enter level (levels: 1-11)").ToString
            restart(num)
            player.last = ""
            player.lastTile = ""
            restartLevel = True
        End If
        If e.KeyValue = Keys.D2 Then
            exportLevel()
        End If
        If e.KeyValue = Keys.D3 Then
            loadLevel()
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Width = Me.Width
        Panel1.Height = Me.Height
        Panel1.Left = 0
        Panel1.Top = 0
        player = New Ball(7, 4, "Ball_0_" & colorStat & ".png")
        player.setup()
        Panel1.Controls.Add(player.ball)


        For i = 0 To 9
            For c = 0 To 9
                'If i = 1 And c = 7 Then
                '    grid(i, c) = New Tile(i, c, "Hole.png")
                '    grid(i, c).setup()
                '    Panel1.Controls.Add(grid(i, c).tile)
                'Else
                If c = 9 Then
                    grid(i, c) = New Tile(i, c, "Tile_1.png")
                    grid(i, c).setup()
                    Panel1.Controls.Add(grid(i, c).tile)
                Else
                    grid(i, c) = New Tile(i, c, "Tile_0.png")
                    grid(i, c).setup()
                    Panel1.Controls.Add(grid(i, c).tile)
                End If
            Next
        Next
        num = InputBox("Enter level (levels: 1-11)").ToString
        restart(num)
        player.last = ""
        player.lastTile = ""
        restartLevel = True
    End Sub


    'Mouse Position and Clicks
    Public Sub mousePos()
        Try
            If TreeView1.Focused Then
                mouseImg = TreeView1.SelectedNode.Name
            End If
        Catch ex As Exception
        End Try

        For i = 0 To 9
            For c = 0 To 9
                If grid(i, c).tile.Bounds.Contains(PointToClient(MousePosition)) And MouseButtons = Windows.Forms.MouseButtons.Left Then
                    Try
                        grid(i, c).img = mouseImg
                    Catch ex As Exception
                    End Try
                End If
            Next
        Next


    End Sub


    'Main Loop
    Private Sub tmrLoop_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLoop.Tick
        Me.Label8.Text = player.key
        Dim count As Integer = 0
        For i = 0 To 11
            count += 1
            level(count) = TreeView2.Nodes(0).Nodes(i).Text
        Next


        Me.picDownLeft.Left = Me.Width - 200
        Me.picDownLeft.Top = 100
        Me.picDownRight.Left = Me.Width - 330
        Me.picDownRight.Top = 100
        Me.picUpLeft.Left = Me.Width - 200
        Me.picUpLeft.Top = 200
        Me.picUpRight.Left = Me.Width - 330
        Me.picUpRight.Top = 200
        Me.picTile.Top = 150
        Me.picTile.Left = Me.Width - 265

        Me.Label4.Left = Me.Width - 200
        Me.Label4.Top = 400
        Me.Label5.Left = Me.Width - 330
        Me.Label5.Top = 400
        Me.Label6.Left = Me.Width - 200
        Me.Label6.Top = 500
        Me.Label7.Left = Me.Width - 330
        Me.Label7.Top = 500

        playerPosX(1) = 1
        playerPosY(1) = 1
        playerPosX(2) = 6
        playerPosY(2) = 2
        playerPosX(3) = 7
        playerPosY(3) = 4
        playerPosX(4) = 3
        playerPosY(4) = 3
        playerPosX(5) = 3
        playerPosY(5) = 2
        playerPosX(6) = 3
        playerPosY(6) = 2
        playerPosX(7) = 5
        playerPosY(7) = 2
        playerPosX(8) = 4
        playerPosY(8) = 4
        playerPosX(9) = 6
        playerPosY(9) = 5
        playerPosX(10) = 2
        playerPosY(10) = 3
        playerPosX(11) = 2
        playerPosY(11) = 2
        playerPosX(12) = 2
        playerPosY(12) = 2

        Me.TreeView1.Top = Me.Height - 175
        Me.TreeView2.Top = Me.Height - 275
        Me.lblEdit.Top = Me.Height - 125
        If levelEditor = True Then
            TreeView1.Visible = True
            TreeView1.Enabled = True
            TreeView2.Visible = True
            TreeView2.Enabled = True
            Me.lblEdit.Visible = True
            Me.lblEdit.Enabled = True
        Else
            TreeView1.Visible = False
            TreeView1.Enabled = False
            TreeView2.Visible = False
            TreeView2.Enabled = False
            Me.lblEdit.Visible = False
            Me.lblEdit.Enabled = False
        End If
        Me.lblEditor.Text = levelEditor
        Panel1.Width = Me.Width
        Panel1.Height = Me.Height

        Me.BackColor = Color.FromArgb(31, 218, 175)
        For i = 0 To 9
            For c = 0 To 9
                grid(i, c).display()
            Next
        Next
        selectTile()
        mousePos()
        colorKey()

    End Sub

    Public Sub selectTile()
        If picDownLeft.Bounds.Contains(PointToClient(MousePosition)) And MouseButtons = Windows.Forms.MouseButtons.Left Then
            mouseImg = "DownLeft_Purple.png"
        ElseIf picDownRight.Bounds.Contains(PointToClient(MousePosition)) And MouseButtons = Windows.Forms.MouseButtons.Left Then
            mouseImg = "DownRight_Purple.png"
        ElseIf picUpLeft.Bounds.Contains(PointToClient(MousePosition)) And MouseButtons = Windows.Forms.MouseButtons.Left Then
            mouseImg = "UpLeft_Purple.png"
        ElseIf picUpRight.Bounds.Contains(PointToClient(MousePosition)) And MouseButtons = Windows.Forms.MouseButtons.Left Then
            mouseImg = "UpRight_Purple.png"
        ElseIf picTile.Bounds.Contains(PointToClient(MousePosition)) And MouseButtons = Windows.Forms.MouseButtons.Left Then
            mouseImg = "block.png"
        ElseIf Label5.Bounds.Contains(PointToClient(MousePosition)) And MouseButtons = Windows.Forms.MouseButtons.Left Then
            mouseImg = "DownLeft_Blue.png"
        ElseIf Label7.Bounds.Contains(PointToClient(MousePosition)) And MouseButtons = Windows.Forms.MouseButtons.Left Then
            mouseImg = "DownRight_Blue.png"
        ElseIf Label6.Bounds.Contains(PointToClient(MousePosition)) And MouseButtons = Windows.Forms.MouseButtons.Left Then
            mouseImg = "UpRight_Blue.png"
        ElseIf Label4.Bounds.Contains(PointToClient(MousePosition)) And MouseButtons = Windows.Forms.MouseButtons.Left Then
            mouseImg = "UpLeft_Blue.png"
        End If
    End Sub

    Public Sub restart(ByVal num As String)
        colorStat = "Purple"
        player.ball.Image = Image.FromFile("Ball_0_" & colorStat & ".png")
        Dim reader As New StreamReader(level(num) & ".txt")
        player.x = playerPosX(num) * 60
        player.y = playerPosY(num) * 60
        player.x += (700 / 2)
        player.y += (700 / 4)
        player.locX = playerPosX(num)
        player.locY = playerPosY(num)
        For i = 0 To 9
            For c = 0 To 9
                'If i = 1 And c = 7 Then
                '    grid(i, c) = New Tile(i, c, "Hole.png")
                '    grid(i, c).setup()
                '    Panel1.Controls.Add(grid(i, c).tile)
                'Else
                grid(i, c).img = reader.ReadLine
            Next
        Next
        player.key = ""
    End Sub


    Public Sub loadLevel()
        colorStat = "Purple"
        player.ball.Image = Image.FromFile("Ball_0_" & colorStat & ".png")
        OpenFileDialog1.ShowDialog()
        Dim reader As New StreamReader(OpenFileDialog1.FileName)
        player.x = playerPosX(num) * 60
        player.y = playerPosY(num) * 60
        player.x += (700 / 2)
        player.y += (700 / 4)
        player.locX = playerPosX(num)
        player.locY = playerPosY(num)
        For i = 0 To 9
            For c = 0 To 9
                'If i = 1 And c = 7 Then
                '    grid(i, c) = New Tile(i, c, "Hole.png")
                '    grid(i, c).setup()
                '    Panel1.Controls.Add(grid(i, c).tile)
                'Else
                grid(i, c).img = reader.ReadLine
            Next
        Next
    End Sub

    Public Sub refresh()
        Dim reader As New StreamReader("Blank.txt")
        player.x = playerPosX(3) * 60
        player.y = playerPosY(4) * 60
        player.x += (700 / 2)
        player.y += (700 / 4)
        player.locX = playerPosX(3)
        player.locY = playerPosY(4)
        For i = 0 To 9
            For c = 0 To 9
                'If i = 1 And c = 7 Then
                '    grid(i, c) = New Tile(i, c, "Hole.png")
                '    grid(i, c).setup()
                '    Panel1.Controls.Add(grid(i, c).tile)
                'Else
                grid(i, c).img = reader.ReadLine
            Next
        Next
    End Sub
    Public Sub saveLevel()
        If TreeView2.Focused Then
            DialogResult = MessageBox.Show("This will Overwrite file " & TreeView2.SelectedNode.Name, "OverWrite", MessageBoxButtons.YesNo)
            If (DialogResult = DialogResult.Yes) Then
                Dim file As System.IO.StreamWriter
                Try
                    file = My.Computer.FileSystem.OpenTextFileWriter(TreeView2.SelectedNode.Name, False)
                    For i = 0 To 9
                        For c = 0 To 9
                            file.WriteLine(grid(i, c).img)
                        Next
                    Next
                    file.Close()
                Catch ex As Exception
                End Try
            End If
        End If
        'MessageBox.Show(TreeView1.SelectedNode.ToString)
    End Sub

    Public Sub exportLevel()
        SaveFileDialog1.ShowDialog()
        DialogResult = MessageBox.Show("This will Overwrite current work", "OverWrite", MessageBoxButtons.YesNo)
        If (DialogResult = DialogResult.Yes And SaveFileDialog1.CheckPathExists) Then
            Dim file As System.IO.StreamWriter
            Try
                file = My.Computer.FileSystem.OpenTextFileWriter(SaveFileDialog1.FileName & ".txt", False)
                For i = 0 To 9
                    For c = 0 To 9
                        file.WriteLine(grid(i, c).img)
                    Next
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        'MessageBox.Show(TreeView1.SelectedNode.ToString)
    End Sub

    Public Sub colorKey()
        If player.current = "Tile_0_Blue.png" Then
            colorStat = "Blue"
            player.ball.Image = Image.FromFile("Ball_0_" & colorStat & ".png")
        ElseIf player.current = "Tile_0_Purple.png" Then
            colorStat = "Purple"
            player.ball.Image = Image.FromFile("Ball_0_" & colorStat & ".png")
        End If
    End Sub

    Public Class Ball
        Public x As Integer
        Public y As Integer
        Public img As String
        Public ball As PictureBox
        Public count As Integer
        Public current As String
        Public locX As Integer
        Public locY As Integer
        Public left As String
        Public right As String
        Public up As String
        Public down As String
        Public key As String
        Public last As String
        Public lastTile As String
        Public lastCount As Integer

        Public Sub New(ByVal tempX As Integer, ByVal tempY As Integer, ByVal tempImg As String)
            x = tempX * 60
            y = tempY * 60
            x += (700 / 2)
            y += (700 / 4) + 5
            img = tempImg
            locX = tempX
            locY = tempY
        End Sub
        Public Sub setup()
            ball = New Windows.Forms.PictureBox
            ball.Image = Image.FromFile(img)
            ball.Visible = True
            ball.Left = x
            ball.Top = y
            ball.Width = 48
            ball.Height = 48
            ball.BackColor = Color.Transparent
            ball.SizeMode = PictureBoxSizeMode.AutoSize

        End Sub
        Public Sub move()
            If key = "space" Or Form1.restartLevel = True Then
                Form1.restartLevel = False
                ball.Top = y - 2
                ball.Left = x
                If Form1.colorStat = "Purple" Then
                    If down = "ArrowDown.png" And locY + 1 < 9 Then
                        lastTile = "Up"
                        last = "Down"
                        y += 69
                        locY += 1
                    ElseIf up = "ArrowUp.png" And locY - 1 > 0 Then
                        lastTile = "Down"
                        last = "Up"
                        y -= 60
                        locY -= 1
                    ElseIf down = "UpRight_Purple.png" And lastTile <> "Down" And locY + 1 < 9 Then
                        lastTile = "Up"
                        last = "Right"
                        y += 60
                        locY += 1
                    ElseIf down = "UpLeft_Purple.png" And lastTile <> "Down" And locY + 1 < 9 Then
                        lastTile = "Up"
                        last = "Left"
                        y += 60
                        locY += 1
                    ElseIf up = "DownRight_Purple.png" And lastTile <> "Up" And locY - 1 < 9 Then
                        last = "Right"
                        lastTile = "Down"
                        y -= 60
                        locY -= 1
                    ElseIf up = "DownLeft_Purple.png" And lastTile <> "Up" And locY - 1 < 9 Then
                        last = "Left"
                        lastTile = "Down"
                        y -= 60
                        locY -= 1
                    ElseIf left = "UpRight_Purple.png" And lastTile <> "Left" And locX - 1 > 0 Then
                        last = "Up"
                        lastTile = "Right"
                        x -= 60
                        locX -= 1
                    ElseIf left = "DownRight_Purple.png" And lastTile <> "Left" And locX - 1 > 0 Then
                        last = "Down"
                        lastTile = "Right"
                        x -= 60
                        locX -= 1
                    ElseIf right = "DownLeft_Purple.png" And lastTile <> "Right" And locX + 1 < 9 Then
                        last = "Down"
                        lastTile = "Left"
                        x += 60
                        locX += 1
                    ElseIf right = "UpLeft_Purple.png" And lastTile <> "Right" And locX + 1 < 9 Then
                        last = "Up"
                        lastTile = "Left"
                        x += 60
                        locX += 1
                    ElseIf last = "Up" And locY - 1 > 0 Then
                        lastTile = "Down"
                        y -= 60
                        locY -= 1
                    ElseIf last = "Down" And locY + 1 < 9 Then
                        lastTile = "Up"
                        y += 60
                        locY += 1
                    ElseIf last = "Right" And locX + 1 < 9 Then
                        lastTile = "Left"
                        x += 60
                        locX += 1
                    ElseIf last = "Left" And locX - 1 > 0 Then
                        lastTile = "Right"
                        x -= 60
                        locX -= 1
                    End If
                End If

                If Form1.colorStat = "Blue" Then
                    If down = "ArrowDown.png" And locY + 1 < 9 Then
                        lastTile = "Up"
                        last = "Down"
                        y += 69
                        locY += 1
                    ElseIf down = "UpRight_Blue.png" And lastTile <> "Down" And locY + 1 < 9 Then
                        lastTile = "Up"
                        last = "Right"
                        y += 60
                        locY += 1
                    ElseIf down = "UpLeft_Blue.png" And lastTile <> "Down" And locY + 1 < 9 Then
                        lastTile = "Up"
                        last = "Left"
                        y += 60
                        locY += 1
                    ElseIf up = "DownRight_Blue.png" And lastTile <> "Up" And locY - 1 < 9 Then
                        last = "Right"
                        lastTile = "Down"
                        y -= 60
                        locY -= 1
                    ElseIf up = "DownLeft_Blue.png" And lastTile <> "Up" And locY - 1 < 9 Then
                        last = "Left"
                        lastTile = "Down"
                        y -= 60
                        locY -= 1
                    ElseIf left = "UpRight_Blue.png" And lastTile <> "Left" And locX - 1 > 0 Then
                        last = "Up"
                        lastTile = "Right"
                        x -= 60
                        locX -= 1
                    ElseIf left = "DownRight_Blue.png" And lastTile <> "Left" And locX - 1 > 0 Then
                        last = "Down"
                        lastTile = "Right"
                        x -= 60
                        locX -= 1
                    ElseIf right = "DownLeft_Blue.png" And lastTile <> "Right" And locX + 1 < 9 Then
                        last = "Down"
                        lastTile = "Left"
                        x += 60
                        locX += 1
                    ElseIf right = "UpLeft_Blue.png" And lastTile <> "Right" And locX + 1 < 9 Then
                        last = "Up"
                        lastTile = "Left"
                        x += 60
                        locX += 1
                    ElseIf last = "Up" And locY - 1 > 0 Then
                        lastTile = "Down"
                        y -= 60
                        locY -= 1
                    ElseIf last = "Down" And locY + 1 < 9 Then
                        lastTile = "Up"
                        y += 60
                        locY += 1
                    ElseIf last = "Right" And locX + 1 < 9 Then
                        lastTile = "Left"
                        x += 60
                        locX += 1
                    ElseIf last = "Left" And locX - 1 > 0 Then
                        lastTile = "Right"
                        x -= 60
                        locX -= 1
                    End If
                End If
                If right = "block.png" Then
                    If last = "Right" Then
                        lastTile = "Left"
                        last = "Left"
                        x -= 60
                        locX -= 1
                    End If
                ElseIf up = "block.png" Then
                    If last = "Up" Then
                        lastTile = "Down"
                        last = "Down"
                        y += 60
                        locY += 1
                    End If
                ElseIf left = "block.png" Then
                    If last = "Left" Then
                        lastTile = "Rights"
                        last = "Right"
                        x += 60
                        locX += 1
                    End If
                ElseIf down = "block.png" Then
                    If last = "Down" Then
                        lastTile = "Up"
                        last = "Up"
                        y -= 60
                        locY -= 1
                    End If
                End If

                If current = "Check.jpg" Then
                    key = ""
                    Form1.num = Form1.num + 1
                    Form1.restart(Form1.num)
                    Form1.restartLevel = True
                    last = "Tile"
                End If
            End If
        End Sub
    End Class

    Private Sub tmrMove_Tick(sender As System.Object, e As System.EventArgs) Handles tmrMove.Tick
        player.move()
        player.right = grid(player.locX + 1, player.locY).img
        player.left = grid(player.locX - 1, player.locY).img
        player.up = grid(player.locX, player.locY - 1).img
        player.down = grid(player.locX, player.locY + 1).img
        player.current = grid(player.locX, player.locY).img
        If num = 1 Then
            tmrMove.Interval = 75
        ElseIf num = 2 Then
            tmrMove.Interval = 150
        End If
    End Sub

    Private Sub tmrUI_Tick(sender As System.Object, e As System.EventArgs) Handles tmrUI.Tick
        If Label1.Bounds.Contains(PointToClient(MousePosition)) Then
            showUI("Show")
        Else
            showUI("Hide")
        End If
        'If Label2.Left < 15 Then
        '    Label2.Visible = False
        'End If
        'If Label3.Left < 15 Then
        '    Label3.Visible = False
        'End If
    End Sub

    Public Sub showUI(ByVal value As String)
        If value = "Hide" Or Label1.Bounds.Contains(PointToClient(MousePosition)) = False Then
            If pic2 = True Then
                If Label2.Left > 12 Then
                    Label2.Left -= 20
                Else
                    pic2 = False
                End If
            ElseIf pic3 = True Then
                If Label3.Left > 12 Then
                    Label3.Left -= 20
                Else
                    pic3 = False
                End If
            End If
        ElseIf value = "Show" Then
            If pic2 = False Then
                If Label2.Left < 50 Then
                    Label2.Visible = True
                    Label2.Left += 20
                Else
                    pic2 = True
                End If
            ElseIf pic3 = False Then
                If Label3.Left < 50 Then
                    Label3.Visible = True
                    Label3.Left += 20
                Else
                    pic3 = True
                End If
            End If
        End If
    End Sub

    Private Sub lblEdit_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblEdit.MouseClick
        saveLevel()
    End Sub

    Private Sub lblEdit_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblEdit.MouseDown
        Me.lblEdit.Image = Image.FromFile("modernuiicons1.png")
    End Sub

    Private Sub lblEdit_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblEdit.MouseUp
        Me.lblEdit.Image = Image.FromFile("modernuiicons.png")
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click
        If levelEditor = False Then
            levelEditor = True
        Else
            levelEditor = False
        End If
    End Sub
End Class


