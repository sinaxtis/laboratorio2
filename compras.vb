Public Class compras
    Dim aceptar As Boolean
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DGBDACCESSDataSet.Compras' Puede moverla o quitarla según sea necesario.
        Me.ComprasTableAdapter.Fill(Me.DGBDACCESSDataSet.Compras)
        'TODO: esta línea de código carga datos en la tabla 'DGBDACCESSDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.DGBDACCESSDataSet.Proveedor)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        vercompras.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)





    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim NuevaFila As DataRowView

        Form13.ShowDialog()
        Form13.Text = "Nueva Compra"

        If Form13.aceptar Then
            NuevaFila = ComprasBindingSource.AddNew
            NuevaFila("Precio") = Val(Form13.TextBox1.Text)
            NuevaFila("Medio de Pago") = Form13.ComboBox2.Text
            NuevaFila("Fecha") = Form13.DateTimePicker1.Value.Date
            NuevaFila("Cantidad") = Val(Form13.TextBox3.Text)
            NuevaFila.EndEdit()

            ComprasTableAdapter.Update(DGBDACCESSDataSet)
        End If

        Form13.Dispose()
    End Sub

    Private Sub ListBox1_Format(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ListControlConvertEventArgs) Handles ListBox1.Format
        Dim r As DataRow = CType(e.ListItem, DataRowView).Row
        e.Value = "Precio:" & r("Precio") & " Fecha: " & r("Fecha")
    End Sub
End Class