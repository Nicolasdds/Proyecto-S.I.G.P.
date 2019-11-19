Imports System.Data.Odbc
Public Class FormReporteGral

    Private Sub FormReporteGral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        MaximizeBox = False
        MinimizeBox = False
        dgvReporteCuestionarios.ReadOnly = True
        setup_datagrids()
        ocultar_etiquetas()
        asignar_datos_estaticos()
        cargar_ComboBox_Cuestionarios()
        cargar_ComboBox_Mapas()
        cargar_datos_relevamiento(RelevamientoActualId)
        cargar_inventario()
        cargar_planes()
    End Sub

    Private Sub btnReporteBuscarCuestionario_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReporteBuscarCuestionario.Click
        Dim seleccion As String
        If cboSeleccionarCuestionario.Text = "" Then
            MsgBox("Debe seleccionario un cuestionario.")
        Else
            seleccion = cboSeleccionarCuestionario.Text
            cargar_datos_cuestionario(seleccion)
            cargar_preguntas(id_cuestionario)
            cargar_calculo(id_cuestionario)
            obtener_promedio(id_cuestionario)
            cargar_reportes(id_cuestionario)
            asignar_datos_dinamicos()
        End If
    End Sub

    Private Sub cargar_reportes(ByVal id_cuestionario As String)
        Dim ds As New DataSet
        Dim sql As String
        Try
            sql = "select * from reporte where id_rep in (select id_rep from pregunta where id_cuestionario=" & id_cuestionario & ")"
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvReporteIndividuales.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox("Error al traer reportes.")
        End Try
    End Sub

    Private Sub btnReporteBuscarMapa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporteBuscarMapa.Click
        Dim seleccion As String
        If cboSeleccionarMapa.Text = "" Then
            MsgBox("Debe seleccionar un mapa")
        Else
            seleccion = cboSeleccionarMapa.Text
            cargar_mapa(seleccion)
        End If
    End Sub

    Private Sub cargar_ComboBox_Cuestionarios()
        Dim dr As Odbc.OdbcDataReader
        Dim sql As String
        Try
            sql = "SELECT * FROM cuestionario where id_relev='" & RelevamientoActualId & "'"
            comando.Connection = conexion
            comando.CommandText = sql
            dr = comando.ExecuteReader()
            While dr.Read
                cboSeleccionarCuestionario.Items.Add(dr.Item("area_trabajo"))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox("Error al traer nombres de cuestionarios.")
        End Try
    End Sub

    Private Sub cargar_ComboBox_Mapas()
        Dim dr As Odbc.OdbcDataReader
        Dim sql As String
        Try
            sql = "SELECT * FROM mapa where id_relev='" & RelevamientoActualId & "'"
            comando.Connection = conexion
            comando.CommandText = sql
            dr = comando.ExecuteReader()
            While dr.Read
                cboSeleccionarMapa.Items.Add(dr.Item("titulo"))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox("Error al traer titulos de mapas.")
        End Try
    End Sub

    Private Sub cargar_datos_cuestionario(ByVal seleccion As String)
        Dim dr As Odbc.OdbcDataReader
        Dim sql As String
        Try
            sql = "select * from cuestionario where area_trabajo='" & seleccion & "'"
            comando.Connection = conexion
            comando.CommandText = sql
            dr = comando.ExecuteReader()
            If dr.HasRows Then
                nom_cuestionario = dr("nom_cuestionario")
                id_cuestionario = dr("id_cuestionario")
                area_trabajo = dr("area_trabajo")
                pers_totales = dr("pers_totales")
                pers_afec = dr("pers_afec")
                res_subjetivo = dr("res_subjetivo")
                fecha_prox_cuest = dr("fecha_prox_cuest")
                fecha_creado = dr("fecha_creado")
                dr.Close()
                If StrComp(res_subjetivo, "c") Then
                    res_subjetivo = "Correcto"
                ElseIf StrComp(res_subjetivo, "m") Then
                    res_subjetivo = "Mejorable"
                ElseIf StrComp(res_subjetivo, "d") Then
                    res_subjetivo = "Deficiente"
                ElseIf StrComp(res_subjetivo, "md") Then
                    res_subjetivo = "Muy Deficiente"
                End If
            Else
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al obtener datos de cuestionario.")
        End Try
    End Sub

    Private Sub cargar_datos_relevamiento(ByVal id_relev As String)
        Dim dr As Odbc.OdbcDataReader
        Dim sql As String
        Try
            sql = "select * from relevamiento where id_relev='" & id_relev & "'"
            comando.Connection = conexion
            comando.CommandText = sql
            dr = comando.ExecuteReader()
            If dr.HasRows Then
                If dr("fecha_fin") Is DBNull.Value Then
                    estado_relevamiento = "Abierto."
                    dr.Close()
                Else
                    fecha_fin_relevamiento = dr("fecha_fin")
                    estado_relevamiento = "Finalizado - " + fecha_fin_relevamiento + "."
                    dr.Close()
                End If
            Else
                dr.Close()
            End If
            lbl_Input_Estado.Text = estado_relevamiento
        Catch ex As Exception
            MsgBox("Error al obtener datos de cuestionario.")
        End Try
    End Sub

    Private Sub cargar_preguntas(ByVal id_cuestionario As Integer)
        Dim sql As String
        Dim ds As New DataSet
        Try
            sql = "select nro_preg as id, enunciado, obs_respuesta as observacion, ponderacion from pregunta where id_cuestionario='" & id_cuestionario & "'"
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvReporteCuestionarios.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox("Error al obtener datos de calculo.")
        End Try
    End Sub

    Private Sub cargar_calculo(ByVal id_cuestionario As Integer)
        Dim sql As String
        Dim ds As New DataSet
        Try
            sql = "select nivel_d, nivel_p, nivel_r, nivel_i, nivel_e, nivel_c, nivel_rep, f_ponderacion from calculo where id_cuestionario='" & id_cuestionario & "'"
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvReporteCalculos.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox("Error al obtener datos de pregunta.")
        End Try
    End Sub

    'Private Sub cargar_repIndividuales(ByVal id_cuestionario As Integer)
    '    Dim sql As String
    '    Dim ds As New DataSet
    '    Try
    '        sql = "select titulo, acotaciones, descripciones, tecnico, fecha_prev as fecha_prevista, fecha_realizado from reporte where id_='" & id_cuestionario & "'"
    '        Dim da As New OdbcDataAdapter(sql, conexion)
    '        da.Fill(ds)
    '        dgvReporteCalculos.DataSource = ds.Tables(0)
    '    Catch ex As Exception
    '        MsgBox("Error al obtener datos de pregunta.")
    '    End Try
    'End Sub


    Private Sub obtener_promedio(ByVal id_cuestionario As Integer)
        Dim sql As String
        Dim dr As Odbc.OdbcDataReader
        Dim ponderacion_decimal As Double
        Try
            sql = "select avg(p.ponderacion) as promedio from pregunta as p join cuestionario as c on p.id_cuestionario=c.id_cuestionario where c.id_cuestionario='" & id_cuestionario & "'"
            comando.Connection = conexion
            comando.CommandText = sql
            dr = comando.ExecuteReader()
            If dr.HasRows Then
                ponderacion_decimal = dr("promedio")
                res_objetivo = CStr(Math.Round(ponderacion_decimal))
                If res_objetivo = 1 Then
                    res_objetivo = "Correcto"
                ElseIf res_objetivo > 1 And ponderacion_cuestionario < 5 Then
                    res_objetivo = "Mejorable"
                ElseIf res_objetivo > 4 And ponderacion_cuestionario < 8 Then
                    res_objetivo = "Deficiente"
                ElseIf res_objetivo > 7 Then
                    res_objetivo = "Muy Deficiente"
                End If
                dr.Close()
            Else
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al obtener el promedio.")
        End Try
    End Sub

    Private Sub asignar_datos_dinamicos()
        mostrar_etiquetas()
        lbl_Input_NomCuest.Text = nom_cuestionario
        lbl_Input_Areat.Text = area_trabajo
        lbl_Input_PAF.Text = pers_afec
        lbl_Input_PTO.Text = pers_totales
        lbl_Input_FECHCRE.Text = fecha_creado
        lbl_Input_FECHPROX.Text = fecha_prox_cuest
        lbl_Input_ResObj.Text = res_objetivo
        lbl_Input_ResSub.Text = res_subjetivo
    End Sub

    Private Sub asignar_datos_estaticos()
        lbl_Input_Empresa.Text = EmpresaActualRS + "."
        lbl_Input_Tecnico.Text = NombrePrevencionista + "."
        If VisitasActuales = "" Then
            lbl_Input_Visitas.Text = "0" + "."
        Else
            lbl_Input_Visitas.Text = VisitasActuales + "."
        End If
    End Sub

    Private Sub btnReporteGralSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporteGralSalir.Click
        Me.Close()
    End Sub

    Private Sub ocultar_etiquetas()
        lblCuestionarioNomCuestionario.Visible = False
        lblCuestionarioAreaTrabajo.Visible = False
        lblCuestionarioPersAfectadas.Visible = False
        lblCuestionarioTotalPers.Visible = False
        lblCuestionarioFECHCRED.Visible = False
        lblCuestionarioFECHPROX.Visible = False
        lblCuestionarioRES0BJ.Visible = False
        lblCuestionarioRESSUB.Visible = False
        lbl_Input_NomCuest.Visible = False
        lbl_Input_Areat.Visible = False
        lbl_Input_PAF.Visible = False
        lbl_Input_PTO.Visible = False
        lbl_Input_FECHCRE.Visible = False
        lbl_Input_FECHPROX.Visible = False
        lbl_Input_ResObj.Visible = False
        lbl_Input_ResSub.Visible = False
    End Sub

    Private Sub mostrar_etiquetas()
        lblCuestionarioNomCuestionario.Visible = True
        lblCuestionarioAreaTrabajo.Visible = True
        lblCuestionarioPersAfectadas.Visible = True
        lblCuestionarioTotalPers.Visible = True
        lblCuestionarioFECHCRED.Visible = True
        lblCuestionarioFECHPROX.Visible = True
        lblCuestionarioRES0BJ.Visible = True
        lblCuestionarioRESSUB.Visible = True
        lbl_Input_NomCuest.Visible = True
        lbl_Input_Areat.Visible = True
        lbl_Input_PAF.Visible = True
        lbl_Input_PTO.Visible = True
        lbl_Input_FECHCRE.Visible = True
        lbl_Input_FECHPROX.Visible = True
        lbl_Input_ResObj.Visible = True
        lbl_Input_ResSub.Visible = True
    End Sub

    Private Sub cargar_inventario()
        Dim sql As String
        Dim ds As New DataSet
        Try
            sql = "select nom_obj, tipo_obj, cant_obj, estado from inventario where id_relev='" & RelevamientoActualId & "'"
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvReporteInventario.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox("Error al obtener datos de inventario.")
        End Try
    End Sub

    Private Sub cargar_planes()
        Dim sql As String
        Dim ds As New DataSet
        Try
            sql = "select p.nom_plan, p.resolucion, p.fecha_redaccion, p.completado from genera as g, plan as p where g.id_plan=p.id_plan and g.id_relev='" & RelevamientoActualId & "'"
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvReportePlanCont.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox("Error al obtener datos de plan.")
        End Try
    End Sub

    Private Sub cargar_mapa(ByVal titulo As String)
        Dim sql As String
        Dim dr As Odbc.OdbcDataReader
        Try
            sql = "SELECT * FROM mapa where titulo='" & titulo & "'"
            comando.Connection = conexion
            comando.CommandText = sql
            dr = comando.ExecuteReader()
            If dr.HasRows Then
                id_mapa = dr("id_mapa")
                pbReporteMapa.Image = Bitmap.FromFile(Application.StartupPath + "\Mapas\Mapa_ID_" + id_mapa + ".png")
                dr.Close()
            Else
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al traer mapa.")
        End Try
    End Sub

    Private Sub setup_datagrids()
        With dgvReporteCalculos.DefaultCellStyle
            .Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
        End With
        With dgvReporteCuestionarios.DefaultCellStyle
            .Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
        End With
        With dgvReporteInventario.DefaultCellStyle
            .Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
        End With
        With dgvReportePlanCont.DefaultCellStyle
            .Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
        End With
        With dgvReporteIndividuales.DefaultCellStyle
            .Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
        End With
    End Sub
End Class
