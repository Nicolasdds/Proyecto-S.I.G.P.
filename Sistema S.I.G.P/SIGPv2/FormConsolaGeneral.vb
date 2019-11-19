Imports System.Data.Odbc
Public Class FormConsolaGeneral
    
    Private Sub FormConsolaGeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        MaximizeBox = False
        MinimizeBox = False
        btnAdminGralGuardar.Enabled = False
        btnAdminGralEliminar.Enabled = False
    End Sub

    Private Sub btnAdminGralSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdminGralSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAdminGralBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdminGralBuscar.Click
        Dim eleccion As String
        eleccion = Trim(Me.cboAdminGral.Text)
        Dim ds As New DataSet
        If cboAdminGral.Text = "" Then
            MsgBox("Debe elegir una opcion.")
        Else
            If eleccion = "EMPRESA" Then
                EMPRESA()
            ElseIf eleccion = "PREVENCIONISTA" Then
                PREVENCIONISTA()
            ElseIf eleccion = "TRABAJADOR" Then
                TRABAJADOR()
            ElseIf eleccion = "RELEVAMIENTO" Then
                RELEVAMIENTO()
            ElseIf eleccion = "REPORTE" Then
                REPORTE()
            ElseIf eleccion = "CUESTIONARIO" Then
                CUESTIONARIO()
            ElseIf eleccion = "PREGUNTA" Then
                PREGUNTA()
            ElseIf eleccion = "MAPA" Then
                MAPA()
            ElseIf eleccion = "ICONO" Then
                ICONO()
            ElseIf eleccion = "CALCULO" Then
                CALCULO()
            ElseIf eleccion = "INVENTARIO" Then
                INVENTARIO()
            ElseIf eleccion = "PLAN" Then
                PLAN()
            ElseIf eleccion = "INSPECCION" Then
                INSPECCION()
            ElseIf eleccion = "OBSERVACION" Then
                OBSERVACION()
            ElseIf eleccion = "CONTRATA" Then
                CONTRATA()
            ElseIf eleccion = "TIENE" Then
                TIENE()
            ElseIf eleccion = "HACE" Then
                HACE()
            ElseIf eleccion = "A" Then
                A()
            ElseIf eleccion = "GENERA" Then
                GENERA()
            ElseIf eleccion = "RESPONDE" Then
                RESPONDE()
            ElseIf eleccion = "CONTIENE" Then
                CONTIENE()
            ElseIf eleccion = "REALIZA" Then
                REALIZA()
            ElseIf eleccion = "SOBRE" Then
                SOBRE()
            ElseIf eleccion = "ROLES" Then
                ROLES()
            ElseIf eleccion = "USUARIO_ROL" Then
                USUARIO_ROL()
            End If
        End If
    End Sub

    Private Sub btnAdminGralGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdminGralGuardar.Click
        If dgvAdminGral.RowCount > 1 Then
            If cboAdminGral.Text = "" Then
                MsgBox("Nada para guardar.")
            Else
                Dim eleccion As String
                Dim temp As String
                eleccion = Trim(Me.cboAdminGral.Text)
                Dim sql As String
                If eleccion = "EMPRESA" Then
                    row1 = (dgvAdminGral("rut", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row2 = (dgvAdminGral("razon_social", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row3 = (dgvAdminGral("rubro", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row4 = (dgvAdminGral("telefono", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row5 = (dgvAdminGral("mail", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row6 = (dgvAdminGral("direccion", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    Try
                        sql = "UPDATE empresa SET razon_social='" & row2 & "',rubro='" & row3 & "',telefono=" & row4 & ",mail='" & row5 & "',direccion='" & row6 & "' where rut=" & rowID
                        comando.Connection = conexion
                        comando.CommandText = sql
                        comando.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("Error al actualizar datos.")
                    End Try
                ElseIf eleccion = "PREVENCIONISTA" Then
                    row1 = (dgvAdminGral("ci_pr", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row2 = (dgvAdminGral("nom_pr", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row3 = (dgvAdminGral("ape_pr", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row4 = (dgvAdminGral("tel_pr", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row5 = (dgvAdminGral("dom_pr", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row6 = (dgvAdminGral("usr_pr", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    Try
                        sql = "UPDATE PREVENCIONISTA SET nom_pr='" & row2 & "',ape_pr='" & row3 & "',tel_pr='" & row4 & "',dom_pr='" & row5 & "',usr_pr='" & row6 & "' where ci_pr=" & rowID
                        comando.Connection = conexion
                        comando.CommandText = sql
                        comando.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("Error al actualizar datos.")
                    End Try
                ElseIf eleccion = "TRABAJADOR" Then
                    row1 = (dgvAdminGral("ci_tr", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row2 = (dgvAdminGral("nom_tr", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row3 = (dgvAdminGral("ape_tr", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row4 = (dgvAdminGral("capacitaciones", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    Try
                        sql = "UPDATE TRABAJADOR SET nom_tr='" & row2 & "',ape_tr='" & row3 & "',capacitaciones='" & row4 & "' where ci_tr=" & rowID
                        comando.Connection = conexion
                        comando.CommandText = sql
                        comando.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("Error al actualizar datos.")
                    End Try
                ElseIf eleccion = "RELEVAMIENTO" Then
                    Dim fecha_inicio As DateTime
                    Dim fecha_fin As DateTime
                    temp = (dgvAdminGral("fecha_fin", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    If temp <> "" Then
                        temp = (dgvAdminGral("fecha_inicio", dgvAdminGral.CurrentRow.Index).Value.ToString())
                        If temp <> "" Then
                            row1 = (dgvAdminGral("id_relev", dgvAdminGral.CurrentRow.Index).Value.ToString())
                            fecha_inicio = (dgvAdminGral("fecha_inicio", dgvAdminGral.CurrentRow.Index).Value.ToString())
                            fecha_fin = (dgvAdminGral("fecha_fin", dgvAdminGral.CurrentRow.Index).Value.ToString())
                            row2 = Format(fecha_inicio, "MM/dd/yyyy")
                            row3 = Format(fecha_fin, "MM/dd/yyyy")
                            Try
                                sql = "UPDATE RELEVAMIENTO SET fecha_inicio='" & row2 & "',fecha_fin='" & row3 & "' where id_relev=" & rowID
                                comando.Connection = conexion
                                comando.CommandText = sql
                                comando.ExecuteNonQuery()
                            Catch ex As Exception
                                MsgBox("Error al actualizar datos.")
                            End Try
                        Else
                            MsgBox("No puede dejar la fecha en blanco")
                        End If
                    Else
                        temp = (dgvAdminGral("fecha_inicio", dgvAdminGral.CurrentRow.Index).Value.ToString())
                        If temp <> "" Then
                            row1 = (dgvAdminGral("id_relev", dgvAdminGral.CurrentRow.Index).Value.ToString())
                            fecha_inicio = (dgvAdminGral("fecha_inicio", dgvAdminGral.CurrentRow.Index).Value.ToString())
                            row2 = Format(fecha_inicio, "MM/dd/yyyy")
                            Try
                                sql = "UPDATE RELEVAMIENTO SET fecha_inicio='" & row2 & "' where id_relev=" & row1
                                comando.Connection = conexion
                                comando.CommandText = sql
                                comando.ExecuteNonQuery()
                            Catch ex As Exception
                                MsgBox("Error al actualizar datos.")
                            End Try
                        Else
                            MsgBox("No puede dejar la fecha en blanco")
                        End If
                    End If
                ElseIf eleccion = "REPORTE" Then
                    Dim fecha_prev As DateTime
                    Dim fecha_realizado As DateTime
                    row1 = (dgvAdminGral("id_rep", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    fecha_prev = (dgvAdminGral("fecha_prev", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row2 = Format(fecha_prev, "MM/dd/yyyy")
                    row3 = (dgvAdminGral("titulo", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row4 = (dgvAdminGral("acotaciones", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row5 = (dgvAdminGral("descripciones", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    temp = (dgvAdminGral("fecha_realizado", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row7 = (dgvAdminGral("tecnico", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    If temp <> "" Then
                        Try
                            fecha_realizado = (dgvAdminGral("fecha_realizado", dgvAdminGral.CurrentRow.Index).Value.ToString())
                            row6 = Format(fecha_realizado, "MM/dd/yyyy")
                            sql = "UPDATE REPORTE SET fecha_prev='" & row2 & "',titulo='" & row3 & "',acotaciones='" & row4 & "',descripciones='" & row5 & "',fecha_realizado='" & row6 & "',tecnico='" & row7 & "' where id_rep=" & rowID
                            comando.Connection = conexion
                            comando.CommandText = sql
                            comando.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox("Error al actualizar datos.")
                        End Try
                    Else
                        Try
                            sql = "UPDATE REPORTE SET fecha_prev='" & row2 & "',titulo='" & row3 & "',acotaciones='" & row4 & "',descripciones='" & row5 & "',tecnico='" & row7 & "' where id_rep=" & rowID
                            comando.Connection = conexion
                            comando.CommandText = sql
                            comando.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox("Error al actualizar datos.")
                        End Try
                    End If
                ElseIf eleccion = "CUESTIONARIO" Then
                    Dim fecha_prox_cuest As DateTime
                    Dim fecha_creado As DateTime
                    row1 = (dgvAdminGral("id_cuestionario", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row2 = (dgvAdminGral("id_relev", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row3 = (dgvAdminGral("nom_cuestionario", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row4 = (dgvAdminGral("area_trabajo", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row5 = (dgvAdminGral("pers_totales", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row6 = (dgvAdminGral("pers_afec", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row7 = (dgvAdminGral("res_subjetivo", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    fecha_prox_cuest = (dgvAdminGral("fecha_prox_cuest", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    fecha_creado = (dgvAdminGral("fecha_creado", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row8 = Format(fecha_prox_cuest, "MM/dd/yyyy")
                    row9 = Format(fecha_creado, "MM/dd/yyyy")
                    Try
                        sql = "UPDATE CUESTIONARIO SET id_relev=" & row2 & ",nom_cuestionario='" & row3 & "',area_trabajo='" & row4 & "',pers_totales=" & row5 & ",pers_afec=" & row6 & ",res_subjetivo='" & row7 & "',fecha_prox_cuest='" & row8 & "',fecha_creado='" & row9 & "' where id_cuestionario=" & rowID
                        comando.Connection = conexion
                        comando.CommandText = sql
                        comando.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("Error al actualizar datos.")
                    End Try
                ElseIf eleccion = "PREGUNTA" Then
                    row1 = (dgvAdminGral("serie_preg", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row2 = (dgvAdminGral("enunciado", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row3 = (dgvAdminGral("ponderacion", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row4 = (dgvAdminGral("obs_respuesta", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row5 = (dgvAdminGral("id_relev", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row6 = (dgvAdminGral("id_rep", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    If row6 <> "" Then
                        Try
                            sql = "UPDATE PREGUNTA SET enunciado='" & row2 & "',ponderacion=" & row3 & ",obs_respuesta='" & row4 & "',id_relev=" & row5 & ",id_rep=" & row6 & " where serie_preg=" & rowID
                            comando.Connection = conexion
                            comando.CommandText = sql
                            comando.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox("Error al actualizar datos.")
                        End Try
                    Else
                        Try
                            sql = "UPDATE PREGUNTA SET ,enunciado='" & row2 & "',ponderacion=" & row3 & ",obs_respuesta='" & row4 & "',id_relev=" & row5 & " where serie_preg=" & rowID
                            comando.Connection = conexion
                            comando.CommandText = sql
                            comando.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox("Error al actualizar datos.")
                        End Try
                    End If
                ElseIf eleccion = "MAPA" Then
                    Dim fecha_creado As DateTime
                    row1 = (dgvAdminGral("id_mapa", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row2 = (dgvAdminGral("titulo", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row3 = (dgvAdminGral("ruta", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    fecha_creado = (dgvAdminGral("fecha_creado", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row4 = Format(fecha_creado, "MM/dd/yyyy")
                    row5 = (dgvAdminGral("id_relev", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    Try
                        sql = "UPDATE MAPA SET titulo='" & row2 & "',ruta='" & row3 & "',fecha_creado='" & row4 & "',id_relev=" & row5 & " where id_mapa=" & rowID
                        comando.Connection = conexion
                        comando.CommandText = sql
                        comando.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("Error al actualizar datos.")
                    End Try
                ElseIf eleccion = "ICONO" Then
                    row1 = (dgvAdminGral("id_icono", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row2 = (dgvAdminGral("tipo_icono", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row3 = (dgvAdminGral("nom_icono", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row4 = (dgvAdminGral("ruta", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    Try
                        sql = "UPDATE ICONO SET tipo_icono='" & row2 & "',nom_icono='" & row3 & "',ruta='" & row4 & "' where id_icono=" & rowID
                        comando.Connection = conexion
                        comando.CommandText = sql
                        comando.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("Error al actualizar datos.")
                    End Try
                ElseIf eleccion = "CALCULO" Then
                    row1 = (dgvAdminGral("id_calculo", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row2 = (dgvAdminGral("id_cuestionario", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row3 = (dgvAdminGral("nivel_d", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row4 = (dgvAdminGral("nivel_p", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row5 = (dgvAdminGral("nivel_r", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row6 = (dgvAdminGral("nivel_i", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row7 = (dgvAdminGral("nivel_e", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row8 = (dgvAdminGral("nivel_c", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row9 = (dgvAdminGral("nivel_rep", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row10 = (dgvAdminGral("f_ponderacion", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    Try
                        sql = "UPDATE CALCULO SET id_cuestionario=" & row2 & ",nivel_d=" & row3 & ",nivel_p=" & row4 & ",nivel_r=" & row5 & ",nivel_i='" & row6 & "',nivel_e=" & row7 & ",nivel_c=" & row8 & ",nivel_rep=" & row9 & ",f_ponderacion=" & row10 & " where id_calculo=" & rowID
                        comando.Connection = conexion
                        comando.CommandText = sql
                        comando.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("Error al actualizar datos.")
                    End Try
                ElseIf eleccion = "INVENTARIO" Then
                    row1 = (dgvAdminGral("serie_objeto", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row2 = (dgvAdminGral("tipo_obj", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row3 = (dgvAdminGral("cant_obj", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row4 = (dgvAdminGral("estado", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    Try 'NOMBRE DE OBJETO AL SER CLAVE PRIAMRIA NO SE PUEDE CAMBIAR
                        sql = "UPDATE INVENTARIO SET tipo_obj='" & row2 & "',cant_obj=" & row3 & ",estado='" & row4 & "' where serie_objeto=" & rowID
                        comando.Connection = conexion
                        comando.CommandText = sql
                        comando.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("Error al actualizar datos.")
                    End Try
                ElseIf eleccion = "PLAN" Then
                    Dim fecha_redaccion As DateTime
                    row1 = (dgvAdminGral("id_plan", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    fecha_redaccion = (dgvAdminGral("fecha_redaccion", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row2 = Format(fecha_redaccion, "MM/dd/yyyy")
                    row3 = (dgvAdminGral("resolucion", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row4 = (dgvAdminGral("completado", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row5 = (dgvAdminGral("nom_plan", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    Try
                        sql = "UPDATE PLAN SET fecha_redaccion='" & row2 & "',resolucion='" & row3 & "',completado='" & row4 & "',nom_plan='" & row5 & "' where id_plan=" & rowID
                        comando.Connection = conexion
                        comando.CommandText = sql
                        comando.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("Error al actualizar datos.")
                    End Try
                ElseIf eleccion = "INSPECCION" Then
                    row1 = (dgvAdminGral("unidad_inspectora", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row2 = (dgvAdminGral("tipo_unidad", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    Try
                        sql = "UPDATE INSPECCION SET unidad_inspectora=" & row1 & ",tipo_unidad='" & row2 & "' where unidad_inspectora='" & rowID & "'"
                        comando.Connection = conexion
                        comando.CommandText = sql
                        comando.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("Error al actualizar datos.")
                    End Try
                ElseIf eleccion = "OBSERVACION" Then
                    Dim fecha_dictado As DateTime
                    Dim fecha_resp As DateTime
                    row1 = (dgvAdminGral("id_obs", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row2 = (dgvAdminGral("tipo_obs", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row3 = (dgvAdminGral("narracion", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    fecha_dictado = (dgvAdminGral("fecha_dictado", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row4 = Format(fecha_dictado, "MM/dd/yyyy")
                    fecha_resp = (dgvAdminGral("fecha_resp", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row5 = Format(fecha_resp, "MM/dd/yyyy")
                    Try
                        sql = "UPDATE OBSERVACION SET tipo_obs='" & row2 & "',narracion='" & row3 & "',fecha_dictado='" & row4 & "',fecha_resp='" & row5 & "' where id_obs=" & rowID
                        comando.Connection = conexion
                        comando.CommandText = sql
                        comando.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("Error al actualizar datos.")
                    End Try
                ElseIf eleccion = "CONTRATA" Then
                    Dim fecha_contrato As DateTime
                    Dim fecha_de_baja As DateTime
                    row1 = (dgvAdminGral("rut", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row2 = (dgvAdminGral("ci_pr", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    fecha_contrato = (dgvAdminGral("fecha_contrato", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row3 = Format(fecha_contrato, "MM/dd/yyyy")
                    temp = (dgvAdminGral("fecha_de_baja", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    If temp <> "" Then
                        MsgBox("Fecha de baja tiene datos")
                        fecha_de_baja = (dgvAdminGral("fecha_de_baja", dgvAdminGral.CurrentRow.Index).Value.ToString())
                        row4 = Format(fecha_de_baja, "MM/dd/yyyy")
                        Try
                            sql = "UPDATE CONTRATA SET rut=" & row1 & ",ci_pr=" & row2 & ",fecha_contrato='" & row3 & "',fecha_de_baja='" & row4 & "' where rut=" & rowID
                            comando.Connection = conexion
                            comando.CommandText = sql
                            comando.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox("Error al actualizar datos.")
                        End Try
                    Else
                        MsgBox("Fecha de baja esta vacio")
                        Try
                            sql = "UPDATE CONTRATA SET rut=" & row1 & ",ci_pr=" & row2 & ",fecha_contrato='" & row3 & "' where rut=" & rowID
                            comando.Connection = conexion
                            comando.CommandText = sql
                            comando.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox("Error al actualizar datos.")
                        End Try
                    End If
                ElseIf eleccion = "TIENE" Then
                    row1 = (dgvAdminGral("rut", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row2 = (dgvAdminGral("ci_tr", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row3 = (dgvAdminGral("turno", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row4 = (dgvAdminGral("sector", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    Try
                        sql = "UPDATE TIENE SET rut='" & row1 & "',ci_tr='" & row2 & "',turno='" & row3 & "',sector='" & row4 & "' WHERE rut='" & rowID & "' and ci_tr='" & rowID1 & "'"
                        comando.Connection = conexion
                        comando.CommandText = sql
                        comando.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("Error al actualizar datos.")
                    End Try
                ElseIf eleccion = "HACE" Then
                    row1 = (dgvAdminGral("id_relev", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row2 = (dgvAdminGral("ci_pr", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    Try
                        sql = "UPDATE HACE SET id_relev=" & row1 & ",ci_pr='" & row2 & "' where id_relev=" & rowID
                        comando.Connection = conexion
                        comando.CommandText = sql
                        comando.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("Error al actualizar datos.")
                    End Try
                ElseIf eleccion = "A" Then
                    Dim fecha_visit As DateTime
                    row1 = (dgvAdminGral("id_obs", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row2 = (dgvAdminGral("unidad_inspectora", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    fecha_visit = (dgvAdminGral("fecha_visita", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row3 = Format(fecha_visit, "MM/dd/yyyy")
                    row4 = (dgvAdminGral("rut", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    Try
                        sql = "UPDATE A SET id_obs=" & row1 & ",unidad_inspectora='" & row2 & "',fecha_visita='" & row3 & "',rut=" & row4 & " where Id_obs=" & rowID & " and unidad_inspectora='" & rowID1 & "' and fecha_visita='" & rowDate & "'"
                        comando.Connection = conexion
                        comando.CommandText = sql
                        comando.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("Error al actualizar datos.")
                    End Try
                ElseIf eleccion = "GENERA" Then
                    row1 = (dgvAdminGral("id_relev", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row2 = (dgvAdminGral("id_plan", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    Try
                        sql = "UPDATE GENERA SET id_relev=" & row1 & ",id_plan=" & row2 & " where id_relev=" & rowID & " AND id_plan=" & rowID1
                        comando.Connection = conexion
                        comando.CommandText = sql
                        comando.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("Error al actualizar datos.")
                    End Try
                ElseIf eleccion = "RESPONDE" Then
                    Dim fecha_visit As DateTime
                    row1 = (dgvAdminGral("id_obs", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    fecha_visit = (dgvAdminGral("fecha_visita", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row2 = Format(fecha_visit, "MM/dd/yyyy")
                    row3 = (dgvAdminGral("unidad_inspectora", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row4 = (dgvAdminGral("id_plan", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    Try
                        sql = "UPDATE RESPONDE SET id_obs=" & row1 & ",fecha_visita='" & row2 & "',unidad_inspectora='" & row3 & "',id_plan=" & row4 & " where Id_obs=" & rowID & " AND unidad_inspectora='" & rowID1 & "' and fecha_visita='" & rowDate & "'"
                        comando.Connection = conexion
                        comando.CommandText = sql
                        comando.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("Error al actualizar datos.")
                    End Try
                ElseIf eleccion = "CONTIENE" Then
                    row1 = (dgvAdminGral("id_icono", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row2 = (dgvAdminGral("id_mapa", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row3 = (dgvAdminGral("id_relev", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row4 = (dgvAdminGral("pos_x", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row5 = (dgvAdminGral("pos_y", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    Try
                        sql = "UPDATE CONTIENE SET id_icono=" & row1 & ",id_mapa=" & row2 & ",id_relev=" & row3 & ",pos_x=" & row4 & ",pos_y=" & row5 & " where id_icono=" & rowID
                        comando.Connection = conexion
                        comando.CommandText = sql
                        comando.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("Error al actualizar datos.")
                    End Try
                ElseIf eleccion = "REALIZA" Then
                    Dim fecha_visit As DateTime
                    row1 = (dgvAdminGral("id_obs", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row2 = (dgvAdminGral("unidad_inspectora", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    fecha_visit = (dgvAdminGral("fecha_visita", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row3 = Format(fecha_visit, "MM/dd/yyyy")
                    Try
                        sql = "UPDATE REALIZA SET id_obs=" & row1 & ",unidad_inspectora='" & row2 & "',fecha_visita='" & row3 & "' where Id_obs=" & rowID & " AND unidad_inspectora='" & rowID1 & "' and fecha_visita='" & rowDate & "'"
                        comando.Connection = conexion
                        comando.CommandText = sql
                        comando.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("Error al actualizar datos.")
                    End Try
                ElseIf eleccion = "SOBRE" Then
                    row1 = (dgvAdminGral("id_relev", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row2 = (dgvAdminGral("rut", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    Try
                        sql = "UPDATE SOBRE SET id_relev=" & row1 & ",rut=" & row2 & " where id_relev=" & rowID
                        comando.Connection = conexion
                        comando.CommandText = sql
                        comando.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("Error al actualizar datos.")
                    End Try
                ElseIf eleccion = "ROLES" Then
                    row1 = (dgvAdminGral("id", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row2 = (dgvAdminGral("rol", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    Try
                        sql = "UPDATE ROLES SET id=" & row1 & ",rol='" & row2 & "' where ID=" & rowID
                        comando.Connection = conexion
                        comando.CommandText = sql
                        comando.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("Error al actualizar datos.")
                    End Try
                ElseIf eleccion = "USUARIO_ROL" Then
                    row1 = (dgvAdminGral("usuario", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    row2 = (dgvAdminGral("rol", dgvAdminGral.CurrentRow.Index).Value.ToString())
                    Try
                        sql = "UPDATE USUARIO_ROL SET usuario='" & row1 & "',rol=" & row2 & " where usuario='" & rowID & "'"
                        comando.Connection = conexion
                        comando.CommandText = sql
                        comando.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("Error al actualizar datos.")
                    End Try
                End If
            End If
        Else
            MsgBox("Debe seleccionar un item válido.")
        End If
    End Sub

    Private Sub btnAdminGralEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdminGralEliminar.Click
        Dim eleccion As String
        Dim id As String
        eleccion = Trim(Me.cboAdminGral.Text)
        If dgvAdminGral.RowCount > 1 Then
            If eleccion = "EMPRESA" Then
                row1 = (dgvAdminGral("rut", dgvAdminGral.CurrentRow.Index).Value.ToString())
                id = dgvAdminGral.Columns(0).HeaderText
                deleteInt(eleccion, id, row1)
                EMPRESA()
            ElseIf eleccion = "PREVENCIONISTA" Then
                row1 = (dgvAdminGral("ci_pr", dgvAdminGral.CurrentRow.Index).Value.ToString())
                id = dgvAdminGral.Columns(0).HeaderText
                deleteInt(eleccion, id, row1)
                PREVENCIONISTA()
            ElseIf eleccion = "TRABAJADOR" Then
                row1 = (dgvAdminGral("ci_tr", dgvAdminGral.CurrentRow.Index).Value.ToString())
                id = dgvAdminGral.Columns(0).HeaderText
                deleteInt(eleccion, id, row1)
                TRABAJADOR()
            ElseIf eleccion = "RELEVAMIENTO" Then
                row1 = (dgvAdminGral("id_relev", dgvAdminGral.CurrentRow.Index).Value.ToString())
                id = dgvAdminGral.Columns(0).HeaderText
                deleteInt(eleccion, id, row1)
                RELEVAMIENTO()
            ElseIf eleccion = "REPORTE" Then
                row1 = (dgvAdminGral("id_rep", dgvAdminGral.CurrentRow.Index).Value.ToString())
                id = dgvAdminGral.Columns(0).HeaderText
                deleteInt(eleccion, id, row1)
                REPORTE()
            ElseIf eleccion = "CUESTIONARIO" Then
                row1 = (dgvAdminGral("id_cuestionario", dgvAdminGral.CurrentRow.Index).Value.ToString())
                id = dgvAdminGral.Columns(0).HeaderText
                deleteInt(eleccion, id, row1)
                CUESTIONARIO()
            ElseIf eleccion = "PREGUNTA" Then
                row1 = (dgvAdminGral("serie_preg", dgvAdminGral.CurrentRow.Index).Value.ToString())
                id = dgvAdminGral.Columns(0).HeaderText
                deleteInt(eleccion, id, row1)
                PREGUNTA()
            ElseIf eleccion = "MAPA" Then
                row1 = (dgvAdminGral("id_mapa", dgvAdminGral.CurrentRow.Index).Value.ToString())
                id = dgvAdminGral.Columns(0).HeaderText
                deleteInt(eleccion, id, row1)
                MAPA()
            ElseIf eleccion = "ICONO" Then
                row1 = (dgvAdminGral("id_icono", dgvAdminGral.CurrentRow.Index).Value.ToString())
                id = dgvAdminGral.Columns(0).HeaderText
                deleteInt(eleccion, id, row1)
                ICONO()
            ElseIf eleccion = "CALCULO" Then
                row1 = (dgvAdminGral("id_calculo", dgvAdminGral.CurrentRow.Index).Value.ToString())
                id = dgvAdminGral.Columns(0).HeaderText
                deleteInt(eleccion, id, row1)
                CALCULO()
            ElseIf eleccion = "INVENTARIO" Then
                row1 = (dgvAdminGral("serie_objeto", dgvAdminGral.CurrentRow.Index).Value.ToString())
                id = dgvAdminGral.Columns(0).HeaderText
                deleteInt(eleccion, id, row1)
                INVENTARIO()
            ElseIf eleccion = "INSPECCION" Then
                row1 = (dgvAdminGral("unidad_inspectora", dgvAdminGral.CurrentRow.Index).Value.ToString())
                id = dgvAdminGral.Columns(0).HeaderText
                deleteStr(eleccion, id, row1)
                INSPECCION()
            ElseIf eleccion = "OBSERVACION" Then
                row1 = (dgvAdminGral("id_obs", dgvAdminGral.CurrentRow.Index).Value.ToString())
                id = dgvAdminGral.Columns(0).HeaderText
                deleteInt(eleccion, id, row1)
                OBSERVACION()
            ElseIf eleccion = "CONTRATA" Then
                row1 = (dgvAdminGral("rut", dgvAdminGral.CurrentRow.Index).Value.ToString())
                id = dgvAdminGral.Columns(0).HeaderText
                deleteInt(eleccion, id, row1)
                CONTRATA()
            ElseIf eleccion = "TIENE" Then
                row1 = (dgvAdminGral("rut", dgvAdminGral.CurrentRow.Index).Value.ToString())
                id = dgvAdminGral.Columns(0).HeaderText
                deleteInt(eleccion, id, row1)
                TIENE()
            ElseIf eleccion = "HACE" Then
                row1 = (dgvAdminGral("id_relev", dgvAdminGral.CurrentRow.Index).Value.ToString())
                id = dgvAdminGral.Columns(0).HeaderText
                deleteInt(eleccion, id, row1)
                HACE()
            ElseIf eleccion = "A" Then
                row1 = (dgvAdminGral("id_obs", dgvAdminGral.CurrentRow.Index).Value.ToString())
                id = dgvAdminGral.Columns(0).HeaderText
                deleteInt(eleccion, id, row1)
                A()
            ElseIf eleccion = "GENERA" Then
                row1 = (dgvAdminGral("id_relev", dgvAdminGral.CurrentRow.Index).Value.ToString())
                id = dgvAdminGral.Columns(0).HeaderText
                deleteInt(eleccion, id, row1)
                GENERA()
            ElseIf eleccion = "RESPONDE" Then
                row1 = (dgvAdminGral("id_obs", dgvAdminGral.CurrentRow.Index).Value.ToString())
                id = dgvAdminGral.Columns(0).HeaderText
                deleteInt(eleccion, id, row1)
                RESPONDE()
            ElseIf eleccion = "CONTIENE" Then
                row1 = (dgvAdminGral("id_icono", dgvAdminGral.CurrentRow.Index).Value.ToString())
                id = dgvAdminGral.Columns(0).HeaderText
                deleteInt(eleccion, id, row1)
                CONTIENE()
            ElseIf eleccion = "REALIZA" Then
                row1 = (dgvAdminGral("id_obs", dgvAdminGral.CurrentRow.Index).Value.ToString())
                id = dgvAdminGral.Columns(0).HeaderText
                deleteInt(eleccion, id, row1)
                REALIZA()
            ElseIf eleccion = "SOBRE" Then
                row1 = (dgvAdminGral("id_relev", dgvAdminGral.CurrentRow.Index).Value.ToString())
                id = dgvAdminGral.Columns(0).HeaderText
                deleteInt(eleccion, id, row1)
                SOBRE()
            ElseIf eleccion = "ROLES" Then
                row1 = (dgvAdminGral("id", dgvAdminGral.CurrentRow.Index).Value.ToString())
                id = dgvAdminGral.Columns(0).HeaderText
                deleteInt(eleccion, id, row1)
                ROLES()
            ElseIf eleccion = "USUARIO_ROL" Then
                row1 = (dgvAdminGral("usuario", dgvAdminGral.CurrentRow.Index).Value.ToString())
                id = dgvAdminGral.Columns(0).HeaderText
                deleteStr(eleccion, id, row1)
                USUARIO_ROL()
            End If
        Else
            MsgBox("Debe seleccionar un item válido.")
        End If
    End Sub

    'FUNCIONES PARA DELETE
    Private Sub deleteStr(ByVal tabla As String, ByVal id As String, ByVal valor As String)
        Dim sql As String
        Try
            sql = "DELETE FROM " & tabla & " where " & id & "='" & valor & "'"
            comando.Connection = conexion
            comando.CommandText = sql
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al actualizar datos.")
        End Try
    End Sub

    Private Sub deleteInt(ByVal tabla As String, ByVal id As String, ByVal valor As Integer)
        Dim sql As String
        Try
            sql = "DELETE FROM " & tabla & " where " & id & "=" & valor
            comando.Connection = conexion
            comando.CommandText = sql
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al actualizar datos.")
        End Try
    End Sub

    'FUNCIONES PARA SELECT
    Private Sub EMPRESA()
        Dim sql As String
        Dim ds As New DataSet
        Try
            sql = "SELECT * FROM EMPRESA"
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvAdminGral.DataSource = ds.Tables(0)
            btnAdminGralGuardar.Enabled = True
            btnAdminGralEliminar.Enabled = True
        Catch ex As Exception
            MsgBox("Error al obtener datos.")
        End Try
    End Sub

    Private Sub PREVENCIONISTA()
        Dim sql As String
        Dim ds As New DataSet
        Try
            sql = "SELECT * FROM PREVENCIONISTA"
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvAdminGral.DataSource = ds.Tables(0)
            btnAdminGralGuardar.Enabled = True
            btnAdminGralEliminar.Enabled = True
        Catch ex As Exception
            MsgBox("Error al obtener datos.")
        End Try

    End Sub

    Private Sub TRABAJADOR()
        Dim sql As String
        Dim ds As New DataSet
        Try
            sql = "SELECT * FROM TRABAJADOR"
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvAdminGral.DataSource = ds.Tables(0)
            btnAdminGralGuardar.Enabled = True
            btnAdminGralEliminar.Enabled = True
        Catch ex As Exception
            MsgBox("Error al obtener datos.")
        End Try
    End Sub

    Private Sub RELEVAMIENTO()
        Dim sql As String
        Dim ds As New DataSet
        Try
            sql = "SELECT * FROM RELEVAMIENTO"
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvAdminGral.DataSource = ds.Tables(0)
            btnAdminGralGuardar.Enabled = True
            btnAdminGralEliminar.Enabled = True
        Catch ex As Exception
            MsgBox("Error al obtener datos.")
        End Try
    End Sub

    Private Sub REPORTE()
        Dim sql As String
        Dim ds As New DataSet
        Try
            sql = "SELECT * FROM REPORTE"
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvAdminGral.DataSource = ds.Tables(0)
            btnAdminGralGuardar.Enabled = True
            btnAdminGralEliminar.Enabled = True
        Catch ex As Exception
            MsgBox("Error al obtener datos.")
        End Try
    End Sub

    Private Sub CUESTIONARIO()
        Dim sql As String
        Dim ds As New DataSet
        Try
            sql = "SELECT * FROM CUESTIONARIO"
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvAdminGral.DataSource = ds.Tables(0)
            btnAdminGralGuardar.Enabled = True
            btnAdminGralEliminar.Enabled = True
        Catch ex As Exception
            MsgBox("Error al obtener datos.")
        End Try
    End Sub

    Private Sub PREGUNTA()
        Dim sql As String
        Dim ds As New DataSet
        Try
            sql = "SELECT * FROM PREGUNTA"
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvAdminGral.DataSource = ds.Tables(0)
            btnAdminGralGuardar.Enabled = True
            btnAdminGralEliminar.Enabled = True
        Catch ex As Exception
            MsgBox("Error al obtener datos.")
        End Try
    End Sub

    Private Sub MAPA()
        Dim sql As String
        Dim ds As New DataSet
        Try
            sql = "SELECT * FROM MAPA"
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvAdminGral.DataSource = ds.Tables(0)
            btnAdminGralGuardar.Enabled = True
            btnAdminGralEliminar.Enabled = True
        Catch ex As Exception
            MsgBox("Error al obtener datos.")
        End Try
    End Sub

    Private Sub ICONO()
        Dim sql As String
        Dim ds As New DataSet
        Try
            sql = "SELECT * FROM ICONO"
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvAdminGral.DataSource = ds.Tables(0)
            btnAdminGralGuardar.Enabled = True
            btnAdminGralEliminar.Enabled = True
        Catch ex As Exception
            MsgBox("Error al obtener datos.")
        End Try
    End Sub

    Private Sub CALCULO()
        Dim sql As String
        Dim ds As New DataSet
        Try
            sql = "SELECT * FROM CALCULO"
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvAdminGral.DataSource = ds.Tables(0)
            btnAdminGralGuardar.Enabled = True
            btnAdminGralEliminar.Enabled = True
        Catch ex As Exception
            MsgBox("Error al obtener datos.")
        End Try
    End Sub

    Private Sub INVENTARIO()
        Dim sql As String
        Dim ds As New DataSet
        Try
            sql = "SELECT * FROM INVENTARIO"
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvAdminGral.DataSource = ds.Tables(0)
            btnAdminGralGuardar.Enabled = True
            btnAdminGralEliminar.Enabled = True
        Catch ex As Exception
            MsgBox("Error al obtener datos.")
        End Try
    End Sub

    Private Sub PLAN()
        Dim sql As String
        Dim ds As New DataSet
        Try
            sql = "SELECT * FROM PLAN"
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvAdminGral.DataSource = ds.Tables(0)
            btnAdminGralGuardar.Enabled = True
            btnAdminGralEliminar.Enabled = True
        Catch ex As Exception
            MsgBox("Error al obtener datos.")
        End Try
    End Sub

    Private Sub INSPECCION()
        Dim sql As String
        Dim ds As New DataSet
        Try
            sql = "SELECT * FROM INSPECCION"
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvAdminGral.DataSource = ds.Tables(0)
            btnAdminGralGuardar.Enabled = True
            btnAdminGralEliminar.Enabled = True
        Catch ex As Exception
            MsgBox("Error al obtener datos.")
        End Try
    End Sub

    Private Sub OBSERVACION()
        Dim sql As String
        Dim ds As New DataSet
        Try
            sql = "SELECT * FROM OBSERVACION"
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvAdminGral.DataSource = ds.Tables(0)
            btnAdminGralGuardar.Enabled = True
            btnAdminGralEliminar.Enabled = True
        Catch ex As Exception
            MsgBox("Error al obtener datos.")
        End Try
    End Sub

    Private Sub CONTRATA()
        Dim sql As String
        Dim ds As New DataSet
        Try
            sql = "SELECT * FROM CONTRATA"
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvAdminGral.DataSource = ds.Tables(0)
            btnAdminGralGuardar.Enabled = True
            btnAdminGralEliminar.Enabled = True
        Catch ex As Exception
            MsgBox("Error al obtener datos.")
        End Try
    End Sub

    Private Sub TIENE()
        Dim sql As String
        Dim ds As New DataSet
        Try
            sql = "SELECT * FROM TIENE"
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvAdminGral.DataSource = ds.Tables(0)
            btnAdminGralGuardar.Enabled = True
            btnAdminGralEliminar.Enabled = True
        Catch ex As Exception
            MsgBox("Error al obtener datos.")
        End Try
    End Sub

    Private Sub HACE()
        Dim sql As String
        Dim ds As New DataSet
        Try
            sql = "SELECT * FROM HACE"
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvAdminGral.DataSource = ds.Tables(0)
            btnAdminGralGuardar.Enabled = True
            btnAdminGralEliminar.Enabled = True
        Catch ex As Exception
            MsgBox("Error al obtener datos.")
        End Try
    End Sub

    Private Sub A()
        Dim sql As String
        Dim ds As New DataSet
        Try
            sql = "SELECT * FROM A"
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvAdminGral.DataSource = ds.Tables(0)
            btnAdminGralGuardar.Enabled = True
            btnAdminGralEliminar.Enabled = True
        Catch ex As Exception
            MsgBox("Error al obtener datos.")
        End Try
    End Sub

    Private Sub GENERA()
        Dim sql As String
        Dim ds As New DataSet
        Try
            sql = "SELECT * FROM GENERA"
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvAdminGral.DataSource = ds.Tables(0)
            btnAdminGralGuardar.Enabled = True
            btnAdminGralEliminar.Enabled = True
        Catch ex As Exception
            MsgBox("Error al obtener datos.")
        End Try
    End Sub

    Private Sub RESPONDE()
        Dim sql As String
        Dim ds As New DataSet
        Try
            sql = "SELECT * FROM RESPONDE"
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvAdminGral.DataSource = ds.Tables(0)
            btnAdminGralGuardar.Enabled = True
            btnAdminGralEliminar.Enabled = True
        Catch ex As Exception
            MsgBox("Error al obtener datos.")
        End Try
    End Sub

    Private Sub CONTIENE()
        Dim sql As String
        Dim ds As New DataSet
        Try
            sql = "SELECT * FROM CONTIENE"
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvAdminGral.DataSource = ds.Tables(0)
            btnAdminGralGuardar.Enabled = True
            btnAdminGralEliminar.Enabled = True
        Catch ex As Exception
            MsgBox("Error al obtener datos.")
        End Try
    End Sub

    Private Sub REALIZA()
        Dim sql As String
        Dim ds As New DataSet
        Try
            sql = "SELECT * FROM REALIZA"
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvAdminGral.DataSource = ds.Tables(0)
            btnAdminGralGuardar.Enabled = True
            btnAdminGralEliminar.Enabled = True
        Catch ex As Exception
            MsgBox("Error al obtener datos.")
        End Try
    End Sub

    Private Sub SOBRE()
        Dim sql As String
        Dim ds As New DataSet
        Try
            sql = "SELECT * FROM SOBRE"
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvAdminGral.DataSource = ds.Tables(0)
            btnAdminGralGuardar.Enabled = True
            btnAdminGralEliminar.Enabled = True
        Catch ex As Exception
            MsgBox("Error al obtener datos.")
        End Try
    End Sub

    Private Sub ROLES()
        Dim sql As String
        Dim ds As New DataSet
        Try
            sql = "SELECT * FROM ROLES"
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvAdminGral.DataSource = ds.Tables(0)
            btnAdminGralGuardar.Enabled = True
            btnAdminGralEliminar.Enabled = True
        Catch ex As Exception
            MsgBox("Error al obtener datos.")
        End Try
    End Sub

    Private Sub USUARIO_ROL()
        Dim sql As String
        Dim ds As New DataSet
        Try
            sql = "SELECT * FROM USUARIO_ROL"
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvAdminGral.DataSource = ds.Tables(0)
            btnAdminGralGuardar.Enabled = True
            btnAdminGralEliminar.Enabled = True
        Catch ex As Exception
            MsgBox("Error al obtener datos.")
        End Try
    End Sub


    Private Sub dgvAdminGral_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAdminGral.CellClick
        Dim eleccion As String
        Dim temp As DateTime
        eleccion = Trim(Me.cboAdminGral.Text)
        If dgvAdminGral.RowCount > 1 Then
            If eleccion = "GENERA" Or eleccion = "SOBRE" Or eleccion = "ROLES" Or eleccion = "USUARIO_ROL" Then
                rowID = (dgvAdminGral(0, dgvAdminGral.CurrentRow.Index).Value.ToString())
                rowID1 = (dgvAdminGral(1, dgvAdminGral.CurrentRow.Index).Value.ToString())
            ElseIf eleccion = "A" Or eleccion = "RESPONDE" Or eleccion = "REALIZA" Then
                rowID = (dgvAdminGral(0, dgvAdminGral.CurrentRow.Index).Value.ToString())
                rowID1 = (dgvAdminGral(1, dgvAdminGral.CurrentRow.Index).Value.ToString())
                temp = (dgvAdminGral(2, dgvAdminGral.CurrentRow.Index).Value.ToString())
                rowDate = Format(temp, "MM/dd/yyyy")
            Else
                rowID = (dgvAdminGral(0, dgvAdminGral.CurrentRow.Index).Value.ToString())
                rowID1 = (dgvAdminGral(1, dgvAdminGral.CurrentRow.Index).Value.ToString())
                rowID2 = (dgvAdminGral(2, dgvAdminGral.CurrentRow.Index).Value.ToString())
            End If
        End If
    End Sub

    Private Sub btnAdminGralLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdminGralLimpiar.Click

    End Sub
End Class








































































'HIPERCODE DEVELOPINGS. ALL RIGHTS RESERVED. ™, ® & COPYRIGHT © 2019, MADE IN URUGUAY.