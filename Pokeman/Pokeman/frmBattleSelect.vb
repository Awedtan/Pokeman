Public Class frmBattleSelect

	Dim gym1 As New frmGym1
	Dim gym2 As New frmGym2
	Dim gym3 As New frmGym3
	Dim gym4 As New frmGym4
	Dim gym5 As New frmGym5

	Public Shared gym1c As Integer
	Public Shared gym2c As Integer
	Public Shared gym3c As Integer
	Public Shared gym4c As Integer
	Public Shared gym5c As Integer

	Dim HauntedHouse As New frmHauntedHouse
	Dim MewtwoEncounter As New frmMewtwoEncounter
	Dim InBattle As New frmInBattle
	Dim BirdNest As New frmBirdNest
	Dim TrainerBattleStart As New frmTrainerBattleStart

    Public Shared trainerbattle As Boolean
    Public Shared legendary As Boolean
    Public Shared gymleader As Boolean
    Public Shared strong As Boolean
    Public Shared champ As Boolean
    Public Shared mewtwo As Boolean
    Public Shared elite As Boolean

    Public Shared trainer As String

	Public Shared enemypokemon1(14) As String
	Public Shared enemypokemon2(14) As String
	Public Shared enemypokemon3(14) As String
	Public Shared enemypokemon4(14) As String
	Public Shared enemypokemon5(14) As String
	Public Shared enemypokemon6(14) As String
	Dim emptypokemon(14) As String

	Dim num As Integer

	Private Sub btnRoute1_Click(sender As Object, e As EventArgs) Handles btnRoute1.Click

        trainerbattle = False
        legendary = False
        gymleader = False
        strong = False
        champ = False
        mewtwo = False
        elite = False

        Randomize()

		num = Int(5 * Rnd(1))

		Select Case num
			Case 1
				enemypokemon1 = frmMainMenu.Rattata
			Case 2
				enemypokemon1 = frmMainMenu.Spearow
			Case 3
				enemypokemon1 = frmMainMenu.Pidgey
			Case 4
				enemypokemon1 = frmMainMenu.Weedle
			Case 0
				enemypokemon1 = frmMainMenu.Caterpie
		End Select

		frmInBattle.Show()

	End Sub

	Private Sub btnTrainer1_Click(sender As Object, e As EventArgs) Handles btnTrainer1.Click

        trainerbattle = True
        legendary = False
        gymleader = False
        strong = False
        champ = False
        mewtwo = False
        elite = False


        enemypokemon1 = frmMainMenu.Caterpie
		frmInBattle.enemypokemon2U = False
		frmInBattle.enemypokemon3U = False
		frmInBattle.enemypokemon4U = False
		frmInBattle.enemypokemon5U = False
		frmInBattle.enemypokemon6U = False

		trainer = "Hagith"
		frmTrainerBattleStart.Show()

	End Sub

	Private Sub btnRoute2_Click(sender As Object, e As EventArgs) Handles btnRoute2.Click

        trainerbattle = False
        legendary = False
        gymleader = False
        strong = False
        champ = False
        mewtwo = False
        elite = False


        Randomize()

		num = Int(6 * Rnd(1))

		Select Case num
			Case 1
				enemypokemon1 = frmMainMenu.Eevee
			Case 2
				enemypokemon1 = frmMainMenu.Bellsprout
			Case 3
				enemypokemon1 = frmMainMenu.Oddish
			Case 4
				enemypokemon1 = frmMainMenu.Vulpix
			Case 5
				enemypokemon1 = frmMainMenu.Nidoranf
			Case 0
				enemypokemon1 = frmMainMenu.Nidoranm
		End Select

		frmInBattle.Show()

	End Sub

	Private Sub btnTrainer2_Click(sender As Object, e As EventArgs) Handles btnTrainer2.Click

        trainerbattle = True

        legendary = False
        gymleader = False
        strong = False
        champ = False
        mewtwo = False
        elite = False


        enemypokemon1 = frmMainMenu.Pidgeotto
		frmInBattle.enemypokemon2U = False
		frmInBattle.enemypokemon3U = False
		frmInBattle.enemypokemon4U = False
		frmInBattle.enemypokemon5U = False
		frmInBattle.enemypokemon6U = False
		trainer = "Jumong"
		frmTrainerBattleStart.Show()


	End Sub

	Private Sub btnGym1_Click(sender As Object, e As EventArgs) Handles btnGym1.Click

        trainerbattle = True
        legendary = False
        gymleader = False
        strong = False
        champ = False
        mewtwo = False
        elite = False

        Select Case gym1c
			Case 0
				enemypokemon1 = frmMainMenu.Oddish
				frmInBattle.enemypokemon2U = False
				frmInBattle.enemypokemon3U = False
				frmInBattle.enemypokemon4U = False
				frmInBattle.enemypokemon5U = False
				frmInBattle.enemypokemon6U = False


                strong = True



                trainer = "Gym 1.1"
			Case 1
				enemypokemon1 = frmMainMenu.Weepinbell
				frmInBattle.enemypokemon2U = False
				frmInBattle.enemypokemon3U = False
				frmInBattle.enemypokemon4U = False
				frmInBattle.enemypokemon5U = False
				frmInBattle.enemypokemon6U = False

                strong = True

                trainer = "Gym 1.2"
			Case 2
				enemypokemon1 = frmMainMenu.Ivysaur
				enemypokemon2 = frmMainMenu.Gloom
				frmInBattle.enemypokemon2U = True
				frmInBattle.enemypokemon3U = False
				frmInBattle.enemypokemon4U = False
				frmInBattle.enemypokemon5U = False
				frmInBattle.enemypokemon6U = False
                gymleader = True
                trainer = "Gym 1.0"
		End Select

		gym1c += 1

		frmTrainerBattleStart.Show()

	End Sub

	Private Sub btnRoute3_Click(sender As Object, e As EventArgs) Handles btnRoute3.Click

        trainerbattle = False
        legendary = False
        gymleader = False
        strong = False
        champ = False
        mewtwo = False
        elite = False

        Randomize()

		num = Int(8 * Rnd(1))

		Select Case num
			Case 1
				enemypokemon1 = frmMainMenu.Metapod
			Case 2
				enemypokemon1 = frmMainMenu.Butterfree
			Case 3
				enemypokemon1 = frmMainMenu.Kakuna
			Case 4
				enemypokemon1 = frmMainMenu.Beedrill
			Case 5
				enemypokemon1 = frmMainMenu.Pidgeotto
			Case 6
				enemypokemon1 = frmMainMenu.Nidorino
			Case 7
				enemypokemon1 = frmMainMenu.Nidorina
			Case 0
				enemypokemon1 = frmMainMenu.Raticate
		End Select

		frmInBattle.Show()

	End Sub

	Private Sub btnTrainer3_Click(sender As Object, e As EventArgs) Handles btnTrainer3.Click

        trainerbattle = True
        legendary = False
        gymleader = False
        strong = False
        champ = False
        mewtwo = False
        elite = False

        enemypokemon1 = frmMainMenu.Squirtle
		enemypokemon2 = frmMainMenu.Squirtle
		frmInBattle.enemypokemon2U = True
		frmInBattle.enemypokemon3U = False
		frmInBattle.enemypokemon4U = False
		frmInBattle.enemypokemon5U = False
		frmInBattle.enemypokemon6U = False

		trainer = "Tom"
		frmTrainerBattleStart.Show()
	End Sub

    Private Sub btnRoute4_Click(sender As Object, e As EventArgs) Handles btnRoute4.Click

        trainerbattle = False
        legendary = False
        gymleader = False
        strong = False
        champ = False
        mewtwo = False
        elite = False

        Randomize()

        num = Int(7 * Rnd(1))

        Select Case num
            Case 1
                enemypokemon1 = frmMainMenu.Ekans
            Case 2
                enemypokemon1 = frmMainMenu.Pikachu
            Case 3
                enemypokemon1 = frmMainMenu.Raichu
            Case 4
                enemypokemon1 = frmMainMenu.Diglett
            Case 5
                enemypokemon1 = frmMainMenu.Meowth
            Case 6
                enemypokemon1 = frmMainMenu.Magnemite
            Case 0
                enemypokemon1 = frmMainMenu.Voltorb
        End Select

        frmInBattle.Show()

    End Sub

    Private Sub btnTrainer4_Click(sender As Object, e As EventArgs) Handles btnTrainer4.Click

        trainerbattle = True
        legendary = False
        gymleader = False
        strong = False
        champ = False
        mewtwo = False
        elite = False

        enemypokemon1 = frmMainMenu.Grimer
        enemypokemon2 = frmMainMenu.Pikachu
        frmInBattle.enemypokemon2U = True
        enemypokemon3 = frmMainMenu.Diglett
        frmInBattle.enemypokemon3U = True
        frmInBattle.enemypokemon4U = False
        frmInBattle.enemypokemon5U = False
        frmInBattle.enemypokemon6U = False

        trainer = "Sam"
        frmTrainerBattleStart.Show()
    End Sub

    Private Sub btnGym2_Click(sender As Object, e As EventArgs) Handles btnGym2.Click

        trainerbattle = True
        legendary = False
        gymleader = False
        strong = False
        champ = False
        mewtwo = False
        elite = False

        Select Case gym2c
            Case 0
                enemypokemon1 = frmMainMenu.Magnemite
                enemypokemon2 = frmMainMenu.Voltorb
                frmInBattle.enemypokemon2U = True
                frmInBattle.enemypokemon3U = False
                frmInBattle.enemypokemon4U = False
                frmInBattle.enemypokemon5U = False
                frmInBattle.enemypokemon6U = False
                strong = True
                trainer = "Gym 2.1"
            Case 1
                enemypokemon1 = frmMainMenu.Voltorb
                enemypokemon2 = frmMainMenu.Voltorb
                frmInBattle.enemypokemon2U = True
                frmInBattle.enemypokemon3U = False
                frmInBattle.enemypokemon4U = False
                frmInBattle.enemypokemon5U = False
                frmInBattle.enemypokemon6U = False
                strong = True
                trainer = "Gym 2.2"
            Case 2
                enemypokemon1 = frmMainMenu.Pikachu
                frmInBattle.enemypokemon2U = False
                frmInBattle.enemypokemon3U = False
                frmInBattle.enemypokemon4U = False
                frmInBattle.enemypokemon5U = False
                frmInBattle.enemypokemon6U = False
                trainer = "Gym 2.3"
                strong = True
            Case 3
                enemypokemon1 = frmMainMenu.Magneton
                enemypokemon2 = frmMainMenu.Raichu
                enemypokemon3 = frmMainMenu.Jolteon
                frmInBattle.enemypokemon2U = True
                frmInBattle.enemypokemon3U = True
                frmInBattle.enemypokemon4U = False
                frmInBattle.enemypokemon5U = False
                frmInBattle.enemypokemon6U = False
                gymleader = True
                trainer = "Gym 2.0"
        End Select
        gym2c += 1
        frmTrainerBattleStart.Show()

    End Sub

    Private Sub btnRoute5_Click(sender As Object, e As EventArgs) Handles btnRoute5.Click

        trainerbattle = False
        legendary = False
        gymleader = False
        strong = False
        champ = False
        mewtwo = False
        elite = False
        Randomize()

        num = Int(10 * Rnd(1))

        Select Case num
            Case 1
                enemypokemon1 = frmMainMenu.Gloom
            Case 2
                enemypokemon1 = frmMainMenu.Paras
            Case 3
                enemypokemon1 = frmMainMenu.Parasect
            Case 4
                enemypokemon1 = frmMainMenu.Venonat
            Case 5
                enemypokemon1 = frmMainMenu.Magnemite
            Case 6
                enemypokemon1 = frmMainMenu.Magneton
            Case 7
                enemypokemon1 = frmMainMenu.Electrode
            Case 8
                enemypokemon1 = frmMainMenu.Gastly
            Case 9
                enemypokemon1 = frmMainMenu.Electabuzz
            Case 0
                enemypokemon1 = frmMainMenu.Jolteon
        End Select

        frmInBattle.Show()

    End Sub

    Private Sub btnTrainer5_Click(sender As Object, e As EventArgs) Handles btnTrainer5.Click

        trainerbattle = True
        legendary = False
        gymleader = False
        strong = False
        champ = False
        mewtwo = False
        elite = False

        enemypokemon1 = frmMainMenu.Zubat
        enemypokemon2 = frmMainMenu.Pikachu
        frmInBattle.enemypokemon2U = True
        enemypokemon3 = frmMainMenu.Gastly
        frmInBattle.enemypokemon3U = True
        frmInBattle.enemypokemon4U = False
        frmInBattle.enemypokemon5U = False
        frmInBattle.enemypokemon6U = False

        trainer = "Ekaterina"
        frmTrainerBattleStart.Show()
    End Sub

    Private Sub btnHauntedHouse_Click(sender As Object, e As EventArgs) Handles btnHauntedHouse.Click

        trainerbattle = False
        legendary = False
        gymleader = False
        strong = False
        champ = False
        mewtwo = False
        elite = False

        enemypokemon1 = frmMainMenu.Gengar 'make him powerful or something
        frmInBattle.Show()

    End Sub

    Private Sub btnRoute6_Click(sender As Object, e As EventArgs) Handles btnRoute6.Click

        trainerbattle = False
        legendary = False
        gymleader = False
        strong = False
        champ = False
        mewtwo = False
        elite = False

        Randomize()

        If frmMainMenu.route6counter < 3 Then

            num = Int(6 * Rnd(1))

            Select Case num
                Case 1
                    enemypokemon1 = frmMainMenu.Ponyta
                Case 2
                    enemypokemon1 = frmMainMenu.Pidgeot
                Case 3
                    enemypokemon1 = frmMainMenu.Fearow
                Case 4
                    enemypokemon1 = frmMainMenu.Growlithe
                Case 5
                    enemypokemon1 = frmMainMenu.Arcanine
                Case 0
                    enemypokemon1 = frmMainMenu.Farfetchd
            End Select

            frmMainMenu.route6counter += 1

        Else

            num = Int(10 * Rnd(1))
        End If

        Select Case num
            Case 1
                enemypokemon1 = frmMainMenu.Ponyta
            Case 2
                enemypokemon1 = frmMainMenu.Pidgeot
            Case 3
                enemypokemon1 = frmMainMenu.Fearow
            Case 4
                enemypokemon1 = frmMainMenu.Growlithe
            Case 5
                enemypokemon1 = frmMainMenu.Arcanine
            Case 6
                enemypokemon1 = frmMainMenu.Farfetchd
            Case 7
                enemypokemon1 = frmMainMenu.Rapidash
            Case 8
                enemypokemon1 = frmMainMenu.Ninetales
            Case 9
                enemypokemon1 = frmMainMenu.Magmar
            Case 0
                enemypokemon1 = frmMainMenu.Flareon
        End Select


        frmInBattle.Show()

    End Sub

    Private Sub btnTrainer6_Click(sender As Object, e As EventArgs) Handles btnTrainer6.Click

        trainerbattle = True
        legendary = False
        gymleader = False
        strong = False
        champ = False
        mewtwo = False
        elite = False

        enemypokemon1 = frmMainMenu.Fearow
        enemypokemon2 = frmMainMenu.Graveler
        frmInBattle.enemypokemon2U = True
        frmInBattle.enemypokemon3U = False
        frmInBattle.enemypokemon4U = False
        frmInBattle.enemypokemon5U = False
        frmInBattle.enemypokemon6U = False
        trainer = "Manny"
        frmTrainerBattleStart.Show()

    End Sub

    Private Sub btnGym3_Click(sender As Object, e As EventArgs) Handles btnGym3.Click

        trainerbattle = True
        legendary = False
        gymleader = False
        strong = False
        champ = False
        mewtwo = False
        elite = False

        Select Case gym3c
            Case 0
                enemypokemon1 = frmMainMenu.Vulpix
                enemypokemon2 = frmMainMenu.Ponyta
                enemypokemon3 = frmMainMenu.Growlithe
                frmInBattle.enemypokemon2U = True
                frmInBattle.enemypokemon3U = True
                frmInBattle.enemypokemon4U = False
                frmInBattle.enemypokemon5U = False
                frmInBattle.enemypokemon6U = False
                strong = True
                trainer = "Gym 3.1"
            Case 1
                enemypokemon1 = frmMainMenu.Magmar
                enemypokemon2 = frmMainMenu.Flareon
                frmInBattle.enemypokemon2U = True
                frmInBattle.enemypokemon3U = False
                frmInBattle.enemypokemon4U = False
                frmInBattle.enemypokemon5U = False
                frmInBattle.enemypokemon6U = False
                strong = True
                trainer = "Gym 3.2"
            Case 2
                enemypokemon1 = frmMainMenu.Charizard
                enemypokemon2 = frmMainMenu.Arcanine
                enemypokemon3 = frmMainMenu.Rapidash
                frmInBattle.enemypokemon2U = True
                frmInBattle.enemypokemon3U = True
                frmInBattle.enemypokemon4U = False
                frmInBattle.enemypokemon5U = False
                frmInBattle.enemypokemon6U = False
                gymleader = True
                trainer = "Gym 3.0"
        End Select
        gym3c += 1
        frmTrainerBattleStart.Show()
    End Sub

    Private Sub btnRoute7_Click(sender As Object, e As EventArgs) Handles btnRoute7.Click

        trainerbattle = False
        legendary = False
        gymleader = False
        strong = False
        champ = False
        mewtwo = False
        elite = False
        Randomize()

        'If frmMainMenu.route7counter < 3 Then

        'num = Int(7 * Rnd(1))

        'Select Case num
        '	Case 1
        '		enemypokemon1 = frmMainMenu.Vileplume
        '	Case 2
        '		enemypokemon1 = frmMainMenu.Poliwag
        '	Case 3
        '		enemypokemon1 = frmMainMenu.Poliwhirl
        '	Case 4
        '		enemypokemon1 = frmMainMenu.Seel
        '	Case 5
        '		enemypokemon1 = frmMainMenu.Shellder
        '	Case 6
        '		enemypokemon1 = frmMainMenu.Krabby
        '	Case 0
        '		enemypokemon1 = frmMainMenu.Magikarp
        'End Select

        'frmMainMenu.route7counter += 1

        'Else

        'num = int(12 * Rnd(1))
        'End If

        'Select Case num
        '	Case 1
        '		enemypokemon1 = frmMainMenu.Vileplume
        '	Case 2
        '		enemypokemon1 = frmMainMenu.Poliwag
        '	Case 3
        '		enemypokemon1 = frmMainMenu.Poliwhirl
        '	Case 4
        '		enemypokemon1 = frmMainMenu.Seel
        '	Case 5
        '		enemypokemon1 = frmMainMenu.Shellder
        '	Case 6
        '		enemypokemon1 = frmMainMenu.Krabby
        '	Case 7
        '		enemypokemon1 = frmMainMenu.Magikarp
        '	Case 8
        '		enemypokemon1 = frmMainMenu.Poliwrath
        '	Case 9
        '		enemypokemon1 = frmMainMenu.Dewgong
        '	Case 10
        '		enemypokemon1 = frmMainMenu.Kingler
        '	Case 11
        '		enemypokemon1 = frmMaineMenu.Lapras
        '	Case 0
        '		pokeon1 = frmMainMenu.Vaporeon
        'End Select


        frmInBattle.Show()

    End Sub

    Private Sub btnTrainer7_Click(sender As Object, e As EventArgs) Handles btnTrainer7.Click

        trainerbattle = True
        legendary = False
        gymleader = False
        strong = False
        champ = False
        mewtwo = False
        elite = False

        enemypokemon1 = frmMainMenu.Exeggutor
        enemypokemon2 = frmMainMenu.Butterfree
        frmInBattle.enemypokemon2U = True
        enemypokemon3 = frmMainMenu.Sandslash
        frmInBattle.enemypokemon3U = True
        frmInBattle.enemypokemon4U = False
        frmInBattle.enemypokemon5U = False
        frmInBattle.enemypokemon6U = False
        trainer = "Tammy"
        frmTrainerBattleStart.Show()

    End Sub

    Private Sub btnGym4_Click(sender As Object, e As EventArgs) Handles btnGym4.Click

        trainerbattle = True
        legendary = False
        gymleader = False
        strong = False
        champ = False
        mewtwo = False
        elite = False

        Select Case gym4c
            Case 0
                enemypokemon1 = frmMainMenu.Seel
                enemypokemon2 = frmMainMenu.Tentacruel
                enemypokemon3 = frmMainMenu.Seel
                frmInBattle.enemypokemon2U = True
                frmInBattle.enemypokemon3U = True
                frmInBattle.enemypokemon4U = False
                frmInBattle.enemypokemon5U = False
                frmInBattle.enemypokemon6U = False
                strong = True
                trainer = "Gym 4.1"
            Case 1
                enemypokemon1 = frmMainMenu.Kingler
                enemypokemon2 = frmMainMenu.Staryu
                enemypokemon3 = frmMainMenu.Goldeen
                frmInBattle.enemypokemon2U = True
                frmInBattle.enemypokemon3U = True
                frmInBattle.enemypokemon4U = False
                frmInBattle.enemypokemon5U = False
                frmInBattle.enemypokemon6U = False
                strong = True
                trainer = "Gym 4.2"
            Case 2
                enemypokemon1 = frmMainMenu.Dewgong
                enemypokemon2 = frmMainMenu.Lapras
                enemypokemon3 = frmMainMenu.Cloyster
                enemypokemon4 = frmMainMenu.Gyarados
                frmInBattle.enemypokemon2U = True
                frmInBattle.enemypokemon3U = True
                frmInBattle.enemypokemon4U = True
                frmInBattle.enemypokemon5U = False
                frmInBattle.enemypokemon6U = False
                gymleader = True
                trainer = "Gym 4.0"
        End Select
        gym4c += 1
        frmTrainerBattleStart.Show()

    End Sub

    Private Sub btnRoute8_Click(sender As Object, e As EventArgs) Handles btnRoute8.Click

        trainerbattle = False
        legendary = False
        gymleader = False
        strong = False
        champ = False
        mewtwo = False
        elite = False

        Randomize()

        num = Int(11 * Rnd(1))

        Select Case num
            Case 1
                enemypokemon1 = frmMainMenu.Arbok
            Case 2
                enemypokemon1 = frmMainMenu.Clefairy
            Case 3
                enemypokemon1 = frmMainMenu.Clefable
            Case 4
                enemypokemon1 = frmMainMenu.Jigglypuff
            Case 5
                enemypokemon1 = frmMainMenu.Wigglytuff
            Case 6
                enemypokemon1 = frmMainMenu.Venomoth
            Case 7
                enemypokemon1 = frmMainMenu.Abra
            Case 8
                enemypokemon1 = frmMainMenu.Kadabra
            Case 9
                enemypokemon1 = frmMainMenu.Doduo
            Case 10
                enemypokemon1 = frmMainMenu.Dodrio
            Case 0
                enemypokemon1 = frmMainMenu.Tauros
        End Select

        frmInBattle.Show()

    End Sub

    Private Sub btnTrainer8_Click(sender As Object, e As EventArgs) Handles btnTrainer8.Click

        trainerbattle = True
        legendary = False
        gymleader = False
        strong = False
        champ = False
        mewtwo = False
        elite = False

        enemypokemon1 = frmMainMenu.Tauros
        enemypokemon2 = frmMainMenu.Eevee
        frmInBattle.enemypokemon2U = True
        enemypokemon3 = frmMainMenu.Parasect
        frmInBattle.enemypokemon3U = True
        enemypokemon4 = frmMainMenu.Gloom
        frmInBattle.enemypokemon4U = True
        frmInBattle.enemypokemon5U = False
        frmInBattle.enemypokemon6U = False
        trainer = "Brenna"
        frmTrainerBattleStart.Show()

    End Sub

    Private Sub BtnBirdNest_Click(sender As Object, e As EventArgs) Handles btnBirdNest.Click
        trainerbattle = False
        legendary = True
        gymleader = False
        strong = False
        champ = False
        mewtwo = False
        elite = False
        Randomize()

        num = Int(3 * Rnd(1))

        Select Case num
            Case 1
                enemypokemon1 = frmMainMenu.Moltres
            Case 2
                enemypokemon1 = frmMainMenu.Zapdos
            Case 0
                enemypokemon1 = frmMainMenu.Articuno
        End Select

        frmInBattle.Show()

    End Sub

    Private Sub btnRoute9_Click(sender As Object, e As EventArgs) Handles btnRoute9.Click

        trainerbattle = False
        legendary = False
        gymleader = False
        strong = False
        champ = False
        mewtwo = False
        elite = False

        Randomize()

        num = Int(16 * Rnd(1))

        Select Case num
            Case 1
                enemypokemon1 = frmMainMenu.Psyduck
            Case 2
                enemypokemon1 = frmMainMenu.Golduck
            Case 3
                enemypokemon1 = frmMainMenu.Machop
            Case 4
                enemypokemon1 = frmMainMenu.Machoke
            Case 5
                enemypokemon1 = frmMainMenu.Psyduck
            Case 6
                enemypokemon1 = frmMainMenu.Arbok
            Case 7
                enemypokemon1 = frmMainMenu.Clefairy
            Case 8
                enemypokemon1 = frmMainMenu.Clefable
            Case 9
                enemypokemon1 = frmMainMenu.Jigglypuff
            Case 10
                enemypokemon1 = frmMainMenu.Wigglytuff
            Case 11
                enemypokemon1 = frmMainMenu.Venomoth
            Case 12
                enemypokemon1 = frmMainMenu.Abra
            Case 13
                enemypokemon1 = frmMainMenu.Kadabra
            Case 14
                enemypokemon1 = frmMainMenu.Doduo
            Case 15
                enemypokemon1 = frmMainMenu.Dodrio
            Case 0
                enemypokemon1 = frmMainMenu.Tauros
        End Select

        frmInBattle.Show()

    End Sub

    Private Sub btnGym5_Click(sender As Object, e As EventArgs) Handles btnGym5.Click

        trainerbattle = True
        legendary = False
        gymleader = True
        strong = False
        champ = False
        mewtwo = False
        elite = False

        enemypokemon1 = frmMainMenu.Dragonair
        enemypokemon2 = frmMainMenu.Charizard
        enemypokemon3 = frmMainMenu.Arbok
        enemypokemon4 = frmMainMenu.Gyarados
        enemypokemon5 = frmMainMenu.Dragonite
        frmInBattle.enemypokemon2U = True
        frmInBattle.enemypokemon3U = True
        frmInBattle.enemypokemon4U = True
        frmInBattle.enemypokemon5U = True
        frmInBattle.enemypokemon6U = False

        trainer = "Gym 5.0"
        frmTrainerBattleStart.Show()

    End Sub

    Private Sub btnVictoryRoad_Click(sender As Object, e As EventArgs) Handles btnVictoryRoad.Click

        trainerbattle = False
        legendary = False
        gymleader = False
        strong = False
        champ = False
        mewtwo = False
        elite = False

        Randomize()

        num = Int(8 * Rnd(1))

        Select Case num
            Case 1
                enemypokemon1 = frmMainMenu.Snorlax
            Case 2
                enemypokemon1 = frmMainMenu.Dragonair
            Case 3
                enemypokemon1 = frmMainMenu.Dragonite
            Case 4
                enemypokemon1 = frmMainMenu.Alakazam
            Case 5
                enemypokemon1 = frmMainMenu.Golem
            Case 6
                enemypokemon1 = frmMainMenu.Onix
            Case 7
                enemypokemon1 = frmMainMenu.Kangaskhan
            Case 0
                enemypokemon1 = frmMainMenu.Machamp
        End Select

        frmInBattle.Show()

    End Sub

    Private Sub btnTrainerV_Click(sender As Object, e As EventArgs) Handles btnTrainerV.Click

        trainerbattle = True
        legendary = False
        gymleader = False
        strong = False
        champ = False
        mewtwo = False
        elite = False

        enemypokemon1 = frmMainMenu.Blastoise
        enemypokemon2 = frmMainMenu.Charizard
        frmInBattle.enemypokemon2U = True
        enemypokemon3 = frmMainMenu.Venusaur
        frmInBattle.enemypokemon3U = True
        enemypokemon4 = frmMainMenu.Magikarp
        frmInBattle.enemypokemon4U = True
        frmInBattle.enemypokemon5U = False
        frmInBattle.enemypokemon6U = False
        trainer = "V"
        frmTrainerBattleStart.Show()

    End Sub

    Private Sub btnLeague_Click(sender As Object, e As EventArgs) Handles btnLeague.Click

        trainerbattle = True
        legendary = False
        gymleader = False
        strong = False
        champ = True
        mewtwo = False
        elite = False

        enemypokemon1 = frmMainMenu.Ryu
        frmInBattle.enemypokemon2U = True
        enemypokemon2 = frmMainMenu.Ken
        frmInBattle.enemypokemon3U = True
        enemypokemon3 = frmMainMenu.Blanka
        frmInBattle.enemypokemon4U = True
        enemypokemon4 = frmMainMenu.MBison
        frmInBattle.enemypokemon5U = True
        enemypokemon5 = frmMainMenu.Akuma
        frmInBattle.enemypokemon6U = True
        enemypokemon6 = frmMainMenu.Balrog

        frmInBattle.Show()

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click

        trainerbattle = False
        legendary = False
        gymleader = False
        strong = False
        champ = False
        mewtwo = True
        elite = False

        enemypokemon1 = frmMainMenu.Mewtwo 'make him powerful or something
        frmInBattle.Show()

    End Sub
End Class