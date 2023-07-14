Public Class Form1
	Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
		Dim angka1 As Double = Double.Parse(txt1.Text)
		Dim angka2 As Double = Double.Parse(txt2.Text)
		Dim hasil As Double = angka1 + angka2

		txtHasil.Text = hasil.ToString()
	End Sub

	Private Sub btnKurang_Click(sender As Object, e As EventArgs) Handles btnKurang.Click
		Dim angka1 As Double = Double.Parse(txt1.Text)
		Dim angka2 As Double = Double.Parse(txt2.Text)
		Dim hasil As Double = angka1 - angka2

		txtHasil.Text = hasil.ToString()
	End Sub

	Private Sub btnKali_Click(sender As Object, e As EventArgs) Handles btnKali.Click
		Dim angka1 As Double = Double.Parse(txt1.Text)
		Dim angka2 As Double = Double.Parse(txt2.Text)
		Dim hasil As Double = angka1 * angka2

		txtHasil.Text = hasil.ToString()
		MsgBox(hasil)
	End Sub

	Private Sub btnBagi_Click(sender As Object, e As EventArgs) Handles btnBagi.Click
		Dim angka1 As Double = Double.Parse(txt1.Text)
		Dim angka2 As Double = Double.Parse(txt2.Text)
		Dim hasil As Double = angka1 / angka2

		txtHasil.Text = hasil.ToString()
		MessageBox.Show(hasil)
	End Sub

	Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
		txt1.Text = ""
		txt2.Text = ""
		txtHasil.Text = ""
	End Sub
End Class
