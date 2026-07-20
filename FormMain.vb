Public Class FormMain
    Private Sub btnPatients_Click(sender As Object, e As EventArgs) Handles btnPatients.Click
        lblTitle.Text = "إدارة المرضى"
        LoadControl(New UC_Patients)
    End Sub

    Private Sub btnSessions_Click(sender As Object, e As EventArgs) Handles btnSessions.Click
        'Admin Or Doctor فقط
        If CurrentUser.RoleID = 1 Or CurrentUser.RoleID = 2 Then

            lblTitle.Text = "الجلسات"

            LoadControl(New UC_Sessions)

        Else
            MessageBox.Show("ليس لديك صلاحية الدخول إلى الإعدادات.",
                        "صلاحيات",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)

            Exit Sub

        End If

    End Sub

    Private Sub btnAccounts_Click(sender As Object, e As EventArgs) Handles btnAccounts.Click
        'Admin Or Doctor فقط
        If CurrentUser.RoleID = 1 Or CurrentUser.RoleID = 3 Then

            lblTitle.Text = "الحسابات"

            LoadControl(New UC_SessionsDue)

        Else
            MessageBox.Show("ليس لديك صلاحية الدخول إلى الإعدادات.",
                        "صلاحيات",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)

            Exit Sub

        End If


    End Sub

    Private Sub Appointments_Click(sender As Object, e As EventArgs) Handles btnAppointments.Click
        lblTitle.Text = "الحجوزات"
        LoadControl(New UC_Appointments)
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click

        lblTitle.Text = "التقارير"

        Dim frm As New FrmAllReports

        frm.lbFullName.Text = CurrentUser.FullName

        frm.Show()

    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        ' Administrator فقط
        If CurrentUser.RoleID <> 1 Then

            MessageBox.Show("ليس لديك صلاحية الدخول إلى الإعدادات.",
                        "صلاحيات",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)

            Exit Sub

        End If

        lblTitle.Text = "الاعدادات"

        Dim frm As New FrmAllSettings

        frm.lbFullName.Text = CurrentUser.FullName

        frm.Show()

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


    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblTitle.Text = "حول (About)"

        LoadControl(New UC_About)
    End Sub
End Class
