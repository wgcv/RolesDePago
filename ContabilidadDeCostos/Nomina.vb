Public Class Nomina

    Private Sub Nomina_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        DataGridView1.AutoGenerateColumns = False

        DataGridView1.DataSource = ListaEmpleados.listadeEmpleados
        Dim column As DataGridViewColumn = New DataGridViewTextBoxColumn()
        column.DataPropertyName = "getId"
        column.Name = "Identificación"
        DataGridView1.Columns.Add(column)
        column = New DataGridViewTextBoxColumn()
        column.DataPropertyName = "getNombre"
        column.Name = "Nombre"
        DataGridView1.Columns.Add(column)
        column = New DataGridViewTextBoxColumn()
        column.DataPropertyName = "getCargo"
        column.Name = "Cargo"
        DataGridView1.Columns.Add(column)
        column = New DataGridViewTextBoxColumn()
        column.DataPropertyName = "getsueldo"
        column.Name = "Sueldo"
        DataGridView1.Columns.Add(column)
        column = New DataGridViewTextBoxColumn()
        column.DataPropertyName = "getExtra"
        column.Name = "Horas Extras"
        DataGridView1.Columns.Add(column)
        column = New DataGridViewTextBoxColumn()
        column.DataPropertyName = "getSuedloConExtras"
        column.Name = "SubTotal"
        DataGridView1.Columns.Add(column)
        column = New DataGridViewTextBoxColumn()
        column.DataPropertyName = "getFondosReserva"
        column.Name = "Fondos De Reserva"
        DataGridView1.Columns.Add(column)
        column = New DataGridViewTextBoxColumn()
        column.DataPropertyName = "getIess"
        column.Name = "Aporte al IESS"
        DataGridView1.Columns.Add(column)
        column = New DataGridViewTextBoxColumn()
        column.DataPropertyName = "getDescuentos"
        column.Name = "Descuentos"
        DataGridView1.Columns.Add(column)
        column = New DataGridViewTextBoxColumn()
        column.DataPropertyName = "getTotalRecibir"
        column.Name = "Total de sueldo"
        DataGridView1.Columns.Add(column)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class