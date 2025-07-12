Imports System.Drawing.Drawing2D

Public Class Form1
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
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        RoundPanelCorners(GunaGradient2Panel1, 20)  '  Here, "20" is the radius value
        RoundPanelCorners(GunaGradient2Panel2, 20)
        RoundPanelCorners(GunaPanel1, 20)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles HomeButton1.Click
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
    Private Sub GunaPanel1_Resize(sender As Object, e As EventArgs) Handles GunaPanel1.Resize
        RoundPanelCorners(GunaPanel1, 20)
    End Sub
    Private Sub GunaGradient2Panel2_Resize(sender As Object, e As EventArgs) Handles GunaGradient2Panel2.Resize
        RoundPanelCorners(GunaGradient2Panel2, 20)
    End Sub
    Private Sub GunaGradient2Panel1_Resize(sender As Object, e As EventArgs) Handles GunaGradient2Panel1.Resize
        RoundPanelCorners(GunaGradient2Panel1, 20)
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        slidebarTimer1.Start()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

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

    Private Sub AccountButton2_Click(sender As Object, e As EventArgs) Handles AccountButton2.Click
        Dim roleForm As New RoleSelectionForm()
        roleForm.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles MinButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ViewButton.Click
        Dim summaryForm As New NewSummaryForm()
        summaryForm.Show()
        Me.Hide()
    End Sub

    Private Sub AnalyzeButton_Click(sender As Object, e As EventArgs) Handles AnalyzeButton.Click
        Dim analyzeForm As New AnalyzeForm()
        analyzeForm.Show()
        Me.Hide()
    End Sub

    Private Sub GunaGauge1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaVAverageProgressBar_Click(sender As Object, e As EventArgs) Handles GunaVAverageProgressBar.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class
