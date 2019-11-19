<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsuarios
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
        Me.lblUsuarios = New System.Windows.Forms.Label()
        Me.lblUsuarioCriterio = New System.Windows.Forms.Label()
        Me.btnUsuariosEliminar = New System.Windows.Forms.Button()
        Me.btnUsuariosGuardar = New System.Windows.Forms.Button()
        Me.btnUsuariosBuscar = New System.Windows.Forms.Button()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.btnUsuariosSalir = New System.Windows.Forms.Button()
        Me.btnUsuariosNuevoUSR = New System.Windows.Forms.Button()
        Me.txtUsuariosAlias = New System.Windows.Forms.TextBox()
        Me.lblUsuarioAlias = New System.Windows.Forms.Label()
        Me.lblUsuarioRolNU = New System.Windows.Forms.Label()
        Me.cboUsuariosRol = New System.Windows.Forms.ComboBox()
        Me.btnUsuariosAceptarNU = New System.Windows.Forms.Button()
        Me.btnUsuariosNuevoROL = New System.Windows.Forms.Button()
        Me.btnUsuariosAceptarNR = New System.Windows.Forms.Button()
        Me.lblUsuarioIDNR = New System.Windows.Forms.Label()
        Me.lblUsuarioRolNR = New System.Windows.Forms.Label()
        Me.txtUsuariosRolNR = New System.Windows.Forms.TextBox()
        Me.txtUsuariosIDNR = New System.Windows.Forms.TextBox()
        Me.rbUsuariosRoles = New System.Windows.Forms.RadioButton()
        Me.rbUsuariosNombres = New System.Windows.Forms.RadioButton()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUsuarios
        '
        Me.lblUsuarios.AutoSize = True
        Me.lblUsuarios.Font = New System.Drawing.Font("Book Antiqua", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarios.Location = New System.Drawing.Point(197, 126)
        Me.lblUsuarios.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuarios.Name = "lblUsuarios"
        Me.lblUsuarios.Size = New System.Drawing.Size(479, 47)
        Me.lblUsuarios.TabIndex = 11
        Me.lblUsuarios.Text = "GESTION DE USUARIOS"
        '
        'lblUsuarioCriterio
        '
        Me.lblUsuarioCriterio.AutoSize = True
        Me.lblUsuarioCriterio.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioCriterio.Location = New System.Drawing.Point(537, 224)
        Me.lblUsuarioCriterio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuarioCriterio.Name = "lblUsuarioCriterio"
        Me.lblUsuarioCriterio.Size = New System.Drawing.Size(109, 24)
        Me.lblUsuarioCriterio.TabIndex = 10
        Me.lblUsuarioCriterio.Text = "CRITERIO:"
        '
        'btnUsuariosEliminar
        '
        Me.btnUsuariosEliminar.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuariosEliminar.Location = New System.Drawing.Point(828, 336)
        Me.btnUsuariosEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUsuariosEliminar.Name = "btnUsuariosEliminar"
        Me.btnUsuariosEliminar.Size = New System.Drawing.Size(215, 58)
        Me.btnUsuariosEliminar.TabIndex = 8
        Me.btnUsuariosEliminar.Text = "ELIMINAR"
        Me.btnUsuariosEliminar.UseVisualStyleBackColor = True
        '
        'btnUsuariosGuardar
        '
        Me.btnUsuariosGuardar.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuariosGuardar.Location = New System.Drawing.Point(828, 273)
        Me.btnUsuariosGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUsuariosGuardar.Name = "btnUsuariosGuardar"
        Me.btnUsuariosGuardar.Size = New System.Drawing.Size(215, 58)
        Me.btnUsuariosGuardar.TabIndex = 7
        Me.btnUsuariosGuardar.Text = "GUARDAR"
        Me.btnUsuariosGuardar.UseVisualStyleBackColor = True
        '
        'btnUsuariosBuscar
        '
        Me.btnUsuariosBuscar.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuariosBuscar.Location = New System.Drawing.Point(828, 208)
        Me.btnUsuariosBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUsuariosBuscar.Name = "btnUsuariosBuscar"
        Me.btnUsuariosBuscar.Size = New System.Drawing.Size(215, 58)
        Me.btnUsuariosBuscar.TabIndex = 12
        Me.btnUsuariosBuscar.Text = "BUSCAR"
        Me.btnUsuariosBuscar.UseVisualStyleBackColor = True
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Location = New System.Drawing.Point(181, 267)
        Me.dgvUsuarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.Size = New System.Drawing.Size(592, 258)
        Me.dgvUsuarios.TabIndex = 52
        '
        'btnUsuariosSalir
        '
        Me.btnUsuariosSalir.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuariosSalir.Location = New System.Drawing.Point(828, 533)
        Me.btnUsuariosSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUsuariosSalir.Name = "btnUsuariosSalir"
        Me.btnUsuariosSalir.Size = New System.Drawing.Size(215, 58)
        Me.btnUsuariosSalir.TabIndex = 53
        Me.btnUsuariosSalir.Text = "SALIR"
        Me.btnUsuariosSalir.UseVisualStyleBackColor = True
        '
        'btnUsuariosNuevoUSR
        '
        Me.btnUsuariosNuevoUSR.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuariosNuevoUSR.Location = New System.Drawing.Point(828, 402)
        Me.btnUsuariosNuevoUSR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUsuariosNuevoUSR.Name = "btnUsuariosNuevoUSR"
        Me.btnUsuariosNuevoUSR.Size = New System.Drawing.Size(215, 55)
        Me.btnUsuariosNuevoUSR.TabIndex = 6
        Me.btnUsuariosNuevoUSR.Text = "NUEVO USUARIO"
        Me.btnUsuariosNuevoUSR.UseVisualStyleBackColor = True
        '
        'txtUsuariosAlias
        '
        Me.txtUsuariosAlias.Location = New System.Drawing.Point(253, 553)
        Me.txtUsuariosAlias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUsuariosAlias.Name = "txtUsuariosAlias"
        Me.txtUsuariosAlias.Size = New System.Drawing.Size(284, 22)
        Me.txtUsuariosAlias.TabIndex = 54
        '
        'lblUsuarioAlias
        '
        Me.lblUsuarioAlias.AutoSize = True
        Me.lblUsuarioAlias.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioAlias.Location = New System.Drawing.Point(169, 553)
        Me.lblUsuarioAlias.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuarioAlias.Name = "lblUsuarioAlias"
        Me.lblUsuarioAlias.Size = New System.Drawing.Size(77, 24)
        Me.lblUsuarioAlias.TabIndex = 56
        Me.lblUsuarioAlias.Text = "ALIAS:"
        '
        'lblUsuarioRolNU
        '
        Me.lblUsuarioRolNU.AutoSize = True
        Me.lblUsuarioRolNU.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioRolNU.Location = New System.Drawing.Point(183, 585)
        Me.lblUsuarioRolNU.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuarioRolNU.Name = "lblUsuarioRolNU"
        Me.lblUsuarioRolNU.Size = New System.Drawing.Size(56, 24)
        Me.lblUsuarioRolNU.TabIndex = 57
        Me.lblUsuarioRolNU.Text = "ROL:"
        '
        'cboUsuariosRol
        '
        Me.cboUsuariosRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUsuariosRol.FormattingEnabled = True
        Me.cboUsuariosRol.Location = New System.Drawing.Point(253, 587)
        Me.cboUsuariosRol.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboUsuariosRol.Name = "cboUsuariosRol"
        Me.cboUsuariosRol.Size = New System.Drawing.Size(284, 24)
        Me.cboUsuariosRol.TabIndex = 58
        '
        'btnUsuariosAceptarNU
        '
        Me.btnUsuariosAceptarNU.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuariosAceptarNU.Location = New System.Drawing.Point(559, 551)
        Me.btnUsuariosAceptarNU.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUsuariosAceptarNU.Name = "btnUsuariosAceptarNU"
        Me.btnUsuariosAceptarNU.Size = New System.Drawing.Size(215, 58)
        Me.btnUsuariosAceptarNU.TabIndex = 59
        Me.btnUsuariosAceptarNU.Text = "ACEPTAR"
        Me.btnUsuariosAceptarNU.UseVisualStyleBackColor = True
        '
        'btnUsuariosNuevoROL
        '
        Me.btnUsuariosNuevoROL.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuariosNuevoROL.Location = New System.Drawing.Point(828, 465)
        Me.btnUsuariosNuevoROL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUsuariosNuevoROL.Name = "btnUsuariosNuevoROL"
        Me.btnUsuariosNuevoROL.Size = New System.Drawing.Size(215, 55)
        Me.btnUsuariosNuevoROL.TabIndex = 60
        Me.btnUsuariosNuevoROL.Text = "NUEVO ROL"
        Me.btnUsuariosNuevoROL.UseVisualStyleBackColor = True
        '
        'btnUsuariosAceptarNR
        '
        Me.btnUsuariosAceptarNR.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuariosAceptarNR.Location = New System.Drawing.Point(559, 553)
        Me.btnUsuariosAceptarNR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUsuariosAceptarNR.Name = "btnUsuariosAceptarNR"
        Me.btnUsuariosAceptarNR.Size = New System.Drawing.Size(215, 58)
        Me.btnUsuariosAceptarNR.TabIndex = 65
        Me.btnUsuariosAceptarNR.Text = "ACEPTAR"
        Me.btnUsuariosAceptarNR.UseVisualStyleBackColor = True
        '
        'lblUsuarioIDNR
        '
        Me.lblUsuarioIDNR.AutoSize = True
        Me.lblUsuarioIDNR.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioIDNR.Location = New System.Drawing.Point(201, 586)
        Me.lblUsuarioIDNR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuarioIDNR.Name = "lblUsuarioIDNR"
        Me.lblUsuarioIDNR.Size = New System.Drawing.Size(37, 24)
        Me.lblUsuarioIDNR.TabIndex = 63
        Me.lblUsuarioIDNR.Text = "ID:"
        '
        'lblUsuarioRolNR
        '
        Me.lblUsuarioRolNR.AutoSize = True
        Me.lblUsuarioRolNR.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioRolNR.Location = New System.Drawing.Point(180, 554)
        Me.lblUsuarioRolNR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuarioRolNR.Name = "lblUsuarioRolNR"
        Me.lblUsuarioRolNR.Size = New System.Drawing.Size(56, 24)
        Me.lblUsuarioRolNR.TabIndex = 62
        Me.lblUsuarioRolNR.Text = "ROL:"
        '
        'txtUsuariosRolNR
        '
        Me.txtUsuariosRolNR.Location = New System.Drawing.Point(253, 554)
        Me.txtUsuariosRolNR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUsuariosRolNR.Name = "txtUsuariosRolNR"
        Me.txtUsuariosRolNR.Size = New System.Drawing.Size(284, 22)
        Me.txtUsuariosRolNR.TabIndex = 61
        '
        'txtUsuariosIDNR
        '
        Me.txtUsuariosIDNR.Location = New System.Drawing.Point(253, 586)
        Me.txtUsuariosIDNR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUsuariosIDNR.Name = "txtUsuariosIDNR"
        Me.txtUsuariosIDNR.Size = New System.Drawing.Size(284, 22)
        Me.txtUsuariosIDNR.TabIndex = 66
        '
        'rbUsuariosRoles
        '
        Me.rbUsuariosRoles.AutoSize = True
        Me.rbUsuariosRoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbUsuariosRoles.Location = New System.Drawing.Point(664, 214)
        Me.rbUsuariosRoles.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbUsuariosRoles.Name = "rbUsuariosRoles"
        Me.rbUsuariosRoles.Size = New System.Drawing.Size(80, 22)
        Me.rbUsuariosRoles.TabIndex = 67
        Me.rbUsuariosRoles.TabStop = True
        Me.rbUsuariosRoles.Text = "ROLES"
        Me.rbUsuariosRoles.UseVisualStyleBackColor = True
        '
        'rbUsuariosNombres
        '
        Me.rbUsuariosNombres.AutoSize = True
        Me.rbUsuariosNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbUsuariosNombres.Location = New System.Drawing.Point(664, 236)
        Me.rbUsuariosNombres.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbUsuariosNombres.Name = "rbUsuariosNombres"
        Me.rbUsuariosNombres.Size = New System.Drawing.Size(106, 22)
        Me.rbUsuariosNombres.TabIndex = 68
        Me.rbUsuariosNombres.TabStop = True
        Me.rbUsuariosNombres.Text = "USUARIOS"
        Me.rbUsuariosNombres.UseVisualStyleBackColor = True
        '
        'FormUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1743, 796)
        Me.Controls.Add(Me.rbUsuariosNombres)
        Me.Controls.Add(Me.rbUsuariosRoles)
        Me.Controls.Add(Me.btnUsuariosNuevoROL)
        Me.Controls.Add(Me.btnUsuariosAceptarNU)
        Me.Controls.Add(Me.cboUsuariosRol)
        Me.Controls.Add(Me.lblUsuarioRolNU)
        Me.Controls.Add(Me.lblUsuarioAlias)
        Me.Controls.Add(Me.txtUsuariosAlias)
        Me.Controls.Add(Me.btnUsuariosSalir)
        Me.Controls.Add(Me.dgvUsuarios)
        Me.Controls.Add(Me.btnUsuariosBuscar)
        Me.Controls.Add(Me.lblUsuarios)
        Me.Controls.Add(Me.lblUsuarioCriterio)
        Me.Controls.Add(Me.btnUsuariosEliminar)
        Me.Controls.Add(Me.btnUsuariosGuardar)
        Me.Controls.Add(Me.btnUsuariosNuevoUSR)
        Me.Controls.Add(Me.txtUsuariosIDNR)
        Me.Controls.Add(Me.btnUsuariosAceptarNR)
        Me.Controls.Add(Me.lblUsuarioIDNR)
        Me.Controls.Add(Me.lblUsuarioRolNR)
        Me.Controls.Add(Me.txtUsuariosRolNR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormUsuarios"
        Me.Text = "FormUsuarios"
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUsuarios As System.Windows.Forms.Label
    Friend WithEvents lblUsuarioCriterio As System.Windows.Forms.Label
    Friend WithEvents btnUsuariosEliminar As System.Windows.Forms.Button
    Friend WithEvents btnUsuariosGuardar As System.Windows.Forms.Button
    Friend WithEvents btnUsuariosBuscar As System.Windows.Forms.Button
    Friend WithEvents dgvUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents btnUsuariosSalir As System.Windows.Forms.Button
    Friend WithEvents btnUsuariosNuevoUSR As System.Windows.Forms.Button
    Friend WithEvents txtUsuariosAlias As System.Windows.Forms.TextBox
    Friend WithEvents lblUsuarioAlias As System.Windows.Forms.Label
    Friend WithEvents lblUsuarioRolNU As System.Windows.Forms.Label
    Friend WithEvents cboUsuariosRol As System.Windows.Forms.ComboBox
    Friend WithEvents btnUsuariosAceptarNU As System.Windows.Forms.Button
    Friend WithEvents btnUsuariosNuevoROL As System.Windows.Forms.Button
    Friend WithEvents btnUsuariosAceptarNR As System.Windows.Forms.Button
    Friend WithEvents lblUsuarioIDNR As System.Windows.Forms.Label
    Friend WithEvents lblUsuarioRolNR As System.Windows.Forms.Label
    Friend WithEvents txtUsuariosRolNR As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuariosIDNR As System.Windows.Forms.TextBox
    Friend WithEvents rbUsuariosRoles As System.Windows.Forms.RadioButton
    Friend WithEvents rbUsuariosNombres As System.Windows.Forms.RadioButton
End Class
