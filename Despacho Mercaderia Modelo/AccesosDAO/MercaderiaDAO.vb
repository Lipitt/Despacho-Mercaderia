
Imports FrameworkLipshitz

Public Class MercaderiaDAO
    Public Sub CrearMercaderia(unaMercaderia As MercaderiaDTO)
        Dim conexion As New ConexionSqlServer
        conexion.ConexionIniciar("MIPC-PC", "Trabajo Final Lipshitz")

        Dim parametros As New Dictionary(Of String, Object)
        parametros.Add("@Nombre", unaMercaderia.Nombre)
        conexion.EjecutarSinResultado("INSERT INTO MERCADERIA VALUES (@NOMBRE)", parametros)
        conexion.ConexionFinalizar()
    End Sub

    Public Function TraerMercaderia() As List(Of MercaderiaDTO)
        Dim conexion As New ConexionSqlServer
        conexion.ConexionIniciar("MIPC-PC", "Trabajo Final Lipshitz")
        Dim parametros As New Dictionary(Of String, Object)
        Dim resultado = conexion.EjecutarTupla(Of MercaderiaDTO)("SELECT * FROM MERCADERIA", parametros)
        conexion.ConexionFinalizar()
        Return resultado
    End Function
End Class
