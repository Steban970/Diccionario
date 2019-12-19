Imports System.IO

Public Class Ventana1
    Dim list_diccionario As New List(Of String)
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ' Dim escribir As New StreamWriter("C: \Users\dyego\OneDrive\Escritorio\prueba.txt", True)
        Dim palabra, definicion, dic As String

        palabra = txtPalabra.Text

        definicion = txtSignificado.Text

        dic = palabra + ":" + definicion
        Dim item1 As ListViewItem
        item1 = New ListViewItem(palabra, 0)
        item1.SubItems.Add(palabra)
        item1.SubItems.Add(definicion)
        'cargar imagen 


        Ventana2.ListPalabras.Items.Add(item1)
        Ventana2.Show()
        Me.Hide()

        ' Dim ruta As String
        'ruta = "C:\Users\nicol\Desktop"
        'PictureBox1.Image = Image.FromFile(Ventana2 And Form(PictureBox1));

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtPalabra.Text = ""
        txtSignificado.Text = ""
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'If MsgBox("¿Desea abandonar el sistema?", MsgBoxStyle.Question + vbYesNo, "Aviso") = vbYes Then
        Me.Close()
        'End If
    End Sub

    Private Sub btnAgregarImagen_Click(sender As Object, e As EventArgs) Handles btnAgregarImagen.Click
        OpenFileDialog1.InitialDirectory = "C:\Users\nicol\Desktop"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            btnAgregar.Enabled = True
        End If
    End Sub

    Private Sub Ventana1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAgregar.Enabled = False
        If txtPalabra.Text = "" And txtSignificado.Text = "" Then
            MsgBox("Campos vacios")
        Else
            btnAgregar.Enabled = True
        End If
    End Sub
End Class
