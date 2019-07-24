Public Class frmMenu

    Private Sub btnDespacho_Click(sender As Object, e As EventArgs) Handles btnDespacho.Click
        Dim formulario As New frmDespacho
        formulario.ShowDialog(Me)
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMercaderia_Click(sender As Object, e As EventArgs) Handles btnMercaderia.Click
        Dim formulario As New frmMercaderia
        formulario.ShowDialog(Me)
    End Sub

    Private Sub btnVendedores_Click(sender As Object, e As EventArgs) Handles btnVendedores.Click
        Dim formulario As New frmVendedores
        formulario.ShowDialog(Me)
    End Sub
End Class
