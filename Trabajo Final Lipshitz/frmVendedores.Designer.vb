<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendedores
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
        Me.txtNombreVendedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtApellidoVendedor = New System.Windows.Forms.TextBox()
        Me.btnAceptarVendedor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNombreVendedor
        '
        Me.txtNombreVendedor.Location = New System.Drawing.Point(109, 69)
        Me.txtNombreVendedor.Name = "txtNombreVendedor"
        Me.txtNombreVendedor.Size = New System.Drawing.Size(174, 20)
        Me.txtNombreVendedor.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apellido"
        '
        'txtApellidoVendedor
        '
        Me.txtApellidoVendedor.Location = New System.Drawing.Point(109, 109)
        Me.txtApellidoVendedor.Name = "txtApellidoVendedor"
        Me.txtApellidoVendedor.Size = New System.Drawing.Size(174, 20)
        Me.txtApellidoVendedor.TabIndex = 3
        '
        'btnAceptarVendedor
        '
        Me.btnAceptarVendedor.Location = New System.Drawing.Point(331, 199)
        Me.btnAceptarVendedor.Name = "btnAceptarVendedor"
        Me.btnAceptarVendedor.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptarVendedor.TabIndex = 4
        Me.btnAceptarVendedor.Text = "Aceptar"
        Me.btnAceptarVendedor.UseVisualStyleBackColor = True
        '
        'frmVendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 317)
        Me.Controls.Add(Me.btnAceptarVendedor)
        Me.Controls.Add(Me.txtApellidoVendedor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombreVendedor)
        Me.Name = "frmVendedores"
        Me.Text = "Vendedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombreVendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtApellidoVendedor As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptarVendedor As System.Windows.Forms.Button
End Class
