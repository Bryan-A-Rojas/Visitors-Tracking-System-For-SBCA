Imports System.Data.SqlClient
Imports System.IO

Public Class Test

    Dim con As SqlConnection = New SqlConnection("server=DESKTOP-LJA6FPI\SQLEXPRESS;Initial Catalog=test;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader





    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        con.Open()
        cmd = New SqlCommand("SELECT * FROM dbo.testView", con)
        rdr = cmd.ExecuteReader
        ListView1.Items.Clear()
        If rdr.HasRows Then
            Do While rdr.Read()
                Dim arr As String() = New String(6) {}
                Dim itm As ListViewItem
                arr(0) = rdr("VisitorID")
                arr(1) = rdr("FirstName")
                arr(2) = rdr("LastName")
                arr(3) = rdr("VisitID")
                arr(4) = rdr("Details")
                arr(5) = rdr("Date").ToString
                arr(6) = rdr("TimeIn").ToString
                itm = New ListViewItem(arr)
                ListView1.Items.Add(itm)
            Loop
        End If
        con.Close()


        
    End Sub


    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Dim itm As ListViewItem = ListView1.SelectedItems(0)
            Dim idvar As String = itm.SubItems(0).Text

            TextBox1.Text = idvar.ToString

            Label4.Text = itm.SubItems(1).Text
            Label5.Text = itm.SubItems(2).Text

            con.Open()
            cmd = New SqlCommand("SELECT dbo.Visit.Details FROM dbo.Visit WHERE VisitorID= '" & idvar & "'", con)
            rdr = cmd.ExecuteReader
            con.Close()
        End If
    End Sub





    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim objectsarray() As Object = {Me.TextBox2, Me.TextBox1, Me.BirthdatePicker}
        modifyrecord("INSERT INTO Visit([Details],[VisitorID],[Date]) VALUES(@value0,@value1,@value2)", "1 record saved", objectsarray)

    End Sub


    Sub modifyrecord(ByVal sql As String, ByVal msg As String, ByVal ObjectsArray() As Object)
        Dim cmd As SqlCommand = New SqlCommand

        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql

        For ctr = 0 To ObjectsArray.Length - 1
            cmd.Parameters.AddWithValue("@value" + ctr.ToString, ObjectsArray(ctr).Text)
        Next

        cmd.Connection = con
        con.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show(msg)
        con.Close()

        'listahan()
        'erasetext()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        For Each lvi As ListViewItem In ListView1.Items
            If Now >= (Convert.ToDateTime(lvi.SubItems(6).Text).AddHours(1)) Then
                If Not lvi.BackColor.Equals(Color.Red) Then
                    lvi.BackColor = Color.Red
                    lvi.ForeColor = Color.White
                End If
            ElseIf Now >= (Convert.ToDateTime(lvi.SubItems(6).Text).AddMinutes(30)) Then
                If Not lvi.BackColor.Equals(Color.Orange) Then
                    lvi.BackColor = Color.Orange
                    lvi.ForeColor = Color.White
                End If
            ElseIf Now < (Convert.ToDateTime(lvi.SubItems(6).Text).AddMinutes(30)) Then
                If Not lvi.BackColor.Equals(Color.Green) Then
                    lvi.BackColor = Color.Green
                    lvi.ForeColor = Color.White
                End If

            End If
        Next

        'Now > (Convert.ToDateTime(SubItems(6).Text).AddHours(1))

        'MsgBox()
        'MsgBox(Date.Now.TimeOfDay.CompareTo(CType(, TimeSpan)))
    End Sub
End Class