Imports System
Imports System.IO
Imports System.Text
Imports System.Net.Mail

Public Class Form3
    Public actualaleeversion As String = "0.0.1 Beta 4"
    Dim cdrive As System.IO.DriveInfo


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cdrive = My.Computer.FileSystem.GetDriveInfo("C:\")
        If My.Computer.FileSystem.DirectoryExists("C:\AleeOS") Then
            If IO.File.ReadAllText("C:/AleeOS/boot.asc") = actualaleeversion Then
                AleeOSDesktop.Show()
                Close()

            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form5.Show()
        Me.Close()

    End Sub
End Class