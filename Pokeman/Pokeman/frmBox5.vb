Public Class frmBox5

	Private Sub frmBox2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		If frmMainMenu.Abra(6) = 1 Then
			btnAbra.Enabled = True
		End If

		If frmMainMenu.Kadabra(6) = 1 Then
			btnKadabra.Enabled = True
		End If

		If frmMainMenu.Alakazam(6) = 1 Then
			btnAlakazam.Enabled = True
		End If

		If frmMainMenu.Machop(6) = 1 Then
			btnMachop.Enabled = True
		End If

		If frmMainMenu.Machoke(6) = 1 Then
			btnMachoke.Enabled = True
		End If

		If frmMainMenu.Psyduck(6) = 1 Then
			btnPsyduck.Enabled = True
		End If

		If frmMainMenu.Bellsprout(6) = 1 Then
			btnBellsprout.Enabled = True
		End If

		If frmMainMenu.Golem(6) = 1 Then
			btnGolem.Enabled = True
		End If

		If frmMainMenu.Ponyta(6) = 1 Then
			btnPonyta.Enabled = True
		End If

		If frmMainMenu.Rapidash(6) = 1 Then
			btnRapidash.Enabled = True
		End If

		If frmMainMenu.Magnemite(6) = 1 Then
			btnMagnemite.Enabled = True
		End If

		If frmMainMenu.Magneton(6) = 1 Then
			btnMagneton.Enabled = True
		End If

	End Sub

	Function switch(ByVal pokemon As String)

		Dim slot As Integer

		If pokemon = "Abra" Then

			If frmMainMenu.Abra(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Abra
				frmMainMenu.Abra(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Abra
				frmMainMenu.Abra(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Abra
				frmMainMenu.Abra(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Abra
				frmMainMenu.Abra(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Abra
				frmMainMenu.Abra(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Abra
				frmMainMenu.Abra(7) = 1
			End If
		End If

		If pokemon = "Kadabra" Then

			If frmMainMenu.Kadabra(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Kadabra
				frmMainMenu.Kadabra(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Kadabra
				frmMainMenu.Kadabra(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Kadabra
				frmMainMenu.Kadabra(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Kadabra
				frmMainMenu.Kadabra(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Kadabra
				frmMainMenu.Kadabra(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Kadabra
				frmMainMenu.Kadabra(7) = 1
			End If
		End If

		If pokemon = "Alakazam" Then

			If frmMainMenu.Alakazam(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Alakazam
				frmMainMenu.Alakazam(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Alakazam
				frmMainMenu.Alakazam(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Alakazam
				frmMainMenu.Alakazam(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Alakazam
				frmMainMenu.Alakazam(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Alakazam
				frmMainMenu.Alakazam(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Alakazam
				frmMainMenu.Alakazam(7) = 1
			End If
		End If
		If pokemon = "Machop" Then

			If frmMainMenu.Machop(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Machop
				frmMainMenu.Machop(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Machop
				frmMainMenu.Machop(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Machop
				frmMainMenu.Machop(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Machop
				frmMainMenu.Machop(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Machop
				frmMainMenu.Machop(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Machop
				frmMainMenu.Machop(7) = 1
			End If
		End If
		If pokemon = "Machoke" Then

			If frmMainMenu.Machoke(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Machoke
				frmMainMenu.Machoke(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Machoke
				frmMainMenu.Machoke(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Machoke
				frmMainMenu.Machoke(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Machoke
				frmMainMenu.Machoke(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Machoke
				frmMainMenu.Machoke(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Machoke
				frmMainMenu.Machoke(7) = 1
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
		If pokemon = "Bellsprout" Then

			If frmMainMenu.Bellsprout(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Bellsprout
				frmMainMenu.Bellsprout(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Bellsprout
				frmMainMenu.Bellsprout(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Bellsprout
				frmMainMenu.Bellsprout(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Bellsprout
				frmMainMenu.Bellsprout(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Bellsprout
				frmMainMenu.Bellsprout(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Bellsprout
				frmMainMenu.Bellsprout(7) = 1
			End If
		End If
		If pokemon = "Golem" Then

			If frmMainMenu.Golem(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Golem
				frmMainMenu.Golem(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Golem
				frmMainMenu.Golem(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Golem
				frmMainMenu.Golem(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Golem
				frmMainMenu.Golem(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Golem
				frmMainMenu.Golem(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Golem
				frmMainMenu.Golem(7) = 1
			End If
		End If
		If pokemon = "Ponyta" Then

			If frmMainMenu.Ponyta(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Ponyta
				frmMainMenu.Ponyta(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Ponyta
				frmMainMenu.Ponyta(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Ponyta
				frmMainMenu.Ponyta(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Ponyta
				frmMainMenu.Ponyta(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Ponyta
				frmMainMenu.Ponyta(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Ponyta
				frmMainMenu.Ponyta(7) = 1
			End If
		End If
		If pokemon = "Rapidash" Then

			If frmMainMenu.Rapidash(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Rapidash
				frmMainMenu.Rapidash(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Rapidash
				frmMainMenu.Rapidash(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Rapidash
				frmMainMenu.Rapidash(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Rapidash
				frmMainMenu.Rapidash(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Rapidash
				frmMainMenu.Rapidash(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Rapidash
				frmMainMenu.Rapidash(7) = 1
			End If
		End If
		If pokemon = "Magnemite" Then

			If frmMainMenu.Magnemite(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Magnemite
				frmMainMenu.Magnemite(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Magnemite
				frmMainMenu.Magnemite(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Magnemite
				frmMainMenu.Magnemite(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Magnemite
				frmMainMenu.Magnemite(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Magnemite
				frmMainMenu.Magnemite(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Magnemite
				frmMainMenu.Magnemite(7) = 1
			End If
		End If
		If pokemon = "Magneton" Then

			If frmMainMenu.Magneton(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Magneton
				frmMainMenu.Magneton(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Magneton
				frmMainMenu.Magneton(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Magneton
				frmMainMenu.Magneton(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Magneton
				frmMainMenu.Magneton(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Magneton
				frmMainMenu.Magneton(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Magneton
				frmMainMenu.Magneton(7) = 1
			End If
		End If
	End Function

	Private Sub btnAbra_Click(sender As Object, e As EventArgs) Handles btnAbra.Click
		switch("Abra")
	End Sub

	Private Sub btnKadabra_Click(sender As Object, e As EventArgs) Handles btnKadabra.Click
		switch("Kadabra")
	End Sub

	Private Sub btnAlakazam_Click(sender As Object, e As EventArgs) Handles btnAlakazam.Click
		switch("Alakazam")
	End Sub

	Private Sub btnMachop_Click(sender As Object, e As EventArgs) Handles btnMachop.Click
		switch("Machop")
	End Sub

	Private Sub btnMachoke_click(sender As Object, e As EventArgs) Handles btnMachoke.Click
		switch("Machoke")
	End Sub

	Private Sub btnPsyduck_Click(sender As Object, e As EventArgs) Handles btnPsyduck.Click
		switch("Psyduck")
	End Sub

	Private Sub btnBellsprout_Click(sender As Object, e As EventArgs) Handles btnBellsprout.Click
		switch("Bellsprout")
	End Sub

	Private Sub btnGolem_Click(sender As Object, e As EventArgs) Handles btnGolem.Click
		switch("Golem")
	End Sub

	Private Sub btnPonyta_Click(sender As Object, e As EventArgs) Handles btnPonyta.Click
		switch("Ponyta")
	End Sub

	Private Sub btnRapidash_Click(sender As Object, e As EventArgs) Handles btnRapidash.Click
		switch("Rapidash")
	End Sub

	Private Sub btnMagnemite_Click(sender As Object, e As EventArgs) Handles btnMagnemite.Click
		switch("Magnemite")
	End Sub

	Private Sub btnMagneton_Click(sender As Object, e As EventArgs) Handles btnMagneton.Click
		switch("Magneton")
	End Sub

	Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
		frmBox4.Show()
		Me.Close()
	End Sub

	Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
		frmBox6.Show()
		Me.Close()
	End Sub
End Class