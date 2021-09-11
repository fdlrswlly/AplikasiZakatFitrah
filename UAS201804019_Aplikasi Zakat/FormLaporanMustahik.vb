Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine
Public Class FormLaporanMustahik

    Private Sub btn_laporan_Click(sender As System.Object, e As System.EventArgs) Handles btn_laporan.Click
        Dim LapReport As New ReportDocument
        LapReport.Load(Application.StartupPath + "\" + "CrystalReport1.rpt")
        CR_Mustahik.ReportSource = LapReport
        CR_Mustahik.SelectionFormula = "{tb_mustahik1.status}='" & CB_status.Text & "'"
        CR_Mustahik.RefreshReport()
        MyBase.OnLoad(e)
    End Sub

    Sub TampilStatus()
        Call KoneksiDb()
        CMD = New OdbcCommand("SELECT status from tb_mustahik GROUP BY status", DbKoneksi)
        DR = CMD.ExecuteReader
        CB_status.Items.Clear()
        While DR.Read
            CB_status.Items.Add(DR(0).ToString)
        End While
    End Sub

    Private Sub FormLaporanMustahik_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call TampilStatus()
    End Sub


End Class