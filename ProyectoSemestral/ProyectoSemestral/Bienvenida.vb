Public Class Bienvenida
    Private Sub Bienvenida_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.WindowState = FormWindowState.Maximized
        Me.Show()
    End Sub

    'Cerrar la sesión
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
End Class