<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLoginPass = New System.Windows.Forms.TextBox()
        Me.txtLoginUsuario = New System.Windows.Forms.TextBox()
        Me.btnLoginSalir = New System.Windows.Forms.Button()
        Me.btnLoginIniciarSesion = New System.Windows.Forms.Button()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLogin_SelecionarIdioma = New System.Windows.Forms.Label()
        Me.cboLogin_Idioma = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(319, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 44)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "LOGIN"
        '
        'txtLoginPass
        '
        Me.txtLoginPass.Font = New System.Drawing.Font("Book Antiqua", 12.0!)
        Me.txtLoginPass.Location = New System.Drawing.Point(301, 211)
        Me.txtLoginPass.Name = "txtLoginPass"
        Me.txtLoginPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtLoginPass.Size = New System.Drawing.Size(195, 27)
        Me.txtLoginPass.TabIndex = 1
        '
        'txtLoginUsuario
        '
        Me.txtLoginUsuario.Font = New System.Drawing.Font("Book Antiqua", 12.0!)
        Me.txtLoginUsuario.Location = New System.Drawing.Point(301, 155)
        Me.txtLoginUsuario.Name = "txtLoginUsuario"
        Me.txtLoginUsuario.Size = New System.Drawing.Size(195, 27)
        Me.txtLoginUsuario.TabIndex = 0
        '
        'btnLoginSalir
        '
        Me.btnLoginSalir.BackColor = System.Drawing.Color.Gray
        Me.btnLoginSalir.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLoginSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLoginSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLoginSalir.Location = New System.Drawing.Point(302, 308)
        Me.btnLoginSalir.Name = "btnLoginSalir"
        Me.btnLoginSalir.Size = New System.Drawing.Size(194, 57)
        Me.btnLoginSalir.TabIndex = 3
        Me.btnLoginSalir.Text = "SALIR"
        Me.btnLoginSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLoginSalir.UseVisualStyleBackColor = False
        '
        'btnLoginIniciarSesion
        '
        Me.btnLoginIniciarSesion.BackColor = System.Drawing.Color.Gray
        Me.btnLoginIniciarSesion.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLoginIniciarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLoginIniciarSesion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLoginIniciarSesion.Location = New System.Drawing.Point(301, 246)
        Me.btnLoginIniciarSesion.Name = "btnLoginIniciarSesion"
        Me.btnLoginIniciarSesion.Size = New System.Drawing.Size(195, 56)
        Me.btnLoginIniciarSesion.TabIndex = 2
        Me.btnLoginIniciarSesion.Text = "INICIAR " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SESION"
        Me.btnLoginIniciarSesion.UseVisualStyleBackColor = False
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblContraseña.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblContraseña.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblContraseña.Location = New System.Drawing.Point(323, 187)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(132, 21)
        Me.lblContraseña.TabIndex = 5
        Me.lblContraseña.Text = "CONTRASEÑA:"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUsuario.Location = New System.Drawing.Point(354, 131)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(91, 21)
        Me.lblUsuario.TabIndex = 7
        Me.lblUsuario.Text = "USUARIO:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SIGP.My.Resources.Resources._1489186756_constructioncivilengineerhelmetprotectionsafety_81825
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(49, 68)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(217, 209)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(49, 308)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(235, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic Light", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(65, 411)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(403, 14)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "HIPERCODE DEVELOPINGS. ALL RIGHTS RESERVED. ™, ® & COPYRIGHT © 2019."
        '
        'lblLogin_SelecionarIdioma
        '
        Me.lblLogin_SelecionarIdioma.AutoSize = True
        Me.lblLogin_SelecionarIdioma.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin_SelecionarIdioma.Location = New System.Drawing.Point(218, 12)
        Me.lblLogin_SelecionarIdioma.Name = "lblLogin_SelecionarIdioma"
        Me.lblLogin_SelecionarIdioma.Size = New System.Drawing.Size(165, 18)
        Me.lblLogin_SelecionarIdioma.TabIndex = 17
        Me.lblLogin_SelecionarIdioma.Text = "SELECCIONAR IDIOMA:"
        '
        'cboLogin_Idioma
        '
        Me.cboLogin_Idioma.FormattingEnabled = True
        Me.cboLogin_Idioma.Items.AddRange(New Object() {"trtrtr", "fd", "fd"})
        Me.cboLogin_Idioma.Location = New System.Drawing.Point(389, 12)
        Me.cboLogin_Idioma.Name = "cboLogin_Idioma"
        Me.cboLogin_Idioma.Size = New System.Drawing.Size(107, 21)
        Me.cboLogin_Idioma.TabIndex = 16
        '
        'FormLogin
        '
        Me.AcceptButton = Me.btnLoginIniciarSesion
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(514, 434)
        Me.Controls.Add(Me.lblLogin_SelecionarIdioma)
        Me.Controls.Add(Me.cboLogin_Idioma)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtLoginPass)
        Me.Controls.Add(Me.txtLoginUsuario)
        Me.Controls.Add(Me.btnLoginSalir)
        Me.Controls.Add(Me.btnLoginIniciarSesion)
        Me.Controls.Add(Me.lblContraseña)
        Me.Controls.Add(Me.lblUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormLogin"
        Me.Text = "S.I.G.P."
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtLoginPass As System.Windows.Forms.TextBox
    Friend WithEvents txtLoginUsuario As System.Windows.Forms.TextBox
    Friend WithEvents btnLoginSalir As System.Windows.Forms.Button
    Friend WithEvents btnLoginIniciarSesion As System.Windows.Forms.Button
    Friend WithEvents lblContraseña As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblLogin_SelecionarIdioma As System.Windows.Forms.Label
    Friend WithEvents cboLogin_Idioma As System.Windows.Forms.ComboBox
End Class
