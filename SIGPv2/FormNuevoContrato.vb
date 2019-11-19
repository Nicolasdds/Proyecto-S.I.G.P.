Imports System.Data.Odbc
Public Class FormNuevoContrato
    Private Sub FormNuevoContrato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNuevoContratoRUT.Text = RutEmpresa
        'DateTimePicker
        dtpNuevoContratoFBaja.ShowCheckBox = True
        dtpNuevoContratoFBaja.Checked = False
    End Sub

    Private Sub btnNuevoContratoAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoContratoAceptar.Click
        Dim dr As Odbc.OdbcDataReader
        Dim sql As String
        Dim fecha_alta As String
        Dim fecha_baja As String
        fecha_alta = Format(dtpNuevoContratoFAlta.Value, "MM/dd/yyyy")
        fecha_baja = Format(dtpNuevoContratoFAlta.Value, "MM/dd/yyyy")
        If txtNuevoContratoRUT.Text = "" Then
            MsgBox("Debe ingresar el RUT.")
        Else
            Try
                sql = "SELECT * FROM empresa WHERE rut='" & txtNuevoContratoRUT.Text & "'"
                comando.Connection = conexion
                comando.CommandText = sql
                dr = comando.ExecuteReader()
                If dr.HasRows Then
                    MsgBox("La empresa existe")
                    dr.Close()
                    Try
                        sql = "SELECT P.ci_pr AS cedula, P.nom_pr AS nombre, P.ape_pr AS apellido FROM prevencionista AS P, contrata AS C WHERE P.ci_pr=C.ci_pr AND C.rut='" & txtNuevoContratoRUT.Text & "'"
                        comando.Connection = conexion
                        comando.CommandText = sql
                        dr = comando.ExecuteReader()
                        If dr.HasRows Then
                            MsgBox("La empresa ya tiene un contrato actualmente con:" + vbCr + "Cedula: " + dr("cedula") + vbCr + "Nombre: " + dr("nombre") + vbCr + "Apellido: " + dr("apellido"))
                            dr.Close()
                        Else
                            dr.Close()
                            'Obteneniendo cedula del prevencionista actual
                            MsgBox("Intentando obtener cedula del prevencionista actual")
                            Try
                                sql = "SELECT ci_pr FROM prevencionista WHERE usr_pr='" & usuario & "'"
                                comando.Connection = conexion
                                comando.CommandText = sql
                                dr = comando.ExecuteReader()
                                If dr.HasRows Then
                                    CiPrevencionista = dr("ci_pr")
                                    'Si existe el prevencionista entonces...
                                    dr.Close()
                                    If dtpNuevoContratoFBaja.Checked = False Then
                                        MsgBox("La cedula del prevencionista es: " + CiPrevencionista)
                                        fecha_baja = ""
                                        Try
                                            sql = "INSERT INTO contrata VALUES('" & txtNuevoContratoRUT.Text & "','" & CiPrevencionista & "','" & fecha_alta & "','" & fecha_baja & "')"
                                            comando.Connection = conexion
                                            comando.CommandText = sql
                                            comando.ExecuteNonQuery()
                                            MsgBox("Contrato del Prevencionista Ingresado.")
                                            btnNuevoContratoAceptar.Enabled = False
                                            dr.Close()
                                        Catch ex As Exception
                                            MsgBox("Error.")
                                        End Try
                                    Else
                                        Try
                                            sql = "INSERT INTO contrata VALUES('" & txtNuevoContratoRUT.Text & "','" & CiPrevencionista & "','" & fecha_alta & "','" & fecha_baja & "')"
                                            comando.Connection = conexion
                                            comando.CommandText = sql
                                            comando.ExecuteNonQuery()
                                            MsgBox("Contrato del Prevencionista Ingresado.")
                                            btnNuevoContratoAceptar.Enabled = False
                                            dr.Close()
                                        Catch ex As Exception
                                            MsgBox("Error.")
                                        End Try
                                    End If
                                    dr.Close()
                                Else
                                    MsgBox("No tiene acceso, el usuario actual no es un prevencionista.")
                                    dr.Close()
                                End If
                            Catch ex As Exception
                                MsgBox("Error.")
                            End Try
                        End If
                        dr.Close()
                    Catch ex As Exception
                        MsgBox("Error.")
                    End Try
                Else
            Dim result As Integer = MessageBox.Show("La empresa no existe, desea ingresarla?", "Mensaje", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                RutEmpresa = txtNuevoContratoRUT.Text
                FormEmpresa.Show()
                FormEmpresa.MdiParent = FormPrincipal
                dr.Close()
            End If
            dr.Close()
        End If
        dr.Close()
            Catch ex As Exception
            MsgBox("Error.")
        End Try
        End If
        dr.Close()
    End Sub
    Private Sub btnNuevoContratoVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoContratoVolver.Click
        Me.Close()
    End Sub
End Class








































































'HIPERCODE DEVELOPINGS. ALL RIGHTS RESERVED. ™, ® & COPYRIGHT © 2019, MADE IN URUGUAY.
