Public Class frmBox6

	Private Sub frmBox2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		If frmMainMenu.Farfetchd(6) = 1 Then
			btnFarfetchd.Enabled = True
		End If

		If frmMainMenu.Doduo(6) = 1 Then
			btnDoduo.Enabled = True
		End If

		If frmMainMenu.Dodrio(6) = 1 Then
			btnDodrio.Enabled = True
		End If

		If frmMainMenu.Seel(6) = 1 Then
			btnSeel.Enabled = True
		End If

		If frmMainMenu.Dewgong(6) = 1 Then
			btnDewgong.Enabled = True
		End If

		If frmMainMenu.Grimer(6) = 1 Then
			btnGrimer.Enabled = True
		End If

		If frmMainMenu.Muk(6) = 1 Then
			btnMuk.Enabled = True
		End If

		If frmMainMenu.Gastly(6) = 1 Then
			btnGastly.Enabled = True
		End If

		If frmMainMenu.Onix(6) = 1 Then
			btnOnix.Enabled = True
		End If

		If frmMainMenu.Hypno(6) = 1 Then
			btnHypno.Enabled = True
		End If

		If frmMainMenu.Krabby(6) = 1 Then
			btnKrabby.Enabled = True
		End If

		If frmMainMenu.Kingler(6) = 1 Then
			btnKingler.Enabled = True
		End If

	End Sub

	Function switch(ByVal pokemon As String)

		Dim slot As Integer

		If pokemon = "Farfetchd" Then

			If frmMainMenu.Farfetchd(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Farfetchd
				frmMainMenu.Farfetchd(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Farfetchd
				frmMainMenu.Farfetchd(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Farfetchd
				frmMainMenu.Farfetchd(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Farfetchd
				frmMainMenu.Farfetchd(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Farfetchd
				frmMainMenu.Farfetchd(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Farfetchd
				frmMainMenu.Farfetchd(7) = 1
			End If
		End If

		If pokemon = "Doduo" Then

			If frmMainMenu.Doduo(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Doduo
				frmMainMenu.Doduo(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Doduo
				frmMainMenu.Doduo(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Doduo
				frmMainMenu.Doduo(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Doduo
				frmMainMenu.Doduo(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Doduo
				frmMainMenu.Doduo(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Doduo
				frmMainMenu.Doduo(7) = 1
			End If
		End If

		If pokemon = "Dodrio" Then

			If frmMainMenu.Dodrio(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Dodrio
				frmMainMenu.Dodrio(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Dodrio
				frmMainMenu.Dodrio(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Dodrio
				frmMainMenu.Dodrio(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Dodrio
				frmMainMenu.Dodrio(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Dodrio
				frmMainMenu.Dodrio(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Dodrio
				frmMainMenu.Dodrio(7) = 1
			End If
		End If
		If pokemon = "Seel" Then

			If frmMainMenu.Seel(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Seel
				frmMainMenu.Seel(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Seel
				frmMainMenu.Seel(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Seel
				frmMainMenu.Seel(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Seel
				frmMainMenu.Seel(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Seel
				frmMainMenu.Seel(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Seel
				frmMainMenu.Seel(7) = 1
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
		If pokemon = "Grimer" Then

			If frmMainMenu.Grimer(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Grimer
				frmMainMenu.Grimer(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Grimer
				frmMainMenu.Grimer(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Grimer
				frmMainMenu.Grimer(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Grimer
				frmMainMenu.Grimer(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Grimer
				frmMainMenu.Grimer(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Grimer
				frmMainMenu.Grimer(7) = 1
			End If
		End If
		If pokemon = "Muk" Then

			If frmMainMenu.Muk(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Muk
				frmMainMenu.Muk(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Muk
				frmMainMenu.Muk(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Muk
				frmMainMenu.Muk(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Muk
				frmMainMenu.Muk(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Muk
				frmMainMenu.Muk(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Muk
				frmMainMenu.Muk(7) = 1
			End If
		End If
		If pokemon = "Gastly" Then

			If frmMainMenu.Gastly(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Gastly
				frmMainMenu.Gastly(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Gastly
				frmMainMenu.Gastly(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Gastly
				frmMainMenu.Gastly(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Gastly
				frmMainMenu.Gastly(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Gastly
				frmMainMenu.Gastly(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Gastly
				frmMainMenu.Gastly(7) = 1
			End If
		End If
		If pokemon = "Onix" Then

			If frmMainMenu.Onix(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Onix
				frmMainMenu.Onix(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Onix
				frmMainMenu.Onix(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Onix
				frmMainMenu.Onix(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Onix
				frmMainMenu.Onix(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Onix
				frmMainMenu.Onix(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Onix
				frmMainMenu.Onix(7) = 1
			End If
		End If
		If pokemon = "Hypno" Then

			If frmMainMenu.Hypno(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Hypno
				frmMainMenu.Hypno(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Hypno
				frmMainMenu.Hypno(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Hypno
				frmMainMenu.Hypno(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Hypno
				frmMainMenu.Hypno(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Hypno
				frmMainMenu.Hypno(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Hypno
				frmMainMenu.Hypno(7) = 1
			End If
		End If
		If pokemon = "Krabby" Then

			If frmMainMenu.Krabby(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Krabby
				frmMainMenu.Krabby(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Krabby
				frmMainMenu.Krabby(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Krabby
				frmMainMenu.Krabby(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Krabby
				frmMainMenu.Krabby(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Krabby
				frmMainMenu.Krabby(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Krabby
				frmMainMenu.Krabby(7) = 1
			End If
		End If
		If pokemon = "Kingler" Then

			If frmMainMenu.Kingler(7) = 0 Then
				slot = Val(InputBox("Which slot from 1 to 6 would you like to put this pokeman in? (0 to cancel)", "Confirm Selection"))
			End If

			If slot = 1 Then

				frmMainMenu.yourpokemon1 = frmMainMenu.Kingler
				frmMainMenu.Kingler(7) = 1
			ElseIf slot = 2 Then

				frmMainMenu.yourpokemon2 = frmMainMenu.Kingler
				frmMainMenu.Kingler(7) = 1
			ElseIf slot = 3 Then

				frmMainMenu.yourpokemon3 = frmMainMenu.Kingler
				frmMainMenu.Kingler(7) = 1
			ElseIf slot = 4 Then

				frmMainMenu.yourpokemon4 = frmMainMenu.Kingler
				frmMainMenu.Kingler(7) = 1
			ElseIf slot = 5 Then

				frmMainMenu.yourpokemon5 = frmMainMenu.Kingler
				frmMainMenu.Kingler(7) = 1
			ElseIf slot = 6 Then

				frmMainMenu.yourpokemon6 = frmMainMenu.Kingler
				frmMainMenu.Kingler(7) = 1
			End If
		End If
	End Function

	Private Sub btnFarfetchd_Click(sender As Object, e As EventArgs) Handles btnFarfetchd.Click
		switch("Farfetchd")
	End Sub

	Private Sub btnDoduo_Click(sender As Object, e As EventArgs) Handles btnDoduo.Click
		switch("Doduo")
	End Sub

	Private Sub btnDodrio_Click(sender As Object, e As EventArgs) Handles btnDodrio.Click
		switch("Dodrio")
	End Sub

	Private Sub btnSeel_Click(sender As Object, e As EventArgs) Handles btnSeel.Click
		switch("Seel")
	End Sub

	Private Sub btnMetapod_click(sender As Object, e As EventArgs) Handles btnDewgong.Click
		switch("Metapod")
	End Sub

	Private Sub btnGrimer_Click(sender As Object, e As EventArgs) Handles btnGrimer.Click
		switch("Grimer")
	End Sub

	Private Sub btnMuk_Click(sender As Object, e As EventArgs) Handles btnMuk.Click
		switch("Muk")
	End Sub

	Private Sub btnGastly_Click(sender As Object, e As EventArgs) Handles btnGastly.Click
		switch("Gastly")
	End Sub

	Private Sub btnOnix_Click(sender As Object, e As EventArgs) Handles btnOnix.Click
		switch("Onix")
	End Sub

	Private Sub btnHypno_Click(sender As Object, e As EventArgs) Handles btnHypno.Click
		switch("Hypno")
	End Sub

	Private Sub btnKrabby_Click(sender As Object, e As EventArgs) Handles btnKrabby.Click
		switch("Krabby")
	End Sub

	Private Sub btnKingler_Click(sender As Object, e As EventArgs) Handles btnKingler.Click
		switch("Kingler")
	End Sub

	Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
		frmBox5.Show()
		Me.Close()
	End Sub

	Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
		frmBox7.Show()
		Me.Close()
	End Sub
End Class