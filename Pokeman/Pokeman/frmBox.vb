Public Class frmBox

	Private Sub frmBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		If frmMainMenu.Bulbasaur(6) = 1 Then
			Button1.Enabled = True
		End If

		If frmMainMenu.Charmander(6) = 1 Then
			Button2.Enabled = True
		End If

		If frmMainMenu.Squirtle(6) = 1 Then
			Button3.Enabled = True
		End If

		If frmMainMenu.Caterpie(6) = 1 Then
			Button4.Enabled = True
		End If

		If frmMainMenu.Metapod(6) = 1 Then
			Button8.Enabled = True
		End If

		If frmMainMenu.Butterfree(6) = 1 Then
			Button7.Enabled = True
		End If

		If frmMainMenu.Weedle(6) = 1 Then
			Button6.Enabled = True
		End If

		If frmMainMenu.Kakuna(6) = 1 Then
			Button5.Enabled = True
		End If

		If frmMainMenu.Beedrill(6) = 1 Then
			Button12.Enabled = True
		End If

		If frmMainMenu.Pidgey(6) = 1 Then
			Button11.Enabled = True
		End If

		If frmMainMenu.Pidgeotto(6) = 1 Then
			Button10.Enabled = True
		End If

		If frmMainMenu.Pidgeot(6) = 1 Then
			Button9.Enabled = True
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
	End Function

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		switch("Bulbasaur")
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		switch("Charmander")
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		switch("Squirtle")
	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		switch("Caterpie")
	End Sub

	Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
		switch("Metapod")
	End Sub

	Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
		switch("Butterfree")
	End Sub

	Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
		switch("Weedle")
	End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
		switch("Kakuna")
	End Sub

	Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
		switch("Beedrill")
	End Sub

	Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
		switch("Pidgey")
	End Sub

	Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
		switch("Pidgeotto")
	End Sub

	Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
		switch("Pidgeot")
	End Sub
End Class