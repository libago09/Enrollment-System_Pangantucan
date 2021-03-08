<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.textIDNumber = New System.Windows.Forms.TextBox()
        Me.textPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.imgCancelButton = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.imgLoginButton = New System.Windows.Forms.PictureBox()
        CType(Me.imgCancelButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLoginButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(77, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "STUDENT ENROLLMENT SYSTEM"
        '
        'textIDNumber
        '
        Me.textIDNumber.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.textIDNumber.Location = New System.Drawing.Point(148, 251)
        Me.textIDNumber.Name = "textIDNumber"
        Me.textIDNumber.Size = New System.Drawing.Size(142, 25)
        Me.textIDNumber.TabIndex = 2
        '
        'textPassword
        '
        Me.textPassword.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.textPassword.Location = New System.Drawing.Point(148, 291)
        Me.textPassword.Name = "textPassword"
        Me.textPassword.Size = New System.Drawing.Size(142, 25)
        Me.textPassword.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(58, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ID NUMBER:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(58, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PASSWORD:"
        '
        'imgCancelButton
        '
        Me.imgCancelButton.Image = Global.EnrollmentSystem.My.Resources.Resources.x_icon1
        Me.imgCancelButton.Location = New System.Drawing.Point(215, 338)
        Me.imgCancelButton.Name = "imgCancelButton"
        Me.imgCancelButton.Size = New System.Drawing.Size(44, 42)
        Me.imgCancelButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgCancelButton.TabIndex = 4
        Me.imgCancelButton.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EnrollmentSystem.My.Resources.Resources.PCHS_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(80, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(210, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'imgLoginButton
        '
        Me.imgLoginButton.Image = Global.EnrollmentSystem.My.Resources.Resources.check_icon
        Me.imgLoginButton.Location = New System.Drawing.Point(113, 338)
        Me.imgLoginButton.Name = "imgLoginButton"
        Me.imgLoginButton.Size = New System.Drawing.Size(44, 42)
        Me.imgLoginButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgLoginButton.TabIndex = 4
        Me.imgLoginButton.TabStop = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(373, 428)
        Me.Controls.Add(Me.imgLoginButton)
        Me.Controls.Add(Me.imgCancelButton)
        Me.Controls.Add(Me.textPassword)
        Me.Controls.Add(Me.textIDNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.Text = "login"
        CType(Me.imgCancelButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLoginButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents textIDNumber As TextBox
    Friend WithEvents textPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents imgCancelButton As PictureBox
    Friend WithEvents imgLoginButton As PictureBox
End Class
