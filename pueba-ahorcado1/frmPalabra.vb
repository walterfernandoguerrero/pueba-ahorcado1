Public Class frmPalabra

    Private Sub frmPalabra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = "Ingrese una Palabra para  " + frmAhorcadoNro2.lblNombre.Text
        txtMiPalabra.Text = ""
        txtMiPalabra.Focus()
        cbxPalabra.Checked = False

    End Sub

    Private Sub cbxPalabra_CheckedChanged(sender As Object, e As EventArgs) Handles cbxPalabra.CheckedChanged
        If (cbxPalabra.Checked = True) Then

            txtMiPalabra.PasswordChar = ""
        Else

            txtMiPalabra.PasswordChar = "*"
            txtMiPalabra.Focus()

        End If
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        frmAhorcadoNro2.txtPalabra.Text = txtMiPalabra.Text

        Close()
    End Sub
End Class