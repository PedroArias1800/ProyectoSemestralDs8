Imports System.Data.SqlClient
Public Class ActualizarCliente
    Dim nombre, apellido, cedula As String

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim glComand As New SqlCommand
        Dim dtOrdenes As New DataTable
        Dim SqlDa As SqlDataAdapter

        glComand.Connection = mYConn
        glComand.CommandText = "SP_ActualizarCliente"
        glComand.Parameters.AddWithValue("@idCliente", txtId.Text)
        glComand.Parameters.AddWithValue("@nombreC", txtNombre.Text)
        glComand.Parameters.AddWithValue("@apellidoC", txtApellido.Text)
        glComand.Parameters.AddWithValue("@cedulaC", txtCedula.Text)
        glComand.CommandTimeout = 0
        glComand.CommandType = CommandType.StoredProcedure

        Try
            mYConn.Open()
            glComand.ExecuteNonQuery()
            SqlDa = New SqlDataAdapter(glComand)
            SqlDa.Fill(dtOrdenes)
            MsgBox("¡Cliente Actualizado Exitosamente!", vbYes, "Éxito")

        Catch ex As Exception
            MsgBox("Hubo un error... inténtelo de nuevo", vbYes, "Error")
        Finally
            If mYConn.State <> ConnectionState.Closed Then
                mYConn.Close()
            End If
        End Try
    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        txtNombre.Text = nombre
        txtApellido.Text = apellido
        txtCedula.Text = cedula
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        accion = "C"
        Actualizar.Close()
        Actualizar.MdiParent = MenuPrincipal
        Actualizar.WindowState = FormWindowState.Maximized
        Actualizar.Show()
    End Sub

    Private Sub ActualizarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Top = Me.Height / 6 - (Label1.Height / 2)
        GroupBox1.Top = Me.Height / 2 - (GroupBox1.Height / 2)

        Label1.Left = Me.Width / 2 - (Label1.Width / 2)
        GroupBox1.Left = Me.Width / 2 - (GroupBox1.Width / 2)

        Label1.BackColor = Color.FromArgb(230, 64, 64, 64)
        GroupBox1.BackColor = Color.FromArgb(230, 64, 64, 64)

        Label1.BackColor = Color.FromArgb(230, 64, 64, 64)
        GroupBox1.BackColor = Color.FromArgb(230, 64, 64, 64)
        btnActualizar.BackColor = Color.FromArgb(230, 64, 64, 64)
        btnReiniciar.BackColor = Color.FromArgb(230, 64, 64, 64)
        btnVolver.BackColor = Color.FromArgb(230, 64, 64, 64)

        nombre = txtNombre.Text
        apellido = txtApellido.Text
        cedula = txtCedula.Text
    End Sub


End Class