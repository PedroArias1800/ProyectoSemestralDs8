Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Left = Me.Width / 2 - (Button1.Width / 2)
        PictureBox1.Left = Me.Width / 2 - (PictureBox1.Width / 2)

        Me.BackColor = Color.FromArgb(169, 169, 169)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conexion()
            mYConn.Open()
            ' MsgBox("conexion realizada con exito", MessageBoxIcon.Information)'
            Login.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Error al realizar la conexion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If mYConn.State <> ConnectionState.Closed Then mYConn.Close()

        End Try
    End Sub
End Class
