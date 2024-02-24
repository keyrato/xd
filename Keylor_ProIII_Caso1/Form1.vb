Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Objetos() As String = {"Iphone 15 PRO MAX", "Apple Vision Pro", "Macbook", "Ipad", "Apple Watch"}
        For Each nombres As String In Objetos
            ListaObjetos.Items.Add(nombres)

            ListaObjetos.SelectedIndex = 0
        Next
    End Sub
    Private Sub calculo()
        Dim valor() As Integer = {1116919, 2000000, 1007235, 1500000, 250000}
        Dim valortotal As Integer = valor(ListaObjetos.SelectedIndex)
        If ConIVA.Checked Then
            valortotal = valortotal * 1.13

        ElseIf SinIVA.Checked Then
            valortotal = valortotal
        End If
        Precio.Text = String.Format("Precio: {0:C}", valortotal)

    End Sub
    Private Sub ListaObjetos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaObjetos.SelectedIndexChanged
        calculo()
    End Sub
    Private Sub ConIVA_CheckedChanged(sender As Object, e As EventArgs) Handles ConIVA.CheckedChanged
        calculo()
    End Sub
End Class
