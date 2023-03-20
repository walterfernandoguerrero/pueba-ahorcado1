Public Class frmAhorcadoNro1
    Dim caja As Object
    Private Sub btnJugar_Click(sender As Object, e As EventArgs) Handles btnJugar.Click

        Dim PalAleatoria As New Random 'variable para guardar un indice aleatorio
        Dim Contenedor As Integer
        Dim i As Integer

        Contenedor = PalAleatoria.Next(0, LstPalabras.Items.Count) ' variable "Contenedor2 me guarda el indice de la palabra del listbox 
        MsgBox(Contenedor)
        LstPalabras.SelectedIndex = Contenedor ' tomo la palabra del indice y la selecciono en azul

        MsgBox(Mid(LstPalabras.SelectedItem, 1, 3)) 'esta funcion Mid me saca caracteres de un string me muestra desde ,una posision la cantidad de caracteres que le pida

        i = 0
        For index = 1 To 10
            i = i + 1
            Select Case i
                Case 1
                    TextBox1.Text = Mid(LstPalabras.SelectedItem, i, 1)
                Case 2
                    TextBox2.Text = Mid(LstPalabras.SelectedItem, i, 1)
                Case 3
                    TextBox3.Text = Mid(LstPalabras.SelectedItem, i, 1)
                Case 4
                    TextBox4.Text = Mid(LstPalabras.SelectedItem, i, 1)
                Case 5
                    TextBox5.Text = Mid(LstPalabras.SelectedItem, i, 1)
                Case 6
                    TextBox6.Text = Mid(LstPalabras.SelectedItem, i, 1)
                Case 7
                    TextBox7.Text = Mid(LstPalabras.SelectedItem, i, 1)
                Case 8
                    TextBox8.Text = Mid(LstPalabras.SelectedItem, i, 1)
                Case 9
                    TextBox9.Text = Mid(LstPalabras.SelectedItem, i, 1)
                Case 10
                    TextBox10.Text = Mid(LstPalabras.SelectedItem, i, 1)
            End Select


        Next


    End Sub
    'funcion cargadora de datos
    Sub probar(LetraBoton As String)
        For Each caja In Controls
            If TypeOf caja Is TextBox Then
                If caja.text = LetraBoton Then
                    caja.forecolor = Color.Red
                End If
            End If
            If TypeOf caja Is Button Then
                If caja.text = LetraBoton Then
                    caja.enabled = False
                End If
            End If

        Next
    End Sub


    'Private Sub frmAhorcadoNro1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
    '    MsgBox(e.KeyCode.ToString)
    '    probar(e.KeyCode)
    'End Sub

    'Private Sub A_Click(sender As Object, e As EventArgs) Handles btnA.Click
    '    For Each caja In Controls
    '        If TypeOf caja Is TextBox Then
    '            If caja.text = btnA.Text Then
    '                caja.forecolor = Color.Red
    '            End If
    '        End If
    '        If TypeOf caja Is Button Then
    '            If caja.text = btnA.Text Then
    '                caja.enabled = False
    '            End If
    '        End If

    '    Next
    'End Sub

    'Private Sub E_Click(sender As Object, e As EventArgs) Handles btnE.Click
    '    probar(btnE.Text)

    'End Sub

    'Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
    '    probar(btnB.Text)
    'End Sub
    Private Sub MisBotones(sender As Object, e As EventArgs) Handles btnA.Click, btnB.Click,
        btnC.Click, btnD.Click, btnE.Click, btnF.Click, btnG.Click, btnH.Click, btnI.Click, btnJ.Click, btnK.Click,
        btnL.Click, btnM.Click, btnN.Click, btnO.Click, btnP.Click, btnQ.Click, btnR.Click, btnS.Click, btnT.Click, btnU.Click,
        btnV.Click, btnW.Click, btnX.Click, btnY.Click, btnZ.Click, btnÑ.Click
        probar(sender.text)

    End Sub
End Class