<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRevenueByDoctor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbDoctors = New System.Windows.Forms.ComboBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.rvRevenue = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'dtpTo
        '
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(285, 11)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(200, 20)
        Me.dtpTo.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(505, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "إلى تاريخ"
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(589, 12)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(200, 20)
        Me.dtpFrom.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(809, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "من تاريخ"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(801, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 19)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "الدكتور"
        '
        'cbDoctors
        '
        Me.cbDoctors.FormattingEnabled = True
        Me.cbDoctors.Items.AddRange(New Object() {"Full Face", "Upper Lip", "Chin", "Neck", "Underarm", "Arms", "Legs", "Bikini", "Back", "Chest"})
        Me.cbDoctors.Location = New System.Drawing.Point(589, 38)
        Me.cbDoctors.Name = "cbDoctors"
        Me.cbDoctors.Size = New System.Drawing.Size(200, 21)
        Me.cbDoctors.TabIndex = 55
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.Blue
        Me.btnShow.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnShow.ForeColor = System.Drawing.Color.White
        Me.btnShow.Location = New System.Drawing.Point(668, 65)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(121, 32)
        Me.btnShow.TabIndex = 57
        Me.btnShow.Text = "عرض التقرير"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'rvRevenue
        '
        Me.rvRevenue.LocalReport.ReportEmbeddedResource = "ClinicPro.RevenueByDoctor.rdlc"
        Me.rvRevenue.Location = New System.Drawing.Point(12, 111)
        Me.rvRevenue.Name = "rvRevenue"
        Me.rvRevenue.ServerReport.BearerToken = Nothing
        Me.rvRevenue.Size = New System.Drawing.Size(870, 389)
        Me.rvRevenue.TabIndex = 58
        '
        'FrmRevenueByDoctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 530)
        Me.Controls.Add(Me.rvRevenue)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbDoctors)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FrmRevenueByDoctor"
        Me.Text = "FrmRevenueByDoctor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cbDoctors As ComboBox
    Friend WithEvents btnShow As Button
    Friend WithEvents rvRevenue As Microsoft.Reporting.WinForms.ReportViewer
End Class
