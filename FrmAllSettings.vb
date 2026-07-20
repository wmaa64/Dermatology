Public Class FrmAllSettings
    Private Sub FrmAllSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Me.RightToLeft = RightToLeft.Yes

        lblTitle.Text = "الاعدادات العامة"

        LoadControl(New UC_Settings)

    End Sub


    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click

        lblTitle.Text = "الاعدادات العامة"

        LoadControl(New UC_Settings)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub LoadControl(ctrl As UserControl)

        pnlMain.Controls.Clear()

        ctrl.Dock = DockStyle.Fill

        pnlMain.Controls.Add(ctrl)

    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        lblTitle.Text = "المستخدمين"

        LoadControl(New UC_Users)

    End Sub

    Private Sub btnDevices_Click(sender As Object, e As EventArgs) Handles btnDevices.Click
        lblTitle.Text = "الأجهزة"

        LoadControl(New UC_Devices)
    End Sub

    Private Sub btnAreas_Click(sender As Object, e As EventArgs) Handles btnAreas.Click
        lblTitle.Text = "المناطق العلاجية"

        LoadControl(New UC_TreatmentAreas)
    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub

    Private Sub btnServices_Click(sender As Object, e As EventArgs) Handles btnServices.Click
        lblTitle.Text = "الخدمات"

        LoadControl(New UC_Services)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblTitle.Text = "انواع الليزر"

        LoadControl(New UC_LaserTypes)
    End Sub
End Class