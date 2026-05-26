<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPatientProfile
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvSessions = New System.Windows.Forms.DataGridView()
        Me.btnAddSession = New System.Windows.Forms.Button()
        Me.lblTotalSessions = New System.Windows.Forms.Label()
        Me.lblTotalPaid = New System.Windows.Forms.Label()
        Me.lblRemaining = New System.Windows.Forms.Label()
        Me.btnAddPayment = New System.Windows.Forms.Button()
        Me.lblSessionsCount = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSessions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblName.Location = New System.Drawing.Point(799, 18)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(94, 19)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "اسم المريض"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblPhone.Location = New System.Drawing.Point(548, 18)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(51, 19)
        Me.lblPhone.TabIndex = 1
        Me.lblPhone.Text = "الهاتف"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblAge.Location = New System.Drawing.Point(387, 18)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(43, 19)
        Me.lblAge.TabIndex = 2
        Me.lblAge.Text = "العمر"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblAddress.Location = New System.Drawing.Point(258, 18)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(54, 19)
        Me.lblAddress.TabIndex = 3
        Me.lblAddress.Text = "العنوان"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvSessions)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 184)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(881, 329)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "جلسات الليزر"
        '
        'dgvSessions
        '
        Me.dgvSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSessions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvSessions.Location = New System.Drawing.Point(3, 24)
        Me.dgvSessions.Name = "dgvSessions"
        Me.dgvSessions.ReadOnly = True
        Me.dgvSessions.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgvSessions.RowHeadersVisible = False
        Me.dgvSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSessions.Size = New System.Drawing.Size(875, 302)
        Me.dgvSessions.TabIndex = 3
        '
        'btnAddSession
        '
        Me.btnAddSession.BackColor = System.Drawing.Color.Blue
        Me.btnAddSession.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddSession.ForeColor = System.Drawing.Color.White
        Me.btnAddSession.Location = New System.Drawing.Point(778, 144)
        Me.btnAddSession.Name = "btnAddSession"
        Me.btnAddSession.Size = New System.Drawing.Size(112, 34)
        Me.btnAddSession.TabIndex = 5
        Me.btnAddSession.Text = "إضافة جلسة"
        Me.btnAddSession.UseVisualStyleBackColor = False
        '
        'lblTotalSessions
        '
        Me.lblTotalSessions.AutoSize = True
        Me.lblTotalSessions.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.lblTotalSessions.Location = New System.Drawing.Point(485, 81)
        Me.lblTotalSessions.Name = "lblTotalSessions"
        Me.lblTotalSessions.Size = New System.Drawing.Size(114, 18)
        Me.lblTotalSessions.TabIndex = 7
        Me.lblTotalSessions.Text = "إجمالى الجلسات"
        '
        'lblTotalPaid
        '
        Me.lblTotalPaid.AutoSize = True
        Me.lblTotalPaid.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.lblTotalPaid.Location = New System.Drawing.Point(375, 81)
        Me.lblTotalPaid.Name = "lblTotalPaid"
        Me.lblTotalPaid.Size = New System.Drawing.Size(55, 18)
        Me.lblTotalPaid.TabIndex = 8
        Me.lblTotalPaid.Text = "المدفوع"
        '
        'lblRemaining
        '
        Me.lblRemaining.AutoSize = True
        Me.lblRemaining.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.lblRemaining.Location = New System.Drawing.Point(254, 81)
        Me.lblRemaining.Name = "lblRemaining"
        Me.lblRemaining.Size = New System.Drawing.Size(58, 18)
        Me.lblRemaining.TabIndex = 9
        Me.lblRemaining.Text = "المتبقى"
        '
        'btnAddPayment
        '
        Me.btnAddPayment.BackColor = System.Drawing.Color.Blue
        Me.btnAddPayment.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddPayment.ForeColor = System.Drawing.Color.White
        Me.btnAddPayment.Location = New System.Drawing.Point(619, 81)
        Me.btnAddPayment.Name = "btnAddPayment"
        Me.btnAddPayment.Size = New System.Drawing.Size(112, 34)
        Me.btnAddPayment.TabIndex = 10
        Me.btnAddPayment.Text = "إضافة دفعة"
        Me.btnAddPayment.UseVisualStyleBackColor = False
        '
        'lblSessionsCount
        '
        Me.lblSessionsCount.AutoSize = True
        Me.lblSessionsCount.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.lblSessionsCount.Location = New System.Drawing.Point(64, 160)
        Me.lblSessionsCount.Name = "lblSessionsCount"
        Me.lblSessionsCount.Size = New System.Drawing.Size(92, 18)
        Me.lblSessionsCount.TabIndex = 11
        Me.lblSessionsCount.Text = "عدد الجلسات"
        '
        'FrmPatientProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 525)
        Me.Controls.Add(Me.lblSessionsCount)
        Me.Controls.Add(Me.btnAddPayment)
        Me.Controls.Add(Me.lblRemaining)
        Me.Controls.Add(Me.lblTotalPaid)
        Me.Controls.Add(Me.lblTotalSessions)
        Me.Controls.Add(Me.btnAddSession)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblName)
        Me.Name = "FrmPatientProfile"
        Me.Text = "FrmPatientProfile"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvSessions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAddSession As Button
    Friend WithEvents dgvSessions As DataGridView
    Friend WithEvents lblTotalSessions As Label
    Friend WithEvents lblTotalPaid As Label
    Friend WithEvents lblRemaining As Label
    Friend WithEvents btnAddPayment As Button
    Friend WithEvents lblSessionsCount As Label
End Class
