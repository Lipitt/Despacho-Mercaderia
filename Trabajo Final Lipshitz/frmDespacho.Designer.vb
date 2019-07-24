<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDespacho
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtZona = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBolsa = New System.Windows.Forms.TextBox()
        Me.cboVendedor = New System.Windows.Forms.ComboBox()
        Me.lstDespacho = New System.Windows.Forms.ListBox()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.cboMercaderia = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Zona"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(469, 429)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtZona
        '
        Me.txtZona.Location = New System.Drawing.Point(153, 52)
        Me.txtZona.Name = "txtZona"
        Me.txtZona.Size = New System.Drawing.Size(156, 20)
        Me.txtZona.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Vendedor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Numero Bolsa"
        '
        'txtBolsa
        '
        Me.txtBolsa.Location = New System.Drawing.Point(153, 19)
        Me.txtBolsa.Name = "txtBolsa"
        Me.txtBolsa.Size = New System.Drawing.Size(156, 20)
        Me.txtBolsa.TabIndex = 6
        '
        'cboVendedor
        '
        Me.cboVendedor.FormattingEnabled = True
        Me.cboVendedor.Location = New System.Drawing.Point(153, 86)
        Me.cboVendedor.Name = "cboVendedor"
        Me.cboVendedor.Size = New System.Drawing.Size(156, 21)
        Me.cboVendedor.TabIndex = 7
        '
        'lstDespacho
        '
        Me.lstDespacho.FormattingEnabled = True
        Me.lstDespacho.Location = New System.Drawing.Point(26, 170)
        Me.lstDespacho.Name = "lstDespacho"
        Me.lstDespacho.Size = New System.Drawing.Size(440, 238)
        Me.lstDespacho.TabIndex = 8
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(391, 130)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(75, 23)
        Me.btnCargar.TabIndex = 9
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'cboMercaderia
        '
        Me.cboMercaderia.FormattingEnabled = True
        Me.cboMercaderia.Location = New System.Drawing.Point(153, 130)
        Me.cboMercaderia.Name = "cboMercaderia"
        Me.cboMercaderia.Size = New System.Drawing.Size(156, 21)
        Me.cboMercaderia.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Mercaderia"
        '
        'btnExportar
        '
        Me.btnExportar.Location = New System.Drawing.Point(469, 458)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(75, 23)
        Me.btnExportar.TabIndex = 12
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'frmDespacho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 500)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboMercaderia)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.lstDespacho)
        Me.Controls.Add(Me.cboVendedor)
        Me.Controls.Add(Me.txtBolsa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtZona)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDespacho"
        Me.Text = "Despacho Mercaderia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtZona As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBolsa As System.Windows.Forms.TextBox
    Friend WithEvents cboVendedor As System.Windows.Forms.ComboBox
    Friend WithEvents lstDespacho As System.Windows.Forms.ListBox
    Friend WithEvents btnCargar As System.Windows.Forms.Button
    Friend WithEvents cboMercaderia As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnExportar As System.Windows.Forms.Button
End Class
