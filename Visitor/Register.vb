Imports System.Data.SqlClient
Imports System.IO

Public Class Register
    'On Load
    Private Sub Register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Sets the resolution from load
        Touchless.CurrentCamera = Camera1
        Touchless.CurrentCamera.CaptureHeight = 720
        Touchless.CurrentCamera.CaptureWidth = 1366

        'Sets Default Item for Sex Combo Box
        ComboSex.SelectedItem = "Male"

        'Sets Default Image Icon
        PictureBoxVisitorPic.Image = DefaultImage

        'Set Limit of TextBoxes
        txtFirstName.MaxLength = 49
        txtMiddleInitial.MaxLength = 4
        txtLastName.MaxLength = 49

        txtPhoneNum.MaxLength = 24

        'Start Clock
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


    'Validation Section

    'Only Letters
    Private Sub ValidationLetter_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) _
                              Handles txtFirstName.KeyPress, txtMiddleInitial.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
                MsgBoxSetMsg(" Only letters are allowed")
            End If
        End If
    End Sub
    'Only Numbers
    Private Sub ValidationNumber_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) _
                              Handles txtPhoneNum.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MsgBoxSetMsg(" Only numbers are allowed")
            End If
        End If
    End Sub
    'Only Letters and Numbers
    Private Sub ValidationLetterAndNumbers_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) _
                                Handles txtLastName.KeyPress
        If Not (Asc(e.KeyChar) = 8) Or Asc(e.KeyChar) <> 8 Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890 "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
                MsgBoxSetMsg("Only alphanumeric characters!")
            End If
        End If
    End Sub

    'Picture Methods
    Private Sub btnstartpic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstartpic.Click
        'Resumes Timer
        PicTimer.Start()
    End Sub
    Private Sub btncapturepic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncapturepic.Click
        'Stops timer to "capture" image
        PicTimer.Stop()
    End Sub
    Private Sub PicTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicTimer.Tick
        'Starts the timer and takes a picture repeatedly
        PicTimer.Start()
        PictureBoxVisitorPic.Image = Touchless.CurrentCamera.GetCurrentImage

        'Flips the Image
        Try
            PictureBoxVisitorPic.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
        Catch a As NullReferenceException
            MsgBoxSetMsg("Exception caught: " & a.ToString)
        End Try

    End Sub

    'SQL Method
    Sub modifyrecord(ByVal sql As String, ByVal msg As String, ByVal ObjArray() As Object)
        Dim cmd As SqlCommand = New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        cmd.Connection = con
        con.Open()

        'Loops through the array of textboxes and other objects
        For i As Integer = 0 To ObjArray.Count - 1
            'System.Globalization.... turns the first letter of each word as uppercase (useful for names)
            cmd.Parameters.AddWithValue("@value" & i, System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ObjArray(i).Text))
        Next

        'Turns the picture into binary
        Dim ms As MemoryStream = New MemoryStream
        PictureBoxVisitorPic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim PicArray() As Byte = ms.ToArray
        cmd.Parameters.AddWithValue("@Picture", PicArray.ToArray)
        cmd.ExecuteNonQuery()
        con.Close()

        Dim query As SqlCommand = New SqlCommand
        con.Open()

        'Gets ID of last inserted row
        query = New SqlCommand("SELECT IDENT_CURRENT('Visitor')", con)
        ApproveDialog.txtVisitorID.Text = query.ExecuteScalar().ToString()
        con.Close()

        ' "Resets" the screen
        EraseText(Me)
        SetDefaultPicture(PictureBoxVisitorPic, DefaultImage)

        MsgBoxSetMsg(msg)
    End Sub




    'Register Button Design
    Private Sub btnRegister_DesignOnHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.MouseHover
        With btnRegister
            .BackColor = Color.Transparent
            .Image = My.Resources.checkedHighlight
        End With
    End Sub
    Private Sub btnRegister_DesignOnLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.MouseLeave
        With btnRegister
            .BackColor = Color.Transparent
            .Image = My.Resources.checked
        End With
    End Sub
    'Register Button Function
    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        Try
            StripSpaces(Me)
            'Validations
            Dim Exceptions As TextBox() = {txtMiddleInitial, txtPhoneNum}

            Dim Check As Boolean = CheckIfEmpty(Me, Exceptions)
            Dim CheckPic As Boolean = CheckIfDefaultPicture(PictureBoxVisitorPic, DefaultImage)

            If Check = False And CheckPic = False Then
                'Split SQL Query for readability
                Dim query As String = "INSERT INTO Visitor([Picture],[FirstName],[LastName],[MiddleName],[Birthdate],[PhoneNumber],[Sex]) "
                Dim values As String = "VALUES(@Picture,@value0,@value1,@value2,@value3,@value4,@value5);"
                Dim InputArray() As Object = {txtFirstName, txtLastName, txtMiddleInitial, BirthdatePicker, txtPhoneNum, ComboSex}

                modifyrecord(query & values, " Visitor record saved", InputArray)

                MsgBoxSetYesOrNo()
                MsgBoxSetMsg("Would you like to time-in?")
                MsgBoxSetDefault()

                If (MessageBoxCustom.yes = True) Then
                    MessageBoxCustom.yes = False
                    ApproveDialog.ShowDialog()
                    Approve.Close()
                    Me.Show()
                End If
            ElseIf Check = True Then
                MsgBoxSetMsg(" Please fill up all fields")
            ElseIf CheckPic = True Then
                MsgBoxSetMsg(" Please take a picture")
            End If
        Catch
            MsgBox("Error detected, Please call administrator", MsgBoxStyle.Critical)
        End Try
    End Sub

End Class