Public Class frmTrainerBattleEnd

	Private Sub frmTrainerBattleEnd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		If frmBattleSelect.trainer = "Hagith" Then

			picTrainer.Image = My.Resources.hagith
			lblDialogue.Text = "My knees aren't as good as they used to be..."
			picTrainer.Size = New Size(190, 190)

			frmBattleSelect.btnRoute2.Enabled = True
			frmBattleSelect.btnTrainer2.Enabled = True

		ElseIf frmBattleSelect.trainer = "Jumong" Then

			picTrainer.Image = My.Resources.jumong
			lblDialogue.Text = "Ah, bollocks!"
			picTrainer.Size = New Size(190, 190)

			frmBattleSelect.btnGym1.Enabled = True

		ElseIf frmBattleSelect.trainer = "Tom" Then

			picTrainer.Image = My.Resources.tom
			lblDialogue.Text = "At least I still have my bike!"
			picTrainer.Size = New Size(190, 190)

			frmBattleSelect.btnRoute4.Enabled = True
			frmBattleSelect.btnTrainer4.Enabled = True

		ElseIf frmBattleSelect.trainer = "Sam" Then

			picTrainer.Image = My.Resources.sam
			lblDialogue.Text = "What a mess."
			picTrainer.Size = New Size(190, 190)

			frmBattleSelect.btnGym2.Enabled = True

		ElseIf frmBattleSelect.trainer = "Ekaterina" Then

			picTrainer.Image = My.Resources.ekaterina
			lblDialogue.Text = "I've been possessed!"
			picTrainer.Size = New Size(190, 190)

			frmBattleSelect.btnRoute6.Enabled = True
			frmBattleSelect.btnTrainer6.Enabled = True
			frmBattleSelect.btnHauntedHouse.Enabled = True

		ElseIf frmBattleSelect.trainer = "Manny" Then

			picTrainer.Image = My.Resources.manny
			lblDialogue.Text = "I'm gonna hit the gym after this."
			picTrainer.Size = New Size(190, 190)

			frmBattleSelect.btnGym3.Enabled = True

		ElseIf frmBattleSelect.trainer = "Tammy" Then

			picTrainer.Image = My.Resources.tammy
			lblDialogue.Text = "Guess my vacation here is over..."
			picTrainer.Size = New Size(190, 190)

			frmBattleSelect.btnGym4.Enabled = True

		ElseIf frmBattleSelect.trainer = "Brenna" Then

			picTrainer.Image = My.Resources.brenna
			lblDialogue.Text = "It's not science time."
			picTrainer.Size = New Size(190, 190)

			frmBattleSelect.btnRoute9.Enabled = True
			frmBattleSelect.btnBirdNest.Enabled = True
			frmBattleSelect.btnGym5.Enabled = True

		ElseIf frmBattleSelect.trainer = "V" Then

			picTrainer.Image = My.Resources.v
			lblDialogue.Text = "Expecting dramatic post-battle dialogue? Think again."
			picTrainer.Size = New Size(190, 190)

			frmBattleSelect.btnLeague.Enabled = True

			'Gym trainers

		ElseIf frmBattleSelect.trainer = "Gym 1.1" Then

			picTrainer.Image = My.Resources.gym11
			lblDialogue.Text = "Damn, I lost!"
			picTrainer.Size = New Size(190, 190)

			frmBattleSelect.gym1c += 1

		ElseIf frmBattleSelect.trainer = "Gym 1.2" Then

			picTrainer.Image = My.Resources.gym12
			lblDialogue.Text = "Gosh, I was defeated!"
			picTrainer.Size = New Size(190, 190)
			frmBattleSelect.gym1c += 1

		ElseIf frmBattleSelect.trainer = "Gym 1.0" Then

			picTrainer.Image = My.Resources.gym10
			lblDialogue.Text = "Nice job, kiddo."
			picTrainer.Size = New Size(280, 190)

			frmBattleSelect.btnRoute3.Enabled = True
			frmBattleSelect.btnTrainer3.Enabled = True

		ElseIf frmBattleSelect.trainer = "Gym 2.1" Then

			picTrainer.Image = My.Resources.gym21
			lblDialogue.Text = "Geez, I was overcome!"
			picTrainer.Size = New Size(190, 190)
			frmBattleSelect.gym2c += 1

		ElseIf frmBattleSelect.trainer = "Gym 2.2" Then

			picTrainer.Image = My.Resources.gym21
			lblDialogue.Text = "Dang, you beat me!"
			picTrainer.Size = New Size(190, 190)
			frmBattleSelect.gym2c += 1

		ElseIf frmBattleSelect.trainer = "Gym 2.3" Then

			picTrainer.Image = My.Resources.gym22
			lblDialogue.Text = "OH NO, MY SKILLS WERE NOT SUFFICIENT."
			picTrainer.Size = New Size(190, 190)
			frmBattleSelect.gym2c += 1

		ElseIf frmBattleSelect.trainer = "Gym 2.0" Then

			picTrainer.Image = My.Resources.gym20
			lblDialogue.Text = "You're not bad, I have to give it to you."
			picTrainer.Size = New Size(280, 190)

			frmBattleSelect.btnRoute5.Enabled = True
			frmBattleSelect.btnTrainer5.Enabled = True

		ElseIf frmBattleSelect.trainer = "Gym 3.1" Then

			picTrainer.Image = My.Resources.gym31
			lblDialogue.Text = "Darn, you won!"
			picTrainer.Size = New Size(190, 190)
			frmBattleSelect.gym3c += 1

		ElseIf frmBattleSelect.trainer = "Gym 3.2" Then

			picTrainer.Image = My.Resources.gym32
			lblDialogue.Text = "Bollocks, I was usurped!"
			picTrainer.Size = New Size(190, 190)
			frmBattleSelect.gym3c += 1

		ElseIf frmBattleSelect.trainer = "Gym 3.3" Then

			picTrainer.Image = My.Resources.gym31
			lblDialogue.Text = "Heck, my pokemon fainted!"
			picTrainer.Size = New Size(190, 190)
			frmBattleSelect.gym3c += 1

		ElseIf frmBattleSelect.trainer = "Gym 3.0" Then

			picTrainer.Image = My.Resources.gym30
			lblDialogue.Text = "Aww, my pokemon burnt out."
			picTrainer.Size = New Size(280, 190)

			frmBattleSelect.btnRoute7.Enabled = True
			frmBattleSelect.btnTrainer7.Enabled = True

		ElseIf frmBattleSelect.trainer = "Gym 4.1" Then

			picTrainer.Image = My.Resources.gym41
			lblDialogue.Text = "Aahh, I was defeated!"
			picTrainer.Size = New Size(190, 190)
			frmBattleSelect.gym4c += 1

		ElseIf frmBattleSelect.trainer = "Gym 4.2" Then

			picTrainer.Image = My.Resources.gym42
			lblDialogue.Text = "Gahh, I yield to you!"
			picTrainer.Size = New Size(190, 190)
			frmBattleSelect.gym4c += 1

		ElseIf frmBattleSelect.trainer = "Gym 4.0" Then

			picTrainer.Image = My.Resources.gym40
			lblDialogue.Text = "Looks like my pokemon weren't strong enough."
			picTrainer.Size = New Size(280, 190)

			frmBattleSelect.btnRoute8.Enabled = True
			frmBattleSelect.btnTrainer8.Enabled = True

		ElseIf frmBattleSelect.trainer = "Gym 5.0" Then

			picTrainer.Image = My.Resources.gym50
			lblDialogue.Text = "Noooo! My unbeatable dragon pokeman!"
			picTrainer.Size = New Size(280, 190)

			frmBattleSelect.btnVictoryRoad.Enabled = True
			frmBattleSelect.btnTrainerV.Enabled = True

		End If
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		Me.Close()
	End Sub
End Class