Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine
Public Class FormLaporanPenerimaan

    Private Sub CB_NmZakat_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CB_NmZakat.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim LapReport As New ReportDocument
        LapReport.Load(Application.StartupPath + "\" + "CRPenerima.rpt")
        CR_Penerima.ReportSource = LapReport
        CR_Penerima.SelectionFormula = "{tb_penerimaanzakat1.Nm_Zakat}='" & CB_NmZakat.Text & "'"
        CR_Penerima.RefreshReport()
        MyBase.OnLoad(e)
    End Sub
    Sub TampilZakat()
        Call KoneksiDb()
        CMD = New OdbcCommand("SELECT Nm_zakat from tb_penerimaanzakat GROUP BY Nm_Zakat", DbKoneksi)
        DR = CMD.ExecuteReader
        CB_NmZakat.Items.Clear()
        While DR.Read
            CB_NmZakat.Items.Add(DR(0).ToString)
        End While
    End Sub

    Private Sub FormLaporanPenerimaan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call TampilZakat()
    End Sub
End Class