Public Class Form1
    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        AboutUs.Show()
    End Sub

    Private Sub EngineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EngineToolStripMenuItem.Click
        Form2.Hide()
        Form2.Show()
    End Sub

    Private Sub RimToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RimToolStripMenuItem.Click
        Form3.Hide()
        Form3.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
