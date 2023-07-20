Imports System.Runtime.CompilerServices

Public Class MainForm
	Private Sub tsExit_Click(sender As Object, e As EventArgs) Handles tsExit.Click
		Dim confirmResult = MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.YesNo)
		If confirmResult = DialogResult.Yes Then
			Application.Exit()
		End If
	End Sub

	Private Sub tsExample_Click(sender As Object, e As EventArgs) Handles tsExample.Click
		Dim isOpen As Boolean = False
		For Each f As Form In Application.OpenForms
			If f.Text = "Example" Then
				isOpen = True
				f.Focus()

			End If
		Next

		If Not isOpen Then
			Dim form As New ExampleForm()
			form.MdiParent = Me
			form.Show()
		End If
	End Sub

	Private Sub tsAbout_Click(sender As Object, e As EventArgs) Handles tsAbout.Click
		ShowAboutForm()
	End Sub

	Private Sub ShowAboutForm()
		Dim isOpen As Boolean = False
		For Each f As Form In Application.OpenForms
			If f.Text = "About Us" Then
				isOpen = True
				f.Focus()

			End If
		Next

		If Not isOpen Then
			Dim form As New AboutForm()
			form.MdiParent = Me
			form.Show()
		End If


	End Sub

	Private Sub tsbExit_Click(sender As Object, e As EventArgs) Handles tsbExit.Click
		Dim confirmResult = MessageBox.Show("Are you sure to Exit?", "Exit", MessageBoxButtons.YesNo)
		If confirmResult = DialogResult.Yes Then
			Application.Exit()
		End If
	End Sub

	Private Sub tsbHelp_Click(sender As Object, e As EventArgs) Handles tsbHelp.Click
		ShowAboutForm()
	End Sub
End Class