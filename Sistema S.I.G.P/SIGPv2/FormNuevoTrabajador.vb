Imports System.Data.Odbc
Public Class FormNuevoTrabajador

    Private Sub FormNuevoTrabajador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        MaximizeBox = False
        MinimizeBox = False
        txtNuevoTrabajadorNombre.Enabled = False
        txtNuevoTrabajadorApellido.Enabled = False
        txtNuevoTrabajadorSector.Enabled = False
        txtNuevoTrabajadorCapacitaciones.Enabled = False
        cboNuevoTrabajadorTurno.Enabled = False
        btnNuevoTrabajadorGuardar.Enabled = False
        btnNuevoTrabajadorAsignarTrabajador.Enabled = False
    End Sub

    Private Sub btnNuevoTrabajadorGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoTrabajadorGuardar.Click
        Dim sql As String
        Try
            If txtNuevoTrabajadorCi.Text = "" Or txtNuevoTrabajadorNombre.Text = "" Or txtNuevoTrabajadorApellido.Text = "" Then
                MsgBox("Asegurese de ingresar todos los datos!")
            Else
                Try
                    sql = "INSERT INTO trabajador VALUES('" & txtNuevoTrabajadorCi.Text & "','" & txtNuevoTrabajadorNombre.Text & "','" & txtNuevoTrabajadorApellido.Text & "','" & txtNuevoTrabajadorCapacitaciones.Text & "')"
                    comando.Connection = conexion
                    comando.CommandText = sql
                    comando.ExecuteNonQuery()
                    MsgBox("Trabajador Ingresado")
                    txtNuevoTrabajadorSector.Enabled = True
                    cboNuevoTrabajadorTurno.Enabled = True
                    txtNuevoTrabajadorNombre.Enabled = False
                    txtNuevoTrabajadorApellido.Enabled = False
                    txtNuevoTrabajadorCapacitaciones.Enabled = False
                    btnNuevoTrabajadorGuardar.Enabled = False
                    btnNuevoTrabajadorAsignarTrabajador.Enabled = True
                    txtNuevoTrabajadorCi.Enabled = False
                    btnNuevoTrabajadorBuscarTrabajador.Enabled = False
                Catch ex As Exception
                    MsgBox("Error.")
                End Try
            End If
        Catch ex As Exception
            MsgBox("Error al ingresar datos")
        End Try
    End Sub

    Private Sub btnNuevoTrabajadorLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoTrabajadorLimpiar.Click
        txtNuevoTrabajadorCi.Clear()
        txtNuevoTrabajadorNombre.Clear()
        txtNuevoTrabajadorApellido.Clear()
        txtNuevoTrabajadorSector.Clear()
        txtNuevoTrabajadorCapacitaciones.Clear()
        cboNuevoTrabajadorTurno.Text = ""
    End Sub

    Private Sub btnNuevoTrabajadorSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoTrabajadorSalir.Click
        Me.Close()
        RutEmpresa = ""
    End Sub

    Private Sub btnNuevoTrabajadorBuscarTrabajador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoTrabajadorBuscarTrabajador.Click
        Dim dr As Odbc.OdbcDataReader
        Dim sql As String
        If txtNuevoTrabajadorCi.Text = "" Then
            MsgBox("Debe ingresar la CI.")
        Else
            ci_tr = txtNuevoTrabajadorCi.Text
            Try
                sql = "SELECT * FROM trabajador WHERE ci_tr='" & txtNuevoTrabajadorCi.Text & "'"
                comando.Connection = conexion
                comando.CommandText = sql
                dr = comando.ExecuteReader()
                If dr.HasRows Then
                    MsgBox("Trabajador ya ingresado.")
                    txtNuevoTrabajadorNombre.Enabled = False
                    txtNuevoTrabajadorApellido.Enabled = False
                    txtNuevoTrabajadorCapacitaciones.Enabled = False
                    txtNuevoTrabajadorNombre.Text = dr("nom_tr")
                    txtNuevoTrabajadorApellido.Text = dr("ape_tr")
                    txtNuevoTrabajadorCapacitaciones.Text = dr("capacitaciones")
                    dr.Close()
                    Try
                        sql = "SELECT * FROM tiene WHERE ci_tr='" & txtNuevoTrabajadorCi.Text & "' and rut='" & RutEmpresa & "'"
                        comando.Connection = conexion
                        comando.CommandText = sql
                        dr = comando.ExecuteReader()
                        If dr.HasRows Then
                            turno_tr = dr("turno")
                            sector_tr = dr("sector")
                            txtNuevoTrabajadorSector.Text = sector_tr
                            If turno_tr = "M" Then
                                cboNuevoTrabajadorTurno.Text = "Matutino"
                            ElseIf turno_tr = "V" Then
                                cboNuevoTrabajadorTurno.Text = "Vespertino"
                            ElseIf turno_tr = "N" Then
                                cboNuevoTrabajadorTurno.Text = "Nocturno"
                            End If
                            txtNuevoTrabajadorSector.Enabled = True
                            cboNuevoTrabajadorTurno.Enabled = True
                            btnNuevoTrabajadorAsignarTrabajador.Enabled = True
                            dr.Close()
                        Else
                            dr.Close()
                        End If
                    Catch ex As Exception
                        MsgBox("Error al obtener datos de la tabla tiene.")
                    End Try
                Else
                    MsgBox("El trabajador no se encuentra ingresado.")
                    txtNuevoTrabajadorNombre.Clear()
                    txtNuevoTrabajadorApellido.Clear()
                    txtNuevoTrabajadorCapacitaciones.Clear()
                    txtNuevoTrabajadorSector.Clear()
                    cboNuevoTrabajadorTurno.Text = ""
                    txtNuevoTrabajadorNombre.Enabled = True
                    txtNuevoTrabajadorApellido.Enabled = True
                    txtNuevoTrabajadorCapacitaciones.Enabled = True
                    txtNuevoTrabajadorSector.Enabled = False
                    cboNuevoTrabajadorTurno.Enabled = False
                    btnNuevoTrabajadorGuardar.Enabled = True
                    dr.Close()
                End If
            Catch ex As Exception
                MsgBox("Error al obtener datos de trabajador.")
            End Try
        End If
    End Sub

    Private Sub btnNuevoTrabajadorAsignarTrabajador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoTrabajadorAsignarTrabajador.Click
        Dim dr As Odbc.OdbcDataReader
        Dim sql As String
        Dim op As String
        Dim eleccion As String
        eleccion = Trim(Me.cboNuevoTrabajadorTurno.Text)

        If txtNuevoTrabajadorSector.Text = "" Or cboNuevoTrabajadorTurno.Text = "" Then
            MsgBox("Debe ingresar todos los datos.")
        Else
            Try
                sql = "SELECT * FROM tiene WHERE ci_tr='" & txtNuevoTrabajadorCi.Text & "' and rut='" & RutEmpresa & "'"
                comando.Connection = conexion
                comando.CommandText = sql
                dr = comando.ExecuteReader()
                If dr.HasRows Then
                    MsgBox("El Trabajador ya esta vinculado a la empresa: " + RSEmpresa)
                    txtNuevoTrabajadorSector.Enabled = False
                    cboNuevoTrabajadorTurno.Enabled = False
                    turno_tr = dr("turno")
                    sector_tr = dr("sector")
                    txtNuevoTrabajadorSector.Text = sector_tr
                    If turno_tr = "M" Then
                        cboNuevoTrabajadorTurno.Text = "Matutino"
                    ElseIf turno_tr = "V" Then
                        cboNuevoTrabajadorTurno.Text = "Vespertino"
                    ElseIf turno_tr = "N" Then
                        cboNuevoTrabajadorTurno.Text = "Nocturno"
                    End If
                    dr.Close()
                Else
                    dr.Close()
                    If eleccion = "Matutino" Then
                        op = "M"
                        Try
                            sql = "SELECT * FROM tiene WHERE ci_tr='" & txtNuevoTrabajadorCi.Text & "' and turno='" & op & "'"
                            comando.Connection = conexion
                            comando.CommandText = sql
                            dr = comando.ExecuteReader()
                            If dr.HasRows Then
                                MsgBox("El trabajador ya trabaja en el turno: " + eleccion)
                                dr.Close()
                            Else
                                dr.Close()
                                sql = "INSERT INTO tiene VALUES('" & RutEmpresa & "','" & txtNuevoTrabajadorCi.Text & "','" & op & "','" & txtNuevoTrabajadorSector.Text & "')"
                                comando.Connection = conexion
                                comando.CommandText = sql
                                comando.ExecuteNonQuery()
                                MsgBox("Trabajador asignado a la empresa: " + RSEmpresa)
                                txtNuevoTrabajadorSector.Enabled = False
                                cboNuevoTrabajadorTurno.Enabled = False
                                btnNuevoTrabajadorAsignarTrabajador.Enabled = False
                                txtNuevoTrabajadorCi.Enabled = True
                                btnNuevoTrabajadorBuscarTrabajador.Enabled = True
                            End If
                        Catch ex As Exception
                            MsgBox("Error.")
                        End Try
                    ElseIf eleccion = "Vespertino" Then
                        op = "V"
                        Try
                            sql = "SELECT * FROM tiene WHERE ci_tr='" & txtNuevoTrabajadorCi.Text & "' and turno='" & op & "'"
                            comando.Connection = conexion
                            comando.CommandText = sql
                            dr = comando.ExecuteReader()
                            If dr.HasRows Then
                                MsgBox("El trabajador ya trabaja en el turno: " + eleccion)
                                dr.Close()
                            Else
                                dr.Close()
                                sql = "INSERT INTO tiene VALUES('" & RutEmpresa & "','" & txtNuevoTrabajadorCi.Text & "','" & op & "','" & txtNuevoTrabajadorSector.Text & "')"
                                comando.Connection = conexion
                                comando.CommandText = sql
                                comando.ExecuteNonQuery()
                                MsgBox("Trabajador asignado a la empresa: " + RSEmpresa)
                                txtNuevoTrabajadorSector.Enabled = False
                                cboNuevoTrabajadorTurno.Enabled = False
                                txtNuevoTrabajadorCi.Enabled = True
                                btnNuevoTrabajadorBuscarTrabajador.Enabled = True
                                btnNuevoTrabajadorAsignarTrabajador.Enabled = False
                            End If
                        Catch ex As Exception
                            MsgBox("Error.")
                        End Try
                    ElseIf eleccion = "Nocturno" Then
                        op = "N"
                        Try
                            sql = "SELECT * FROM tiene WHERE ci_tr='" & txtNuevoTrabajadorCi.Text & "' and turno='" & op & "'"
                            comando.Connection = conexion
                            comando.CommandText = sql
                            dr = comando.ExecuteReader()
                            If dr.HasRows Then
                                MsgBox("El trabajador ya trabaja en el turno: " + eleccion)
                                dr.Close()
                            Else
                                dr.Close()
                                sql = "INSERT INTO tiene VALUES('" & RutEmpresa & "','" & txtNuevoTrabajadorCi.Text & "','" & op & "','" & txtNuevoTrabajadorSector.Text & "')"
                                comando.Connection = conexion
                                comando.CommandText = sql
                                comando.ExecuteNonQuery()
                                MsgBox("Trabajador asignado a la empresa: " + RSEmpresa)
                                txtNuevoTrabajadorSector.Enabled = False
                                cboNuevoTrabajadorTurno.Enabled = False
                                txtNuevoTrabajadorCi.Enabled = True
                                btnNuevoTrabajadorBuscarTrabajador.Enabled = True
                                btnNuevoTrabajadorAsignarTrabajador.Enabled = False
                            End If
                        Catch ex As Exception
                            MsgBox("Error.")
                        End Try
                        dr.Close()
                    End If
                    dr.Close()
                End If
                dr.Close()
            Catch ex As Exception
                MsgBox("Error.")
            End Try
        End If
    End Sub
End Class








































































'HIPERCODE DEVELOPINGS. ALL RIGHTS RESERVED. ™, ® & COPYRIGHT © 2019, MADE IN URUGUAY.