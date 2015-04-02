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
        Me.TreeView2 = New System.Windows.Forms.TreeView()
        Me.picDownLeft = New System.Windows.Forms.PictureBox()
        Me.picDownRight = New System.Windows.Forms.PictureBox()
        Me.picUpRight = New System.Windows.Forms.PictureBox()
        Me.picUpLeft = New System.Windows.Forms.PictureBox()
        Me.picTile = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.picDownLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDownRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUpRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUpLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrLoop
        '
        Me.tmrLoop.Enabled = True
        Me.tmrLoop.Interval = 1
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'tmrMove
        '
        Me.tmrMove.Enabled = True
        Me.tmrMove.Interval = 125
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'tmrUI
        '
        Me.tmrUI.Enabled = True
        Me.tmrUI.Interval = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'lblEditor
        '
        resources.ApplyResources(Me.lblEditor, "lblEditor")
        Me.lblEditor.ForeColor = System.Drawing.Color.White
        Me.lblEditor.Name = "lblEditor"
        '
        'lblEdit
        '
        Me.lblEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.lblEdit, "lblEdit")
        Me.lblEdit.ForeColor = System.Drawing.SystemColors.Control
        Me.lblEdit.Name = "lblEdit"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        resources.ApplyResources(Me.ContextMenuStrip1, "ContextMenuStrip1")
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Level1ToolStripMenuItem, Me.Leve2ToolStripMenuItem, Me.Level3ToolStripMenuItem, Me.Level4ToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        '
        'Level1ToolStripMenuItem
        '
        Me.Level1ToolStripMenuItem.Name = "Level1ToolStripMenuItem"
        resources.ApplyResources(Me.Level1ToolStripMenuItem, "Level1ToolStripMenuItem")
        '
        'Leve2ToolStripMenuItem
        '
        Me.Leve2ToolStripMenuItem.Name = "Leve2ToolStripMenuItem"
        resources.ApplyResources(Me.Leve2ToolStripMenuItem, "Leve2ToolStripMenuItem")
        '
        'Level3ToolStripMenuItem
        '
        Me.Level3ToolStripMenuItem.Name = "Level3ToolStripMenuItem"
        resources.ApplyResources(Me.Level3ToolStripMenuItem, "Level3ToolStripMenuItem")
        '
        'Level4ToolStripMenuItem
        '
        Me.Level4ToolStripMenuItem.Name = "Level4ToolStripMenuItem"
        resources.ApplyResources(Me.Level4ToolStripMenuItem, "Level4ToolStripMenuItem")
        '
        'TreeView1
        '
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.TreeView1, "TreeView1")
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {CType(resources.GetObject("TreeView1.Nodes"), System.Windows.Forms.TreeNode)})
        '
        'TreeView2
        '
        Me.TreeView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.TreeView2, "TreeView2")
        Me.TreeView2.Name = "TreeView2"
        Me.TreeView2.Nodes.AddRange(New System.Windows.Forms.TreeNode() {CType(resources.GetObject("TreeView2.Nodes"), System.Windows.Forms.TreeNode)})
        '
        'picDownLeft
        '
        resources.ApplyResources(Me.picDownLeft, "picDownLeft")
        Me.picDownLeft.Name = "picDownLeft"
        Me.picDownLeft.TabStop = False
        '
        'picDownRight
        '
        resources.ApplyResources(Me.picDownRight, "picDownRight")
        Me.picDownRight.Name = "picDownRight"
        Me.picDownRight.TabStop = False
        '
        'picUpRight
        '
        resources.ApplyResources(Me.picUpRight, "picUpRight")
        Me.picUpRight.Name = "picUpRight"
        Me.picUpRight.TabStop = False
        '
        'picUpLeft
        '
        resources.ApplyResources(Me.picUpLeft, "picUpLeft")
        Me.picUpLeft.Name = "picUpLeft"
        Me.picUpLeft.TabStop = False
        '
        'picTile
        '
        resources.ApplyResources(Me.picTile, "picTile")
        Me.picTile.Name = "picTile"
        Me.picTile.TabStop = False
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aquamarine
        Me.Controls.Add(Me.picTile)
        Me.Controls.Add(Me.picUpLeft)
        Me.Controls.Add(Me.picUpRight)
        Me.Controls.Add(Me.picDownLeft)
        Me.Controls.Add(Me.picDownRight)
        Me.Controls.Add(Me.TreeView2)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.lblEdit)
        Me.Controls.Add(Me.lblEditor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.picDownLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDownRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUpRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUpLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTile, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TreeView2 As System.Windows.Forms.TreeView
    Friend WithEvents picDownLeft As System.Windows.Forms.PictureBox
    Friend WithEvents picDownRight As System.Windows.Forms.PictureBox
    Friend WithEvents picUpRight As System.Windows.Forms.PictureBox
    Friend WithEvents picUpLeft As System.Windows.Forms.PictureBox
    Friend WithEvents picTile As System.Windows.Forms.PictureBox

End Class
