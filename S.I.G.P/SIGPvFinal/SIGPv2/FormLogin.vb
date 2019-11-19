Public Class FormLogin

    Private Sub btnLoginIniciarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoginIniciarSesion.Click
        usuario = txtLoginUsuario.Text
        pass = txtLoginPass.Text
        conectar()
        If conexion.State = 1 Then
            permisos(txtLoginUsuario.Text)
        End If
    End Sub

    Private Sub FormLogin_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        conexion = Nothing
        FormPrincipal.Close()
        Me.Close()
    End Sub

    Private Sub limpiar()
        txtLoginUsuario.Clear()
        txtLoginPass.Clear()
    End Sub

    Private Sub FormLogin_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        limpiar()
    End Sub

    Private Sub btnLoginSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoginSalir.Click
        FormPrincipal.Close()
    End Sub

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MaximizeBox = False
        MinimizeBox = False
        Español()
    End Sub

    Private Sub Ingles()
        lblUsuario.Text = "USER:"
        lblContraseña.Text = "PASSWORD:"
        btnLoginIniciarSesion.Text = "lOGIN"
        btnLoginSalir.Text = "EXIT"
        lblLogin_SelecionarIdioma.Text = "SELECT LANGUAGE:"
        idioma_actual = "Inglés"
        cboLogin_Idioma.Items.Clear()
        cboLogin_Idioma.Items.Add("Spanish")
    End Sub

    Private Sub Español()
        lblUsuario.Text = "USUARIO:"
        lblContraseña.Text = "CONTRASEÑA:"
        btnLoginIniciarSesion.Text = "INICIAR SESION"
        btnLoginSalir.Text = "SALIR"
        lblLogin_SelecionarIdioma.Text = "SELECCIONAR IDIOMA:"
        idioma_actual = "Español"
        cboLogin_Idioma.Items.Clear()
        cboLogin_Idioma.Items.Add("Inglés")
    End Sub

    Private Sub cboLogin_Idioma_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLogin_Idioma.TextChanged
        If cboLogin_Idioma.Text = "Inglés" Then
            Ingles()
        ElseIf cboLogin_Idioma.Text = "Spanish" Then
            Español()
        End If
    End Sub

    Private Sub lblLogin_SelecionarIdioma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLogin_SelecionarIdioma.Click

    End Sub
End Class








































































'HIPERCODE DEVELOPINGS. ALL RIGHTS RESERVED. ™, ® & COPYRIGHT © 2019, MADE IN URUGUAY.