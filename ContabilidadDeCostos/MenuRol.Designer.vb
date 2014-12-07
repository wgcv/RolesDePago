<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuRol
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
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnNomina = New System.Windows.Forms.Button()
        Me.btnDetalle = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(53, 27)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(181, 53)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar Empleado"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnNomina
        '
        Me.btnNomina.Location = New System.Drawing.Point(53, 86)
        Me.btnNomina.Name = "btnNomina"
        Me.btnNomina.Size = New System.Drawing.Size(181, 53)
        Me.btnNomina.TabIndex = 1
        Me.btnNomina.Text = "Nómina"
        Me.btnNomina.UseVisualStyleBackColor = True
        '
        'btnDetalle
        '
        Me.btnDetalle.Location = New System.Drawing.Point(53, 145)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.Size = New System.Drawing.Size(181, 53)
        Me.btnDetalle.TabIndex = 2
        Me.btnDetalle.Text = "Detalle de Empleado"
        Me.btnDetalle.UseVisualStyleBackColor = True
        '
        'MenuRol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 243)
        Me.Controls.Add(Me.btnDetalle)
        Me.Controls.Add(Me.btnNomina)
        Me.Controls.Add(Me.btnAgregar)
        Me.Name = "MenuRol"
        Me.Text = "Sistema de Rol de Empleados"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnNomina As System.Windows.Forms.Button
    Friend WithEvents btnDetalle As System.Windows.Forms.Button

End Class
