Imports System.Data.SqlClient

Public Class Form9

    Dim connectionString As String = "Data Source=LAPTOP-OIMBR982\SQLEXPRESS;Initial Catalog=userDetails;Integrated Security=True"

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles confirmButton.Click
        Dim email As String = emailBox.Text
        Dim username As String = userNameBox.Text
        Dim password As String = passwordBox.Text
        Dim confirmPassword As String = confirmPasswordBox.Text

        If password <> confirmPassword Then
            MessageBox.Show("Passwords do not match. Please try again.")
            Return
        End If

        ' Update password in the database
        UpdatePassword(email, username, password)
    End Sub

    Private Sub UpdatePassword(email As String, username As String, password As String)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "UPDATE users SET Password = @Password WHERE Email = @Email AND Username = @Username"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Password", password)
                    command.Parameters.AddWithValue("@Email", email)
                    command.Parameters.AddWithValue("@Username", username)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Password updated successfully.")
                        ' Redirect to Form1 after updating password
                        Me.Hide()
                        Dim form1 As New Form1()
                        form1.Show()
                    Else
                        MessageBox.Show("Failed to update password. User not found.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while updating password: " & ex.Message)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
