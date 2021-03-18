<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAcademicRecord
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.linkAdmClose = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.comboSchoolYear = New System.Windows.Forms.ComboBox()
        Me.comboYearLevel = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textStudentID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colStudID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStudName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStudStr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldStudSection = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStudStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStudGradeLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStudSchYear = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.buttonAddNew = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel1.Controls.Add(Me.linkAdmClose)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(955, 51)
        Me.Panel1.TabIndex = 1
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 37)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ENROLLMENT"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.comboSchoolYear)
        Me.Panel2.Controls.Add(Me.comboYearLevel)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.textStudentID)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(955, 41)
        Me.Panel2.TabIndex = 2
        '
        'comboSchoolYear
        '
        Me.comboSchoolYear.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.comboSchoolYear.FormattingEnabled = True
        Me.comboSchoolYear.Items.AddRange(New Object() {"2021-2022", "2022-2023", "2023-2024", "2024-2025", "2025-2026"})
        Me.comboSchoolYear.Location = New System.Drawing.Point(587, 6)
        Me.comboSchoolYear.Name = "comboSchoolYear"
        Me.comboSchoolYear.Size = New System.Drawing.Size(121, 28)
        Me.comboSchoolYear.TabIndex = 8
        '
        'comboYearLevel
        '
        Me.comboYearLevel.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.comboYearLevel.FormattingEnabled = True
        Me.comboYearLevel.Items.AddRange(New Object() {"Grade 7", "Grade 8", "Grade 9", "Grade 10", "Grade 11", "Grade 12"})
        Me.comboYearLevel.Location = New System.Drawing.Point(807, 6)
        Me.comboYearLevel.Name = "comboYearLevel"
        Me.comboYearLevel.Size = New System.Drawing.Size(134, 28)
        Me.comboYearLevel.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(717, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "YEAR LEVEL:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(477, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "SCHOOL YEAR:"
        '
        'textStudentID
        '
        Me.textStudentID.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.textStudentID.Location = New System.Drawing.Point(134, 6)
        Me.textStudentID.Name = "textStudentID"
        Me.textStudentID.Size = New System.Drawing.Size(300, 25)
        Me.textStudentID.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SEARCH STUDENT:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colStudID, Me.colStudName, Me.colStudStr, Me.coldStudSection, Me.colStudStatus, Me.colStudGradeLevel, Me.colStudSchYear})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 91)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(402, 182)
        Me.DataGridView1.TabIndex = 3
        '
        'colStudID
        '
        Me.colStudID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colStudID.HeaderText = "Student ID"
        Me.colStudID.Name = "colStudID"
        Me.colStudID.ReadOnly = True
        Me.colStudID.Width = 83
        '
        'colStudName
        '
        Me.colStudName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colStudName.HeaderText = "Student Name"
        Me.colStudName.Name = "colStudName"
        Me.colStudName.ReadOnly = True
        '
        'colStudStr
        '
        Me.colStudStr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colStudStr.HeaderText = "Strand"
        Me.colStudStr.Name = "colStudStr"
        Me.colStudStr.ReadOnly = True
        Me.colStudStr.Width = 63
        '
        'coldStudSection
        '
        Me.coldStudSection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.coldStudSection.HeaderText = "Section"
        Me.coldStudSection.Name = "coldStudSection"
        Me.coldStudSection.ReadOnly = True
        Me.coldStudSection.Width = 68
        '
        'colStudStatus
        '
        Me.colStudStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colStudStatus.HeaderText = "Status"
        Me.colStudStatus.Name = "colStudStatus"
        Me.colStudStatus.ReadOnly = True
        Me.colStudStatus.Width = 62
        '
        'colStudGradeLevel
        '
        Me.colStudGradeLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colStudGradeLevel.HeaderText = "Year Level"
        Me.colStudGradeLevel.Name = "colStudGradeLevel"
        Me.colStudGradeLevel.ReadOnly = True
        Me.colStudGradeLevel.Width = 83
        '
        'colStudSchYear
        '
        Me.colStudSchYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colStudSchYear.HeaderText = "School Year"
        Me.colStudSchYear.Name = "colStudSchYear"
        Me.colStudSchYear.ReadOnly = True
        Me.colStudSchYear.Width = 90
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.EnrollmentSystem.My.Resources.Resources.delete2
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(127, 452)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 36)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "DELETE"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.EnrollmentSystem.My.Resources.Resources.requirements1
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(12, 452)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 36)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "UPDATE"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'buttonAddNew
        '
        Me.buttonAddNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonAddNew.Image = Global.EnrollmentSystem.My.Resources.Resources.addnew
        Me.buttonAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonAddNew.Location = New System.Drawing.Point(842, 452)
        Me.buttonAddNew.Name = "buttonAddNew"
        Me.buttonAddNew.Size = New System.Drawing.Size(99, 36)
        Me.buttonAddNew.TabIndex = 4
        Me.buttonAddNew.Text = "ADD NEW"
        Me.buttonAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.buttonAddNew.UseVisualStyleBackColor = True
        '
        'formAcademicRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 500)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.buttonAddNew)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formAcademicRecord"
        Me.Text = "formAcademicRecordViewGrades"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents linkAdmClose As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents textStudentID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents comboSchoolYear As ComboBox
    Friend WithEvents comboYearLevel As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents buttonAddNew As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents colStudID As DataGridViewTextBoxColumn
    Friend WithEvents colStudName As DataGridViewTextBoxColumn
    Friend WithEvents colStudStr As DataGridViewTextBoxColumn
    Friend WithEvents coldStudSection As DataGridViewTextBoxColumn
    Friend WithEvents colStudStatus As DataGridViewTextBoxColumn
    Friend WithEvents colStudGradeLevel As DataGridViewTextBoxColumn
    Friend WithEvents colStudSchYear As DataGridViewTextBoxColumn
End Class
