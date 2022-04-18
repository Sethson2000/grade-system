Public Class main
    'Fields
    Private currentChildForm As Form

    Private Sub OpenChildForm(ByVal childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Paneldeskitop.Controls.Add(childForm)
        Paneldeskitop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()

        'FORM
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True



    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Label3.Text = "P1" Then
            PictureBox6.Image = My.Resources.IMG_20220405_141258
            Label3.Text = "P2"

        ElseIf Label3.Text = "P2" Then
            PictureBox6.Image = My.Resources.IMG_20220405_141337

            Label3.Text = "P3"

        ElseIf Label3.Text = "P3" Then
            PictureBox6.Image = My.Resources.IMG_20220405_141413

            Label3.Text = "P1"


        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Label4.Text = "P1" Then
            PictureBox7.Image = My.Resources.IMG_20220405_141535

            Label4.Text = "P2"

        ElseIf Label4.Text = "P2" Then
            PictureBox7.Image = My.Resources.IMG_20220405_141507


            Label4.Text = "P3"

        ElseIf Label4.Text = "P3" Then
            PictureBox7.Image = My.Resources.IMG_20220405_141628


            Label4.Text = "P1"


        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If Label5.Text = "P1" Then
            PictureBox8.Image = My.Resources.IMG_20220405_141731


            Label5.Text = "P2"

        ElseIf Label5.Text = "P2" Then
            PictureBox8.Image = My.Resources.IMG_20220405_141650



            Label5.Text = "P3"

        ElseIf Label5.Text = "P3" Then
            PictureBox8.Image = My.Resources.IMG_20220405_141804



            Label5.Text = "P1"


        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If Label6.Text = "P1" Then
            PictureBox9.Image = My.Resources.IMG_20220405_150403



            Label6.Text = "P2"

        ElseIf Label6.Text = "P2" Then
            PictureBox9.Image = My.Resources.scnd
            Label6.Text = "P3"

        ElseIf Label6.Text = "P3" Then
            PictureBox9.Image = My.Resources.thrd




            Label6.Text = "P1"


        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub



    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Application.Exit()

    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = DateTime.Now.ToString("hh:mm dddd, dd MMMM yyyy")
    End Sub



    Private Sub PictureBox2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        OpenChildForm(New calculate)
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        OpenChildForm(New repo)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenChildForm(New Calculate)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenChildForm(New Repo)
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OpenChildForm(New Help)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenChildForm(New Privacy)
    End Sub
End Class