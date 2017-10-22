Imports System.Data.SqlClient
Imports System.IO

Public Class VisitHistoryWhole

    'SQL Variables
    Dim con As SqlConnection = New SqlConnection("server=DESKTOP-LJA6FPI\SQLEXPRESS;Initial Catalog=Visitor's Tracking System;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader

    'On Load
    Private Sub VisitHistoryWhole_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        List()
    End Sub

    'Refreshes the ListView
    Sub List()
        con.Open()
        cmd = New SqlCommand("SELECT * FROM OfAllTime", con)
        rdr = cmd.ExecuteReader
        ListView1.Items.Clear()
        If rdr.HasRows Then
            Do While rdr.Read()
                Dim arr As String() = New String(11) {}
                Dim itm As ListViewItem
                arr(0) = rdr("VisitorID")
                arr(1) = rdr("FirstName")
                arr(2) = rdr("MiddleName")
                arr(3) = rdr("LastName")
                arr(4) = rdr("Sex")
                arr(5) = rdr("VisitID")
                arr(6) = rdr("PurposeName")
                arr(7) = rdr("DestinationName")
                arr(8) = rdr("Description")
                arr(9) = rdr("DateOfVisit")
                arr(10) = rdr("TimeIn").ToString
                arr(11) = rdr("TimeOut").ToString
                itm = New ListViewItem(arr)
                ListView1.Items.Add(itm)
            Loop
        Else
            MsgBoxSetMsg("No visitors present")
        End If
        con.Close()
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
        Me.Close()
    End Sub
End Class