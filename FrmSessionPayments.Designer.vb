<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSessionPayments
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalPaid = New System.Windows.Forms.TextBox()
        Me.txtServicesNet = New System.Windows.Forms.TextBox()
        Me.txtSessionID = New System.Windows.Forms.TextBox()
        Me.txtPatient = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRemaining = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvPayments = New System.Windows.Forms.DataGridView()
        Me.colPaymentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPaymentDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAmountPaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPaymentMethod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNotes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAmountPaid = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.RichTextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(294, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "إجمالى المدفوعات"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(455, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "المستحق"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(574, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "الجلسة"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(807, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "اسم المريض"
        '
        'txtTotalPaid
        '
        Me.txtTotalPaid.Location = New System.Drawing.Point(283, 23)
        Me.txtTotalPaid.Name = "txtTotalPaid"
        Me.txtTotalPaid.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotalPaid.Size = New System.Drawing.Size(114, 20)
        Me.txtTotalPaid.TabIndex = 13
        '
        'txtServicesNet
        '
        Me.txtServicesNet.Location = New System.Drawing.Point(413, 23)
        Me.txtServicesNet.Name = "txtServicesNet"
        Me.txtServicesNet.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtServicesNet.Size = New System.Drawing.Size(116, 20)
        Me.txtServicesNet.TabIndex = 12
        '
        'txtSessionID
        '
        Me.txtSessionID.Location = New System.Drawing.Point(542, 23)
        Me.txtSessionID.Name = "txtSessionID"
        Me.txtSessionID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSessionID.Size = New System.Drawing.Size(100, 20)
        Me.txtSessionID.TabIndex = 11
        '
        'txtPatient
        '
        Me.txtPatient.Location = New System.Drawing.Point(652, 23)
        Me.txtPatient.Name = "txtPatient"
        Me.txtPatient.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPatient.Size = New System.Drawing.Size(221, 20)
        Me.txtPatient.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(189, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "الباقي"
        '
        'txtRemaining
        '
        Me.txtRemaining.Location = New System.Drawing.Point(148, 23)
        Me.txtRemaining.Name = "txtRemaining"
        Me.txtRemaining.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtRemaining.Size = New System.Drawing.Size(114, 20)
        Me.txtRemaining.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvPayments)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(881, 223)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "المدفوعات"
        '
        'dgvPayments
        '
        Me.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPayments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPaymentID, Me.colPaymentDate, Me.colAmountPaid, Me.colPaymentMethod, Me.colUserName, Me.colNotes, Me.colEdit, Me.colDelete})
        Me.dgvPayments.Location = New System.Drawing.Point(8, 24)
        Me.dgvPayments.Name = "dgvPayments"
        Me.dgvPayments.ReadOnly = True
        Me.dgvPayments.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgvPayments.RowHeadersVisible = False
        Me.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPayments.Size = New System.Drawing.Size(867, 193)
        Me.dgvPayments.TabIndex = 3
        '
        'colPaymentID
        '
        Me.colPaymentID.HeaderText = "ID"
        Me.colPaymentID.Name = "colPaymentID"
        Me.colPaymentID.ReadOnly = True
        Me.colPaymentID.Visible = False
        '
        'colPaymentDate
        '
        Me.colPaymentDate.HeaderText = "تاريخ الدفع"
        Me.colPaymentDate.Name = "colPaymentDate"
        Me.colPaymentDate.ReadOnly = True
        '
        'colAmountPaid
        '
        Me.colAmountPaid.HeaderText = "المبلغ"
        Me.colAmountPaid.Name = "colAmountPaid"
        Me.colAmountPaid.ReadOnly = True
        '
        'colPaymentMethod
        '
        Me.colPaymentMethod.HeaderText = "طريقة الدفع"
        Me.colPaymentMethod.Name = "colPaymentMethod"
        Me.colPaymentMethod.ReadOnly = True
        '
        'colUserName
        '
        Me.colUserName.HeaderText = "المستخدم"
        Me.colUserName.Name = "colUserName"
        Me.colUserName.ReadOnly = True
        '
        'colNotes
        '
        Me.colNotes.HeaderText = "الملاحظات"
        Me.colNotes.Name = "colNotes"
        Me.colNotes.ReadOnly = True
        '
        'colEdit
        '
        Me.colEdit.HeaderText = "تعديل"
        Me.colEdit.Name = "colEdit"
        Me.colEdit.ReadOnly = True
        '
        'colDelete
        '
        Me.colDelete.HeaderText = "حذف"
        Me.colDelete.Name = "colDelete"
        Me.colDelete.ReadOnly = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(775, 287)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 19)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "المبلغ المدفوع"
        '
        'txtAmountPaid
        '
        Me.txtAmountPaid.Location = New System.Drawing.Point(669, 289)
        Me.txtAmountPaid.Name = "txtAmountPaid"
        Me.txtAmountPaid.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAmountPaid.Size = New System.Drawing.Size(100, 20)
        Me.txtAmountPaid.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(781, 327)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 19)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "طريقة الدفع"
        '
        'cbPaymentMethod
        '
        Me.cbPaymentMethod.FormattingEnabled = True
        Me.cbPaymentMethod.Items.AddRange(New Object() {"Cash", "Visa", "Bank Transfer", "Instapay", "Vodafone Cash"})
        Me.cbPaymentMethod.Location = New System.Drawing.Point(569, 325)
        Me.cbPaymentMethod.Name = "cbPaymentMethod"
        Me.cbPaymentMethod.Size = New System.Drawing.Size(200, 21)
        Me.cbPaymentMethod.TabIndex = 55
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(820, 352)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 19)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "ملاحظات"
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(524, 374)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(364, 61)
        Me.txtNotes.TabIndex = 57
        Me.txtNotes.Text = ""
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Blue
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(767, 453)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(121, 32)
        Me.btnSave.TabIndex = 59
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.Blue
        Me.btnNew.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Location = New System.Drawing.Point(600, 453)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(121, 32)
        Me.btnNew.TabIndex = 60
        Me.btnNew.Text = "جديد"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Blue
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(408, 453)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(121, 32)
        Me.btnClose.TabIndex = 61
        Me.btnClose.Text = "إغلاق"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'FrmSessionPayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 514)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbPaymentMethod)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAmountPaid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRemaining)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalPaid)
        Me.Controls.Add(Me.txtServicesNet)
        Me.Controls.Add(Me.txtSessionID)
        Me.Controls.Add(Me.txtPatient)
        Me.Name = "FrmSessionPayments"
        Me.Text = "FrmSessionPayments"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalPaid As TextBox
    Friend WithEvents txtServicesNet As TextBox
    Friend WithEvents txtSessionID As TextBox
    Friend WithEvents txtPatient As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRemaining As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvPayments As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAmountPaid As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbPaymentMethod As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNotes As RichTextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents colPaymentID As DataGridViewTextBoxColumn
    Friend WithEvents colPaymentDate As DataGridViewTextBoxColumn
    Friend WithEvents colAmountPaid As DataGridViewTextBoxColumn
    Friend WithEvents colPaymentMethod As DataGridViewTextBoxColumn
    Friend WithEvents colUserName As DataGridViewTextBoxColumn
    Friend WithEvents colNotes As DataGridViewTextBoxColumn
    Friend WithEvents colEdit As DataGridViewButtonColumn
    Friend WithEvents colDelete As DataGridViewButtonColumn
End Class
