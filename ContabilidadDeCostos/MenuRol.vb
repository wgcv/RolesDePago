Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

Public Class MenuRol


    Private Sub MenuRol_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim myFileStream As Stream = File.Create("SavedLoan.bin")
        Dim serializer As New BinaryFormatter()
        serializer.Serialize(myFileStream, ListaEmpleados.listadeEmpleados)
        myFileStream.Close()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If File.Exists("SavedLoan.bin") Then
            Dim myFileStream As Stream = File.OpenRead("SavedLoan.bin")
            Dim deserializer As New BinaryFormatter()
            ListaEmpleados.listadeEmpleados = CType(deserializer.Deserialize(myFileStream), List(Of Empleado))
            myFileStream.Close()
        End If

    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        Agregar.Show()

    End Sub

    Private Sub btnNomina_Click(sender As System.Object, e As System.EventArgs) Handles btnNomina.Click
        Nomina.Show()


    End Sub

    Private Sub btnDetalle_Click(sender As System.Object, e As System.EventArgs) Handles btnDetalle.Click
        Detalle.Show()

    End Sub
End Class
