<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPatientSessions
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvSessions = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPatientName = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSessions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvSessions)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(915, 462)
        Me.GroupBox1.TabIndex = 28
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
        Me.dgvSessions.Size = New System.Drawing.Size(897, 432)
        Me.dgvSessions.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(766, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 17)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "اسم المريض"
        '
        'txtPatientName
        '
        Me.txtPatientName.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtPatientName.ForeColor = System.Drawing.Color.Blue
        Me.txtPatientName.Location = New System.Drawing.Point(620, 12)
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPatientName.Size = New System.Drawing.Size(140, 25)
        Me.txtPatientName.TabIndex = 41
        '
        'FrmPatientSessions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 530)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPatientName)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmPatientSessions"
        Me.Text = "FrmPatientSessions"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvSessions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvSessions As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPatientName As TextBox
End Class
