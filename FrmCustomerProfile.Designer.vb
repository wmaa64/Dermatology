<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCustomerProfile
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbPhotoPlan = New System.Windows.Forms.ComboBox()
        Me.btnAddPhoto = New System.Windows.Forms.Button()
        Me.flpPhotos = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabNotes = New System.Windows.Forms.TabPage()
        Me.flpNotes = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAddNote = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDoctorNote = New System.Windows.Forms.RichTextBox()
        Me.tabPayments = New System.Windows.Forms.TabPage()
        Me.lblTotalSessions = New System.Windows.Forms.Label()
        Me.btnAddPayment = New System.Windows.Forms.Button()
        Me.lblRemaining = New System.Windows.Forms.Label()
        Me.lblTotalPaid = New System.Windows.Forms.Label()
        Me.tabSessions = New System.Windows.Forms.TabPage()
        Me.lblSessionsCount = New System.Windows.Forms.Label()
        Me.btnAddSession = New System.Windows.Forms.Button()
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
        Me.tabOverview = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabTreatmentPlan = New System.Windows.Forms.TabPage()
        Me.prgTreatment = New System.Windows.Forms.ProgressBar()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.lblRemainingSessions = New System.Windows.Forms.Label()
        Me.lblCompleted = New System.Windows.Forms.Label()
        Me.dgvTreatmentPlans = New System.Windows.Forms.DataGridView()
        Me.btnNewPlan = New System.Windows.Forms.Button()
        Me.tabPhotos.SuspendLayout()
        Me.tabNotes.SuspendLayout()
        Me.tabPayments.SuspendLayout()
        Me.tabSessions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSessions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMedical.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabTreatmentPlan.SuspendLayout()
        CType(Me.dgvTreatmentPlans, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabPhotos.Controls.Add(Me.Label12)
        Me.tabPhotos.Controls.Add(Me.cbPhotoPlan)
        Me.tabPhotos.Controls.Add(Me.btnAddPhoto)
        Me.tabPhotos.Controls.Add(Me.flpPhotos)
        Me.tabPhotos.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPhotos.Location = New System.Drawing.Point(4, 29)
        Me.tabPhotos.Name = "tabPhotos"
        Me.tabPhotos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tabPhotos.Size = New System.Drawing.Size(915, 567)
        Me.tabPhotos.TabIndex = 5
        Me.tabPhotos.Text = "الصور"
        Me.tabPhotos.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(624, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 19)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "اختار الخطة"
        '
        'cbPhotoPlan
        '
        Me.cbPhotoPlan.FormattingEnabled = True
        Me.cbPhotoPlan.Location = New System.Drawing.Point(312, 19)
        Me.cbPhotoPlan.Name = "cbPhotoPlan"
        Me.cbPhotoPlan.Size = New System.Drawing.Size(300, 24)
        Me.cbPhotoPlan.TabIndex = 56
        '
        'btnAddPhoto
        '
        Me.btnAddPhoto.BackColor = System.Drawing.Color.Blue
        Me.btnAddPhoto.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddPhoto.ForeColor = System.Drawing.Color.White
        Me.btnAddPhoto.Location = New System.Drawing.Point(761, 19)
        Me.btnAddPhoto.Name = "btnAddPhoto"
        Me.btnAddPhoto.Size = New System.Drawing.Size(112, 34)
        Me.btnAddPhoto.TabIndex = 14
        Me.btnAddPhoto.Text = "إضافة صورة"
        Me.btnAddPhoto.UseVisualStyleBackColor = False
        '
        'flpPhotos
        '
        Me.flpPhotos.AutoScroll = True
        Me.flpPhotos.Location = New System.Drawing.Point(14, 59)
        Me.flpPhotos.Name = "flpPhotos"
        Me.flpPhotos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.flpPhotos.Size = New System.Drawing.Size(884, 499)
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
        Me.tabNotes.Size = New System.Drawing.Size(915, 567)
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
        'tabPayments
        '
        Me.tabPayments.Controls.Add(Me.lblTotalSessions)
        Me.tabPayments.Controls.Add(Me.btnAddPayment)
        Me.tabPayments.Controls.Add(Me.lblRemaining)
        Me.tabPayments.Controls.Add(Me.lblTotalPaid)
        Me.tabPayments.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPayments.Location = New System.Drawing.Point(4, 29)
        Me.tabPayments.Name = "tabPayments"
        Me.tabPayments.Size = New System.Drawing.Size(915, 567)
        Me.tabPayments.TabIndex = 3
        Me.tabPayments.Text = "الحسابات"
        Me.tabPayments.UseVisualStyleBackColor = True
        '
        'lblTotalSessions
        '
        Me.lblTotalSessions.AutoSize = True
        Me.lblTotalSessions.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.lblTotalSessions.Location = New System.Drawing.Point(451, 23)
        Me.lblTotalSessions.Name = "lblTotalSessions"
        Me.lblTotalSessions.Size = New System.Drawing.Size(114, 18)
        Me.lblTotalSessions.TabIndex = 15
        Me.lblTotalSessions.Text = "إجمالى الجلسات"
        '
        'btnAddPayment
        '
        Me.btnAddPayment.BackColor = System.Drawing.Color.Blue
        Me.btnAddPayment.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddPayment.ForeColor = System.Drawing.Color.White
        Me.btnAddPayment.Location = New System.Drawing.Point(739, 23)
        Me.btnAddPayment.Name = "btnAddPayment"
        Me.btnAddPayment.Size = New System.Drawing.Size(112, 34)
        Me.btnAddPayment.TabIndex = 12
        Me.btnAddPayment.Text = "إضافة دفعة"
        Me.btnAddPayment.UseVisualStyleBackColor = False
        '
        'lblRemaining
        '
        Me.lblRemaining.AutoSize = True
        Me.lblRemaining.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.lblRemaining.Location = New System.Drawing.Point(185, 23)
        Me.lblRemaining.Name = "lblRemaining"
        Me.lblRemaining.Size = New System.Drawing.Size(58, 18)
        Me.lblRemaining.TabIndex = 11
        Me.lblRemaining.Text = "المتبقى"
        '
        'lblTotalPaid
        '
        Me.lblTotalPaid.AutoSize = True
        Me.lblTotalPaid.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.lblTotalPaid.Location = New System.Drawing.Point(306, 23)
        Me.lblTotalPaid.Name = "lblTotalPaid"
        Me.lblTotalPaid.Size = New System.Drawing.Size(55, 18)
        Me.lblTotalPaid.TabIndex = 10
        Me.lblTotalPaid.Text = "المدفوع"
        '
        'tabSessions
        '
        Me.tabSessions.Controls.Add(Me.lblSessionsCount)
        Me.tabSessions.Controls.Add(Me.btnAddSession)
        Me.tabSessions.Controls.Add(Me.GroupBox1)
        Me.tabSessions.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabSessions.Location = New System.Drawing.Point(4, 29)
        Me.tabSessions.Name = "tabSessions"
        Me.tabSessions.Size = New System.Drawing.Size(915, 567)
        Me.tabSessions.TabIndex = 2
        Me.tabSessions.Text = "الجلسات"
        Me.tabSessions.UseVisualStyleBackColor = True
        '
        'lblSessionsCount
        '
        Me.lblSessionsCount.AutoSize = True
        Me.lblSessionsCount.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.lblSessionsCount.Location = New System.Drawing.Point(32, 45)
        Me.lblSessionsCount.Name = "lblSessionsCount"
        Me.lblSessionsCount.Size = New System.Drawing.Size(92, 18)
        Me.lblSessionsCount.TabIndex = 15
        Me.lblSessionsCount.Text = "عدد الجلسات"
        '
        'btnAddSession
        '
        Me.btnAddSession.BackColor = System.Drawing.Color.Blue
        Me.btnAddSession.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddSession.ForeColor = System.Drawing.Color.White
        Me.btnAddSession.Location = New System.Drawing.Point(739, 12)
        Me.btnAddSession.Name = "btnAddSession"
        Me.btnAddSession.Size = New System.Drawing.Size(112, 34)
        Me.btnAddSession.TabIndex = 13
        Me.btnAddSession.Text = "إضافة جلسة"
        Me.btnAddSession.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvSessions)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(846, 373)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "جلسات الليزر"
        '
        'dgvSessions
        '
        Me.dgvSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSessions.Location = New System.Drawing.Point(6, 37)
        Me.dgvSessions.Name = "dgvSessions"
        Me.dgvSessions.ReadOnly = True
        Me.dgvSessions.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgvSessions.RowHeadersVisible = False
        Me.dgvSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSessions.Size = New System.Drawing.Size(834, 332)
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
        Me.tabMedical.Size = New System.Drawing.Size(915, 567)
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
        Me.Label3.Location = New System.Drawing.Point(748, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Medical Conditions"
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
        'tabOverview
        '
        Me.tabOverview.BackColor = System.Drawing.Color.Transparent
        Me.tabOverview.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabOverview.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tabOverview.Location = New System.Drawing.Point(4, 29)
        Me.tabOverview.Name = "tabOverview"
        Me.tabOverview.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOverview.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tabOverview.Size = New System.Drawing.Size(915, 567)
        Me.tabOverview.TabIndex = 0
        Me.tabOverview.Text = "نظرة عامة"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabOverview)
        Me.TabControl1.Controls.Add(Me.tabTreatmentPlan)
        Me.TabControl1.Controls.Add(Me.tabMedical)
        Me.TabControl1.Controls.Add(Me.tabSessions)
        Me.TabControl1.Controls.Add(Me.tabPayments)
        Me.TabControl1.Controls.Add(Me.tabNotes)
        Me.TabControl1.Controls.Add(Me.tabPhotos)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.Location = New System.Drawing.Point(12, 52)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(923, 600)
        Me.TabControl1.TabIndex = 12
        '
        'tabTreatmentPlan
        '
        Me.tabTreatmentPlan.Controls.Add(Me.prgTreatment)
        Me.tabTreatmentPlan.Controls.Add(Me.lblProgress)
        Me.tabTreatmentPlan.Controls.Add(Me.lblRemainingSessions)
        Me.tabTreatmentPlan.Controls.Add(Me.lblCompleted)
        Me.tabTreatmentPlan.Controls.Add(Me.dgvTreatmentPlans)
        Me.tabTreatmentPlan.Controls.Add(Me.btnNewPlan)
        Me.tabTreatmentPlan.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabTreatmentPlan.Location = New System.Drawing.Point(4, 29)
        Me.tabTreatmentPlan.Name = "tabTreatmentPlan"
        Me.tabTreatmentPlan.Size = New System.Drawing.Size(915, 567)
        Me.tabTreatmentPlan.TabIndex = 6
        Me.tabTreatmentPlan.Text = "الخطة العلاجية"
        Me.tabTreatmentPlan.UseVisualStyleBackColor = True
        '
        'prgTreatment
        '
        Me.prgTreatment.Location = New System.Drawing.Point(12, 19)
        Me.prgTreatment.Name = "prgTreatment"
        Me.prgTreatment.Size = New System.Drawing.Size(188, 23)
        Me.prgTreatment.TabIndex = 5
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblProgress.Location = New System.Drawing.Point(203, 43)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(70, 19)
        Me.lblProgress.TabIndex = 4
        Me.lblProgress.Text = "Progress"
        '
        'lblRemainingSessions
        '
        Me.lblRemainingSessions.AutoSize = True
        Me.lblRemainingSessions.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblRemainingSessions.Location = New System.Drawing.Point(400, 43)
        Me.lblRemainingSessions.Name = "lblRemainingSessions"
        Me.lblRemainingSessions.Size = New System.Drawing.Size(84, 19)
        Me.lblRemainingSessions.TabIndex = 3
        Me.lblRemainingSessions.Text = "Remaining"
        '
        'lblCompleted
        '
        Me.lblCompleted.AutoSize = True
        Me.lblCompleted.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblCompleted.Location = New System.Drawing.Point(571, 43)
        Me.lblCompleted.Name = "lblCompleted"
        Me.lblCompleted.Size = New System.Drawing.Size(85, 19)
        Me.lblCompleted.TabIndex = 2
        Me.lblCompleted.Text = "Completed"
        '
        'dgvTreatmentPlans
        '
        Me.dgvTreatmentPlans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTreatmentPlans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTreatmentPlans.Location = New System.Drawing.Point(12, 71)
        Me.dgvTreatmentPlans.Name = "dgvTreatmentPlans"
        Me.dgvTreatmentPlans.ReadOnly = True
        Me.dgvTreatmentPlans.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgvTreatmentPlans.RowHeadersVisible = False
        Me.dgvTreatmentPlans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTreatmentPlans.Size = New System.Drawing.Size(874, 450)
        Me.dgvTreatmentPlans.TabIndex = 0
        '
        'btnNewPlan
        '
        Me.btnNewPlan.BackColor = System.Drawing.Color.Blue
        Me.btnNewPlan.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnNewPlan.ForeColor = System.Drawing.Color.White
        Me.btnNewPlan.Location = New System.Drawing.Point(739, 19)
        Me.btnNewPlan.Name = "btnNewPlan"
        Me.btnNewPlan.Size = New System.Drawing.Size(147, 34)
        Me.btnNewPlan.TabIndex = 1
        Me.btnNewPlan.Text = "خطة علاج جديدة"
        Me.btnNewPlan.UseVisualStyleBackColor = False
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
        Me.tabPayments.ResumeLayout(False)
        Me.tabPayments.PerformLayout()
        Me.tabSessions.ResumeLayout(False)
        Me.tabSessions.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvSessions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMedical.ResumeLayout(False)
        Me.tabMedical.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tabTreatmentPlan.ResumeLayout(False)
        Me.tabTreatmentPlan.PerformLayout()
        CType(Me.dgvTreatmentPlans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents tabPhotos As TabPage
    Friend WithEvents tabNotes As TabPage
    Friend WithEvents tabPayments As TabPage
    Friend WithEvents btnAddPayment As Button
    Friend WithEvents lblRemaining As Label
    Friend WithEvents lblTotalPaid As Label
    Friend WithEvents tabSessions As TabPage
    Friend WithEvents lblSessionsCount As Label
    Friend WithEvents btnAddSession As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvSessions As DataGridView
    Friend WithEvents tabMedical As TabPage
    Friend WithEvents tabOverview As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents lblTotalSessions As Label
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
    Friend WithEvents tabTreatmentPlan As TabPage
    Friend WithEvents dgvTreatmentPlans As DataGridView
    Friend WithEvents btnNewPlan As Button
    Friend WithEvents lblProgress As Label
    Friend WithEvents lblRemainingSessions As Label
    Friend WithEvents lblCompleted As Label
    Friend WithEvents prgTreatment As ProgressBar
    Friend WithEvents Label12 As Label
    Friend WithEvents cbPhotoPlan As ComboBox
End Class
