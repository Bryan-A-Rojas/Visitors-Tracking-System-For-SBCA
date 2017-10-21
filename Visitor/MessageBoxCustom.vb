Public Class MessageBoxCustom
    Private Sub MessageBoxCustom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Set this form to be top at all times
        Me.TopMost = True
        btnOK.Focus()
    End Sub

    Private Sub MessageBoxCustom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then Me.Close()
    End Sub

    Private Sub btnOK_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub
End Class