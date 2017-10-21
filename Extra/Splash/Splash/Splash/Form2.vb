Public Class Form2

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p1Timer.Tick
        pbTimer.Stop()

        Panel2.Top -= 3
        Panel3.Top -= 3
        lblsec.Text = DateTime.Now.ToString("ss")
        lblw.Text = DateTime.Now.ToString("hh:mm tt")

        If (Panel2.Top <= 484) Then
            p1Timer.Stop()
            p2Timer.Start()
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p2Timer.Tick
        Panel1.Top -= 3
        If (Panel1.Top <= 390) Then
            p2Timer.Stop()

        End If
    End Sub
    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Time.Tick
        lblsec.Text = DateTime.Now.ToString("ss")
        lblw.Text = DateTime.Now.ToString("hh:mm tt")
    End Sub

    Private Sub pbTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbTimer.Tick
        p1Timer.Start()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Form4.Show()
    End Sub
End Class