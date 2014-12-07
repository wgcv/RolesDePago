Public Class ListaEmpleados
    Public lista As List(Of Empleado)
    Public Sub New()
        lista = New List(Of Empleado)

    End Sub
    Public Sub agregar(ByVal empleado As Empleado)
        lista.Add(empleado)

    End Sub
End Class
