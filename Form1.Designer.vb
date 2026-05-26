<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.lblClinic = New System.Windows.Forms.Label()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnAppointments = New System.Windows.Forms.Button()
        Me.btnAccounts = New System.Windows.Forms.Button()
        Me.btnSessions = New System.Windows.Forms.Button()
        Me.btnPatients = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSidebar.BackColor = System.Drawing.SystemColors.Highlight
        Me.pnlSidebar.Controls.Add(Me.lblClinic)
        Me.pnlSidebar.Controls.Add(Me.btnSettings)
        Me.pnlSidebar.Controls.Add(Me.btnReports)
        Me.pnlSidebar.Controls.Add(Me.btnAppointments)
        Me.pnlSidebar.Controls.Add(Me.btnAccounts)
        Me.pnlSidebar.Controls.Add(Me.btnSessions)
        Me.pnlSidebar.Controls.Add(Me.btnPatients)
        Me.pnlSidebar.Controls.Add(Me.btnDashboard)
        Me.pnlSidebar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlSidebar.Location = New System.Drawing.Point(1146, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(220, 746)
        Me.pnlSidebar.TabIndex = 0
        '
        'lblClinic
        '
        Me.lblClinic.AutoSize = True
        Me.lblClinic.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClinic.ForeColor = System.Drawing.Color.White
        Me.lblClinic.Location = New System.Drawing.Point(53, 3)
        Me.lblClinic.Name = "lblClinic"
        Me.lblClinic.Size = New System.Drawing.Size(125, 30)
        Me.lblClinic.TabIndex = 8
        Me.lblClinic.Text = "عيادة الجلدية"
        '
        'btnSettings
        '
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.Location = New System.Drawing.Point(0, 332)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(220, 50)
        Me.btnSettings.TabIndex = 7
        Me.btnSettings.Text = "الاعدادات"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.ForeColor = System.Drawing.Color.White
        Me.btnReports.Location = New System.Drawing.Point(0, 282)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(220, 50)
        Me.btnReports.TabIndex = 6
        Me.btnReports.Text = "التقارير"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnAppointments
        '
        Me.btnAppointments.FlatAppearance.BorderSize = 0
        Me.btnAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAppointments.ForeColor = System.Drawing.Color.White
        Me.btnAppointments.Location = New System.Drawing.Point(0, 237)
        Me.btnAppointments.Name = "btnAppointments"
        Me.btnAppointments.Size = New System.Drawing.Size(220, 50)
        Me.btnAppointments.TabIndex = 5
        Me.btnAppointments.Text = "الحجوزات"
        Me.btnAppointments.UseVisualStyleBackColor = True
        '
        'btnAccounts
        '
        Me.btnAccounts.FlatAppearance.BorderSize = 0
        Me.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccounts.ForeColor = System.Drawing.Color.White
        Me.btnAccounts.Location = New System.Drawing.Point(0, 191)
        Me.btnAccounts.Name = "btnAccounts"
        Me.btnAccounts.Size = New System.Drawing.Size(220, 50)
        Me.btnAccounts.TabIndex = 4
        Me.btnAccounts.Text = "الحسابات"
        Me.btnAccounts.UseVisualStyleBackColor = True
        '
        'btnSessions
        '
        Me.btnSessions.FlatAppearance.BorderSize = 0
        Me.btnSessions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSessions.ForeColor = System.Drawing.Color.White
        Me.btnSessions.Location = New System.Drawing.Point(0, 145)
        Me.btnSessions.Name = "btnSessions"
        Me.btnSessions.Size = New System.Drawing.Size(220, 50)
        Me.btnSessions.TabIndex = 3
        Me.btnSessions.Text = "جلسات الليزر"
        Me.btnSessions.UseVisualStyleBackColor = True
        '
        'btnPatients
        '
        Me.btnPatients.FlatAppearance.BorderSize = 0
        Me.btnPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPatients.ForeColor = System.Drawing.Color.White
        Me.btnPatients.Location = New System.Drawing.Point(0, 102)
        Me.btnPatients.Name = "btnPatients"
        Me.btnPatients.Size = New System.Drawing.Size(220, 50)
        Me.btnPatients.TabIndex = 1
        Me.btnPatients.Text = "المرضى"
        Me.btnPatients.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Location = New System.Drawing.Point(0, 59)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(220, 50)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "الرئيسية"
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'pnlHeader
        '
        Me.pnlHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.btnMinimize)
        Me.pnlHeader.Controls.Add(Me.btnClose)
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1146, 60)
        Me.pnlHeader.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Blue
        Me.lblTitle.Location = New System.Drawing.Point(564, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(106, 37)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "الرئيسية"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnMinimize
        '
        Me.btnMinimize.Location = New System.Drawing.Point(1067, 3)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(30, 23)
        Me.btnMinimize.TabIndex = 1
        Me.btnMinimize.Text = "-"
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(1105, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(32, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'pnlMain
        '
        Me.pnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMain.Location = New System.Drawing.Point(0, 60)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1146, 708)
        Me.pnlMain.TabIndex = 2
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 749)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMain"
        Me.Text = "Form1"
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnAccounts As Button
    Friend WithEvents btnAppointments As Button
    Friend WithEvents btnSessions As Button
    Friend WithEvents btnPatients As Button
    Friend WithEvents lblClinic As Label
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblTitle As Label

End Class
