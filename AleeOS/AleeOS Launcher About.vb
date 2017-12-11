Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
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

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class