Imports System.Data.Odbc
Public Class FormMuzzaki
    Sub FormNonAktif()
        Txt_fitrah.Enabled = False
        Txt_namakk.Enabled = False
        Txt_ket.Enabled = False
        Txt_kd_zakat.Enabled = False
    End Sub
    Sub FormAktif()
        Txt_fitrah.Enabled = True
        Txt_namakk.Enabled = True
        Txt_ket.Enabled = True
        Txt_kd_zakat.Enabled = True
    End Sub
    Sub Kosongkan()
        Txt_fitrah.Clear()
        Txt_namakk.Clear()
        Txt_ket.Clear()
        Txt_kd_zakat.Clear()
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
    'Sub CbJz()
    '   Cb_Jz.Items.Add("Zakat Uang")
    '  Cb_Jz.Items.Add("Zakat Beras")
    ' End Sub
    Sub buatidfitrah()
        CMD = New OdbcCommand("SELECT * FROM tb_muzzaki " _
                             & "WHERE tb_muzzaki.id_fitrah IN (SELECT MAX(id_fitrah)" _
                             & "FROM tb_muzzaki) ORDER BY id_fitrah Desc", DbKoneksi)
        Dim Urut As String
        Dim Hitung As Long
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            Urut = "F" + "001"
        Else
            If Microsoft.VisualBasic.Right(DR.GetString(0), 3) >= "999" Then
                Urut = "F" + "001"
            Else
                Hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 3) + 1
                Urut = "F" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
            End If
        End If
        DR.Close()
        Txt_fitrah.Text = Urut
    End Sub
    Sub AktifDataGridFitrah()
        With DataGridZakat
            .EnableHeadersVisualStyles = True
            Try
                .Font = New Font(DataGridZakat.Font, FontStyle.Bold)
                DataGridZakat.DefaultCellStyle.Font = New Font("Arial", 9)
                DataGridZakat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                DataGridZakat.ColumnHeadersHeight = 35

                'ID Fitrah
                DataGridZakat.Columns(0).Width = 70
                DataGridZakat.Columns(0).HeaderText = "ID Fitrah"
                DataGridZakat.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                'Nama KK
                DataGridZakat.Columns(1).Width = 160
                DataGridZakat.Columns(1).HeaderText = "Nama Kepala Keluarga"
                DataGridZakat.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                'Keterangan
                DataGridZakat.Columns(2).Width = 150
                DataGridZakat.Columns(2).HeaderText = "Keterangan"
                DataGridZakat.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                'Kode Zakat
                DataGridZakat.Columns(3).Width = 120
                DataGridZakat.Columns(3).HeaderText = "Kode Zakat"
                DataGridZakat.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Catch ex As Exception
            End Try
        End With
    End Sub
    'Menampilkan Data Grid View dari DB
    Sub TampilDataGridZakat()
        Call KoneksiDb()
        DA = New OdbcDataAdapter("SELECT * FROM tb_muzzaki ORDER BY id_fitrah ASC", DbKoneksi)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS)
        DataGridZakat.DataSource = DS.Tables(0)
        DataGridZakat.ReadOnly = True
        Call AktifDataGridFitrah()
    End Sub
    Sub buat_kolom()
        With DataGridZakat
            'Mengisi nama pada kolom grid
            .Columns.Add("Id_Fitrah", "Id Fitrah")
            .Columns.Add("Nama KK", "Nama KK")
            .Columns.Add("Keterangan", "Keterangan")
            .Columns.Add("Kode Zakat", "Kode Zakat")
            'Mengatur ukuran Table
            .Columns("Id Fitrah").Width = 150
            .Columns("Nama KK").Width = 150
            .Columns("Keterangan").Width = 150
            .Columns("Kode Zakat").Width = 150
        End With
    End Sub
    Private Sub FormZakat_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call KoneksiDb()
        Call FormNonAktif()
        Call TampilDataGridZakat()
        Call AktifDataGridFitrah()
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
                sqlInsert = "INSERT INTO tb_muzzaki VALUES('" & Txt_fitrah.Text & "','" _
               & Txt_namakk.Text & "','" _
               & Txt_ket.Text & "','" _
               & Txt_kd_zakat.Text & "')"
                CMD = New OdbcCommand(sqlInsert, DbKoneksi)
                CMD.ExecuteNonQuery()
                Call FormNormal()
                Call TampilDataGridZakat()
                btntambah.Enabled = True
                btnsimpan.Enabled = False
                btntambah.BackColor = Color.CornflowerBlue
                btnsimpan.BackColor = Color.Red
            ElseIf btnsimpan.Text = "&UBAH" Then
                Call KoneksiDb()
                Dim sqlUpdate As String = "UPDATE tb_muzzaki set nama_kk= '" & Txt_namakk.Text & "', keterangan= '" & Txt_ket.Text & "', kd_zakat= '" & Txt_kd_zakat.Text & "' WHERE id_fitrah= '" & Txt_fitrah.Text & "'"
                CMD = New OdbcCommand(sqlUpdate, DbKoneksi)
                CMD.ExecuteNonQuery()
                Call FormNormal()
                Call TampilDataGridZakat()
                btntambah.Enabled = True
                btnsimpan.Enabled = False
                btntambah.BackColor = Color.CornflowerBlue
                btnsimpan.BackColor = Color.Red
            End If

        End If
    End Sub

    Private Sub btntambah_Click(sender As System.Object, e As System.EventArgs) Handles btntambah.Click
        Call FormAktif()
        Call buatidfitrah()
        'Call CbJz()
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


    Private Sub GroupBox2_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox2.Enter

    End Sub



    Private Sub btnhapus_Click(sender As System.Object, e As System.EventArgs) Handles btnhapus.Click
        Dim Konfirmasi As String
        Konfirmasi = MsgBox("Yakin ingin menghapus?", vbYesNo + vbQuestion, "Konfirmasi")
        If Konfirmasi = vbYes Then
            Call KoneksiDb()
            Dim sqlDelete As String = "DELETE FROM tb_muzzaki where id_fitrah = '" & Txt_fitrah.Text & "'"
            CMD = New OdbcCommand(sqlDelete, DbKoneksi)
            CMD.ExecuteNonQuery()
            Call TampilDataGridZakat()
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

    Private Sub Txt_cari_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txt_cari.TextChanged
        DA = New OdbcDataAdapter("SELECT * FROM tb_muzzaki WHERE nama_kk like '%" & Txt_cari.Text & "%'", DbKoneksi)
        DS = New DataSet
        DA.Fill(DS)
        DataGridZakat.DataSource = DS.Tables(0)
    End Sub

    Sub LoadZakat()
        Dim i As Integer
        i = DataGridZakat.CurrentRow.Index
        Txt_fitrah.Text = DataGridZakat.Item(0, i).Value
        Txt_namakk.Text = DataGridZakat.Item(1, i).Value
        Txt_ket.Text = DataGridZakat.Item(2, i).Value
        Txt_kd_zakat.Text = DataGridZakat.Item(3, i).Value
    End Sub
    Private Sub DataGridZakat_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridZakat.CellContentClick
        Call LoadZakat()
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
End Class