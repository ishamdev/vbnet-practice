<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class penumpang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label9 = New Label()
        Label1 = New Label()
        ListView1 = New ListView()
        ColumnHeader7 = New ColumnHeader()
        Id = New ColumnHeader()
        nama = New ColumnHeader()
        notelpon = New ColumnHeader()
        tanggal = New ColumnHeader()
        jam = New ColumnHeader()
        asal = New ColumnHeader()
        tujuan = New ColumnHeader()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Sylfaen", 30F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(233, 9)
        Label9.Name = "Label9"
        Label9.Size = New Size(228, 52)
        Label9.TabIndex = 18
        Label9.Text = "UNSIA AIR"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sylfaen", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(282, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 18)
        Label1.TabIndex = 20
        Label1.Text = "Data Penumpang"
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader7, Id, nama, notelpon, tanggal, jam, asal, tujuan})
        ListView1.Location = New Point(81, 117)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(530, 235)
        ListView1.TabIndex = 21
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.DisplayIndex = 7
        ColumnHeader7.Text = "Keterangan"
        ' 
        ' Id
        ' 
        Id.DisplayIndex = 0
        Id.Text = "No Invoice"
        Id.TextAlign = HorizontalAlignment.Center
        Id.Width = 50
        ' 
        ' nama
        ' 
        nama.DisplayIndex = 1
        nama.Text = "Nama"
        nama.TextAlign = HorizontalAlignment.Center
        nama.Width = 80
        ' 
        ' notelpon
        ' 
        notelpon.DisplayIndex = 2
        notelpon.Text = "No. Telpon"
        notelpon.TextAlign = HorizontalAlignment.Center
        notelpon.Width = 80
        ' 
        ' tanggal
        ' 
        tanggal.DisplayIndex = 3
        tanggal.Text = "Tanggal"
        tanggal.TextAlign = HorizontalAlignment.Center
        tanggal.Width = 75
        ' 
        ' jam
        ' 
        jam.DisplayIndex = 4
        jam.Text = "Jam"
        jam.TextAlign = HorizontalAlignment.Center
        ' 
        ' asal
        ' 
        asal.DisplayIndex = 5
        asal.Text = "Asal"
        asal.TextAlign = HorizontalAlignment.Center
        ' 
        ' tujuan
        ' 
        tujuan.DisplayIndex = 6
        tujuan.Text = "Tujuan"
        tujuan.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(325, 377)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 22
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(536, 88)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 23
        Button2.Text = "Refresh"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' penumpang
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(689, 412)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ListView1)
        Controls.Add(Label1)
        Controls.Add(Label9)
        Name = "penumpang"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents nama As ColumnHeader
    Friend WithEvents notelpon As ColumnHeader
    Friend WithEvents tanggal As ColumnHeader
    Friend WithEvents jam As ColumnHeader
    Friend WithEvents asal As ColumnHeader
    Friend WithEvents tujuan As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents Id As ColumnHeader
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
