<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bienvenida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bienvenida))
        Me.gbxInfo = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.horaSistema = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBienvenida = New System.Windows.Forms.Label()
        Me.gbxInfo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxInfo
        '
        Me.gbxInfo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.gbxInfo.Controls.Add(Me.PictureBox1)
        Me.gbxInfo.Controls.Add(Me.horaSistema)
        Me.gbxInfo.Controls.Add(Me.Label2)
        Me.gbxInfo.Controls.Add(Me.Label1)
        Me.gbxInfo.Controls.Add(Me.txtBienvenida)
        Me.gbxInfo.Location = New System.Drawing.Point(18, 12)
        Me.gbxInfo.Name = "gbxInfo"
        Me.gbxInfo.Size = New System.Drawing.Size(1042, 404)
        Me.gbxInfo.TabIndex = 6
        Me.gbxInfo.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(832, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(191, 181)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'horaSistema
        '
        Me.horaSistema.AutoSize = True
        Me.horaSistema.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horaSistema.ForeColor = System.Drawing.Color.White
        Me.horaSistema.Location = New System.Drawing.Point(222, 331)
        Me.horaSistema.Name = "horaSistema"
        Me.horaSistema.Size = New System.Drawing.Size(245, 36)
        Me.horaSistema.TabIndex = 5
        Me.horaSistema.Text = "Hora del sistema:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(150, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(689, 36)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Elija una de las opciones de la barra de navegación"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 44)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Menu Principal"
        '
        'txtBienvenida
        '
        Me.txtBienvenida.AutoSize = True
        Me.txtBienvenida.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBienvenida.ForeColor = System.Drawing.Color.White
        Me.txtBienvenida.Location = New System.Drawing.Point(17, 89)
        Me.txtBienvenida.Name = "txtBienvenida"
        Me.txtBienvenida.Size = New System.Drawing.Size(155, 31)
        Me.txtBienvenida.TabIndex = 0
        Me.txtBienvenida.Text = "Bienvenido: "
        '
        'Bienvenida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1080, 701)
        Me.Controls.Add(Me.gbxInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Bienvenida"
        Me.Text = "Bienvenida"
        Me.gbxInfo.ResumeLayout(False)
        Me.gbxInfo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxInfo As GroupBox
    Friend WithEvents horaSistema As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBienvenida As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
