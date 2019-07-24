<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMercaderia
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
        Me.txtNombreMercaderia = New System.Windows.Forms.TextBox()
        Me.btnAceptarMercaderia = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Mercaderia"
        '
        'txtNombreMercaderia
        '
        Me.txtNombreMercaderia.Location = New System.Drawing.Point(134, 19)
        Me.txtNombreMercaderia.Name = "txtNombreMercaderia"
        Me.txtNombreMercaderia.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreMercaderia.TabIndex = 1
        '
        'btnAceptarMercaderia
        '
        Me.btnAceptarMercaderia.Location = New System.Drawing.Point(197, 181)
        Me.btnAceptarMercaderia.Name = "btnAceptarMercaderia"
        Me.btnAceptarMercaderia.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptarMercaderia.TabIndex = 2
        Me.btnAceptarMercaderia.Text = "Aceptar"
        Me.btnAceptarMercaderia.UseVisualStyleBackColor = True
        '
        'frmMercaderia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnAceptarMercaderia)
        Me.Controls.Add(Me.txtNombreMercaderia)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMercaderia"
        Me.Text = "Mercaderia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombreMercaderia As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptarMercaderia As System.Windows.Forms.Button
End Class
