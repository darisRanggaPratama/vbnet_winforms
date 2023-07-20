Public Class AboutForm
	Private Sub LinkLabel_Click(sender As Object, e As EventArgs) Handles LinkLabel.Click
		System.Diagnostics.Process.Start("https://www.hyvoy.com")


	End Sub

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
		Me.Close()
	End Sub
End Class