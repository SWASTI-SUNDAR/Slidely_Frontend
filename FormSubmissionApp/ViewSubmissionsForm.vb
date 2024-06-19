Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json.Linq

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private submissions As JArray

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True ' Enable key preview to capture key events
        Await LoadSubmissions()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Await LoadSubmission(currentIndex)
        Else
            MessageBox.Show("No submissions available.")
        End If
    End Sub

    Private Async Function LoadSubmissions() As Task
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.GetAsync("http://localhost:3000/read-all")
                If response.IsSuccessStatusCode Then
                    Dim content As String = Await response.Content.ReadAsStringAsync()
                    submissions = JArray.Parse(content)
                Else
                    MessageBox.Show("Failed to load submissions.")
                End If
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}")
            End Try
        End Using
    End Function

    Private Async Function LoadSubmission(index As Integer) As Task
        If submissions IsNot Nothing AndAlso index >= 0 AndAlso index < submissions.Count Then
            Dim submission As JObject = submissions(index)
            txtName.Text = submission("name").ToString()
            txtEmail.Text = submission("email").ToString()
            txtPhone.Text = submission("phone").ToString()
            txtGitHub.Text = submission("github_link").ToString()
            txtStopwatch.Text = submission("stopwatch_time").ToString()
        Else
            MessageBox.Show("No more submissions.")
        End If
    End Function

    Private Async Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If submissions IsNot Nothing AndAlso currentIndex > 0 Then
            currentIndex -= 1
            Await LoadSubmission(currentIndex)
        End If
    End Sub

    Private Async Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If submissions IsNot Nothing AndAlso currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            Await LoadSubmission(currentIndex)
        End If
    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.DeleteAsync($"http://localhost:3000/delete?index={currentIndex}")
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission deleted.")
                    Await LoadSubmissions()
                    If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
                        If currentIndex >= submissions.Count Then
                            currentIndex = submissions.Count - 1
                        End If
                        Await LoadSubmission(currentIndex)
                    Else
                        MessageBox.Show("No submissions available.")
                    End If
                Else
                    MessageBox.Show("Failed to delete submission.")
                End If
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}")
            End Try
        End Using
    End Sub

    Private Async Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim editForm As New EditSubmissionForm()
        If submissions IsNot Nothing AndAlso currentIndex >= 0 AndAlso currentIndex < submissions.Count Then
            editForm.LoadSubmission(submissions(currentIndex), currentIndex)
            editForm.ShowDialog()
            ' Reload submissions after editing
            Await LoadSubmissions()
            If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
                Await LoadSubmission(currentIndex)
            Else
                MessageBox.Show("No submissions available.")
            End If
        Else
            MessageBox.Show("Submission not found.")
        End If
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub
End Class
