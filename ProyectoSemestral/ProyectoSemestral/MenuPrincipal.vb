Public Class MenuPrincipal

    Private Sub MenuPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        tipo = 0
        Application.Exit()
    End Sub
    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If tipo = 1 Then
            txtBienvenida.Text = "Bienvenido Administrador " & nombreCompleto
        ElseIf tipo = 2 Then
            txtBienvenida.Text = "Bienvenido Cajero " & nombreCompleto
            'Ocultando opciones de usuarios
            UsuarioToolStripMenuItem.Visible = False
            UsuarioToolStripMenuItem1.Visible = False
            UsuarioToolStripMenuItem2.Visible = False

            'Ocultando opciones de productos
            ProductoToolStripMenuItem.Visible = False
            ProductoToolStripMenuItem1.Visible = False
            ProductoToolStripMenuItem2.Visible = False
            ProductoToolStripMenuItem3.Visible = False

            'Ocultando lo de eliminar
            EliminarToolStripMenuItem.Visible = False

        ElseIf tipo = 3 Then
            txtBienvenida.Text = "Bienvenido Personal De Inventario " & nombreCompleto
            'Ocultando opciones de usuarios
            UsuarioToolStripMenuItem.Visible = False
            UsuarioToolStripMenuItem1.Visible = False
            UsuarioToolStripMenuItem2.Visible = False

            'Ocultando opciones de cliente
            ClienteToolStripMenuItem.Visible = False
            ClienteToolStripMenuItem1.Visible = False
            ClienteToolStripMenuItem2.Visible = False

            'Ocultando lo de cobrar
            CobrarToolStripMenuItem.Visible = False

        Else
            tipo = 0
            nombreCompleto = ""
            idUsuario = 0
            MsgBox("Vuelva a iniciar sesión nuevamente...", vbYes, "Ha ocurrido un error")
        End If
    End Sub

    'Registrar Usuario
    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem.Click
        RegistrarUsuario.MdiParent = Me
        RegistrarUsuario.WindowState = FormWindowState.Maximized
        RegistrarUsuario.Show()
    End Sub

    'Actualizar Usuario
    Private Sub UsuarioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem1.Click

    End Sub

    'Buscar Usuario
    Private Sub UsuarioToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem2.Click

    End Sub

    'Cerrar la sesión
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        idUsuario = 0
        tipo = 0
        nombreCompleto = ""
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        RegistrarCliente.MdiParent = Me
        RegistrarCliente.WindowState = FormWindowState.Maximized
        RegistrarCliente.Show()
    End Sub

    Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem.Click
        RegistrarProducto.MdiParent = Me
        RegistrarProducto.WindowState = FormWindowState.Maximized
        RegistrarProducto.Show()
    End Sub
End Class