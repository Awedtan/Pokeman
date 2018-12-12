Public Class frmBox

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

		If frmMainMenu.Bulbasaur(4) = 1 Then

			Button1.Enabled = True

		End If

	End Sub

End Class