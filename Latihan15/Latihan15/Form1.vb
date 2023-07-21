Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim today_date As Date = DateTimePicker1.Value
        Dim date_five As Date = today_date.AddDays(5)
        Dim formatdate As String = date_five.ToString("MMMM dd, yyyy")

        TextBox1.Text = formatdate



    End Sub


End Class
