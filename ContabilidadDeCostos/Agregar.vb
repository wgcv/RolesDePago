Public Class Agregar

    Private Sub btnGrabar_Click(sender As System.Object, e As System.EventArgs) Handles btnGrabar.Click
        Dim empleado As Empleado
        Dim salario As Decimal
        If (Decimal.TryParse(TxtSalario.Text, salario)) Then
            empleado = New Empleado(txtId.Text, txtNombre.Text, TxtCargo.Text, salario, dtpFecha.Value)
            ListaEmpleados.agregar(empleado)

            lblMensaje.Text = "Se ha grabado un empleado"
            Me.btnGrabar.Enabled = False

        Else
            lblMensaje.Text = "Ingrese un salario valido"
        End If



    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Agregar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblMensaje.Text = ""
    End Sub

    Private Sub lblMensaje_Click(sender As System.Object, e As System.EventArgs) Handles lblMensaje.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Dispose()

    End Sub
End Class