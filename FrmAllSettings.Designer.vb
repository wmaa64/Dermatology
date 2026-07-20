<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAllSettings
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
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.btnAreas = New System.Windows.Forms.Button()
        Me.btnDevices = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.lblClinic = New System.Windows.Forms.Label()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lbFullName = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnServices = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlHeader.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMain.Location = New System.Drawing.Point(0, 61)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1138, 747)
        Me.pnlMain.TabIndex = 5
        '
        'btnAreas
        '
        Me.btnAreas.FlatAppearance.BorderSize = 0
        Me.btnAreas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAreas.ForeColor = System.Drawing.Color.White
        Me.btnAreas.Location = New System.Drawing.Point(0, 360)
        Me.btnAreas.Name = "btnAreas"
        Me.btnAreas.Size = New System.Drawing.Size(199, 50)
        Me.btnAreas.TabIndex = 11
        Me.btnAreas.Text = "المناطق العلاجية"
        Me.btnAreas.UseVisualStyleBackColor = True
        '
        'btnDevices
        '
        Me.btnDevices.FlatAppearance.BorderSize = 0
        Me.btnDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDevices.ForeColor = System.Drawing.Color.White
        Me.btnDevices.Location = New System.Drawing.Point(0, 317)
        Me.btnDevices.Name = "btnDevices"
        Me.btnDevices.Size = New System.Drawing.Size(199, 50)
        Me.btnDevices.TabIndex = 10
        Me.btnDevices.Text = "الأجهزة"
        Me.btnDevices.UseVisualStyleBackColor = True
        '
        'btnUsers
        '
        Me.btnUsers.FlatAppearance.BorderSize = 0
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsers.ForeColor = System.Drawing.Color.White
        Me.btnUsers.Location = New System.Drawing.Point(0, 274)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(199, 50)
        Me.btnUsers.TabIndex = 9
        Me.btnUsers.Text = "المستخدمين"
        Me.btnUsers.UseVisualStyleBackColor = True
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
        Me.btnSettings.Location = New System.Drawing.Point(3, 231)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(196, 50)
        Me.btnSettings.TabIndex = 7
        Me.btnSettings.Text = "الاعدادات العامة"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Blue
        Me.lblTitle.Location = New System.Drawing.Point(556, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(219, 37)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "الإعدادات الرئيسية"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnMinimize
        '
        Me.btnMinimize.Location = New System.Drawing.Point(1042, 3)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(30, 23)
        Me.btnMinimize.TabIndex = 1
        Me.btnMinimize.Text = "-"
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'pnlHeader
        '
        Me.pnlHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.lbFullName)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.btnMinimize)
        Me.pnlHeader.Controls.Add(Me.btnClose)
        Me.pnlHeader.Location = New System.Drawing.Point(0, -1)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1138, 60)
        Me.pnlHeader.TabIndex = 4
        '
        'lbFullName
        '
        Me.lbFullName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbFullName.AutoSize = True
        Me.lbFullName.BackColor = System.Drawing.Color.Transparent
        Me.lbFullName.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFullName.ForeColor = System.Drawing.Color.Blue
        Me.lbFullName.Location = New System.Drawing.Point(58, 23)
        Me.lbFullName.Name = "lbFullName"
        Me.lbFullName.Size = New System.Drawing.Size(76, 20)
        Me.lbFullName.TabIndex = 4
        Me.lbFullName.Text = "FullName"
        Me.lbFullName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(1080, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(32, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'pnlSidebar
        '
        Me.pnlSidebar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSidebar.BackColor = System.Drawing.SystemColors.Highlight
        Me.pnlSidebar.Controls.Add(Me.Button1)
        Me.pnlSidebar.Controls.Add(Me.PictureBox1)
        Me.pnlSidebar.Controls.Add(Me.btnServices)
        Me.pnlSidebar.Controls.Add(Me.btnReturn)
        Me.pnlSidebar.Controls.Add(Me.btnAreas)
        Me.pnlSidebar.Controls.Add(Me.btnDevices)
        Me.pnlSidebar.Controls.Add(Me.btnUsers)
        Me.pnlSidebar.Controls.Add(Me.lblClinic)
        Me.pnlSidebar.Controls.Add(Me.btnSettings)
        Me.pnlSidebar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlSidebar.Location = New System.Drawing.Point(1141, -2)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(220, 785)
        Me.pnlSidebar.TabIndex = 3
        '
        'btnServices
        '
        Me.btnServices.FlatAppearance.BorderSize = 0
        Me.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnServices.ForeColor = System.Drawing.Color.White
        Me.btnServices.Location = New System.Drawing.Point(2, 405)
        Me.btnServices.Name = "btnServices"
        Me.btnServices.Size = New System.Drawing.Size(199, 50)
        Me.btnServices.TabIndex = 13
        Me.btnServices.Text = "الخدمات"
        Me.btnServices.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.FlatAppearance.BorderSize = 0
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.ForeColor = System.Drawing.Color.White
        Me.btnReturn.Location = New System.Drawing.Point(0, 508)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(199, 50)
        Me.btnReturn.TabIndex = 12
        Me.btnReturn.Text = "رجـــــوع"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(11, 454)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(199, 50)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "انواع الليزر"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ClinicPro.My.Resources.Resources.SkyLogo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 190)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'FrmAllSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 749)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlSidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAllSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAllSettings"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents btnAreas As Button
    Friend WithEvents btnDevices As Button
    Friend WithEvents btnUsers As Button
    Friend WithEvents lblClinic As Label
    Friend WithEvents btnSettings As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnMinimize As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnServices As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbFullName As Label
    Friend WithEvents Button1 As Button
End Class
