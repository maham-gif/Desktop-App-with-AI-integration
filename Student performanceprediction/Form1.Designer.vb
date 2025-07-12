<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.HomeButton1 = New System.Windows.Forms.Button()
        Me.AccountButton2 = New System.Windows.Forms.Button()
        Me.ViewButton = New System.Windows.Forms.Button()
        Me.AnalyzeButton = New System.Windows.Forms.Button()
        Me.NavPanel3 = New System.Windows.Forms.Panel()
        Me.MinButton = New System.Windows.Forms.Button()
        Me.MaximizeButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.slidebarTimer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaGradient2Panel1 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.GunaCircleProgressBar1 = New Guna.UI.WinForms.GunaCircleProgressBar()
        Me.GunaGradient2Panel2 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GunaCircleProgressBar2 = New Guna.UI.WinForms.GunaCircleProgressBar()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GunaVWorstProgressBar1 = New Guna.UI.WinForms.GunaVProgressBar()
        Me.GunaVAverageProgressBar = New Guna.UI.WinForms.GunaVProgressBar()
        Me.GunaVBestProgressBar = New Guna.UI.WinForms.GunaVProgressBar()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.NavPanel3.SuspendLayout()
        Me.GunaGradient2Panel1.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGradient2Panel2.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.AccountButton2)
        Me.FlowLayoutPanel1.Controls.Add(Me.ViewButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.AnalyzeButton)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 2)
        Me.FlowLayoutPanel1.MaximumSize = New System.Drawing.Size(245, 720)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(236, 720)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(214, 106)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(65, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Menu"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 40)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.HomeButton1)
        Me.Panel2.Location = New System.Drawing.Point(3, 115)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(214, 50)
        Me.Panel2.TabIndex = 1
        '
        'HomeButton1
        '
        Me.HomeButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.HomeButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.HomeButton1.FlatAppearance.BorderSize = 0
        Me.HomeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeButton1.ForeColor = System.Drawing.Color.White
        Me.HomeButton1.Image = CType(resources.GetObject("HomeButton1.Image"), System.Drawing.Image)
        Me.HomeButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HomeButton1.Location = New System.Drawing.Point(0, 0)
        Me.HomeButton1.Name = "HomeButton1"
        Me.HomeButton1.Size = New System.Drawing.Size(232, 50)
        Me.HomeButton1.TabIndex = 2
        Me.HomeButton1.Text = "              Home"
        Me.HomeButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HomeButton1.UseVisualStyleBackColor = False
        '
        'AccountButton2
        '
        Me.AccountButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.AccountButton2.FlatAppearance.BorderSize = 0
        Me.AccountButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AccountButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountButton2.ForeColor = System.Drawing.Color.White
        Me.AccountButton2.Image = CType(resources.GetObject("AccountButton2.Image"), System.Drawing.Image)
        Me.AccountButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AccountButton2.Location = New System.Drawing.Point(3, 171)
        Me.AccountButton2.Name = "AccountButton2"
        Me.AccountButton2.Size = New System.Drawing.Size(233, 50)
        Me.AccountButton2.TabIndex = 3
        Me.AccountButton2.Text = "              Account"
        Me.AccountButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AccountButton2.UseVisualStyleBackColor = False
        '
        'ViewButton
        '
        Me.ViewButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ViewButton.FlatAppearance.BorderSize = 0
        Me.ViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewButton.ForeColor = System.Drawing.Color.White
        Me.ViewButton.Image = CType(resources.GetObject("ViewButton.Image"), System.Drawing.Image)
        Me.ViewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ViewButton.Location = New System.Drawing.Point(3, 227)
        Me.ViewButton.Name = "ViewButton"
        Me.ViewButton.Size = New System.Drawing.Size(233, 50)
        Me.ViewButton.TabIndex = 4
        Me.ViewButton.Text = "              View"
        Me.ViewButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ViewButton.UseVisualStyleBackColor = False
        '
        'AnalyzeButton
        '
        Me.AnalyzeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.AnalyzeButton.FlatAppearance.BorderSize = 0
        Me.AnalyzeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AnalyzeButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalyzeButton.ForeColor = System.Drawing.Color.White
        Me.AnalyzeButton.Image = CType(resources.GetObject("AnalyzeButton.Image"), System.Drawing.Image)
        Me.AnalyzeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AnalyzeButton.Location = New System.Drawing.Point(3, 283)
        Me.AnalyzeButton.Name = "AnalyzeButton"
        Me.AnalyzeButton.Size = New System.Drawing.Size(233, 50)
        Me.AnalyzeButton.TabIndex = 5
        Me.AnalyzeButton.TabStop = False
        Me.AnalyzeButton.Text = "              Analyze"
        Me.AnalyzeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AnalyzeButton.UseVisualStyleBackColor = False
        '
        'NavPanel3
        '
        Me.NavPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.NavPanel3.Controls.Add(Me.MinButton)
        Me.NavPanel3.Controls.Add(Me.MaximizeButton)
        Me.NavPanel3.Controls.Add(Me.CloseButton)
        Me.NavPanel3.Controls.Add(Me.Label2)
        Me.NavPanel3.Location = New System.Drawing.Point(3, 2)
        Me.NavPanel3.Name = "NavPanel3"
        Me.NavPanel3.Size = New System.Drawing.Size(1340, 43)
        Me.NavPanel3.TabIndex = 1
        '
        'MinButton
        '
        Me.MinButton.BackgroundImage = CType(resources.GetObject("MinButton.BackgroundImage"), System.Drawing.Image)
        Me.MinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MinButton.FlatAppearance.BorderSize = 0
        Me.MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinButton.Location = New System.Drawing.Point(1218, 3)
        Me.MinButton.Name = "MinButton"
        Me.MinButton.Size = New System.Drawing.Size(23, 23)
        Me.MinButton.TabIndex = 3
        Me.MinButton.UseVisualStyleBackColor = True
        '
        'MaximizeButton
        '
        Me.MaximizeButton.BackgroundImage = CType(resources.GetObject("MaximizeButton.BackgroundImage"), System.Drawing.Image)
        Me.MaximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MaximizeButton.FlatAppearance.BorderSize = 0
        Me.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MaximizeButton.Location = New System.Drawing.Point(1247, 3)
        Me.MaximizeButton.Name = "MaximizeButton"
        Me.MaximizeButton.Size = New System.Drawing.Size(23, 23)
        Me.MaximizeButton.TabIndex = 2
        Me.MaximizeButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.BackgroundImage = CType(resources.GetObject("CloseButton.BackgroundImage"), System.Drawing.Image)
        Me.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Location = New System.Drawing.Point(1276, 3)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(23, 23)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 36)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "                POLAC"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'slidebarTimer1
        '
        Me.slidebarTimer1.Interval = 10
        '
        'GunaGradient2Panel1
        '
        Me.GunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel1.Controls.Add(Me.GunaPictureBox1)
        Me.GunaGradient2Panel1.Controls.Add(Me.Label3)
        Me.GunaGradient2Panel1.Controls.Add(Me.NameLabel)
        Me.GunaGradient2Panel1.GradientColor1 = System.Drawing.Color.DarkOrange
        Me.GunaGradient2Panel1.GradientColor2 = System.Drawing.Color.DarkOrange
        Me.GunaGradient2Panel1.Location = New System.Drawing.Point(242, 51)
        Me.GunaGradient2Panel1.Name = "GunaGradient2Panel1"
        Me.GunaGradient2Panel1.Radius = 10
        Me.GunaGradient2Panel1.Size = New System.Drawing.Size(1081, 100)
        Me.GunaGradient2Panel1.TabIndex = 2
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.ErrorImage = Nothing
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(970, 0)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(131, 102)
        Me.GunaPictureBox1.TabIndex = 0
        Me.GunaPictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(462, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Early detection. Better guidance. Brighter outcomes"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.ForeColor = System.Drawing.Color.White
        Me.NameLabel.Location = New System.Drawing.Point(47, 8)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(88, 33)
        Me.NameLabel.TabIndex = 1
        Me.NameLabel.Text = "POLAC"
        '
        'GunaCircleProgressBar1
        '
        Me.GunaCircleProgressBar1.AnimationSpeed = 0.6!
        Me.GunaCircleProgressBar1.BaseColor = System.Drawing.Color.White
        Me.GunaCircleProgressBar1.IdleColor = System.Drawing.Color.DarkGray
        Me.GunaCircleProgressBar1.IdleOffset = 20
        Me.GunaCircleProgressBar1.IdleThickness = 15
        Me.GunaCircleProgressBar1.Image = Nothing
        Me.GunaCircleProgressBar1.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleProgressBar1.Location = New System.Drawing.Point(259, 414)
        Me.GunaCircleProgressBar1.Name = "GunaCircleProgressBar1"
        Me.GunaCircleProgressBar1.ProgressMaxColor = System.Drawing.Color.Blue
        Me.GunaCircleProgressBar1.ProgressMinColor = System.Drawing.Color.Red
        Me.GunaCircleProgressBar1.ProgressOffset = 20
        Me.GunaCircleProgressBar1.ProgressThickness = 15
        Me.GunaCircleProgressBar1.Size = New System.Drawing.Size(172, 170)
        Me.GunaCircleProgressBar1.TabIndex = 3
        '
        'GunaGradient2Panel2
        '
        Me.GunaGradient2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel2.Controls.Add(Me.Label5)
        Me.GunaGradient2Panel2.Controls.Add(Me.GunaCircleProgressBar2)
        Me.GunaGradient2Panel2.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.GunaGradient2Panel2.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.GunaGradient2Panel2.Location = New System.Drawing.Point(437, 446)
        Me.GunaGradient2Panel2.Name = "GunaGradient2Panel2"
        Me.GunaGradient2Panel2.Radius = 10
        Me.GunaGradient2Panel2.Size = New System.Drawing.Size(408, 100)
        Me.GunaGradient2Panel2.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(258, 33)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Average Performance"
        '
        'GunaCircleProgressBar2
        '
        Me.GunaCircleProgressBar2.AnimationSpeed = 0.6!
        Me.GunaCircleProgressBar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.GunaCircleProgressBar2.BaseColor = System.Drawing.Color.White
        Me.GunaCircleProgressBar2.IdleColor = System.Drawing.Color.DarkGray
        Me.GunaCircleProgressBar2.IdleOffset = 20
        Me.GunaCircleProgressBar2.IdleThickness = 10
        Me.GunaCircleProgressBar2.Image = Nothing
        Me.GunaCircleProgressBar2.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleProgressBar2.Location = New System.Drawing.Point(299, 0)
        Me.GunaCircleProgressBar2.Name = "GunaCircleProgressBar2"
        Me.GunaCircleProgressBar2.ProgressMaxColor = System.Drawing.Color.Blue
        Me.GunaCircleProgressBar2.ProgressMinColor = System.Drawing.Color.Red
        Me.GunaCircleProgressBar2.ProgressOffset = 20
        Me.GunaCircleProgressBar2.ProgressThickness = 5
        Me.GunaCircleProgressBar2.Size = New System.Drawing.Size(109, 103)
        Me.GunaCircleProgressBar2.TabIndex = 4
        '
        'GunaPanel1
        '
        Me.GunaPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GunaPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GunaPanel1.Controls.Add(Me.Label7)
        Me.GunaPanel1.Controls.Add(Me.Panel3)
        Me.GunaPanel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.GunaPanel1.Location = New System.Drawing.Point(968, 361)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(287, 338)
        Me.GunaPanel1.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(57, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(193, 29)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Students Progress"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.GunaVWorstProgressBar1)
        Me.Panel3.Controls.Add(Me.GunaVAverageProgressBar)
        Me.Panel3.Controls.Add(Me.GunaVBestProgressBar)
        Me.Panel3.Location = New System.Drawing.Point(40, 105)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(210, 231)
        Me.Panel3.TabIndex = 0
        '
        'GunaVWorstProgressBar1
        '
        Me.GunaVWorstProgressBar1.BorderColor = System.Drawing.Color.Black
        Me.GunaVWorstProgressBar1.ColorStyle = Guna.UI.WinForms.ColorStyle.[Default]
        Me.GunaVWorstProgressBar1.IdleColor = System.Drawing.Color.Gainsboro
        Me.GunaVWorstProgressBar1.Location = New System.Drawing.Point(170, 23)
        Me.GunaVWorstProgressBar1.Name = "GunaVWorstProgressBar1"
        Me.GunaVWorstProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaVWorstProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaVWorstProgressBar1.Size = New System.Drawing.Size(15, 218)
        Me.GunaVWorstProgressBar1.TabIndex = 2
        '
        'GunaVAverageProgressBar
        '
        Me.GunaVAverageProgressBar.BorderColor = System.Drawing.Color.Black
        Me.GunaVAverageProgressBar.ColorStyle = Guna.UI.WinForms.ColorStyle.[Default]
        Me.GunaVAverageProgressBar.IdleColor = System.Drawing.Color.Gainsboro
        Me.GunaVAverageProgressBar.Location = New System.Drawing.Point(109, 26)
        Me.GunaVAverageProgressBar.Name = "GunaVAverageProgressBar"
        Me.GunaVAverageProgressBar.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaVAverageProgressBar.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaVAverageProgressBar.Size = New System.Drawing.Size(15, 218)
        Me.GunaVAverageProgressBar.TabIndex = 1
        '
        'GunaVBestProgressBar
        '
        Me.GunaVBestProgressBar.BorderColor = System.Drawing.Color.Black
        Me.GunaVBestProgressBar.ColorStyle = Guna.UI.WinForms.ColorStyle.[Default]
        Me.GunaVBestProgressBar.IdleColor = System.Drawing.Color.Gainsboro
        Me.GunaVBestProgressBar.Location = New System.Drawing.Point(41, 26)
        Me.GunaVBestProgressBar.Name = "GunaVBestProgressBar"
        Me.GunaVBestProgressBar.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaVBestProgressBar.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaVBestProgressBar.Size = New System.Drawing.Size(15, 218)
        Me.GunaVBestProgressBar.TabIndex = 0
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BackColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = CType(resources.GetObject("GunaCirclePictureBox1.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(259, 181)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(187, 182)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 7
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(455, 184)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(416, 245)
        Me.Panel4.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(412, 184)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = resources.GetString("Label6.Text")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(285, 46)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "This desktop application is designed" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " to help identify and"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1304, 720)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GunaCirclePictureBox1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.GunaGradient2Panel2)
        Me.Controls.Add(Me.GunaCircleProgressBar1)
        Me.Controls.Add(Me.GunaGradient2Panel1)
        Me.Controls.Add(Me.NavPanel3)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.NavPanel3.ResumeLayout(False)
        Me.NavPanel3.PerformLayout()
        Me.GunaGradient2Panel1.ResumeLayout(False)
        Me.GunaGradient2Panel1.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGradient2Panel2.ResumeLayout(False)
        Me.GunaGradient2Panel2.PerformLayout()
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents HomeButton1 As Button
    Friend WithEvents AccountButton2 As Button
    Friend WithEvents ViewButton As Button
    Friend WithEvents AnalyzeButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents slidebarTimer1 As Timer
    Friend WithEvents NavPanel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents CloseButton As Button
    Friend WithEvents MaximizeButton As Button
    Friend WithEvents MinButton As Button
    Friend WithEvents GunaGradient2Panel1 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GunaCircleProgressBar1 As Guna.UI.WinForms.GunaCircleProgressBar
    Friend WithEvents GunaGradient2Panel2 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents GunaCircleProgressBar2 As Guna.UI.WinForms.GunaCircleProgressBar
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GunaVWorstProgressBar1 As Guna.UI.WinForms.GunaVProgressBar
    Friend WithEvents GunaVAverageProgressBar As Guna.UI.WinForms.GunaVProgressBar
    Friend WithEvents GunaVBestProgressBar As Guna.UI.WinForms.GunaVProgressBar
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
End Class
