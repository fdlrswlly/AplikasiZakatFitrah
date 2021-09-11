Imports System.Data.Odbc
Public Class FormPenerimaanZakat
    Sub FormNonAktif()
        Txt_idpenerima.Enabled = False
        DT_TglPenerimaan.Enabled = False
        Txt_NamaPenerima.Enabled = False
        CB_NmZakat.Enabled = False
        Txt_namakk.Enabled = False
        Txt_jmlkk.Enabled = False
        Txt_totalzakat.Enabled = False
        Txt_idfitrah.Enabled = False
    End Sub
    Sub FormAktif()
        Txt_idpenerima.Enabled = True
        DT_TglPenerimaan.Enabled = True
        Txt_NamaPenerima.Enabled = True
        CB_NmZakat.Enabled = True
        Txt_namakk.Enabled = True
        Txt_jmlkk.Enabled = True
        Txt_totalzakat.Enabled = True
        Txt_idfitrah.Enabled = True
    End Sub
    Sub Kosongkan()
        Txt_idpenerima.Clear()
        'DT_Penerimaan.Items.Clear()
        Txt_NamaPenerima.Clear()
        CB_NmZakat.Items.Clear()
        Txt_namakk.Clear()
        Txt_jmlkk.Clear()
        Txt_totalzakat.Clear()
        Txt_idfitrah.Clear()
    End Sub
    Sub FormNormal()
        Kosongkan()
        FormNonAktif()
        btnhapus.Enabled = True
        btnhapus.Text = "&HAPUS"
        btnsimpan.Text = "&SIMPAN"
        btnsimpan.BackColor = Color.Red
        btnhapus.BackColor = Color.Red
        btnsimpan.Enabled = False
        btnkeluar.Text = "&KELUAR"
    End Sub
    Sub CbNmZakat()
        CB_NmZakat.Items.Add("Zakat Uang")
        CB_NmZakat.Items.Add("Zakat Beras")
    End Sub
    Sub buatidpenerima()
        CMD = New OdbcCommand("SELECT * FROM tb_penerimaanzakat " _
                             & "WHERE tb_penerimaanzakat.id_penerima IN (SELECT MAX(id_penerima)" _
                             & "FROM tb_penerimaanzakat) ORDER BY id_penerima Desc", DbKoneksi)
        Dim Urut As String
        Dim Hitung As Long
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            Urut = "PR" + "001"
        Else
            If Microsoft.VisualBasic.Right(DR.GetString(0), 3) >= "999" Then
                Urut = "PR" + "001"
            Else
                Hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 3) + 1
                Urut = "PR" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
            End If
        End If
        DR.Close()
        Txt_idpenerima.Text = Urut
    End Sub
    Sub AktifDataGridPenerimaan()
        With DataGridPenerimaan
            .EnableHeadersVisualStyles = True
            Try
                .Font = New Font(DataGridPenerimaan.Font, FontStyle.Bold)
                DataGridPenerimaan.DefaultCellStyle.Font = New Font("Arial", 9)
                DataGridPenerimaan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                DataGridPenerimaan.ColumnHeadersHeight = 35

                'ID Penerimaan
                DataGridPenerimaan.Columns(0).Width = 90
                DataGridPenerimaan.Columns(0).HeaderText = "ID Penerima"
                DataGridPenerimaan.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                'Tgl Penerimaan
                DataGridPenerimaan.Columns(1).Width = 90
                DataGridPenerimaan.Columns(1).HeaderText = "Tgl.Penerimaan"
                DataGridPenerimaan.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                'Nama Penerima
                DataGridPenerimaan.Columns(2).Width = 150
                DataGridPenerimaan.Columns(2).HeaderText = "Nama Penerima"
                DataGridPenerimaan.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                'Nama Zakat
                DataGridPenerimaan.Columns(3).Width = 90
                DataGridPenerimaan.Columns(3).HeaderText = "Nama Zakat"
                DataGridPenerimaan.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                'Nama KK
                DataGridPenerimaan.Columns(4).Width = 100
                DataGridPenerimaan.Columns(4).HeaderText = "Nama Kepala Keluarga"
                DataGridPenerimaan.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                'Jumlah KK
                DataGridPenerimaan.Columns(5).Width = 100
                DataGridPenerimaan.Columns(5).HeaderText = "Jumlah Kepala Keluarga"
                DataGridPenerimaan.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                'Total Zakat
                DataGridPenerimaan.Columns(6).Width = 120
                DataGridPenerimaan.Columns(6).HeaderText = "Total Zakat"
                DataGridPenerimaan.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            Catch ex As Exception
            End Try
        End With
    End Sub
    'Menampilkan Data dari DB
    Sub TampilDataGridPenerimaan()
        Call KoneksiDb()
        DA = New OdbcDataAdapter("SELECT * FROM tb_penerimaanzakat ORDER BY id_penerima ASC", DbKoneksi)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS)
        DataGridPenerimaan.DataSource = DS.Tables(0)
        DataGridPenerimaan.ReadOnly = True
        Call AktifDataGridPenerimaan()
    End Sub
    Sub buat_kolom()
        With DataGridPenerimaan
            'Mengisi nama pada kolom grid
            .Columns.Add("Id_Penerima", "Id Penerimaan")
            .Columns.Add("Tgl.Penerimaan", "Tgl.Penerimaan")
            .Columns.Add("Nama Penerima", "Nama Penerima")
            .Columns.Add("Nama Zakat", "Nama Zakat")
            .Columns.Add("Nama Kepala Keluarga", "Nama Kepala Keluarga")
            .Columns.Add("Jumlah Kepala Keluarga", "Jumlah Kepala Keluarga")
            .Columns.Add("Total Zakat", "Total Zakat")
            'Mengatur ukuran Table
            .Columns("Id Penerimaan").Width = 150
            .Columns("Tgl.Penerimaan").Width = 150
            .Columns("Nama Penerima").Width = 150
            .Columns("Nama Zakat").Width = 150
            .Columns("Nama Kepala Keluarga").Width = 150
            .Columns("Jumlah Kepala Keluarga").Width = 150
            .Columns("Total Zakat").Width = 150
        End With
    End Sub
    Private Sub FormPenerimaanZakat_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call KoneksiDb()
        Call FormNonAktif()
        Call TampilDataGridPenerimaan()
        Call AktifDataGridPenerimaan()
        btnsimpan.Enabled = True
        btnsimpan.BackColor = Color.CornflowerBlue
        btnhapus.Enabled = False
        btnhapus.BackColor = Color.Red
        btntambah.BackColor = Color.CornflowerBlue
    End Sub
    Private Sub btnsimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnsimpan.Click
        If Txt_namakk.Text = "" Then
            MsgBox("Silahkan isi data dahulu", vbInformation, "Informasi")

        Else
            If btnsimpan.Text = "&SIMPAN" Then
                Dim Tglpenerimaan As Date
                Tglpenerimaan = DT_tglpenerimaan.Value
                Dim tgl As String
                tgl = Tglpenerimaan.ToString("dd-MM-yyyy")
                sqlInsert = "INSERT INTO tb_penerimaanzakat VALUES('" & Txt_idpenerima.Text & "','" _
               & tgl & "','" _
               & Txt_NamaPenerima.Text & "','" _
               & CB_NmZakat.Text & "','" _
               & Txt_namakk.Text & "','" _
               & Txt_jmlkk.Text & "','" _
               & Txt_totalzakat.Text & "')"
                CMD = New OdbcCommand(sqlInsert, DbKoneksi)
                CMD.ExecuteNonQuery()
                Call FormNormal()
                Call TampilDataGridPenerimaan()
                btntambah.Enabled = True
                btnsimpan.Enabled = False
                btntambah.BackColor = Color.CornflowerBlue
                btnsimpan.BackColor = Color.Red
            ElseIf btnsimpan.Text = "&UBAH" Then
                Dim Tglpenerimaan As Date
                Tglpenerimaan = DT_tglpenerimaan.Value
                Dim tgl As String
                tgl = Tglpenerimaan.ToString("dd-MM-yyyy")
                Call KoneksiDb()
                Dim sqlUpdate As String = "UPDATE tb_penerimaanzakat set tgl_penerimaan= '" & tgl & "', Nm_penerima= '" & Txt_NamaPenerima.Text & "', Nm_zakat= '" & CB_NmZakat.Text & "', Nama_kk= '" & Txt_namakk.Text & "', Jml_kk= '" & Txt_jmlkk.Text & "', Total_zakat= '" & Txt_totalzakat.Text & "'  WHERE id_penerima= '" & Txt_idpenerima.Text & "'"
                CMD = New OdbcCommand(sqlUpdate, DbKoneksi)
                CMD.ExecuteNonQuery()
                Call FormNormal()
                Call TampilDataGridPenerimaan()
                btntambah.Enabled = True
                btnsimpan.Enabled = False
                btntambah.BackColor = Color.CornflowerBlue
                btnsimpan.BackColor = Color.Red
            End If

        End If
    End Sub

    Private Sub btntambah_Click(sender As System.Object, e As System.EventArgs) Handles btntambah.Click
        Call FormAktif()
        Call buatidpenerima()
        Call CbNmZakat()
        Txt_NamaPenerima.Focus()
        btntambah.Enabled = False
        btntambah.BackColor = Color.Red
        btnsimpan.Enabled = True
        btnsimpan.BackColor = Color.CornflowerBlue
        btnsimpan.Text = "&SIMPAN"
        btnhapus.Enabled = False
        btnhapus.BackColor = Color.Red()
        btnkeluar.Text = "&BATAL"
    End Sub
    Sub LoadPenerimaan()
        Dim i As Integer
        i = DataGridPenerimaan.CurrentRow.Index
        Txt_idpenerima.Text = DataGridPenerimaan.Item(0, i).Value
        DT_tglpenerimaan.Value = DataGridPenerimaan.Item(1, i).Value
        Txt_NamaPenerima.Text = DataGridPenerimaan.Item(2, i).Value
        CB_NmZakat.Text = DataGridPenerimaan.Item(3, i).Value
        Txt_namakk.Text = DataGridPenerimaan.Item(4, i).Value
        Txt_jmlkk.Text = DataGridPenerimaan.Item(5, i).Value
        Txt_totalzakat.Text = DataGridPenerimaan.Item(6, i).Value
    End Sub
    Private Sub DataGridPenerimaan_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridPenerimaan.CellContentClick
        Call LoadPenerimaan()
        Call FormAktif()
        Call CbNmZakat()
        btnkeluar.Text = "&BATAL"
        btnsimpan.Enabled = True
        btnsimpan.Text = "&UBAH"
        btnsimpan.BackColor = Color.CornflowerBlue
        btnhapus.Enabled = True
        btnhapus.BackColor = Color.CornflowerBlue
        btntambah.Enabled = False
        btntambah.BackColor = Color.Red
    End Sub

    
    Private Sub Txt_cari_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txt_cari.TextChanged
        DA = New OdbcDataAdapter("SELECT * FROM tb_penerimaanzakat WHERE nama_kk like '%" & Txt_cari.Text & "%'", DbKoneksi)
        DS = New DataSet
        DA.Fill(DS)
        DataGridPenerimaan.DataSource = DS.Tables(0)
    End Sub

    Private Sub btnhapus_Click(sender As System.Object, e As System.EventArgs) Handles btnhapus.Click
        Dim Konfirmasi As String
        Konfirmasi = MsgBox("Yakin ingin menghapus?", vbYesNo + vbQuestion, "Konfirmasi")
        If Konfirmasi = vbYes Then
            Call KoneksiDb()
            Dim sqlDelete As String = "DELETE FROM tb_penerimaanzakat where id_penerima = '" & Txt_idpenerima.Text & "'"
            CMD = New OdbcCommand(sqlDelete, DbKoneksi)
            CMD.ExecuteNonQuery()
            Call TampilDataGridPenerimaan()
            Call Kosongkan()
            Call FormNormal()
            btntambah.Enabled = True
            btntambah.BackColor = Color.CornflowerBlue
        End If
    End Sub

    Private Sub btnkeluar_Click(sender As System.Object, e As System.EventArgs) Handles btnkeluar.Click
        If btnkeluar.Text = "&KELUAR" Then
            Me.Close()
        Else
            Call FormNormal()
            Call Kosongkan()

            btntambah.Enabled = True
            btntambah.BackColor = Color.CornflowerBlue
            btnsimpan.BackColor = Color.Red
        End If
    End Sub

    Private Sub btn_cetak_Click(sender As System.Object, e As System.EventArgs) Handles btn_cetak.Click
        FormLaporanPenerimaan.Show()
    End Sub

    Private Sub Txt_idfitrah_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_idfitrah.KeyPress
        If e.KeyChar = Chr(13) Then
            Call KoneksiDb()
            CMD = New OdbcCommand("select * from tb_muzzaki where id_fitrah= '" & Txt_idfitrah.Text & "'", DbKoneksi)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                MsgBox("Nama tidak ditemukan", vbExclamation, "Tidak Ada")
            Else
                Txt_namakk.Text = DR.Item("Nama_KK")
            End If
        End If
    End Sub
End Class