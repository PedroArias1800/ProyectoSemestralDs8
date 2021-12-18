Public Class Actualizar
    Private Sub Actualizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Escribiendo textos
        If accion = "U" Then
            Label1.Text = "Actualizar Usuarios"
            Label2.Text = "Seleccione un usuario de la lista"
        ElseIf accion = "C" Then
            Label1.Text = "Actualizar Clientes"
            Label2.Text = "Seleccione un cliente de la lista"
        ElseIf accion = "P" Then
            Label1.Text = "Actualizar Productos"
            Label2.Text = "Seleccione un producto de la lista"
        Else
            MsgBox("Ha ocurrido un error inesperado...", vbYes, "Error")
            MenuPrincipal.Show()
            Me.Hide()
        End If

        'Centrando elementos
        Label1.Left = Me.Width / 2 - (Label1.Width / 2)
        Label2.Left = Me.Width / 2 - (Label2.Width / 2)
        GroupBox1.Left = Me.Width / 2 - (GroupBox1.Width / 2)
    End Sub

    Private Sub Actualizar_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        mostrar = "Si"
    End Sub
End Class