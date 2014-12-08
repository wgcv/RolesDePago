Public Class Empleado
    Private id As String
    Private nombre As String
    Private cargo As String
    Private salario As Decimal
    Private fecha As Date
    Public extras As List(Of extra)
    Private descuentos As Decimal




    Public Sub New(ByVal id As String, nombre As String, cargo As String, salario As Decimal, fecha As Date)
        Me.id = id
        Me.nombre = nombre
        Me.cargo = cargo
        Me.salario = salario
        Me.fecha = fecha
        Me.extras = New List(Of extra)

    End Sub
    Public Function ValorExtras() As Decimal
        Dim valor As Decimal = 0



        For Each item As extra In extras
            valor += item.valor(salario)

        Next
        Return valor
    End Function
    Public Sub AgregarExtras(ByVal lista As List(Of extra))
        Me.extras = lista
    End Sub
    Public Function SuedloConExtras() As Decimal
        Return (salario + ValorExtras())
    End Function
    Public Function decimoTercero() As Decimal
        Return (salario + ValorExtras()) / 12
    End Function

    Public Function fondosReserva() As Decimal
        Dim fecha As Date = Date.Now()
        Dim dias As Integer
        dias = (fecha - Me.fecha).TotalDays
        If (dias > 360) Then
            Return (salario + ValorExtras()) / 12
        Else
            Return 0
        End If


    End Function
    Public Function iess() As Decimal
        Return (SuedloConExtras() * 11.35) / 100


    End Function
    Public Class extra
        Public porcentaje As Decimal
        Public horas As Decimal
        Public Sub New(ByVal porcentaje As Decimal, horas As Decimal)
            Me.horas = horas
            Me.porcentaje = porcentaje

        End Sub
        Public Function valor(ByVal salario) As Decimal
            Return ((porcentaje * (salario / 167.33)) * horas)
        End Function

    End Class
    Public ReadOnly Property getNombre() As String
        Get
            Return nombre
        End Get

    End Property
    Public ReadOnly Property getId() As String
        Get
            Return id
        End Get

    End Property
    Public ReadOnly Property getCargo() As String
        Get
            Return cargo
        End Get
    End Property
    Public ReadOnly Property getsueldo() As String
        Get
            Return salario
        End Get

    End Property
    Public ReadOnly Property getExtra() As String
        Get
            Return ValorExtras()
        End Get

    End Property

    Public ReadOnly Property getSuedloConExtras() As String
        Get
            Return SuedloConExtras()
        End Get

    End Property
    Public ReadOnly Property getFondosReserva() As String
        Get
            Return fondosReserva()
        End Get

    End Property
    Public ReadOnly Property getIess() As String
        Get
            Return iess()
        End Get

    End Property
    Public ReadOnly Property getDescuentos() As String
        Get
            Return descuentos
        End Get

    End Property

    Public ReadOnly Property getTotalRecibir() As String
        Get
            Return (salario + ValorExtras() + fondosReserva() - iess() - descuentos)
        End Get

    End Property
End Class
