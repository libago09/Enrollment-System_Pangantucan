<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formStatus
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
        Me.totalSectionsPanel = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.academicYearPanel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.totalEnrolledPanel = New System.Windows.Forms.Panel()
        Me.totalELabel = New System.Windows.Forms.Label()
        Me.totalStudentsPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.totalSectionsPanel.SuspendLayout()
        Me.academicYearPanel.SuspendLayout()
        Me.totalEnrolledPanel.SuspendLayout()
        Me.totalStudentsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'totalSectionsPanel
        '
        Me.totalSectionsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.totalSectionsPanel.Controls.Add(Me.Label4)
        Me.totalSectionsPanel.Location = New System.Drawing.Point(523, 259)
        Me.totalSectionsPanel.Name = "totalSectionsPanel"
        Me.totalSectionsPanel.Size = New System.Drawing.Size(289, 197)
        Me.totalSectionsPanel.TabIndex = 2
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
        Me.academicYearPanel.Location = New System.Drawing.Point(154, 259)
        Me.academicYearPanel.Name = "academicYearPanel"
        Me.academicYearPanel.Size = New System.Drawing.Size(289, 197)
        Me.academicYearPanel.TabIndex = 3
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
        Me.totalEnrolledPanel.Location = New System.Drawing.Point(523, 34)
        Me.totalEnrolledPanel.Name = "totalEnrolledPanel"
        Me.totalEnrolledPanel.Size = New System.Drawing.Size(289, 197)
        Me.totalEnrolledPanel.TabIndex = 4
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
        Me.totalStudentsPanel.Location = New System.Drawing.Point(154, 35)
        Me.totalStudentsPanel.Name = "totalStudentsPanel"
        Me.totalStudentsPanel.Size = New System.Drawing.Size(289, 197)
        Me.totalStudentsPanel.TabIndex = 5
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
        'formStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 500)
        Me.Controls.Add(Me.totalSectionsPanel)
        Me.Controls.Add(Me.academicYearPanel)
        Me.Controls.Add(Me.totalEnrolledPanel)
        Me.Controls.Add(Me.totalStudentsPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formStatus"
        Me.Text = "formStatus"
        Me.totalSectionsPanel.ResumeLayout(False)
        Me.totalSectionsPanel.PerformLayout()
        Me.academicYearPanel.ResumeLayout(False)
        Me.academicYearPanel.PerformLayout()
        Me.totalEnrolledPanel.ResumeLayout(False)
        Me.totalEnrolledPanel.PerformLayout()
        Me.totalStudentsPanel.ResumeLayout(False)
        Me.totalStudentsPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents totalSectionsPanel As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents academicYearPanel As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents totalEnrolledPanel As Panel
    Friend WithEvents totalELabel As Label
    Friend WithEvents totalStudentsPanel As Panel
    Friend WithEvents Label1 As Label
End Class
