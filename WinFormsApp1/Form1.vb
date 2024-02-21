Imports System.Data.SqlClient

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles signUp.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Data Source=LAPTOP-OIMBR982\SQLEXPRESS;Initial Catalog=HistoryQuestionsDB;Integrated Security=True"

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                If connection.State = ConnectionState.Open Then
                    MessageBox.Show("Database connected successfully.")
                Else
                    MessageBox.Show("Database connection failed.")
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

End Class
