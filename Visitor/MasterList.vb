Imports System.Data.SqlClient
Imports System.IO

Public Class MasterList

    'SQL Variables
    Dim con As SqlConnection = New SqlConnection("server=DESKTOP-LJA6FPI\SQLEXPRESS;Initial Catalog=Visitor's Tracking System;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader

    'Container Variable for picture
    Dim DefaultImage As Image = My.Resources.No_Image_Icon

    'Variable for ID
    Public VisitorID As String

    'On Load
    Private Sub MasterList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    'Refreshes the ListView
    Sub List(ByVal sql As String, ByVal showMsg As Boolean)
        con.Open()
        cmd = New SqlCommand(sql, con)

        rdr = cmd.ExecuteReader
        ListView1.Items.Clear()
        If rdr.HasRows Then
            Do While rdr.Read()
                Dim arr As String() = New String(7) {}
                Dim itm As ListViewItem
                arr(0) = rdr("VisitorID")
                arr(1) = rdr("FirstName")
                arr(2) = rdr("MiddleName")
                arr(3) = rdr("LastName")
                arr(4) = rdr("Birthdate")
                arr(5) = rdr("PhoneNumber")
                arr(6) = rdr("Sex")
                arr(7) = rdr("Status")
                itm = New ListViewItem(arr)
                ListView1.Items.Add(itm)
            Loop
            If showMsg = True Then
                MsgBoxSetMsg(ListView1.Items.Count & " results found")
            End If
        Else
            If showMsg = True Then
                MsgBoxSetMsg("No results found")
            End If
        End If
            con.Close()
            ChangeHighlight()
    End Sub

    'Utility Section

    'Cycles through the list to change colors
    Private Sub ChangeHighlight()
        For Each lvi As ListViewItem In ListView1.Items
            '1 hour = Red
            If lvi.SubItems(8).Text = "Active" Then
                If Not lvi.BackColor.Equals(Color.Green) Then
                    lvi.BackColor = Color.Green
                    lvi.ForeColor = Color.White
                End If
            Else
                If Not lvi.BackColor.Equals(Color.Red) Then
                    lvi.BackColor = Color.Red
                    lvi.ForeColor = Color.White
                End If
            End If
        Next
    End Sub


    'Button Section

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


    Private Sub btnShowAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAll.Click
        Try
            List("SELECT * FROM MasterList", True)
        Catch ex As Exception
            MsgBox("Error detected, please contact the administrator")
        End Try
    End Sub

    'Search Button
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        StripSpaces()
        Try
            If Not txtSearch.Text = "" Then
                Dim Query As String = "SELECT * FROM MasterList"
                Dim Condition As String = " WHERE FirstName + ' ' + LastName LIKE  '%' + @value0 + '%' "
                List(Query & Condition, True)
            Else
                MsgBoxSetMsg("Search field is empty")
            End If
        Catch ex As Exception
            MsgBox("Error detected, please contact the administrator")
        End Try
    End Sub

    'On enter go and search as if search button was clicked
    Private Sub txtSearch_EnterKey(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            StripSpaces()
            Try
                If Not txtSearch.Text = "" Then
                    Dim Query As String = "SELECT * FROM MasterList"
                    Dim Condition As String = " WHERE FirstName + ' ' + LastName LIKE  '%' + '" & txtSearch.Text & "' + '%' "
                    List(Query & Condition, True)
                Else
                    MsgBoxSetMsg("Search field is empty")
                End If
            Catch ex As Exception
                MsgBox("Error detected, please contact the administrator")
            End Try
        End If
    End Sub

    'Removes Extra White Spaces
    Private Sub StripSpaces()
        txtSearch.Text = String.Join(" ", txtSearch.Text.Split(New Char() {}, StringSplitOptions.RemoveEmptyEntries))
    End Sub

    'SQL Method
    Sub modifyrecord(ByVal sql As String, ByVal msg As String)
        Dim cmd As SqlCommand = New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql

        cmd.Connection = con
        con.Open()
        cmd.Parameters.AddWithValue("@ID", VisitorID)
        cmd.ExecuteNonQuery()
        MsgBoxSetMsg(msg)
        con.Close()

        '"Refreshes" the screen
        txtSearch.Text = Nothing
        List("SELECT * FROM MasterList", False)
    End Sub

    'Delete Button
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If ListView1.SelectedItems.Count > 0 Then
            Try
                Dim query As String = " UPDATE Visitor SET [Status]='Inactive' WHERE VisitorID =@ID"
                modifyrecord(query, " Visitor deactivated")
            Catch
                MsgBox("Error, please contact the administrator")
            End Try
        Else
            MsgBoxSetMsg("Please select a visitor")
        End If
    End Sub

    'Inserts the ID from ID column in the variable
    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Dim itm As ListViewItem = ListView1.SelectedItems(0)
            VisitorID = itm.SubItems(0).Text
            'Carries the ID into the dialog box
            MasterListDialog.VisitorID = itm.SubItems(0).Text
        End If
    End Sub



    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If ListView1.SelectedItems.Count > 0 Then
            MasterListDialog.ShowDialog()
        Else
            MsgBoxSetMsg("Please select a visitor")
        End If
    End Sub

    Private Sub btnVisitHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllVisitHistory.Click
        VisitHistoryWhole.Show()
    End Sub

    Private Sub btnViewVisitHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewVisitHistory.Click
        If ListView1.SelectedItems.Count > 0 Then
            VisitHistoryDialog.ShowDialog()
        Else
            MsgBoxSetMsg("Please select a visitor")
        End If
    End Sub
End Class