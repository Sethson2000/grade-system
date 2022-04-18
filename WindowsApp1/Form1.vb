Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces




Public Class Form1
    Private fcon As New FirebaseConfig() With
        {
        .AuthSecret = "lqM1tlY8gSrMe4RAfFO5Z606eVnBCzBGaqcr1zHI",
        .BasePath = "https://tryone-4950d-default-rtdb.firebaseio.com/"
    }

    Private client As IFirebaseClient


    Private Sub Form1_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Client = New FireSharp.FirebaseClient(fcon)
        Catch
            MessageBox.Show("there was a problem in internet connection")
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim std As New Student() With
            {
            .FullName = nameTbox.Text,
            .RollNo = rollTbox.Text,
            .Grade = gradeTbox.Text,
            .Section = secTbox.Text
        }
        Dim setter = client.Set("StudentList/" + rollTbox.Text, std)
        MessageBox.Show("Data stored succesful")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim res = client.Get("StudentList/" + rollTbox.Text)
        Dim std As New Student()
        std = res.ResultAs(Of Student)
        nameTbox.Text = std.FullName
        secTbox.Text = std.Section
        gradeTbox.Text = std.Grade


    End Sub
End Class
