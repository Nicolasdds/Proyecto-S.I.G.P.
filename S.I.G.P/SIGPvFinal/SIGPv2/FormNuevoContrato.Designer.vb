<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNuevoContrato
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
        Me.txtNuevoContratoRUT = New System.Windows.Forms.TextBox()
        Me.lblNuevoContratoRUT = New System.Windows.Forms.Label()
        Me.lblNuevoContratoTitulo = New System.Windows.Forms.Label()
        Me.dtpNuevoContratoFBaja = New System.Windows.Forms.DateTimePicker()
        Me.dtpNuevoContratoFAlta = New System.Windows.Forms.DateTimePicker()
        Me.lblNuevoContratoFBaja = New System.Windows.Forms.Label()
        Me.lblNuevoContratoFAlta = New System.Windows.Forms.Label()
        Me.btnNuevoContratoAceptar = New System.Windows.Forms.Button()
        Me.btnNuevoContratoVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNuevoContratoRUT
        '
        Me.txtNuevoContratoRUT.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuevoContratoRUT.Location = New System.Drawing.Point(308, 150)
        Me.txtNuevoContratoRUT.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtNuevoContratoRUT.MaxLength = 12
        Me.txtNuevoContratoRUT.Name = "txtNuevoContratoRUT"
        Me.txtNuevoContratoRUT.Size = New System.Drawing.Size(383, 32)
        Me.txtNuevoContratoRUT.TabIndex = 94
        '
        'lblNuevoContratoRUT
        '
        Me.lblNuevoContratoRUT.AutoSize = True
        Me.lblNuevoContratoRUT.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevoContratoRUT.Location = New System.Drawing.Point(129, 159)
        Me.lblNuevoContratoRUT.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblNuevoContratoRUT.Name = "lblNuevoContratoRUT"
        Me.lblNuevoContratoRUT.Size = New System.Drawing.Size(156, 24)
        Me.lblNuevoContratoRUT.TabIndex = 93
        Me.lblNuevoContratoRUT.Text = "RUT EMPRESA:"
        '
        'lblNuevoContratoTitulo
        '
        Me.lblNuevoContratoTitulo.AutoSize = True
        Me.lblNuevoContratoTitulo.Font = New System.Drawing.Font("Book Antiqua", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevoContratoTitulo.Location = New System.Drawing.Point(127, 71)
        Me.lblNuevoContratoTitulo.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblNuevoContratoTitulo.Name = "lblNuevoContratoTitulo"
        Me.lblNuevoContratoTitulo.Size = New System.Drawing.Size(178, 32)
        Me.lblNuevoContratoTitulo.TabIndex = 92
        Me.lblNuevoContratoTitulo.Text = "CONTRATO"
        '
        'dtpNuevoContratoFBaja
        '
        Me.dtpNuevoContratoFBaja.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNuevoContratoFBaja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNuevoContratoFBaja.Location = New System.Drawing.Point(308, 254)
        Me.dtpNuevoContratoFBaja.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpNuevoContratoFBaja.Name = "dtpNuevoContratoFBaja"
        Me.dtpNuevoContratoFBaja.Size = New System.Drawing.Size(196, 32)
        Me.dtpNuevoContratoFBaja.TabIndex = 91
        '
        'dtpNuevoContratoFAlta
        '
        Me.dtpNuevoContratoFAlta.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNuevoContratoFAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNuevoContratoFAlta.Location = New System.Drawing.Point(308, 201)
        Me.dtpNuevoContratoFAlta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpNuevoContratoFAlta.Name = "dtpNuevoContratoFAlta"
        Me.dtpNuevoContratoFAlta.Size = New System.Drawing.Size(196, 32)
        Me.dtpNuevoContratoFAlta.TabIndex = 90
        '
        'lblNuevoContratoFBaja
        '
        Me.lblNuevoContratoFBaja.AutoSize = True
        Me.lblNuevoContratoFBaja.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevoContratoFBaja.Location = New System.Drawing.Point(143, 257)
        Me.lblNuevoContratoFBaja.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblNuevoContratoFBaja.Name = "lblNuevoContratoFBaja"
        Me.lblNuevoContratoFBaja.Size = New System.Drawing.Size(141, 24)
        Me.lblNuevoContratoFBaja.TabIndex = 89
        Me.lblNuevoContratoFBaja.Text = "FECHA BAJA:"
        '
        'lblNuevoContratoFAlta
        '
        Me.lblNuevoContratoFAlta.AutoSize = True
        Me.lblNuevoContratoFAlta.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevoContratoFAlta.Location = New System.Drawing.Point(143, 204)
        Me.lblNuevoContratoFAlta.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblNuevoContratoFAlta.Name = "lblNuevoContratoFAlta"
        Me.lblNuevoContratoFAlta.Size = New System.Drawing.Size(146, 24)
        Me.lblNuevoContratoFAlta.TabIndex = 88
        Me.lblNuevoContratoFAlta.Text = "FECHA ALTA:"
        '
        'btnNuevoContratoAceptar
        '
        Me.btnNuevoContratoAceptar.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoContratoAceptar.Location = New System.Drawing.Point(739, 150)
        Me.btnNuevoContratoAceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNuevoContratoAceptar.Name = "btnNuevoContratoAceptar"
        Me.btnNuevoContratoAceptar.Size = New System.Drawing.Size(167, 70)
        Me.btnNuevoContratoAceptar.TabIndex = 96
        Me.btnNuevoContratoAceptar.Text = "ACEPTAR"
        Me.btnNuevoContratoAceptar.UseVisualStyleBackColor = True
        '
        'btnNuevoContratoVolver
        '
        Me.btnNuevoContratoVolver.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoContratoVolver.Location = New System.Drawing.Point(739, 235)
        Me.btnNuevoContratoVolver.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNuevoContratoVolver.Name = "btnNuevoContratoVolver"
        Me.btnNuevoContratoVolver.Size = New System.Drawing.Size(167, 70)
        Me.btnNuevoContratoVolver.TabIndex = 97
        Me.btnNuevoContratoVolver.Text = "VOLVER"
        Me.btnNuevoContratoVolver.UseVisualStyleBackColor = True
        '
        'FormNuevoContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 448)
        Me.Controls.Add(Me.btnNuevoContratoVolver)
        Me.Controls.Add(Me.btnNuevoContratoAceptar)
        Me.Controls.Add(Me.txtNuevoContratoRUT)
        Me.Controls.Add(Me.lblNuevoContratoRUT)
        Me.Controls.Add(Me.lblNuevoContratoTitulo)
        Me.Controls.Add(Me.dtpNuevoContratoFBaja)
        Me.Controls.Add(Me.dtpNuevoContratoFAlta)
        Me.Controls.Add(Me.lblNuevoContratoFBaja)
        Me.Controls.Add(Me.lblNuevoContratoFAlta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormNuevoContrato"
        Me.Text = "FormNuevoContrato"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNuevoContratoRUT As System.Windows.Forms.TextBox
    Friend WithEvents lblNuevoContratoRUT As System.Windows.Forms.Label
    Friend WithEvents lblNuevoContratoTitulo As System.Windows.Forms.Label
    Friend WithEvents dtpNuevoContratoFBaja As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpNuevoContratoFAlta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNuevoContratoFBaja As System.Windows.Forms.Label
    Friend WithEvents lblNuevoContratoFAlta As System.Windows.Forms.Label
    Friend WithEvents btnNuevoContratoAceptar As System.Windows.Forms.Button
    Friend WithEvents btnNuevoContratoVolver As System.Windows.Forms.Button
End Class
