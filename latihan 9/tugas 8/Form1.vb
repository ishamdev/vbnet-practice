Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        t_awal.Text = "00:00:00"
        t_akhir.Text = "00:00:00"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim selisih As TimeSpan = TimeValue(t_akhir.Text) - TimeValue(t_awal.Text)

        hasil.Text = (String.Format("{0}:{1}:{2}", selisih.Hours, selisih.Minutes, selisih.Seconds))


    End Sub


End Class
