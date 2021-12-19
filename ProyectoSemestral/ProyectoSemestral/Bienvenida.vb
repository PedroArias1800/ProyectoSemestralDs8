Public Class Bienvenida
    Private Sub Bienvenida_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.WindowState = FormWindowState.Maximized
        Me.Show()
    End Sub

    Private Sub Bienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbxInfo.Left = Me.Width / 2 - (gbxInfo.Width / 2)
        gbxInfo.Top = Me.Height / 2 - (gbxInfo.Height / 2)

        gbxInfo.BackColor = Color.FromArgb(230, 169, 169, 169)
    End Sub
End Class