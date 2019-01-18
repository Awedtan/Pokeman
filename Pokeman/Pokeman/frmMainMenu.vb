Public Class frmMainMenu

	https://github.com/Awedtan/Pokeman

	Dim Currency As Integer
    Dim Ballcount As Integer

    Dim ShopMenu As New frmShopMenu
    Dim Box As New frmBox
	Dim BattleSelect As New frmBattleSelect
	Dim Start As New frmStart

	Public Shared route6counter As Integer
	Public Shared route7counter As Integer

	'Pokeman name, health, attack, defense, speed, special, obtained, selected, type1, type2, move1, move2, move3, move4
	'      0          1       2       3       4       5         6         7       8      9      10     11     13    14

	'Bug, Dragon, Ice, FIghting, Fire, Flying, Grass, Ghost, Ground, Electric, Normal , Poison, Psychic, Rock, Water
	' 1      2     3     4         5      6     7        8       9      10       11       12        13     14     15

	'Special cases:
	'Nidoran(m&f), Farfetch'd, Mr. Mime

	Public Shared Bulbasaur() As String = {"Bulbasaur", 45, 49, 49, 45, 65, 0, 0, 7, 12, "Absorb", "Razor Leaf", "Cut", "Vine Whip"}
	Public Shared Ivysaur() As String = {"Ivysaur", 60, 62, 63, 60, 80, 0, 0, 7, 12, "Mega Drain", "Razor Leaf", "Take Down", "Poison Powder"}
    Public Shared Venusaur() As String = {"Venusaur", 80, 82, 83, 80, 100, 0, 0, 7, 12, "Mega Drain", "Poison Powder", "Double-Edge", "Solar Beam"}
    Public Shared Charmander() As String = {"Charmander", 39, 52, 43, 65, 50, 0, 0, 5, 0, "Ember", "Scratch", "Growl", "Fire Spin"}
	Public Shared Charmeleon() As String = {"Charmeleon", 58, 64, 58, 80, 65, 0, 0, 5, 0}
    Public Shared Charizard() As String = {"Charizard", 78, 84, 78, 100, 85, 0, 0, 5, 6, "Fire Blast", "Fly", "Seismic Toss", "Slash"}
    Public Shared Squirtle() As String = {"Squirtle", 44, 48, 65, 43, 50, 0, 0, 15, 0, "Tackle", "Water Gun", "Bubble", "Tail Whip"}
	Public Shared Wartortle() As String = {"Wartortle", 59, 63, 80, 58, 65, 0, 0, 15, 0}
    Public Shared Blastoise() As String = {"Blastoise", 79, 83, 100, 78, 85, 0, 0, 15, 0, "Hydro Pump", "Defense Curl", "Double-Edge", "Blizzard"}
    Public Shared Caterpie() As String = {"Caterpie", 45, 30, 35, 56, 20, 0, 0, 1, 0, "String Shot", "Tackle", "Nothing", "Nothing"}
	Public Shared Metapod() As String = {"Metapod", 50, 20, 55, 30, 25, 0, 0, 1, 0, "Harden", "Nothing", "Nothing", "Nothing"}
	Public Shared Butterfree() As String = {"Butterfree", 60, 45, 50, 70, 80, 0, 0, 1, 6, "Poison Powder", "Confusion", "Gust", "Double-Edge"}
    Public Shared Weedle() As String = {"Weedle", 40, 35, 30, 50, 20, 0, 0, 1, 12, "Poison Sting", "String Shot", "Nothing", "Nothing"}
    Public Shared Kakuna() As String = {"Kakuna", 45, 25, 50, 35, 25, 0, 0, 1, 12, "Harden", "Nothing", "Nothing", "Nothing"}
    Public Shared Beedrill() As String = {"Beedrill", 35, 80, 40, 75, 45, 0, 0, 1, 12, "Poison Sting", "Pin Missile", "Body Slam", "Swords Dance"}
    Public Shared Pidgey() As String = {"Pidgey", 40, 45, 40, 56, 35, 0, 0, 11, 6, "Wing Attack", "Quick Attack", "Sand Attack", "Whirlwind"}
    Public Shared Pidgeotto() As String = {"Pidgeotto", 63, 60, 55, 71, 50, 0, 0, 11, 6, "Wing Attack", "Whirlwind", "Tackle", "Fly"}
	Public Shared Pidgeot() As String = {"Pidgeot", 83, 80, 75, 91, 70, 0, 0, 11, 6, "Wing Attack", "Take Down", "Whirlwind", "Peck"}
	Public Shared Rattata() As String = {"Rattata", 30, 56, 35, 72, 25, 0, 0, 11, 0, "Quick Attack", "Tail Whip", "Super Fang", "Fury Swipes"}
    Public Shared Raticate() As String = {"Raticate", 55, 81, 60, 97, 50, 0, 0, 11, 0, "Hyper Fang", "Super Fang", "Bite", "Dig"}
    Public Shared Spearow() As String = {"Spearow", 40, 60, 30, 70, 31, 0, 0, 11, 6, "Drill Peck", "Fury Attack", "Growl", "Peck"}
    Public Shared Fearow() As String = {"Fearow", 65, 90, 65, 100, 61, 0, 0, 11, 6, "Drill Peck", "Roost", "Take Down", "Fury Attack"}
    Public Shared Ekans() As String = {"Ekans", 35, 60, 44, 55, 40, 0, 0, 12, 0, "Poison Sting", "Bite", "Glare", "Screech"}
    Public Shared Arbok() As String = {"Arbok", 60, 85, 69, 80, 65, 0, 0, 12, 0, "Wrap", "Bite", "Body Slam", "Poison Sting"}
    Public Shared Pikachu() As String = {"Pikachu", 35, 55, 30, 90, 50, 0, 0, 10, 0, "Thunderbolt", "Thunder Wave", "Slam", "Agility"}
    Public Shared Raichu() As String = {"Raichu", 60, 90, 55, 100, 90, 0, 0, 10, 0, "Thunder", "Thunder Wave", "Slam", "Light Screen"}
    Public Shared Sandshrew() As String = {"Sandshrew", 50, 75, 85, 40, 30, 0, 0, 9, 0}
    Public Shared Sandslash() As String = {"Sandslash", 75, 100, 110, 65, 55, 0, 0, 9, 0, "Fury Swipes", "Slash", "Poison Sting", "Sand Attack"}
    Public Shared Nidoranm() As String = {"Nidoran (female)", 55, 47, 52, 41, 40, 0, 0, 12, 0, "Horn Attack", "Poison Sting", "Fury Attack", "Leer"}
    Public Shared Nidorina() As String = {"Nidorina", 70, 62, 67, 56, 55, 0, 0, 12, 0, "Horn Attack", "Double Kick", "Poison Sting", "Fury Attack"}
    Public Shared Nidoqueen() As String = {"Nidoqueen", 90, 82, 87, 76, 75, 0, 0, 12, 9, "Horn Attack", "Double Kick", "Poison Sting", "Fury Attack"}
    Public Shared Nidoranf() As String = {"Nidoran (male)", 46, 57, 40, 50, 40, 0, 0, 12, 0, "Horn Attack", "Poison Sting", "Fury Attack", "Leer"}
    Public Shared Nidorino() As String = {"Nidorino", 61, 72, 57, 65, 55, 0, 0, 12, 0, "Horn Attack", "Double Kick", "Poison Sting", "Fury Attack"}
    Public Shared Nidoking() As String = {"Nidoking", 81, 92, 77, 85, 75, 0, 0, 12, 9, "Horn Attack", "Double Kick", "Poison Sting", "Fury Attack"}
    Public Shared Clefairy() As String = {"Clefairy", 70, 45, 48, 35, 60, 0, 0, 11, 0, "Double Slap", "Body Slam", "Light Screen", "Defense Curl"}
    Public Shared Clefable() As String = {"Clefable", 95, 70, 73, 60, 85, 0, 0, 11, 0, "Double Slap", "Body Slam", "Light Screen", "Defense Curl"}
    Public Shared Vulpix() As String = {"Vulpix", 38, 41, 40, 65, 65, 0, 0, 5, 0, "Ember", "Flamethrower", "Tail Whip", "Body Slam"}
    Public Shared Ninetales() As String = {"Ninetales", 73, 76, 75, 100, 100, 0, 0, 5, 0, "Fire Blast", "Hyper Beam", "Reflect", "Rest"}
    Public Shared Jigglypuff() As String = {"Jigglypuff", 115, 45, 20, 20, 25, 0, 0, 11, 0, "Sing", "Rest", "Double-Edge", "Tackle"}
    Public Shared Wigglytuff() As String = {"Wigglytuff", 140, 70, 45, 45, 50, 0, 0, 11, 0, "Sing", "Rest", "Double-Edge", "Tackle"}
    Public Shared Zubat() As String = {"Zubat", 40, 45, 35, 55, 40, 0, 0, 12, 6, "Leech Life", "Supersonic", "Bite", "Haze"}
    Public Shared Golbat() As String = {"Golbat", 75, 80, 70, 90, 75, 0, 0, 12, 6}
    Public Shared Oddish() As String = {"Oddish", 45, 50, 55, 30, 75, 0, 0, 7, 12, "Absorb", "Stun Spore", "Acid", "Take Down"}
    Public Shared Gloom() As String = {"Gloom", 60, 65, 70, 40, 85, 0, 0, 7, 12, "Absorb", "Stun Spore", "Solar Beam", "Acid"}
    Public Shared Vileplume() As String = {"Vileplume", 75, 80, 85, 50, 100, 0, 0, 7, 12, "Vine Whip", "Stun Spore", "Poison Powder", "Sleep Powder"}
    Public Shared Paras() As String = {"Paras", 35, 70, 55, 25, 55, 0, 0, 1, 7, "Scratch", "Leech Life", "Spore", "Stun Spore"}
    Public Shared Parasect() As String = {"Parasect", 60, 95, 80, 30, 80, 0, 0, 1, 7, "Slash", "Growth", "Mega Drain", "Spore"}
    Public Shared Venonat() As String = {"Venonat", 60, 55, 50, 45, 40, 0, 0, 1, 12, "Poison Powder", "Take Down", "Sleep Powder", "Leech Life"}
    Public Shared Venomoth() As String = {"Venomoth", 70, 65, 60, 90, 90, 0, 0, 1, 12, "Poison Powder", "Stun Spore", "Leech Life", "Psybeam"}
    Public Shared Diglett() As String = {"Diglett", 10, 55, 25, 90, 45, 0, 0, 9, 0, "Dig", "Sand Attack", "Slash", "Rock Slide"}
    Public Shared Dugtrio() As String = {"Dugtrio", 35, 80, 50, 120, 70, 0, 0, 9, 0}
    Public Shared Meowth() As String = {"Meowth", 40, 45, 35, 90, 40, 0, 0, 11, 0, "Slash", "Fury Swipes", "Growl", "Pay Day"}
    Public Shared Persian() As String = {"Persian", 65, 70, 60, 115, 65, 0, 0, 11, 0}
    Public Shared Psyduck() As String = {"Psyduck", 50, 52, 48, 55, 50, 0, 0, 15, 0, "Confusion", "Tackle", "Hydro Pump", "Body Slam"}
    Public Shared Golduck() As String = {"Golduck", 80, 82, 78, 85, 80, 0, 0, 15, 0, "Confusion", "Hydro Pump", "Mega Kick", "Ice Beam"}
    Public Shared Mankey() As String = {"Mankey", 40, 80, 35, 70, 35, 0, 0, 4, 0}
    Public Shared Primeape() As String = {"Primeape", 65, 105, 60, 95, 60, 0, 0, 4, 0}
    Public Shared Growlithe() As String = {"Growlithe", 55, 70, 45, 60, 50, 0, 0, 5, 0, "Flamethrower", "Bite", "Roar", "Take Down"}
    Public Shared Arcanine() As String = {"Arcanine", 90, 110, 80, 95, 80, 0, 0, 5, 0, "Fire Blast", "Double-Edge", "Hyper Beam", "Roar"}
    Public Shared Poliwag() As String = {"Poliwag", 40, 50, 40, 90, 40, 0, 0, 15, 0, "Bubble", "Water Gun", "Double Slap", "Amnesia"}
    Public Shared Poliwhirl() As String = {"Poliwhirl", 65, 65, 65, 90, 50, 0, 0, 15, 0, "Surf", "Double Slap", "Mega Punch", "Ice Beam"}
    Public Shared Poliwrath() As String = {"Poliwrath", 90, 85, 95, 70, 70, 0, 0, 15, 4, "Double Slap", "Hydro Pump", "Mega Punch", "Amnesia"}
    Public Shared Abra() As String = {"Abra", 25, 20, 15, 90, 105, 0, 0, 13, 0, "Teleport", "Flash", "Nothing", "Nothing"}
    Public Shared Kadabra() As String = {"Kadabra", 40, 35, 30, 105, 120, 0, 0, 13, 0, "Psybeam", "Recover", "Reflect", "Submission"}
    Public Shared Alakazam() As String = {"Alakazam", 55, 50, 45, 120, 135, 0, 0, 13, 0, "Psychic", "Reflect", "Recover", "Confuse Ray"}
    Public Shared Machop() As String = {"Machop", 70, 80, 50, 35, 35, 0, 0, 4, 0, "Karate Chop", "Low Kick", "Focus Energy", "Body Slam"}
    Public Shared Machoke() As String = {"Machoke", 80, 100, 70, 45, 50, 0, 0, 4, 0, "Submission", "Seismic Toss", "Focus Energy", "Strength"}
    Public Shared Machamp() As String = {"Machamp", 90, 130, 80, 55, 65, 0, 0, 4, 0, "Submission", "Seismic Toss", "Earthquake", "Mega Kick"}
    Public Shared Bellsprout() As String = {"Bellsprout", 50, 75, 35, 40, 70, 0, 0, 7, 12, "Vine Whip", "Growth", "Poison Powder", "Acid"}
    Public Shared Weepinbell() As String = {"Weepinbell", 65, 90, 50, 55, 85, 0, 0, 7, 12, "Vine Whip", "Razor Leaf", "Poison Powder", "Slam"}
    Public Shared Victreebel() As String = {"Victreebel", 80, 105, 65, 70, 100, 0, 0, 7, 12}
    Public Shared Tentacool() As String = {"Tentacool", 40, 40, 35, 70, 100, 0, 0, 15, 12}
    Public Shared Tentacruel() As String = {"Tentacruel", 80, 70, 65, 100, 120, 0, 0, 15, 12, "Poison Sting", "Hydro Pump", "Barrier", "Toxic"}
    Public Shared Geodude() As String = {"Geodude", 40, 80, 100, 20, 30, 0, 0, 14, 9}
    Public Shared Graveler() As String = {"Graveler", 55, 95, 115, 35, 45, 0, 0, 14, 9, "Earthquake", "Rock Throw", "Defense Curl", "Body Slam"}
    Public Shared Golem() As String = {"Golem", 80, 110, 130, 45, 55, 0, 0, 14, 9, "Earthquake", "Rock Throw", "Defense Curl", "Explosion"}
    Public Shared Ponyta() As String = {"Ponyta", 50, 85, 55, 90, 65, 0, 0, 5, 0, "Ember", "Fire Spin", "Agility", "Stomp"}
    Public Shared Rapidash() As String = {"Rapidash", 65, 100, 70, 105, 80, 0, 0, 5, 0, "Fire Blast", "Fire Spin", "Horn Drill", "Agility"}
    Public Shared Slowpoke() As String = {"Slowpoke", 90, 65, 65, 15, 40, 0, 0, 15, 13}
    Public Shared Slowbro() As String = {"Slowbro", 95, 75, 110, 30, 80, 0, 0, 15, 13}
    Public Shared Magnemite() As String = {"Magnemite", 25, 35, 70, 45, 95, 0, 0, 10, 0, "Sonic Boom", "Thunder Shock", "Swift", "Reflect"}
    Public Shared Magneton() As String = {"Magneton", 50, 60, 95, 70, 120, 0, 0, 10, 0, "Supersonic", "Thunder", "Thunder Wave", "Double-Edge"}
    Public Shared Farfetchd() As String = {"Farfetch'd", 52, 65, 55, 60, 58, 0, 0, 11, 6, "Slash", "Swords Dance", "Peck", "Fury Attack"}
    Public Shared Doduo() As String = {"Doduo", 35, 85, 45, 75, 35, 0, 0, 11, 6, "Drill Peck", "Fury Attack", "Agility", "Quick Attack"}
    Public Shared Dodrio() As String = {"Dodrio", 60, 110, 70, 100, 60, 0, 0, 11, 6, "Drill Peck", "Tri Attack", "Body Slam", "Fury Attack"}
    Public Shared Seel() As String = {"Seel", 65, 45, 55, 45, 70, 0, 0, 15, 0, "Aurora Beam", "Rest", "Take Down", "Growl"}
    Public Shared Dewgong() As String = {"Dewgong", 90, 70, 80, 70, 95, 0, 0, 15, 3, "Blizzard", "Horn Drill", "Rest", "Surf"}
    Public Shared Grimer() As String = {"Grimer", 80, 80, 50, 25, 40, 0, 0, 12, 0, "Sludge", "Toxic", "Acid Armor", "Pound"}
    Public Shared Muk() As String = {"Muk", 105, 105, 75, 50, 65, 0, 0, 12, 0}
    Public Shared Shellder() As String = {"Shellder", 30, 65, 100, 40, 45, 0, 0, 15, 0, "Clamp", "Withdraw", "Tackle", "Supersonic"}
    Public Shared Cloyster() As String = {"Cloyster", 50, 95, 180, 70, 85, 0, 0, 15, 12, "Clamp", "Withdraw", "Ice Beam", "Spike Cannon"}
    Public Shared Gastly() As String = {"Gastly", 30, 35, 30, 80, 100, 0, 0, 8, 12, "Lick", "Hypnosis", "Confuse Ray", "Night Shade"}
    Public Shared Haunter() As String = {"Haunter", 45, 50, 45, 95, 115, 0, 0, 8, 12, "Lick", "Confuse Ray", "Dream Eater", "Psychic"}
    Public Shared Gengar() As String = {"Gengar", 60, 65, 60, 110, 130, 0, 0, 8, 12, "Confuse Ray", "Dream Eater", "Hypnosis", "Mega Kick"}
    Public Shared Onix() As String = {"Onix", 35, 45, 160, 70, 30, 0, 0, 14, 9, "Rock Throw", "Slam", "Harden", "Earthquake"}
    Public Shared Drowzee() As String = {"Drowzee", 60, 48, 45, 42, 90, 0, 0, 13, 0}
    Public Shared Hypno() As String = {"Hypno", 85, 73, 70, 67, 115, 0, 0, 13, 0, "Psychic", "Confusion", "Pound", "Poison Gas"}
    Public Shared Krabby() As String = {"Krabby", 30, 105, 90, 50, 25, 0, 0, 15, 0, "Crabhammer", "Vice Grip", "Stomp", "Harden"}
    Public Shared Kingler() As String = {"Kingler", 55, 130, 115, 75, 50, 0, 0, 15, 0, "Crabhammer", "Guillotine", "Vice Grip", "Swords Dance"}
    Public Shared Voltorb() As String = {"Voltorb", 40, 30, 50, 100, 55, 0, 0, 10, 0, "Self Destruct", "Thunderbolt", "Swift", "Flash"}
    Public Shared Electrode() As String = {"Electrode", 60, 50, 70, 140, 80, 0, 0, 10, 0, "Explosion", "Thunder", "Thunder Wave", "Flash"}
    Public Shared Exeggcute() As String = {"Exeggcute", 60, 40, 80, 40, 60, 0, 0, 7, 13, "Barrage", "Stun Spore", "Take Down", "Egg Bomb"}
    Public Shared Exeggutor() As String = {"Exeggutor", 95, 95, 85, 55, 125, 0, 0, 7, 13, "Barrage", "Solar Beam", "Stomp", "Mega Drain"}
    Public Shared Cubone() As String = {"Cubone", 50, 50, 95, 35, 40, 0, 0, 9, 0, "Growl", "Headbutt", "Bonemerang", "Bone Club"}
    Public Shared Marowak() As String = {"Marowak", 60, 80, 110, 45, 50, 0, 0, 9, 0, "Bone Club", "Bonemerang", "Body Slam", "Dig"}
    Public Shared Hitmonlee() As String = {"Hitmonlee", 50, 120, 53, 87, 35, 0, 0, 4, 0}
    Public Shared Hitmonchan() As String = {"Hitmonchan", 50, 105, 79, 76, 35, 0, 0, 4, 0}
    Public Shared Lickitung() As String = {"Lickitung", 90, 55, 75, 30, 60, 0, 0, 11, 0}
    Public Shared Koffing() As String = {"Koffing", 40, 65, 95, 35, 60, 0, 0, 12, 0, "Smog", "Sludge", "Smokescreen", "Tackle"}
    Public Shared Weezing() As String = {"Weezing", 65, 90, 120, 60, 85, 0, 0, 12, 0}
    Public Shared Rhyhorn() As String = {"Rhyhorn", 80, 85, 95, 25, 30, 0, 0, 9, 14}
    Public Shared Rhydon() As String = {"Rhydon", 105, 130, 120, 40, 45, 0, 0, 9, 14}
    Public Shared Chansey() As String = {"Chansey", 250, 5, 5, 50, 105, 0, 0, 11, 0}
    Public Shared Tangela() As String = {"Tangela", 65, 55, 115, 60, 100, 0, 0, 7, 0}
    Public Shared Kangaskhan() As String = {"Kangaskhan", 105, 95, 80, 90, 40, 0, 0, 11, 0, "Mega Punch", "Dizzy Punch", "Hyper Beam", "Earthquake"}
    Public Shared Horsea() As String = {"Horsea", 30, 40, 70, 60, 70, 0, 0, 15, 0}
    Public Shared Seadra() As String = {"Seadra", 55, 65, 95, 85, 95, 0, 0, 15, 0}
    Public Shared Goldeen() As String = {"Goldeen", 45, 67, 60, 63, 50, 0, 0, 15, 0, "Peck", "Horn Attack", "Fury Attack", "Waterfall"}
    Public Shared Seaking() As String = {"Seaking", 80, 92, 65, 68, 80, 0, 0, 15, 0}
    Public Shared Staryu() As String = {"Staryu", 30, 45, 55, 85, 70, 0, 0, 15, 0, "Light Screen", "Swift", "Recover", "Hydro Pump"}
    Public Shared Starmie() As String = {"Starmie", 60, 75, 85, 115, 100, 0, 0, 15, 13}
    Public Shared MrMime() As String = {"Mr. Mime", 40, 45, 65, 90, 100, 0, 0, 13, 0}
    Public Shared Scyther() As String = {"Scyther", 70, 110, 80, 105, 55, 0, 0, 1, 6}
    Public Shared Jynx() As String = {"Jynx", 65, 50, 35, 95, 95, 0, 0, 3, 13}
    Public Shared Electabuzz() As String = {"Electabuzz", 65, 83, 57, 105, 85, 0, 0, 10, 0, "Light Screen", "Thunder", "Thunder Punch", "Mega Punch"}
    Public Shared Magmar() As String = {"Magmar", 65, 95, 57, 93, 85, 0, 0, 5, 0, "Fire Punch", "Smokescreen", "Take Down", "Flamethrower"}
    Public Shared Pinsir() As String = {"Pinsir", 65, 125, 100, 85, 55, 0, 0, 1, 0}
    Public Shared Tauros() As String = {"Tauros", 75, 100, 95, 110, 70, 0, 0, 11, 0, "Earthquake", "Double-Edge", "Horn Drill", "Hyper Beam"}
    Public Shared Magikarp() As String = {"Magikarp", 20, 10, 55, 80, 20, 0, 0, 15, 0, "Splash", "Nothing", "Nothing", "Nothing"}
    Public Shared Gyarados() As String = {"Gyarados", 95, 125, 79, 81, 100, 0, 0, 15, 6, "Hydro Pump", "Hyper Beam", "Bite", "Blizzard"}
    Public Shared Lapras() As String = {"Lapras", 130, 85, 80, 60, 95, 0, 0, 15, 3, "Hydro Pump", "Ice Beam", "Body Slam", "Psychic"}
    Public Shared Ditto() As String = {"Ditto", 48, 48, 48, 48, 48, 0, 0, 11, 0}
    Public Shared Eevee() As String = {"Eevee", 55, 55, 50, 55, 65, 0, 0, 11, 0, "Double-Edge", "Swift", "Bite", "Sand Attack"}
    Public Shared Vaporeon() As String = {"Vaporeon", 130, 65, 60, 65, 110, 0, 0, 15, 0, "Ice Beam", "Double-Edge", "Surf", "Water Gun"}
    Public Shared Jolteon() As String = {"Jolteon", 65, 65, 60, 130, 110, 0, 0, 10, 0, "Thunder", "Double Kick", "Pin Missile", "Thunder Wave"}
    Public Shared Flareon() As String = {"Flareon", 65, 130, 60, 65, 110, 0, 0, 5, 0, "Flamethrower", "Fire Spin", "Double-Edge", "Double Team"}
    Public Shared Porygon() As String = {"Porygon", 65, 60, 70, 40, 75, 0, 0, 11, 0}
    Public Shared Omanyte() As String = {"Omanyte", 35, 40, 100, 35, 90, 0, 0, 14, 15}
    Public Shared Omastar() As String = {"Omastar", 70, 60, 125, 55, 115, 0, 0, 14, 15}
    Public Shared Kabuto() As String = {"Kabuto", 30, 80, 90, 55, 45, 0, 0, 14, 15}
    Public Shared Kabutops() As String = {"Kabutops", 60, 115, 105, 80, 70, 0, 0, 14, 15}
    Public Shared Aerodactyl() As String = {"Aerodactyl", 80, 60, 105, 65, 130, 0, 0, 14, 6, "Wing Attack", "Double-Edge", "Hyper Beam", "Earthquake"}
    Public Shared Snorlax() As String = {"Snorlax", 160, 110, 65, 30, 65, 0, 0, 11, 0, "Rest", "Harden", "Double-Edge", "Hyper Beam"}
    Public Shared Articuno() As String = {"Articuno", 90, 85, 100, 85, 125, 0, 0, 3, 6, "Blizzard", "Wing Attack", "Hyper Beam", "Mist"}
    Public Shared Zapdos() As String = {"Zapdos", 90, 90, 85, 100, 125, 0, 0, 10, 6, "Thunder", "Wing Attack", "Thunder Wave", "Hyper Beam"}
    Public Shared Moltres() As String = {"Moltres", 90, 100, 90, 90, 125, 0, 0, 5, 6, "Fire Spin", "Wing Attack", "Fire Blast", "Hyper Beam"}
    Public Shared Dratini() As String = {"Dratini", 41, 64, 45, 50, 50, 0, 0, 2, 0}
    Public Shared Dragonair() As String = {"Dragonair", 61, 84, 65, 70, 70, 0, 0, 2, 0, "Thunder", "Wrap", "Hyper Beam", "Surf"}
    Public Shared Dragonite() As String = {"Dragonite", 91, 134, 95, 80, 100, 0, 0, 2, 6, "Thunder", "Hyper Beam", "Surf", "Blizzard"}
    Public Shared Mewtwo() As String = {"Mewtwo", 106, 110, 90, 130, 154, 0, 0, 13, 0, "Recover", "Barrier ", "Psychic", "Thunder"}
    Public Shared Mew() As String = {"Mew", 100, 100, 100, 100, 100, 0, 0, 13, 0, "Psychic", "Confuse Ray", "Mega Punch", "Explosion"}

    Public Shared Ryu() As String = {"Ryu", 100, 100, 100, 100, 100, 0, 0, 4, 11, "Hadouken", "Shoryuken", "Hurricane Kick", "Collarbone Breaker"}
    Public Shared Ken() As String = {"Ken", 100, 100, 100, 100, 100, 0, 0, 4, 11, "Hadouken", "Heat Rush", "Guren Enjinkyaku", "Quick Step"}
    Public Shared Blanka() As String = {"Blanka", 90, 120, 90, 120, 100, 0, 0, 4, 10, "Lightning Cannonball", "Shout OF Earth", "Low Kick", "Seismic Toss"}
    Public Shared MBison() As String = {"M.Bison", 105, 105, 105, 85, 130, 0, 0, 4, 12, "Psycho Crusher", "Super Scissor Kicks", "Devil's Reverse", "Seismic Toss"}
    Public Shared Akuma() As String = {"Akuma", 80, 150, 80, 110, 120, 0, 0, 4, 12, "Hadouken", "Raging Demon", "Gou Shoryuken", "Ahura Senku"} 'teleport
    Public Shared Balrog() As String = {"Balrog", 125, 125, 120, 75, 60, 0, 0, 4, 4, "Buffalo Headbutt", "Super Running Uppercut", "Dash Punch", "Head Bomber"}

	Public Shared yourpokemon1(14) As String
	Public Shared yourpokemon2(14) As String
	Public Shared yourpokemon3(14) As String
	Public Shared yourpokemon4(14) As String
	Public Shared yourpokemon5(14) As String
	Public Shared yourpokemon6(14) As String

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

		lblPokeman1.Text = yourpokemon1(0)
		lblPokeman2.Text = yourpokemon2(0)
		lblPokeman3.Text = yourpokemon3(0)
		lblPokeman4.Text = yourpokemon4(0)
		lblPokeman5.Text = yourpokemon5(0)
		lblPokeman6.Text = yourpokemon6(0)



	End Sub

	Private Sub btnStore_Click(sender As Object, e As EventArgs)
		frmShopMenu.Show()
	End Sub

	Private Sub btnBox_Click(sender As Object, e As EventArgs) Handles btnBox.Click
		frmBox.Show()
	End Sub

	Private Sub btnBattle_Click(sender As Object, e As EventArgs) Handles btnBattle.Click
        frmBattleSelect.Show()
    End Sub

	Private Async Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Await Task.Delay(1000)
		frmStart.Show()
	End Sub
End Class
