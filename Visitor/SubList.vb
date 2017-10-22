Imports System.Data.SqlClient
Imports System.IO

Public Class SubList

    'SQL Variables
    Dim con As SqlConnection = New SqlConnection("server=DESKTOP-LJA6FPI\SQLEXPRESS;Initial Catalog=Visitor's Tracking System;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader

    'Container Variable for picture
    Dim DefaultImage As Image = My.Resources.No_Image_Icon

    'On Load
    Private Sub Listfortheday_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Refresh the List View
        List()
        'Sets Default Image Icon
        PictureBoxVisitorPic.Image = DefaultImage
        'Start the higlight timer
        CheckTimer.Start()
        ChangeHighlight()

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


    'SQL Section

    'SQL Method
    Sub modifyrecord(ByVal sql As String, ByVal msg As String)
        Dim cmd As SqlCommand = New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql

        cmd.Connection = con
        con.Open()
        Dim test As String = Format(Now, "HH:mm:ss")
        cmd.Parameters.AddWithValue("@Time", test)
        cmd.Parameters.AddWithValue("@ID", txtVisitID.Text)
        cmd.ExecuteNonQuery()
        MsgBoxSetMsg(msg)
        con.Close()

        '"Refreshes" the screen
        erasetext()
        List()
    End Sub
    'Refreshes the ListView
    Sub List()
        con.Open()
        cmd = New SqlCommand("SELECT * FROM VisitorOfTheDay", con)
        rdr = cmd.ExecuteReader
        ListView1.Items.Clear()
        If rdr.HasRows Then
            Do While rdr.Read()
                Dim arr As String() = New String(9) {}
                Dim itm As ListViewItem
                arr(0) = rdr("VisitorID")
                arr(1) = rdr("FirstName")
                arr(2) = rdr("MiddleName")
                arr(3) = rdr("LastName")
                arr(4) = rdr("Sex")
                arr(5) = rdr("PurposeName")
                arr(6) = rdr("Time-In").ToString
                arr(7) = rdr("DestinationName")
                arr(8) = rdr("Description")
                arr(9) = rdr("VisitID")
                itm = New ListViewItem(arr)
                ListView1.Items.Add(itm)
            Loop
        Else
            MsgBoxSetMsg("No visitors present")
        End If
        con.Close()
        ChangeHighlight()
    End Sub
    'Puts the selected row into textboxes
    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Dim itm As ListViewItem = ListView1.SelectedItems(0)

            txtID.Text = itm.SubItems(0).Text
            txtFirstName.Text = itm.SubItems(1).Text & " " & itm.SubItems(2).Text & " " & itm.SubItems(3).Text
            ComboSex.Text = itm.SubItems(4).Text
            txtPurpose.Text = itm.SubItems(5).Text
            txtTimeIn.Text = itm.SubItems(6).Text
            txtDestination.Text = itm.SubItems(7).Text
            txtDescription.Text = itm.SubItems(8).Text
            txtVisitID.Text = itm.SubItems(9).Text

            con.Open()
            cmd = New SqlCommand("SELECT Picture FROM VisitorOfTheDay WHERE VisitorID=@ID", con)
            cmd.Parameters.AddWithValue("@ID", txtID.Text)
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


            con.Open()

            query = New SqlCommand("SELECT TOP 1 [No. of Visits] FROM VisitorOfTheDay WHERE VisitorID=@ID2", con)
            query.Parameters.AddWithValue("@ID2", txtID.Text)
            txtvisits.Text = query.ExecuteScalar().ToString()
            con.Close()
        End If

    End Sub


    'Utility Section

    'Clears Text
    Sub erasetext()
        Dim Data() As Label = {txtID, txtDate, txtDestination, txtFirstName, txtPurpose, txtTimeIn, txtVisitID, txtVisits, ComboSex}
        For ctr As Integer = 0 To Data.Count - 1
            Data(ctr).Text = Nothing
        Next
        'Sets Default Picture
        PictureBoxVisitorPic.Image = DefaultImage
        txtDescription.Text = Nothing
    End Sub
    'Checks the Color every 2 Seconds
    Private Sub CheckTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckTimer.Tick
        ChangeHighlight()
    End Sub
    'Cycles through the list to change colors
    Private Sub ChangeHighlight()
        For Each lvi As ListViewItem In ListView1.Items
            '1 hour = Red
            If Now >= (Convert.ToDateTime(lvi.SubItems(6).Text).AddHours(1)) Then
                If Not lvi.BackColor.Equals(Color.Red) Then
                    lvi.BackColor = Color.Red
                    lvi.ForeColor = Color.White
                End If
                '30 mins = Orange
            ElseIf Now >= (Convert.ToDateTime(lvi.SubItems(6).Text).AddMinutes(30)) Then
                If Not lvi.BackColor.Equals(Color.Orange) Then
                    lvi.BackColor = Color.Orange
                    lvi.ForeColor = Color.White
                End If
                ' <30mins = Green
            ElseIf Now < (Convert.ToDateTime(lvi.SubItems(6).Text).AddMinutes(30)) Then
                If Not lvi.BackColor.Equals(Color.Green) Then
                    lvi.BackColor = Color.Green
                    lvi.ForeColor = Color.White
                End If
            End If
        Next
    End Sub


    'Button Section

    'Button for Time-Out
    Private Sub btnTimeOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimeOut.Click
        If ListView1.SelectedItems.Count > 0 Then
            Try
                Dim query As String = " UPDATE Details SET [TimeOut]= '" & Format(Now, "HH:mm:ss") & "' WHERE VisitID =@ID"
                modifyrecord(query, " Come Again!")
            Catch
                MsgBox("Error, please contact the administrator")
            End Try
        Else
            MsgBoxSetMsg("Please select a visitor")
        End If
    End Sub

    'Back Button Design
    Private Sub btnBack_DesignOnHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.MouseHover
        With btnBack
            .BackColor = Color.Transparent
            .Image = My.Resources.previousHighlight
        End With
    End Sub
    Private Sub btnBack_DesignOnLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.MouseLeave
        With btnBack
            .BackColor = Color.Transparent
            .Image = My.Resources.previous
        End With
    End Sub
    'Back Button Function
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        MainMenu.Show()
        Me.Close()
    End Sub

End Class