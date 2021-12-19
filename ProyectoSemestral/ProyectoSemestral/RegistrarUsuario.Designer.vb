<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnRegistrarUsuario = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.cboTipoCuenta = New System.Windows.Forms.ComboBox()
        Me.txtContraseña2 = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblContraseña2 = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgRU = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgRU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRegistrarUsuario
        '
        Me.btnRegistrarUsuario.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarUsuario.Location = New System.Drawing.Point(336, 351)
        Me.btnRegistrarUsuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRegistrarUsuario.Name = "btnRegistrarUsuario"
        Me.btnRegistrarUsuario.Size = New System.Drawing.Size(151, 38)
        Me.btnRegistrarUsuario.TabIndex = 7
        Me.btnRegistrarUsuario.Text = "Registrar"
        Me.btnRegistrarUsuario.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnRegistrarUsuario)
        Me.GroupBox1.Controls.Add(Me.lblTipo)
        Me.GroupBox1.Controls.Add(Me.cboTipoCuenta)
        Me.GroupBox1.Controls.Add(Me.txtContraseña2)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.lblApellido)
        Me.GroupBox1.Controls.Add(Me.lblContraseña2)
        Me.GroupBox1.Controls.Add(Me.txtContraseña)
        Me.GroupBox1.Controls.Add(Me.txtCedula)
        Me.GroupBox1.Controls.Add(Me.lblCedula)
        Me.GroupBox1.Controls.Add(Me.lblContraseña)
        Me.GroupBox1.Controls.Add(Me.txtCorreo)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Controls.Add(Me.lblCorreo)
        Me.GroupBox1.Location = New System.Drawing.Point(50, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(805, 405)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(473, 238)
        Me.lblTipo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(57, 25)
        Me.lblTipo.TabIndex = 14
        Me.lblTipo.Text = "Tipo:"
        '
        'cboTipoCuenta
        '
        Me.cboTipoCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoCuenta.FormattingEnabled = True
        Me.cboTipoCuenta.ItemHeight = 20
        Me.cboTipoCuenta.Location = New System.Drawing.Point(534, 238)
        Me.cboTipoCuenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboTipoCuenta.Name = "cboTipoCuenta"
        Me.cboTipoCuenta.Size = New System.Drawing.Size(245, 28)
        Me.cboTipoCuenta.TabIndex = 13
        '
        'txtContraseña2
        '
        Me.txtContraseña2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña2.Location = New System.Drawing.Point(153, 292)
        Me.txtContraseña2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtContraseña2.Name = "txtContraseña2"
        Me.txtContraseña2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña2.Size = New System.Drawing.Size(245, 28)
        Me.txtContraseña2.TabIndex = 12
        Me.txtContraseña2.Tag = ""
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(534, 104)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(245, 28)
        Me.txtApellido.TabIndex = 11
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(438, 106)
        Me.lblApellido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(92, 25)
        Me.lblApellido.TabIndex = 9
        Me.lblApellido.Text = "Apellido:"
        '
        'lblContraseña2
        '
        Me.lblContraseña2.AutoSize = True
        Me.lblContraseña2.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblContraseña2.Location = New System.Drawing.Point(27, 294)
        Me.lblContraseña2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblContraseña2.Name = "lblContraseña2"
        Me.lblContraseña2.Size = New System.Drawing.Size(122, 25)
        Me.lblContraseña2.TabIndex = 10
        Me.lblContraseña2.Text = "Contraseña:"
        '
        'txtContraseña
        '
        Me.txtContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.Location = New System.Drawing.Point(153, 236)
        Me.txtContraseña.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(245, 28)
        Me.txtContraseña.TabIndex = 8
        '
        'txtCedula
        '
        Me.txtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(534, 168)
        Me.txtCedula.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(245, 28)
        Me.txtCedula.TabIndex = 7
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(449, 170)
        Me.lblCedula.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(81, 25)
        Me.lblCedula.TabIndex = 5
        Me.lblCedula.Text = "Cédula:"
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblContraseña.Location = New System.Drawing.Point(27, 236)
        Me.lblContraseña.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(122, 25)
        Me.lblContraseña.TabIndex = 6
        Me.lblContraseña.Text = "Contraseña:"
        '
        'txtCorreo
        '
        Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(153, 169)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(245, 28)
        Me.txtCorreo.TabIndex = 4
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(153, 105)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(245, 28)
        Me.txtNombre.TabIndex = 3
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(57, 107)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(92, 25)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre:"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblCorreo.Location = New System.Drawing.Point(70, 171)
        Me.lblCorreo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(79, 25)
        Me.lblCorreo.TabIndex = 2
        Me.lblCorreo.Text = "Correo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(290, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "REGISTRAR USUARIO"
        '
        'dtgRU
        '
        Me.dtgRU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgRU.Location = New System.Drawing.Point(891, 438)
        Me.dtgRU.Name = "dtgRU"
        Me.dtgRU.RowHeadersWidth = 51
        Me.dtgRU.Size = New System.Drawing.Size(17, 17)
        Me.dtgRU.TabIndex = 8
        Me.dtgRU.Visible = False
        '
        'RegistrarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectoSemestral.My.Resources.Resources.registrar_usuario_fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(920, 467)
        Me.ControlBox = False
        Me.Controls.Add(Me.dtgRU)
        Me.Controls.Add(Me.GroupBox1)
        Me.HelpButton = True
        Me.Name = "RegistrarUsuario"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistrarUsuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgRU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRegistrarUsuario As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtContraseña2 As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblContraseña2 As Label
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents lblCedula As Label
    Friend WithEvents lblContraseña As Label
    Friend WithEvents cboTipoCuenta As ComboBox
    Friend WithEvents lblTipo As Label
    Friend WithEvents dtgRU As DataGridView
End Class
