Public Class frmBox3

	Private Sub frmBox2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		If frmMainMenu.Nidorino(6) = 1 Then
			btnNidorino.Enabled = True
		End If

		If frmMainMenu.Nidoking(6) = 1 Then
			btnNidoking.Enabled = True
		End If

		If frmMainMenu.Clefairy(6) = 1 Then
			btnClefairy.Enabled = True
		End If

		If frmMainMenu.Clefable(6) = 1 Then
			btnClefable.Enabled = True
		End If

		If frmMainMenu.Vulpix(6) = 1 Then
			btnVulpix.Enabled = True
		End If

		If frmMainMenu.Ninetales(6) = 1 Then
			btnNinetales.Enabled = True
		End If

		If frmMainMenu.Jigglypuff(6) = 1 Then
			btnJigglypuff.Enabled = True
		End If

		If frmMainMenu.Wigglytuff(6) = 1 Then
			btnWigglytuff.Enabled = True
		End If

		If frmMainMenu.Oddish(6) = 1 Then
			btnOddish.Enabled = True
		End If

		If frmMainMenu.Gloom(6) = 1 Then
			btnGloom.Enabled = True
		End If

		If frmMainMenu.Vileplume(6) = 1 Then
			btnVileplume.Enabled = True
		End If

		If frmMainMenu.Paras(6) = 1 Then
			btnParas.Enabled = True
		End If

	End Sub

	Function switch(ByVal pokemon As String)

		Dim slot As Integer

		If pokemon = "Nidorino" Then

			If frmMainMenu.Nidorino(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Nidorino
				frmMainMenu.Nidorino(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Nidorino
				frmMainMenu.Nidorino(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Nidorino
				frmMainMenu.Nidorino(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Nidorino
				frmMainMenu.Nidorino(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Nidorino
				frmMainMenu.Nidorino(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Nidorino
				frmMainMenu.Nidorino(7) = 1
			End If
		End If

		If pokemon = "Nidoking" Then

			If frmMainMenu.Nidoking(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Nidoking
				frmMainMenu.Nidoking(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Nidoking
				frmMainMenu.Nidoking(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Nidoking
				frmMainMenu.Nidoking(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Nidoking
				frmMainMenu.Nidoking(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Nidoking
				frmMainMenu.Nidoking(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Nidoking
				frmMainMenu.Nidoking(7) = 1
			End If
		End If

		If pokemon = "Clefairy" Then

			If frmMainMenu.Clefairy(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Clefairy
				frmMainMenu.Clefairy(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Clefairy
				frmMainMenu.Clefairy(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Clefairy
				frmMainMenu.Clefairy(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Clefairy
				frmMainMenu.Clefairy(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Clefairy
				frmMainMenu.Clefairy(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Clefairy
				frmMainMenu.Clefairy(7) = 1
			End If
		End If
		If pokemon = "Clefable" Then

			If frmMainMenu.Clefable(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Clefable
				frmMainMenu.Clefable(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Clefable
				frmMainMenu.Clefable(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Clefable
				frmMainMenu.Clefable(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Clefable
				frmMainMenu.Clefable(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Clefable
				frmMainMenu.Clefable(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Clefable
				frmMainMenu.Clefable(7) = 1
			End If
		End If
		If pokemon = "Vulpix" Then

			If frmMainMenu.Vulpix(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Vulpix
				frmMainMenu.Vulpix(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Vulpix
				frmMainMenu.Vulpix(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Vulpix
				frmMainMenu.Vulpix(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Vulpix
				frmMainMenu.Vulpix(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Vulpix
				frmMainMenu.Vulpix(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Vulpix
				frmMainMenu.Vulpix(7) = 1
			End If
		End If
		If pokemon = "Ninetales" Then

			If frmMainMenu.Ninetales(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Ninetales
				frmMainMenu.Ninetales(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Ninetales
				frmMainMenu.Ninetales(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Ninetales
				frmMainMenu.Ninetales(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Ninetales
				frmMainMenu.Ninetales(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Ninetales
				frmMainMenu.Ninetales(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Ninetales
				frmMainMenu.Ninetales(7) = 1
			End If
		End If
		If pokemon = "Jigglypuff" Then

			If frmMainMenu.Jigglypuff(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Jigglypuff
				frmMainMenu.Jigglypuff(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Jigglypuff
				frmMainMenu.Jigglypuff(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Jigglypuff
				frmMainMenu.Jigglypuff(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Jigglypuff
				frmMainMenu.Jigglypuff(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Jigglypuff
				frmMainMenu.Jigglypuff(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Jigglypuff
				frmMainMenu.Jigglypuff(7) = 1
			End If
		End If
		If pokemon = "Wigglytuff" Then

			If frmMainMenu.Wigglytuff(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Wigglytuff
				frmMainMenu.Wigglytuff(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Wigglytuff
				frmMainMenu.Wigglytuff(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Wigglytuff
				frmMainMenu.Wigglytuff(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Wigglytuff
				frmMainMenu.Wigglytuff(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Wigglytuff
				frmMainMenu.Wigglytuff(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Wigglytuff
				frmMainMenu.Wigglytuff(7) = 1
			End If
		End If
		If pokemon = "Oddish" Then

			If frmMainMenu.Oddish(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Oddish
				frmMainMenu.Oddish(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Oddish
				frmMainMenu.Oddish(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Oddish
				frmMainMenu.Oddish(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Oddish
				frmMainMenu.Oddish(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Oddish
				frmMainMenu.Oddish(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Oddish
				frmMainMenu.Oddish(7) = 1
			End If
		End If
		If pokemon = "Gloom" Then

			If frmMainMenu.Gloom(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Gloom
				frmMainMenu.Gloom(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Gloom
				frmMainMenu.Gloom(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Gloom
				frmMainMenu.Gloom(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Gloom
				frmMainMenu.Gloom(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Gloom
				frmMainMenu.Gloom(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Gloom
				frmMainMenu.Gloom(7) = 1
			End If
		End If
		If pokemon = "Vileplume" Then

			If frmMainMenu.Vileplume(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Vileplume
				frmMainMenu.Vileplume(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Vileplume
				frmMainMenu.Vileplume(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Vileplume
				frmMainMenu.Vileplume(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Vileplume
				frmMainMenu.Vileplume(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Vileplume
				frmMainMenu.Vileplume(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Vileplume
				frmMainMenu.Vileplume(7) = 1
			End If
		End If
		If pokemon = "Paras" Then

			If frmMainMenu.Paras(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Paras
				frmMainMenu.Paras(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Paras
				frmMainMenu.Paras(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Paras
				frmMainMenu.Paras(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Paras
				frmMainMenu.Paras(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Paras
				frmMainMenu.Paras(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Paras
				frmMainMenu.Paras(7) = 1
			End If
		End If
	End Function

	Private Sub btnNidorino_Click(sender As Object, e As EventArgs) Handles btnNidorino.Click
		switch("Nidorino")
	End Sub

	Private Sub btnNidoking_Click(sender As Object, e As EventArgs) Handles btnNidoking.Click
		switch("Nidoking")
	End Sub

	Private Sub btnClefairy_Click(sender As Object, e As EventArgs) Handles btnClefairy.Click
		switch("Clefairy")
	End Sub

	Private Sub btnClefable_Click(sender As Object, e As EventArgs) Handles btnClefable.Click
		switch("Clefable")
	End Sub

	Private Sub btnVulpix_click(sender As Object, e As EventArgs) Handles btnVulpix.Click
		switch("Vulpix")
	End Sub

	Private Sub btnNinetales_Click(sender As Object, e As EventArgs) Handles btnNinetales.Click
		switch("Ninetales")
	End Sub

	Private Sub btnJigglypuff_Click(sender As Object, e As EventArgs) Handles btnJigglypuff.Click
		switch("Jigglypuff")
	End Sub

	Private Sub btnWigglytuff_Click(sender As Object, e As EventArgs) Handles btnWigglytuff.Click
		switch("Wigglytuff")
	End Sub

	Private Sub btnOddish_Click(sender As Object, e As EventArgs) Handles btnOddish.Click
		switch("Oddish")
	End Sub

	Private Sub btnGloom_Click(sender As Object, e As EventArgs) Handles btnGloom.Click
		switch("Gloom")
	End Sub

	Private Sub btnVileplume_Click(sender As Object, e As EventArgs) Handles btnVileplume.Click
		switch("Vileplume")
	End Sub

	Private Sub btnParas_Click(sender As Object, e As EventArgs) Handles btnParas.Click
		switch("Paras")
	End Sub

	Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
		frmBox2.Show()
		Me.Close()
	End Sub

	Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
		frmBox4.Show()
		Me.Close()
	End Sub
End Class