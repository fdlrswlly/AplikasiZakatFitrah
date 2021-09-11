'Memanggil library odbc mysql
Imports System.Data.Odbc
Module Koneksi
    'Membuat Variable yang akan di panggil secara publik
    Public Hitung As Integer = 1
    Public DbKoneksi As OdbcConnection
    Public DA As OdbcDataAdapter
    Public DS As DataSet
    Public CMD As OdbcCommand
    Public DR As OdbcDataReader
    'membuat variable perintah SQL dan lokasi database
    Public LokasiDB As String
    Public sqlInsert As String
    Public sqlUpdate As String
    Public sqlHapus As String

    'Membuat prosedur public untuk ke database MySql
    Public Sub KoneksiDb()
        LokasiDB = "Driver={MySQL ODBC 3.51 Driver};Database=uas201804019;server;localhost;uid=root"
        DbKoneksi = New OdbcConnection(LokasiDB)
        If DbKoneksi.State = ConnectionState.Closed Then
            DbKoneksi.Open()
        End If
    End Sub
End Module
