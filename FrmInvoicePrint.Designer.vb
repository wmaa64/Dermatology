<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInvoicePrint
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
        Me.rvInvoice = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'rvInvoice
        '
        Me.rvInvoice.LocalReport.ReportEmbeddedResource = "ClinicPro.Invoice.rdlc"
        Me.rvInvoice.Location = New System.Drawing.Point(12, 12)
        Me.rvInvoice.Name = "rvInvoice"
        Me.rvInvoice.ServerReport.BearerToken = Nothing
        Me.rvInvoice.Size = New System.Drawing.Size(870, 506)
        Me.rvInvoice.TabIndex = 59
        '
        'FrmInvoicePrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 530)
        Me.Controls.Add(Me.rvInvoice)
        Me.Name = "FrmInvoicePrint"
        Me.Text = "FrmInvoicePrint"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rvInvoice As Microsoft.Reporting.WinForms.ReportViewer
End Class
