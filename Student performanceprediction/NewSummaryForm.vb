Public Class NewSummaryForm
    Dim isSidebarExpanded As Boolean = True
    Dim sidebarWidthExpanded As Integer = 200
    Dim sidebarWidthCollapsed As Integer = 60
    Dim slideSpeed As Integer = 10
    Private WithEvents client As New Net.WebClient

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
            MaximizeButton.Text = "🗖"
        End If
    End Sub

    Private Sub NewSummaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display all user data
        NameLabel.Text = "Name: " & If(Not String.IsNullOrWhiteSpace(UserName), UserName, "N/A")
        AgeLabel.Text = "Age: " & If(Not String.IsNullOrWhiteSpace(UserAge), UserAge, "N/A")
        GenderLabel.Text = "Gender: " & If(Not String.IsNullOrWhiteSpace(UserGender), UserGender, "N/A")
        SchoolTypeLabel.Text = "School Type: " & If(Not String.IsNullOrWhiteSpace(UserSchoolType), UserSchoolType, "N/A")
        PreviousSchoolLabel.Text = "Previous School: " & If(Not String.IsNullOrWhiteSpace(UserPreviousSchool), UserPreviousSchool, "N/A")
        ExamLabel.Text = "Exam Scores: " & FormatExamScores(UserExamScores)
        ParentalEducationLabel.Text = "Parental Education: " & If(Not String.IsNullOrWhiteSpace(UserParentalEducation), UserParentalEducation, "N/A")
        HoursStudyLabel.Text = "Study Hours: " & FormatNumericValue(UserStudyHours, " hours")
        SleepHoursLabel.Text = "Sleep Hours: " & FormatNumericValue(UserSleepHours, " hours")
        TutoringSessionsLabel.Text = "Tutoring Sessions: " & FormatNumericValue(UserTutoringSessions, " sessions")
        InternetLabel.Text = "Internet Access: " & If(Not String.IsNullOrWhiteSpace(UserInternetAccess), UserInternetAccess, "N/A")
        LearningDisabilityLabel.Text = "Learning Disability: " & If(Not String.IsNullOrWhiteSpace(UserLearningDisability), UserLearningDisability, "N/A")
        ExtraActivitiesLabel.Text = "Extracurricular Activities: " & If(Not String.IsNullOrWhiteSpace(UserExtracurricularActivities), UserExtracurricularActivities, "N/A")
        PhysicalLabel.Text = "Physical Activities: " & If(Not String.IsNullOrWhiteSpace(UserPhysicalActivities), UserPhysicalActivities, "N/A")
        ParentalRoleLabel.Text = "Parental Role in Education: " & If(Not String.IsNullOrWhiteSpace(UserParentalRoleInEducation), UserParentalRoleInEducation, "N/A")
        DistanceLabel.Text = "Distance from Home to School: " & FormatNumericValue(UserDistanceFromHome, " km")
        OtherNotesLabel.Text = "Other Notes: " & If(Not String.IsNullOrWhiteSpace(UserOtherNotes), UserOtherNotes, "N/A")

        ' Handle progress bars with safe numeric conversion
        SetupProgressBar(GunaProgressBar1, MotivationLevelLabel, UserData.UserMotivationLevel, "Motivation Level")
        SetupProgressBar(GunaParentalInvolvementProgressBar, ParentalInvolvementLabel, UserData.UserParentalInvolvement, "Parental Involvement")
        SetupProgressBar(GunaResourcesProgressBar, ResourceLabel, UserData.UserResourcesAccess, "Resources Access")
    End Sub

    Private Function FormatExamScores(scores As String) As String
        If String.IsNullOrWhiteSpace(scores) Then Return "N/A"

        ' Try to parse as number
        Dim numericValue As Double
        If Double.TryParse(scores, numericValue) Then
            Return numericValue.ToString("0.##") & "%"
        Else
            Return scores ' Return as-is if not purely numeric
        End If
    End Function

    Private Function FormatNumericValue(value As String, unit As String) As String
        If String.IsNullOrWhiteSpace(value) Then Return "N/A"

        Dim numericValue As Double
        If Double.TryParse(value, numericValue) Then
            Return numericValue.ToString("0.##") & unit
        Else
            Return value ' Return as-is if not purely numeric
        End If
    End Function

    Private Sub SetupProgressBar(progressBar As Guna.UI.WinForms.GunaProgressBar,
                               label As Label,
                               rawValue As Object,
                               labelPrefix As String)
        Dim valueStr As String = rawValue.ToString().Replace("%", "").Trim()
        Dim value As Integer

        If Integer.TryParse(valueStr, value) Then
            ' Ensure value is between 0-100
            value = Math.Max(0, Math.Min(100, value))
            label.Text = $"{labelPrefix}: {value}%"
            progressBar.Maximum = 100
            progressBar.Value = value

            ' Set color based on value
            Select Case value
                Case >= 80
                    progressBar.ProgressMinColor = Color.ForestGreen
                    progressBar.ProgressMaxColor = Color.LimeGreen
                Case >= 50
                    progressBar.ProgressMinColor = Color.Orange
                    progressBar.ProgressMaxColor = Color.Gold
                Case Else
                    progressBar.ProgressMinColor = Color.DarkRed
                    progressBar.ProgressMaxColor = Color.Red
            End Select
        Else
            label.Text = $"{labelPrefix}: N/A"
            progressBar.Value = 0
        End If
    End Sub

    Private Sub GunaButtonNext_Click(sender As Object, e As EventArgs) Handles GunaButtonNext.Click
        ' Prepare data for the Flask API
        Dim postData As New Specialized.NameValueCollection
        postData.Add("Hours_Studied", GetNumericValue(UserStudyHours))
        postData.Add("Attendance", "90") ' Default value or get from user data
        postData.Add("Parental_Involvement", GetNumericValue(UserData.UserParentalInvolvement))
        postData.Add("Access_to_Resources", GetNumericValue(UserData.UserResourcesAccess))
        postData.Add("Extracurricular_Activities", If(Not String.IsNullOrWhiteSpace(UserExtracurricularActivities), UserExtracurricularActivities, "medium"))
        postData.Add("Sleep_Hours", GetNumericValue(UserSleepHours))
        postData.Add("Previous_Scores", GetNumericValue(UserExamScores))
        postData.Add("Motivation_Level", GetNumericValue(UserData.UserMotivationLevel))
        postData.Add("Internet_Access", If(Not String.IsNullOrWhiteSpace(UserInternetAccess), UserInternetAccess, "yes"))
        postData.Add("Tutoring_Sessions", GetNumericValue(UserTutoringSessions))
        postData.Add("Family_Income", "medium") ' Default value or get from user data
        postData.Add("Teacher_Quality", "good") ' Default value or get from user data
        postData.Add("School_Type", If(Not String.IsNullOrWhiteSpace(UserSchoolType), UserSchoolType, "public"))
        postData.Add("Peer_Influence", "positive") ' Default value or get from user data
        postData.Add("Physical_Activity", If(Not String.IsNullOrWhiteSpace(UserPhysicalActivities), UserPhysicalActivities, "medium"))
        postData.Add("Learning_Disabilities", If(Not String.IsNullOrWhiteSpace(UserLearningDisability), UserLearningDisability, "no"))
        postData.Add("Parental_Education_Level", If(Not String.IsNullOrWhiteSpace(UserParentalEducation), UserParentalEducation, "some_college"))
        postData.Add("Distance_from_Home", GetNumericValue(UserDistanceFromHome))
        postData.Add("Gender", If(Not String.IsNullOrWhiteSpace(UserGender), UserGender, "male"))

        ' Show loading indicator
        GunaButtonNext.Enabled = False
        GunaButtonNext.Text = "Processing..."

        ' Send data to Flask API (run this in background)
        Dim apiUrl As String = "http://localhost:5000/api/predict" ' Update with your Flask server URL
        client.Headers(Net.HttpRequestHeader.ContentType) = "application/json"

        ' Convert NameValueCollection to JSON
        Dim json As String = "{"
        For Each key As String In postData.AllKeys
            json &= $"""{key}"":""{postData(key)}"","
        Next
        json = json.TrimEnd(",") & "}"

        ' Upload data asynchronously
        client.UploadStringAsync(New Uri(apiUrl), "POST", json)
    End Sub

    Private Sub client_UploadStringCompleted(sender As Object, e As Net.UploadStringCompletedEventArgs) Handles client.UploadStringCompleted
        ' Process the response from Flask API
        Me.Invoke(Sub()
                      GunaButtonNext.Enabled = True
                      GunaButtonNext.Text = "Next"

                      If e.Error IsNot Nothing Then
                          MessageBox.Show($"Error communicating with prediction service: {e.Error.Message}",
                                         "Error",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Error)
                          Return
                      End If

                      Try
                          ' Parse the JSON response
                          Dim response As String = e.Result
                          Dim prediction As String = "N/A"

                          ' Simple JSON parsing (for .NET without JSON library)
                          If response.Contains("predicted_grade") Then
                              Dim startIdx As Integer = response.IndexOf("predicted_grade") + 16
                              Dim endIdx As Integer = response.IndexOf("}", startIdx)
                              If endIdx = -1 Then endIdx = response.Length
                              prediction = response.Substring(startIdx, endIdx - startIdx).Trim()

                              ' Show the prediction result
                              Dim analyzeForm As New AnalyzeForm()
                              analyzeForm.SetPredictionResult(prediction)
                              analyzeForm.Show()
                              Me.Hide()
                          ElseIf response.Contains("error") Then
                              MessageBox.Show($"Prediction error: {response}",
                                             "Error",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error)
                          End If
                      Catch ex As Exception
                          MessageBox.Show($"Error processing prediction result: {ex.Message}",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error)
                      End Try
                  End Sub)
    End Sub

    Private Function GetNumericValue(value As Object) As String
        If value Is Nothing Then Return "0"

        Dim valueStr As String = value.ToString()
        Dim numericValue As Double

        ' Try to extract numeric value from string
        If Double.TryParse(valueStr.Replace("%", "").Trim(), numericValue) Then
            Return numericValue.ToString()
        Else
            Return "0" ' Default value if parsing fails
        End If
    End Function

    ' Other existing methods...
    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Me.Hide()
        Dim studentForm As New StudentProfileForm()
        studentForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles MinButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub AnalyzeButton_Click(sender As Object, e As EventArgs) Handles AnalyzeButton.Click
        Dim analyzeForm As New AnalyzeForm()
        analyzeForm.Show()
        Me.Hide()
    End Sub

    ' ... (keep all other existing methods)
End Class