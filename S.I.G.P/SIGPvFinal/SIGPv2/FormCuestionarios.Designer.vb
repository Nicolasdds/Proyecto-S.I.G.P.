<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCuestionarios
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
        Me.lblCuestionariosTipo = New System.Windows.Forms.Label()
        Me.cboCuestionarios = New System.Windows.Forms.ComboBox()
        Me.btnCuestionariosSalir = New System.Windows.Forms.Button()
        Me.btnCuestionariosAceptar = New System.Windows.Forms.Button()
        Me.lblCuestionariosTitulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCuestionariosTipo
        '
        Me.lblCuestionariosTipo.AutoSize = True
        Me.lblCuestionariosTipo.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuestionariosTipo.Location = New System.Drawing.Point(329, 164)
        Me.lblCuestionariosTipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCuestionariosTipo.Name = "lblCuestionariosTipo"
        Me.lblCuestionariosTipo.Size = New System.Drawing.Size(62, 24)
        Me.lblCuestionariosTipo.TabIndex = 0
        Me.lblCuestionariosTipo.Text = "TIPO:"
        '
        'cboCuestionarios
        '
        Me.cboCuestionarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCuestionarios.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuestionarios.FormattingEnabled = True
        Me.cboCuestionarios.Items.AddRange(New Object() {"Lugares de trabajo"})
        Me.cboCuestionarios.Location = New System.Drawing.Point(405, 160)
        Me.cboCuestionarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboCuestionarios.Name = "cboCuestionarios"
        Me.cboCuestionarios.Size = New System.Drawing.Size(449, 32)
        Me.cboCuestionarios.TabIndex = 2
        '
        'btnCuestionariosSalir
        '
        Me.btnCuestionariosSalir.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuestionariosSalir.Location = New System.Drawing.Point(987, 222)
        Me.btnCuestionariosSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCuestionariosSalir.Name = "btnCuestionariosSalir"
        Me.btnCuestionariosSalir.Size = New System.Drawing.Size(167, 70)
        Me.btnCuestionariosSalir.TabIndex = 8
        Me.btnCuestionariosSalir.Text = "SALIR"
        Me.btnCuestionariosSalir.UseVisualStyleBackColor = True
        '
        'btnCuestionariosAceptar
        '
        Me.btnCuestionariosAceptar.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuestionariosAceptar.Location = New System.Drawing.Point(987, 124)
        Me.btnCuestionariosAceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCuestionariosAceptar.Name = "btnCuestionariosAceptar"
        Me.btnCuestionariosAceptar.Size = New System.Drawing.Size(167, 70)
        Me.btnCuestionariosAceptar.TabIndex = 7
        Me.btnCuestionariosAceptar.Text = "ACEPTAR"
        Me.btnCuestionariosAceptar.UseVisualStyleBackColor = True
        '
        'lblCuestionariosTitulo
        '
        Me.lblCuestionariosTitulo.AutoSize = True
        Me.lblCuestionariosTitulo.Font = New System.Drawing.Font("Book Antiqua", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuestionariosTitulo.Location = New System.Drawing.Point(263, 80)
        Me.lblCuestionariosTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCuestionariosTitulo.Name = "lblCuestionariosTitulo"
        Me.lblCuestionariosTitulo.Size = New System.Drawing.Size(298, 40)
        Me.lblCuestionariosTitulo.TabIndex = 9
        Me.lblCuestionariosTitulo.Text = "CUESTIONARIOS"
        '
        'FormCuestionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1367, 634)
        Me.Controls.Add(Me.lblCuestionariosTitulo)
        Me.Controls.Add(Me.lblCuestionariosTipo)
        Me.Controls.Add(Me.cboCuestionarios)
        Me.Controls.Add(Me.btnCuestionariosSalir)
        Me.Controls.Add(Me.btnCuestionariosAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormCuestionarios"
        Me.Text = "FormCuestionarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCuestionariosTipo As System.Windows.Forms.Label
    Friend WithEvents cboCuestionarios As System.Windows.Forms.ComboBox
    Friend WithEvents btnCuestionariosSalir As System.Windows.Forms.Button
    Friend WithEvents btnCuestionariosAceptar As System.Windows.Forms.Button
    Friend WithEvents lblCuestionariosTitulo As System.Windows.Forms.Label
End Class
