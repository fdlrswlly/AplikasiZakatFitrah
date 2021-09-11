<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataMustahik
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
        Me.Txt_jmlkeluarga = New System.Windows.Forms.TextBox()
        Me.Cb_status = New System.Windows.Forms.ComboBox()
        Me.Txt_alamat = New System.Windows.Forms.RichTextBox()
        Me.Txt_namamustahik = New System.Windows.Forms.TextBox()
        Me.Txt_idmustahik = New System.Windows.Forms.TextBox()
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Txt_cari = New System.Windows.Forms.TextBox()
        Me.DataGridMustahik = New System.Windows.Forms.DataGridView()
        Me.btn_cetak = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridMustahik, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1189, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATA MUSTAHIK"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txt_jmlkeluarga)
        Me.GroupBox1.Controls.Add(Me.Cb_status)
        Me.GroupBox1.Controls.Add(Me.Txt_alamat)
        Me.GroupBox1.Controls.Add(Me.Txt_namamustahik)
        Me.GroupBox1.Controls.Add(Me.Txt_idmustahik)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(510, 211)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data Mustahik"
        '
        'Txt_jmlkeluarga
        '
        Me.Txt_jmlkeluarga.Location = New System.Drawing.Point(122, 77)
        Me.Txt_jmlkeluarga.Name = "Txt_jmlkeluarga"
        Me.Txt_jmlkeluarga.Size = New System.Drawing.Size(60, 20)
        Me.Txt_jmlkeluarga.TabIndex = 10
        '
        'Cb_status
        '
        Me.Cb_status.FormattingEnabled = True
        Me.Cb_status.Location = New System.Drawing.Point(122, 170)
        Me.Cb_status.Name = "Cb_status"
        Me.Cb_status.Size = New System.Drawing.Size(217, 21)
        Me.Cb_status.TabIndex = 9
        '
        'Txt_alamat
        '
        Me.Txt_alamat.Location = New System.Drawing.Point(122, 102)
        Me.Txt_alamat.Name = "Txt_alamat"
        Me.Txt_alamat.Size = New System.Drawing.Size(221, 53)
        Me.Txt_alamat.TabIndex = 8
        Me.Txt_alamat.Text = ""
        '
        'Txt_namamustahik
        '
        Me.Txt_namamustahik.Location = New System.Drawing.Point(122, 50)
        Me.Txt_namamustahik.Name = "Txt_namamustahik"
        Me.Txt_namamustahik.Size = New System.Drawing.Size(221, 20)
        Me.Txt_namamustahik.TabIndex = 6
        '
        'Txt_idmustahik
        '
        Me.Txt_idmustahik.Location = New System.Drawing.Point(122, 19)
        Me.Txt_idmustahik.Name = "Txt_idmustahik"
        Me.Txt_idmustahik.Size = New System.Drawing.Size(136, 20)
        Me.Txt_idmustahik.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Status"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Jumlah KK"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama Mustahik"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Mustahik"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnkeluar)
        Me.GroupBox2.Controls.Add(Me.btntambah)
        Me.GroupBox2.Controls.Add(Me.btnhapus)
        Me.GroupBox2.Controls.Add(Me.btnsimpan)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 289)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(344, 57)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'btnkeluar
        '
        Me.btnkeluar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnkeluar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkeluar.Location = New System.Drawing.Point(266, 17)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(66, 31)
        Me.btnkeluar.TabIndex = 3
        Me.btnkeluar.Text = "KELUAR"
        Me.btnkeluar.UseVisualStyleBackColor = False
        '
        'btntambah
        '
        Me.btntambah.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btntambah.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambah.Location = New System.Drawing.Point(182, 17)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(66, 31)
        Me.btntambah.TabIndex = 2
        Me.btntambah.Text = "TAMBAH"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnhapus.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.Location = New System.Drawing.Point(99, 17)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(66, 31)
        Me.btnhapus.TabIndex = 1
        Me.btnhapus.Text = "HAPUS"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnsimpan.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.Location = New System.Drawing.Point(16, 17)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(66, 31)
        Me.btnsimpan.TabIndex = 0
        Me.btnsimpan.Text = "UBAH"
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Txt_cari)
        Me.GroupBox3.Location = New System.Drawing.Point(366, 290)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(161, 56)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cari Data"
        '
        'Txt_cari
        '
        Me.Txt_cari.Location = New System.Drawing.Point(6, 23)
        Me.Txt_cari.Name = "Txt_cari"
        Me.Txt_cari.Size = New System.Drawing.Size(149, 20)
        Me.Txt_cari.TabIndex = 0
        '
        'DataGridMustahik
        '
        Me.DataGridMustahik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridMustahik.Location = New System.Drawing.Point(547, 72)
        Me.DataGridMustahik.Name = "DataGridMustahik"
        Me.DataGridMustahik.Size = New System.Drawing.Size(654, 204)
        Me.DataGridMustahik.TabIndex = 4
        '
        'btn_cetak
        '
        Me.btn_cetak.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cetak.Location = New System.Drawing.Point(1066, 302)
        Me.btn_cetak.Name = "btn_cetak"
        Me.btn_cetak.Size = New System.Drawing.Size(135, 38)
        Me.btn_cetak.TabIndex = 5
        Me.btn_cetak.Text = "CETAK LAPORAN"
        Me.btn_cetak.UseVisualStyleBackColor = True
        '
        'FormDataMustahik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(1213, 366)
        Me.Controls.Add(Me.btn_cetak)
        Me.Controls.Add(Me.DataGridMustahik)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormDataMustahik"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DATA MUSTAHIK"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridMustahik, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cb_status As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_alamat As System.Windows.Forms.RichTextBox
    Friend WithEvents Txt_namamustahik As System.Windows.Forms.TextBox
    Friend WithEvents Txt_idmustahik As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_cari As System.Windows.Forms.TextBox
    Friend WithEvents DataGridMustahik As System.Windows.Forms.DataGridView
    Friend WithEvents Txt_jmlkeluarga As System.Windows.Forms.TextBox
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btn_cetak As System.Windows.Forms.Button
End Class
