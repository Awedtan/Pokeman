Public Class frmInBattle

	Function catchp(ByVal ran As Integer) As Boolean

		If enemypokemon1inbattle(1) > (frmBattleSelect.enemypokemon1(1) / 2) Then

			If ran = 2 Then

				catchp = True

			Else

				catchp = False

			End If

		ElseIf enemypokemon1inbattle(1) > ((frmBattleSelect.enemypokemon1(1) / 2) / 2) Then

			If ran < 5 Then

				catchp = True

			Else

				catchp = False

			End If

		Else
			If ran < 17 Then

				catchp = True

			Else

				catchp = False

			End If
		End If
	End Function

	Dim yourpokemon() As String

	Dim enemypokemon1inbattle(14) As String
	Dim enemypokemon2inbattle(14) As String
	Dim enemypokemon3inbattle(14) As String
	Dim enemypokemon4inbattle(14) As String
	Dim enemypokemon5inbattle(14) As String
	Dim enemypokemon6inbattle(14) As String

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMove1.Click
		Select Case yourpokemon(1)
			Case 45
				Label1.Text = "1"
			Case 49
				Label1.Text = "0"

		End Select
	End Sub

	Private Sub btnPokeball_Click(sender As Object, e As EventArgs) Handles btnPokeball.Click

		'enemypokemon1inbattle(0) = "Rattata"

		'frmBattleSelect.enemypokemon1(1) = 100
		'enemypokemon1inbattle(1) = 100

		Dim num As Integer

		Randomize()

		num = Int(20 * Rnd(1))

		Select Case enemypokemon1inbattle(0)
			Case "Rattata"

				If catchp(num) Then

					frmMainMenu.Rattata(6) = 1

				End If

			Case "Spearow"

				If catchp(num) Then

					frmMainMenu.Spearow(6) = 1

				End If

			Case "Pidgey"

				If catchp(num) Then

					frmMainMenu.Pidgey(6) = 1

				End If

			Case "Weedle"

				If catchp(num) Then

					frmMainMenu.Weedle(6) = 1

				End If

			Case "Caterpie"

				If catchp(num) Then

					frmMainMenu.Caterpie(6) = 1

				End If

			Case "Eevee"

				If catchp(num) Then

					frmMainMenu.Eevee(6) = 1

				End If

			Case "Bellspout"

				If catchp(num) Then

					frmMainMenu.Bellsprout(6) = 1

				End If

			Case "Oddish"

				If catchp(num) Then

					frmMainMenu.Oddish(6) = 1

				End If

			Case "Vulpix"

				If catchp(num) Then

					frmMainMenu.Vulpix(6) = 1

				End If

			Case "Nidoran (male)"

				If catchp(num) Then

					frmMainMenu.Nidoranm(6) = 1

				End If

			Case "Nidoran (female)"

				If catchp(num) Then

					frmMainMenu.Nidoranf(6) = 1

				End If

			Case "Metapod"

				If catchp(num) Then

					frmMainMenu.Metapod(6) = 1

				End If

			Case "Butterfree"

				If catchp(num) Then

					frmMainMenu.Butterfree(6) = 1

				End If

			Case "Kakuna"

				If catchp(num) Then

					frmMainMenu.Kakuna(6) = 1

				End If

			Case "Beedrill"

				If catchp(num) Then

					frmMainMenu.Beedrill(6) = 1

				End If

			Case "Pidgeotto"

				If catchp(num) Then

					frmMainMenu.Pidgeotto(6) = 1

				End If

			Case "Nidorino"

				If catchp(num) Then

					frmMainMenu.Nidorino(6) = 1

				End If

			Case "Nidorina"

				If catchp(num) Then

					frmMainMenu.Nidorina(6) = 1

				End If

			Case "Raticate"

				If catchp(num) Then

					frmMainMenu.Raticate(6) = 1

				End If

			Case "Ekans"

				If catchp(num) Then

					frmMainMenu.Ekans(6) = 1

				End If

			Case "Pikachu"

				If catchp(num) Then

					frmMainMenu.Pikachu(6) = 1

				End If

			Case "Raichu"

				If catchp(num) Then

					frmMainMenu.Raichu(6) = 1

				End If

			Case "Diglett"

				If catchp(num) Then

					frmMainMenu.Diglett(6) = 1

				End If

			Case "Meowth"

				If catchp(num) Then

					frmMainMenu.Meowth(6) = 1

				End If

			Case "Magnemite"

				If catchp(num) Then

					frmMainMenu.Magnemite(6) = 1

				End If

			Case "Voltorb"

				If catchp(num) Then

					frmMainMenu.Voltorb(6) = 1

				End If

			Case "Gloom"

				If catchp(num) Then

					frmMainMenu.Gloom(6) = 1

				End If

			Case "Paras"

				If catchp(num) Then

					frmMainMenu.Paras(6) = 1

				End If

			Case "Parasect"

				If catchp(num) Then

					frmMainMenu.Parasect(6) = 1

				End If

			Case "Venonat"

				If catchp(num) Then

					frmMainMenu.Venonat(6) = 1

				End If

			Case "Magneton"

				If catchp(num) Then

					frmMainMenu.Magneton(6) = 1

				End If

			Case "Electrode"

				If catchp(num) Then

					frmMainMenu.Electrode(6) = 1

				End If

			Case "Gastly"

				If catchp(num) Then

					frmMainMenu.Gastly(6) = 1

				End If

			Case "Electabuzz"

				If catchp(num) Then

					frmMainMenu.Electabuzz(6) = 1

				End If

			Case "Jolteon"

				If catchp(num) Then

					frmMainMenu.Jolteon(6) = 1

				End If

			Case "Ponyta"

				If catchp(num) Then

					frmMainMenu.Ponyta(6) = 1

				End If

			Case "Pidgeot"

				If catchp(num) Then

					frmMainMenu.Pidgeot(6) = 1

				End If

			Case "Fearow"

				If catchp(num) Then

					frmMainMenu.Fearow(6) = 1

				End If

			Case "Growlithe"

				If catchp(num) Then

					frmMainMenu.Growlithe(6) = 1

				End If

			Case "Arcanine"

				If catchp(num) Then

					frmMainMenu.Arcanine(6) = 1

				End If

			Case "Farfetch'd"

				If catchp(num) Then

					frmMainMenu.Farfetchd(6) = 1

				End If

			Case "Rapidash"

				If catchp(num) Then

					frmMainMenu.Rapidash(6) = 1

				End If

			Case "Ninetales"

				If catchp(num) Then

					frmMainMenu.Ninetales(6) = 1

				End If

			Case "Magmar"

				If catchp(num) Then

					frmMainMenu.Magmar(6) = 1

				End If

			Case "Flareon"

				If catchp(num) Then

					frmMainMenu.Flareon(6) = 1

				End If

			Case "Vileplume"

				If catchp(num) Then

					frmMainMenu.Vileplume(6) = 1

				End If

			Case "Poliwag"

				If catchp(num) Then

					frmMainMenu.Poliwag(6) = 1

				End If

			Case "Poliwhirl"

				If catchp(num) Then

					frmMainMenu.Poliwhirl(6) = 1

				End If

			Case "Seel"

				If catchp(num) Then

					frmMainMenu.Seel(6) = 1

				End If

			Case "Shellder"

				If catchp(num) Then

					frmMainMenu.Shellder(6) = 1

				End If

			Case "Krabby"

				If catchp(num) Then

					frmMainMenu.Krabby(6) = 1

				End If

			Case "Magikarp"

				If catchp(num) Then

					frmMainMenu.Magikarp(6) = 1

				End If

			Case "Poliwrath"

				If catchp(num) Then

					frmMainMenu.Poliwrath(6) = 1

				End If

			Case "Dewgong"

				If catchp(num) Then

					frmMainMenu.Dewgong(6) = 1

				End If

			Case "Kingler"

				If catchp(num) Then

					frmMainMenu.Kingler(6) = 1

				End If

			Case "Lapras"

				If catchp(num) Then

					frmMainMenu.Lapras(6) = 1

				End If

			Case "Vaporeon"

				If catchp(num) Then

					frmMainMenu.Vaporeon(6) = 1

				End If

			Case "Arbok"

				If catchp(num) Then

					frmMainMenu.Arbok(6) = 1

				End If

			Case "Clefairy"

				If catchp(num) Then

					frmMainMenu.Clefairy(6) = 1

				End If

			Case "Clefable"

				If catchp(num) Then

					frmMainMenu.Clefable(6) = 1

				End If

			Case "Jigglypuff"

				If catchp(num) Then

					frmMainMenu.Jigglypuff(6) = 1

				End If

			Case "Wigglytuff"

				If catchp(num) Then

					frmMainMenu.Wigglytuff(6) = 1

				End If

			Case "Venomoth"

				If catchp(num) Then

					frmMainMenu.Venomoth(6) = 1

				End If

			Case "Abra"

				If catchp(num) Then

					frmMainMenu.Abra(6) = 1

				End If

			Case "Kadabra"

				If catchp(num) Then

					frmMainMenu.Kadabra(6) = 1

				End If

			Case "Doduo"

				If catchp(num) Then

					frmMainMenu.Doduo(6) = 1

				End If

			Case "Dodrio"

				If catchp(num) Then

					frmMainMenu.Dodrio(6) = 1

				End If

			Case "Tauros"

				If catchp(num) Then

					frmMainMenu.Tauros(6) = 1

				End If

			Case "Moltres"

				If catchp(num) Then

					frmMainMenu.Moltres(6) = 1

				End If

			Case "Zapdos"

				If catchp(num) Then

					frmMainMenu.Zapdos(6) = 1

				End If

			Case "Articuno"

				If catchp(num) Then

					frmMainMenu.Articuno(6) = 1

				End If

			Case "Psyduck"

				If catchp(num) Then

					frmMainMenu.Psyduck(6) = 1

				End If

			Case "Golduck"

				If catchp(num) Then

					frmMainMenu.Golduck(6) = 1

				End If

			Case "Machoke"

				If catchp(num) Then

					frmMainMenu.Machoke(6) = 1

				End If

			Case "Machop"

				If catchp(num) Then

					frmMainMenu.Machop(6) = 1

				End If

			Case "Hypno"

				If catchp(num) Then

					frmMainMenu.Hypno(6) = 1

				End If

			Case "Snorlax"

				If catchp(num) Then

					frmMainMenu.Snorlax(6) = 1

				End If

			Case "Dragonair"

				If catchp(num) Then

					frmMainMenu.Dragonair(6) = 1

				End If

			Case "Dragonite"

				If catchp(num) Then

					frmMainMenu.Dragonite(6) = 1

				End If

			Case "Alakazam"

				If catchp(num) Then

					frmMainMenu.Alakazam(6) = 1

				End If

			Case "Golem"

				If catchp(num) Then

					frmMainMenu.Golem(6) = 1

				End If

			Case "Onix"

				If catchp(num) Then

					frmMainMenu.Onix(6) = 1

				End If

			Case "Kangaskhan"

				If catchp(num) Then

					frmMainMenu.Kangaskhan(6) = 1

				End If

			Case "Machamp"

				If catchp(num) Then

					frmMainMenu.Machamp(6) = 1

				End If

		End Select

	End Sub
End Class
