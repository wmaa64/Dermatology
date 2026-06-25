<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_Customers
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
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnAddCustomer = New System.Windows.Forms.Button()
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(295, 89)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSearch.Size = New System.Drawing.Size(479, 25)
        Me.txtSearch.TabIndex = 0
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.BackColor = System.Drawing.Color.Blue
        Me.btnAddCustomer.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCustomer.ForeColor = System.Drawing.Color.White
        Me.btnAddCustomer.Location = New System.Drawing.Point(622, 0)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(152, 36)
        Me.btnAddCustomer.TabIndex = 1
        Me.btnAddCustomer.Text = "إضافة عميل جديد"
        Me.btnAddCustomer.UseVisualStyleBackColor = False
        '
        'dgvCustomers
        '
        Me.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvCustomers.Location = New System.Drawing.Point(0, 120)
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.ReadOnly = True
        Me.dgvCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgvCustomers.RowHeadersVisible = False
        Me.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomers.Size = New System.Drawing.Size(801, 433)
        Me.dgvCustomers.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(457, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "البحث عن عميل بجزء من الاسم / او بتليفونه"
        '
        'UC_Customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvCustomers)
        Me.Controls.Add(Me.btnAddCustomer)
        Me.Controls.Add(Me.txtSearch)
        Me.Name = "UC_Customers"
        Me.Size = New System.Drawing.Size(801, 553)
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnAddCustomer As Button
    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents Label1 As Label
End Class
