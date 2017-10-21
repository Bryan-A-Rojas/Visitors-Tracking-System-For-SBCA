<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Approve
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Approve))
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ID = New System.Windows.Forms.ColumnHeader
        Me.Firstname = New System.Windows.Forms.ColumnHeader
        Me.MI = New System.Windows.Forms.ColumnHeader
        Me.Lastname = New System.Windows.Forms.ColumnHeader
        Me.Sex = New System.Windows.Forms.ColumnHeader
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Clock = New System.Windows.Forms.Timer(Me.components)
        Me.btnViewInfo = New System.Windows.Forms.Button
        Me.txtDate = New System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.btnBack = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBoxVisitorPic = New System.Windows.Forms.PictureBox
        Me.txtVisitorID = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.Label
        Me.txtSex = New System.Windows.Forms.Label
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxVisitorPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Raleway", 20.0!)
        Me.txtSearch.Location = New System.Drawing.Point(950, 188)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(212, 39)
        Me.txtSearch.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Raleway", 26.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(808, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 41)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Search:"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Firstname, Me.MI, Me.Lastname, Me.Sex})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(41, 400)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1177, 231)
        Me.ListView1.TabIndex = 15
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "Visitor ID"
        Me.ID.Width = 274
        '
        'Firstname
        '
        Me.Firstname.Text = "First Name"
        Me.Firstname.Width = 205
        '
        'MI
        '
        Me.MI.Text = "Middle Initial"
        Me.MI.Width = 245
        '
        'Lastname
        '
        Me.Lastname.Text = "Last Name"
        Me.Lastname.Width = 237
        '
        'Sex
        '
        Me.Sex.Text = "Sex"
        Me.Sex.Width = 202
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Raleway", 26.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(355, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 41)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Raleway", 26.0!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(355, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 41)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Visitor ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Raleway", 26.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(355, 284)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 41)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Sex:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bebas Neue Bold", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(134, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(299, 28)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Visitors Tracking Information System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Old English Text MT", 22.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(133, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(349, 35)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "San Beda College Alabang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Raleway", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(492, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 47)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Approval"
        '
        'Clock
        '
        '
        'btnViewInfo
        '
        Me.btnViewInfo.Font = New System.Drawing.Font("Raleway", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewInfo.Location = New System.Drawing.Point(364, 347)
        Me.btnViewInfo.Name = "btnViewInfo"
        Me.btnViewInfo.Size = New System.Drawing.Size(160, 38)
        Me.btnViewInfo.TabIndex = 49
        Me.btnViewInfo.Text = "Open Details"
        Me.btnViewInfo.UseVisualStyleBackColor = True
        '
        'txtDate
        '
        Me.txtDate.AutoSize = True
        Me.txtDate.Font = New System.Drawing.Font("Raleway", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.ForeColor = System.Drawing.Color.White
        Me.txtDate.Location = New System.Drawing.Point(54, 634)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(183, 37)
        Me.txtDate.TabIndex = 66
        Me.txtDate.Text = "Date Today"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Image = Global.Visitor.My.Resources.Resources.Search
        Me.btnSearch.Location = New System.Drawing.Point(1161, 188)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(50, 39)
        Me.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnSearch.TabIndex = 68
        Me.btnSearch.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Visitor.My.Resources.Resources.circular_clock
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(16, 637)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 34)
        Me.PictureBox2.TabIndex = 67
        Me.PictureBox2.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Image = Global.Visitor.My.Resources.Resources.previous
        Me.btnBack.Location = New System.Drawing.Point(1127, 47)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(91, 87)
        Me.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnBack.TabIndex = 65
        Me.btnBack.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'PictureBoxVisitorPic
        '
        Me.PictureBoxVisitorPic.BackColor = System.Drawing.Color.White
        Me.PictureBoxVisitorPic.InitialImage = CType(resources.GetObject("PictureBoxVisitorPic.InitialImage"), System.Drawing.Image)
        Me.PictureBoxVisitorPic.Location = New System.Drawing.Point(41, 160)
        Me.PictureBoxVisitorPic.Name = "PictureBoxVisitorPic"
        Me.PictureBoxVisitorPic.Size = New System.Drawing.Size(299, 234)
        Me.PictureBoxVisitorPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxVisitorPic.TabIndex = 25
        Me.PictureBoxVisitorPic.TabStop = False
        '
        'txtVisitorID
        '
        Me.txtVisitorID.AutoSize = True
        Me.txtVisitorID.Font = New System.Drawing.Font("Raleway", 26.0!)
        Me.txtVisitorID.ForeColor = System.Drawing.Color.White
        Me.txtVisitorID.Location = New System.Drawing.Point(530, 183)
        Me.txtVisitorID.Name = "txtVisitorID"
        Me.txtVisitorID.Size = New System.Drawing.Size(0, 41)
        Me.txtVisitorID.TabIndex = 69
        '
        'txtName
        '
        Me.txtName.AutoSize = True
        Me.txtName.Font = New System.Drawing.Font("Raleway", 26.0!)
        Me.txtName.ForeColor = System.Drawing.Color.White
        Me.txtName.Location = New System.Drawing.Point(530, 235)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(0, 41)
        Me.txtName.TabIndex = 70
        '
        'txtSex
        '
        Me.txtSex.AutoSize = True
        Me.txtSex.Font = New System.Drawing.Font("Raleway", 26.0!)
        Me.txtSex.ForeColor = System.Drawing.Color.White
        Me.txtSex.Location = New System.Drawing.Point(530, 284)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(0, 41)
        Me.txtSex.TabIndex = 71
        '
        'Approve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.txtSex)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtVisitorID)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnViewInfo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBoxVisitorPic)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Approve"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxVisitorPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Firstname As System.Windows.Forms.ColumnHeader
    Friend WithEvents MI As System.Windows.Forms.ColumnHeader
    Friend WithEvents Lastname As System.Windows.Forms.ColumnHeader
    Friend WithEvents Sex As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBoxVisitorPic As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Clock As System.Windows.Forms.Timer
    Friend WithEvents btnViewInfo As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtDate As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.PictureBox
    Friend WithEvents txtVisitorID As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.Label
    Friend WithEvents txtSex As System.Windows.Forms.Label

End Class
