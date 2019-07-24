Imports FrameworkLipshitz

Public Class DespachoDAO

    Public Function TraerDespachos() As List(Of DespachoDTO)
        Dim conexion As New ConexionSqlServer
        conexion.ConexionIniciar("MIPC-PC", "Trabajo Final Lipshitz")
        Dim parametros As New Dictionary(Of String, Object)
        Dim resultado = conexion.EjecutarTupla(Of DespachoDTO)("SELECT * FROM DESPACHOMERCADERIA", parametros)
        conexion.ConexionFinalizar()
        Return resultado
    End Function








    Public Sub CrearDespacho(unDespacho As DespachoDTO, listadoBolsa As List(Of ContenidoBolsaDTO))
        Dim conexion As New ConexionSqlServer

        conexion.ConexionIniciar("MIPC-PC", "Trabajo Final Lipshitz")
        conexion.TransaccionIniciar()
        Try


            Dim parametros As New Dictionary(Of String, Object)
            parametros.Add("@Zona", unDespacho.Zona)
            parametros.Add("@IdVendedor", unDespacho.IdVendedor)
            parametros.Add("@NumeroBolsa", unDespacho.NumeroBolsa)


            conexion.EjecutarSinResultado("INSERT INTO DESPACHOMERCADERIA VALUES (@Zona, @IdVendedor, @NumeroBolsa)", parametros)

            Dim IdDespachoCreado As Integer = conexion.EjecutarEscalar("Select Max(IdDespacho) from DESPACHOMERCADERIA", New Dictionary(Of String, Object))

            For Each item In listadoBolsa
                Dim parametrosDespacho As New Dictionary(Of String, Object)
                parametrosDespacho.Add("@IdDespacho", IdDespachoCreado)
                parametrosDespacho.Add("@IdMercaderia", item.IdMercaderia)


                conexion.EjecutarSinResultado("INSERT INTO CONTENIDOBOLSA VALUES (@IdDespacho, @IdMercaderia)", parametrosDespacho)
            Next
            conexion.TransaccionAceptar()

        Catch ex As Exception

            conexion.TransaccionCancelar()
            MsgBox(ex.Message)
        Finally

            conexion.ConexionFinalizar()
        End Try
    End Sub
End Class
