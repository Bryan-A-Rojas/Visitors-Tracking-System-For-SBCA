Imports System.Data.SqlClient
Imports Microsoft.Office.Core
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Reports

    'SQL Variables
    Dim con As SqlConnection = New SqlConnection("server=DESKTOP-LJA6FPI\SQLEXPRESS;Initial Catalog=Visitor's Tracking System;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader

    'Excel Variables
    Dim myExcelApp As Excel.Application
    Dim myExcelWorkbooks As Excel.Workbooks
    Dim myExcelWorkbook As Excel.Workbook
    Dim misValue As Object = System.Reflection.Missing.Value
    Dim fileName As [String] = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\Report.xls"


    'On Load
    Private Sub Reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    'Day Button
    Private Sub btnDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDay.Click
        export_excel("SELECT * FROM OfTheDay", "Report of the day")
    End Sub
    'Month button
    Private Sub btnMonth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMonth.Click
        export_excel("SELECT * FROM OfTheMonth", "Report of the month")
    End Sub
    'Year Button
    Private Sub btnYear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYear.Click
        export_excel("SELECT * FROM OfTheYear", "Report of the year")
    End Sub
    'All Time Button
    Private Sub btnAlltime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlltime.Click
        export_excel("SELECT * FROM OfAllTime", "Report of every visit")
    End Sub

    Sub export_excel(ByVal sql As String, ByVal NameOfReport As String)
        con.Open()
        cmd = New SqlCommand(sql, con)
        rdr = cmd.ExecuteReader
        If rdr.HasRows Then
            myExcelApp = New Excel.ApplicationClass()
            myExcelApp.Visible = True
            myExcelWorkbooks = myExcelApp.Workbooks

            myExcelWorkbook = myExcelWorkbooks.Open(fileName, misValue, misValue)

            Dim myExcelWorksheet As Excel.Worksheet = DirectCast(myExcelWorkbook.ActiveSheet, Excel.Worksheet)

            myExcelWorksheet.Range("D6", misValue).Formula = NameOfReport

            myExcelWorksheet.Range("D7", misValue).Formula = "As of " & Date.Now.ToString("dddd, MMMM dd,yyyy") & "  " & Date.Now.ToString("h:mm:ss tt")

            'Starting Row
            Dim ctr As Integer = 13

            Do While rdr.Read()
                myExcelWorksheet.Cells(ctr, 1) = rdr("VisitorID")
                myExcelWorksheet.Cells(ctr, 2) = rdr("FirstName")
                myExcelWorksheet.Cells(ctr, 3) = rdr("MiddleName")
                myExcelWorksheet.Cells(ctr, 4) = rdr("LastName")
                myExcelWorksheet.Cells(ctr, 5) = rdr("Sex")
                myExcelWorksheet.Cells(ctr, 6) = rdr("VisitID")
                myExcelWorksheet.Cells(ctr, 7) = rdr("PurposeName")
                myExcelWorksheet.Cells(ctr, 8) = rdr("DestinationName")
                myExcelWorksheet.Cells(ctr, 9) = rdr("Description")
                myExcelWorksheet.Cells(ctr, 10) = Format(rdr("DateOfVisit"), "dddd, MMMM dd,yyyy")
                myExcelWorksheet.Cells(ctr, 11) = rdr("TimeIn").ToString
                myExcelWorksheet.Cells(ctr, 12) = rdr("TimeOut").ToString
                ctr = ctr + 1
            Loop
        Else
            MsgBoxSetMsg("No Record Found")
        End If
        con.Close()
    End Sub

End Class