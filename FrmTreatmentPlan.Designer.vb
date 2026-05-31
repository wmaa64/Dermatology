<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTreatmentPlan
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
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.numInterval = New System.Windows.Forms.NumericUpDown()
        Me.numSessions = New System.Windows.Forms.NumericUpDown()
        Me.txtPlanName = New System.Windows.Forms.TextBox()
        Me.dtStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbDevice = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cbTreatmentArea = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPlanNotes = New System.Windows.Forms.RichTextBox()
        CType(Me.numInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSessions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label14.Location = New System.Drawing.Point(706, 237)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 19)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "تاريخ البداية"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(706, 145)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(209, 19)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "الفاصل بين الجلسات (أسابيع)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(706, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 19)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "اسم الخطة"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(706, 109)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 19)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "عدد الجلسات"
        '
        'numInterval
        '
        Me.numInterval.Location = New System.Drawing.Point(579, 146)
        Me.numInterval.Name = "numInterval"
        Me.numInterval.Size = New System.Drawing.Size(120, 20)
        Me.numInterval.TabIndex = 45
        '
        'numSessions
        '
        Me.numSessions.Location = New System.Drawing.Point(579, 105)
        Me.numSessions.Name = "numSessions"
        Me.numSessions.Size = New System.Drawing.Size(120, 20)
        Me.numSessions.TabIndex = 44
        '
        'txtPlanName
        '
        Me.txtPlanName.Location = New System.Drawing.Point(499, 27)
        Me.txtPlanName.Name = "txtPlanName"
        Me.txtPlanName.Size = New System.Drawing.Size(200, 20)
        Me.txtPlanName.TabIndex = 43
        '
        'dtStartDate
        '
        Me.dtStartDate.Location = New System.Drawing.Point(500, 235)
        Me.dtStartDate.Name = "dtStartDate"
        Me.dtStartDate.Size = New System.Drawing.Size(200, 20)
        Me.dtStartDate.TabIndex = 42
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(706, 279)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 19)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "الحالة"
        '
        'cbStatus
        '
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Active", "Completed", "Cancelled", "Paused"})
        Me.cbStatus.Location = New System.Drawing.Point(578, 279)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(121, 21)
        Me.cbStatus.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(706, 191)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 19)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "الجهاز المستخدم"
        '
        'cbDevice
        '
        Me.cbDevice.FormattingEnabled = True
        Me.cbDevice.Items.AddRange(New Object() {"Candela GentleMax", "Soprano Titanium", "Clarity II", "Alexandrite", "ND:YAG", "Diode"})
        Me.cbDevice.Location = New System.Drawing.Point(579, 191)
        Me.cbDevice.Name = "cbDevice"
        Me.cbDevice.Size = New System.Drawing.Size(121, 21)
        Me.cbDevice.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(706, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 19)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "منطقة العلاج"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Blue
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(746, 505)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(121, 32)
        Me.btnSave.TabIndex = 36
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'cbTreatmentArea
        '
        Me.cbTreatmentArea.FormattingEnabled = True
        Me.cbTreatmentArea.Items.AddRange(New Object() {"Full Face", "Upper Lip", "Chin", "Neck", "Underarm", "Arms", "Legs", "Bikini", "Back", "Chest"})
        Me.cbTreatmentArea.Location = New System.Drawing.Point(579, 65)
        Me.cbTreatmentArea.Name = "cbTreatmentArea"
        Me.cbTreatmentArea.Size = New System.Drawing.Size(121, 21)
        Me.cbTreatmentArea.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(706, 323)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 19)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "ملاحظات الخطة"
        '
        'txtPlanNotes
        '
        Me.txtPlanNotes.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtPlanNotes.Location = New System.Drawing.Point(305, 324)
        Me.txtPlanNotes.Name = "txtPlanNotes"
        Me.txtPlanNotes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPlanNotes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtPlanNotes.Size = New System.Drawing.Size(394, 125)
        Me.txtPlanNotes.TabIndex = 33
        Me.txtPlanNotes.Text = ""
        '
        'FrmTreatmentPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 557)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.numInterval)
        Me.Controls.Add(Me.numSessions)
        Me.Controls.Add(Me.txtPlanName)
        Me.Controls.Add(Me.dtStartDate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbDevice)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cbTreatmentArea)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPlanNotes)
        Me.Name = "FrmTreatmentPlan"
        Me.Text = "FrmTreatmentPlan"
        CType(Me.numInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSessions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents numInterval As NumericUpDown
    Friend WithEvents numSessions As NumericUpDown
    Friend WithEvents txtPlanName As TextBox
    Friend WithEvents dtStartDate As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbDevice As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents cbTreatmentArea As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPlanNotes As RichTextBox
End Class
