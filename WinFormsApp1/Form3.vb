Public Class Form3
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        ' Check which radio button is checked
        If scienceRadioButton.Checked Then
            ' Redirect to Form4 for Science subject
            Me.Hide() ' Hide the current form (Form3)
            Form5.Show() ' Show Form4
        ElseIf mathRadioButton.Checked Then
            ' Redirect to Form5 for Math subject
            Me.Hide() ' Hide the current form (Form3)
            Form6.Show() ' Show Form5
        ElseIf historyRadioButton.Checked Then
            ' Redirect to Form6 for History subject
            Me.Hide() ' Hide the current form (Form3)
            Form7.Show() ' Show Form6
        ElseIf sportsRadioButton.Checked Then
            ' Redirect to Form7 for Sports subject
            Me.Hide() ' Hide the current form (Form3)
            Form8.Show() ' Show Form7
        Else
            MessageBox.Show("Please choose a subject.") ' Display a message if no subject is chosen
        End If
    End Sub
End Class