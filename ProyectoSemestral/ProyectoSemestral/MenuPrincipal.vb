Public Class MenuPrincipal

    Private Sub MenuPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        tipo = 0
        Application.Exit()
    End Sub


    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackgroundImage = Image.FromFile("..\..\Resources\verdeCompleto.jpg")

        Me.WindowState = FormWindowState.Maximized
        MenuStrip1.ForeColor = Color.FromArgb(230, 255, 255, 255)

        If tipo = 1 Then
            Bienvenida.txtBienvenida.Text = "Bienvenido Administrador " & nombreCompleto
        ElseIf tipo = 2 Then
            Bienvenida.txtBienvenida.Text = "Bienvenido Cajero " & nombreCompleto
            'Ocultando opciones de usuarios
            AdministracionToolStripMenuItem.Visible = False
            ReporteToolStripMenuItem.Visible = False

            'Ocultando opciones de inventario
            InventarioToolStripMenuItem.Visible = False

        ElseIf tipo = 3 Then
            Bienvenida.txtBienvenida.Text = "Bienvenido Personal De Inventario " & nombreCompleto

            'Ocultando opciones de usuarios
            AdministracionToolStripMenuItem.Visible = False
            ReporteToolStripMenuItem.Visible = False

            'Ocultando opciones de cajero
            FacturacionToolStripMenuItem.Visible = False
            ClientesToolStripMenuItem.Visible = False

        Else
            tipo = 0
            nombreCompleto = ""
            idUsuario = 0
            MsgBox("Vuelva a iniciar sesión nuevamente...", vbYes, "Ha ocurrido un error")
        End If
        ItemSesion.Text = nombreCompleto
        Bienvenida.horaSistema.Text = "Hora del sistema: " & Now
        BienvenidaToolStripMenuItem.Visible = False
        Bienvenida.MdiParent = Me
        Bienvenida.WindowState = FormWindowState.Maximized
        Bienvenida.Show()

    End Sub

    'Registrar Usuario
    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearUsuarioToolStripMenuItem.Click
        RegistrarUsuario.MdiParent = Me
        RegistrarUsuario.WindowState = FormWindowState.Maximized
        RegistrarUsuario.Show()
    End Sub

    'Facturar - Cobrar
    Private Sub CobrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CobrarToolStripMenuItem1.Click
        accion = "CC"
        Actualizar.Close()
        Actualizar.MdiParent = Me
        Actualizar.WindowState = FormWindowState.Maximized
        Actualizar.Show()
    End Sub

    'Buscar Usuario
    Private Sub CrearClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearClienteToolStripMenuItem2.Click
        RegistrarCliente.MdiParent = Me
        RegistrarCliente.WindowState = FormWindowState.Maximized
        RegistrarCliente.Show()
    End Sub

    'Actualizar Cliente
    Private Sub ClienteToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        accion = "C"
        Actualizar.Close()
        Actualizar.MdiParent = Me
        Actualizar.WindowState = FormWindowState.Maximized
        Actualizar.Show()
    End Sub

    'Actualizar Usuario
    Private Sub ActualizarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarUsuarioToolStripMenuItem.Click
        accion = "U"
        Actualizar.Close()
        Actualizar.MdiParent = Me
        Actualizar.WindowState = FormWindowState.Maximized
        Actualizar.Show()

    End Sub

    'Crear Producto
    Private Sub CrearProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearProductoToolStripMenuItem2.Click
        RegistrarProducto.MdiParent = Me
        RegistrarProducto.WindowState = FormWindowState.Maximized
        RegistrarProducto.Show()
    End Sub

    'Cerrar Sesión
    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        'idUsuario = 0
        'tipo = 0
        'nombreCompleto = ""
        'Me.Close()
        'Login.txtEmail.Text = ""
        'Login.txtPassword.Text = ""
        'Login.Show()
        'MenuPrincipal.Hide()
        Application.Restart()
    End Sub

    'Actualizar Producto
    Private Sub ActualizarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarProductoToolStripMenuItem.Click
        accion = "P"
        Actualizar.Close()
        Actualizar.MdiParent = Me
        Actualizar.WindowState = FormWindowState.Maximized
        Actualizar.Show()
    End Sub

    'Eliminar Producto
    Private Sub EliminarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarProductoToolStripMenuItem.Click
        accion = "E"
        Actualizar.Close()
        Actualizar.MdiParent = Me
        Actualizar.WindowState = FormWindowState.Maximized
        Actualizar.Show()
    End Sub

    'Actualizar Cliente
    Private Sub ActualizarClienteToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ActualizarClienteToolStripMenuItem2.Click
        accion = "C"
        Actualizar.Close()
        Actualizar.MdiParent = Me
        Actualizar.WindowState = FormWindowState.Maximized
        Actualizar.Show()
    End Sub

    'Reporte
    Private Sub ReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteToolStripMenuItem.Click
        Reporte.MdiParent = Me
        Reporte.WindowState = FormWindowState.Maximized
        Reporte.Show()
    End Sub

End Class