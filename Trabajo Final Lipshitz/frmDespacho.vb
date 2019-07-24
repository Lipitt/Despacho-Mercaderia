Imports Despacho_Mercaderia_Modelo
Imports System.IO

Public Class frmDespacho


    Dim unDespacho As New DespachoDTO
    Private serializador As New FrameworkLipshitz.SerializadorXmlComplejo
    Private listadoBolsa As New List(Of ContenidoBolsaDTO)
    Private Sub frmDespacho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()

        Dim fsw As New FileSystemWatcher
        fsw.Path = "D:\Despachos\"
        fsw.Filter = "*.xml"
        fsw.IncludeSubdirectories = False
        fsw.NotifyFilter = NotifyFilters.LastWrite
        AddHandler fsw.Changed, AddressOf fsw_Modificado
        fsw.EnableRaisingEvents = True

    End Sub

    Private Sub CargarCombos()
        Dim daoVendedor As New VendedoresDAO
        cboVendedor.DataSource = Nothing
        cboVendedor.DisplayMember = "Apellido"
        cboVendedor.ValueMember = "IdVendedor"
        cboVendedor.DataSource = daoVendedor.TraerVendedores

        Dim daoMercaderia As New MercaderiaDAO
        cboMercaderia.DataSource = Nothing
        cboMercaderia.DisplayMember = "Nombre"
        cboMercaderia.ValueMember = "IdMercaderia"
        cboMercaderia.DataSource = daoMercaderia.TraerMercaderia

    End Sub




    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        FrameworkLipshitz.ExpresionesRegular.ValidarStringRegex.CadenaSoloNumero(txtBolsa.Text)
        Dim nuevoContenido As New ContenidoBolsaDTO
        nuevoContenido.IdMercaderia = cboMercaderia.SelectedValue
        listadoBolsa.Add(nuevoContenido)
        lstDespacho.Items.Add(cboMercaderia.SelectedValue)


    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click







        Dim Despachodao As New DespachoDAO

        unDespacho.NumeroBolsa = txtBolsa.Text
        unDespacho.Zona = txtZona.Text
        unDespacho.IdVendedor = cboVendedor.SelectedValue

        Despachodao.CrearDespacho(unDespacho, listadoBolsa)
        FrameworkLipshitz.EventViewer.GenerarLog.LogInfomacion("Trabajo Final Lipshitz", "Se ha creado un despacho")
        MsgBox("Despacho Creado!")
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click



        Dim reporte As New reporteDespacho



        Dim listaFiltrada = (From AA In reporte.reporteDespacho
                             Where AA.IdMercaderia = 1
                             Select AA).ToList()

        'vuelvo a serializar
        Dim reporteFiltrado As New reporteDespacho
        reporteFiltrado.reporteDespacho = listaFiltrada
        Dim resultado = serializador.Serializar(reporteFiltrado)

        FrameworkLipshitz.Sistema.Archivos.CrearArchivo("D:\Despachos\DespachosZona2.xml", resultado)


        'Dim nuevoDespacho As New DespachoDAO
        'Dim despachosTraidos = nuevoDespacho.TraerDespachos()



        'Dim consultaDespacho = (From aa In despachosTraidos
        '                Where aa.Zona = 2
        '                Select aa).ToList()




        'Dim despachoSerializado = serializador.Serializar(consultaDespacho)
        'FrameworkLipshitz.Sistema.Archivos.CrearArchivo("D:\DespachosZona2.xml", despachoSerializado)


        'MsgBox("Exportado con exito!")

    End Sub

 

    Private Sub fsw_Modificado(sender As Object, e As FileSystemEventArgs)
        MsgBox("Se ha creado un nuevo archivo", MsgBoxStyle.Information)
    End Sub

End Class
Public Class reporteDespacho
    Property reporteDespacho As New List(Of ContenidoBolsaDTO)
End Class