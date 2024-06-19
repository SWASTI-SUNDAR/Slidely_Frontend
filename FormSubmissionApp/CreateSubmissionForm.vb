Imports System.Net.Http
Imports Newtonsoft.Json.Linq
Imports System.Threading.Tasks
Imports System.Diagnostics

Public Class CreateSubmissionForm
    Private stopwatchRunning As Boolean = False
    Private stopwatch As New Stopwatch()

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True ' Enable key preview to capture key events
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatchRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        stopwatchRunning = Not stopwatchRunning
        txtStopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim phone As String = txtPhone.Text
        Dim github As String = txtGithub.Text
        Dim stopwatchTime As String = stopwatch.Elapsed.ToString("hh\:mm\:ss")

        Dim submission As New JObject()
        submission("name") = name
        submission("email") = email
        submission("phone") = phone
        submission("github_link") = github
        submission("stopwatch_time") = stopwatchTime

        Using client As New HttpClient()
            Dim content As New StringContent(submission.ToString(), System.Text.Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission successful")
            Else
                MessageBox.Show("Submission failed")
            End If
        End Using
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggleStopwatch.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub
End Class
