Imports System.Net.Http
Imports System.Net.Mime.MediaTypeNames

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        lblStopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Collect data from the textboxes
        Dim name As String = Me.Name.Text
        Dim email As String = Me.Email.Text
        Dim phoneNumber As String = Me.PhoneNumber.Text
        Dim githubRepo As String = Me.GitHubRepo.Text

        ' Submit the data to the backend
        SubmitData(name, email, phoneNumber, githubRepo, stopwatch.Elapsed.ToString("hh\:mm\:ss"))

        ' Reset the form
        txtName.Clear()
        txtEmail.Clear()
        txtPhoneNumber.Clear()
        txtGitHubRepo.Clear()
        stopwatch.Reset()
        lblStopwatch.Text = "00:00:00"
    End Sub

    Private Async Sub SubmitData(name As String, email As String, phoneNumber As String, githubRepo As String, timeElapsed As String)
        Dim client As New HttpClient()
        Dim values As New Dictionary(Of String, String) From {
            {"name", name},
            {"email", email},
            {"phoneNumber", phoneNumber},
            {"githubRepo", githubRepo},
            {"timeElapsed", timeElapsed}
        }

        Dim content As New FormUrlEncodedContent(values)
        Await client.PostAsync("http://localhost:3000/submit", content)
    End Sub
End Class
