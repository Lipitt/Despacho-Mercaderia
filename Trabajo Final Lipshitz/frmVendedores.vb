Public Class frmVendedores



    Private Sub btnAceptarVendedor_Click(sender As Object, e As EventArgs) Handles btnAceptarVendedor.Click
        Dim nuevoVendedor As New Despacho_Mercaderia_Modelo.VendedoresDTO
        Dim daoVendedor As New Despacho_Mercaderia_Modelo.VendedoresDAO

        nuevoVendedor.Nombre = txtNombreVendedor.Text
        nuevoVendedor.Apellido = txtApellidoVendedor.Text
        daoVendedor.CrearVendedor(nuevoVendedor)
    End Sub

    

End Class