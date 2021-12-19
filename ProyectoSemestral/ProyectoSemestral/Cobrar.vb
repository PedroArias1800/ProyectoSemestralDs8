Imports System.Data.SqlClient
Public Class Cobrar
    Private Sub Cobrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Left = Me.Width / 2 - (Label1.Width / 2)
        GroupBox1.Left = Me.Width / 2 - (GroupBox1.Width / 2)

        Dim glComand As New SqlCommand
        Dim dtOrdenes As New DataTable
        Dim SqlDa As SqlDataAdapter

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

            Dim glComand As New SqlCommand
            Dim dtOrdenes As New DataTable
            Dim SqlDa As SqlDataAdapter
            Dim cantidad As Integer

            glComand.Connection = mYConn
            glComand.CommandText = "SP_BuscarProductoPorNombre"
            glComand.Parameters.AddWithValue("@nombreP", cboProductos.SelectedItem.ToString())
            glComand.CommandTimeout = 0
            glComand.CommandType = CommandType.StoredProcedure

            Try
                mYConn.Open()
                glComand.ExecuteNonQuery()
                SqlDa = New SqlDataAdapter(glComand)
                SqlDa.Fill(dtOrdenes)

                If dtOrdenes.Rows.Count <> 0 Then
                    dtg1.DataSource = dtOrdenes

                    cantidad = InputBox("Unidades existentes: " & dtg1.Item(3, 0).Value, "Catidad a Comprar", 1)

                    If cantidad > 0 Then
                        lboProductos.Items.Add(cantidad & "   " & dtg1.Item(1, 0).Value & "   B/." & Math.Round(Val(dtg1.Item(2, 0).Value), 2))
                    Else
                        MsgBox("Ingrese una cantidad valida")
                    End If
                End If

                'dtg1.DataSource = Nothing
                'dtg1.Rows.Clear()
                'dtg1.Columns.Clear()
                cboProductos.SelectedIndex = 0

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If mYConn.State <> ConnectionState.Closed Then
                    mYConn.Close()
                End If
            End Try
        End If
    End Sub
End Class