Public Class frmBox2

	Private Sub frmBox2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		If frmMainMenu.Rattata(6) = 1 Then
			btnRattata.Enabled = True
		End If

		If frmMainMenu.Raticate(6) = 1 Then
			btnRaticate.Enabled = True
		End If

		If frmMainMenu.Spearow(6) = 1 Then
			btnSpearow.Enabled = True
		End If

		If frmMainMenu.Fearow(6) = 1 Then
			btnFearow.Enabled = True
		End If

		If frmMainMenu.Ekans(6) = 1 Then
			btnEkans.Enabled = True
		End If

		If frmMainMenu.Arbok(6) = 1 Then
			btnArbok.Enabled = True
		End If

		If frmMainMenu.Pikachu(6) = 1 Then
			btnPikachu.Enabled = True
		End If

		If frmMainMenu.Raichu(6) = 1 Then
			btnRaichu.Enabled = True
		End If

		If frmMainMenu.Nidoranf(6) = 1 Then
			btnNidoranf.Enabled = True
		End If

		If frmMainMenu.Nidorina(6) = 1 Then
			btnNidorina.Enabled = True
		End If

		If frmMainMenu.Nidoqueen(6) = 1 Then
			btnNidoqueen.Enabled = True
		End If

		If frmMainMenu.Nidoranm(6) = 1 Then
			btnNidoranm.Enabled = True
		End If

	End Sub

	Function switch(ByVal pokemon As String)

		Dim slot As Integer

		If pokemon = "Rattata" Then

			If frmMainMenu.Rattata(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Rattata
				frmMainMenu.Rattata(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Rattata
				frmMainMenu.Rattata(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Rattata
				frmMainMenu.Rattata(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Rattata
				frmMainMenu.Rattata(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Rattata
				frmMainMenu.Rattata(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Rattata
				frmMainMenu.Rattata(7) = 1
			End If
		End If

		If pokemon = "Raticate" Then

			If frmMainMenu.Raticate(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Raticate
				frmMainMenu.Raticate(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Raticate
				frmMainMenu.Raticate(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Raticate
				frmMainMenu.Raticate(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Raticate
				frmMainMenu.Raticate(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Raticate
				frmMainMenu.Raticate(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Raticate
				frmMainMenu.Raticate(7) = 1
			End If
		End If

		If pokemon = "Spearow" Then

			If frmMainMenu.Spearow(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Spearow
				frmMainMenu.Spearow(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Spearow
				frmMainMenu.Spearow(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Spearow
				frmMainMenu.Spearow(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Spearow
				frmMainMenu.Spearow(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Spearow
				frmMainMenu.Spearow(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Spearow
				frmMainMenu.Spearow(7) = 1
			End If
		End If
		If pokemon = "Fearow" Then

			If frmMainMenu.Fearow(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Fearow
				frmMainMenu.Fearow(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Fearow
				frmMainMenu.Fearow(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Fearow
				frmMainMenu.Fearow(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Fearow
				frmMainMenu.Fearow(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Fearow
				frmMainMenu.Fearow(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Fearow
				frmMainMenu.Fearow(7) = 1
			End If
		End If
		If pokemon = "Ekans" Then

			If frmMainMenu.Ekans(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Ekans
				frmMainMenu.Ekans(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Ekans
				frmMainMenu.Ekans(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Ekans
				frmMainMenu.Ekans(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Ekans
				frmMainMenu.Ekans(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Ekans
				frmMainMenu.Ekans(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Ekans
				frmMainMenu.Ekans(7) = 1
			End If
		End If
		If pokemon = "Arbok" Then

			If frmMainMenu.Arbok(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Arbok
				frmMainMenu.Arbok(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Arbok
				frmMainMenu.Arbok(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Arbok
				frmMainMenu.Arbok(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Arbok
				frmMainMenu.Arbok(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Arbok
				frmMainMenu.Arbok(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Arbok
				frmMainMenu.Arbok(7) = 1
			End If
		End If
		If pokemon = "Pikachu" Then

			If frmMainMenu.Pikachu(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Pikachu
				frmMainMenu.Pikachu(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Pikachu
				frmMainMenu.Pikachu(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Pikachu
				frmMainMenu.Pikachu(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Pikachu
				frmMainMenu.Pikachu(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Pikachu
				frmMainMenu.Pikachu(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Pikachu
				frmMainMenu.Pikachu(7) = 1
			End If
		End If
		If pokemon = "Raichu" Then

			If frmMainMenu.Raichu(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Raichu
				frmMainMenu.Raichu(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Raichu
				frmMainMenu.Raichu(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Raichu
				frmMainMenu.Raichu(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Raichu
				frmMainMenu.Raichu(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Raichu
				frmMainMenu.Raichu(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Raichu
				frmMainMenu.Raichu(7) = 1
			End If
		End If
		If pokemon = "Nidoranf" Then

			If frmMainMenu.Nidoranf(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Nidoranf
				frmMainMenu.Nidoranf(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Nidoranf
				frmMainMenu.Nidoranf(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Nidoranf
				frmMainMenu.Nidoranf(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Nidoranf
				frmMainMenu.Nidoranf(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Nidoranf
				frmMainMenu.Nidoranf(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Nidoranf
				frmMainMenu.Nidoranf(7) = 1
			End If
		End If
		If pokemon = "Nidorina" Then

			If frmMainMenu.Nidorina(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Nidorina
				frmMainMenu.Nidorina(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Nidorina
				frmMainMenu.Nidorina(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Nidorina
				frmMainMenu.Nidorina(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Nidorina
				frmMainMenu.Nidorina(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Nidorina
				frmMainMenu.Nidorina(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Nidorina
				frmMainMenu.Nidorina(7) = 1
			End If
		End If
		If pokemon = "Nidoqueen" Then

			If frmMainMenu.Nidoqueen(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Nidoqueen
				frmMainMenu.Nidoqueen(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Nidoqueen
				frmMainMenu.Nidoqueen(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Nidoqueen
				frmMainMenu.Nidoqueen(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Nidoqueen
				frmMainMenu.Nidoqueen(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Nidoqueen
				frmMainMenu.Nidoqueen(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Nidoqueen
				frmMainMenu.Nidoqueen(7) = 1
			End If
		End If
		If pokemon = "Nidoranm" Then

			If frmMainMenu.Nidoranm(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Nidoranm
				frmMainMenu.Nidoranm(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Nidoranm
				frmMainMenu.Nidoranm(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Nidoranm
				frmMainMenu.Nidoranm(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Nidoranm
				frmMainMenu.Nidoranm(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Nidoranm
				frmMainMenu.Nidoranm(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Nidoranm
				frmMainMenu.Nidoranm(7) = 1
			End If
		End If
	End Function

	Private Sub btnRattata_Click(sender As Object, e As EventArgs) Handles btnRattata.Click
		switch("Rattata")
	End Sub

	Private Sub btnRaticate_Click(sender As Object, e As EventArgs) Handles btnRaticate.Click
		switch("Raticate")
	End Sub

	Private Sub btnSpearow_Click(sender As Object, e As EventArgs) Handles btnSpearow.Click
		switch("Spearow")
	End Sub

	Private Sub btnFearow_Click(sender As Object, e As EventArgs) Handles btnFearow.Click
		switch("Fearow")
	End Sub

	Private Sub btnEkans_click(sender As Object, e As EventArgs) Handles btnEkans.Click
		switch("Ekans")
	End Sub

	Private Sub btnArbok_Click(sender As Object, e As EventArgs) Handles btnArbok.Click
		switch("Arbok")
	End Sub

	Private Sub btnPikachu_Click(sender As Object, e As EventArgs) Handles btnPikachu.Click
		switch("Pikachu")
	End Sub

	Private Sub btnRaichu_Click(sender As Object, e As EventArgs) Handles btnRaichu.Click
		switch("Raichu")
	End Sub

	Private Sub btnNidoranf_Click(sender As Object, e As EventArgs) Handles btnNidoranf.Click
		switch("Nidoranf")
	End Sub

	Private Sub btnNidorina_Click(sender As Object, e As EventArgs) Handles btnNidorina.Click
		switch("Nidorina")
	End Sub

	Private Sub btnNidoqueen_Click(sender As Object, e As EventArgs) Handles btnNidoqueen.Click
		switch("Nidoqueen")
	End Sub

	Private Sub btnNidoranm_Click(sender As Object, e As EventArgs) Handles btnNidoranm.Click
		switch("Nidoranm")
	End Sub

	Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
		frmBox.Show()
		Me.Close()
	End Sub

	Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
		frmBox3.Show()
		Me.Close()
	End Sub
End Class