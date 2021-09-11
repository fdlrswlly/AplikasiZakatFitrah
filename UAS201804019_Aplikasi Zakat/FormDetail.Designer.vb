<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetail
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Txt_cari = New System.Windows.Forms.TextBox()
        Me.btn_cetak = New System.Windows.Forms.Button()
        Me.DataGridDetail = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txt_fitrah = New System.Windows.Forms.TextBox()
        Me.Txt_JumlahKK = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_jumlahzakat = New System.Windows.Forms.TextBox()
        Me.Txt_NamaMuzzaki = New System.Windows.Forms.TextBox()
        Me.Txt_idpenerima = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Txt_cari)
        Me.GroupBox4.Location = New System.Drawing.Point(381, 255)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(142, 60)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cari Data"
        '
        'Txt_cari
        '
        Me.Txt_cari.Location = New System.Drawing.Point(6, 25)
        Me.Txt_cari.Name = "Txt_cari"
        Me.Txt_cari.Size = New System.Drawing.Size(130, 20)
        Me.Txt_cari.TabIndex = 0
        '
        'btn_cetak
        '
        Me.btn_cetak.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_cetak.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cetak.Location = New System.Drawing.Point(17, 321)
        Me.btn_cetak.Name = "btn_cetak"
        Me.btn_cetak.Size = New System.Drawing.Size(506, 59)
        Me.btn_cetak.TabIndex = 10
        Me.btn_cetak.Text = "CETAK DATA"
        Me.btn_cetak.UseVisualStyleBackColor = False
        '
        'DataGridDetail
        '
        Me.DataGridDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridDetail.Location = New System.Drawing.Point(540, 81)
        Me.DataGridDetail.Name = "DataGridDetail"
        Me.DataGridDetail.Size = New System.Drawing.Size(552, 299)
        Me.DataGridDetail.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnkeluar)
        Me.GroupBox2.Controls.Add(Me.btntambah)
        Me.GroupBox2.Controls.Add(Me.btnhapus)
        Me.GroupBox2.Controls.Add(Me.btnsimpan)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 255)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(352, 60)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'btnkeluar
        '
        Me.btnkeluar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnkeluar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkeluar.Location = New System.Drawing.Point(265, 17)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(81, 34)
        Me.btnkeluar.TabIndex = 3
        Me.btnkeluar.Text = "KELUAR"
        Me.btnkeluar.UseVisualStyleBackColor = False
        '
        'btntambah
        '
        Me.btntambah.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btntambah.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambah.Location = New System.Drawing.Point(180, 18)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(81, 34)
        Me.btntambah.TabIndex = 2
        Me.btntambah.Text = "TAMBAH"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnhapus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.Location = New System.Drawing.Point(93, 17)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(81, 34)
        Me.btnhapus.TabIndex = 1
        Me.btnhapus.Text = "HAPUS"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnsimpan.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.Location = New System.Drawing.Point(6, 17)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(81, 34)
        Me.btnsimpan.TabIndex = 0
        Me.btnsimpan.Text = "UBAH"
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txt_fitrah)
        Me.GroupBox1.Controls.Add(Me.Txt_JumlahKK)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Txt_jumlahzakat)
        Me.GroupBox1.Controls.Add(Me.Txt_NamaMuzzaki)
        Me.GroupBox1.Controls.Add(Me.Txt_idpenerima)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(505, 168)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data Penerimaan"
        '
        'Txt_fitrah
        '
        Me.Txt_fitrah.Location = New System.Drawing.Point(105, 48)
        Me.Txt_fitrah.Name = "Txt_fitrah"
        Me.Txt_fitrah.Size = New System.Drawing.Size(145, 20)
        Me.Txt_fitrah.TabIndex = 16
        '
        'Txt_JumlahKK
        '
        Me.Txt_JumlahKK.Location = New System.Drawing.Point(105, 102)
        Me.Txt_JumlahKK.Name = "Txt_JumlahKK"
        Me.Txt_JumlahKK.Size = New System.Drawing.Size(176, 20)
        Me.Txt_JumlahKK.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Jumlah KK"
        '
        'Txt_jumlahzakat
        '
        Me.Txt_jumlahzakat.Location = New System.Drawing.Point(105, 130)
        Me.Txt_jumlahzakat.Name = "Txt_jumlahzakat"
        Me.Txt_jumlahzakat.Size = New System.Drawing.Size(176, 20)
        Me.Txt_jumlahzakat.TabIndex = 9
        '
        'Txt_NamaMuzzaki
        '
        Me.Txt_NamaMuzzaki.Location = New System.Drawing.Point(105, 76)
        Me.Txt_NamaMuzzaki.Name = "Txt_NamaMuzzaki"
        Me.Txt_NamaMuzzaki.Size = New System.Drawing.Size(202, 20)
        Me.Txt_NamaMuzzaki.TabIndex = 8
        '
        'Txt_idpenerima
        '
        Me.Txt_idpenerima.Location = New System.Drawing.Point(105, 22)
        Me.Txt_idpenerima.Name = "Txt_idpenerima"
        Me.Txt_idpenerima.Size = New System.Drawing.Size(145, 20)
        Me.Txt_idpenerima.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Jumlah Zakat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nama Muzzaki"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ID Fitrah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Penerima"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkGray
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1080, 55)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "DETAIL PENERIMAAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(1109, 390)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btn_cetak)
        Me.Controls.Add(Me.DataGridDetail)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDetail"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_cari As System.Windows.Forms.TextBox
    Friend WithEvents btn_cetak As System.Windows.Forms.Button
    Friend WithEvents DataGridDetail As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Txt_jumlahzakat As System.Windows.Forms.TextBox
    Friend WithEvents Txt_NamaMuzzaki As System.Windows.Forms.TextBox
    Friend WithEvents Txt_idpenerima As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txt_JumlahKK As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_fitrah As System.Windows.Forms.TextBox
End Class
