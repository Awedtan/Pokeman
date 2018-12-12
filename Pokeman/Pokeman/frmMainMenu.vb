Public Class frmMainMenu

	Dim Currency As Integer
	Dim Ballcount As Integer

	Dim ShopMenu As New frmShopMenu
	Dim Box As New frmBox
	Dim BattleSelect As New frmBattleSelect


	'Pokeman name, health, attack, defense, obtained, selected

	'Special cases:
	'Nidoran(m&f), Farfetch'd, Mr. Mime

	Public Shared Bulbasaur() As String = {"Bulbasaur", 45, 49, 49, 0, 0, 7, 12}
	Public Shared Ivysaur() As String = {"Ivysaur", 60, 62, 63, 0, 0, 7, 12}
	Public Shared Venusaur() As String = {"Venusaur", 80, 82, 83, 0, 0, 7, 12}
	Public Shared Charmander() As String = {"Charmander", 39, 52, 43, 0, 0, 5, 0}
	Public Shared Charmeleon() As String = {"Charmeleon", 58, 64, 58, 0, 0, 5, 0}
	Public Shared Charizard() As String = {"Charizard", 78, 84, 78, 0, 0, 5, 6}
	Public Shared Squirtle() As String = {"Squirtle", 44, 48, 65, 0, 0, 15, 0}
	Public Shared Wartortle() As String = {"Wartortle", 59, 63, 80, 0, 0, 15, 0}
	Public Shared Blastoise() As String = {"Blastoise", 79, 83, 100, 0, 0, 15, 0}
	Public Shared Caterpie() As String = {"Caterpie", 45, 30, 35, 0, 0, 1, 0}
	Public Shared Metapod() As String = {"Metapod", 50, 20, 55, 0, 0, 1, 0}
	Public Shared Butterfree() As String = {"Butterfree", 60, 45, 50, 0, 0, 1, 6}
	Public Shared Weedle() As String = {"Weedle", 40, 35, 30, 0, 0, 1, 12}
	Public Shared Kakuna() As String = {"Kakuna", 45, 25, 50, 0, 0, 1, 12}
	Public Shared Beedrill() As String = {"Beedrill", 35, 80, 40, 0, 0, 1, 12}
	Public Shared Pidgey() As String = {"Pidgey", 40, 45, 40, 0, 0, 11, 6}
	Public Shared Pidgeotto() As String = {"Pidgeotto", 63, 60, 55, 0, 0, 11, 6}
	Public Shared Pidgeot() As String = {"Pidgeot", 83, 80, 75, 0, 0, 11, 6}
	Public Shared Rattata() As String = {"Rattata", 30, 56, 35, 0, 0, 11, 0}
	Public Shared Raticate() As String = {"Raticate", 55, 81, 60, 0, 0, 11, 0}
	Public Shared Spearow() As String = {"Spearow", 40, 60, 30, 0, 0, 11, 6}
	Public Shared Fearow() As String = {"Fearow", 65, 90, 65, 0, 0, 11, 6}
	Public Shared Ekans() As String = {"Ekans", 35, 60, 44, 0, 0, 12, 0}
	Public Shared Arbok() As String = {"Arbok", 60, 85, 69, 0, 0, 12, 0}
	Public Shared Pikachu() As String = {"Pikachu", 35, 55, 30, 0, 0, 10, 0}
	Public Shared Raichu() As String = {"Raichu", 60, 90, 55, 0, 0, 10, 0}
	Public Shared Sandshrew() As String = {"Sandshrew", 50, 75, 85, 0, 0, 9, 0}
	Public Shared Sandslash() As String = {"Sandslash", 75, 100, 110, 0, 0, 9, 0}
	Public Shared Nidoranm() As String = {"Nidoran (female)", 55, 47, 52, 0, 0, 12, 0}
	Public Shared Nidorina() As String = {"Nidorina", 70, 62, 67, 0, 0, 12, 0}
	Public Shared Nidoqueen() As String = {"Nidoqueen", 90, 82, 87, 0, 0, 12, 9}
	Public Shared Nidoranf() As String = {"Nidoran (male)", 46, 57, 40, 0, 0, 12, 0}
	Public Shared Nidorino() As String = {"Nidorino", 61, 72, 57, 0, 0, 12, 0}
	Public Shared Nidoking() As String = {"Nidoking", 81, 92, 77, 0, 0, 12, 9}
	Public Shared Clefairy() As String = {"Clefairy", 70, 45, 48, 0, 0, 11, 0}
	Public Shared Clefable() As String = {"Clefable", 95, 70, 73, 0, 0, 11, 0}
	Public Shared Vulpix() As String = {"Vulpix", 38, 41, 40, 0, 0, 5, 0}
	Public Shared Ninetales() As String = {"Ninetales", 73, 76, 75, 0, 0, 5, 0}
	Public Shared Jigglypuff() As String = {"Jigglypuff", 115, 45, 20, 0, 0, 11, 0}
	Public Shared Wigglytuff() As String = {"Wigglytuff", 140, 70, 45, 0, 0, 11, 0}
	Public Shared Zubat() As String = {"Zubat", 40, 45, 35, 0, 0, 12, 6}
	Public Shared Golbat() As String = {"Golbat", 75, 80, 70, 0, 0, 12, 6}
	Public Shared Oddish() As String = {"Oddish", 45, 50, 55, 0, 0, 7, 12}
	Public Shared Gloom() As String = {"Gloom", 60, 65, 70, 0, 0, 7, 12}
	Public Shared Vileplume() As String = {"Vileplume", 75, 80, 85, 0, 0, 7, 12}
	Public Shared Paras() As String = {"Paras", 35, 70, 55, 0, 0, 1, 7}
	Public Shared Parasect() As String = {"Parasect", 60, 95, 80, 0, 0, 1, 7}
	Public Shared Venonat() As String = {"Venonat", 60, 55, 50, 0, 0, 1, 12}
	Public Shared Venomoth() As String = {"Venomoth", 70, 65, 60, 0, 0, 1, 12}
	Public Shared Diglett() As String = {"Diglett", 10, 55, 25, 0, 0, 9, 0}
	Public Shared Dugtrio() As String = {"Dugtrio", 35, 80, 50, 0, 0, 9, 0}
	Public Shared Meowth() As String = {"Meowth", 40, 45, 35, 0, 0, 11, 0}
	Public Shared Persian() As String = {"Persian", 65, 70, 60, 0, 0, 11, 0}
	Public Shared Psyduck() As String = {"Psyduck", 50, 52, 48, 0, 0, 15, 0}
	Public Shared Golduck() As String = {"Golduck", 80, 82, 78, 0, 0, 15, 0}
	Public Shared Mankey() As String = {"Mankey", 40, 80, 35, 0, 0, 4, 0}
	Public Shared Primeape() As String = {"Primeape", 65, 105, 60, 0, 0, 4, 0}
	Public Shared Growlithe() As String = {"Growlithe", 55, 70, 45, 0, 0, 5, 0}
	Public Shared Arcanine() As String = {"Arcanine", 90, 110, 80, 0, 0, 5, 0}
	Public Shared Poliwag() As String = {"Poliwag", 40, 50, 40, 0, 0, 15, 0}
	Public Shared Poliwhirl() As String = {"Poliwhirl", 65, 65, 65, 0, 0, 15, 0}
	Public Shared Poliwrath() As String = {"Poliwrath", 90, 85, 95, 0, 0, 15, 4}
	Public Shared Abra() As String = {"Abra", 25, 20, 15, 0, 0, 13, 0}
	Public Shared Kadabra() As String = {"Kadabra", 40, 35, 30, 0, 0, 13, 0}
	Public Shared Alakazam() As String = {"Alakazam", 55, 50, 45, 0, 0, 13, 0}
	Public Shared Machop() As String = {"Machop", 70, 80, 50, 0, 0, 4, 0}
	Public Shared Machoke() As String = {"Machoke", 80, 100, 70, 0, 0, 4, 0}
	Public Shared Machamp() As String = {"Machamp", 90, 130, 80, 0, 0, 4, 0}
	Public Shared Bellsprout() As String = {"Bellsprout", 50, 75, 35, 0, 0, 7, 12}
	Public Shared Weepinbell() As String = {"Weepinbell", 65, 90, 50, 0, 0, 7, 12}
	Public Shared Victreebel() As String = {"Victreebel", 80, 105, 65, 0, 0, 7, 12}
	Public Shared Tentacool() As String = {"Tentacool", 40, 40, 35, 0, 0, 15, 12}
	Public Shared Tentacruel() As String = {"Tentacruel", 80, 70, 65, 0, 0, 15, 12}
	Public Shared Geodude() As String = {"Geodude", 40, 80, 100, 0, 0, 14, 9}
	Public Shared Graveler() As String = {"Graveler", 55, 95, 115, 0, 0, 14, 9}
	Public Shared Golem() As String = {"Golem", 80, 110, 130, 0, 0, 14, 9}
	Public Shared Ponyta() As String = {"Ponyta", 50, 85, 55, 0, 0, 5, 0}
	Public Shared Rapidash() As String = {"Rapidash", 65, 100, 70, 0, 0, 5, 0}
	Public Shared Slowpoke() As String = {"Slowpoke", 90, 65, 65, 0, 0, 15, 13}
	Public Shared Slowbro() As String = {"Slowbro", 95, 75, 110, 0, 0, 15, 13}
	Public Shared Magnemite() As String = {"Magnemite", 25, 35, 70, 0, 0, 10, 0}
	Public Shared Magneton() As String = {"Magneton", 50, 60, 95, 0, 0, 10, 0}
	Public Shared Farfetchd() As String = {"Farfetch'd", 52, 65, 55, 0, 0, 11, 6}
	Public Shared Doduo() As String = {"Doduo", 35, 85, 45, 0, 0, 11, 6}
	Public Shared Dodrio() As String = {"Dodrio", 60, 110, 70, 0, 0, 11, 6}
	Public Shared Seel() As String = {"Seel", 65, 45, 55, 0, 0, 15, 0}
	Public Shared Dewgong() As String = {"Dewgong", 90, 70, 80, 0, 0, 15, 3}
	Public Shared Grimer() As String = {"Grimer", 80, 80, 50, 0, 0, 12, 0}
	Public Shared Muk() As String = {"Muk", 105, 105, 75, 0, 0, 12, 0}
	Public Shared Shellder() As String = {"Shellder", 30, 65, 100, 0, 0, 15, 0}
	Public Shared Cloyster() As String = {"Cloyster", 50, 95, 180, 0, 0, 15, 12}
	Public Shared Gastly() As String = {"Gastly", 30, 35, 30, 0, 0, 8, 12}
	Public Shared Haunter() As String = {"Haunter", 45, 50, 45, 0, 0, 8, 12}
	Public Shared Gengar() As String = {"Gengar", 60, 65, 60, 0, 0, 8, 12}
	Public Shared Onix() As String = {"Onix", 35, 45, 160, 0, 0, 14, 9}
	Public Shared Drowzee() As String = {"Drowzee", 60, 48, 45, 0, 0, 13, 0}
	Public Shared Hypno() As String = {"Hypno", 85, 73, 70, 0, 0, 13, 0}
	Public Shared Krabby() As String = {"Krabby", 30, 105, 90, 0, 0, 15, 0}
	Public Shared Kingler() As String = {"Kingler", 55, 130, 115, 0, 0, 15, 0}
	Public Shared Voltorb() As String = {"Voltorb", 40, 30, 50, 0, 0, 10, 0}
	Public Shared Electrode() As String = {"Electrode", 60, 50, 70, 0, 0, 10, 0}
	Public Shared Exeggcute() As String = {"Exeggcute", 60, 40, 80, 0, 0, 7, 13}
	Public Shared Exeggutor() As String = {"Exeggutor", 95, 95, 85, 0, 0, 7, 13}
	Public Shared Cubone() As String = {"Cubone", 50, 50, 95, 0, 0, 9, 0}
	Public Shared Marowak() As String = {"Marowak", 60, 80, 110, 0, 0, 9, 0}
	Public Shared Hitmonlee() As String = {"Hitmonlee", 50, 120, 53, 0, 0, 4, 0}
	Public Shared Hitmonchan() As String = {"Hitmonchan", 50, 105, 79, 0, 0, 4, 0}
	Public Shared Lickitung() As String = {"Lickitung", 90, 55, 75, 0, 0, 11, 0}
	Public Shared Koffing() As String = {"Koffing", 40, 65, 95, 0, 0, 12, 0}
	Public Shared Weezing() As String = {"Weezing", 65, 90, 120, 0, 0, 12, 0}
	Public Shared Rhyhorn() As String = {"Rhyhorn", 80, 85, 95, 0, 0, 9, 14}
	Public Shared Rhydon() As String = {"Rhydon", 105, 130, 120, 0, 0, 9, 14}
	Public Shared Chansey() As String = {"Chansey", 250, 5, 5, 0, 0, 11, 0}
	Public Shared Tangela() As String = {"Tangela", 65, 55, 115, 0, 0, 7, 0}
	Public Shared Kangaskhan() As String = {"Kangaskhan", 105, 95, 80, 0, 0, 11, 0}
	Public Shared Horsea() As String = {"Horsea", 30, 40, 70, 0, 0, 15, 0}
	Public Shared Seadra() As String = {"Seadra", 55, 65, 95, 0, 0, 15, 0}
	Public Shared Goldeen() As String = {"Goldeen", 45, 67, 60, 0, 0, 15, 0}
	Public Shared Seaking() As String = {"Seaking", 80, 92, 65, 0, 0, 15, 0}
	Public Shared Staryu() As String = {"Staryu", 30, 45, 55, 0, 0, 15, 0}
	Public Shared Starmie() As String = {"Starmie", 60, 75, 85, 0, 0, 15, 13}
	Public Shared MrMime() As String = {"Mr. Mime", 40, 45, 65, 0, 0, 13, 0}
	Public Shared Scyther() As String = {"Scyther", 70, 110, 80, 0, 0, 1, 6}
	Public Shared Jynx() As String = {"Jynx", 65, 50, 35, 0, 0, 3, 13}
	Public Shared Electabuzz() As String = {"Electabuzz", 65, 83, 57, 0, 0, 10, 0}
	Public Shared Magmar() As String = {"Magmar", 65, 95, 57, 0, 0, 5, 0}
	Public Shared Pinsir() As String = {"Pinsir", 65, 125, 100, 0, 0, 1, 0}
	Public Shared Tauros() As String = {"Tauros", 75, 100, 95, 0, 0, 11, 0}
	Public Shared Magikarp() As String = {"Magikarp", 20, 10, 55, 0, 0, 15, 0}
	Public Shared Gyarados() As String = {"Gyarados", 95, 125, 79, 0, 0, 15, 6}
	Public Shared Lapras() As String = {"Lapras", 130, 85, 80, 0, 0, 15, 3}
	Public Shared Ditto() As String = {"Ditto", 48, 48, 48, 0, 0, 11, 0}
	Public Shared Eevee() As String = {"Eevee", 55, 55, 50, 0, 0, 11, 0}
	Public Shared Vaporeon() As String = {"Vaporeon", 130, 65, 60, 0, 0, 15, 0}
	Public Shared Jolteon() As String = {"Jolteon", 65, 65, 60, 0, 0, 10, 0}
	Public Shared Flareon() As String = {"Flareon", 65, 130, 60, 0, 0, 5, 0}
	Public Shared Porygon() As String = {"Porygon", 65, 60, 70, 0, 0, 11, 0}
	Public Shared Omanyte() As String = {"Omanyte", 35, 40, 100, 0, 0, 14, 15}
	Public Shared Omastar() As String = {"Omastar", 70, 60, 125, 0, 0, 14, 15}
	Public Shared Kabuto() As String = {"Kabuto", 30, 80, 90, 0, 0, 14, 15}
	Public Shared Kabutops() As String = {"Kabutops", 60, 115, 105, 0, 0, 14, 15}
	Public Shared Aerodactyl() As String = {"Aerodactyl", 80, 105, 65, 0, 0, 14, 6}
	Public Shared Snorlax() As String = {"Snorlax", 160, 110, 65, 0, 0, 11, 0}
	Public Shared Articuno() As String = {"Articuno", 90, 85, 100, 0, 0, 3, 6}
	Public Shared Zapdos() As String = {"Zapdos", 90, 90, 85, 0, 0, 10, 6}
	Public Shared Moltres() As String = {"Moltres", 90, 100, 90, 0, 0, 5, 6}
	Public Shared Dratini() As String = {"Dratini", 41, 64, 45, 0, 0, 2, 0}
	Public Shared Dragonair() As String = {"Dragonair", 61, 84, 65, 0, 0, 2, 0}
	Public Shared Dragonite() As String = {"Dragonite", 91, 134, 95, 0, 0, 2, 6}
	Public Shared Mewtwo() As String = {"Mewtwo", 106, 110, 90, 0, 0, 13, 0}
	Public Shared Mew() As String = {"Mew", 100, 100, 100, 0, 0, 13, 0}

	Public Shared Ryu() As String = {"Ryu", 100, 100, 100, 0, 0, 4, 11}
	Public Shared Ken() As String = {"Ken", 100, 100, 100, 0, 0, 4, 11}
	Public Shared Blanka() As String = {"Blanka", 90, 120, 90, 0, 0, 4, 10}
	Public Shared MBison() As String = {"M.Bison", 105, 105, 105, 0, 0, 4, 12}
	Public Shared Akuma() As String = {"Akuma", 80, 150, 80, 0, 0, 4, 12}
	Public Shared Balrog() As String = {"Balrog", 110, 110, 80, 0, 0, 4, 4}

	Private Sub btnStore_Click(sender As Object, e As EventArgs) Handles btnStore.Click

		frmShopMenu.Show()

	End Sub

	Private Sub btnBox_Click(sender As Object, e As EventArgs) Handles btnBox.Click

		frmBox.Show()

	End Sub

	Private Sub btnBattle_Click(sender As Object, e As EventArgs) Handles btnBattle.Click
		frmBattleSelect.Show()
	End Sub

End Class
