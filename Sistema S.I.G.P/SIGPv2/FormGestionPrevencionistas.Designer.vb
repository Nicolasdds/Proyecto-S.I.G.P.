<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGestionPrevencionistas
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
        Me.lblGestionPrevencionistasTitulo = New System.Windows.Forms.Label()
        Me.txtGestionPrevencionistasNombre = New System.Windows.Forms.TextBox()
        Me.txtGestionPrevencionistasCi = New System.Windows.Forms.TextBox()
        Me.lblGestionPrevencionistasCi = New System.Windows.Forms.Label()
        Me.lblGestionPrevencionistasNombre = New System.Windows.Forms.Label()
        Me.btnGestionPrevencionistasLimpiar = New System.Windows.Forms.Button()
        Me.btnGestionPrevencionistasSalir = New System.Windows.Forms.Button()
        Me.btnGestionPrevencionistasGuardar = New System.Windows.Forms.Button()
        Me.lblGestionPrevencionistasApellido = New System.Windows.Forms.Label()
        Me.lblGestionPrevencionistasDomicilio = New System.Windows.Forms.Label()
        Me.txtGestionPrevencionistasDomicilio = New System.Windows.Forms.TextBox()
        Me.txtGestionPrevencionistasApellido = New System.Windows.Forms.TextBox()
        Me.lblGestionPrevencionistasTelefono = New System.Windows.Forms.Label()
        Me.txtGestionPrevencionistasTelefono = New System.Windows.Forms.TextBox()
        Me.btnGestionPrevencionistasBuscar = New System.Windows.Forms.Button()
        Me.lblGestionPrevencionistaContratos = New System.Windows.Forms.Label()
        Me.dgvGestionPrevencionistasContratos = New System.Windows.Forms.DataGridView()
        Me.btnGestionPrevencionistasNuevoContrato = New System.Windows.Forms.Button()
        Me.lblGestionPrevencionistasAviso = New System.Windows.Forms.Label()
        Me.lblGestionPrevencionistasUsuario = New System.Windows.Forms.Label()
        Me.cboGestionPrevencionistas = New System.Windows.Forms.ComboBox()
        Me.btnGestionPrevencionistasGU = New System.Windows.Forms.Button()
        Me.btnGestionPrevencionistasActualizarU = New System.Windows.Forms.Button()
        CType(Me.dgvGestionPrevencionistasContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblGestionPrevencionistasTitulo
        '
        Me.lblGestionPrevencionistasTitulo.AutoSize = True
        Me.lblGestionPrevencionistasTitulo.Font = New System.Drawing.Font("Book Antiqua", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGestionPrevencionistasTitulo.Location = New System.Drawing.Point(213, 68)
        Me.lblGestionPrevencionistasTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGestionPrevencionistasTitulo.Name = "lblGestionPrevencionistasTitulo"
        Me.lblGestionPrevencionistasTitulo.Size = New System.Drawing.Size(397, 47)
        Me.lblGestionPrevencionistasTitulo.TabIndex = 73
        Me.lblGestionPrevencionistasTitulo.Text = "PREVENCIONISTAS"
        '
        'txtGestionPrevencionistasNombre
        '
        Me.txtGestionPrevencionistasNombre.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGestionPrevencionistasNombre.Location = New System.Drawing.Point(304, 222)
        Me.txtGestionPrevencionistasNombre.Margin = New System.Windows.Forms.Padding(5)
        Me.txtGestionPrevencionistasNombre.MaxLength = 15
        Me.txtGestionPrevencionistasNombre.Name = "txtGestionPrevencionistasNombre"
        Me.txtGestionPrevencionistasNombre.Size = New System.Drawing.Size(383, 32)
        Me.txtGestionPrevencionistasNombre.TabIndex = 2
        '
        'txtGestionPrevencionistasCi
        '
        Me.txtGestionPrevencionistasCi.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGestionPrevencionistasCi.Location = New System.Drawing.Point(304, 169)
        Me.txtGestionPrevencionistasCi.Margin = New System.Windows.Forms.Padding(5)
        Me.txtGestionPrevencionistasCi.MaxLength = 8
        Me.txtGestionPrevencionistasCi.Name = "txtGestionPrevencionistasCi"
        Me.txtGestionPrevencionistasCi.Size = New System.Drawing.Size(383, 32)
        Me.txtGestionPrevencionistasCi.TabIndex = 1
        '
        'lblGestionPrevencionistasCi
        '
        Me.lblGestionPrevencionistasCi.AutoSize = True
        Me.lblGestionPrevencionistasCi.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGestionPrevencionistasCi.Location = New System.Drawing.Point(128, 172)
        Me.lblGestionPrevencionistasCi.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblGestionPrevencionistasCi.Name = "lblGestionPrevencionistasCi"
        Me.lblGestionPrevencionistasCi.Size = New System.Drawing.Size(155, 24)
        Me.lblGestionPrevencionistasCi.TabIndex = 66
        Me.lblGestionPrevencionistasCi.Text = "C. IDENTIDAD:"
        '
        'lblGestionPrevencionistasNombre
        '
        Me.lblGestionPrevencionistasNombre.AutoSize = True
        Me.lblGestionPrevencionistasNombre.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGestionPrevencionistasNombre.Location = New System.Drawing.Point(164, 225)
        Me.lblGestionPrevencionistasNombre.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblGestionPrevencionistasNombre.Name = "lblGestionPrevencionistasNombre"
        Me.lblGestionPrevencionistasNombre.Size = New System.Drawing.Size(104, 24)
        Me.lblGestionPrevencionistasNombre.TabIndex = 65
        Me.lblGestionPrevencionistasNombre.Text = "NOMBRE:"
        '
        'btnGestionPrevencionistasLimpiar
        '
        Me.btnGestionPrevencionistasLimpiar.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGestionPrevencionistasLimpiar.Location = New System.Drawing.Point(887, 265)
        Me.btnGestionPrevencionistasLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGestionPrevencionistasLimpiar.Name = "btnGestionPrevencionistasLimpiar"
        Me.btnGestionPrevencionistasLimpiar.Size = New System.Drawing.Size(167, 70)
        Me.btnGestionPrevencionistasLimpiar.TabIndex = 9
        Me.btnGestionPrevencionistasLimpiar.Text = "LIMPIAR"
        Me.btnGestionPrevencionistasLimpiar.UseVisualStyleBackColor = True
        '
        'btnGestionPrevencionistasSalir
        '
        Me.btnGestionPrevencionistasSalir.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGestionPrevencionistasSalir.Location = New System.Drawing.Point(887, 340)
        Me.btnGestionPrevencionistasSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGestionPrevencionistasSalir.Name = "btnGestionPrevencionistasSalir"
        Me.btnGestionPrevencionistasSalir.Size = New System.Drawing.Size(167, 70)
        Me.btnGestionPrevencionistasSalir.TabIndex = 10
        Me.btnGestionPrevencionistasSalir.Text = "SALIR"
        Me.btnGestionPrevencionistasSalir.UseVisualStyleBackColor = True
        '
        'btnGestionPrevencionistasGuardar
        '
        Me.btnGestionPrevencionistasGuardar.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGestionPrevencionistasGuardar.Location = New System.Drawing.Point(887, 187)
        Me.btnGestionPrevencionistasGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGestionPrevencionistasGuardar.Name = "btnGestionPrevencionistasGuardar"
        Me.btnGestionPrevencionistasGuardar.Size = New System.Drawing.Size(167, 70)
        Me.btnGestionPrevencionistasGuardar.TabIndex = 8
        Me.btnGestionPrevencionistasGuardar.Text = "GUARDAR"
        Me.btnGestionPrevencionistasGuardar.UseVisualStyleBackColor = True
        '
        'lblGestionPrevencionistasApellido
        '
        Me.lblGestionPrevencionistasApellido.AutoSize = True
        Me.lblGestionPrevencionistasApellido.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGestionPrevencionistasApellido.Location = New System.Drawing.Point(151, 282)
        Me.lblGestionPrevencionistasApellido.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblGestionPrevencionistasApellido.Name = "lblGestionPrevencionistasApellido"
        Me.lblGestionPrevencionistasApellido.Size = New System.Drawing.Size(117, 24)
        Me.lblGestionPrevencionistasApellido.TabIndex = 67
        Me.lblGestionPrevencionistasApellido.Text = "APELLIDO:"
        '
        'lblGestionPrevencionistasDomicilio
        '
        Me.lblGestionPrevencionistasDomicilio.AutoSize = True
        Me.lblGestionPrevencionistasDomicilio.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGestionPrevencionistasDomicilio.Location = New System.Drawing.Point(143, 399)
        Me.lblGestionPrevencionistasDomicilio.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblGestionPrevencionistasDomicilio.Name = "lblGestionPrevencionistasDomicilio"
        Me.lblGestionPrevencionistasDomicilio.Size = New System.Drawing.Size(128, 24)
        Me.lblGestionPrevencionistasDomicilio.TabIndex = 68
        Me.lblGestionPrevencionistasDomicilio.Text = "DOMICILIO:"
        '
        'txtGestionPrevencionistasDomicilio
        '
        Me.txtGestionPrevencionistasDomicilio.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGestionPrevencionistasDomicilio.Location = New System.Drawing.Point(304, 394)
        Me.txtGestionPrevencionistasDomicilio.Margin = New System.Windows.Forms.Padding(5)
        Me.txtGestionPrevencionistasDomicilio.MaxLength = 50
        Me.txtGestionPrevencionistasDomicilio.Name = "txtGestionPrevencionistasDomicilio"
        Me.txtGestionPrevencionistasDomicilio.Size = New System.Drawing.Size(383, 32)
        Me.txtGestionPrevencionistasDomicilio.TabIndex = 5
        '
        'txtGestionPrevencionistasApellido
        '
        Me.txtGestionPrevencionistasApellido.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGestionPrevencionistasApellido.Location = New System.Drawing.Point(304, 278)
        Me.txtGestionPrevencionistasApellido.Margin = New System.Windows.Forms.Padding(5)
        Me.txtGestionPrevencionistasApellido.MaxLength = 15
        Me.txtGestionPrevencionistasApellido.Name = "txtGestionPrevencionistasApellido"
        Me.txtGestionPrevencionistasApellido.Size = New System.Drawing.Size(383, 32)
        Me.txtGestionPrevencionistasApellido.TabIndex = 3
        '
        'lblGestionPrevencionistasTelefono
        '
        Me.lblGestionPrevencionistasTelefono.AutoSize = True
        Me.lblGestionPrevencionistasTelefono.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGestionPrevencionistasTelefono.Location = New System.Drawing.Point(144, 345)
        Me.lblGestionPrevencionistasTelefono.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblGestionPrevencionistasTelefono.Name = "lblGestionPrevencionistasTelefono"
        Me.lblGestionPrevencionistasTelefono.Size = New System.Drawing.Size(123, 24)
        Me.lblGestionPrevencionistasTelefono.TabIndex = 74
        Me.lblGestionPrevencionistasTelefono.Text = "TELEFONO:"
        '
        'txtGestionPrevencionistasTelefono
        '
        Me.txtGestionPrevencionistasTelefono.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGestionPrevencionistasTelefono.Location = New System.Drawing.Point(304, 340)
        Me.txtGestionPrevencionistasTelefono.Margin = New System.Windows.Forms.Padding(5)
        Me.txtGestionPrevencionistasTelefono.MaxLength = 10
        Me.txtGestionPrevencionistasTelefono.Name = "txtGestionPrevencionistasTelefono"
        Me.txtGestionPrevencionistasTelefono.Size = New System.Drawing.Size(383, 32)
        Me.txtGestionPrevencionistasTelefono.TabIndex = 4
        '
        'btnGestionPrevencionistasBuscar
        '
        Me.btnGestionPrevencionistasBuscar.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGestionPrevencionistasBuscar.Location = New System.Drawing.Point(712, 188)
        Me.btnGestionPrevencionistasBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGestionPrevencionistasBuscar.Name = "btnGestionPrevencionistasBuscar"
        Me.btnGestionPrevencionistasBuscar.Size = New System.Drawing.Size(167, 70)
        Me.btnGestionPrevencionistasBuscar.TabIndex = 6
        Me.btnGestionPrevencionistasBuscar.Text = "BUSCAR"
        Me.btnGestionPrevencionistasBuscar.UseVisualStyleBackColor = True
        '
        'lblGestionPrevencionistaContratos
        '
        Me.lblGestionPrevencionistaContratos.AutoSize = True
        Me.lblGestionPrevencionistaContratos.Font = New System.Drawing.Font("Book Antiqua", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGestionPrevencionistaContratos.Location = New System.Drawing.Point(73, 522)
        Me.lblGestionPrevencionistaContratos.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblGestionPrevencionistaContratos.Name = "lblGestionPrevencionistaContratos"
        Me.lblGestionPrevencionistaContratos.Size = New System.Drawing.Size(195, 32)
        Me.lblGestionPrevencionistaContratos.TabIndex = 78
        Me.lblGestionPrevencionistaContratos.Text = "CONTRATOS"
        '
        'dgvGestionPrevencionistasContratos
        '
        Me.dgvGestionPrevencionistasContratos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGestionPrevencionistasContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGestionPrevencionistasContratos.Location = New System.Drawing.Point(80, 570)
        Me.dgvGestionPrevencionistasContratos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvGestionPrevencionistasContratos.Name = "dgvGestionPrevencionistasContratos"
        Me.dgvGestionPrevencionistasContratos.Size = New System.Drawing.Size(971, 281)
        Me.dgvGestionPrevencionistasContratos.TabIndex = 83
        '
        'btnGestionPrevencionistasNuevoContrato
        '
        Me.btnGestionPrevencionistasNuevoContrato.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGestionPrevencionistasNuevoContrato.Location = New System.Drawing.Point(712, 265)
        Me.btnGestionPrevencionistasNuevoContrato.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGestionPrevencionistasNuevoContrato.Name = "btnGestionPrevencionistasNuevoContrato"
        Me.btnGestionPrevencionistasNuevoContrato.Size = New System.Drawing.Size(167, 70)
        Me.btnGestionPrevencionistasNuevoContrato.TabIndex = 87
        Me.btnGestionPrevencionistasNuevoContrato.Text = "NUEVO CONTRATO"
        Me.btnGestionPrevencionistasNuevoContrato.UseVisualStyleBackColor = True
        '
        'lblGestionPrevencionistasAviso
        '
        Me.lblGestionPrevencionistasAviso.AutoSize = True
        Me.lblGestionPrevencionistasAviso.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGestionPrevencionistasAviso.ForeColor = System.Drawing.Color.Red
        Me.lblGestionPrevencionistasAviso.Location = New System.Drawing.Point(128, 126)
        Me.lblGestionPrevencionistasAviso.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblGestionPrevencionistasAviso.Name = "lblGestionPrevencionistasAviso"
        Me.lblGestionPrevencionistasAviso.Size = New System.Drawing.Size(850, 24)
        Me.lblGestionPrevencionistasAviso.TabIndex = 89
        Me.lblGestionPrevencionistasAviso.Text = "No quedan mas nombres de usuarios disponibles, debe gestionarlos en la seccion de" & _
            " usuarios.!"
        '
        'lblGestionPrevencionistasUsuario
        '
        Me.lblGestionPrevencionistasUsuario.AutoSize = True
        Me.lblGestionPrevencionistasUsuario.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGestionPrevencionistasUsuario.Location = New System.Drawing.Point(160, 447)
        Me.lblGestionPrevencionistasUsuario.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblGestionPrevencionistasUsuario.Name = "lblGestionPrevencionistasUsuario"
        Me.lblGestionPrevencionistasUsuario.Size = New System.Drawing.Size(110, 24)
        Me.lblGestionPrevencionistasUsuario.TabIndex = 90
        Me.lblGestionPrevencionistasUsuario.Text = "USUARIO:"
        '
        'cboGestionPrevencionistas
        '
        Me.cboGestionPrevencionistas.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGestionPrevencionistas.FormattingEnabled = True
        Me.cboGestionPrevencionistas.Location = New System.Drawing.Point(304, 444)
        Me.cboGestionPrevencionistas.Margin = New System.Windows.Forms.Padding(4)
        Me.cboGestionPrevencionistas.Name = "cboGestionPrevencionistas"
        Me.cboGestionPrevencionistas.Size = New System.Drawing.Size(383, 32)
        Me.cboGestionPrevencionistas.TabIndex = 91
        '
        'btnGestionPrevencionistasGU
        '
        Me.btnGestionPrevencionistasGU.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGestionPrevencionistasGU.Location = New System.Drawing.Point(712, 340)
        Me.btnGestionPrevencionistasGU.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGestionPrevencionistasGU.Name = "btnGestionPrevencionistasGU"
        Me.btnGestionPrevencionistasGU.Size = New System.Drawing.Size(167, 70)
        Me.btnGestionPrevencionistasGU.TabIndex = 92
        Me.btnGestionPrevencionistasGU.Text = "GESTION USUARIOS"
        Me.btnGestionPrevencionistasGU.UseVisualStyleBackColor = True
        '
        'btnGestionPrevencionistasActualizarU
        '
        Me.btnGestionPrevencionistasActualizarU.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGestionPrevencionistasActualizarU.Location = New System.Drawing.Point(712, 444)
        Me.btnGestionPrevencionistasActualizarU.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGestionPrevencionistasActualizarU.Name = "btnGestionPrevencionistasActualizarU"
        Me.btnGestionPrevencionistasActualizarU.Size = New System.Drawing.Size(339, 34)
        Me.btnGestionPrevencionistasActualizarU.TabIndex = 93
        Me.btnGestionPrevencionistasActualizarU.Text = "ACTUALIZAR USUARIO"
        Me.btnGestionPrevencionistasActualizarU.UseVisualStyleBackColor = True
        '
        'FormGestionPrevencionistas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1915, 996)
        Me.Controls.Add(Me.btnGestionPrevencionistasActualizarU)
        Me.Controls.Add(Me.btnGestionPrevencionistasGU)
        Me.Controls.Add(Me.cboGestionPrevencionistas)
        Me.Controls.Add(Me.lblGestionPrevencionistasUsuario)
        Me.Controls.Add(Me.lblGestionPrevencionistasAviso)
        Me.Controls.Add(Me.btnGestionPrevencionistasNuevoContrato)
        Me.Controls.Add(Me.dgvGestionPrevencionistasContratos)
        Me.Controls.Add(Me.lblGestionPrevencionistaContratos)
        Me.Controls.Add(Me.btnGestionPrevencionistasBuscar)
        Me.Controls.Add(Me.txtGestionPrevencionistasTelefono)
        Me.Controls.Add(Me.lblGestionPrevencionistasTelefono)
        Me.Controls.Add(Me.lblGestionPrevencionistasTitulo)
        Me.Controls.Add(Me.txtGestionPrevencionistasNombre)
        Me.Controls.Add(Me.txtGestionPrevencionistasApellido)
        Me.Controls.Add(Me.txtGestionPrevencionistasDomicilio)
        Me.Controls.Add(Me.txtGestionPrevencionistasCi)
        Me.Controls.Add(Me.lblGestionPrevencionistasDomicilio)
        Me.Controls.Add(Me.lblGestionPrevencionistasApellido)
        Me.Controls.Add(Me.lblGestionPrevencionistasCi)
        Me.Controls.Add(Me.lblGestionPrevencionistasNombre)
        Me.Controls.Add(Me.btnGestionPrevencionistasLimpiar)
        Me.Controls.Add(Me.btnGestionPrevencionistasSalir)
        Me.Controls.Add(Me.btnGestionPrevencionistasGuardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormGestionPrevencionistas"
        Me.Text = " "
        CType(Me.dgvGestionPrevencionistasContratos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGestionPrevencionistasTitulo As System.Windows.Forms.Label
    Friend WithEvents txtGestionPrevencionistasNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtGestionPrevencionistasCi As System.Windows.Forms.TextBox
    Friend WithEvents lblGestionPrevencionistasCi As System.Windows.Forms.Label
    Friend WithEvents lblGestionPrevencionistasNombre As System.Windows.Forms.Label
    Friend WithEvents btnGestionPrevencionistasLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnGestionPrevencionistasSalir As System.Windows.Forms.Button
    Friend WithEvents btnGestionPrevencionistasGuardar As System.Windows.Forms.Button
    Friend WithEvents lblGestionPrevencionistasApellido As System.Windows.Forms.Label
    Friend WithEvents lblGestionPrevencionistasDomicilio As System.Windows.Forms.Label
    Friend WithEvents txtGestionPrevencionistasDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents txtGestionPrevencionistasApellido As System.Windows.Forms.TextBox
    Friend WithEvents lblGestionPrevencionistasTelefono As System.Windows.Forms.Label
    Friend WithEvents txtGestionPrevencionistasTelefono As System.Windows.Forms.TextBox
    Friend WithEvents btnGestionPrevencionistasBuscar As System.Windows.Forms.Button
    Friend WithEvents lblGestionPrevencionistaContratos As System.Windows.Forms.Label
    Friend WithEvents dgvGestionPrevencionistasContratos As System.Windows.Forms.DataGridView
    Friend WithEvents btnGestionPrevencionistasNuevoContrato As System.Windows.Forms.Button
    Friend WithEvents lblGestionPrevencionistasAviso As System.Windows.Forms.Label
    Friend WithEvents lblGestionPrevencionistasUsuario As System.Windows.Forms.Label
    Friend WithEvents cboGestionPrevencionistas As System.Windows.Forms.ComboBox
    Friend WithEvents btnGestionPrevencionistasGU As System.Windows.Forms.Button
    Friend WithEvents btnGestionPrevencionistasActualizarU As System.Windows.Forms.Button
End Class
