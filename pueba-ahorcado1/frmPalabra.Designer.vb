<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPalabra
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.txtMiPalabra = New System.Windows.Forms.TextBox()
        Me.cbxPalabra = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese una palabra: "
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(412, 160)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(94, 49)
        Me.btnIngresar.TabIndex = 1
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'txtMiPalabra
        '
        Me.txtMiPalabra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiPalabra.Location = New System.Drawing.Point(226, 63)
        Me.txtMiPalabra.Name = "txtMiPalabra"
        Me.txtMiPalabra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMiPalabra.Size = New System.Drawing.Size(280, 26)
        Me.txtMiPalabra.TabIndex = 2
        '
        'cbxPalabra
        '
        Me.cbxPalabra.AutoSize = True
        Me.cbxPalabra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxPalabra.Location = New System.Drawing.Point(226, 107)
        Me.cbxPalabra.Name = "cbxPalabra"
        Me.cbxPalabra.Size = New System.Drawing.Size(153, 20)
        Me.cbxPalabra.TabIndex = 3
        Me.cbxPalabra.Text = "Chequear Palabra"
        Me.cbxPalabra.UseVisualStyleBackColor = True
        '
        'frmPalabra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 238)
        Me.Controls.Add(Me.cbxPalabra)
        Me.Controls.Add(Me.txtMiPalabra)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPalabra"
        Me.Text = "frmPalabra"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnIngresar As Button
    Friend WithEvents txtMiPalabra As TextBox
    Friend WithEvents cbxPalabra As CheckBox
End Class
