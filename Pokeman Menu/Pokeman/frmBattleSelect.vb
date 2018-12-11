Public Class frmBattleSelect
    Dim Gym1 As New frmGym1
    Dim gym2 As New frmGym2
    Dim gym3 As New frmGym3
    Dim gym4 As New frmGym4
    Dim gym5 As New frmGym5
    Dim HauntedHouse As New frmHauntedHouse
    Dim MewtwoEncounter As New frmMewtwoEncounter

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmGym1.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frmGym2.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        frmGym3.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        frmGym4.Show()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        frmGym4.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        frmHauntedHouse.Show()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        frmMewtwoEncounter.Show()
    End Sub
End Class