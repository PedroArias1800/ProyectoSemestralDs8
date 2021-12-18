Imports System.Data.SqlClient

Public Class RegistrarUsuario

    Private Sub RegistrarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnRegistrarUsuario.Left = Me.Width / 2 - (btnRegistrarUsuario.Width / 2)
        Label1.Left = Me.Width / 2 - (Label1.Width / 2)
        GroupBox1.Left = Me.Width / 2 - (GroupBox1.Width / 2)

        cboTipoCuenta.Items.Add("Seleccione un tipo")
        cboTipoCuenta.Items.Add("Administrador")
        cboTipoCuenta.Items.Add("Cajera")
        cboTipoCuenta.Items.Add("Inventario")
        cboTipoCuenta.SelectedIndex = 0

        'glComand.Connection = mYConn
        'glComand.CommandText = "SP_BuscarTipoCuenta"
        'glComand.CommandTimeout = 0
        'glComand.CommandType = CommandType.StoredProcedure

        'Try
        'mYConn.Open()
        'glComand.ExecuteNonQuery()
        'SqlDa = New SqlDataAdapter(glComand)
        'SqlDa.Fill(dtOrdenes)
        'If dtOrdenes.Rows.Count <> 0 Then
        'dtgIniciarSesion.DataSource = dtOrdenes
        'idUsuario = Val(dtgIniciarSesion.Item(0, 0).Value)
        'nombreCompleto = dtgIniciarSesion(1, 0).Value.ToString & " " & dtgIniciarSesion(2, 0).Value.ToString
        'tipo = Val(dtgIniciarSesion.Item(3, 0).Value)
        'MenuPrincipal.Show()
        'Me.Hide()
        'Else
        'MsgBox("Datos inválidos, inténtelo de nuevo", vbYes, "Error")
        'End If
        '
        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'Finally
        'If mYConn.State <> ConnectionState.Closed Then
        'mYConn.Close()
        'End If
        'End Try
    End Sub

    Private Sub btnRegistrarUsuario_Click(sender As Object, e As EventArgs) Handles btnRegistrarUsuario.Click
        Dim glComand As New SqlCommand

        Dim nombre, apellido, correo, cedula, contraseña
        Dim tipo As Integer

        nombre = txtNombre.Text
        apellido = txtApellido.Text
        correo = txtCorreo.Text
        cedula = txtCedula.Text
        contraseña = txtContraseña.Text
        tipo = cboTipoCuenta.SelectedIndex

        If nombre <> "" And apellido <> "" And correo <> "" And cedula <> "" And contraseña <> "" And tipo <> 0 Then

            If contraseña = txtContraseña2.Text Then

                glComand.Connection = mYConn
                glComand.CommandText = "SP_RegistrarUsuario"
                glComand.Parameters.AddWithValue("@nombreU", nombre)
                glComand.Parameters.AddWithValue("@apellidoU", apellido)
                glComand.Parameters.AddWithValue("@cedulaU", cedula)
                glComand.Parameters.AddWithValue("@emailU", correo)
                glComand.Parameters.AddWithValue("@passwordU", contraseña)
                glComand.Parameters.AddWithValue("@tipoCuenta", tipo)
                glComand.CommandTimeout = 0
                glComand.CommandType = CommandType.StoredProcedure

                Try
                    mYConn.Open()
                    glComand.ExecuteNonQuery()
                    MsgBox("Usuario registrado exitosamente", vbYes, "Exito")

                    txtNombre.Text = ""
                    txtApellido.Text = ""
                    txtCedula.Text = ""
                    txtCorreo.Text = ""
                    txtContraseña.Text = ""
                    txtContraseña2.Text = ""
                    cboTipoCuenta.SelectedIndex = 0
                Catch ex As Exception
                    MsgBox("No se pudo registrar al usuario, vuelva a intentarlo
                            Error:" & ex.Message, vbYes, "Error")
                Finally
                    If mYConn.State <> ConnectionState.Closed Then
                        mYConn.Close()
                    End If
                End Try
            Else
                MsgBox("Las contraseñas no coinsiden", vbYes, "Error")
            End If
        Else
            MsgBox("Debe llenar todos los campos", vbYes, "Error")
        End If
    End Sub
End Class