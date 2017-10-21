Public Class SplashScreen


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Me.Close()
            'Login.Show()
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbSearching.Click
        pbSearching.Visible = False
        pbSearching.Enabled = True
        Me.BringToFront()
        pbSearching.Visible = True
        pbSearching.BringToFront()
    End Sub
End Class