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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnHost = New System.Windows.Forms.Button()
        Me.BtnPlay = New System.Windows.Forms.Button()
        Me.BtnBoth = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.Bingo2023_24.My.Resources.Resources.BINGO
        Me.PictureBox1.Location = New System.Drawing.Point(46, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(257, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BtnHost
        '
        Me.BtnHost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHost.Location = New System.Drawing.Point(46, 137)
        Me.BtnHost.Name = "BtnHost"
        Me.BtnHost.Size = New System.Drawing.Size(257, 30)
        Me.BtnHost.TabIndex = 1
        Me.BtnHost.Text = "Host"
        Me.BtnHost.UseVisualStyleBackColor = True
        '
        'BtnPlay
        '
        Me.BtnPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPlay.Location = New System.Drawing.Point(46, 173)
        Me.BtnPlay.Name = "BtnPlay"
        Me.BtnPlay.Size = New System.Drawing.Size(257, 30)
        Me.BtnPlay.TabIndex = 2
        Me.BtnPlay.Text = "Play"
        Me.BtnPlay.UseVisualStyleBackColor = True
        '
        'BtnBoth
        '
        Me.BtnBoth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBoth.Location = New System.Drawing.Point(46, 209)
        Me.BtnBoth.Name = "BtnBoth"
        Me.BtnBoth.Size = New System.Drawing.Size(257, 30)
        Me.BtnBoth.TabIndex = 3
        Me.BtnBoth.Text = "Host && Play"
        Me.BtnBoth.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 259)
        Me.Controls.Add(Me.BtnBoth)
        Me.Controls.Add(Me.BtnPlay)
        Me.Controls.Add(Me.BtnHost)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Bingo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnHost As Button
    Friend WithEvents BtnPlay As Button
    Friend WithEvents BtnBoth As Button
End Class
