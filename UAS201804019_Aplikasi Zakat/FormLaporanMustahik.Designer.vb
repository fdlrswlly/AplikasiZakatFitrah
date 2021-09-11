<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanMustahik
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_laporan = New System.Windows.Forms.Button()
        Me.CB_status = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CR_Mustahik = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_laporan)
        Me.GroupBox1.Controls.Add(Me.CB_status)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(805, 101)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btn_laporan
        '
        Me.btn_laporan.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_laporan.Location = New System.Drawing.Point(291, 39)
        Me.btn_laporan.Name = "btn_laporan"
        Me.btn_laporan.Size = New System.Drawing.Size(138, 32)
        Me.btn_laporan.TabIndex = 2
        Me.btn_laporan.Text = "CETAK LAPORAN"
        Me.btn_laporan.UseVisualStyleBackColor = True
        '
        'CB_status
        '
        Me.CB_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_status.FormattingEnabled = True
        Me.CB_status.Location = New System.Drawing.Point(105, 44)
        Me.CB_status.Name = "CB_status"
        Me.CB_status.Size = New System.Drawing.Size(166, 21)
        Me.CB_status.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Status"
        '
        'CR_Mustahik
        '
        Me.CR_Mustahik.ActiveViewIndex = -1
        Me.CR_Mustahik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CR_Mustahik.Cursor = System.Windows.Forms.Cursors.Default
        Me.CR_Mustahik.Location = New System.Drawing.Point(0, 101)
        Me.CR_Mustahik.Name = "CR_Mustahik"
        Me.CR_Mustahik.ShowGroupTreeButton = False
        Me.CR_Mustahik.ShowLogo = False
        Me.CR_Mustahik.Size = New System.Drawing.Size(805, 400)
        Me.CR_Mustahik.TabIndex = 1
        Me.CR_Mustahik.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FormLaporanMustahik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 501)
        Me.Controls.Add(Me.CR_Mustahik)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormLaporanMustahik"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLaporanMustahik"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_laporan As System.Windows.Forms.Button
    Friend WithEvents CB_status As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CR_Mustahik As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
