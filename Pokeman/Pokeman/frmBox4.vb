Public Class frmBox4

	Private Sub frmBox2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		If frmMainMenu.Parasect(6) = 1 Then
			btnParasect.Enabled = True
		End If

		If frmMainMenu.Venonat(6) = 1 Then
			btnVenonat.Enabled = True
		End If

		If frmMainMenu.Venomoth(6) = 1 Then
			btnVenomoth.Enabled = True
		End If

		If frmMainMenu.Diglett(6) = 1 Then
			btnDiglett.Enabled = True
		End If

		If frmMainMenu.Meowth(6) = 1 Then
			btnMeowth.Enabled = True
		End If

		If frmMainMenu.Psyduck(6) = 1 Then
			btnPsyduck.Enabled = True
		End If

		If frmMainMenu.Golduck(6) = 1 Then
			btnGolduck.Enabled = True
		End If

		If frmMainMenu.Growlithe(6) = 1 Then
			btnGrowlithe.Enabled = True
		End If

		If frmMainMenu.Arcanine(6) = 1 Then
			btnArcanine.Enabled = True
		End If

		If frmMainMenu.Poliwag(6) = 1 Then
			btnPoliwag.Enabled = True
		End If

		If frmMainMenu.Poliwhirl(6) = 1 Then
			btnPoliwhirl.Enabled = True
		End If

		If frmMainMenu.Poliwrath(6) = 1 Then
			btnPoliwrath.Enabled = True
		End If

	End Sub

	Function switch(ByVal pokemon As String)

		Dim slot As Integer

		If pokemon = "Parasect" Then

			If frmMainMenu.Parasect(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Parasect
				frmMainMenu.Parasect(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Parasect
				frmMainMenu.Parasect(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Parasect
				frmMainMenu.Parasect(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Parasect
				frmMainMenu.Parasect(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Parasect
				frmMainMenu.Parasect(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Parasect
				frmMainMenu.Parasect(7) = 1
			End If
		End If

		If pokemon = "venonat" Then

			If frmMainMenu.Venonat(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Venonat
				frmMainMenu.Venonat(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Venonat
				frmMainMenu.Venonat(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Venonat
				frmMainMenu.Venonat(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Venonat
				frmMainMenu.Venonat(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Venonat
				frmMainMenu.Venonat(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Venonat
				frmMainMenu.Venonat(7) = 1
			End If
		End If

		If pokemon = "venomoth" Then

			If frmMainMenu.Venomoth(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Venomoth
				frmMainMenu.Venomoth(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Venomoth
				frmMainMenu.Venomoth(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Venomoth
				frmMainMenu.Venomoth(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Venomoth
				frmMainMenu.Venomoth(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Venomoth
				frmMainMenu.Venomoth(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Venomoth
				frmMainMenu.Venomoth(7) = 1
			End If
		End If
		If pokemon = "Diglett" Then

			If frmMainMenu.Diglett(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Diglett
				frmMainMenu.Diglett(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Diglett
				frmMainMenu.Diglett(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Diglett
				frmMainMenu.Diglett(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Diglett
				frmMainMenu.Diglett(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Diglett
				frmMainMenu.Diglett(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Diglett
				frmMainMenu.Diglett(7) = 1
			End If
		End If
		If pokemon = "Meowth" Then

			If frmMainMenu.Meowth(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Meowth
				frmMainMenu.Meowth(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Meowth
				frmMainMenu.Meowth(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Meowth
				frmMainMenu.Meowth(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Meowth
				frmMainMenu.Meowth(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Meowth
				frmMainMenu.Meowth(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Meowth
				frmMainMenu.Meowth(7) = 1
			End If
		End If
		If pokemon = "Psyduck" Then

			If frmMainMenu.Psyduck(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Psyduck
				frmMainMenu.Psyduck(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Psyduck
				frmMainMenu.Psyduck(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Psyduck
				frmMainMenu.Psyduck(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Psyduck
				frmMainMenu.Psyduck(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Psyduck
				frmMainMenu.Psyduck(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Psyduck
				frmMainMenu.Psyduck(7) = 1
			End If
		End If
		If pokemon = "Golduck" Then

			If frmMainMenu.Golduck(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Golduck
				frmMainMenu.Golduck(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Golduck
				frmMainMenu.Golduck(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Golduck
				frmMainMenu.Golduck(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Golduck
				frmMainMenu.Golduck(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Golduck
				frmMainMenu.Golduck(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Golduck
				frmMainMenu.Golduck(7) = 1
			End If
		End If
		If pokemon = "Growlithe" Then

			If frmMainMenu.Growlithe(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Growlithe
				frmMainMenu.Growlithe(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Growlithe
				frmMainMenu.Growlithe(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Growlithe
				frmMainMenu.Growlithe(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Growlithe
				frmMainMenu.Growlithe(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Growlithe
				frmMainMenu.Growlithe(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Growlithe
				frmMainMenu.Growlithe(7) = 1
			End If
		End If
		If pokemon = "Arcanine" Then

			If frmMainMenu.Arcanine(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Arcanine
				frmMainMenu.Arcanine(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Arcanine
				frmMainMenu.Arcanine(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Arcanine
				frmMainMenu.Arcanine(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Arcanine
				frmMainMenu.Arcanine(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Arcanine
				frmMainMenu.Arcanine(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Arcanine
				frmMainMenu.Arcanine(7) = 1
			End If
		End If
		If pokemon = "Poliwag" Then

			If frmMainMenu.Poliwag(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Poliwag
				frmMainMenu.Poliwag(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Poliwag
				frmMainMenu.Poliwag(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Poliwag
				frmMainMenu.Poliwag(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Poliwag
				frmMainMenu.Poliwag(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Poliwag
				frmMainMenu.Poliwag(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Poliwag
				frmMainMenu.Poliwag(7) = 1
			End If
		End If
		If pokemon = "Poliwhirl" Then

			If frmMainMenu.Poliwhirl(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Poliwhirl
				frmMainMenu.Poliwhirl(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Poliwhirl
				frmMainMenu.Poliwhirl(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Poliwhirl
				frmMainMenu.Poliwhirl(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Poliwhirl
				frmMainMenu.Poliwhirl(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Poliwhirl
				frmMainMenu.Poliwhirl(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Poliwhirl
				frmMainMenu.Poliwhirl(7) = 1
			End If
		End If
		If pokemon = "Poliwrath" Then

			If frmMainMenu.Poliwrath(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Poliwrath
				frmMainMenu.Poliwrath(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Poliwrath
				frmMainMenu.Poliwrath(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Poliwrath
				frmMainMenu.Poliwrath(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Poliwrath
				frmMainMenu.Poliwrath(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Poliwrath
				frmMainMenu.Poliwrath(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Poliwrath
				frmMainMenu.Poliwrath(7) = 1
			End If
		End If
	End Function

	Private Sub btnParasect_Click(sender As Object, e As EventArgs) Handles btnParasect.Click
		switch("Parasect")
	End Sub

	Private Sub btnvenonat_Click(sender As Object, e As EventArgs) Handles btnVenonat.Click
		switch("venonat")
	End Sub

	Private Sub btnvenomoth_Click(sender As Object, e As EventArgs) Handles btnVenomoth.Click
		switch("venomoth")
	End Sub

	Private Sub btnDiglett_Click(sender As Object, e As EventArgs) Handles btnDiglett.Click
		switch("Diglett")
	End Sub

	Private Sub btnMeowth_click(sender As Object, e As EventArgs) Handles btnMeowth.Click
		switch("Meowth")
	End Sub

	Private Sub btnPsyduck_Click(sender As Object, e As EventArgs) Handles btnPsyduck.Click
		switch("Psyduck")
	End Sub

	Private Sub btnGolduck_Click(sender As Object, e As EventArgs) Handles btnGolduck.Click
		switch("Golduck")
	End Sub

	Private Sub btnGrowlithe_Click(sender As Object, e As EventArgs) Handles btnGrowlithe.Click
		switch("Growlithe")
	End Sub

	Private Sub btnArcanine_Click(sender As Object, e As EventArgs) Handles btnArcanine.Click
		switch("Arcanine")
	End Sub

	Private Sub btnPoliwag_Click(sender As Object, e As EventArgs) Handles btnPoliwag.Click
		switch("Poliwag")
	End Sub

	Private Sub btnPoliwhirl_Click(sender As Object, e As EventArgs) Handles btnPoliwhirl.Click
		switch("Poliwhirl")
	End Sub

	Private Sub btnPoliwrath_Click(sender As Object, e As EventArgs) Handles btnPoliwrath.Click
		switch("Poliwrath")
	End Sub

	Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
		frmBox3.Show()
		Me.Close()
	End Sub

	Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
		frmBox5.Show()
		Me.Close()
	End Sub
End Class