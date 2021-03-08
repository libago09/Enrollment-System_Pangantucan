<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formEnrollmentSelection
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.buttonViewGrades = New System.Windows.Forms.Button()
        Me.buttonAddDrop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(353, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 43)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ENROLLMENT"
        '
        'buttonViewGrades
        '
        Me.buttonViewGrades.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonViewGrades.Image = Global.EnrollmentSystem.My.Resources.Resources.requirements1
        Me.buttonViewGrades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonViewGrades.Location = New System.Drawing.Point(391, 130)
        Me.buttonViewGrades.Name = "buttonViewGrades"
        Me.buttonViewGrades.Size = New System.Drawing.Size(144, 43)
        Me.buttonViewGrades.TabIndex = 2
        Me.buttonViewGrades.Text = "VIEW GRADES"
        Me.buttonViewGrades.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.buttonViewGrades.UseVisualStyleBackColor = True
        '
        'buttonAddDrop
        '
        Me.buttonAddDrop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonAddDrop.Image = Global.EnrollmentSystem.My.Resources.Resources.loghistory
        Me.buttonAddDrop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonAddDrop.Location = New System.Drawing.Point(391, 213)
        Me.buttonAddDrop.Name = "buttonAddDrop"
        Me.buttonAddDrop.Size = New System.Drawing.Size(144, 43)
        Me.buttonAddDrop.TabIndex = 2
        Me.buttonAddDrop.Text = "ADD/DROP"
        Me.buttonAddDrop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.buttonAddDrop.UseVisualStyleBackColor = True
        '
        'formEnrollmentSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 500)
        Me.Controls.Add(Me.buttonAddDrop)
        Me.Controls.Add(Me.buttonViewGrades)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formEnrollmentSelection"
        Me.Text = "formEnrollmentSelection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents buttonViewGrades As Button
    Friend WithEvents buttonAddDrop As Button
End Class
