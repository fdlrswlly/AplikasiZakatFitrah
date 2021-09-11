Public Class FormMenuUtama
    'Sub Terkunci()
    '   LoginToolStripMenuItem.Enabled = True
    '  LogoutToolStripMenuItem.Enabled = False
    ' DataMasterToolStripMenuItem.Enabled = False
    'HelpToolStripMenuItem.Enabled = False
    ' End Sub

    Private Sub DataZakatFItrahToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DataZakatFItrahToolStripMenuItem.Click
        FormMuzzaki.Show()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        FormLogin.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Hide()
        FormLogin.Show()
    End Sub

    Private Sub FormMenuUtama_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Call Terkunci()
    End Sub

    Private Sub DataMustahikToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DataMustahikToolStripMenuItem.Click
        FormJenisZakat.Show()
    End Sub

    Private Sub DataPenyaluranToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        FormPenyaluran.Show()
    End Sub

    Private Sub DataDetailMustahikToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        FormDetailMustahik.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub DataPenerimaanZakatToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DataPenerimaanZakatToolStripMenuItem.Click
        FormPenerimaanZakat.Show()
    End Sub

    Private Sub DetailPenerimaanZakatToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DetailPenerimaanZakatToolStripMenuItem.Click
        FormDetail.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub
End Class