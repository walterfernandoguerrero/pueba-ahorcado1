Public Class frmAhorcadoNro2
    Dim contador As Integer
    Dim cont As Integer
    Dim palabra As String
    Dim cantletras As Integer
    Dim palabracontrol As String
    Dim relleno As String = "----------------------------------------------------------------------------------"
    Dim letra As String
    Dim LetraPalabra As String
    Dim CuentaIngresos As Integer
    Dim CuentaAciertos As Integer
    Dim CuentaErrores As Integer
    Dim Cuenta2Errores As Integer
    Dim seguir As Integer
    Dim control As Integer

    'Dim MisLetras(27) As String

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblPalabra.Click

    End Sub
    Private Sub jugar()
        cont = 0
        ' caracter = "_"
        palabra = txtPalabra.Text
        cantletras = Len(palabra)



        txtCuentaLetras.Text = cantletras



        For x = 1 To cantletras
            cont = cont + 1

            If (rbtFacil.Checked = True) Then ' copia primera y ultima letra

                If (x = 1) Then
                    Dim primera As String
                    primera = Mid(palabra, 1, x)
                    palabracontrol = Mid(primera, 1, x)
                Else
                    If (x = cantletras) Then
                        Dim ultima As String
                        ultima = Mid(palabra, 1, x)
                        palabracontrol = palabracontrol + Mid(ultima, x, 1)
                    Else
                        palabracontrol = palabracontrol + "-" ' Mid(relleno, 1, x)  ' a cada letra le da giuon si no
                    End If


                End If
            Else

                palabracontrol = Mid(relleno, 1, x)  ' a cada letra le doy un guion



            End If


            '  MsgBox(letras)
        Next
        lblControl.Text = palabracontrol 'guardo la palabra con los guiones esos
        txtLabel15.Text = palabracontrol
        txtLabel15.Show() 'Label5.Show()
        txtLetra.Visible = True 'TBletra.Show()
        txtLetra.Enabled = True
        txtLetra.Focus() 'TBletra.Focus()
        cbxChequeo.Enabled = False


    End Sub


    Private Sub frmAhorcadoNro2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnJugar.Enabled = False
        txtPalabra.Enabled = False
        txtLetra.Enabled = False
        rbtNormal.Checked = True
        ' gbxDificultad.Enabled = False
        cbxChequeo.Enabled = False
        lbxJugadores.Items.Clear()
        lboxPuntos.Items.Clear()
        'lbxJugadores.Items.Add("...........NOMBRES............")
        ' gbxDificultad.Enabled = False

        txtJugadores.Focus()
        txtJugadores.Enabled = True
        Limpieza()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnJugar.Click
        gbxDificultad.Enabled = False
        Label8.Text = ""
        Label8.Visible = True
        txtPalabra.Enabled = True
        If txtPalabra.Text <> "" Then
            jugar()
            Me.Size = New Size(800, 542)

        Else
            MsgBox("Ingrese una Palabra")
            frmPalabra.ShowDialog()
            txtPalabra.Focus()
        End If
        cbxChequeo.Checked = False
        txtPalabra.Enabled = False
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        Limpieza()


    End Sub

    Private Sub txtPalabra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPalabra.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            If txtPalabra.Text = "" Then
                MsgBox("El texto esta vacio")
            Else
                e.Handled = True
                jugar()

            End If

            txtPalabra.Enabled = False
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Limpieza()
        Close()
        lbxJugadores.Items.Clear()
    End Sub

    Private Sub txtLetra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLetra.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            If txtLetra.Text = "" Then
                MsgBox("--------INGRESE UNA LETRA...------------")
            Else
                e.Handled = True
                letra = txtLetra.Text
                ControlConisidencias()
            End If
        End If
    End Sub
    Sub ControlConisidencias()


        control = 0
        seguir = 0
        CuentaIngresos = CuentaIngresos + 1
        txtIntentos.Text = CuentaIngresos
        For index = 1 To cantletras
            LetraPalabra = Mid(palabra, index, 1) 'Agarra cada letra que introduje en la caja de texto
            ' MsgBox(LetraPalabra)

            If Asc(letra) = Asc(LetraPalabra) Then
                Mid(txtLabel15.Text, index, 1) = letra
                control = 1
                MsgBox("Muy bien Nusetra Palabra tiene  " + txtLetra.Text + "  siga asi. Ingrese otra Letra")
            End If
            Ganador()

        Next


        If control = 1 Then
            CuentaAciertos = CuentaAciertos + 1
            txtAciertos.Text = CuentaAciertos
            Label8.Text = Label8.Text + " " + letra

            ' MsgBox("Muy bien Nuetra Palabra tiene: " + txtLetra.Text + " siga asi.")
        Else
            If control = 0 Then
                MsgBox("Nuestra palabra no tiene la letra   " + txtLetra.Text + "  lo lamento. Ingrese otra Letra")
                If rbtDificil.Checked = True Then

                    CuentaErrores = CuentaErrores + 1
                    Cuenta2Errores = CuentaErrores * 2
                    txtFallos.Text = CuentaErrores
                    Label8.Text = Label8.Text + " " + letra
                    FallosDeLetras(Cuenta2Errores)

                    If CuentaErrores = 4 Then
                        seguir = 1
                        'Label8.Text = Label8.Text + " " + letra

                    End If

                Else
                    CuentaErrores = CuentaErrores + 1
                    txtFallos.Text = CuentaErrores
                    Label8.Text = Label8.Text + " " + letra
                    FallosDeLetras(CuentaErrores)
                    If CuentaErrores = 8 Then
                        seguir = 1
                        'Label8.Text = Label8.Text + " " + letra

                    End If
                End If





            End If
        End If

        If seguir = 0 Then

            txtLetra.Clear()
            txtLetra.Focus()
        Else
            If seguir = 2 Then
                FallosDeLetras(100)
            End If
            txtLetra.Clear()
            txtPalabra.Focus()

        End If

        txtIntentos.Text = CuentaIngresos
        txtAciertos.Text = CuentaAciertos
        txtFallos.Text = CuentaErrores
    End Sub
    Sub Ganador()
        Dim Restador As Integer
        Restador = cantletras
        For index = 1 To cantletras
            If Mid(txtLabel15.Text, index, 1) <> "-" Then
                Restador = Restador - 1
            End If
        Next
        If Restador = 0 Then
            seguir = 2
            control = 1
        End If

    End Sub
    Sub Limpieza()

        txtPalabra.Clear()
        lblControl.Text = ""
        txtLabel15.Clear()
        txtLetra.Clear()
        txtCuentaLetras.Clear()
        'txtPalabra.Focus()
        txtJugadores.Focus()
        txtAciertos.Clear()
        txtFallos.Clear()
        txtIntentos.Clear()
        CuentaIngresos = 0
        CuentaErrores = 0
        CuentaAciertos = 0
        PictureBox1.Image = Image.FromFile("C:\Users\Walter\source\repos\pueba-ahorcado1\pueba-ahorcado1\bin\Debug\img00.jpg")
        Label8.Text = ""
        'letra = ""
        'palabra = ""
        txtPalabra.Enabled = False
        txtLetra.Enabled = False
        btnJugar.Focus()
        Label8.Visible = False
        'lbxJugadores.Items.Clear()
        CargarJugador()
        rbtNormal.Checked = True
        gbxDificultad.Enabled = False
        btnJugar.Enabled = False
        cbxChequeo.Enabled = False
        lblCartelFinal.Text = ""
        Me.Size = New Size(1200, 542)
    End Sub
    Sub FallosDeLetras(Numero As Integer)
        'contador = contador + 1
        Select Case Numero
            Case 1
                Me.PictureBox1.Image = Image.FromFile("C:\Users\Walter\source\repos\pueba-ahorcado1\pueba-ahorcado1\bin\Debug\imgCadalzo.jpg")
            Case 2
                Me.PictureBox1.Image = Image.FromFile("C:\Users\Walter\source\repos\pueba-ahorcado1\pueba-ahorcado1\bin\Debug\img1.jpg")
            Case 3
                Me.PictureBox1.Image = Image.FromFile("C:\Users\Walter\source\repos\pueba-ahorcado1\pueba-ahorcado1\bin\Debug\img2.jpg")
            Case 4
                Me.PictureBox1.Image = Image.FromFile("C:\Users\Walter\source\repos\pueba-ahorcado1\pueba-ahorcado1\bin\Debug\img3.jpg")
            Case 5
                Me.PictureBox1.Image = Image.FromFile("C:\Users\Walter\source\repos\pueba-ahorcado1\pueba-ahorcado1\bin\Debug\img4.jpg")
            Case 6
                Me.PictureBox1.Image = Image.FromFile("C:\Users\Walter\source\repos\pueba-ahorcado1\pueba-ahorcado1\bin\Debug\img5.jpg")
            Case 7
                Me.PictureBox1.Image = Image.FromFile("C:\Users\Walter\source\repos\pueba-ahorcado1\pueba-ahorcado1\bin\Debug\img6.jpg")
            Case 8
                Me.PictureBox1.Image = Image.FromFile("C:\Users\Walter\source\repos\pueba-ahorcado1\pueba-ahorcado1\bin\Debug\pepeAhorcado.png")
                'MsgBox("Perdiste el juego")
                lblCartelFinal.Text = "¡¡P E R D I S T E!!"
                'txtFallos.Text = Numero
                'prueba de puntos
                Puntos(Numero)


                If MessageBox.Show("Desea seguir Jugando", "--LO SIENTO PERDISTE--", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                    seguir = 1
                    Limpieza()

                Else

                    Close()

                End If

            Case 100
                Me.PictureBox1.Image = Image.FromFile("C:\Users\Walter\source\repos\pueba-ahorcado1\pueba-ahorcado1\bin\Debug\ganador.jpg")
                'CuentaAciertos = CuentaAciertos + 1
                Puntos(Numero)
                lblCartelFinal.Text = "!! G A N A S T E ¡¡"
                If MessageBox.Show("Desea seguir Jugando", "--MUY BIEN ERES GANADOR--", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then


                    Limpieza()

                Else

                    Close()

                End If

                'Puntos(Numero)
        End Select

    End Sub

    Private Sub btnJugadores_Click(sender As Object, e As EventArgs) Handles btnJugadores.Click
        CargarLista()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbxChequeo.CheckedChanged

        If (cbxChequeo.Checked = True) Then

            txtPalabra.PasswordChar = ""
            txtPalabra.Enabled = True
        Else

            txtPalabra.PasswordChar = "*"
            txtPalabra.Focus()
            txtPalabra.Enabled = False

        End If

    End Sub

    Private Sub lbxJugadores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxJugadores.SelectedIndexChanged

        btnJugar.Enabled = True
        lblNombre.Text = lbxJugadores.SelectedItem.ToString
        Call SeleccionJugador()
        gbxDificultad.Enabled = True
        cbxChequeo.Enabled = True
        gbxDificultad.Enabled = True
        lblPuntos.Text = "0"


    End Sub
    Private Sub SeleccionJugador()
        Label11.Enabled = False
        Label10.Enabled = False
        txtJugadores.Enabled = False
        btnJugadores.Enabled = False
        lblPodesJugar.Enabled = False
    End Sub
    Private Sub CargarJugador()
        Label11.Enabled = True
        Label10.Enabled = True
        txtJugadores.Enabled = True
        btnJugadores.Enabled = True
        lblPodesJugar.Enabled = True
        lblNombre.Text = "NOMBRE"
    End Sub

    Private Sub txtJugadores_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJugadores.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            Call CargarLista()

        End If



    End Sub
    Private Sub CargarLista()

        If MessageBox.Show("Desea ingresar otro Jugador", "CARGA JUGADORES", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then

            lbxJugadores.Items.Add(txtJugadores.Text)
            txtJugadores.Text = ""
            txtJugadores.Focus()
            lboxPuntos.Items.Add(0)
        Else
            lbxJugadores.Items.Add(txtJugadores.Text)
            Call SeleccionJugador()
            gbxDificultad.Enabled = True
            txtJugadores.Text = ""
            lbxJugadores.SelectedIndex = 0
            lboxPuntos.Items.Add(0)


        End If

    End Sub
    Private Sub Puntos(num As Integer)
        Dim puntoaSumar As Integer
        Dim puntoaRestar As Integer
        Dim totalPuntos As Integer
        Dim indiceJugador As Integer


        puntoaSumar = CuentaAciertos * 5
        puntoaRestar = CuentaErrores * (-4)
        If num > 10 Then
            totalPuntos = 100 + puntoaSumar + puntoaRestar
        Else
            totalPuntos = 20 + puntoaSumar + puntoaRestar
        End If

        indiceJugador = lbxJugadores.SelectedIndex
        lboxPuntos.Items.RemoveAt(indiceJugador)
        lboxPuntos.Items.Insert(indiceJugador, totalPuntos)
        lblPuntos.Text = totalPuntos

    End Sub


End Class