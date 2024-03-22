<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class board
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(board))
        Me.pnlBoard = New System.Windows.Forms.Panel()
        Me.pnlCardTop = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FIleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnToMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBoard
        '
        Me.pnlBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBoard.Location = New System.Drawing.Point(38, 216)
        Me.pnlBoard.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlBoard.Name = "pnlBoard"
        Me.pnlBoard.Size = New System.Drawing.Size(460, 470)
        Me.pnlBoard.TabIndex = 0
        '
        'pnlCardTop
        '
        Me.pnlCardTop.Location = New System.Drawing.Point(38, 96)
        Me.pnlCardTop.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlCardTop.Name = "pnlCardTop"
        Me.pnlCardTop.Size = New System.Drawing.Size(460, 96)
        Me.pnlCardTop.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FIleToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(537, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FIleToolStripMenuItem
        '
        Me.FIleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem, Me.ReturnToMenuToolStripMenuItem})
        Me.FIleToolStripMenuItem.Name = "FIleToolStripMenuItem"
        Me.FIleToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FIleToolStripMenuItem.Text = "&FIle"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'ReturnToMenuToolStripMenuItem
        '
        Me.ReturnToMenuToolStripMenuItem.Name = "ReturnToMenuToolStripMenuItem"
        Me.ReturnToMenuToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.ReturnToMenuToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReturnToMenuToolStripMenuItem.Text = "Return to menu"
        '
        'board
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 726)
        Me.Controls.Add(Me.pnlCardTop)
        Me.Controls.Add(Me.pnlBoard)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "board"
        Me.Text = "Bingo!"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlBoard As Panel
    Friend WithEvents pnlCardTop As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FIleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnToMenuToolStripMenuItem As ToolStripMenuItem
End Class
