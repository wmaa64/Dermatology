<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPatientProfile
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.tabPhotos = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbSessions = New System.Windows.Forms.ComboBox()
        Me.btnAddPhoto = New System.Windows.Forms.Button()
        Me.flpPhotos = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabNotes = New System.Windows.Forms.TabPage()
        Me.flpNotes = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAddNote = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDoctorNote = New System.Windows.Forms.RichTextBox()
        Me.tabSessions = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvSessions = New System.Windows.Forms.DataGridView()
        Me.tabMedical = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSaveMedical = New System.Windows.Forms.Button()
        Me.cbSkinType = New System.Windows.Forms.ComboBox()
        Me.txtMedicalNotes = New System.Windows.Forms.RichTextBox()
        Me.txtMedications = New System.Windows.Forms.RichTextBox()
        Me.txtConditions = New System.Windows.Forms.RichTextBox()
        Me.txtAllergies = New System.Windows.Forms.RichTextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSpotSize = New System.Windows.Forms.TextBox()
        Me.txtPulseWidth = New System.Windows.Forms.TextBox()
        Me.txtEnergy = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbLaserType = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtNextSession = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtDoctorNotes = New System.Windows.Forms.RichTextBox()
        Me.txtSkinReaction = New System.Windows.Forms.RichTextBox()
        Me.txtAreaDetails = New System.Windows.Forms.RichTextBox()
        Me.tabPhotos.SuspendLayout()
        Me.tabNotes.SuspendLayout()
        Me.tabSessions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSessions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMedical.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblName.Location = New System.Drawing.Point(824, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(94, 19)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "اسم المريض"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblPhone.Location = New System.Drawing.Point(548, 9)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(51, 19)
        Me.lblPhone.TabIndex = 1
        Me.lblPhone.Text = "الهاتف"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblAge.Location = New System.Drawing.Point(387, 9)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(43, 19)
        Me.lblAge.TabIndex = 2
        Me.lblAge.Text = "العمر"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblAddress.Location = New System.Drawing.Point(258, 9)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(54, 19)
        Me.lblAddress.TabIndex = 3
        Me.lblAddress.Text = "العنوان"
        '
        'tabPhotos
        '
        Me.tabPhotos.Controls.Add(Me.Label7)
        Me.tabPhotos.Controls.Add(Me.cbSessions)
        Me.tabPhotos.Controls.Add(Me.btnAddPhoto)
        Me.tabPhotos.Controls.Add(Me.flpPhotos)
        Me.tabPhotos.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPhotos.Location = New System.Drawing.Point(4, 29)
        Me.tabPhotos.Name = "tabPhotos"
        Me.tabPhotos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tabPhotos.Size = New System.Drawing.Size(944, 567)
        Me.tabPhotos.TabIndex = 5
        Me.tabPhotos.Text = "الصور"
        Me.tabPhotos.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(532, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 19)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "اختر الجلسة"
        '
        'cbSessions
        '
        Me.cbSessions.FormattingEnabled = True
        Me.cbSessions.Items.AddRange(New Object() {"Type I", "Type II", "Type III", "Type IV", "Type V", "Type VI"})
        Me.cbSessions.Location = New System.Drawing.Point(242, 14)
        Me.cbSessions.Name = "cbSessions"
        Me.cbSessions.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbSessions.Size = New System.Drawing.Size(284, 24)
        Me.cbSessions.TabIndex = 18
        '
        'btnAddPhoto
        '
        Me.btnAddPhoto.BackColor = System.Drawing.Color.Blue
        Me.btnAddPhoto.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddPhoto.ForeColor = System.Drawing.Color.White
        Me.btnAddPhoto.Location = New System.Drawing.Point(786, 14)
        Me.btnAddPhoto.Name = "btnAddPhoto"
        Me.btnAddPhoto.Size = New System.Drawing.Size(112, 34)
        Me.btnAddPhoto.TabIndex = 14
        Me.btnAddPhoto.Text = "إضافة صورة"
        Me.btnAddPhoto.UseVisualStyleBackColor = False
        '
        'flpPhotos
        '
        Me.flpPhotos.AutoScroll = True
        Me.flpPhotos.Location = New System.Drawing.Point(14, 54)
        Me.flpPhotos.Name = "flpPhotos"
        Me.flpPhotos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.flpPhotos.Size = New System.Drawing.Size(884, 504)
        Me.flpPhotos.TabIndex = 5
        Me.flpPhotos.WrapContents = False
        '
        'tabNotes
        '
        Me.tabNotes.Controls.Add(Me.flpNotes)
        Me.tabNotes.Controls.Add(Me.btnAddNote)
        Me.tabNotes.Controls.Add(Me.Label6)
        Me.tabNotes.Controls.Add(Me.txtDoctorNote)
        Me.tabNotes.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabNotes.Location = New System.Drawing.Point(4, 29)
        Me.tabNotes.Name = "tabNotes"
        Me.tabNotes.Size = New System.Drawing.Size(944, 567)
        Me.tabNotes.TabIndex = 4
        Me.tabNotes.Text = "ملاحظات الطبيب"
        Me.tabNotes.UseVisualStyleBackColor = True
        '
        'flpNotes
        '
        Me.flpNotes.AutoScroll = True
        Me.flpNotes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpNotes.Location = New System.Drawing.Point(256, 151)
        Me.flpNotes.Name = "flpNotes"
        Me.flpNotes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.flpNotes.Size = New System.Drawing.Size(270, 400)
        Me.flpNotes.TabIndex = 18
        '
        'btnAddNote
        '
        Me.btnAddNote.BackColor = System.Drawing.Color.Blue
        Me.btnAddNote.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddNote.ForeColor = System.Drawing.Color.White
        Me.btnAddNote.Location = New System.Drawing.Point(766, 21)
        Me.btnAddNote.Name = "btnAddNote"
        Me.btnAddNote.Size = New System.Drawing.Size(121, 32)
        Me.btnAddNote.TabIndex = 17
        Me.btnAddNote.Text = "Save"
        Me.btnAddNote.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(779, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 19)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "TimeLine Note"
        '
        'txtDoctorNote
        '
        Me.txtDoctorNote.Location = New System.Drawing.Point(637, 151)
        Me.txtDoctorNote.Name = "txtDoctorNote"
        Me.txtDoctorNote.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtDoctorNote.Size = New System.Drawing.Size(250, 400)
        Me.txtDoctorNote.TabIndex = 15
        Me.txtDoctorNote.Text = ""
        '
        'tabSessions
        '
        Me.tabSessions.Controls.Add(Me.Label12)
        Me.tabSessions.Controls.Add(Me.dtNextSession)
        Me.tabSessions.Controls.Add(Me.Label13)
        Me.tabSessions.Controls.Add(Me.Label14)
        Me.tabSessions.Controls.Add(Me.Label15)
        Me.tabSessions.Controls.Add(Me.txtDoctorNotes)
        Me.tabSessions.Controls.Add(Me.txtSkinReaction)
        Me.tabSessions.Controls.Add(Me.txtAreaDetails)
        Me.tabSessions.Controls.Add(Me.Label8)
        Me.tabSessions.Controls.Add(Me.Label9)
        Me.tabSessions.Controls.Add(Me.Label10)
        Me.tabSessions.Controls.Add(Me.txtSpotSize)
        Me.tabSessions.Controls.Add(Me.txtPulseWidth)
        Me.tabSessions.Controls.Add(Me.txtEnergy)
        Me.tabSessions.Controls.Add(Me.Label11)
        Me.tabSessions.Controls.Add(Me.cbLaserType)
        Me.tabSessions.Controls.Add(Me.GroupBox1)
        Me.tabSessions.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabSessions.Location = New System.Drawing.Point(4, 29)
        Me.tabSessions.Name = "tabSessions"
        Me.tabSessions.Size = New System.Drawing.Size(944, 567)
        Me.tabSessions.TabIndex = 2
        Me.tabSessions.Text = "الجلسات"
        Me.tabSessions.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvSessions)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(920, 178)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "جلسات الليزر"
        '
        'dgvSessions
        '
        Me.dgvSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSessions.Location = New System.Drawing.Point(15, 37)
        Me.dgvSessions.Name = "dgvSessions"
        Me.dgvSessions.ReadOnly = True
        Me.dgvSessions.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgvSessions.RowHeadersVisible = False
        Me.dgvSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSessions.Size = New System.Drawing.Size(887, 132)
        Me.dgvSessions.TabIndex = 3
        '
        'tabMedical
        '
        Me.tabMedical.Controls.Add(Me.Label5)
        Me.tabMedical.Controls.Add(Me.Label4)
        Me.tabMedical.Controls.Add(Me.Label3)
        Me.tabMedical.Controls.Add(Me.Label2)
        Me.tabMedical.Controls.Add(Me.Label1)
        Me.tabMedical.Controls.Add(Me.btnSaveMedical)
        Me.tabMedical.Controls.Add(Me.cbSkinType)
        Me.tabMedical.Controls.Add(Me.txtMedicalNotes)
        Me.tabMedical.Controls.Add(Me.txtMedications)
        Me.tabMedical.Controls.Add(Me.txtConditions)
        Me.tabMedical.Controls.Add(Me.txtAllergies)
        Me.tabMedical.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMedical.Location = New System.Drawing.Point(4, 29)
        Me.tabMedical.Name = "tabMedical"
        Me.tabMedical.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMedical.Size = New System.Drawing.Size(944, 567)
        Me.tabMedical.TabIndex = 1
        Me.tabMedical.Text = "التاريخ المرضى"
        Me.tabMedical.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(380, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 19)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Notes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(357, 508)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 19)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "SkinType"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(814, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Conditions"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(340, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Medications"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(829, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 19)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Allergies"
        '
        'btnSaveMedical
        '
        Me.btnSaveMedical.BackColor = System.Drawing.Color.Blue
        Me.btnSaveMedical.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveMedical.ForeColor = System.Drawing.Color.White
        Me.btnSaveMedical.Location = New System.Drawing.Point(773, 530)
        Me.btnSaveMedical.Name = "btnSaveMedical"
        Me.btnSaveMedical.Size = New System.Drawing.Size(121, 32)
        Me.btnSaveMedical.TabIndex = 12
        Me.btnSaveMedical.Text = "Save"
        Me.btnSaveMedical.UseVisualStyleBackColor = False
        '
        'cbSkinType
        '
        Me.cbSkinType.FormattingEnabled = True
        Me.cbSkinType.Items.AddRange(New Object() {"Type I", "Type II", "Type III", "Type IV", "Type V", "Type VI"})
        Me.cbSkinType.Location = New System.Drawing.Point(318, 530)
        Me.cbSkinType.Name = "cbSkinType"
        Me.cbSkinType.Size = New System.Drawing.Size(121, 24)
        Me.cbSkinType.TabIndex = 4
        '
        'txtMedicalNotes
        '
        Me.txtMedicalNotes.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtMedicalNotes.Location = New System.Drawing.Point(45, 285)
        Me.txtMedicalNotes.Name = "txtMedicalNotes"
        Me.txtMedicalNotes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMedicalNotes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtMedicalNotes.Size = New System.Drawing.Size(394, 213)
        Me.txtMedicalNotes.TabIndex = 3
        Me.txtMedicalNotes.Text = ""
        '
        'txtMedications
        '
        Me.txtMedications.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtMedications.Location = New System.Drawing.Point(45, 36)
        Me.txtMedications.Name = "txtMedications"
        Me.txtMedications.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMedications.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtMedications.Size = New System.Drawing.Size(394, 224)
        Me.txtMedications.TabIndex = 2
        Me.txtMedications.Text = ""
        '
        'txtConditions
        '
        Me.txtConditions.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtConditions.Location = New System.Drawing.Point(500, 285)
        Me.txtConditions.Name = "txtConditions"
        Me.txtConditions.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConditions.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtConditions.Size = New System.Drawing.Size(394, 213)
        Me.txtConditions.TabIndex = 1
        Me.txtConditions.Text = ""
        '
        'txtAllergies
        '
        Me.txtAllergies.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtAllergies.Location = New System.Drawing.Point(501, 36)
        Me.txtAllergies.Name = "txtAllergies"
        Me.txtAllergies.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAllergies.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtAllergies.Size = New System.Drawing.Size(394, 224)
        Me.txtAllergies.TabIndex = 0
        Me.txtAllergies.Text = ""
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabMedical)
        Me.TabControl1.Controls.Add(Me.tabSessions)
        Me.TabControl1.Controls.Add(Me.tabNotes)
        Me.TabControl1.Controls.Add(Me.tabPhotos)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.Location = New System.Drawing.Point(12, 52)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(952, 600)
        Me.TabControl1.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(408, 205)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 16)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Spot Size"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(543, 205)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 16)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Pulse Width"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(719, 206)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 16)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Energy"
        '
        'txtSpotSize
        '
        Me.txtSpotSize.Location = New System.Drawing.Point(351, 224)
        Me.txtSpotSize.Name = "txtSpotSize"
        Me.txtSpotSize.Size = New System.Drawing.Size(121, 23)
        Me.txtSpotSize.TabIndex = 39
        '
        'txtPulseWidth
        '
        Me.txtPulseWidth.Location = New System.Drawing.Point(502, 225)
        Me.txtPulseWidth.Name = "txtPulseWidth"
        Me.txtPulseWidth.Size = New System.Drawing.Size(121, 23)
        Me.txtPulseWidth.TabIndex = 38
        '
        'txtEnergy
        '
        Me.txtEnergy.Location = New System.Drawing.Point(647, 225)
        Me.txtEnergy.Name = "txtEnergy"
        Me.txtEnergy.Size = New System.Drawing.Size(121, 23)
        Me.txtEnergy.TabIndex = 37
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(827, 202)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 19)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Laser Type"
        '
        'cbLaserType
        '
        Me.cbLaserType.FormattingEnabled = True
        Me.cbLaserType.Items.AddRange(New Object() {"Candela GentleMax", "Soprano Titanium", "Clarity II", "ND:YAG", "Alexandrite", "Diode"})
        Me.cbLaserType.Location = New System.Drawing.Point(792, 224)
        Me.cbLaserType.Name = "cbLaserType"
        Me.cbLaserType.Size = New System.Drawing.Size(121, 24)
        Me.cbLaserType.TabIndex = 35
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(327, 432)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(155, 19)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "Date of Next Session"
        '
        'dtNextSession
        '
        Me.dtNextSession.Location = New System.Drawing.Point(282, 454)
        Me.dtNextSession.Name = "dtNextSession"
        Me.dtNextSession.Size = New System.Drawing.Size(200, 23)
        Me.dtNextSession.TabIndex = 49
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(815, 432)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 19)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Doctor Notes"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label14.Location = New System.Drawing.Point(383, 261)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 19)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "Skin Reaction"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label15.Location = New System.Drawing.Point(819, 261)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 19)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "Area Details"
        '
        'txtDoctorNotes
        '
        Me.txtDoctorNotes.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtDoctorNotes.Location = New System.Drawing.Point(519, 454)
        Me.txtDoctorNotes.Name = "txtDoctorNotes"
        Me.txtDoctorNotes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDoctorNotes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtDoctorNotes.Size = New System.Drawing.Size(394, 98)
        Me.txtDoctorNotes.TabIndex = 45
        Me.txtDoctorNotes.Text = ""
        '
        'txtSkinReaction
        '
        Me.txtSkinReaction.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtSkinReaction.Location = New System.Drawing.Point(88, 283)
        Me.txtSkinReaction.Name = "txtSkinReaction"
        Me.txtSkinReaction.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSkinReaction.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtSkinReaction.Size = New System.Drawing.Size(394, 124)
        Me.txtSkinReaction.TabIndex = 44
        Me.txtSkinReaction.Text = ""
        '
        'txtAreaDetails
        '
        Me.txtAreaDetails.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtAreaDetails.Location = New System.Drawing.Point(519, 283)
        Me.txtAreaDetails.Name = "txtAreaDetails"
        Me.txtAreaDetails.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAreaDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtAreaDetails.Size = New System.Drawing.Size(394, 124)
        Me.txtAreaDetails.TabIndex = 43
        Me.txtAreaDetails.Text = ""
        '
        'FrmPatientProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1144, 661)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblName)
        Me.Name = "FrmPatientProfile"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "FrmPatientProfile"
        Me.tabPhotos.ResumeLayout(False)
        Me.tabPhotos.PerformLayout()
        Me.tabNotes.ResumeLayout(False)
        Me.tabNotes.PerformLayout()
        Me.tabSessions.ResumeLayout(False)
        Me.tabSessions.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvSessions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMedical.ResumeLayout(False)
        Me.tabMedical.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents tabPhotos As TabPage
    Friend WithEvents tabNotes As TabPage
    Friend WithEvents tabSessions As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvSessions As DataGridView
    Friend WithEvents tabMedical As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents txtAllergies As RichTextBox
    Friend WithEvents txtMedicalNotes As RichTextBox
    Friend WithEvents txtMedications As RichTextBox
    Friend WithEvents txtConditions As RichTextBox
    Friend WithEvents cbSkinType As ComboBox
    Friend WithEvents btnSaveMedical As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddNote As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDoctorNote As RichTextBox
    Friend WithEvents flpNotes As FlowLayoutPanel
    Friend WithEvents flpPhotos As FlowLayoutPanel
    Friend WithEvents btnAddPhoto As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cbSessions As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSpotSize As TextBox
    Friend WithEvents txtPulseWidth As TextBox
    Friend WithEvents txtEnergy As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbLaserType As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents dtNextSession As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtDoctorNotes As RichTextBox
    Friend WithEvents txtSkinReaction As RichTextBox
    Friend WithEvents txtAreaDetails As RichTextBox
End Class
