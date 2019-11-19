Imports System.Data.Odbc
Public Class FormEmpresa

    Private Sub FormEmpresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        MaximizeBox = False
        MinimizeBox = False
        txtEmpresaRut.Text = RutEmpresa
        txtEmpresaRSocial.Enabled = False
        txtEmpresaRubro.Enabled = False
        txtEmpresaTelefono.Enabled = False
        txtEmpresaMail.Enabled = False
        txtEmpresaDepartamento.Enabled = False
        txtEmpresaDireccion.Enabled = False
        btnEmpresaNuevoTrabajador.Enabled = False
        btnEmpresaGuardar.Enabled = False
        btnEmpresaVolver.Visible = False
        If txtEmpresaRut.Text <> "" Then
            txtEmpresaRSocial.Enabled = True
            txtEmpresaRubro.Enabled = True
            txtEmpresaTelefono.Enabled = True
            txtEmpresaMail.Enabled = True
            txtEmpresaDireccion.Enabled = True
            txtEmpresaDepartamento.Enabled = True
            btnEmpresaGuardar.Enabled = True
            btnEmpresaSalir.Visible = False
            btnEmpresaVolver.Visible = True
        End If
    End Sub

    Private Sub btnEmpresaNuevoTrabajador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpresaNuevoTrabajador.Click
        If txtEmpresaRut.Text = "" Then
            MsgBox("Debe ingresar el RUT de la empresa")
        Else
            RutEmpresa = txtEmpresaRut.Text
            RSEmpresa = txtEmpresaRSocial.Text
            FormNuevoTrabajador.MdiParent = FormPrincipal
            FormNuevoTrabajador.Show()
        End If
    End Sub

    Private Sub btnEmpresaGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpresaGuardar.Click
        Dim sql As String
        Dim dirDep As String

        If txtEmpresaRut.Text = "" Or txtEmpresaRSocial.Text = "" Or txtEmpresaRubro.Text = "" Or txtEmpresaTelefono.Text = "" Or txtEmpresaMail.Text = "" Or txtEmpresaDepartamento.Text = "" Or txtEmpresaDireccion.Text = "" Then
            MsgBox("Asegurese de ingresar todos los datos!")
        Else
            Try
                dirDep = txtEmpresaDireccion.Text + ", " + txtEmpresaDepartamento.Text
                sql = "INSERT INTO empresa VALUES('" & txtEmpresaRut.Text & "','" & txtEmpresaRSocial.Text & "','" & txtEmpresaRubro.Text & "','" & txtEmpresaTelefono.Text & "','" & txtEmpresaMail.Text & "','" & dirDep & "')"
                comando.Connection = conexion
                comando.CommandText = sql
                comando.ExecuteNonQuery()
                MsgBox("Ingresado")
                txtEmpresaRSocial.Enabled = False
                txtEmpresaRubro.Enabled = False
                txtEmpresaTelefono.Enabled = False
                txtEmpresaMail.Enabled = False
                txtEmpresaDepartamento.Enabled = False
                txtEmpresaDireccion.Enabled = False
                btnEmpresaNuevoTrabajador.Enabled = True
                btnEmpresaGuardar.Enabled = False
            Catch ex As Exception
                MsgBox("Error al ingresar datos")
            End Try
        End If
    End Sub

    Private Sub btnEmpresaLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpresaLimpiar.Click
        txtEmpresaRut.Clear()
        txtEmpresaRSocial.Clear()
        txtEmpresaRubro.Clear()
        txtEmpresaTelefono.Clear()
        txtEmpresaMail.Clear()
        txtEmpresaDepartamento.Clear()
        txtEmpresaDireccion.Clear()
    End Sub

    Private Sub btnEmpresaBuscarEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpresaBuscarEmpresa.Click
        Dim dr As Odbc.OdbcDataReader
        Dim sql As String
        If txtEmpresaRut.Text = "" Then
            MsgBox("Debe ingresar el RUT.")
        Else
            If IsNumeric(txtEmpresaRut.Text) Then
                Try
                    sql = "SELECT * FROM empresa WHERE rut='" & txtEmpresaRut.Text & "'"
                    comando.Connection = conexion
                    comando.CommandText = sql
                    dr = comando.ExecuteReader()
                    If dr.HasRows Then
                        MsgBox("La empresa existe.")
                        txtEmpresaRSocial.Enabled = False
                        txtEmpresaRubro.Enabled = False
                        txtEmpresaTelefono.Enabled = False
                        txtEmpresaMail.Enabled = False
                        txtEmpresaDepartamento.Enabled = False
                        txtEmpresaDireccion.Enabled = False
                        btnEmpresaNuevoTrabajador.Enabled = True
                        btnEmpresaGuardar.Enabled = False
                        txtEmpresaRSocial.Text = dr("razon_social")
                        txtEmpresaRubro.Text = dr("rubro")
                        txtEmpresaTelefono.Text = dr("telefono")
                        txtEmpresaMail.Text = dr("mail")
                        txtEmpresaDireccion.Text = dr("direccion")
                        lblEmpresaDepartamento.Visible = False
                        txtEmpresaDepartamento.Visible = False
                        dr.Close()
                    Else
                        MsgBox("Empresa no ingresada aun.")
                        txtEmpresaRSocial.Clear()
                        txtEmpresaRubro.Clear()
                        txtEmpresaTelefono.Clear()
                        txtEmpresaMail.Clear()
                        txtEmpresaDepartamento.Clear()
                        txtEmpresaDireccion.Clear()
                        txtEmpresaRSocial.Enabled = True
                        txtEmpresaRubro.Enabled = True
                        txtEmpresaTelefono.Enabled = True
                        txtEmpresaMail.Enabled = True
                        txtEmpresaDepartamento.Enabled = True
                        txtEmpresaDireccion.Enabled = True
                        btnEmpresaNuevoTrabajador.Enabled = False
                        btnEmpresaGuardar.Enabled = True
                        lblEmpresaDepartamento.Visible = True
                        txtEmpresaDepartamento.Visible = True
                        dr.Close()
                    End If
                    dr.Close()
                Catch ex As Exception
                    MsgBox("Error.")
                    dr.Close()
                End Try
            Else
                MsgBox("El rut debe contener solamente numeros.")
            End If
        End If
    End Sub

    Private Sub btnEmpresaSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpresaSalir.Click
        Me.Close()
    End Sub

    Private Sub btnEmpresaVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpresaVolver.Click
        Me.Close()
    End Sub
End Class








































































'HIPERCODE DEVELOPINGS. ALL RIGHTS RESERVED. ™, ® & COPYRIGHT © 2019, MADE IN URUGUAY.