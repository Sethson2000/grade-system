Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports Newtonsoft.Json
Imports System.IO

Public Class Repo





    Private fcon As New FirebaseConfig() With
            {
            .AuthSecret = "lqM1tlY8gSrMe4RAfFO5Z606eVnBCzBGaqcr1zHI",
            .BasePath = "https://tryone-4950d-default-rtdb.firebaseio.com/"
        }

    Private client As IFirebaseClient











    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 0, 0)
        Dim PrintView As RectangleF = e.PageSettings.PrintableArea

        If Me.GroupBox1.Height - PrintView.Height > 0 Then
            e.HasMorePages = True
        End If
    End Sub


    Private bitmap As Bitmap
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim height As Integer = GroupBox1.Height
        GroupBox1.Height = GroupBox1.Width * GroupBox1.Height
        bitmap = New Bitmap(Me.GroupBox1.Width, Me.GroupBox1.Height)
        GroupBox1.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.GroupBox1.Width, Me.GroupBox1.Height))
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
        GroupBox1.Height = height


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DataGridView1.ClearSelection()
        DataGridView2.ClearSelection()
    End Sub

    Private Sub Label51_Click(sender As Object, e As EventArgs) Handles Label51.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox2.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim res As FirebaseResponse = client.Get("Studentmarks")
        Dim data As Dictionary(Of String, Studentmarks) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Studentmarks))(res.Body.ToString())
        UpdateButton1(data)

    End Sub

    Private Sub Repo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch
            MessageBox.Show("there was a problem in internet connection")
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim res As FirebaseResponse = client.Get("Studentmarks")
        Dim data As Dictionary(Of String, Studentmarks) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Studentmarks))(res.Body.ToString())
        UpdateButton4(data)
    End Sub

    Sub UpdateButton1(ByVal records As Dictionary(Of String, Studentmarks))
        RichTextBox1.Clear()
        For Each item In records

            RichTextBox1.Text += "FullName" + item.Value.FullName + "\n"
            RichTextBox1.Text += "Clas" + item.Value.Clas + "\n"
            RichTextBox1.Text += "Math_marks" + item.Value.Math_marks + "\n"
            RichTextBox1.Text += "Engl_marks" + item.Value.Engl_marks + "\n"
            RichTextBox1.Text += "Bio_marks" + item.Value.Bio_marks + "\n"
            RichTextBox1.Text += "Geo_marks" + item.Value.Geo_marks + "\n"
            RichTextBox1.Text += "History_marks" + item.Value.Hist_marks + "\n"
            RichTextBox1.Text += "Chem_marks" + item.Value.Chem_marks + "\n"
            RichTextBox1.Text += "Kisw_marks" + item.Value.Kisw_marks + "\n"
            RichTextBox1.Text += "Phy_marks" + item.Value.Phy_marks + "\n"
            RichTextBox1.Text += "Entr_marks" + item.Value.Entr_marks + "\n"
            RichTextBox1.Text += "Lug_marks" + item.Value.Lug_marks + "\n"
            RichTextBox1.Text += "Cra_marks" + item.Value.Cra_marks + "\n"
            RichTextBox1.Text += "Tail_marks" + item.Value.Tail_marks + "\n"
            RichTextBox1.Text += "Aver" + item.Value.Aver + "\n"

        Next
    End Sub
    Sub UpdateButton4(ByVal records As Dictionary(Of String, Studentmarks))
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()

        DataGridView1.Columns.Add("FullName", "FullName")
        DataGridView1.Columns.Add("Clas", "Clas")
        DataGridView1.Columns.Add("Math_Marks", "Math_marks")
        DataGridView1.Columns.Add("Engl_marks", "Engl_marks")
        DataGridView1.Columns.Add("Bio_marks", "Bio_marks")
        DataGridView1.Columns.Add("Phy_marks", "Phy_marks")
        DataGridView1.Columns.Add("Chem_marks", "Chem_marks")
        DataGridView1.Columns.Add("Geo_marks", "Geo_marks")
        DataGridView1.Columns.Add("Kisw_marks", "Kisw_marks")
        DataGridView1.Columns.Add("Entr_marks", "Entr_marks")
        DataGridView1.Columns.Add("Lug_marks", "Lug_marks")
        DataGridView1.Columns.Add("Cra_marks", "Cra_marks")
        DataGridView1.Columns.Add("Tail_marks", "Tail_marks")

        DataGridView1.Columns.Add("Hist_marks", "Hist_marks")
        DataGridView1.Columns.Add("Aver", "Aver")


        For Each item In records
            DataGridView1.Rows.Add(item.Value.FullName, item.Value.Clas, item.Value.Math_marks, item.Value.Engl_marks, item.Value.Bio_marks, item.Value.Phy_marks, item.Value.Chem_marks, item.Value.Geo_marks, item.Value.Kisw_marks, item.Value.Entr_marks, item.Value.Cra_marks, item.Value.Hist_marks, item.Value.Tail_marks, item.Value.Bio_marks, item.Value.Lug_marks, item.Value.Aver)
        Next
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim ms As New MemoryStream







        Label4.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Label6.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        Label23.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        Label24.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        Label25.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        Label26.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        Label27.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
        Label28.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
        Label29.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value
        Label30.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value
        Label31.Text = DataGridView1.Rows(e.RowIndex).Cells(10).Value
        Label32.Text = DataGridView1.Rows(e.RowIndex).Cells(11).Value
        Label22.Text = DataGridView1.Rows(e.RowIndex).Cells(12).Value
        Label54.Text = DataGridView1.Rows(e.RowIndex).Cells(13).Value
        Label57.Text = DataGridView1.Rows(e.RowIndex).Cells(14).Value


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim res As FirebaseResponse = client.Get("Studentgrades")
        Dim data As Dictionary(Of String, Studentgrades) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Studentgrades))(res.Body.ToString())
        UpdateButton2(data)
    End Sub

    Sub UpdateButton2(ByVal records As Dictionary(Of String, Studentgrades))
        RichTextBox1.Clear()
        For Each item In records

            RichTextBox1.Text += "FullName" + item.Value.FullName + "\n"

            RichTextBox1.Text += "Math_grades" + item.Value.Math_grade + "\n"
            RichTextBox1.Text += "Engl_grade" + item.Value.Engl_grade + "\n"
            RichTextBox1.Text += "Bio_grade" + item.Value.Bio_grades + "\n"
            RichTextBox1.Text += "Geo_grade" + item.Value.Geo_grade + "\n"
            RichTextBox1.Text += "History_grades" + item.Value.Hist_grades + "\n"
            RichTextBox1.Text += "Chem_grades" + item.Value.Chem_grades + "\n"
            RichTextBox1.Text += "Kisw_grades" + item.Value.Kisw_grades + "\n"
            RichTextBox1.Text += "Phygrades" + item.Value.Phy_grades + "\n"
            RichTextBox1.Text += "Entr_grades" + item.Value.Entr_grades + "\n"
            RichTextBox1.Text += "Lug_grades" + item.Value.Lug_grades + "\n"
            RichTextBox1.Text += "Cra_grades" + item.Value.Cra_grades + "\n"
            RichTextBox1.Text += "Tail_grades" + item.Value.Tail_grades + "\n"


        Next
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim res As FirebaseResponse = client.Get("Studentgrades")
        Dim data As Dictionary(Of String, Studentgrades) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Studentgrades))(res.Body.ToString())
        UpdateButton7(data)
    End Sub

    Sub UpdateButton7(ByVal records As Dictionary(Of String, Studentgrades))
        DataGridView2.Rows.Clear()
        DataGridView2.Columns.Clear()

        DataGridView2.Columns.Add("FullName", "FullName")

        DataGridView2.Columns.Add("Math_grade", "Math_grade")
        DataGridView2.Columns.Add("Engl_grade", "Engl_grade")
        DataGridView2.Columns.Add("Bio_grade", "Bio_grades")
        DataGridView2.Columns.Add("Phy_grade", "Phy_grades")
        DataGridView2.Columns.Add("Chem_grades", "Chem_grades")
        DataGridView2.Columns.Add("Geo_grade", "Geo_grade")
        DataGridView2.Columns.Add("Kisw_grades", "Kisw_grades")
        DataGridView2.Columns.Add("Entr_grades", "Entr_grades")
        DataGridView2.Columns.Add("Lug_grades", "Lug_grades")
        DataGridView2.Columns.Add("Cra_grades", "Cra_grades")
        DataGridView2.Columns.Add("Tail_grades", "Tail_grades")

        DataGridView2.Columns.Add("Hist_grades", "Hist_grades")



        For Each item In records
            DataGridView2.Rows.Add(item.Value.FullName, item.Value.Math_grade, item.Value.Engl_grade, item.Value.Bio_grades, item.Value.Phy_grades, item.Value.Chem_grades, item.Value.Geo_grade, item.Value.Kisw_grades, item.Value.Entr_grades, item.Value.Cra_grades, item.Value.Hist_grades, item.Value.Tail_grades, item.Value.Bio_grades, item.Value.Lug_grades)
        Next
    End Sub


    Private Sub DataGridView2_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick

        Label45.Text = DataGridView2.Rows(e.RowIndex).Cells(1).Value
        Label44.Text = DataGridView2.Rows(e.RowIndex).Cells(2).Value
        Label43.Text = DataGridView2.Rows(e.RowIndex).Cells(3).Value
        Label42.Text = DataGridView2.Rows(e.RowIndex).Cells(4).Value
        Label41.Text = DataGridView2.Rows(e.RowIndex).Cells(5).Value
        Label40.Text = DataGridView2.Rows(e.RowIndex).Cells(6).Value
        Label39.Text = DataGridView2.Rows(e.RowIndex).Cells(7).Value
        Label38.Text = DataGridView2.Rows(e.RowIndex).Cells(8).Value
        Label37.Text = DataGridView2.Rows(e.RowIndex).Cells(9).Value
        Label36.Text = DataGridView2.Rows(e.RowIndex).Cells(10).Value
        Label53.Text = DataGridView2.Rows(e.RowIndex).Cells(11).Value
        Label56.Text = DataGridView2.Rows(e.RowIndex).Cells(12).Value





    End Sub
End Class