Public Class FormManual

    Private Sub Manual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        MaximizeBox = False
        MinimizeBox = False
    End Sub

    Private Sub btnInspeccionSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManualSalir.Click
        Me.Close()
    End Sub
End Class