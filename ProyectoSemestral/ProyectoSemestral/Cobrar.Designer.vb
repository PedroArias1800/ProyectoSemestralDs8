<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cobrar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtg2 = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dtg1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.Label()
        Me.cboProductos = New System.Windows.Forms.ComboBox()
        Me.lblProductos = New System.Windows.Forms.Label()
        Me.btnReiniciar = New System.Windows.Forms.Button()
        Me.btnCobrar = New System.Windows.Forms.Button()
        Me.txtNombreCompleto = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtg2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.dtg1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btnVolver)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.cboProductos)
        Me.GroupBox1.Controls.Add(Me.lblProductos)
        Me.GroupBox1.Controls.Add(Me.btnReiniciar)
        Me.GroupBox1.Controls.Add(Me.btnCobrar)
        Me.GroupBox1.Controls.Add(Me.txtNombreCompleto)
        Me.GroupBox1.Location = New System.Drawing.Point(49, 59)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(854, 405)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'dtg2
        '
        Me.dtg2.AllowUserToAddRows = False
        Me.dtg2.AllowUserToDeleteRows = False
        Me.dtg2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtg2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtg2.BackgroundColor = System.Drawing.Color.LightCoral
        Me.dtg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg2.GridColor = System.Drawing.Color.Maroon
        Me.dtg2.Location = New System.Drawing.Point(13, 128)
        Me.dtg2.Margin = New System.Windows.Forms.Padding(2)
        Me.dtg2.Name = "dtg2"
        Me.dtg2.ReadOnly = True
        Me.dtg2.RowHeadersWidth = 51
        Me.dtg2.RowTemplate.Height = 24
        Me.dtg2.Size = New System.Drawing.Size(434, 182)
        Me.dtg2.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(605, 171)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(187, 139)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'dtg1
        '
        Me.dtg1.AllowUserToAddRows = False
        Me.dtg1.AllowUserToDeleteRows = False
        Me.dtg1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtg1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtg1.BackgroundColor = System.Drawing.Color.LightCoral
        Me.dtg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg1.GridColor = System.Drawing.Color.Maroon
        Me.dtg1.Location = New System.Drawing.Point(826, 376)
        Me.dtg1.Margin = New System.Windows.Forms.Padding(2)
        Me.dtg1.Name = "dtg1"
        Me.dtg1.ReadOnly = True
        Me.dtg1.RowHeadersWidth = 51
        Me.dtg1.RowTemplate.Height = 24
        Me.dtg1.Size = New System.Drawing.Size(24, 25)
        Me.dtg1.TabIndex = 21
        Me.dtg1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 25)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Productos Seleccionados"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(511, 24)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 22)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "ID:"
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(4, 370)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(91, 31)
        Me.btnVolver.TabIndex = 15
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'txtId
        '
        Me.txtId.AutoSize = True
        Me.txtId.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(540, 24)
        Me.txtId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(30, 22)
        Me.txtId.TabIndex = 16
        Me.txtId.Text = "00"
        '
        'cboProductos
        '
        Me.cboProductos.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProductos.FormattingEnabled = True
        Me.cboProductos.Location = New System.Drawing.Point(605, 78)
        Me.cboProductos.Margin = New System.Windows.Forms.Padding(2)
        Me.cboProductos.Name = "cboProductos"
        Me.cboProductos.Size = New System.Drawing.Size(219, 29)
        Me.cboProductos.TabIndex = 15
        '
        'lblProductos
        '
        Me.lblProductos.AutoSize = True
        Me.lblProductos.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductos.Location = New System.Drawing.Point(510, 81)
        Me.lblProductos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProductos.Name = "lblProductos"
        Me.lblProductos.Size = New System.Drawing.Size(91, 22)
        Me.lblProductos.TabIndex = 14
        Me.lblProductos.Text = "Producto:"
        '
        'btnReiniciar
        '
        Me.btnReiniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReiniciar.Location = New System.Drawing.Point(307, 332)
        Me.btnReiniciar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReiniciar.Name = "btnReiniciar"
        Me.btnReiniciar.Size = New System.Drawing.Size(140, 36)
        Me.btnReiniciar.TabIndex = 13
        Me.btnReiniciar.Text = "Reiniciar"
        Me.btnReiniciar.UseVisualStyleBackColor = True
        '
        'btnCobrar
        '
        Me.btnCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCobrar.Location = New System.Drawing.Point(461, 332)
        Me.btnCobrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(140, 36)
        Me.btnCobrar.TabIndex = 12
        Me.btnCobrar.Text = "Confirmar"
        Me.btnCobrar.UseVisualStyleBackColor = True
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.AutoSize = True
        Me.txtNombreCompleto.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCompleto.Location = New System.Drawing.Point(8, 17)
        Me.txtNombreCompleto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.Size = New System.Drawing.Size(237, 30)
        Me.txtNombreCompleto.TabIndex = 1
        Me.txtNombreCompleto.Text = "Cliente Seleccionado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(461, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 36)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cobrar"
        '
        'Cobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 488)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Cobrar"
        Me.ShowIcon = False
        Me.Text = "Cobrar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents txtId As Label
    Friend WithEvents cboProductos As ComboBox
    Friend WithEvents lblProductos As Label
    Friend WithEvents btnReiniciar As Button
    Friend WithEvents btnCobrar As Button
    Friend WithEvents txtNombreCompleto As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtg1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dtg2 As DataGridView
End Class
