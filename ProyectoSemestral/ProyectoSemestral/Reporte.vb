Imports System.Data.SqlClient
Public Class Reporte
    Private Sub Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Top = Me.Height / 7 - (Label1.Height / 2)
        GroupBox1.Top = Me.Height / 2 - (GroupBox1.Height / 2)

        Label1.Left = Me.Width / 2 - (Label1.Width / 2)
        GroupBox1.Left = Me.Width / 2 - (GroupBox1.Width / 2)

        Label1.BackColor = Color.FromArgb(230, 64, 64, 64)
        GroupBox1.BackColor = Color.FromArgb(230, 64, 64, 64)

        Dim glComand As New SqlCommand
        Dim dtOrdenes As New DataTable
        Dim SqlDa As SqlDataAdapter
        Dim total As Double

        glComand.Connection = mYConn
        glComand.CommandText = "SP_Reporte"

        glComand.CommandTimeout = 0
        glComand.CommandType = CommandType.StoredProcedure
        Try
            mYConn.Open()
            glComand.ExecuteNonQuery()
            SqlDa = New SqlDataAdapter(glComand)
            SqlDa.Fill(dtOrdenes)

            If dtOrdenes.Rows.Count <> 0 Then
                dtg1.DataSource = dtOrdenes
                For x = 0 To dtOrdenes.Rows.Count - 1
                    dtg1.Item(5, x).Value = Convert.ToDouble(FormatNumber(CDbl(dtg1.Item(5, x).Value), 2))
                    total = total + dtg1.Item(5, x).Value
                Next
                txtTotal.Text = txtTotal.Text & total
            Else
                txtTotal.Text = "No hay datos para desplegar"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If mYConn.State <> ConnectionState.Closed Then
                mYConn.Close()
            End If
        End Try
    End Sub

    Private Sub Reporte_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Bienvenida.MdiParent = MenuPrincipal
        Bienvenida.WindowState = FormWindowState.Maximized
        Bienvenida.Show()
    End Sub
End Class