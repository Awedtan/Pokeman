Public Class frmStart
	Private Async Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		lblDialogue.Text = "Hey there"
		Await Task.Delay(5000)
		lblDialogue.Text = "I'm Professor Black Ash"
		Await Task.Delay(5000)
		lblDialogue.Text = "Welcome to the world of Pokeman"
		Await Task.Delay(5000)
		lblDialogue.Text = "Here you will battle other Pokeman and catch them"
		Await Task.Delay(5000)
		lblDialogue.Text = "If you catch enough, you'll be able to take on the gyms"
		Await Task.Delay(5000)
		lblDialogue.Text = "Beating all the gyms will allow you to challenge the Pokeman champion, the best trainer this side of Kanto"
		Await Task.Delay(7000)
		lblDialogue.Text = "You might even encounter some rare legendary pokemon along the way"
		Await Task.Delay(5000)
		lblDialogue.Text = "Here I have 3 Pokeman. You may choose one to start your journey with"

		btnCharmander.Visible = True
		btnSquirtle.Visible = True
		btnBulbasaur.Visible = True
		picBulbasaur.Visible = True
		picCharmander.Visible = True
		picSquirtle.Visible = True

	End Sub

	Private Async Sub btnSquirtle_Click(sender As Object, e As EventArgs) Handles btnSquirtle.Click
		frmMainMenu.Squirtle(6) = 1
		frmMainMenu.yourpokemon1 = frmMainMenu.Squirtle

		lblDialogue.Text = "Great choice!"
		Await Task.Delay(10000)
		lblDialogue.Text = "Well, what are you waiting for? Close this tab already and start your journey!"
	End Sub

	Private Async Sub btnBulbasaur_Click(sender As Object, e As EventArgs) Handles btnBulbasaur.Click
		frmMainMenu.Bulbasaur(6) = 1
		frmMainMenu.yourpokemon1 = frmMainMenu.Bulbasaur

		lblDialogue.Text = "Great choice!"
		Await Task.Delay(10000)
		lblDialogue.Text = "Well, what are you waiting for? Close this tab already and start your journey!"
	End Sub

	Private Async Sub btnCharmander_Click(sender As Object, e As EventArgs) Handles btnCharmander.Click
		frmMainMenu.Charmander(6) = 1
		frmMainMenu.yourpokemon1 = frmMainMenu.Charmander

		lblDialogue.Text = "Great choice!"
		Await Task.Delay(10000)
		lblDialogue.Text = "Well, what are you waiting for? Close this tab already and start your journey!"
	End Sub
End Class