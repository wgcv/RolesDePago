Public Class ListaEmpleados
    Public Shared listadeEmpleados As List(Of Empleado) = New List(Of Empleado)

    Public Shared Sub agregar(ByVal empleado As Empleado)
        listadeEmpleados.Add(empleado)

    End Sub
End Class
