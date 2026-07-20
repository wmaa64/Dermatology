<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Sessions
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
        Me.dgvSessions = New System.Windows.Forms.DataGridView()
        Me.btnAddSession = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPatientSearch = New System.Windows.Forms.Button()
        Me.cbPatients = New System.Windows.Forms.ComboBox()
        Me.btnAddServices = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvServices = New System.Windows.Forms.DataGridView()
        Me.colServiceID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colServiceName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDiscount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnSaveServices = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtServicesNet = New System.Windows.Forms.TextBox()
        Me.txtServicesDiscount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtServicesTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvSessions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvServices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSessions
        '
        Me.dgvSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSessions.Location = New System.Drawing.Point(6, 22)
        Me.dgvSessions.Name = "dgvSessions"
        Me.dgvSessions.ReadOnly = True
        Me.dgvSessions.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgvSessions.RowHeadersVisible = False
        Me.dgvSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSessions.Size = New System.Drawing.Size(768, 108)
        Me.dgvSessions.TabIndex = 3
        '
        'btnAddSession
        '
        Me.btnAddSession.BackColor = System.Drawing.Color.Blue
        Me.btnAddSession.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddSession.ForeColor = System.Drawing.Color.White
        Me.btnAddSession.Location = New System.Drawing.Point(791, 51)
        Me.btnAddSession.Name = "btnAddSession"
        Me.btnAddSession.Size = New System.Drawing.Size(112, 34)
        Me.btnAddSession.TabIndex = 15
        Me.btnAddSession.Text = "إضافة جلسة"
        Me.btnAddSession.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvSessions)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(780, 136)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "جلسات الليزر"
        '
        'btnPatientSearch
        '
        Me.btnPatientSearch.BackColor = System.Drawing.Color.Blue
        Me.btnPatientSearch.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnPatientSearch.ForeColor = System.Drawing.Color.White
        Me.btnPatientSearch.Location = New System.Drawing.Point(791, 14)
        Me.btnPatientSearch.Name = "btnPatientSearch"
        Me.btnPatientSearch.Size = New System.Drawing.Size(127, 32)
        Me.btnPatientSearch.TabIndex = 16
        Me.btnPatientSearch.Text = "بحث عن مريض"
        Me.btnPatientSearch.UseVisualStyleBackColor = False
        '
        'cbPatients
        '
        Me.cbPatients.FormattingEnabled = True
        Me.cbPatients.Location = New System.Drawing.Point(583, 21)
        Me.cbPatients.Name = "cbPatients"
        Me.cbPatients.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbPatients.Size = New System.Drawing.Size(200, 21)
        Me.cbPatients.TabIndex = 17
        '
        'btnAddServices
        '
        Me.btnAddServices.BackColor = System.Drawing.Color.Blue
        Me.btnAddServices.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddServices.ForeColor = System.Drawing.Color.White
        Me.btnAddServices.Location = New System.Drawing.Point(791, 193)
        Me.btnAddServices.Name = "btnAddServices"
        Me.btnAddServices.Size = New System.Drawing.Size(112, 34)
        Me.btnAddServices.TabIndex = 18
        Me.btnAddServices.Text = "إضافة خدمات"
        Me.btnAddServices.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvServices)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 193)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(780, 308)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "خدمات الجلسة الحالية"
        '
        'dgvServices
        '
        Me.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colServiceID, Me.colServiceName, Me.colQty, Me.colUnitPrice, Me.colDiscount, Me.colTotal, Me.colDelete})
        Me.dgvServices.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvServices.Location = New System.Drawing.Point(6, 20)
        Me.dgvServices.MultiSelect = False
        Me.dgvServices.Name = "dgvServices"
        Me.dgvServices.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgvServices.RowHeadersVisible = False
        Me.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvServices.Size = New System.Drawing.Size(768, 278)
        Me.dgvServices.TabIndex = 4
        '
        'colServiceID
        '
        Me.colServiceID.HeaderText = "ServiceID"
        Me.colServiceID.Name = "colServiceID"
        Me.colServiceID.ReadOnly = True
        Me.colServiceID.Visible = False
        '
        'colServiceName
        '
        Me.colServiceName.HeaderText = "ServiceName"
        Me.colServiceName.Name = "colServiceName"
        Me.colServiceName.ReadOnly = True
        '
        'colQty
        '
        Me.colQty.HeaderText = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.ReadOnly = True
        '
        'colUnitPrice
        '
        Me.colUnitPrice.HeaderText = "UnitPrice"
        Me.colUnitPrice.Name = "colUnitPrice"
        Me.colUnitPrice.ReadOnly = True
        '
        'colDiscount
        '
        Me.colDiscount.HeaderText = "خصم"
        Me.colDiscount.Name = "colDiscount"
        '
        'colTotal
        '
        Me.colTotal.HeaderText = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.ReadOnly = True
        '
        'colDelete
        '
        Me.colDelete.HeaderText = "Delete"
        Me.colDelete.Name = "colDelete"
        Me.colDelete.ReadOnly = True
        '
        'btnSaveServices
        '
        Me.btnSaveServices.BackColor = System.Drawing.Color.Blue
        Me.btnSaveServices.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveServices.ForeColor = System.Drawing.Color.White
        Me.btnSaveServices.Location = New System.Drawing.Point(791, 354)
        Me.btnSaveServices.Name = "btnSaveServices"
        Me.btnSaveServices.Size = New System.Drawing.Size(127, 34)
        Me.btnSaveServices.TabIndex = 20
        Me.btnSaveServices.Text = "Save Services"
        Me.btnSaveServices.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(171, 515)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "إجمالى الخدمات المستحقة"
        '
        'txtServicesNet
        '
        Me.txtServicesNet.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtServicesNet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtServicesNet.Location = New System.Drawing.Point(25, 509)
        Me.txtServicesNet.Name = "txtServicesNet"
        Me.txtServicesNet.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtServicesNet.Size = New System.Drawing.Size(140, 25)
        Me.txtServicesNet.TabIndex = 22
        '
        'txtServicesDiscount
        '
        Me.txtServicesDiscount.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtServicesDiscount.ForeColor = System.Drawing.Color.Green
        Me.txtServicesDiscount.Location = New System.Drawing.Point(366, 509)
        Me.txtServicesDiscount.Name = "txtServicesDiscount"
        Me.txtServicesDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtServicesDiscount.Size = New System.Drawing.Size(140, 25)
        Me.txtServicesDiscount.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(512, 515)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 17)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "إجمالى الخصم"
        '
        'txtServicesTotal
        '
        Me.txtServicesTotal.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtServicesTotal.ForeColor = System.Drawing.Color.Blue
        Me.txtServicesTotal.Location = New System.Drawing.Point(627, 509)
        Me.txtServicesTotal.Name = "txtServicesTotal"
        Me.txtServicesTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtServicesTotal.Size = New System.Drawing.Size(140, 25)
        Me.txtServicesTotal.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(773, 515)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 17)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "إجمالى قبل الخصم"
        '
        'UC_Sessions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtServicesTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtServicesDiscount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtServicesNet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSaveServices)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnAddServices)
        Me.Controls.Add(Me.btnPatientSearch)
        Me.Controls.Add(Me.cbPatients)
        Me.Controls.Add(Me.btnAddSession)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UC_Sessions"
        Me.Size = New System.Drawing.Size(921, 553)
        CType(Me.dgvSessions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvServices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvSessions As DataGridView
    Friend WithEvents btnAddSession As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnPatientSearch As Button
    Friend WithEvents cbPatients As ComboBox
    Friend WithEvents btnAddServices As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvServices As DataGridView
    Friend WithEvents btnSaveServices As Button
    Friend WithEvents colServiceID As DataGridViewTextBoxColumn
    Friend WithEvents colServiceName As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colUnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents colDiscount As DataGridViewTextBoxColumn
    Friend WithEvents colTotal As DataGridViewTextBoxColumn
    Friend WithEvents colDelete As DataGridViewButtonColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents txtServicesNet As TextBox
    Friend WithEvents txtServicesDiscount As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtServicesTotal As TextBox
    Friend WithEvents Label3 As Label
End Class
