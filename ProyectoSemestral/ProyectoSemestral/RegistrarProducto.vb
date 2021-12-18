Imports System.Data.SqlClient
Public Class RegistrarProducto
    Private Sub btnRegistrarProducto_Click(sender As Object, e As EventArgs) Handles btnRegistrarProducto.Click
        Dim glComand As New SqlCommand

        Dim nombre As String
        Dim precio As Double
        Dim cantidad As Integer

        If txtNombre.Text <> "" And txtPrecio.Text <> "" And txtCantidad.Text <> "" Then

            nombre = txtNombre.Text
            precio = txtPrecio.Text
            cantidad = txtCantidad.Text

            If precio < 0 Then
                MsgBox("El precio de ser mayor que cero. Precio= " & precio, vbYes, "Error")
            ElseIf cantidad < 0 Then
                MsgBox("Debe ingresar una cantidad mayor a cero.", vbYes, "Error")
            Else
                glComand.Connection = mYConn
                glComand.CommandText = "SP_RegistrarProducto"
                glComand.Parameters.AddWithValue("@nombreP", nombre)
                glComand.Parameters.AddWithValue("@precioP", precio)
                glComand.Parameters.AddWithValue("@cantidadP", cantidad)
                glComand.CommandTimeout = 0
                glComand.CommandType = CommandType.StoredProcedure

                Try
                    mYConn.Open()
                    glComand.ExecuteNonQuery()
                    MsgBox("Producto registrado exitosamente", vbYes, "Exito")

                    txtNombre.Text = ""
                    txtPrecio.Text = ""
                    txtCantidad.Text = ""

                Catch ex As Exception
                    MsgBox("No se pudo registrar al producto, vuelva a intentarlo
                        Error:" & ex.Message, vbYes, "Error")
                Finally
                    If mYConn.State <> ConnectionState.Closed Then
                        mYConn.Close()
                    End If
                End Try
            End If
        Else
            MsgBox("Debe llenar todos los campos.", vbYes, "Error")
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) And e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso
            Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub RegistrarProducto_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Bienvenida.MdiParent = Me
        Bienvenida.WindowState = FormWindowState.Maximized
        Bienvenida.Show()
    End Sub
End Class