'Imports System.Data.SqlClient
'Imports System.Security.Cryptography
'Imports System.Text
Public Class SignUpForm
    ' Function to hash the password securely
    'Private Function HashPassword(password As String) As String
    'Using sha256 As SHA256 = SHA256.Create()
    'Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
    'Dim hash As Byte() = sha256.ComputeHash(bytes)
    'Return Convert.ToBase64String(hash)
    'End Using
    'End Function
    Private Sub usernameLabel2_Click(sender As Object, e As EventArgs) Handles usernameLabel2.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim roleForm As New RoleSelectionForm()
        roleForm.Show()
        Me.Hide()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub loginGunaButton1_Click(sender As Object, e As EventArgs) Handles loginGunaButton1.Click
        Dim email As String = EmailsignupTextBox.Text.Trim()
        Dim password As String = PasswordsignupTextBox.Text.Trim()

        'If email = "" OrElse password = "" Then
        MessageBox.Show("Please enter both email and password.")
        '   Return
        'End If

        'Dim hashedPassword As String = HashPassword(password)
        'Dim connectionString As String = "Data Source=YOUR_SERVER;Initial Catalog=YOUR_DATABASE;Integrated Security=True"

        'Using conn As New SqlConnection(connectionString)
        'conn.Open()

        ' First check if the user already exists
        'Dim checkQuery As String = "SELECT COUNT(*) FROM Users WHERE Email = @Email"
        'Using checkCmd As New SqlCommand(checkQuery, conn)
        'checkCmd.Parameters.AddWithValue("@Email", email)

        ' Dim userExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
        '   If userExists > 0 Then
        '  MessageBox.Show("This email is already registered.")
        'Return
        '  End If
        ' End Using

        ' Insert new user
        'Dim insertQuery As String = "INSERT INTO Users (Email, PasswordHash) VALUES (@Email, @PasswordHash)"
        'Using insertCmd As New SqlCommand(insertQuery, conn)
        'insertCmd.Parameters.AddWithValue("@Email", email)
        'insertCmd.Parameters.AddWithValue("@PasswordHash", hashedPassword)
        ' Dim rowsAffected As Integer = insertCmd.ExecuteNonQuery()
        'If rowsAffected > 0 Then
        ' MessageBox.Show("Signup successful! You can now log in.")
        ' Optionally redirect to login form
        ' Dim loginForm As New LoginForm()
        ' loginForm.Show()
        ' Me.Hide()
        ' Else
        ' MessageBox.Show("Signup failed. Please try again.")
        'End If
        ' End Using
        'End Using
        Dim roleForm As New RoleSelectionForm()
        roleForm.Show()
        Me.Hide()
    End Sub

End Class