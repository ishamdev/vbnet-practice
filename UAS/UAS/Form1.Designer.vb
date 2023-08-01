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
        GroupBox1 = New GroupBox()
        invoicebutton = New Button()
        Label8 = New Label()
        jumlahbox = New TextBox()
        Label6 = New Label()
        tujuanbox = New ComboBox()
        Label5 = New Label()
        asalbox = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        Label4 = New Label()
        jambox = New ComboBox()
        Label3 = New Label()
        nobox = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        namabox = New TextBox()
        GroupBox2 = New GroupBox()
        Label17 = New Label()
        total = New Label()
        Label20 = New Label()
        diskon = New Label()
        Label18 = New Label()
        harga = New Label()
        Label16 = New Label()
        jumlah = New Label()
        Label13 = New Label()
        jam = New Label()
        tanggal = New Label()
        Label14 = New Label()
        tujuan = New Label()
        Label15 = New Label()
        Label12 = New Label()
        asal = New Label()
        telpon = New Label()
        Label10 = New Label()
        nama = New Label()
        Label9 = New Label()
        pesanbutton = New Button()
        clear = New Button()
        Label11 = New Label()
        Button1 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ControlDarkDark
        GroupBox1.Controls.Add(invoicebutton)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(jumlahbox)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(tujuanbox)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(asalbox)
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(jambox)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(nobox)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(namabox)
        GroupBox1.ForeColor = SystemColors.ButtonHighlight
        GroupBox1.Location = New Point(12, 71)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(705, 277)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Form Pemesanan"
        ' 
        ' invoicebutton
        ' 
        invoicebutton.ForeColor = SystemColors.ActiveCaptionText
        invoicebutton.Location = New Point(293, 236)
        invoicebutton.Name = "invoicebutton"
        invoicebutton.Size = New Size(75, 23)
        invoicebutton.TabIndex = 17
        invoicebutton.Text = "Invoice"
        invoicebutton.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(375, 151)
        Label8.Name = "Label8"
        Label8.Size = New Size(73, 15)
        Label8.TabIndex = 16
        Label8.Text = "Jumlah Tiket"
        ' 
        ' jumlahbox
        ' 
        jumlahbox.Location = New Point(459, 148)
        jumlahbox.Name = "jumlahbox"
        jumlahbox.Size = New Size(121, 23)
        jumlahbox.TabIndex = 15
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(374, 104)
        Label6.Name = "Label6"
        Label6.Size = New Size(43, 15)
        Label6.TabIndex = 12
        Label6.Text = "Tujuan"
        ' 
        ' tujuanbox
        ' 
        tujuanbox.FormattingEnabled = True
        tujuanbox.Location = New Point(459, 101)
        tujuanbox.Name = "tujuanbox"
        tujuanbox.Size = New Size(121, 23)
        tujuanbox.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(374, 66)
        Label5.Name = "Label5"
        Label5.Size = New Size(29, 15)
        Label5.TabIndex = 10
        Label5.Text = "Asal"
        ' 
        ' asalbox
        ' 
        asalbox.FormattingEnabled = True
        asalbox.Location = New Point(459, 63)
        asalbox.Name = "asalbox"
        asalbox.Size = New Size(121, 23)
        asalbox.TabIndex = 9
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(109, 150)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(121, 23)
        DateTimePicker1.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(35, 196)
        Label4.Name = "Label4"
        Label4.Size = New Size(28, 15)
        Label4.TabIndex = 7
        Label4.Text = "Jam"
        ' 
        ' jambox
        ' 
        jambox.FormattingEnabled = True
        jambox.Location = New Point(109, 193)
        jambox.Name = "jambox"
        jambox.Size = New Size(121, 23)
        jambox.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(35, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 15)
        Label3.TabIndex = 5
        Label3.Text = "No. Telpon"
        ' 
        ' nobox
        ' 
        nobox.Location = New Point(109, 104)
        nobox.MaxLength = 15
        nobox.Name = "nobox"
        nobox.Size = New Size(121, 23)
        nobox.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(35, 156)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 15)
        Label2.TabIndex = 3
        Label2.Text = "Tanggal"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(35, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 2
        Label1.Text = "Nama"
        ' 
        ' namabox
        ' 
        namabox.Location = New Point(109, 60)
        namabox.Name = "namabox"
        namabox.Size = New Size(121, 23)
        namabox.TabIndex = 1
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.ButtonHighlight
        GroupBox2.Controls.Add(Label17)
        GroupBox2.Controls.Add(total)
        GroupBox2.Controls.Add(Label20)
        GroupBox2.Controls.Add(diskon)
        GroupBox2.Controls.Add(Label18)
        GroupBox2.Controls.Add(harga)
        GroupBox2.Controls.Add(Label16)
        GroupBox2.Controls.Add(jumlah)
        GroupBox2.Controls.Add(Label13)
        GroupBox2.Controls.Add(jam)
        GroupBox2.Controls.Add(tanggal)
        GroupBox2.Controls.Add(Label14)
        GroupBox2.Controls.Add(tujuan)
        GroupBox2.Controls.Add(Label15)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(asal)
        GroupBox2.Controls.Add(telpon)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(nama)
        GroupBox2.Location = New Point(12, 371)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(342, 271)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Invoice"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Sylfaen", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.Location = New Point(246, 19)
        Label17.Name = "Label17"
        Label17.Size = New Size(73, 16)
        Label17.TabIndex = 21
        Label17.Text = "UNSIA AIR"
        ' 
        ' total
        ' 
        total.AutoSize = True
        total.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        total.Location = New Point(110, 228)
        total.Name = "total"
        total.Size = New Size(12, 15)
        total.TabIndex = 33
        total.Text = "-"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(24, 228)
        Label20.Name = "Label20"
        Label20.Size = New Size(32, 15)
        Label20.TabIndex = 32
        Label20.Text = "Total"
        ' 
        ' diskon
        ' 
        diskon.AutoSize = True
        diskon.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        diskon.Location = New Point(110, 198)
        diskon.Name = "diskon"
        diskon.Size = New Size(12, 15)
        diskon.TabIndex = 31
        diskon.Text = "-"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(24, 198)
        Label18.Name = "Label18"
        Label18.Size = New Size(43, 15)
        Label18.TabIndex = 30
        Label18.Text = "Diskon"
        ' 
        ' harga
        ' 
        harga.AutoSize = True
        harga.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        harga.Location = New Point(110, 168)
        harga.Name = "harga"
        harga.Size = New Size(12, 15)
        harga.TabIndex = 29
        harga.Text = "-"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(24, 168)
        Label16.Name = "Label16"
        Label16.Size = New Size(39, 15)
        Label16.TabIndex = 28
        Label16.Text = "Harga"
        ' 
        ' jumlah
        ' 
        jumlah.AutoSize = True
        jumlah.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        jumlah.Location = New Point(246, 135)
        jumlah.Name = "jumlah"
        jumlah.Size = New Size(14, 15)
        jumlah.TabIndex = 27
        jumlah.Text = "0"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(180, 135)
        Label13.Name = "Label13"
        Label13.Size = New Size(45, 15)
        Label13.TabIndex = 26
        Label13.Text = "Jumlah"
        ' 
        ' jam
        ' 
        jam.AutoSize = True
        jam.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        jam.Location = New Point(110, 135)
        jam.Name = "jam"
        jam.Size = New Size(12, 15)
        jam.TabIndex = 25
        jam.Text = "-"
        ' 
        ' tanggal
        ' 
        tanggal.AutoSize = True
        tanggal.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        tanggal.Location = New Point(110, 109)
        tanggal.Name = "tanggal"
        tanggal.Size = New Size(12, 15)
        tanggal.TabIndex = 24
        tanggal.Text = "-"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(24, 135)
        Label14.Name = "Label14"
        Label14.Size = New Size(28, 15)
        Label14.TabIndex = 19
        Label14.Text = "Jam"
        ' 
        ' tujuan
        ' 
        tujuan.AutoSize = True
        tujuan.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        tujuan.Location = New Point(109, 75)
        tujuan.Name = "tujuan"
        tujuan.Size = New Size(12, 15)
        tujuan.TabIndex = 23
        tujuan.Text = "-"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(22, 109)
        Label15.Name = "Label15"
        Label15.Size = New Size(48, 15)
        Label15.TabIndex = 18
        Label15.Text = "Tanggal"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(84, 75)
        Label12.Name = "Label12"
        Label12.Size = New Size(12, 15)
        Label12.TabIndex = 22
        Label12.Text = "/"
        ' 
        ' asal
        ' 
        asal.AutoSize = True
        asal.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        asal.Location = New Point(24, 75)
        asal.Name = "asal"
        asal.Size = New Size(12, 15)
        asal.TabIndex = 21
        asal.Text = "-"
        ' 
        ' telpon
        ' 
        telpon.AutoSize = True
        telpon.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        telpon.Location = New Point(110, 41)
        telpon.Name = "telpon"
        telpon.Size = New Size(12, 15)
        telpon.TabIndex = 20
        telpon.Text = "-"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(87, 41)
        Label10.Name = "Label10"
        Label10.Size = New Size(12, 15)
        Label10.TabIndex = 19
        Label10.Text = "/"
        ' 
        ' nama
        ' 
        nama.AutoSize = True
        nama.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        nama.Location = New Point(24, 41)
        nama.Name = "nama"
        nama.Size = New Size(12, 15)
        nama.TabIndex = 18
        nama.Text = "-"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Sylfaen", 30F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(258, 9)
        Label9.Name = "Label9"
        Label9.Size = New Size(228, 52)
        Label9.TabIndex = 18
        Label9.Text = "UNSIA AIR"
        ' 
        ' pesanbutton
        ' 
        pesanbutton.Location = New Point(431, 425)
        pesanbutton.Name = "pesanbutton"
        pesanbutton.Size = New Size(91, 70)
        pesanbutton.TabIndex = 19
        pesanbutton.Text = "Pesan"
        pesanbutton.UseVisualStyleBackColor = True
        ' 
        ' clear
        ' 
        clear.Location = New Point(556, 425)
        clear.Name = "clear"
        clear.Size = New Size(106, 70)
        clear.TabIndex = 20
        clear.Text = "Clear Invoice"
        clear.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(386, 515)
        Label11.Name = "Label11"
        Label11.Size = New Size(323, 21)
        Label11.TabIndex = 18
        Label11.Text = "NB : Pembelian 2 Tiket dapat Diskon 10%"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(462, 597)
        Button1.Name = "Button1"
        Button1.Size = New Size(169, 45)
        Button1.TabIndex = 21
        Button1.Text = "Data Penumpang"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(728, 654)
        Controls.Add(Button1)
        Controls.Add(Label11)
        Controls.Add(clear)
        Controls.Add(pesanbutton)
        Controls.Add(Label9)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents namabox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents nobox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents jambox As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents jumlahbox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tujuanbox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents asalbox As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents invoicebutton As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents nama As Label
    Friend WithEvents jam As Label
    Friend WithEvents tanggal As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents tujuan As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents asal As Label
    Friend WithEvents telpon As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents total As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents diskon As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents harga As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents jumlah As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents pesanbutton As Button
    Friend WithEvents clear As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Button1 As Button
End Class
