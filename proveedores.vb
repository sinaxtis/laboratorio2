Public Class proveedores
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DGBDACCESSDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.DGBDACCESSDataSet.Proveedor)
        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim info As String
        If ComboBox1.SelectedIndex = -1 Then
            Label4.Text = " "
        Else
            ProveedorBindingSource.Filter = "idProveedor =" & ComboBox1.SelectedValue & ""
            info = ProveedorBindingSource.Current("Mail").ToString
            Label4.Text = info
            ProveedorBindingSource.RemoveFilter()

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class