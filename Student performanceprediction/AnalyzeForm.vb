Imports System.Drawing.Drawing2D
'Imports Guna.UI2.WinForms

Public Class AnalyzeForm
    Dim isSidebarExpanded As Boolean = True
    Dim sidebarWidthExpanded As Integer = 200
    Dim sidebarWidthCollapsed As Integer = 60
    Dim slideSpeed As Integer = 10
    ' In AnalyzeForm
    ' Public Property StudentData As Object ' Replace with actual data type



    Private Function CalculateProgress(data As Object) As Integer
        ' Placeholder for actual logic to calculate progress
        ' If your data is a numeric value, return that value directly
        Return 70 ' For example, 70% progress
    End Function

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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        slidebarTimer1.Start()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles MinButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub viewButton_Click(sender As Object, e As EventArgs) Handles viewButton.Click
        Dim summaryForm As New NewSummaryForm()
        summaryForm.Show()
        Me.Hide()
    End Sub

    Private Sub AnalyzeButton_Click(sender As Object, e As EventArgs) Handles AnalyzeButton.Click
        Dim analyzeForm As New AnalyzeForm()
        analyzeForm.Show()
        Me.Hide()
    End Sub
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ' RoundPanelCorners(GraphGunaPanel, 20)  '  Here, "20" is the radius value
        ' RoundPanelCorners(AcademicPanel, 20)
        ' RoundPanelCorners(GunaPanelStudy, 20)
    End Sub
    Private Sub GraphGunaPanel_Paint(sender As Object, e As PaintEventArgs)
        ' RoundPanelCorners(GraphGunaPanel, 20)
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AnalyzeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' === Calculate Performance Score ===
        Dim score As Double
        score += UserData.UserExamScores * 0.3
        score += UserData.UserMotivationLevel * 0.2
        score += UserData.UserParentalInvolvement * 0.15
        score += UserData.UserResourcesAccess * 0.15
        score += UserData.UserTutoringSessions * 2
        score += UserData.UserExtracurricularActivities * 2

        If UserData.UserLearningDisability.ToLower() = "yes" Then
            score -= 15
        End If

        ' Clamp the score
        If score > 100 Then score = 100
        If score < 0 Then score = 0

        Dim finalScore As Integer = CInt(score)
        ' ========== Display Circle Progress for Key Metrics ==========
        Dim motivation As Integer = CInt(UserData.UserMotivationLevel)
        Dim parental As Integer = CInt(UserData.UserParentalInvolvement)
        Dim resources As Integer = CInt(UserData.UserResourcesAccess)

        ' Motivation
        ' Motivation
        GunaCircularProgressBar1.Value = motivation
        lblMotivation.Text = motivation.ToString() & "%"
        Dim motivationColors = GetColorBasedOnValue(motivation)
        GunaCircularProgressBar1.ProgressMinColor = motivationColors.Item1
        GunaCircularProgressBar1.ProgressMaxColor = motivationColors.Item2

        ' Parental Involvement
        GunaCircleProgressBar1.Value = parental
        LabelParental.Text = parental.ToString() & "%"
        Dim parentalColors = GetColorBasedOnValue(parental)
        GunaCircleProgressBar1.ProgressMinColor = parentalColors.Item1
        GunaCircleProgressBar1.ProgressMaxColor = parentalColors.Item2

        ' Resources Access
        GunaCircleProgressBar2.Value = resources
        LabelResources.Text = resources.ToString() & "%"
        Dim resourcesColors = GetColorBasedOnValue(resources)
        GunaCircleProgressBar2.ProgressMinColor = resourcesColors.Item1
        GunaCircleProgressBar2.ProgressMaxColor = resourcesColors.Item2

    End Sub
    Private Function GetColorBasedOnValue(value As Integer) As Tuple(Of Color, Color)
        If value >= 80 Then
            Return Tuple.Create(Color.ForestGreen, Color.LimeGreen)
        ElseIf value >= 50 Then
            Return Tuple.Create(Color.Orange, Color.Gold)
        Else
            Return Tuple.Create(Color.DarkRed, Color.Red)
        End If
    End Function



End Class