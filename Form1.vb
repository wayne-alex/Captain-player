Public Class CaptainPlayer
    Private Sub CaptainPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = Guna2PictureBox1
        Label2.Parent = Guna2PictureBox1

        Dim user As String = SystemInformation.UserDomainName
        Guna2TextBox1.Text = "C:\Users\" + user + "\Videos"
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click, Guna2Button2.Click
        Form2.Show()
        Me.Hide()

    End Sub
End Class
