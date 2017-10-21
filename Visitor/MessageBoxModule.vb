Module MessageBoxModule
    Public Sub MsgBoxSetMsg(ByVal msg)
        MessageBoxCustom.lblmsg.Text = msg
        MessageBoxCustom.ShowDialog()
    End Sub
End Module
