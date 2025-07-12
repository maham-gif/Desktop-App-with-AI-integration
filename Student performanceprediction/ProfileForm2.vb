Imports System.Drawing.Drawing2D
Imports Guna.UI.WinForms
Public Class ProfileForm2


    Dim isSidebarExpanded As Boolean = True
    Dim sidebarWidthExpanded As Integer = 200
    Dim sidebarWidthCollapsed As Integer = 60
    Dim slideSpeed As Integer = 10
    Private Sub RoundPanelCorners(panel As Control, cornerRadius As Integer)
        Dim path As New GraphicsPath()
        path.StartFigure()
        path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90)
        path.AddArc(panel.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90)
        path.AddArc(panel.Width - cornerRadius, panel.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90)
        path.AddArc(0, panel.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90)
        path.CloseFigure()
        panel.Region = New Region(path)
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        slidebarTimer1.Start()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

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

    Private Sub AccountButton2_Click(sender As Object, e As EventArgs) Handles AccountButton2.Click
        Dim roleForm As New RoleSelectionForm()
        roleForm.Show()
        Me.Hide()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
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

    Private Sub ProfileForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        '  Here, "20" is the radius value

        RoundPanelCorners(ExtraActivityGunaPanel, 20)
        RoundPanelCorners(InternetGunaPanel3, 20)
        RoundPanelCorners(AdditionalInfoGunaPanel, 20)
    End Sub

    Private Sub ExtraActivityGunaPanel_Paint(sender As Object, e As PaintEventArgs) Handles ExtraActivityGunaPanel.Paint

    End Sub

    Private Sub PersonalInfoGunaPanel_Resize(sender As Object, e As EventArgs) Handles AdditionalInfoGunaPanel.Resize
        RoundPanelCorners(AdditionalInfoGunaPanel, 20)
    End Sub

    Private Sub InternetGunaPanel3_Resize(sender As Object, e As EventArgs) Handles InternetGunaPanel3.Resize
        RoundPanelCorners(InternetGunaPanel3, 20)
    End Sub
    Private Sub ParentGunaPanel_Resize(sender As Object, e As EventArgs) Handles ParentGunaPanel.Resize
        RoundPanelCorners(ParentGunaPanel, 20)
    End Sub
    Private Sub ExtraActivityGunaPanel_Resize(sender As Object, e As EventArgs) Handles ParentGunaPanel.Resize
        RoundPanelCorners(ExtraActivityGunaPanel, 20)
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxOther.CheckedChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxNo.CheckedChanged

    End Sub

    Private Sub NextButton1_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        Dim previousForm As New StudentProfileForm()
        previousForm.Show()
        Me.Hide()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        ' Save values from ComboBoxes and TextBoxes to the UserData module
        UserInternetAccess = If(InternetComboBox3.SelectedItem IsNot Nothing, InternetComboBox3.SelectedItem.ToString(), "Not Selected")
        UserResourcesAccess = If(String.IsNullOrWhiteSpace(ResourceAccessTextBox.Text), "Not Provided", ResourceAccessTextBox.Text)
        UserExtracurricularActivities = If(String.IsNullOrWhiteSpace(ExtraActivityTextBox.Text), "Not Provided", ExtraActivityTextBox.Text)
        UserParentalInvolvement = If(String.IsNullOrWhiteSpace(ParentalInvolvementTextBox.Text), "Not Provided", ParentalInvolvementTextBox.Text)
        UserParentalRoleInEducation = If(String.IsNullOrWhiteSpace(RoleTextBox.Text), "Not Provided", RoleTextBox.Text)
        UserDistanceFromHome = If(String.IsNullOrWhiteSpace(DistanceTextBox.Text), "Not Provided", DistanceTextBox.Text)
        UserOtherNotes = If(String.IsNullOrWhiteSpace(OtherTextBox.Text), "Not Provided", OtherTextBox.Text)
        'UserParentalInvolvement = If(CheckBoxYes.Checked, "Yes", If(CheckBoxNo.Checked, "No", "Not Selected"))
        UserLearningDisability = If(CheckBoxYes.Checked, "Yes", If(CheckBoxNo.Checked, "No", "Not Selected"))
        UserPhysicalActivities = If(CheckBoxSports.Checked, "Sports", If(CheckBoxReading.Checked, "Reading", If(CheckBoxOther.Checked, "Other", "Not Selected")))
        If String.IsNullOrWhiteSpace(UserName) OrElse String.IsNullOrWhiteSpace(UserMotivationLevel) Then
            MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        ' Navigate to SummaryForm after saving data
        Dim nextForm As New NewSummaryForm()
        nextForm.Show()
        Me.Hide()
    End Sub

    Private Sub GunaLabel15_Click(sender As Object, e As EventArgs) Handles GunaLabel15.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles MinButton.Click
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

    Private Sub GunaLabel22_Click(sender As Object, e As EventArgs) Handles GunaLabel22.Click

    End Sub

    Private Sub GunaLabel24_Click(sender As Object, e As EventArgs) Handles GunaLabel24.Click

    End Sub

    Private Sub CheckBoxYes_CheckedChanged(sender As Object, e As EventArgs)

    End Sub
End Class