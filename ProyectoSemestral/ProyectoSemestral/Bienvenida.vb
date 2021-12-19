Public Class Bienvenida
    Private Sub Bienvenida_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.WindowState = FormWindowState.Maximized
        Me.Show()
    End Sub

End Class