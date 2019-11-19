<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNuevoTrabajador
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
        Me.txtNuevoTrabajadorCapacitaciones = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNuevoTrabajadorLimpiar = New System.Windows.Forms.Button()
        Me.btnNuevoTrabajadorSalir = New System.Windows.Forms.Button()
        Me.btnNuevoTrabajadorGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNuevoTrabajadorNombre = New System.Windows.Forms.TextBox()
        Me.txtNuevoTrabajadorApellido = New System.Windows.Forms.TextBox()
        Me.txtNuevoTrabajadorSector = New System.Windows.Forms.TextBox()
        Me.txtNuevoTrabajadorCi = New System.Windows.Forms.TextBox()
        Me.cboNuevoTrabajadorTurno = New System.Windows.Forms.ComboBox()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.lblSector = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblCi = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnNuevoTrabajadorBuscarTrabajador = New System.Windows.Forms.Button()
        Me.btnNuevoTrabajadorAsignarTrabajador = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNuevoTrabajadorCapacitaciones
        '
        Me.txtNuevoTrabajadorCapacitaciones.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuevoTrabajadorCapacitaciones.Location = New System.Drawing.Point(399, 350)
        Me.txtNuevoTrabajadorCapacitaciones.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNuevoTrabajadorCapacitaciones.Name = "txtNuevoTrabajadorCapacitaciones"
        Me.txtNuevoTrabajadorCapacitaciones.Size = New System.Drawing.Size(383, 32)
        Me.txtNuevoTrabajadorCapacitaciones.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(180, 358)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 24)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "CAPACITACIONES:"
        '
        'btnNuevoTrabajadorLimpiar
        '
        Me.btnNuevoTrabajadorLimpiar.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoTrabajadorLimpiar.Location = New System.Drawing.Point(1095, 331)
        Me.btnNuevoTrabajadorLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevoTrabajadorLimpiar.Name = "btnNuevoTrabajadorLimpiar"
        Me.btnNuevoTrabajadorLimpiar.Size = New System.Drawing.Size(167, 70)
        Me.btnNuevoTrabajadorLimpiar.TabIndex = 9
        Me.btnNuevoTrabajadorLimpiar.Text = "LIMPIAR"
        Me.btnNuevoTrabajadorLimpiar.UseVisualStyleBackColor = True
        '
        'btnNuevoTrabajadorSalir
        '
        Me.btnNuevoTrabajadorSalir.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoTrabajadorSalir.Location = New System.Drawing.Point(1095, 406)
        Me.btnNuevoTrabajadorSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevoTrabajadorSalir.Name = "btnNuevoTrabajadorSalir"
        Me.btnNuevoTrabajadorSalir.Size = New System.Drawing.Size(167, 70)
        Me.btnNuevoTrabajadorSalir.TabIndex = 10
        Me.btnNuevoTrabajadorSalir.Text = "SALIR"
        Me.btnNuevoTrabajadorSalir.UseVisualStyleBackColor = True
        '
        'btnNuevoTrabajadorGuardar
        '
        Me.btnNuevoTrabajadorGuardar.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoTrabajadorGuardar.Location = New System.Drawing.Point(807, 293)
        Me.btnNuevoTrabajadorGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevoTrabajadorGuardar.Name = "btnNuevoTrabajadorGuardar"
        Me.btnNuevoTrabajadorGuardar.Size = New System.Drawing.Size(167, 70)
        Me.btnNuevoTrabajadorGuardar.TabIndex = 7
        Me.btnNuevoTrabajadorGuardar.Text = "GUARDAR TRABAJADOR"
        Me.btnNuevoTrabajadorGuardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(180, 81)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 47)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "TRABAJADOR"
        '
        'txtNuevoTrabajadorNombre
        '
        Me.txtNuevoTrabajadorNombre.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuevoTrabajadorNombre.Location = New System.Drawing.Point(399, 250)
        Me.txtNuevoTrabajadorNombre.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNuevoTrabajadorNombre.Name = "txtNuevoTrabajadorNombre"
        Me.txtNuevoTrabajadorNombre.Size = New System.Drawing.Size(383, 32)
        Me.txtNuevoTrabajadorNombre.TabIndex = 2
        '
        'txtNuevoTrabajadorApellido
        '
        Me.txtNuevoTrabajadorApellido.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuevoTrabajadorApellido.Location = New System.Drawing.Point(399, 302)
        Me.txtNuevoTrabajadorApellido.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNuevoTrabajadorApellido.Name = "txtNuevoTrabajadorApellido"
        Me.txtNuevoTrabajadorApellido.Size = New System.Drawing.Size(383, 32)
        Me.txtNuevoTrabajadorApellido.TabIndex = 3
        '
        'txtNuevoTrabajadorSector
        '
        Me.txtNuevoTrabajadorSector.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuevoTrabajadorSector.Location = New System.Drawing.Point(403, 471)
        Me.txtNuevoTrabajadorSector.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNuevoTrabajadorSector.Name = "txtNuevoTrabajadorSector"
        Me.txtNuevoTrabajadorSector.Size = New System.Drawing.Size(383, 32)
        Me.txtNuevoTrabajadorSector.TabIndex = 4
        '
        'txtNuevoTrabajadorCi
        '
        Me.txtNuevoTrabajadorCi.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuevoTrabajadorCi.Location = New System.Drawing.Point(399, 197)
        Me.txtNuevoTrabajadorCi.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNuevoTrabajadorCi.MaxLength = 10
        Me.txtNuevoTrabajadorCi.Name = "txtNuevoTrabajadorCi"
        Me.txtNuevoTrabajadorCi.Size = New System.Drawing.Size(383, 32)
        Me.txtNuevoTrabajadorCi.TabIndex = 1
        '
        'cboNuevoTrabajadorTurno
        '
        Me.cboNuevoTrabajadorTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNuevoTrabajadorTurno.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNuevoTrabajadorTurno.FormattingEnabled = True
        Me.cboNuevoTrabajadorTurno.Items.AddRange(New Object() {"Matutino", "Vespertino", "Nocturno"})
        Me.cboNuevoTrabajadorTurno.Location = New System.Drawing.Point(403, 514)
        Me.cboNuevoTrabajadorTurno.Margin = New System.Windows.Forms.Padding(5)
        Me.cboNuevoTrabajadorTurno.Name = "cboNuevoTrabajadorTurno"
        Me.cboNuevoTrabajadorTurno.Size = New System.Drawing.Size(383, 32)
        Me.cboNuevoTrabajadorTurno.TabIndex = 6
        '
        'lblTurno
        '
        Me.lblTurno.AutoSize = True
        Me.lblTurno.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurno.Location = New System.Drawing.Point(184, 524)
        Me.lblTurno.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(89, 24)
        Me.lblTurno.TabIndex = 22
        Me.lblTurno.Text = "TURNO:"
        '
        'lblSector
        '
        Me.lblSector.AutoSize = True
        Me.lblSector.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSector.Location = New System.Drawing.Point(184, 480)
        Me.lblSector.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblSector.Name = "lblSector"
        Me.lblSector.Size = New System.Drawing.Size(93, 24)
        Me.lblSector.TabIndex = 21
        Me.lblSector.Text = "SECTOR:"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(180, 315)
        Me.lblApellido.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(117, 24)
        Me.lblApellido.TabIndex = 20
        Me.lblApellido.Text = "APELLIDO:"
        '
        'lblCi
        '
        Me.lblCi.AutoSize = True
        Me.lblCi.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCi.Location = New System.Drawing.Point(180, 197)
        Me.lblCi.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblCi.Name = "lblCi"
        Me.lblCi.Size = New System.Drawing.Size(155, 24)
        Me.lblCi.TabIndex = 19
        Me.lblCi.Text = "C. IDENTIDAD:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(180, 258)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(104, 24)
        Me.lblNombre.TabIndex = 18
        Me.lblNombre.Text = "NOMBRE:"
        '
        'btnNuevoTrabajadorBuscarTrabajador
        '
        Me.btnNuevoTrabajadorBuscarTrabajador.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoTrabajadorBuscarTrabajador.Location = New System.Drawing.Point(807, 209)
        Me.btnNuevoTrabajadorBuscarTrabajador.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevoTrabajadorBuscarTrabajador.Name = "btnNuevoTrabajadorBuscarTrabajador"
        Me.btnNuevoTrabajadorBuscarTrabajador.Size = New System.Drawing.Size(167, 70)
        Me.btnNuevoTrabajadorBuscarTrabajador.TabIndex = 34
        Me.btnNuevoTrabajadorBuscarTrabajador.Text = "BUSCAR TRABAJADOR"
        Me.btnNuevoTrabajadorBuscarTrabajador.UseVisualStyleBackColor = True
        '
        'btnNuevoTrabajadorAsignarTrabajador
        '
        Me.btnNuevoTrabajadorAsignarTrabajador.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoTrabajadorAsignarTrabajador.Location = New System.Drawing.Point(820, 479)
        Me.btnNuevoTrabajadorAsignarTrabajador.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevoTrabajadorAsignarTrabajador.Name = "btnNuevoTrabajadorAsignarTrabajador"
        Me.btnNuevoTrabajadorAsignarTrabajador.Size = New System.Drawing.Size(167, 70)
        Me.btnNuevoTrabajadorAsignarTrabajador.TabIndex = 35
        Me.btnNuevoTrabajadorAsignarTrabajador.Text = "ASIGNAR TRABAJADOR"
        Me.btnNuevoTrabajadorAsignarTrabajador.UseVisualStyleBackColor = True
        '
        'FormNuevoTrabajador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1301, 592)
        Me.Controls.Add(Me.btnNuevoTrabajadorAsignarTrabajador)
        Me.Controls.Add(Me.btnNuevoTrabajadorBuscarTrabajador)
        Me.Controls.Add(Me.txtNuevoTrabajadorCapacitaciones)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnNuevoTrabajadorLimpiar)
        Me.Controls.Add(Me.btnNuevoTrabajadorSalir)
        Me.Controls.Add(Me.btnNuevoTrabajadorGuardar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNuevoTrabajadorNombre)
        Me.Controls.Add(Me.txtNuevoTrabajadorApellido)
        Me.Controls.Add(Me.txtNuevoTrabajadorSector)
        Me.Controls.Add(Me.txtNuevoTrabajadorCi)
        Me.Controls.Add(Me.cboNuevoTrabajadorTurno)
        Me.Controls.Add(Me.lblTurno)
        Me.Controls.Add(Me.lblSector)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblCi)
        Me.Controls.Add(Me.lblNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormNuevoTrabajador"
        Me.Text = "FormNuevoTrabajador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNuevoTrabajadorCapacitaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnNuevoTrabajadorLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnNuevoTrabajadorSalir As System.Windows.Forms.Button
    Friend WithEvents btnNuevoTrabajadorGuardar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNuevoTrabajadorNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtNuevoTrabajadorApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtNuevoTrabajadorSector As System.Windows.Forms.TextBox
    Friend WithEvents txtNuevoTrabajadorCi As System.Windows.Forms.TextBox
    Friend WithEvents cboNuevoTrabajadorTurno As System.Windows.Forms.ComboBox
    Friend WithEvents lblTurno As System.Windows.Forms.Label
    Friend WithEvents lblSector As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblCi As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents btnNuevoTrabajadorBuscarTrabajador As System.Windows.Forms.Button
    Friend WithEvents btnNuevoTrabajadorAsignarTrabajador As System.Windows.Forms.Button
End Class
