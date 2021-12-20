Imports System.Data.SqlClient
Public Class ActualizarUsuario

    'Guardando la data en este form
    Dim nombre, apellido, cedula, email, password As String

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim glComand As New SqlCommand
        Dim dtOrdenes As New DataTable
        Dim SqlDa As SqlDataAdapter
        Dim tipo As Integer

        glComand.Connection = mYConn
        glComand.CommandText = "SP_ActualizarUsuario"
        glComand.Parameters.AddWithValue("@idUsuario", txtId.Text)
        glComand.Parameters.AddWithValue("@nombreU", txtNombre.Text)
        glComand.Parameters.AddWithValue("@apellidoU", txtApellido.Text)
        glComand.Parameters.AddWithValue("@cedulaU", txtCedula.Text)
        glComand.Parameters.AddWithValue("@emailU", txtEmail.Text)
        glComand.Parameters.AddWithValue("@passwordU", txtPassword.Text)
        If cboTipo.SelectedItem.ToString = "Administrador" Then
            tipo = 1
        ElseIf cboTipo.SelectedItem.ToString = "Cajero" Then
            tipo = 2
        Else
            tipo = 3
        End If
        glComand.Parameters.AddWithValue("@tipoCuentaU", tipo)
        glComand.Parameters.AddWithValue("@intentoU", cboIntento.Text)
        glComand.CommandTimeout = 0
        glComand.CommandType = CommandType.StoredProcedure

        Try
            mYConn.Open()
            glComand.ExecuteNonQuery()
            SqlDa = New SqlDataAdapter(glComand)
            SqlDa.Fill(dtOrdenes)
            MsgBox("¡Usuario Actualizado Exitosamente!", vbYes, "Éxito")

        Catch ex As Exception
            MsgBox("Hubo un error... inténtelo de nuevo", vbYes, "Error")
        Finally
            If mYConn.State <> ConnectionState.Closed Then
                mYConn.Close()
            End If
        End Try
    End Sub

    Private Sub cboTipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboTipo.KeyPress
        If Asc(e.KeyChar) <> 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtIntento_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 5 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 51 Then
                e.Handled = True
            ElseIf Asc(e.KeyChar) = Keys.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Dim intento As Integer

    Private Sub ActualizarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        email = txtEmail.Text
        password = txtPassword.Text

    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        txtNombre.Text = nombre
        txtApellido.Text = apellido
        txtCedula.Text = cedula
        txtEmail.Text = email
        txtPassword.Text = password

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        accion = "U"
        Actualizar.Close()
        Actualizar.MdiParent = MenuPrincipal
        Actualizar.WindowState = FormWindowState.Maximized
        Actualizar.Show()
    End Sub
End Class