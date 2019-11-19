<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNuevoRelevamiento
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
        Me.btnNuevoRelevamientoSalir = New System.Windows.Forms.Button()
        Me.btnNuevoRelevamientoGuardarRelevamiento = New System.Windows.Forms.Button()
        Me.btnNuevoRelevamientoBuscar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpNuevoRelevamientoFI = New System.Windows.Forms.DateTimePicker()
        Me.lblFecRealizado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNuevoRelevamientoRUT = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnNuevoRelevamientoSalir
        '
        Me.btnNuevoRelevamientoSalir.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoRelevamientoSalir.Location = New System.Drawing.Point(952, 178)
        Me.btnNuevoRelevamientoSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNuevoRelevamientoSalir.Name = "btnNuevoRelevamientoSalir"
        Me.btnNuevoRelevamientoSalir.Size = New System.Drawing.Size(204, 70)
        Me.btnNuevoRelevamientoSalir.TabIndex = 12
        Me.btnNuevoRelevamientoSalir.Text = "SALIR"
        Me.btnNuevoRelevamientoSalir.UseVisualStyleBackColor = True
        '
        'btnNuevoRelevamientoGuardarRelevamiento
        '
        Me.btnNuevoRelevamientoGuardarRelevamiento.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoRelevamientoGuardarRelevamiento.Location = New System.Drawing.Point(740, 256)
        Me.btnNuevoRelevamientoGuardarRelevamiento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNuevoRelevamientoGuardarRelevamiento.Name = "btnNuevoRelevamientoGuardarRelevamiento"
        Me.btnNuevoRelevamientoGuardarRelevamiento.Size = New System.Drawing.Size(204, 70)
        Me.btnNuevoRelevamientoGuardarRelevamiento.TabIndex = 11
        Me.btnNuevoRelevamientoGuardarRelevamiento.Text = "GUARDAR RELEVAMIENTO"
        Me.btnNuevoRelevamientoGuardarRelevamiento.UseVisualStyleBackColor = True
        '
        'btnNuevoRelevamientoBuscar
        '
        Me.btnNuevoRelevamientoBuscar.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoRelevamientoBuscar.Location = New System.Drawing.Point(740, 178)
        Me.btnNuevoRelevamientoBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNuevoRelevamientoBuscar.Name = "btnNuevoRelevamientoBuscar"
        Me.btnNuevoRelevamientoBuscar.Size = New System.Drawing.Size(204, 70)
        Me.btnNuevoRelevamientoBuscar.TabIndex = 10
        Me.btnNuevoRelevamientoBuscar.Text = "BUSCAR"
        Me.btnNuevoRelevamientoBuscar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(92, 108)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(315, 28)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "NUEVO RELEVAMIENTO"
        '
        'dtpNuevoRelevamientoFI
        '
        Me.dtpNuevoRelevamientoFI.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNuevoRelevamientoFI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNuevoRelevamientoFI.Location = New System.Drawing.Point(305, 267)
        Me.dtpNuevoRelevamientoFI.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.dtpNuevoRelevamientoFI.Name = "dtpNuevoRelevamientoFI"
        Me.dtpNuevoRelevamientoFI.Size = New System.Drawing.Size(289, 32)
        Me.dtpNuevoRelevamientoFI.TabIndex = 45
        '
        'lblFecRealizado
        '
        Me.lblFecRealizado.AutoSize = True
        Me.lblFecRealizado.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecRealizado.Location = New System.Drawing.Point(92, 273)
        Me.lblFecRealizado.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblFecRealizado.Name = "lblFecRealizado"
        Me.lblFecRealizado.Size = New System.Drawing.Size(190, 24)
        Me.lblFecRealizado.TabIndex = 44
        Me.lblFecRealizado.Text = "FECHA DE INICIO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(231, 224)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 24)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "RUT:"
        '
        'txtNuevoRelevamientoRUT
        '
        Me.txtNuevoRelevamientoRUT.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuevoRelevamientoRUT.Location = New System.Drawing.Point(305, 224)
        Me.txtNuevoRelevamientoRUT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNuevoRelevamientoRUT.MaxLength = 12
        Me.txtNuevoRelevamientoRUT.Name = "txtNuevoRelevamientoRUT"
        Me.txtNuevoRelevamientoRUT.Size = New System.Drawing.Size(289, 32)
        Me.txtNuevoRelevamientoRUT.TabIndex = 43
        '
        'FormNuevoRelevamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1232, 574)
        Me.Controls.Add(Me.dtpNuevoRelevamientoFI)
        Me.Controls.Add(Me.lblFecRealizado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNuevoRelevamientoRUT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnNuevoRelevamientoSalir)
        Me.Controls.Add(Me.btnNuevoRelevamientoGuardarRelevamiento)
        Me.Controls.Add(Me.btnNuevoRelevamientoBuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormNuevoRelevamiento"
        Me.Text = "FormNuevoRelevamiento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNuevoRelevamientoSalir As System.Windows.Forms.Button
    Friend WithEvents btnNuevoRelevamientoGuardarRelevamiento As System.Windows.Forms.Button
    Friend WithEvents btnNuevoRelevamientoBuscar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpNuevoRelevamientoFI As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFecRealizado As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNuevoRelevamientoRUT As System.Windows.Forms.TextBox
End Class
