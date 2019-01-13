Public Class frmTrainerBattleEnd

	Private Sub frmTrainerBattleEnd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		If frmBattleSelect.trainer = "Hagith" Then

			picTrainer.Image = My.Resources.hagith
			lblDialogue.Text = "My knees aren't as good as they used to be..."
			lblName.Text = "School Boy Hagith approaches!"
		ElseIf frmBattleSelect.trainer = "Jumong" Then

			picTrainer.Image = My.Resources.jumong
			lblDialogue.Text = "Ah, bollocks!"
			lblName.Text = "Park Ranger Jumong approaches!"
		ElseIf frmBattleSelect.trainer = "Tom" Then

			picTrainer.Image = My.Resources.tom
			lblDialogue.Text = "At least I still have my bike!"
			lblName.Text = "Biker Boy Tom approaches!"
		ElseIf frmBattleSelect.trainer = "Sam" Then

			picTrainer.Image = My.Resources.sam
			lblDialogue.Text = "What a mess."
			lblName.Text = "Sanitation Services Sam approaches!"
		ElseIf frmBattleSelect.trainer = "Ekaterina" Then

			picTrainer.Image = My.Resources.ekaterina
			lblDialogue.Text = "I've been possessed!"
			lblName.Text = "Exorcist Ekaterina approaches!"
		ElseIf frmBattleSelect.trainer = "Manny" Then

			picTrainer.Image = My.Resources.manny
			lblDialogue.Text = "I'm gonna hit the gym after this."
			lblName.Text = "Mountain Climber Manny approaches!"
		ElseIf frmBattleSelect.trainer = "Tammy" Then

			picTrainer.Image = My.Resources.tammy
			lblDialogue.Text = "Guess my vacation here is over..."
			lblName.Text = "Lost Tourist Tammy approaches!"
		ElseIf frmBattleSelect.trainer = "Brenna" Then

			picTrainer.Image = My.Resources.brenna
			lblDialogue.Text = "It's not science time."
			lblName.Text = "Biologist Brenna approaches!"
		ElseIf frmBattleSelect.trainer = "V" Then

			picTrainer.Image = My.Resources.v
			lblDialogue.Text = "Expecting dramatic post-battle dialogue? Think again."
			lblName.Text = "Trainer V approaches!"
		End If
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		frmInBattle.Show()
		Me.Close()
	End Sub
End Class