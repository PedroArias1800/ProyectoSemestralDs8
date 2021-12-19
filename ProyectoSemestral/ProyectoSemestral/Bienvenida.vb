Public Class Bienvenida
    Private Sub Bienvenida_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.MdiParent = MenuPrincipal
        Me.WindowState = FormWindowState.Maximized
        Me.Show()
    End Sub

    Private Sub Bienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbxInfo.Left = Me.Width / 2 - (gbxInfo.Width / 2)
        gbxInfo.Top = Me.Height / 2 - (gbxInfo.Height / 1.5)

        gbxInfo.BackColor = Color.FromArgb(230, 64, 64, 64)
    End Sub
End Class