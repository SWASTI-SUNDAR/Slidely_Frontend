Imports System.Net.Http
Imports Newtonsoft.Json.Linq
Imports System.Threading.Tasks

Public Class SearchForm
    Private Async Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim email As String = txtEmailSearch.Text

        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/search?email={email}")
            If response.IsSuccessStatusCode Then
                Dim content As String = Await response.Content.ReadAsStringAsync()
                Dim submissions As JArray = JArray.Parse(content)
                If submissions.Count > 0 Then
                    Dim submission As JObject = submissions(0)
                    txtName.Text = submission("name").ToString()
                    txtEmail.Text = submission("email").ToString()
                    txtPhone.Text = submission("phone").ToString()
                    txtGitHub.Text = submission("github_link").ToString()
                    txtStopwatch.Text = submission("stopwatch_time").ToString()
                Else
                    MessageBox.Show("No submissions found with this email.")
                End If
            Else
                MessageBox.Show("Search failed.")
            End If
        End Using
    End Sub
End Class
