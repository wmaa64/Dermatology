Public Class FormMain
    Private Sub btnPatients_Click(sender As Object, e As EventArgs) Handles btnPatients.Click
        lblTitle.Text = "إدارة المرضى"
        LoadControl(New UC_Patients)
    End Sub

    Private Sub btnSessions_Click(sender As Object, e As EventArgs) Handles btnSessions.Click
        lblTitle.Text = "جلسات الليزر"
    End Sub

    Private Sub btnAccounts_Click(sender As Object, e As EventArgs) Handles btnAccounts.Click
        lblTitle.Text = "الحسابات"
    End Sub

    Private Sub Appointments_Click(sender As Object, e As EventArgs) Handles btnAppointments.Click
        lblTitle.Text = "الحجوزات"
        LoadControl(New UC_Appointments)
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        lblTitle.Text = "التقارير"
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        lblTitle.Text = "الاعدادات"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.RightToLeft = RightToLeft.Yes

        LoadControl(New UC_Dashboard)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub LoadControl(ctrl As UserControl)

        pnlMain.Controls.Clear()

        ctrl.Dock = DockStyle.Fill

        pnlMain.Controls.Add(ctrl)

    End Sub

    Private Sub btnDashboard_Click(sender, e) Handles btnDashboard.Click
        lblTitle.Text = "الرئيسية"

        LoadControl(New UC_Dashboard)
    End Sub
End Class
