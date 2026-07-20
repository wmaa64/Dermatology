<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_SessionsDue
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtServicesDiscount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtServicesNet = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvServices = New System.Windows.Forms.DataGridView()
        Me.colServiceID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colServiceName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDiscount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtServicesTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvSessions = New System.Windows.Forms.DataGridView()
        Me.dtpSessionDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvServices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSessions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(773, 499)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 17)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "إجمالى قبل الخصم"
        '
        'txtServicesDiscount
        '
        Me.txtServicesDiscount.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtServicesDiscount.ForeColor = System.Drawing.Color.Green
        Me.txtServicesDiscount.Location = New System.Drawing.Point(366, 493)
        Me.txtServicesDiscount.Name = "txtServicesDiscount"
        Me.txtServicesDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtServicesDiscount.Size = New System.Drawing.Size(140, 25)
        Me.txtServicesDiscount.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(512, 499)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 17)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "إجمالى الخصم"
        '
        'txtServicesNet
        '
        Me.txtServicesNet.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtServicesNet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtServicesNet.Location = New System.Drawing.Point(25, 493)
        Me.txtServicesNet.Name = "txtServicesNet"
        Me.txtServicesNet.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtServicesNet.Size = New System.Drawing.Size(140, 25)
        Me.txtServicesNet.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(171, 499)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 17)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "إجمالى الخدمات المستحقة"
        '
        'dgvServices
        '
        Me.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colServiceID, Me.colServiceName, Me.colQty, Me.colUnitPrice, Me.colDiscount, Me.colTotal})
        Me.dgvServices.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvServices.Location = New System.Drawing.Point(6, 22)
        Me.dgvServices.MultiSelect = False
        Me.dgvServices.Name = "dgvServices"
        Me.dgvServices.ReadOnly = True
        Me.dgvServices.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgvServices.RowHeadersVisible = False
        Me.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvServices.Size = New System.Drawing.Size(895, 253)
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
        Me.colDiscount.ReadOnly = True
        '
        'colTotal
        '
        Me.colTotal.HeaderText = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.ReadOnly = True
        '
        'txtServicesTotal
        '
        Me.txtServicesTotal.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtServicesTotal.ForeColor = System.Drawing.Color.Blue
        Me.txtServicesTotal.Location = New System.Drawing.Point(627, 493)
        Me.txtServicesTotal.Name = "txtServicesTotal"
        Me.txtServicesTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtServicesTotal.Size = New System.Drawing.Size(140, 25)
        Me.txtServicesTotal.TabIndex = 39
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvServices)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 206)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(913, 281)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "خدمات الجلسة الحالية"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvSessions)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(915, 153)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "جلسات الليزر"
        '
        'dgvSessions
        '
        Me.dgvSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSessions.Location = New System.Drawing.Point(6, 24)
        Me.dgvSessions.Name = "dgvSessions"
        Me.dgvSessions.ReadOnly = True
        Me.dgvSessions.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgvSessions.RowHeadersVisible = False
        Me.dgvSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSessions.Size = New System.Drawing.Size(897, 123)
        Me.dgvSessions.TabIndex = 3
        '
        'dtpSessionDate
        '
        Me.dtpSessionDate.Location = New System.Drawing.Point(578, 12)
        Me.dtpSessionDate.Name = "dtpSessionDate"
        Me.dtpSessionDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpSessionDate.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(785, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 17)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "تاريخ الجلسات"
        '
        'UC_SessionsDue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpSessionDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtServicesDiscount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtServicesNet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtServicesTotal)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UC_SessionsDue"
        Me.Size = New System.Drawing.Size(921, 553)
        CType(Me.dgvServices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvSessions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents txtServicesDiscount As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtServicesNet As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvServices As DataGridView
    Friend WithEvents txtServicesTotal As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvSessions As DataGridView
    Friend WithEvents colServiceID As DataGridViewTextBoxColumn
    Friend WithEvents colServiceName As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colUnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents colDiscount As DataGridViewTextBoxColumn
    Friend WithEvents colTotal As DataGridViewTextBoxColumn
    Friend WithEvents dtpSessionDate As DateTimePicker
    Friend WithEvents Label4 As Label
End Class
