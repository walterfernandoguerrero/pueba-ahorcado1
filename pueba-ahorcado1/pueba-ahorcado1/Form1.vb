Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PictureBox1.Image = Image.FromFile("C:\Users\Walter\Desktop\fotosEscritorio\Cuaresma.jpg")
    End Sub

    Private Sub btnCambiar_Click(sender As Object, e As EventArgs) Handles btnCambiar.Click
        Me.PictureBox1.Image = Image.FromFile("C:\Users\Walter\Desktop\fotosEscritorio\fondoZen.jpg")
    End Sub
End Class
