<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class host
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(host))
        Me.BtnDraw = New System.Windows.Forms.Button()
        Me.LblNum = New System.Windows.Forms.Label()
        Me.LstPrevious = New System.Windows.Forms.ListBox()
        Me.lblPreviousCalls = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ReturnToMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnDraw
        '
        Me.BtnDraw.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDraw.Location = New System.Drawing.Point(46, 205)
        Me.BtnDraw.Name = "BtnDraw"
        Me.BtnDraw.Size = New System.Drawing.Size(242, 55)
        Me.BtnDraw.TabIndex = 0
        Me.BtnDraw.Text = "Draw Number"
        Me.BtnDraw.UseVisualStyleBackColor = True
        '
        'LblNum
        '
        Me.LblNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNum.Location = New System.Drawing.Point(46, 294)
        Me.LblNum.Name = "LblNum"
        Me.LblNum.Size = New System.Drawing.Size(242, 131)
        Me.LblNum.TabIndex = 1
        Me.LblNum.Text = "B17"
        Me.LblNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LstPrevious
        '
        Me.LstPrevious.FormattingEnabled = True
        Me.LstPrevious.Location = New System.Drawing.Point(312, 83)
        Me.LstPrevious.Name = "LstPrevious"
        Me.LstPrevious.Size = New System.Drawing.Size(103, 342)
        Me.LstPrevious.TabIndex = 3
        '
        'lblPreviousCalls
        '
        Me.lblPreviousCalls.AutoSize = True
        Me.lblPreviousCalls.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreviousCalls.Location = New System.Drawing.Point(308, 47)
        Me.lblPreviousCalls.Name = "lblPreviousCalls"
        Me.lblPreviousCalls.Size = New System.Drawing.Size(107, 20)
        Me.lblPreviousCalls.TabIndex = 4
        Me.lblPreviousCalls.Text = "Previous Calls"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(511, 27)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem, Me.ReturnToMenuToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 23)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.ResetToolStripMenuItem.Text = "Reset()"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Bingo2023_24.My.Resources.Resources.BINGO
        Me.PictureBox1.Location = New System.Drawing.Point(46, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(242, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'ReturnToMenuToolStripMenuItem
        '
        Me.ReturnToMenuToolStripMenuItem.Name = "ReturnToMenuToolStripMenuItem"
        Me.ReturnToMenuToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.ReturnToMenuToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.ReturnToMenuToolStripMenuItem.Text = "Return To Menu"
        '
        'host
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 450)
        Me.Controls.Add(Me.lblPreviousCalls)
        Me.Controls.Add(Me.LstPrevious)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblNum)
        Me.Controls.Add(Me.BtnDraw)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "host"
        Me.Text = "Bingo Host"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnDraw As Button
    Friend WithEvents LblNum As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LstPrevious As ListBox
    Friend WithEvents lblPreviousCalls As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnToMenuToolStripMenuItem As ToolStripMenuItem
End Class
