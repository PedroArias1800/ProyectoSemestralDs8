Imports System.Data.SqlClient
Public Class RegistrarProducto
    Private Sub btnRegistrarProducto_Click(sender As Object, e As EventArgs) Handles btnRegistrarProducto.Click
        Dim glComand As New SqlCommand

        Dim nombre As String
        Dim precio, cantidad As Integer

        nombre = txtNombre.Text
        cantidad = txtCantidad.Text

        If nombre <> "" And precio <> 0 And cantidad <> 0 Then

            glComand.Connection = mYConn
            glComand.CommandText = "SP_RegistrarCliente"
            glComand.Parameters.AddWithValue("@nombreP", nombre)
            glComand.Parameters.AddWithValue("@precioP", precio)
            glComand.Parameters.AddWithValue("@cantidadP", cantidad)
            glComand.CommandTimeout = 0
            glComand.CommandType = CommandType.StoredProcedure

            Try
                mYConn.Open()
                glComand.ExecuteNonQuery()
                MsgBox("Cliente registrado exitosamente", vbYes, "Exito")

                txtNombre.Text = ""
                txtPrecio.Text = ""
                txtCantidad.Text = ""

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
End Class