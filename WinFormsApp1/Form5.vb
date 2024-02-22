Imports System.Data.SqlClient

Public Class Form5

    Dim connectionString As String = "Data Source=LAPTOP-OIMBR982\SQLEXPRESS;Initial Catalog=ScienceQuestionsDB;Integrated Security=True"

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load questions and options from the database
        LoadQuestions()
    End Sub

    Private Sub LoadQuestions()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT QuestionID, QuestionText, Option1, Option2, Option3, Option4 FROM ScienceQuestions ORDER BY QuestionID"
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        Dim questionIndex As Integer = 1
                        Do While reader.Read() AndAlso questionIndex <= 10
                            ' Display the question
                            Dim richTextBoxName As String = "question" & questionIndex.ToString() & "RichTextBox"
                            Dim questionText As String = reader("QuestionText").ToString()
                            Dim richTextBox As RichTextBox = DirectCast(Me.Controls.Find(richTextBoxName, True).FirstOrDefault(), RichTextBox)
                            richTextBox.Text = questionText

                            ' Display the options
                            For optionIndex As Integer = 1 To 4
                                Dim optionRadioButtonName As String = "question" & questionIndex.ToString() & "Option" & optionIndex.ToString()
                                Dim optionText As String = reader("Option" & optionIndex.ToString()).ToString()
                                Dim radioButton As RadioButton = DirectCast(Me.Controls.Find(optionRadioButtonName, True).FirstOrDefault(), RadioButton)
                                radioButton.Text = optionText
                            Next

                            questionIndex += 1
                        Loop
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading questions: " & ex.Message)
        End Try
    End Sub

    Private Sub CalculateScoreButton_Click(sender As Object, e As EventArgs) Handles calculateScoreButton.Click
        Dim score = CalculateScore()
        scoreTextBox.Text = score.ToString
    End Sub

    Private Function CalculateScore() As Integer
        Dim score As Integer = 0
        For questionIndex As Integer = 1 To 10
            Dim selectedOption As Integer = GetSelectedOption(questionIndex)
            Dim correctOption As Integer = GetCorrectOption(questionIndex)
            If selectedOption = correctOption Then
                score += 1
            End If
        Next
        Return score
    End Function

    Private Function GetSelectedOption(questionIndex As Integer) As Integer
        Dim optionRadioButtonName As String = "question" & questionIndex.ToString() & "Option"
        For optionIndex As Integer = 1 To 4
            Dim radioButton As RadioButton = DirectCast(Me.Controls.Find(optionRadioButtonName & optionIndex.ToString(), True).FirstOrDefault(), RadioButton)
            If radioButton IsNot Nothing AndAlso radioButton.Checked Then
                Return optionIndex
            End If
        Next
        Return -1 ' No option selected
    End Function

    Private Function GetCorrectOption(questionIndex As Integer) As Integer
        Dim connectionString As String = "Data Source=LAPTOP-OIMBR982\SQLEXPRESS;Initial Catalog=ScienceQuestionsDB;Integrated Security=True"
        Dim correctOption As Integer = -1
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT CorrectOption FROM ScienceQuestions WHERE QuestionID = @QuestionID"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@QuestionID", questionIndex)
                    correctOption = Convert.ToInt32(command.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while fetching correct option: " & ex.Message)
        End Try
        Return correctOption
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Form3.Show()
    End Sub

    Private Sub GroupBox8_Enter(sender As Object, e As EventArgs) Handles GroupBox8.Enter

    End Sub
End Class
