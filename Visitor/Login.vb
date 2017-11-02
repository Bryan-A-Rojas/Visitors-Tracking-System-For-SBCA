Imports System
Imports System.Text
Imports System.Security.Cryptography

Imports System.Data.SqlClient
Imports System.IO

Public Class Login

    'SQL Variables
    Dim con As SqlConnection = New SqlConnection("server=DESKTOP-LJA6FPI\SQLEXPRESS;Initial Catalog=Visitor's Tracking System;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader
    Dim sqlResult As Object

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


    'On Load
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        erasetext()
        Clock.Start()
    End Sub
    'Clock Timer
    Private Sub Clock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clock.Tick
        txtDate.Text = Date.Now.ToString("dddd, MMMM dd,yyyy") & "  " & Date.Now.ToString("h:mm:ss tt")
    End Sub
    

    'Utility Section

    'Clears Text
    Sub erasetext()
        txtPassword.Text = Nothing
        txtUsername.Text = Nothing
    End Sub
    'Encryption3
    Public Shared Function VerifyHash(ByVal plainText As String, _
                                         ByVal hashAlgorithm As String, _
                                         ByVal hashValue As String) _
                              As Boolean

        ' Convert base64-encoded hash value into a byte array.
        Dim hashWithSaltBytes As Byte()
        hashWithSaltBytes = Convert.FromBase64String(hashValue)

        ' We must know size of hash (without salt).
        Dim hashSizeInBits As Integer
        Dim hashSizeInBytes As Integer

        ' Make sure that hashing algorithm name is specified.
        If (hashAlgorithm Is Nothing) Then
            hashAlgorithm = ""
        End If

        ' Size of hash is based on the specified algorithm.
        Select Case hashAlgorithm.ToUpper()

            Case "SHA1"
                hashSizeInBits = 160

            Case "SHA256"
                hashSizeInBits = 256

            Case "SHA384"
                hashSizeInBits = 384

            Case "SHA512"
                hashSizeInBits = 512

            Case Else ' Must be MD5
                hashSizeInBits = 128

        End Select

        ' Convert size of hash from bits to bytes.
        hashSizeInBytes = hashSizeInBits / 8

        ' Make sure that the specified hash value is long enough.
        If (hashWithSaltBytes.Length < hashSizeInBytes) Then
            VerifyHash = False
        End If

        ' Allocate array to hold original salt bytes retrieved from hash.
        Dim saltBytes() As Byte = New Byte(hashWithSaltBytes.Length - _
                                           hashSizeInBytes - 1) {}

        ' Copy salt from the end of the hash to the new array.
        Dim I As Integer
        For I = 0 To saltBytes.Length - 1
            saltBytes(I) = hashWithSaltBytes(hashSizeInBytes + I)
        Next I

        ' Compute a new hash string.
        Dim expectedHashString As String
        expectedHashString = ComputeHash(plainText, hashAlgorithm, saltBytes)

        ' If the computed hash matches the specified hash,
        ' the plain text value must be correct.
        VerifyHash = (hashValue = expectedHashString)
    End Function
    Public Shared Function ComputeHash(ByVal plainText As String, _
                                       ByVal hashAlgorithm As String, _
                                       ByVal saltBytes() As Byte) _
                           As String

        ' If salt is not specified, generate it on the fly.
        If (saltBytes Is Nothing) Then

            ' Define min and max salt sizes.
            Dim minSaltSize As Integer
            Dim maxSaltSize As Integer

            minSaltSize = 4
            maxSaltSize = 8

            ' Generate a random number for the size of the salt.
            Dim random As Random
            random = New Random()

            Dim saltSize As Integer
            saltSize = random.Next(minSaltSize, maxSaltSize)

            ' Allocate a byte array, which will hold the salt.
            saltBytes = New Byte(saltSize - 1) {}

            ' Initialize a random number generator.
            Dim rng As RNGCryptoServiceProvider
            rng = New RNGCryptoServiceProvider()

            ' Fill the salt with cryptographically strong byte values.
            rng.GetNonZeroBytes(saltBytes)
        End If

        ' Convert plain text into a byte array.
        Dim plainTextBytes As Byte()
        plainTextBytes = Encoding.UTF8.GetBytes(plainText)

        ' Allocate array, which will hold plain text and salt.
        Dim plainTextWithSaltBytes() As Byte = _
            New Byte(plainTextBytes.Length + saltBytes.Length - 1) {}

        ' Copy plain text bytes into resulting array.
        Dim I As Integer
        For I = 0 To plainTextBytes.Length - 1
            plainTextWithSaltBytes(I) = plainTextBytes(I)
        Next I

        ' Append salt bytes to the resulting array.
        For I = 0 To saltBytes.Length - 1
            plainTextWithSaltBytes(plainTextBytes.Length + I) = saltBytes(I)
        Next I

        ' Because we support multiple hashing algorithms, we must define
        ' hash object as a common (abstract) base class. We will specify the
        ' actual hashing algorithm class later during object creation.
        Dim hash As HashAlgorithm

        ' Make sure hashing algorithm name is specified.
        If (hashAlgorithm Is Nothing) Then
            hashAlgorithm = ""
        End If

        ' Initialize appropriate hashing algorithm class.
        Select Case hashAlgorithm.ToUpper()

            Case "SHA1"
                hash = New SHA1Managed()

            Case "SHA256"
                hash = New SHA256Managed()

            Case "SHA384"
                hash = New SHA384Managed()

            Case "SHA512"
                hash = New SHA512Managed()

            Case Else
                hash = New MD5CryptoServiceProvider()

        End Select

        ' Compute hash value of our plain text with appended salt.
        Dim hashBytes As Byte()
        hashBytes = hash.ComputeHash(plainTextWithSaltBytes)

        ' Create array which will hold hash and original salt bytes.
        Dim hashWithSaltBytes() As Byte = _
                                   New Byte(hashBytes.Length + _
                                            saltBytes.Length - 1) {}

        ' Copy hash bytes into resulting array.
        For I = 0 To hashBytes.Length - 1
            hashWithSaltBytes(I) = hashBytes(I)
        Next I

        ' Append salt bytes to the result.
        For I = 0 To saltBytes.Length - 1
            hashWithSaltBytes(hashBytes.Length + I) = saltBytes(I)
        Next I

        ' Convert result into a base64-encoded string.
        Dim hashValue As String
        hashValue = Convert.ToBase64String(hashWithSaltBytes)

        ' Return the result.
        ComputeHash = hashValue
    End Function
    'Removes Extra White Spaces
    Private Sub StripSpaces()
        txtUsername.Text = String.Join(" ", txtUsername.Text.Split(New Char() {}, StringSplitOptions.RemoveEmptyEntries))
        txtPassword.Text = String.Join(" ", txtPassword.Text.Split(New Char() {}, StringSplitOptions.RemoveEmptyEntries))
    End Sub

    'SQL Section

    'Checks if the password is correct
    Sub List()
        con.Open()
        cmd = New SqlCommand("SELECT Password FROM Accounts WHERE UserName= @value0", con)
        cmd.Parameters.AddWithValue("@value0", txtUsername.Text)

        sqlResult = cmd.ExecuteScalar()

        If sqlResult Is Nothing Then
            sqlResult = ComputeHash("wrongpass", "SHA512", Nothing)
        Else
            sqlResult = cmd.ExecuteScalar().ToString  'result found
        End If

        cmd.Parameters.Clear()
        con.Close()
    End Sub

    
    'Button Section

    'Login Button
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        StripSpaces()
        If Not txtUsername.Text = "" And Not txtPassword.Text = "" Then
            List()
            If VerifyHash(txtPassword.Text, "SHA512", sqlResult.ToString).ToString() Then
                MsgBoxSetMsg("Welcome")
                MainMenu.Show()
                Me.Close()
            Else
                MsgBoxSetMsg("Wrong Username or password!")
                txtUsername.Text = Nothing
                txtPassword.Text = Nothing
                sqlResult = Nothing
            End If
        Else
            MsgBoxSetMsg("Please fill up all fields")
        End If
    End Sub
    Private Sub txtLogin_EnterKey(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            StripSpaces()
            If Not txtUsername.Text = "" And Not txtPassword.Text = "" Then
                List()
                If VerifyHash(txtPassword.Text, "SHA512", sqlResult.ToString).ToString() Then
                    MsgBoxSetMsg("Welcome")
                    MainMenu.Show()
                    Me.Close()
                Else
                    MsgBoxSetMsg("Wrong Username or password!")
                    txtUsername.Text = Nothing
                    txtPassword.Text = Nothing
                    sqlResult = Nothing
                End If
            Else
                MsgBoxSetMsg("Please fill up all fields")
            End If
        End If
    End Sub
    Private Sub txtPassword_EnterKey(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            StripSpaces()
            If Not txtUsername.Text = "" And Not txtPassword.Text = "" Then
                List()
                If VerifyHash(txtPassword.Text, "SHA512", sqlResult.ToString).ToString() Then
                    MsgBoxSetMsg("Welcome")
                    MainMenu.Show()
                    Me.Close()
                Else
                    MsgBoxSetMsg("Wrong Username or password!")
                    txtUsername.Text = Nothing
                    txtPassword.Text = Nothing
                    sqlResult = Nothing
                End If
            Else
                MsgBoxSetMsg("Please fill up all fields")
            End If
        End If
    End Sub
    'Exit Button
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
        MsgBoxSetMsg("Goodbye!")
    End Sub
End Class