Public Class frmTrainerBattleStart

	Dim InBattle As New frmInBattle

	Private Sub frmTrainerBattleStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		If frmBattleSelect.trainer = "Hagith" Then

			picTrainer.Image = My.Resources.hagith
			lblDialogue.Text = "Ohh, my back!"
			lblName.Text = "School Boy Hagith approaches!"
			picTrainer.Size = New Size(190, 190)

		ElseIf frmBattleSelect.trainer = "Jumong" Then

			picTrainer.Image = My.Resources.jumong
			lblDialogue.Text = "Don't litter!"
			lblName.Text = "Park Ranger Jumong approaches!"
			picTrainer.Size = New Size(190, 190)

		ElseIf frmBattleSelect.trainer = "Tom" Then

			picTrainer.Image = My.Resources.tom
			lblDialogue.Text = "Isn't my bike the best?"
			lblName.Text = "Biker Boy Tom approaches!"
			picTrainer.Size = New Size(190, 190)

		ElseIf frmBattleSelect.trainer = "Sam" Then

			picTrainer.Image = My.Resources.sam
			lblDialogue.Text = "I like to mop floors."
			lblName.Text = "Sanitation Services Sam approaches!"
			picTrainer.Size = New Size(190, 190)

		ElseIf frmBattleSelect.trainer = "Ekaterina" Then

			picTrainer.Image = My.Resources.ekaterina
			lblDialogue.Text = "Begone foul spirits!"
			lblName.Text = "Exorcist Ekaterina approaches!"
			picTrainer.Size = New Size(190, 190)

		ElseIf frmBattleSelect.trainer = "Manny" Then

			picTrainer.Image = My.Resources.manny
			lblDialogue.Text = "Man I'm really out of shape."
			lblName.Text = "Mountain Climber Manny approaches!"
			picTrainer.Size = New Size(190, 190)

		ElseIf frmBattleSelect.trainer = "Tammy" Then

			picTrainer.Image = My.Resources.tammy
			lblDialogue.Text = "Is there a hotel anywhere around here?"
			lblName.Text = "Lost Tourist Tammy approaches!"
			picTrainer.Size = New Size(190, 190)

		ElseIf frmBattleSelect.trainer = "Brenna" Then

			picTrainer.Image = My.Resources.brenna
			lblDialogue.Text = "It's science time."
			lblName.Text = "Biologist Brenna approaches!"
			picTrainer.Size = New Size(190, 190)

		ElseIf frmBattleSelect.trainer = "V" Then

			picTrainer.Image = My.Resources.v
			lblDialogue.Text = "Expecting dramatic pre-battle dialogue? Think again."
			lblName.Text = "Trainer V approaches!"
			picTrainer.Size = New Size(190, 190)

			'Gym trainers

		ElseIf frmBattleSelect.trainer = "Gym 1.1" Then

			picTrainer.Image = My.Resources.gym11
			lblDialogue.Text = "Get ready for a tough battle!"
			lblName.Text = "Grass-type trainer Jaden approaches!"
			picTrainer.Size = New Size(190, 190)

		ElseIf frmBattleSelect.trainer = "Gym 1.2" Then

			picTrainer.Image = My.Resources.gym12
			lblDialogue.Text = "You won't get past me!"
			lblName.Text = "Grass-type trainer Jemma approaches!"
			picTrainer.Size = New Size(190, 190)

		ElseIf frmBattleSelect.trainer = "Gym 1.0" Then

			picTrainer.Image = My.Resources.gym10
			lblDialogue.Text = "Welcome to the big leagues, kiddo."
			lblName.Text = "Gym leader/herb dealer/broccoli vendor Murphy approaches!"
			picTrainer.Size = New Size(280, 190)

		ElseIf frmBattleSelect.trainer = "Gym 2.1" Then

			picTrainer.Image = My.Resources.gym21
			lblDialogue.Text = "You'll find my pokeman to be quite shocking!"
			lblName.Text = "Electric-type trainer Tyrone approaches!"
			picTrainer.Size = New Size(190, 190)

		ElseIf frmBattleSelect.trainer = "Gym 2.2" Then

			picTrainer.Image = My.Resources.gym21
			lblDialogue.Text = "Even if you got this far, you won't go any farther!"
			lblName.Text = "Electric-type trainer Paul approaches!"
			picTrainer.Size = New Size(190, 190)

		ElseIf frmBattleSelect.trainer = "Gym 2.3" Then

			picTrainer.Image = My.Resources.gym22
			lblDialogue.Text = "YES FELLOW HUMAN I WOULD LIKE TO DO THE BATTLE WITH YOU."
			lblName.Text = "Electric-type trainer Emma approaches!"
			picTrainer.Size = New Size(190, 190)

		ElseIf frmBattleSelect.trainer = "Gym 2.0" Then

			picTrainer.Image = My.Resources.gym20
			lblDialogue.Text = "Quite impressive, I'll have to test your skills myself."
			lblName.Text = "Gym leader Taserface approaches!"
			picTrainer.Size = New Size(280, 190)

		ElseIf frmBattleSelect.trainer = "Gym 3.1" Then

			picTrainer.Image = My.Resources.gym31
			lblDialogue.Text = "Anyone up for a barbeque?"
			lblName.Text = "Fire-type trainer Fennel approaches!"
			picTrainer.Size = New Size(190, 190)

		ElseIf frmBattleSelect.trainer = "Gym 3.2" Then

			picTrainer.Image = My.Resources.gym32
			lblDialogue.Text = "You'll find my fighting style is as firey as my hair."
			lblName.Text = "Fire-type trainer Flambe approaches!"
			picTrainer.Size = New Size(190, 190)

		ElseIf frmBattleSelect.trainer = "Gym 3.3" Then

			picTrainer.Image = My.Resources.gym31
			lblDialogue.Text = "Yea, it's me again."
			lblName.Text = "Fire-type trainer Fennel approaches!"
			picTrainer.Size = New Size(190, 190)

		ElseIf frmBattleSelect.trainer = "Gym 3.0" Then

			picTrainer.Image = My.Resources.gym30
			lblDialogue.Text = "I like to light things up with my fire-type Pokémon!"
			lblName.Text = "Gym leader Hot Man Zuko approaches!"
			picTrainer.Size = New Size(280, 190)

		ElseIf frmBattleSelect.trainer = "Gym 4.1" Then

			picTrainer.Image = My.Resources.gym41
			lblDialogue.Text = "No running near the pool!"
			lblName.Text = "Water-type trainer Lyfgward approaches!"
			picTrainer.Size = New Size(190, 190)

		ElseIf frmBattleSelect.trainer = "Gym 4.2" Then

			picTrainer.Image = My.Resources.gym42
			lblDialogue.Text = "I'm about to dive right into this battle!"
			lblName.Text = "Water-type trainer Fhelps approaches!"
			picTrainer.Size = New Size(190, 190)

		ElseIf frmBattleSelect.trainer = "Gym 4.0" Then

			picTrainer.Image = My.Resources.gym40
			lblDialogue.Text = "My water pokeman will wash away yours!"
			lblName.Text = "Gym leader Super Soaker Simon approaches!"
			picTrainer.Size = New Size(280, 190)

		ElseIf frmBattleSelect.trainer = "Gym 5.0" Then

			picTrainer.Image = My.Resources.gym50
			lblDialogue.Text = "Mwahaha! Good luck beating my unbeatable dragon pokeman!"
			lblName.Text = "Gym Leader Doug approaches!"
			picTrainer.Size = New Size(280, 190)

		ElseIf frmBattleSelect.trainer = "Gym 6.1" Then

			picTrainer.Image = My.Resources.gym61
			lblDialogue.Text = "Get ready for battle!"
			lblName.Text = "Elite Four Spooky Simone approaches!"
			picTrainer.Size = New Size(190, 190)

		ElseIf frmBattleSelect.trainer = "Gym 6.2" Then

			picTrainer.Image = My.Resources.gym62
			lblDialogue.Text = "Get ready for battle!"
			lblName.Text = "Elite Four Stone-Faced Rocky approaches!"
			picTrainer.Size = New Size(190, 190)

		ElseIf frmBattleSelect.trainer = "Gym 6.3" Then

			picTrainer.Image = My.Resources.gym63
			lblDialogue.Text = "Get ready for battle!"
			lblName.Text = "Elite Four Soarin' Steve approaches!"
			picTrainer.Size = New Size(280, 190)

		ElseIf frmBattleSelect.trainer = "Gym 6.4" Then

			picTrainer.Image = My.Resources.gym64
			lblDialogue.Text = "Hey."
			lblName.Text = "Bob approaches."
			picTrainer.Size = New Size(280, 190)

		ElseIf frmBattleSelect.trainer = "Gym 6.0" Then

			picTrainer.Image = My.Resources.gym40
			lblDialogue.Text = "This is Street Fighter right?"
			lblName.Text = "Pokeman Champion Mr. Chu approaches!"
			picTrainer.Size = New Size(280, 190)
		End If
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		frmInBattle.Show()
		Me.Close()
	End Sub
End Class