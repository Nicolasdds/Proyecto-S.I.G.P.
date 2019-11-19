<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEmpresa
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
        Me.btnEmpresaLimpiar = New System.Windows.Forms.Button()
        Me.btnEmpresaNuevoTrabajador = New System.Windows.Forms.Button()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.txtEmpresaMail = New System.Windows.Forms.TextBox()
        Me.btnEmpresaGuardar = New System.Windows.Forms.Button()
        Me.btnEmpresaSalir = New System.Windows.Forms.Button()
        Me.txtEmpresaTelefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmpresaRubro = New System.Windows.Forms.TextBox()
        Me.lblRazonSocial = New System.Windows.Forms.Label()
        Me.txtEmpresaRSocial = New System.Windows.Forms.TextBox()
        Me.lblRubro = New System.Windows.Forms.Label()
        Me.lblRut = New System.Windows.Forms.Label()
        Me.txtEmpresaDepartamento = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmpresaRut = New System.Windows.Forms.TextBox()
        Me.txtEmpresaDireccion = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblEmpresaDepartamento = New System.Windows.Forms.Label()
        Me.btnEmpresaBuscarEmpresa = New System.Windows.Forms.Button()
        Me.btnEmpresaVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEmpresaLimpiar
        '
        Me.btnEmpresaLimpiar.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpresaLimpiar.Location = New System.Drawing.Point(1088, 486)
        Me.btnEmpresaLimpiar.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnEmpresaLimpiar.Name = "btnEmpresaLimpiar"
        Me.btnEmpresaLimpiar.Size = New System.Drawing.Size(167, 70)
        Me.btnEmpresaLimpiar.TabIndex = 10
        Me.btnEmpresaLimpiar.Text = "LIMPIAR"
        Me.btnEmpresaLimpiar.UseVisualStyleBackColor = True
        '
        'btnEmpresaNuevoTrabajador
        '
        Me.btnEmpresaNuevoTrabajador.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpresaNuevoTrabajador.Location = New System.Drawing.Point(1088, 320)
        Me.btnEmpresaNuevoTrabajador.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEmpresaNuevoTrabajador.Name = "btnEmpresaNuevoTrabajador"
        Me.btnEmpresaNuevoTrabajador.Size = New System.Drawing.Size(167, 70)
        Me.btnEmpresaNuevoTrabajador.TabIndex = 8
        Me.btnEmpresaNuevoTrabajador.Text = "NUEVO TRABAJADOR"
        Me.btnEmpresaNuevoTrabajador.UseVisualStyleBackColor = True
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.Font = New System.Drawing.Font("Book Antiqua", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresa.Location = New System.Drawing.Point(365, 206)
        Me.lblEmpresa.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(209, 47)
        Me.lblEmpresa.TabIndex = 45
        Me.lblEmpresa.Text = "EMPRESA"
        '
        'txtEmpresaMail
        '
        Me.txtEmpresaMail.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpresaMail.Location = New System.Drawing.Point(629, 496)
        Me.txtEmpresaMail.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtEmpresaMail.MaxLength = 20
        Me.txtEmpresaMail.Name = "txtEmpresaMail"
        Me.txtEmpresaMail.Size = New System.Drawing.Size(389, 32)
        Me.txtEmpresaMail.TabIndex = 4
        '
        'btnEmpresaGuardar
        '
        Me.btnEmpresaGuardar.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpresaGuardar.Location = New System.Drawing.Point(1088, 399)
        Me.btnEmpresaGuardar.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnEmpresaGuardar.Name = "btnEmpresaGuardar"
        Me.btnEmpresaGuardar.Size = New System.Drawing.Size(167, 70)
        Me.btnEmpresaGuardar.TabIndex = 9
        Me.btnEmpresaGuardar.Text = "GUARDAR"
        Me.btnEmpresaGuardar.UseVisualStyleBackColor = True
        '
        'btnEmpresaSalir
        '
        Me.btnEmpresaSalir.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpresaSalir.Location = New System.Drawing.Point(1088, 575)
        Me.btnEmpresaSalir.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnEmpresaSalir.Name = "btnEmpresaSalir"
        Me.btnEmpresaSalir.Size = New System.Drawing.Size(167, 70)
        Me.btnEmpresaSalir.TabIndex = 11
        Me.btnEmpresaSalir.Text = "SALIR"
        Me.btnEmpresaSalir.UseVisualStyleBackColor = True
        '
        'txtEmpresaTelefono
        '
        Me.txtEmpresaTelefono.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpresaTelefono.Location = New System.Drawing.Point(629, 442)
        Me.txtEmpresaTelefono.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtEmpresaTelefono.MaxLength = 10
        Me.txtEmpresaTelefono.Name = "txtEmpresaTelefono"
        Me.txtEmpresaTelefono.Size = New System.Drawing.Size(389, 32)
        Me.txtEmpresaTelefono.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(368, 505)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 24)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "E-MAIL:"
        '
        'txtEmpresaRubro
        '
        Me.txtEmpresaRubro.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpresaRubro.Location = New System.Drawing.Point(629, 394)
        Me.txtEmpresaRubro.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtEmpresaRubro.MaxLength = 15
        Me.txtEmpresaRubro.Name = "txtEmpresaRubro"
        Me.txtEmpresaRubro.Size = New System.Drawing.Size(389, 32)
        Me.txtEmpresaRubro.TabIndex = 2
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.AutoSize = True
        Me.lblRazonSocial.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazonSocial.Location = New System.Drawing.Point(368, 351)
        Me.lblRazonSocial.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(171, 24)
        Me.lblRazonSocial.TabIndex = 29
        Me.lblRazonSocial.Text = "RAZON SOCIAL:"
        '
        'txtEmpresaRSocial
        '
        Me.txtEmpresaRSocial.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpresaRSocial.Location = New System.Drawing.Point(629, 342)
        Me.txtEmpresaRSocial.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtEmpresaRSocial.MaxLength = 20
        Me.txtEmpresaRSocial.Name = "txtEmpresaRSocial"
        Me.txtEmpresaRSocial.Size = New System.Drawing.Size(389, 32)
        Me.txtEmpresaRSocial.TabIndex = 1
        '
        'lblRubro
        '
        Me.lblRubro.AutoSize = True
        Me.lblRubro.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRubro.Location = New System.Drawing.Point(368, 402)
        Me.lblRubro.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblRubro.Name = "lblRubro"
        Me.lblRubro.Size = New System.Drawing.Size(85, 24)
        Me.lblRubro.TabIndex = 35
        Me.lblRubro.Text = "RUBRO:"
        '
        'lblRut
        '
        Me.lblRut.AutoSize = True
        Me.lblRut.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRut.Location = New System.Drawing.Point(368, 292)
        Me.lblRut.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.Size = New System.Drawing.Size(56, 24)
        Me.lblRut.TabIndex = 31
        Me.lblRut.Text = "RUT:"
        '
        'txtEmpresaDepartamento
        '
        Me.txtEmpresaDepartamento.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpresaDepartamento.Location = New System.Drawing.Point(631, 597)
        Me.txtEmpresaDepartamento.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtEmpresaDepartamento.MaxLength = 12
        Me.txtEmpresaDepartamento.Name = "txtEmpresaDepartamento"
        Me.txtEmpresaDepartamento.Size = New System.Drawing.Size(389, 32)
        Me.txtEmpresaDepartamento.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(368, 450)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 24)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "TELEFONO:"
        '
        'txtEmpresaRut
        '
        Me.txtEmpresaRut.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpresaRut.Location = New System.Drawing.Point(629, 283)
        Me.txtEmpresaRut.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtEmpresaRut.MaxLength = 12
        Me.txtEmpresaRut.Name = "txtEmpresaRut"
        Me.txtEmpresaRut.Size = New System.Drawing.Size(389, 32)
        Me.txtEmpresaRut.TabIndex = 0
        '
        'txtEmpresaDireccion
        '
        Me.txtEmpresaDireccion.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpresaDireccion.Location = New System.Drawing.Point(629, 554)
        Me.txtEmpresaDireccion.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtEmpresaDireccion.MaxLength = 36
        Me.txtEmpresaDireccion.Name = "txtEmpresaDireccion"
        Me.txtEmpresaDireccion.Size = New System.Drawing.Size(389, 32)
        Me.txtEmpresaDireccion.TabIndex = 5
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(368, 562)
        Me.lblDireccion.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(130, 24)
        Me.lblDireccion.TabIndex = 33
        Me.lblDireccion.Text = "DIRECCION:"
        '
        'lblEmpresaDepartamento
        '
        Me.lblEmpresaDepartamento.AutoSize = True
        Me.lblEmpresaDepartamento.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresaDepartamento.Location = New System.Drawing.Point(369, 606)
        Me.lblEmpresaDepartamento.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblEmpresaDepartamento.Name = "lblEmpresaDepartamento"
        Me.lblEmpresaDepartamento.Size = New System.Drawing.Size(187, 24)
        Me.lblEmpresaDepartamento.TabIndex = 34
        Me.lblEmpresaDepartamento.Text = "DEPARTAMENTO:"
        '
        'btnEmpresaBuscarEmpresa
        '
        Me.btnEmpresaBuscarEmpresa.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpresaBuscarEmpresa.Location = New System.Drawing.Point(1088, 234)
        Me.btnEmpresaBuscarEmpresa.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnEmpresaBuscarEmpresa.Name = "btnEmpresaBuscarEmpresa"
        Me.btnEmpresaBuscarEmpresa.Size = New System.Drawing.Size(167, 70)
        Me.btnEmpresaBuscarEmpresa.TabIndex = 7
        Me.btnEmpresaBuscarEmpresa.Text = "BUSCAR EMPRESA"
        Me.btnEmpresaBuscarEmpresa.UseVisualStyleBackColor = True
        '
        'btnEmpresaVolver
        '
        Me.btnEmpresaVolver.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpresaVolver.Location = New System.Drawing.Point(1067, 575)
        Me.btnEmpresaVolver.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnEmpresaVolver.Name = "btnEmpresaVolver"
        Me.btnEmpresaVolver.Size = New System.Drawing.Size(204, 70)
        Me.btnEmpresaVolver.TabIndex = 11
        Me.btnEmpresaVolver.Text = "VOLVER"
        Me.btnEmpresaVolver.UseVisualStyleBackColor = True
        '
        'FormEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1405, 768)
        Me.Controls.Add(Me.btnEmpresaVolver)
        Me.Controls.Add(Me.btnEmpresaBuscarEmpresa)
        Me.Controls.Add(Me.btnEmpresaLimpiar)
        Me.Controls.Add(Me.btnEmpresaNuevoTrabajador)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.txtEmpresaMail)
        Me.Controls.Add(Me.btnEmpresaGuardar)
        Me.Controls.Add(Me.btnEmpresaSalir)
        Me.Controls.Add(Me.txtEmpresaTelefono)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEmpresaRubro)
        Me.Controls.Add(Me.lblRazonSocial)
        Me.Controls.Add(Me.txtEmpresaRSocial)
        Me.Controls.Add(Me.lblRubro)
        Me.Controls.Add(Me.lblRut)
        Me.Controls.Add(Me.txtEmpresaDepartamento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEmpresaRut)
        Me.Controls.Add(Me.txtEmpresaDireccion)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblEmpresaDepartamento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormEmpresa"
        Me.Text = "FormEmpresa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEmpresaLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnEmpresaNuevoTrabajador As System.Windows.Forms.Button
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents txtEmpresaMail As System.Windows.Forms.TextBox
    Friend WithEvents btnEmpresaGuardar As System.Windows.Forms.Button
    Friend WithEvents btnEmpresaSalir As System.Windows.Forms.Button
    Friend WithEvents txtEmpresaTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEmpresaRubro As System.Windows.Forms.TextBox
    Friend WithEvents lblRazonSocial As System.Windows.Forms.Label
    Friend WithEvents txtEmpresaRSocial As System.Windows.Forms.TextBox
    Friend WithEvents lblRubro As System.Windows.Forms.Label
    Friend WithEvents lblRut As System.Windows.Forms.Label
    Friend WithEvents txtEmpresaDepartamento As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEmpresaRut As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpresaDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblEmpresaDepartamento As System.Windows.Forms.Label
    Friend WithEvents btnEmpresaBuscarEmpresa As System.Windows.Forms.Button
    Friend WithEvents btnEmpresaVolver As System.Windows.Forms.Button
End Class
