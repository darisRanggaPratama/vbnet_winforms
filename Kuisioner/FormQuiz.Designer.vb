<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormQuiz
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtName = New System.Windows.Forms.TextBox()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.rdFemale = New System.Windows.Forms.RadioButton()
		Me.rdMale = New System.Windows.Forms.RadioButton()
		Me.cboxOccupation = New System.Windows.Forms.ComboBox()
		Me.ckPHP = New System.Windows.Forms.CheckBox()
		Me.ckJava = New System.Windows.Forms.CheckBox()
		Me.ckJavascript = New System.Windows.Forms.CheckBox()
		Me.ckCsharp = New System.Windows.Forms.CheckBox()
		Me.lblResult = New System.Windows.Forms.Label()
		Me.btnAccept = New System.Windows.Forms.Button()
		Me.btnReset = New System.Windows.Forms.Button()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(32, 16)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(55, 20)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Name"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(32, 64)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(69, 20)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Gender"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(32, 112)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(100, 20)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Occupation"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(32, 160)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(161, 20)
		Me.Label4.TabIndex = 3
		Me.Label4.Text = "Programming Skills"
		'
		'txtName
		'
		Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtName.Location = New System.Drawing.Point(200, 16)
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(288, 24)
		Me.txtName.TabIndex = 4
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.rdMale)
		Me.GroupBox1.Controls.Add(Me.rdFemale)
		Me.GroupBox1.Location = New System.Drawing.Point(200, 56)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(288, 40)
		Me.GroupBox1.TabIndex = 5
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Gender"
		'
		'rdFemale
		'
		Me.rdFemale.AutoSize = True
		Me.rdFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rdFemale.Location = New System.Drawing.Point(8, 16)
		Me.rdFemale.Name = "rdFemale"
		Me.rdFemale.Size = New System.Drawing.Size(75, 22)
		Me.rdFemale.TabIndex = 0
		Me.rdFemale.TabStop = True
		Me.rdFemale.Text = "Female"
		Me.rdFemale.UseVisualStyleBackColor = True
		'
		'rdMale
		'
		Me.rdMale.AutoSize = True
		Me.rdMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rdMale.Location = New System.Drawing.Point(112, 16)
		Me.rdMale.Name = "rdMale"
		Me.rdMale.Size = New System.Drawing.Size(58, 22)
		Me.rdMale.TabIndex = 1
		Me.rdMale.TabStop = True
		Me.rdMale.Text = "Male"
		Me.rdMale.UseVisualStyleBackColor = True
		'
		'cboxOccupation
		'
		Me.cboxOccupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboxOccupation.FormattingEnabled = True
		Me.cboxOccupation.Items.AddRange(New Object() {"Government Employee", "Non-Government Employee"})
		Me.cboxOccupation.Location = New System.Drawing.Point(200, 112)
		Me.cboxOccupation.Name = "cboxOccupation"
		Me.cboxOccupation.Size = New System.Drawing.Size(288, 26)
		Me.cboxOccupation.TabIndex = 6
		'
		'ckPHP
		'
		Me.ckPHP.AutoSize = True
		Me.ckPHP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckPHP.Location = New System.Drawing.Point(200, 160)
		Me.ckPHP.Name = "ckPHP"
		Me.ckPHP.Size = New System.Drawing.Size(58, 22)
		Me.ckPHP.TabIndex = 7
		Me.ckPHP.Text = "PHP"
		Me.ckPHP.UseVisualStyleBackColor = True
		'
		'ckJava
		'
		Me.ckJava.AutoSize = True
		Me.ckJava.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckJava.Location = New System.Drawing.Point(272, 160)
		Me.ckJava.Name = "ckJava"
		Me.ckJava.Size = New System.Drawing.Size(58, 22)
		Me.ckJava.TabIndex = 8
		Me.ckJava.Text = "Java"
		Me.ckJava.UseVisualStyleBackColor = True
		'
		'ckJavascript
		'
		Me.ckJavascript.AutoSize = True
		Me.ckJavascript.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckJavascript.Location = New System.Drawing.Point(344, 160)
		Me.ckJavascript.Name = "ckJavascript"
		Me.ckJavascript.Size = New System.Drawing.Size(94, 22)
		Me.ckJavascript.TabIndex = 9
		Me.ckJavascript.Text = "Javascript"
		Me.ckJavascript.UseVisualStyleBackColor = True
		'
		'ckCsharp
		'
		Me.ckCsharp.AutoSize = True
		Me.ckCsharp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckCsharp.Location = New System.Drawing.Point(448, 160)
		Me.ckCsharp.Name = "ckCsharp"
		Me.ckCsharp.Size = New System.Drawing.Size(46, 22)
		Me.ckCsharp.TabIndex = 10
		Me.ckCsharp.Text = "C#"
		Me.ckCsharp.UseVisualStyleBackColor = True
		'
		'lblResult
		'
		Me.lblResult.AutoSize = True
		Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblResult.Location = New System.Drawing.Point(32, 248)
		Me.lblResult.Name = "lblResult"
		Me.lblResult.Size = New System.Drawing.Size(61, 20)
		Me.lblResult.TabIndex = 11
		Me.lblResult.Text = "Result"
		Me.lblResult.Visible = False
		'
		'btnAccept
		'
		Me.btnAccept.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnAccept.ForeColor = System.Drawing.SystemColors.MenuHighlight
		Me.btnAccept.Location = New System.Drawing.Point(200, 200)
		Me.btnAccept.Name = "btnAccept"
		Me.btnAccept.Size = New System.Drawing.Size(75, 32)
		Me.btnAccept.TabIndex = 12
		Me.btnAccept.Text = "Accept"
		Me.btnAccept.UseVisualStyleBackColor = True
		'
		'btnReset
		'
		Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnReset.ForeColor = System.Drawing.SystemColors.MenuHighlight
		Me.btnReset.Location = New System.Drawing.Point(416, 200)
		Me.btnReset.Name = "btnReset"
		Me.btnReset.Size = New System.Drawing.Size(75, 32)
		Me.btnReset.TabIndex = 13
		Me.btnReset.Text = "Reset"
		Me.btnReset.UseVisualStyleBackColor = True
		'
		'FormQuiz
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(524, 450)
		Me.Controls.Add(Me.btnReset)
		Me.Controls.Add(Me.btnAccept)
		Me.Controls.Add(Me.lblResult)
		Me.Controls.Add(Me.ckCsharp)
		Me.Controls.Add(Me.ckJavascript)
		Me.Controls.Add(Me.ckJava)
		Me.Controls.Add(Me.ckPHP)
		Me.Controls.Add(Me.cboxOccupation)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.txtName)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "FormQuiz"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "EazyQuiz"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents txtName As TextBox
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents rdFemale As RadioButton
	Friend WithEvents rdMale As RadioButton
	Friend WithEvents cboxOccupation As ComboBox
	Friend WithEvents ckPHP As CheckBox
	Friend WithEvents ckJava As CheckBox
	Friend WithEvents ckJavascript As CheckBox
	Friend WithEvents ckCsharp As CheckBox
	Friend WithEvents lblResult As Label
	Friend WithEvents btnAccept As Button
	Friend WithEvents btnReset As Button
End Class
