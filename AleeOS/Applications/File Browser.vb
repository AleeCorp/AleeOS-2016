Public Class Form4

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Close()

    End Sub
End Class