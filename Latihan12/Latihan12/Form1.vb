Public Class Form1
    Dim tabungan, lama, x, saldo As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tabungan = TextBox1.Text
        lama = TextBox2.Text
        saldo = tabungan
        For x = 1 To lama
            ListBox.Items.Add("saldo tabungan ke - " + CStr(x) + " = " + CStr(saldo))

            saldo = saldo + tabungan

        Next

    End Sub


End Class
