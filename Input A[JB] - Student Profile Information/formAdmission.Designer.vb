<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formAdmission
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
        Me.linkAdmClose = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.comboSchoolYear = New System.Windows.Forms.ComboBox()
        Me.comboStudentType = New System.Windows.Forms.ComboBox()
        Me.comboYearLevel = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textStudentID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.admissionTab = New System.Windows.Forms.TabControl()
        Me.studentTab = New System.Windows.Forms.TabPage()
        Me.labelStudentImage = New System.Windows.Forms.Label()
        Me.buttonStudentPhoto = New System.Windows.Forms.Button()
        Me.pictureStudentPhoto = New System.Windows.Forms.PictureBox()
        Me.comboStudentGender = New System.Windows.Forms.ComboBox()
        Me.dateStudentBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.textStudentPlaceOfBirth = New System.Windows.Forms.TextBox()
        Me.textStudentAge = New System.Windows.Forms.TextBox()
        Me.textStudentMiddleName = New System.Windows.Forms.TextBox()
        Me.textStudentFirstName = New System.Windows.Forms.TextBox()
        Me.textStudentLastName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.studentAddInfo = New System.Windows.Forms.TabPage()
        Me.comboStudentBeneficiary = New System.Windows.Forms.ComboBox()
        Me.textStudentAddress = New System.Windows.Forms.TextBox()
        Me.textStudentCitizenship = New System.Windows.Forms.TextBox()
        Me.textStudentReligion = New System.Windows.Forms.TextBox()
        Me.textStudentEthnicGroup = New System.Windows.Forms.TextBox()
        Me.textStudentContactNumber = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.parentTab = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.textFatherMiddleName = New System.Windows.Forms.TextBox()
        Me.textFatherFirstName = New System.Windows.Forms.TextBox()
        Me.textFatherOccupation = New System.Windows.Forms.TextBox()
        Me.textFatherContactNumber = New System.Windows.Forms.TextBox()
        Me.textFatherLastName = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.textMotherMiddleName = New System.Windows.Forms.TextBox()
        Me.textMotherFirstName = New System.Windows.Forms.TextBox()
        Me.textMotherOccupation = New System.Windows.Forms.TextBox()
        Me.textMotherContactNumber = New System.Windows.Forms.TextBox()
        Me.textMotherLastName = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.guardianTab = New System.Windows.Forms.TabPage()
        Me.textGuardianAddress = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.textGuardianMiddleName = New System.Windows.Forms.TextBox()
        Me.textGuardianFirstName = New System.Windows.Forms.TextBox()
        Me.textGuardianOccupation = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.textGuardianRelationship = New System.Windows.Forms.TextBox()
        Me.textGuardianContactNumber = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.textGuardianLastName = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.admissionCancelButton = New MetroFramework.Controls.MetroLink()
        Me.admissionSaveButton = New MetroFramework.Controls.MetroLink()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.admissionTab.SuspendLayout()
        Me.studentTab.SuspendLayout()
        CType(Me.pictureStudentPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.studentAddInfo.SuspendLayout()
        Me.parentTab.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.guardianTab.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel1.Controls.Add(Me.linkAdmClose)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(955, 51)
        Me.Panel1.TabIndex = 0
        '
        'linkAdmClose
        '
        Me.linkAdmClose.ActiveLinkColor = System.Drawing.Color.White
        Me.linkAdmClose.AutoSize = True
        Me.linkAdmClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkAdmClose.LinkColor = System.Drawing.Color.White
        Me.linkAdmClose.Location = New System.Drawing.Point(882, 14)
        Me.linkAdmClose.Name = "linkAdmClose"
        Me.linkAdmClose.Size = New System.Drawing.Size(61, 20)
        Me.linkAdmClose.TabIndex = 1
        Me.linkAdmClose.TabStop = True
        Me.linkAdmClose.Text = "[close]"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADMISSION"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.comboSchoolYear)
        Me.Panel2.Controls.Add(Me.comboStudentType)
        Me.Panel2.Controls.Add(Me.comboYearLevel)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.textStudentID)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(0, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(955, 41)
        Me.Panel2.TabIndex = 1
        '
        'comboSchoolYear
        '
        Me.comboSchoolYear.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.comboSchoolYear.FormattingEnabled = True
        Me.comboSchoolYear.Items.AddRange(New Object() {"2021-2022", "2022-2023", "2023-2024", "2024-2025", "2025-2026"})
        Me.comboSchoolYear.Location = New System.Drawing.Point(342, 7)
        Me.comboSchoolYear.Name = "comboSchoolYear"
        Me.comboSchoolYear.Size = New System.Drawing.Size(121, 28)
        Me.comboSchoolYear.TabIndex = 4
        '
        'comboStudentType
        '
        Me.comboStudentType.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.comboStudentType.FormattingEnabled = True
        Me.comboStudentType.Items.AddRange(New Object() {"Freshmen", "Transferees", "Returnee"})
        Me.comboStudentType.Location = New System.Drawing.Point(809, 6)
        Me.comboStudentType.Name = "comboStudentType"
        Me.comboStudentType.Size = New System.Drawing.Size(134, 28)
        Me.comboStudentType.TabIndex = 2
        '
        'comboYearLevel
        '
        Me.comboYearLevel.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.comboYearLevel.FormattingEnabled = True
        Me.comboYearLevel.Items.AddRange(New Object() {"Grade 7", "Grade 8", "Grade 9", "Grade 10", "Grade 11", "Grade 12"})
        Me.comboYearLevel.Location = New System.Drawing.Point(562, 7)
        Me.comboYearLevel.Name = "comboYearLevel"
        Me.comboYearLevel.Size = New System.Drawing.Size(134, 28)
        Me.comboYearLevel.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(703, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "STUDENT TYPE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(472, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "YEAR LEVEL:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(232, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SCHOOL YEAR:"
        '
        'textStudentID
        '
        Me.textStudentID.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.textStudentID.Location = New System.Drawing.Point(99, 8)
        Me.textStudentID.Name = "textStudentID"
        Me.textStudentID.Size = New System.Drawing.Size(124, 25)
        Me.textStudentID.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(5, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "STUDENT ID:"
        '
        'admissionTab
        '
        Me.admissionTab.Controls.Add(Me.studentTab)
        Me.admissionTab.Controls.Add(Me.studentAddInfo)
        Me.admissionTab.Controls.Add(Me.parentTab)
        Me.admissionTab.Controls.Add(Me.guardianTab)
        Me.admissionTab.Location = New System.Drawing.Point(0, 90)
        Me.admissionTab.Name = "admissionTab"
        Me.admissionTab.SelectedIndex = 0
        Me.admissionTab.Size = New System.Drawing.Size(955, 372)
        Me.admissionTab.TabIndex = 2
        '
        'studentTab
        '
        Me.studentTab.BackColor = System.Drawing.SystemColors.Control
        Me.studentTab.Controls.Add(Me.labelStudentImage)
        Me.studentTab.Controls.Add(Me.buttonStudentPhoto)
        Me.studentTab.Controls.Add(Me.pictureStudentPhoto)
        Me.studentTab.Controls.Add(Me.comboStudentGender)
        Me.studentTab.Controls.Add(Me.dateStudentBirthDate)
        Me.studentTab.Controls.Add(Me.textStudentPlaceOfBirth)
        Me.studentTab.Controls.Add(Me.textStudentAge)
        Me.studentTab.Controls.Add(Me.textStudentMiddleName)
        Me.studentTab.Controls.Add(Me.textStudentFirstName)
        Me.studentTab.Controls.Add(Me.textStudentLastName)
        Me.studentTab.Controls.Add(Me.Label13)
        Me.studentTab.Controls.Add(Me.Label12)
        Me.studentTab.Controls.Add(Me.Label35)
        Me.studentTab.Controls.Add(Me.Label15)
        Me.studentTab.Controls.Add(Me.Label8)
        Me.studentTab.Controls.Add(Me.Label7)
        Me.studentTab.Controls.Add(Me.Label6)
        Me.studentTab.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentTab.Location = New System.Drawing.Point(4, 22)
        Me.studentTab.Name = "studentTab"
        Me.studentTab.Padding = New System.Windows.Forms.Padding(3)
        Me.studentTab.Size = New System.Drawing.Size(947, 346)
        Me.studentTab.TabIndex = 0
        Me.studentTab.Text = "STUDENT DETAILS"
        '
        'labelStudentImage
        '
        Me.labelStudentImage.AutoSize = True
        Me.labelStudentImage.Location = New System.Drawing.Point(57, 111)
        Me.labelStudentImage.Name = "labelStudentImage"
        Me.labelStudentImage.Size = New System.Drawing.Size(14, 16)
        Me.labelStudentImage.TabIndex = 6
        Me.labelStudentImage.Text = "  "
        '
        'buttonStudentPhoto
        '
        Me.buttonStudentPhoto.Location = New System.Drawing.Point(169, 188)
        Me.buttonStudentPhoto.Name = "buttonStudentPhoto"
        Me.buttonStudentPhoto.Size = New System.Drawing.Size(75, 23)
        Me.buttonStudentPhoto.TabIndex = 5
        Me.buttonStudentPhoto.Text = "Photo"
        Me.buttonStudentPhoto.UseVisualStyleBackColor = True
        '
        'pictureStudentPhoto
        '
        Me.pictureStudentPhoto.Location = New System.Drawing.Point(135, 42)
        Me.pictureStudentPhoto.Name = "pictureStudentPhoto"
        Me.pictureStudentPhoto.Size = New System.Drawing.Size(140, 124)
        Me.pictureStudentPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureStudentPhoto.TabIndex = 4
        Me.pictureStudentPhoto.TabStop = False
        '
        'comboStudentGender
        '
        Me.comboStudentGender.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.comboStudentGender.FormattingEnabled = True
        Me.comboStudentGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.comboStudentGender.Location = New System.Drawing.Point(720, 265)
        Me.comboStudentGender.Name = "comboStudentGender"
        Me.comboStudentGender.Size = New System.Drawing.Size(109, 28)
        Me.comboStudentGender.TabIndex = 3
        '
        'dateStudentBirthDate
        '
        Me.dateStudentBirthDate.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.dateStudentBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateStudentBirthDate.Location = New System.Drawing.Point(573, 171)
        Me.dateStudentBirthDate.MinDate = New Date(1920, 1, 1, 0, 0, 0, 0)
        Me.dateStudentBirthDate.Name = "dateStudentBirthDate"
        Me.dateStudentBirthDate.Size = New System.Drawing.Size(256, 25)
        Me.dateStudentBirthDate.TabIndex = 2
        '
        'textStudentPlaceOfBirth
        '
        Me.textStudentPlaceOfBirth.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.textStudentPlaceOfBirth.Location = New System.Drawing.Point(573, 219)
        Me.textStudentPlaceOfBirth.Name = "textStudentPlaceOfBirth"
        Me.textStudentPlaceOfBirth.Size = New System.Drawing.Size(256, 25)
        Me.textStudentPlaceOfBirth.TabIndex = 1
        '
        'textStudentAge
        '
        Me.textStudentAge.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.textStudentAge.Location = New System.Drawing.Point(575, 266)
        Me.textStudentAge.Name = "textStudentAge"
        Me.textStudentAge.Size = New System.Drawing.Size(65, 25)
        Me.textStudentAge.TabIndex = 1
        '
        'textStudentMiddleName
        '
        Me.textStudentMiddleName.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.textStudentMiddleName.Location = New System.Drawing.Point(573, 124)
        Me.textStudentMiddleName.Name = "textStudentMiddleName"
        Me.textStudentMiddleName.Size = New System.Drawing.Size(256, 25)
        Me.textStudentMiddleName.TabIndex = 1
        '
        'textStudentFirstName
        '
        Me.textStudentFirstName.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.textStudentFirstName.Location = New System.Drawing.Point(573, 83)
        Me.textStudentFirstName.Name = "textStudentFirstName"
        Me.textStudentFirstName.Size = New System.Drawing.Size(256, 25)
        Me.textStudentFirstName.TabIndex = 1
        '
        'textStudentLastName
        '
        Me.textStudentLastName.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.textStudentLastName.Location = New System.Drawing.Point(573, 38)
        Me.textStudentLastName.Name = "textStudentLastName"
        Me.textStudentLastName.Size = New System.Drawing.Size(256, 25)
        Me.textStudentLastName.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(449, 222)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 20)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "PLACE OF BIRTH:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(449, 172)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 20)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "DATE OF BIRTH:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(519, 269)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(40, 20)
        Me.Label35.TabIndex = 0
        Me.Label35.Text = "AGE:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(649, 269)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 20)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "GENDER:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(449, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "MIDDLE NAME:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(449, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "FIRST NAME:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(449, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "LAST NAME:"
        '
        'studentAddInfo
        '
        Me.studentAddInfo.BackColor = System.Drawing.SystemColors.Control
        Me.studentAddInfo.Controls.Add(Me.comboStudentBeneficiary)
        Me.studentAddInfo.Controls.Add(Me.textStudentAddress)
        Me.studentAddInfo.Controls.Add(Me.textStudentCitizenship)
        Me.studentAddInfo.Controls.Add(Me.textStudentReligion)
        Me.studentAddInfo.Controls.Add(Me.textStudentEthnicGroup)
        Me.studentAddInfo.Controls.Add(Me.textStudentContactNumber)
        Me.studentAddInfo.Controls.Add(Me.Label11)
        Me.studentAddInfo.Controls.Add(Me.Label14)
        Me.studentAddInfo.Controls.Add(Me.Label33)
        Me.studentAddInfo.Controls.Add(Me.Label34)
        Me.studentAddInfo.Controls.Add(Me.Label10)
        Me.studentAddInfo.Controls.Add(Me.Label9)
        Me.studentAddInfo.Location = New System.Drawing.Point(4, 22)
        Me.studentAddInfo.Name = "studentAddInfo"
        Me.studentAddInfo.Size = New System.Drawing.Size(947, 346)
        Me.studentAddInfo.TabIndex = 3
        Me.studentAddInfo.Text = "ADDITIONAL INFORMATION"
        '
        'comboStudentBeneficiary
        '
        Me.comboStudentBeneficiary.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.comboStudentBeneficiary.FormattingEnabled = True
        Me.comboStudentBeneficiary.Items.AddRange(New Object() {"4P'S", "INDIGENOUS PEOPLE", "ESC/VOUCHER RECIPIENT"})
        Me.comboStudentBeneficiary.Location = New System.Drawing.Point(193, 138)
        Me.comboStudentBeneficiary.Name = "comboStudentBeneficiary"
        Me.comboStudentBeneficiary.Size = New System.Drawing.Size(256, 28)
        Me.comboStudentBeneficiary.TabIndex = 10
        '
        'textStudentAddress
        '
        Me.textStudentAddress.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.textStudentAddress.Location = New System.Drawing.Point(612, 142)
        Me.textStudentAddress.Multiline = True
        Me.textStudentAddress.Name = "textStudentAddress"
        Me.textStudentAddress.Size = New System.Drawing.Size(256, 116)
        Me.textStudentAddress.TabIndex = 6
        '
        'textStudentCitizenship
        '
        Me.textStudentCitizenship.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.textStudentCitizenship.Location = New System.Drawing.Point(612, 91)
        Me.textStudentCitizenship.Name = "textStudentCitizenship"
        Me.textStudentCitizenship.Size = New System.Drawing.Size(256, 25)
        Me.textStudentCitizenship.TabIndex = 7
        '
        'textStudentReligion
        '
        Me.textStudentReligion.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.textStudentReligion.Location = New System.Drawing.Point(193, 90)
        Me.textStudentReligion.Name = "textStudentReligion"
        Me.textStudentReligion.Size = New System.Drawing.Size(256, 25)
        Me.textStudentReligion.TabIndex = 8
        '
        'textStudentEthnicGroup
        '
        Me.textStudentEthnicGroup.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.textStudentEthnicGroup.Location = New System.Drawing.Point(193, 43)
        Me.textStudentEthnicGroup.Name = "textStudentEthnicGroup"
        Me.textStudentEthnicGroup.Size = New System.Drawing.Size(256, 25)
        Me.textStudentEthnicGroup.TabIndex = 9
        '
        'textStudentContactNumber
        '
        Me.textStudentContactNumber.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.textStudentContactNumber.Location = New System.Drawing.Point(612, 43)
        Me.textStudentContactNumber.Name = "textStudentContactNumber"
        Me.textStudentContactNumber.Size = New System.Drawing.Size(256, 25)
        Me.textStudentContactNumber.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(468, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 20)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "CITIZENSHIP:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(468, 141)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(146, 20)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "COMPLETE ADDRESS:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(72, 45)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(109, 20)
        Me.Label33.TabIndex = 5
        Me.Label33.Text = "ETHNIC GROUP:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(72, 141)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(98, 20)
        Me.Label34.TabIndex = 4
        Me.Label34.Text = "BENEFICIARY:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(72, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 20)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "RELIGION:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(468, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 20)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "CONTACT NUMBER:"
        '
        'parentTab
        '
        Me.parentTab.BackColor = System.Drawing.SystemColors.Control
        Me.parentTab.Controls.Add(Me.GroupBox2)
        Me.parentTab.Controls.Add(Me.GroupBox1)
        Me.parentTab.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.parentTab.Location = New System.Drawing.Point(4, 22)
        Me.parentTab.Name = "parentTab"
        Me.parentTab.Padding = New System.Windows.Forms.Padding(3)
        Me.parentTab.Size = New System.Drawing.Size(947, 346)
        Me.parentTab.TabIndex = 1
        Me.parentTab.Text = "PARENT DETAILS"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.textFatherMiddleName)
        Me.GroupBox2.Controls.Add(Me.textFatherFirstName)
        Me.GroupBox2.Controls.Add(Me.textFatherOccupation)
        Me.GroupBox2.Controls.Add(Me.textFatherContactNumber)
        Me.GroupBox2.Controls.Add(Me.textFatherLastName)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Location = New System.Drawing.Point(484, 36)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(443, 258)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FATHER'S DETAIL"
        '
        'textFatherMiddleName
        '
        Me.textFatherMiddleName.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.textFatherMiddleName.Location = New System.Drawing.Point(159, 119)
        Me.textFatherMiddleName.Name = "textFatherMiddleName"
        Me.textFatherMiddleName.Size = New System.Drawing.Size(256, 25)
        Me.textFatherMiddleName.TabIndex = 7
        '
        'textFatherFirstName
        '
        Me.textFatherFirstName.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.textFatherFirstName.Location = New System.Drawing.Point(159, 77)
        Me.textFatherFirstName.Name = "textFatherFirstName"
        Me.textFatherFirstName.Size = New System.Drawing.Size(256, 25)
        Me.textFatherFirstName.TabIndex = 8
        '
        'textFatherOccupation
        '
        Me.textFatherOccupation.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.textFatherOccupation.Location = New System.Drawing.Point(159, 160)
        Me.textFatherOccupation.Name = "textFatherOccupation"
        Me.textFatherOccupation.Size = New System.Drawing.Size(256, 25)
        Me.textFatherOccupation.TabIndex = 9
        '
        'textFatherContactNumber
        '
        Me.textFatherContactNumber.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.textFatherContactNumber.Location = New System.Drawing.Point(159, 208)
        Me.textFatherContactNumber.Name = "textFatherContactNumber"
        Me.textFatherContactNumber.Size = New System.Drawing.Size(256, 25)
        Me.textFatherContactNumber.TabIndex = 10
        '
        'textFatherLastName
        '
        Me.textFatherLastName.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.textFatherLastName.Location = New System.Drawing.Point(159, 33)
        Me.textFatherLastName.Name = "textFatherLastName"
        Me.textFatherLastName.Size = New System.Drawing.Size(256, 25)
        Me.textFatherLastName.TabIndex = 11
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(18, 162)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(98, 20)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "OCCUPATION:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(18, 122)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(102, 20)
        Me.Label22.TabIndex = 3
        Me.Label22.Text = "MIDDLE NAME:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(15, 210)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(133, 20)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "CONTACT NUMBER:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(18, 79)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(90, 20)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "FIRST NAME:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(18, 33)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(86, 20)
        Me.Label25.TabIndex = 6
        Me.Label25.Text = "LAST NAME:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.textMotherMiddleName)
        Me.GroupBox1.Controls.Add(Me.textMotherFirstName)
        Me.GroupBox1.Controls.Add(Me.textMotherOccupation)
        Me.GroupBox1.Controls.Add(Me.textMotherContactNumber)
        Me.GroupBox1.Controls.Add(Me.textMotherLastName)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 258)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MOTHER'S DETAIL"
        '
        'textMotherMiddleName
        '
        Me.textMotherMiddleName.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.textMotherMiddleName.Location = New System.Drawing.Point(159, 119)
        Me.textMotherMiddleName.Name = "textMotherMiddleName"
        Me.textMotherMiddleName.Size = New System.Drawing.Size(256, 25)
        Me.textMotherMiddleName.TabIndex = 7
        '
        'textMotherFirstName
        '
        Me.textMotherFirstName.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.textMotherFirstName.Location = New System.Drawing.Point(159, 77)
        Me.textMotherFirstName.Name = "textMotherFirstName"
        Me.textMotherFirstName.Size = New System.Drawing.Size(256, 25)
        Me.textMotherFirstName.TabIndex = 8
        '
        'textMotherOccupation
        '
        Me.textMotherOccupation.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.textMotherOccupation.Location = New System.Drawing.Point(159, 160)
        Me.textMotherOccupation.Name = "textMotherOccupation"
        Me.textMotherOccupation.Size = New System.Drawing.Size(256, 25)
        Me.textMotherOccupation.TabIndex = 9
        '
        'textMotherContactNumber
        '
        Me.textMotherContactNumber.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.textMotherContactNumber.Location = New System.Drawing.Point(159, 208)
        Me.textMotherContactNumber.Name = "textMotherContactNumber"
        Me.textMotherContactNumber.Size = New System.Drawing.Size(256, 25)
        Me.textMotherContactNumber.TabIndex = 10
        '
        'textMotherLastName
        '
        Me.textMotherLastName.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.textMotherLastName.Location = New System.Drawing.Point(159, 33)
        Me.textMotherLastName.Name = "textMotherLastName"
        Me.textMotherLastName.Size = New System.Drawing.Size(256, 25)
        Me.textMotherLastName.TabIndex = 11
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(18, 162)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 20)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "OCCUPATION:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(18, 122)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(102, 20)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "MIDDLE NAME:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(15, 210)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(133, 20)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "CONTACT NUMBER:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(18, 79)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(90, 20)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "FIRST NAME:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(18, 33)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(86, 20)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "LAST NAME:"
        '
        'guardianTab
        '
        Me.guardianTab.BackColor = System.Drawing.SystemColors.Control
        Me.guardianTab.Controls.Add(Me.textGuardianAddress)
        Me.guardianTab.Controls.Add(Me.Label32)
        Me.guardianTab.Controls.Add(Me.textGuardianMiddleName)
        Me.guardianTab.Controls.Add(Me.textGuardianFirstName)
        Me.guardianTab.Controls.Add(Me.textGuardianOccupation)
        Me.guardianTab.Controls.Add(Me.Label30)
        Me.guardianTab.Controls.Add(Me.textGuardianRelationship)
        Me.guardianTab.Controls.Add(Me.textGuardianContactNumber)
        Me.guardianTab.Controls.Add(Me.Label29)
        Me.guardianTab.Controls.Add(Me.textGuardianLastName)
        Me.guardianTab.Controls.Add(Me.Label31)
        Me.guardianTab.Controls.Add(Me.Label28)
        Me.guardianTab.Controls.Add(Me.Label26)
        Me.guardianTab.Controls.Add(Me.Label27)
        Me.guardianTab.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.guardianTab.Location = New System.Drawing.Point(4, 22)
        Me.guardianTab.Name = "guardianTab"
        Me.guardianTab.Size = New System.Drawing.Size(947, 346)
        Me.guardianTab.TabIndex = 2
        Me.guardianTab.Text = "GUARDIAN DETAILS"
        '
        'textGuardianAddress
        '
        Me.textGuardianAddress.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.textGuardianAddress.Location = New System.Drawing.Point(620, 108)
        Me.textGuardianAddress.Multiline = True
        Me.textGuardianAddress.Name = "textGuardianAddress"
        Me.textGuardianAddress.Size = New System.Drawing.Size(256, 106)
        Me.textGuardianAddress.TabIndex = 13
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(476, 107)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(146, 20)
        Me.Label32.TabIndex = 12
        Me.Label32.Text = "COMPLETE ADDRESS:"
        '
        'textGuardianMiddleName
        '
        Me.textGuardianMiddleName.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.textGuardianMiddleName.Location = New System.Drawing.Point(196, 148)
        Me.textGuardianMiddleName.Name = "textGuardianMiddleName"
        Me.textGuardianMiddleName.Size = New System.Drawing.Size(256, 25)
        Me.textGuardianMiddleName.TabIndex = 7
        '
        'textGuardianFirstName
        '
        Me.textGuardianFirstName.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.textGuardianFirstName.Location = New System.Drawing.Point(196, 106)
        Me.textGuardianFirstName.Name = "textGuardianFirstName"
        Me.textGuardianFirstName.Size = New System.Drawing.Size(256, 25)
        Me.textGuardianFirstName.TabIndex = 8
        '
        'textGuardianOccupation
        '
        Me.textGuardianOccupation.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.textGuardianOccupation.Location = New System.Drawing.Point(196, 189)
        Me.textGuardianOccupation.Name = "textGuardianOccupation"
        Me.textGuardianOccupation.Size = New System.Drawing.Size(256, 25)
        Me.textGuardianOccupation.TabIndex = 9
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(55, 62)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(86, 20)
        Me.Label30.TabIndex = 6
        Me.Label30.Text = "LAST NAME:"
        '
        'textGuardianRelationship
        '
        Me.textGuardianRelationship.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.textGuardianRelationship.Location = New System.Drawing.Point(620, 63)
        Me.textGuardianRelationship.Name = "textGuardianRelationship"
        Me.textGuardianRelationship.Size = New System.Drawing.Size(256, 25)
        Me.textGuardianRelationship.TabIndex = 10
        '
        'textGuardianContactNumber
        '
        Me.textGuardianContactNumber.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.textGuardianContactNumber.Location = New System.Drawing.Point(196, 237)
        Me.textGuardianContactNumber.Name = "textGuardianContactNumber"
        Me.textGuardianContactNumber.Size = New System.Drawing.Size(256, 25)
        Me.textGuardianContactNumber.TabIndex = 10
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(55, 108)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(90, 20)
        Me.Label29.TabIndex = 5
        Me.Label29.Text = "FIRST NAME:"
        '
        'textGuardianLastName
        '
        Me.textGuardianLastName.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.textGuardianLastName.Location = New System.Drawing.Point(196, 62)
        Me.textGuardianLastName.Name = "textGuardianLastName"
        Me.textGuardianLastName.Size = New System.Drawing.Size(256, 25)
        Me.textGuardianLastName.TabIndex = 11
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(476, 64)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(107, 20)
        Me.Label31.TabIndex = 4
        Me.Label31.Text = "RELATIONSHIP:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(52, 239)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(133, 20)
        Me.Label28.TabIndex = 4
        Me.Label28.Text = "CONTACT NUMBER:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(55, 191)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(98, 20)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "OCCUPATION:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(55, 151)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(102, 20)
        Me.Label27.TabIndex = 3
        Me.Label27.Text = "MIDDLE NAME:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel3.Controls.Add(Me.admissionCancelButton)
        Me.Panel3.Controls.Add(Me.admissionSaveButton)
        Me.Panel3.Location = New System.Drawing.Point(0, 465)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(955, 37)
        Me.Panel3.TabIndex = 3
        '
        'admissionCancelButton
        '
        Me.admissionCancelButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.admissionCancelButton.ForeColor = System.Drawing.Color.White
        Me.admissionCancelButton.Image = Global.EnrollmentSystem.My.Resources.Resources.x_icon
        Me.admissionCancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.admissionCancelButton.ImageSize = 20
        Me.admissionCancelButton.Location = New System.Drawing.Point(857, 0)
        Me.admissionCancelButton.Name = "admissionCancelButton"
        Me.admissionCancelButton.Size = New System.Drawing.Size(73, 37)
        Me.admissionCancelButton.TabIndex = 4
        Me.admissionCancelButton.Text = "CANCEL"
        Me.admissionCancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.admissionCancelButton.UseCustomBackColor = True
        Me.admissionCancelButton.UseCustomForeColor = True
        Me.admissionCancelButton.UseSelectable = True
        '
        'admissionSaveButton
        '
        Me.admissionSaveButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.admissionSaveButton.ForeColor = System.Drawing.Color.White
        Me.admissionSaveButton.Image = Global.EnrollmentSystem.My.Resources.Resources.check_icon
        Me.admissionSaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.admissionSaveButton.ImageSize = 20
        Me.admissionSaveButton.Location = New System.Drawing.Point(773, 0)
        Me.admissionSaveButton.Name = "admissionSaveButton"
        Me.admissionSaveButton.Size = New System.Drawing.Size(60, 37)
        Me.admissionSaveButton.TabIndex = 4
        Me.admissionSaveButton.Text = "SAVE"
        Me.admissionSaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.admissionSaveButton.UseCustomBackColor = True
        Me.admissionSaveButton.UseCustomForeColor = True
        Me.admissionSaveButton.UseSelectable = True
        '
        'formAdmission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 500)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.admissionTab)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formAdmission"
        Me.Text = "formAdmission"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.admissionTab.ResumeLayout(False)
        Me.studentTab.ResumeLayout(False)
        Me.studentTab.PerformLayout()
        CType(Me.pictureStudentPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.studentAddInfo.ResumeLayout(False)
        Me.studentAddInfo.PerformLayout()
        Me.parentTab.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.guardianTab.ResumeLayout(False)
        Me.guardianTab.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents linkAdmClose As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents comboStudentType As ComboBox
    Friend WithEvents comboYearLevel As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents textStudentID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents admissionTab As TabControl
    Friend WithEvents studentTab As TabPage
    Friend WithEvents comboStudentGender As ComboBox
    Friend WithEvents dateStudentBirthDate As DateTimePicker
    Friend WithEvents textStudentPlaceOfBirth As TextBox
    Friend WithEvents textStudentMiddleName As TextBox
    Friend WithEvents textStudentFirstName As TextBox
    Friend WithEvents textStudentLastName As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents parentTab As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents textFatherMiddleName As TextBox
    Friend WithEvents textFatherFirstName As TextBox
    Friend WithEvents textFatherOccupation As TextBox
    Friend WithEvents textFatherContactNumber As TextBox
    Friend WithEvents textFatherLastName As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents textMotherMiddleName As TextBox
    Friend WithEvents textMotherFirstName As TextBox
    Friend WithEvents textMotherOccupation As TextBox
    Friend WithEvents textMotherContactNumber As TextBox
    Friend WithEvents textMotherLastName As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents guardianTab As TabPage
    Friend WithEvents textGuardianAddress As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents textGuardianMiddleName As TextBox
    Friend WithEvents textGuardianFirstName As TextBox
    Friend WithEvents textGuardianOccupation As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents textGuardianRelationship As TextBox
    Friend WithEvents textGuardianContactNumber As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents textGuardianLastName As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents admissionSaveButton As MetroFramework.Controls.MetroLink
    Friend WithEvents admissionCancelButton As MetroFramework.Controls.MetroLink
    Friend WithEvents studentAddInfo As TabPage
    Friend WithEvents buttonStudentPhoto As Button
    Friend WithEvents pictureStudentPhoto As PictureBox
    Friend WithEvents textStudentAge As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents comboStudentBeneficiary As ComboBox
    Friend WithEvents textStudentAddress As TextBox
    Friend WithEvents textStudentCitizenship As TextBox
    Friend WithEvents textStudentReligion As TextBox
    Friend WithEvents textStudentEthnicGroup As TextBox
    Friend WithEvents textStudentContactNumber As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents comboSchoolYear As ComboBox
    Friend WithEvents labelStudentImage As Label
End Class
