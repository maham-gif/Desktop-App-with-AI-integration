<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentProfileForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentProfileForm))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.HomeButton1 = New System.Windows.Forms.Button()
        Me.AccountButton2 = New System.Windows.Forms.Button()
        Me.ViewButton = New System.Windows.Forms.Button()
        Me.AnalyzeButton = New System.Windows.Forms.Button()
        Me.slidebarTimer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NavPanel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MaximizeButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.MinButton = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.AcademicPanel = New Guna.UI.WinForms.GunaPanel()
        Me.MotivationTextBox1 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.ExamScoreTextBox = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.ParentalEducationComboBox = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.SchoolInfoTextBox = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanelStudy = New Guna.UI.WinForms.GunaPanel()
        Me.TutoringTextBox = New Guna.UI.WinForms.GunaLineTextBox()
        Me.SleepHoursTextBox = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel12 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel13 = New Guna.UI.WinForms.GunaLabel()
        Me.HoursStudyTextBox = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel14 = New Guna.UI.WinForms.GunaLabel()
        Me.NextButton1 = New System.Windows.Forms.Button()
        Me.PersonalInfoGunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.SchoolComboBox = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaStudentPictureBox = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaComboBox1 = New Guna.UI.WinForms.GunaComboBox()
        Me.AgeTextBox = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.nameGunaTextBox = New Guna.UI.WinForms.GunaLineTextBox()
        Me.NameLabel = New Guna.UI.WinForms.GunaLabel()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.NavPanel3.SuspendLayout()
        Me.AcademicPanel.SuspendLayout()
        Me.GunaPanelStudy.SuspendLayout()
        Me.PersonalInfoGunaPanel1.SuspendLayout()
        CType(Me.GunaStudentPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(1, 1)
        Me.FlowLayoutPanel1.MaximumSize = New System.Drawing.Size(245, 720)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(236, 720)
        Me.FlowLayoutPanel1.TabIndex = 1
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
        'slidebarTimer1
        '
        Me.slidebarTimer1.Interval = 10
        '
        'NavPanel3
        '
        Me.NavPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.NavPanel3.Controls.Add(Me.Label2)
        Me.NavPanel3.Controls.Add(Me.MaximizeButton)
        Me.NavPanel3.Controls.Add(Me.CloseButton)
        Me.NavPanel3.Controls.Add(Me.MinButton)
        Me.NavPanel3.Location = New System.Drawing.Point(1, -1)
        Me.NavPanel3.Name = "NavPanel3"
        Me.NavPanel3.Size = New System.Drawing.Size(1390, 43)
        Me.NavPanel3.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label2.Location = New System.Drawing.Point(3, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 36)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "                POLAC"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MaximizeButton
        '
        Me.MaximizeButton.BackgroundImage = CType(resources.GetObject("MaximizeButton.BackgroundImage"), System.Drawing.Image)
        Me.MaximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MaximizeButton.FlatAppearance.BorderSize = 0
        Me.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MaximizeButton.Location = New System.Drawing.Point(1300, 7)
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
        Me.CloseButton.Location = New System.Drawing.Point(1329, 5)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(23, 23)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'MinButton
        '
        Me.MinButton.BackgroundImage = CType(resources.GetObject("MinButton.BackgroundImage"), System.Drawing.Image)
        Me.MinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MinButton.FlatAppearance.BorderSize = 0
        Me.MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinButton.Location = New System.Drawing.Point(1271, 7)
        Me.MinButton.Name = "MinButton"
        Me.MinButton.Size = New System.Drawing.Size(23, 23)
        Me.MinButton.TabIndex = 6
        Me.MinButton.UseVisualStyleBackColor = True
        '
        'AcademicPanel
        '
        Me.AcademicPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AcademicPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AcademicPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AcademicPanel.Controls.Add(Me.MotivationTextBox1)
        Me.AcademicPanel.Controls.Add(Me.ExamScoreTextBox)
        Me.AcademicPanel.Controls.Add(Me.GunaLabel7)
        Me.AcademicPanel.Controls.Add(Me.GunaLabel5)
        Me.AcademicPanel.Controls.Add(Me.GunaLabel6)
        Me.AcademicPanel.Controls.Add(Me.ParentalEducationComboBox)
        Me.AcademicPanel.Controls.Add(Me.GunaLabel8)
        Me.AcademicPanel.Controls.Add(Me.SchoolInfoTextBox)
        Me.AcademicPanel.Controls.Add(Me.GunaLabel9)
        Me.AcademicPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.AcademicPanel.Location = New System.Drawing.Point(803, 136)
        Me.AcademicPanel.Name = "AcademicPanel"
        Me.AcademicPanel.Size = New System.Drawing.Size(434, 226)
        Me.AcademicPanel.TabIndex = 10
        '
        'MotivationTextBox1
        '
        Me.MotivationTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MotivationTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MotivationTextBox1.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MotivationTextBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MotivationTextBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.MotivationTextBox1.Location = New System.Drawing.Point(174, 174)
        Me.MotivationTextBox1.Name = "MotivationTextBox1"
        Me.MotivationTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MotivationTextBox1.SelectedText = ""
        Me.MotivationTextBox1.Size = New System.Drawing.Size(217, 37)
        Me.MotivationTextBox1.TabIndex = 12
        '
        'ExamScoreTextBox
        '
        Me.ExamScoreTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExamScoreTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ExamScoreTextBox.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExamScoreTextBox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExamScoreTextBox.LineColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ExamScoreTextBox.Location = New System.Drawing.Point(174, 88)
        Me.ExamScoreTextBox.Name = "ExamScoreTextBox"
        Me.ExamScoreTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ExamScoreTextBox.SelectedText = ""
        Me.ExamScoreTextBox.Size = New System.Drawing.Size(217, 37)
        Me.ExamScoreTextBox.TabIndex = 11
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.GunaLabel7.Location = New System.Drawing.Point(28, 104)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(101, 21)
        Me.GunaLabel7.TabIndex = 10
        Me.GunaLabel7.Text = "Exam Scores"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.GunaLabel5.Location = New System.Drawing.Point(17, 187)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(132, 21)
        Me.GunaLabel5.TabIndex = 8
        Me.GunaLabel5.Text = "Motivation Level"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.GunaLabel6.Location = New System.Drawing.Point(17, 146)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(145, 21)
        Me.GunaLabel6.TabIndex = 7
        Me.GunaLabel6.Text = "Parental Education"
        '
        'ParentalEducationComboBox
        '
        Me.ParentalEducationComboBox.BackColor = System.Drawing.Color.Transparent
        Me.ParentalEducationComboBox.BaseColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ParentalEducationComboBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ParentalEducationComboBox.DisplayMember = "Male, Female, other"
        Me.ParentalEducationComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ParentalEducationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ParentalEducationComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ParentalEducationComboBox.FocusedColor = System.Drawing.Color.Empty
        Me.ParentalEducationComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ParentalEducationComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ParentalEducationComboBox.FormattingEnabled = True
        Me.ParentalEducationComboBox.Items.AddRange(New Object() {"No", "Formal Education", "Primary Education", "Secondary Education", "Higher Education"})
        Me.ParentalEducationComboBox.Location = New System.Drawing.Point(174, 141)
        Me.ParentalEducationComboBox.Name = "ParentalEducationComboBox"
        Me.ParentalEducationComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ParentalEducationComboBox.OnHoverItemForeColor = System.Drawing.Color.White
        Me.ParentalEducationComboBox.Size = New System.Drawing.Size(217, 26)
        Me.ParentalEducationComboBox.TabIndex = 6
        Me.ParentalEducationComboBox.ValueMember = "Male, Female, Others"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.GunaLabel8.Location = New System.Drawing.Point(55, 11)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(261, 33)
        Me.GunaLabel8.TabIndex = 3
        Me.GunaLabel8.Text = "Academic Background"
        '
        'SchoolInfoTextBox
        '
        Me.SchoolInfoTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SchoolInfoTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SchoolInfoTextBox.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SchoolInfoTextBox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SchoolInfoTextBox.LineColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.SchoolInfoTextBox.Location = New System.Drawing.Point(174, 41)
        Me.SchoolInfoTextBox.Name = "SchoolInfoTextBox"
        Me.SchoolInfoTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SchoolInfoTextBox.SelectedText = ""
        Me.SchoolInfoTextBox.Size = New System.Drawing.Size(217, 37)
        Me.SchoolInfoTextBox.TabIndex = 2
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.GunaLabel9.Location = New System.Drawing.Point(25, 57)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(121, 21)
        Me.GunaLabel9.TabIndex = 1
        Me.GunaLabel9.Text = "Teacher Quality"
        '
        'GunaPanelStudy
        '
        Me.GunaPanelStudy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GunaPanelStudy.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.GunaPanelStudy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GunaPanelStudy.Controls.Add(Me.TutoringTextBox)
        Me.GunaPanelStudy.Controls.Add(Me.SleepHoursTextBox)
        Me.GunaPanelStudy.Controls.Add(Me.GunaLabel10)
        Me.GunaPanelStudy.Controls.Add(Me.GunaLabel12)
        Me.GunaPanelStudy.Controls.Add(Me.GunaLabel13)
        Me.GunaPanelStudy.Controls.Add(Me.HoursStudyTextBox)
        Me.GunaPanelStudy.Controls.Add(Me.GunaLabel14)
        Me.GunaPanelStudy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.GunaPanelStudy.Location = New System.Drawing.Point(621, 412)
        Me.GunaPanelStudy.Name = "GunaPanelStudy"
        Me.GunaPanelStudy.Size = New System.Drawing.Size(363, 175)
        Me.GunaPanelStudy.TabIndex = 13
        '
        'TutoringTextBox
        '
        Me.TutoringTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TutoringTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TutoringTextBox.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TutoringTextBox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TutoringTextBox.LineColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.TutoringTextBox.Location = New System.Drawing.Point(159, 125)
        Me.TutoringTextBox.Name = "TutoringTextBox"
        Me.TutoringTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TutoringTextBox.SelectedText = ""
        Me.TutoringTextBox.Size = New System.Drawing.Size(171, 37)
        Me.TutoringTextBox.TabIndex = 13
        '
        'SleepHoursTextBox
        '
        Me.SleepHoursTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.SleepHoursTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SleepHoursTextBox.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SleepHoursTextBox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SleepHoursTextBox.LineColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.SleepHoursTextBox.Location = New System.Drawing.Point(159, 82)
        Me.SleepHoursTextBox.Name = "SleepHoursTextBox"
        Me.SleepHoursTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SleepHoursTextBox.SelectedText = ""
        Me.SleepHoursTextBox.Size = New System.Drawing.Size(171, 37)
        Me.SleepHoursTextBox.TabIndex = 11
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.GunaLabel10.Location = New System.Drawing.Point(10, 98)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(99, 21)
        Me.GunaLabel10.TabIndex = 10
        Me.GunaLabel10.Text = "Sleep Hours"
        '
        'GunaLabel12
        '
        Me.GunaLabel12.AutoSize = True
        Me.GunaLabel12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.GunaLabel12.Location = New System.Drawing.Point(3, 141)
        Me.GunaLabel12.Name = "GunaLabel12"
        Me.GunaLabel12.Size = New System.Drawing.Size(138, 21)
        Me.GunaLabel12.TabIndex = 7
        Me.GunaLabel12.Text = "Tutoring Sessions"
        '
        'GunaLabel13
        '
        Me.GunaLabel13.AutoSize = True
        Me.GunaLabel13.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.GunaLabel13.Location = New System.Drawing.Point(114, 11)
        Me.GunaLabel13.Name = "GunaLabel13"
        Me.GunaLabel13.Size = New System.Drawing.Size(155, 33)
        Me.GunaLabel13.TabIndex = 3
        Me.GunaLabel13.Text = "Study Habits"
        '
        'HoursStudyTextBox
        '
        Me.HoursStudyTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.HoursStudyTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HoursStudyTextBox.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HoursStudyTextBox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HoursStudyTextBox.LineColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.HoursStudyTextBox.Location = New System.Drawing.Point(159, 44)
        Me.HoursStudyTextBox.Name = "HoursStudyTextBox"
        Me.HoursStudyTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.HoursStudyTextBox.SelectedText = ""
        Me.HoursStudyTextBox.Size = New System.Drawing.Size(171, 37)
        Me.HoursStudyTextBox.TabIndex = 2
        '
        'GunaLabel14
        '
        Me.GunaLabel14.AutoSize = True
        Me.GunaLabel14.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.GunaLabel14.Location = New System.Drawing.Point(9, 60)
        Me.GunaLabel14.Name = "GunaLabel14"
        Me.GunaLabel14.Size = New System.Drawing.Size(100, 21)
        Me.GunaLabel14.TabIndex = 1
        Me.GunaLabel14.Text = "Hours Study"
        '
        'NextButton1
        '
        Me.NextButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.NextButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextButton1.ForeColor = System.Drawing.Color.White
        Me.NextButton1.Location = New System.Drawing.Point(743, 614)
        Me.NextButton1.Name = "NextButton1"
        Me.NextButton1.Size = New System.Drawing.Size(117, 39)
        Me.NextButton1.TabIndex = 14
        Me.NextButton1.Text = "Next"
        Me.NextButton1.UseVisualStyleBackColor = False
        '
        'PersonalInfoGunaPanel1
        '
        Me.PersonalInfoGunaPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PersonalInfoGunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.PersonalInfoGunaPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PersonalInfoGunaPanel1.Controls.Add(Me.SchoolComboBox)
        Me.PersonalInfoGunaPanel1.Controls.Add(Me.GunaStudentPictureBox)
        Me.PersonalInfoGunaPanel1.Controls.Add(Me.GunaLabel4)
        Me.PersonalInfoGunaPanel1.Controls.Add(Me.GunaLabel3)
        Me.PersonalInfoGunaPanel1.Controls.Add(Me.GunaComboBox1)
        Me.PersonalInfoGunaPanel1.Controls.Add(Me.AgeTextBox)
        Me.PersonalInfoGunaPanel1.Controls.Add(Me.GunaLabel2)
        Me.PersonalInfoGunaPanel1.Controls.Add(Me.GunaLabel1)
        Me.PersonalInfoGunaPanel1.Controls.Add(Me.nameGunaTextBox)
        Me.PersonalInfoGunaPanel1.Controls.Add(Me.NameLabel)
        Me.PersonalInfoGunaPanel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.PersonalInfoGunaPanel1.Location = New System.Drawing.Point(308, 136)
        Me.PersonalInfoGunaPanel1.Name = "PersonalInfoGunaPanel1"
        Me.PersonalInfoGunaPanel1.Size = New System.Drawing.Size(434, 226)
        Me.PersonalInfoGunaPanel1.TabIndex = 3
        '
        'SchoolComboBox
        '
        Me.SchoolComboBox.BackColor = System.Drawing.Color.Transparent
        Me.SchoolComboBox.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.SchoolComboBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.SchoolComboBox.DisplayMember = "Public ,Private, Home School"
        Me.SchoolComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SchoolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SchoolComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SchoolComboBox.FocusedColor = System.Drawing.Color.Empty
        Me.SchoolComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.SchoolComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.SchoolComboBox.FormattingEnabled = True
        Me.SchoolComboBox.Items.AddRange(New Object() {"Public ", "Private", "Home"})
        Me.SchoolComboBox.Location = New System.Drawing.Point(237, 185)
        Me.SchoolComboBox.Name = "SchoolComboBox"
        Me.SchoolComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SchoolComboBox.OnHoverItemForeColor = System.Drawing.Color.White
        Me.SchoolComboBox.Size = New System.Drawing.Size(171, 26)
        Me.SchoolComboBox.TabIndex = 9
        Me.SchoolComboBox.ValueMember = "Public, Private, Home School"
        '
        'GunaStudentPictureBox
        '
        Me.GunaStudentPictureBox.BaseColor = System.Drawing.Color.White
        Me.GunaStudentPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GunaStudentPictureBox.Location = New System.Drawing.Point(13, 46)
        Me.GunaStudentPictureBox.Name = "GunaStudentPictureBox"
        Me.GunaStudentPictureBox.Size = New System.Drawing.Size(126, 136)
        Me.GunaStudentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaStudentPictureBox.TabIndex = 4
        Me.GunaStudentPictureBox.TabStop = False
        Me.GunaStudentPictureBox.UseTransfarantBackground = False
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(130, 185)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(99, 21)
        Me.GunaLabel4.TabIndex = 8
        Me.GunaLabel4.Text = "School Type"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(155, 146)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(64, 21)
        Me.GunaLabel3.TabIndex = 7
        Me.GunaLabel3.Text = "Gender"
        '
        'GunaComboBox1
        '
        Me.GunaComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaComboBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GunaComboBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.GunaComboBox1.DisplayMember = "Male, Female, other"
        Me.GunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.GunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GunaComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GunaComboBox1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.GunaComboBox1.FormattingEnabled = True
        Me.GunaComboBox1.Items.AddRange(New Object() {"Male ", "Female", "Others"})
        Me.GunaComboBox1.Location = New System.Drawing.Point(237, 141)
        Me.GunaComboBox1.Name = "GunaComboBox1"
        Me.GunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White
        Me.GunaComboBox1.Size = New System.Drawing.Size(171, 26)
        Me.GunaComboBox1.TabIndex = 6
        Me.GunaComboBox1.ValueMember = "Male, Female, Others"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.AgeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AgeTextBox.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AgeTextBox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeTextBox.LineColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.AgeTextBox.Location = New System.Drawing.Point(237, 90)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AgeTextBox.SelectedText = ""
        Me.AgeTextBox.Size = New System.Drawing.Size(171, 37)
        Me.AgeTextBox.TabIndex = 5
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(145, 104)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(95, 21)
        Me.GunaLabel2.TabIndex = 4
        Me.GunaLabel2.Text = "Attendance"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(114, 11)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(254, 33)
        Me.GunaLabel1.TabIndex = 3
        Me.GunaLabel1.Text = "Personal Information"
        '
        'nameGunaTextBox
        '
        Me.nameGunaTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.nameGunaTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nameGunaTextBox.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nameGunaTextBox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameGunaTextBox.LineColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.nameGunaTextBox.Location = New System.Drawing.Point(237, 41)
        Me.nameGunaTextBox.Name = "nameGunaTextBox"
        Me.nameGunaTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.nameGunaTextBox.SelectedText = ""
        Me.nameGunaTextBox.Size = New System.Drawing.Size(171, 37)
        Me.nameGunaTextBox.TabIndex = 2
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.NameLabel.Location = New System.Drawing.Point(155, 57)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(53, 21)
        Me.NameLabel.TabIndex = 1
        Me.NameLabel.Text = "Name"
        '
        'StudentProfileForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.PersonalInfoGunaPanel1)
        Me.Controls.Add(Me.NextButton1)
        Me.Controls.Add(Me.GunaPanelStudy)
        Me.Controls.Add(Me.AcademicPanel)
        Me.Controls.Add(Me.NavPanel3)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StudentProfileForm"
        Me.Text = "StudentProfileForm"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.NavPanel3.ResumeLayout(False)
        Me.NavPanel3.PerformLayout()
        Me.AcademicPanel.ResumeLayout(False)
        Me.AcademicPanel.PerformLayout()
        Me.GunaPanelStudy.ResumeLayout(False)
        Me.GunaPanelStudy.PerformLayout()
        Me.PersonalInfoGunaPanel1.ResumeLayout(False)
        Me.PersonalInfoGunaPanel1.PerformLayout()
        CType(Me.GunaStudentPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents HomeButton1 As Button
    Friend WithEvents AccountButton2 As Button
    Friend WithEvents ViewButton As Button
    Friend WithEvents AnalyzeButton As Button
    Friend WithEvents slidebarTimer1 As Timer
    Friend WithEvents NavPanel3 As Panel
    Friend WithEvents MaximizeButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents AcademicPanel As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents ParentalEducationComboBox As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents SchoolInfoTextBox As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents ExamScoreTextBox As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPanelStudy As Guna.UI.WinForms.GunaPanel
    Friend WithEvents SleepHoursTextBox As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel12 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel13 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents HoursStudyTextBox As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel14 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TutoringTextBox As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents NextButton1 As Button
    Friend WithEvents PersonalInfoGunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents SchoolComboBox As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaStudentPictureBox As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaComboBox1 As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents AgeTextBox As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents nameGunaTextBox As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents NameLabel As Guna.UI.WinForms.GunaLabel
    Friend WithEvents MotivationTextBox1 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents MinButton As Button
    Friend WithEvents Label2 As Label
End Class
