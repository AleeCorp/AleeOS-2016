<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeveloperModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(380, 384)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 33)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Run AleeOS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(32, 82)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(818, 283)
        Me.WebBrowser1.TabIndex = 1
        Me.WebBrowser1.Url = New System.Uri("http://aleeos.freeforums.org/", System.UriKind.Absolute)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(217, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(460, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Welcome User to AleeOS click ""Run AleeOS"" to Start and sign up to the forums if y" &
    "ou have not." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 453)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(896, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OptionsToolStripMenuItem1
        '
        Me.OptionsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeToolStripMenuItem, Me.AboutToolStripMenuItem1, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem1})
        Me.OptionsToolStripMenuItem1.Name = "OptionsToolStripMenuItem1"
        Me.OptionsToolStripMenuItem1.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem1.Text = "Options"
        '
        'DeToolStripMenuItem
        '
        Me.DeToolStripMenuItem.Name = "DeToolStripMenuItem"
        Me.DeToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.DeToolStripMenuItem.Text = "Developer Mode"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(161, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(158, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(161, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeveloperModeToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'DeveloperModeToolStripMenuItem
        '
        Me.DeveloperModeToolStripMenuItem.Name = "DeveloperModeToolStripMenuItem"
        Me.DeveloperModeToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.DeveloperModeToolStripMenuItem.Text = "Developer Mode"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(158, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Green
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(896, 29)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Green
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "AleeOS Launcher"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(49, 384)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(789, 23)
        Me.ProgressBar1.TabIndex = 6
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(896, 477)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alee Launcher"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DeveloperModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents OptionsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
End Class
