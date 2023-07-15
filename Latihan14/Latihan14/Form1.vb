Public Class Form1
    Dim x1, x2, p, b, keuntungan As Integer

    Function penjualan(x) As Integer
        p = 2000 * x

        Return p
    End Function

    Function biaya(x) As Integer
        b = 900000 + (625 * x)

        Return b
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        x1 = nilai_awal.Text
        x2 = nilai_akhir.Text


        For i As Integer = x1 To x2

            ListBox1.Items.Add("Produk = " & i & " Penjualan = " & penjualan(i) & " Biaya = " & biaya(i) & " Keuntungan = " & penjualan(i) - biaya(i))

        Next
        ListBox1.Items.Add(" ")
        If x2 >= 655 Then
            ListBox1.Items.Add("BEP Terjadi di 655 dengan keuntungan 625")

        Else
            ListBox1.Items.Add("Belum terjadi BEP tambahkan Nilai")
        End If






    End Sub

End Class
