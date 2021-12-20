Imports System.Data.SqlClient
Public Class RegistrarCliente
    Private Sub btnRegistrarCliente_Click(sender As Object, e As EventArgs) Handles btnRegistrarCliente.Click
        Dim glComand As New SqlCommand

        Dim nombre, apellido, cedula

        nombre = txtNombre.Text
        apellido = txtApellido.Text
        cedula = txtCedula.Text

        If nombre <> "" And apellido <> "" And cedula <> "" Then

            glComand.Connection = mYConn
            glComand.CommandText = "SP_RegistrarCliente"
            glComand.Parameters.AddWithValue("@nombreC", nombre)
            glComand.Parameters.AddWithValue("@apellidoC", apellido)
            glComand.Parameters.AddWithValue("@cedulaC", cedula)
            glComand.CommandTimeout = 0
            glComand.CommandType = CommandType.StoredProcedure

            Try
                mYConn.Open()
                glComand.ExecuteNonQuery()
                MsgBox("Cliente registrado exitosamente", vbYes, "Exito")

                txtNombre.Text = ""
                txtApellido.Text = ""
                txtCedula.Text = ""

            Catch ex As Exception
                MsgBox("No se pudo registrar al cliente, vuelva a intentarlo
                            Error:" & ex.Message, vbYes, "Error")
            Finally
                If mYConn.State <> ConnectionState.Closed Then
                    mYConn.Close()
                End If
            End Try
        Else
            MsgBox("Debe llenar todos los campos", vbYes, "Error")
        End If

        If cobrar2 = "Si" Then
            cobrar2 = "No"
            accion = "CC"
            Me.Close()
            Actualizar.Close()
            Actualizar.MdiParent = MenuPrincipal
            Actualizar.WindowState = FormWindowState.Maximized
            Actualizar.Show()
        End If
    End Sub

    Private Sub RegistrarCliente_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Bienvenida.MdiParent = MenuPrincipal
        Bienvenida.WindowState = FormWindowState.Maximized
        Bienvenida.Show()
    End Sub

    Private Sub RegistrarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Top = Me.Height / 6 - (Label1.Height / 2)
        GroupBox1.Top = Me.Height / 2.5 - (GroupBox1.Height / 2)
        btnRegistrarCliente.Top = Me.Height / 1.4 - (btnRegistrarCliente.Height / 2)

        Label1.Left = Me.Width / 2 - (Label1.Width / 2)
        GroupBox1.Left = Me.Width / 2 - (GroupBox1.Width / 2)
        btnRegistrarCliente.Left = Me.Width / 2 - (btnRegistrarCliente.Width / 2)

        Label1.BackColor = Color.FromArgb(230, 64, 64, 64)
        GroupBox1.BackColor = Color.FromArgb(230, 64, 64, 64)
        btnRegistrarCliente.BackColor = Color.FromArgb(230, 64, 64, 64)

        Me.BackgroundImage = Image.FromFile("..\..\Resources\verdeCompleto.jpg")

    End Sub

End Class