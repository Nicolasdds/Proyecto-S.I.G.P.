Imports System.Data.Odbc
Public Class FormInspecciones

    Private Sub FormInspecciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        MaximizeBox = False
        MinimizeBox = False
        'TextBox
        txtInspeccionUnidadInspectora.Enabled = False
        txtInspeccionTipoObservacion.Enabled = False
        txtInspeccionNarracion.Enabled = False
        'Button
        btnInspeccionGuardarInspeccion.Enabled = False
        'DataTimePicker
        dtpInspeccionFechaVisita.Enabled = False
        dtpInspeccionFechaDictado.Enabled = False
        dtpInspeccionFechaRespuesta.Enabled = False
        'ComboBox
        cboInspeccionTipoUnidad.Enabled = False
    End Sub
    Private Sub btnInspeccionBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInspeccionBuscar.Click
        Dim dr As Odbc.OdbcDataReader
        Dim ds As New DataSet
        Dim sql As String

        If txtInspeccionRUT.Text = "" Then
            MsgBox("Debe ingresar el RUT.")
        Else
            sql = "SELECT * FROM empresa WHERE rut='" & txtInspeccionRUT.Text & "'"
            comando.Connection = conexion
            comando.CommandText = sql
            dr = comando.ExecuteReader()
            If dr.HasRows Then
                MsgBox("La empresa existe.")
                RSEmpresa = dr("razon_social")
                txtInspeccionRUT.Enabled = False
                txtInspeccionUnidadInspectora.Enabled = True
                txtInspeccionUnidadInspectora.Clear()
                txtInspeccionTipoObservacion.Enabled = True
                txtInspeccionTipoObservacion.Clear()
                txtInspeccionNarracion.Enabled = True
                txtInspeccionNarracion.Clear()
                btnInspeccionGuardarInspeccion.Enabled = True
                cboInspeccionTipoUnidad.Enabled = True
                cboInspeccionTipoUnidad.Text = ""
                dtpInspeccionFechaVisita.Enabled = True
                dtpInspeccionFechaDictado.Enabled = True
                dtpInspeccionFechaRespuesta.Enabled = True
                dr.Close()
                datagrid()
            Else
                txtInspeccionUnidadInspectora.Clear()
                txtInspeccionTipoObservacion.Clear()
                txtInspeccionNarracion.Clear()
                cboInspeccionTipoUnidad.Text = ""
                Dim result As Integer = MessageBox.Show("La empresa no existe, desea ingresarla?", "Mensaje", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    dr.Close()
                    RutEmpresa = txtInspeccionRUT.Text
                    FormEmpresa.Show()
                    FormEmpresa.MdiParent = FormPrincipal
                    dr.Close()
                End If
                dr.Close()
            End If
        End If
    End Sub

    Private Sub datagrid()
        Dim dr As Odbc.OdbcDataReader
        Dim ds As New DataSet
        Dim sql As String
        Try
            sql = "SELECT a.unidad_inspectora, e.razon_social as empresa, a.fecha_visita, o.narracion from a as a, empresa as e, observacion as o where e.rut=a.rut and o.id_obs=a.id_obs and a.rut='" & txtInspeccionRUT.Text & "'"
            Dim da As New OdbcDataAdapter(sql, conexion)
            comando.Connection = conexion
            comando.CommandText = sql
            dr = comando.ExecuteReader()
            If dr.HasRows Then
                MsgBox("La empresa tiene inspecciones")
                da.Fill(ds)
                dgvInspeccionInspeccionesRealizadas.DataSource = ds.Tables(0)
                dgvInspeccionInspeccionesRealizadas.Visible = True
                dgvInspeccionInspeccionesRealizadas.ReadOnly = True
                dr.Close()
            Else
                MsgBox("La empresa no tiene inspecciones")
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox("Error.")
        End Try
    End Sub

    Private Sub btnInspeccionGuardarInspeccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInspeccionGuardarInspeccion.Click
        Dim sql As String
        Dim dr As Odbc.OdbcDataReader
        Dim fecha_visita As String
        Dim fecha_dictado As String
        Dim fecha_resp As String
        Dim eleccion As String
        fecha_visita = Format(dtpInspeccionFechaVisita.Value, "MM/dd/yyyy")
        fecha_dictado = Format(dtpInspeccionFechaDictado.Value, "MM/dd/yyyy")
        fecha_resp = Format(dtpInspeccionFechaRespuesta.Value, "MM/dd/yyyy")
        eleccion = Trim(Me.cboInspeccionTipoUnidad.Text)
        If txtInspeccionUnidadInspectora.Text = "" Or cboInspeccionTipoUnidad.Text = "" Or txtInspeccionTipoObservacion.Text = "" Or txtInspeccionNarracion.Text = "" Then
            MsgBox("Debe ingresar todos los datos")
        Else
            Try
                sql = "select * from inspeccion WHERE unidad_inspectora='" & txtInspeccionUnidadInspectora.Text & "' and fecha_visita='" & fecha_visita & "'"
                comando.Connection = conexion
                comando.CommandText = sql
                dr = comando.ExecuteReader()
                If dr.HasRows Then
                    MsgBox("Ya existe una inspeccion de esta unidad en esa fecha.")
                    dr.Close()
                Else
                    dr.Close()
                    Try
                        sql = "INSERT INTO inspeccion VALUES('" & txtInspeccionUnidadInspectora.Text & "','" & fecha_visita & "','" & eleccion & "')"
                        comando.Connection = conexion
                        comando.CommandText = sql
                        comando.ExecuteNonQuery()
                        MsgBox("Inspeccion ingresada")
                        Try
                            sql = "INSERT INTO observacion VALUES(0,'" & txtInspeccionTipoObservacion.Text & "','" & txtInspeccionNarracion.Text & "','" & fecha_dictado & "','" & fecha_resp & "')"
                            comando.Connection = conexion
                            comando.CommandText = sql
                            comando.ExecuteNonQuery()
                            MsgBox("Observacion ingresada")
                            Try
                                dr.Close()
                                sql = "SELECT * FROM observacion WHERE id_obs=(select max(id_obs) from observacion)"
                                comando.Connection = conexion
                                comando.CommandText = sql
                                dr = comando.ExecuteReader()
                                If dr.HasRows Then
                                    Id_obs = dr("id_obs")
                                    Try
                                        dr.Close()
                                        sql = "INSERT INTO realiza VALUES('" & Id_obs & "','" & txtInspeccionUnidadInspectora.Text & "','" & fecha_visita & "')"
                                        comando.Connection = conexion
                                        comando.CommandText = sql
                                        comando.ExecuteNonQuery()
                                        MsgBox("Observacion vinculada a Inspeccion de: " + txtInspeccionUnidadInspectora.Text)
                                        dr.Close()
                                        Try
                                            sql = "INSERT INTO a VALUES('" & Id_obs & "','" & txtInspeccionUnidadInspectora.Text & "','" & fecha_visita & "','" & txtInspeccionRUT.Text & "')"
                                            comando.Connection = conexion
                                            comando.CommandText = sql
                                            comando.ExecuteNonQuery()
                                            MsgBox("Inspeccion de: " + txtInspeccionUnidadInspectora.Text + vbCr + "Vinculada a Empresa: " + RSEmpresa)
                                            txtInspeccionUnidadInspectora.Enabled = False
                                            txtInspeccionTipoObservacion.Enabled = False
                                            txtInspeccionNarracion.Enabled = False
                                            cboInspeccionTipoUnidad.Enabled = False
                                            dtpInspeccionFechaDictado.Enabled = False
                                            dtpInspeccionFechaRespuesta.Enabled = False
                                            dtpInspeccionFechaVisita.Enabled = False
                                            btnInspeccionGuardarInspeccion.Enabled = False
                                            dr.Close()
                                            datagrid()
                                        Catch ex As Exception
                                            MsgBox("Error al intenter vincular la inspeccion con la empresa: " + RSEmpresa)
                                        End Try
                                    Catch ex As Exception
                                        MsgBox("Error al ingresar datos en la tabla realiza")
                                    End Try
                                Else
                                    MsgBox("No existe un ultimo relevamiento")
                                    dr.Close()
                                End If
                            Catch ex As Exception
                                MsgBox("Error al obtener el ultimo id de la tabla observacion")
                            End Try
                        Catch ex As Exception
                            MsgBox("Error al ingresar datos en la tabla observacion")
                        End Try
                    Catch ex As Exception
                        MsgBox("Error al ingresar datos en la tabla inspeccion")
                    End Try
                End If
            Catch ex As Exception
                MsgBox("Error.")
            End Try
        End If
    End Sub

    Private Sub btnInspeccionSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInspeccionSalir.Click
        Me.Close()
    End Sub

    Private Sub btnInspeccionLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInspeccionLimpiar.Click
        txtInspeccionRUT.Clear()
        txtInspeccionRUT.Enabled = True
        txtInspeccionNarracion.Clear()
        txtInspeccionTipoObservacion.Clear()
        txtInspeccionUnidadInspectora.Clear()

    End Sub
End Class








































































'HIPERCODE DEVELOPINGS. ALL RIGHTS RESERVED. ™, ® & COPYRIGHT © 2019, MADE IN URUGUAY.