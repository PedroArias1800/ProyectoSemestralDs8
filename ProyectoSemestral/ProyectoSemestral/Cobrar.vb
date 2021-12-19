Imports System.Data.SqlClient
Public Class Cobrar
    Dim SqlDa As SqlDataAdapter
    Dim glComand As New SqlCommand
    Dim total As Double
    Dim cantidad, i As Integer
    Private Sub Cobrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Left = Me.Width / 2 - (Label1.Width / 2)
        GroupBox1.Left = Me.Width / 2 - (GroupBox1.Width / 2)

        Label1.BackColor = Color.FromArgb(230, 64, 64, 64)
        GroupBox1.BackColor = Color.FromArgb(230, 64, 64, 64)
        btnCobrar.BackColor = Color.FromArgb(230, 64, 64, 64)
        btnVolver.BackColor = Color.FromArgb(230, 64, 64, 64)

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
        Dim pasar As String = "No"
        Dim tryCatch As String = "No"
        If cboProductos.SelectedIndex > 0 Then

            Try

                i = cboProductos.SelectedIndex - 1
                cantidad = 0

                Try
                    cantidad = InputBox("Producto: " & dtg1.Item(1, i).Value & vbCrLf &
                                        "Unidades existentes: " & dtg1.Item(3, i).Value & vbCrLf & vbCrLf &
                                        "Ingrese la cantidad a cobrar:", "Cantidad a Comprar", 1)
                Catch ex As Exception
                    tryCatch = "Si"
                End Try

                If cantidad > 0 And cantidad <= dtg1.Item(3, i).Value Then

                    dtg1.Item(3, i).Value = dtg1.Item(3, i).Value - cantidad

                    For x = 0 To dtg2.Rows.Count - 1
                        If dtg2.Item(2, x).Value.ToString = dtg1.Item(1, i).Value.ToString Then
                            dtg2.Item(1, x).Value = dtg2.Item(1, x).Value + cantidad
                            pasar = "Si"
                        End If
                    Next

                    If dtg2.Rows.Count = 0 Then
                        dtg2.Rows.Add(dtg1.Item(0, i).Value, cantidad, dtg1.Item(1, i).Value, FormatNumber(CDbl(dtg1.Item(2, i).Value), 2), "")
                    Else
                        If pasar = "No" Then
                            dtg2.Rows(dtg2.Rows.Count - 1).Cells(0).Value = dtg1.Item(0, i).Value
                            dtg2.Rows(dtg2.Rows.Count - 1).Cells(1).Value = cantidad
                            dtg2.Rows(dtg2.Rows.Count - 1).Cells(2).Value = dtg1.Item(1, i).Value
                            dtg2.Rows(dtg2.Rows.Count - 1).Cells(3).Value = FormatNumber(CDbl(dtg1.Item(2, i).Value), 2)
                            dtg2.Rows(dtg2.Rows.Count - 1).Cells(4).Value = ""

                        End If
                    End If

                    total += FormatNumber(CDbl(cantidad * dtg1.Item(2, i).Value), 2)

                    If pasar = "No" Then
                        dtg2.Rows.Add("", "", "", "", total)
                    Else
                        dtg2.Rows(dtg2.Rows.Count - 1).Cells(4).Value = total
                    End If

                    pasar = "No"

                    PictureBox1.Image = Image.FromFile("..\..\Productos\" & dtg1.Item(4, i).Value.ToString)
                ElseIf (cantidad = 0 And tryCatch = "No") Or (cantidad > dtg1.Item(3, i).Value And tryCatch = "No") Then
                    MsgBox("Ingrese una cantidad valida")
                Else
                    tryCatch = "No"
                End If

                cantidad = 0

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

    Private Sub cboProductos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboProductos.KeyPress
        If Asc(e.KeyChar) <> 0 Then
            If Asc(e.KeyChar) < 45 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim pregunta As String
        pregunta = MsgBox("¿Está seguro de salir y no facturar?, los datos se perderán...", vbYesNo, "Volver")
        If pregunta = vbYes Then
            Me.Close()
            Bienvenida.MdiParent = MenuPrincipal
            Bienvenida.WindowState = FormWindowState.Maximized
            Bienvenida.Show()
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