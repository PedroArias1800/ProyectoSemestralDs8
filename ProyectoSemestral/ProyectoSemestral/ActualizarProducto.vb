Imports System.Data.SqlClient
Public Class ActualizarProducto
    Dim nombre, precio, cantidad As String
    Private Sub ActualizarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Left = Me.Width / 2 - (Label1.Width / 2)
        GroupBox1.Left = Me.Width / 2 - (GroupBox1.Width / 2)

        nombre = txtNombre.Text
        precio = txtPrecio.Text
        cantidad = txtCantidad.Text
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        accion = "P"
        Actualizar.Close()
        Actualizar.MdiParent = MenuPrincipal
        Actualizar.WindowState = FormWindowState.Maximized
        Actualizar.Show()
    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        txtNombre.Text = nombre
        txtPrecio.Text = precio
        txtCantidad.Text = cantidad
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim glComand As New SqlCommand
        Dim dtOrdenes As New DataTable
        Dim SqlDa As SqlDataAdapter
        Dim tipo As Integer

        glComand.Connection = mYConn
        glComand.CommandText = "SP_ActualizarProducto"
        glComand.Parameters.AddWithValue("@idUsuario", txtId.Text)
        glComand.Parameters.AddWithValue("@nombreP", txtNombre.Text)
        glComand.Parameters.AddWithValue("@precioP", txtPrecio.Text)
        glComand.Parameters.AddWithValue("@cantidadU", txtCantidad.Text)
        glComand.CommandTimeout = 0
        glComand.CommandType = CommandType.StoredProcedure

        Try
            mYConn.Open()
            glComand.ExecuteNonQuery()
            SqlDa = New SqlDataAdapter(glComand)
            SqlDa.Fill(dtOrdenes)
            MsgBox("¡Producto Actualizado Exitosamente!", vbYes, "Éxito")

        Catch ex As Exception
            MsgBox("Hubo un error... inténtelo de nuevo", vbYes, "Error")
        Finally
            If mYConn.State <> ConnectionState.Closed Then
                mYConn.Close()
            End If
        End Try
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class