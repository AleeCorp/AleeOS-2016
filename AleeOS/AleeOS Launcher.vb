Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        ProgressBar1.Show()
        Button1.Hide()
        MenuStrip1.Hide()
        Label1.Text = "Please Wait Until AleeOS Loads"

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub FilesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)
#Disable Warning BC42024 ' Unused local variable
        Dim loc As Point
#Enable Warning BC42024 ' Unused local variable
    End Sub

    Dim mouseLocation As Point
    Dim isMouseDown As Boolean = False

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown


        isMouseDown = True
        mouseLocation = e.Location

    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove

        If (isMouseDown = True) Then
            Me.Location += e.Location - mouseLocation
        End If


    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp

        isMouseDown = False


    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Form3.Show()
            Me.Close()
        End If
    End Sub

    Private Sub DeveloperModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeveloperModeToolStripMenuItem.Click
        Alee_Launcher_Developer_Mode.Show()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub DeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeToolStripMenuItem.Click
        Alee_Launcher_Developer_Mode.Show()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        Form2.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class