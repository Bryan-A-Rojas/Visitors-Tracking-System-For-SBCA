Module MessageBoxModule
    'Shows the custom messageBox
    Public Sub MsgBoxSetMsg(ByVal msg)
        MessageBoxCustom.lblmsg.Text = msg
        MessageBoxCustom.ShowDialog()
    End Sub

    'Turns on yes or no option
    Public Sub MsgBoxSetYesOrNo()
        MessageBoxCustom.btnYes.Visible = True
        MessageBoxCustom.btnOK.Text = "No"
    End Sub

    'Restores default buttons
    Public Sub MsgBoxSetDefault()
        MessageBoxCustom.btnYes.Visible = False
        MessageBoxCustom.btnOK.Text = "OK"
    End Sub

End Module
