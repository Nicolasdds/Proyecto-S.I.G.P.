Imports System.Data.Odbc
Public Class FormPlanDeContingencia

    Private Sub FormPlanDeContingencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        MaximizeBox = False
        MinimizeBox = False
        txtPlanContingenciaInspeccion.Enabled = False
        datagrid()
    End Sub

    Private Sub datagrid()
        Dim dr As Odbc.OdbcDataReader
        Dim ds As New DataSet
        Dim sql As String
        Try
            sql = "SELECT o.id_obs as id_obs, a.unidad_inspectora, e.razon_social as empresa, a.fecha_visita, o.narracion from a as a, empresa as e, observacion as o where e.rut=a.rut and o.id_obs=a.id_obs and a.rut='" & EmpresaActualRUT & "'"
            Dim da As New OdbcDataAdapter(sql, conexion)
            comando.Connection = conexion
            comando.CommandText = sql
            dr = comando.ExecuteReader()
            If dr.HasRows Then
                da.Fill(ds)
                dgvPlanContingenciaInspecciones.DataSource = ds.Tables(0)
                dgvPlanContingenciaInspecciones.Visible = True
                dgvPlanContingenciaInspecciones.ReadOnly = True
                dr.Close()
            Else
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al obtener inspecciones.")
        End Try
    End Sub

    Private Sub dgvPlanContingenciaInspecciones_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPlanContingenciaInspecciones.CellClick
        If e.RowIndex > -1 Then
            Id_obs = (dgvPlanContingenciaInspecciones("id_obs", dgvPlanContingenciaInspecciones.CurrentRow.Index).Value.ToString())
            unidad_inspectora = (dgvPlanContingenciaInspecciones("unidad_inspectora", dgvPlanContingenciaInspecciones.CurrentRow.Index).Value.ToString())
            fecha_visita = Format((dgvPlanContingenciaInspecciones("fecha_visita", dgvPlanContingenciaInspecciones.CurrentRow.Index).Value), "MM/dd/yyyy")
            txtPlanContingenciaInspeccion.Text = unidad_inspectora + " - " + fecha_visita + "."
        End If
    End Sub

    Private Sub btnPlanContingenciaGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlanContingenciaGuardar.Click
        Dim dr As Odbc.OdbcDataReader
        Dim sql As String
        Dim fecha_actual As DateTime = DateTime.Now
        Dim solo_fecha As String
        Dim completado As String
        Dim id_plan As String
        Dim nom_plan As String
        solo_fecha = Format(fecha_actual, "MM/dd/yyyy")
        If txtPlanContingenciaNombre.Text = "" Or txtPlanContingenciaSolucion.Text = "" Then
            MsgBox("Debe ingresar todos los datos.")
        Else
            If txtPlanContingenciaInspeccion.Text = "" Then



                If chkPlanContingenciaCompletado.Checked = True Then
                    MsgBox("Completado esta chequeado")
                    'Try
                    completado = "v"
                    sql = "INSERT INTO plan VALUES(0,'" & solo_fecha & "','" & txtPlanContingenciaSolucion.Text & "','" & completado & "','" & txtPlanContingenciaNombre.Text & "')"
                    comando.Connection = conexion
                    comando.CommandText = sql
                    comando.ExecuteNonQuery()
                    MsgBox("Plan Ingresado")
                    'Try
                    sql = "SELECT * FROM plan WHERE id_plan=(select max(id_plan) from plan)"
                    comando.Connection = conexion
                    comando.CommandText = sql
                    dr = comando.ExecuteReader()
                    If dr.HasRows Then
                        'Try
                        id_plan = dr("id_plan")
                        dr.Close()
                        sql = "INSERT INTO genera VALUES('" & RelevamientoActualId & "','" & id_plan & "')"
                        comando.Connection = conexion
                        comando.CommandText = sql
                        comando.ExecuteNonQuery()
                        MsgBox("Se ha asociado plan a relevamiento")
                        dr.Close()
                        'Catch ex As Exception
                        '    MsgBox("Error al relacionar plan con relevamiento")
                        'End Try
                    Else
                        MsgBox("No existe un ultimo ingreso en la tabla plan.")
                        dr.Close()
                    End If
                    '    Catch ex As Exception
                    '        MsgBox("Error al obtener el id del ultimo plan")
                    '    End Try
                    'Catch ex As Exception
                    '    MsgBox("Error al insertar datos en la tabla plan")
                    'End Try
                Else
                    MsgBox("Completado no esta chequeado")
                    'Try
                    completado = "f"
                    sql = "INSERT INTO plan VALUES(0,'" & solo_fecha & "','" & txtPlanContingenciaSolucion.Text & "','" & completado & "','" & txtPlanContingenciaNombre.Text & "')"
                    comando.Connection = conexion
                    comando.CommandText = sql
                    comando.ExecuteNonQuery()
                    MsgBox("Plan Ingresado")
                    'Try
                    sql = "SELECT * FROM plan WHERE id_plan=(select max(id_plan) from plan)"
                    comando.Connection = conexion
                    comando.CommandText = sql
                    dr = comando.ExecuteReader()
                    If dr.HasRows Then
                        'Try
                        id_plan = dr("id_plan")
                        dr.Close()
                        sql = "INSERT INTO genera VALUES('" & RelevamientoActualId & "','" & id_plan & "')"
                        comando.Connection = conexion
                        comando.CommandText = sql
                        comando.ExecuteNonQuery()
                        MsgBox("Se ha asociado plan a relevamiento")
                        dr.Close()
                        '        Catch ex As Exception
                        '    MsgBox("Error al relacionar plan con relevamiento")
                        'End Try
                    Else
                        MsgBox("No existe un ultimo ingreso en la tabla plan.")
                        dr.Close()
                    End If
                    'Catch ex As Exception
                    '    MsgBox("Error al obtener el id del ultimo plan")
                    'End Try
                    'Catch ex As Exception
                    '    MsgBox("Error al insertar datos en la tabla plan")
                    'End Try
                End If






            Else
                Try
                    sql = "SELECT p.nom_plan FROM responde as r, plan as p WHERE r.id_plan=p.id_plan and id_obs=" & Id_obs & " and unidad_inspectora='" & unidad_inspectora & "' and fecha_visita='" & fecha_visita & "'"
                    comando.Connection = conexion
                    comando.CommandText = sql
                    dr = comando.ExecuteReader()
                    If dr.HasRows Then
                        nom_plan = dr("nom_plan")
                        MsgBox("Esta inspeccion ya esta asociada al plan: " + nom_plan)
                        dr.Close()
                    Else
                        If chkPlanContingenciaCompletado.Checked = True Then
                            MsgBox("Completado esta chequeado")
                            Try
                                dr.Close()
                                completado = "v"
                                sql = "INSERT INTO plan VALUES(0,'" & solo_fecha & "','" & txtPlanContingenciaSolucion.Text & "','" & completado & "','" & txtPlanContingenciaNombre.Text & "')"
                                comando.Connection = conexion
                                comando.CommandText = sql
                                comando.ExecuteNonQuery()
                                MsgBox("Plan Ingresado")
                                Try
                                    sql = "SELECT * FROM plan WHERE id_plan=(select max(id_plan) from plan)"
                                    comando.Connection = conexion
                                    comando.CommandText = sql
                                    dr = comando.ExecuteReader()
                                    If dr.HasRows Then
                                        Try
                                            id_plan = dr("id_plan")
                                            dr.Close()
                                            sql = "INSERT INTO genera VALUES('" & RelevamientoActualId & "','" & id_plan & "')"
                                            comando.Connection = conexion
                                            comando.CommandText = sql
                                            comando.ExecuteNonQuery()
                                            MsgBox("Se ha asociado plan a relevamiento")
                                            dr.Close()
                                            Try
                                                dr.Close()
                                                sql = "INSERT INTO responde VALUES('" & Id_obs & "','" & unidad_inspectora & "','" & fecha_visita & "','" & id_plan & "')"
                                                comando.Connection = conexion
                                                comando.CommandText = sql
                                                comando.ExecuteNonQuery()
                                                MsgBox("Se ha asociado plan con inspeccion")
                                                dr.Close()
                                            Catch ex As Exception
                                                MsgBox("Error al relacionar plan con inspeccion")
                                            End Try
                                        Catch ex As Exception
                                            MsgBox("Error al relacionar plan con relevamiento")
                                        End Try
                                    Else
                                        MsgBox("No existe un ultimo ingreso en la tabla plan.")
                                        dr.Close()
                                    End If
                                Catch ex As Exception
                                    MsgBox("Error al obtener el id del ultimo plan")
                                End Try
                            Catch ex As Exception
                                MsgBox("Error al insertar datos en la tabla plan")
                            End Try
                        Else
                            MsgBox("Completado no esta chequeado")
                            Try
                                dr.Close()
                                completado = "f"
                                sql = "INSERT INTO plan VALUES(0,'" & solo_fecha & "','" & txtPlanContingenciaSolucion.Text & "','" & completado & "','" & txtPlanContingenciaNombre.Text & "')"
                                comando.Connection = conexion
                                comando.CommandText = sql
                                comando.ExecuteNonQuery()
                                MsgBox("Plan Ingresado")
                                Try
                                    sql = "SELECT * FROM plan WHERE id_plan=(select max(id_plan) from plan)"
                                    comando.Connection = conexion
                                    comando.CommandText = sql
                                    dr = comando.ExecuteReader()
                                    If dr.HasRows Then
                                        Try
                                            id_plan = dr("id_plan")
                                            dr.Close()
                                            sql = "INSERT INTO genera VALUES('" & RelevamientoActualId & "','" & id_plan & "')"
                                            comando.Connection = conexion
                                            comando.CommandText = sql
                                            comando.ExecuteNonQuery()
                                            MsgBox("Se ha asociado plan a relevamiento")
                                            dr.Close()
                                            Try
                                                dr.Close()
                                                sql = "INSERT INTO responde VALUES('" & Id_obs & "','" & unidad_inspectora & "','" & fecha_visita & "','" & id_plan & "')"
                                                comando.Connection = conexion
                                                comando.CommandText = sql
                                                comando.ExecuteNonQuery()
                                                MsgBox("Se ha asociado plan con inspeccion")
                                                dr.Close()
                                            Catch ex As Exception
                                                MsgBox("Error al relacionar plan con inspeccion")
                                            End Try
                                        Catch ex As Exception
                                            MsgBox("Error al relacionar plan con relevamiento")
                                        End Try
                                    Else
                                        MsgBox("No existe un ultimo ingreso en la tabla plan.")
                                        dr.Close()
                                    End If
                                Catch ex As Exception
                                    MsgBox("Error al obtener el id del ultimo plan")
                                End Try
                            Catch ex As Exception
                                MsgBox("Error al insertar datos en la tabla plan")
                            End Try
                            dr.Close()
                        End If
                        dr.Close()
                    End If
                    dr.Close()
                Catch ex As Exception
                    MsgBox("Error al verificar datos en tabla responde")
                End Try
            End If
            End If
    End Sub

    Private Sub btnPlanContingenciaSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlanContingenciaSalir.Click
        Me.Close()
    End Sub

    Private Sub btnPlanContingenciaLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlanContingenciaLimpiar.Click
        txtPlanContingenciaNombre.Clear()
        txtPlanContingenciaSolucion.Clear()
        txtPlanContingenciaInspeccion.Clear()
    End Sub
End Class









































































'HIPERCODE DEVELOPINGS. ALL RIGHTS RESERVED. ™, ® & COPYRIGHT © 2019, MADE IN URUGUAY.