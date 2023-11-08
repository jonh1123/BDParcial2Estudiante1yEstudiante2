<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbApellido = New System.Windows.Forms.TextBox()
        Me.cbDepartamento = New System.Windows.Forms.ComboBox()
        Me.cbMunicipio = New System.Windows.Forms.ComboBox()
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(308, 97)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(178, 22)
        Me.tbNombre.TabIndex = 0
        '
        'tbApellido
        '
        Me.tbApellido.Location = New System.Drawing.Point(308, 152)
        Me.tbApellido.Name = "tbApellido"
        Me.tbApellido.Size = New System.Drawing.Size(178, 22)
        Me.tbApellido.TabIndex = 1
        '
        'cbDepartamento
        '
        Me.cbDepartamento.FormattingEnabled = True
        Me.cbDepartamento.Items.AddRange(New Object() {"Sonsonate", "San Miguel", "Chalatenango", "La Union"})
        Me.cbDepartamento.Location = New System.Drawing.Point(308, 200)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(178, 24)
        Me.cbDepartamento.TabIndex = 2
        '
        'cbMunicipio
        '
        Me.cbMunicipio.FormattingEnabled = True
        Me.cbMunicipio.Location = New System.Drawing.Point(308, 260)
        Me.cbMunicipio.Name = "cbMunicipio"
        Me.cbMunicipio.Size = New System.Drawing.Size(178, 24)
        Me.cbMunicipio.TabIndex = 3
        '
        'btAceptar
        '
        Me.btAceptar.Location = New System.Drawing.Point(308, 316)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(160, 52)
        Me.btAceptar.TabIndex = 4
        Me.btAceptar.Text = "Aceptar"
        Me.btAceptar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(305, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Parcial 2 -Progracion"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btAceptar)
        Me.Controls.Add(Me.cbMunicipio)
        Me.Controls.Add(Me.cbDepartamento)
        Me.Controls.Add(Me.tbApellido)
        Me.Controls.Add(Me.tbNombre)
        Me.Name = "Form1"
        Me.Text = "Parcial 2 - Programcion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbApellido As TextBox
    Friend WithEvents cbDepartamento As ComboBox
    Friend WithEvents cbMunicipio As ComboBox
    Friend WithEvents btAceptar As Button
    Friend WithEvents Label1 As Label
End Class
