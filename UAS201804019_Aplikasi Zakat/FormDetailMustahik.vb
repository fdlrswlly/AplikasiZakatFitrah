Imports System.Data.Odbc
Public Class FormDetailMustahik
    Sub FormNonAktif()
        Txt_fitrah.Enabled = False
        Txt_idmustahik.Enabled = False
        Txt_nopenyaluran.Enabled = False
        Cb_Jz.Enabled = False
        Txt_jmlzakat.Enabled = False
    End Sub
    Sub FormAktif()
        Txt_fitrah.Enabled = True
        Txt_idmustahik.Enabled = True
        Txt_nopenyaluran.Enabled = True
        Cb_Jz.Enabled = True
        Txt_jmlzakat.Enabled = True
    End Sub
    Sub Kosongkan()
        Txt_fitrah.Clear()
        Txt_idmustahik.Clear()
        Txt_nopenyaluran.Clear()
        Cb_Jz.Items.Clear()
        Txt_jmlzakat.Clear()
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
    Sub CbJz()
        Cb_Jz.Items.Add("Zakat Fitrah")
        Cb_Jz.Items.Add("Zakat Mal")
    End Sub
    
    Sub buatidfitrah()
        CMD = New OdbcCommand("SELECT * FROM tb_detailmustahik " _
                             & "WHERE tb_detailmustahik.id_fitrah IN (SELECT MAX(id_fitrah)" _
                             & "FROM tb_detailmustahik) ORDER BY id_fitrah Desc", DbKoneksi)
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
    Sub AktifDataGridDetail()
        With DataGridDetail
            .EnableHeadersVisualStyles = True
            Try
                .Font = New Font(DataGridDetail.Font, FontStyle.Bold)
                DataGridDetail.DefaultCellStyle.Font = New Font("Arial", 9)
                DataGridDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                DataGridDetail.ColumnHeadersHeight = 35

                'ID Fitrah
                DataGridDetail.Columns(0).Width = 120
                DataGridDetail.Columns(0).HeaderText = "ID Fitrah"
                DataGridDetail.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                'ID Mustahik
                DataGridDetail.Columns(1).Width = 120
                DataGridDetail.Columns(1).HeaderText = "ID Mustahik"
                DataGridDetail.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                'No Penyaluran
                DataGridDetail.Columns(2).Width = 120
                DataGridDetail.Columns(2).HeaderText = "No Penyaluran"
                DataGridDetail.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                'Jenis Zakat
                DataGridDetail.Columns(3).Width = 120
                DataGridDetail.Columns(3).HeaderText = "Jenis Zakat"
                DataGridDetail.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                'Jumlah Zakat
                DataGridDetail.Columns(0).Width = 120
                DataGridDetail.Columns(0).HeaderText = "Jumlah Zakat"
                DataGridDetail.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Catch ex As Exception
            End Try
        End With
    End Sub
    'Menampilkan Data Grid View dari DB
    Sub TampilDataGridDetail()
        Call KoneksiDb()
        DA = New OdbcDataAdapter("SELECT * FROM tb_detailmustahik ORDER BY id_fitrah ASC", DbKoneksi)
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
            .Columns.Add("ID Fitrah", "ID Fitrah")
            .Columns.Add("ID Mustahik", "ID Mustahik")
            .Columns.Add("No.Penyaluran", "No.Penyaluran")
            .Columns.Add("Jenis Zakat", "Jenis Zakat")
            .Columns.Add("Jumlah Zakat", "Jumlah Zakat")
            'Mengatur ukuran Table
            .Columns("ID Fitrah").Width = 200
            .Columns("ID Mustahik").Width = 150
            .Columns("No.Penyaluran").Width = 150
            .Columns("Jenis Zakat").Width = 150
            .Columns("Jumlah Zakat").Width = 190
        End With
    End Sub
    Private Sub FormDetailMustahik_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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

    Private Sub btntambah_Click(sender As System.Object, e As System.EventArgs) Handles btntambah.Click
        Call FormAktif()
        Call buatidfitrah()
        Call CbJz()
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
        If Txt_idmustahik.Text = "" Then
            MsgBox("Silahkan isi data dahulu", vbInformation, "Informasi")
            Txt_idmustahik.Focus()

        Else
            If btnsimpan.Text = "&SIMPAN" Then
                sqlInsert = "INSERT INTO tb_detailmustahik VALUES('" & Txt_fitrah.Text & "','" _
               & Txt_idmustahik.Text & "','" _
               & Txt_nopenyaluran.Text & "','" _
               & Cb_Jz.Text & "','" _
               & Txt_jmlzakat.Text & "')"
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
                Dim sqlUpdate As String = "UPDATE tb_detailmustahik set id_mustahik= '" & Txt_idmustahik.Text & "', no_penyaluran= '" & Txt_nopenyaluran.Text & "', jenis_zakat= '" & Cb_Jz.Text & "', jumlah_zakat= '" & Txt_jmlzakat.Text & "' WHERE id_fitrah= '" & Txt_fitrah.Text & "'"
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
    Sub LoadDetail()
        Dim i As Integer
        i = DataGridDetail.CurrentRow.Index
        Txt_fitrah.Text = DataGridDetail.Item(0, i).Value
        Txt_idmustahik.Text = DataGridDetail.Item(1, i).Value
        Txt_nopenyaluran.Text = DataGridDetail.Item(2, i).Value
        Cb_Jz.Text = DataGridDetail.Item(3, i).Value
        Txt_jmlzakat.Text = DataGridDetail.Item(4, i).Value
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
        
    End Sub

    Private Sub Cb_Jz_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Cb_Jz.SelectedIndexChanged

    End Sub
End Class