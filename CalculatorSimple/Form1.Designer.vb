<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txt1 = New System.Windows.Forms.TextBox()
		Me.txt2 = New System.Windows.Forms.TextBox()
		Me.txtHasil = New System.Windows.Forms.TextBox()
		Me.btnTambah = New System.Windows.Forms.Button()
		Me.btnKurang = New System.Windows.Forms.Button()
		Me.btnKali = New System.Windows.Forms.Button()
		Me.btnBagi = New System.Windows.Forms.Button()
		Me.btnReset = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(16, 24)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(80, 20)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Angka_1"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(16, 64)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(80, 20)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Angka_2"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(16, 104)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(49, 20)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Hasil"
		'
		'txt1
		'
		Me.txt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txt1.Location = New System.Drawing.Point(112, 24)
		Me.txt1.Name = "txt1"
		Me.txt1.Size = New System.Drawing.Size(128, 23)
		Me.txt1.TabIndex = 3
		'
		'txt2
		'
		Me.txt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txt2.Location = New System.Drawing.Point(112, 64)
		Me.txt2.Name = "txt2"
		Me.txt2.Size = New System.Drawing.Size(128, 23)
		Me.txt2.TabIndex = 4
		'
		'txtHasil
		'
		Me.txtHasil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtHasil.Location = New System.Drawing.Point(112, 104)
		Me.txtHasil.Name = "txtHasil"
		Me.txtHasil.Size = New System.Drawing.Size(128, 23)
		Me.txtHasil.TabIndex = 5
		'
		'btnTambah
		'
		Me.btnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTambah.Location = New System.Drawing.Point(16, 144)
		Me.btnTambah.Name = "btnTambah"
		Me.btnTambah.Size = New System.Drawing.Size(75, 32)
		Me.btnTambah.TabIndex = 6
		Me.btnTambah.Text = "Tambah"
		Me.btnTambah.UseVisualStyleBackColor = True
		'
		'btnKurang
		'
		Me.btnKurang.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnKurang.Location = New System.Drawing.Point(104, 144)
		Me.btnKurang.Name = "btnKurang"
		Me.btnKurang.Size = New System.Drawing.Size(75, 32)
		Me.btnKurang.TabIndex = 7
		Me.btnKurang.Text = "Kurang"
		Me.btnKurang.UseVisualStyleBackColor = True
		'
		'btnKali
		'
		Me.btnKali.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnKali.Location = New System.Drawing.Point(192, 144)
		Me.btnKali.Name = "btnKali"
		Me.btnKali.Size = New System.Drawing.Size(75, 32)
		Me.btnKali.TabIndex = 8
		Me.btnKali.Text = "Kali"
		Me.btnKali.UseVisualStyleBackColor = True
		'
		'btnBagi
		'
		Me.btnBagi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBagi.Location = New System.Drawing.Point(280, 144)
		Me.btnBagi.Name = "btnBagi"
		Me.btnBagi.Size = New System.Drawing.Size(75, 32)
		Me.btnBagi.TabIndex = 9
		Me.btnBagi.Text = "Bagi"
		Me.btnBagi.UseVisualStyleBackColor = True
		'
		'btnReset
		'
		Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnReset.Location = New System.Drawing.Point(392, 144)
		Me.btnReset.Name = "btnReset"
		Me.btnReset.Size = New System.Drawing.Size(75, 32)
		Me.btnReset.TabIndex = 10
		Me.btnReset.Text = "Restart"
		Me.btnReset.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(483, 206)
		Me.Controls.Add(Me.btnReset)
		Me.Controls.Add(Me.btnBagi)
		Me.Controls.Add(Me.btnKali)
		Me.Controls.Add(Me.btnKurang)
		Me.Controls.Add(Me.btnTambah)
		Me.Controls.Add(Me.txtHasil)
		Me.Controls.Add(Me.txt2)
		Me.Controls.Add(Me.txt1)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "EazyCalc"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents txt1 As TextBox
	Friend WithEvents txt2 As TextBox
	Friend WithEvents txtHasil As TextBox
	Friend WithEvents btnTambah As Button
	Friend WithEvents btnKurang As Button
	Friend WithEvents btnKali As Button
	Friend WithEvents btnBagi As Button
	Friend WithEvents btnReset As Button
End Class
