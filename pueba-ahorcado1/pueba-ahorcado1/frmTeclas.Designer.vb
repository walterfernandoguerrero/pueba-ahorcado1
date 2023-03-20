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
        'frmTeclas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 539)
        Me.Controls.Add(Me.B)
        Me.Controls.Add(Me.A)
        Me.Controls.Add(Me.btnJugar)
        Me.Name = "frmTeclas"
        Me.Text = "frmTeclas"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents B As Button
    Friend WithEvents A As Button
    Friend WithEvents btnJugar As Button
End Class
