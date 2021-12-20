Imports System.Data.SqlClient
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tipo = 0
        txtEmail.Text = ""
        txtPassword.Text = ""
        dtgIniciarSesion.Visible = False

        GroupBox1.Left = Me.Width / 2 - (GroupBox1.Width / 2)
        Label1.Left = Me.Width / 2 - (Label1.Width / 2)

        btnIniciarSesion.Left = Me.Width / 2 - (btnIniciarSesion.Width / 2)
        Button1.Left = Me.Width / 2 - (Button1.Width / 2)

        GroupBox1.BackColor = Color.FromArgb(230, 64, 64, 64)
        Label1.BackColor = Color.FromArgb(230, 64, 64, 64)
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Dim glComand As New SqlCommand
        Dim dtOrdenes As New DataTable
        Dim SqlDa As SqlDataAdapter
        Dim permitir As String = "Si"

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
                Try
                    Dim fechaActual As String = Now
                    Dim fecha, passU As String()
                    Dim borrar As String = "No"

                    passU = Split(dtgIniciarSesion(4, 0).Value.ToString(), " ")
                    fecha = Split(fechaActual, " ")

                    If CDate(fecha(0)) <> CDate(passU(0)) Then
                        Dim spl1, spl2 As String()
                        spl1 = Split(fecha(1), ":")
                        spl2 = Split(passU(1), ":")
                        If Int(spl1(0)) = Int(spl2(0)) Then
                            If Int(spl1(1)) = Int(spl2(1)) Then
                                borrar = "Si"
                            ElseIf Int(spl1(1)) > Int(spl2(1)) Then
                                borrar = "Si"
                            Else

                            End If
                        ElseIf Int(spl1(0)) > Int(spl2(0)) Then
                            borrar = "Si"
                        Else

                        End If

                        If borrar = "Si" Then
                            permitir = "No"

                            Dim glComand2 As New SqlCommand
                            Dim dtOrdenes2 As New DataTable
                            Dim SqlDa2 As SqlDataAdapter

                            glComand2.Connection = mYConn

                            glComand2.CommandText = "SP_UpdatePassTemp"
                            glComand2.Parameters.AddWithValue("@email", txtEmail.Text)
                            glComand2.CommandTimeout = 0
                            glComand2.CommandType = CommandType.StoredProcedure

                            Try

                                glComand2.ExecuteNonQuery()
                                SqlDa2 = New SqlDataAdapter(glComand2)
                                SqlDa2.Fill(dtOrdenes2)

                            Catch ex As Exception

                            Finally
                                If mYConn.State <> ConnectionState.Closed Then
                                    mYConn.Close()
                                End If
                            End Try

                        End If

                    End If

                    If borrar = "No" Then
                        MsgBox("Recuerde que esta contraseña es temporal, comuníquese con el administrador", vbYes, "Recordatorio")
                    End If

                Catch ex As Exception

                End Try

                If permitir = "Si" Then
                    MenuPrincipal.Show()
                    Me.Hide()
                Else
                    MsgBox("Su contraseña temporal expíró, comuníquese con el administrador", vbYes, "Lo sentimos")
                End If
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