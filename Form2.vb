Public Class Form2
    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint, Guna2Panel3.Paint

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2Panel2.BackColor = Color.FromArgb(100, 0, 0, 0)
        Guna2Panel3.BackColor = Color.FromArgb(100, 0, 0, 0)
        Guna2Panel2.Parent = Guna2PictureBox1
        Guna2Panel3.Parent = Guna2PictureBox1
    End Sub
End Class