<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Clock = New System.Windows.Forms.Timer(Me.components)
        Me.txtDate = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnReports = New System.Windows.Forms.PictureBox
        Me.btnMasterList = New System.Windows.Forms.PictureBox
        Me.btnCurrent = New System.Windows.Forms.PictureBox
        Me.btnApproval = New System.Windows.Forms.PictureBox
        Me.btnRegister = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnSignOut = New System.Windows.Forms.Button
        CType(Me.btnReports, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMasterList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCurrent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnApproval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRegister, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bebas Neue Bold", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(131, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Visitors Tracking Information System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Old English Text MT", 16.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(130, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 27)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "San Beda College Alabang"
        '
        'Clock
        '
        '
        'txtDate
        '
        Me.txtDate.AutoSize = True
        Me.txtDate.Font = New System.Drawing.Font("Raleway", 15.0!)
        Me.txtDate.ForeColor = System.Drawing.Color.White
        Me.txtDate.Location = New System.Drawing.Point(35, 561)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(114, 24)
        Me.txtDate.TabIndex = 46
        Me.txtDate.Text = "Date Today"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Raleway", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(81, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 22)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Register"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Raleway", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(227, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 22)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Approval"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Raleway", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(53, 377)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 22)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Current Visitors"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Raleway", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(217, 377)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 22)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Master List"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Raleway", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(157, 511)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 22)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Reports"
        '
        'btnReports
        '
        Me.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReports.Image = Global.Visitor.My.Resources.Resources.Reports
        Me.btnReports.Location = New System.Drawing.Point(146, 415)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(100, 89)
        Me.btnReports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnReports.TabIndex = 56
        Me.btnReports.TabStop = False
        '
        'btnMasterList
        '
        Me.btnMasterList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMasterList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMasterList.Image = Global.Visitor.My.Resources.Resources.MasterList
        Me.btnMasterList.Location = New System.Drawing.Point(220, 281)
        Me.btnMasterList.Name = "btnMasterList"
        Me.btnMasterList.Size = New System.Drawing.Size(100, 89)
        Me.btnMasterList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMasterList.TabIndex = 54
        Me.btnMasterList.TabStop = False
        '
        'btnCurrent
        '
        Me.btnCurrent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCurrent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCurrent.Image = Global.Visitor.My.Resources.Resources.Current
        Me.btnCurrent.Location = New System.Drawing.Point(73, 281)
        Me.btnCurrent.Name = "btnCurrent"
        Me.btnCurrent.Size = New System.Drawing.Size(100, 89)
        Me.btnCurrent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCurrent.TabIndex = 52
        Me.btnCurrent.TabStop = False
        '
        'btnApproval
        '
        Me.btnApproval.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnApproval.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApproval.Image = Global.Visitor.My.Resources.Resources.Approval
        Me.btnApproval.Location = New System.Drawing.Point(220, 158)
        Me.btnApproval.Name = "btnApproval"
        Me.btnApproval.Size = New System.Drawing.Size(100, 89)
        Me.btnApproval.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnApproval.TabIndex = 50
        Me.btnApproval.TabStop = False
        '
        'btnRegister
        '
        Me.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegister.Image = Global.Visitor.My.Resources.Resources.Register
        Me.btnRegister.Location = New System.Drawing.Point(73, 158)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(100, 89)
        Me.btnRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnRegister.TabIndex = 49
        Me.btnRegister.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Visitor.My.Resources.Resources.circular_clock
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(9, 561)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox2.TabIndex = 47
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'btnSignOut
        '
        Me.btnSignOut.Font = New System.Drawing.Font("Raleway", 13.0!)
        Me.btnSignOut.Location = New System.Drawing.Point(288, 104)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(100, 30)
        Me.btnSignOut.TabIndex = 58
        Me.btnSignOut.Text = "Sign-Out"
        Me.btnSignOut.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 600)
        Me.Controls.Add(Me.btnSignOut)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnMasterList)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCurrent)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnApproval)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenu"
        CType(Me.btnReports, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMasterList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCurrent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnApproval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRegister, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Clock As System.Windows.Forms.Timer
    Friend WithEvents txtDate As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnRegister As System.Windows.Forms.PictureBox
    Friend WithEvents btnApproval As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCurrent As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnMasterList As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnReports As System.Windows.Forms.PictureBox
    Friend WithEvents btnSignOut As System.Windows.Forms.Button
End Class
