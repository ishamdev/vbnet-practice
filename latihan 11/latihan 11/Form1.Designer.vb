<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        ListBarang = New ListBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txt_jumlah = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txt_harga = New Label()
        txt_satuan = New Label()
        txt_diskon = New Label()
        txt_total = New Label()
        Panel1 = New Panel()
        total = New Label()
        Button1 = New Button()
        Label8 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ListBarang
        ' 
        ListBarang.FormattingEnabled = True
        ListBarang.ItemHeight = 15
        ListBarang.Items.AddRange(New Object() {"Pensil", "Bulpen", "Kertas HVS", "Buku", "Penghapus", "Penggaris"})
        ListBarang.Location = New Point(27, 134)
        ListBarang.Name = "ListBarang"
        ListBarang.Size = New Size(120, 109)
        ListBarang.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(27, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 28)
        Label1.TabIndex = 1
        Label1.Text = "Jenis Barang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ImageAlign = ContentAlignment.TopCenter
        Label2.Location = New Point(239, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(166, 28)
        Label2.TabIndex = 2
        Label2.Text = "Input Pembelian"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(237, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 3
        Label3.Text = "Harga   :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(237, 164)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 15)
        Label4.TabIndex = 4
        Label4.Text = "Satuan  :"
        ' 
        ' txt_jumlah
        ' 
        txt_jumlah.Location = New Point(292, 193)
        txt_jumlah.Name = "txt_jumlah"
        txt_jumlah.Size = New Size(113, 23)
        txt_jumlah.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(236, 196)
        Label5.Name = "Label5"
        Label5.Size = New Size(54, 15)
        Label5.TabIndex = 6
        Label5.Text = "Jumlah  :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(236, 235)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 15)
        Label6.TabIndex = 7
        Label6.Text = "Diskon   :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(27, 339)
        Label7.Name = "Label7"
        Label7.Size = New Size(133, 30)
        Label7.TabIndex = 8
        Label7.Text = "Total Bayar :"
        ' 
        ' txt_harga
        ' 
        txt_harga.AutoSize = True
        txt_harga.Location = New Point(294, 136)
        txt_harga.Name = "txt_harga"
        txt_harga.Size = New Size(13, 15)
        txt_harga.TabIndex = 9
        txt_harga.Text = "0"
        ' 
        ' txt_satuan
        ' 
        txt_satuan.AutoSize = True
        txt_satuan.Location = New Point(294, 164)
        txt_satuan.Name = "txt_satuan"
        txt_satuan.Size = New Size(32, 15)
        txt_satuan.TabIndex = 10
        txt_satuan.Text = "lusin"
        ' 
        ' txt_diskon
        ' 
        txt_diskon.AutoSize = True
        txt_diskon.Location = New Point(297, 235)
        txt_diskon.Name = "txt_diskon"
        txt_diskon.Size = New Size(13, 15)
        txt_diskon.TabIndex = 11
        txt_diskon.Text = "0"
        ' 
        ' txt_total
        ' 
        txt_total.AutoSize = True
        txt_total.Location = New Point(18, 13)
        txt_total.Name = "txt_total"
        txt_total.Size = New Size(13, 15)
        txt_total.TabIndex = 12
        txt_total.Text = "0"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLightLight
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.Controls.Add(total)
        Panel1.Controls.Add(txt_total)
        Panel1.ForeColor = SystemColors.ButtonFace
        Panel1.Location = New Point(180, 334)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(145, 42)
        Panel1.TabIndex = 13
        ' 
        ' total
        ' 
        total.AutoSize = True
        total.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        total.ForeColor = SystemColors.ActiveCaptionText
        total.Location = New Point(11, 10)
        total.Name = "total"
        total.Size = New Size(19, 21)
        total.TabIndex = 13
        total.Text = "0"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(170, 278)
        Button1.Name = "Button1"
        Button1.Size = New Size(80, 30)
        Button1.TabIndex = 14
        Button1.Text = "Hitung"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(136, 18)
        Label8.Name = "Label8"
        Label8.Size = New Size(174, 31)
        Label8.TabIndex = 15
        Label8.Text = "Aplikasi Kasir"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(459, 414)
        Controls.Add(Label8)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        Controls.Add(txt_diskon)
        Controls.Add(txt_satuan)
        Controls.Add(txt_harga)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(txt_jumlah)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ListBarang)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBarang As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_jumlah As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_harga As Label
    Friend WithEvents txt_satuan As Label
    Friend WithEvents txt_diskon As Label
    Friend WithEvents txt_total As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents total As Label
    Friend WithEvents Label8 As Label
End Class
