<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("level1")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("level2")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("levels", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("DownLeft")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("DownRight")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("UpRight")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("UpLeft")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("DirectionTiles", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5, TreeNode6, TreeNode7})
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hole")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hover")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("EndTile")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Misc", New System.Windows.Forms.TreeNode() {TreeNode9, TreeNode10, TreeNode11})
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tiles", New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode12})
        Me.tmrLoop = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tmrMove = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmrUI = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblEditor = New System.Windows.Forms.Label()
        Me.lblEdit = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Level1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Leve2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Level3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Level4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrLoop
        '
        Me.tmrLoop.Enabled = True
        Me.tmrLoop.Interval = 1
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(512, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 100)
        Me.Panel1.TabIndex = 0
        '
        'tmrMove
        '
        Me.tmrMove.Enabled = True
        Me.tmrMove.Interval = 50
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 400)
        Me.Label1.TabIndex = 1
        '
        'tmrUI
        '
        Me.tmrUI.Enabled = True
        Me.tmrUI.Interval = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(12, 270)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 66)
        Me.Label3.TabIndex = 3
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(12, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 80)
        Me.Label2.TabIndex = 2
        Me.Label2.Visible = False
        '
        'lblEditor
        '
        Me.lblEditor.AutoSize = True
        Me.lblEditor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditor.ForeColor = System.Drawing.Color.White
        Me.lblEditor.Location = New System.Drawing.Point(13, 12)
        Me.lblEditor.Name = "lblEditor"
        Me.lblEditor.Size = New System.Drawing.Size(0, 25)
        Me.lblEditor.TabIndex = 4
        '
        'lblEdit
        '
        Me.lblEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdit.ForeColor = System.Drawing.SystemColors.Control
        Me.lblEdit.Image = CType(resources.GetObject("lblEdit.Image"), System.Drawing.Image)
        Me.lblEdit.Location = New System.Drawing.Point(271, 565)
        Me.lblEdit.Name = "lblEdit"
        Me.lblEdit.Size = New System.Drawing.Size(53, 54)
        Me.lblEdit.TabIndex = 7
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(99, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Level1ToolStripMenuItem, Me.Leve2ToolStripMenuItem, Me.Level3ToolStripMenuItem, Me.Level4ToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(98, 22)
        Me.ToolStripMenuItem1.Text = "level"
        '
        'Level1ToolStripMenuItem
        '
        Me.Level1ToolStripMenuItem.Name = "Level1ToolStripMenuItem"
        Me.Level1ToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.Level1ToolStripMenuItem.Text = "level1"
        '
        'Leve2ToolStripMenuItem
        '
        Me.Leve2ToolStripMenuItem.Name = "Leve2ToolStripMenuItem"
        Me.Leve2ToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.Leve2ToolStripMenuItem.Text = "leve2"
        '
        'Level3ToolStripMenuItem
        '
        Me.Level3ToolStripMenuItem.Name = "Level3ToolStripMenuItem"
        Me.Level3ToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.Level3ToolStripMenuItem.Text = "level3"
        '
        'Level4ToolStripMenuItem
        '
        Me.Level4ToolStripMenuItem.Name = "Level4ToolStripMenuItem"
        Me.Level4ToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.Level4ToolStripMenuItem.Text = "level4"
        '
        'TreeView1
        '
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView1.Location = New System.Drawing.Point(18, 539)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "level1"
        TreeNode1.Text = "level1"
        TreeNode2.Name = "level2"
        TreeNode2.Text = "level2"
        TreeNode3.Name = "levels"
        TreeNode3.Text = "levels"
        TreeNode4.Name = "DownLeft.png"
        TreeNode4.Text = "DownLeft"
        TreeNode5.Name = "DownRight.png"
        TreeNode5.Text = "DownRight"
        TreeNode6.Name = "UpRight.png"
        TreeNode6.Text = "UpRight"
        TreeNode7.Name = "UpLeft.png"
        TreeNode7.Text = "UpLeft"
        TreeNode8.Name = "DirectionTiles"
        TreeNode8.Text = "DirectionTiles"
        TreeNode9.Name = "Hole.png"
        TreeNode9.Text = "Hole"
        TreeNode10.Name = "Hover.png"
        TreeNode10.Text = "Hover"
        TreeNode11.Name = "Check.png"
        TreeNode11.Text = "EndTile"
        TreeNode12.Name = "Misc"
        TreeNode12.Text = "Misc"
        TreeNode13.Name = "Tiles"
        TreeNode13.Text = "Tiles"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode13})
        Me.TreeView1.Size = New System.Drawing.Size(255, 97)
        Me.TreeView1.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aquamarine
        Me.ClientSize = New System.Drawing.Size(724, 648)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.lblEdit)
        Me.Controls.Add(Me.lblEditor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrLoop As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tmrMove As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tmrUI As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblEditor As System.Windows.Forms.Label
    Friend WithEvents lblEdit As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Level1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Leve2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Level3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Level4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView

End Class
