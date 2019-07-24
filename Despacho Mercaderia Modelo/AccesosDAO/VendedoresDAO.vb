
Imports FrameworkLipshitz

Public Class VendedoresDAO

    Public Sub CrearVendedor(unVendedor As VendedoresDTO)
        Dim conexion As New ConexionSqlServer
        conexion.ConexionIniciar("MIPC-PC", "Trabajo Final Lipshitz")

        Dim parametros As New Dictionary(Of String, Object)
        parametros.Add("@Nombre", unVendedor.Nombre)
        parametros.Add("@Apellido", unVendedor.Apellido)
        conexion.EjecutarSinResultado("INSERT INTO VENDEDOR VALUES (@Nombre, @Apellido)", parametros)

        conexion.ConexionFinalizar()

    End Sub

    Public Function TraerVendedores() As List(Of VendedoresDTO)
        Dim conexion As New ConexionSqlServer
        conexion.ConexionIniciar("MIPC-PC", "Trabajo Final Lipshitz")
        Dim parametros As New Dictionary(Of String, Object)
        Dim resultado = conexion.EjecutarTupla(Of VendedoresDTO)("SELECT * FROM VENDEDOR", parametros)
        conexion.ConexionFinalizar()
        Return resultado
    End Function
End Class
