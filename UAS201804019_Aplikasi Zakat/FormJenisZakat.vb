Imports System.Data.Odbc
Public Class FormJenisZakat
    Sub FormNonAktif()
        Txt_kdzakat.Enabled = False
        Txt_NmZakat.Enabled = False
        Txt_Jumlah.Enabled = False
    End Sub
    Sub FormAktif()
        Txt_kdzakat.Enabled = True
        Txt_NmZakat.Enabled = True
        Txt_Jumlah.Enabled = True
    End Sub
    Sub Kosongkan()
        Txt_kdzakat.Clear()
        Txt_NmZakat.Clear()
        Txt_Jumlah.Clear()
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
    Sub buatidjenis()
        CMD = New OdbcCommand("SELECT * FROM tb_jeniszakat " _
                             & "WHERE tb_jeniszakat.Kd_zakat IN (SELECT MAX(kd_zakat)" _
                             & "FROM tb_jeniszakat) ORDER BY kd_zakat Desc", DbKoneksi)
        Dim Urut As String
        Dim Hitung As Long
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            Urut = "Z" + "001"
        Else
            If Microsoft.VisualBasic.Right(DR.GetString(0), 3) >= "999" Then
                Urut = "Z" + "001"
            Else
                Hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 3) + 1
                Urut = "Z" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
            End If
        End If
        DR.Close()
        Txt_kdzakat.Text = Urut
    End Sub
    Sub AktifDataGridJenis()
        With DataGridJenis
            .EnableHeadersVisualStyles = True
            Try
                .Font = New Font(DataGridJenis.Font, FontStyle.Bold)
                DataGridJenis.DefaultCellStyle.Font = New Font("Arial", 9)
                DataGridJenis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                DataGridJenis.ColumnHeadersHeight = 35

                'Kd Zakat
                DataGridJenis.Columns(0).Width = 70
                DataGridJenis.Columns(0).HeaderText = "Kd Zakat"
                DataGridJenis.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                'Nama Zakat
                DataGridJenis.Columns(1).Width = 120
                DataGridJenis.Columns(1).HeaderText = "Nama Zakat"
                DataGridJenis.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                'Jumlah Zakat
                DataGridJenis.Columns(1).Width = 100
                DataGridJenis.Columns(1).HeaderText = "Jumlah Zakat"
                DataGridJenis.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Catch ex As Exception
            End Try
        End With
    End Sub
    Sub TampilDataGridJenis()
        Call KoneksiDb()
        DA = New OdbcDataAdapter("SELECT * FROM tb_jeniszakat ORDER BY kd_zakat ASC", DbKoneksi)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS)
        DataGridJenis.DataSource = DS.Tables(0)
        DataGridJenis.ReadOnly = True
        Call AktifDataGridJenis()
    End Sub
    Sub buat_kolom()
        With DataGridJenis
            'Mengisi nama pada kolom grid
            .Columns.Add("Kode Zakat", "Kode Zakat")
            .Columns.Add("Nama Zakat", "Nama Zakat")
            .Columns.Add("Jumlah Zakat", "Jumlah Zakat")

            'Mengatur ukuran Table
            .Columns("Kode Zakat").Width = 150
            .Columns("Nama Zakat").Width = 150
            .Columns("Jumlah Zakat").Width = 150
        End With
    End Sub
    Private Sub FormJenisZakat_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call KoneksiDb()
        Call FormNonAktif()
        Call TampilDataGridJenis()
        Call AktifDataGridJenis()
        btnsimpan.Enabled = True
        btnsimpan.BackColor = Color.CornflowerBlue
        btnhapus.Enabled = False
        btnhapus.BackColor = Color.Red
        btntambah.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub btntambah_Click(sender As System.Object, e As System.EventArgs) Handles btntambah.Click
        Call FormAktif()
        Call buatidjenis()
        'Call CbJz()
        Txt_kdzakat.Focus()
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
        If Txt_NmZakat.Text = "" Then
            MsgBox("Silahkan isi data dahulu", vbInformation, "Informasi")

        Else
            If btnsimpan.Text = "&SIMPAN" Then
                sqlInsert = "INSERT INTO tb_jeniszakat VALUES('" & Txt_kdzakat.Text & "','" _
               & Txt_NmZakat.Text & "','" _
               & Txt_Jumlah.Text & "')"
                CMD = New OdbcCommand(sqlInsert, DbKoneksi)
                CMD.ExecuteNonQuery()
                Call FormNormal()
                Call TampilDataGridJenis()
                btntambah.Enabled = True
                btnsimpan.Enabled = False
                btntambah.BackColor = Color.CornflowerBlue
                btnsimpan.BackColor = Color.Red
            ElseIf btnsimpan.Text = "&UBAH" Then
                Call KoneksiDb()
                Dim sqlUpdate As String = "UPDATE tb_jeniszakat set Nm_zakat = '" & Txt_NmZakat.Text & "', jml_zakat= '" & Txt_Jumlah.Text & "' WHERE kd_zakat = '" & Txt_kdzakat.Text & "'"

                CMD = New OdbcCommand(sqlUpdate, DbKoneksi)
                CMD.ExecuteNonQuery()
                Call FormNormal()
                Call TampilDataGridJenis()
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
            Dim sqlDelete As String = "DELETE FROM tb_jeniszakat where kd_zakat = '" & Txt_kdzakat.Text & "'"
            CMD = New OdbcCommand(sqlDelete, DbKoneksi)
            CMD.ExecuteNonQuery()
            Call TampilDataGridJenis()
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
    Sub LoadJenis()
        Dim i As Integer
        i = DataGridJenis.CurrentRow.Index
        Txt_kdzakat.Text = DataGridJenis.Item(0, i).Value
        Txt_NmZakat.Text = DataGridJenis.Item(1, i).Value
        Txt_Jumlah.Text = DataGridJenis.Item(2, i).Value
    End Sub

    Private Sub DataGridJenis_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridJenis.CellContentClick
        Call LoadJenis()
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
End Class