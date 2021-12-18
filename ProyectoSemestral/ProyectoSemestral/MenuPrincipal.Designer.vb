<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BienvenidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CobrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BienvenidaToolStripMenuItem, Me.RegistrarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.BuscarToolStripMenuItem, Me.CobrarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1080, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BienvenidaToolStripMenuItem
        '
        Me.BienvenidaToolStripMenuItem.Name = "BienvenidaToolStripMenuItem"
        Me.BienvenidaToolStripMenuItem.Size = New System.Drawing.Size(96, 24)
        Me.BienvenidaToolStripMenuItem.Text = "Bienvenida"
        '
        'RegistrarToolStripMenuItem
        '
        Me.RegistrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuarioToolStripMenuItem, Me.ClienteToolStripMenuItem, Me.ProductoToolStripMenuItem})
        Me.RegistrarToolStripMenuItem.Name = "RegistrarToolStripMenuItem"
        Me.RegistrarToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.RegistrarToolStripMenuItem.Text = "Registrar"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.ProductoToolStripMenuItem.Text = "Producto"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuarioToolStripMenuItem1, Me.ClienteToolStripMenuItem1, Me.ProductoToolStripMenuItem1})
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'UsuarioToolStripMenuItem1
        '
        Me.UsuarioToolStripMenuItem1.Name = "UsuarioToolStripMenuItem1"
        Me.UsuarioToolStripMenuItem1.Size = New System.Drawing.Size(152, 26)
        Me.UsuarioToolStripMenuItem1.Text = "Usuario"
        '
        'ClienteToolStripMenuItem1
        '
        Me.ClienteToolStripMenuItem1.Name = "ClienteToolStripMenuItem1"
        Me.ClienteToolStripMenuItem1.Size = New System.Drawing.Size(152, 26)
        Me.ClienteToolStripMenuItem1.Text = "Cliente"
        '
        'ProductoToolStripMenuItem1
        '
        Me.ProductoToolStripMenuItem1.Name = "ProductoToolStripMenuItem1"
        Me.ProductoToolStripMenuItem1.Size = New System.Drawing.Size(152, 26)
        Me.ProductoToolStripMenuItem1.Text = "Producto"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductoToolStripMenuItem2})
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'ProductoToolStripMenuItem2
        '
        Me.ProductoToolStripMenuItem2.Name = "ProductoToolStripMenuItem2"
        Me.ProductoToolStripMenuItem2.Size = New System.Drawing.Size(152, 26)
        Me.ProductoToolStripMenuItem2.Text = "Producto"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuarioToolStripMenuItem2, Me.ClienteToolStripMenuItem2, Me.ProductoToolStripMenuItem3})
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.BuscarToolStripMenuItem.Text = "Buscar"
        '
        'UsuarioToolStripMenuItem2
        '
        Me.UsuarioToolStripMenuItem2.Name = "UsuarioToolStripMenuItem2"
        Me.UsuarioToolStripMenuItem2.Size = New System.Drawing.Size(152, 26)
        Me.UsuarioToolStripMenuItem2.Text = "Usuario"
        '
        'ClienteToolStripMenuItem2
        '
        Me.ClienteToolStripMenuItem2.Name = "ClienteToolStripMenuItem2"
        Me.ClienteToolStripMenuItem2.Size = New System.Drawing.Size(152, 26)
        Me.ClienteToolStripMenuItem2.Text = "Cliente"
        '
        'ProductoToolStripMenuItem3
        '
        Me.ProductoToolStripMenuItem3.Name = "ProductoToolStripMenuItem3"
        Me.ProductoToolStripMenuItem3.Size = New System.Drawing.Size(152, 26)
        Me.ProductoToolStripMenuItem3.Text = "Producto"
        '
        'CobrarToolStripMenuItem
        '
        Me.CobrarToolStripMenuItem.Name = "CobrarToolStripMenuItem"
        Me.CobrarToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.CobrarToolStripMenuItem.Text = "Cobrar"
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 701)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "MenuPrincipal"
        Me.Text = "Menu Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegistrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents CobrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BienvenidaToolStripMenuItem As ToolStripMenuItem
End Class
