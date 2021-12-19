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
    End Sub

    Private Sub RegistrarCliente_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Bienvenida.MdiParent = MenuPrincipal
        Bienvenida.WindowState = FormWindowState.Maximized
        Bienvenida.Show()
    End Sub

    Private Sub RegistrarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class