Imports ContabilidadDeCostos.Empleado

Public Class Detalle
    Dim numextras As String = 1
    Dim empleado As Empleado
    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Detalle_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblNombre.Text = ""
    End Sub

    Private Sub lblNombre_Click(sender As System.Object, e As System.EventArgs) Handles lblNombre.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub btnAgregarHoras_Click(sender As System.Object, e As System.EventArgs)
        Dim horas As Label = New Label()
        Dim porcentaje As Label = New Label()
    End Sub

    Private Sub GroupBox3_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim panel As FlowLayoutPanel = New FlowLayoutPanel()
        panel.FlowDirection = FlowDirection.LeftToRight
        panel.AutoSize = True
        Dim hora As Label = New Label()
        hora.Text = "Horas"
        hora.Dock = DockStyle.Bottom
        Dim porcentaje As Label = New Label()
        porcentaje.Text = "Porcentaje"
        porcentaje.Dock = DockStyle.Bottom
        Dim txthora As TextBox = New TextBox()
        Dim txtporcentaje As TextBox = New TextBox()
        txtporcentaje.Text = "1,50"
        panel.Controls.Add(hora)
        panel.Controls.Add(txthora)
        panel.Controls.Add(porcentaje)
        panel.Controls.Add(txtporcentaje)
        FlowLayoutPanel1.Controls.Add(panel)

    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Empleado = ListaEmpleados.buscar(txtCedula.Text)

        If (empleado IsNot Nothing) Then
            GroupBox2.Visible = True
            lblNombre.Visible = True
            lblNombre.Text = empleado.getNombre()
            txtDecimo3.Text = (empleado.getSuedloConExtras / 12)
            txtVacaciones.Text = (empleado.getSuedloConExtras / 12) / 2
            txtdecimo4.Text = "28,33"
            txtTotal.Text = Convert.ToDecimal(txtDecimo3.Text) + Convert.ToDecimal(txtVacaciones.Text) + Convert.ToDecimal(txtdecimo4.Text)
            d3.Text = (empleado.getSuedloConExtras / 12) * Month(Now)
            va.Text = ((empleado.getSuedloConExtras / 12) / 2) * Month(Now)
            d4.Text = Convert.ToDecimal(28.33 * Month(Now))
            t.Text = Convert.ToDecimal(d3.Text) + Convert.ToDecimal(va.Text) + Convert.ToDecimal(d4.Text)

            For Each item As extra In empleado.extras
                Dim panel As FlowLayoutPanel = New FlowLayoutPanel()
                panel.FlowDirection = FlowDirection.LeftToRight
                panel.AutoSize = True
                Dim hora As Label = New Label()
                hora.Text = "Horas"
                hora.Dock = DockStyle.Bottom
                Dim porcentaje As Label = New Label()
                porcentaje.Text = "Porcentaje"
                porcentaje.Dock = DockStyle.Bottom
                Dim txthora As TextBox = New TextBox()
                Dim txtporcentaje As TextBox = New TextBox()
                txtporcentaje.Text = item.porcentaje
                txthora.Text = item.horas
                panel.Controls.Add(hora)
                panel.Controls.Add(txthora)
                panel.Controls.Add(porcentaje)
                panel.Controls.Add(txtporcentaje)
                FlowLayoutPanel1.Controls.Add(panel)
            Next


        Else
            MsgBox("No existe el empleado")
        End If

    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Dim listadeextras As extra
        Dim extras As List(Of extra) = New List(Of extra)
        Dim horas, porcentajes As Decimal
        For Each ctrl As Control In FlowLayoutPanel1.Controls
            Dim hora As TextBox = DirectCast(ctrl.Controls.Item(1), TextBox)
            Dim porcentaje As TextBox = DirectCast(ctrl.Controls.Item(3), TextBox)
            If (Decimal.TryParse(hora.Text, horas) And Decimal.TryParse(porcentaje.Text, porcentajes)) Then
                listadeextras = New extra(horas, porcentajes)
                extras.Add(listadeextras)
            End If
        Next
        empleado.AgregarExtras(extras)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim desc As Decimal
        If (Decimal.TryParse(TextBox1.Text, desc)) Then
            empleado.descuento(desc)
        End If

    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox4_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox4.Enter

    End Sub
End Class