Public Class frmBox7

	Private Sub frmBox2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		If frmMainMenu.Voltorb(6) = 1 Then
			btnVoltorb.Enabled = True
		End If

		If frmMainMenu.Electrode(6) = 1 Then
			btnElectrode.Enabled = True
		End If

		If frmMainMenu.Kangaskhan(6) = 1 Then
			btnKangaskhan.Enabled = True
		End If

		If frmMainMenu.Electabuzz(6) = 1 Then
			btnElectabuzz.Enabled = True
		End If

		If frmMainMenu.Magmar(6) = 1 Then
			btnMagmar.Enabled = True
		End If

		If frmMainMenu.Tauros(6) = 1 Then
			btnTauros.Enabled = True
		End If

		If frmMainMenu.Magikarp(6) = 1 Then
			btnMagikarp.Enabled = True
		End If

		If frmMainMenu.Lapras(6) = 1 Then
			btnLapras.Enabled = True
		End If

		If frmMainMenu.Eevee(6) = 1 Then
			btnEevee.Enabled = True
		End If

		If frmMainMenu.Vaporeon(6) = 1 Then
			btnVaporeon.Enabled = True
		End If

		If frmMainMenu.Jolteon(6) = 1 Then
			btnJolteon.Enabled = True
		End If

		If frmMainMenu.Flareon(6) = 1 Then
			btnFlareon.Enabled = True
		End If

	End Sub

	Function switch(ByVal pokemon As String)

		Dim slot As Integer

		If pokemon = "Voltorb" Then

			If frmMainMenu.Voltorb(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Voltorb
				frmMainMenu.Voltorb(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Voltorb
				frmMainMenu.Voltorb(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Voltorb
				frmMainMenu.Voltorb(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Voltorb
				frmMainMenu.Voltorb(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Voltorb
				frmMainMenu.Voltorb(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Voltorb
				frmMainMenu.Voltorb(7) = 1
			End If
		End If

		If pokemon = "Electrode" Then

			If frmMainMenu.Electrode(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Electrode
				frmMainMenu.Electrode(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Electrode
				frmMainMenu.Electrode(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Electrode
				frmMainMenu.Electrode(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Electrode
				frmMainMenu.Electrode(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Electrode
				frmMainMenu.Electrode(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Electrode
				frmMainMenu.Electrode(7) = 1
			End If
		End If

		If pokemon = "Kangaskhan" Then

			If frmMainMenu.Kangaskhan(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Kangaskhan
				frmMainMenu.Kangaskhan(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Kangaskhan
				frmMainMenu.Kangaskhan(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Kangaskhan
				frmMainMenu.Kangaskhan(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Kangaskhan
				frmMainMenu.Kangaskhan(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Kangaskhan
				frmMainMenu.Kangaskhan(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Kangaskhan
				frmMainMenu.Kangaskhan(7) = 1
			End If
		End If
		If pokemon = "Electabuzz" Then

			If frmMainMenu.Electabuzz(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Electabuzz
				frmMainMenu.Electabuzz(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Electabuzz
				frmMainMenu.Electabuzz(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Electabuzz
				frmMainMenu.Electabuzz(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Electabuzz
				frmMainMenu.Electabuzz(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Electabuzz
				frmMainMenu.Electabuzz(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Electabuzz
				frmMainMenu.Electabuzz(7) = 1
			End If
		End If
		If pokemon = "Magmar" Then

			If frmMainMenu.Magmar(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Magmar
				frmMainMenu.Magmar(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Magmar
				frmMainMenu.Magmar(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Magmar
				frmMainMenu.Magmar(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Magmar
				frmMainMenu.Magmar(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Magmar
				frmMainMenu.Magmar(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Magmar
				frmMainMenu.Magmar(7) = 1
			End If
		End If
		If pokemon = "Tauros" Then

			If frmMainMenu.Tauros(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Tauros
				frmMainMenu.Tauros(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Tauros
				frmMainMenu.Tauros(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Tauros
				frmMainMenu.Tauros(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Tauros
				frmMainMenu.Tauros(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Tauros
				frmMainMenu.Tauros(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Tauros
				frmMainMenu.Tauros(7) = 1
			End If
		End If
		If pokemon = "Magikarp" Then

			If frmMainMenu.Magikarp(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Magikarp
				frmMainMenu.Magikarp(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Magikarp
				frmMainMenu.Magikarp(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Magikarp
				frmMainMenu.Magikarp(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Magikarp
				frmMainMenu.Magikarp(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Magikarp
				frmMainMenu.Magikarp(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Magikarp
				frmMainMenu.Magikarp(7) = 1
			End If
		End If
		If pokemon = "Lapras" Then

			If frmMainMenu.Lapras(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Lapras
				frmMainMenu.Lapras(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Lapras
				frmMainMenu.Lapras(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Lapras
				frmMainMenu.Lapras(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Lapras
				frmMainMenu.Lapras(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Lapras
				frmMainMenu.Lapras(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Lapras
				frmMainMenu.Lapras(7) = 1
			End If
		End If
		If pokemon = "Eevee" Then

			If frmMainMenu.Eevee(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Eevee
				frmMainMenu.Eevee(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Eevee
				frmMainMenu.Eevee(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Eevee
				frmMainMenu.Eevee(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Eevee
				frmMainMenu.Eevee(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Eevee
				frmMainMenu.Eevee(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Eevee
				frmMainMenu.Eevee(7) = 1
			End If
		End If
		If pokemon = "Vaporeon" Then

			If frmMainMenu.Vaporeon(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Vaporeon
				frmMainMenu.Vaporeon(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Vaporeon
				frmMainMenu.Vaporeon(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Vaporeon
				frmMainMenu.Vaporeon(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Vaporeon
				frmMainMenu.Vaporeon(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Vaporeon
				frmMainMenu.Vaporeon(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Vaporeon
				frmMainMenu.Vaporeon(7) = 1
			End If
		End If
		If pokemon = "Jolteon" Then

			If frmMainMenu.Jolteon(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Jolteon
				frmMainMenu.Jolteon(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Jolteon
				frmMainMenu.Jolteon(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Jolteon
				frmMainMenu.Jolteon(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Jolteon
				frmMainMenu.Jolteon(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Jolteon
				frmMainMenu.Jolteon(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Jolteon
				frmMainMenu.Jolteon(7) = 1
			End If
		End If
		If pokemon = "Flareon" Then

			If frmMainMenu.Flareon(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Flareon
				frmMainMenu.Flareon(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Flareon
				frmMainMenu.Flareon(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Flareon
				frmMainMenu.Flareon(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Flareon
				frmMainMenu.Flareon(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Flareon
				frmMainMenu.Flareon(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Flareon
				frmMainMenu.Flareon(7) = 1
			End If
		End If
	End Function

	Private Sub btnVoltorb_Click(sender As Object, e As EventArgs) Handles btnVoltorb.Click
		switch("Voltorb")
	End Sub

	Private Sub btnElectrode_Click(sender As Object, e As EventArgs) Handles btnElectrode.Click
		switch("Electrode")
	End Sub

	Private Sub btnKangaskhan_Click(sender As Object, e As EventArgs) Handles btnKangaskhan.Click
		switch("Kangaskhan")
	End Sub

	Private Sub btnElectabuzz_Click(sender As Object, e As EventArgs) Handles btnElectabuzz.Click
		switch("Electabuzz")
	End Sub

	Private Sub btnMagmar_click(sender As Object, e As EventArgs) Handles btnMagmar.Click
		switch("Magmar")
	End Sub

	Private Sub btnTauros_Click(sender As Object, e As EventArgs) Handles btnTauros.Click
		switch("Tauros")
	End Sub

	Private Sub btnMagikarp_Click(sender As Object, e As EventArgs) Handles btnMagikarp.Click
		switch("Magikarp")
	End Sub

	Private Sub btnLapras_Click(sender As Object, e As EventArgs) Handles btnLapras.Click
		switch("Lapras")
	End Sub

	Private Sub btnEevee_Click(sender As Object, e As EventArgs) Handles btnEevee.Click
		switch("Eevee")
	End Sub

	Private Sub btnVaporeon_Click(sender As Object, e As EventArgs) Handles btnVaporeon.Click
		switch("Vaporeon")
	End Sub

	Private Sub btnJolteon_Click(sender As Object, e As EventArgs) Handles btnJolteon.Click
		switch("Jolteon")
	End Sub

	Private Sub btnFlareon_Click(sender As Object, e As EventArgs) Handles btnFlareon.Click
		switch("Flareon")
	End Sub

	Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
		frmBox6.Show()
		Me.Close()
	End Sub

	Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
		frmBox8.Show()
		Me.Close()
	End Sub
End Class