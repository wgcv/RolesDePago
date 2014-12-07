Public Class Detalle
    Dim numextras As String = 1
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
        txtporcentaje.Text = "0.50"
        panel.Controls.Add(hora)
        panel.Controls.Add(txthora)
        panel.Controls.Add(porcentaje)
        panel.Controls.Add(txtporcentaje)
        FlowLayoutPanel1.Controls.Add(panel)

    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        GroupBox2.Visible = True
        lblNombre.Visible = True
        lblNombre.Text = "NOMBRE"
    End Sub
End Class