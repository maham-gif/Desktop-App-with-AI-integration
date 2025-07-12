<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnalyzeForm
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnalyzeForm))
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.HomeButton1 = New System.Windows.Forms.Button()
		Me.AccountButton2 = New System.Windows.Forms.Button()
		Me.viewButton = New System.Windows.Forms.Button()
		Me.AnalyzeButton = New System.Windows.Forms.Button()
		Me.slidebarTimer1 = New System.Windows.Forms.Timer(Me.components)
		Me.NavPanel3 = New System.Windows.Forms.Panel()
		Me.MinButton = New System.Windows.Forms.Button()
		Me.MaximizeButton = New System.Windows.Forms.Button()
		Me.CloseButton = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
		Me.GunaCircularProgressBar1 = New Guna.UI.WinForms.GunaCircleProgressBar()
		Me.lblMotivation = New System.Windows.Forms.Label()
		Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
		Me.GunaCircleProgressBar1 = New Guna.UI.WinForms.GunaCircleProgressBar()
		Me.LabelParental = New System.Windows.Forms.Label()
		Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
		Me.GunaCircleProgressBar2 = New Guna.UI.WinForms.GunaCircleProgressBar()
		Me.LabelResources = New System.Windows.Forms.Label()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.Panel1.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel2.SuspendLayout()
		Me.NavPanel3.SuspendLayout()
		Me.GunaPanel2.SuspendLayout()
		Me.GunaCircularProgressBar1.SuspendLayout()
		Me.GunaPanel1.SuspendLayout()
		Me.GunaCircleProgressBar1.SuspendLayout()
		Me.GunaPanel3.SuspendLayout()
		Me.GunaCircleProgressBar2.SuspendLayout()
		Me.SuspendLayout()
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
		Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
		Me.FlowLayoutPanel1.Controls.Add(Me.Panel2)
		Me.FlowLayoutPanel1.Controls.Add(Me.AccountButton2)
		Me.FlowLayoutPanel1.Controls.Add(Me.viewButton)
		Me.FlowLayoutPanel1.Controls.Add(Me.AnalyzeButton)
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.FlowLayoutPanel1.MaximumSize = New System.Drawing.Size(245, 720)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(236, 720)
		Me.FlowLayoutPanel1.TabIndex = 2
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
		'viewButton
		'
		Me.viewButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
		Me.viewButton.FlatAppearance.BorderSize = 0
		Me.viewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.viewButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.viewButton.ForeColor = System.Drawing.Color.White
		Me.viewButton.Image = CType(resources.GetObject("viewButton.Image"), System.Drawing.Image)
		Me.viewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.viewButton.Location = New System.Drawing.Point(3, 227)
		Me.viewButton.Name = "viewButton"
		Me.viewButton.Size = New System.Drawing.Size(233, 50)
		Me.viewButton.TabIndex = 4
		Me.viewButton.Text = "              View"
		Me.viewButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.viewButton.UseVisualStyleBackColor = False
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
		Me.NavPanel3.Controls.Add(Me.MinButton)
		Me.NavPanel3.Controls.Add(Me.MaximizeButton)
		Me.NavPanel3.Controls.Add(Me.CloseButton)
		Me.NavPanel3.Controls.Add(Me.Label2)
		Me.NavPanel3.Location = New System.Drawing.Point(-9, 0)
		Me.NavPanel3.Name = "NavPanel3"
		Me.NavPanel3.Size = New System.Drawing.Size(1340, 41)
		Me.NavPanel3.TabIndex = 3
		'
		'MinButton
		'
		Me.MinButton.BackgroundImage = CType(resources.GetObject("MinButton.BackgroundImage"), System.Drawing.Image)
		Me.MinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.MinButton.FlatAppearance.BorderSize = 0
		Me.MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.MinButton.Location = New System.Drawing.Point(1238, 5)
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
		Me.MaximizeButton.Location = New System.Drawing.Point(1267, 3)
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
		Me.CloseButton.Location = New System.Drawing.Point(1296, 3)
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
		Me.Label2.Size = New System.Drawing.Size(172, 36)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "           POLAC"
		'
		'GunaPanel2
		'
		Me.GunaPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.GunaPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
		Me.GunaPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.GunaPanel2.Controls.Add(Me.GunaCircularProgressBar1)
		Me.GunaPanel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
		Me.GunaPanel2.Location = New System.Drawing.Point(736, 87)
		Me.GunaPanel2.Name = "GunaPanel2"
		Me.GunaPanel2.Size = New System.Drawing.Size(312, 248)
		Me.GunaPanel2.TabIndex = 7
		'
		'GunaCircularProgressBar1
		'
		Me.GunaCircularProgressBar1.AnimationSpeed = 0.6!
		Me.GunaCircularProgressBar1.BaseColor = System.Drawing.Color.White
		Me.GunaCircularProgressBar1.Controls.Add(Me.lblMotivation)
		Me.GunaCircularProgressBar1.IdleColor = System.Drawing.Color.Gainsboro
		Me.GunaCircularProgressBar1.IdleOffset = 20
		Me.GunaCircularProgressBar1.Image = Nothing
		Me.GunaCircularProgressBar1.ImageSize = New System.Drawing.Size(52, 52)
		Me.GunaCircularProgressBar1.Location = New System.Drawing.Point(32, 13)
		Me.GunaCircularProgressBar1.Name = "GunaCircularProgressBar1"
		Me.GunaCircularProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.GunaCircularProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.GunaCircularProgressBar1.ProgressOffset = 20
		Me.GunaCircularProgressBar1.Size = New System.Drawing.Size(227, 216)
		Me.GunaCircularProgressBar1.TabIndex = 5
		'
		'lblMotivation
		'
		Me.lblMotivation.AutoSize = True
		Me.lblMotivation.Location = New System.Drawing.Point(98, 101)
		Me.lblMotivation.Name = "lblMotivation"
		Me.lblMotivation.Size = New System.Drawing.Size(39, 13)
		Me.lblMotivation.TabIndex = 8
		Me.lblMotivation.Text = "Label3"
		'
		'GunaPanel1
		'
		Me.GunaPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
		Me.GunaPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.GunaPanel1.Controls.Add(Me.GunaCircleProgressBar1)
		Me.GunaPanel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
		Me.GunaPanel1.Location = New System.Drawing.Point(524, 376)
		Me.GunaPanel1.Name = "GunaPanel1"
		Me.GunaPanel1.Size = New System.Drawing.Size(312, 248)
		Me.GunaPanel1.TabIndex = 8
		'
		'GunaCircleProgressBar1
		'
		Me.GunaCircleProgressBar1.AnimationSpeed = 0.6!
		Me.GunaCircleProgressBar1.BaseColor = System.Drawing.Color.White
		Me.GunaCircleProgressBar1.Controls.Add(Me.LabelParental)
		Me.GunaCircleProgressBar1.IdleColor = System.Drawing.Color.Gainsboro
		Me.GunaCircleProgressBar1.IdleOffset = 20
		Me.GunaCircleProgressBar1.Image = Nothing
		Me.GunaCircleProgressBar1.ImageSize = New System.Drawing.Size(52, 52)
		Me.GunaCircleProgressBar1.Location = New System.Drawing.Point(32, 3)
		Me.GunaCircleProgressBar1.Name = "GunaCircleProgressBar1"
		Me.GunaCircleProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.GunaCircleProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.GunaCircleProgressBar1.ProgressOffset = 20
		Me.GunaCircleProgressBar1.Size = New System.Drawing.Size(253, 243)
		Me.GunaCircleProgressBar1.TabIndex = 5
		'
		'LabelParental
		'
		Me.LabelParental.AutoSize = True
		Me.LabelParental.Location = New System.Drawing.Point(100, 100)
		Me.LabelParental.Name = "LabelParental"
		Me.LabelParental.Size = New System.Drawing.Size(39, 13)
		Me.LabelParental.TabIndex = 9
		Me.LabelParental.Text = "Label3"
		'
		'GunaPanel3
		'
		Me.GunaPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.GunaPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
		Me.GunaPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.GunaPanel3.Controls.Add(Me.GunaCircleProgressBar2)
		Me.GunaPanel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
		Me.GunaPanel3.Location = New System.Drawing.Point(318, 87)
		Me.GunaPanel3.Name = "GunaPanel3"
		Me.GunaPanel3.Size = New System.Drawing.Size(312, 248)
		Me.GunaPanel3.TabIndex = 8
		'
		'GunaCircleProgressBar2
		'
		Me.GunaCircleProgressBar2.AnimationSpeed = 0.6!
		Me.GunaCircleProgressBar2.BaseColor = System.Drawing.Color.White
		Me.GunaCircleProgressBar2.Controls.Add(Me.LabelResources)
		Me.GunaCircleProgressBar2.IdleColor = System.Drawing.Color.Gainsboro
		Me.GunaCircleProgressBar2.IdleOffset = 20
		Me.GunaCircleProgressBar2.Image = Nothing
		Me.GunaCircleProgressBar2.ImageSize = New System.Drawing.Size(52, 52)
		Me.GunaCircleProgressBar2.Location = New System.Drawing.Point(29, 3)
		Me.GunaCircleProgressBar2.Name = "GunaCircleProgressBar2"
		Me.GunaCircleProgressBar2.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.GunaCircleProgressBar2.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.GunaCircleProgressBar2.ProgressOffset = 20
		Me.GunaCircleProgressBar2.Size = New System.Drawing.Size(253, 243)
		Me.GunaCircleProgressBar2.TabIndex = 5
		'
		'LabelResources
		'
		Me.LabelResources.AutoSize = True
		Me.LabelResources.Location = New System.Drawing.Point(104, 111)
		Me.LabelResources.Name = "LabelResources"
		Me.LabelResources.Size = New System.Drawing.Size(39, 13)
		Me.LabelResources.TabIndex = 10
		Me.LabelResources.Text = "Label3"
		'
		'AnalyzeForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(1322, 710)
		Me.Controls.Add(Me.GunaPanel3)
		Me.Controls.Add(Me.GunaPanel1)
		Me.Controls.Add(Me.GunaPanel2)
		Me.Controls.Add(Me.NavPanel3)
		Me.Controls.Add(Me.FlowLayoutPanel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "AnalyzeForm"
		Me.Text = "AnalyzeForm"
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel2.ResumeLayout(False)
		Me.NavPanel3.ResumeLayout(False)
		Me.NavPanel3.PerformLayout()
		Me.GunaPanel2.ResumeLayout(False)
		Me.GunaCircularProgressBar1.ResumeLayout(False)
		Me.GunaCircularProgressBar1.PerformLayout()
		Me.GunaPanel1.ResumeLayout(False)
		Me.GunaCircleProgressBar1.ResumeLayout(False)
		Me.GunaCircleProgressBar1.PerformLayout()
		Me.GunaPanel3.ResumeLayout(False)
		Me.GunaCircleProgressBar2.ResumeLayout(False)
		Me.GunaCircleProgressBar2.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents HomeButton1 As Button
    Friend WithEvents AccountButton2 As Button
    Friend WithEvents viewButton As Button
    Friend WithEvents AnalyzeButton As Button
    Friend WithEvents slidebarTimer1 As Timer
    Friend WithEvents NavPanel3 As Panel
    Friend WithEvents MaximizeButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents MinButton As Button
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaCircularProgressBar1 As Guna.UI.WinForms.GunaCircleProgressBar
    Friend WithEvents lblMotivation As Label
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaCircleProgressBar1 As Guna.UI.WinForms.GunaCircleProgressBar
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaCircleProgressBar2 As Guna.UI.WinForms.GunaCircleProgressBar
    Friend WithEvents LabelParental As Label
    Friend WithEvents LabelResources As Label
End Class
