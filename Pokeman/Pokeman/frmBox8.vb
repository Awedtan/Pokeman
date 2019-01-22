Public Class frmBox8

	Private Sub frmBox2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		If frmMainMenu.Aerodactyl(6) = 1 Then
			btnAerodactyl.Enabled = True
		End If

		If frmMainMenu.Snorlax(6) = 1 Then
			btnSnorlax.Enabled = True
		End If

		If frmMainMenu.Articuno(6) = 1 Then
			btnArticuno.Enabled = True
		End If

		If frmMainMenu.Zapdos(6) = 1 Then
			btnZapdos.Enabled = True
		End If

		If frmMainMenu.Moltres(6) = 1 Then
			btnMoltres.Enabled = True
		End If

		If frmMainMenu.Dragonair(6) = 1 Then
			btnDragonair.Enabled = True
		End If

		If frmMainMenu.Dragonite(6) = 1 Then
			btnDragonite.Enabled = True
		End If
	End Sub

	Function switch(ByVal pokemon As String)

		Dim slot As Integer

		If pokemon = "Aerodactyl" Then

			If frmMainMenu.Aerodactyl(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Aerodactyl
				frmMainMenu.Aerodactyl(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Aerodactyl
				frmMainMenu.Aerodactyl(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Aerodactyl
				frmMainMenu.Aerodactyl(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Aerodactyl
				frmMainMenu.Aerodactyl(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Aerodactyl
				frmMainMenu.Aerodactyl(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Aerodactyl
				frmMainMenu.Aerodactyl(7) = 1
			End If
		End If

		If pokemon = "Snorlax" Then

			If frmMainMenu.Snorlax(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Snorlax
				frmMainMenu.Snorlax(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Snorlax
				frmMainMenu.Snorlax(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Snorlax
				frmMainMenu.Snorlax(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Snorlax
				frmMainMenu.Snorlax(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Snorlax
				frmMainMenu.Snorlax(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Snorlax
				frmMainMenu.Snorlax(7) = 1
			End If
		End If

		If pokemon = "Articuno" Then

			If frmMainMenu.Articuno(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Articuno
				frmMainMenu.Articuno(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Articuno
				frmMainMenu.Articuno(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Articuno
				frmMainMenu.Articuno(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Articuno
				frmMainMenu.Articuno(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Articuno
				frmMainMenu.Articuno(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Articuno
				frmMainMenu.Articuno(7) = 1
			End If
		End If
		If pokemon = "Zapdos" Then

			If frmMainMenu.Zapdos(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Zapdos
				frmMainMenu.Zapdos(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Zapdos
				frmMainMenu.Zapdos(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Zapdos
				frmMainMenu.Zapdos(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Zapdos
				frmMainMenu.Zapdos(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Zapdos
				frmMainMenu.Zapdos(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Zapdos
				frmMainMenu.Zapdos(7) = 1
			End If
		End If
		If pokemon = "Moltres" Then

			If frmMainMenu.Moltres(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Moltres
				frmMainMenu.Moltres(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Moltres
				frmMainMenu.Moltres(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Moltres
				frmMainMenu.Moltres(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Moltres
				frmMainMenu.Moltres(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Moltres
				frmMainMenu.Moltres(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Moltres
				frmMainMenu.Moltres(7) = 1
			End If
		End If
		If pokemon = "Dragonair" Then

			If frmMainMenu.Dragonair(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Dragonair
				frmMainMenu.Dragonair(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Dragonair
				frmMainMenu.Dragonair(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Dragonair
				frmMainMenu.Dragonair(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Dragonair
				frmMainMenu.Dragonair(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Dragonair
				frmMainMenu.Dragonair(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Dragonair
				frmMainMenu.Dragonair(7) = 1
			End If
		End If
		If pokemon = "Dragonite" Then

			If frmMainMenu.Dragonite(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Dragonite
				frmMainMenu.Dragonite(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Dragonite
				frmMainMenu.Dragonite(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Dragonite
				frmMainMenu.Dragonite(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Dragonite
				frmMainMenu.Dragonite(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Dragonite
				frmMainMenu.Dragonite(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Dragonite
				frmMainMenu.Dragonite(7) = 1
			End If
		End If
	End Function

	Private Sub btnAerodactyl_Click(sender As Object, e As EventArgs) Handles btnAerodactyl.Click
		switch("Aerodactyl")
	End Sub

	Private Sub btnSnorlax_Click(sender As Object, e As EventArgs) Handles btnSnorlax.Click
		switch("Snorlax")
	End Sub

	Private Sub btnArticuno_Click(sender As Object, e As EventArgs) Handles btnArticuno.Click
		switch("Articuno")
	End Sub

	Private Sub btnZapdos_Click(sender As Object, e As EventArgs) Handles btnZapdos.Click
		switch("Zapdos")
	End Sub

	Private Sub btnMoltres_click(sender As Object, e As EventArgs) Handles btnMoltres.Click
		switch("Moltres")
	End Sub

	Private Sub btnDragonair_Click(sender As Object, e As EventArgs) Handles btnDragonair.Click
		switch("Dragonair")
	End Sub

	Private Sub btnDragonite_Click(sender As Object, e As EventArgs) Handles btnDragonite.Click
		switch("Dragonite")
	End Sub

	Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
		frmBox7.Show()
		Me.Close()
	End Sub

	Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
		frmBox.Show()
		Me.Close()
	End Sub
	Private Sub Button1_Click(sender As Object, e As EventArgs) 
	End Sub
End Class