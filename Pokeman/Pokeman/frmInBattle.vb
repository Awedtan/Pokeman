﻿Public Class frmInBattle
    Dim yourturn As Boolean

    Dim movetype As Integer
    'burn, freeze, paralyze, poison, badly poisoned, sleep, confused, bound, LS, flinch
    '  1     2        3         4           5          6      7          8    9, 10

    Dim yboundcounter As Integer 'for clamp, also no attacking
    Dim eboundcounter As Integer
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

    Dim yourpokemon() As String = frmMainMenu.Pidgeot 'functional changing stats
    Dim enemypokemon() As String = frmMainMenu.Squirtle

    Dim yourpokemonstat() As String = frmMainMenu.Pidgeot 'just so stat boosting moves have a base value to work off of
    Dim enemypokemonstat() As String = frmMainMenu.Squirtle

	Dim enemymaxhp As Integer = frmMainMenu.Squirtle(1)
	Dim yourmaxhp As Integer = frmMainMenu.Pidgeot(1)

	Dim EYourPokemon() As String
    Dim EEnemyPokemon() As String
    Dim TempSwapStat() As String

    Dim tempattack As Double 'for super effective moves
    Dim tempspecial As Double
    ' tempattack = tempattack * 2
    'tempspecial = tempspecial * 2

    Dim enemypokemon1inbattle() As String = enemypokemon
    Dim enemypokemon2inbattle(14) As String
    Dim enemypokemon3inbattle(14) As String
    Dim enemypokemon4inbattle(14) As String
    Dim enemypokemon5inbattle(14) As String
    Dim enemypokemon6inbattle(14) As String

    Dim countBarrage As Integer
    Dim countFuryAttack As Integer
    Dim countFurySwipes As Integer
    Dim countPinMissile As Integer
    Dim countSpikeCannon As Integer
    Dim countHurricaneKick As Integer
    Dim countDoubleSlap As Integer
    Dim tempcounter As Integer = 1

    Dim yHBcharge As Boolean
    Dim ySBcharge As Boolean
    Dim yDigcharge As Boolean
    Dim yFlycharge As Boolean

    Dim eHBcharge As Boolean
    Dim eSBcharge As Boolean
    Dim eDigcharge As Boolean
    Dim eFlycharge As Boolean

    Dim yflinch As Boolean = True
    Dim eflinch As Boolean = False
    Dim ystatus As Integer
    Dim estatus As Integer

    Dim payday As Boolean

    Dim movecat As Integer ' 1 = damaging, 2 = selfstatus, 3 = estatus
	Dim counter As Integer

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMove1.Click
        ' If yourpokemon(4) >= enemypokemon(4) Then
        yourturn = True
        counter = 0
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
                    tempcounter = 1
                    chance = 1 + Rnd() * 8
                    Select Case chance
                        Case 1, 2, 3
                            TimerBarrage.Enabled = True
                            countBarrage = 2
                        Case 4, 5, 6
                            TimerBarrage.Enabled = True
                            countBarrage = 3
                        Case 7
                            TimerBarrage.Enabled = True
                            countBarrage = 4
                        Case 8
                            TimerBarrage.Enabled = True
                            countBarrage = 5
                    End Select
                Case "Barrier"
                    yourpokemon(3) += yourpokemonstat(3)
                    Label7.Text = "Your defense went up by 2 stages!"
                Case "Bide"

                Case "Bite"
                    Select Case DAttackS(11)
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
                    enemypokemon(1) -= tempattack * 30 / enemypokemon(3)
                    chance = 1 + Rnd() * 10
                    If chance = 1 Then

                        If yourturn = False Then
                            yflinch = True
                            Label7.Text = "Your Pokemon flinched!"
                        ElseIf yourturn = True Then
                            eflinch = True
                            Label7.Text = "The enemy flinched!"
                        End If
                    End If
                Case "Blizzard"
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
                    enemypokemon(1) -= tempspecial * 65 / enemypokemon(5)
                    chance = 1 + Rnd() * 10
                    If chance = 1 Then
                        If yourturn = True Then
                            Label7.Text = "The enemy was frozen!"
                            estatus = 2
                        ElseIf yourturn = False Then
                            Label7.Text = "Your Pokemon was frozen!"
                            ystatus = 2
                        End If
                    End If
                Case "Body Slam"
                    Select Case DAttackS(11)
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
                    enemypokemon(1) -= tempattack * 42.5 / enemypokemon(3)
                    chance = 1 + Rnd() * 10
                    If chance = 1 Or 2 Or 3 Then
                        If yourturn = False Then
                            ystatus = 3
                            Label7.Text = "Your Pokemon was paralyzed!"
                        ElseIf yourturn = True Then
                            estatus = 3
                            Label7.Text = "The enemy was paralyzed!"
                        End If
                    End If
                Case "Bone Club"
                    Select Case DAttackS(9)
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
                    enemypokemon(1) -= tempattack * 32.5 / enemypokemon(3)
                    chance = 1 + Rnd() * 10
                    If chance = 1 Then
                        If yourturn = False Then
                            yflinch = True
                            Label7.Text = "Your Pokemon flinched!"
                        ElseIf yourturn = True Then
                            eflinch = True
                            Label7.Text = "The enemy flinched!"
                        End If
                    End If
                Case "Bonemerang"
                    TimerBonemerang.Enabled = True
                    tempcounter = 1
                Case "Bubble"
                    Select Case DAttackS(15)
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
                    chance = 1 + Rnd() * 3
                    If chance = 1 Then
                        enemypokemon(4) -= enemypokemonstat(4) / 2
                        Label7.Text = "Enemy Speed Was Lowered by 1 Stage!"
                    End If
                Case "Clamp"
                    Select Case DAttackS(15)
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
                    enemypokemon(1) -= tempattack * 17.5 / enemypokemon(3)
                    chance = 1 + Rnd() * 8
                    If yourturn = True Then
                        Select Case chance
                            Case 1, 2, 3
                                eboundcounter = 2
                            Case 4, 5, 6
                                eboundcounter = 3
                            Case 7
                                eboundcounter = 4
                            Case 8
                                eboundcounter = 5
                        End Select
                    ElseIf yourturn = False Then
                        Select Case chance
                            Case 1, 2, 3
                                yboundcounter = 2
                            Case 4, 5, 6
                                yboundcounter = 3
                            Case 7
                                yboundcounter = 4
                            Case 8
                                yboundcounter = 5
                        End Select
                    End If
                Case "Confuse Ray"
                    If yourturn = True Then
                        Label7.Text = "The enemy was Confused!"
                        estatus = 7
                    ElseIf yourturn = False Then
                        Label7.Text = "Your Pokemon was Confused!"
                        ystatus = 7
                    End If
                Case "Confusion"
                    Select Case DAttackS(13)
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
                    enemypokemon(1) -= tempspecial * 25 / enemypokemon(5)
                    chance = 1 + Rnd() * 10
                    If chance = 1 Then
                        If yourturn = True Then
                            Label7.Text = "The enemy was Confused!"
                            estatus = 7
                        ElseIf yourturn = False Then
                            Label7.Text = "Your Pokemon was Confused!"
                            ystatus = 7
                        End If
                    End If
                Case "Crabhammer"
                    Select Case DAttackS(15)
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
                    enemypokemon(1) -= tempattack * 50 / enemypokemon(3)
                Case "Cut"
                    Select Case DAttackS(11)
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
                    enemypokemon(1) -= tempattack * 25 / enemypokemon(3)
                Case "Defense Curl"
                    yourpokemon(3) += yourpokemonstat(3) / 2
                    Label7.Text = "Your defense went up by 1 stage!"
                Case "Dig"
                    If yourturn = True Then
                        yDigcharge = 1
                    ElseIf yourturn = False Then
                        eDigcharge = 1
                    End If
                Case "Disable"
                Case "Dizzy Punch"
                    Select Case DAttackS(11)
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
                    enemypokemon(1) -= tempattack * 35 / enemypokemon(3)
                Case "Double Kick"
                    TimerDoubleKick.Enabled = True
                    tempcounter = 1
                Case "Double Slap"
                    tempcounter = 1
                    chance = 1 + Rnd() * 8
                    Select Case chance
                        Case 1, 2, 3
                            TimerDoubleSlap.Enabled = True
                            countDoubleSlap = 2
                        Case 4, 5, 6
                            TimerDoubleSlap.Enabled = True
                            countDoubleSlap = 3
                        Case 7
                            TimerDoubleSlap.Enabled = True
                            countDoubleSlap = 4
                        Case 8
                            TimerDoubleSlap.Enabled = True
                            countDoubleSlap = 5
                    End Select
                Case "Double Team"
                    yourpokemon(4) += yourpokemonstat(4) / 2
                    Label7.Text = "Your speed went up by 1 stage!"
                Case "Double-Edge"
                    Select Case DAttackS(11)
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
                    enemypokemon(1) -= tempattack * 60 / enemypokemon(3)
                    yourpokemon(1) -= tempattack * 15 / enemypokemon(3)
                Case "Dream Eater"
                    If yourturn = True Then
                        If estatus = 6 Then
                            Select Case DAttackS(13)
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
                            enemypokemon(1) -= tempspecial * 50 / enemypokemon(5)
                            yourpokemon(1) = +tempspecial * 50 / enemypokemon(5)
                        ElseIf estatus <> 6 Then
                            Label7.Text = "The attack failed!"
                        End If
                    ElseIf yourturn = False Then
                        If ystatus = 6 Then
                            Select Case DAttackS(13)
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
                            enemypokemon(1) -= tempspecial * 50 / enemypokemon(5)
                            yourpokemon(1) = +tempspecial * 50 / enemypokemon(5)
                        ElseIf ystatus <> 6 Then
                            Label7.Text = "The attack failed!"
                        End If
                    End If
                Case "Drill Peck"
                    Select Case DAttackS(6)
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
                    enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                Case "Earthquake"
                    Select Case DAttackS(9)
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
                    enemypokemon(1) -= tempattack * 50 / enemypokemon(3)
                Case "Egg Bomb"
                    Select Case DAttackS(11)
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
                    enemypokemon(1) -= tempattack * 50 / enemypokemon(3)
                Case "Ember"
                    Select Case DAttackS(5)
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
                    enemypokemon(1) -= tempspecial * 20 / enemypokemon(5)
                    chance = 1 + Rnd() * 10
                    If chance = 1 Then
                        If yourturn = True Then
                            Label7.Text = "The enemy was Burned!"
                            estatus = 1
                        ElseIf yourturn = False Then
                            Label7.Text = "Your Pokemon was Burned!"
                            ystatus = 1
                        End If
                    End If
                Case "Explosion"
                    Select Case DAttackS(11)
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
                    enemypokemon(1) -= tempattack * 170 / enemypokemon(3)
                    yourpokemon(1) = 0
                Case "Fire Blast"
                    Select Case DAttackS(5)
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
                    enemypokemon(1) -= tempspecial * 60 / enemypokemon(5)
                    chance = 1 + Rnd() * 3
                    If chance = 1 Then
                        If yourturn = True Then
                            Label7.Text = "The enemy was Burned!"
                            estatus = 1
                        ElseIf yourturn = False Then
                            Label7.Text = "Your Pokemon was Burned!"
                            ystatus = 1
                        End If
                    End If
                Case "Fire Punch"
                    Select Case DAttackS(5)
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
                    enemypokemon(1) -= tempattack * 37.5 / enemypokemon(3)
                    chance = 1 + Rnd() * 10
                    If chance = 1 Then
                        If yourturn = True Then
                            Label7.Text = "The enemy was Burned!"
                            estatus = 1
                        ElseIf yourturn = False Then
                            Label7.Text = "Your Pokemon was Burned!"
                            ystatus = 1
                        End If
                    End If
                Case "Fire Spin"
                    Select Case DAttackS(5)
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
                    enemypokemon(1) -= tempattack * 17.5 / enemypokemon(3)
                    chance = 1 + Rnd() * 8
                    If yourturn = True Then
                        Select Case chance
                            Case 1, 2, 3
                                eboundcounter = 2
                            Case 4, 5, 6
                                eboundcounter = 3
                            Case 7
                                eboundcounter = 4
                            Case 8
                                eboundcounter = 5
                        End Select
                    ElseIf yourturn = False Then
                        Select Case chance
                            Case 1, 2, 3
                                yboundcounter = 2
                            Case 4, 5, 6
                                yboundcounter = 3
                            Case 7
                                yboundcounter = 4
                            Case 8
                                yboundcounter = 5
                        End Select
                    End If
                Case "Flamethrower"
                    Select Case DAttackS(5)
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
                    enemypokemon(1) -= tempspecial * 47.5 / enemypokemon(5)
                    chance = 1 + Rnd() * 10
                    If chance = 1 Then
                        If yourturn = True Then
                            Label7.Text = "The enemy was Burned!"
                            estatus = 1
                        ElseIf yourturn = False Then
                            Label7.Text = "Your Pokemon was Burned!"
                            ystatus = 1
                        End If
                    End If
                Case "Flash"
                    enemypokemon(4) -= enemypokemonstat(4) / 2
                    Label7.Text = "The Enemy's speed fell by 1 stage!"
                Case "Fly"
                    If yourturn = True Then
                        yflycharge = 1
                    ElseIf yourturn = False Then
                        eflycharge = 1
                    End If
                Case "Focus Energy"
                    yourpokemon(4) += yourpokemonstat(4) / 2
                    yourpokemon(2) += yourpokemonstat(2) / 2
                    yourpokemon(5) += yourpokemonstat(5) / 2
                    Label7.Text = "Your pokemon is getting pumped!"
                Case "Fury Attack"
                    tempcounter = 1
                    chance = 1 + Rnd() * 8
                    Select Case chance
                        Case 1, 2, 3
                            TimerFuryAttack.Enabled = True
                            countFuryAttack = 2
                        Case 4, 5, 6
                            TimerFuryAttack.Enabled = True
                            countFuryAttack = 3
                        Case 7
                            TimerFuryAttack.Enabled = True
                            countFuryAttack = 4
                        Case 8
                            TimerFuryAttack.Enabled = True
                            countFuryAttack = 5
                    End Select
                Case "Fury Swipes"
                    tempcounter = 1
                    chance = 1 + Rnd() * 8
                    Select Case chance
                        Case 1, 2, 3
                            TimerFurySwipes.Enabled = True
                            countFurySwipes = 2
                        Case 4, 5, 6
                            TimerFurySwipes.Enabled = True
                            countFurySwipes = 3
                        Case 7
                            TimerFurySwipes.Enabled = True
                            countFurySwipes = 4
                        Case 8
                            TimerFurySwipes.Enabled = True
                            countFurySwipes = 5
                    End Select
                Case "Glare"
                    If yourturn = True Then
                        Label7.Text = "The enemy was Paralyzed!"
                        estatus = 3
                    ElseIf yourturn = False Then
                        Label7.Text = "Your Pokemon was Paralyzed!"
                        ystatus = 3
                    End If
                Case "Growl"
                    enemypokemon(2) -= enemypokemonstat(2) / 2
                    Label7.Text = "Enemy Attack Was Lowered by 1 Stage!"
                Case "Growth"
                    yourpokemon(5) += yourpokemonstat(5) / 2
                    Label7.Text = "Your special went up by 1 stage!"
                Case "Guillotine"
                    chance = 1 + Rnd() * 3
                    If chance = 1 Then
                        enemypokemon(1) = 0
                    End If
                Case "Gust"
                    Select Case DAttackS(11)
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
                    enemypokemon(1) -= tempattack * 20 / enemypokemon(3)
                Case "Harden"
                    yourpokemon(3) += yourpokemonstat(3) / 2
                    Label7.Text = "Your Defense went up by 1 stage!"
                Case "Haze"
                    enemypokemon(2) = enemypokemonstat(2)
                    enemypokemon(3) = enemypokemonstat(3)
                    enemypokemon(4) = enemypokemonstat(4)
                    enemypokemon(5) = enemypokemonstat(5)

                    yourpokemon(2) = yourpokemonstat(2)
                    yourpokemon(3) = yourpokemonstat(3)
                    yourpokemon(4) = yourpokemonstat(4)
                    yourpokemon(5) = yourpokemonstat(5)

                    Label7.Text = "Stats have been reset!"

                Case "Headbutt"
                    Select Case DAttackS(11)
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
                    enemypokemon(1) -= tempattack * 35 / enemypokemon(3)
                    chance = 1 + Rnd() * 3
                    If chance = 1 Then
                        If yourturn = True Then
                            eflinch = True
                        ElseIf yourturn = False Then
                            yflinch = True
                        End If
                    End If
                Case "Horn Attack"
                    Select Case DAttackS(11)
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
                    enemypokemon(1) -= tempattack * 32.5 / enemypokemon(3)
                Case "Horn Drill"
                    chance = 1 + Rnd() * 3
                    If chance = 1 Then
                        enemypokemon(1) = 0
                    End If
                Case "Hydro Pump"
                    Select Case DAttackS(15)
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
                    enemypokemon(1) -= tempspecial * 55 / enemypokemon(5)
                Case "Hyper Beam"
                    Select Case DAttackS(11)
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
                    enemypokemon(1) -= tempspecial * 75 / enemypokemon(5)
                    If yourturn = True Then
                        yHBcharge = True
                    ElseIf yourturn = False Then
                        eHBcharge = True
                    End If
                Case "Hyper Fang"
                    Select Case DAttackS(11)
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
                    enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                    chance = 1 + Rnd() * 10
                    If chance = 1 Then

                        If yourturn = False Then
                            yflinch = True
                            Label7.Text = "Your Pokemon flinched!"
                        ElseIf yourturn = True Then
                            eflinch = True
                            Label7.Text = "The enemy flinched!"
                        End If
                    End If
                Case "Hypnosis"
                    chance = 1 + Rnd() * 3
                    If chance = 1 Or 2 Then
                        If yourturn = True Then
                            estatus = 6
                        ElseIf yourturn = False Then
                            ystatus = 6
                        End If
                    End If
                Case "Ice Beam"
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
                    enemypokemon(1) -= tempspecial * 45 / enemypokemon(5)
                    chance = 1 + Rnd() * 10
                    If chance = 1 Then
                        If yourturn = True Then
                            Label7.Text = "The enemy was Frozen!"
                            estatus = 2
                        ElseIf yourturn = False Then
                            Label7.Text = "Your Pokemon was Frozen!"
                            ystatus = 2
                        End If
                    End If
                Case "Karate Chop"
                    Select Case DAttackS(4)
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
                    enemypokemon(1) -= tempattack * 25 / enemypokemon(3)
                Case "Leech Life"
                    Select Case DAttackS(1)
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
                    enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                    yourpokemon(1) += tempattack * 20 / enemypokemon(3)
                Case "Leer"
                    enemypokemon(3) -= enemypokemonstat(3) / 2
                    Label7.Text = "Enemy Defense went fell by 1 stage!"
                Case "Lick"
                    Select Case DAttackS(8)
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
                    enemypokemon(1) -= tempattack * 15 / enemypokemon(3)
                    chance = 1 + Rnd() * 10
                    If chance = 1 Or 2 Or 3 Then
                        If yourturn = False Then
                            ystatus = 3
                            Label7.Text = "Your Pokemon was paralyzed!"
                        ElseIf yourturn = True Then
                            estatus = 3
                            Label7.Text = "The enemy was paralyzed!"
                        End If
                    End If
                Case "Light Screen"
                    yourpokemon(5) = yourpokemon(5) * 2
                Case "Low Kick"
                    Select Case DAttackS(4)
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
                    enemypokemon(1) -= tempattack * 25 / enemypokemon(3)
                    chance = 1 + Rnd() * 10
                    If chance = 1 Or 2 Or 3 Then

                        If yourturn = False Then
                            yflinch = True
                            Label7.Text = "Your Pokemon flinched!"
                        ElseIf yourturn = True Then
                            eflinch = True
                            Label7.Text = "The enemy flinched!"
                        End If
                    End If
                Case "Mega Drain"
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
                    enemypokemon(1) -= tempspecial * 37.5 / enemypokemon(5)
                    yourpokemon(1) += tempspecial * 37.5 / enemypokemon(5) / 2
                Case "Mega Kick"
                    Select Case DAttackS(4)
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
                    enemypokemon(1) -= tempattack * 60 / enemypokemon(3)
                Case "Mega Punch"
                    Select Case DAttackS(4)
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
                    enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                Case "Metronone"
                Case "Mist"
                    enemypokemon(2) = enemypokemonstat(2)
                    enemypokemon(3) = enemypokemonstat(3)
                    enemypokemon(4) = enemypokemonstat(4)
                    enemypokemon(5) = enemypokemonstat(5)

                    yourpokemon(2) = yourpokemonstat(2)
                    yourpokemon(3) = yourpokemonstat(3)
                    yourpokemon(4) = yourpokemonstat(4)
                    yourpokemon(5) = yourpokemonstat(5)

                    Label7.Text = "Stats have been reset!"
                Case "Night Shade"
                    enemypokemon(1) -= 25
                Case "Pay Day"
                    Select Case DAttackS(11)
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
                    enemypokemon(1) -= tempattack * 10 / enemypokemon(3)
                    If yourturn = True Then
                        payday = True
                    End If
                Case "Peck"
                    Select Case DAttackS(6)
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
                    enemypokemon(1) -= tempattack * 17.5 / enemypokemon(3)
                Case "Petal Dance"
                Case "Pin Missile"
                    tempcounter = 1
                    chance = 1 + Rnd() * 8
                    Select Case chance
                        Case 1, 2, 3
                            TimerPinMissile.Enabled = True
                            countPinMissile = 2
                        Case 4, 5, 6
                            TimerPinMissile.Enabled = True
                            countPinMissile = 3
                        Case 7
                            TimerPinMissile.Enabled = True
                            countPinMissile = 4
                        Case 8
                            TimerPinMissile.Enabled = True
                            countPinMissile = 5
                    End Select
                Case "Poison Gas"
                    chance = 1 + Rnd() * 2
                    If chance = 1 Then
                        If yourturn = True Then
                            estatus = 4
                            Label7.Text = "The enemy was Poisoned!"
                        ElseIf yourturn = False Then
                            ystatus = 4
                            Label7.Text = "Your pokemon was Poisoned!"
                        End If
                    End If
                Case "Poison Powder"
                    If yourturn = True Then
                        estatus = 4
                        Label7.Text = "The enemy was Poisoned!"
                    ElseIf yourturn = False Then
                        ystatus = 4
                        Label7.Text = "Your pokemon was Poisoned!"
                    End If
                Case "Poison Sting"
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
                    enemypokemon(1) -= tempattack * 7.5 / enemypokemon(3)
                    chance = 1 + Rnd() * 5
                    If chance = 1 Then
                        If yourturn = True Then
                            estatus = 4
                            Label7.Text = "The enemy was Poisoned!"
                        ElseIf yourturn = False Then
                            ystatus = 4
                            Label7.Text = "Your pokemon was Poisoned!"
                        End If
                    End If
                Case "Pound"
                    Select Case DAttackS(11)
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
                    enemypokemon(1) -= tempattack * 20 / enemypokemon(3)
                Case "Psybeam"
                    Select Case DAttackS(13)
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
                    chance = 1 + Rnd() * 10
                    If chance = 1 Then
                        If yourturn = True Then
                            estatus = 7
                            Label7.Text = "The enemy was Confused!"
                        ElseIf yourturn = False Then
                            ystatus = 7
                            Label7.Text = "Your pokemon was Confused!"
                        End If
                    End If
                Case "Psychic"
                    Select Case DAttackS(13)
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
                    enemypokemon(1) -= tempspecial * 45 / enemypokemon(5)
                    chance = 1 + Rnd() * 3
                    If chance = 1 Then
                        enemypokemon(5) -= enemypokemonstat(5) / 2
                        Label7.Text = "The enemy special fell by 1 stage!"
                    End If
                Case "Quick Attack"
                    Select Case DAttackS(11)
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
                    enemypokemon(1) -= tempattack * 20 / enemypokemon(3)
                Case "Razor Leaf"
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
                    enemypokemon(1) -= tempspecial * 25.5 / enemypokemon(5)
                Case "Razor Wind"
                Case "Recover"
                    yourpokemon(1) += yourpokemonstat(1) / 2
                Case "Reflect"
                    yourpokemon(3) = yourpokemon(3) * 2
                Case "Rest"
                    yourpokemon(1) = yourpokemonstat(1)
                    If yourturn = True Then
                        ystatus = 6
                    ElseIf yourturn = False Then
                        estatus = 6
                    End If
                Case "Rock Slide"
                    Select Case DAttackS(14)
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
                    enemypokemon(1) -= tempattack * 37.5 / enemypokemon(3)
                Case "Rock Throw"
                    Select Case DAttackS(14)
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
                    enemypokemon(1) -= tempattack * 25 / enemypokemon(3)
                Case "Sand Attack"
                    enemypokemon(4) -= enemypokemonstat(4) / 2
                    Label7.Text = "The enemy's speed fell by 1 stage!"
                Case "Scratch"
                    Select Case DAttackS(11)
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
                    enemypokemon(1) -= tempattack * 20 / enemypokemon(3)
                Case "Screech"
                    enemypokemon(3) -= enemypokemonstat(3)
                    Label7.Text = "The Enemy's Defense fell by 2 stages!"
                Case "Seismic Toss"
                    enemypokemon(1) -= 50
                Case "Self Destruct"
                    Select Case DAttackS(11)
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
                    enemypokemon(1) -= tempattack * 130 / enemypokemon(3)
                    yourpokemon(1) = 0
                Case "Skull Bash"
                Case "Sky Attack"
                Case "Slam"
                    Select Case DAttackS(11)
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
                    enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                Case "Slash"
                    Select Case DAttackS(11)
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
                    enemypokemon(1) -= tempattack * 35 / enemypokemon(3)
                Case "Sleep Powder"
                    If yourturn = True Then
                        estatus = 6
                    ElseIf yourturn = False Then
                        ystatus = 6
                    End If
                Case "Sludge"
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
                    enemypokemon(1) -= tempspecial * 32.6 / enemypokemon(5)
                    chance = 1 + Rnd() * 5
                    If chance = 1 Or 2 Then
                        If yourturn = True Then
                            estatus = 4
                        ElseIf yourturn = False Then
                            ystatus = 4
                        End If
                    End If
                Case "Smog"
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
                    chance = 1 + Rnd() * 5
                    If chance = 1 Or 2 Then
                        If yourturn = True Then
                            estatus = 4
                        ElseIf yourturn = False Then
                            ystatus = 4
                        End If
                    End If
                Case "Smokescreen"
                    enemypokemon(4) -= enemypokemonstat(4) / 2
                    Label7.Text = "The enemy's Speed fell by 1 stage!"
                Case "Solar Beam"
                Case "Sonic Boom"
                    enemypokemon(1) -= 10
                Case "Spike Cannon"
                    tempcounter = 1
                    chance = 1 + Rnd() * 8
                    Select Case chance
                        Case 1, 2, 3
                            TimerSpikeCannon.Enabled = True
                            countSpikeCannon = 2
                        Case 4, 5, 6
                            TimerSpikeCannon.Enabled = True
                            countSpikeCannon = 3
                        Case 7
                            TimerSpikeCannon.Enabled = True
                            countSpikeCannon = 4
                        Case 8
                            TimerSpikeCannon.Enabled = True
                            countSpikeCannon = 5
                    End Select
                Case "Splash"
                    Label7.Text = "But nothing happened!"
                Case "Spore"
                    If yourturn = True Then
                        estatus = 6
                    ElseIf yourturn = False Then
                        ystatus = 6
                    End If
                Case "Stomp"
                    Select Case DAttackS(11)
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
                    enemypokemon(1) -= tempattack * 32.5 / enemypokemon(3)
                    chance = 1 + Rnd() * 10
                    If chance = 1 Or 2 Or 3 Then

                        If yourturn = False Then
                            yflinch = True
                            Label7.Text = "Your Pokemon flinched!"
                        ElseIf yourturn = True Then
                            eflinch = True
                            Label7.Text = "The enemy flinched!"
                        End If
                    End If
                Case "Strength"
                    Select Case DAttackS(11)
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
                    enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                Case "String Shot"
                    enemypokemon(4) -= enemypokemonstat(4) / 2
                    Label7.Text = "The enemy's Speed fell by 1 stage!"
                Case "Stun Spore"
                    If yourturn = True Then
                        estatus = 3
                    ElseIf yourturn = False Then
                        ystatus = 3
                    End If
                Case "Submission"
                    Select Case DAttackS(4)
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
                    enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                    yourpokemon(1) -= tempattack * 10 / enemypokemon(3)
                Case "Supersonic"
                    If yourturn = True Then
                        estatus = 7
                    ElseIf yourturn = False Then
                        ystatus = 7
                    End If
                Case "Super Fang"
                    enemypokemon(1) = enemypokemon(1) / 2
                Case "Surf"
                    Select Case DAttackS(15)
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
                    enemypokemon(1) -= tempspecial * 45 / enemypokemon(5)
                Case "Swift"
                    Select Case DAttackS(11)
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
                    enemypokemon(1) -= tempspecial * 30 / enemypokemon(5)
                Case "Swords Dance"
                    yourpokemon(2) += yourpokemonstat(2)
                    Label7.Text = "Your Attack went up by 2 stages!"
                Case "Tackle"
                    Select Case DAttackS(11)
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
                    enemypokemon(1) -= tempattack * 20 / enemypokemon(3)
                Case "Tail Whip"
                    enemypokemon(3) -= enemypokemonstat(3) / 2
                    Label7.Text = "Enemy Defence Was Lowered by 1 Stage!"
                Case "Take Down"
                    Select Case DAttackS(11)
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
                    enemypokemon(1) -= tempattack * 45 / enemypokemon(3)
                    yourpokemon(1) -= tempattack * 22.5 / enemypokemon(3) / 2
                Case "Teleport"
                    If frmBattleSelect.trainerbattle = False Then
                        enemypokemon(1) = 0
                    End If
                Case "Thunder"
                    Select Case DAttackS(10)
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
                    enemypokemon(1) -= tempspecial * 55 / enemypokemon(5)
                    chance = 1 + Rnd() * 10
                    If chance = 1 Then
                        If yourturn = False Then
                            ystatus = 3
                            Label7.Text = "Your Pokemon was paralyzed!"
                        ElseIf yourturn = True Then
                            estatus = 3
                            Label7.Text = "The enemy was paralyzed!"
                        End If
                    End If
                Case "Thunder Punch"
                    Select Case DAttackS(10)
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
                    enemypokemon(1) -= tempattack * 37.5 / enemypokemon(3)
                    chance = 1 + Rnd() * 10
                    If chance = 1 Then
                        If yourturn = False Then
                            ystatus = 3
                            Label7.Text = "Your Pokemon was paralyzed!"
                        ElseIf yourturn = True Then
                            estatus = 3
                            Label7.Text = "The enemy was paralyzed!"
                        End If
                    End If
                Case "Thunder Shock"
                    Select Case DAttackS(10)
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
                    enemypokemon(1) -= tempspecial * 20 / enemypokemon(5)
                    chance = 1 + Rnd() * 10
                    If chance = 1 Then
                        If yourturn = False Then
                            ystatus = 3
                            Label7.Text = "Your Pokemon was paralyzed!"
                        ElseIf yourturn = True Then
                            estatus = 3
                            Label7.Text = "The enemy was paralyzed!"
                        End If
                    End If
                Case "Thunder Wave"
                    If yourturn = True Then
                        estatus = 3
                    ElseIf yourturn = False Then
                        ystatus = 3
                    End If
                Case "Thunderbolt"
                    Select Case DAttackS(10)
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
                    enemypokemon(1) -= tempspecial * 45 / enemypokemon(5)
                    chance = 1 + Rnd() * 10
                    If chance = 1 Then
                        If yourturn = False Then
                            ystatus = 3
                            Label7.Text = "Your Pokemon was paralyzed!"
                        ElseIf yourturn = True Then
                            estatus = 3
                            Label7.Text = "The enemy was paralyzed!"
                        End If
                    End If
                Case "Toxic"
                    If yourturn = True Then
                        estatus = 5
                    ElseIf yourturn = False Then
                        ystatus = 5
                    End If
                Case "Tri Attack"
                    Select Case DAttackS(11)
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
                    enemypokemon(1) -= tempspecial * 40 / enemypokemon(5)
                Case "Vice Grip"
                    Select Case DAttackS(11)
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
                    enemypokemon(1) -= tempattack * 27.5 / enemypokemon(3)
                Case "Vine Whip"
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
                    enemypokemon(1) -= tempattack * 22.5 / enemypokemon(3)
                Case "Water Gun"
                    Select Case DAttackS(15)
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
                    enemypokemon(1) -= tempspecial * 20 / enemypokemon(5)
                Case "Whirlwind"
                    If frmBattleSelect.trainerbattle = False Then
                        enemypokemon(1) = 0
                    End If
                Case "Wing Attack"
                    Select Case DAttackS(6)
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
                    enemypokemon(1) -= tempattack * 17.5 / enemypokemon(3)
                Case "Withdraw"
                    yourpokemon(3) += yourpokemonstat(3) / 2
                    Label7.Text = "Your Defense went up by 1 stage!"
                Case "Wrap"
                    Select Case DAttackS(11)
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
                    enemypokemon(1) -= tempattack * 17.5 / enemypokemon(3)
                    chance = 1 + Rnd() * 8
                    If yourturn = True Then
                        Select Case chance
                            Case 1, 2, 3
                                eboundcounter = 2
                            Case 4, 5, 6
                                eboundcounter = 3
                            Case 7
                                eboundcounter = 4
                            Case 8
                                eboundcounter = 5
                        End Select
                    ElseIf yourturn = False Then
                        Select Case chance
                            Case 1, 2, 3
                                yboundcounter = 2
                            Case 4, 5, 6
                                yboundcounter = 3
                            Case 7
                                yboundcounter = 4
                            Case 8
                                yboundcounter = 5
                        End Select
                    End If


                Case "Hadouken"
                    Select Case DAttackS(4)
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
                    enemypokemon(1) -= tempspecial * 35.5 / enemypokemon(5)
                Case "Shoryuken"
                    Select Case DAttackS(4)
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
                    enemypokemon(1) -= tempattack * 55 / enemypokemon(3)
                Case "Collarbone Breaker"
                    Select Case DAttackS(4)
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
                    enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                    If chance = 1 Then
                        enemypokemon(3) -= enemypokemonstat(3)
                        Label7.Text = "Enemy Defence Was Lowered by 2 Stages!"
                    End If
                Case "Heat Rush"
                    Select Case DAttackS(5)
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
                    enemypokemon(1) -= tempattack * 35 / enemypokemon(3)
                    chance = 1 + Rnd() * 10
                    If chance = 1 Then
                        If yourturn = True Then
                            Label7.Text = "The enemy was Burned!"
                            estatus = 1
                        ElseIf yourturn = False Then
                            Label7.Text = "Your Pokemon was Burned!"
                            ystatus = 1
                        End If
                    End If
                Case "Guren Enjinkyaku"
                    Select Case DAttackS(4)
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
                    enemypokemon(1) -= tempattack * 45 / enemypokemon(3)
                    chance = 1 + Rnd() * 10
                    If chance = 1 Then
                        If yourturn = True Then
                            Label7.Text = "The enemy was Burned!"
                            estatus = 1
                        ElseIf yourturn = False Then
                            Label7.Text = "Your Pokemon was Burned!"
                            ystatus = 1
                        End If
                    End If
                Case "Quick Step"
                    yourpokemon(4) += yourpokemonstat(4)
                    Label7.Text = "Your Speed went up by 2 stages!"
                Case "Lightning Cannonball"
                    Select Case DAttackS(10)
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
                    enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                    chance = 1 + Rnd() * 10
                    If chance = 1 Then
                        If yourturn = False Then
                            ystatus = 3
                            Label7.Text = "Your Pokemon was paralyzed!"
                        ElseIf yourturn = True Then
                            estatus = 3
                            Label7.Text = "The enemy was paralyzed!"
                        End If
                    End If
                Case "Shout Of Earth"
                    Select Case DAttackS(10)
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
                    enemypokemon(1) -= tempspecial * 37.5 / enemypokemon(5)
                    chance = 1 + Rnd() * 8
                    If chance = 1 Then
                        If yourturn = False Then
                            ystatus = 3
                            Label7.Text = "Your Pokemon was paralyzed!"
                        ElseIf yourturn = True Then
                            estatus = 3
                            Label7.Text = "The enemy was paralyzed!"
                        End If
                    End If
                Case "Psycho Crusher"
                    Select Case DAttackS(13)
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
                    enemypokemon(1) -= tempattack * 65 / enemypokemon(3)
                Case "Super Scissor Kicks"
                    Select Case DAttackS(4)
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
                    enemypokemon(1) -= tempattack * 55 / enemypokemon(3)
                Case "Devil's Reverse"
                    Select Case DAttackS(4)
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
                    enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                Case "Raging Demon"
                    Select Case DAttackS(4)
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
                    enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                    chance = 1 + Rnd() * 3
                    If chance = 1 Then
                        enemypokemon(1) = 0
                    End If
                Case "Gou Shoryuken"
                    Select Case DAttackS(4)
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
                    enemypokemon(1) -= tempattack * 60 / enemypokemon(3)
                Case "Ahura Senku"
                    yourpokemon(4) += yourpokemonstat(4)
                    Label7.Text = "Your Speed went up by 2 stages!"
                Case "Buffalo Headbutt"
                    Select Case DAttackS(4)
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
                    enemypokemon(1) -= tempattack * 60 / enemypokemon(3)
                    yourpokemon(1) -= tempattack * 45 / enemypokemon(3) / 2
                Case "Super Running Uppercut"
                    Select Case DAttackS(4)
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
                    enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                    chance = 1 + Rnd() * 5
                    If chance = 1 Then
                        yourpokemon(4) += yourpokemonstat(4) / 2
                        Label7.Text = "Your Speed went up by 1 stage!"
                    End If
                Case "Dash Punch"
                    Select Case DAttackS(4)
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
                    enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                    chance = 1 + Rnd() * 3
                    If chance = 1 Then
                        yourpokemon(4) += yourpokemonstat(4) / 2
                        Label7.Text = "Your Speed went up by 1 stage!"
                    End If
                Case "Head Bomber"
                    Select Case DAttackS(4)
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
                    enemypokemon(1) -= tempattack * 60 / enemypokemon(3)
                    yourpokemon(1) -= tempattack * 35 / enemypokemon(3)
            End Select
            Label7.Text = yourpokemon(0) & " used " & yourpokemon(10) & "!"
            yturn.Enabled = True
        ' ElseIf enemypokemon(4) > yourpokemon(4) Then
        'End If
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

    Private Sub TimerBarrage_Tick(sender As Object, e As EventArgs) Handles TimerBarrage.Tick
        tempcounter += 1
        Select Case DAttackS(11)
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
        If tempcounter = countBarrage Then
            TimerBarrage.Enabled = False

        End If
        enemypokemon(1) -= tempattack * 10 / enemypokemon(3)
        Label7.Text = "The enemy was hit " & tempcounter & " times!"

    End Sub

    Private Sub TimerBonemerang_Tick(sender As Object, e As EventArgs) Handles TimerBonemerang.Tick
        tempcounter += 1
        Select Case DAttackS(11)
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
        If tempcounter = 2 Then
            TimerBonemerang.Enabled = False

        End If
        enemypokemon(1) -= tempattack * 25 / enemypokemon(3)
        Label7.Text = "The enemy was hit " & tempcounter & " times!"

    End Sub

    Private Sub TimerDoubleKick_Tick(sender As Object, e As EventArgs) Handles TimerDoubleKick.Tick
        tempcounter += 1
        Select Case DAttackS(4)
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
        If tempcounter = 2 Then
            TimerBonemerang.Enabled = False

        End If
        enemypokemon(1) -= tempattack * 15 / enemypokemon(3)
        Label7.Text = "The enemy was hit " & tempcounter & " times!"
    End Sub

    Private Sub TimerDoubleSlap_Tick(sender As Object, e As EventArgs) Handles TimerDoubleSlap.Tick
        tempcounter += 1
        Select Case DAttackS(11)
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
        If tempcounter = countDoubleSlap Then
            TimerDoubleSlap.Enabled = False

        End If
        enemypokemon(1) -= tempattack * 7.5 / enemypokemon(3)
        Label7.Text = "The enemy was hit " & tempcounter & " times!"

    End Sub

    Private Sub TimerFuryAttack_Tick(sender As Object, e As EventArgs) Handles TimerFuryAttack.Tick
        tempcounter += 1
        Select Case DAttackS(11)
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
        If tempcounter = countFuryAttack Then
            TimerFuryAttack.Enabled = False

        End If
        enemypokemon(1) -= tempattack * 10 / enemypokemon(3)
        Label7.Text = "The enemy was hit " & tempcounter & " times!"
    End Sub

    Private Sub TimerFurySwipes_Tick(sender As Object, e As EventArgs) Handles TimerFurySwipes.Tick
        tempcounter += 1
        Select Case DAttackS(11)
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
        If tempcounter = countFurySwipes Then
            TimerFurySwipes.Enabled = False

        End If
        enemypokemon(1) -= tempattack * 9 / enemypokemon(3)
        Label7.Text = "The enemy was hit " & tempcounter & " times!"
    End Sub

    Private Sub TimerPinMissile_Tick(sender As Object, e As EventArgs) Handles TimerPinMissile.Tick
        tempcounter += 1
        Select Case DAttackS(1)
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
        If tempcounter = countPinMissile Then
            TimerPinMissile.Enabled = False

        End If
        enemypokemon(1) -= tempattack * 10 / enemypokemon(3)
        Label7.Text = "The enemy was hit " & tempcounter & " times!"
    End Sub

    Private Sub TimerSpikeCannon_Tick(sender As Object, e As EventArgs) Handles TimerSpikeCannon.Tick
        tempcounter += 1
        Select Case DAttackS(11)
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
        If tempcounter = countSpikeCannon Then
            TimerSpikeCannon.Enabled = False

        End If
        enemypokemon(1) -= tempattack * 10 / enemypokemon(3)
        Label7.Text = "The enemy was hit " & tempcounter & " times!"
    End Sub

    Private Sub btnMove2_Click(sender As Object, e As EventArgs) Handles btnMove2.Click
        Dim tempattack As Double
        Dim tempspecial As Double
        Dim chance As Integer

        Select Case yourpokemon(11)
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
                tempcounter = 1
                chance = 1 + Rnd() * 8
                Select Case chance
                    Case 1, 2, 3
                        TimerBarrage.Enabled = True
                        countBarrage = 2
                    Case 4, 5, 6
                        TimerBarrage.Enabled = True
                        countBarrage = 3
                    Case 7
                        TimerBarrage.Enabled = True
                        countBarrage = 4
                    Case 8
                        TimerBarrage.Enabled = True
                        countBarrage = 5
                End Select
            Case "Barrier"
                yourpokemon(3) += yourpokemonstat(3)
                Label7.Text = "Your defense went up by 2 stages!"
            Case "Bide"

            Case "Bite"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 30 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Then

                    If yourturn = False Then
                        yflinch = True
                        Label7.Text = "Your Pokemon flinched!"
                    ElseIf yourturn = True Then
                        eflinch = True
                        Label7.Text = "The enemy flinched!"
                    End If
                End If
            Case "Blizzard"
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
                enemypokemon(1) -= tempspecial * 65 / enemypokemon(5)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = True Then
                        Label7.Text = "The enemy was frozen!"
                        estatus = 2
                    ElseIf yourturn = False Then
                        Label7.Text = "Your Pokemon was frozen!"
                        ystatus = 2
                    End If
                End If
            Case "Body Slam"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 42.5 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Or 2 Or 3 Then
                    If yourturn = False Then
                        ystatus = 3
                        Label7.Text = "Your Pokemon was paralyzed!"
                    ElseIf yourturn = True Then
                        estatus = 3
                        Label7.Text = "The enemy was paralyzed!"
                    End If
                End If
            Case "Bone Club"
                Select Case DAttackS(9)
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
                enemypokemon(1) -= tempattack * 32.5 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = False Then
                        yflinch = True
                        Label7.Text = "Your Pokemon flinched!"
                    ElseIf yourturn = True Then
                        eflinch = True
                        Label7.Text = "The enemy flinched!"
                    End If
                End If
            Case "Bonemerang"
                TimerBonemerang.Enabled = True
                tempcounter = 1
            Case "Bubble"
                Select Case DAttackS(15)
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
                chance = 1 + Rnd() * 3
                If chance = 1 Then
                    enemypokemon(4) -= enemypokemonstat(4) / 2
                    Label7.Text = "Enemy Speed Was Lowered by 1 Stage!"
                End If
            Case "Clamp"
                Select Case DAttackS(15)
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
                enemypokemon(1) -= tempattack * 17.5 / enemypokemon(3)
                chance = 1 + Rnd() * 8
                If yourturn = True Then
                    Select Case chance
                        Case 1, 2, 3
                            eboundcounter = 2
                        Case 4, 5, 6
                            eboundcounter = 3
                        Case 7
                            eboundcounter = 4
                        Case 8
                            eboundcounter = 5
                    End Select
                ElseIf yourturn = False Then
                    Select Case chance
                        Case 1, 2, 3
                            yboundcounter = 2
                        Case 4, 5, 6
                            yboundcounter = 3
                        Case 7
                            yboundcounter = 4
                        Case 8
                            yboundcounter = 5
                    End Select
                End If
            Case "Confuse Ray"
                If yourturn = True Then
                    Label7.Text = "The enemy was Confused!"
                    estatus = 7
                ElseIf yourturn = False Then
                    Label7.Text = "Your Pokemon was Confused!"
                    ystatus = 7
                End If
            Case "Confusion"
                Select Case DAttackS(13)
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
                enemypokemon(1) -= tempspecial * 25 / enemypokemon(5)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = True Then
                        Label7.Text = "The enemy was Confused!"
                        estatus = 7
                    ElseIf yourturn = False Then
                        Label7.Text = "Your Pokemon was Confused!"
                        ystatus = 7
                    End If
                End If
            Case "Crabhammer"
                Select Case DAttackS(15)
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
                enemypokemon(1) -= tempattack * 50 / enemypokemon(3)
            Case "Cut"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 25 / enemypokemon(3)
            Case "Defense Curl"
                yourpokemon(3) += yourpokemonstat(3) / 2
                Label7.Text = "Your defense went up by 1 stage!"
            Case "Dig"
                If yourturn = True Then
                    yDigcharge = 1
                ElseIf yourturn = False Then
                    eDigcharge = 1
                End If
            Case "Disable"
            Case "Dizzy Punch"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 35 / enemypokemon(3)
            Case "Double Kick"
                TimerDoubleKick.Enabled = True
                tempcounter = 1
            Case "Double Slap"
                tempcounter = 1
                chance = 1 + Rnd() * 8
                Select Case chance
                    Case 1, 2, 3
                        TimerDoubleSlap.Enabled = True
                        countDoubleSlap = 2
                    Case 4, 5, 6
                        TimerDoubleSlap.Enabled = True
                        countDoubleSlap = 3
                    Case 7
                        TimerDoubleSlap.Enabled = True
                        countDoubleSlap = 4
                    Case 8
                        TimerDoubleSlap.Enabled = True
                        countDoubleSlap = 5
                End Select
            Case "Double Team"
                yourpokemon(4) += yourpokemonstat(4) / 2
                Label7.Text = "Your speed went up by 1 stage!"
            Case "Double-Edge"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 60 / enemypokemon(3)
                yourpokemon(1) -= tempattack * 15 / enemypokemon(3)
            Case "Dream Eater"
                If yourturn = True Then
                    If estatus = 6 Then
                        Select Case DAttackS(13)
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
                        enemypokemon(1) -= tempspecial * 50 / enemypokemon(5)
                        yourpokemon(1) = +tempspecial * 50 / enemypokemon(5)
                    ElseIf estatus <> 6 Then
                        Label7.Text = "The attack failed!"
                    End If
                ElseIf yourturn = False Then
                    If ystatus = 6 Then
                        Select Case DAttackS(13)
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
                        enemypokemon(1) -= tempspecial * 50 / enemypokemon(5)
                        yourpokemon(1) = +tempspecial * 50 / enemypokemon(5)
                    ElseIf ystatus <> 6 Then
                        Label7.Text = "The attack failed!"
                    End If
                End If
            Case "Drill Peck"
                Select Case DAttackS(6)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
            Case "Earthquake"
                Select Case DAttackS(9)
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
                enemypokemon(1) -= tempattack * 50 / enemypokemon(3)
            Case "Egg Bomb"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 50 / enemypokemon(3)
            Case "Ember"
                Select Case DAttackS(5)
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
                enemypokemon(1) -= tempspecial * 20 / enemypokemon(5)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = True Then
                        Label7.Text = "The enemy was Burned!"
                        estatus = 1
                    ElseIf yourturn = False Then
                        Label7.Text = "Your Pokemon was Burned!"
                        ystatus = 1
                    End If
                End If
            Case "Explosion"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 170 / enemypokemon(3)
                yourpokemon(1) = 0
            Case "Fire Blast"
                Select Case DAttackS(5)
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
                enemypokemon(1) -= tempspecial * 60 / enemypokemon(5)
                chance = 1 + Rnd() * 3
                If chance = 1 Then
                    If yourturn = True Then
                        Label7.Text = "The enemy was Burned!"
                        estatus = 1
                    ElseIf yourturn = False Then
                        Label7.Text = "Your Pokemon was Burned!"
                        ystatus = 1
                    End If
                End If
            Case "Fire Punch"
                Select Case DAttackS(5)
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
                enemypokemon(1) -= tempattack * 37.5 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = True Then
                        Label7.Text = "The enemy was Burned!"
                        estatus = 1
                    ElseIf yourturn = False Then
                        Label7.Text = "Your Pokemon was Burned!"
                        ystatus = 1
                    End If
                End If
            Case "Fire Spin"
                Select Case DAttackS(5)
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
                enemypokemon(1) -= tempattack * 17.5 / enemypokemon(3)
                chance = 1 + Rnd() * 8
                If yourturn = True Then
                    Select Case chance
                        Case 1, 2, 3
                            eboundcounter = 2
                        Case 4, 5, 6
                            eboundcounter = 3
                        Case 7
                            eboundcounter = 4
                        Case 8
                            eboundcounter = 5
                    End Select
                ElseIf yourturn = False Then
                    Select Case chance
                        Case 1, 2, 3
                            yboundcounter = 2
                        Case 4, 5, 6
                            yboundcounter = 3
                        Case 7
                            yboundcounter = 4
                        Case 8
                            yboundcounter = 5
                    End Select
                End If
            Case "Flamethrower"
                Select Case DAttackS(5)
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
                enemypokemon(1) -= tempspecial * 47.5 / enemypokemon(5)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = True Then
                        Label7.Text = "The enemy was Burned!"
                        estatus = 1
                    ElseIf yourturn = False Then
                        Label7.Text = "Your Pokemon was Burned!"
                        ystatus = 1
                    End If
                End If
            Case "Flash"
                enemypokemon(4) -= enemypokemonstat(4) / 2
                Label7.Text = "The Enemy's speed fell by 1 stage!"
            Case "Fly"
                If yourturn = True Then
                    yFlycharge = 1
                ElseIf yourturn = False Then
                    eFlycharge = 1
                End If
            Case "Focus Energy"
                yourpokemon(4) += yourpokemonstat(4) / 2
                yourpokemon(2) += yourpokemonstat(2) / 2
                yourpokemon(5) += yourpokemonstat(5) / 2
                Label7.Text = "Your pokemon is getting pumped!"
            Case "Fury Attack"
                tempcounter = 1
                chance = 1 + Rnd() * 8
                Select Case chance
                    Case 1, 2, 3
                        TimerFuryAttack.Enabled = True
                        countFuryAttack = 2
                    Case 4, 5, 6
                        TimerFuryAttack.Enabled = True
                        countFuryAttack = 3
                    Case 7
                        TimerFuryAttack.Enabled = True
                        countFuryAttack = 4
                    Case 8
                        TimerFuryAttack.Enabled = True
                        countFuryAttack = 5
                End Select
            Case "Fury Swipes"
                tempcounter = 1
                chance = 1 + Rnd() * 8
                Select Case chance
                    Case 1, 2, 3
                        TimerFurySwipes.Enabled = True
                        countFurySwipes = 2
                    Case 4, 5, 6
                        TimerFurySwipes.Enabled = True
                        countFurySwipes = 3
                    Case 7
                        TimerFurySwipes.Enabled = True
                        countFurySwipes = 4
                    Case 8
                        TimerFurySwipes.Enabled = True
                        countFurySwipes = 5
                End Select
            Case "Glare"
                If yourturn = True Then
                    Label7.Text = "The enemy was Paralyzed!"
                    estatus = 3
                ElseIf yourturn = False Then
                    Label7.Text = "Your Pokemon was Paralyzed!"
                    ystatus = 3
                End If
            Case "Growl"
                enemypokemon(2) -= enemypokemonstat(2) / 2
                Label7.Text = "Enemy Attack Was Lowered by 1 Stage!"
            Case "Growth"
                yourpokemon(5) += yourpokemonstat(5) / 2
                Label7.Text = "Your special went up by 1 stage!"
            Case "Guillotine"
                chance = 1 + Rnd() * 3
                If chance = 1 Then
                    enemypokemon(1) = 0
                End If
            Case "Gust"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 20 / enemypokemon(3)
            Case "Harden"
                yourpokemon(3) += yourpokemonstat(3) / 2
                Label7.Text = "Your Defense went up by 1 stage!"
            Case "Haze"
                enemypokemon(2) = enemypokemonstat(2)
                enemypokemon(3) = enemypokemonstat(3)
                enemypokemon(4) = enemypokemonstat(4)
                enemypokemon(5) = enemypokemonstat(5)

                yourpokemon(2) = yourpokemonstat(2)
                yourpokemon(3) = yourpokemonstat(3)
                yourpokemon(4) = yourpokemonstat(4)
                yourpokemon(5) = yourpokemonstat(5)

                Label7.Text = "Stats have been reset!"

            Case "Headbutt"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 35 / enemypokemon(3)
                chance = 1 + Rnd() * 3
                If chance = 1 Then
                    If yourturn = True Then
                        eflinch = True
                    ElseIf yourturn = False Then
                        yflinch = True
                    End If
                End If
            Case "Horn Attack"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 32.5 / enemypokemon(3)
            Case "Horn Drill"
                chance = 1 + Rnd() * 3
                If chance = 1 Then
                    enemypokemon(1) = 0
                End If
            Case "Hydro Pump"
                Select Case DAttackS(15)
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
                enemypokemon(1) -= tempspecial * 55 / enemypokemon(5)
            Case "Hyper Beam"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempspecial * 75 / enemypokemon(5)
                If yourturn = True Then
                    yHBcharge = True
                ElseIf yourturn = False Then
                    eHBcharge = True
                End If
            Case "Hyper Fang"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Then

                    If yourturn = False Then
                        yflinch = True
                        Label7.Text = "Your Pokemon flinched!"
                    ElseIf yourturn = True Then
                        eflinch = True
                        Label7.Text = "The enemy flinched!"
                    End If
                End If
            Case "Hypnosis"
                chance = 1 + Rnd() * 3
                If chance = 1 Or 2 Then
                    If yourturn = True Then
                        estatus = 6
                    ElseIf yourturn = False Then
                        ystatus = 6
                    End If
                End If
            Case "Ice Beam"
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
                enemypokemon(1) -= tempspecial * 45 / enemypokemon(5)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = True Then
                        Label7.Text = "The enemy was Frozen!"
                        estatus = 2
                    ElseIf yourturn = False Then
                        Label7.Text = "Your Pokemon was Frozen!"
                        ystatus = 2
                    End If
                End If
            Case "Karate Chop"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 25 / enemypokemon(3)
            Case "Leech Life"
                Select Case DAttackS(1)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                yourpokemon(1) += tempattack * 20 / enemypokemon(3)
            Case "Leer"
                enemypokemon(3) -= enemypokemonstat(3) / 2
                Label7.Text = "Enemy Defense went fell by 1 stage!"
            Case "Lick"
                Select Case DAttackS(8)
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
                enemypokemon(1) -= tempattack * 15 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Or 2 Or 3 Then
                    If yourturn = False Then
                        ystatus = 3
                        Label7.Text = "Your Pokemon was paralyzed!"
                    ElseIf yourturn = True Then
                        estatus = 3
                        Label7.Text = "The enemy was paralyzed!"
                    End If
                End If
            Case "Light Screen"
                yourpokemon(5) = yourpokemon(5) * 2
            Case "Low Kick"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 25 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Or 2 Or 3 Then

                    If yourturn = False Then
                        yflinch = True
                        Label7.Text = "Your Pokemon flinched!"
                    ElseIf yourturn = True Then
                        eflinch = True
                        Label7.Text = "The enemy flinched!"
                    End If
                End If
            Case "Mega Drain"
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
                enemypokemon(1) -= tempspecial * 37.5 / enemypokemon(5)
                yourpokemon(1) += tempspecial * 37.5 / enemypokemon(5) / 2
            Case "Mega Kick"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 60 / enemypokemon(3)
            Case "Mega Punch"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
            Case "Metronone"
            Case "Mist"
                enemypokemon(2) = enemypokemonstat(2)
                enemypokemon(3) = enemypokemonstat(3)
                enemypokemon(4) = enemypokemonstat(4)
                enemypokemon(5) = enemypokemonstat(5)

                yourpokemon(2) = yourpokemonstat(2)
                yourpokemon(3) = yourpokemonstat(3)
                yourpokemon(4) = yourpokemonstat(4)
                yourpokemon(5) = yourpokemonstat(5)

                Label7.Text = "Stats have been reset!"
            Case "Night Shade"
                enemypokemon(1) -= 25
            Case "Pay Day"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 10 / enemypokemon(3)
                If yourturn = True Then
                    payday = True
                End If
            Case "Peck"
                Select Case DAttackS(6)
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
                enemypokemon(1) -= tempattack * 17.5 / enemypokemon(3)
            Case "Petal Dance"
            Case "Pin Missile"
                tempcounter = 1
                chance = 1 + Rnd() * 8
                Select Case chance
                    Case 1, 2, 3
                        TimerPinMissile.Enabled = True
                        countPinMissile = 2
                    Case 4, 5, 6
                        TimerPinMissile.Enabled = True
                        countPinMissile = 3
                    Case 7
                        TimerPinMissile.Enabled = True
                        countPinMissile = 4
                    Case 8
                        TimerPinMissile.Enabled = True
                        countPinMissile = 5
                End Select
            Case "Poison Gas"
                chance = 1 + Rnd() * 2
                If chance = 1 Then
                    If yourturn = True Then
                        estatus = 4
                        Label7.Text = "The enemy was Poisoned!"
                    ElseIf yourturn = False Then
                        ystatus = 4
                        Label7.Text = "Your pokemon was Poisoned!"
                    End If
                End If
            Case "Poison Powder"
                If yourturn = True Then
                    estatus = 4
                    Label7.Text = "The enemy was Poisoned!"
                ElseIf yourturn = False Then
                    ystatus = 4
                    Label7.Text = "Your pokemon was Poisoned!"
                End If
            Case "Poison Sting"
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
                enemypokemon(1) -= tempattack * 7.5 / enemypokemon(3)
                chance = 1 + Rnd() * 5
                If chance = 1 Then
                    If yourturn = True Then
                        estatus = 4
                        Label7.Text = "The enemy was Poisoned!"
                    ElseIf yourturn = False Then
                        ystatus = 4
                        Label7.Text = "Your pokemon was Poisoned!"
                    End If
                End If
            Case "Pound"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 20 / enemypokemon(3)
            Case "Psybeam"
                Select Case DAttackS(13)
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
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = True Then
                        estatus = 7
                        Label7.Text = "The enemy was Confused!"
                    ElseIf yourturn = False Then
                        ystatus = 7
                        Label7.Text = "Your pokemon was Confused!"
                    End If
                End If
            Case "Psychic"
                Select Case DAttackS(13)
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
                enemypokemon(1) -= tempspecial * 45 / enemypokemon(5)
                chance = 1 + Rnd() * 3
                If chance = 1 Then
                    enemypokemon(5) -= enemypokemonstat(5) / 2
                    Label7.Text = "The enemy special fell by 1 stage!"
                End If
            Case "Quick Attack"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 20 / enemypokemon(3)
            Case "Razor Leaf"
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
                enemypokemon(1) -= tempspecial * 25.5 / enemypokemon(5)
            Case "Razor Wind"
            Case "Recover"
                yourpokemon(1) += yourpokemonstat(1) / 2
            Case "Reflect"
                yourpokemon(3) = yourpokemon(3) * 2
            Case "Rest"
                yourpokemon(1) = yourpokemonstat(1)
                If yourturn = True Then
                    ystatus = 6
                ElseIf yourturn = False Then
                    estatus = 6
                End If
            Case "Rock Slide"
                Select Case DAttackS(14)
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
                enemypokemon(1) -= tempattack * 37.5 / enemypokemon(3)
            Case "Rock Throw"
                Select Case DAttackS(14)
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
                enemypokemon(1) -= tempattack * 25 / enemypokemon(3)
            Case "Sand Attack"
                enemypokemon(4) -= enemypokemonstat(4) / 2
                Label7.Text = "The enemy's speed fell by 1 stage!"
            Case "Scratch"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 20 / enemypokemon(3)
            Case "Screech"
                enemypokemon(3) -= enemypokemonstat(3)
                Label7.Text = "The Enemy's Defense fell by 2 stages!"
            Case "Seismic Toss"
                enemypokemon(1) -= 50
            Case "Self Destruct"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 130 / enemypokemon(3)
                yourpokemon(1) = 0
            Case "Skull Bash"
            Case "Sky Attack"
            Case "Slam"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
            Case "Slash"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 35 / enemypokemon(3)
            Case "Sleep Powder"
                If yourturn = True Then
                    estatus = 6
                ElseIf yourturn = False Then
                    ystatus = 6
                End If
            Case "Sludge"
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
                enemypokemon(1) -= tempspecial * 32.6 / enemypokemon(5)
                chance = 1 + Rnd() * 5
                If chance = 1 Or 2 Then
                    If yourturn = True Then
                        estatus = 4
                    ElseIf yourturn = False Then
                        ystatus = 4
                    End If
                End If
            Case "Smog"
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
                chance = 1 + Rnd() * 5
                If chance = 1 Or 2 Then
                    If yourturn = True Then
                        estatus = 4
                    ElseIf yourturn = False Then
                        ystatus = 4
                    End If
                End If
            Case "Smokescreen"
                enemypokemon(4) -= enemypokemonstat(4) / 2
                Label7.Text = "The enemy's Speed fell by 1 stage!"
            Case "Solar Beam"
            Case "Sonic Boom"
                enemypokemon(1) -= 10
            Case "Spike Cannon"
                tempcounter = 1
                chance = 1 + Rnd() * 8
                Select Case chance
                    Case 1, 2, 3
                        TimerSpikeCannon.Enabled = True
                        countSpikeCannon = 2
                    Case 4, 5, 6
                        TimerSpikeCannon.Enabled = True
                        countSpikeCannon = 3
                    Case 7
                        TimerSpikeCannon.Enabled = True
                        countSpikeCannon = 4
                    Case 8
                        TimerSpikeCannon.Enabled = True
                        countSpikeCannon = 5
                End Select
            Case "Splash"
                Label7.Text = "But nothing happened!"
            Case "Spore"
                If yourturn = True Then
                    estatus = 6
                ElseIf yourturn = False Then
                    ystatus = 6
                End If
            Case "Stomp"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 32.5 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Or 2 Or 3 Then

                    If yourturn = False Then
                        yflinch = True
                        Label7.Text = "Your Pokemon flinched!"
                    ElseIf yourturn = True Then
                        eflinch = True
                        Label7.Text = "The enemy flinched!"
                    End If
                End If
            Case "Strength"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
            Case "String Shot"
                enemypokemon(4) -= enemypokemonstat(4) / 2
                Label7.Text = "The enemy's Speed fell by 1 stage!"
            Case "Stun Spore"
                If yourturn = True Then
                    estatus = 3
                ElseIf yourturn = False Then
                    ystatus = 3
                End If
            Case "Submission"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                yourpokemon(1) -= tempattack * 10 / enemypokemon(3)
            Case "Supersonic"
                If yourturn = True Then
                    estatus = 7
                ElseIf yourturn = False Then
                    ystatus = 7
                End If
            Case "Super Fang"
                enemypokemon(1) = enemypokemon(1) / 2
            Case "Surf"
                Select Case DAttackS(15)
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
                enemypokemon(1) -= tempspecial * 45 / enemypokemon(5)
            Case "Swift"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempspecial * 30 / enemypokemon(5)
            Case "Swords Dance"
                yourpokemon(2) += yourpokemonstat(2)
                Label7.Text = "Your Attack went up by 2 stages!"
            Case "Tackle"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 20 / enemypokemon(3)
            Case "Tail Whip"
                enemypokemon(3) -= enemypokemonstat(3) / 2
                Label7.Text = "Enemy Defence Was Lowered by 1 Stage!"
            Case "Take Down"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 45 / enemypokemon(3)
                yourpokemon(1) -= tempattack * 22.5 / enemypokemon(3) / 2
            Case "Teleport"
                If frmBattleSelect.trainerbattle = False Then
                    enemypokemon(1) = 0
                End If
            Case "Thunder"
                Select Case DAttackS(10)
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
                enemypokemon(1) -= tempspecial * 55 / enemypokemon(5)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = False Then
                        ystatus = 3
                        Label7.Text = "Your Pokemon was paralyzed!"
                    ElseIf yourturn = True Then
                        estatus = 3
                        Label7.Text = "The enemy was paralyzed!"
                    End If
                End If
            Case "Thunder Punch"
                Select Case DAttackS(10)
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
                enemypokemon(1) -= tempattack * 37.5 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = False Then
                        ystatus = 3
                        Label7.Text = "Your Pokemon was paralyzed!"
                    ElseIf yourturn = True Then
                        estatus = 3
                        Label7.Text = "The enemy was paralyzed!"
                    End If
                End If
            Case "Thunder Shock"
                Select Case DAttackS(10)
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
                enemypokemon(1) -= tempspecial * 20 / enemypokemon(5)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = False Then
                        ystatus = 3
                        Label7.Text = "Your Pokemon was paralyzed!"
                    ElseIf yourturn = True Then
                        estatus = 3
                        Label7.Text = "The enemy was paralyzed!"
                    End If
                End If
            Case "Thunder Wave"
                If yourturn = True Then
                    estatus = 3
                ElseIf yourturn = False Then
                    ystatus = 3
                End If
            Case "Thunderbolt"
                Select Case DAttackS(10)
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
                enemypokemon(1) -= tempspecial * 45 / enemypokemon(5)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = False Then
                        ystatus = 3
                        Label7.Text = "Your Pokemon was paralyzed!"
                    ElseIf yourturn = True Then
                        estatus = 3
                        Label7.Text = "The enemy was paralyzed!"
                    End If
                End If
            Case "Toxic"
                If yourturn = True Then
                    estatus = 5
                ElseIf yourturn = False Then
                    ystatus = 5
                End If
            Case "Tri Attack"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempspecial * 40 / enemypokemon(5)
            Case "Vice Grip"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 27.5 / enemypokemon(3)
            Case "Vine Whip"
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
                enemypokemon(1) -= tempattack * 22.5 / enemypokemon(3)
            Case "Water Gun"
                Select Case DAttackS(15)
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
                enemypokemon(1) -= tempspecial * 20 / enemypokemon(5)
            Case "Whirlwind"
                If frmBattleSelect.trainerbattle = False Then
                    enemypokemon(1) = 0
                End If
            Case "Wing Attack"
                Select Case DAttackS(6)
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
                enemypokemon(1) -= tempattack * 17.5 / enemypokemon(3)
            Case "Withdraw"
                yourpokemon(3) += yourpokemonstat(3) / 2
                Label7.Text = "Your Defense went up by 1 stage!"
            Case "Wrap"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 17.5 / enemypokemon(3)
                chance = 1 + Rnd() * 8
                If yourturn = True Then
                    Select Case chance
                        Case 1, 2, 3
                            eboundcounter = 2
                        Case 4, 5, 6
                            eboundcounter = 3
                        Case 7
                            eboundcounter = 4
                        Case 8
                            eboundcounter = 5
                    End Select
                ElseIf yourturn = False Then
                    Select Case chance
                        Case 1, 2, 3
                            yboundcounter = 2
                        Case 4, 5, 6
                            yboundcounter = 3
                        Case 7
                            yboundcounter = 4
                        Case 8
                            yboundcounter = 5
                    End Select
                End If


            Case "Hadouken"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempspecial * 35.5 / enemypokemon(5)
            Case "Shoryuken"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 55 / enemypokemon(3)
            Case "Collarbone Breaker"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                If chance = 1 Then
                    enemypokemon(3) -= enemypokemonstat(3)
                    Label7.Text = "Enemy Defence Was Lowered by 2 Stages!"
                End If
            Case "Heat Rush"
                Select Case DAttackS(5)
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
                enemypokemon(1) -= tempattack * 35 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = True Then
                        Label7.Text = "The enemy was Burned!"
                        estatus = 1
                    ElseIf yourturn = False Then
                        Label7.Text = "Your Pokemon was Burned!"
                        ystatus = 1
                    End If
                End If
            Case "Guren Enjinkyaku"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 45 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = True Then
                        Label7.Text = "The enemy was Burned!"
                        estatus = 1
                    ElseIf yourturn = False Then
                        Label7.Text = "Your Pokemon was Burned!"
                        ystatus = 1
                    End If
                End If
            Case "Quick Step"
                yourpokemon(4) += yourpokemonstat(4)
                Label7.Text = "Your Speed went up by 2 stages!"
            Case "Lightning Cannonball"
                Select Case DAttackS(10)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = False Then
                        ystatus = 3
                        Label7.Text = "Your Pokemon was paralyzed!"
                    ElseIf yourturn = True Then
                        estatus = 3
                        Label7.Text = "The enemy was paralyzed!"
                    End If
                End If
            Case "Shout Of Earth"
                Select Case DAttackS(10)
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
                enemypokemon(1) -= tempspecial * 37.5 / enemypokemon(5)
                chance = 1 + Rnd() * 8
                If chance = 1 Then
                    If yourturn = False Then
                        ystatus = 3
                        Label7.Text = "Your Pokemon was paralyzed!"
                    ElseIf yourturn = True Then
                        estatus = 3
                        Label7.Text = "The enemy was paralyzed!"
                    End If
                End If
            Case "Psycho Crusher"
                Select Case DAttackS(13)
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
                enemypokemon(1) -= tempattack * 65 / enemypokemon(3)
            Case "Super Scissor Kicks"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 55 / enemypokemon(3)
            Case "Devil's Reverse"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
            Case "Raging Demon"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                chance = 1 + Rnd() * 3
                If chance = 1 Then
                    enemypokemon(1) = 0
                End If
            Case "Gou Shoryuken"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 60 / enemypokemon(3)
            Case "Ahura Senku"
                yourpokemon(4) += yourpokemonstat(4)
                Label7.Text = "Your Speed went up by 2 stages!"
            Case "Buffalo Headbutt"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 60 / enemypokemon(3)
                yourpokemon(1) -= tempattack * 45 / enemypokemon(3) / 2
            Case "Super Running Uppercut"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                chance = 1 + Rnd() * 5
                If chance = 1 Then
                    yourpokemon(4) += yourpokemonstat(4) / 2
                    Label7.Text = "Your Speed went up by 1 stage!"
                End If
            Case "Dash Punch"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                chance = 1 + Rnd() * 3
                If chance = 1 Then
                    yourpokemon(4) += yourpokemonstat(4) / 2
                    Label7.Text = "Your Speed went up by 1 stage!"
                End If
            Case "Head Bomber"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 60 / enemypokemon(3)
                yourpokemon(1) -= tempattack * 35 / enemypokemon(3)
        End Select
    End Sub

    Private Sub btnMove3_Click(sender As Object, e As EventArgs) Handles btnMove3.Click
        Dim tempattack As Double
        Dim tempspecial As Double
        Dim chance As Integer

        Select Case yourpokemon(12)
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
                tempcounter = 1
                chance = 1 + Rnd() * 8
                Select Case chance
                    Case 1, 2, 3
                        TimerBarrage.Enabled = True
                        countBarrage = 2
                    Case 4, 5, 6
                        TimerBarrage.Enabled = True
                        countBarrage = 3
                    Case 7
                        TimerBarrage.Enabled = True
                        countBarrage = 4
                    Case 8
                        TimerBarrage.Enabled = True
                        countBarrage = 5
                End Select
            Case "Barrier"
                yourpokemon(3) += yourpokemonstat(3)
                Label7.Text = "Your defense went up by 2 stages!"
            Case "Bide"

            Case "Bite"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 30 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Then

                    If yourturn = False Then
                        yflinch = True
                        Label7.Text = "Your Pokemon flinched!"
                    ElseIf yourturn = True Then
                        eflinch = True
                        Label7.Text = "The enemy flinched!"
                    End If
                End If
            Case "Blizzard"
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
                enemypokemon(1) -= tempspecial * 65 / enemypokemon(5)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = True Then
                        Label7.Text = "The enemy was frozen!"
                        estatus = 2
                    ElseIf yourturn = False Then
                        Label7.Text = "Your Pokemon was frozen!"
                        ystatus = 2
                    End If
                End If
            Case "Body Slam"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 42.5 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Or 2 Or 3 Then
                    If yourturn = False Then
                        ystatus = 3
                        Label7.Text = "Your Pokemon was paralyzed!"
                    ElseIf yourturn = True Then
                        estatus = 3
                        Label7.Text = "The enemy was paralyzed!"
                    End If
                End If
            Case "Bone Club"
                Select Case DAttackS(9)
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
                enemypokemon(1) -= tempattack * 32.5 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = False Then
                        yflinch = True
                        Label7.Text = "Your Pokemon flinched!"
                    ElseIf yourturn = True Then
                        eflinch = True
                        Label7.Text = "The enemy flinched!"
                    End If
                End If
            Case "Bonemerang"
                TimerBonemerang.Enabled = True
                tempcounter = 1
            Case "Bubble"
                Select Case DAttackS(15)
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
                chance = 1 + Rnd() * 3
                If chance = 1 Then
                    enemypokemon(4) -= enemypokemonstat(4) / 2
                    Label7.Text = "Enemy Speed Was Lowered by 1 Stage!"
                End If
            Case "Clamp"
                Select Case DAttackS(15)
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
                enemypokemon(1) -= tempattack * 17.5 / enemypokemon(3)
                chance = 1 + Rnd() * 8
                If yourturn = True Then
                    Select Case chance
                        Case 1, 2, 3
                            eboundcounter = 2
                        Case 4, 5, 6
                            eboundcounter = 3
                        Case 7
                            eboundcounter = 4
                        Case 8
                            eboundcounter = 5
                    End Select
                ElseIf yourturn = False Then
                    Select Case chance
                        Case 1, 2, 3
                            yboundcounter = 2
                        Case 4, 5, 6
                            yboundcounter = 3
                        Case 7
                            yboundcounter = 4
                        Case 8
                            yboundcounter = 5
                    End Select
                End If
            Case "Confuse Ray"
                If yourturn = True Then
                    Label7.Text = "The enemy was Confused!"
                    estatus = 7
                ElseIf yourturn = False Then
                    Label7.Text = "Your Pokemon was Confused!"
                    ystatus = 7
                End If
            Case "Confusion"
                Select Case DAttackS(13)
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
                enemypokemon(1) -= tempspecial * 25 / enemypokemon(5)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = True Then
                        Label7.Text = "The enemy was Confused!"
                        estatus = 7
                    ElseIf yourturn = False Then
                        Label7.Text = "Your Pokemon was Confused!"
                        ystatus = 7
                    End If
                End If
            Case "Crabhammer"
                Select Case DAttackS(15)
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
                enemypokemon(1) -= tempattack * 50 / enemypokemon(3)
            Case "Cut"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 25 / enemypokemon(3)
            Case "Defense Curl"
                yourpokemon(3) += yourpokemonstat(3) / 2
                Label7.Text = "Your defense went up by 1 stage!"
            Case "Dig"
                If yourturn = True Then
                    yDigcharge = 1
                ElseIf yourturn = False Then
                    eDigcharge = 1
                End If
            Case "Disable"
            Case "Dizzy Punch"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 35 / enemypokemon(3)
            Case "Double Kick"
                TimerDoubleKick.Enabled = True
                tempcounter = 1
            Case "Double Slap"
                tempcounter = 1
                chance = 1 + Rnd() * 8
                Select Case chance
                    Case 1, 2, 3
                        TimerDoubleSlap.Enabled = True
                        countDoubleSlap = 2
                    Case 4, 5, 6
                        TimerDoubleSlap.Enabled = True
                        countDoubleSlap = 3
                    Case 7
                        TimerDoubleSlap.Enabled = True
                        countDoubleSlap = 4
                    Case 8
                        TimerDoubleSlap.Enabled = True
                        countDoubleSlap = 5
                End Select
            Case "Double Team"
                yourpokemon(4) += yourpokemonstat(4) / 2
                Label7.Text = "Your speed went up by 1 stage!"
            Case "Double-Edge"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 60 / enemypokemon(3)
                yourpokemon(1) -= tempattack * 15 / enemypokemon(3)
            Case "Dream Eater"
                If yourturn = True Then
                    If estatus = 6 Then
                        Select Case DAttackS(13)
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
                        enemypokemon(1) -= tempspecial * 50 / enemypokemon(5)
                        yourpokemon(1) = +tempspecial * 50 / enemypokemon(5)
                    ElseIf estatus <> 6 Then
                        Label7.Text = "The attack failed!"
                    End If
                ElseIf yourturn = False Then
                    If ystatus = 6 Then
                        Select Case DAttackS(13)
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
                        enemypokemon(1) -= tempspecial * 50 / enemypokemon(5)
                        yourpokemon(1) = +tempspecial * 50 / enemypokemon(5)
                    ElseIf ystatus <> 6 Then
                        Label7.Text = "The attack failed!"
                    End If
                End If
            Case "Drill Peck"
                Select Case DAttackS(6)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
            Case "Earthquake"
                Select Case DAttackS(9)
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
                enemypokemon(1) -= tempattack * 50 / enemypokemon(3)
            Case "Egg Bomb"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 50 / enemypokemon(3)
            Case "Ember"
                Select Case DAttackS(5)
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
                enemypokemon(1) -= tempspecial * 20 / enemypokemon(5)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = True Then
                        Label7.Text = "The enemy was Burned!"
                        estatus = 1
                    ElseIf yourturn = False Then
                        Label7.Text = "Your Pokemon was Burned!"
                        ystatus = 1
                    End If
                End If
            Case "Explosion"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 170 / enemypokemon(3)
                yourpokemon(1) = 0
            Case "Fire Blast"
                Select Case DAttackS(5)
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
                enemypokemon(1) -= tempspecial * 60 / enemypokemon(5)
                chance = 1 + Rnd() * 3
                If chance = 1 Then
                    If yourturn = True Then
                        Label7.Text = "The enemy was Burned!"
                        estatus = 1
                    ElseIf yourturn = False Then
                        Label7.Text = "Your Pokemon was Burned!"
                        ystatus = 1
                    End If
                End If
            Case "Fire Punch"
                Select Case DAttackS(5)
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
                enemypokemon(1) -= tempattack * 37.5 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = True Then
                        Label7.Text = "The enemy was Burned!"
                        estatus = 1
                    ElseIf yourturn = False Then
                        Label7.Text = "Your Pokemon was Burned!"
                        ystatus = 1
                    End If
                End If
            Case "Fire Spin"
                Select Case DAttackS(5)
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
                enemypokemon(1) -= tempattack * 17.5 / enemypokemon(3)
                chance = 1 + Rnd() * 8
                If yourturn = True Then
                    Select Case chance
                        Case 1, 2, 3
                            eboundcounter = 2
                        Case 4, 5, 6
                            eboundcounter = 3
                        Case 7
                            eboundcounter = 4
                        Case 8
                            eboundcounter = 5
                    End Select
                ElseIf yourturn = False Then
                    Select Case chance
                        Case 1, 2, 3
                            yboundcounter = 2
                        Case 4, 5, 6
                            yboundcounter = 3
                        Case 7
                            yboundcounter = 4
                        Case 8
                            yboundcounter = 5
                    End Select
                End If
            Case "Flamethrower"
                Select Case DAttackS(5)
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
                enemypokemon(1) -= tempspecial * 47.5 / enemypokemon(5)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = True Then
                        Label7.Text = "The enemy was Burned!"
                        estatus = 1
                    ElseIf yourturn = False Then
                        Label7.Text = "Your Pokemon was Burned!"
                        ystatus = 1
                    End If
                End If
            Case "Flash"
                enemypokemon(4) -= enemypokemonstat(4) / 2
                Label7.Text = "The Enemy's speed fell by 1 stage!"
            Case "Fly"
                If yourturn = True Then
                    yFlycharge = 1
                ElseIf yourturn = False Then
                    eFlycharge = 1
                End If
            Case "Focus Energy"
                yourpokemon(4) += yourpokemonstat(4) / 2
                yourpokemon(2) += yourpokemonstat(2) / 2
                yourpokemon(5) += yourpokemonstat(5) / 2
                Label7.Text = "Your pokemon is getting pumped!"
            Case "Fury Attack"
                tempcounter = 1
                chance = 1 + Rnd() * 8
                Select Case chance
                    Case 1, 2, 3
                        TimerFuryAttack.Enabled = True
                        countFuryAttack = 2
                    Case 4, 5, 6
                        TimerFuryAttack.Enabled = True
                        countFuryAttack = 3
                    Case 7
                        TimerFuryAttack.Enabled = True
                        countFuryAttack = 4
                    Case 8
                        TimerFuryAttack.Enabled = True
                        countFuryAttack = 5
                End Select
            Case "Fury Swipes"
                tempcounter = 1
                chance = 1 + Rnd() * 8
                Select Case chance
                    Case 1, 2, 3
                        TimerFurySwipes.Enabled = True
                        countFurySwipes = 2
                    Case 4, 5, 6
                        TimerFurySwipes.Enabled = True
                        countFurySwipes = 3
                    Case 7
                        TimerFurySwipes.Enabled = True
                        countFurySwipes = 4
                    Case 8
                        TimerFurySwipes.Enabled = True
                        countFurySwipes = 5
                End Select
            Case "Glare"
                If yourturn = True Then
                    Label7.Text = "The enemy was Paralyzed!"
                    estatus = 3
                ElseIf yourturn = False Then
                    Label7.Text = "Your Pokemon was Paralyzed!"
                    ystatus = 3
                End If
            Case "Growl"
                enemypokemon(2) -= enemypokemonstat(2) / 2
                Label7.Text = "Enemy Attack Was Lowered by 1 Stage!"
            Case "Growth"
                yourpokemon(5) += yourpokemonstat(5) / 2
                Label7.Text = "Your special went up by 1 stage!"
            Case "Guillotine"
                chance = 1 + Rnd() * 3
                If chance = 1 Then
                    enemypokemon(1) = 0
                End If
            Case "Gust"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 20 / enemypokemon(3)
            Case "Harden"
                yourpokemon(3) += yourpokemonstat(3) / 2
                Label7.Text = "Your Defense went up by 1 stage!"
            Case "Haze"
                enemypokemon(2) = enemypokemonstat(2)
                enemypokemon(3) = enemypokemonstat(3)
                enemypokemon(4) = enemypokemonstat(4)
                enemypokemon(5) = enemypokemonstat(5)

                yourpokemon(2) = yourpokemonstat(2)
                yourpokemon(3) = yourpokemonstat(3)
                yourpokemon(4) = yourpokemonstat(4)
                yourpokemon(5) = yourpokemonstat(5)

                Label7.Text = "Stats have been reset!"

            Case "Headbutt"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 35 / enemypokemon(3)
                chance = 1 + Rnd() * 3
                If chance = 1 Then
                    If yourturn = True Then
                        eflinch = True
                    ElseIf yourturn = False Then
                        yflinch = True
                    End If
                End If
            Case "Horn Attack"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 32.5 / enemypokemon(3)
            Case "Horn Drill"
                chance = 1 + Rnd() * 3
                If chance = 1 Then
                    enemypokemon(1) = 0
                End If
            Case "Hydro Pump"
                Select Case DAttackS(15)
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
                enemypokemon(1) -= tempspecial * 55 / enemypokemon(5)
            Case "Hyper Beam"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempspecial * 75 / enemypokemon(5)
                If yourturn = True Then
                    yHBcharge = True
                ElseIf yourturn = False Then
                    eHBcharge = True
                End If
            Case "Hyper Fang"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Then

                    If yourturn = False Then
                        yflinch = True
                        Label7.Text = "Your Pokemon flinched!"
                    ElseIf yourturn = True Then
                        eflinch = True
                        Label7.Text = "The enemy flinched!"
                    End If
                End If
            Case "Hypnosis"
                chance = 1 + Rnd() * 3
                If chance = 1 Or 2 Then
                    If yourturn = True Then
                        estatus = 6
                    ElseIf yourturn = False Then
                        ystatus = 6
                    End If
                End If
            Case "Ice Beam"
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
                enemypokemon(1) -= tempspecial * 45 / enemypokemon(5)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = True Then
                        Label7.Text = "The enemy was Frozen!"
                        estatus = 2
                    ElseIf yourturn = False Then
                        Label7.Text = "Your Pokemon was Frozen!"
                        ystatus = 2
                    End If
                End If
            Case "Karate Chop"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 25 / enemypokemon(3)
            Case "Leech Life"
                Select Case DAttackS(1)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                yourpokemon(1) += tempattack * 20 / enemypokemon(3)
            Case "Leer"
                enemypokemon(3) -= enemypokemonstat(3) / 2
                Label7.Text = "Enemy Defense went fell by 1 stage!"
            Case "Lick"
                Select Case DAttackS(8)
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
                enemypokemon(1) -= tempattack * 15 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Or 2 Or 3 Then
                    If yourturn = False Then
                        ystatus = 3
                        Label7.Text = "Your Pokemon was paralyzed!"
                    ElseIf yourturn = True Then
                        estatus = 3
                        Label7.Text = "The enemy was paralyzed!"
                    End If
                End If
            Case "Light Screen"
                yourpokemon(5) = yourpokemon(5) * 2
            Case "Low Kick"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 25 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Or 2 Or 3 Then

                    If yourturn = False Then
                        yflinch = True
                        Label7.Text = "Your Pokemon flinched!"
                    ElseIf yourturn = True Then
                        eflinch = True
                        Label7.Text = "The enemy flinched!"
                    End If
                End If
            Case "Mega Drain"
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
                enemypokemon(1) -= tempspecial * 37.5 / enemypokemon(5)
                yourpokemon(1) += tempspecial * 37.5 / enemypokemon(5) / 2
            Case "Mega Kick"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 60 / enemypokemon(3)
            Case "Mega Punch"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
            Case "Metronone"
            Case "Mist"
                enemypokemon(2) = enemypokemonstat(2)
                enemypokemon(3) = enemypokemonstat(3)
                enemypokemon(4) = enemypokemonstat(4)
                enemypokemon(5) = enemypokemonstat(5)

                yourpokemon(2) = yourpokemonstat(2)
                yourpokemon(3) = yourpokemonstat(3)
                yourpokemon(4) = yourpokemonstat(4)
                yourpokemon(5) = yourpokemonstat(5)

                Label7.Text = "Stats have been reset!"
            Case "Night Shade"
                enemypokemon(1) -= 25
            Case "Pay Day"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 10 / enemypokemon(3)
                If yourturn = True Then
                    payday = True
                End If
            Case "Peck"
                Select Case DAttackS(6)
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
                enemypokemon(1) -= tempattack * 17.5 / enemypokemon(3)
            Case "Petal Dance"
            Case "Pin Missile"
                tempcounter = 1
                chance = 1 + Rnd() * 8
                Select Case chance
                    Case 1, 2, 3
                        TimerPinMissile.Enabled = True
                        countPinMissile = 2
                    Case 4, 5, 6
                        TimerPinMissile.Enabled = True
                        countPinMissile = 3
                    Case 7
                        TimerPinMissile.Enabled = True
                        countPinMissile = 4
                    Case 8
                        TimerPinMissile.Enabled = True
                        countPinMissile = 5
                End Select
            Case "Poison Gas"
                chance = 1 + Rnd() * 2
                If chance = 1 Then
                    If yourturn = True Then
                        estatus = 4
                        Label7.Text = "The enemy was Poisoned!"
                    ElseIf yourturn = False Then
                        ystatus = 4
                        Label7.Text = "Your pokemon was Poisoned!"
                    End If
                End If
            Case "Poison Powder"
                If yourturn = True Then
                    estatus = 4
                    Label7.Text = "The enemy was Poisoned!"
                ElseIf yourturn = False Then
                    ystatus = 4
                    Label7.Text = "Your pokemon was Poisoned!"
                End If
            Case "Poison Sting"
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
                enemypokemon(1) -= tempattack * 7.5 / enemypokemon(3)
                chance = 1 + Rnd() * 5
                If chance = 1 Then
                    If yourturn = True Then
                        estatus = 4
                        Label7.Text = "The enemy was Poisoned!"
                    ElseIf yourturn = False Then
                        ystatus = 4
                        Label7.Text = "Your pokemon was Poisoned!"
                    End If
                End If
            Case "Pound"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 20 / enemypokemon(3)
            Case "Psybeam"
                Select Case DAttackS(13)
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
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = True Then
                        estatus = 7
                        Label7.Text = "The enemy was Confused!"
                    ElseIf yourturn = False Then
                        ystatus = 7
                        Label7.Text = "Your pokemon was Confused!"
                    End If
                End If
            Case "Psychic"
                Select Case DAttackS(13)
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
                enemypokemon(1) -= tempspecial * 45 / enemypokemon(5)
                chance = 1 + Rnd() * 3
                If chance = 1 Then
                    enemypokemon(5) -= enemypokemonstat(5) / 2
                    Label7.Text = "The enemy special fell by 1 stage!"
                End If
            Case "Quick Attack"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 20 / enemypokemon(3)
            Case "Razor Leaf"
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
                enemypokemon(1) -= tempspecial * 25.5 / enemypokemon(5)
            Case "Razor Wind"
            Case "Recover"
                yourpokemon(1) += yourpokemonstat(1) / 2
            Case "Reflect"
                yourpokemon(3) = yourpokemon(3) * 2
            Case "Rest"
                yourpokemon(1) = yourpokemonstat(1)
                If yourturn = True Then
                    ystatus = 6
                ElseIf yourturn = False Then
                    estatus = 6
                End If
            Case "Rock Slide"
                Select Case DAttackS(14)
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
                enemypokemon(1) -= tempattack * 37.5 / enemypokemon(3)
            Case "Rock Throw"
                Select Case DAttackS(14)
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
                enemypokemon(1) -= tempattack * 25 / enemypokemon(3)
            Case "Sand Attack"
                enemypokemon(4) -= enemypokemonstat(4) / 2
                Label7.Text = "The enemy's speed fell by 1 stage!"
            Case "Scratch"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 20 / enemypokemon(3)
            Case "Screech"
                enemypokemon(3) -= enemypokemonstat(3)
                Label7.Text = "The Enemy's Defense fell by 2 stages!"
            Case "Seismic Toss"
                enemypokemon(1) -= 50
            Case "Self Destruct"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 130 / enemypokemon(3)
                yourpokemon(1) = 0
            Case "Skull Bash"
            Case "Sky Attack"
            Case "Slam"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
            Case "Slash"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 35 / enemypokemon(3)
            Case "Sleep Powder"
                If yourturn = True Then
                    estatus = 6
                ElseIf yourturn = False Then
                    ystatus = 6
                End If
            Case "Sludge"
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
                enemypokemon(1) -= tempspecial * 32.6 / enemypokemon(5)
                chance = 1 + Rnd() * 5
                If chance = 1 Or 2 Then
                    If yourturn = True Then
                        estatus = 4
                    ElseIf yourturn = False Then
                        ystatus = 4
                    End If
                End If
            Case "Smog"
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
                chance = 1 + Rnd() * 5
                If chance = 1 Or 2 Then
                    If yourturn = True Then
                        estatus = 4
                    ElseIf yourturn = False Then
                        ystatus = 4
                    End If
                End If
            Case "Smokescreen"
                enemypokemon(4) -= enemypokemonstat(4) / 2
                Label7.Text = "The enemy's Speed fell by 1 stage!"
            Case "Solar Beam"
            Case "Sonic Boom"
                enemypokemon(1) -= 10
            Case "Spike Cannon"
                tempcounter = 1
                chance = 1 + Rnd() * 8
                Select Case chance
                    Case 1, 2, 3
                        TimerSpikeCannon.Enabled = True
                        countSpikeCannon = 2
                    Case 4, 5, 6
                        TimerSpikeCannon.Enabled = True
                        countSpikeCannon = 3
                    Case 7
                        TimerSpikeCannon.Enabled = True
                        countSpikeCannon = 4
                    Case 8
                        TimerSpikeCannon.Enabled = True
                        countSpikeCannon = 5
                End Select
            Case "Splash"
                Label7.Text = "But nothing happened!"
            Case "Spore"
                If yourturn = True Then
                    estatus = 6
                ElseIf yourturn = False Then
                    ystatus = 6
                End If
            Case "Stomp"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 32.5 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Or 2 Or 3 Then

                    If yourturn = False Then
                        yflinch = True
                        Label7.Text = "Your Pokemon flinched!"
                    ElseIf yourturn = True Then
                        eflinch = True
                        Label7.Text = "The enemy flinched!"
                    End If
                End If
            Case "Strength"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
            Case "String Shot"
                enemypokemon(4) -= enemypokemonstat(4) / 2
                Label7.Text = "The enemy's Speed fell by 1 stage!"
            Case "Stun Spore"
                If yourturn = True Then
                    estatus = 3
                ElseIf yourturn = False Then
                    ystatus = 3
                End If
            Case "Submission"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                yourpokemon(1) -= tempattack * 10 / enemypokemon(3)
            Case "Supersonic"
                If yourturn = True Then
                    estatus = 7
                ElseIf yourturn = False Then
                    ystatus = 7
                End If
            Case "Super Fang"
                enemypokemon(1) = enemypokemon(1) / 2
            Case "Surf"
                Select Case DAttackS(15)
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
                enemypokemon(1) -= tempspecial * 45 / enemypokemon(5)
            Case "Swift"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempspecial * 30 / enemypokemon(5)
            Case "Swords Dance"
                yourpokemon(2) += yourpokemonstat(2)
                Label7.Text = "Your Attack went up by 2 stages!"
            Case "Tackle"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 20 / enemypokemon(3)
            Case "Tail Whip"
                enemypokemon(3) -= enemypokemonstat(3) / 2
                Label7.Text = "Enemy Defence Was Lowered by 1 Stage!"
            Case "Take Down"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 45 / enemypokemon(3)
                yourpokemon(1) -= tempattack * 22.5 / enemypokemon(3) / 2
            Case "Teleport"
                If frmBattleSelect.trainerbattle = False Then
                    enemypokemon(1) = 0
                End If
            Case "Thunder"
                Select Case DAttackS(10)
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
                enemypokemon(1) -= tempspecial * 55 / enemypokemon(5)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = False Then
                        ystatus = 3
                        Label7.Text = "Your Pokemon was paralyzed!"
                    ElseIf yourturn = True Then
                        estatus = 3
                        Label7.Text = "The enemy was paralyzed!"
                    End If
                End If
            Case "Thunder Punch"
                Select Case DAttackS(10)
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
                enemypokemon(1) -= tempattack * 37.5 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = False Then
                        ystatus = 3
                        Label7.Text = "Your Pokemon was paralyzed!"
                    ElseIf yourturn = True Then
                        estatus = 3
                        Label7.Text = "The enemy was paralyzed!"
                    End If
                End If
            Case "Thunder Shock"
                Select Case DAttackS(10)
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
                enemypokemon(1) -= tempspecial * 20 / enemypokemon(5)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = False Then
                        ystatus = 3
                        Label7.Text = "Your Pokemon was paralyzed!"
                    ElseIf yourturn = True Then
                        estatus = 3
                        Label7.Text = "The enemy was paralyzed!"
                    End If
                End If
            Case "Thunder Wave"
                If yourturn = True Then
                    estatus = 3
                ElseIf yourturn = False Then
                    ystatus = 3
                End If
            Case "Thunderbolt"
                Select Case DAttackS(10)
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
                enemypokemon(1) -= tempspecial * 45 / enemypokemon(5)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = False Then
                        ystatus = 3
                        Label7.Text = "Your Pokemon was paralyzed!"
                    ElseIf yourturn = True Then
                        estatus = 3
                        Label7.Text = "The enemy was paralyzed!"
                    End If
                End If
            Case "Toxic"
                If yourturn = True Then
                    estatus = 5
                ElseIf yourturn = False Then
                    ystatus = 5
                End If
            Case "Tri Attack"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempspecial * 40 / enemypokemon(5)
            Case "Vice Grip"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 27.5 / enemypokemon(3)
            Case "Vine Whip"
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
                enemypokemon(1) -= tempattack * 22.5 / enemypokemon(3)
            Case "Water Gun"
                Select Case DAttackS(15)
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
                enemypokemon(1) -= tempspecial * 20 / enemypokemon(5)
            Case "Whirlwind"
                If frmBattleSelect.trainerbattle = False Then
                    enemypokemon(1) = 0
                End If
            Case "Wing Attack"
                Select Case DAttackS(6)
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
                enemypokemon(1) -= tempattack * 17.5 / enemypokemon(3)
            Case "Withdraw"
                yourpokemon(3) += yourpokemonstat(3) / 2
                Label7.Text = "Your Defense went up by 1 stage!"
            Case "Wrap"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 17.5 / enemypokemon(3)
                chance = 1 + Rnd() * 8
                If yourturn = True Then
                    Select Case chance
                        Case 1, 2, 3
                            eboundcounter = 2
                        Case 4, 5, 6
                            eboundcounter = 3
                        Case 7
                            eboundcounter = 4
                        Case 8
                            eboundcounter = 5
                    End Select
                ElseIf yourturn = False Then
                    Select Case chance
                        Case 1, 2, 3
                            yboundcounter = 2
                        Case 4, 5, 6
                            yboundcounter = 3
                        Case 7
                            yboundcounter = 4
                        Case 8
                            yboundcounter = 5
                    End Select
                End If


            Case "Hadouken"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempspecial * 35.5 / enemypokemon(5)
            Case "Shoryuken"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 55 / enemypokemon(3)
            Case "Collarbone Breaker"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                If chance = 1 Then
                    enemypokemon(3) -= enemypokemonstat(3)
                    Label7.Text = "Enemy Defence Was Lowered by 2 Stages!"
                End If
            Case "Heat Rush"
                Select Case DAttackS(5)
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
                enemypokemon(1) -= tempattack * 35 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = True Then
                        Label7.Text = "The enemy was Burned!"
                        estatus = 1
                    ElseIf yourturn = False Then
                        Label7.Text = "Your Pokemon was Burned!"
                        ystatus = 1
                    End If
                End If
            Case "Guren Enjinkyaku"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 45 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = True Then
                        Label7.Text = "The enemy was Burned!"
                        estatus = 1
                    ElseIf yourturn = False Then
                        Label7.Text = "Your Pokemon was Burned!"
                        ystatus = 1
                    End If
                End If
            Case "Quick Step"
                yourpokemon(4) += yourpokemonstat(4)
                Label7.Text = "Your Speed went up by 2 stages!"
            Case "Lightning Cannonball"
                Select Case DAttackS(10)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = False Then
                        ystatus = 3
                        Label7.Text = "Your Pokemon was paralyzed!"
                    ElseIf yourturn = True Then
                        estatus = 3
                        Label7.Text = "The enemy was paralyzed!"
                    End If
                End If
            Case "Shout Of Earth"
                Select Case DAttackS(10)
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
                enemypokemon(1) -= tempspecial * 37.5 / enemypokemon(5)
                chance = 1 + Rnd() * 8
                If chance = 1 Then
                    If yourturn = False Then
                        ystatus = 3
                        Label7.Text = "Your Pokemon was paralyzed!"
                    ElseIf yourturn = True Then
                        estatus = 3
                        Label7.Text = "The enemy was paralyzed!"
                    End If
                End If
            Case "Psycho Crusher"
                Select Case DAttackS(13)
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
                enemypokemon(1) -= tempattack * 65 / enemypokemon(3)
            Case "Super Scissor Kicks"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 55 / enemypokemon(3)
            Case "Devil's Reverse"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
            Case "Raging Demon"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                chance = 1 + Rnd() * 3
                If chance = 1 Then
                    enemypokemon(1) = 0
                End If
            Case "Gou Shoryuken"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 60 / enemypokemon(3)
            Case "Ahura Senku"
                yourpokemon(4) += yourpokemonstat(4)
                Label7.Text = "Your Speed went up by 2 stages!"
            Case "Buffalo Headbutt"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 60 / enemypokemon(3)
                yourpokemon(1) -= tempattack * 45 / enemypokemon(3) / 2
            Case "Super Running Uppercut"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                chance = 1 + Rnd() * 5
                If chance = 1 Then
                    yourpokemon(4) += yourpokemonstat(4) / 2
                    Label7.Text = "Your Speed went up by 1 stage!"
                End If
            Case "Dash Punch"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                chance = 1 + Rnd() * 3
                If chance = 1 Then
                    yourpokemon(4) += yourpokemonstat(4) / 2
                    Label7.Text = "Your Speed went up by 1 stage!"
                End If
            Case "Head Bomber"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 60 / enemypokemon(3)
                yourpokemon(1) -= tempattack * 35 / enemypokemon(3)
        End Select
    End Sub

    Private Sub btnMove4_Click(sender As Object, e As EventArgs) Handles btnMove4.Click
        Dim tempattack As Double
        Dim tempspecial As Double
        Dim chance As Integer

        Select Case yourpokemon(13)
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
                tempcounter = 1
                chance = 1 + Rnd() * 8
                Select Case chance
                    Case 1, 2, 3
                        TimerBarrage.Enabled = True
                        countBarrage = 2
                    Case 4, 5, 6
                        TimerBarrage.Enabled = True
                        countBarrage = 3
                    Case 7
                        TimerBarrage.Enabled = True
                        countBarrage = 4
                    Case 8
                        TimerBarrage.Enabled = True
                        countBarrage = 5
                End Select
            Case "Barrier"
                yourpokemon(3) += yourpokemonstat(3)
                Label7.Text = "Your defense went up by 2 stages!"
            Case "Bide"

            Case "Bite"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 30 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Then

                    If yourturn = False Then
                        yflinch = True
                        Label7.Text = "Your Pokemon flinched!"
                    ElseIf yourturn = True Then
                        eflinch = True
                        Label7.Text = "The enemy flinched!"
                    End If
                End If
            Case "Blizzard"
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
                enemypokemon(1) -= tempspecial * 65 / enemypokemon(5)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = True Then
                        Label7.Text = "The enemy was frozen!"
                        estatus = 2
                    ElseIf yourturn = False Then
                        Label7.Text = "Your Pokemon was frozen!"
                        ystatus = 2
                    End If
                End If
            Case "Body Slam"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 42.5 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Or 2 Or 3 Then
                    If yourturn = False Then
                        ystatus = 3
                        Label7.Text = "Your Pokemon was paralyzed!"
                    ElseIf yourturn = True Then
                        estatus = 3
                        Label7.Text = "The enemy was paralyzed!"
                    End If
                End If
            Case "Bone Club"
                Select Case DAttackS(9)
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
                enemypokemon(1) -= tempattack * 32.5 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = False Then
                        yflinch = True
                        Label7.Text = "Your Pokemon flinched!"
                    ElseIf yourturn = True Then
                        eflinch = True
                        Label7.Text = "The enemy flinched!"
                    End If
                End If
            Case "Bonemerang"
                TimerBonemerang.Enabled = True
                tempcounter = 1
            Case "Bubble"
                Select Case DAttackS(15)
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
                chance = 1 + Rnd() * 3
                If chance = 1 Then
                    enemypokemon(4) -= enemypokemonstat(4) / 2
                    Label7.Text = "Enemy Speed Was Lowered by 1 Stage!"
                End If
            Case "Clamp"
                Select Case DAttackS(15)
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
                enemypokemon(1) -= tempattack * 17.5 / enemypokemon(3)
                chance = 1 + Rnd() * 8
                If yourturn = True Then
                    Select Case chance
                        Case 1, 2, 3
                            eboundcounter = 2
                        Case 4, 5, 6
                            eboundcounter = 3
                        Case 7
                            eboundcounter = 4
                        Case 8
                            eboundcounter = 5
                    End Select
                ElseIf yourturn = False Then
                    Select Case chance
                        Case 1, 2, 3
                            yboundcounter = 2
                        Case 4, 5, 6
                            yboundcounter = 3
                        Case 7
                            yboundcounter = 4
                        Case 8
                            yboundcounter = 5
                    End Select
                End If
            Case "Confuse Ray"
                If yourturn = True Then
                    Label7.Text = "The enemy was Confused!"
                    estatus = 7
                ElseIf yourturn = False Then
                    Label7.Text = "Your Pokemon was Confused!"
                    ystatus = 7
                End If
            Case "Confusion"
                Select Case DAttackS(13)
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
                enemypokemon(1) -= tempspecial * 25 / enemypokemon(5)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = True Then
                        Label7.Text = "The enemy was Confused!"
                        estatus = 7
                    ElseIf yourturn = False Then
                        Label7.Text = "Your Pokemon was Confused!"
                        ystatus = 7
                    End If
                End If
            Case "Crabhammer"
                Select Case DAttackS(15)
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
                enemypokemon(1) -= tempattack * 50 / enemypokemon(3)
            Case "Cut"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 25 / enemypokemon(3)
            Case "Defense Curl"
                yourpokemon(3) += yourpokemonstat(3) / 2
                Label7.Text = "Your defense went up by 1 stage!"
            Case "Dig"
                If yourturn = True Then
                    yDigcharge = 1
                ElseIf yourturn = False Then
                    eDigcharge = 1
                End If
            Case "Disable"
            Case "Dizzy Punch"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 35 / enemypokemon(3)
            Case "Double Kick"
                TimerDoubleKick.Enabled = True
                tempcounter = 1
            Case "Double Slap"
                tempcounter = 1
                chance = 1 + Rnd() * 8
                Select Case chance
                    Case 1, 2, 3
                        TimerDoubleSlap.Enabled = True
                        countDoubleSlap = 2
                    Case 4, 5, 6
                        TimerDoubleSlap.Enabled = True
                        countDoubleSlap = 3
                    Case 7
                        TimerDoubleSlap.Enabled = True
                        countDoubleSlap = 4
                    Case 8
                        TimerDoubleSlap.Enabled = True
                        countDoubleSlap = 5
                End Select
            Case "Double Team"
                yourpokemon(4) += yourpokemonstat(4) / 2
                Label7.Text = "Your speed went up by 1 stage!"
            Case "Double-Edge"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 60 / enemypokemon(3)
                yourpokemon(1) -= tempattack * 15 / enemypokemon(3)
            Case "Dream Eater"
                If yourturn = True Then
                    If estatus = 6 Then
                        Select Case DAttackS(13)
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
                        enemypokemon(1) -= tempspecial * 50 / enemypokemon(5)
                        yourpokemon(1) = +tempspecial * 50 / enemypokemon(5)
                    ElseIf estatus <> 6 Then
                        Label7.Text = "The attack failed!"
                    End If
                ElseIf yourturn = False Then
                    If ystatus = 6 Then
                        Select Case DAttackS(13)
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
                        enemypokemon(1) -= tempspecial * 50 / enemypokemon(5)
                        yourpokemon(1) = +tempspecial * 50 / enemypokemon(5)
                    ElseIf ystatus <> 6 Then
                        Label7.Text = "The attack failed!"
                    End If
                End If
            Case "Drill Peck"
                Select Case DAttackS(6)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
            Case "Earthquake"
                Select Case DAttackS(9)
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
                enemypokemon(1) -= tempattack * 50 / enemypokemon(3)
            Case "Egg Bomb"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 50 / enemypokemon(3)
            Case "Ember"
                Select Case DAttackS(5)
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
                enemypokemon(1) -= tempspecial * 20 / enemypokemon(5)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = True Then
                        Label7.Text = "The enemy was Burned!"
                        estatus = 1
                    ElseIf yourturn = False Then
                        Label7.Text = "Your Pokemon was Burned!"
                        ystatus = 1
                    End If
                End If
            Case "Explosion"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 170 / enemypokemon(3)
                yourpokemon(1) = 0
            Case "Fire Blast"
                Select Case DAttackS(5)
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
                enemypokemon(1) -= tempspecial * 60 / enemypokemon(5)
                chance = 1 + Rnd() * 3
                If chance = 1 Then
                    If yourturn = True Then
                        Label7.Text = "The enemy was Burned!"
                        estatus = 1
                    ElseIf yourturn = False Then
                        Label7.Text = "Your Pokemon was Burned!"
                        ystatus = 1
                    End If
                End If
            Case "Fire Punch"
                Select Case DAttackS(5)
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
                enemypokemon(1) -= tempattack * 37.5 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = True Then
                        Label7.Text = "The enemy was Burned!"
                        estatus = 1
                    ElseIf yourturn = False Then
                        Label7.Text = "Your Pokemon was Burned!"
                        ystatus = 1
                    End If
                End If
            Case "Fire Spin"
                Select Case DAttackS(5)
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
                enemypokemon(1) -= tempattack * 17.5 / enemypokemon(3)
                chance = 1 + Rnd() * 8
                If yourturn = True Then
                    Select Case chance
                        Case 1, 2, 3
                            eboundcounter = 2
                        Case 4, 5, 6
                            eboundcounter = 3
                        Case 7
                            eboundcounter = 4
                        Case 8
                            eboundcounter = 5
                    End Select
                ElseIf yourturn = False Then
                    Select Case chance
                        Case 1, 2, 3
                            yboundcounter = 2
                        Case 4, 5, 6
                            yboundcounter = 3
                        Case 7
                            yboundcounter = 4
                        Case 8
                            yboundcounter = 5
                    End Select
                End If
            Case "Flamethrower"
                Select Case DAttackS(5)
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
                enemypokemon(1) -= tempspecial * 47.5 / enemypokemon(5)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = True Then
                        Label7.Text = "The enemy was Burned!"
                        estatus = 1
                    ElseIf yourturn = False Then
                        Label7.Text = "Your Pokemon was Burned!"
                        ystatus = 1
                    End If
                End If
            Case "Flash"
                enemypokemon(4) -= enemypokemonstat(4) / 2
                Label7.Text = "The Enemy's speed fell by 1 stage!"
            Case "Fly"
                If yourturn = True Then
                    yFlycharge = 1
                ElseIf yourturn = False Then
                    eFlycharge = 1
                End If
            Case "Focus Energy"
                yourpokemon(4) += yourpokemonstat(4) / 2
                yourpokemon(2) += yourpokemonstat(2) / 2
                yourpokemon(5) += yourpokemonstat(5) / 2
                Label7.Text = "Your pokemon is getting pumped!"
            Case "Fury Attack"
                tempcounter = 1
                chance = 1 + Rnd() * 8
                Select Case chance
                    Case 1, 2, 3
                        TimerFuryAttack.Enabled = True
                        countFuryAttack = 2
                    Case 4, 5, 6
                        TimerFuryAttack.Enabled = True
                        countFuryAttack = 3
                    Case 7
                        TimerFuryAttack.Enabled = True
                        countFuryAttack = 4
                    Case 8
                        TimerFuryAttack.Enabled = True
                        countFuryAttack = 5
                End Select
            Case "Fury Swipes"
                tempcounter = 1
                chance = 1 + Rnd() * 8
                Select Case chance
                    Case 1, 2, 3
                        TimerFurySwipes.Enabled = True
                        countFurySwipes = 2
                    Case 4, 5, 6
                        TimerFurySwipes.Enabled = True
                        countFurySwipes = 3
                    Case 7
                        TimerFurySwipes.Enabled = True
                        countFurySwipes = 4
                    Case 8
                        TimerFurySwipes.Enabled = True
                        countFurySwipes = 5
                End Select
            Case "Glare"
                If yourturn = True Then
                    Label7.Text = "The enemy was Paralyzed!"
                    estatus = 3
                ElseIf yourturn = False Then
                    Label7.Text = "Your Pokemon was Paralyzed!"
                    ystatus = 3
                End If
            Case "Growl"
                enemypokemon(2) -= enemypokemonstat(2) / 2
                Label7.Text = "Enemy Attack Was Lowered by 1 Stage!"
            Case "Growth"
                yourpokemon(5) += yourpokemonstat(5) / 2
                Label7.Text = "Your special went up by 1 stage!"
            Case "Guillotine"
                chance = 1 + Rnd() * 3
                If chance = 1 Then
                    enemypokemon(1) = 0
                End If
            Case "Gust"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 20 / enemypokemon(3)
            Case "Harden"
                yourpokemon(3) += yourpokemonstat(3) / 2
                Label7.Text = "Your Defense went up by 1 stage!"
            Case "Haze"
                enemypokemon(2) = enemypokemonstat(2)
                enemypokemon(3) = enemypokemonstat(3)
                enemypokemon(4) = enemypokemonstat(4)
                enemypokemon(5) = enemypokemonstat(5)

                yourpokemon(2) = yourpokemonstat(2)
                yourpokemon(3) = yourpokemonstat(3)
                yourpokemon(4) = yourpokemonstat(4)
                yourpokemon(5) = yourpokemonstat(5)

                Label7.Text = "Stats have been reset!"

            Case "Headbutt"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 35 / enemypokemon(3)
                chance = 1 + Rnd() * 3
                If chance = 1 Then
                    If yourturn = True Then
                        eflinch = True
                    ElseIf yourturn = False Then
                        yflinch = True
                    End If
                End If
            Case "Horn Attack"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 32.5 / enemypokemon(3)
            Case "Horn Drill"
                chance = 1 + Rnd() * 3
                If chance = 1 Then
                    enemypokemon(1) = 0
                End If
            Case "Hydro Pump"
                Select Case DAttackS(15)
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
                enemypokemon(1) -= tempspecial * 55 / enemypokemon(5)
            Case "Hyper Beam"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempspecial * 75 / enemypokemon(5)
                If yourturn = True Then
                    yHBcharge = True
                ElseIf yourturn = False Then
                    eHBcharge = True
                End If
            Case "Hyper Fang"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Then

                    If yourturn = False Then
                        yflinch = True
                        Label7.Text = "Your Pokemon flinched!"
                    ElseIf yourturn = True Then
                        eflinch = True
                        Label7.Text = "The enemy flinched!"
                    End If
                End If
            Case "Hypnosis"
                chance = 1 + Rnd() * 3
                If chance = 1 Or 2 Then
                    If yourturn = True Then
                        estatus = 6
                    ElseIf yourturn = False Then
                        ystatus = 6
                    End If
                End If
            Case "Ice Beam"
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
                enemypokemon(1) -= tempspecial * 45 / enemypokemon(5)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = True Then
                        Label7.Text = "The enemy was Frozen!"
                        estatus = 2
                    ElseIf yourturn = False Then
                        Label7.Text = "Your Pokemon was Frozen!"
                        ystatus = 2
                    End If
                End If
            Case "Karate Chop"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 25 / enemypokemon(3)
            Case "Leech Life"
                Select Case DAttackS(1)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                yourpokemon(1) += tempattack * 20 / enemypokemon(3)
            Case "Leer"
                enemypokemon(3) -= enemypokemonstat(3) / 2
                Label7.Text = "Enemy Defense went fell by 1 stage!"
            Case "Lick"
                Select Case DAttackS(8)
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
                enemypokemon(1) -= tempattack * 15 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Or 2 Or 3 Then
                    If yourturn = False Then
                        ystatus = 3
                        Label7.Text = "Your Pokemon was paralyzed!"
                    ElseIf yourturn = True Then
                        estatus = 3
                        Label7.Text = "The enemy was paralyzed!"
                    End If
                End If
            Case "Light Screen"
                yourpokemon(5) = yourpokemon(5) * 2
            Case "Low Kick"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 25 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Or 2 Or 3 Then

                    If yourturn = False Then
                        yflinch = True
                        Label7.Text = "Your Pokemon flinched!"
                    ElseIf yourturn = True Then
                        eflinch = True
                        Label7.Text = "The enemy flinched!"
                    End If
                End If
            Case "Mega Drain"
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
                enemypokemon(1) -= tempspecial * 37.5 / enemypokemon(5)
                yourpokemon(1) += tempspecial * 37.5 / enemypokemon(5) / 2
            Case "Mega Kick"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 60 / enemypokemon(3)
            Case "Mega Punch"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
            Case "Metronone"
            Case "Mist"
                enemypokemon(2) = enemypokemonstat(2)
                enemypokemon(3) = enemypokemonstat(3)
                enemypokemon(4) = enemypokemonstat(4)
                enemypokemon(5) = enemypokemonstat(5)

                yourpokemon(2) = yourpokemonstat(2)
                yourpokemon(3) = yourpokemonstat(3)
                yourpokemon(4) = yourpokemonstat(4)
                yourpokemon(5) = yourpokemonstat(5)

                Label7.Text = "Stats have been reset!"
            Case "Night Shade"
                enemypokemon(1) -= 25
            Case "Pay Day"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 10 / enemypokemon(3)
                If yourturn = True Then
                    payday = True
                End If
            Case "Peck"
                Select Case DAttackS(6)
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
                enemypokemon(1) -= tempattack * 17.5 / enemypokemon(3)
            Case "Petal Dance"
            Case "Pin Missile"
                tempcounter = 1
                chance = 1 + Rnd() * 8
                Select Case chance
                    Case 1, 2, 3
                        TimerPinMissile.Enabled = True
                        countPinMissile = 2
                    Case 4, 5, 6
                        TimerPinMissile.Enabled = True
                        countPinMissile = 3
                    Case 7
                        TimerPinMissile.Enabled = True
                        countPinMissile = 4
                    Case 8
                        TimerPinMissile.Enabled = True
                        countPinMissile = 5
                End Select
            Case "Poison Gas"
                chance = 1 + Rnd() * 2
                If chance = 1 Then
                    If yourturn = True Then
                        estatus = 4
                        Label7.Text = "The enemy was Poisoned!"
                    ElseIf yourturn = False Then
                        ystatus = 4
                        Label7.Text = "Your pokemon was Poisoned!"
                    End If
                End If
            Case "Poison Powder"
                If yourturn = True Then
                    estatus = 4
                    Label7.Text = "The enemy was Poisoned!"
                ElseIf yourturn = False Then
                    ystatus = 4
                    Label7.Text = "Your pokemon was Poisoned!"
                End If
            Case "Poison Sting"
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
                enemypokemon(1) -= tempattack * 7.5 / enemypokemon(3)
                chance = 1 + Rnd() * 5
                If chance = 1 Then
                    If yourturn = True Then
                        estatus = 4
                        Label7.Text = "The enemy was Poisoned!"
                    ElseIf yourturn = False Then
                        ystatus = 4
                        Label7.Text = "Your pokemon was Poisoned!"
                    End If
                End If
            Case "Pound"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 20 / enemypokemon(3)
            Case "Psybeam"
                Select Case DAttackS(13)
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
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = True Then
                        estatus = 7
                        Label7.Text = "The enemy was Confused!"
                    ElseIf yourturn = False Then
                        ystatus = 7
                        Label7.Text = "Your pokemon was Confused!"
                    End If
                End If
            Case "Psychic"
                Select Case DAttackS(13)
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
                enemypokemon(1) -= tempspecial * 45 / enemypokemon(5)
                chance = 1 + Rnd() * 3
                If chance = 1 Then
                    enemypokemon(5) -= enemypokemonstat(5) / 2
                    Label7.Text = "The enemy special fell by 1 stage!"
                End If
            Case "Quick Attack"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 20 / enemypokemon(3)
            Case "Razor Leaf"
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
                enemypokemon(1) -= tempspecial * 25.5 / enemypokemon(5)
            Case "Razor Wind"
            Case "Recover"
                yourpokemon(1) += yourpokemonstat(1) / 2
            Case "Reflect"
                yourpokemon(3) = yourpokemon(3) * 2
            Case "Rest"
                yourpokemon(1) = yourpokemonstat(1)
                If yourturn = True Then
                    ystatus = 6
                ElseIf yourturn = False Then
                    estatus = 6
                End If
            Case "Rock Slide"
                Select Case DAttackS(14)
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
                enemypokemon(1) -= tempattack * 37.5 / enemypokemon(3)
            Case "Rock Throw"
                Select Case DAttackS(14)
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
                enemypokemon(1) -= tempattack * 25 / enemypokemon(3)
            Case "Sand Attack"
                enemypokemon(4) -= enemypokemonstat(4) / 2
                Label7.Text = "The enemy's speed fell by 1 stage!"
            Case "Scratch"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 20 / enemypokemon(3)
            Case "Screech"
                enemypokemon(3) -= enemypokemonstat(3)
                Label7.Text = "The Enemy's Defense fell by 2 stages!"
            Case "Seismic Toss"
                enemypokemon(1) -= 50
            Case "Self Destruct"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 130 / enemypokemon(3)
                yourpokemon(1) = 0
            Case "Skull Bash"
            Case "Sky Attack"
            Case "Slam"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
            Case "Slash"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 35 / enemypokemon(3)
            Case "Sleep Powder"
                If yourturn = True Then
                    estatus = 6
                ElseIf yourturn = False Then
                    ystatus = 6
                End If
            Case "Sludge"
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
                enemypokemon(1) -= tempspecial * 32.6 / enemypokemon(5)
                chance = 1 + Rnd() * 5
                If chance = 1 Or 2 Then
                    If yourturn = True Then
                        estatus = 4
                    ElseIf yourturn = False Then
                        ystatus = 4
                    End If
                End If
            Case "Smog"
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
                chance = 1 + Rnd() * 5
                If chance = 1 Or 2 Then
                    If yourturn = True Then
                        estatus = 4
                    ElseIf yourturn = False Then
                        ystatus = 4
                    End If
                End If
            Case "Smokescreen"
                enemypokemon(4) -= enemypokemonstat(4) / 2
                Label7.Text = "The enemy's Speed fell by 1 stage!"
            Case "Solar Beam"
            Case "Sonic Boom"
                enemypokemon(1) -= 10
            Case "Spike Cannon"
                tempcounter = 1
                chance = 1 + Rnd() * 8
                Select Case chance
                    Case 1, 2, 3
                        TimerSpikeCannon.Enabled = True
                        countSpikeCannon = 2
                    Case 4, 5, 6
                        TimerSpikeCannon.Enabled = True
                        countSpikeCannon = 3
                    Case 7
                        TimerSpikeCannon.Enabled = True
                        countSpikeCannon = 4
                    Case 8
                        TimerSpikeCannon.Enabled = True
                        countSpikeCannon = 5
                End Select
            Case "Splash"
                Label7.Text = "But nothing happened!"
            Case "Spore"
                If yourturn = True Then
                    estatus = 6
                ElseIf yourturn = False Then
                    ystatus = 6
                End If
            Case "Stomp"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 32.5 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Or 2 Or 3 Then

                    If yourturn = False Then
                        yflinch = True
                        Label7.Text = "Your Pokemon flinched!"
                    ElseIf yourturn = True Then
                        eflinch = True
                        Label7.Text = "The enemy flinched!"
                    End If
                End If
            Case "Strength"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
            Case "String Shot"
                enemypokemon(4) -= enemypokemonstat(4) / 2
                Label7.Text = "The enemy's Speed fell by 1 stage!"
            Case "Stun Spore"
                If yourturn = True Then
                    estatus = 3
                ElseIf yourturn = False Then
                    ystatus = 3
                End If
            Case "Submission"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                yourpokemon(1) -= tempattack * 10 / enemypokemon(3)
            Case "Supersonic"
                If yourturn = True Then
                    estatus = 7
                ElseIf yourturn = False Then
                    ystatus = 7
                End If
            Case "Super Fang"
                enemypokemon(1) = enemypokemon(1) / 2
            Case "Surf"
                Select Case DAttackS(15)
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
                enemypokemon(1) -= tempspecial * 45 / enemypokemon(5)
            Case "Swift"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempspecial * 30 / enemypokemon(5)
            Case "Swords Dance"
                yourpokemon(2) += yourpokemonstat(2)
                Label7.Text = "Your Attack went up by 2 stages!"
            Case "Tackle"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 20 / enemypokemon(3)
            Case "Tail Whip"
                enemypokemon(3) -= enemypokemonstat(3) / 2
                Label7.Text = "Enemy Defence Was Lowered by 1 Stage!"
            Case "Take Down"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 45 / enemypokemon(3)
                yourpokemon(1) -= tempattack * 22.5 / enemypokemon(3) / 2
            Case "Teleport"
                If frmBattleSelect.trainerbattle = False Then
                    enemypokemon(1) = 0
                End If
            Case "Thunder"
                Select Case DAttackS(10)
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
                enemypokemon(1) -= tempspecial * 55 / enemypokemon(5)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = False Then
                        ystatus = 3
                        Label7.Text = "Your Pokemon was paralyzed!"
                    ElseIf yourturn = True Then
                        estatus = 3
                        Label7.Text = "The enemy was paralyzed!"
                    End If
                End If
            Case "Thunder Punch"
                Select Case DAttackS(10)
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
                enemypokemon(1) -= tempattack * 37.5 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = False Then
                        ystatus = 3
                        Label7.Text = "Your Pokemon was paralyzed!"
                    ElseIf yourturn = True Then
                        estatus = 3
                        Label7.Text = "The enemy was paralyzed!"
                    End If
                End If
            Case "Thunder Shock"
                Select Case DAttackS(10)
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
                enemypokemon(1) -= tempspecial * 20 / enemypokemon(5)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = False Then
                        ystatus = 3
                        Label7.Text = "Your Pokemon was paralyzed!"
                    ElseIf yourturn = True Then
                        estatus = 3
                        Label7.Text = "The enemy was paralyzed!"
                    End If
                End If
            Case "Thunder Wave"
                If yourturn = True Then
                    estatus = 3
                ElseIf yourturn = False Then
                    ystatus = 3
                End If
            Case "Thunderbolt"
                Select Case DAttackS(10)
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
                enemypokemon(1) -= tempspecial * 45 / enemypokemon(5)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = False Then
                        ystatus = 3
                        Label7.Text = "Your Pokemon was paralyzed!"
                    ElseIf yourturn = True Then
                        estatus = 3
                        Label7.Text = "The enemy was paralyzed!"
                    End If
                End If
            Case "Toxic"
                If yourturn = True Then
                    estatus = 5
                ElseIf yourturn = False Then
                    ystatus = 5
                End If
            Case "Tri Attack"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempspecial * 40 / enemypokemon(5)
            Case "Vice Grip"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 27.5 / enemypokemon(3)
            Case "Vine Whip"
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
                enemypokemon(1) -= tempattack * 22.5 / enemypokemon(3)
            Case "Water Gun"
                Select Case DAttackS(15)
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
                enemypokemon(1) -= tempspecial * 20 / enemypokemon(5)
            Case "Whirlwind"
                If frmBattleSelect.trainerbattle = False Then
                    enemypokemon(1) = 0
                End If
            Case "Wing Attack"
                Select Case DAttackS(6)
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
                enemypokemon(1) -= tempattack * 17.5 / enemypokemon(3)
            Case "Withdraw"
                yourpokemon(3) += yourpokemonstat(3) / 2
                Label7.Text = "Your Defense went up by 1 stage!"
            Case "Wrap"
                Select Case DAttackS(11)
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
                enemypokemon(1) -= tempattack * 17.5 / enemypokemon(3)
                chance = 1 + Rnd() * 8
                If yourturn = True Then
                    Select Case chance
                        Case 1, 2, 3
                            eboundcounter = 2
                        Case 4, 5, 6
                            eboundcounter = 3
                        Case 7
                            eboundcounter = 4
                        Case 8
                            eboundcounter = 5
                    End Select
                ElseIf yourturn = False Then
                    Select Case chance
                        Case 1, 2, 3
                            yboundcounter = 2
                        Case 4, 5, 6
                            yboundcounter = 3
                        Case 7
                            yboundcounter = 4
                        Case 8
                            yboundcounter = 5
                    End Select
                End If


            Case "Hadouken"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempspecial * 35.5 / enemypokemon(5)
            Case "Shoryuken"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 55 / enemypokemon(3)
            Case "Collarbone Breaker"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                If chance = 1 Then
                    enemypokemon(3) -= enemypokemonstat(3)
                    Label7.Text = "Enemy Defence Was Lowered by 2 Stages!"
                End If
            Case "Heat Rush"
                Select Case DAttackS(5)
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
                enemypokemon(1) -= tempattack * 35 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = True Then
                        Label7.Text = "The enemy was Burned!"
                        estatus = 1
                    ElseIf yourturn = False Then
                        Label7.Text = "Your Pokemon was Burned!"
                        ystatus = 1
                    End If
                End If
            Case "Guren Enjinkyaku"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 45 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = True Then
                        Label7.Text = "The enemy was Burned!"
                        estatus = 1
                    ElseIf yourturn = False Then
                        Label7.Text = "Your Pokemon was Burned!"
                        ystatus = 1
                    End If
                End If
            Case "Quick Step"
                yourpokemon(4) += yourpokemonstat(4)
                Label7.Text = "Your Speed went up by 2 stages!"
            Case "Lightning Cannonball"
                Select Case DAttackS(10)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                chance = 1 + Rnd() * 10
                If chance = 1 Then
                    If yourturn = False Then
                        ystatus = 3
                        Label7.Text = "Your Pokemon was paralyzed!"
                    ElseIf yourturn = True Then
                        estatus = 3
                        Label7.Text = "The enemy was paralyzed!"
                    End If
                End If
            Case "Shout Of Earth"
                Select Case DAttackS(10)
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
                enemypokemon(1) -= tempspecial * 37.5 / enemypokemon(5)
                chance = 1 + Rnd() * 8
                If chance = 1 Then
                    If yourturn = False Then
                        ystatus = 3
                        Label7.Text = "Your Pokemon was paralyzed!"
                    ElseIf yourturn = True Then
                        estatus = 3
                        Label7.Text = "The enemy was paralyzed!"
                    End If
                End If
            Case "Psycho Crusher"
                Select Case DAttackS(13)
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
                enemypokemon(1) -= tempattack * 65 / enemypokemon(3)
            Case "Super Scissor Kicks"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 55 / enemypokemon(3)
            Case "Devil's Reverse"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
            Case "Raging Demon"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                chance = 1 + Rnd() * 3
                If chance = 1 Then
                    enemypokemon(1) = 0
                End If
            Case "Gou Shoryuken"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 60 / enemypokemon(3)
            Case "Ahura Senku"
                yourpokemon(4) += yourpokemonstat(4)
                Label7.Text = "Your Speed went up by 2 stages!"
            Case "Buffalo Headbutt"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 60 / enemypokemon(3)
                yourpokemon(1) -= tempattack * 45 / enemypokemon(3) / 2
            Case "Super Running Uppercut"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                chance = 1 + Rnd() * 5
                If chance = 1 Then
                    yourpokemon(4) += yourpokemonstat(4) / 2
                    Label7.Text = "Your Speed went up by 1 stage!"
                End If
            Case "Dash Punch"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 40 / enemypokemon(3)
                chance = 1 + Rnd() * 3
                If chance = 1 Then
                    yourpokemon(4) += yourpokemonstat(4) / 2
                    Label7.Text = "Your Speed went up by 1 stage!"
                End If
            Case "Head Bomber"
                Select Case DAttackS(4)
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
                enemypokemon(1) -= tempattack * 60 / enemypokemon(3)
                yourpokemon(1) -= tempattack * 35 / enemypokemon(3)
        End Select
    End Sub

    Private Sub frmInBattle_Load(sender As Object, e As EventArgs) Handles Me.Load

        btnMove1.Enabled = True
            btnMove2.Enabled = True
            btnMove3.Enabled = True
            btnMove3.Enabled = True


            btnMove1.Text = yourpokemon(10)
        btnMove2.Text = yourpokemon(11)
        btnMove3.Text = yourpokemon(12)
        btnMove4.Text = yourpokemon(13)
        lblYName.Text = yourpokemon(0)
		lblYHp.Text = yourpokemon(1) & " / " & yourmaxhp
		lblEName.Text = enemypokemon(0)
		lblEHp.Text = enemypokemon(1) & " / " & enemymaxhp
	End Sub

    Private Sub yturn_Tick(sender As Object, e As EventArgs) Handles yturn.Tick
        counter += 1
        Select Case counter
            Case 1
                If movecat = 1 Then
                    edamage.Enabled = True 'make it flash 3 times
                End If
            Case 2
                yourpokemon(1) = Int(yourpokemon(1))
                enemypokemon(1) = Int(enemypokemon(1))
				lblYHp.Text = yourpokemon(1) & " / " & yourmaxhp
				lblEHp.Text = enemypokemon(1) & " / " & enemymaxhp
		End Select

    End Sub
End Class
