<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenerimaanZakat
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CB_NmZakat = New System.Windows.Forms.ComboBox()
        Me.DT_tglpenerimaan = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_totalzakat = New System.Windows.Forms.TextBox()
        Me.Txt_jmlkk = New System.Windows.Forms.TextBox()
        Me.Txt_namakk = New System.Windows.Forms.TextBox()
        Me.Txt_NamaPenerima = New System.Windows.Forms.TextBox()
        Me.Txt_idpenerima = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.DataGridPenerimaan = New System.Windows.Forms.DataGridView()
        Me.btn_cetak = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Txt_cari = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txt_idfitrah = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridPenerimaan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkGray
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1080, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATA PENERIMAAN ZAKAT"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txt_idfitrah)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.CB_NmZakat)
        Me.GroupBox1.Controls.Add(Me.DT_tglpenerimaan)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Txt_totalzakat)
        Me.GroupBox1.Controls.Add(Me.Txt_jmlkk)
        Me.GroupBox1.Controls.Add(Me.Txt_namakk)
        Me.GroupBox1.Controls.Add(Me.Txt_NamaPenerima)
        Me.GroupBox1.Controls.Add(Me.Txt_idpenerima)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(508, 208)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data Penerimaan"
        '
        'CB_NmZakat
        '
        Me.CB_NmZakat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_NmZakat.FormattingEnabled = True
        Me.CB_NmZakat.Location = New System.Drawing.Point(105, 93)
        Me.CB_NmZakat.Name = "CB_NmZakat"
        Me.CB_NmZakat.Size = New System.Drawing.Size(138, 21)
        Me.CB_NmZakat.TabIndex = 15
        '
        'DT_tglpenerimaan
        '
        Me.DT_tglpenerimaan.Location = New System.Drawing.Point(105, 47)
        Me.DT_tglpenerimaan.Name = "DT_tglpenerimaan"
        Me.DT_tglpenerimaan.Size = New System.Drawing.Size(202, 20)
        Me.DT_tglpenerimaan.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Nama Zakat"
        '
        'Txt_totalzakat
        '
        Me.Txt_totalzakat.Location = New System.Drawing.Point(105, 163)
        Me.Txt_totalzakat.Name = "Txt_totalzakat"
        Me.Txt_totalzakat.Size = New System.Drawing.Size(145, 20)
        Me.Txt_totalzakat.TabIndex = 11
        '
        'Txt_jmlkk
        '
        Me.Txt_jmlkk.Location = New System.Drawing.Point(105, 138)
        Me.Txt_jmlkk.Name = "Txt_jmlkk"
        Me.Txt_jmlkk.Size = New System.Drawing.Size(69, 20)
        Me.Txt_jmlkk.TabIndex = 10
        '
        'Txt_namakk
        '
        Me.Txt_namakk.Location = New System.Drawing.Point(105, 116)
        Me.Txt_namakk.Name = "Txt_namakk"
        Me.Txt_namakk.Size = New System.Drawing.Size(176, 20)
        Me.Txt_namakk.TabIndex = 9
        '
        'Txt_NamaPenerima
        '
        Me.Txt_NamaPenerima.Location = New System.Drawing.Point(105, 70)
        Me.Txt_NamaPenerima.Name = "Txt_NamaPenerima"
        Me.Txt_NamaPenerima.Size = New System.Drawing.Size(202, 20)
        Me.Txt_NamaPenerima.TabIndex = 8
        '
        'Txt_idpenerima
        '
        Me.Txt_idpenerima.Location = New System.Drawing.Point(105, 24)
        Me.Txt_idpenerima.Name = "Txt_idpenerima"
        Me.Txt_idpenerima.Size = New System.Drawing.Size(145, 20)
        Me.Txt_idpenerima.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Total Zakat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Jumlah KK"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Nama KK"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nama Penerima"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tgl. Penerimaan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Penerimaan"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnkeluar)
        Me.GroupBox2.Controls.Add(Me.btntambah)
        Me.GroupBox2.Controls.Add(Me.btnhapus)
        Me.GroupBox2.Controls.Add(Me.btnsimpan)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 297)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(352, 60)
        Me.GroupBox2.TabIndex = 2
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
        'DataGridPenerimaan
        '
        Me.DataGridPenerimaan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridPenerimaan.Location = New System.Drawing.Point(532, 83)
        Me.DataGridPenerimaan.Name = "DataGridPenerimaan"
        Me.DataGridPenerimaan.Size = New System.Drawing.Size(560, 339)
        Me.DataGridPenerimaan.TabIndex = 3
        '
        'btn_cetak
        '
        Me.btn_cetak.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_cetak.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cetak.Location = New System.Drawing.Point(12, 363)
        Me.btn_cetak.Name = "btn_cetak"
        Me.btn_cetak.Size = New System.Drawing.Size(513, 59)
        Me.btn_cetak.TabIndex = 4
        Me.btn_cetak.Text = "CETAK DATA"
        Me.btn_cetak.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Txt_cari)
        Me.GroupBox4.Location = New System.Drawing.Point(383, 297)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(142, 60)
        Me.GroupBox4.TabIndex = 6
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(323, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "ID Fitrah"
        '
        'Txt_idfitrah
        '
        Me.Txt_idfitrah.Location = New System.Drawing.Point(376, 19)
        Me.Txt_idfitrah.Name = "Txt_idfitrah"
        Me.Txt_idfitrah.Size = New System.Drawing.Size(100, 20)
        Me.Txt_idfitrah.TabIndex = 17
        '
        'FormPenerimaanZakat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(1104, 434)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btn_cetak)
        Me.Controls.Add(Me.DataGridPenerimaan)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPenerimaanZakat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penerimaan Zakat"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridPenerimaan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridPenerimaan As System.Windows.Forms.DataGridView
    Friend WithEvents Txt_totalzakat As System.Windows.Forms.TextBox
    Friend WithEvents Txt_jmlkk As System.Windows.Forms.TextBox
    Friend WithEvents Txt_namakk As System.Windows.Forms.TextBox
    Friend WithEvents Txt_NamaPenerima As System.Windows.Forms.TextBox
    Friend WithEvents Txt_idpenerima As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btn_cetak As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DT_tglpenerimaan As System.Windows.Forms.DateTimePicker
    Friend WithEvents CB_NmZakat As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_cari As System.Windows.Forms.TextBox
    Friend WithEvents Txt_idfitrah As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
