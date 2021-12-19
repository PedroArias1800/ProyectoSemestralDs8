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
        Me.btnRegistrarUsuario.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnRegistrarUsuario.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarUsuario.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarUsuario.Location = New System.Drawing.Point(490, 464)
        Me.btnRegistrarUsuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegistrarUsuario.Name = "btnRegistrarUsuario"
        Me.btnRegistrarUsuario.Size = New System.Drawing.Size(201, 47)
        Me.btnRegistrarUsuario.TabIndex = 7
        Me.btnRegistrarUsuario.Text = "Registrar"
        Me.btnRegistrarUsuario.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
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
        Me.GroupBox1.Location = New System.Drawing.Point(67, 103)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1073, 334)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.White
        Me.lblTipo.Location = New System.Drawing.Point(609, 198)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(70, 31)
        Me.lblTipo.TabIndex = 14
        Me.lblTipo.Text = "Tipo:"
        '
        'cboTipoCuenta
        '
        Me.cboTipoCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoCuenta.ForeColor = System.Drawing.Color.Black
        Me.cboTipoCuenta.FormattingEnabled = True
        Me.cboTipoCuenta.ItemHeight = 25
        Me.cboTipoCuenta.Location = New System.Drawing.Point(691, 198)
        Me.cboTipoCuenta.Margin = New System.Windows.Forms.Padding(5)
        Me.cboTipoCuenta.Name = "cboTipoCuenta"
        Me.cboTipoCuenta.Size = New System.Drawing.Size(325, 33)
        Me.cboTipoCuenta.TabIndex = 13
        '
        'txtContraseña2
        '
        Me.txtContraseña2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña2.ForeColor = System.Drawing.Color.Black
        Me.txtContraseña2.Location = New System.Drawing.Point(208, 265)
        Me.txtContraseña2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtContraseña2.Name = "txtContraseña2"
        Me.txtContraseña2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña2.Size = New System.Drawing.Size(325, 34)
        Me.txtContraseña2.TabIndex = 12
        Me.txtContraseña2.Tag = ""
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.ForeColor = System.Drawing.Color.Black
        Me.txtApellido.Location = New System.Drawing.Point(691, 33)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(325, 34)
        Me.txtApellido.TabIndex = 11
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.ForeColor = System.Drawing.Color.White
        Me.lblApellido.Location = New System.Drawing.Point(563, 36)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(114, 31)
        Me.lblApellido.TabIndex = 9
        Me.lblApellido.Text = "Apellido:"
        '
        'lblContraseña2
        '
        Me.lblContraseña2.AutoSize = True
        Me.lblContraseña2.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña2.ForeColor = System.Drawing.Color.White
        Me.lblContraseña2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblContraseña2.Location = New System.Drawing.Point(40, 267)
        Me.lblContraseña2.Name = "lblContraseña2"
        Me.lblContraseña2.Size = New System.Drawing.Size(150, 31)
        Me.lblContraseña2.TabIndex = 10
        Me.lblContraseña2.Text = "Contraseña:"
        '
        'txtContraseña
        '
        Me.txtContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.ForeColor = System.Drawing.Color.Black
        Me.txtContraseña.Location = New System.Drawing.Point(208, 196)
        Me.txtContraseña.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(325, 34)
        Me.txtContraseña.TabIndex = 8
        '
        'txtCedula
        '
        Me.txtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.ForeColor = System.Drawing.Color.Black
        Me.txtCedula.Location = New System.Drawing.Point(691, 112)
        Me.txtCedula.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(325, 34)
        Me.txtCedula.TabIndex = 7
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.ForeColor = System.Drawing.Color.White
        Me.lblCedula.Location = New System.Drawing.Point(577, 114)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(99, 31)
        Me.lblCedula.TabIndex = 5
        Me.lblCedula.Text = "Cédula:"
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.ForeColor = System.Drawing.Color.White
        Me.lblContraseña.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblContraseña.Location = New System.Drawing.Point(40, 196)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(150, 31)
        Me.lblContraseña.TabIndex = 6
        Me.lblContraseña.Text = "Contraseña:"
        '
        'txtCorreo
        '
        Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.ForeColor = System.Drawing.Color.Black
        Me.txtCorreo.Location = New System.Drawing.Point(208, 113)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(325, 34)
        Me.txtCorreo.TabIndex = 4
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Location = New System.Drawing.Point(208, 34)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(325, 34)
        Me.txtNombre.TabIndex = 3
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(80, 37)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(115, 31)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre:"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.ForeColor = System.Drawing.Color.White
        Me.lblCorreo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblCorreo.Location = New System.Drawing.Point(97, 116)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(98, 31)
        Me.lblCorreo.TabIndex = 2
        Me.lblCorreo.Text = "Correo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(456, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 39)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Registrar Usuario"
        '
        'dtgRU
        '
        Me.dtgRU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgRU.Location = New System.Drawing.Point(1188, 539)
        Me.dtgRU.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgRU.Name = "dtgRU"
        Me.dtgRU.RowHeadersWidth = 51
        Me.dtgRU.Size = New System.Drawing.Size(23, 21)
        Me.dtgRU.TabIndex = 8
        Me.dtgRU.Visible = False
        '
        'RegistrarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectoSemestral.My.Resources.Resources.verdeCompleto
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1227, 575)
        Me.ControlBox = False
        Me.Controls.Add(Me.dtgRU)
        Me.Controls.Add(Me.btnRegistrarUsuario)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "RegistrarUsuario"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistrarUsuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgRU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
