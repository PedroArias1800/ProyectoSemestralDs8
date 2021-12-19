Imports System.Data.SqlClient

Public Class Actualizar
    Private Sub Actualizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Escribiendo textos
        If accion = "U" Then
            Label1.Text = "Actualizar Usuarios"
            Label2.Text = "Seleccione un usuario de la lista"
        ElseIf accion = "C" Then
            Label1.Text = "Actualizar Clientes"
            Label2.Text = "Seleccione un cliente de la lista"
        ElseIf accion = "P" Then
            Label1.Text = "Actualizar Productos"
            Label2.Text = "Seleccione un producto de la lista"
        ElseIf accion = "E" Then
            Label1.Text = "Eliminar Productos"
            Label2.Text = "Seleccione un producto de la lista"

        Else
            MsgBox("Ha ocurrido un error inesperado...", vbYes, "Error")
            MenuPrincipal.Show()
            Me.Hide()
        End If

        'Centrando elementos
        Label1.Left = Me.Width / 2 - (Label1.Width / 2)
        GroupBox1.Left = Me.Width / 2 - (GroupBox1.Width / 2)

        Dim glComand As New SqlCommand
        Dim dtOrdenes As New DataTable
        Dim SqlDa As SqlDataAdapter

        glComand.Connection = mYConn
        If accion = "U" Then
            glComand.CommandText = "SP_BuscarUsuario"
        ElseIf accion = "C" Then
            glComand.CommandText = "SP_BuscarCliente"
        ElseIf accion = "P" Then
            glComand.CommandText = "SP_BuscarProductos"

        ElseIf accion = "E" Then
            glComand.CommandText = "SP_BuscarProductos"

        End If
        glComand.CommandTimeout = 0
        glComand.CommandType = CommandType.StoredProcedure

        Try
            mYConn.Open()
            glComand.ExecuteNonQuery()
            SqlDa = New SqlDataAdapter(glComand)
            SqlDa.Fill(dtOrdenes)

            If dtOrdenes.Rows.Count <> 0 Then
                dtg1.DataSource = dtOrdenes

                If accion = "P" Or accion = "E" Then
                    For x = 0 To dtOrdenes.Rows.Count - 1
                        dtg1.Item(2, x).Value = FormatNumber(CDbl(dtg1.Item(2, x).Value), 2)
                    Next


                End If
            Else
                Label2.Text = "No hay datos para desplegar"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If mYConn.State <> ConnectionState.Closed Then
                mYConn.Close()
            End If
        End Try

    End Sub

    Private Sub dtg1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg1.CellClick
        Dim pregunta As String
        Dim nombreElegido As String
        If accion = "U" Then
            nombreElegido = dtg1.Item(1, e.RowIndex).Value.ToString & " " & dtg1.Item(2, e.RowIndex).Value.ToString
            pregunta = MsgBox("¿Desea actualizar los datos del usuario " & nombreElegido & "?", vbYesNo)
            If pregunta = vbYes Then
                ActualizarUsuario.Close()
                ActualizarUsuario.MdiParent = MenuPrincipal
                ActualizarUsuario.WindowState = FormWindowState.Maximized
                ActualizarUsuario.txtNombreCompleto.Text = "Usuario Seleccionado: " & dtg1.Item(1, e.RowIndex).Value.ToString & " " & dtg1.Item(2, e.RowIndex).Value.ToString
                ActualizarUsuario.txtId.Text = dtg1.Item(0, e.RowIndex).Value.ToString
                ActualizarUsuario.txtNombre.Text = dtg1.Item(1, e.RowIndex).Value.ToString
                ActualizarUsuario.txtApellido.Text = dtg1.Item(2, e.RowIndex).Value.ToString
                ActualizarUsuario.txtCedula.Text = dtg1.Item(3, e.RowIndex).Value.ToString
                ActualizarUsuario.txtEmail.Text = dtg1.Item(4, e.RowIndex).Value.ToString
                ActualizarUsuario.txtPassword.Text = dtg1.Item(5, e.RowIndex).Value.ToString

                ActualizarUsuario.cboTipo.Items.Add("Administrador")
                ActualizarUsuario.cboTipo.Items.Add("Cajero")
                ActualizarUsuario.cboTipo.Items.Add("Personal De Inventario")

                If Val(dtg1.Item(6, e.RowIndex).Value) = 1 Then
                    ActualizarUsuario.cboTipo.SelectedIndex = 0
                ElseIf Val(dtg1.Item(6, e.RowIndex).Value) = 2 Then
                    ActualizarUsuario.cboTipo.SelectedIndex = 1

                Else
                    ActualizarUsuario.cboTipo.SelectedIndex = 2
                End If

                ActualizarUsuario.cboIntento.Items.Add(0)
                ActualizarUsuario.cboIntento.Items.Add(1)
                ActualizarUsuario.cboIntento.Items.Add(2)
                ActualizarUsuario.cboIntento.Items.Add(3)

                If Val(dtg1.Item(7, e.RowIndex).Value) = 0 Then
                    ActualizarUsuario.cboIntento.SelectedIndex = 0
                ElseIf Val(dtg1.Item(7, e.RowIndex).Value) = 1 Then
                    ActualizarUsuario.cboIntento.SelectedIndex = 1
                ElseIf Val(dtg1.Item(7, e.RowIndex).Value) = 2 Then
                    ActualizarUsuario.cboIntento.SelectedIndex = 2
                Else
                    ActualizarUsuario.cboIntento.SelectedIndex = 3

                End If

                ActualizarUsuario.Show()

            End If
        ElseIf accion = "C" Then
            nombreElegido = dtg1.Item(1, e.RowIndex).Value.ToString & " " & dtg1.Item(2, e.RowIndex).Value.ToString
            pregunta = MsgBox("¿Desea actualizar los datos del cliente " & nombreElegido & "?", vbYesNo)
            If pregunta = vbYes Then
                ActualizarCliente.Close()
                ActualizarCliente.txtId.Text = dtg1.Item(0, e.RowIndex).Value.ToString
                ActualizarCliente.txtNombre.Text = dtg1.Item(1, e.RowIndex).Value.ToString
                ActualizarCliente.txtApellido.Text = dtg1.Item(2, e.RowIndex).Value.ToString
                ActualizarCliente.txtCedula.Text = dtg1.Item(3, e.RowIndex).Value.ToString
                ActualizarCliente.MdiParent = MenuPrincipal
                ActualizarCliente.WindowState = FormWindowState.Maximized
                ActualizarCliente.txtNombreCompleto.Text = "Cliente Seleccionado: " & dtg1.Item(1, e.RowIndex).Value.ToString & " " & dtg1.Item(2, e.RowIndex).Value.ToString
                ActualizarCliente.Show()

            End If

        ElseIf accion = "P" Then
            nombreElegido = dtg1.Item(1, e.RowIndex).Value.ToString
            pregunta = MsgBox("¿Desea actualizar los datos del producto " & nombreElegido & "?", vbYesNo)
            If pregunta = vbYes Then
                Dim img As Image
                ActualizarProducto.Close()
                ActualizarProducto.txtId.Text = dtg1.Item(0, e.RowIndex).Value.ToString
                ActualizarProducto.txtNombre.Text = dtg1.Item(1, e.RowIndex).Value.ToString
                ActualizarProducto.txtPrecio.Text = dtg1.Item(2, e.RowIndex).Value.ToString
                ActualizarProducto.txtCantidad.Text = dtg1.Item(3, e.RowIndex).Value.ToString
                If System.IO.File.Exists("../../Productos/" & dtg1.Item(4, e.RowIndex).Value.ToString) Then
                    ActualizarProducto.PictureBox1.Image = Image.FromFile("../../Productos/" & dtg1.Item(4, e.RowIndex).Value.ToString)
                    ActualizarProducto.txtImg.Text = dtg1.Item(4, e.RowIndex).Value.ToString
                Else
                    ActualizarProducto.PictureBox1.Image = Image.FromFile("..\..\Productos\Producto.jpg")
                End If
                ActualizarProducto.MdiParent = MenuPrincipal
                ActualizarProducto.WindowState = FormWindowState.Maximized
                ActualizarProducto.txtNombreCompleto.Text = "Producto Seleccionado: " & dtg1.Item(1, e.RowIndex).Value.ToString
                ActualizarProducto.Show()

            End If


            ElseIf accion = "E" Then
            nombreElegido = dtg1.Item(1, e.RowIndex).Value.ToString
            pregunta = MsgBox("¿Desea eliminar el producto " & nombreElegido & "?", vbYesNo)
            If pregunta = vbYes Then
                Dim glComand As New SqlCommand
                Dim dtOrdenes As New DataTable
                Dim SqlDa As SqlDataAdapter


                glComand.Connection = mYConn
                glComand.CommandText = "SP_EliminarProducto"
                glComand.Parameters.AddWithValue("@idProducto", dtg1.Item(0, e.RowIndex).Value.ToString)
                glComand.CommandTimeout = 0
                glComand.CommandType = CommandType.StoredProcedure

                Try
                    mYConn.Open()
                    glComand.ExecuteNonQuery()
                    SqlDa = New SqlDataAdapter(glComand)
                    SqlDa.Fill(dtOrdenes)
                    MsgBox("¡Producto Eliminado Exitosamente!", vbYes, "Éxito")
                    Me.Hide()



                Catch ex As Exception
                    MsgBox("Hubo un error... inténtelo de nuevo", vbYes, "Error")
                Finally
                    If mYConn.State <> ConnectionState.Closed Then
                        mYConn.Close()
                    End If
                End Try

            End If

        End If
    End Sub

    Private Sub Actualizar_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Bienvenida.MdiParent = MenuPrincipal
        Bienvenida.WindowState = FormWindowState.Maximized
        Bienvenida.Show()
    End Sub
End Class