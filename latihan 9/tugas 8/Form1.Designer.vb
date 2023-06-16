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
        hasil = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        Label4 = New Label()
        t_akhir = New TextBox()
        t_awal = New TextBox()
        SuspendLayout()
        ' 
        ' hasil
        ' 
        hasil.Location = New Point(134, 219)
        hasil.Name = "hasil"
        hasil.Size = New Size(133, 23)
        hasil.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(53, 130)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 15)
        Label1.TabIndex = 3
        Label1.Text = "Jam Awal"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(50, 174)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 4
        Label2.Text = "Jam Akhir"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(47, 221)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 15)
        Label3.TabIndex = 5
        Label3.Text = "Selisih Jam"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(137, 264)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 6
        Button1.Text = "Hitung"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(106, 25)
        Label4.Name = "Label4"
        Label4.Size = New Size(147, 21)
        Label4.TabIndex = 7
        Label4.Text = "Aplikasi Hitung Jam"
        ' 
        ' t_akhir
        ' 
        t_akhir.Location = New Point(137, 171)
        t_akhir.Name = "t_akhir"
        t_akhir.Size = New Size(133, 23)
        t_akhir.TabIndex = 8
        ' 
        ' t_awal
        ' 
        t_awal.Location = New Point(137, 125)
        t_awal.Name = "t_awal"
        t_awal.Size = New Size(133, 23)
        t_awal.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(342, 353)
        Controls.Add(t_awal)
        Controls.Add(t_akhir)
        Controls.Add(Label4)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(hasil)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents hasil As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents t_akhir As TextBox
    Friend WithEvents t_awal As TextBox
End Class
