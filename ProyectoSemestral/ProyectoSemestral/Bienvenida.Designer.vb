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
        Me.gbxInfo.Controls.Add(Me.PictureBox1)
        Me.gbxInfo.Controls.Add(Me.horaSistema)
        Me.gbxInfo.Controls.Add(Me.Label2)
        Me.gbxInfo.Controls.Add(Me.Label1)
        Me.gbxInfo.Controls.Add(Me.txtBienvenida)
        Me.gbxInfo.Location = New System.Drawing.Point(14, 10)
        Me.gbxInfo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxInfo.Name = "gbxInfo"
        Me.gbxInfo.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxInfo.Size = New System.Drawing.Size(782, 328)
        Me.gbxInfo.TabIndex = 6
        Me.gbxInfo.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(624, 18)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 148)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'horaSistema
        '
        Me.horaSistema.AutoSize = True
        Me.horaSistema.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horaSistema.Location = New System.Drawing.Point(166, 269)
        Me.horaSistema.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.horaSistema.Name = "horaSistema"
        Me.horaSistema.Size = New System.Drawing.Size(194, 30)
        Me.horaSistema.TabIndex = 5
        Me.horaSistema.Text = "Hora del sistema:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 219)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(552, 30)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Elija una de las opciones de la barra de navegación"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Menu Principal"
        '
        'txtBienvenida
        '
        Me.txtBienvenida.AutoSize = True
        Me.txtBienvenida.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBienvenida.Location = New System.Drawing.Point(13, 72)
        Me.txtBienvenida.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtBienvenida.Name = "txtBienvenida"
        Me.txtBienvenida.Size = New System.Drawing.Size(125, 25)
        Me.txtBienvenida.TabIndex = 0
        Me.txtBienvenida.Text = "Bienvenido: "
        '
        'Bienvenida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectoSemestral.My.Resources.Resources.menu_fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(810, 570)
        Me.Controls.Add(Me.gbxInfo)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
