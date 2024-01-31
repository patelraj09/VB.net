Public Class Form1
    Private Sub CodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CodeToolStripMenuItem.Click
        Dim codefrm As New Code
        codefrm.MdiParent = Me
        codefrm.Show()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim codefrm As New Code
        codefrm.MdiParent = Me
        codefrm.Show()
        codefrm.Label1.Text &= "Data from form1"
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim codefrm As New Code
        codefrm.MdiParent = Me
        codefrm.Show()
    End Sub
End Class

