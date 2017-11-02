Public Class juegos

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim NuevaFila As DataRowView

        juegosAlta.ShowDialog()
        juegosAlta.Text = "Nuevo"

        If juegosAlta.aceptar Then
            NuevaFila = JuegosBindingSource.AddNew
            NuevaFila("Nombre") = juegosAlta.TextBox1.Text
            NuevaFila("PrecioUnitarioCompra") = Val(juegosAlta.TextBox2.Text)
            NuevaFila("PEGI") = Val(juegosAlta.TextBox3.Text)
            NuevaFila("Stock") = juegosAlta.TextBox4.Text

            NuevaFila.EndEdit()

            JuegosTableAdapter.Update(DGBDACCESSDataSet)
        End If

        juegosAlta.Dispose()
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DGBDACCESSDataSet.Juegos' Puede moverla o quitarla según sea necesario.
        Me.JuegosTableAdapter.Fill(Me.DGBDACCESSDataSet.Juegos)
        ListBox1.SelectedIndex = -1
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim info As String
        If ListBox1.SelectedIndex = -1 Then
            Label3.Text = " "
            nombre.Text = " "
            nombre.Visible = False
        Else
            Label3.Text = "dasdasasdasdasd "
            nombre.Visible = True

        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim cadena As String
        cadena = TextBox1.Text.Trim()
        If cadena.Length > 0 Then
            'hay que crear una condición del tipo
            'nombre like '*enri*'
            'donde "enri" es lo que escribión el usuario

            JuegosBindingSource.Filter = "Nombre like '*" & cadena & "*'"
        Else
            JuegosBindingSource.Filter = ""
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim FilaActual As DataRowView, MiID As Long, i As Integer

        juegosAlta.Text = "Modificar"

        juegosAlta.TextBox1.Text = TextBox1.Text()


        JuegosBindingSource.MoveFirst()

        For i = 1 To JuegosBindingSource.Count
            FilaActual = JuegosBindingSource.Current
            JuegosBindingSource.MoveNext()
        Next

        juegosAlta.ShowDialog()

        If juegosAlta.aceptar Then
            MiID = JuegosBindingSource.Current("idJuegos")
            FilaActual = JuegosBindingSource.Current
            FilaActual("Nombre") = juegosAlta.TextBox1.Text
            FilaActual("PrecioUnitario") = Val(juegosAlta.TextBox2.Text)
            FilaActual("PEGI") = Val(juegosAlta.TextBox3.Text)
            FilaActual("STOCK") = juegosAlta.TextBox4.Text()

            FilaActual.EndEdit()
            JuegosTableAdapter.Update(DGBDACCESSDataSet)
            JuegosTableAdapter.Fill(DGBDACCESSDataSet.Juegos)
        End If

        juegosAlta.Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim NuevaFila As DataRowView

        NuevaFila = JuegosBindingSource.Current

        eliminarjuego.lblJuego.Text = NuevaFila("Nombre")

        eliminarjuego.ShowDialog()

        If eliminarjuego.aceptar Then
            NuevaFila.Delete()

        End If

        eliminarjuego.Dispose()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nombre.Click

    End Sub
End Class