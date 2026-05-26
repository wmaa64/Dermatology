<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_Appointments
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
        Me.components = New System.ComponentModel.Container()
        Me.label1 = New System.Windows.Forms.Label()
        Me.dgvAppointments = New System.Windows.Forms.DataGridView()
        Me.cmsAppointmentStatus = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.miConfirm = New System.Windows.Forms.ToolStripMenuItem()
        Me.miDone = New System.Windows.Forms.ToolStripMenuItem()
        Me.miCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAddAppointment = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.flpFilters = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnConfirmed = New System.Windows.Forms.Button()
        Me.btnPending = New System.Windows.Forms.Button()
        Me.btnTomorrow = New System.Windows.Forms.Button()
        Me.btnToday = New System.Windows.Forms.Button()
        CType(Me.dgvAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsAppointmentStatus.SuspendLayout()
        Me.flpFilters.SuspendLayout()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(484, 47)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(351, 18)
        Me.label1.TabIndex = 7
        Me.label1.Text = "البحث عن حجز مريض بجزء من الاسم / او بتليفونه"
        '
        'dgvAppointments
        '
        Me.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAppointments.ContextMenuStrip = Me.cmsAppointmentStatus
        Me.dgvAppointments.Location = New System.Drawing.Point(0, 172)
        Me.dgvAppointments.Name = "dgvAppointments"
        Me.dgvAppointments.ReadOnly = True
        Me.dgvAppointments.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgvAppointments.RowHeadersVisible = False
        Me.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAppointments.Size = New System.Drawing.Size(855, 411)
        Me.dgvAppointments.TabIndex = 6
        '
        'cmsAppointmentStatus
        '
        Me.cmsAppointmentStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmsAppointmentStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miConfirm, Me.miDone, Me.miCancel})
        Me.cmsAppointmentStatus.Name = "cmsAppointmentStatus"
        Me.cmsAppointmentStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmsAppointmentStatus.Size = New System.Drawing.Size(181, 98)
        '
        'miConfirm
        '
        Me.miConfirm.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.miConfirm.ForeColor = System.Drawing.Color.White
        Me.miConfirm.Name = "miConfirm"
        Me.miConfirm.Size = New System.Drawing.Size(180, 24)
        Me.miConfirm.Text = "Confirm"
        '
        'miDone
        '
        Me.miDone.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.miDone.ForeColor = System.Drawing.Color.White
        Me.miDone.Name = "miDone"
        Me.miDone.Size = New System.Drawing.Size(180, 24)
        Me.miDone.Text = "Done"
        '
        'miCancel
        '
        Me.miCancel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.miCancel.ForeColor = System.Drawing.Color.White
        Me.miCancel.Name = "miCancel"
        Me.miCancel.Size = New System.Drawing.Size(180, 24)
        Me.miCancel.Text = "Cancel"
        '
        'btnAddAppointment
        '
        Me.btnAddAppointment.BackColor = System.Drawing.Color.Blue
        Me.btnAddAppointment.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAppointment.ForeColor = System.Drawing.Color.White
        Me.btnAddAppointment.Location = New System.Drawing.Point(683, 3)
        Me.btnAddAppointment.Name = "btnAddAppointment"
        Me.btnAddAppointment.Size = New System.Drawing.Size(152, 36)
        Me.btnAddAppointment.TabIndex = 5
        Me.btnAddAppointment.Text = "حجز جديد"
        Me.btnAddAppointment.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(308, 68)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSearch.Size = New System.Drawing.Size(527, 25)
        Me.txtSearch.TabIndex = 4
        '
        'flpFilters
        '
        Me.flpFilters.Controls.Add(Me.btnAll)
        Me.flpFilters.Controls.Add(Me.btnDone)
        Me.flpFilters.Controls.Add(Me.btnConfirmed)
        Me.flpFilters.Controls.Add(Me.btnPending)
        Me.flpFilters.Controls.Add(Me.btnTomorrow)
        Me.flpFilters.Controls.Add(Me.btnToday)
        Me.flpFilters.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.flpFilters.Location = New System.Drawing.Point(308, 105)
        Me.flpFilters.Name = "flpFilters"
        Me.flpFilters.Size = New System.Drawing.Size(527, 45)
        Me.flpFilters.TabIndex = 8
        '
        'btnAll
        '
        Me.btnAll.BackColor = System.Drawing.Color.Blue
        Me.btnAll.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnAll.ForeColor = System.Drawing.Color.White
        Me.btnAll.Location = New System.Drawing.Point(3, 3)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(75, 39)
        Me.btnAll.TabIndex = 0
        Me.btnAll.Text = "الكل"
        Me.btnAll.UseVisualStyleBackColor = False
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.Blue
        Me.btnDone.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnDone.ForeColor = System.Drawing.Color.White
        Me.btnDone.Location = New System.Drawing.Point(84, 3)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 39)
        Me.btnDone.TabIndex = 1
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'btnConfirmed
        '
        Me.btnConfirmed.BackColor = System.Drawing.Color.Blue
        Me.btnConfirmed.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnConfirmed.ForeColor = System.Drawing.Color.White
        Me.btnConfirmed.Location = New System.Drawing.Point(165, 3)
        Me.btnConfirmed.Name = "btnConfirmed"
        Me.btnConfirmed.Size = New System.Drawing.Size(98, 39)
        Me.btnConfirmed.TabIndex = 2
        Me.btnConfirmed.Text = "Confirmed"
        Me.btnConfirmed.UseVisualStyleBackColor = False
        '
        'btnPending
        '
        Me.btnPending.BackColor = System.Drawing.Color.Blue
        Me.btnPending.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnPending.ForeColor = System.Drawing.Color.White
        Me.btnPending.Location = New System.Drawing.Point(269, 3)
        Me.btnPending.Name = "btnPending"
        Me.btnPending.Size = New System.Drawing.Size(86, 39)
        Me.btnPending.TabIndex = 3
        Me.btnPending.Text = "Pending"
        Me.btnPending.UseVisualStyleBackColor = False
        '
        'btnTomorrow
        '
        Me.btnTomorrow.BackColor = System.Drawing.Color.Blue
        Me.btnTomorrow.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnTomorrow.ForeColor = System.Drawing.Color.White
        Me.btnTomorrow.Location = New System.Drawing.Point(361, 3)
        Me.btnTomorrow.Name = "btnTomorrow"
        Me.btnTomorrow.Size = New System.Drawing.Size(75, 39)
        Me.btnTomorrow.TabIndex = 4
        Me.btnTomorrow.Text = "غدًا"
        Me.btnTomorrow.UseVisualStyleBackColor = False
        '
        'btnToday
        '
        Me.btnToday.BackColor = System.Drawing.Color.Blue
        Me.btnToday.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnToday.ForeColor = System.Drawing.Color.White
        Me.btnToday.Location = New System.Drawing.Point(442, 3)
        Me.btnToday.Name = "btnToday"
        Me.btnToday.Size = New System.Drawing.Size(75, 39)
        Me.btnToday.TabIndex = 5
        Me.btnToday.Text = "اليوم"
        Me.btnToday.UseVisualStyleBackColor = False
        '
        'UC_Appointments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.flpFilters)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.dgvAppointments)
        Me.Controls.Add(Me.btnAddAppointment)
        Me.Controls.Add(Me.txtSearch)
        Me.Name = "UC_Appointments"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Size = New System.Drawing.Size(870, 583)
        CType(Me.dgvAppointments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsAppointmentStatus.ResumeLayout(False)
        Me.flpFilters.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents dgvAppointments As DataGridView
    Friend WithEvents btnAddAppointment As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents flpFilters As FlowLayoutPanel
    Friend WithEvents btnAll As Button
    Friend WithEvents btnDone As Button
    Friend WithEvents btnConfirmed As Button
    Friend WithEvents btnPending As Button
    Friend WithEvents btnTomorrow As Button
    Friend WithEvents btnToday As Button
    Friend WithEvents cmsAppointmentStatus As ContextMenuStrip
    Friend WithEvents miConfirm As ToolStripMenuItem
    Friend WithEvents miDone As ToolStripMenuItem
    Friend WithEvents miCancel As ToolStripMenuItem
End Class
