<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Settings
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.cbDateFormat = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbCurrency = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBrowseBackup = New System.Windows.Forms.Button()
        Me.btnBrowseReports = New System.Windows.Forms.Button()
        Me.btnBrowsePhotos = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtClinicAddress = New System.Windows.Forms.TextBox()
        Me.txtClinicName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBackupPath = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtReportsPath = New System.Windows.Forms.TextBox()
        Me.txtPatientPhotosPath = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtClinicWhatsApp = New System.Windows.Forms.TextBox()
        Me.txtClinicPhone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbDateFormat
        '
        Me.cbDateFormat.FormattingEnabled = True
        Me.cbDateFormat.Location = New System.Drawing.Point(123, 65)
        Me.cbDateFormat.Name = "cbDateFormat"
        Me.cbDateFormat.Size = New System.Drawing.Size(221, 21)
        Me.cbDateFormat.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "DateFormat"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Currency"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbDateFormat)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.cbCurrency)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(30, 334)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(378, 114)
        Me.GroupBox3.TabIndex = 58
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "System"
        '
        'cbCurrency
        '
        Me.cbCurrency.FormattingEnabled = True
        Me.cbCurrency.Location = New System.Drawing.Point(123, 28)
        Me.cbCurrency.Name = "cbCurrency"
        Me.cbCurrency.Size = New System.Drawing.Size(221, 21)
        Me.cbCurrency.TabIndex = 36
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Blue
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(271, 468)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(137, 30)
        Me.btnCancel.TabIndex = 57
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Blue
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(44, 468)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(137, 30)
        Me.btnSave.TabIndex = 56
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnBrowseBackup
        '
        Me.btnBrowseBackup.BackColor = System.Drawing.Color.Blue
        Me.btnBrowseBackup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseBackup.ForeColor = System.Drawing.Color.White
        Me.btnBrowseBackup.Location = New System.Drawing.Point(350, 92)
        Me.btnBrowseBackup.Name = "btnBrowseBackup"
        Me.btnBrowseBackup.Size = New System.Drawing.Size(119, 32)
        Me.btnBrowseBackup.TabIndex = 50
        Me.btnBrowseBackup.Text = "BrowseBackup"
        Me.btnBrowseBackup.UseVisualStyleBackColor = False
        '
        'btnBrowseReports
        '
        Me.btnBrowseReports.BackColor = System.Drawing.Color.Blue
        Me.btnBrowseReports.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseReports.ForeColor = System.Drawing.Color.White
        Me.btnBrowseReports.Location = New System.Drawing.Point(350, 55)
        Me.btnBrowseReports.Name = "btnBrowseReports"
        Me.btnBrowseReports.Size = New System.Drawing.Size(119, 31)
        Me.btnBrowseReports.TabIndex = 49
        Me.btnBrowseReports.Text = "BrowseReports"
        Me.btnBrowseReports.UseVisualStyleBackColor = False
        '
        'btnBrowsePhotos
        '
        Me.btnBrowsePhotos.BackColor = System.Drawing.Color.Blue
        Me.btnBrowsePhotos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowsePhotos.ForeColor = System.Drawing.Color.White
        Me.btnBrowsePhotos.Location = New System.Drawing.Point(350, 17)
        Me.btnBrowsePhotos.Name = "btnBrowsePhotos"
        Me.btnBrowsePhotos.Size = New System.Drawing.Size(119, 32)
        Me.btnBrowsePhotos.TabIndex = 48
        Me.btnBrowsePhotos.Text = "BrowsePhotos"
        Me.btnBrowsePhotos.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "ClinicWhatsApp"
        '
        'txtClinicAddress
        '
        Me.txtClinicAddress.Location = New System.Drawing.Point(123, 48)
        Me.txtClinicAddress.Name = "txtClinicAddress"
        Me.txtClinicAddress.Size = New System.Drawing.Size(221, 20)
        Me.txtClinicAddress.TabIndex = 41
        '
        'txtClinicName
        '
        Me.txtClinicName.Location = New System.Drawing.Point(123, 19)
        Me.txtClinicName.Name = "txtClinicName"
        Me.txtClinicName.Size = New System.Drawing.Size(221, 20)
        Me.txtClinicName.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "BackupPath"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "ReportsPath"
        '
        'txtBackupPath
        '
        Me.txtBackupPath.Location = New System.Drawing.Point(123, 104)
        Me.txtBackupPath.Name = "txtBackupPath"
        Me.txtBackupPath.Size = New System.Drawing.Size(221, 20)
        Me.txtBackupPath.TabIndex = 44
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "PatientPhotosPath"
        '
        'txtReportsPath
        '
        Me.txtReportsPath.Location = New System.Drawing.Point(123, 62)
        Me.txtReportsPath.Name = "txtReportsPath"
        Me.txtReportsPath.Size = New System.Drawing.Size(221, 20)
        Me.txtReportsPath.TabIndex = 41
        '
        'txtPatientPhotosPath
        '
        Me.txtPatientPhotosPath.Location = New System.Drawing.Point(123, 23)
        Me.txtPatientPhotosPath.Name = "txtPatientPhotosPath"
        Me.txtPatientPhotosPath.Size = New System.Drawing.Size(221, 20)
        Me.txtPatientPhotosPath.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "ClinicPhone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "ClinicAddress"
        '
        'txtClinicWhatsApp
        '
        Me.txtClinicWhatsApp.Location = New System.Drawing.Point(123, 100)
        Me.txtClinicWhatsApp.Name = "txtClinicWhatsApp"
        Me.txtClinicWhatsApp.Size = New System.Drawing.Size(221, 20)
        Me.txtClinicWhatsApp.TabIndex = 45
        '
        'txtClinicPhone
        '
        Me.txtClinicPhone.Location = New System.Drawing.Point(123, 74)
        Me.txtClinicPhone.Name = "txtClinicPhone"
        Me.txtClinicPhone.Size = New System.Drawing.Size(221, 20)
        Me.txtClinicPhone.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "ClinicName"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBrowseBackup)
        Me.GroupBox2.Controls.Add(Me.btnBrowseReports)
        Me.GroupBox2.Controls.Add(Me.btnBrowsePhotos)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtBackupPath)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtReportsPath)
        Me.GroupBox2.Controls.Add(Me.txtPatientPhotosPath)
        Me.GroupBox2.Location = New System.Drawing.Point(30, 175)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(493, 140)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Folders"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtClinicWhatsApp)
        Me.GroupBox1.Controls.Add(Me.txtClinicPhone)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtClinicAddress)
        Me.GroupBox1.Controls.Add(Me.txtClinicName)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 132)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clinic Information"
        '
        'UC_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UC_Settings"
        Me.Size = New System.Drawing.Size(801, 553)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbDateFormat As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbCurrency As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnBrowseBackup As Button
    Friend WithEvents btnBrowseReports As Button
    Friend WithEvents btnBrowsePhotos As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtClinicAddress As TextBox
    Friend WithEvents txtClinicName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBackupPath As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtReportsPath As TextBox
    Friend WithEvents txtPatientPhotosPath As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtClinicWhatsApp As TextBox
    Friend WithEvents txtClinicPhone As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
