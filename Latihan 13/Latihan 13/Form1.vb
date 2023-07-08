Public Class Form1



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        satuan.Items.Add("Celcius")
        satuan.Items.Add("Fahrenheit")
        satuan.Items.Add("Kelvin")
        satuan.Items.Add("Reamur")


        koma.Items.Add("1")
        koma.Items.Add("2")
        koma.Items.Add("3")
        koma.Items.Add("4")
        koma.Items.Add("5")


    End Sub
    Function konversi(nilai As Double) As String

        Select Case satuan.SelectedItem
            Case "Celcius"

                'celcius
                txt_celcius.Text = nilaisuhu.Text
                Dim hasil_c As String = FormatNumber(txt_celcius.Text, koma.SelectedItem)
                txt_celcius.Text = hasil_c

                'fahrenheit
                txt_fahrenheit.Text = (nilaisuhu.Text * 9 / 5) + 32
                Dim hasil_f As String = FormatNumber(txt_fahrenheit.Text, koma.SelectedItem)
                txt_fahrenheit.Text = hasil_f

                'Kelvin
                txt_kelvin.Text = nilaisuhu.Text + 273.15
                Dim hasil_k As String = FormatNumber(txt_kelvin.Text, koma.SelectedItem)
                txt_kelvin.Text = hasil_k

                'Reamur
                txt_reamur.Text = (4 / 5) * nilaisuhu.Text
                Dim hasil_r As String = FormatNumber(txt_reamur.Text, koma.SelectedItem)
                txt_reamur.Text = hasil_r


            Case "Fahrenheit"
                'celcius
                txt_celcius.Text = (5 / 9) * (nilaisuhu.Text - 32)
                Dim hasil_c As String = FormatNumber(txt_celcius.Text, koma.SelectedItem)
                txt_celcius.Text = hasil_c

                'fahrenheit
                txt_fahrenheit.Text = nilaisuhu.Text
                Dim hasil_f As String = FormatNumber(txt_fahrenheit.Text, koma.SelectedItem)
                txt_fahrenheit.Text = hasil_f

                'kelvin
                txt_kelvin.Text = ((5 / 9) * (nilaisuhu.Text - 32)) + 273.15
                Dim hasil_k As String = FormatNumber(txt_kelvin.Text, koma.SelectedItem)
                txt_kelvin.Text = hasil_k

                'reamur
                txt_reamur.Text = (4 / 9) * (nilaisuhu.Text - 32)
                Dim hasil_r As String = FormatNumber(txt_reamur.Text, koma.SelectedItem)
                txt_reamur.Text = hasil_r

            Case "Kelvin"

                'celcius
                txt_celcius.Text = nilaisuhu.Text - 273.15
                Dim hasil_c As String = FormatNumber(txt_celcius.Text, koma.SelectedItem)
                txt_celcius.Text = hasil_c


                'fahrenheit
                txt_fahrenheit.Text = ((9 / 5) * (nilaisuhu.Text - 273.15)) + 32
                Dim hasil_f As String = FormatNumber(txt_fahrenheit.Text, koma.SelectedItem)
                txt_fahrenheit.Text = hasil_f


                'kelvin
                txt_kelvin.Text = nilaisuhu.Text
                Dim hasil_k As String = FormatNumber(txt_kelvin.Text, koma.SelectedItem)
                txt_kelvin.Text = hasil_k

                'reamur
                txt_reamur.Text = (4 / 5) * (nilaisuhu.Text - 273.15)
                Dim hasil_r As String = FormatNumber(txt_reamur.Text, koma.SelectedItem)
                txt_reamur.Text = hasil_r


            Case "Reamur"

                'celcius
                txt_celcius.Text = (5 / 4) * nilaisuhu.Text
                Dim hasil_c As String = FormatNumber(txt_celcius.Text, koma.SelectedItem)
                txt_celcius.Text = hasil_c

                'fahrenheit
                txt_fahrenheit.Text = ((9 / 4) * nilaisuhu.Text) + 273.15
                Dim hasil_f As String = FormatNumber(txt_fahrenheit.Text, koma.SelectedItem)
                txt_fahrenheit.Text = hasil_f

                'kelvin
                txt_kelvin.Text = ((5 / 4) * nilaisuhu.Text) + 273.15
                Dim hasil_k As String = FormatNumber(txt_kelvin.Text, koma.SelectedItem)
                txt_kelvin.Text = hasil_k

                'reamur
                txt_reamur.Text = nilaisuhu.Text
                Dim hasil_r As String = FormatNumber(txt_reamur.Text, koma.SelectedItem)
                txt_reamur.Text = hasil_r

        End Select

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        konversi(nilaisuhu.Text)





    End Sub


End Class
