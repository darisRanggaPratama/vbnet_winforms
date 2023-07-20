<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
		Me.MenuSp = New System.Windows.Forms.MenuStrip()
		Me.tsFile = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsExit = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsControls = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsExample = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsHelp = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsAbout = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolSp = New System.Windows.Forms.ToolStrip()
		Me.tsbExit = New System.Windows.Forms.ToolStripButton()
		Me.tsbHelp = New System.Windows.Forms.ToolStripButton()
		Me.MenuSp.SuspendLayout()
		Me.ToolSp.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuSp
		'
		Me.MenuSp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsFile, Me.tsControls, Me.tsHelp})
		Me.MenuSp.Location = New System.Drawing.Point(0, 0)
		Me.MenuSp.Name = "MenuSp"
		Me.MenuSp.Size = New System.Drawing.Size(800, 24)
		Me.MenuSp.TabIndex = 1
		Me.MenuSp.Text = "MenuStrip"
		'
		'tsFile
		'
		Me.tsFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsExit})
		Me.tsFile.Name = "tsFile"
		Me.tsFile.Size = New System.Drawing.Size(37, 20)
		Me.tsFile.Text = "File"
		'
		'tsExit
		'
		Me.tsExit.Name = "tsExit"
		Me.tsExit.Size = New System.Drawing.Size(180, 22)
		Me.tsExit.Text = "Exit"
		'
		'tsControls
		'
		Me.tsControls.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsExample})
		Me.tsControls.Name = "tsControls"
		Me.tsControls.Size = New System.Drawing.Size(64, 20)
		Me.tsControls.Text = "Controls"
		'
		'tsExample
		'
		Me.tsExample.Name = "tsExample"
		Me.tsExample.Size = New System.Drawing.Size(180, 22)
		Me.tsExample.Text = "Example"
		'
		'tsHelp
		'
		Me.tsHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsAbout})
		Me.tsHelp.Name = "tsHelp"
		Me.tsHelp.Size = New System.Drawing.Size(44, 20)
		Me.tsHelp.Text = "Help"
		'
		'tsAbout
		'
		Me.tsAbout.Name = "tsAbout"
		Me.tsAbout.Size = New System.Drawing.Size(180, 22)
		Me.tsAbout.Text = "About"
		'
		'ToolSp
		'
		Me.ToolSp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExit, Me.tsbHelp})
		Me.ToolSp.Location = New System.Drawing.Point(0, 24)
		Me.ToolSp.Name = "ToolSp"
		Me.ToolSp.Size = New System.Drawing.Size(800, 25)
		Me.ToolSp.TabIndex = 2
		Me.ToolSp.Text = "ToolStrip"
		'
		'tsbExit
		'
		Me.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.tsbExit.Image = Global.vb_net_mdi.My.Resources.Resources.x
		Me.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsbExit.Name = "tsbExit"
		Me.tsbExit.Size = New System.Drawing.Size(23, 22)
		Me.tsbExit.Text = "Exit"
		'
		'tsbHelp
		'
		Me.tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.tsbHelp.Image = Global.vb_net_mdi.My.Resources.Resources.h
		Me.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsbHelp.Name = "tsbHelp"
		Me.tsbHelp.Size = New System.Drawing.Size(23, 22)
		Me.tsbHelp.Text = "Help"
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.ToolSp)
		Me.Controls.Add(Me.MenuSp)
		Me.IsMdiContainer = True
		Me.MainMenuStrip = Me.MenuSp
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "MainForm"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.MenuSp.ResumeLayout(False)
		Me.MenuSp.PerformLayout()
		Me.ToolSp.ResumeLayout(False)
		Me.ToolSp.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MenuSp As MenuStrip
	Friend WithEvents tsFile As ToolStripMenuItem
	Friend WithEvents tsExit As ToolStripMenuItem
	Friend WithEvents tsControls As ToolStripMenuItem
	Friend WithEvents tsExample As ToolStripMenuItem
	Friend WithEvents tsHelp As ToolStripMenuItem
	Friend WithEvents tsAbout As ToolStripMenuItem
	Friend WithEvents ToolSp As ToolStrip
	Friend WithEvents tsbExit As ToolStripButton
	Friend WithEvents tsbHelp As ToolStripButton
End Class
