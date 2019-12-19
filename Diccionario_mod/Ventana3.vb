Public Class Ventana3
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Ventana2.Show()
        Me.Hide()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim palabra, definicion, dic As String

        definicion = txtDescripcion.Text
        dic = palabra + ":" + definicion
        Dim item1 As ListViewItem
        item1 = New ListViewItem(palabra, 0)
        item1.SubItems.Add(palabra)
        item1.SubItems.Add(definicion)
        Ventana2.ListPalabras.Items.Add(item1)
        Ventana2.ListPalabras.Refresh()
        Ventana2.Show()
        Me.Hide()
    End Sub


End Class