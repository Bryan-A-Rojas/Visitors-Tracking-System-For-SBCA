Imports System.Data.SqlClient
Imports System.IO

Public Class Approve
    'On Load
    Private Sub Approve_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Sets Default Image Icon
        PictureBoxVisitorPic.Image = DefaultImage

        'Set Max length of textboxes
        txtSearch.MaxLength = 99

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
    Sub List(ByVal sql)
        con.Open()
        cmd = New SqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@value0", txtSearch.Text)
        rdr = cmd.ExecuteReader

        ListView1.Items.Clear()
        If rdr.HasRows Then
            Do While rdr.Read()
                Dim arr As String() = New String(4) {}
                Dim itm As ListViewItem
                arr(0) = rdr("VisitorID")
                arr(1) = rdr("FirstName")
                arr(2) = rdr("MiddleName")
                arr(3) = rdr("LastName")
                arr(4) = rdr("Sex")
                itm = New ListViewItem(arr)
                ListView1.Items.Add(itm)
            Loop
            MsgBoxSetMsg(ListView1.Items.Count & " results found")
        Else
            MsgBoxSetMsg("No results found")
        End If
        con.Close()

        EraseText(Me)
        SetDefaultPicture(PictureBoxVisitorPic, DefaultImage)
    End Sub
    'Puts the selected row into textboxes
    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Dim itm As ListViewItem = ListView1.SelectedItems(0)

            txtVisitorID.Text = itm.SubItems(0).Text
            txtName.Text = itm.SubItems(1).Text & " " & itm.SubItems(2).Text & " " & itm.SubItems(3).Text
            txtSex.Text = itm.SubItems(4).Text

            con.Open()
            cmd = New SqlCommand("SELECT Picture FROM Visitor WHERE VisitorID=@value0", con)
            cmd.Parameters.AddWithValue("@value0", txtVisitorID.Text)
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
        End If
    End Sub
    'Open Time in screen
    Private Sub btnViewInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewInfo.Click
        If ListView1.SelectedItems.Count > 0 Then
            ApproveDialog.txtVisitorID.Text = Me.txtVisitorID.Text
            ApproveDialog.ShowDialog()
        Else
            MsgBoxSetMsg("Please select a visitor")
        End If
    End Sub
    'On enter go and search as if search button was clicked
    Private Sub txtSearch_EnterKey(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            StripSpaces(Me)
            Try
                If Not txtSearch.Text = "" Then
                    Dim Query As String = "SELECT [VisitorID],[FirstName],[MiddleName],[LastName],[Sex],[Picture] FROM Visitor"
                    Dim Condition As String = " WHERE FirstName + ' ' + LastName LIKE  '%' + @value0 + '%' AND Status = 'Active'"
                    List(Query & Condition)
                Else
                    MsgBoxSetMsg("Search field is empty")
                End If
            Catch ex As Exception
                MsgBox("Error detected, please contact the administrator")
            End Try
        End If
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

    'Search Button
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            StripSpaces(Me)
            If Not txtSearch.Text = "" Then
                Dim Query As String = "SELECT [VisitorID],[FirstName],[MiddleName],[LastName],[Sex],[Picture] FROM Visitor"
                Dim Condition As String = " WHERE FirstName + ' ' + LastName LIKE  '%' + @value0 + '%' AND Status = 'Active'"
                List(Query & Condition)
            Else
                MsgBoxSetMsg("Search field is empty")
            End If
        Catch ex As Exception
            MsgBox("Error detected, please contact the administrator")
        End Try
    End Sub
End Class
