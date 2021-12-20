Public Class Form1

    'Universidad Tecnológica De Panamá
    'Facultad De Ingeniería En Sistema Computacionales
    'Licenciatura En Desarrollo De Software
    'Proyecto Semestral De Desarrollo De Software VIII
    '
    'Integrantes:
    'Alvarado Jordan / 8-954-1826
    'Arias Pedro / 8-961-780
    'Gómez Daniel / E-8-164026
    'Morales Aurelio / 8-944-1505
    '
    'Docente:
    'José Javier Chirú
    '
    'Grupo: 1LS132
    '
    'Fecha De Entrega
    '20/12/2021

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
