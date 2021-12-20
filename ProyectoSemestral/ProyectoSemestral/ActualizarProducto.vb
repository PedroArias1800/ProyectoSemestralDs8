Imports System.Data.SqlClient
Imports System.IO.Path
Public Class ActualizarProducto
    Dim nombre, precio, cantidad, imagenProducto As String
    Dim openFileDialog1 As OpenFileDialog
    Dim IMAGEN As String
    Dim nombreImagen As String = "Producto.jpg"
    Dim extension As String = ".jpg"
    Dim img As Image
    Dim agarroImagen As String = "No"
    Private Sub ActualizarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Top = Me.Height / 7 - (Label1.Height / 2)
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

        txtImg.Visible = False

        nombre = txtNombre.Text
        precio = txtPrecio.Text
        cantidad = txtCantidad.Text
        img = PictureBox1.Image
        imagenProducto = txtImg.Text
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        accion = "P"
        Actualizar.Close()
        Actualizar.MdiParent = MenuPrincipal
        Actualizar.WindowState = FormWindowState.Maximized
        Actualizar.Show()
    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        txtNombre.Text = nombre
        txtPrecio.Text = precio
        txtCantidad.Text = cantidad
        PictureBox1.Image = img
        txtImg.Text = imagenProducto
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim glComand As New SqlCommand
        Dim dtOrdenes As New DataTable
        Dim SqlDa As SqlDataAdapter
        Dim nuevaRuta As String
        Dim now1 As Date = Now
        Dim fecha As String

        If agarroImagen = "Si" Then
            fecha = Replace(now1, "/", "")
            fecha = Replace(fecha, ":", "")
            fecha = Replace(fecha, " ", "")
            nuevaRuta = "..\..\Productos\" & txtNombre.Text & fecha & extension
            nombre = txtNombre.Text & fecha & extension
            CopiarArchivo(nombreImagen, nuevaRuta)
        Else
            nombre = imagenProducto
        End If

        agarroImagen = "No"

        glComand.Connection = mYConn
        glComand.CommandText = "SP_ActualizarProducto"
        glComand.Parameters.AddWithValue("@idProducto", txtId.Text)
        glComand.Parameters.AddWithValue("@nombreP", txtNombre.Text)
        glComand.Parameters.AddWithValue("@precioP", txtPrecio.Text)
        glComand.Parameters.AddWithValue("@cantidadP", txtCantidad.Text)
        glComand.Parameters.AddWithValue("@fotoP", nombre)
        glComand.CommandTimeout = 0
        glComand.CommandType = CommandType.StoredProcedure

        Try
            mYConn.Open()
            glComand.ExecuteNonQuery()
            SqlDa = New SqlDataAdapter(glComand)
            SqlDa.Fill(dtOrdenes)
            MsgBox("¡Producto Actualizado Exitosamente!", vbYes, "Éxito")

        Catch ex As Exception
            MsgBox("Hubo un error... inténtelo de nuevo", vbYes, "Error")
        Finally
            If mYConn.State <> ConnectionState.Closed Then
                mYConn.Close()
            End If
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim openFileDialog1 As New OpenFileDialog
            openFileDialog1.InitialDirectory = "C:\"
            openFileDialog1.CheckFileExists = True
            openFileDialog1.ShowDialog()
            If openFileDialog1.FileName = "" Then
                IMAGEN = openFileDialog1.FileName
                Dim largo As Integer = IMAGEN.Length
                Dim imagen2 As String
                imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(IMAGEN), largo - 2, largo))
                If imagen2 <> "gif" And imagen2 <> "bmp" And imagen2 <> "jpg" And imagen2 <> "jpeg" And imagen2 <> "GIF" And imagen2 <> "BMP" And imagen2 <> "JPG" And imagen2 <> "JPEG" Then
                    imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(IMAGEN), largo - 3, largo))
                    If imagen2 <> "jpeg" And imagen2 <> "JPEG" And imagen2 <> "log1" Then
                        MsgBox("Formato no valido") : Exit Sub
                        If imagen2 <> "log1" Then Exit Sub
                    End If

                End If
            End If
            extension = GetExtension(openFileDialog1.FileName)
            nombreImagen = openFileDialog1.FileName
            PictureBox1.Image = Image.FromFile(openFileDialog1.FileName)
            agarroImagen = "Si"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 45 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 45 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class