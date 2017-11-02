Public Class Form2
    Public aceptar As Boolean
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        aceptar = False
        Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DGBDACCESSDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.DGBDACCESSDataSet.Ventas)
        'TODO: esta línea de código carga datos en la tabla 'DGBDACCESSDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.DGBDACCESSDataSet.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'DGBDACCESSDataSet.Juegos' Puede moverla o quitarla según sea necesario.
        Me.JuegosTableAdapter.Fill(Me.DGBDACCESSDataSet.Juegos)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        aceptar = True
        Hide()
    End Sub

    Private Sub ComboBox1_Format(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ListControlConvertEventArgs) Handles ComboBox1.Format
        Dim r As DataRow = CType(e.ListItem, DataRowView).Row
        e.Value = r("Email") & "-" & r("Nombre")
    End Sub
End Class