Imports System.Data.SqlClient
Public Class Cobrar
    Dim SqlDa As SqlDataAdapter
    Dim glComand As New SqlCommand
    Dim total As Double
    Dim cantidad, i As Integer
    Private Sub Cobrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Left = Me.Width / 2 - (Label1.Width / 2)
        GroupBox1.Left = Me.Width / 2 - (GroupBox1.Width / 2)

        total = 0.00
        dtg2.Columns.Add(0, "ID")
        dtg2.Columns.Add(1, "Cantidad")
        dtg2.Columns.Add(2, "Producto")
        dtg2.Columns.Add(3, "Precio")
        dtg2.Columns.Add(4, "Total")

        Dim dtOrdenes As New DataTable

        glComand.Connection = mYConn
        glComand.CommandText = "SP_BuscarProductoVender"
        glComand.CommandTimeout = 0
        glComand.CommandType = CommandType.StoredProcedure

        Try
            mYConn.Open()
            glComand.ExecuteNonQuery()
            SqlDa = New SqlDataAdapter(glComand)
            SqlDa.Fill(dtOrdenes)

            If dtOrdenes.Rows.Count <> 0 Then
                dtg1.DataSource = dtOrdenes

                cboProductos.Items.Add("Seleccione un producto")

                For x = 0 To dtOrdenes.Rows.Count - 1
                    cboProductos.Items.Add(dtg1.Item(1, x).Value.ToString)
                Next
            Else
                Label2.Text = "No hay datos para desplegar"
            End If

            'dtg1.DataSource = Nothing
            'dtg1.Rows.Clear()
            'dtg1.Columns.Clear()
            cboProductos.SelectedIndex = 0
            PictureBox1.Image = Image.FromFile("..\..\Productos\Producto.jpg")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If mYConn.State <> ConnectionState.Closed Then
                mYConn.Close()
            End If
        End Try
    End Sub

    Private Sub cboProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProductos.SelectedIndexChanged
        If cboProductos.SelectedIndex > 0 Then

            Try

                cantidad = InputBox("Producto: " & dtg1.Item(1, i).Value & vbCrLf &
                                    "Unidades existentes: " & dtg1.Item(3, 0).Value & vbCrLf & vbCrLf &
                                    "Ingrese la cantidad a cobrar:", "Catidad a Comprar", 1)
                i = cboProductos.SelectedIndex - 1

                If cantidad > 0 Then

                    If dtg2.Rows.Count = 0 Then
                        dtg2.Rows.Add(dtg1.Item(0, i).Value, cantidad, dtg1.Item(1, i).Value, Math.Round(Val(dtg1.Item(2, i).Value), 2))
                    Else
                        dtg2.Rows(dtg2.Rows.Count - 1).Cells(0).Value = dtg1.Item(0, i).Value
                        dtg2.Rows(dtg2.Rows.Count - 1).Cells(1).Value = cantidad
                        dtg2.Rows(dtg2.Rows.Count - 1).Cells(2).Value = dtg1.Item(1, i).Value
                        dtg2.Rows(dtg2.Rows.Count - 1).Cells(3).Value = Math.Round(Val(dtg1.Item(2, i).Value), 2)
                        dtg2.Rows(dtg2.Rows.Count - 1).Cells(4).Value = ""
                    End If

                    total += cantidad * dtg1.Item(2, i).Value
                    dtg2.Rows.Add("", "", "", "", total)
                Else
                    MsgBox("Ingrese una cantidad valida")
                End If

                cantidad = 0

                cboProductos.SelectedIndex = 0
                PictureBox1.Image = Image.FromFile("..\..\Productos\Producto.jpg")

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If mYConn.State <> ConnectionState.Closed Then
                    mYConn.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub btnCobrar_Click(sender As Object, e As EventArgs) Handles btnCobrar.Click
        If total > 0 Then
            If MessageBox.Show("Desea confirmar el cobro", "Confrirmar Cobro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                glComand.Connection = mYConn
                glComand.CommandText = "SP_Comprar"
                glComand.Parameters.AddWithValue("@idCliente", txtId.Text)
                glComand.Parameters.AddWithValue("@idUsuario", idUsuario)
                glComand.CommandTimeout = 0
                glComand.CommandType = CommandType.StoredProcedure

                Try
                    mYConn.Open()
                    glComand.ExecuteNonQuery()

                    mYConn.Close()

                    For x = 0 To dtg2.Rows.Count - 2

                        Dim glComand2 As New SqlCommand

                        glComand2.Connection = mYConn
                        glComand2.CommandText = "SP_DetalleOrden"
                        glComand2.Parameters.AddWithValue("@idProducto", dtg2.Item(0, x).Value)
                        glComand2.Parameters.AddWithValue("@cantidad", dtg2.Item(1, x).Value)
                        glComand2.CommandTimeout = 0
                        glComand2.CommandType = CommandType.StoredProcedure

                        mYConn.Open()
                        glComand2.ExecuteNonQuery()

                        mYConn.Close()
                    Next

                    MsgBox("Compra realizado con exito", vbYes, "Exito")

                    dtg2.DataSource = Nothing
                    dtg2.Rows.Clear()
                    dtg2.Columns.Clear()
                    cboProductos.SelectedIndex = 0

                    Me.Close()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    If mYConn.State <> ConnectionState.Closed Then
                        mYConn.Close()
                    End If
                End Try
            End If
        Else
            MsgBox("No se han incluido productos")
        End If
    End Sub
End Class