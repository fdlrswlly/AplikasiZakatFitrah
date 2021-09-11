Imports System.Data.Odbc

Public Class FormLogin
    'Sub Terbuka()
    '   FormMenuUtama.LoginToolStripMenuItem.Enabled = False
    '  FormMenuUtama.LogoutToolStripMenuItem.Enabled = True
    ' FormMenuUtama.DataMasterToolStripMenuItem.Enabled = True
    'FormMenuUtama.HelpToolStripMenuItem.Enabled = True
    'End Sub
    Sub KondisiAwal()
        Txt_username.Text = ""
        Txt_password.Text = ""
    End Sub
    Private Sub Btn_login_Click(sender As System.Object, e As System.EventArgs) Handles Btn_login.Click
        If Txt_username.Text = "" Then
            MsgBox("Username Harus Diisi", MsgBoxStyle.Exclamation, "Kosong!!")
        ElseIf Txt_password.Text = "" Then
            MsgBox("Password Harus Diisi", MsgBoxStyle.Exclamation, "Kosong!!")
        Else

            Call KoneksiDb()
            CMD = New OdbcCommand("SELECT * FROM tb_user WHERE NmUser= '" & Txt_username.Text & "'", DbKoneksi)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows = 0 Then
                CMD = New OdbcCommand("SELECT * FROM tb_user WHERE PassUser='" & Txt_password.Text & "'", DbKoneksi) 'And PassUser='"& Txt_pass.Text &
                DR = CMD.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    If DR.Item("LevelUser") = "admin" And DR.Item("NmUser") = Txt_username.Text Then
                        With FormMenuUtama
                            Hide()
                            .Show()
                            .DataMasterToolStripMenuItem.Enabled = True
                            .DetailPenerimaanZakatToolStripMenuItem.Enabled = True
                            .DataZakatFItrahToolStripMenuItem.Enabled = True
                            .TransaksiToolStripMenuItem.Enabled = True
                            .LoginToolStripMenuItem.Enabled = False
                            .LogoutToolStripMenuItem.Enabled = True
                        End With
                    ElseIf DR.Item("LevelUser") = "user" And DR.Item("NmUser") = Txt_username.Text Then
                        With FormMenuUtama
                            Hide()
                            .Show()
                            .DataMasterToolStripMenuItem.Enabled = True
                            .DetailPenerimaanZakatToolStripMenuItem.Enabled = False
                            .DataZakatFItrahToolStripMenuItem.Enabled = False
                            .TransaksiToolStripMenuItem.Enabled = False
                            .LoginToolStripMenuItem.Enabled = False
                            .LogoutToolStripMenuItem.Enabled = True
                        End With
                    End If
                    'Call Terbuka()
                    FormMenuUtama.Show()
                    'Hide()

                Else
                    If Hitung < 4 Then
                        MsgBox("Password Yang anda masukkan salah !!, Percobaan anda tersisa: " & Hitung, vbCritical + vbOKOnly, "Perhatian")
                        Txt_password.Text = ""
                        Txt_password.Focus()
                        Hitung = Hitung + 1
                    Else
                        MsgBox("Anda Bukan User yang berhak!!", vbCritical + vbOKOnly, "ERROR!!")
                        Me.Close()
                    End If

                End If
                End If
        End If
    End Sub


    Private Sub Btn_keluar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_keluar.Click
        Me.Close()
    End Sub
End Class
