Public Class MainMenu


	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Dim Currency As Integer
		Dim Ballcount As Integer

		Dim ShopMenu As New frmShopMenu
        Dim Box As New frmBox
        Dim BattleSelect As New frmBattleSelect

        Dim yhp As Integer
        Dim yattack As Integer
        Dim ydefence As Integer
        Dim ehp As Integer
        Dim eattack As Integer
        Dim edefence As Integer

        'Pokeman name, health, attack, defense, obtained, selected

        'Special cases:
        'Nidoran(m&f), Farfetch'd, Mr. Mime

        Dim Bulbasaur() As String = {"Bulbasaur", 45, 49, 49, 0, 0, 7, 12}
        Dim Ivysaur() As String = {"Ivysaur", 60, 62, 63, 0, 0, 7, 12}
        Dim Venusaur() As String = {"Venusaur", 80, 82, 83, 0, 0, 7, 12}
        Dim Charmander() As String = {"Charmander", 39, 52, 43, 0, 0, 5, 0}
        Dim Charmeleon() As String = {"Charmeleon", 58, 64, 58, 0, 0, 5, 0}
        Dim Charizard() As String = {"Charizard", 78, 84, 78, 0, 0, 5, 6}
        Dim Squirtle() As String = {"Squirtle", 44, 48, 65, 0, 0, 15, 0}
        Dim Wartortle() As String = {"Wartortle", 59, 63, 80, 0, 0, 15, 0}
        Dim Blastoise() As String = {"Blastoise", 79, 83, 100, 0, 0, 15, 0}
        Dim Caterpie() As String = {"Caterpie", 45, 30, 35, 0, 0, 1, 0}
        Dim Metapod() As String = {"Metapod", 50, 20, 55, 0, 0, 1, 0}
        Dim Butterfree() As String = {"Butterfree", 60, 45, 50, 0, 0, 1, 6}
        Dim Weedle() As String = {"Weedle", 40, 35, 30, 0, 0, 1, 12}
        Dim Kakuna() As String = {"Kakuna", 45, 25, 50, 0, 0, 1, 12}
        Dim Beedrill() As String = {"Beedrill", 35, 80, 40, 0, 0, 1, 12}
        Dim Pidgey() As String = {"Pidgey", 40, 45, 40, 0, 0, 11, 6}
        Dim Pidgeotto() As String = {"Pidgeotto", 63, 60, 55, 0, 0, 11, 6}
        Dim Pidgeot() As String = {"Pidgeot", 83, 80, 75, 0, 0, 11, 6}
        Dim Rattata() As String = {"Rattata", 30, 56, 35, 0, 0, 11, 0}
        Dim Raticate() As String = {"Raticate", 55, 81, 60, 0, 0, 11, 0}
        Dim Spearow() As String = {"Spearow", 40, 60, 30, 0, 0, 11, 6}
        Dim Fearow() As String = {"Fearow", 65, 90, 65, 0, 0, 11, 6}
        Dim Ekans() As String = {"Ekans", 35, 60, 44, 0, 0, 12, 0}
        Dim Arbok() As String = {"Arbok", 60, 85, 69, 0, 0, 12, 0}
        Dim Pikachu() As String = {"Pikachu", 35, 55, 30, 0, 0, 10, 0}
        Dim Raichu() As String = {"Raichu", 60, 90, 55, 0, 0, 10, 0}
        Dim Sandshrew() As String = {"Sandshrew", 50, 75, 85, 0, 0, 9, 0}
        Dim Sandslash() As String = {"Sandslash", 75, 100, 110, 0, 0, 9, 0}
        Dim Nidoranm() As String = {"Nidoran (female)", 55, 47, 52, 0, 0, 12, 0}
        Dim Nidorina() As String = {"Nidorina", 70, 62, 67, 0, 0, 12, 0}
        Dim Nidoqueen() As String = {"Nidoqueen", 90, 82, 87, 0, 0, 12, 9}
        Dim Nidoranf() As String = {"Nidoran (male)", 46, 57, 40, 0, 0, 12, 0}
        Dim Nidorino() As String = {"Nidorino", 61, 72, 57, 0, 0, 12, 0}
        Dim Nidoking() As String = {"Nidoking", 81, 92, 77, 0, 0, 12, 9}
        Dim Clefairy() As String = {"Clefairy", 70, 45, 48, 0, 0, 11, 0}
        Dim Clefable() As String = {"Clefable", 95, 70, 73, 0, 0, 11, 0}
        Dim Vulpix() As String = {"Vulpix", 38, 41, 40, 0, 0, 5, 0}
        Dim Ninetales() As String = {"Ninetales", 73, 76, 75, 0, 0, 5, 0}
        Dim Jigglypuff() As String = {"Jigglypuff", 115, 45, 20, 0, 0, 11, 0}
        Dim Wigglytuff() As String = {"Wigglytuff", 140, 70, 45, 0, 0, 11, 0}
        Dim Zubat() As String = {"Zubat", 40, 45, 35, 0, 0, 12, 6}
        Dim Golbat() As String = {"Golbat", 75, 80, 70, 0, 0, 12, 6}
        Dim Oddish() As String = {"Oddish", 45, 50, 55, 0, 0, 7, 12}
        Dim Gloom() As String = {"Gloom", 60, 65, 70, 0, 0, 7, 12}
        Dim Vileplume() As String = {"Vileplume", 75, 80, 85, 0, 0, 7, 12}
        Dim Paras() As String = {"Paras", 35, 70, 55, 0, 0, 1, 7}
        Dim Parasect() As String = {"Parasect", 60, 95, 80, 0, 0, 1, 7}
        Dim Venonat() As String = {"Venonat", 60, 55, 50, 0, 0, 1, 12}
        Dim Venomoth() As String = {"Venomoth", 70, 65, 60, 0, 0, 1, 12}
        Dim Diglett() As String = {"Diglett", 10, 55, 25, 0, 0, 9, 0}
        Dim Dugtrio() As String = {"Dugtrio", 35, 80, 50, 0, 0, 9, 0}
        Dim Meowth() As String = {"Meowth", 40, 45, 35, 0, 0, 11, 0}
        Dim Persian() As String = {"Persian", 65, 70, 60, 0, 0, 11, 0}
        Dim Psyduck() As String = {"Psyduck", 50, 52, 48, 0, 0, 15, 0}
        Dim Golduck() As String = {"Golduck", 80, 82, 78, 0, 0, 15, 0}
        Dim Mankey() As String = {"Mankey", 40, 80, 35, 0, 0, 4, 0}
        Dim Primeape() As String = {"Primeape", 65, 105, 60, 0, 0, 4, 0}
        Dim Growlithe() As String = {"Growlithe", 55, 70, 45, 0, 0, 5, 0}
        Dim Arcanine() As String = {"Arcanine", 90, 110, 80, 0, 0, 5, 0}
        Dim Poliwag() As String = {"Poliwag", 40, 50, 40, 0, 0, 15, 0}
        Dim Poliwhirl() As String = {"Poliwhirl", 65, 65, 65, 0, 0, 15, 0}
        Dim Poliwrath() As String = {"Poliwrath", 90, 85, 95, 0, 0, 15, 4}
        Dim Abra() As String = {"Abra", 25, 20, 15, 0, 0, 13, 0}
        Dim Kadabra() As String = {"Kadabra", 40, 35, 30, 0, 0, 13, 0}
        Dim Alakazam() As String = {"Alakazam", 55, 50, 45, 0, 0, 13, 0}
        Dim Machop() As String = {"Machop", 70, 80, 50, 0, 0, 4, 0}
        Dim Machoke() As String = {"Machoke", 80, 100, 70, 0, 0, 4, 0}
        Dim Machamp() As String = {"Machamp", 90, 130, 80, 0, 0, 4, 0}
        Dim Bellsprout() As String = {"Bellsprout", 50, 75, 35, 0, 0, 7, 12}
        Dim Weepinbell() As String = {"Weepinbell", 65, 90, 50, 0, 0, 7, 12}
        Dim Victreebel() As String = {"Victreebel", 80, 105, 65, 0, 0, 7, 12}
        Dim Tentacool() As String = {"Tentacool", 40, 40, 35, 0, 0, 15, 12}
        Dim Tentacruel() As String = {"Tentacruel", 80, 70, 65, 0, 0, 15, 12}
        Dim Geodude() As String = {"Geodude", 40, 80, 100, 0, 0, 14, 9}
        Dim Graveler() As String = {"Graveler", 55, 95, 115, 0, 0, 14, 9}
        Dim Golem() As String = {"Golem", 80, 110, 130, 0, 0, 14, 9}
        Dim Ponyta() As String = {"Ponyta", 50, 85, 55, 0, 0, 5, 0}
        Dim Rapidash() As String = {"Rapidash", 65, 100, 70, 0, 0, 5, 0}
        Dim Slowpoke() As String = {"Slowpoke", 90, 65, 65, 0, 0, 15, 13}
        Dim Slowbro() As String = {"Slowbro", 95, 75, 110, 0, 0, 15, 13}
        Dim Magnemite() As String = {"Magnemite", 25, 35, 70, 0, 0, 10, 0}
        Dim Magneton() As String = {"Magneton", 50, 60, 95, 0, 0, 10, 0}
        Dim Farfetchd() As String = {"Farfetch'd", 52, 65, 55, 0, 0, 11, 6}
        Dim Doduo() As String = {"Doduo", 35, 85, 45, 0, 0, 11, 6}
        Dim Dodrio() As String = {"Dodrio", 60, 110, 70, 0, 0, 11, 6}
        Dim Seel() As String = {"Seel", 65, 45, 55, 0, 0, 15, 0}
        Dim Dewgong() As String = {"Dewgong", 90, 70, 80, 0, 0, 15, 3}
        Dim Grimer() As String = {"Grimer", 80, 80, 50, 0, 0, 12, 0}
        Dim Muk() As String = {"Muk", 105, 105, 75, 0, 0, 12, 0}
        Dim Shellder() As String = {"Shellder", 30, 65, 100, 0, 0, 15, 0}
        Dim Cloyster() As String = {"Cloyster", 50, 95, 180, 0, 0, 15, 12}
        Dim Gastly() As String = {"Gastly", 30, 35, 30, 0, 0, 8, 12}
        Dim Haunter() As String = {"Haunter", 45, 50, 45, 0, 0, 8, 12}
        Dim Gengar() As String = {"Gengar", 60, 65, 60, 0, 0, 8, 12}
        Dim Onix() As String = {"Onix", 35, 45, 160, 0, 0, 14, 9}
        Dim Drowzee() As String = {"Drowzee", 60, 48, 45, 0, 0, 13, 0}
        Dim Hypno() As String = {"Hypno", 85, 73, 70, 0, 0, 13, 0}
        Dim Krabby() As String = {"Krabby", 30, 105, 90, 0, 0, 15, 0}
        Dim Kingler() As String = {"Kingler", 55, 130, 115, 0, 0, 15, 0}
        Dim Voltorb() As String = {"Voltorb", 40, 30, 50, 0, 0, 10, 0}
        Dim Electrode() As String = {"Electrode", 60, 50, 70, 0, 0, 10, 0}
        Dim Exeggcute() As String = {"Exeggcute", 60, 40, 80, 0, 0, 7, 13}
        Dim Exeggutor() As String = {"Exeggutor", 95, 95, 85, 0, 0, 7, 13}
        Dim Cubone() As String = {"Cubone", 50, 50, 95, 0, 0, 9, 0}
        Dim Marowak() As String = {"Marowak", 60, 80, 110, 0, 0, 9, 0}
        Dim Hitmonlee() As String = {"Hitmonlee", 50, 120, 53, 0, 0, 4, 0}
        Dim Hitmonchan() As String = {"Hitmonchan", 50, 105, 79, 0, 0, 4, 0}
        Dim Lickitung() As String = {"Lickitung", 90, 55, 75, 0, 0, 11, 0}
        Dim Koffing() As String = {"Koffing", 40, 65, 95, 0, 0, 12, 0}
        Dim Weezing() As String = {"Weezing", 65, 90, 120, 0, 0, 12, 0}
        Dim Rhyhorn() As String = {"Rhyhorn", 80, 85, 95, 0, 0, 9, 14}
        Dim Rhydon() As String = {"Rhydon", 105, 130, 120, 0, 0, 9, 14}
        Dim Chansey() As String = {"Chansey", 250, 5, 5, 0, 0, 11, 0}
        Dim Tangela() As String = {"Tangela", 65, 55, 115, 0, 0, 7, 0}
        Dim Kangaskhan() As String = {"Kangaskhan", 105, 95, 80, 0, 0, 11, 0}
        Dim Horsea() As String = {"Horsea", 30, 40, 70, 0, 0, 15, 0}
        Dim Seadra() As String = {"Seadra", 55, 65, 95, 0, 0, 15, 0}
        Dim Goldeen() As String = {"Goldeen", 45, 67, 60, 0, 0, 15, 0}
        Dim Seaking() As String = {"Seaking", 80, 92, 65, 0, 0, 15, 0}
        Dim Staryu() As String = {"Staryu", 30, 45, 55, 0, 0, 15, 0}
        Dim Starmie() As String = {"Starmie", 60, 75, 85, 0, 0, 15, 13}
        Dim MrMime() As String = {"Mr. Mime", 40, 45, 65, 0, 0, 13, 0}
        Dim Scyther() As String = {"Scyther", 70, 110, 80, 0, 0, 1, 6}
        Dim Jynx() As String = {"Jynx", 65, 50, 35, 0, 0, 3, 13}
        Dim Electabuzz() As String = {"Electabuzz", 65, 83, 57, 0, 0, 10, 0}
        Dim Magmar() As String = {"Magmar", 65, 95, 57, 0, 0, 5, 0}
        Dim Pinsir() As String = {"Pinsir", 65, 125, 100, 0, 0, 1, 0}
        Dim Tauros() As String = {"Tauros", 75, 100, 95, 0, 0, 11, 0}
        Dim Magikarp() As String = {"Magikarp", 20, 10, 55, 0, 0, 15, 0}
        Dim Gyarados() As String = {"Gyarados", 95, 125, 79, 0, 0, 15, 6}
        Dim Lapras() As String = {"Lapras", 130, 85, 80, 0, 0, 15, 3}
        Dim Ditto() As String = {"Ditto", 48, 48, 48, 0, 0, 11, 0}
        Dim Eevee() As String = {"Eevee", 55, 55, 50, 0, 0, 11, 0}
        Dim Vaporeon() As String = {"Vaporeon", 130, 65, 60, 0, 0, 15, 0}
        Dim Jolteon() As String = {"Jolteon", 65, 65, 60, 0, 0, 10, 0}
        Dim Flareon() As String = {"Flareon", 65, 130, 60, 0, 0, 5, 0}
        Dim Porygon() As String = {"Porygon", 65, 60, 70, 0, 0, 11, 0}
        Dim Omanyte() As String = {"Omanyte", 35, 40, 100, 0, 0, 14, 15}
        Dim Omastar() As String = {"Omastar", 70, 60, 125, 0, 0, 14, 15}
        Dim Kabuto() As String = {"Kabuto", 30, 80, 90, 0, 0, 14, 15}
        Dim Kabutops() As String = {"Kabutops", 60, 115, 105, 0, 0, 14, 15}
        Dim Aerodactyl() As String = {"Aerodactyl", 80, 105, 65, 0, 0, 14, 6}
        Dim Snorlax() As String = {"Snorlax", 160, 110, 65, 0, 0, 11, 0}
        Dim Articuno() As String = {"Articuno", 90, 85, 100, 0, 0, 3, 6}
        Dim Zapdos() As String = {"Zapdos", 90, 90, 85, 0, 0, 10, 6}
        Dim Moltres() As String = {"Moltres", 90, 100, 90, 0, 0, 5, 6}
        Dim Dratini() As String = {"Dratini", 41, 64, 45, 0, 0, 2, 0}
        Dim Dragonair() As String = {"Dragonair", 61, 84, 65, 0, 0, 2, 0}
        Dim Dragonite() As String = {"Dragonite", 91, 134, 95, 0, 0, 2, 6}
        Dim Mewtwo() As String = {"Mewtwo", 106, 110, 90, 0, 0, 13, 0}
        Dim Mew() As String = {"Mew", 100, 100, 100, 0, 0, 13, 0}

    End Sub

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
