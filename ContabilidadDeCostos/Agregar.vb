Public Class Agregar

    Private Sub btnGrabar_Click(sender As System.Object, e As System.EventArgs) Handles btnGrabar.Click
        Dim empleado As Empleado
        Dim salario As Decimal
        If (Decimal.TryParse(TxtSalario.Text, salario)) Then
            empleado = New Empleado(txtNombre.Text, TxtCargo.Text, salario, dtpFecha.Value)

            lblMensaje.Text = "Se ha grabado un empleado"
        Else
            lblMensaje.Text = "Ingrese un salario valido"
        End If


    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Agregar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblMensaje.Text = ""
    End Sub
End Class