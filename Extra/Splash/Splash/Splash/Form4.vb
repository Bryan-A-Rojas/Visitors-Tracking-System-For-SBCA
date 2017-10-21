Public Class Form4

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Panel2.Top -= 3
        Panel3.Top -= 3
     

        If (Panel2.Top <= 484) Then
            Timer1.Stop()

        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        lblsec.Text = DateTime.Now.ToString("ss")
        lblw.Text = DateTime.Now.ToString("hh:mm tt")
    End Sub
End Class