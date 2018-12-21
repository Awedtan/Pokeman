Public Class frmInBattle
    Dim yourturn As Boolean
    Dim status As Integer
    Dim movetype As Integer
    'burn, freeze, paralyze, poison, badly poisoned, sleep, confused, bound, LS, 
    '  1     2        3         4           5          6      7          8    9

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

    Function DAttackS(ByVal yourtype As Integer) As Integer
        DAttackS = 3
        Select Case yourtype
            Case 1
                Select Case enemypokemon(8)
                    Case 4, 5, 6, 8
                        DAttackS -= 1
                    Case 7, 12, 13
                        DAttackS += 1
                End Select
                Select Case enemypokemon(9)
                    Case 4, 5, 6, 8
                        DAttackS -= 1
                    Case 7, 12, 13
                        DAttackS += 1
                End Select

            Case 2
                Select Case enemypokemon(8)
                    Case 2
                        DAttackS += 1
                End Select
                Select Case enemypokemon(9)
                    Case 2
                        DAttackS += 1
                End Select

            Case 3
                Select Case enemypokemon(8)
                    Case 15
                        DAttackS -= 1
                    Case 2, 6, 7, 9,
                         DAttackS = DAttackS + 1
                End Select
                Select Case enemypokemon(9)
                    Case 15
                        DAttackS -= 1
                    Case 2, 6, 7, 9,
                         DAttackS = DAttackS + 1
                End Select

            Case 4
                Select Case enemypokemon(8)
                    Case 6, 12, 1, 13
                        DAttackS -= 1
                    Case 11, 14, 3
                        DAttackS += 1
                    Case 8
                        DAttackS -= 10
                End Select
                Select Case enemypokemon(9)
                    Case 6, 12, 1, 13
                        DAttackS -= 1
                    Case 11, 14, 3
                        DAttackS += 1
                    Case 8
                        DAttackS -= 10
                End Select

            Case 5
                Select Case enemypokemon(8)
                    Case 14, 5, 15, 2
                        DAttackS -= 1
                    Case 1, 7, 3
                        DAttackS += 1
                End Select
                Select Case enemypokemon(9)
                    Case 14, 5, 15, 2
                        DAttackS -= 1
                    Case 1, 7, 3
                        DAttackS += 1
                End Select

            Case 6
                Select Case enemypokemon(8)
                    Case 14, 10
                        DAttackS -= 1
                    Case 4, 1, 7
                        DAttackS += 1
                End Select
                Select Case enemypokemon(9)
                    Case 14, 10
                        DAttackS -= 1
                    Case 4, 1, 7
                        DAttackS += 1
                End Select
            Case 7
                Select Case enemypokemon(8)
                    Case 6, 12, 1, 5, 7, 2
                        DAttackS -= 1
                    Case 9, 14, 15
                        DAttackS += 1
                End Select
                Select Case enemypokemon(9)
                    Case 6, 12, 1, 5, 7, 2
                        DAttackS -= 1
                    Case 9, 14, 15
                        DAttackS += 1
                End Select
            Case 8
                Select Case enemypokemon(8)
                    Case 11, 13
                        DAttackS -= 10
                    Case 8
                        DAttackS += 1
                End Select
                Select Case enemypokemon(9)
                    Case 11, 13
                        DAttackS -= 10
                    Case 8
                        DAttackS += 1
                End Select
            Case 9
                Select Case enemypokemon(8)
                    Case 6
                        DAttackS -= 10
                    Case 1, 7
                        DAttackS -= 1
                    Case 12, 14, 5, 10
                        DAttackS += 1
                End Select
                Select Case enemypokemon(9)
                    Case 6
                        DAttackS -= 10
                    Case 1, 7
                        DAttackS -= 1
                    Case 12, 14, 5, 10
                        DAttackS += 1
                End Select
            Case 10
                Select Case enemypokemon(8)
                    Case 9
                        DAttackS -= 10
                    Case 7, 10, 2
                        DAttackS -= 1
                    Case 6, 15
                        DAttackS += 1
                End Select
                Select Case enemypokemon(9)
                    Case 9
                        DAttackS -= 10
                    Case 7, 10, 2
                        DAttackS -= 1
                    Case 6, 15
                        DAttackS += 1
                End Select
            Case 11
                Select Case enemypokemon(8)
                    Case 14
                        DAttackS -= 1
                    Case 8
                        DAttackS -= 10
                End Select
                Select Case enemypokemon(9)
                    Case 14
                        DAttackS -= 1
                    Case 8
                        DAttackS -= 10
                End Select
            Case 12
                Select Case enemypokemon(8)
                    Case 12, 9, 14, 8
                        DAttackS -= 1
                    Case 1, 7
                        DAttackS += 1
                End Select
                Select Case enemypokemon(9)
                    Case 12, 9, 14, 8
                        DAttackS -= 1
                    Case 1, 7
                        DAttackS += 1
                End Select
            Case 13
                Select Case enemypokemon(8)
                    Case 13
                        DAttackS -= 1
                    Case 4, 12,
                         DAttackS = DAttackS + 1
                End Select
                Select Case enemypokemon(9)
                    Case 13
                        DAttackS -= 1
                    Case 4, 12,
                         DAttackS = DAttackS + 1
                End Select
            Case 14
                Select Case enemypokemon(8)
                    Case 4, 9
                        DAttackS -= 1
                    Case 6, 1, 3
                        DAttackS += 1
                End Select
                Select Case enemypokemon(9)
                    Case 4, 9
                        DAttackS -= 1
                    Case 6, 1, 3
                        DAttackS += 1
                End Select
            Case 15
                Select Case enemypokemon(8)
                    Case 15, 7, 2
                        DAttackS -= 1
                    Case 9, 14, 5
                        DAttackS += 1
                End Select
        End Select
    End Function

    Dim yourpokemon() As String = frmMainMenu.yourpokemon1
    Dim enemypokemon() As String = frmMainMenu.Squirtle

    Dim yourpokemonstat() As String = yourpokemon
    Dim enemypokemonstat() As String = enemypokemon

    Dim EYourPokemon() As String
    Dim EEnemyPokemon() As String
    Dim TempSwapStat() As String

    Dim tempattack As Double
    Dim tempspecial As Double
    ' tempattack = tempattack * 2
    'tempspecial = tempspecial * 2

    Dim enemypokemon1inbattle(14) As String
    Dim enemypokemon2inbattle(14) As String
    Dim enemypokemon3inbattle(14) As String
    Dim enemypokemon4inbattle(14) As String
    Dim enemypokemon5inbattle(14) As String
    Dim enemypokemon6inbattle(14) As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMove1.Click
        Dim tempattack As Double
        Dim tempspecial As Double
        Dim chance As Integer

        Select Case yourpokemon(10)
            Case "Absorb"
                Select Case DAttackS(7)
                    Case 1
                        tempattack = yourpokemon(2) / 4
                        tempspecial = yourpokemon(5) / 4
                    Case 2
                        tempattack = yourpokemon(2) / 2
                        tempspecial = yourpokemon(5) / 2
                    Case 3
                        tempattack = yourpokemon(2)
                        tempspecial = yourpokemon(5)
                    Case 4
                        tempattack = yourpokemon(2) * 2
                        tempspecial = yourpokemon(5) * 2
                    Case 5
                        tempattack = yourpokemon(2) * 4
                        tempspecial = yourpokemon(5) * 4
                    Case DAttackS(7) < 0
                        tempattack = 0
                        tempspecial = 0
                End Select
                enemypokemon(1) -= tempspecial * 10 / enemypokemon(5)
                yourpokemon(1) += tempspecial * 5 / enemypokemon(5) / 2

                lblYHp.Text = yourpokemon(1)
                lblEHp.Text = enemypokemon(1)
            Case "Acid"
                Select Case DAttackS(12)
                    Case 1
                        tempattack = yourpokemon(2) / 4
                        tempspecial = yourpokemon(5) / 4
                    Case 2
                        tempattack = yourpokemon(2) / 2
                        tempspecial = yourpokemon(5) / 2
                    Case 3
                        tempattack = yourpokemon(2)
                        tempspecial = yourpokemon(5)
                    Case 4
                        tempattack = yourpokemon(2) * 2
                        tempspecial = yourpokemon(5) * 2
                    Case 5
                        tempattack = yourpokemon(2) * 4
                        tempspecial = yourpokemon(5) * 4
                    Case DAttackS(7) < 0
                        tempattack = 0
                        tempspecial = 0
                End Select
                enemypokemon(1) -= tempspecial * 15 / enemypokemon(5)
                chance = 1 + Rnd() * 3
                If chance = 1 Then
                    enemypokemon(3) -= enemypokemonstat(3) / 2
                    Label7.Text = "Enemy Defence Was Lowered by 1 Stage!"
                End If

                lblYHp.Text = yourpokemon(1)
                lblEHp.Text = enemypokemon(1)
            Case "Acid Armor"
                yourpokemon(3) += yourpokemonstat(3)
                Label7.Text = "Your defence went up by 2 stages!"
            Case "Agility"
                yourpokemon(4) += yourpokemonstat(4)
                Label7.Text = "Your speed went up by 2 stages!"
            Case "Amnesia"
                yourpokemon(5) += yourpokemonstat(5)
                Label7.Text = "Your special went up by 2 stages!"
            Case "Aurora Beam"
                Select Case DAttackS(3)
                    Case 1
                        tempattack = yourpokemon(2) / 4
                        tempspecial = yourpokemon(5) / 4
                    Case 2
                        tempattack = yourpokemon(2) / 2
                        tempspecial = yourpokemon(5) / 2
                    Case 3
                        tempattack = yourpokemon(2)
                        tempspecial = yourpokemon(5)
                    Case 4
                        tempattack = yourpokemon(2) * 2
                        tempspecial = yourpokemon(5) * 2
                    Case 5
                        tempattack = yourpokemon(2) * 4
                        tempspecial = yourpokemon(5) * 4
                    Case DAttackS(7) < 0
                        tempattack = 0
                        tempspecial = 0
                End Select
                enemypokemon(1) -= tempspecial * 32.5 / enemypokemon(5)
                chance = 1 + Rnd() * 3
                If chance = 1 Then
                    enemypokemon(2) -= enemypokemonstat(2) / 2
                    Label7.Text = "Enemy Attack Was Lowered by 1 Stage!"
                End If

                lblYHp.Text = yourpokemon(1)
                lblEHp.Text = enemypokemon(1)
            Case "Barrage"
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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        lblYName.Text = yourpokemon(0)
        lblYHp.Text = yourpokemon(1)
        lblEName.Text = enemypokemon(0)
        lblEHp.Text = enemypokemon(1)
    End Sub
End Class
