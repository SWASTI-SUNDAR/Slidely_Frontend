Imports System.Net.Http
Imports Newtonsoft.Json.Linq
Imports System.Threading.Tasks

Public Class EditSubmissionForm
    Private submissionIndex As Integer

    Public Sub LoadSubmission(submission As JObject, index As Integer)
        txtName.Text = submission("name").ToString()
        txtEmail.Text = submission("email").ToString()
        txtPhone.Text = submission("phone").ToString()
        txtGitHub.Text = submission("github_link").ToString()
        txtStopwatch.Text = submission("stopwatch_time").ToString()
        submissionIndex = index
    End Sub

    Private Async Sub btnSubmitEdit_Click(sender As Object, e As EventArgs) Handles btnSubmitEdit.Click
        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim phone As String = txtPhone.Text
        Dim github As String = txtGitHub.Text
        Dim stopwatchTime As String = txtStopwatch.Text

        Dim updatedSubmission As New JObject()
        updatedSubmission("name") = name
        updatedSubmission("email") = email
        updatedSubmission("phone") = phone
        updatedSubmission("github_link") = github
        updatedSubmission("stopwatch_time") = stopwatchTime

        Using client As New HttpClient()
            Dim content As New StringContent(updatedSubmission.ToString(), System.Text.Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = Await client.PutAsync($"http://localhost:3000/update?index={submissionIndex}", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission updated successfully.")
                Me.Close()
            Else
                MessageBox.Show("Failed to update submission.")
            End If
        End Using
    End Sub

    Private Sub EditSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
