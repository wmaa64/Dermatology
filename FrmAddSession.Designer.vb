<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddSession
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
        Me.dtSessionDate = New System.Windows.Forms.DateTimePicker()
        Me.cbArea = New System.Windows.Forms.ComboBox()
        Me.cbDevice = New System.Windows.Forms.ComboBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtNotes = New System.Windows.Forms.RichTextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cbTreatmentPlan = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dtSessionDate
        '
        Me.dtSessionDate.Location = New System.Drawing.Point(506, 48)
        Me.dtSessionDate.Name = "dtSessionDate"
        Me.dtSessionDate.Size = New System.Drawing.Size(200, 20)
        Me.dtSessionDate.TabIndex = 0
        '
        'cbArea
        '
        Me.cbArea.FormattingEnabled = True
        Me.cbArea.Items.AddRange(New Object() {"Full Face", "Upper Lip", "Chin", "Neck", "Underarm", "Arms", "Legs", "Bikini", "Back", "Chest"})
        Me.cbArea.Location = New System.Drawing.Point(585, 90)
        Me.cbArea.Name = "cbArea"
        Me.cbArea.Size = New System.Drawing.Size(121, 21)
        Me.cbArea.TabIndex = 1
        '
        'cbDevice
        '
        Me.cbDevice.FormattingEnabled = True
        Me.cbDevice.Items.AddRange(New Object() {"Candela GentleMax", "Soprano Titanium", "Clarity II", "Alexandrite", "ND:YAG", "Diode"})
        Me.cbDevice.Location = New System.Drawing.Point(585, 130)
        Me.cbDevice.Name = "cbDevice"
        Me.cbDevice.Size = New System.Drawing.Size(121, 21)
        Me.cbDevice.TabIndex = 2
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(606, 175)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 3
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(342, 217)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(364, 96)
        Me.txtNotes.TabIndex = 4
        Me.txtNotes.Text = ""
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Blue
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(682, 440)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(121, 32)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'cbTreatmentPlan
        '
        Me.cbTreatmentPlan.FormattingEnabled = True
        Me.cbTreatmentPlan.Location = New System.Drawing.Point(585, 12)
        Me.cbTreatmentPlan.Name = "cbTreatmentPlan"
        Me.cbTreatmentPlan.Size = New System.Drawing.Size(121, 21)
        Me.cbTreatmentPlan.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label14.Location = New System.Drawing.Point(718, 176)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 19)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "السعر"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(718, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 19)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "اختار الخطة"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(718, 92)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 19)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "المنطقة"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(718, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 19)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "الجهاز المستخدم"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(718, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 19)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "تاريخ الجلسة"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(718, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 19)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "ملاحظات الجلسة"
        '
        'FrmAddSession
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 530)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbTreatmentPlan)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.cbDevice)
        Me.Controls.Add(Me.cbArea)
        Me.Controls.Add(Me.dtSessionDate)
        Me.Name = "FrmAddSession"
        Me.Text = "FrmAddSession"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtSessionDate As DateTimePicker
    Friend WithEvents cbArea As ComboBox
    Friend WithEvents cbDevice As ComboBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtNotes As RichTextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents cbTreatmentPlan As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class
