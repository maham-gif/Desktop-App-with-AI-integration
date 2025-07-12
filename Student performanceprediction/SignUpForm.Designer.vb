<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUpForm))
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EmailsignupTextBox = New Guna.UI.WinForms.GunaLineTextBox()
        Me.PasswordsignupTextBox = New Guna.UI.WinForms.GunaLineTextBox()
        Me.usernameLabel2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GunaLineTextBox1 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.loginGunaButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaCircleButton1
        '
        Me.GunaCircleButton1.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton1.AnimationSpeed = 0.03!
        Me.GunaCircleButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.GunaCircleButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaCircleButton1.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.Image = Nothing
        Me.GunaCircleButton1.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleButton1.Location = New System.Drawing.Point(-180, -23)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.Size = New System.Drawing.Size(437, 439)
        Me.GunaCircleButton1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(345, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 36)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Create Your Account"
        '
        'EmailsignupTextBox
        '
        Me.EmailsignupTextBox.BackColor = System.Drawing.Color.White
        Me.EmailsignupTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EmailsignupTextBox.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmailsignupTextBox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailsignupTextBox.LineColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.EmailsignupTextBox.Location = New System.Drawing.Point(477, 100)
        Me.EmailsignupTextBox.Name = "EmailsignupTextBox"
        Me.EmailsignupTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EmailsignupTextBox.SelectedText = ""
        Me.EmailsignupTextBox.Size = New System.Drawing.Size(193, 38)
        Me.EmailsignupTextBox.TabIndex = 5
        '
        'PasswordsignupTextBox
        '
        Me.PasswordsignupTextBox.BackColor = System.Drawing.Color.White
        Me.PasswordsignupTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordsignupTextBox.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordsignupTextBox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordsignupTextBox.LineColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.PasswordsignupTextBox.Location = New System.Drawing.Point(477, 144)
        Me.PasswordsignupTextBox.Name = "PasswordsignupTextBox"
        Me.PasswordsignupTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordsignupTextBox.SelectedText = ""
        Me.PasswordsignupTextBox.Size = New System.Drawing.Size(193, 38)
        Me.PasswordsignupTextBox.TabIndex = 6
        '
        'usernameLabel2
        '
        Me.usernameLabel2.AutoSize = True
        Me.usernameLabel2.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.usernameLabel2.Location = New System.Drawing.Point(295, 149)
        Me.usernameLabel2.Name = "usernameLabel2"
        Me.usernameLabel2.Size = New System.Drawing.Size(122, 33)
        Me.usernameLabel2.TabIndex = 7
        Me.usernameLabel2.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(295, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 33)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(263, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(218, 33)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Confirm Password"
        '
        'GunaLineTextBox1
        '
        Me.GunaLineTextBox1.BackColor = System.Drawing.Color.White
        Me.GunaLineTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox1.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaLineTextBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLineTextBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.GunaLineTextBox1.Location = New System.Drawing.Point(477, 188)
        Me.GunaLineTextBox1.Name = "GunaLineTextBox1"
        Me.GunaLineTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.GunaLineTextBox1.SelectedText = ""
        Me.GunaLineTextBox1.Size = New System.Drawing.Size(193, 38)
        Me.GunaLineTextBox1.TabIndex = 10
        '
        'loginGunaButton1
        '
        Me.loginGunaButton1.AnimationHoverSpeed = 0.07!
        Me.loginGunaButton1.AnimationSpeed = 0.03!
        Me.loginGunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.loginGunaButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.loginGunaButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.loginGunaButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.loginGunaButton1.CheckedForeColor = System.Drawing.Color.White
        Me.loginGunaButton1.CheckedImage = CType(resources.GetObject("loginGunaButton1.CheckedImage"), System.Drawing.Image)
        Me.loginGunaButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.loginGunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.loginGunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.loginGunaButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginGunaButton1.ForeColor = System.Drawing.Color.White
        Me.loginGunaButton1.Image = Nothing
        Me.loginGunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.loginGunaButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.loginGunaButton1.Location = New System.Drawing.Point(415, 254)
        Me.loginGunaButton1.Name = "loginGunaButton1"
        Me.loginGunaButton1.OnHoverBaseColor = System.Drawing.Color.SkyBlue
        Me.loginGunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.loginGunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.loginGunaButton1.OnHoverImage = Nothing
        Me.loginGunaButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.loginGunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.loginGunaButton1.Size = New System.Drawing.Size(167, 38)
        Me.loginGunaButton1.TabIndex = 11
        Me.loginGunaButton1.Text = "SignUp"
        Me.loginGunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(281, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Already have an account?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(465, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "login here"
        '
        'CloseButton
        '
        Me.CloseButton.BackgroundImage = CType(resources.GetObject("CloseButton.BackgroundImage"), System.Drawing.Image)
        Me.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Location = New System.Drawing.Point(690, 12)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(23, 23)
        Me.CloseButton.TabIndex = 14
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = CType(resources.GetObject("GunaCirclePictureBox1.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(41, 124)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(120, 120)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 15
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'SignUpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(725, 402)
        Me.Controls.Add(Me.GunaCirclePictureBox1)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.loginGunaButton1)
        Me.Controls.Add(Me.GunaLineTextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.usernameLabel2)
        Me.Controls.Add(Me.PasswordsignupTextBox)
        Me.Controls.Add(Me.EmailsignupTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GunaCircleButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SignUpForm"
        Me.Text = "SignUpForm"
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Label1 As Label
    Friend WithEvents EmailsignupTextBox As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents PasswordsignupTextBox As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents usernameLabel2 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GunaLineTextBox1 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents loginGunaButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CloseButton As Button
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
End Class
