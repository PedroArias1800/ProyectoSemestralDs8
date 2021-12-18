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
        Me.gbxInfo = New System.Windows.Forms.GroupBox()
        Me.horaSistema = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBienvenida = New System.Windows.Forms.Label()
        Me.gbxInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxInfo
        '
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
        'horaSistema
        '
        Me.horaSistema.AutoSize = True
        Me.horaSistema.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Label1.Location = New System.Drawing.Point(15, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 44)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Menu Principal"
        '
        'txtBienvenida
        '
        Me.txtBienvenida.AutoSize = True
        Me.txtBienvenida.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.ClientSize = New System.Drawing.Size(1080, 701)
        Me.Controls.Add(Me.gbxInfo)
        Me.Name = "Bienvenida"
        Me.Text = "Bienvenida"
        Me.gbxInfo.ResumeLayout(False)
        Me.gbxInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxInfo As GroupBox
    Friend WithEvents horaSistema As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBienvenida As Label
End Class
