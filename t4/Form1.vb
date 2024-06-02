
Imports System.Drawing.Printing
Public Class Form1
    Private WithEvents Myprintdocument As New PrintDocument
    Private selecteditems As New List(Of String)






    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        cblinpacitados.Items.Add(txtpersonas.Text)
        txtpersonas.Clear()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i As Integer = cblinpacitados.CheckedItems.Count - 1 To 0 Step -1
            cblinpacitados.Items.Remove(cblinpacitados.CheckedItems(i))

        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        selecteditems.Clear()

        For Each item As String In cblinpacitados.CheckedItems
            selecteditems.Add(item)
        Next

        Dim printDialog As New PrintDialog
        printDialog.Document = Myprintdocument


        If printDialog.ShowDialog() = DialogResult.OK Then
            Myprintdocument.Print()
        End If


    End Sub

    Private Sub MyPrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs) Handles Myprintdocument.PrintPage
        ' Obtener el objeto Graphics para la impresión
        Dim g As Graphics = e.Graphics
        Dim printFont As New Font("Arial", 12)
        Dim y As Integer = 100 ' Posición inicial en y

        ' Imprimir cada elemento seleccionado
        For Each item As String In selectedItems
            g.DrawString(item, printFont, Brushes.Black, 100, y)
            y += 20 ' Incrementar la posición y para el siguiente elemento
        Next

        ' Indicar que solo hay una página
        e.HasMorePages = False
    End Sub


End Class
