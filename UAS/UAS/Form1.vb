Imports System.Data.OleDb
Public Class Form1
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\data.accdb")
    Private Sub nobox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nobox.KeyPress
        ' Mengizinkan hanya karakter angka, backspace, dan tombol delete
        If (Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar)) Then
            e.Handled = True ' Menahan karakter yang tidak diizinkan
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        jambox.Items.Add("09:00")
        jambox.Items.Add("13:00")
        jambox.Items.Add("21:00")

        asalbox.Items.Add("Jakarta")
        asalbox.Items.Add("Surabaya")
        asalbox.Items.Add("Bali")

        tujuanbox.Items.Add("Jakarta")
        tujuanbox.Items.Add("Surabaya")
        tujuanbox.Items.Add("Bali")



    End Sub

    Private Function totalHarga(jumlah As Integer, harga As Double) As Double
        Return jumlah * harga
    End Function

    Private Sub invoicebutton_Click(sender As Object, e As EventArgs) Handles invoicebutton.Click




        If asalbox.SelectedItem.ToString() = tujuanbox.SelectedItem.ToString() Then
            MessageBox.Show("Kota keberangkatan dan tujuan harus berbeda.")
        Else
            nama.Text = namabox.Text
            telpon.Text = nobox.Text
            asal.Text = asalbox.SelectedItem.ToString()
            tujuan.Text = tujuanbox.SelectedItem.ToString()
            tanggal.Text = DateTimePicker1.Value.ToShortDateString()
            jam.Text = jambox.SelectedItem.ToString()
            jumlah.Text = jumlahbox.Text

            Dim hrg As Double
            Select Case tujuanbox.SelectedItem.ToString()
                Case "Jakarta"
                    harga.Text = 1000000
                Case "Surabaya"
                    harga.Text = 800000
                Case "Bali"
                    harga.Text = 1200000
                Case Else
                    MessageBox.Show("Kota tujuan tidak valid.")
                    Return
            End Select

            Dim jml As Integer = Integer.Parse(jumlahbox.Text)

            If jml >= 2 Then
                ' Tampilkan total harga jika jumlah penumpang >= 2
                diskon.Text = totalHarga(jml, harga.Text) * 0.1
            Else
                diskon.Text = "0" ' Tidak ada diskon jika jumlah penumpang < 2
            End If

            total.Text = (totalHarga(jml, harga.Text)) - diskon.Text



        End If








    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        penumpang.Show()
        Me.Hide()
    End Sub

    Private Sub pesanbutton_Click(sender As Object, e As EventArgs) Handles pesanbutton.Click
        conn.Open()
        Dim cmd As New OleDbCommand("INSERT INTO penumpang(`nama`,`no_telpon`,`tanggal`,`jam`,`asal`,`tujuan`,`jumlah`,`harga`,`diskon`,`total`)values(@nama,@no_telpon,@tanggal,@jam,@asal,@tujuan,@jumlah,@harga,@diskon,@total)", conn)

        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@nama", nama.Text)
        cmd.Parameters.AddWithValue("@no_telpon", telpon.Text)
        cmd.Parameters.AddWithValue("@tanggal", tanggal.Text)
        cmd.Parameters.AddWithValue("@jam", jam.Text)
        cmd.Parameters.AddWithValue("@asal", asal.Text)
        cmd.Parameters.AddWithValue("@tujuan", tujuan.Text)
        cmd.Parameters.AddWithValue("@jumlah", jumlah.Text)
        cmd.Parameters.AddWithValue("@harga", harga.Text)
        cmd.Parameters.AddWithValue("@diskon", diskon.Text)
        cmd.Parameters.AddWithValue("@total", total.Text)

        cmd.ExecuteNonQuery()
        conn.Close()

        MsgBox("Pesanan sudah Selesai")


    End Sub
End Class
