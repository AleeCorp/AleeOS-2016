Imports System
Imports System.IO
Imports System.Text
Imports System.Net.Mail

Public Class Form5
    Public actualaleeversion As String = "0.0.1 Beta 4"
    Dim newgame As Boolean = True
    Dim tcount As Integer = 0
    Dim rtext As String
    Dim gtexttotype As String
    Dim charcount As Integer
    Dim currentletter As Integer
    Dim slashcount As Integer
    Dim lblhackwords As Object
    Dim conversationcount As Integer = 0
    Dim textgeninput As Object
    Dim textgen As Integer
    Dim TextType As Boolean
    Dim di As DirectoryInfo
    Dim needtoclose As Boolean = False
    Dim oldversion As String
    Public upgraded As Boolean = False

    Dim fs As FileStream
    Dim sw As StreamWriter
    Dim hackeffect As Integer
    Dim percentcount As Integer
    Dim cdrive As System.IO.DriveInfo

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        aleeosinstalltimer.Start()

    End Sub

    Private Sub aleeosinstalltimer_Tick(sender As Object, e As EventArgs) Handles aleeosinstalltimer.Tick


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class