Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces



Public Class Calculate





    Private fcon As New FirebaseConfig() With
            {
            .AuthSecret = "lqM1tlY8gSrMe4RAfFO5Z606eVnBCzBGaqcr1zHI",
            .BasePath = "https://tryone-4950d-default-rtdb.firebaseio.com/"
        }

    Private client As IFirebaseClient


    Private Sub Calculate_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch
            MessageBox.Show("there was a problem in internet connection")
        End Try

    End Sub








    Dim p As Double
    Dim s As Double
    Dim a As Double
    Dim b As Double
    Dim c As Double
    Dim d As Double
    Dim f As Double
    Dim g As Double
    Dim h As Double
    Dim i As Double
    Dim k As Double
    Dim l As Double





    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        p = CDbl(first.Text)
        s = CDbl(TextBox3.Text)
        a = CDbl(TextBox6.Text)
        b = CDbl(TextBox8.Text)
        c = CDbl(TextBox10.Text)
        d = CDbl(TextBox12.Text)
        f = CDbl(TextBox13.Text)
        g = CDbl(TextBox16.Text)
        h = CDbl(TextBox18.Text)
        i = CDbl(TextBox20.Text)
        k = CDbl(TextBox26.Text)
        l = CDbl(TextBox23.Text)




        If p >= 90 Then
            second.Text = "A"
        End If
        If p >= 80 And p < 90 Then
            second.Text = "B"
        End If
        If p >= 65 And p < 80 Then
            second.Text = "C"
        End If
        If p >= 50 And p < 65 Then
            second.Text = "D"
        End If
        If p >= 35 And p < 50 Then
            second.Text = "E"
        End If
        If p >= 0 And p < 35 Then
            second.Text = "F"
        End If



        If s >= 90 Then
            TextBox4.Text = "A"
        End If
        If s >= 80 And s < 90 Then
            TextBox4.Text = "B"
        End If
        If s >= 65 And s < 80 Then
            TextBox4.Text = "C"
        End If
        If s >= 50 And s < 65 Then
            TextBox4.Text = "D"
        End If
        If s >= 35 And s < 50 Then
            TextBox4.Text = "E"
        End If
        If s >= 0 And s < 35 Then
            TextBox4.Text = "F"
        End If


        If a >= 90 Then
            TextBox5.Text = "A"
        End If
        If a >= 80 And a < 90 Then
            TextBox5.Text = "B"
        End If
        If a >= 65 And a < 80 Then
            TextBox5.Text = "C"
        End If
        If a >= 50 And a < 65 Then
            TextBox5.Text = "D"
        End If
        If a >= 35 And a < 50 Then
            TextBox5.Text = "E"
        End If
        If a >= 0 And a < 35 Then
            TextBox5.Text = "F"
        End If


        If b >= 90 Then
            TextBox7.Text = "A"
        End If
        If b >= 80 And b < 90 Then
            TextBox7.Text = "B"
        End If
        If b >= 65 And b < 80 Then
            TextBox7.Text = "C"
        End If
        If b >= 50 And b < 65 Then
            TextBox7.Text = "D"
        End If
        If b >= 35 And b < 50 Then
            TextBox7.Text = "E"
        End If
        If b >= 0 And b < 35 Then
            TextBox7.Text = "F"
        End If



        If c >= 90 Then
            TextBox9.Text = "A"
        End If
        If c >= 80 And c < 90 Then
            TextBox9.Text = "B"
        End If
        If c >= 65 And c < 80 Then
            TextBox9.Text = "C"
        End If
        If c >= 50 And c < 65 Then
            TextBox9.Text = "D"
        End If
        If c >= 35 And c < 50 Then
            TextBox9.Text = "E"
        End If
        If c >= 0 And c < 35 Then
            TextBox9.Text = "F"
        End If



        If d >= 90 Then
            TextBox11.Text = "A"
        End If
        If d >= 80 And d < 90 Then
            TextBox11.Text = "B"
        End If
        If d >= 65 And d < 80 Then
            TextBox11.Text = "C"
        End If
        If d >= 50 And d < 65 Then
            TextBox11.Text = "D"
        End If
        If d >= 35 And d < 50 Then
            TextBox11.Text = "E"
        End If
        If d >= 0 And d < 35 Then
            TextBox11.Text = "F"
        End If



        If f >= 90 Then
            TextBox14.Text = "A"
        End If
        If f >= 80 And f < 90 Then
            TextBox14.Text = "B"
        End If
        If f >= 65 And f < 80 Then
            TextBox14.Text = "C"
        End If
        If f >= 50 And f < 65 Then
            TextBox14.Text = "D"
        End If
        If f >= 35 And f < 50 Then
            TextBox14.Text = "E"
        End If
        If f >= 0 And f < 35 Then
            TextBox14.Text = "F"
        End If



        If g >= 90 Then
            TextBox15.Text = "A"
        End If
        If g >= 80 And g < 90 Then
            TextBox15.Text = "B"
        End If
        If g >= 65 And g < 80 Then
            TextBox15.Text = "C"
        End If
        If g >= 50 And g < 65 Then
            TextBox15.Text = "D"
        End If
        If g >= 35 And g < 50 Then
            TextBox15.Text = "E"
        End If
        If g >= 0 And g < 35 Then
            TextBox15.Text = "F"
        End If



        If h >= 90 Then
            TextBox17.Text = "A"
        End If
        If h >= 80 And h < 90 Then
            TextBox17.Text = "B"
        End If
        If h >= 65 And h < 80 Then
            TextBox17.Text = "C"
        End If
        If h >= 50 And h < 65 Then
            TextBox17.Text = "D"
        End If
        If h >= 35 And h < 50 Then
            TextBox17.Text = "E"
        End If
        If h >= 0 And h < 35 Then
            TextBox17.Text = "F"
        End If



        If i >= 90 Then
            TextBox19.Text = "A"
        End If
        If i >= 80 And i < 90 Then
            TextBox19.Text = "B"
        End If
        If i >= 65 And i < 80 Then
            TextBox19.Text = "C"
        End If
        If i >= 50 And i < 65 Then
            TextBox19.Text = "D"
        End If
        If i >= 35 And i < 50 Then
            TextBox19.Text = "E"
        End If
        If i >= 0 And i < 35 Then
            TextBox19.Text = "F"
        End If



        If k >= 90 Then
            TextBox25.Text = "A"
        End If
        If k >= 80 And k < 90 Then
            TextBox25.Text = "B"
        End If
        If k >= 65 And k < 80 Then
            TextBox25.Text = "C"
        End If
        If k >= 50 And k < 65 Then
            TextBox25.Text = "D"
        End If
        If k >= 35 And k < 50 Then
            TextBox25.Text = "E"
        End If
        If k >= 0 And k < 35 Then
            TextBox25.Text = "F"
        End If


        If l >= 90 Then
            TextBox2.Text = "A"
        End If
        If l >= 80 And l < 90 Then
            TextBox2.Text = "B"
        End If
        If l >= 65 And l < 80 Then
            TextBox2.Text = "C"
        End If
        If l >= 50 And l < 65 Then
            TextBox2.Text = "D"
        End If
        If l >= 35 And l < 50 Then
            TextBox2.Text = "E"
        End If
        If l >= 0 And l < 35 Then
            TextBox2.Text = "F"
        End If




        TextBox24.Text = Val(first.Text) + Val(TextBox3.Text) + Val(TextBox6.Text) + Val(TextBox8.Text) + Val(TextBox10.Text) + Val(TextBox12.Text) + Val(TextBox13.Text) + Val(TextBox16.Text) + Val(TextBox18.Text) + Val(TextBox20.Text) + Val(TextBox26.Text) + Val(TextBox23.Text) / 12


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim std As New Student() With
            {
            .FullName = TextBox21.Text,
            .Clas = TextBox22.Text,
            .Math_marks = first.Text,
                 .Geo_marks = TextBox3.Text,
                    .Phy_marks = TextBox6.Text,
                       .Bio_marks = TextBox8.Text,
                          .Chem_marks = TextBox10.Text,
                             .Engl_marks = TextBox12.Text,
                              .Entr_marks = TextBox3.Text,
                                 .Hist_marks = TextBox16.Text,
                                    .Kisw_marks = TextBox18.Text,
                                       .Cra_marks = TextBox20.Text,
                                          .Tail_marks = TextBox26.Text,
                                             .Lug_marks = TextBox23.Text,
                                                .Aver = TextBox24.Text
        }
        Dim setter = client.Set("Studentmarks/" + TextBox21.Text, std)
        MessageBox.Show("Data stored succesful")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim st As New Student() With
         {
           .FullName = TextBox21.Text,
       .Math_grade = second.Text,
        .Geo_grade = TextBox4.Text,
          .Phy_grades = TextBox5.Text,
            .Bio_grades = TextBox7.Text,
              .Chem_grades = TextBox9.Text,
                .Engl_grade = TextBox11.Text,
                  .Entr_grades = TextBox14.Text,
                    .Hist_grades = TextBox15.Text,
                      .Kisw_grades = TextBox17.Text,
                        .Cra_grades = TextBox19.Text,
                          .Tail_grades = TextBox25.Text,
                            .Lug_grades = TextBox2.Text
             }
        Dim setter = client.Set("Studentgrades/" + TextBox21.Text, st)
        MessageBox.Show("Data stored succesful")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class