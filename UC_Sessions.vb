Imports System.Data.SqlClient

Public Class UC_Sessions
    Public CurrentSessionId As Integer = 0

    Public CurrentPatientId As Integer = 0

    Private Sub btnPatientSearch_Click(sender As Object, e As EventArgs) Handles btnPatientSearch.Click

        Using frm As New FrmPatientSearch

            If frm.ShowDialog() = DialogResult.OK Then

                cbPatients.SelectedValue = frm.SelectedPatientID

                CurrentPatientId = frm.SelectedPatientID

                LoadSession()

                'dgvServices.Rows.Clear()

                LoadSessionServices()

            End If

        End Using

    End Sub

    Private Sub UC_Sessions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPatients()

        dgvServices.SelectionMode = DataGridViewSelectionMode.CellSelect

        dgvServices.EditMode = DataGridViewEditMode.EditOnEnter

        dgvServices.MultiSelect = False

        dgvServices.Columns("colQty").ReadOnly = False

        dgvServices.Columns("colDiscount").ReadOnly = False

    End Sub

    Private Sub LoadPatients()

        Dim cmd As New SqlCommand("SELECT PatientID, FullName  FROM Patients")

        Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

        cbPatients.DataSource = dt

        cbPatients.DisplayMember = "FullName"

        cbPatients.ValueMember = "PatientID"

    End Sub

    Private Sub btnAddSession_Click(sender As Object, e As EventArgs) Handles btnAddSession.Click
        Dim frm As New FrmAddNewSession()

        frm.PatientID = cbPatients.SelectedValue

        frm.ShowDialog()

        LoadSession()

    End Sub


    Private Sub LoadSession()

        Try

            Dim cmd As New SqlCommand("SELECT
                                            LS.SessionID,
                                            LS.SessionDate AS 'تاريخ الجلسة',
                                            TA.AreaName AS 'المنطقة',
                                            D.DeviceName AS 'الجهاز',
                                            LS.Notes AS 'ملاحظات',
                                            US.FullName As 'الطبيب'
                                            

                                        FROM LaserSessions LS

                                        LEFT JOIN Devices D
                                               ON LS.DeviceID = D.DeviceID

                                        LEFT JOIN TreatmentAreas TA
                                               ON LS.AreaID = TA.AreaID

                                        LEFT JOIN Users US
                                               ON LS.UserID = US.UserID

                                        WHERE LS.PatientID=@PatientID
                                        
                                        AND   LS.UserID=@UserID

                                        AND   CAST(LS.SessionDate AS DATE) = CAST(GETDATE() AS DATE)

                                        ORDER BY LS.SessionDate DESC")

            cmd.Parameters.AddWithValue("@PatientID", cbPatients.SelectedValue)

            cmd.Parameters.AddWithValue("@UserID", CurrentUser.UserID)

            dgvSessions.DataSource = DatabaseHelper.GetDataTable(cmd)

            If dgvSessions.Columns("Edit") Is Nothing Then

                Dim btnEdit As New DataGridViewButtonColumn()

                btnEdit.Name = "Edit"

                btnEdit.HeaderText = "تعديل"

                btnEdit.Text = "✏️"

                btnEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                btnEdit.Width = 60

                btnEdit.UseColumnTextForButtonValue = True

                dgvSessions.Columns.Add(btnEdit)

            End If


            If dgvSessions.Columns("Delete") Is Nothing Then

                Dim btnDelete As New DataGridViewButtonColumn()

                btnDelete.Name = "Delete"

                btnDelete.HeaderText = "حذف"

                btnDelete.Text = "🗑"

                btnDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                btnDelete.Width = 60

                btnDelete.UseColumnTextForButtonValue = True

                dgvSessions.Columns.Add(btnDelete)

            End If

            If dgvSessions.Rows.Count > 0 Then

                dgvSessions.ClearSelection()

                dgvSessions.Rows(0).Selected = True

                dgvSessions.CurrentCell = dgvSessions.Rows(0).Cells(0)

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub dgvSessions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSessions.CellContentClick

    End Sub

    Private Sub dgvSessions_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSessions.CellClick
        If e.RowIndex < 0 Then Exit Sub

        If dgvSessions.Rows.Count = 1 Then Exit Sub

        Dim SessionID As Integer = dgvSessions.Rows(e.RowIndex).Cells("SessionID").Value

        ' تعديل

        If dgvSessions.Columns(e.ColumnIndex).Name = "Edit" Then

            Dim frm As New FrmAddNewSession()

            frm.PatientID = cbPatients.SelectedValue

            frm.ShowDialog()

            LoadSession()

        End If


        ' حذف

        If dgvSessions.Columns(e.ColumnIndex).Name = "Delete" Then

            Dim result As DialogResult = MessageBox.Show("هل تريد حذف الجلسة؟", "تأكيد",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                DeleteSession(SessionID)
            End If

        End If

    End Sub

    Private Sub DeleteSession(SessionID As Integer)

        Try

            ' التأكد من عدم وجود خدمات

            Dim cmdCheck As New SqlCommand("SELECT COUNT(*) FROM SessionServices WHERE SessionID=@SessionID")

            cmdCheck.Parameters.AddWithValue("@SessionID", SessionID)

            Dim count As Integer = DatabaseHelper.ExecuteScalar(cmdCheck)

            If count > 0 Then

                MessageBox.Show("لا يمكن حذف الجلسة لوجود خدمات مرتبطة بها")

                Exit Sub

            End If


            ' حذف المريض

            Dim cmdDelete As New SqlCommand("DELETE FROM Sessions WHERE SessionID=@SessionID")

            cmdDelete.Parameters.AddWithValue("@SessionID", SessionID)

            DatabaseHelper.ExecuteNonQuery(cmdDelete)

            MessageBox.Show("تم حذف الجلسة")

            LoadSession()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnAddServices_Click(sender As Object, e As EventArgs) Handles btnAddServices.Click

        If dgvSessions.CurrentRow Is Nothing Then

            MessageBox.Show("اختر جلسة أولاً.")

            Exit Sub

        End If

        Dim frm As New FrmSelectServices

        If frm.ShowDialog() = DialogResult.OK Then

            For Each dr As DataRow In frm.SelectedServices.Rows

                AddServiceToGrid(
                    CInt(dr("ServiceID")),
                    dr("ServiceName").ToString(),
                    CDec(dr("UnitPrice"))
                )

            Next

            CalculateServicesTotal()

        End If

    End Sub

    Private Sub AddServiceToGrid(ServiceID As Integer, ServiceName As String, UnitPrice As Decimal)

        'هل الخدمة موجودة بالفعل؟

        For Each row As DataGridViewRow In dgvServices.Rows

            If CInt(row.Cells("colServiceID").Value) = ServiceID Then

                MessageBox.Show("هذه الخدمة موجودة بالفعل.")

                Exit Sub

            End If

        Next

        Dim Qty As Decimal = 1D

        Dim Discount As Decimal = 0D

        Dim LineTotal As Decimal = (Qty * UnitPrice) - Discount

        dgvServices.Rows.Add(
                                ServiceID,
                                ServiceName,
                                Qty,
                                UnitPrice,
                                Discount,
                                LineTotal,
                                "حذف"
                            )
        CalculateServicesTotal()

    End Sub

    Private Sub dgvServices_CellEndEdit(sender As Object,
                                    e As DataGridViewCellEventArgs) Handles dgvServices.CellEndEdit
        Try

            If e.RowIndex < 0 Then Exit Sub

            Dim ColName As String = dgvServices.Columns(e.ColumnIndex).Name

            If ColName <> "colQty" AndAlso ColName <> "colDiscount" Then Exit Sub

            If dgvServices.Rows(e.RowIndex).IsNewRow Then Exit Sub

            Dim Qty As Decimal = 1
            Decimal.TryParse(dgvServices.Rows(e.RowIndex).Cells("colQty").Value.ToString(), Qty)

            If Qty <= 0 Then Qty = 1

            Dim UnitPrice As Decimal =
            Convert.ToDecimal(dgvServices.Rows(e.RowIndex).Cells("colUnitPrice").Value)

            Dim Discount As Decimal = 0
            Decimal.TryParse(dgvServices.Rows(e.RowIndex).Cells("colDiscount").Value.ToString(), Discount)

            If Discount < 0 Then Discount = 0

            Dim LineTotal As Decimal = Qty * UnitPrice - Discount

            If LineTotal < 0 Then LineTotal = 0

            dgvServices.Rows(e.RowIndex).Cells("colQty").Value = Qty
            dgvServices.Rows(e.RowIndex).Cells("colDiscount").Value = Discount
            dgvServices.Rows(e.RowIndex).Cells("colTotal").Value = LineTotal

            CalculateServicesTotal()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub dgvServices_CellContentClick(sender As Object,
                                         e As DataGridViewCellEventArgs) Handles dgvServices.CellContentClick

        If e.RowIndex < 0 Then Exit Sub

        If dgvServices.Columns(e.ColumnIndex).Name = "colDelete" Then

            dgvServices.Rows.RemoveAt(e.RowIndex)

        End If

        CalculateServicesTotal()

    End Sub


    Private Sub LoadSessionServices()

        Try

            dgvServices.Rows.Clear()

            If CurrentSessionID = 0 Then Exit Sub

            Dim cmd As New SqlCommand("SELECT
                                        SS.ServiceID,
                                        S.ServiceName,
                                        SS.Qty,
                                        SS.UnitPrice,
                                        SS.Discount,
                                        SS.LineTotal

                                   FROM SessionServices SS

                                   INNER JOIN Services S

                                        ON SS.ServiceID = S.ServiceID

                                   WHERE SS.SessionID=@SessionID

                                   ORDER BY S.ServiceName")

            cmd.Parameters.AddWithValue("@SessionID", CurrentSessionID)

            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

            For Each dr As DataRow In dt.Rows

                dgvServices.Rows.Add(
                                    dr("ServiceID"),
                                    dr("ServiceName"),
                                    dr("Qty"),
                                    dr("UnitPrice"),
                                    dr("Discount"),
                                    dr("LineTotal"),
                                    "حذف")

            Next

            CalculateServicesTotal()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub


    Private Sub btnSaveServices_Click(sender As Object,
                                  e As EventArgs) Handles btnSaveServices.Click

        Try

            If CurrentSessionId = 0 Then

                MessageBox.Show("اختر جلسة أولاً.")

                Exit Sub

            End If

            ' حذف الخدمات القديمة

            Dim cmdDelete As New SqlCommand("DELETE FROM SessionServices
                                         WHERE SessionID=@SessionID")

            cmdDelete.Parameters.AddWithValue("@SessionID", CurrentSessionId)

            DatabaseHelper.ExecuteNonQuery(cmdDelete)

            ' حفظ الخدمات الحالية

            For Each row As DataGridViewRow In dgvServices.Rows

                If row.IsNewRow Then Continue For

                Dim cmd As New SqlCommand("INSERT INTO SessionServices
                                      (
                                            SessionID,
                                            PatientID,
                                            ServiceID,
                                            Qty,
                                            UnitPrice,
                                            Discount,
                                            LineTotal
                                      )

                                      VALUES
                                      (
                                            @SessionID,
                                            @PatientID,
                                            @ServiceID,
                                            @Qty,
                                            @UnitPrice,
                                            @Discount,
                                            @LineTotal
                                      )")

                cmd.Parameters.AddWithValue("@SessionID", CurrentSessionId)

                cmd.Parameters.AddWithValue("@PatientID", CurrentPatientId)

                cmd.Parameters.AddWithValue("@ServiceID", row.Cells("colServiceID").Value)

                cmd.Parameters.AddWithValue("@Qty", row.Cells("colQty").Value)

                cmd.Parameters.AddWithValue("@UnitPrice", row.Cells("colUnitPrice").Value)

                cmd.Parameters.AddWithValue("@Discount", row.Cells("colDiscount").Value)

                cmd.Parameters.AddWithValue("@LineTotal", row.Cells("colTotal").Value)

                DatabaseHelper.ExecuteNonQuery(cmd)

            Next

            CalculateServicesTotal()

            MessageBox.Show("تم حفظ الخدمات بنجاح")

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub dgvSessions_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSessions.SelectionChanged

        If dgvSessions.Rows.Count = 1 Then
            CurrentSessionId = 0

            dgvServices.Rows.Clear()

            CalculateServicesTotal()

            Exit Sub

        End If

        CurrentSessionId = CInt(dgvSessions.CurrentRow.Cells("SessionID").Value)

        CurrentPatientId = cbPatients.SelectedValue

        LoadSessionServices()
    End Sub

    Private Sub CalculateServicesTotal()

        Dim GrossTotal As Decimal = 0D
        Dim DiscountTotal As Decimal = 0D
        Dim NetTotal As Decimal = 0D

        For Each row As DataGridViewRow In dgvServices.Rows

            If row.IsNewRow Then Continue For

            Dim Qty As Decimal = 0D
            Dim UnitPrice As Decimal = 0D
            Dim Discount As Decimal = 0D
            Dim LineTotal As Decimal = 0D

            Decimal.TryParse(Convert.ToString(row.Cells("colQty").Value), Qty)
            Decimal.TryParse(Convert.ToString(row.Cells("colUnitPrice").Value), UnitPrice)
            Decimal.TryParse(Convert.ToString(row.Cells("colDiscount").Value), Discount)
            Decimal.TryParse(Convert.ToString(row.Cells("colTotal").Value), LineTotal)

            GrossTotal += Qty * UnitPrice

            DiscountTotal += Discount

            NetTotal += LineTotal

        Next

        txtServicesTotal.Text = GrossTotal.ToString("N2")
        txtServicesDiscount.Text = DiscountTotal.ToString("N2")
        txtServicesNet.Text = NetTotal.ToString("N2")

    End Sub

    Private Sub cbPatients_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPatients.SelectedIndexChanged

    End Sub
End Class
