Public Class FormMain
    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        lblTitle.Text = "إدارة العملاء"
        LoadControl(New UC_Customers)
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        lblTitle.Text = "إدارة الأصناف"
        LoadControl(New UC_Products)
    End Sub

    Private Sub btnBrands_Click(sender As Object, e As EventArgs) Handles btnBrands.Click
        lblTitle.Text = "الموردين"
        LoadControl(New UC_Brands)
    End Sub

    Private Sub btnUnits_Click(sender As Object, e As EventArgs) Handles btnUnits.Click
        lblTitle.Text = "الوحدات"
        LoadControl(New UC_Units)
    End Sub

    Private Sub btnProductUnits_Click(sender As Object, e As EventArgs) Handles btnProductUnits.Click
        lblTitle.Text = "الوحدات لصنف"
        LoadControl(New UC_ProductUnits)
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
