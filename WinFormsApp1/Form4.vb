﻿
Imports System.Data.SqlClient
Public Class Form4

    Dim connectionString As String = "Data Source=LAPTOP-OIMBR982\SQLEXPRESS;Initial Catalog=userDetails;Integrated Security=True"


    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim fullName As String = fullNameBox.Text
        Dim email As String = emailBox.Text
        Dim username As String = userNameBox.Text
        Dim password As String = passwordBox.Text
        Dim confirmPassword As String = confirmPasswordBox.Text

        ' Validate if all fields are filled
        If String.IsNullOrEmpty(fullName) OrElse String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) OrElse String.IsNullOrEmpty(confirmPassword) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        ' Validate if password and confirm password match
        If password <> confirmPassword Then
            MessageBox.Show("Password and confirm password do not match.")
            Return
        End If

        ' Insert user details into database
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "INSERT INTO users (FullName, Email, Username, Password) VALUES (@FullName, @Email, @Username, @Password)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@FullName", fullName)
                    command.Parameters.AddWithValue("@Email", email)
                    command.Parameters.AddWithValue("@Username", username)
                    command.Parameters.AddWithValue("@Password", password)
                    command.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Signup successful. You can now sign in.")

            ' Redirect to Form2
            Me.Hide()   ' Hide the current form (Form4)
            Form2.Show() ' Show Form3
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Form1.Show()
    End Sub
End Class