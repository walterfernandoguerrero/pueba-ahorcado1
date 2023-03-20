Public Class frmAhorcadoNro1
    Dim caja As Object
    Dim intentos As Integer 'contador de intentos en el juego
    Dim aciertos As Integer ' contador de letras que estan en las cajas
    Dim errores As Integer  ' contador de fallos de lestras
    Private Sub btnJugar_Click(sender As Object, e As EventArgs) Handles btnJugar.Click

        Dim PalAleatoria As New Random 'variable para guardar un indice aleatorio
        Dim Contenedor As Integer ' para guardar el indice de un lisbox en este caso
        Dim i As Integer

        intentos = 0
        txtIntentos.Text = intentos
        aciertos = 0
        txtAciertos.Text = 0
        errores = 0
        txtErrores.Text = 0


        HabilitarTeclas()

        Contenedor = PalAleatoria.Next(0, LstPalabras.Items.Count) ' variable "Contenedor me guarda el indice de la palabra del listbox 
        'MsgBox(Contenedor)
        LstPalabras.SelectedIndex = Contenedor ' tomo la palabra del indice y la selecciono en azul

        MsgBox("La palabra Empieza con: " + Mid(LstPalabras.SelectedItem, 1, 1)) 'esta funcion Mid me saca caracteres de un string me muestra desde ,una posision la cantidad de caracteres que le pida

        i = 0
        For index = 1 To 10  'guardo cada letra en un textbox y la pinto de blanco
            i = i + 1
            Select Case i
                Case 1
                    TextBox1.Text = Mid(LstPalabras.SelectedItem, i, 1)
                    TextBox1.ForeColor = Color.Red
                Case 2
                    TextBox2.Text = Mid(LstPalabras.SelectedItem, i, 1)
                    TextBox2.ForeColor = Color.White
                Case 3
                    TextBox3.Text = Mid(LstPalabras.SelectedItem, i, 1)
                    TextBox3.ForeColor = Color.White
                Case 4
                    TextBox4.Text = Mid(LstPalabras.SelectedItem, i, 1)
                    TextBox4.ForeColor = Color.White
                Case 5
                    TextBox5.Text = Mid(LstPalabras.SelectedItem, i, 1)
                    TextBox5.ForeColor = Color.White
                Case 6
                    TextBox6.Text = Mid(LstPalabras.SelectedItem, i, 1)
                    TextBox6.ForeColor = Color.White
                Case 7
                    TextBox7.Text = Mid(LstPalabras.SelectedItem, i, 1)
                    TextBox7.ForeColor = Color.White
                Case 8
                    TextBox8.Text = Mid(LstPalabras.SelectedItem, i, 1)
                    TextBox8.ForeColor = Color.White
                Case 9
                    TextBox9.Text = Mid(LstPalabras.SelectedItem, i, 1)
                    TextBox9.ForeColor = Color.White
                Case 10
                    TextBox10.Text = Mid(LstPalabras.SelectedItem, i, 1)
                    TextBox10.ForeColor = Color.White
            End Select


        Next


    End Sub
    'funcion cargadora de datos
    Sub Coincidencia(LetraBoton As String) 'le paso el texto de 

        Dim contador As Integer 'cuenta si el texto del boton apretado esta en alguna de las cajas de texto
        contador = 0 'inicializo en cero si no hubo coincidencia queda en cero

        intentos = intentos + 1 ' cuenta las veces que se seleccion una letra  
        txtIntentos.Text = intentos 'muestro los intentos
        For Each caja In Controls 'este bucle  recorre  todos los controles del formulario

            'si el control es un Texbox compara el Texto del boton que aprete con los textbox donde esta la palabra metida
            If TypeOf caja Is TextBox Then
                If caja.text = LetraBoton Then 'Letra boton el un parametro string que le doy a la funcion Coincidencia (contiene el texto del boton)
                    caja.forecolor = Color.Red ' si esta en alguna caja pinta la letra del textbox de rojo

                    contador = 1 'marca que en algun texbox se encontro una coincidencia con el boton que aprete

                End If
            End If
            'si el control es un boton y tiene el texto de referncia (LetraBoton) se bloquea la tecla 
            If TypeOf caja Is Button Then
                If caja.text = LetraBoton Then
                    caja.enabled = False 'bloqueo

                End If
            End If

        Next
        If contador = 1 Then
            aciertos = aciertos + 1  'si se marco contador cuento la letra como un asierto
            txtAciertos.Text = aciertos
        Else
            errores = errores + 1 'si quedo en 0 fue una letra que no esta en la palabra
            txtErrores.Text = errores
        End If

        Dibujos(errores)
        Ganador()



    End Sub



    Private Sub MisBotones(sender As Object, e As EventArgs) Handles btnA.Click, btnB.Click,
        btnC.Click, btnD.Click, btnE.Click, btnF.Click, btnG.Click, btnH.Click, btnI.Click, btnJ.Click, btnK.Click,
        btnL.Click, btnM.Click, btnN.Click, btnO.Click, btnP.Click, btnQ.Click, btnR.Click, btnS.Click, btnT.Click, btnU.Click,
        btnV.Click, btnW.Click, btnX.Click, btnY.Click, btnZ.Click, btnÑ.Click
        Coincidencia(sender.text) 'paso con sender en texto del Boton de los 27 segun el click

    End Sub

    Sub TeclasInactivas() 'antes de arrancar el juego todas la teclas desabilitadas
        btnA.Enabled = False
        btnB.Enabled = False
        btnC.Enabled = False
        btnD.Enabled = False
        btnE.Enabled = False
        btnF.Enabled = False
        btnG.Enabled = False
        btnH.Enabled = False
        btnI.Enabled = False
        btnJ.Enabled = False
        btnK.Enabled = False
        btnL.Enabled = False
        btnM.Enabled = False
        btnN.Enabled = False
        btnÑ.Enabled = False
        btnO.Enabled = False
        btnP.Enabled = False
        btnQ.Enabled = False
        btnR.Enabled = False
        btnS.Enabled = False
        btnT.Enabled = False
        btnU.Enabled = False
        btnV.Enabled = False
        btnW.Enabled = False
        btnX.Enabled = False
        btnY.Enabled = False
        btnZ.Enabled = False
    End Sub

    Private Sub frmAhorcadoNro1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        intentos = 0
        txtIntentos.Text = intentos
        aciertos = 0
        txtAciertos.Text = 0
        errores = 0
        txtErrores.Text = 0
        TeclasInactivas()
    End Sub

    Private Sub HabilitarTeclas() 'si toco el boton jugar se habilitan las teclas
        btnA.Enabled = True
        btnB.Enabled = True
        btnC.Enabled = True
        btnD.Enabled = True
        btnE.Enabled = True
        btnF.Enabled = True
        btnG.Enabled = True
        btnH.Enabled = True
        btnI.Enabled = True
        btnJ.Enabled = True
        btnK.Enabled = True
        btnL.Enabled = True
        btnM.Enabled = True
        btnN.Enabled = True
        btnÑ.Enabled = True
        btnO.Enabled = True
        btnP.Enabled = True
        btnQ.Enabled = True
        btnR.Enabled = True
        btnS.Enabled = True
        btnT.Enabled = True
        btnU.Enabled = True
        btnV.Enabled = True
        btnW.Enabled = True
        btnX.Enabled = True
        btnY.Enabled = True
        btnZ.Enabled = True

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case errores
            Case 1
                Me.PictureBox1.Image = Image.FromFile("C:\Users\Walter\source\repos\pueba-ahorcado1\pueba-ahorcado1\bin\Debug\B.jpg")
            Case 2
                Me.PictureBox1.Image = Image.FromFile("C:\Users\Walter\source\repos\pueba-ahorcado1\pueba-ahorcado1\bin\Debug\C.jpg")
            Case 3
                Me.PictureBox1.Image = Image.FromFile("C:\Users\Walter\source\repos\pueba-ahorcado1\pueba-ahorcado1\bin\Debug\D.jpg")
            Case 4
                Me.PictureBox1.Image = Image.FromFile("C:\Users\Walter\source\repos\pueba-ahorcado1\pueba-ahorcado1\bin\Debug\E.jpg")
            Case 5
                Me.PictureBox1.Image = Image.FromFile("C:\Users\Walter\source\repos\pueba-ahorcado1\pueba-ahorcado1\bin\Debug\F.jpg")
            Case 6
                Me.PictureBox1.Image = Image.FromFile("C:\Users\Walter\source\repos\pueba-ahorcado1\pueba-ahorcado1\bin\Debug\G.jpg")
            Case 7
                Me.PictureBox1.Image = Image.FromFile("C:\Users\Walter\source\repos\pueba-ahorcado1\pueba-ahorcado1\bin\Debug\H.jpg")
            Case 8
                Me.PictureBox1.Image = Image.FromFile("C:\Users\Walter\source\repos\pueba-ahorcado1\pueba-ahorcado1\bin\Debug\I.jpg")
            Case 9
                MsgBox("Perdio el juego")
                Me.PictureBox1.Image = Image.FromFile("C:\Users\Walter\source\repos\pueba-ahorcado1\pueba-ahorcado1\bin\Debug\A.jpg")

        End Select
    End Sub
    Private Sub Dibujos(fallas As Integer)
        Select Case fallas
            Case 1
                Me.PictureBox1.Image = Image.FromFile("C:\Users\Walter\source\repos\pueba-ahorcado1\pueba-ahorcado1\bin\Debug\B.jpg")
            Case 2
                Me.PictureBox1.Image = Image.FromFile("C:\Users\Walter\source\repos\pueba-ahorcado1\pueba-ahorcado1\bin\Debug\C.jpg")
            Case 3
                Me.PictureBox1.Image = Image.FromFile("C:\Users\Walter\source\repos\pueba-ahorcado1\pueba-ahorcado1\bin\Debug\D.jpg")
            Case 4
                Me.PictureBox1.Image = Image.FromFile("C:\Users\Walter\source\repos\pueba-ahorcado1\pueba-ahorcado1\bin\Debug\E.jpg")
            Case 5
                Me.PictureBox1.Image = Image.FromFile("C:\Users\Walter\source\repos\pueba-ahorcado1\pueba-ahorcado1\bin\Debug\F.jpg")
            Case 6
                Me.PictureBox1.Image = Image.FromFile("C:\Users\Walter\source\repos\pueba-ahorcado1\pueba-ahorcado1\bin\Debug\G.jpg")
            Case 7
                Me.PictureBox1.Image = Image.FromFile("C:\Users\Walter\source\repos\pueba-ahorcado1\pueba-ahorcado1\bin\Debug\H.jpg")
            Case 8
                Me.PictureBox1.Image = Image.FromFile("C:\Users\Walter\source\repos\pueba-ahorcado1\pueba-ahorcado1\bin\Debug\I.jpg")
            Case 9
                MsgBox("Perdio el juego")
                Me.PictureBox1.Image = Image.FromFile("C:\Users\Walter\source\repos\pueba-ahorcado1\pueba-ahorcado1\bin\Debug\A.jpg")
                intentos = 0
                txtIntentos.Text = intentos
                aciertos = 0
                txtAciertos.Text = 0
                errores = 0
                txtErrores.Text = 0
                TeclasInactivas()

        End Select
    End Sub
    Private Sub Ganador()
        If TextBox1.ForeColor = Color.Red And TextBox2.ForeColor = Color.Red And
            TextBox3.ForeColor = Color.Red And TextBox4.ForeColor = Color.Red And TextBox5.ForeColor = Color.Red And
            TextBox6.ForeColor = Color.Red And TextBox7.ForeColor = Color.Red And TextBox8.ForeColor = Color.Red And
           TextBox9.ForeColor = Color.Red And TextBox10.ForeColor = Color.Red Then

            MsgBox("¡¡¡¡¡¡¡¡GANO EL JUEGO¡¡¡¡¡¡¡¡")
            Me.PictureBox1.Image = Image.FromFile("C:\Users\Walter\source\repos\pueba-ahorcado1\pueba-ahorcado1\bin\Debug\A.jpg")
            intentos = 0
            txtIntentos.Text = intentos
            aciertos = 0
            txtAciertos.Text = 0
            errores = 0
            txtErrores.Text = 0
            TeclasInactivas()


        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class