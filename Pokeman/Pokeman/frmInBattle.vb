﻿Public Class frmInBattle
	Dim yourpokemon() As String

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMove1.Click
        Select Case yourpokemon(1)
            Case 45
                Label1.Text = "1"
            Case 49
                Label1.Text = "0"

        End Select
    End Sub

	Private Sub btnPokeball_Click(sender As Object, e As EventArgs) Handles btnPokeball.Click

		Select Case frmBattleSelect.enemypokemon1(0)
			Case "Rattata"
			Case "Spearow"
			Case "Pidgey"
			Case "Weedle"
			Case "Caterpie"
			Case "Eevee"
			Case "Bellspout"
			Case "Oddish"
			Case "Vulpix"
			Case "Nidoran (male)"
			Case "Nidoran (female)"
			Case "Metapod"
			Case "Butterfree"
			Case "Kakuna"
			Case "Beedrill"
			Case "Pidgeotto"
			Case "Nidorino"
			Case "Nidorina"
			Case "Raticate"
			Case "Ekans"
			Case "Pikachu"
			Case "Raichu"
			Case "Diglett"
			Case "Meowth"
			Case "Magnemite"
			Case "Voltorb"
			Case "Gloom"
			Case "Paras"
			Case "Parasect"
			Case "Venonat"
			Case "Magneton"
			Case "Electrode"
			Case "Gastly"
			Case "Electabuzz"
			Case "Jolteon"
			Case "Ponyta"
			Case "Pidgeot"
			Case "Fearow"
			Case "Growlithe"
			Case "Arcanine"
			Case "Farfetch'd"
			Case "Rapidash"
			Case "Ninetales"
			Case "Magmar"
			Case "Flareon"
			Case "Vileplume"
			Case "Poliwag"
			Case "Poliwhirl"
			Case "Seel"
			Case "Shellder"
			Case "Krabby"
			Case "Magikarp"
			Case "Poliwrath"
			Case "Dewgong"
			Case "Kingler"
			Case "Lapras"
			Case "Vaporeon"
		End Select

	End Sub
End Class