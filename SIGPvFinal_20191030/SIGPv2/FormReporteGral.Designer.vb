<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteGral
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
        Me.lbl_Input_ResSub = New System.Windows.Forms.Label()
        Me.lbl_Input_ResObj = New System.Windows.Forms.Label()
        Me.lblCuestionarioRES0BJ = New System.Windows.Forms.Label()
        Me.lblCuestionarioRESSUB = New System.Windows.Forms.Label()
        Me.lbl_Input_FECHPROX = New System.Windows.Forms.Label()
        Me.lbl_Input_FECHCRE = New System.Windows.Forms.Label()
        Me.lbl_Input_PTO = New System.Windows.Forms.Label()
        Me.lbl_Input_PAF = New System.Windows.Forms.Label()
        Me.lbl_Input_Areat = New System.Windows.Forms.Label()
        Me.lbl_Input_NomCuest = New System.Windows.Forms.Label()
        Me.lblCuestionarioFECHCRED = New System.Windows.Forms.Label()
        Me.lblCuestionarioNomCuestionario = New System.Windows.Forms.Label()
        Me.lblCuestionarioTotalPers = New System.Windows.Forms.Label()
        Me.lblCuestionarioPersAfectadas = New System.Windows.Forms.Label()
        Me.lblCuestionarioAreaTrabajo = New System.Windows.Forms.Label()
        Me.lblCuestionarioFECHPROX = New System.Windows.Forms.Label()
        Me.lblCuestionarioTecnico = New System.Windows.Forms.Label()
        Me.lblCalculosTitulo = New System.Windows.Forms.Label()
        Me.lblCuestionarioEmpresa = New System.Windows.Forms.Label()
        Me.lbl_Input_Empresa = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_Input_Tecnico = New System.Windows.Forms.Label()
        Me.btnReporteGralSalir = New System.Windows.Forms.Button()
        Me.cboSeleccionarCuestionario = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnReporteBuscarCuestionario = New System.Windows.Forms.Button()
        Me.btnReporteBuscarMapa = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboSeleccionarMapa = New System.Windows.Forms.ComboBox()
        Me.lbl_Input_Estado = New System.Windows.Forms.Label()
        Me.lbl_Input_Visitas = New System.Windows.Forms.Label()
        Me.lblCuestionarioVisitas = New System.Windows.Forms.Label()
        Me.lblCuestionarioEstado = New System.Windows.Forms.Label()
        Me.tpReporteIndividuales = New System.Windows.Forms.TabPage()
        Me.dgvReporteIndividuales = New System.Windows.Forms.DataGridView()
        Me.tpReporteCuestionario = New System.Windows.Forms.TabPage()
        Me.dgvReporteCuestionarios = New System.Windows.Forms.DataGridView()
        Me.tpReporteInventario = New System.Windows.Forms.TabControl()
        Me.tpReporteCalculos = New System.Windows.Forms.TabPage()
        Me.dgvReporteCalculos = New System.Windows.Forms.DataGridView()
        Me.tpReporteMapas = New System.Windows.Forms.TabPage()
        Me.pbReporteMapa = New System.Windows.Forms.PictureBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dgvReporteInventario = New System.Windows.Forms.DataGridView()
        Me.tpReportePContingencia = New System.Windows.Forms.TabPage()
        Me.dgvReportePlanCont = New System.Windows.Forms.DataGridView()
        Me.tpReporteIndividuales.SuspendLayout()
        CType(Me.dgvReporteIndividuales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpReporteCuestionario.SuspendLayout()
        CType(Me.dgvReporteCuestionarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpReporteInventario.SuspendLayout()
        Me.tpReporteCalculos.SuspendLayout()
        CType(Me.dgvReporteCalculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpReporteMapas.SuspendLayout()
        CType(Me.pbReporteMapa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgvReporteInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpReportePContingencia.SuspendLayout()
        CType(Me.dgvReportePlanCont, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Input_ResSub
        '
        Me.lbl_Input_ResSub.AutoSize = True
        Me.lbl_Input_ResSub.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Input_ResSub.Location = New System.Drawing.Point(1715, 214)
        Me.lbl_Input_ResSub.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Input_ResSub.Name = "lbl_Input_ResSub"
        Me.lbl_Input_ResSub.Size = New System.Drawing.Size(147, 21)
        Me.lbl_Input_ResSub.TabIndex = 482
        Me.lbl_Input_ResSub.Text = "Etiqueta Res. Sub."
        '
        'lbl_Input_ResObj
        '
        Me.lbl_Input_ResObj.AutoSize = True
        Me.lbl_Input_ResObj.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Input_ResObj.Location = New System.Drawing.Point(1715, 196)
        Me.lbl_Input_ResObj.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Input_ResObj.Name = "lbl_Input_ResObj"
        Me.lbl_Input_ResObj.Size = New System.Drawing.Size(146, 21)
        Me.lbl_Input_ResObj.TabIndex = 481
        Me.lbl_Input_ResObj.Text = "Etiqueta Res. Obj."
        '
        'lblCuestionarioRES0BJ
        '
        Me.lblCuestionarioRES0BJ.AutoSize = True
        Me.lblCuestionarioRES0BJ.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuestionarioRES0BJ.Location = New System.Drawing.Point(1540, 194)
        Me.lblCuestionarioRES0BJ.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCuestionarioRES0BJ.Name = "lblCuestionarioRES0BJ"
        Me.lblCuestionarioRES0BJ.Size = New System.Drawing.Size(180, 21)
        Me.lblCuestionarioRES0BJ.TabIndex = 480
        Me.lblCuestionarioRES0BJ.Text = "Resultado Objetivo:"
        '
        'lblCuestionarioRESSUB
        '
        Me.lblCuestionarioRESSUB.AutoSize = True
        Me.lblCuestionarioRESSUB.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuestionarioRESSUB.Location = New System.Drawing.Point(1529, 214)
        Me.lblCuestionarioRESSUB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCuestionarioRESSUB.Name = "lblCuestionarioRESSUB"
        Me.lblCuestionarioRESSUB.Size = New System.Drawing.Size(189, 21)
        Me.lblCuestionarioRESSUB.TabIndex = 479
        Me.lblCuestionarioRESSUB.Text = "Resultado Subjetivo:"
        '
        'lbl_Input_FECHPROX
        '
        Me.lbl_Input_FECHPROX.AutoSize = True
        Me.lbl_Input_FECHPROX.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Input_FECHPROX.Location = New System.Drawing.Point(1243, 214)
        Me.lbl_Input_FECHPROX.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Input_FECHPROX.Name = "lbl_Input_FECHPROX"
        Me.lbl_Input_FECHPROX.Size = New System.Drawing.Size(196, 21)
        Me.lbl_Input_FECHPROX.TabIndex = 478
        Me.lbl_Input_FECHPROX.Text = "Etiqueta Fecha Prox Rev."
        '
        'lbl_Input_FECHCRE
        '
        Me.lbl_Input_FECHCRE.AutoSize = True
        Me.lbl_Input_FECHCRE.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Input_FECHCRE.Location = New System.Drawing.Point(1243, 196)
        Me.lbl_Input_FECHCRE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Input_FECHCRE.Name = "lbl_Input_FECHCRE"
        Me.lbl_Input_FECHCRE.Size = New System.Drawing.Size(178, 21)
        Me.lbl_Input_FECHCRE.TabIndex = 477
        Me.lbl_Input_FECHCRE.Text = "Etiqueta Fecha Creado"
        '
        'lbl_Input_PTO
        '
        Me.lbl_Input_PTO.AutoSize = True
        Me.lbl_Input_PTO.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Input_PTO.Location = New System.Drawing.Point(765, 213)
        Me.lbl_Input_PTO.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Input_PTO.Name = "lbl_Input_PTO"
        Me.lbl_Input_PTO.Size = New System.Drawing.Size(187, 21)
        Me.lbl_Input_PTO.TabIndex = 476
        Me.lbl_Input_PTO.Text = "Etiqueta Total Personas"
        '
        'lbl_Input_PAF
        '
        Me.lbl_Input_PAF.AutoSize = True
        Me.lbl_Input_PAF.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Input_PAF.Location = New System.Drawing.Point(765, 194)
        Me.lbl_Input_PAF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Input_PAF.Name = "lbl_Input_PAF"
        Me.lbl_Input_PAF.Size = New System.Drawing.Size(223, 21)
        Me.lbl_Input_PAF.TabIndex = 475
        Me.lbl_Input_PAF.Text = "Etiqueta Personas Afectadas"
        '
        'lbl_Input_Areat
        '
        Me.lbl_Input_Areat.AutoSize = True
        Me.lbl_Input_Areat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Input_Areat.Location = New System.Drawing.Point(280, 213)
        Me.lbl_Input_Areat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Input_Areat.Name = "lbl_Input_Areat"
        Me.lbl_Input_Areat.Size = New System.Drawing.Size(174, 21)
        Me.lbl_Input_Areat.TabIndex = 474
        Me.lbl_Input_Areat.Text = "Etiqueta Area Trabajo"
        '
        'lbl_Input_NomCuest
        '
        Me.lbl_Input_NomCuest.AutoSize = True
        Me.lbl_Input_NomCuest.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Input_NomCuest.Location = New System.Drawing.Point(280, 194)
        Me.lbl_Input_NomCuest.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Input_NomCuest.Name = "lbl_Input_NomCuest"
        Me.lbl_Input_NomCuest.Size = New System.Drawing.Size(232, 21)
        Me.lbl_Input_NomCuest.TabIndex = 473
        Me.lbl_Input_NomCuest.Text = "Etiqueta Nombre Cuestionario"
        '
        'lblCuestionarioFECHCRED
        '
        Me.lblCuestionarioFECHCRED.AutoSize = True
        Me.lblCuestionarioFECHCRED.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuestionarioFECHCRED.Location = New System.Drawing.Point(1113, 194)
        Me.lblCuestionarioFECHCRED.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCuestionarioFECHCRED.Name = "lblCuestionarioFECHCRED"
        Me.lblCuestionarioFECHCRED.Size = New System.Drawing.Size(131, 21)
        Me.lblCuestionarioFECHCRED.TabIndex = 470
        Me.lblCuestionarioFECHCRED.Text = "Fecha Creado:"
        '
        'lblCuestionarioNomCuestionario
        '
        Me.lblCuestionarioNomCuestionario.AutoSize = True
        Me.lblCuestionarioNomCuestionario.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuestionarioNomCuestionario.Location = New System.Drawing.Point(61, 194)
        Me.lblCuestionarioNomCuestionario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCuestionarioNomCuestionario.Name = "lblCuestionarioNomCuestionario"
        Me.lblCuestionarioNomCuestionario.Size = New System.Drawing.Size(223, 21)
        Me.lblCuestionarioNomCuestionario.TabIndex = 468
        Me.lblCuestionarioNomCuestionario.Text = "Nombre de Cuestionario:"
        '
        'lblCuestionarioTotalPers
        '
        Me.lblCuestionarioTotalPers.AutoSize = True
        Me.lblCuestionarioTotalPers.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuestionarioTotalPers.Location = New System.Drawing.Point(620, 214)
        Me.lblCuestionarioTotalPers.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCuestionarioTotalPers.Name = "lblCuestionarioTotalPers"
        Me.lblCuestionarioTotalPers.Size = New System.Drawing.Size(142, 21)
        Me.lblCuestionarioTotalPers.TabIndex = 340
        Me.lblCuestionarioTotalPers.Text = "Total Personas:"
        '
        'lblCuestionarioPersAfectadas
        '
        Me.lblCuestionarioPersAfectadas.AutoSize = True
        Me.lblCuestionarioPersAfectadas.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuestionarioPersAfectadas.Location = New System.Drawing.Point(575, 194)
        Me.lblCuestionarioPersAfectadas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCuestionarioPersAfectadas.Name = "lblCuestionarioPersAfectadas"
        Me.lblCuestionarioPersAfectadas.Size = New System.Drawing.Size(184, 21)
        Me.lblCuestionarioPersAfectadas.TabIndex = 333
        Me.lblCuestionarioPersAfectadas.Text = "Personas Afectadas:"
        '
        'lblCuestionarioAreaTrabajo
        '
        Me.lblCuestionarioAreaTrabajo.AutoSize = True
        Me.lblCuestionarioAreaTrabajo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuestionarioAreaTrabajo.Location = New System.Drawing.Point(127, 214)
        Me.lblCuestionarioAreaTrabajo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCuestionarioAreaTrabajo.Name = "lblCuestionarioAreaTrabajo"
        Me.lblCuestionarioAreaTrabajo.Size = New System.Drawing.Size(148, 21)
        Me.lblCuestionarioAreaTrabajo.TabIndex = 335
        Me.lblCuestionarioAreaTrabajo.Text = "Area de trabajo:"
        '
        'lblCuestionarioFECHPROX
        '
        Me.lblCuestionarioFECHPROX.AutoSize = True
        Me.lblCuestionarioFECHPROX.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuestionarioFECHPROX.Location = New System.Drawing.Point(1036, 214)
        Me.lblCuestionarioFECHPROX.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCuestionarioFECHPROX.Name = "lblCuestionarioFECHPROX"
        Me.lblCuestionarioFECHPROX.Size = New System.Drawing.Size(219, 21)
        Me.lblCuestionarioFECHPROX.TabIndex = 336
        Me.lblCuestionarioFECHPROX.Text = "Fecha Proxima Revisión:"
        '
        'lblCuestionarioTecnico
        '
        Me.lblCuestionarioTecnico.AutoSize = True
        Me.lblCuestionarioTecnico.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuestionarioTecnico.Location = New System.Drawing.Point(61, 122)
        Me.lblCuestionarioTecnico.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCuestionarioTecnico.Name = "lblCuestionarioTecnico"
        Me.lblCuestionarioTecnico.Size = New System.Drawing.Size(90, 23)
        Me.lblCuestionarioTecnico.TabIndex = 337
        Me.lblCuestionarioTecnico.Text = "Técnico:"
        '
        'lblCalculosTitulo
        '
        Me.lblCalculosTitulo.AutoSize = True
        Me.lblCalculosTitulo.Font = New System.Drawing.Font("Book Antiqua", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalculosTitulo.Location = New System.Drawing.Point(61, 50)
        Me.lblCalculosTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCalculosTitulo.Name = "lblCalculosTitulo"
        Me.lblCalculosTitulo.Size = New System.Drawing.Size(416, 47)
        Me.lblCalculosTitulo.TabIndex = 20
        Me.lblCalculosTitulo.Text = "REPORTE GENERAL."
        '
        'lblCuestionarioEmpresa
        '
        Me.lblCuestionarioEmpresa.AutoSize = True
        Me.lblCuestionarioEmpresa.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuestionarioEmpresa.Location = New System.Drawing.Point(53, 102)
        Me.lblCuestionarioEmpresa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCuestionarioEmpresa.Name = "lblCuestionarioEmpresa"
        Me.lblCuestionarioEmpresa.Size = New System.Drawing.Size(99, 23)
        Me.lblCuestionarioEmpresa.TabIndex = 470
        Me.lblCuestionarioEmpresa.Text = "Empresa:"
        '
        'lbl_Input_Empresa
        '
        Me.lbl_Input_Empresa.AutoSize = True
        Me.lbl_Input_Empresa.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Input_Empresa.Location = New System.Drawing.Point(151, 105)
        Me.lbl_Input_Empresa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Input_Empresa.Name = "lbl_Input_Empresa"
        Me.lbl_Input_Empresa.Size = New System.Drawing.Size(142, 21)
        Me.lbl_Input_Empresa.TabIndex = 471
        Me.lbl_Input_Empresa.Text = "Etiqueta Empresa"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 0
        '
        'lbl_Input_Tecnico
        '
        Me.lbl_Input_Tecnico.AutoSize = True
        Me.lbl_Input_Tecnico.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Input_Tecnico.Location = New System.Drawing.Point(151, 124)
        Me.lbl_Input_Tecnico.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Input_Tecnico.Name = "lbl_Input_Tecnico"
        Me.lbl_Input_Tecnico.Size = New System.Drawing.Size(134, 21)
        Me.lbl_Input_Tecnico.TabIndex = 472
        Me.lbl_Input_Tecnico.Text = "Etiqueta Técnico"
        '
        'btnReporteGralSalir
        '
        Me.btnReporteGralSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnReporteGralSalir.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporteGralSalir.Location = New System.Drawing.Point(1627, 908)
        Me.btnReporteGralSalir.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnReporteGralSalir.Name = "btnReporteGralSalir"
        Me.btnReporteGralSalir.Size = New System.Drawing.Size(241, 62)
        Me.btnReporteGralSalir.TabIndex = 473
        Me.btnReporteGralSalir.Text = "SALIR"
        Me.btnReporteGralSalir.UseVisualStyleBackColor = False
        '
        'cboSeleccionarCuestionario
        '
        Me.cboSeleccionarCuestionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSeleccionarCuestionario.FormattingEnabled = True
        Me.cboSeleccionarCuestionario.Location = New System.Drawing.Point(1399, 70)
        Me.cboSeleccionarCuestionario.Margin = New System.Windows.Forms.Padding(4)
        Me.cboSeleccionarCuestionario.Name = "cboSeleccionarCuestionario"
        Me.cboSeleccionarCuestionario.Size = New System.Drawing.Size(328, 24)
        Me.cboSeleccionarCuestionario.TabIndex = 483
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1168, 71)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(227, 21)
        Me.Label5.TabIndex = 484
        Me.Label5.Text = "Seleccionar Cuestionario:"
        '
        'btnReporteBuscarCuestionario
        '
        Me.btnReporteBuscarCuestionario.BackColor = System.Drawing.SystemColors.Control
        Me.btnReporteBuscarCuestionario.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporteBuscarCuestionario.Image = Global.SIGP.My.Resources.Resources.iconfinder_magnifying_glass_226571
        Me.btnReporteBuscarCuestionario.Location = New System.Drawing.Point(1739, 68)
        Me.btnReporteBuscarCuestionario.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnReporteBuscarCuestionario.Name = "btnReporteBuscarCuestionario"
        Me.btnReporteBuscarCuestionario.Size = New System.Drawing.Size(129, 30)
        Me.btnReporteBuscarCuestionario.TabIndex = 485
        Me.btnReporteBuscarCuestionario.UseVisualStyleBackColor = False
        '
        'btnReporteBuscarMapa
        '
        Me.btnReporteBuscarMapa.BackColor = System.Drawing.SystemColors.Control
        Me.btnReporteBuscarMapa.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporteBuscarMapa.Image = Global.SIGP.My.Resources.Resources.iconfinder_magnifying_glass_226571
        Me.btnReporteBuscarMapa.Location = New System.Drawing.Point(1739, 103)
        Me.btnReporteBuscarMapa.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnReporteBuscarMapa.Name = "btnReporteBuscarMapa"
        Me.btnReporteBuscarMapa.Size = New System.Drawing.Size(129, 30)
        Me.btnReporteBuscarMapa.TabIndex = 488
        Me.btnReporteBuscarMapa.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1225, 107)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 21)
        Me.Label2.TabIndex = 487
        Me.Label2.Text = "Seleccionar Mapa:"
        '
        'cboSeleccionarMapa
        '
        Me.cboSeleccionarMapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSeleccionarMapa.FormattingEnabled = True
        Me.cboSeleccionarMapa.Location = New System.Drawing.Point(1399, 106)
        Me.cboSeleccionarMapa.Margin = New System.Windows.Forms.Padding(4)
        Me.cboSeleccionarMapa.Name = "cboSeleccionarMapa"
        Me.cboSeleccionarMapa.Size = New System.Drawing.Size(328, 24)
        Me.cboSeleccionarMapa.TabIndex = 486
        '
        'lbl_Input_Estado
        '
        Me.lbl_Input_Estado.AutoSize = True
        Me.lbl_Input_Estado.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Input_Estado.Location = New System.Drawing.Point(152, 164)
        Me.lbl_Input_Estado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Input_Estado.Name = "lbl_Input_Estado"
        Me.lbl_Input_Estado.Size = New System.Drawing.Size(128, 21)
        Me.lbl_Input_Estado.TabIndex = 492
        Me.lbl_Input_Estado.Text = "Etiqueta Estado"
        '
        'lbl_Input_Visitas
        '
        Me.lbl_Input_Visitas.AutoSize = True
        Me.lbl_Input_Visitas.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Input_Visitas.Location = New System.Drawing.Point(151, 144)
        Me.lbl_Input_Visitas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Input_Visitas.Name = "lbl_Input_Visitas"
        Me.lbl_Input_Visitas.Size = New System.Drawing.Size(126, 21)
        Me.lbl_Input_Visitas.TabIndex = 491
        Me.lbl_Input_Visitas.Text = "Etiqueta Visitas"
        '
        'lblCuestionarioVisitas
        '
        Me.lblCuestionarioVisitas.AutoSize = True
        Me.lblCuestionarioVisitas.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuestionarioVisitas.Location = New System.Drawing.Point(69, 142)
        Me.lblCuestionarioVisitas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCuestionarioVisitas.Name = "lblCuestionarioVisitas"
        Me.lblCuestionarioVisitas.Size = New System.Drawing.Size(81, 23)
        Me.lblCuestionarioVisitas.TabIndex = 490
        Me.lblCuestionarioVisitas.Text = "Visitas:"
        '
        'lblCuestionarioEstado
        '
        Me.lblCuestionarioEstado.AutoSize = True
        Me.lblCuestionarioEstado.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuestionarioEstado.Location = New System.Drawing.Point(71, 161)
        Me.lblCuestionarioEstado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCuestionarioEstado.Name = "lblCuestionarioEstado"
        Me.lblCuestionarioEstado.Size = New System.Drawing.Size(82, 23)
        Me.lblCuestionarioEstado.TabIndex = 489
        Me.lblCuestionarioEstado.Text = "Estado:"
        '
        'tpReporteIndividuales
        '
        Me.tpReporteIndividuales.Controls.Add(Me.dgvReporteIndividuales)
        Me.tpReporteIndividuales.Location = New System.Drawing.Point(4, 29)
        Me.tpReporteIndividuales.Margin = New System.Windows.Forms.Padding(4)
        Me.tpReporteIndividuales.Name = "tpReporteIndividuales"
        Me.tpReporteIndividuales.Padding = New System.Windows.Forms.Padding(4)
        Me.tpReporteIndividuales.Size = New System.Drawing.Size(1832, 627)
        Me.tpReporteIndividuales.TabIndex = 5
        Me.tpReporteIndividuales.Text = "Reportes Individuales"
        Me.tpReporteIndividuales.UseVisualStyleBackColor = True
        '
        'dgvReporteIndividuales
        '
        Me.dgvReporteIndividuales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReporteIndividuales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvReporteIndividuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReporteIndividuales.Location = New System.Drawing.Point(8, 5)
        Me.dgvReporteIndividuales.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvReporteIndividuales.Name = "dgvReporteIndividuales"
        Me.dgvReporteIndividuales.Size = New System.Drawing.Size(1813, 613)
        Me.dgvReporteIndividuales.TabIndex = 473
        '
        'tpReporteCuestionario
        '
        Me.tpReporteCuestionario.Controls.Add(Me.dgvReporteCuestionarios)
        Me.tpReporteCuestionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpReporteCuestionario.Location = New System.Drawing.Point(4, 29)
        Me.tpReporteCuestionario.Margin = New System.Windows.Forms.Padding(4)
        Me.tpReporteCuestionario.Name = "tpReporteCuestionario"
        Me.tpReporteCuestionario.Padding = New System.Windows.Forms.Padding(4)
        Me.tpReporteCuestionario.Size = New System.Drawing.Size(1832, 627)
        Me.tpReporteCuestionario.TabIndex = 0
        Me.tpReporteCuestionario.Text = "Cuestionario"
        Me.tpReporteCuestionario.UseVisualStyleBackColor = True
        '
        'dgvReporteCuestionarios
        '
        Me.dgvReporteCuestionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReporteCuestionarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvReporteCuestionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReporteCuestionarios.Location = New System.Drawing.Point(8, 7)
        Me.dgvReporteCuestionarios.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvReporteCuestionarios.Name = "dgvReporteCuestionarios"
        Me.dgvReporteCuestionarios.Size = New System.Drawing.Size(1813, 615)
        Me.dgvReporteCuestionarios.TabIndex = 469
        '
        'tpReporteInventario
        '
        Me.tpReporteInventario.Controls.Add(Me.tpReporteCuestionario)
        Me.tpReporteInventario.Controls.Add(Me.tpReporteIndividuales)
        Me.tpReporteInventario.Controls.Add(Me.tpReporteCalculos)
        Me.tpReporteInventario.Controls.Add(Me.tpReporteMapas)
        Me.tpReporteInventario.Controls.Add(Me.TabPage4)
        Me.tpReporteInventario.Controls.Add(Me.tpReportePContingencia)
        Me.tpReporteInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpReporteInventario.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.tpReporteInventario.Location = New System.Drawing.Point(33, 239)
        Me.tpReporteInventario.Margin = New System.Windows.Forms.Padding(4)
        Me.tpReporteInventario.Name = "tpReporteInventario"
        Me.tpReporteInventario.SelectedIndex = 0
        Me.tpReporteInventario.Size = New System.Drawing.Size(1840, 660)
        Me.tpReporteInventario.TabIndex = 0
        '
        'tpReporteCalculos
        '
        Me.tpReporteCalculos.Controls.Add(Me.dgvReporteCalculos)
        Me.tpReporteCalculos.Location = New System.Drawing.Point(4, 29)
        Me.tpReporteCalculos.Margin = New System.Windows.Forms.Padding(4)
        Me.tpReporteCalculos.Name = "tpReporteCalculos"
        Me.tpReporteCalculos.Padding = New System.Windows.Forms.Padding(4)
        Me.tpReporteCalculos.Size = New System.Drawing.Size(1832, 627)
        Me.tpReporteCalculos.TabIndex = 6
        Me.tpReporteCalculos.Text = "Cálculos"
        Me.tpReporteCalculos.UseVisualStyleBackColor = True
        '
        'dgvReporteCalculos
        '
        Me.dgvReporteCalculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReporteCalculos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvReporteCalculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReporteCalculos.Location = New System.Drawing.Point(4, 7)
        Me.dgvReporteCalculos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvReporteCalculos.Name = "dgvReporteCalculos"
        Me.dgvReporteCalculos.Size = New System.Drawing.Size(1836, 609)
        Me.dgvReporteCalculos.TabIndex = 470
        '
        'tpReporteMapas
        '
        Me.tpReporteMapas.Controls.Add(Me.pbReporteMapa)
        Me.tpReporteMapas.Location = New System.Drawing.Point(4, 29)
        Me.tpReporteMapas.Margin = New System.Windows.Forms.Padding(4)
        Me.tpReporteMapas.Name = "tpReporteMapas"
        Me.tpReporteMapas.Padding = New System.Windows.Forms.Padding(4)
        Me.tpReporteMapas.Size = New System.Drawing.Size(1832, 627)
        Me.tpReporteMapas.TabIndex = 7
        Me.tpReporteMapas.Text = "Mapa"
        Me.tpReporteMapas.UseVisualStyleBackColor = True
        '
        'pbReporteMapa
        '
        Me.pbReporteMapa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbReporteMapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbReporteMapa.Location = New System.Drawing.Point(8, 7)
        Me.pbReporteMapa.Margin = New System.Windows.Forms.Padding(4)
        Me.pbReporteMapa.Name = "pbReporteMapa"
        Me.pbReporteMapa.Size = New System.Drawing.Size(1809, 612)
        Me.pbReporteMapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbReporteMapa.TabIndex = 1
        Me.pbReporteMapa.TabStop = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dgvReporteInventario)
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Size = New System.Drawing.Size(1832, 627)
        Me.TabPage4.TabIndex = 8
        Me.TabPage4.Text = "Inventario"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dgvReporteInventario
        '
        Me.dgvReporteInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReporteInventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvReporteInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReporteInventario.Location = New System.Drawing.Point(8, 7)
        Me.dgvReporteInventario.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvReporteInventario.Name = "dgvReporteInventario"
        Me.dgvReporteInventario.Size = New System.Drawing.Size(1813, 613)
        Me.dgvReporteInventario.TabIndex = 471
        '
        'tpReportePContingencia
        '
        Me.tpReportePContingencia.Controls.Add(Me.dgvReportePlanCont)
        Me.tpReportePContingencia.Location = New System.Drawing.Point(4, 29)
        Me.tpReportePContingencia.Margin = New System.Windows.Forms.Padding(4)
        Me.tpReportePContingencia.Name = "tpReportePContingencia"
        Me.tpReportePContingencia.Padding = New System.Windows.Forms.Padding(4)
        Me.tpReportePContingencia.Size = New System.Drawing.Size(1832, 627)
        Me.tpReportePContingencia.TabIndex = 9
        Me.tpReportePContingencia.Text = "Planes de Contingencia"
        Me.tpReportePContingencia.UseVisualStyleBackColor = True
        '
        'dgvReportePlanCont
        '
        Me.dgvReportePlanCont.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReportePlanCont.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvReportePlanCont.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReportePlanCont.Location = New System.Drawing.Point(8, 7)
        Me.dgvReportePlanCont.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvReportePlanCont.Name = "dgvReportePlanCont"
        Me.dgvReportePlanCont.Size = New System.Drawing.Size(1813, 613)
        Me.dgvReportePlanCont.TabIndex = 472
        '
        'FormReporteGral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1889, 972)
        Me.Controls.Add(Me.lbl_Input_Estado)
        Me.Controls.Add(Me.lbl_Input_Visitas)
        Me.Controls.Add(Me.lblCuestionarioVisitas)
        Me.Controls.Add(Me.lblCuestionarioEstado)
        Me.Controls.Add(Me.btnReporteBuscarMapa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboSeleccionarMapa)
        Me.Controls.Add(Me.btnReporteBuscarCuestionario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboSeleccionarCuestionario)
        Me.Controls.Add(Me.lbl_Input_ResSub)
        Me.Controls.Add(Me.lbl_Input_ResObj)
        Me.Controls.Add(Me.btnReporteGralSalir)
        Me.Controls.Add(Me.lbl_Input_Tecnico)
        Me.Controls.Add(Me.lblCuestionarioRES0BJ)
        Me.Controls.Add(Me.lbl_Input_Empresa)
        Me.Controls.Add(Me.lblCuestionarioRESSUB)
        Me.Controls.Add(Me.lblCuestionarioEmpresa)
        Me.Controls.Add(Me.lbl_Input_FECHPROX)
        Me.Controls.Add(Me.lblCuestionarioTecnico)
        Me.Controls.Add(Me.lbl_Input_FECHCRE)
        Me.Controls.Add(Me.lblCalculosTitulo)
        Me.Controls.Add(Me.lbl_Input_PTO)
        Me.Controls.Add(Me.tpReporteInventario)
        Me.Controls.Add(Me.lbl_Input_PAF)
        Me.Controls.Add(Me.lblCuestionarioNomCuestionario)
        Me.Controls.Add(Me.lbl_Input_Areat)
        Me.Controls.Add(Me.lblCuestionarioFECHPROX)
        Me.Controls.Add(Me.lbl_Input_NomCuest)
        Me.Controls.Add(Me.lblCuestionarioAreaTrabajo)
        Me.Controls.Add(Me.lblCuestionarioFECHCRED)
        Me.Controls.Add(Me.lblCuestionarioPersAfectadas)
        Me.Controls.Add(Me.lblCuestionarioTotalPers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormReporteGral"
        Me.Text = "ReporteGral"
        Me.tpReporteIndividuales.ResumeLayout(False)
        CType(Me.dgvReporteIndividuales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpReporteCuestionario.ResumeLayout(False)
        CType(Me.dgvReporteCuestionarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpReporteInventario.ResumeLayout(False)
        Me.tpReporteCalculos.ResumeLayout(False)
        CType(Me.dgvReporteCalculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpReporteMapas.ResumeLayout(False)
        CType(Me.pbReporteMapa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.dgvReporteInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpReportePContingencia.ResumeLayout(False)
        CType(Me.dgvReportePlanCont, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCuestionarioTotalPers As System.Windows.Forms.Label
    Friend WithEvents lblCuestionarioTecnico As System.Windows.Forms.Label
    Friend WithEvents lblCuestionarioFECHPROX As System.Windows.Forms.Label
    Friend WithEvents lblCuestionarioAreaTrabajo As System.Windows.Forms.Label
    Friend WithEvents lblCuestionarioPersAfectadas As System.Windows.Forms.Label
    Friend WithEvents lblCuestionarioNomCuestionario As System.Windows.Forms.Label
    Friend WithEvents lblCalculosTitulo As System.Windows.Forms.Label
    Friend WithEvents lbl_Input_FECHPROX As System.Windows.Forms.Label
    Friend WithEvents lbl_Input_FECHCRE As System.Windows.Forms.Label
    Friend WithEvents lbl_Input_PTO As System.Windows.Forms.Label
    Friend WithEvents lbl_Input_PAF As System.Windows.Forms.Label
    Friend WithEvents lbl_Input_Areat As System.Windows.Forms.Label
    Friend WithEvents lbl_Input_NomCuest As System.Windows.Forms.Label
    Friend WithEvents lblCuestionarioFECHCRED As System.Windows.Forms.Label
    Friend WithEvents lblCuestionarioEmpresa As System.Windows.Forms.Label
    Friend WithEvents lbl_Input_Empresa As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_Input_Tecnico As System.Windows.Forms.Label
    Friend WithEvents lbl_Input_ResSub As System.Windows.Forms.Label
    Friend WithEvents lbl_Input_ResObj As System.Windows.Forms.Label
    Friend WithEvents lblCuestionarioRES0BJ As System.Windows.Forms.Label
    Friend WithEvents lblCuestionarioRESSUB As System.Windows.Forms.Label
    Friend WithEvents btnReporteGralSalir As System.Windows.Forms.Button
    Friend WithEvents cboSeleccionarCuestionario As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnReporteBuscarCuestionario As System.Windows.Forms.Button
    Friend WithEvents btnReporteBuscarMapa As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboSeleccionarMapa As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Input_Estado As System.Windows.Forms.Label
    Friend WithEvents lbl_Input_Visitas As System.Windows.Forms.Label
    Friend WithEvents lblCuestionarioVisitas As System.Windows.Forms.Label
    Friend WithEvents lblCuestionarioEstado As System.Windows.Forms.Label
    Friend WithEvents tpReporteIndividuales As System.Windows.Forms.TabPage
    Friend WithEvents dgvReporteIndividuales As System.Windows.Forms.DataGridView
    Friend WithEvents tpReporteCuestionario As System.Windows.Forms.TabPage
    Friend WithEvents dgvReporteCuestionarios As System.Windows.Forms.DataGridView
    Friend WithEvents tpReporteInventario As System.Windows.Forms.TabControl
    Friend WithEvents tpReporteCalculos As System.Windows.Forms.TabPage
    Friend WithEvents dgvReporteCalculos As System.Windows.Forms.DataGridView
    Friend WithEvents tpReporteMapas As System.Windows.Forms.TabPage
    Friend WithEvents pbReporteMapa As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents dgvReporteInventario As System.Windows.Forms.DataGridView
    Friend WithEvents tpReportePContingencia As System.Windows.Forms.TabPage
    Friend WithEvents dgvReportePlanCont As System.Windows.Forms.DataGridView
End Class
