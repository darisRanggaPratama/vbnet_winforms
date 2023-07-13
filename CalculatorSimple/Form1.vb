Public Class Form1
	Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
		Dim angka1 As Int32 = Int32.Parse(txt1.Text)
		Dim angka2 As Int32 = Int32.Parse(txt2.Text)
		Dim hasil As Int32 = angka1 + angka2

		txtHasil.Text = hasil.ToString()
	End Sub

	Private Sub btnKurang_Click(sender As Object, e As EventArgs) Handles btnKurang.Click
		Dim angka1 As Int32 = Int32.Parse(txt1.Text)
		Dim angka2 As Int32 = Int32.Parse(txt2.Text)
		Dim hasil As Int32 = angka1 - angka2

		txtHasil.Text = hasil.ToString()
	End Sub

	Private Sub btnKali_Click(sender As Object, e As EventArgs) Handles btnKali.Click
		Dim angka1 As Int32 = Int32.Parse(txt1.Text)
		Dim angka2 As Int32 = Int32.Parse(txt2.Text)
		Dim hasil As Int32 = angka1 * angka2

		txtHasil.Text = hasil.ToString()
	End Sub

	Private Sub btnBagi_Click(sender As Object, e As EventArgs) Handles btnBagi.Click
		Dim angka1 As Int32 = Int32.Parse(txt1.Text)
		Dim angka2 As Int32 = Int32.Parse(txt2.Text)
		Dim hasil As Int32 = angka1 / angka2

		txtHasil.Text = hasil.ToString()
	End Sub

	Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
		txt1.Text = ""
		txt2.Text = ""
		txtHasil.Text = ""
	End Sub
End Class
