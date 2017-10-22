Imports System.Data.SqlClient
Imports System.IO

Public Class VisitHistoryDialog
    'SQL Variables
    Dim con As SqlConnection = New SqlConnection("server=DESKTOP-LJA6FPI\SQLEXPRESS;Initial Catalog=Visitor's Tracking System;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader

    Dim VisitorID As String

    'On Load
    Private Sub VisitHistoryDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        VisitorID = MasterList.VisitorID
        txtVisitorID.Text = VisitorID
        Open("SELECT [FirstName],[MiddleName],[LastName],[Sex],[PhoneNumber],[Address],[Birthdate],[Status] FROM Visitor WHERE [VisitorID] = @value0")
        List("SELECT [VisitID],[PurposeName],[DestinationName],[Description],[TimeIn],[TimeOut] FROM Details INNER JOIN Purpose ON dbo.Details.PurposeID = dbo.Purpose.PurposeID INNER JOIN dbo.Destination ON dbo.Details.DestinationID = dbo.Destination.DestinationID WHERE [VisitorID] = @value0")
        ChangeHighlight()
    End Sub

    'Inserts the data of selected visitor
    Sub Open(ByVal sql)
        con.Open()
        cmd = New SqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@value0", VisitorID)

        rdr = cmd.ExecuteReader
        rdr.Read()

        txtName.Text = rdr("FirstName") & " " & rdr("MiddleName") & " " & rdr("LastName")
        txtSex.Text = rdr("Sex")
        txtPhoneNum.Text = rdr("PhoneNumber")
        txtAddress.Text = rdr("Address")
        txtBirthDate.Text = Format(rdr("Birthdate"), "MMMM dd,yyyy")
        txtStatus.Text = rdr("Status")

        con.Close()

        con.Open()
        cmd = New SqlCommand("SELECT Picture FROM Visitor WHERE VisitorID=@value0", con)
        cmd.Parameters.AddWithValue("@value0", VisitorID)
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

    'Cycles through the list to change colors
    Private Sub ChangeHighlight()
        If txtStatus.Text = "Active" Then
            txtStatus.BackColor = Color.Green
            txtStatus.ForeColor = Color.White
        Else
            txtStatus.BackColor = Color.Red
            txtStatus.ForeColor = Color.White
        End If
    End Sub

    'Refreshes the ListView
    Sub List(ByVal sql As String)
        con.Open()
        cmd = New SqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@value0", VisitorID)

        rdr = cmd.ExecuteReader
        ListView1.Items.Clear()
        If rdr.HasRows Then
            Do While rdr.Read()
                Dim arr As String() = New String(5) {}
                Dim itm As ListViewItem
                arr(0) = rdr("VisitID")
                arr(1) = rdr("PurposeName")
                arr(2) = rdr("DestinationName")
                arr(3) = rdr("Description")
                arr(4) = rdr("TimeIn").ToString
                arr(5) = rdr("TimeOut").ToString
                itm = New ListViewItem(arr)
                ListView1.Items.Add(itm)
            Loop
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
        MainMenu.Show()
        Me.Close()
    End Sub
End Class