Public Class Empleado
    Private nombre As String
    Private cargo As String
    Private salario As Decimal
    Private fecha As Date
    Private extras As List(Of extra)


    Public Sub New(ByVal nombre As String, cargo As String, salario As Decimal, fecha As Date)
        Me.nombre = nombre
        Me.cargo = cargo
        Me.salario = salario
        Me.fecha = fecha
        Me.extras = New List(Of extra)

    End Sub
    Public Function ValorExtras() As Decimal
        Dim valor As Decimal = 0

        Return (0)

        For Each item As extra In extras
            valor += item.valor()

        Next

    End Function
    Public Sub AgregarExtras(ByVal porcentaje As Decimal, horas As Decimal)
        Dim HoraExtra As extra
        HoraExtra = New extra(porcentaje, horas)
        extras.Add(HoraExtra)

    End Sub

    Public Class extra
        Dim porcentaje As Decimal
        Dim horas As Decimal
        Public Sub New(ByVal porcentaje As Decimal, horas As Decimal)
            Me.horas = horas
            Me.porcentaje = porcentaje

        End Sub
        Public Function valor() As Decimal
            Return (porcentaje * horas)
        End Function

    End Class
End Class
