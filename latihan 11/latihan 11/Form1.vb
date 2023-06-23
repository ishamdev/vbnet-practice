Public Class Form1
    Dim harga As Integer
    Dim satuan As String


    Private Sub ListBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBarang.SelectedIndexChanged
        Select Case ListBarang.Text
            Case "Pensil"
                harga = 12000
                satuan = "Lusin"
            Case "Bulpen"
                harga = 15000
                satuan = "Lusin"
            Case "Kertas HVS"
                harga = 130000
                satuan = "Ream"
            Case "Buku"
                harga = 25000
                satuan = "Lusin"
            Case "Penghapus"
                harga = 10000
                satuan = "Lusin"
            Case "Penggaris"
                harga = 24000
                satuan = "Kodi"

        End Select


        'output
        txt_harga.Text = harga
        txt_satuan.Text = satuan

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Diskon
        If txt_jumlah.Text > 5 Then
            txt_diskon.Text = (txt_harga.Text * txt_jumlah.Text) * 0.05
        Else
            txt_diskon.Text = 0
        End If

        'total
        total.Text = (txt_harga.Text * txt_jumlah.Text) - txt_diskon.Text
    End Sub

End Class
