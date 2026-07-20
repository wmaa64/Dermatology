<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_TreatmentAreas
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
        Me.dgvTreatmentAreas = New System.Windows.Forms.DataGridView()
        Me.btnAddArea = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        CType(Me.dgvTreatmentAreas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(457, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 18)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "البحث عن منطقة بجزء من الاسم /"
        '
        'dgvTreatmentAreas
        '
        Me.dgvTreatmentAreas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTreatmentAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTreatmentAreas.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvTreatmentAreas.Location = New System.Drawing.Point(0, 120)
        Me.dgvTreatmentAreas.Name = "dgvTreatmentAreas"
        Me.dgvTreatmentAreas.ReadOnly = True
        Me.dgvTreatmentAreas.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgvTreatmentAreas.RowHeadersVisible = False
        Me.dgvTreatmentAreas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTreatmentAreas.Size = New System.Drawing.Size(801, 433)
        Me.dgvTreatmentAreas.TabIndex = 10
        '
        'btnAddArea
        '
        Me.btnAddArea.BackColor = System.Drawing.Color.Blue
        Me.btnAddArea.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddArea.ForeColor = System.Drawing.Color.White
        Me.btnAddArea.Location = New System.Drawing.Point(544, 0)
        Me.btnAddArea.Name = "btnAddArea"
        Me.btnAddArea.Size = New System.Drawing.Size(230, 36)
        Me.btnAddArea.TabIndex = 9
        Me.btnAddArea.Text = "إضافة منطقة علاجية جديده"
        Me.btnAddArea.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(295, 89)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSearch.Size = New System.Drawing.Size(479, 25)
        Me.txtSearch.TabIndex = 8
        '
        'UC_TreatmentAreas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvTreatmentAreas)
        Me.Controls.Add(Me.btnAddArea)
        Me.Controls.Add(Me.txtSearch)
        Me.Name = "UC_TreatmentAreas"
        Me.Size = New System.Drawing.Size(801, 553)
        CType(Me.dgvTreatmentAreas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvTreatmentAreas As DataGridView
    Friend WithEvents btnAddArea As Button
    Friend WithEvents txtSearch As TextBox
End Class
