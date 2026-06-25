<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddSalesInvoice
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.cmbCustomer = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtWorkDomain = New System.Windows.Forms.TextBox()
        Me.dtInvoiceDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvItems = New System.Windows.Forms.DataGridView()
        Me.colProductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSearch = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colProductUnitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUnitSearch = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstUnits = New System.Windows.Forms.ListBox()
        Me.txtGrandTotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtInvoiceDiscount = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtLinesDiscount = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtValueAddedTax = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtExtraInvoiceDiscount = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtInvoiceTotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1061, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "ملاحظات"
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(481, 205)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNotes.Size = New System.Drawing.Size(628, 20)
        Me.txtNotes.TabIndex = 4
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Location = New System.Drawing.Point(887, 70)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtInvoiceNo.Size = New System.Drawing.Size(221, 20)
        Me.txtInvoiceNo.TabIndex = 1
        '
        'cmbCustomer
        '
        Me.cmbCustomer.FormattingEnabled = True
        Me.cmbCustomer.Location = New System.Drawing.Point(887, 115)
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(221, 21)
        Me.cmbCustomer.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1044, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "مجال العميل"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1042, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "اختار العميل"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1045, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "رقم الفاتورة"
        '
        'txtWorkDomain
        '
        Me.txtWorkDomain.Location = New System.Drawing.Point(887, 161)
        Me.txtWorkDomain.Name = "txtWorkDomain"
        Me.txtWorkDomain.ReadOnly = True
        Me.txtWorkDomain.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtWorkDomain.Size = New System.Drawing.Size(221, 20)
        Me.txtWorkDomain.TabIndex = 3
        '
        'dtInvoiceDate
        '
        Me.dtInvoiceDate.Location = New System.Drawing.Point(887, 30)
        Me.dtInvoiceDate.Name = "dtInvoiceDate"
        Me.dtInvoiceDate.Size = New System.Drawing.Size(221, 20)
        Me.dtInvoiceDate.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1046, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "تاريخ الفاتورة"
        '
        'dgvItems
        '
        Me.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colProductID, Me.colProduct, Me.colSearch, Me.colProductUnitID, Me.colUnit, Me.colUnitSearch, Me.colQty, Me.colPrice, Me.colTotal, Me.colDelete})
        Me.dgvItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvItems.Location = New System.Drawing.Point(8, 231)
        Me.dgvItems.MultiSelect = False
        Me.dgvItems.Name = "dgvItems"
        Me.dgvItems.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgvItems.RowHeadersVisible = False
        Me.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvItems.Size = New System.Drawing.Size(1096, 342)
        Me.dgvItems.TabIndex = 5
        '
        'colProductID
        '
        Me.colProductID.HeaderText = "ProductID"
        Me.colProductID.Name = "colProductID"
        Me.colProductID.Visible = False
        '
        'colProduct
        '
        Me.colProduct.FillWeight = 125.9805!
        Me.colProduct.HeaderText = "المنتج"
        Me.colProduct.Name = "colProduct"
        Me.colProduct.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'colSearch
        '
        Me.colSearch.FillWeight = 19.78923!
        Me.colSearch.HeaderText = "..."
        Me.colSearch.Name = "colSearch"
        '
        'colProductUnitID
        '
        Me.colProductUnitID.HeaderText = "ProductUnit"
        Me.colProductUnitID.Name = "colProductUnitID"
        Me.colProductUnitID.Visible = False
        '
        'colUnit
        '
        Me.colUnit.FillWeight = 126.7852!
        Me.colUnit.HeaderText = "الوحدة"
        Me.colUnit.Name = "colUnit"
        Me.colUnit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'colUnitSearch
        '
        Me.colUnitSearch.FillWeight = 20.30457!
        Me.colUnitSearch.HeaderText = "..."
        Me.colUnitSearch.Name = "colUnitSearch"
        '
        'colQty
        '
        Me.colQty.FillWeight = 126.7852!
        Me.colQty.HeaderText = "الكمية"
        Me.colQty.Name = "colQty"
        '
        'colPrice
        '
        Me.colPrice.FillWeight = 126.7852!
        Me.colPrice.HeaderText = "السعر"
        Me.colPrice.Name = "colPrice"
        '
        'colTotal
        '
        Me.colTotal.FillWeight = 126.7852!
        Me.colTotal.HeaderText = "الاجمالى"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.ReadOnly = True
        '
        'colDelete
        '
        Me.colDelete.FillWeight = 126.7852!
        Me.colDelete.HeaderText = "إلغاء"
        Me.colDelete.Name = "colDelete"
        Me.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1022, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 48
        '
        'lstUnits
        '
        Me.lstUnits.FormattingEnabled = True
        Me.lstUnits.Location = New System.Drawing.Point(734, 268)
        Me.lstUnits.Name = "lstUnits"
        Me.lstUnits.Size = New System.Drawing.Size(160, 95)
        Me.lstUnits.TabIndex = 49
        Me.lstUnits.Visible = False
        '
        'txtGrandTotal
        '
        Me.txtGrandTotal.Location = New System.Drawing.Point(198, 577)
        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.ReadOnly = True
        Me.txtGrandTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtGrandTotal.Size = New System.Drawing.Size(159, 20)
        Me.txtGrandTotal.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(363, 580)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "إجمالى المبيعات"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Blue
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(1004, 629)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 33)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtInvoiceDiscount
        '
        Me.txtInvoiceDiscount.Location = New System.Drawing.Point(793, 577)
        Me.txtInvoiceDiscount.Name = "txtInvoiceDiscount"
        Me.txtInvoiceDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtInvoiceDiscount.Size = New System.Drawing.Size(159, 20)
        Me.txtInvoiceDiscount.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(958, 580)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "إجمالى الخصم"
        '
        'txtLinesDiscount
        '
        Me.txtLinesDiscount.Location = New System.Drawing.Point(510, 577)
        Me.txtLinesDiscount.Name = "txtLinesDiscount"
        Me.txtLinesDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtLinesDiscount.Size = New System.Drawing.Size(159, 20)
        Me.txtLinesDiscount.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(675, 580)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 13)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "إجمالى خصم الصنف"
        '
        'txtValueAddedTax
        '
        Me.txtValueAddedTax.Location = New System.Drawing.Point(793, 603)
        Me.txtValueAddedTax.Name = "txtValueAddedTax"
        Me.txtValueAddedTax.ReadOnly = True
        Me.txtValueAddedTax.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtValueAddedTax.Size = New System.Drawing.Size(159, 20)
        Me.txtValueAddedTax.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(958, 606)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 13)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "ضريبة القيمة المضافة"
        '
        'txtExtraInvoiceDiscount
        '
        Me.txtExtraInvoiceDiscount.Location = New System.Drawing.Point(510, 603)
        Me.txtExtraInvoiceDiscount.Name = "txtExtraInvoiceDiscount"
        Me.txtExtraInvoiceDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtExtraInvoiceDiscount.Size = New System.Drawing.Size(159, 20)
        Me.txtExtraInvoiceDiscount.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(675, 606)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 13)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "خصم الفاتورة الاضافى"
        '
        'txtInvoiceTotal
        '
        Me.txtInvoiceTotal.Location = New System.Drawing.Point(198, 637)
        Me.txtInvoiceTotal.Name = "txtInvoiceTotal"
        Me.txtInvoiceTotal.ReadOnly = True
        Me.txtInvoiceTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtInvoiceTotal.Size = New System.Drawing.Size(159, 20)
        Me.txtInvoiceTotal.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(363, 640)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "إجمالى الفاتورة "
        '
        'FrmAddSalesInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 669)
        Me.Controls.Add(Me.txtInvoiceTotal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtExtraInvoiceDiscount)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtValueAddedTax)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtLinesDiscount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtInvoiceDiscount)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtGrandTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lstUnits)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvItems)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtInvoiceDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Controls.Add(Me.cmbCustomer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtWorkDomain)
        Me.Name = "FrmAddSalesInvoice"
        Me.Text = "FrmAddSalesInvoice"
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents txtInvoiceNo As TextBox
    Friend WithEvents cmbCustomer As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtWorkDomain As TextBox
    Friend WithEvents dtInvoiceDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents lstUnits As ListBox
    Friend WithEvents colProductID As DataGridViewTextBoxColumn
    Friend WithEvents colProduct As DataGridViewTextBoxColumn
    Friend WithEvents colSearch As DataGridViewButtonColumn
    Friend WithEvents colProductUnitID As DataGridViewTextBoxColumn
    Friend WithEvents colUnit As DataGridViewTextBoxColumn
    Friend WithEvents colUnitSearch As DataGridViewButtonColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colPrice As DataGridViewTextBoxColumn
    Friend WithEvents colTotal As DataGridViewTextBoxColumn
    Friend WithEvents colDelete As DataGridViewButtonColumn
    Friend WithEvents txtGrandTotal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtInvoiceDiscount As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtLinesDiscount As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtValueAddedTax As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtExtraInvoiceDiscount As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtInvoiceTotal As TextBox
    Friend WithEvents Label12 As Label
End Class
