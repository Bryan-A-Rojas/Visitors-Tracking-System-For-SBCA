<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtMiddleInitial = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.BirthdatePicker = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.ComboSex = New System.Windows.Forms.ComboBox
        Me.btnstartpic = New System.Windows.Forms.Button
        Me.PicTimer = New System.Windows.Forms.Timer(Me.components)
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtPhoneNum = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Clock = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label
        Me.PictureBoxVisitorPic = New System.Windows.Forms.PictureBox
        Me.btncapturepic = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.txtDate = New System.Windows.Forms.Label
        Me.btnBack = New System.Windows.Forms.PictureBox
        Me.btnRegister = New System.Windows.Forms.PictureBox
        CType(Me.PictureBoxVisitorPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRegister, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bebas Neue Bold", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(130, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(299, 28)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Visitors Tracking Information System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Old English Text MT", 22.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(129, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(349, 35)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "San Beda College Alabang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Raleway", 26.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(572, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 41)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "First Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Raleway", 20.0!)
        Me.txtFirstName.Location = New System.Drawing.Point(579, 228)
        Me.txtFirstName.MaxLength = 50
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(197, 39)
        Me.txtFirstName.TabIndex = 8
        '
        'txtMiddleInitial
        '
        Me.txtMiddleInitial.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleInitial.Location = New System.Drawing.Point(796, 228)
        Me.txtMiddleInitial.Name = "txtMiddleInitial"
        Me.txtMiddleInitial.Size = New System.Drawing.Size(124, 39)
        Me.txtMiddleInitial.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Raleway", 26.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(789, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 41)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "MI."
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(980, 228)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(231, 39)
        Me.txtLastName.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Raleway", 26.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(973, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(201, 41)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Last Name:"
        '
        'BirthdatePicker
        '
        Me.BirthdatePicker.Font = New System.Drawing.Font("Raleway", 17.0!)
        Me.BirthdatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BirthdatePicker.Location = New System.Drawing.Point(796, 339)
        Me.BirthdatePicker.Name = "BirthdatePicker"
        Me.BirthdatePicker.Size = New System.Drawing.Size(171, 34)
        Me.BirthdatePicker.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Raleway", 26.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(572, 281)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 41)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Sex:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Raleway", 26.0!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(789, 281)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(174, 41)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Birthdate:"
        '
        'ComboSex
        '
        Me.ComboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboSex.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboSex.FormattingEnabled = True
        Me.ComboSex.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.ComboSex.Location = New System.Drawing.Point(579, 334)
        Me.ComboSex.Name = "ComboSex"
        Me.ComboSex.Size = New System.Drawing.Size(197, 39)
        Me.ComboSex.TabIndex = 22
        '
        'btnstartpic
        '
        Me.btnstartpic.BackColor = System.Drawing.Color.White
        Me.btnstartpic.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnstartpic.Font = New System.Drawing.Font("Raleway", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstartpic.ForeColor = System.Drawing.Color.Black
        Me.btnstartpic.Location = New System.Drawing.Point(135, 575)
        Me.btnstartpic.Name = "btnstartpic"
        Me.btnstartpic.Size = New System.Drawing.Size(116, 84)
        Me.btnstartpic.TabIndex = 25
        Me.btnstartpic.Text = "Start"
        Me.btnstartpic.UseVisualStyleBackColor = False
        '
        'PicTimer
        '
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(579, 465)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(632, 39)
        Me.txtAddress.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Raleway", 26.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(572, 412)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 41)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Address:"
        '
        'txtPhoneNum
        '
        Me.txtPhoneNum.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNum.Location = New System.Drawing.Point(980, 334)
        Me.txtPhoneNum.Name = "txtPhoneNum"
        Me.txtPhoneNum.Size = New System.Drawing.Size(231, 39)
        Me.txtPhoneNum.TabIndex = 42
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Raleway", 26.0!)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(973, 281)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(273, 41)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "Phone Number:"
        '
        'Clock
        '
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Raleway", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(482, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(306, 47)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Register Visitor"
        '
        'PictureBoxVisitorPic
        '
        Me.PictureBoxVisitorPic.BackColor = System.Drawing.Color.White
        Me.PictureBoxVisitorPic.InitialImage = CType(resources.GetObject("PictureBoxVisitorPic.InitialImage"), System.Drawing.Image)
        Me.PictureBoxVisitorPic.Location = New System.Drawing.Point(24, 168)
        Me.PictureBoxVisitorPic.Name = "PictureBoxVisitorPic"
        Me.PictureBoxVisitorPic.Size = New System.Drawing.Size(504, 394)
        Me.PictureBoxVisitorPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxVisitorPic.TabIndex = 24
        Me.PictureBoxVisitorPic.TabStop = False
        '
        'btncapturepic
        '
        Me.btncapturepic.BackColor = System.Drawing.Color.Transparent
        Me.btncapturepic.BackgroundImage = CType(resources.GetObject("btncapturepic.BackgroundImage"), System.Drawing.Image)
        Me.btncapturepic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncapturepic.FlatAppearance.BorderSize = 0
        Me.btncapturepic.Font = New System.Drawing.Font("Raleway", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncapturepic.ForeColor = System.Drawing.Color.Black
        Me.btncapturepic.Location = New System.Drawing.Point(301, 575)
        Me.btncapturepic.Name = "btncapturepic"
        Me.btncapturepic.Size = New System.Drawing.Size(116, 84)
        Me.btncapturepic.TabIndex = 23
        Me.btncapturepic.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Visitor.My.Resources.Resources.circular_clock
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(24, 674)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 34)
        Me.PictureBox2.TabIndex = 50
        Me.PictureBox2.TabStop = False
        '
        'txtDate
        '
        Me.txtDate.AutoSize = True
        Me.txtDate.Font = New System.Drawing.Font("Raleway", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.ForeColor = System.Drawing.Color.White
        Me.txtDate.Location = New System.Drawing.Point(62, 671)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(183, 37)
        Me.txtDate.TabIndex = 49
        Me.txtDate.Text = "Date Today"
        '
        'btnBack
        '
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Image = Global.Visitor.My.Resources.Resources.previous
        Me.btnBack.Location = New System.Drawing.Point(1124, 24)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(107, 99)
        Me.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnBack.TabIndex = 66
        Me.btnBack.TabStop = False
        '
        'btnRegister
        '
        Me.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegister.Image = Global.Visitor.My.Resources.Resources.checked
        Me.btnRegister.Location = New System.Drawing.Point(839, 550)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(124, 99)
        Me.btnRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnRegister.TabIndex = 67
        Me.btnRegister.TabStop = False
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtPhoneNum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.btnstartpic)
        Me.Controls.Add(Me.PictureBoxVisitorPic)
        Me.Controls.Add(Me.btncapturepic)
        Me.Controls.Add(Me.ComboSex)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BirthdatePicker)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMiddleInitial)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        CType(Me.PictureBoxVisitorPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRegister, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtMiddleInitial As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BirthdatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComboSex As System.Windows.Forms.ComboBox
    Friend WithEvents btnstartpic As System.Windows.Forms.Button
    Friend WithEvents PictureBoxVisitorPic As System.Windows.Forms.PictureBox
    Friend WithEvents btncapturepic As System.Windows.Forms.Button
    Friend WithEvents PicTimer As System.Windows.Forms.Timer
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNum As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Clock As System.Windows.Forms.Timer
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtDate As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.PictureBox
    Friend WithEvents btnRegister As System.Windows.Forms.PictureBox
End Class
