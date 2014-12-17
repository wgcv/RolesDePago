<Serializable()> Public Class ListaEmpleados
    Public Shared listadeEmpleados As List(Of Empleado) = New List(Of Empleado)

    Public Shared Sub agregar(ByVal empleado As Empleado)
        listadeEmpleados.Add(empleado)

    End Sub
    Public Shared Function buscar(ByRef cedula As String) As Empleado

        For Each item As Empleado In listadeEmpleados
            If (item.getId() = cedula) Then
                Return item

            End If

        Next
        Return Nothing

    End Function
End Class
