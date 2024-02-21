Imports System.Data.SqlClient

Public Class Form5

    Dim connectionString As String = "Data Source=LAPTOP-OIMBR982\SQLEXPRESS;Initial Catalog=ScienceQuestionsDB;Integrated Security=True"
    Dim correctOptions As New Dictionary(Of Integer, Integer)()

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load questions and options from the database
        LoadQuestions()
    End Sub

    Private Sub LoadQuestions()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT QuestionID, QuestionText, Option1, Option2, Option3, Option4, CorrectOption FROM ScienceQuestions ORDER BY QuestionID"
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim questionID As Integer = Convert.ToInt32(reader("QuestionID"))

                            ' Store correct options
                            Dim correctOption As Integer = Convert.ToInt32(reader("CorrectOption"))
                            correctOptions.Add(questionID, correctOption)

                            ' Get the corresponding GroupBox name
                            Dim groupBoxName As String = "GroupBox" & questionID.ToString()
                            Dim groupBox As GroupBox = DirectCast(Me.Controls.Find(groupBoxName, True).FirstOrDefault(), GroupBox)

                            If groupBox IsNot Nothing Then
                                ' Set the question to the RichTextBox
                                Dim richTextBox As RichTextBox = DirectCast(groupBox.Controls.Find("RichTextBox" & questionID.ToString(), True).FirstOrDefault(), RichTextBox)
                                richTextBox.Text = reader("QuestionText").ToString()

                                ' Set the options to the RadioButtons
                                For i As Integer = 1 To 4
                                    Dim optionText As String = reader("Option" & i.ToString()).ToString()
                                    Dim radioButton As RadioButton = DirectCast(groupBox.Controls.Find("RadioButton" & i.ToString(), True).FirstOrDefault(), RadioButton)
                                    radioButton.Text = optionText
                                Next
                            End If
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading questions: " & ex.Message)
        End Try
    End Sub

    Private Sub CalculateScoreButton_Click(sender As Object, e As EventArgs) Handles CalculateScoreButton.Click
        Dim score As Integer = CalculateScore()
        scoreTextBox.Text = score.ToString()
    End Sub

    Private Function CalculateScore() As Integer
        Dim score As Integer = 0
        For questionIndex As Integer = 1 To 10
            Dim selectedOption As Integer = GetSelectedOption(questionIndex)
            Dim correctOption As Integer = correctOptions(questionIndex)
            If selectedOption = correctOption Then
                score += 1
            End If
        Next
        Return score
    End Function

    Private Function GetSelectedOption(questionID As Integer) As Integer
        Dim groupName As String = "GroupBox" & questionID.ToString()
        Dim groupBox As GroupBox = DirectCast(Me.Controls.Find(groupName, True).FirstOrDefault(), GroupBox)
        If groupBox IsNot Nothing Then
            For i As Integer = 1 To 4
                Dim radioButton As RadioButton = DirectCast(groupBox.Controls.Find("RadioButton" & i.ToString(), True).FirstOrDefault(), RadioButton)
                If radioButton IsNot Nothing AndAlso radioButton.Checked Then
                    Return i
                End If
            Next
        End If
        Return -1 ' No option selected
    End Function
End Class
