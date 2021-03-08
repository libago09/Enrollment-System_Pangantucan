<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSettingsSelection
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.buttonSettingsRegisterFaculty = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 43)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SETTINGS"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button2.Image = Global.EnrollmentSystem.My.Resources.Resources.requirements1
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(414, 243)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(172, 45)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "MANAGE FACULTY"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'buttonSettingsRegisterFaculty
        '
        Me.buttonSettingsRegisterFaculty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.buttonSettingsRegisterFaculty.Image = Global.EnrollmentSystem.My.Resources.Resources.folder_users_icon
        Me.buttonSettingsRegisterFaculty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonSettingsRegisterFaculty.Location = New System.Drawing.Point(414, 158)
        Me.buttonSettingsRegisterFaculty.Name = "buttonSettingsRegisterFaculty"
        Me.buttonSettingsRegisterFaculty.Size = New System.Drawing.Size(172, 45)
        Me.buttonSettingsRegisterFaculty.TabIndex = 2
        Me.buttonSettingsRegisterFaculty.Text = "REGISTER FACULTY"
        Me.buttonSettingsRegisterFaculty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.buttonSettingsRegisterFaculty.UseVisualStyleBackColor = True
        '
        'formSettingsSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 500)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.buttonSettingsRegisterFaculty)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formSettingsSelection"
        Me.Text = "formSettingsSelection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents buttonSettingsRegisterFaculty As Button
    Friend WithEvents Button2 As Button
End Class
