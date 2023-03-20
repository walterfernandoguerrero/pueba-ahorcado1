<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTeclas
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
        Me.B = New System.Windows.Forms.Button()
        Me.A = New System.Windows.Forms.Button()
        Me.btnJugar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuJuegosAhorcado = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu10Letras = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPalabrasLibres = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnJuego1 = New System.Windows.Forms.Button()
        Me.btnJuego2 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'B
        '
        Me.B.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B.Location = New System.Drawing.Point(-64, 347)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(42, 39)
        Me.B.TabIndex = 52
        Me.B.Text = "B"
        Me.B.UseVisualStyleBackColor = True
        '
        'A
        '
        Me.A.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A.Location = New System.Drawing.Point(-111, 347)
        Me.A.Name = "A"
        Me.A.Size = New System.Drawing.Size(42, 39)
        Me.A.TabIndex = 51
        Me.A.Text = "A"
        Me.A.UseVisualStyleBackColor = True
        '
        'btnJugar
        '
        Me.btnJugar.Location = New System.Drawing.Point(-111, 47)
        Me.btnJugar.Name = "btnJugar"
        Me.btnJugar.Size = New System.Drawing.Size(75, 23)
        Me.btnJugar.TabIndex = 40
        Me.btnJugar.Text = "Jugar"
        Me.btnJugar.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuJuegosAhorcado})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(693, 24)
        Me.MenuStrip1.TabIndex = 53
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuJuegosAhorcado
        '
        Me.mnuJuegosAhorcado.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu10Letras, Me.mnuPalabrasLibres})
        Me.mnuJuegosAhorcado.Name = "mnuJuegosAhorcado"
        Me.mnuJuegosAhorcado.Size = New System.Drawing.Size(129, 20)
        Me.mnuJuegosAhorcado.Text = "Juegos del Ahorcado"
        '
        'mnu10Letras
        '
        Me.mnu10Letras.Name = "mnu10Letras"
        Me.mnu10Letras.Size = New System.Drawing.Size(406, 22)
        Me.mnu10Letras.Text = "Juego ahorcado 10 letras con palabras precargadas"
        '
        'mnuPalabrasLibres
        '
        Me.mnuPalabrasLibres.Name = "mnuPalabrasLibres"
        Me.mnuPalabrasLibres.Size = New System.Drawing.Size(406, 22)
        Me.mnuPalabrasLibres.Text = "Juego del ahorcado con palabras ingresadas por el usuario rival"
        '
        'btnJuego1
        '
        Me.btnJuego1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJuego1.Location = New System.Drawing.Point(127, 173)
        Me.btnJuego1.Name = "btnJuego1"
        Me.btnJuego1.Size = New System.Drawing.Size(154, 97)
        Me.btnJuego1.TabIndex = 54
        Me.btnJuego1.Text = "AHORCADO 10 LETRAS"
        Me.btnJuego1.UseVisualStyleBackColor = True
        '
        'btnJuego2
        '
        Me.btnJuego2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJuego2.Location = New System.Drawing.Point(404, 173)
        Me.btnJuego2.Name = "btnJuego2"
        Me.btnJuego2.Size = New System.Drawing.Size(154, 97)
        Me.btnJuego2.TabIndex = 55
        Me.btnJuego2.Text = "AHORCADO LIBRE"
        Me.btnJuego2.UseVisualStyleBackColor = True
        '
        'frmTeclas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 539)
        Me.Controls.Add(Me.btnJuego2)
        Me.Controls.Add(Me.btnJuego1)
        Me.Controls.Add(Me.B)
        Me.Controls.Add(Me.A)
        Me.Controls.Add(Me.btnJugar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmTeclas"
        Me.Text = "JUEGOS DEL AHORCADO"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B As Button
    Friend WithEvents A As Button
    Friend WithEvents btnJugar As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuJuegosAhorcado As ToolStripMenuItem
    Friend WithEvents mnu10Letras As ToolStripMenuItem
    Friend WithEvents mnuPalabrasLibres As ToolStripMenuItem
    Friend WithEvents btnJuego1 As Button
    Friend WithEvents btnJuego2 As Button
End Class
