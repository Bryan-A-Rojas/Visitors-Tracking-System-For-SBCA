<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterListDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterListDialog))
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtPhoneNum = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.btnstartpic = New System.Windows.Forms.Button
        Me.ComboSex = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.BirthdatePicker = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtMiddleInitial = New System.Windows.Forms.TextBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.PictureBoxVisitorPic = New System.Windows.Forms.PictureBox
        Me.btncapturepic = New System.Windows.Forms.Button
        Me.PicTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBoxVisitorPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Raleway", 18.0!)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(597, 127)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(187, 29)
        Me.Label15.TabIndex = 84
        Me.Label15.Text = "Phone Number:"
        '
        'txtPhoneNum
        '
        Me.txtPhoneNum.Font = New System.Drawing.Font("Raleway", 15.0!)
        Me.txtPhoneNum.Location = New System.Drawing.Point(606, 159)
        Me.txtPhoneNum.Name = "txtPhoneNum"
        Me.txtPhoneNum.Size = New System.Drawing.Size(157, 31)
        Me.txtPhoneNum.TabIndex = 83
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Raleway", 18.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(331, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 29)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Address:"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Raleway", 15.0!)
        Me.txtAddress.Location = New System.Drawing.Point(336, 241)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(427, 31)
        Me.txtAddress.TabIndex = 81
        '
        'btnstartpic
        '
        Me.btnstartpic.BackColor = System.Drawing.Color.White
        Me.btnstartpic.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnstartpic.Font = New System.Drawing.Font("Raleway", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstartpic.ForeColor = System.Drawing.Color.Black
        Me.btnstartpic.Location = New System.Drawing.Point(67, 290)
        Me.btnstartpic.Name = "btnstartpic"
        Me.btnstartpic.Size = New System.Drawing.Size(100, 62)
        Me.btnstartpic.TabIndex = 80
        Me.btnstartpic.Text = "Start"
        Me.btnstartpic.UseVisualStyleBackColor = False
        '
        'ComboSex
        '
        Me.ComboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboSex.Font = New System.Drawing.Font("Raleway", 15.0!)
        Me.ComboSex.FormattingEnabled = True
        Me.ComboSex.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.ComboSex.Location = New System.Drawing.Point(336, 159)
        Me.ComboSex.Name = "ComboSex"
        Me.ComboSex.Size = New System.Drawing.Size(107, 32)
        Me.ComboSex.TabIndex = 77
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Raleway", 18.0!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(449, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 29)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "Birthdate:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Raleway", 18.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(331, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 29)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Sex:"
        '
        'BirthdatePicker
        '
        Me.BirthdatePicker.Font = New System.Drawing.Font("Raleway", 15.0!)
        Me.BirthdatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BirthdatePicker.Location = New System.Drawing.Point(449, 160)
        Me.BirthdatePicker.Name = "BirthdatePicker"
        Me.BirthdatePicker.Size = New System.Drawing.Size(151, 31)
        Me.BirthdatePicker.TabIndex = 74
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Raleway", 18.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(597, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 29)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Last Name:"
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Raleway", 15.0!)
        Me.txtLastName.Location = New System.Drawing.Point(602, 80)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(161, 31)
        Me.txtLastName.TabIndex = 72
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Raleway", 18.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(507, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 29)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "MI."
        '
        'txtMiddleInitial
        '
        Me.txtMiddleInitial.Font = New System.Drawing.Font("Raleway", 15.0!)
        Me.txtMiddleInitial.Location = New System.Drawing.Point(512, 80)
        Me.txtMiddleInitial.Name = "txtMiddleInitial"
        Me.txtMiddleInitial.Size = New System.Drawing.Size(79, 31)
        Me.txtMiddleInitial.TabIndex = 70
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Raleway", 15.0!)
        Me.txtFirstName.Location = New System.Drawing.Point(336, 80)
        Me.txtFirstName.MaxLength = 50
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(166, 31)
        Me.txtFirstName.TabIndex = 69
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Raleway", 18.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(331, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 29)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "First Name:"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Raleway", 24.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(410, 384)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(142, 87)
        Me.btnCancel.TabIndex = 103
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Raleway", 24.0!)
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Location = New System.Drawing.Point(226, 384)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(142, 87)
        Me.btnUpdate.TabIndex = 102
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'PictureBoxVisitorPic
        '
        Me.PictureBoxVisitorPic.BackColor = System.Drawing.Color.White
        Me.PictureBoxVisitorPic.InitialImage = CType(resources.GetObject("PictureBoxVisitorPic.InitialImage"), System.Drawing.Image)
        Me.PictureBoxVisitorPic.Location = New System.Drawing.Point(29, 46)
        Me.PictureBoxVisitorPic.Name = "PictureBoxVisitorPic"
        Me.PictureBoxVisitorPic.Size = New System.Drawing.Size(294, 238)
        Me.PictureBoxVisitorPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxVisitorPic.TabIndex = 79
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
        Me.btncapturepic.Location = New System.Drawing.Point(191, 290)
        Me.btncapturepic.Name = "btncapturepic"
        Me.btncapturepic.Size = New System.Drawing.Size(100, 62)
        Me.btncapturepic.TabIndex = 78
        Me.btncapturepic.UseVisualStyleBackColor = False
        '
        'PicTimer
        '
        '
        'MasterListDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 505)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MasterListDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ApproveDialog"
        CType(Me.PictureBoxVisitorPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNum As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents btnstartpic As System.Windows.Forms.Button
    Friend WithEvents PictureBoxVisitorPic As System.Windows.Forms.PictureBox
    Friend WithEvents btncapturepic As System.Windows.Forms.Button
    Friend WithEvents ComboSex As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BirthdatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMiddleInitial As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents PicTimer As System.Windows.Forms.Timer
End Class
