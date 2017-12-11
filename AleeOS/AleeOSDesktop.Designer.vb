<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AleeOSDesktop
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AppsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Clock = New System.Windows.Forms.Label()
        Me.DesktopClock = New System.Windows.Forms.Timer(Me.components)
        Me.AppsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShutdownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.WebBrowserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileBrowserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AppsToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1336, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AppsToolStripMenuItem
        '
        Me.AppsToolStripMenuItem.Name = "AppsToolStripMenuItem"
        Me.AppsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.AppsToolStripMenuItem.Text = "Apps"
        '
        'Clock
        '
        Me.Clock.AutoSize = True
        Me.Clock.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Clock.Location = New System.Drawing.Point(1273, 4)
        Me.Clock.Name = "Clock"
        Me.Clock.Size = New System.Drawing.Size(47, 13)
        Me.Clock.TabIndex = 1
        Me.Clock.Text = "0:00 AM"
        '
        'DesktopClock
        '
        '
        'AppsToolStripMenuItem1
        '
        Me.AppsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramsToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.ToolStripSeparator1, Me.ShutdownToolStripMenuItem})
        Me.AppsToolStripMenuItem1.Name = "AppsToolStripMenuItem1"
        Me.AppsToolStripMenuItem1.Size = New System.Drawing.Size(46, 20)
        Me.AppsToolStripMenuItem1.Text = "Apps"
        '
        'ProgramsToolStripMenuItem
        '
        Me.ProgramsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WebBrowserToolStripMenuItem, Me.FileBrowserToolStripMenuItem})
        Me.ProgramsToolStripMenuItem.Name = "ProgramsToolStripMenuItem"
        Me.ProgramsToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ProgramsToolStripMenuItem.Text = "Programs"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ShutdownToolStripMenuItem
        '
        Me.ShutdownToolStripMenuItem.Name = "ShutdownToolStripMenuItem"
        Me.ShutdownToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ShutdownToolStripMenuItem.Text = "Shutdown AleeOS"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(166, 6)
        '
        'WebBrowserToolStripMenuItem
        '
        Me.WebBrowserToolStripMenuItem.Name = "WebBrowserToolStripMenuItem"
        Me.WebBrowserToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.WebBrowserToolStripMenuItem.Text = "Web Browser"
        '
        'FileBrowserToolStripMenuItem
        '
        Me.FileBrowserToolStripMenuItem.Name = "FileBrowserToolStripMenuItem"
        Me.FileBrowserToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FileBrowserToolStripMenuItem.Text = "File Browser"
        '
        'AleeOSDesktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1336, 720)
        Me.Controls.Add(Me.Clock)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AleeOSDesktop"
        Me.Text = "AleeOSDesktop"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AppsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Clock As Label
    Friend WithEvents DesktopClock As Timer
    Friend WithEvents AppsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProgramsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WebBrowserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ShutdownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileBrowserToolStripMenuItem As ToolStripMenuItem
End Class
