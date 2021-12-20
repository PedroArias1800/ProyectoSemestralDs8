Imports System.Net.Mail
Imports System.Data.SqlClient

Public Class RecuperarContraseña
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fecha As String = Now
        Dim Temp As String

        Dim caracteres As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefg0123456789?#@!-+"
        Dim Longitud As Integer = 20
        Dim RND As New Random
        Dim cadena As String = ""
        Do Until cadena.Length = Longitud
            cadena += caracteres.ToCharArray(RND.Next(0, caracteres.Length), 1)
        Loop
        Temp = cadena

        Dim glComand As New SqlCommand
        Dim dtOrdenes As New DataTable
        Dim SqlDa As SqlDataAdapter



        glComand.Connection = mYConn
        glComand.CommandText = "SP_Enviar_Temp"
        glComand.Parameters.AddWithValue("@email", txtCorreo.Text)
        glComand.Parameters.AddWithValue("@random", Temp)
        glComand.Parameters.AddWithValue("@fecha", fecha)
        glComand.CommandTimeout = 0
        glComand.CommandType = CommandType.StoredProcedure

        Try
            mYConn.Open()
            glComand.ExecuteNonQuery()
            SqlDa = New SqlDataAdapter(glComand)
            SqlDa.Fill(dtOrdenes)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If mYConn.State <> ConnectionState.Closed Then
                mYConn.Close()
            End If
        End Try


        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("ds8semestral@gmail.com", "globoblanco29")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage
            e_mail.From = New MailAddress("ds8semestral@gmail.com")
            e_mail.To.Add(txtCorreo.Text)
            e_mail.Subject = "Petición De Contraseña Temporal"
            e_mail.Body = "Puede acceder a su cuenta con la siguiente contraseña temporal:" & vbCrLf & Temp & vbCrLf & "Recuerde que es válida por 24 horas, comuníquese con el administrador." & vbCrLf & vbCrLf & "Equipo De Factura EGPH ™" & vbCrLf & vbCrLf & vbCrLf
            Smtp_Server.Send(e_mail)
            MsgBox("¡Se ha enviado exitosamente el correo, revíselo en sus bandejas de entrada!", vbYes, "Éxito")
            Me.Hide()
            Login.txtEmail.Text = txtCorreo.Text
            Login.txtPassword.Text = ""
            Me.txtCorreo.Text = ""
            Login.Show()

        Catch ex As Exception
            MsgBox("Error al enviar el correo", vbYes, "Error")

        End Try
    End Sub

    Private Sub RecuperarContraseña_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Left = Me.Width / 2 - (Label1.Width / 2)
        Button1.Left = Me.Width / 2 - (Button1.Width / 2)
        Button2.Left = Me.Width / 2 - (Button2.Width / 2)
        GroupBox1.Left = Me.Width / 2 - (GroupBox1.Width / 2)

        Button2.BackColor = Color.FromArgb(230, 64, 64, 64)
        GroupBox1.BackColor = Color.FromArgb(230, 64, 64, 64)
        Label1.BackColor = Color.FromArgb(230, 64, 64, 64)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Me.txtCorreo.Text = ""
        Login.txtEmail.Text = ""
        Login.txtPassword.Text = ""
        Login.Show()
    End Sub
End Class