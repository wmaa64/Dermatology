<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_SalesInvoices
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvSalesInvoices = New System.Windows.Forms.DataGridView()
        Me.btnAddInvoice = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        CType(Me.dgvSalesInvoices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(428, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "البحث عن فاتورة عميل بجزء من الاسم / او بتليفونه"
        '
        'dgvSalesInvoices
        '
        Me.dgvSalesInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSalesInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalesInvoices.Location = New System.Drawing.Point(18, 102)
        Me.dgvSalesInvoices.Name = "dgvSalesInvoices"
        Me.dgvSalesInvoices.ReadOnly = True
        Me.dgvSalesInvoices.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgvSalesInvoices.RowHeadersVisible = False
        Me.dgvSalesInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSalesInvoices.Size = New System.Drawing.Size(766, 406)
        Me.dgvSalesInvoices.TabIndex = 6
        '
        'btnAddInvoice
        '
        Me.btnAddInvoice.BackColor = System.Drawing.Color.Blue
        Me.btnAddInvoice.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddInvoice.ForeColor = System.Drawing.Color.White
        Me.btnAddInvoice.Location = New System.Drawing.Point(604, 5)
        Me.btnAddInvoice.Name = "btnAddInvoice"
        Me.btnAddInvoice.Size = New System.Drawing.Size(180, 36)
        Me.btnAddInvoice.TabIndex = 5
        Me.btnAddInvoice.Text = "إضافة فاتورة مبيعات"
        Me.btnAddInvoice.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(305, 71)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSearch.Size = New System.Drawing.Size(479, 25)
        Me.txtSearch.TabIndex = 4
        '
        'UC_SalesInvoices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvSalesInvoices)
        Me.Controls.Add(Me.btnAddInvoice)
        Me.Controls.Add(Me.txtSearch)
        Me.Name = "UC_SalesInvoices"
        Me.Size = New System.Drawing.Size(801, 553)
        CType(Me.dgvSalesInvoices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvSalesInvoices As DataGridView
    Friend WithEvents btnAddInvoice As Button
    Friend WithEvents txtSearch As TextBox
End Class
