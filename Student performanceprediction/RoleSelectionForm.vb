Public Class RoleSelectionForm
    Dim isSidebarExpanded As Boolean = True
    Dim sidebarWidthExpanded As Integer = 200
    Dim sidebarWidthCollapsed As Integer = 60
    Dim slideSpeed As Integer = 10
    Private Sub RoleSelectionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        slidebarTimer1.Start()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub slidebarTimer1_Tick(sender As Object, e As EventArgs) Handles slidebarTimer1.Tick
        If isSidebarExpanded Then
            ' Collapse sidebar
            FlowLayoutPanel2.Width -= slideSpeed
            If FlowLayoutPanel2.Width <= sidebarWidthCollapsed Then
                slidebarTimer1.Stop()
                isSidebarExpanded = False
            End If
        Else
            ' Expand sidebar
            FlowLayoutPanel2.Width += slideSpeed
            If FlowLayoutPanel2.Width >= sidebarWidthExpanded Then
                slidebarTimer1.Stop()
                isSidebarExpanded = True
            End If
        End If
    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaximizeButton_Click(sender As Object, e As EventArgs) Handles MaximizeButton.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized

        Else
            Me.WindowState = FormWindowState.Normal
            MaximizeButton.Text = "🗖" ' Maximize icon/text
        End If
    End Sub

    Private Sub CloseButton_Click_1(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub studentButton_Click(sender As Object, e As EventArgs) Handles studentButton.Click
        Dim loginForm As New newLoginForm()
        loginForm.UserRole = "Student"
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub AdminButton_Click(sender As Object, e As EventArgs) Handles AdminButton.Click
        Dim loginForm As New newLoginForm()
        loginForm.UserRole = "Admin"
        loginForm.Show()
        Me.Hide()
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
End Class