Public Class MainMenu
    'On Load
    Private Sub MainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clock.Start()
    End Sub

    'Clock Timer
    Private Sub Clock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clock.Tick
        txtDate.Text = Date.Now.ToString("dddd, MMMM dd,yyyy") & "  " & Date.Now.ToString("h:mm:ss tt")
    End Sub

    'Mobility Section

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True 'Sets the variable drag to true.
        mousex = Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        'If drag is set to true then move the form accordingly.
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub



    'Registration Button Design
    Private Sub btnRegistration_DesignOnHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.MouseHover
        With btnRegister
            .BackColor = Color.Transparent
            .Image = My.Resources.RegisterHighlight
        End With
    End Sub
    Private Sub btnRegistration_DesignOnLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.MouseLeave
        With btnRegister
            .BackColor = Color.Transparent
            .Image = My.Resources.Register
        End With
    End Sub
    'Registration Button Function
    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        Register.Show()
        Me.Close()
    End Sub


    'Approval Button Design
    Private Sub btnApproval_DesignOnHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApproval.MouseHover
        With btnApproval
            .BackColor = Color.Transparent
            .Image = My.Resources.ApproveHighlight
        End With
    End Sub
    Private Sub btnApproval_DesignOnLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApproval.MouseLeave
        With btnApproval
            .BackColor = Color.Transparent
            .Image = My.Resources.Approval
        End With
    End Sub
    'Approval Button Function
    Private Sub btnApproval_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApproval.Click
        Approve.Show()
        Me.Close()
    End Sub


    'Current Button Design
    Private Sub btnCurrent_DesignOnHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurrent.MouseHover
        With btnCurrent
            .BackColor = Color.Transparent
            .Image = My.Resources.CurrentHighlight
        End With
    End Sub
    Private Sub btnCurrent_DesignOnLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurrent.MouseLeave
        With btnCurrent
            .BackColor = Color.Transparent
            .Image = My.Resources.Current
        End With
    End Sub
    'Current Button Function
    Private Sub btnCurrent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurrent.Click
        SubList.Show()
        Me.Close()
    End Sub


    'Master List Button Design
    Private Sub btnMasterList_DesignOnHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMasterList.MouseHover
        With btnMasterList
            .BackColor = Color.Transparent
            .Image = My.Resources.MasterListHighlight
        End With
    End Sub
    Private Sub btnMasterList_DesignOnLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMasterList.MouseLeave
        With btnMasterList
            .BackColor = Color.Transparent
            .Image = My.Resources.MasterList
        End With
    End Sub
    'Master List Function
    Private Sub btnMasterList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMasterList.Click
        MasterList.Show()
        Me.Close()
    End Sub


    'Reports Button Design
    Private Sub btnReports_DesignOnHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.MouseHover
        With btnReports
            .BackColor = Color.Transparent
            .Image = My.Resources.ReportsHighlight
        End With
    End Sub
    Private Sub btnReports_DesignOnLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.MouseLeave
        With btnReports
            .BackColor = Color.Transparent
            .Image = My.Resources.Reports
        End With
    End Sub
    'Reports Button Function
    Private Sub btnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.Click
        Reports.Show()
        Me.Close()
    End Sub

    'Sign Out Button
    Private Sub btnSignOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignOut.Click
        Login.Show()
        Me.Close()
    End Sub

End Class