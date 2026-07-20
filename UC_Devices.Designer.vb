<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Devices
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
        Me.dgvDevices = New System.Windows.Forms.DataGridView()
        Me.btnAddDevice = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        CType(Me.dgvDevices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(457, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "البحث عن جهاز بجزء من الاسم"
        '
        'dgvDevices
        '
        Me.dgvDevices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDevices.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvDevices.Location = New System.Drawing.Point(0, 120)
        Me.dgvDevices.Name = "dgvDevices"
        Me.dgvDevices.ReadOnly = True
        Me.dgvDevices.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgvDevices.RowHeadersVisible = False
        Me.dgvDevices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDevices.Size = New System.Drawing.Size(801, 433)
        Me.dgvDevices.TabIndex = 6
        '
        'btnAddDevice
        '
        Me.btnAddDevice.BackColor = System.Drawing.Color.Blue
        Me.btnAddDevice.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddDevice.ForeColor = System.Drawing.Color.White
        Me.btnAddDevice.Location = New System.Drawing.Point(622, 0)
        Me.btnAddDevice.Name = "btnAddDevice"
        Me.btnAddDevice.Size = New System.Drawing.Size(152, 36)
        Me.btnAddDevice.TabIndex = 5
        Me.btnAddDevice.Text = "إضافة جهاز جديد"
        Me.btnAddDevice.UseVisualStyleBackColor = False
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
        'UC_Devices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDevices)
        Me.Controls.Add(Me.btnAddDevice)
        Me.Controls.Add(Me.txtSearch)
        Me.Name = "UC_Devices"
        Me.Size = New System.Drawing.Size(801, 553)
        CType(Me.dgvDevices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDevices As DataGridView
    Friend WithEvents btnAddDevice As Button
    Friend WithEvents txtSearch As TextBox
End Class
