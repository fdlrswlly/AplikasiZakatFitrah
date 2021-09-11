<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLapDetail
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CR_Detail = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CRDetail1 = New _201804019_Aplikasi_Zakat.CRDetail()
        Me.SuspendLayout()
        '
        'CR_Detail
        '
        Me.CR_Detail.ActiveViewIndex = 0
        Me.CR_Detail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CR_Detail.Cursor = System.Windows.Forms.Cursors.Default
        Me.CR_Detail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CR_Detail.Location = New System.Drawing.Point(0, 0)
        Me.CR_Detail.Name = "CR_Detail"
        Me.CR_Detail.ReportSource = Me.CRDetail1
        Me.CR_Detail.Size = New System.Drawing.Size(789, 508)
        Me.CR_Detail.TabIndex = 0
        Me.CR_Detail.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FormLapDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 508)
        Me.Controls.Add(Me.CR_Detail)
        Me.Name = "FormLapDetail"
        Me.Text = "Laporan Detail Penerimaan"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CR_Detail As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CRDetail1 As _201804019_Aplikasi_Zakat.CRDetail
End Class
