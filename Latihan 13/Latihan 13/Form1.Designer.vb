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
        satuan = New ComboBox()
        Label1 = New Label()
        nilaisuhu = New TextBox()
        GroupBox1 = New GroupBox()
        Label7 = New Label()
        txt_reamur = New TextBox()
        Label8 = New Label()
        txt_kelvin = New TextBox()
        Label6 = New Label()
        txt_fahrenheit = New TextBox()
        Label5 = New Label()
        txt_celcius = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        koma = New ComboBox()
        Button2 = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' satuan
        ' 
        satuan.FormattingEnabled = True
        satuan.Location = New Point(241, 144)
        satuan.Name = "satuan"
        satuan.Size = New Size(121, 23)
        satuan.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(151, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(268, 32)
        Label1.TabIndex = 1
        Label1.Text = "Program Konversi Suhu"
        ' 
        ' nilaisuhu
        ' 
        nilaisuhu.Location = New Point(241, 104)
        nilaisuhu.Name = "nilaisuhu"
        nilaisuhu.Size = New Size(121, 23)
        nilaisuhu.TabIndex = 2
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(txt_reamur)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(txt_kelvin)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(txt_fahrenheit)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(txt_celcius)
        GroupBox1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        GroupBox1.ForeColor = SystemColors.ControlText
        GroupBox1.Location = New Point(39, 290)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(470, 132)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Hasil"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(246, 75)
        Label7.Name = "Label7"
        Label7.Size = New Size(78, 15)
        Label7.TabIndex = 13
        Label7.Text = "Reamur         :"
        ' 
        ' txt_reamur
        ' 
        txt_reamur.Location = New Point(352, 72)
        txt_reamur.Name = "txt_reamur"
        txt_reamur.Size = New Size(88, 24)
        txt_reamur.TabIndex = 14
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(246, 45)
        Label8.Name = "Label8"
        Label8.Size = New Size(78, 15)
        Label8.TabIndex = 11
        Label8.Text = "Kelvin            :"
        ' 
        ' txt_kelvin
        ' 
        txt_kelvin.Location = New Point(352, 42)
        txt_kelvin.Name = "txt_kelvin"
        txt_kelvin.Size = New Size(88, 24)
        txt_kelvin.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(6, 72)
        Label6.Name = "Label6"
        Label6.Size = New Size(84, 15)
        Label6.TabIndex = 9
        Label6.Text = "Fahrenheit      :"
        ' 
        ' txt_fahrenheit
        ' 
        txt_fahrenheit.Location = New Point(112, 69)
        txt_fahrenheit.Name = "txt_fahrenheit"
        txt_fahrenheit.Size = New Size(88, 24)
        txt_fahrenheit.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(6, 42)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 15)
        Label5.TabIndex = 8
        Label5.Text = "Celcius            :"
        ' 
        ' txt_celcius
        ' 
        txt_celcius.Location = New Point(112, 39)
        txt_celcius.Name = "txt_celcius"
        txt_celcius.Size = New Size(88, 24)
        txt_celcius.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(64, 107)
        Label2.Name = "Label2"
        Label2.Size = New Size(168, 15)
        Label2.TabIndex = 4
        Label2.Text = "Nilai yang dikonversi                :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(63, 148)
        Label3.Name = "Label3"
        Label3.Size = New Size(168, 15)
        Label3.TabIndex = 5
        Label3.Text = "Satuan Suhu dalam derajat     :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(64, 192)
        Label4.Name = "Label4"
        Label4.Size = New Size(168, 15)
        Label4.TabIndex = 6
        Label4.Text = "Angka dibelakang koma          :"
        ' 
        ' koma
        ' 
        koma.FormattingEnabled = True
        koma.Location = New Point(242, 188)
        koma.Name = "koma"
        koma.Size = New Size(121, 23)
        koma.TabIndex = 7
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        Button2.Location = New Point(216, 248)
        Button2.Name = "Button2"
        Button2.Size = New Size(81, 28)
        Button2.TabIndex = 9
        Button2.Text = "Konversi"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(545, 448)
        Controls.Add(Button2)
        Controls.Add(koma)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(GroupBox1)
        Controls.Add(nilaisuhu)
        Controls.Add(Label1)
        Controls.Add(satuan)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents satuan As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents nilaisuhu As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents koma As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_reamur As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_kelvin As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_fahrenheit As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_celcius As TextBox
    Friend WithEvents Button2 As Button
End Class
