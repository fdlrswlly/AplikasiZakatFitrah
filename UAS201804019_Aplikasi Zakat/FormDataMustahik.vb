Imports System.Data.Odbc
Public Class FormDataMustahik
    Sub FormNonAktif()
        Txt_idmustahik.Enabled = False
        Txt_namamustahik.Enabled = False
        Txt_jmlkeluarga.Enabled = False
        Txt_alamat.Enabled = False
        Cb_status.Enabled = False
    End Sub
    Sub FormAktif()
        Txt_idmustahik.Enabled = True
        Txt_namamustahik.Enabled = True
        Txt_jmlkeluarga.Enabled = True
        Txt_alamat.Enabled = True
        Cb_status.Enabled = True
    End Sub
    Sub Kosongkan()
        Txt_idmustahik.Clear()
        Txt_namamustahik.Clear()
        Txt_jmlkeluarga.Clear()
        Txt_alamat.Clear()
        Cb_status.Items.Clear()
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
    Sub CbStatus()
        Cb_status.Items.Add("Sudah Menerima")
        Cb_status.Items.Add("Belum Menerima")
    End Sub
    Sub buatidmustahik()
        CMD = New OdbcCommand("SELECT * FROM tb_mustahik " _
                            & "WHERE tb_mustahik.id_mustahik IN (SELECT MAX(id_mustahik)" _
                            & "FROM tb_mustahik) ORDER BY id_mustahik Desc", DbKoneksi)
        Dim Urut As String
        Dim Hitung As Long
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            Urut = "M" + "001"
        Else
            If Microsoft.VisualBasic.Right(DR.GetString(0), 3) >= "999" Then
                Urut = "M" + "001"
            Else
                Hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 3) + 1
                Urut = "M" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
            End If
        End If
        DR.Close()
        Txt_idmustahik.Text = Urut
    End Sub
    Sub AktifDataGridMustah()
        With DataGridMustahik
            .EnableHeadersVisualStyles = True
            Try
                .Font = New Font(DataGridMustahik.Font, FontStyle.Bold)
                DataGridMustahik.DefaultCellStyle.Font = New Font("Arial", 9)
                DataGridMustahik.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                DataGridMustahik.ColumnHeadersHeight = 35

                'ID Mustahik
                DataGridMustahik.Columns(0).Width = 120
                DataGridMustahik.Columns(0).HeaderText = "ID Mustahik"
                DataGridMustahik.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                'Nama Mustahik
                DataGridMustahik.Columns(1).Width = 120
                DataGridMustahik.Columns(1).HeaderText = "Nama Mustahik"
                DataGridMustahik.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                'Jumlah Keluarga
                DataGridMustahik.Columns(2).Width = 90
                DataGridMustahik.Columns(2).HeaderText = "Jumlah Keluarga"
                DataGridMustahik.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                'Alamat
                DataGridMustahik.Columns(3).Width = 150
                DataGridMustahik.Columns(3).HeaderText = "Alamat"
                DataGridMustahik.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                'Status
                DataGridMustahik.Columns(4).Width = 160
                DataGridMustahik.Columns(4).HeaderText = "Status"
                DataGridMustahik.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Catch ex As Exception
            End Try
        End With
    End Sub
    'Menampilkan Data Grid View dari DB
    Sub TampilDataGridMustahik()
        Call KoneksiDb()
        DA = New OdbcDataAdapter("SELECT * FROM tb_mustahik ORDER BY id_mustahik ASC", DbKoneksi)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS)
        DataGridMustahik.DataSource = DS.Tables(0)
        DataGridMustahik.ReadOnly = True
        Call AktifDataGridMustah()
    End Sub
    Sub buat_kolom()
        With DataGridMustahik
            'Mengisi nama pada kolom grid
            .Columns.Add("Id_Mustahik", "Id_Mustahik")
            .Columns.Add("Nama Mustahik", "Nama Mustahik")
            .Columns.Add("Jumlah Keluarga", "Jumlah Keluarga")
            .Columns.Add("Alamat", "Alamat")
            .Columns.Add("Status", "Status")
            'Mengatur ukuran Table
            .Columns("Id Mustahik").Width = 200
            .Columns("Nama Mustahik").Width = 150
            .Columns("Jumlah Keluarga").Width = 150
            .Columns("Alamat").Width = 150
            .Columns("Status").Width = 190
        End With
    End Sub
    Private Sub FormDataMustahik_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call KoneksiDb()
        Call FormNonAktif()
        Call TampilDataGridMustahik()
        Call AktifDataGridMustah()
        btnsimpan.Enabled = True
        btnsimpan.BackColor = Color.CornflowerBlue
        btnhapus.Enabled = False
        btnhapus.BackColor = Color.Red
        btntambah.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub btntambah_Click(sender As System.Object, e As System.EventArgs) Handles btntambah.Click
        Call FormAktif()
        Call buatidmustahik()
        Call CbStatus()
        Txt_idmustahik.Focus()
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
        If Txt_namamustahik.Text = "" Then
            MsgBox("Silahkan isi data dahulu", vbInformation, "Informasi")

        Else
            If btnsimpan.Text = "&SIMPAN" Then
                sqlInsert = "INSERT INTO tb_mustahik VALUES('" & Txt_idmustahik.Text & "','" _
               & Txt_namamustahik.Text & "','" _
               & Txt_jmlkeluarga.Text & "','" _
               & Txt_alamat.Text & "','" _
               & Cb_status.Text & "')"
                CMD = New OdbcCommand(sqlInsert, DbKoneksi)
                CMD.ExecuteNonQuery()
                Call FormNormal()
                Call TampilDataGridMustahik()
                btntambah.Enabled = True
                btnsimpan.Enabled = False
                btntambah.BackColor = Color.CornflowerBlue
                btnsimpan.BackColor = Color.Red
            ElseIf btnsimpan.Text = "&UBAH" Then
                Call KoneksiDb()
                Dim sqlUpdate As String = "UPDATE tb_mustahik set nama_kk= '" & Txt_namamustahik.Text & "', jml_kk= '" & Txt_jmlkeluarga.Text & "', alamat= '" & Txt_alamat.Text & "', status= '" & Cb_status.Text & "'WHERE id_mustahik= '" & Txt_idmustahik.Text & "'"
                CMD = New OdbcCommand(sqlUpdate, DbKoneksi)
                CMD.ExecuteNonQuery()
                Call FormNormal()
                Call TampilDataGridMustahik()
                btntambah.Enabled = True
                btnsimpan.Enabled = False
                btntambah.BackColor = Color.CornflowerBlue
                btnsimpan.BackColor = Color.Red
            End If

        End If
    End Sub

    Private Sub Txt_idmustahik_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_idmustahik.KeyPress
        If e.KeyChar = Chr(13) Then
            Call KoneksiDb()
            CMD = New OdbcCommand("SELECT * FROM tb_mustahik where id_mustahik= '" & Txt_idmustahik.Text & "'", DbKoneksi)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                MsgBox("Id Mustahik tidak ditemukan", MsgBoxStyle.Exclamation, "Informasi")
            Else
                btnsimpan.Text = "&UBAH"
                btnhapus.Enabled = True
                btnsimpan.BackColor = Color.CornflowerBlue
                btnhapus.Enabled = True
                btnhapus.BackColor = Color.CornflowerBlue
                Txt_idmustahik.Text = DR.Item("id_mustahik")
                Txt_namamustahik.Text = DR.Item("nama_kk")
                Txt_jmlkeluarga.Text = DR.Item("jml_kk")
                Txt_alamat.Text = DR.Item("alamat")
                Cb_status.Text = DR.Item("status")
            End If
        End If
    End Sub

    Private Sub btnhapus_Click(sender As System.Object, e As System.EventArgs) Handles btnhapus.Click
        Dim Konfirmasi As String
        Konfirmasi = MsgBox("Yakin ingin menghapus?", vbYesNo + vbQuestion, "Konfirmasi")
        If Konfirmasi = vbYes Then
            Call KoneksiDb()
            Dim sqlDelete As String = "DELETE FROM tb_mustahik where id_mustahik = '" & Txt_idmustahik.Text & "'"
            CMD = New OdbcCommand(sqlDelete, DbKoneksi)
            CMD.ExecuteNonQuery()
            Call TampilDataGridMustahik()
            Call Kosongkan()
            Call CbStatus()
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

    

    Private Sub Txt_cari_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txt_cari.TextChanged
        DA = New OdbcDataAdapter("SELECT * FROM tb_mustahik WHERE nama_kk like '%" & Txt_cari.Text & "%'", DbKoneksi)
        DS = New DataSet
        DA.Fill(DS)
        DataGridMustahik.DataSource = DS.Tables(0)
    End Sub
    Sub LoadMustahik()
        Dim i As Integer
        i = DataGridMustahik.CurrentRow.Index
        Txt_idmustahik.Text = DataGridMustahik.Item(0, i).Value
        Txt_namamustahik.Text = DataGridMustahik.Item(1, i).Value
        Txt_jmlkeluarga.Text = DataGridMustahik.Item(2, i).Value
        Txt_alamat.Text = DataGridMustahik.Item(3, i).Value
        Cb_status.Text = DataGridMustahik.Item(4, i).Value
    End Sub
    Private Sub DataGridMustahik_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridMustahik.CellContentClick
        Call LoadMustahik()
        Call FormAktif()
        btnsimpan.Text = "&UBAH"
        btnhapus.Enabled = True
        btntambah.Enabled = False

    End Sub

    Private Sub btn_cetak_Click(sender As System.Object, e As System.EventArgs) Handles btn_cetak.Click
        FormLaporanMustahik.Show()
    End Sub
End Class