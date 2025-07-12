
'Imports System.Data.SqlClient
'Imports System.Security.Cryptography
'Imports System.Text
Public Class newLoginForm
    'Public Function HashPassword(password As String) As String
    'Using sha256 As SHA256 = SHA256.Create()
    'Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
    'Dim hash As Byte() = sha256.ComputeHash(bytes)
    'Return Convert.ToBase64String(hash)
    'End Using
    'End Function
    Public Property UserRole As String
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim signUpForm = New SignUpForm()
        signUpForm.Show()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub loginGunaButton1_Click(sender As Object, e As EventArgs) Handles loginGunaButton1.Click
        Dim email As String = usernameGunaLineTextBox.Text.Trim()
        Dim password As String = PasswordGunaLineTextBox.Text.Trim()
        ' If email = "" OrElse password = "" Then
        'MessageBox.Show("Please enter both email and password.")
        'Return
        'End If
        'Dim hashedPassword As String = HashPassword(password)
        'Dim connectionString As String = "Data Source=YOUR_SERVER;Initial Catalog=YOUR_DATABASE;Integrated Security=True"
        'Using conn As New SqlConnection(connectionString)
        'Dim query As String = "SELECT COUNT(*) FROM Users WHERE Email = @Email AND PasswordHash = @PasswordHash"
        'Using cmd As New SqlCommand(query, conn)
        'cmd.Parameters.AddWithValue("@Email", email)
        ' cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword)
        'conn.Open()
        'Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

        'If count > 0 Then
        MessageBox.Show("Login successful!")
        ' Redirect to dashboard
        ' Dim dashboard As New DashboardForm()
        ' dashboard.Show()
        ' Me.Hide()
        'Else
        ' MessageBox.Show("Invalid email or password.")
        'End If
        'End Using
        ' End Using
        'opens the student profile form
        Dim studentForm As New StudentProfileForm()
        studentForm.Show()
        Me.Hide()
    End Sub

    Private Sub GunaCirclePictureBox1_Click(sender As Object, e As EventArgs) Handles GunaCirclePictureBox1.Click

    End Sub
End Class