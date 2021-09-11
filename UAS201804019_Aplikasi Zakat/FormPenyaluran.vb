Imports System.Data.Odbc
Public Class FormPenyaluran
    Sub FormNonAktif()
        Txt_nopenyaluran.Enabled = False
        Dt_tglpenyaluran.Enabled = False
        CbJz.Enabled = False
        Txt_saldoakhir.Enabled = False
        Txt_saldoawal.Enabled = False
    End Sub
    Sub FormAktif()
        Txt_nopenyaluran.Enabled = True
        Dt_tglpenyaluran.Enabled = True
        CbJz.Enabled = True
        Txt_saldoawal.Enabled = True
        Txt_saldoakhir.Enabled = True
    End Sub
    Sub Kosongkan()
        Txt_nopenyaluran.Clear()
        'Dt_tglpenyaluran.Clear()
        CbJz.Items.Clear()
        Txt_saldoawal.Clear()
        Txt_saldoakhir.Clear()
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
    Sub Cb_Jz()
        CbJz.Items.Add("Zakat Fitrah")
        CbJz.Items.Add("Zakat Mal")
    End Sub
    Sub buatnopenyaluran()
        CMD = New OdbcCommand("SELECT * FROM tb_penyaluran " _
                            & "WHERE tb_penyaluran.no_penyaluran IN (SELECT MAX(no_penyaluran)" _
                            & "FROM tb_penyaluran) ORDER BY no_penyaluran Desc", DbKoneksi)
        Dim Urut As String
        Dim Hitung As Long
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            Urut = "P" + "001"
        Else
            If Microsoft.VisualBasic.Right(DR.GetString(0), 3) >= "999" Then
                Urut = "P" + "001"
            Else
                Hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 3) + 1
                Urut = "P" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
            End If
        End If
        DR.Close()
        Txt_nopenyaluran.Text = Urut
    End Sub
    Sub AktifDataGridPenyaluran()
        With DataGridPenyaluran
            .EnableHeadersVisualStyles = True
            Try
                .Font = New Font(DataGridPenyaluran.Font, FontStyle.Bold)
                DataGridPenyaluran.DefaultCellStyle.Font = New Font("Arial", 9)
                DataGridPenyaluran.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                DataGridPenyaluran.ColumnHeadersHeight = 35

                'No Penyaluran
                DataGridPenyaluran.Columns(0).Width = 120
                DataGridPenyaluran.Columns(0).HeaderText = "No Penyaluran"
                DataGridPenyaluran.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                'Tgl penyaluran
                DataGridPenyaluran.Columns(0).Width = 90
                DataGridPenyaluran.Columns(0).HeaderText = "Tgl.Penyaluran"
                DataGridPenyaluran.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                'Jenis Zakat
                DataGridPenyaluran.Columns(0).Width = 100
                DataGridPenyaluran.Columns(0).HeaderText = "Jenis Zakat"
                DataGridPenyaluran.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                'Saldo Awal
                DataGridPenyaluran.Columns(0).Width = 100
                DataGridPenyaluran.Columns(0).HeaderText = "Saldo Awal"
                DataGridPenyaluran.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                'Saldo Akhir
                DataGridPenyaluran.Columns(0).Width = 120
                DataGridPenyaluran.Columns(0).HeaderText = "Saldo Akhir"
                DataGridPenyaluran.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Catch ex As Exception
            End Try
        End With
    End Sub
    'Menampilkan Data Grid View dari DB
    Sub TampilDataGridPenyaluran()
        Call KoneksiDb()
        DA = New OdbcDataAdapter("SELECT * FROM tb_penyaluran ORDER BY no_penyaluran ASC", DbKoneksi)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS)
        DataGridPenyaluran.DataSource = DS.Tables(0)
        DataGridPenyaluran.ReadOnly = True
        Call AktifDataGridPenyaluran()
    End Sub
    Sub buat_kolom()
        With DataGridPenyaluran
            'Mengisi nama pada kolom grid
            .Columns.Add("No.Penyaluran", "No.Penyaluran")
            .Columns.Add("Tgl.Penyaluran", "No.Penyaluran")
            .Columns.Add("Jenis Zakat", "Jenis Zakat")
            .Columns.Add("Saldo Awal", "Saldo Awal")
            .Columns.Add("Saldo Akhir", "Saldo Akhir")
            'Mengatur ukuran Table
            .Columns("No.Penyaluran").Width = 200
            .Columns("Tgl.Penyaluran").Width = 150
            .Columns("Jenis Zakat").Width = 150
            .Columns("Saldo Awal").Width = 150
            .Columns("Saldo Akhir").Width = 190
        End With
    End Sub

    Private Sub FormPenyaluran_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call KoneksiDb()
        Call FormNonAktif()
        Call TampilDataGridPenyaluran()
        Call AktifDataGridPenyaluran()
        btnsimpan.Enabled = True
        btnsimpan.BackColor = Color.CornflowerBlue
        btnhapus.Enabled = False
        btnhapus.BackColor = Color.Red
        btntambah.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub btntambah_Click(sender As System.Object, e As System.EventArgs) Handles btntambah.Click
        Call FormAktif()
        Call buatnopenyaluran()
        Call Cb_Jz()
        Txt_nopenyaluran.Focus()
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
        If Dt_tglpenyaluran.Text = "" Then
            MsgBox("Silahkan isi data dahulu", vbInformation, "Informasi")

        Else
            If btnsimpan.Text = "&SIMPAN" Then
                Dim Tglpenyaluran As Date
                Tglpenyaluran = Dt_tglpenyaluran.Value
                Dim tgl As String
                tgl = Tglpenyaluran.ToString("dd-MM-yyyy")
                'Dim y As String
                ' y = "21-01-2000"
                sqlInsert = "INSERT INTO tb_penyaluran VALUES('" & Txt_nopenyaluran.Text & "','" _
               & tgl & "','" _
               & CbJz.Text & "','" _
               & Txt_saldoawal.Text & "','" _
               & Txt_saldoakhir.Text & "')"
                CMD = New OdbcCommand(sqlInsert, DbKoneksi)
                CMD.ExecuteNonQuery()
                Call FormNormal()
                Call TampilDataGridPenyaluran()
                btntambah.Enabled = True
                btnsimpan.Enabled = False
                btntambah.BackColor = Color.CornflowerBlue
                btnsimpan.BackColor = Color.Red
            ElseIf btnsimpan.Text = "&UBAH" Then
                Dim Tglpenyaluran As Date
                Tglpenyaluran = Dt_tglpenyaluran.Value
                Dim tgl As String
                tgl = Tglpenyaluran.ToString("dd-MM-yyyy")
                Call KoneksiDb()
                Dim sqlUpdate As String = "UPDATE tb_penyaluran set tgl_penyaluran= '" & tgl & "', jenis_zakat= '" & CbJz.Text & "', saldo_awal= '" & Txt_saldoawal.Text & "', saldo_akhir= '" & Txt_saldoakhir.Text & "'WHERE no_penyaluran= '" & Txt_nopenyaluran.Text & "'"
                CMD = New OdbcCommand(sqlUpdate, DbKoneksi)
                CMD.ExecuteNonQuery()
                Call FormNormal()
                Call TampilDataGridPenyaluran()
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
            Dim sqlDelete As String = "DELETE FROM tb_penyaluran where no_penyaluran = '" & Txt_nopenyaluran.Text & "'"
            CMD = New OdbcCommand(sqlDelete, DbKoneksi)
            CMD.ExecuteNonQuery()
            Call TampilDataGridPenyaluran()
            Call Kosongkan()
            Call FormNormal()
            btntambah.Enabled = True
            btntambah.BackColor = Color.CornflowerBlue
        End If
    End Sub

    Sub LoadPenyaluran()
        Dim i As Integer
        i = DataGridPenyaluran.CurrentRow.Index
        Txt_nopenyaluran.Text = DataGridPenyaluran.Item(0, i).Value
        Dt_tglpenyaluran.Value = DataGridPenyaluran.Item(1, i).Value
        CbJz.Text = DataGridPenyaluran.Item(2, i).Value
        Txt_saldoawal.Text = DataGridPenyaluran.Item(3, i).Value
        Txt_saldoakhir.Text = DataGridPenyaluran.Item(4, i).Value
    End Sub
    Private Sub DataGridPenyaluran_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridPenyaluran.CellContentClick
        Call LoadPenyaluran()
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

    Private Sub Txt_cari_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txt_cari.TextChanged
      
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

    Private Sub Dt_tglpenyaluran_ValueChanged(sender As System.Object, e As System.EventArgs) Handles Dt_tglpenyaluran.ValueChanged

    End Sub
End Class