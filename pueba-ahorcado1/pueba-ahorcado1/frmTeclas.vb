Public Class frmTeclas
    Private Sub frmTeclas_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        MsgBox(e.KeyCode.ToString)
    End Sub
End Class
