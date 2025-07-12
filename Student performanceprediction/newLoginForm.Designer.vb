<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class newLoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newLoginForm))
        Me.LoginGunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.usernameGunaLineTextBox = New Guna.UI.WinForms.GunaLineTextBox()
        Me.PasswordGunaLineTextBox = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.usernameLabel2 = New System.Windows.Forms.Label()
        Me.PasswordLabel2 = New System.Windows.Forms.Label()
        Me.loginGunaButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoginGunaCircleButton1
        '
        Me.LoginGunaCircleButton1.AnimationHoverSpeed = 0.07!
        Me.LoginGunaCircleButton1.AnimationSpeed = 0.03!
        Me.LoginGunaCircleButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.LoginGunaCircleButton1.BorderColor = System.Drawing.Color.Black
        Me.LoginGunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.LoginGunaCircleButton1.FocusedColor = System.Drawing.Color.Empty
        Me.LoginGunaCircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LoginGunaCircleButton1.ForeColor = System.Drawing.Color.White
        Me.LoginGunaCircleButton1.Image = Nothing
        Me.LoginGunaCircleButton1.ImageSize = New System.Drawing.Size(52, 52)
        Me.LoginGunaCircleButton1.Location = New System.Drawing.Point(-188, -4)
        Me.LoginGunaCircleButton1.Name = "LoginGunaCircleButton1"
        Me.LoginGunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LoginGunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LoginGunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.LoginGunaCircleButton1.OnHoverImage = Nothing
        Me.LoginGunaCircleButton1.OnPressedColor = System.Drawing.Color.Black
        Me.LoginGunaCircleButton1.Size = New System.Drawing.Size(437, 439)
        Me.LoginGunaCircleButton1.TabIndex = 0
        '
        'usernameGunaLineTextBox
        '
        Me.usernameGunaLineTextBox.BackColor = System.Drawing.Color.White
        Me.usernameGunaLineTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usernameGunaLineTextBox.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usernameGunaLineTextBox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameGunaLineTextBox.LineColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.usernameGunaLineTextBox.Location = New System.Drawing.Point(482, 139)
        Me.usernameGunaLineTextBox.Name = "usernameGunaLineTextBox"
        Me.usernameGunaLineTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.usernameGunaLineTextBox.SelectedText = ""
        Me.usernameGunaLineTextBox.Size = New System.Drawing.Size(196, 44)
        Me.usernameGunaLineTextBox.TabIndex = 1
        '
        'PasswordGunaLineTextBox
        '
        Me.PasswordGunaLineTextBox.BackColor = System.Drawing.Color.White
        Me.PasswordGunaLineTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordGunaLineTextBox.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordGunaLineTextBox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordGunaLineTextBox.LineColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.PasswordGunaLineTextBox.Location = New System.Drawing.Point(482, 203)
        Me.PasswordGunaLineTextBox.Name = "PasswordGunaLineTextBox"
        Me.PasswordGunaLineTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordGunaLineTextBox.SelectedText = ""
        Me.PasswordGunaLineTextBox.Size = New System.Drawing.Size(196, 45)
        Me.PasswordGunaLineTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(354, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 39)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Login To Your Account"
        '
        'usernameLabel2
        '
        Me.usernameLabel2.AutoSize = True
        Me.usernameLabel2.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.usernameLabel2.Location = New System.Drawing.Point(327, 162)
        Me.usernameLabel2.Name = "usernameLabel2"
        Me.usernameLabel2.Size = New System.Drawing.Size(131, 33)
        Me.usernameLabel2.TabIndex = 4
        Me.usernameLabel2.Text = "Username"
        '
        'PasswordLabel2
        '
        Me.PasswordLabel2.AutoSize = True
        Me.PasswordLabel2.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.PasswordLabel2.Location = New System.Drawing.Point(332, 223)
        Me.PasswordLabel2.Name = "PasswordLabel2"
        Me.PasswordLabel2.Size = New System.Drawing.Size(122, 33)
        Me.PasswordLabel2.TabIndex = 5
        Me.PasswordLabel2.Text = "Password"
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
        Me.loginGunaButton1.Location = New System.Drawing.Point(432, 275)
        Me.loginGunaButton1.Name = "loginGunaButton1"
        Me.loginGunaButton1.OnHoverBaseColor = System.Drawing.Color.SkyBlue
        Me.loginGunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.loginGunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.loginGunaButton1.OnHoverImage = Nothing
        Me.loginGunaButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.loginGunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.loginGunaButton1.Size = New System.Drawing.Size(167, 38)
        Me.loginGunaButton1.TabIndex = 6
        Me.loginGunaButton1.Text = "Login"
        Me.loginGunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(290, 342)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Don't have an account?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(459, 342)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Register here"
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
        Me.CloseButton.TabIndex = 9
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(33, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 36)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "WELCOME!"
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = CType(resources.GetObject("GunaCirclePictureBox1.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(39, 162)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(120, 120)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 11
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'newLoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(725, 402)
        Me.Controls.Add(Me.GunaCirclePictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.loginGunaButton1)
        Me.Controls.Add(Me.PasswordLabel2)
        Me.Controls.Add(Me.usernameLabel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PasswordGunaLineTextBox)
        Me.Controls.Add(Me.usernameGunaLineTextBox)
        Me.Controls.Add(Me.LoginGunaCircleButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "newLoginForm"
        Me.Text = "newLoginForm"
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginGunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents usernameGunaLineTextBox As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents PasswordGunaLineTextBox As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents usernameLabel2 As Label
    Friend WithEvents PasswordLabel2 As Label
    Friend WithEvents loginGunaButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CloseButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
End Class
