Public Class ventas

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DGBDACCESSDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.DGBDACCESSDataSet.Ventas)

    End Sub

    Private Sub ListBox1_Format(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ListControlConvertEventArgs) Handles ListBox1.Format
        Dim r As DataRow = CType(e.ListItem, DataRowView).Row
        e.Value = "Fecha:" & r("Fecha") & " Total " & r("Total")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim NuevaFila As DataRowView

        Form2.ShowDialog()
        Form2.Text = "Nueva venta"

        If Form2.aceptar Then
            NuevaFila = VentasBindingSource.AddNew()
            NuevaFila("Precio") = Form2.TextBox1.Text
            NuevaFila("Fecha") = Form2.DateTimePicker1.Value.Date
            NuevaFila("Medio de pago") = Form2.ComboBox3.Text

            NuevaFila.EndEdit()

            VentasTableAdapter.Update(DGBDACCESSDataSet)
        End If

        Form2.Dispose()
    End Sub
End Class