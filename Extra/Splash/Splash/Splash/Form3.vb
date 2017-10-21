Public Class Form3

    Private Sub LoginTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginTimer.Tick
        Panel4.Top -= 70
        If (Panel4.Top <= 116) Then
            LoginTimer.Stop()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()

    End Sub
End Class