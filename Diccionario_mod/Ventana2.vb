Public Class Ventana2
    Dim ListDiccionario As ListView
    Dim palabra, defnicion As String

    Private Sub ListPalabras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListPalabras.SelectedIndexChanged
        If ListPalabras.SelectedItems.Count > 0 Then

            Dim item As ListViewItem = ListPalabras.SelectedItems(0)

            Dim palabra As String = item.SubItems(1).Text
            Dim significado As String = item.SubItems(2).Text

            Ventana3.txtDescripcion.Text = palabra
            Ventana3.txtDescripcion.Text = significado

            Ventana3.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Ventana2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListDiccionario = ListDiccionario
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim item As ListViewItem = ListPalabras.SelectedItems(0)
        If (ListPalabras.SelectedIndex > -1) Then

            ' Eliminamos el elemento que se encuentra seleccionado 
            '
            ListPalabras.Items.RemoveAt(ListPalabras.SelectedIndex)

        End If

    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs)
        Dim save As New SaveFileDialog
        save.Filter = "Archivo.txt | *.txt"
        'condicion
        If save.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim archivo As New System.IO.StreamWriter(save.FileName)
            For Each item In ListPalabras.Items
                archivo.WriteLine(item.ToString())

            Next
            archivo.Close()
        End If
        'declaro respuesta 
        Dim respuesta As MsgBoxResult
        respuesta = MessageBox.Show("Desea vaciar su lista", "Nota", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = vbYes Then
            ListPalabras.Items.Clear()
        End If
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs)
        Dim destino As String = ""
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Archivos Text(*.Txt*.txt)|*.Txt;txt|Todos los archivos(*.*)|*-*"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                destino = .FileName
            End If
        End With
        'declarando y ciclo 
        Dim direccion As New System.IO.StreamReader(destino)
        While Not direccion.EndOfStream
            ListPalabras.Items.Add(direccion.ReadLine())
        End While
        direccion.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click

        Ventana1.Show()
        Me.Hide()
    End Sub
End Class