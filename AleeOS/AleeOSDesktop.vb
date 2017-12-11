Public Class AleeOSDesktop
    Private Sub AppsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AppsToolStripMenuItem1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Clock.Click



    End Sub

    Private Sub DesktopClock_Tick(sender As Object, e As EventArgs) Handles DesktopClock.Tick

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub WebBrowserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebBrowserToolStripMenuItem.Click

    End Sub

    Private Sub ShutdownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShutdownToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Form6.Show()
    End Sub

    Private Sub FileBrowserToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles FileBrowserToolStripMenuItem.Click
        Form4.Show()
    End Sub
End Class