Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If angka.Text Mod 2 = 0 Then
            ket.Text = "Genap"
        Else
            ket.Text = "Ganjil"
        End If
    End Sub
End Class
