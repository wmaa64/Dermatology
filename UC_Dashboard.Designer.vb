<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Dashboard
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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.pnlCharts = New System.Windows.Forms.FlowLayoutPanel()
        Me.chartSessions = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chartRevenue = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dgvRecentSessions = New System.Windows.Forms.DataGridView()
        Me.flpCards = New System.Windows.Forms.FlowLayoutPanel()
        Me.cardAppointments = New System.Windows.Forms.Panel()
        Me.lblAppointmentsCount = New System.Windows.Forms.Label()
        Me.lblAppointmentsTitle = New System.Windows.Forms.Label()
        Me.cardRevenue = New System.Windows.Forms.Panel()
        Me.lblRevenueToday = New System.Windows.Forms.Label()
        Me.lblRevenueTitle = New System.Windows.Forms.Label()
        Me.cardSessions = New System.Windows.Forms.Panel()
        Me.lblSessionsToday = New System.Windows.Forms.Label()
        Me.lblSessionsTitle = New System.Windows.Forms.Label()
        Me.cardPatients = New System.Windows.Forms.Panel()
        Me.lblCustomersCount = New System.Windows.Forms.Label()
        Me.lblCustomersTitle = New System.Windows.Forms.Label()
        Me.pnlCharts.SuspendLayout()
        CType(Me.chartSessions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartRevenue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRecentSessions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flpCards.SuspendLayout()
        Me.cardAppointments.SuspendLayout()
        Me.cardRevenue.SuspendLayout()
        Me.cardSessions.SuspendLayout()
        Me.cardPatients.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCharts
        '
        Me.pnlCharts.AutoScroll = True
        Me.pnlCharts.Controls.Add(Me.chartSessions)
        Me.pnlCharts.Controls.Add(Me.chartRevenue)
        Me.pnlCharts.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.pnlCharts.Location = New System.Drawing.Point(10, 160)
        Me.pnlCharts.Name = "pnlCharts"
        Me.pnlCharts.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCharts.Size = New System.Drawing.Size(960, 200)
        Me.pnlCharts.TabIndex = 2
        Me.pnlCharts.WrapContents = False
        '
        'chartSessions
        '
        ChartArea3.Name = "ChartArea1"
        Me.chartSessions.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.chartSessions.Legends.Add(Legend3)
        Me.chartSessions.Location = New System.Drawing.Point(3, 3)
        Me.chartSessions.Name = "chartSessions"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.chartSessions.Series.Add(Series3)
        Me.chartSessions.Size = New System.Drawing.Size(466, 184)
        Me.chartSessions.TabIndex = 0
        Me.chartSessions.Text = "Chart1"
        '
        'chartRevenue
        '
        ChartArea4.Name = "ChartArea1"
        Me.chartRevenue.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.chartRevenue.Legends.Add(Legend4)
        Me.chartRevenue.Location = New System.Drawing.Point(475, 3)
        Me.chartRevenue.Name = "chartRevenue"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Me.chartRevenue.Series.Add(Series4)
        Me.chartRevenue.Size = New System.Drawing.Size(465, 184)
        Me.chartRevenue.TabIndex = 1
        Me.chartRevenue.Text = "Chart1"
        '
        'dgvRecentSessions
        '
        Me.dgvRecentSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRecentSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecentSessions.Location = New System.Drawing.Point(10, 372)
        Me.dgvRecentSessions.Name = "dgvRecentSessions"
        Me.dgvRecentSessions.ReadOnly = True
        Me.dgvRecentSessions.Size = New System.Drawing.Size(960, 165)
        Me.dgvRecentSessions.TabIndex = 3
        '
        'flpCards
        '
        Me.flpCards.AutoScroll = True
        Me.flpCards.Controls.Add(Me.cardAppointments)
        Me.flpCards.Controls.Add(Me.cardRevenue)
        Me.flpCards.Controls.Add(Me.cardSessions)
        Me.flpCards.Controls.Add(Me.cardPatients)
        Me.flpCards.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.flpCards.Location = New System.Drawing.Point(10, 10)
        Me.flpCards.Name = "flpCards"
        Me.flpCards.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.flpCards.Size = New System.Drawing.Size(960, 130)
        Me.flpCards.TabIndex = 4
        Me.flpCards.WrapContents = False
        '
        'cardAppointments
        '
        Me.cardAppointments.BackColor = System.Drawing.Color.White
        Me.cardAppointments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cardAppointments.Controls.Add(Me.lblAppointmentsCount)
        Me.cardAppointments.Controls.Add(Me.lblAppointmentsTitle)
        Me.cardAppointments.Location = New System.Drawing.Point(3, 3)
        Me.cardAppointments.Name = "cardAppointments"
        Me.cardAppointments.Size = New System.Drawing.Size(230, 120)
        Me.cardAppointments.TabIndex = 1
        '
        'lblAppointmentsCount
        '
        Me.lblAppointmentsCount.AutoSize = True
        Me.lblAppointmentsCount.Font = New System.Drawing.Font("Tahoma", 24.0!)
        Me.lblAppointmentsCount.ForeColor = System.Drawing.Color.Red
        Me.lblAppointmentsCount.Location = New System.Drawing.Point(20, 50)
        Me.lblAppointmentsCount.Name = "lblAppointmentsCount"
        Me.lblAppointmentsCount.Size = New System.Drawing.Size(35, 39)
        Me.lblAppointmentsCount.TabIndex = 3
        Me.lblAppointmentsCount.Text = "0"
        '
        'lblAppointmentsTitle
        '
        Me.lblAppointmentsTitle.AutoSize = True
        Me.lblAppointmentsTitle.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblAppointmentsTitle.ForeColor = System.Drawing.Color.Red
        Me.lblAppointmentsTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblAppointmentsTitle.Name = "lblAppointmentsTitle"
        Me.lblAppointmentsTitle.Size = New System.Drawing.Size(149, 29)
        Me.lblAppointmentsTitle.TabIndex = 2
        Me.lblAppointmentsTitle.Text = "أصناف رواكد"
        '
        'cardRevenue
        '
        Me.cardRevenue.BackColor = System.Drawing.Color.White
        Me.cardRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cardRevenue.Controls.Add(Me.lblRevenueToday)
        Me.cardRevenue.Controls.Add(Me.lblRevenueTitle)
        Me.cardRevenue.Location = New System.Drawing.Point(239, 3)
        Me.cardRevenue.Name = "cardRevenue"
        Me.cardRevenue.Size = New System.Drawing.Size(230, 120)
        Me.cardRevenue.TabIndex = 1
        '
        'lblRevenueToday
        '
        Me.lblRevenueToday.AutoSize = True
        Me.lblRevenueToday.Font = New System.Drawing.Font("Tahoma", 24.0!)
        Me.lblRevenueToday.ForeColor = System.Drawing.Color.Orange
        Me.lblRevenueToday.Location = New System.Drawing.Point(20, 50)
        Me.lblRevenueToday.Name = "lblRevenueToday"
        Me.lblRevenueToday.Size = New System.Drawing.Size(64, 39)
        Me.lblRevenueToday.TabIndex = 3
        Me.lblRevenueToday.Text = "0 ج"
        '
        'lblRevenueTitle
        '
        Me.lblRevenueTitle.AutoSize = True
        Me.lblRevenueTitle.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblRevenueTitle.ForeColor = System.Drawing.Color.Orange
        Me.lblRevenueTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblRevenueTitle.Name = "lblRevenueTitle"
        Me.lblRevenueTitle.Size = New System.Drawing.Size(153, 29)
        Me.lblRevenueTitle.TabIndex = 2
        Me.lblRevenueTitle.Text = "تحصيل اليوم"
        '
        'cardSessions
        '
        Me.cardSessions.BackColor = System.Drawing.Color.White
        Me.cardSessions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cardSessions.Controls.Add(Me.lblSessionsToday)
        Me.cardSessions.Controls.Add(Me.lblSessionsTitle)
        Me.cardSessions.Location = New System.Drawing.Point(475, 3)
        Me.cardSessions.Name = "cardSessions"
        Me.cardSessions.Size = New System.Drawing.Size(230, 120)
        Me.cardSessions.TabIndex = 1
        '
        'lblSessionsToday
        '
        Me.lblSessionsToday.AutoSize = True
        Me.lblSessionsToday.Font = New System.Drawing.Font("Tahoma", 24.0!)
        Me.lblSessionsToday.ForeColor = System.Drawing.Color.Lime
        Me.lblSessionsToday.Location = New System.Drawing.Point(20, 50)
        Me.lblSessionsToday.Name = "lblSessionsToday"
        Me.lblSessionsToday.Size = New System.Drawing.Size(35, 39)
        Me.lblSessionsToday.TabIndex = 3
        Me.lblSessionsToday.Text = "0"
        '
        'lblSessionsTitle
        '
        Me.lblSessionsTitle.AutoSize = True
        Me.lblSessionsTitle.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblSessionsTitle.ForeColor = System.Drawing.Color.Lime
        Me.lblSessionsTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblSessionsTitle.Name = "lblSessionsTitle"
        Me.lblSessionsTitle.Size = New System.Drawing.Size(193, 29)
        Me.lblSessionsTitle.TabIndex = 2
        Me.lblSessionsTitle.Text = "فواتير البيع اليوم"
        '
        'cardPatients
        '
        Me.cardPatients.BackColor = System.Drawing.Color.White
        Me.cardPatients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cardPatients.Controls.Add(Me.lblCustomersCount)
        Me.cardPatients.Controls.Add(Me.lblCustomersTitle)
        Me.cardPatients.Location = New System.Drawing.Point(711, 3)
        Me.cardPatients.Name = "cardPatients"
        Me.cardPatients.Size = New System.Drawing.Size(230, 120)
        Me.cardPatients.TabIndex = 0
        '
        'lblCustomersCount
        '
        Me.lblCustomersCount.AutoSize = True
        Me.lblCustomersCount.Font = New System.Drawing.Font("Tahoma", 24.0!)
        Me.lblCustomersCount.ForeColor = System.Drawing.Color.Blue
        Me.lblCustomersCount.Location = New System.Drawing.Point(20, 50)
        Me.lblCustomersCount.Name = "lblCustomersCount"
        Me.lblCustomersCount.Size = New System.Drawing.Size(35, 39)
        Me.lblCustomersCount.TabIndex = 1
        Me.lblCustomersCount.Text = "0"
        '
        'lblCustomersTitle
        '
        Me.lblCustomersTitle.AutoSize = True
        Me.lblCustomersTitle.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustomersTitle.ForeColor = System.Drawing.Color.Blue
        Me.lblCustomersTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblCustomersTitle.Name = "lblCustomersTitle"
        Me.lblCustomersTitle.Size = New System.Drawing.Size(136, 29)
        Me.lblCustomersTitle.TabIndex = 0
        Me.lblCustomersTitle.Text = "عدد العملاء"
        '
        'UC_Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.flpCards)
        Me.Controls.Add(Me.dgvRecentSessions)
        Me.Controls.Add(Me.pnlCharts)
        Me.Name = "UC_Dashboard"
        Me.Size = New System.Drawing.Size(953, 555)
        Me.pnlCharts.ResumeLayout(False)
        CType(Me.chartSessions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartRevenue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRecentSessions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flpCards.ResumeLayout(False)
        Me.cardAppointments.ResumeLayout(False)
        Me.cardAppointments.PerformLayout()
        Me.cardRevenue.ResumeLayout(False)
        Me.cardRevenue.PerformLayout()
        Me.cardSessions.ResumeLayout(False)
        Me.cardSessions.PerformLayout()
        Me.cardPatients.ResumeLayout(False)
        Me.cardPatients.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlCharts As FlowLayoutPanel
    Friend WithEvents dgvRecentSessions As DataGridView
    Friend WithEvents flpCards As FlowLayoutPanel
    Friend WithEvents cardAppointments As Panel
    Friend WithEvents lblAppointmentsCount As Label
    Friend WithEvents lblAppointmentsTitle As Label
    Friend WithEvents cardRevenue As Panel
    Friend WithEvents lblRevenueToday As Label
    Friend WithEvents lblRevenueTitle As Label
    Friend WithEvents cardSessions As Panel
    Friend WithEvents lblSessionsToday As Label
    Friend WithEvents lblSessionsTitle As Label
    Friend WithEvents cardPatients As Panel
    Friend WithEvents lblCustomersCount As Label
    Friend WithEvents lblCustomersTitle As Label
    Friend WithEvents chartSessions As DataVisualization.Charting.Chart
    Friend WithEvents chartRevenue As DataVisualization.Charting.Chart
End Class
