Imports System.Data.SqlClient
Imports System.IO

Public Class ApproveDialog

    'SQL Variables
    Dim con As SqlConnection = New SqlConnection("server=DESKTOP-LJA6FPI\SQLEXPRESS;Initial Catalog=Visitor's Tracking System;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader

    'Container Variable for picture
    Dim DefaultImage As Image = My.Resources.No_Image_Icon

    'On Load
    Private Sub ApproveDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Default Values
        txtDestination.Text = "St. Maur"
        txtPurpose.Text = "Escort"

        List("SELECT [FirstName],[MiddleName],[LastName],[Sex],[PhoneNumber],[Address],[Birthdate],[Status] FROM Visitor WHERE [VisitorID] = @value0")
        ChangeStatusColor()
    End Sub


    'SQL Section

    'SQL Query
    Sub modifyrecord(ByVal sql As String, ByVal msg As String)
        Dim cmd As SqlCommand = New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        cmd.Connection = con
        con.Open()

        Dim purpose As Int16 = PurposeID(txtPurpose.Text)
        Dim destination As Int16 = DestinationID(txtDestination.Text)

        cmd.Parameters.AddWithValue("@value0", txtVisitorID.Text)
        cmd.Parameters.AddWithValue("@value1", Format(Now, "HH:mm:ss"))
        cmd.Parameters.AddWithValue("@value2", Format(Now, "d"))
        cmd.Parameters.AddWithValue("@value3", purpose)
        cmd.Parameters.AddWithValue("@value4", destination)
        cmd.Parameters.AddWithValue("@value5", txtDescription.Text)

        cmd.ExecuteNonQuery()
        con.Close()

        MsgBoxSetMsg(msg)
        '"Refreshes" the screen
        erasetext()
    End Sub
    'Refreshes the ListView
    Sub List(ByVal sql)
        con.Open()
        cmd = New SqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@value0", txtVisitorID.Text)

        rdr = cmd.ExecuteReader
        rdr.Read()

        txtName.Text = rdr("FirstName") & " " & rdr("MiddleName") & " " & rdr("LastName")
        txtSex.Text = rdr("Sex")
        txtPhoneNum.Text = rdr("PhoneNumber")
        txtAddress.Text = rdr("Address")
        txtBirthDate.Text = Format(rdr("Birthdate"), "MMMM dd,yyyy")
        txtStatus.Text = rdr("Status")

        Me.PictureBoxVisitorPic.Image = Approve.PictureBoxVisitorPic.Image
        con.Close()
    End Sub
    'Changes the value of Purpose ID
    Function PurposeID(ByVal PurposeName As String) As Int16
        If String.Compare(PurposeName, "Escort") = 0 Then
            PurposeID = 1
        ElseIf String.Compare(PurposeName, "Inquiry") = 0 Then
            PurposeID = 2
        ElseIf String.Compare(PurposeName, "Visit") = 0 Then
            PurposeID = 3
        ElseIf String.Compare(PurposeName, "Delivery/Package") = 0 Then
            PurposeID = 4
        ElseIf String.Compare(PurposeName, "Maintenance/Services") = 0 Then
            PurposeID = 5
        ElseIf String.Compare(PurposeName, "Events") = 0 Then
            PurposeID = 6
        ElseIf String.Compare(PurposeName, "Others") = 0 Then
            PurposeID = 7
        End If
    End Function




    'ADD MORE!!!!!!!!!

    'Changes the value of Description ID
    Function DestinationID(ByVal DestinationName As String) As Int16
        If String.Compare(DestinationName, "St. Maur") = 0 Then
            DestinationID = 1
        ElseIf String.Compare(DestinationName, "St. Benedict Hall") = 0 Then
            DestinationID = 2
        ElseIf String.Compare(DestinationName, "CAS Building") = 0 Then
            DestinationID = 3
        ElseIf String.Compare(DestinationName, "Gym") = 0 Then
            DestinationID = 4
        End If
    End Function


    'Utility Section

    'Change Status Text Box Color Ex: Active = Green
    Sub ChangeStatusColor()
        If String.Compare(txtStatus.Text, "Active") = 0 Then
            txtStatus.BackColor = Color.Green
            txtStatus.ForeColor = Color.White
        Else
            txtStatus.BackColor = Color.Red
            txtStatus.ForeColor = Color.White
        End If
    End Sub
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
        txtDescription.Text = String.Join(" ", txtDescription.Text.Split(New Char() {}, StringSplitOptions.RemoveEmptyEntries))
    End Sub


    'Buttons Section

    'Approve
    Private Sub btnTimeIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimeIn.Click
        StripSpaces()
        If Not txtDescription.Text = "" Then
            Dim query As String = "INSERT INTO Details([VisitorID],[TimeIn],[DateOfVisit],[PurposeID],[DestinationID],[Description]) "
            Dim values As String = "VALUES(@value0,@value1,@value2,@value3,@value4,@value5)"
            modifyrecord(query & values, " Welcome!")
            Approve.Show()
            Me.Close()
        Else
            MsgBoxSetMsg("Please fill up all fields")
        End If
    End Sub
    'Reject
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        erasetext()
        Approve.Show()
        Me.Close()
    End Sub
End Class