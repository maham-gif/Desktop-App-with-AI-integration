<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoleSelectionForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RoleSelectionForm))
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.HomeButton1 = New System.Windows.Forms.Button()
        Me.AccountButton2 = New System.Windows.Forms.Button()
        Me.ViewButton = New System.Windows.Forms.Button()
        Me.AnalyzeButton = New System.Windows.Forms.Button()
        Me.RoleSelectionNavPanel = New System.Windows.Forms.Panel()
        Me.MinButton = New System.Windows.Forms.Button()
        Me.MaximizeButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.slidebarTimer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.AdminButton = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.studentButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.RoleSelectionNavPanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.FlowLayoutPanel2.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel2.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel2.Controls.Add(Me.AccountButton2)
        Me.FlowLayoutPanel2.Controls.Add(Me.ViewButton)
        Me.FlowLayoutPanel2.Controls.Add(Me.AnalyzeButton)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 0)
        Me.FlowLayoutPanel2.MaximumSize = New System.Drawing.Size(245, 720)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(236, 720)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(203, 123)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(66, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Menu"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 40)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.HomeButton1)
        Me.Panel2.Location = New System.Drawing.Point(3, 132)
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
        Me.AccountButton2.Location = New System.Drawing.Point(3, 188)
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
        Me.ViewButton.Location = New System.Drawing.Point(3, 244)
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
        Me.AnalyzeButton.Location = New System.Drawing.Point(3, 300)
        Me.AnalyzeButton.Name = "AnalyzeButton"
        Me.AnalyzeButton.Size = New System.Drawing.Size(233, 50)
        Me.AnalyzeButton.TabIndex = 5
        Me.AnalyzeButton.TabStop = False
        Me.AnalyzeButton.Text = "              Analyze"
        Me.AnalyzeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AnalyzeButton.UseVisualStyleBackColor = False
        '
        'RoleSelectionNavPanel
        '
        Me.RoleSelectionNavPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.RoleSelectionNavPanel.Controls.Add(Me.Label2)
        Me.RoleSelectionNavPanel.Controls.Add(Me.MinButton)
        Me.RoleSelectionNavPanel.Controls.Add(Me.MaximizeButton)
        Me.RoleSelectionNavPanel.Controls.Add(Me.CloseButton)
        Me.RoleSelectionNavPanel.Location = New System.Drawing.Point(9, 0)
        Me.RoleSelectionNavPanel.Name = "RoleSelectionNavPanel"
        Me.RoleSelectionNavPanel.Size = New System.Drawing.Size(1340, 49)
        Me.RoleSelectionNavPanel.TabIndex = 2
        '
        'MinButton
        '
        Me.MinButton.BackgroundImage = CType(resources.GetObject("MinButton.BackgroundImage"), System.Drawing.Image)
        Me.MinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MinButton.FlatAppearance.BorderSize = 0
        Me.MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinButton.Location = New System.Drawing.Point(1186, 9)
        Me.MinButton.Name = "MinButton"
        Me.MinButton.Size = New System.Drawing.Size(23, 23)
        Me.MinButton.TabIndex = 4
        Me.MinButton.UseVisualStyleBackColor = True
        '
        'MaximizeButton
        '
        Me.MaximizeButton.BackgroundImage = CType(resources.GetObject("MaximizeButton.BackgroundImage"), System.Drawing.Image)
        Me.MaximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MaximizeButton.FlatAppearance.BorderSize = 0
        Me.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MaximizeButton.Location = New System.Drawing.Point(1215, 9)
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
        Me.CloseButton.Location = New System.Drawing.Point(1244, 9)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(23, 23)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'slidebarTimer1
        '
        Me.slidebarTimer1.Interval = 10
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(462, 132)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(382, 241)
        Me.Panel3.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.PictureBox3)
        Me.Panel5.Controls.Add(Me.AdminButton)
        Me.Panel5.Location = New System.Drawing.Point(199, 34)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(150, 128)
        Me.Panel5.TabIndex = 1
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(35, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(74, 80)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'AdminButton
        '
        Me.AdminButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.AdminButton.FlatAppearance.BorderSize = 0
        Me.AdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AdminButton.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminButton.ForeColor = System.Drawing.Color.White
        Me.AdminButton.Location = New System.Drawing.Point(16, 98)
        Me.AdminButton.Name = "AdminButton"
        Me.AdminButton.Size = New System.Drawing.Size(115, 27)
        Me.AdminButton.TabIndex = 1
        Me.AdminButton.Text = "Admin Login"
        Me.AdminButton.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Controls.Add(Me.studentButton)
        Me.Panel4.Location = New System.Drawing.Point(33, 34)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(150, 128)
        Me.Panel4.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(34, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(78, 80)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'studentButton
        '
        Me.studentButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.studentButton.FlatAppearance.BorderSize = 0
        Me.studentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.studentButton.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentButton.ForeColor = System.Drawing.Color.White
        Me.studentButton.Location = New System.Drawing.Point(18, 98)
        Me.studentButton.Name = "studentButton"
        Me.studentButton.Size = New System.Drawing.Size(115, 27)
        Me.studentButton.TabIndex = 0
        Me.studentButton.Text = "Student Login"
        Me.studentButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label2.Location = New System.Drawing.Point(0, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 36)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "                POLAC"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RoleSelectionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1288, 681)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.RoleSelectionNavPanel)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RoleSelectionForm"
        Me.Text = "RoleSelectionForm"
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.RoleSelectionNavPanel.ResumeLayout(False)
        Me.RoleSelectionNavPanel.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents HomeButton1 As Button
    Friend WithEvents AccountButton2 As Button
    Friend WithEvents ViewButton As Button
    Friend WithEvents AnalyzeButton As Button
    Friend WithEvents slidebarTimer1 As Timer
    Friend WithEvents RoleSelectionNavPanel As Panel
    Friend WithEvents MaximizeButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents studentButton As Button
    Friend WithEvents AdminButton As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents MinButton As Button
    Friend WithEvents Label2 As Label
End Class
