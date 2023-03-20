Public Class frmTeclas

    Private Sub JuegoAhorcado10LetrasConPalabrasPrecargadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnu10Letras.Click
        frmAhorcadoNro1.ShowDialog()
    End Sub

    Private Sub mnuPalabrasLibres_Click(sender As Object, e As EventArgs) Handles mnuPalabrasLibres.Click
        frmAhorcadoNro2.ShowDialog()
    End Sub

    Private Sub btnJuego1_Click(sender As Object, e As EventArgs) Handles btnJuego1.Click
        frmAhorcadoNro1.ShowDialog()
    End Sub



    Private Sub mnuJuegosAhorcado_Click(sender As Object, e As EventArgs) Handles mnuJuegosAhorcado.Click

    End Sub

    Private Sub btnJuego2_Click_1(sender As Object, e As EventArgs) Handles btnJuego2.Click
        frmAhorcadoNro2.ShowDialog()
    End Sub
End Class
