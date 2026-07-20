<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_About
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.pnlUnderHeader = New System.Windows.Forms.Panel()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblProgramName = New System.Windows.Forms.Label()
        Me.lblDescription_ar = New System.Windows.Forms.Label()
        Me.grpDeveloper = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grpVersion = New System.Windows.Forms.GroupBox()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.pnlUnderHeader.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDeveloper.SuspendLayout()
        Me.grpVersion.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlUnderHeader
        '
        Me.pnlUnderHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlUnderHeader.BackColor = System.Drawing.SystemColors.Highlight
        Me.pnlUnderHeader.Controls.Add(Me.picLogo)
        Me.pnlUnderHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlUnderHeader.Name = "pnlUnderHeader"
        Me.pnlUnderHeader.Size = New System.Drawing.Size(950, 221)
        Me.pnlUnderHeader.TabIndex = 2
        '
        'picLogo
        '
        Me.picLogo.Image = Global.ClinicPro.My.Resources.Resources.EgSoftProLogo3
        Me.picLogo.Location = New System.Drawing.Point(388, 0)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(270, 218)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 3
        Me.picLogo.TabStop = False
        '
        'lblProgramName
        '
        Me.lblProgramName.AutoSize = True
        Me.lblProgramName.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgramName.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblProgramName.Location = New System.Drawing.Point(465, 224)
        Me.lblProgramName.Name = "lblProgramName"
        Me.lblProgramName.Size = New System.Drawing.Size(117, 32)
        Me.lblProgramName.TabIndex = 3
        Me.lblProgramName.Text = "ClinicPro"
        '
        'lblDescription_ar
        '
        Me.lblDescription_ar.AutoSize = True
        Me.lblDescription_ar.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription_ar.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblDescription_ar.Location = New System.Drawing.Point(234, 262)
        Me.lblDescription_ar.Name = "lblDescription_ar"
        Me.lblDescription_ar.Size = New System.Drawing.Size(565, 32)
        Me.lblDescription_ar.TabIndex = 4
        Me.lblDescription_ar.Text = "نظام متكامل لإدارة عيادات الجلدية والليزر ومراكز التجميل"
        '
        'grpDeveloper
        '
        Me.grpDeveloper.Controls.Add(Me.Label5)
        Me.grpDeveloper.Controls.Add(Me.Label4)
        Me.grpDeveloper.Controls.Add(Me.Label3)
        Me.grpDeveloper.Controls.Add(Me.Label2)
        Me.grpDeveloper.Controls.Add(Me.Label1)
        Me.grpDeveloper.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDeveloper.ForeColor = System.Drawing.Color.RoyalBlue
        Me.grpDeveloper.Location = New System.Drawing.Point(33, 302)
        Me.grpDeveloper.Name = "grpDeveloper"
        Me.grpDeveloper.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grpDeveloper.Size = New System.Drawing.Size(876, 102)
        Me.grpDeveloper.TabIndex = 5
        Me.grpDeveloper.TabStop = False
        Me.grpDeveloper.Text = "معلومات المطور"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(701, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "الإسم: م/ وائل محمد على"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(464, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "الوظيفة:Software Developer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(741, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "موبايل: 01001452251"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(534, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "واتساب: 01001452251"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(198, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(250, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "بريد الكترونى: wmaa64@yahoo.com"
        '
        'grpVersion
        '
        Me.grpVersion.Controls.Add(Me.lblDescription)
        Me.grpVersion.Controls.Add(Me.lblCopyright)
        Me.grpVersion.Controls.Add(Me.lblCompany)
        Me.grpVersion.Controls.Add(Me.lblVersion)
        Me.grpVersion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpVersion.ForeColor = System.Drawing.Color.RoyalBlue
        Me.grpVersion.Location = New System.Drawing.Point(38, 413)
        Me.grpVersion.Name = "grpVersion"
        Me.grpVersion.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grpVersion.Size = New System.Drawing.Size(876, 105)
        Me.grpVersion.TabIndex = 6
        Me.grpVersion.TabStop = False
        Me.grpVersion.Text = "معلومات نسخة البرنامج"
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblCompany.Location = New System.Drawing.Point(262, 20)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(75, 20)
        Me.lblCompany.TabIndex = 6
        Me.lblCompany.Text = "Company"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblVersion.Location = New System.Drawing.Point(23, 20)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(61, 20)
        Me.lblVersion.TabIndex = 4
        Me.lblVersion.Text = "Version"
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblCopyright.Location = New System.Drawing.Point(23, 46)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(78, 20)
        Me.lblCopyright.TabIndex = 7
        Me.lblCopyright.Text = "Copyright"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblDescription.Location = New System.Drawing.Point(23, 73)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(89, 20)
        Me.lblDescription.TabIndex = 8
        Me.lblDescription.Text = "Description"
        '
        'UC_About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.grpVersion)
        Me.Controls.Add(Me.grpDeveloper)
        Me.Controls.Add(Me.lblDescription_ar)
        Me.Controls.Add(Me.lblProgramName)
        Me.Controls.Add(Me.pnlUnderHeader)
        Me.Name = "UC_About"
        Me.Size = New System.Drawing.Size(953, 555)
        Me.pnlUnderHeader.ResumeLayout(False)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDeveloper.ResumeLayout(False)
        Me.grpDeveloper.PerformLayout()
        Me.grpVersion.ResumeLayout(False)
        Me.grpVersion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlUnderHeader As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblProgramName As Label
    Friend WithEvents lblDescription_ar As Label
    Friend WithEvents grpDeveloper As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents grpVersion As GroupBox
    Friend WithEvents lblCompany As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblCopyright As Label
End Class
