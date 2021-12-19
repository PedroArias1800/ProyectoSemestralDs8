Imports System.Data.SqlClient
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Left = Me.Width / 2 - (GroupBox1.Width / 2)
        GroupBox1.Top = Me.Height / 2 - (GroupBox1.Height / 2)
        Label1.Left = GroupBox1.Width / 2 - (Label1.Width / 2)
        btnIniciarSesion.Left = GroupBox1.Width / 2 - (btnIniciarSesion.Width / 2)

        GroupBox1.BackColor = Color.FromArgb(230, 169, 169, 169)

        tipo = 0
        txtEmail.Text = ""
        txtPassword.Text = ""
        dtgIniciarSesion.Visible = False
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Dim glComand As New SqlCommand
        Dim dtOrdenes As New DataTable
        Dim SqlDa As SqlDataAdapter

        glComand.Connection = mYConn
        glComand.CommandText = "SP_Login"
        glComand.Parameters.AddWithValue("@email", txtEmail.Text)
        glComand.Parameters.AddWithValue("@password", txtPassword.Text)
        glComand.CommandTimeout = 0
        glComand.CommandType = CommandType.StoredProcedure

        Try
            mYConn.Open()
            glComand.ExecuteNonQuery()
            SqlDa = New SqlDataAdapter(glComand)
            SqlDa.Fill(dtOrdenes)
            If dtOrdenes.Rows.Count <> 0 Then
                dtgIniciarSesion.DataSource = dtOrdenes
                idUsuario = Val(dtgIniciarSesion.Item(0, 0).Value)
                nombreCompleto = dtgIniciarSesion(1, 0).Value.ToString & " " & dtgIniciarSesion(2, 0).Value.ToString
                tipo = Val(dtgIniciarSesion.Item(3, 0).Value)
                'MenuPrincipal.Refresh()
                MenuPrincipal.Show()
                'Bienvenida.Show()
                Me.Hide()
            Else
                MsgBox("Datos inválidos, inténtelo de nuevo", vbYes, "Error")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If mYConn.State <> ConnectionState.Closed Then
                mYConn.Close()
            End If
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        RecuperarContraseña.Show()
    End Sub
End Class