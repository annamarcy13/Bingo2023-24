Public Class Form1
    Private Sub BtnHost_Click(sender As Object, e As EventArgs) Handles BtnHost.Click
        host.Show()
        Me.Close()
    End Sub

    Private Sub BtnPlay_Click(sender As Object, e As EventArgs) Handles BtnPlay.Click
        board.Show()
        Me.Close()
    End Sub

    Private Sub BtnBoth_Click(sender As Object, e As EventArgs) Handles BtnBoth.Click
        host.Show()
        board.Show()
        Me.Close()
    End Sub
End Class
