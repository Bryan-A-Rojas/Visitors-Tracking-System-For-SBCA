Imports System.Data.SqlClient
Imports System.IO

Public Class MasterListDialog

    'SQL Variables
    Dim con As SqlConnection = New SqlConnection("server=DESKTOP-LJA6FPI\SQLEXPRESS;Initial Catalog=Visitor's Tracking System;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader

    'Camera Variables
    Public Touchless As New TouchlessLib.TouchlessMgr
    Public Camera1 As TouchlessLib.Camera = Touchless.Cameras.Item(0)

    'Container Variable for picture
    Dim DefaultImage As Image = My.Resources.No_Image_Icon

    'Variable for ID
    Public VisitorID As String

    'On Load
    Private Sub MasterListDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Sets the resolution from load
        Touchless.CurrentCamera = Camera1
        Touchless.CurrentCamera.CaptureHeight = 720
        Touchless.CurrentCamera.CaptureWidth = 1366

        'Sets Default Image Icon
        PictureBoxVisitorPic.Image = DefaultImage

        'Set Limit of TextBoxes
        txtFirstName.MaxLength = 49
        txtMiddleInitial.MaxLength = 4
        txtLastName.MaxLength = 49

        txtPhoneNum.MaxLength = 24

        List("SELECT [FirstName],[MiddleName],[LastName],[Sex],[PhoneNumber],[Birthdate],[Picture] FROM Visitor WHERE [VisitorID] = " & VisitorID & "")

    End Sub


    'Validation Section

    'Only Letters
    Private Sub ValidationLetter_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) _
                              Handles txtFirstName.KeyPress, txtMiddleInitial.KeyPress, txtLastName.KeyPress
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
    Private Sub ValidationLetterAndNumbers_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)

        If Not (Asc(e.KeyChar) = 8) Or Asc(e.KeyChar) <> 8 Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890 "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
                MsgBoxSetMsg("Only alphanumeric characters!")
            End If
        End If
    End Sub
    'Prevents Empty Fields
    Private Function CheckIfEmpty() As Boolean
        'Checks if All textboxes are empty
        Dim empty = Me.Controls.OfType(Of TextBox)().Where(Function(txt) txt.Text.Trim.Length = 0)
        If empty.Any Then
            MsgBoxSetMsg(" Please fill up all fields")
            CheckIfEmpty = True

            'Checks if PictureBox is Empty or Default
        ElseIf PictureBoxVisitorPic.Image Is DefaultImage Then
            MsgBoxSetMsg(" Please take a picture")
            CheckIfEmpty = True
        Else
            CheckIfEmpty = False
        End If
    End Function


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


    'SQL Section

    'SQL Method
    Sub modifyrecord(ByVal sql As String, ByVal msg As String, ByVal ObjArray() As Object)
        Dim cmd As SqlCommand = New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        cmd.Connection = con
        con.Open()

        For i As Integer = 0 To ObjArray.Count - 1
            cmd.Parameters.AddWithValue("@value" & i, ObjArray(i).Text)
        Next

        Dim ms As MemoryStream = New MemoryStream
        PictureBoxVisitorPic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim PicArray() As Byte = ms.ToArray
        cmd.Parameters.AddWithValue("@Picture", PicArray.ToArray)

        cmd.ExecuteNonQuery()
        MsgBoxSetMsg(msg)
        con.Close()
        cmd.Parameters.Clear()

        ' "Refreshes" the screen
        erasetext()
        VisitorID = Nothing
    End Sub
    'Refreshes the ListView
    Sub List(ByVal sql)
        con.Open()
        cmd = New SqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@value0", VisitorID)

        rdr = cmd.ExecuteReader
        rdr.Read()

        txtFirstName.Text = rdr("FirstName")
        txtMiddleInitial.Text = rdr("MiddleName")
        txtLastName.Text = rdr("LastName")
        ComboSex.Text = rdr("Sex")
        txtPhoneNum.Text = rdr("PhoneNumber")
        BirthdatePicker.Text = rdr("Birthdate")

        con.Close()

        con.Open()
        cmd = New SqlCommand("SELECT Picture FROM Visitor  WHERE VisitorID=@ID", con)
        cmd.Parameters.AddWithValue("@ID", VisitorID)
        rdr = cmd.ExecuteReader

        If rdr.HasRows Then
            Do While rdr.Read()
                Dim PicArray() As Byte = CType(rdr("Picture"), Byte())
                Dim ms As MemoryStream = New MemoryStream(PicArray)
                ms.Seek(0, SeekOrigin.Begin)
                PictureBoxVisitorPic.Image = Image.FromStream(ms)
            Loop
        End If
        con.Close()

    End Sub
  

    'Utility Section

    'Clears Text
    Sub erasetext()
        Dim a As Control
        For Each a In Me.Controls
            If TypeOf a Is TextBox Then
                a.Text = Nothing
            End If
        Next
        'Sets Default Picture
        PictureBoxVisitorPic.Image = DefaultImage
    End Sub
    'Removes Extra White Spaces
    Private Sub StripSpaces()
        Dim a As Control
        For Each a In Me.Controls
            If TypeOf a Is TextBox Then
                a.Text = String.Join(" ", a.Text.Split(New Char() {}, StringSplitOptions.RemoveEmptyEntries))
            End If
        Next
    End Sub

    'Buttons Section

    'Update
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            StripSpaces()
            Dim Check As Boolean = CheckIfEmpty()

            Dim InputArray() As Object = {txtFirstName, txtLastName, txtMiddleInitial, BirthdatePicker, txtPhoneNum, ComboSex}

            If Check = False Then
                'Split SQL Query for readability
                Dim query As String = "UPDATE Visitor SET [Picture] = @Picture, [FirstName]= @value0,[LastName] = @value1,[MiddleName] = @value2,[Birthdate] = @value3,[PhoneNumber] = @value4,[Sex] = @value5, [Status] = 'Active' "
                Dim values As String = "WHERE [VisitorID] = " & VisitorID & ";"
                modifyrecord(query & values, " Visitor Updated", InputArray)
                MasterList.List("SELECT * FROM MasterList", False)
                Me.Close()
            End If
        Catch
            MsgBox("Error detected, Please call administrator", MsgBoxStyle.Critical)
        End Try
    End Sub
    'Reject
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        erasetext()
        Me.Close()
    End Sub
End Class