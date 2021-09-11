Imports System.Data.Odbc
Public Class FormDetail
    Sub FormNonAktif()
        Txt_idpenerima.Enabled = False
        Txt_fitrah.Enabled = False
        Txt_NamaMuzzaki.Enabled = False
        Txt_JumlahKK.Enabled = False
        Txt_jumlahzakat.Enabled = False
    End Sub
    Sub FormAktif()
        Txt_idpenerima.Enabled = True
        Txt_fitrah.Enabled = True
        Txt_NamaMuzzaki.Enabled = True
        Txt_JumlahKK.Enabled = True
        Txt_jumlahzakat.Enabled = True
    End Sub
    Sub Kosongkan()
        Txt_idpenerima.Clear()
        Txt_fitrah.Clear()
        Txt_NamaMuzzaki.Clear()
        Txt_JumlahKK.Clear()
        Txt_jumlahzakat.Clear()
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
    Sub buatidpenerima()
        CMD = New OdbcCommand("SELECT * FROM tb_detailzakat " _
                             & "WHERE tb_detailzakat.id_penerima IN (SELECT MAX(id_penerima)" _
                             & "FROM tb_detailzakat) ORDER BY id_penerima Desc", DbKoneksi)
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
    Sub AktifDataGridDetail()
        With DataGridDetail
            .EnableHeadersVisualStyles = True
            Try
                .Font = New Font(DataGridDetail.Font, FontStyle.Bold)
                DataGridDetail.DefaultCellStyle.Font = New Font("Arial", 9)
                DataGridDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                DataGridDetail.ColumnHeadersHeight = 35

                'ID Penerimaan
                DataGridDetail.Columns(0).Width = 90
                DataGridDetail.Columns(0).HeaderText = "ID Penerima"
                DataGridDetail.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                'ID Fitrah
                DataGridDetail.Columns(1).Width = 90
                DataGridDetail.Columns(1).HeaderText = "ID Fitrah"
                DataGridDetail.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                'Nama Muzzaki
                DataGridDetail.Columns(2).Width = 150
                DataGridDetail.Columns(2).HeaderText = "Nama Muzzaki"
                DataGridDetail.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                'Jumlah KK
                DataGridDetail.Columns(3).Width = 100
                DataGridDetail.Columns(3).HeaderText = "Jumlah Kepala Keluarga"
                DataGridDetail.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                'Jumlah Zakat
                DataGridDetail.Columns(4).Width = 120
                DataGridDetail.Columns(4).HeaderText = "Jumlah Zakat"
                DataGridDetail.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            Catch ex As Exception
            End Try
        End With
    End Sub
    Sub TampilDataGridDetail()
        Call KoneksiDb()
        DA = New OdbcDataAdapter("SELECT * FROM tb_detailzakat ORDER BY id_penerima ASC", DbKoneksi)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS)
        DataGridDetail.DataSource = DS.Tables(0)
        DataGridDetail.ReadOnly = True
        Call AktifDataGridDetail()
    End Sub
    Sub buat_kolom()
        With DataGridDetail
            'Mengisi nama pada kolom grid
            .Columns.Add("Id_Penerima", "Id Penerima")
            .Columns.Add("Id Fitrah", "Id Fitrah")
            .Columns.Add("Nama Muzzaki", "Nama Muzzaki")
            .Columns.Add("Jumlah Kepala Keluarga", "Jumlah Kepala Keluarga")
            .Columns.Add("Jumlah Zakat", "Jumlah Zakat")
            'Mengatur ukuran Table
            .Columns("Id Penerimaan").Width = 150
            .Columns("Id Fitrah").Width = 150
            .Columns("Nama Muzzaki").Width = 150
            .Columns("Jumlah Kepala Keluarga").Width = 150
            .Columns("Total Zakat").Width = 150
        End With
    End Sub
    Private Sub FormDetail_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call KoneksiDb()
        Call FormNonAktif()
        Call TampilDataGridDetail()
        Call AktifDataGridDetail()
        btnsimpan.Enabled = True
        btnsimpan.BackColor = Color.CornflowerBlue
        btnhapus.Enabled = False
        btnhapus.BackColor = Color.Red
        btntambah.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub Txt_fitrah_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_fitrah.KeyPress
        If e.KeyChar = Chr(13) Then
            Call KoneksiDb()
            CMD = New OdbcCommand("select * from tb_muzzaki where id_fitrah= '" & Txt_fitrah.Text & "'", DbKoneksi)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                MsgBox("Nama tidak ditemukan", vbExclamation, "Tidak Ada")
            Else
                Txt_NamaMuzzaki.Text = DR.Item("Nama_KK")
            End If
        End If
    End Sub

    Private Sub btntambah_Click(sender As System.Object, e As System.EventArgs) Handles btntambah.Click
        Call FormAktif()
        Call buatidpenerima()
        'Call CbNmZakat()
        Txt_fitrah.Focus()
        btntambah.Enabled = False
        btntambah.BackColor = Color.Red
        btnsimpan.Enabled = True
        btnsimpan.BackColor = Color.CornflowerBlue
        btnsimpan.Text = "&SIMPAN"
        btnhapus.Enabled = False
        btnhapus.BackColor = Color.Red()
        btnkeluar.Text = "&BATAL"
    End Sub

    Private Sub btnsimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnsimpan.Click
        If Txt_NamaMuzzaki.Text = "" Then
            MsgBox("Silahkan isi data dahulu", vbInformation, "Informasi")

        Else
            If btnsimpan.Text = "&SIMPAN" Then
                sqlInsert = "INSERT INTO tb_detailzakat VALUES('" & Txt_idpenerima.Text & "','" _
               & Txt_fitrah.Text & "','" _
               & Txt_NamaMuzzaki.Text & "','" _
               & Txt_JumlahKK.Text & "','" _
               & Txt_jumlahzakat.Text & "')"
                CMD = New OdbcCommand(sqlInsert, DbKoneksi)
                CMD.ExecuteNonQuery()
                Call FormNormal()
                Call TampilDataGridDetail()
                btntambah.Enabled = True
                btnsimpan.Enabled = False
                btntambah.BackColor = Color.CornflowerBlue
                btnsimpan.BackColor = Color.Red
            ElseIf btnsimpan.Text = "&UBAH" Then
                Call KoneksiDb()
                Dim sqlUpdate As String = "UPDATE tb_detailzakat set id_penerima= '" & Txt_idpenerima.Text & "', nama_muzzaki= '" & Txt_NamaMuzzaki.Text & "', Jumlah_kk= '" & Txt_JumlahKK.Text & "', Jumlah_zakat= '" & Txt_jumlahzakat.Text & "' WHERE id_fitrah = '" & Txt_fitrah.Text & "'"
                CMD = New OdbcCommand(sqlUpdate, DbKoneksi)
                CMD.ExecuteNonQuery()
                Call FormNormal()
                Call TampilDataGridDetail()
                btntambah.Enabled = True
                btnsimpan.Enabled = False
                btntambah.BackColor = Color.CornflowerBlue
                btnsimpan.BackColor = Color.Red
            End If

        End If
    End Sub

    Private Sub btnhapus_Click(sender As System.Object, e As System.EventArgs) Handles btnhapus.Click
        Dim Konfirmasi As String
        Konfirmasi = MsgBox("Yakin ingin menghapus?", vbYesNo + vbQuestion, "Konfirmasi")
        If Konfirmasi = vbYes Then
            Call KoneksiDb()
            Dim sqlDelete As String = "DELETE FROM tb_detailzakat where id_penerima = '" & Txt_idpenerima.Text & "'"
            CMD = New OdbcCommand(sqlDelete, DbKoneksi)
            CMD.ExecuteNonQuery()
            Call TampilDataGridDetail()
            Call Kosongkan()
            Call FormNormal()
            btntambah.Enabled = True
            btntambah.BackColor = Color.CornflowerBlue
        End If
    End Sub
    Sub LoadDetail()
        Dim i As Integer
        i = DataGridDetail.CurrentRow.Index
        Txt_idpenerima.Text = DataGridDetail.Item(0, i).Value
        Txt_fitrah.Text = DataGridDetail.Item(1, i).Value
        Txt_NamaMuzzaki.Text = DataGridDetail.Item(2, i).Value
        Txt_JumlahKK.Text = DataGridDetail.Item(3, i).Value
        Txt_jumlahzakat.Text = DataGridDetail.Item(4, i).Value
    End Sub
    Private Sub DataGridDetail_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridDetail.CellContentClick
        Call LoadDetail()
        Call FormAktif()
        btnkeluar.Text = "&BATAL"
        btnsimpan.Enabled = True
        btnsimpan.Text = "&UBAH"
        btnsimpan.BackColor = Color.CornflowerBlue
        btnhapus.Enabled = True
        btnhapus.BackColor = Color.CornflowerBlue
        btntambah.Enabled = False
        btntambah.BackColor = Color.Red
    End Sub

    Private Sub btn_cetak_Click(sender As System.Object, e As System.EventArgs) Handles btn_cetak.Click
        FormLapDetail.Show()
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

    Private Sub Txt_cari_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txt_cari.TextChanged
        DA = New OdbcDataAdapter("SELECT * FROM tb_detailzakat WHERE nama_muzzaki like '%" & Txt_cari.Text & "%'", DbKoneksi)
        DS = New DataSet
        DA.Fill(DS)
        DataGridDetail.DataSource = DS.Tables(0)
    End Sub
End Class