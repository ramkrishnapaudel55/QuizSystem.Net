Imports System.Data.SqlClient

Public Class Form2

    Dim connectionString As String = "Data Source=LAPTOP-OIMBR982\SQLEXPRESS;Initial Catalog=userDetails;Integrated Security=True"

    Private Sub logInButton_Click(sender As Object, e As EventArgs) Handles logInButton.Click
        Dim username As String = logInUserName.Text
        Dim password As String = logInPassword.Text

        ' Validate if both username and password are entered
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.")
            Return
        End If

        ' Validate user credentials against the database
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT COUNT(*) FROM users WHERE Username = @Username AND Password = @Password"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", username)
                    command.Parameters.AddWithValue("@Password", password)
                    Dim result As Integer = CInt(command.ExecuteScalar())

                    If result > 0 Then
                        MessageBox.Show("Login successful.")
                        ' Redirect to the next form or perform other actions
                        ' Redirect to Form3
                        Me.Hide()   ' Hide the current form (Form2)
                        Form3.Show() ' Show Form3
                    Else
                        MessageBox.Show("Invalid username or password.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub


End Class
