<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class userDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LogoutButton = New MetroFramework.Controls.MetroLink()
        Me.labelPosition = New System.Windows.Forms.Label()
        Me.userPicture = New System.Windows.Forms.PictureBox()
        Me.labelLastName = New System.Windows.Forms.Label()
        Me.labelName = New System.Windows.Forms.Label()
        Me.SettingsButton = New MetroFramework.Controls.MetroLink()
        Me.AdmissionButton = New MetroFramework.Controls.MetroLink()
        Me.EnrollmentButton = New MetroFramework.Controls.MetroLink()
        Me.StatusButton = New MetroFramework.Controls.MetroLink()
        Me.dashboardPanel = New System.Windows.Forms.Panel()
        Me.totalSectionsPanel = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.academicYearPanel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.totalEnrolledPanel = New System.Windows.Forms.Panel()
        Me.totalELabel = New System.Windows.Forms.Label()
        Me.totalStudentsPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.userPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dashboardPanel.SuspendLayout()
        Me.totalSectionsPanel.SuspendLayout()
        Me.academicYearPanel.SuspendLayout()
        Me.totalEnrolledPanel.SuspendLayout()
        Me.totalStudentsPanel.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LogoutButton)
        Me.Panel1.Controls.Add(Me.labelPosition)
        Me.Panel1.Controls.Add(Me.userPicture)
        Me.Panel1.Controls.Add(Me.labelLastName)
        Me.Panel1.Controls.Add(Me.labelName)
        Me.Panel1.Controls.Add(Me.SettingsButton)
        Me.Panel1.Controls.Add(Me.AdmissionButton)
        Me.Panel1.Controls.Add(Me.EnrollmentButton)
        Me.Panel1.Controls.Add(Me.StatusButton)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(203, 593)
        Me.Panel1.TabIndex = 0
        '
        'LogoutButton
        '
        Me.LogoutButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogoutButton.ForeColor = System.Drawing.Color.White
        Me.LogoutButton.Image = Global.EnrollmentSystem.My.Resources.Resources.logout
        Me.LogoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogoutButton.ImageSize = 32
        Me.LogoutButton.Location = New System.Drawing.Point(39, 446)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(103, 65)
        Me.LogoutButton.TabIndex = 2
        Me.LogoutButton.Text = "LOGOUT"
        Me.LogoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LogoutButton.UseCustomBackColor = True
        Me.LogoutButton.UseCustomForeColor = True
        Me.LogoutButton.UseSelectable = True
        '
        'labelPosition
        '
        Me.labelPosition.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelPosition.AutoSize = True
        Me.labelPosition.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPosition.ForeColor = System.Drawing.Color.Transparent
        Me.labelPosition.Location = New System.Drawing.Point(46, 167)
        Me.labelPosition.Name = "labelPosition"
        Me.labelPosition.Size = New System.Drawing.Size(69, 18)
        Me.labelPosition.TabIndex = 1
        Me.labelPosition.Text = "Position"
        '
        'userPicture
        '
        Me.userPicture.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.userPicture.Location = New System.Drawing.Point(49, 14)
        Me.userPicture.Name = "userPicture"
        Me.userPicture.Size = New System.Drawing.Size(100, 88)
        Me.userPicture.TabIndex = 0
        Me.userPicture.TabStop = False
        '
        'labelLastName
        '
        Me.labelLastName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelLastName.AutoSize = True
        Me.labelLastName.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelLastName.ForeColor = System.Drawing.Color.Transparent
        Me.labelLastName.Location = New System.Drawing.Point(46, 143)
        Me.labelLastName.Name = "labelLastName"
        Me.labelLastName.Size = New System.Drawing.Size(40, 18)
        Me.labelLastName.TabIndex = 1
        Me.labelLastName.Text = "Last"
        '
        'labelName
        '
        Me.labelName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelName.AutoSize = True
        Me.labelName.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelName.ForeColor = System.Drawing.Color.Transparent
        Me.labelName.Location = New System.Drawing.Point(46, 120)
        Me.labelName.Name = "labelName"
        Me.labelName.Size = New System.Drawing.Size(43, 18)
        Me.labelName.TabIndex = 1
        Me.labelName.Text = "First"
        '
        'SettingsButton
        '
        Me.SettingsButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SettingsButton.ForeColor = System.Drawing.Color.White
        Me.SettingsButton.Image = Global.EnrollmentSystem.My.Resources.Resources.Settings
        Me.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SettingsButton.ImageSize = 32
        Me.SettingsButton.Location = New System.Drawing.Point(39, 385)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(110, 65)
        Me.SettingsButton.TabIndex = 2
        Me.SettingsButton.Text = "SETTINGS"
        Me.SettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SettingsButton.UseCustomBackColor = True
        Me.SettingsButton.UseCustomForeColor = True
        Me.SettingsButton.UseSelectable = True
        '
        'AdmissionButton
        '
        Me.AdmissionButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AdmissionButton.ForeColor = System.Drawing.Color.White
        Me.AdmissionButton.Image = Global.EnrollmentSystem.My.Resources.Resources.reservation_icon
        Me.AdmissionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AdmissionButton.ImageSize = 32
        Me.AdmissionButton.Location = New System.Drawing.Point(39, 263)
        Me.AdmissionButton.Name = "AdmissionButton"
        Me.AdmissionButton.Size = New System.Drawing.Size(122, 65)
        Me.AdmissionButton.TabIndex = 2
        Me.AdmissionButton.Text = "ADMISSION"
        Me.AdmissionButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AdmissionButton.UseCustomBackColor = True
        Me.AdmissionButton.UseCustomForeColor = True
        Me.AdmissionButton.UseSelectable = True
        '
        'EnrollmentButton
        '
        Me.EnrollmentButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EnrollmentButton.ForeColor = System.Drawing.Color.White
        Me.EnrollmentButton.Image = Global.EnrollmentSystem.My.Resources.Resources.enrollment
        Me.EnrollmentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EnrollmentButton.ImageSize = 32
        Me.EnrollmentButton.Location = New System.Drawing.Point(39, 308)
        Me.EnrollmentButton.Name = "EnrollmentButton"
        Me.EnrollmentButton.Size = New System.Drawing.Size(131, 97)
        Me.EnrollmentButton.TabIndex = 2
        Me.EnrollmentButton.Text = "ENROLLMENT"
        Me.EnrollmentButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EnrollmentButton.UseCustomBackColor = True
        Me.EnrollmentButton.UseCustomForeColor = True
        Me.EnrollmentButton.UseSelectable = True
        '
        'StatusButton
        '
        Me.StatusButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatusButton.ForeColor = System.Drawing.Color.White
        Me.StatusButton.Image = Global.EnrollmentSystem.My.Resources.Resources.check_icon
        Me.StatusButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StatusButton.ImageSize = 32
        Me.StatusButton.Location = New System.Drawing.Point(39, 204)
        Me.StatusButton.Name = "StatusButton"
        Me.StatusButton.Size = New System.Drawing.Size(99, 65)
        Me.StatusButton.TabIndex = 2
        Me.StatusButton.Text = "STATUS"
        Me.StatusButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.StatusButton.UseCustomBackColor = True
        Me.StatusButton.UseCustomForeColor = True
        Me.StatusButton.UseSelectable = True
        '
        'dashboardPanel
        '
        Me.dashboardPanel.Controls.Add(Me.totalSectionsPanel)
        Me.dashboardPanel.Controls.Add(Me.academicYearPanel)
        Me.dashboardPanel.Controls.Add(Me.totalEnrolledPanel)
        Me.dashboardPanel.Controls.Add(Me.totalStudentsPanel)
        Me.dashboardPanel.Location = New System.Drawing.Point(201, 90)
        Me.dashboardPanel.Name = "dashboardPanel"
        Me.dashboardPanel.Size = New System.Drawing.Size(955, 500)
        Me.dashboardPanel.TabIndex = 2
        '
        'totalSectionsPanel
        '
        Me.totalSectionsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.totalSectionsPanel.Controls.Add(Me.Label4)
        Me.totalSectionsPanel.Location = New System.Drawing.Point(517, 264)
        Me.totalSectionsPanel.Name = "totalSectionsPanel"
        Me.totalSectionsPanel.Size = New System.Drawing.Size(289, 199)
        Me.totalSectionsPanel.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(70, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "TOTAL SECTIONS"
        '
        'academicYearPanel
        '
        Me.academicYearPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.academicYearPanel.Controls.Add(Me.Label3)
        Me.academicYearPanel.Location = New System.Drawing.Point(148, 264)
        Me.academicYearPanel.Name = "academicYearPanel"
        Me.academicYearPanel.Size = New System.Drawing.Size(289, 199)
        Me.academicYearPanel.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(69, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ACADEMIC YEAR"
        '
        'totalEnrolledPanel
        '
        Me.totalEnrolledPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.totalEnrolledPanel.Controls.Add(Me.totalELabel)
        Me.totalEnrolledPanel.Location = New System.Drawing.Point(517, 39)
        Me.totalEnrolledPanel.Name = "totalEnrolledPanel"
        Me.totalEnrolledPanel.Size = New System.Drawing.Size(289, 199)
        Me.totalEnrolledPanel.TabIndex = 8
        '
        'totalELabel
        '
        Me.totalELabel.AutoSize = True
        Me.totalELabel.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalELabel.ForeColor = System.Drawing.Color.White
        Me.totalELabel.Location = New System.Drawing.Point(60, 134)
        Me.totalELabel.Name = "totalELabel"
        Me.totalELabel.Size = New System.Drawing.Size(168, 25)
        Me.totalELabel.TabIndex = 0
        Me.totalELabel.Text = "TOTAL ENROLLED"
        '
        'totalStudentsPanel
        '
        Me.totalStudentsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.totalStudentsPanel.Controls.Add(Me.Label1)
        Me.totalStudentsPanel.Location = New System.Drawing.Point(148, 40)
        Me.totalStudentsPanel.Name = "totalStudentsPanel"
        Me.totalStudentsPanel.Size = New System.Drawing.Size(289, 199)
        Me.totalStudentsPanel.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(60, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TOTAL STUDENTS"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.PictureBox1)
        Me.Panel6.Location = New System.Drawing.Point(201, -1)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(956, 91)
        Me.Panel6.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(156, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(577, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "PANGANTUCAN COMMUNITY HIGH SCHOOL ENROLLMENT SYSTEM"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EnrollmentSystem.My.Resources.Resources.PCHS_Logo1
        Me.PictureBox1.Location = New System.Drawing.Point(3, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'userDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 591)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.dashboardPanel)
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "userDashboard"
        Me.Text = "Enrollment System"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.userPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dashboardPanel.ResumeLayout(False)
        Me.totalSectionsPanel.ResumeLayout(False)
        Me.totalSectionsPanel.PerformLayout()
        Me.academicYearPanel.ResumeLayout(False)
        Me.academicYearPanel.PerformLayout()
        Me.totalEnrolledPanel.ResumeLayout(False)
        Me.totalEnrolledPanel.PerformLayout()
        Me.totalStudentsPanel.ResumeLayout(False)
        Me.totalStudentsPanel.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LogoutButton As MetroFramework.Controls.MetroLink
    Friend WithEvents SettingsButton As MetroFramework.Controls.MetroLink
    Friend WithEvents EnrollmentButton As MetroFramework.Controls.MetroLink
    Friend WithEvents AdmissionButton As MetroFramework.Controls.MetroLink
    Friend WithEvents StatusButton As MetroFramework.Controls.MetroLink
    Friend WithEvents labelPosition As Label
    Friend WithEvents labelLastName As Label
    Friend WithEvents labelName As Label
    Friend WithEvents userPicture As PictureBox
    Friend WithEvents dashboardPanel As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents totalSectionsPanel As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents academicYearPanel As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents totalEnrolledPanel As Panel
    Friend WithEvents totalELabel As Label
    Friend WithEvents totalStudentsPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class
