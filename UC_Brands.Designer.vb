<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Brands
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
        Me.dgvBrands = New System.Windows.Forms.DataGridView()
        Me.btnAddBrand = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        CType(Me.dgvBrands, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(457, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "البحث عن براند بجزء من الاسم"
        '
        'dgvBrands
        '
        Me.dgvBrands.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBrands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBrands.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvBrands.Location = New System.Drawing.Point(0, 120)
        Me.dgvBrands.Name = "dgvBrands"
        Me.dgvBrands.ReadOnly = True
        Me.dgvBrands.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgvBrands.RowHeadersVisible = False
        Me.dgvBrands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBrands.Size = New System.Drawing.Size(801, 433)
        Me.dgvBrands.TabIndex = 6
        '
        'btnAddBrand
        '
        Me.btnAddBrand.BackColor = System.Drawing.Color.Blue
        Me.btnAddBrand.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBrand.ForeColor = System.Drawing.Color.White
        Me.btnAddBrand.Location = New System.Drawing.Point(622, 0)
        Me.btnAddBrand.Name = "btnAddBrand"
        Me.btnAddBrand.Size = New System.Drawing.Size(152, 36)
        Me.btnAddBrand.TabIndex = 5
        Me.btnAddBrand.Text = "إضافة براند جديد"
        Me.btnAddBrand.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(295, 89)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSearch.Size = New System.Drawing.Size(479, 25)
        Me.txtSearch.TabIndex = 4
        '
        'UC_Brands
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvBrands)
        Me.Controls.Add(Me.btnAddBrand)
        Me.Controls.Add(Me.txtSearch)
        Me.Name = "UC_Brands"
        Me.Size = New System.Drawing.Size(801, 553)
        CType(Me.dgvBrands, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvBrands As DataGridView
    Friend WithEvents btnAddBrand As Button
    Friend WithEvents txtSearch As TextBox
End Class
