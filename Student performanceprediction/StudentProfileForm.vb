Imports System.Drawing.Drawing2D
Imports Guna.UI.WinForms

Public Class StudentProfileForm

    Public Sub RoundPanelCorners(panel As Panel, radius As Integer)
        Dim path As New GraphicsPath()
        path.StartFigure()
        path.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        path.AddArc(New Rectangle(panel.Width - radius, 0, radius, radius), 270, 90)
        path.AddArc(New Rectangle(panel.Width - radius, panel.Height - radius, radius, radius), 0, 90)
        path.AddArc(New Rectangle(0, panel.Height - radius, radius, radius), 90, 90)
        path.CloseFigure()
        panel.Region = New Region(path)
    End Sub

    Dim isSidebarExpanded As Boolean = True
    Dim sidebarWidthExpanded As Integer = 200
    Dim sidebarWidthCollapsed As Integer = 60
    Dim slideSpeed As Integer = 10
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        slidebarTimer1.Start()
    End Sub

    Private Sub slidebarTimer1_Tick(sender As Object, e As EventArgs) Handles slidebarTimer1.Tick
        If isSidebarExpanded Then
            ' Collapse sidebar
            FlowLayoutPanel1.Width -= slideSpeed
            If FlowLayoutPanel1.Width <= sidebarWidthCollapsed Then
                slidebarTimer1.Stop()
                isSidebarExpanded = False
            End If
        Else
            ' Expand sidebar
            FlowLayoutPanel1.Width += slideSpeed
            If FlowLayoutPanel1.Width >= sidebarWidthExpanded Then
                slidebarTimer1.Stop()
                isSidebarExpanded = True
            End If
        End If
    End Sub

    Private Sub HomeButton1_Click(sender As Object, e As EventArgs) Handles HomeButton1.Click
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is Form1 Then
                frm.Show()
                frm.BringToFront()
                Me.Close()
                Exit Sub
            End If
        Next
        ' If not open, create new
        Dim homeForm As New Form1()
        homeForm.Show()
        Me.Close()
    End Sub

    Private Sub MaximizeButton_Click(sender As Object, e As EventArgs) Handles MaximizeButton.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized

        Else
            Me.WindowState = FormWindowState.Normal
            MaximizeButton.Text = "🗖" ' Maximize icon/text
        End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub AccountButton2_Click(sender As Object, e As EventArgs) Handles AccountButton2.Click
        Dim roleForm As New RoleSelectionForm()
        roleForm.Show()
        Me.Hide()
    End Sub
    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub usernameGunaLineTextBox_TextChanged(sender As Object, e As EventArgs) Handles nameGunaTextBox.TextChanged

    End Sub
    Private Sub AgeTextBox_TextChanged(sender As Object, e As EventArgs) Handles AgeTextBox.TextChanged

    End Sub
    Private Sub GunaPanel1_Paint(sender As Object, e As PaintEventArgs) Handles PersonalInfoGunaPanel1.Paint

    End Sub
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        RoundPanelCorners(PersonalInfoGunaPanel1, 20)  '  Here, "20" is the radius value
        RoundPanelCorners(AcademicPanel, 20)
        RoundPanelCorners(GunaPanelStudy, 20)
    End Sub
    Private Sub PersonalInfoGunaPanel1_Resize(sender As Object, e As EventArgs) Handles PersonalInfoGunaPanel1.Resize
        RoundPanelCorners(PersonalInfoGunaPanel1, 20)
    End Sub

    Private Sub GunaComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ParentalEducationComboBox.SelectedIndexChanged
        ParentalEducationComboBox.Items.Add("High School")
        ParentalEducationComboBox.Items.Add("Bachelor's")
        ParentalEducationComboBox.Items.Add("Master's")
        ParentalEducationComboBox.Items.Add("PhD")
        '
    End Sub

    Private Sub GunaLabel6_Click(sender As Object, e As EventArgs) Handles GunaLabel6.Click

    End Sub

    Private Sub GunaProgressBar1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub GunaLabel17_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaProgressBar2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaLabel3_Click(sender As Object, e As EventArgs) Handles GunaLabel3.Click

    End Sub

    Private Sub GunaLabel10_Click(sender As Object, e As EventArgs) Handles GunaLabel10.Click

    End Sub

    Private Sub GunaLabel12_Click(sender As Object, e As EventArgs) Handles GunaLabel12.Click

    End Sub

    Private Sub GunaLabel7_Click(sender As Object, e As EventArgs) Handles GunaLabel7.Click

    End Sub

    Private Sub GunaPanel1_Paint_1(sender As Object, e As PaintEventArgs) Handles AcademicPanel.Paint

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub AcademicPanel_Resize(sender As Object, e As EventArgs) Handles PersonalInfoGunaPanel1.Resize
        RoundPanelCorners(AcademicPanel, 20)
    End Sub
    Private Sub ParentGunaPanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    Private Sub YourForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundPanelCorners(PersonalInfoGunaPanel1, 20)
        RoundPanelCorners(AcademicPanel, 20)
        RoundPanelCorners(GunaPanelStudy, 20)
    End Sub


    Private Sub GunaPanelStudy_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanelStudy.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles NextButton1.Click
        ' Save all values from textboxes, comboboxes into module variables
        UserData.UserName = nameGunaTextBox.Text
        UserData.UserAge = AgeTextBox.Text
        UserData.UserStudyHours = HoursStudyTextBox.Text
        UserData.UserSleepHours = SleepHoursTextBox.Text
        UserData.UserTutoringSessions = TutoringTextBox.Text

        If GunaComboBox1.SelectedItem IsNot Nothing Then
            UserData.UserGender = GunaComboBox1.SelectedItem.ToString()
        Else
            UserData.UserGender = "Not Selected"
        End If

        If SchoolComboBox.SelectedItem IsNot Nothing Then
            UserData.UserSchoolType = SchoolComboBox.SelectedItem.ToString()
        Else
            UserData.UserSchoolType = "Not Selected"
        End If

        UserData.UserPreviousSchool = SchoolInfoTextBox.Text
        UserData.UserExamScores = ExamScoreTextBox.Text

        If ParentalEducationComboBox.SelectedItem IsNot Nothing Then
            UserData.UserParentalEducation = ParentalEducationComboBox.SelectedItem.ToString()
        Else
            UserData.UserParentalEducation = "Not Selected"
        End If
        UserData.UserMotivationLevel = MotivationTextBox1.Text


        ' Open next form
        Dim nextForm As New ProfileForm2()
        nextForm.Show()
        Me.Hide()
    End Sub


    Private Sub StudentProfileForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub GunaCirclePictureBox1_Click(sender As Object, e As EventArgs) Handles GunaStudentPictureBox.Click

        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If ofd.ShowDialog() = DialogResult.OK Then
            GunaStudentPictureBox.Image = Image.FromFile(ofd.FileName)
            UserData.UserImage = GunaStudentPictureBox.Image ' Save to module
        End If
    End Sub

    Private Sub MinButton_Click(sender As Object, e As EventArgs) Handles MinButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ViewButton_Click(sender As Object, e As EventArgs) Handles ViewButton.Click
        Dim summaryForm As New NewSummaryForm()
        summaryForm.Show()
        Me.Hide()
    End Sub

    Private Sub AnalyzeButton_Click(sender As Object, e As EventArgs) Handles AnalyzeButton.Click
        Dim analyzeForm As New AnalyzeForm()
        analyzeForm.Show()
        Me.Hide()
    End Sub
End Class