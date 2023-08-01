Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class penumpang
    Private Sub penumpang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\data.accdb"


        Dim query As String = "SELECT * FROM penumpang"


        Using connection As New OleDbConnection(connectionString)

            Using command As New OleDbCommand(query, connection)

                connection.Open()

                Using reader As OleDbDataReader = command.ExecuteReader()

                    ListView1.Items.Clear()

                    While reader.Read()
                        Dim newItem As New ListViewItem()
                        For i As Integer = 0 To reader.FieldCount - 1
                            newItem.SubItems.Add(reader.GetValue(i).ToString())
                        Next
                        ListView1.Items.Add(newItem)
                    End While
                End Using
            End Using
        End Using
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\data.accdb"


        Dim query As String = "SELECT * FROM penumpang"


        Using connection As New OleDbConnection(connectionString)

            Using command As New OleDbCommand(query, connection)

                connection.Open()

                Using reader As OleDbDataReader = command.ExecuteReader()

                    ListView1.Items.Clear()

                    While reader.Read()
                        Dim newItem As New ListViewItem()
                        For i As Integer = 0 To reader.FieldCount - 1
                            newItem.SubItems.Add(reader.GetValue(i).ToString())
                        Next
                        ListView1.Items.Add(newItem)
                    End While
                End Using
            End Using
        End Using
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub


End Class
