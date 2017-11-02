Imports System.Data.SqlClient
Imports System.IO

Module MyFunctions
    'Camera Variables
    Public Touchless As New TouchlessLib.TouchlessMgr
    Public Camera1 As TouchlessLib.Camera = Touchless.Cameras.Item(0)

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

    'Checks if the picture is the same
    Function CheckIfDefaultPicture(ByRef Picture As PictureBox, ByRef DefaultImage As Image) As Boolean
        If Picture.Image Is DefaultImage Then
            CheckIfDefaultPicture = True
        End If
    End Function


End Module
