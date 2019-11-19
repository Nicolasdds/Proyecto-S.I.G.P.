Public Class FormNuevoRelevamiento
    'Estos permisos solo los deberá tener el tecnico prevencionista.
    Private Sub FormNuevoRelevamiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        MaximizeBox = False
        MinimizeBox = False
        dtpNuevoRelevamientoFI.Enabled = False
        btnNuevoRelevamientoGuardarRelevamiento.Enabled = False
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoRelevamientoBuscar.Click
        Dim dr As Odbc.OdbcDataReader
        Dim sql As String
        If txtNuevoRelevamientoRUT.Text = "" Then
            MsgBox("Debe ingresar el RUT.")
        Else
            Try
                sql = "SELECT * FROM empresa WHERE rut='" & txtNuevoRelevamientoRUT.Text & "'"
                comando.Connection = conexion
                comando.CommandText = sql
                dr = comando.ExecuteReader()
                If dr.HasRows Then
                    MsgBox("La empresa existe.")
                    dtpNuevoRelevamientoFI.Enabled = True
                    btnNuevoRelevamientoGuardarRelevamiento.Enabled = True
                    dr.Close()
                Else
                    Dim result As Integer = MessageBox.Show("La empresa no existe, desea ingresarla?", "Mensaje", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                        dtpNuevoRelevamientoFI.Enabled = False
                        btnNuevoRelevamientoGuardarRelevamiento.Enabled = False
                        dr.Close()
                        RutEmpresa = txtNuevoRelevamientoRUT.Text
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

    Private Sub btnNuevoRelevamientoAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoRelevamientoGuardarRelevamiento.Click
        Dim sql As String
        Dim fecha_inicio As String
        Dim dr As Odbc.OdbcDataReader
        Dim id_relev As String

        If txtNuevoRelevamientoRUT.Text = "" Then
            MsgBox("Debe ingresar todos los datos.")
        Else
            Try
                'Seleccionamos el nombre, apellido y el usuario del prevencionista de la empresa en cuestion para verificar si la empresa tiene contratos.
                sql = "SELECT P.ci_pr as cedula, P.nom_pr as nombre, P.ape_pr as apellido, P.usr_pr as usr_pr FROM prevencionista AS P, contrata AS C, empresa AS E WHERE P.ci_pr=C.ci_pr AND C.rut=E.rut AND E.rut='" & txtNuevoRelevamientoRUT.Text & "'"
                comando.Connection = conexion
                comando.CommandText = sql
                dr = comando.ExecuteReader()
                If dr.HasRows Then
                    'Si la empresa tiene contratos, entonces...
                    MsgBox("La empresa tiene contrato con el prevencionista: " + dr("nombre") + " " + dr("apellido"))
                    If dr("usr_pr") Is DBNull.Value Then
                        'Si el campo del usr_pr es nulo entonces...
                        MsgBox("Debe asignarle un nombre de usuario al prevencionista para poder asignarle un relevamiento.")
                        dr.Close()
                    Else
                        'Si el campo del usr_pr tiene datos entonces...
                        If (dr("usr_pr")) = usuario Then
                            'Si el nombre de usuario del prevencionista de esa empresa es el mismo que esta logueado entonces...
                            CiPrevencionista = dr("cedula")
                            NombrePrevencionista = dr("nombre")
                            dr.Close()
                            Try
                                'Empezamos a ingresar los datos a la tabla relevamiento.
                                fecha_inicio = Format(dtpNuevoRelevamientoFI.Value, "MM/dd/yyyy")
                                sql = "INSERT INTO relevamiento VALUES(0,'" & fecha_inicio & "',NULL)"
                                comando.Connection = conexion
                                comando.CommandText = sql
                                comando.ExecuteNonQuery()
                                MsgBox("Relevamiento Ingresado")
                                Try
                                    'Selecciona el ultimo id de relevamiento
                                    sql = "SELECT * FROM relevamiento WHERE id_relev=(select max(id_relev) from relevamiento)"
                                    comando.Connection = conexion
                                    comando.CommandText = sql
                                    dr = comando.ExecuteReader()
                                    If dr.HasRows Then

                                        'Si encontramos el ultimo id de relevamiento entonces...
                                        'Guardamos el id del relevamiento en una variable.
                                        id_relev = dr("id_relev")
                                        dr.Close()
                                        Try
                                            sql = "INSERT INTO sobre VALUES('" & id_relev & "','" & txtNuevoRelevamientoRUT.Text & "',NULL)"
                                            comando.Connection = conexion
                                            comando.CommandText = sql
                                            comando.ExecuteNonQuery()
                                            dr.Close()
                                            Try
                                                'Ingresando en la tabla hace.
                                                sql = "INSERT INTO hace VALUES('" & id_relev & "','" & CiPrevencionista & "')"
                                                comando.Connection = conexion
                                                comando.CommandText = sql
                                                comando.ExecuteNonQuery()
                                                btnNuevoRelevamientoGuardarRelevamiento.Enabled = False
                                                dr.Close()
                                            Catch ex As Exception
                                                MsgBox("error al ingresar datos en la tabla HACE")
                                                dr.Close()
                                            End Try
                                        Catch ex As Exception
                                            MsgBox("Error el insertar datos en la tabla sobre.")
                                            dr.Close()
                                        End Try
                                    Else
                                        MsgBox("No existe un ultimo relevamiento.")
                                        dr.Close()
                                    End If
                                Catch ex As Exception
                                    MsgBox("Error al seleccionar el ultimo relevamiento")
                                    dr.Close()
                                End Try
                            Catch ex As Exception
                                MsgBox("Error al igresar datos en la tabla relevamiento.")
                                dr.Close()
                            End Try
                        Else
                            MsgBox("Usted no es el prevencionista de la empresa.")
                            dr.Close()
                        End If
                        dr.Close()
                    End If
                    dr.Close()
                Else
                    Dim result As Integer = MessageBox.Show("La empresa no tiene contrato con ningun prevencionista, desea ingresar uno?", "Mensaje", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                        RutEmpresa = txtNuevoRelevamientoRUT.Text
                        FormNuevoContrato.Show()
                        FormNuevoContrato.MdiParent = FormPrincipal
                        dr.Close()
                    End If
                    dr.Close()
                End If
            Catch ex As Exception
                MsgBox("Error al intentar verificar si la empresa tiene contratos.")
                dr.Close()
            End Try
            dr.Close()
        End If
        dr.Close()
    End Sub

    Private Sub btnNuevoRelevamientoSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoRelevamientoSalir.Click
        Me.Close()
    End Sub
End Class








































































'HIPERCODE DEVELOPINGS. ALL RIGHTS RESERVED. ™, ® & COPYRIGHT © 2019, MADE IN URUGUAY.