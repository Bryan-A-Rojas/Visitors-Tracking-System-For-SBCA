Imports System.Data.SqlClient

Module MyFunctions
    'Variables

    'SQL Variables
    Public con As SqlConnection = New SqlConnection("server=DESKTOP-LJA6FPI\SQLEXPRESS;Initial Catalog=Visitor's Tracking System;Integrated Security=True")
    Public cmd As SqlCommand
    Public rdr As SqlDataReader

    'Camera Variables
    Public Touchless As New TouchlessLib.TouchlessMgr
    Public Camera1 As TouchlessLib.Camera = Touchless.Cameras.Item(0)

    'Container Variable for picture
    Public DefaultImage As Image = My.Resources.No_Image_Icon


    'Functions
    'Clears Text
    Sub EraseText(ByVal FormName As Form)
        Dim a As Control
        For Each a In FormName.Controls
            If TypeOf a Is TextBox Then
                a.Text = Nothing
            End If
        Next
    End Sub
    'Removes Extra White Spaces
    Sub StripSpaces(ByVal FormName As Form)
        Dim a As Control
        For Each a In FormName.Controls
            If TypeOf a Is TextBox Then
                a.Text = String.Join(" ", a.Text.Split(New Char() {}, StringSplitOptions.RemoveEmptyEntries))
            End If
        Next
    End Sub
    'Sets Default Picture
    Sub SetDefaultPicture(ByRef Picture As PictureBox, ByRef DefaultImage As Image)
        Picture.Image = DefaultImage
    End Sub
    'Prevents Empty Fields
    Function CheckIfEmpty(ByVal FormName As Form, ByVal ParamArray exceptions As TextBox()) As Boolean
        'Checks if any textbox is empty
        Dim empty = FormName.Controls.OfType(Of TextBox)().Where(Function(txt) txt.Text.Trim.Length = 0 AndAlso Not exceptions.Contains(txt))

        If empty.Any Then
            CheckIfEmpty = True
        Else
            CheckIfEmpty = False
        End If
    End Function
    'Checks if the picture is same as default
    Function CheckIfDefaultPicture(ByRef Picture As PictureBox, ByRef DefaultImage As Image) As Boolean
        If Picture.Image Is DefaultImage Then
            CheckIfDefaultPicture = True
        End If
    End Function

    'Extract ID Methods
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
        ElseIf String.Compare(PurposeName, "Other") = 0 Then
            PurposeID = 5
        End If
    End Function
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
            'ADD MORE
            '!!!!!!!
        End If
    End Function


    'Button Section

    'Back Button Design
    Private Sub btnBack_DesignOnHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Mousehover
        With Register.btnBack
            .BackColor = Color.Transparent
            .Image = My.Resources.previousHighlight
        End With
    End Sub
    Private Sub btnBack_DesignOnLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.MouseLeave
        With Register.btnBack
            .BackColor = Color.Transparent
            .Image = My.Resources.previous
        End With
    End Sub
    'Back Button Function
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        MainMenu.Show()
        Me.Close()
    End Sub

End Module
