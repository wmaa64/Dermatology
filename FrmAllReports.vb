Public Class FrmAllReports
    Private Sub btnRevenues_Click(sender As Object, e As EventArgs) Handles btnRevenues.Click

        ' Administrator فقط
        If CurrentUser.RoleID <> 1 Then

            MessageBox.Show("ليس لديك صلاحية الدخول إلى هذا التقرير.",
                        "صلاحيات",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)

            Exit Sub

        End If

        Dim frm As New FrmRevenueByDoctor

        frm.ShowDialog()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub
End Class