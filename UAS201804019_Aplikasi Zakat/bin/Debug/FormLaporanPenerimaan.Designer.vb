<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanPenerimaan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_NmZakat = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CR_Penerima = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.CB_NmZakat)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(647, 95)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Zakat"
        '
        'CB_NmZakat
        '
        Me.CB_NmZakat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_NmZakat.FormattingEnabled = True
        Me.CB_NmZakat.Location = New System.Drawing.Point(121, 39)
        Me.CB_NmZakat.Name = "CB_NmZakat"
        Me.CB_NmZakat.Size = New System.Drawing.Size(154, 23)
        Me.CB_NmZakat.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(299, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 34)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "CETAK LAPORAN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CR_Penerima
        '
        Me.CR_Penerima.ActiveViewIndex = -1
        Me.CR_Penerima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CR_Penerima.Cursor = System.Windows.Forms.Cursors.Default
        Me.CR_Penerima.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CR_Penerima.Location = New System.Drawing.Point(0, 95)
        Me.CR_Penerima.Name = "CR_Penerima"
        Me.CR_Penerima.Size = New System.Drawing.Size(647, 385)
        Me.CR_Penerima.TabIndex = 1
        Me.CR_Penerima.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FormLaporanPenerimaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 480)
        Me.Controls.Add(Me.CR_Penerima)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormLaporanPenerimaan"
        Me.Text = "FormLaporanPenerimaan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CB_NmZakat As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CR_Penerima As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
