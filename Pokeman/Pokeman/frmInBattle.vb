Public Class frmInBattle
    Dim yourpokemon() As String

    Dim enemypokemon1() As String
    Dim enemypokmeon2() As String
    Dim enemypokemon3() As String
    Dim enemypokemon4() As String
    Dim enemypokemon5() As String
    Dim enemypokemon6() As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMove1.Click
        Select Case yourpokemon(1)
            Case 45
                Label1.Text = "1"
            Case 49
                Label1.Text = "0"

        End Select
    End Sub
End Class