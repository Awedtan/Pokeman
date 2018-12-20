Public Class frmBox2

	Private Sub frmBox2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		If frmMainMenu.Bulbasaur(6) = 1 Then
			btnBulbasaur.Enabled = True
		End If

		If frmMainMenu.Charmander(6) = 1 Then
			btnCharmander.Enabled = True
		End If

		If frmMainMenu.Squirtle(6) = 1 Then
			btnSquirtle.Enabled = True
		End If

		If frmMainMenu.Caterpie(6) = 1 Then
			btnCaterpie.Enabled = True
		End If

		If frmMainMenu.Metapod(6) = 1 Then
			btnMetapod.Enabled = True
		End If

		If frmMainMenu.Butterfree(6) = 1 Then
			btnButterfree.Enabled = True
		End If

		If frmMainMenu.Weedle(6) = 1 Then
			btnWeedle.Enabled = True
		End If

		If frmMainMenu.Kakuna(6) = 1 Then
			btnKakuna.Enabled = True
		End If

		If frmMainMenu.Beedrill(6) = 1 Then
			btnBeedrill.Enabled = True
		End If

		If frmMainMenu.Pidgey(6) = 1 Then
			btnPidgey.Enabled = True
		End If

		If frmMainMenu.Pidgeotto(6) = 1 Then
			btnPidgeotto.Enabled = True
		End If

		If frmMainMenu.Pidgeot(6) = 1 Then
			btnPidgeot.Enabled = True
		End If

	End Sub

	Function switch(ByVal pokemon As String)

		Dim slot As Integer

		If pokemon = "Bulbasaur" Then

			If frmMainMenu.Bulbasaur(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Bulbasaur
				frmMainMenu.Bulbasaur(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Bulbasaur
				frmMainMenu.Bulbasaur(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Bulbasaur
				frmMainMenu.Bulbasaur(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Bulbasaur
				frmMainMenu.Bulbasaur(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Bulbasaur
				frmMainMenu.Bulbasaur(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Bulbasaur
				frmMainMenu.Bulbasaur(7) = 1
			End If
		End If

		If pokemon = "Charmander" Then

			If frmMainMenu.Charmander(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Charmander
				frmMainMenu.Charmander(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Charmander
				frmMainMenu.Charmander(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Charmander
				frmMainMenu.Charmander(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Charmander
				frmMainMenu.Charmander(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Charmander
				frmMainMenu.Charmander(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Charmander
				frmMainMenu.Charmander(7) = 1
			End If
		End If

		If pokemon = "Squirtle" Then

			If frmMainMenu.Squirtle(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Squirtle
				frmMainMenu.Squirtle(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Squirtle
				frmMainMenu.Squirtle(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Squirtle
				frmMainMenu.Squirtle(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Squirtle
				frmMainMenu.Squirtle(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Squirtle
				frmMainMenu.Squirtle(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Squirtle
				frmMainMenu.Squirtle(7) = 1
			End If
		End If
		If pokemon = "Caterpie" Then

			If frmMainMenu.Caterpie(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Caterpie
				frmMainMenu.Caterpie(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Caterpie
				frmMainMenu.Caterpie(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Caterpie
				frmMainMenu.Caterpie(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Caterpie
				frmMainMenu.Caterpie(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Caterpie
				frmMainMenu.Caterpie(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Caterpie
				frmMainMenu.Caterpie(7) = 1
			End If
		End If
		If pokemon = "Metapod" Then

			If frmMainMenu.Metapod(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Metapod
				frmMainMenu.Metapod(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Metapod
				frmMainMenu.Metapod(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Metapod
				frmMainMenu.Metapod(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Metapod
				frmMainMenu.Metapod(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Metapod
				frmMainMenu.Metapod(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Metapod
				frmMainMenu.Metapod(7) = 1
			End If
		End If
		If pokemon = "Butterfree" Then

			If frmMainMenu.Butterfree(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Butterfree
				frmMainMenu.Butterfree(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Butterfree
				frmMainMenu.Butterfree(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Butterfree
				frmMainMenu.Butterfree(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Butterfree
				frmMainMenu.Butterfree(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Butterfree
				frmMainMenu.Butterfree(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Butterfree
				frmMainMenu.Butterfree(7) = 1
			End If
		End If
		If pokemon = "Weedle" Then

			If frmMainMenu.Weedle(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Weedle
				frmMainMenu.Weedle(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Weedle
				frmMainMenu.Weedle(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Weedle
				frmMainMenu.Weedle(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Weedle
				frmMainMenu.Weedle(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Weedle
				frmMainMenu.Weedle(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Weedle
				frmMainMenu.Weedle(7) = 1
			End If
		End If
		If pokemon = "Kakuna" Then

			If frmMainMenu.Kakuna(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Kakuna
				frmMainMenu.Kakuna(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Kakuna
				frmMainMenu.Kakuna(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Kakuna
				frmMainMenu.Kakuna(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Kakuna
				frmMainMenu.Kakuna(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Kakuna
				frmMainMenu.Kakuna(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Kakuna
				frmMainMenu.Kakuna(7) = 1
			End If
		End If
		If pokemon = "Beedrill" Then

			If frmMainMenu.Beedrill(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Beedrill
				frmMainMenu.Beedrill(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Beedrill
				frmMainMenu.Beedrill(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Beedrill
				frmMainMenu.Beedrill(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Beedrill
				frmMainMenu.Beedrill(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Beedrill
				frmMainMenu.Beedrill(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Beedrill
				frmMainMenu.Beedrill(7) = 1
			End If
		End If
		If pokemon = "Pidgey" Then

			If frmMainMenu.Pidgey(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Pidgey
				frmMainMenu.Pidgey(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Pidgey
				frmMainMenu.Pidgey(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Pidgey
				frmMainMenu.Pidgey(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Pidgey
				frmMainMenu.Pidgey(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Pidgey
				frmMainMenu.Pidgey(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Pidgey
				frmMainMenu.Pidgey(7) = 1
			End If
		End If
		If pokemon = "Pidgeotto" Then

			If frmMainMenu.Pidgeotto(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Pidgeotto
				frmMainMenu.Pidgeotto(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Pidgeotto
				frmMainMenu.Pidgeotto(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Pidgeotto
				frmMainMenu.Pidgeotto(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Pidgeotto
				frmMainMenu.Pidgeotto(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Pidgeotto
				frmMainMenu.Pidgeotto(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Pidgeotto
				frmMainMenu.Pidgeotto(7) = 1
			End If
		End If
		If pokemon = "Pidgeot" Then

			If frmMainMenu.Pidgeot(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Pidgeot
				frmMainMenu.Pidgeot(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Pidgeot
				frmMainMenu.Pidgeot(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Pidgeot
				frmMainMenu.Pidgeot(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Pidgeot
				frmMainMenu.Pidgeot(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Pidgeot
				frmMainMenu.Pidgeot(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Pidgeot
				frmMainMenu.Pidgeot(7) = 1
			End If
		End If
	End Function

	Private Sub btnBulbasaur_Click(sender As Object, e As EventArgs) Handles btnBulbasaur.Click
		switch("Bulbasaur")
	End Sub

	Private Sub btnCharmander_Click(sender As Object, e As EventArgs) Handles btnCharmander.Click
		switch("Charmander")
	End Sub

	Private Sub btnSquirtle_Click(sender As Object, e As EventArgs) Handles btnSquirtle.Click
		switch("Squirtle")
	End Sub

	Private Sub btnCaterpie_Click(sender As Object, e As EventArgs) Handles btnCaterpie.Click
		switch("Caterpie")
	End Sub

	Private Sub btnMetapod_click(sender As Object, e As EventArgs) Handles btnMetapod.Click
		switch("Metapod")
	End Sub

	Private Sub btnButterfree_Click(sender As Object, e As EventArgs) Handles btnButterfree.Click
		switch("Butterfree")
	End Sub

	Private Sub btnWeedle_Click(sender As Object, e As EventArgs) Handles btnWeedle.Click
		switch("Weedle")
	End Sub

	Private Sub btnKakuna_Click(sender As Object, e As EventArgs) Handles btnKakuna.Click
		switch("Kakuna")
	End Sub

	Private Sub btnBeedrill_Click(sender As Object, e As EventArgs) Handles btnBeedrill.Click
		switch("Beedrill")
	End Sub

	Private Sub btnPidgey_Click(sender As Object, e As EventArgs) Handles btnPidgey.Click
		switch("Pidgey")
	End Sub

	Private Sub btnPidgeotto_Click(sender As Object, e As EventArgs) Handles btnPidgeotto.Click
		switch("Pidgeotto")
	End Sub

	Private Sub btnPidgeot_Click(sender As Object, e As EventArgs) Handles btnPidgeot.Click
		switch("Pidgeot")
	End Sub

	Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
		Me.Close()
	End Sub

	Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
		Me.Close()
	End Sub
End Class