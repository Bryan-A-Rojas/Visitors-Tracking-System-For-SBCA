<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisitHistoryDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VisitHistoryDialog))
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.txtBirthDate = New System.Windows.Forms.Label
        Me.txtPhoneNum = New System.Windows.Forms.Label
        Me.txtSex = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.Label
        Me.txtVisitorID = New System.Windows.Forms.Label
        Me.txtStatus = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.PictureBoxVisitorPic = New System.Windows.Forms.PictureBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ID = New System.Windows.Forms.ColumnHeader
        Me.Purpose = New System.Windows.Forms.ColumnHeader
        Me.Destination = New System.Windows.Forms.ColumnHeader
        Me.Description = New System.Windows.Forms.ColumnHeader
        Me.TimeIn = New System.Windows.Forms.ColumnHeader
        Me.TimeOut = New System.Windows.Forms.ColumnHeader
        Me.btnBack = New System.Windows.Forms.PictureBox
        CType(Me.PictureBoxVisitorPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Raleway", 10.0!)
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.Location = New System.Drawing.Point(386, 136)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(241, 23)
        Me.txtAddress.TabIndex = 90
        '
        'txtBirthDate
        '
        Me.txtBirthDate.AutoSize = True
        Me.txtBirthDate.Font = New System.Drawing.Font("Raleway", 10.0!)
        Me.txtBirthDate.ForeColor = System.Drawing.Color.White
        Me.txtBirthDate.Location = New System.Drawing.Point(383, 174)
        Me.txtBirthDate.Name = "txtBirthDate"
        Me.txtBirthDate.Size = New System.Drawing.Size(0, 16)
        Me.txtBirthDate.TabIndex = 89
        '
        'txtPhoneNum
        '
        Me.txtPhoneNum.AutoSize = True
        Me.txtPhoneNum.Font = New System.Drawing.Font("Raleway", 10.0!)
        Me.txtPhoneNum.ForeColor = System.Drawing.Color.White
        Me.txtPhoneNum.Location = New System.Drawing.Point(383, 110)
        Me.txtPhoneNum.Name = "txtPhoneNum"
        Me.txtPhoneNum.Size = New System.Drawing.Size(0, 16)
        Me.txtPhoneNum.TabIndex = 88
        '
        'txtSex
        '
        Me.txtSex.AutoSize = True
        Me.txtSex.Font = New System.Drawing.Font("Raleway", 10.0!)
        Me.txtSex.ForeColor = System.Drawing.Color.White
        Me.txtSex.Location = New System.Drawing.Point(383, 82)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(0, 16)
        Me.txtSex.TabIndex = 87
        '
        'txtName
        '
        Me.txtName.AutoSize = True
        Me.txtName.Font = New System.Drawing.Font("Raleway", 10.0!)
        Me.txtName.ForeColor = System.Drawing.Color.White
        Me.txtName.Location = New System.Drawing.Point(383, 54)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(0, 16)
        Me.txtName.TabIndex = 86
        '
        'txtVisitorID
        '
        Me.txtVisitorID.AutoSize = True
        Me.txtVisitorID.Font = New System.Drawing.Font("Raleway", 10.0!)
        Me.txtVisitorID.ForeColor = System.Drawing.Color.White
        Me.txtVisitorID.Location = New System.Drawing.Point(383, 27)
        Me.txtVisitorID.Name = "txtVisitorID"
        Me.txtVisitorID.Size = New System.Drawing.Size(0, 16)
        Me.txtVisitorID.TabIndex = 85
        '
        'txtStatus
        '
        Me.txtStatus.Font = New System.Drawing.Font("Raleway", 10.0!)
        Me.txtStatus.ForeColor = System.Drawing.Color.Black
        Me.txtStatus.Location = New System.Drawing.Point(386, 205)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(114, 23)
        Me.txtStatus.TabIndex = 84
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Raleway", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(262, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Status:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Raleway", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(262, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Birth Date:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Raleway", 10.0!)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(260, 110)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(110, 16)
        Me.Label13.TabIndex = 81
        Me.Label13.Text = "Phone Number:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Raleway", 10.0!)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(260, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 16)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "Sex:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Raleway", 10.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(260, 139)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 16)
        Me.Label11.TabIndex = 79
        Me.Label11.Text = "Address:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Raleway", 10.0!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(260, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 16)
        Me.Label8.TabIndex = 78
        Me.Label8.Text = "Visitor ID:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Raleway", 10.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(260, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "Name:"
        '
        'PictureBoxVisitorPic
        '
        Me.PictureBoxVisitorPic.BackColor = System.Drawing.Color.White
        Me.PictureBoxVisitorPic.InitialImage = CType(resources.GetObject("PictureBoxVisitorPic.InitialImage"), System.Drawing.Image)
        Me.PictureBoxVisitorPic.Location = New System.Drawing.Point(27, 24)
        Me.PictureBoxVisitorPic.Name = "PictureBoxVisitorPic"
        Me.PictureBoxVisitorPic.Size = New System.Drawing.Size(215, 211)
        Me.PictureBoxVisitorPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxVisitorPic.TabIndex = 76
        Me.PictureBoxVisitorPic.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Purpose, Me.Destination, Me.Description, Me.TimeIn, Me.TimeOut})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(12, 252)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(776, 318)
        Me.ListView1.TabIndex = 91
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "Visit ID"
        Me.ID.Width = 107
        '
        'Purpose
        '
        Me.Purpose.Text = "Purpose"
        Me.Purpose.Width = 245
        '
        'Destination
        '
        Me.Destination.Text = "Destination"
        Me.Destination.Width = 237
        '
        'Description
        '
        Me.Description.Text = "Description"
        Me.Description.Width = 202
        '
        'TimeIn
        '
        Me.TimeIn.Text = "Time-In"
        Me.TimeIn.Width = 202
        '
        'TimeOut
        '
        Me.TimeOut.Text = "Time-Out"
        '
        'btnBack
        '
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Image = Global.Visitor.My.Resources.Resources.previous
        Me.btnBack.Location = New System.Drawing.Point(730, 11)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(58, 48)
        Me.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnBack.TabIndex = 96
        Me.btnBack.TabStop = False
        '
        'VisitHistoryDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 582)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtBirthDate)
        Me.Controls.Add(Me.txtPhoneNum)
        Me.Controls.Add(Me.txtSex)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtVisitorID)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBoxVisitorPic)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VisitHistoryDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VisitHistoryDialog"
        CType(Me.PictureBoxVisitorPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtBirthDate As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNum As System.Windows.Forms.Label
    Friend WithEvents txtSex As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.Label
    Friend WithEvents txtVisitorID As System.Windows.Forms.Label
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBoxVisitorPic As System.Windows.Forms.PictureBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Purpose As System.Windows.Forms.ColumnHeader
    Friend WithEvents Destination As System.Windows.Forms.ColumnHeader
    Friend WithEvents Description As System.Windows.Forms.ColumnHeader
    Friend WithEvents TimeIn As System.Windows.Forms.ColumnHeader
    Friend WithEvents TimeOut As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnBack As System.Windows.Forms.PictureBox
End Class
