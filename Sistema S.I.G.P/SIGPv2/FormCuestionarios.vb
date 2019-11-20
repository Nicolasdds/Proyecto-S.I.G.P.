Public Class FormCuestionarios

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionariosAceptar.Click
        Dim eleccion As String
        eleccion = Trim(Me.cboCuestionarios.Text)
        If eleccion = "Lugares de trabajo" Then
            FormCuestionarioLugaresDeTrabajo.Show()
            FormCuestionarioLugaresDeTrabajo.MdiParent = FormPrincipal
        End If
        Me.Close()
    End Sub

    Private Sub FormCuestionarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        MaximizeBox = False
        MinimizeBox = False
    End Sub
    Private Sub btnCuestionariosSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionariosSalir.Click
        Me.Close()
    End Sub
End Class








































































'HIPERCODE DEVELOPINGS. ALL RIGHTS RESERVED. ™, ® & COPYRIGHT © 2019, MADE IN URUGUAY.