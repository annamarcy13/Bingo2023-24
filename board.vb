Public Class board
    Private Sub board_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WriteBingo()
        ResetBoard()

    End Sub

    Private Sub WriteBingo()
        Dim bingo As String = "BINGO"
        Dim width As Integer = pnlCardTop.Width / bingo.Length
        Dim height As Integer = pnlCardTop.Height
        For i As Integer = 0 To bingo.Length - 1
            Dim lbl As New Label With {
                .AutoSize = False,
                .Text = bingo(i),
                .Width = width,
                .Height = height,
                .Location = New Point(width * i, 0),
                .TextAlign = ContentAlignment.MiddleCenter,
                .Font = New Font("Segoe UI", 40, FontStyle.Regular)
            }
            pnlCardTop.Controls.Add(lbl)
        Next
    End Sub

    Private Sub ResetBoard()
        pnlBoard.Controls.Clear()
        Dim btnWidth As Integer = pnlBoard.Width / 5
        Dim btnHeight As Integer = pnlBoard.Height / 5
        Dim rand As New Random()
        For i As Integer = 0 To 4
            Dim startpoint = (15 * i)
            Dim possible As New List(Of Integer)
            For k As Integer = 1 To 15
                possible.Add(startpoint + k)
            Next
            For j As Integer = 0 To 4
                Dim index As Integer = rand.Next(0, possible.Count)
                Dim btn As New Button With {
                .Text = possible(index).ToString,
                .Font = New Font("Segoe UI", 40, FontStyle.Regular),
                .TextAlign = ContentAlignment.MiddleCenter,
                .Location = New Point(btnWidth * i, btnHeight * j),
                .Width = btnWidth,
                .Height = btnHeight
            }
                If i = 2 AndAlso j = 2 Then
                    btn.Text = "Free space"
                    btn.Font = New Font("Segoe UI", 10, FontStyle.Regular)
                    btn.BackColor = Color.Yellow

                Else
                    AddHandler btn.Click, AddressOf handleButtonClick
                End If


                pnlBoard.Controls.Add(btn)
                possible.RemoveAt(index)
            Next
        Next
    End Sub
    Sub handleButtonClick(sender As Button, e As EventArgs)
        If sender.BackColor = Color.Yellow Then
            sender.BackColor = Color.White
        Else
            sender.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click

        ResetBoard()
    End Sub

    Private Sub ReturnToMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToMenuToolStripMenuItem.Click
        Form1.Show()
        Me.Close()
        host.Close()
    End Sub
End Class