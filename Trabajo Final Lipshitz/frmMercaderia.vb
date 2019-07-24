Public Class frmMercaderia

    Private Sub btnAceptarMercaderia_Click(sender As Object, e As EventArgs) Handles btnAceptarMercaderia.Click
        Dim nuevaMercaderia As New Despacho_Mercaderia_Modelo.MercaderiaDTO
        nuevaMercaderia.Nombre = txtNombreMercaderia.Text
        Dim daoMercaderia As New Despacho_Mercaderia_Modelo.MercaderiaDAO
        daoMercaderia.CrearMercaderia(nuevaMercaderia)
    End Sub
End Class