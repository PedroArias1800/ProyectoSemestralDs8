Imports System.Data.SqlClient

Public Class RegistrarUsuario

    Private Sub RegistrarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Top = Me.Height / 6 - (Label1.Height / 2)
        GroupBox1.Top = Me.Height / 2.5 - (GroupBox1.Height / 2)
        btnRegistrarUsuario.Top = Me.Height / 1.4 - (btnRegistrarUsuario.Height / 2)

        Label1.Left = Me.Width / 2 - (Label1.Width / 2)
        GroupBox1.Left = Me.Width / 2 - (GroupBox1.Width / 2)
        btnRegistrarUsuario.Left = Me.Width / 2 - (btnRegistrarUsuario.Width / 2)

        Label1.BackColor = Color.FromArgb(230, 64, 64, 64)
        GroupBox1.BackColor = Color.FromArgb(230, 64, 64, 64)
        btnRegistrarUsuario.BackColor = Color.FromArgb(230, 64, 64, 64)

        cboTipoCuenta.Items.Add("Seleccione un tipo")
        cboTipoCuenta.Items.Add("Administrador")
        cboTipoCuenta.Items.Add("Cajera")
        cboTipoCuenta.Items.Add("Inventario")
        cboTipoCuenta.SelectedIndex = 0

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

    Private Sub cboTipoCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboTipoCuenta.KeyPress
        If Asc(e.KeyChar) <> 0 Then
            If Asc(e.KeyChar) < 45 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class