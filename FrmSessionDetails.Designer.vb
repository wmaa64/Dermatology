<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSessionDetails
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cbLaserType = New System.Windows.Forms.ComboBox()
        Me.txtDoctorNotes = New System.Windows.Forms.RichTextBox()
        Me.txtSkinReaction = New System.Windows.Forms.RichTextBox()
        Me.txtAreaDetails = New System.Windows.Forms.RichTextBox()
        Me.dtNextSession = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSpotSize = New System.Windows.Forms.TextBox()
        Me.txtPulseWidth = New System.Windows.Forms.TextBox()
        Me.txtEnergy = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(767, 376)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 19)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Doctor Notes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(779, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 19)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Laser Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(335, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 19)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Skin Reaction"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(771, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 19)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Area Details"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Blue
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(744, 539)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(121, 32)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'cbLaserType
        '
        Me.cbLaserType.FormattingEnabled = True
        Me.cbLaserType.Items.AddRange(New Object() {"Candela GentleMax", "Soprano Titanium", "Clarity II", "ND:YAG", "Alexandrite", "Diode"})
        Me.cbLaserType.Location = New System.Drawing.Point(744, 39)
        Me.cbLaserType.Name = "cbLaserType"
        Me.cbLaserType.Size = New System.Drawing.Size(121, 21)
        Me.cbLaserType.TabIndex = 22
        '
        'txtDoctorNotes
        '
        Me.txtDoctorNotes.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtDoctorNotes.Location = New System.Drawing.Point(471, 398)
        Me.txtDoctorNotes.Name = "txtDoctorNotes"
        Me.txtDoctorNotes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDoctorNotes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtDoctorNotes.Size = New System.Drawing.Size(394, 98)
        Me.txtDoctorNotes.TabIndex = 21
        Me.txtDoctorNotes.Text = ""
        '
        'txtSkinReaction
        '
        Me.txtSkinReaction.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtSkinReaction.Location = New System.Drawing.Point(40, 227)
        Me.txtSkinReaction.Name = "txtSkinReaction"
        Me.txtSkinReaction.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSkinReaction.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtSkinReaction.Size = New System.Drawing.Size(394, 124)
        Me.txtSkinReaction.TabIndex = 20
        Me.txtSkinReaction.Text = ""
        '
        'txtAreaDetails
        '
        Me.txtAreaDetails.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtAreaDetails.Location = New System.Drawing.Point(471, 227)
        Me.txtAreaDetails.Name = "txtAreaDetails"
        Me.txtAreaDetails.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAreaDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtAreaDetails.Size = New System.Drawing.Size(394, 124)
        Me.txtAreaDetails.TabIndex = 19
        Me.txtAreaDetails.Text = ""
        '
        'dtNextSession
        '
        Me.dtNextSession.Location = New System.Drawing.Point(234, 398)
        Me.dtNextSession.Name = "dtNextSession"
        Me.dtNextSession.Size = New System.Drawing.Size(200, 20)
        Me.dtNextSession.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(814, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Spot Size"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(802, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Pulse Width"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(827, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Energy"
        '
        'txtSpotSize
        '
        Me.txtSpotSize.Location = New System.Drawing.Point(744, 173)
        Me.txtSpotSize.Name = "txtSpotSize"
        Me.txtSpotSize.Size = New System.Drawing.Size(121, 20)
        Me.txtSpotSize.TabIndex = 31
        '
        'txtPulseWidth
        '
        Me.txtPulseWidth.Location = New System.Drawing.Point(744, 129)
        Me.txtPulseWidth.Name = "txtPulseWidth"
        Me.txtPulseWidth.Size = New System.Drawing.Size(121, 20)
        Me.txtPulseWidth.TabIndex = 30
        '
        'txtEnergy
        '
        Me.txtEnergy.Location = New System.Drawing.Point(744, 91)
        Me.txtEnergy.Name = "txtEnergy"
        Me.txtEnergy.Size = New System.Drawing.Size(121, 20)
        Me.txtEnergy.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(279, 376)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 19)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Date of Next Session"
        '
        'FrmSessionDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 583)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSpotSize)
        Me.Controls.Add(Me.txtPulseWidth)
        Me.Controls.Add(Me.txtEnergy)
        Me.Controls.Add(Me.dtNextSession)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cbLaserType)
        Me.Controls.Add(Me.txtDoctorNotes)
        Me.Controls.Add(Me.txtSkinReaction)
        Me.Controls.Add(Me.txtAreaDetails)
        Me.Name = "FrmSessionDetails"
        Me.Text = "FrmSessionDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents cbLaserType As ComboBox
    Friend WithEvents txtDoctorNotes As RichTextBox
    Friend WithEvents txtSkinReaction As RichTextBox
    Friend WithEvents txtAreaDetails As RichTextBox
    Friend WithEvents dtNextSession As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSpotSize As TextBox
    Friend WithEvents txtPulseWidth As TextBox
    Friend WithEvents txtEnergy As TextBox
    Friend WithEvents Label8 As Label
End Class
