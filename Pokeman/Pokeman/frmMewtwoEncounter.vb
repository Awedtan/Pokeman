Public Class frmMewtwoEncounter
    Dim up As Boolean = False
    Dim down As Boolean = False
    Dim leftp As Boolean = False
    Dim rightp As Boolean = False
    Dim loc As Point
    Private Sub frmGym1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.W
                up = True
            Case Keys.A
                leftp = True
            Case Keys.D
                rightp = True
            Case Keys.S
                down = True
        End Select
    End Sub

    Private Sub frmGym1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        Select Case e.KeyCode
            Case Keys.W
                up = False
            Case Keys.A
                leftp = False
            Case Keys.D
                rightp = False
            Case Keys.S
                down = False
        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If up = True Then
            loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 3)
            picPlayer.Location = loc
        End If
        If leftp = True Then
            loc = New Point(picPlayer.Location.X - 3, picPlayer.Location.Y)
            picPlayer.Location = loc
        End If
        If rightp = True Then
            loc = New Point(picPlayer.Location.X + 3, picPlayer.Location.Y)
            picPlayer.Location = loc
        End If
        If down = True Then
            loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 3)
            picPlayer.Location = loc
        End If
    End Sub
End Class