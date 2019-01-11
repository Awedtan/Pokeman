Public Class frmTrainerBattleStart

	Private Sub frmTrainerBattleStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		If frmBattleSelect.trainer = "Hagith" Then

			picTrainer.Image = My.Resources.hagith
			lblDialogue.Text = "Ohh, my back!"
			lblName.Text = "School Boy Hagith approaches!"
		ElseIf frmBattleSelect.trainer = "Jumong" Then

			picTrainer.Image = My.Resources.jumong
			lblDialogue.Text = "Don't litter!"
			lblName.Text = "Park Ranger Jumong approaches!"
		ElseIf frmBattleSelect.trainer = "Tom" Then

			picTrainer.Image = My.Resources.tom
			lblDialogue.Text = "Isn't my bike the best?"
			lblName.Text = "Biker Boy Tom approaches!"
		ElseIf frmBattleSelect.trainer = "Sam" Then

			picTrainer.Image = My.Resources.sam
			lblDialogue.Text = "I like to mop floors."
			lblName.Text = "Sanitation Services Sam approaches!"
		ElseIf frmBattleSelect.trainer = "Ekaterina" Then

			picTrainer.Image = My.Resources.ekaterina
			lblDialogue.Text = "Begone foul spirits!"
			lblName.Text = "Exorcist Ekaterina approaches!"
		ElseIf frmBattleSelect.trainer = "Manny" Then

			picTrainer.Image = My.Resources.manny
			lblDialogue.Text = "Man I'm really out of shape."
			lblName.Text = "Mountain Climber Manny approaches!"
		ElseIf frmBattleSelect.trainer = "Tammy" Then

			picTrainer.Image = My.Resources.tammy
			lblDialogue.Text = "Is there a hotel anywhere around here?"
			lblName.Text = "Lost Tourist Tammy approaches!"
		ElseIf frmBattleSelect.trainer = "Brenna" Then

			picTrainer.Image = My.Resources.brenna
			lblDialogue.Text = "It's science time."
			lblName.Text = "Biologist Brenna approaches!"
		ElseIf frmBattleSelect.trainer = "V" Then

			picTrainer.Image = My.Resources.v
			lblDialogue.Text = "Expecting dramatic pre-battle dialogue? Think again."
			lblName.Text = "Trainer V approaches!"
		End If
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		frmInBattle.Show()
		Me.Close()
	End Sub
End Class