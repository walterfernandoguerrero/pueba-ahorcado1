<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAhorcadoNro2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblPalabra = New System.Windows.Forms.Label()
        Me.txtPalabra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCuentaLetras = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLetra = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblControl = New System.Windows.Forms.Label()
        Me.btnJugar = New System.Windows.Forms.Button()
        Me.txtLabel15 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIntentos = New System.Windows.Forms.TextBox()
        Me.txtAciertos = New System.Windows.Forms.TextBox()
        Me.txtFallos = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtJugadores = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbxJugadores = New System.Windows.Forms.ListBox()
        Me.btnJugadores = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.gbxDificultad = New System.Windows.Forms.GroupBox()
        Me.rbtDificil = New System.Windows.Forms.RadioButton()
        Me.rbtNormal = New System.Windows.Forms.RadioButton()
        Me.rbtFacil = New System.Windows.Forms.RadioButton()
        Me.cbxChequeo = New System.Windows.Forms.CheckBox()
        Me.lblPodesJugar = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCartelFinal = New System.Windows.Forms.Label()
        Me.lblCartelJugar = New System.Windows.Forms.Label()
        Me.lboxPuntos = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.gbxJugar = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblCartPuntaje = New System.Windows.Forms.Label()
        Me.lblCartelPtos = New System.Windows.Forms.Label()
        Me.lblPuntos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbxDificultad.SuspendLayout()
        Me.gbxJugar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPalabra
        '
        Me.lblPalabra.AutoSize = True
        Me.lblPalabra.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPalabra.Location = New System.Drawing.Point(5, 389)
        Me.lblPalabra.Name = "lblPalabra"
        Me.lblPalabra.Size = New System.Drawing.Size(102, 22)
        Me.lblPalabra.TabIndex = 0
        Me.lblPalabra.Text = "Mi Palabra:"
        '
        'txtPalabra
        '
        Me.txtPalabra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPalabra.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPalabra.Location = New System.Drawing.Point(9, 417)
        Me.txtPalabra.MaxLength = 24
        Me.txtPalabra.Name = "txtPalabra"
        Me.txtPalabra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPalabra.Size = New System.Drawing.Size(349, 29)
        Me.txtPalabra.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(492, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Palabra de "
        '
        'txtCuentaLetras
        '
        Me.txtCuentaLetras.Enabled = False
        Me.txtCuentaLetras.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaLetras.Location = New System.Drawing.Point(602, 155)
        Me.txtCuentaLetras.Name = "txtCuentaLetras"
        Me.txtCuentaLetras.Size = New System.Drawing.Size(35, 29)
        Me.txtCuentaLetras.TabIndex = 3
        Me.txtCuentaLetras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(643, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Letras"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(290, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Ingrese una Letra:"
        '
        'txtLetra
        '
        Me.txtLetra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLetra.Enabled = False
        Me.txtLetra.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLetra.Location = New System.Drawing.Point(424, 155)
        Me.txtLetra.MaxLength = 1
        Me.txtLetra.Name = "txtLetra"
        Me.txtLetra.Size = New System.Drawing.Size(39, 31)
        Me.txtLetra.TabIndex = 6
        Me.txtLetra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtLetra.Visible = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(567, 393)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 41)
        Me.btnLimpiar.TabIndex = 7
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(648, 393)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 41)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblControl
        '
        Me.lblControl.AutoSize = True
        Me.lblControl.Enabled = False
        Me.lblControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControl.Location = New System.Drawing.Point(557, 64)
        Me.lblControl.Name = "lblControl"
        Me.lblControl.Size = New System.Drawing.Size(0, 55)
        Me.lblControl.TabIndex = 11
        Me.lblControl.Visible = False
        '
        'btnJugar
        '
        Me.btnJugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJugar.Location = New System.Drawing.Point(370, 33)
        Me.btnJugar.Name = "btnJugar"
        Me.btnJugar.Size = New System.Drawing.Size(181, 64)
        Me.btnJugar.TabIndex = 12
        Me.btnJugar.Text = "Jugar"
        Me.btnJugar.UseVisualStyleBackColor = True
        '
        'txtLabel15
        '
        Me.txtLabel15.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.txtLabel15.Enabled = False
        Me.txtLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabel15.ForeColor = System.Drawing.Color.Black
        Me.txtLabel15.Location = New System.Drawing.Point(294, 194)
        Me.txtLabel15.Name = "txtLabel15"
        Me.txtLabel15.Size = New System.Drawing.Size(348, 49)
        Me.txtLabel15.TabIndex = 14
        Me.txtLabel15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(291, 277)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 18)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Intentos:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(415, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 18)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Aciertos:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(537, 277)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 18)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Fallos:"
        '
        'txtIntentos
        '
        Me.txtIntentos.Enabled = False
        Me.txtIntentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntentos.Location = New System.Drawing.Point(370, 271)
        Me.txtIntentos.Name = "txtIntentos"
        Me.txtIntentos.Size = New System.Drawing.Size(35, 29)
        Me.txtIntentos.TabIndex = 18
        Me.txtIntentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAciertos
        '
        Me.txtAciertos.Enabled = False
        Me.txtAciertos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAciertos.Location = New System.Drawing.Point(496, 271)
        Me.txtAciertos.Name = "txtAciertos"
        Me.txtAciertos.Size = New System.Drawing.Size(35, 29)
        Me.txtAciertos.TabIndex = 19
        Me.txtAciertos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFallos
        '
        Me.txtFallos.Enabled = False
        Me.txtFallos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFallos.Location = New System.Drawing.Point(607, 271)
        Me.txtFallos.Name = "txtFallos"
        Me.txtFallos.Size = New System.Drawing.Size(35, 29)
        Me.txtFallos.TabIndex = 20
        Me.txtFallos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 468)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 25)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 441)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 18)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Letras Usadas:"
        '
        'txtJugadores
        '
        Me.txtJugadores.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtJugadores.Location = New System.Drawing.Point(9, 45)
        Me.txtJugadores.Name = "txtJugadores"
        Me.txtJugadores.Size = New System.Drawing.Size(193, 20)
        Me.txtJugadores.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(256, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "INGRESE LOS NOMBRES  DEL LOS JUGADORES"
        '
        'lbxJugadores
        '
        Me.lbxJugadores.FormattingEnabled = True
        Me.lbxJugadores.Location = New System.Drawing.Point(9, 86)
        Me.lbxJugadores.Name = "lbxJugadores"
        Me.lbxJugadores.Size = New System.Drawing.Size(116, 95)
        Me.lbxJugadores.TabIndex = 25
        '
        'btnJugadores
        '
        Me.btnJugadores.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJugadores.Location = New System.Drawing.Point(286, 26)
        Me.btnJugadores.Name = "btnJugadores"
        Me.btnJugadores.Size = New System.Drawing.Size(49, 47)
        Me.btnJugadores.TabIndex = 26
        Me.btnJugadores.Text = ">>"
        Me.btnJugadores.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(283, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 52)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Pulse el botòn " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para agregar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "un jugador" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " a la lista:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'gbxDificultad
        '
        Me.gbxDificultad.Controls.Add(Me.rbtDificil)
        Me.gbxDificultad.Controls.Add(Me.rbtNormal)
        Me.gbxDificultad.Controls.Add(Me.rbtFacil)
        Me.gbxDificultad.Location = New System.Drawing.Point(12, 248)
        Me.gbxDificultad.Name = "gbxDificultad"
        Me.gbxDificultad.Size = New System.Drawing.Size(253, 129)
        Me.gbxDificultad.TabIndex = 28
        Me.gbxDificultad.TabStop = False
        Me.gbxDificultad.Text = "DIFICULTAD"
        '
        'rbtDificil
        '
        Me.rbtDificil.AutoSize = True
        Me.rbtDificil.Location = New System.Drawing.Point(12, 93)
        Me.rbtDificil.Name = "rbtDificil"
        Me.rbtDificil.Size = New System.Drawing.Size(159, 17)
        Me.rbtDificil.TabIndex = 2
        Me.rbtDificil.Text = "Mas Dicultad (solo 4 errores)"
        Me.rbtDificil.UseVisualStyleBackColor = True
        '
        'rbtNormal
        '
        Me.rbtNormal.AutoSize = True
        Me.rbtNormal.Checked = True
        Me.rbtNormal.Location = New System.Drawing.Point(12, 65)
        Me.rbtNormal.Name = "rbtNormal"
        Me.rbtNormal.Size = New System.Drawing.Size(185, 17)
        Me.rbtNormal.TabIndex = 1
        Me.rbtNormal.TabStop = True
        Me.rbtNormal.Text = "Normal (8 oportunidades de fallas)"
        Me.rbtNormal.UseVisualStyleBackColor = True
        '
        'rbtFacil
        '
        Me.rbtFacil.AutoSize = True
        Me.rbtFacil.Location = New System.Drawing.Point(12, 30)
        Me.rbtFacil.Name = "rbtFacil"
        Me.rbtFacil.Size = New System.Drawing.Size(178, 17)
        Me.rbtFacil.TabIndex = 0
        Me.rbtFacil.Text = "Baja Dificultad (1ra y ultima letra)"
        Me.rbtFacil.UseVisualStyleBackColor = True
        '
        'cbxChequeo
        '
        Me.cbxChequeo.AutoSize = True
        Me.cbxChequeo.Location = New System.Drawing.Point(187, 394)
        Me.cbxChequeo.Name = "cbxChequeo"
        Me.cbxChequeo.Size = New System.Drawing.Size(171, 17)
        Me.cbxChequeo.TabIndex = 31
        Me.cbxChequeo.Text = "Chequear o Modicar la palabra"
        Me.cbxChequeo.UseVisualStyleBackColor = True
        '
        'lblPodesJugar
        '
        Me.lblPodesJugar.AutoSize = True
        Me.lblPodesJugar.Location = New System.Drawing.Point(11, 209)
        Me.lblPodesJugar.Name = "lblPodesJugar"
        Me.lblPodesJugar.Size = New System.Drawing.Size(198, 26)
        Me.lblPodesJugar.TabIndex = 32
        Me.lblPodesJugar.Text = "Luego de cargar los jugadores selecione" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "un jugador para iniciar el JUEGO........" &
    ".."
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Maiandra GD", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Lime
        Me.lblNombre.Location = New System.Drawing.Point(12, 15)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(139, 32)
        Me.lblNombre.TabIndex = 33
        Me.lblNombre.Text = "NOMBRE"
        '
        'lblCartelFinal
        '
        Me.lblCartelFinal.AutoSize = True
        Me.lblCartelFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCartelFinal.ForeColor = System.Drawing.Color.Red
        Me.lblCartelFinal.Location = New System.Drawing.Point(12, 385)
        Me.lblCartelFinal.Name = "lblCartelFinal"
        Me.lblCartelFinal.Size = New System.Drawing.Size(0, 37)
        Me.lblCartelFinal.TabIndex = 34
        '
        'lblCartelJugar
        '
        Me.lblCartelJugar.AutoSize = True
        Me.lblCartelJugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCartelJugar.Location = New System.Drawing.Point(586, 41)
        Me.lblCartelJugar.Name = "lblCartelJugar"
        Me.lblCartelJugar.Size = New System.Drawing.Size(76, 52)
        Me.lblCartelJugar.TabIndex = 35
        Me.lblCartelJugar.Text = "Presione el" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "boton para " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "comenzar a " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "jugar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lboxPuntos
        '
        Me.lboxPuntos.FormattingEnabled = True
        Me.lboxPuntos.Location = New System.Drawing.Point(139, 86)
        Me.lboxPuntos.Name = "lboxPuntos"
        Me.lboxPuntos.Size = New System.Drawing.Size(58, 95)
        Me.lboxPuntos.TabIndex = 36
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Nombres:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(136, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 13)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Puntuacion"
        '
        'gbxJugar
        '
        Me.gbxJugar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gbxJugar.Controls.Add(Me.Label10)
        Me.gbxJugar.Controls.Add(Me.lblPalabra)
        Me.gbxJugar.Controls.Add(Me.Label13)
        Me.gbxJugar.Controls.Add(Me.txtPalabra)
        Me.gbxJugar.Controls.Add(Me.Label12)
        Me.gbxJugar.Controls.Add(Me.txtJugadores)
        Me.gbxJugar.Controls.Add(Me.lboxPuntos)
        Me.gbxJugar.Controls.Add(Me.lbxJugadores)
        Me.gbxJugar.Controls.Add(Me.btnJugadores)
        Me.gbxJugar.Controls.Add(Me.Label11)
        Me.gbxJugar.Controls.Add(Me.gbxDificultad)
        Me.gbxJugar.Controls.Add(Me.cbxChequeo)
        Me.gbxJugar.Controls.Add(Me.lblPodesJugar)
        Me.gbxJugar.Location = New System.Drawing.Point(799, 12)
        Me.gbxJugar.Name = "gbxJugar"
        Me.gbxJugar.Size = New System.Drawing.Size(364, 479)
        Me.gbxJugar.TabIndex = 40
        Me.gbxJugar.TabStop = False
        Me.gbxJugar.Text = "JUGAR AHORCADO"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.pueba_ahorcado1.My.Resources.Resources.img00
        Me.PictureBox1.Location = New System.Drawing.Point(12, 117)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(244, 305)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'lblCartPuntaje
        '
        Me.lblCartPuntaje.AutoSize = True
        Me.lblCartPuntaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCartPuntaje.ForeColor = System.Drawing.Color.Lime
        Me.lblCartPuntaje.Location = New System.Drawing.Point(291, 325)
        Me.lblCartPuntaje.Name = "lblCartPuntaje"
        Me.lblCartPuntaje.Size = New System.Drawing.Size(371, 48)
        Me.lblCartPuntaje.TabIndex = 42
        Me.lblCartPuntaje.Text = "Puntaje :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "100 ptos adivinar la palabra ; 20 puntos si no adivino" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5 puntos cada " &
    "acierto ;  - 4 puntos cada error"
        '
        'lblCartelPtos
        '
        Me.lblCartelPtos.AutoSize = True
        Me.lblCartelPtos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCartelPtos.ForeColor = System.Drawing.Color.Lime
        Me.lblCartelPtos.Location = New System.Drawing.Point(16, 64)
        Me.lblCartelPtos.Name = "lblCartelPtos"
        Me.lblCartelPtos.Size = New System.Drawing.Size(68, 16)
        Me.lblCartelPtos.TabIndex = 43
        Me.lblCartelPtos.Text = "Puntaje: "
        '
        'lblPuntos
        '
        Me.lblPuntos.AutoSize = True
        Me.lblPuntos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPuntos.ForeColor = System.Drawing.Color.Lime
        Me.lblPuntos.Location = New System.Drawing.Point(90, 62)
        Me.lblPuntos.Name = "lblPuntos"
        Me.lblPuntos.Size = New System.Drawing.Size(19, 20)
        Me.lblPuntos.TabIndex = 44
        Me.lblPuntos.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(147, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "puntos"
        '
        'frmAhorcadoNro2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1184, 503)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPuntos)
        Me.Controls.Add(Me.lblCartelPtos)
        Me.Controls.Add(Me.lblCartPuntaje)
        Me.Controls.Add(Me.gbxJugar)
        Me.Controls.Add(Me.lblCartelJugar)
        Me.Controls.Add(Me.lblCartelFinal)
        Me.Controls.Add(Me.txtLabel15)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtFallos)
        Me.Controls.Add(Me.txtAciertos)
        Me.Controls.Add(Me.txtIntentos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnJugar)
        Me.Controls.Add(Me.lblControl)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.txtLetra)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCuentaLetras)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmAhorcadoNro2"
        Me.Text = "Juego del Ahorcado "
        Me.gbxDificultad.ResumeLayout(False)
        Me.gbxDificultad.PerformLayout()
        Me.gbxJugar.ResumeLayout(False)
        Me.gbxJugar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPalabra As Label
    Friend WithEvents txtPalabra As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCuentaLetras As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLetra As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblControl As Label
    Friend WithEvents btnJugar As Button
    Friend WithEvents txtLabel15 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtIntentos As TextBox
    Friend WithEvents txtAciertos As TextBox
    Friend WithEvents txtFallos As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtJugadores As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lbxJugadores As ListBox
    Friend WithEvents btnJugadores As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents gbxDificultad As GroupBox
    Friend WithEvents rbtDificil As RadioButton
    Friend WithEvents rbtNormal As RadioButton
    Friend WithEvents rbtFacil As RadioButton
    Friend WithEvents cbxChequeo As CheckBox
    Friend WithEvents lblPodesJugar As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblCartelFinal As Label
    Friend WithEvents lblCartelJugar As Label
    Friend WithEvents lboxPuntos As ListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents gbxJugar As GroupBox
    Friend WithEvents lblCartPuntaje As Label
    Friend WithEvents lblCartelPtos As Label
    Friend WithEvents lblPuntos As Label
    Friend WithEvents Label1 As Label
End Class
