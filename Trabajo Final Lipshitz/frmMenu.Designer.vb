<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.btnDespacho = New System.Windows.Forms.Button()
        Me.btnMercaderia = New System.Windows.Forms.Button()
        Me.btnVendedores = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDespacho
        '
        Me.btnDespacho.Location = New System.Drawing.Point(96, 56)
        Me.btnDespacho.Name = "btnDespacho"
        Me.btnDespacho.Size = New System.Drawing.Size(120, 23)
        Me.btnDespacho.TabIndex = 0
        Me.btnDespacho.Text = "Despacho Mercaderia"
        Me.btnDespacho.UseVisualStyleBackColor = True
        '
        'btnMercaderia
        '
        Me.btnMercaderia.Location = New System.Drawing.Point(96, 97)
        Me.btnMercaderia.Name = "btnMercaderia"
        Me.btnMercaderia.Size = New System.Drawing.Size(120, 23)
        Me.btnMercaderia.TabIndex = 1
        Me.btnMercaderia.Text = "Mercaderia"
        Me.btnMercaderia.UseVisualStyleBackColor = True
        '
        'btnVendedores
        '
        Me.btnVendedores.Location = New System.Drawing.Point(96, 142)
        Me.btnVendedores.Name = "btnVendedores"
        Me.btnVendedores.Size = New System.Drawing.Size(120, 23)
        Me.btnVendedores.TabIndex = 2
        Me.btnVendedores.Text = "Vendedores"
        Me.btnVendedores.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnVendedores)
        Me.Controls.Add(Me.btnMercaderia)
        Me.Controls.Add(Me.btnDespacho)
        Me.Name = "frmMenu"
        Me.Text = "Menu Principal"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDespacho As System.Windows.Forms.Button
    Friend WithEvents btnMercaderia As System.Windows.Forms.Button
    Friend WithEvents btnVendedores As System.Windows.Forms.Button

End Class
