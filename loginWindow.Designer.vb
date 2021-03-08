<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginWindow))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.passwordTextbox = New System.Windows.Forms.TextBox()
        Me.userIDTextbox = New System.Windows.Forms.TextBox()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.loginCancelButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USER ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(20, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "PASSWORD"
        '
        'passwordTextbox
        '
        Me.passwordTextbox.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.passwordTextbox.Location = New System.Drawing.Point(143, 229)
        Me.passwordTextbox.Name = "passwordTextbox"
        Me.passwordTextbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTextbox.Size = New System.Drawing.Size(169, 27)
        Me.passwordTextbox.TabIndex = 1
        '
        'userIDTextbox
        '
        Me.userIDTextbox.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.userIDTextbox.Location = New System.Drawing.Point(143, 180)
        Me.userIDTextbox.Name = "userIDTextbox"
        Me.userIDTextbox.Size = New System.Drawing.Size(169, 27)
        Me.userIDTextbox.TabIndex = 1
        '
        'loginButton
        '
        Me.loginButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.loginButton.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.loginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.loginButton.Location = New System.Drawing.Point(56, 308)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(97, 39)
        Me.loginButton.TabIndex = 2
        Me.loginButton.Text = "LOGIN"
        Me.loginButton.UseVisualStyleBackColor = False
        '
        'loginCancelButton
        '
        Me.loginCancelButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.loginCancelButton.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.loginCancelButton.Location = New System.Drawing.Point(196, 308)
        Me.loginCancelButton.Name = "loginCancelButton"
        Me.loginCancelButton.Size = New System.Drawing.Size(97, 39)
        Me.loginCancelButton.TabIndex = 2
        Me.loginCancelButton.Text = "CANCEL"
        Me.loginCancelButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(121, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'loginWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(355, 423)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.loginCancelButton)
        Me.Controls.Add(Me.loginButton)
        Me.Controls.Add(Me.userIDTextbox)
        Me.Controls.Add(Me.passwordTextbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "loginWindow"
        Me.Text = "loginWindow"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents passwordTextbox As TextBox
    Friend WithEvents userIDTextbox As TextBox
    Friend WithEvents loginButton As Button
    Friend WithEvents loginCancelButton As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
