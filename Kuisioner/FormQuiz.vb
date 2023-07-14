Public Class FormQuiz

	Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
		txtName.Text = ""
		rdMale.Checked = False
		rdFemale.Checked = False
		cboxOccupation.SelectedIndex = -1
		ckCsharp.Checked = False
		ckJava.Checked = False
		ckJavascript.Checked = False
		ckPHP.Checked = False
		lblResult.Visible = False
	End Sub

	Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
		Dim hasil As String = ""
		Dim name As String = txtName.Text
		Dim gender As String = ""
		Dim occupation As String = cboxOccupation.Text
		Dim skill As String = ""

		If (rdMale.Checked) Then
			gender = "Male"
		ElseIf (rdFemale.Checked) Then
			gender = "Female"
		Else
			MessageBox.Show("Please choose your gender.")
		End If

		If (String.IsNullOrEmpty(occupation)) Then
			MessageBox.Show("Please choose your occupation.")
		End If

		If (ckCsharp.Checked) Then
			skill += "C#, "
		End If

		If (ckJava.Checked) Then
			skill += "Java, "
		End If

		If (ckJavascript.Checked) Then
			skill += "Javascript, "
		End If

		If (ckPHP.Checked) Then
			skill += "PHP, "
		End If

		If (String.IsNullOrEmpty(skill)) Then
			MessageBox.Show("Please choose your programming skills")
		End If

		If (Not String.IsNullOrEmpty(name) Or Not String.IsNullOrEmpty(gender) Or Not String.IsNullOrEmpty(occupation) Or Not String.IsNullOrEmpty(skill)) Then

			hasil = "Name: " & name & "\n"
			hasil += "Gender: " & gender & "\n"
			hasil += "Occupation: " & occupation & "\n"
			hasil += "Programming Skills: " & skill & "\n"

			lblResult.Visible = True
			lblResult.Text = hasil
		End If

	End Sub
End Class
