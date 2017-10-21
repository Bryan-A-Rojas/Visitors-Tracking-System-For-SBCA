<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SubList))
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ID = New System.Windows.Forms.ColumnHeader
        Me.Firstname = New System.Windows.Forms.ColumnHeader
        Me.MI = New System.Windows.Forms.ColumnHeader
        Me.Lastname = New System.Windows.Forms.ColumnHeader
        Me.Sex = New System.Windows.Forms.ColumnHeader
        Me.Purpose = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.btnTimeOut = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.CheckTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBoxVisitorPic = New System.Windows.Forms.PictureBox
        Me.btnBack = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.txtDate = New System.Windows.Forms.Label
        Me.Clock = New System.Windows.Forms.Timer(Me.components)
        Me.txtID = New System.Windows.Forms.Label
        Me.txtFirstName = New System.Windows.Forms.Label
        Me.ComboSex = New System.Windows.Forms.Label
        Me.txtVisitID = New System.Windows.Forms.Label
        Me.txtVisits = New System.Windows.Forms.Label
        Me.txtDestination = New System.Windows.Forms.Label
        Me.txtPurpose = New System.Windows.Forms.Label
        Me.txtTimeIn = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxVisitorPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Firstname, Me.MI, Me.Lastname, Me.Sex, Me.Purpose, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(110, 393)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1058, 238)
        Me.ListView1.TabIndex = 10
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 73
        '
        'Firstname
        '
        Me.Firstname.Text = "First Name"
        Me.Firstname.Width = 89
        '
        'MI
        '
        Me.MI.Text = "Middle Initial"
        Me.MI.Width = 102
        '
        'Lastname
        '
        Me.Lastname.Text = "Last Name"
        Me.Lastname.Width = 90
        '
        'Sex
        '
        Me.Sex.Text = "Sex"
        Me.Sex.Width = 80
        '
        'Purpose
        '
        Me.Purpose.Text = "Purpose"
        Me.Purpose.Width = 95
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Time-In"
        Me.ColumnHeader1.Width = 86
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Destination"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Description"
        Me.ColumnHeader3.Width = 286
        '
        'btnTimeOut
        '
        Me.btnTimeOut.BackColor = System.Drawing.Color.Green
        Me.btnTimeOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimeOut.Font = New System.Drawing.Font("Raleway", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeOut.ForeColor = System.Drawing.Color.White
        Me.btnTimeOut.Location = New System.Drawing.Point(1058, 269)
        Me.btnTimeOut.Name = "btnTimeOut"
        Me.btnTimeOut.Size = New System.Drawing.Size(110, 56)
        Me.btnTimeOut.TabIndex = 11
        Me.btnTimeOut.Text = "Time-Out"
        Me.btnTimeOut.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Raleway", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(781, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 24)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Raleway", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(781, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 24)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Sex:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Raleway", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(453, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 24)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "No. of Visits:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Raleway", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(453, 325)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 24)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Description:"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Raleway", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(457, 356)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(598, 31)
        Me.txtDescription.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Raleway", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(781, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 24)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "ID:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Raleway", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(453, 255)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 24)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Purpose:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Raleway", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(453, 285)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 24)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Time-In:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Raleway", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(453, 226)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 24)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Destination:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Raleway", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(453, 172)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 24)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Visit No:"
        '
        'CheckTimer
        '
        Me.CheckTimer.Interval = 2000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Raleway", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(483, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 47)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Current Visitors"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bebas Neue Bold", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(130, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(299, 28)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Visitors Tracking Information System"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Old English Text MT", 22.0!)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(129, 44)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(349, 35)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "San Beda College Alabang"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 49
        Me.PictureBox1.TabStop = False
        '
        'PictureBoxVisitorPic
        '
        Me.PictureBoxVisitorPic.BackColor = System.Drawing.Color.White
        Me.PictureBoxVisitorPic.InitialImage = CType(resources.GetObject("PictureBoxVisitorPic.InitialImage"), System.Drawing.Image)
        Me.PictureBoxVisitorPic.Location = New System.Drawing.Point(117, 140)
        Me.PictureBoxVisitorPic.Name = "PictureBoxVisitorPic"
        Me.PictureBoxVisitorPic.Size = New System.Drawing.Size(316, 247)
        Me.PictureBoxVisitorPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxVisitorPic.TabIndex = 53
        Me.PictureBoxVisitorPic.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Image = Global.Visitor.My.Resources.Resources.previous
        Me.btnBack.Location = New System.Drawing.Point(1120, 44)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(91, 87)
        Me.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnBack.TabIndex = 66
        Me.btnBack.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Visitor.My.Resources.Resources.circular_clock
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(19, 638)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 34)
        Me.PictureBox2.TabIndex = 69
        Me.PictureBox2.TabStop = False
        '
        'txtDate
        '
        Me.txtDate.AutoSize = True
        Me.txtDate.Font = New System.Drawing.Font("Raleway", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.ForeColor = System.Drawing.Color.White
        Me.txtDate.Location = New System.Drawing.Point(57, 635)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(183, 37)
        Me.txtDate.TabIndex = 68
        Me.txtDate.Text = "Date Today"
        '
        'Clock
        '
        '
        'txtID
        '
        Me.txtID.AutoSize = True
        Me.txtID.Font = New System.Drawing.Font("Raleway", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.Color.White
        Me.txtID.Location = New System.Drawing.Point(857, 172)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(0, 24)
        Me.txtID.TabIndex = 70
        '
        'txtFirstName
        '
        Me.txtFirstName.AutoSize = True
        Me.txtFirstName.Font = New System.Drawing.Font("Raleway", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.Color.White
        Me.txtFirstName.Location = New System.Drawing.Point(857, 199)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(0, 24)
        Me.txtFirstName.TabIndex = 71
        '
        'ComboSex
        '
        Me.ComboSex.AutoSize = True
        Me.ComboSex.Font = New System.Drawing.Font("Raleway", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboSex.ForeColor = System.Drawing.Color.White
        Me.ComboSex.Location = New System.Drawing.Point(857, 226)
        Me.ComboSex.Name = "ComboSex"
        Me.ComboSex.Size = New System.Drawing.Size(0, 24)
        Me.ComboSex.TabIndex = 72
        '
        'txtVisitID
        '
        Me.txtVisitID.AutoSize = True
        Me.txtVisitID.Font = New System.Drawing.Font("Raleway", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVisitID.ForeColor = System.Drawing.Color.White
        Me.txtVisitID.Location = New System.Drawing.Point(575, 172)
        Me.txtVisitID.Name = "txtVisitID"
        Me.txtVisitID.Size = New System.Drawing.Size(0, 24)
        Me.txtVisitID.TabIndex = 73
        '
        'txtVisits
        '
        Me.txtVisits.AutoSize = True
        Me.txtVisits.Font = New System.Drawing.Font("Raleway", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVisits.ForeColor = System.Drawing.Color.White
        Me.txtVisits.Location = New System.Drawing.Point(575, 199)
        Me.txtVisits.Name = "txtVisits"
        Me.txtVisits.Size = New System.Drawing.Size(0, 24)
        Me.txtVisits.TabIndex = 74
        '
        'txtDestination
        '
        Me.txtDestination.AutoSize = True
        Me.txtDestination.Font = New System.Drawing.Font("Raleway", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDestination.ForeColor = System.Drawing.Color.White
        Me.txtDestination.Location = New System.Drawing.Point(575, 226)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(0, 24)
        Me.txtDestination.TabIndex = 75
        '
        'txtPurpose
        '
        Me.txtPurpose.AutoSize = True
        Me.txtPurpose.Font = New System.Drawing.Font("Raleway", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurpose.ForeColor = System.Drawing.Color.White
        Me.txtPurpose.Location = New System.Drawing.Point(575, 255)
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Size = New System.Drawing.Size(0, 24)
        Me.txtPurpose.TabIndex = 76
        '
        'txtTimeIn
        '
        Me.txtTimeIn.AutoSize = True
        Me.txtTimeIn.Font = New System.Drawing.Font("Raleway", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeIn.ForeColor = System.Drawing.Color.White
        Me.txtTimeIn.Location = New System.Drawing.Point(575, 285)
        Me.txtTimeIn.Name = "txtTimeIn"
        Me.txtTimeIn.Size = New System.Drawing.Size(0, 24)
        Me.txtTimeIn.TabIndex = 77
        '
        'SubList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.txtTimeIn)
        Me.Controls.Add(Me.txtPurpose)
        Me.Controls.Add(Me.txtDestination)
        Me.Controls.Add(Me.txtVisits)
        Me.Controls.Add(Me.txtVisitID)
        Me.Controls.Add(Me.ComboSex)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PictureBoxVisitorPic)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnTimeOut)
        Me.Controls.Add(Me.ListView1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SubList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxVisitorPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Lastname As System.Windows.Forms.ColumnHeader
    Friend WithEvents Firstname As System.Windows.Forms.ColumnHeader
    Friend WithEvents MI As System.Windows.Forms.ColumnHeader
    Friend WithEvents Sex As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnTimeOut As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Purpose As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CheckTimer As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxVisitorPic As System.Windows.Forms.PictureBox
    Friend WithEvents btnBack As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtDate As System.Windows.Forms.Label
    Friend WithEvents Clock As System.Windows.Forms.Timer
    Friend WithEvents txtID As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.Label
    Friend WithEvents ComboSex As System.Windows.Forms.Label
    Friend WithEvents txtVisitID As System.Windows.Forms.Label
    Friend WithEvents txtVisits As System.Windows.Forms.Label
    Friend WithEvents txtDestination As System.Windows.Forms.Label
    Friend WithEvents txtPurpose As System.Windows.Forms.Label
    Friend WithEvents txtTimeIn As System.Windows.Forms.Label
End Class
