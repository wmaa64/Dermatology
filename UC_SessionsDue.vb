Imports System.Data.SqlClient
Imports System.IO

Public Class UC_SessionsDue
    Public CurrentSessionId As Integer = 0

    Public CurrentPatientId As Integer = 0

    Private Sub UC_SessionsDue_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtpSessionDate.Value = Today

        FormatServicesGrid()

        LoadSessionsByDate()

    End Sub
    Private Sub LoadSessionsByDate()

        Try

            Dim cmd As New SqlCommand("SELECT

                                                LS.SessionID,
                                                
                                                LS.PatientID,

                                                LS.UserID,

                                                P.FullName AS PatientName,

                                                U.FullName AS DoctorName,

                                                CONVERT(varchar(5),LS.SessionDate,108) AS SessionTime,

                                                ISNULL(S.ServicesTotal,0) AS ServicesTotal,

                                                ISNULL(S.ServicesDiscount,0) AS ServicesDiscount,

                                                ISNULL(S.ServicesNet,0) AS ServicesNet,

                                                ISNULL(PM.TotalPaid,0) AS TotalPaid,

                                                ISNULL(S.ServicesNet,0)-ISNULL(PM.TotalPaid,0) AS Remaining

                                            FROM LaserSessions LS

                                            INNER JOIN Patients P
                                                ON LS.PatientID=P.PatientID

                                            INNER JOIN Users U
                                                ON LS.UserID=U.UserID

                                            LEFT JOIN
                                            (

                                                SELECT

                                                    SessionID,

                                                    SUM(Qty*UnitPrice) ServicesTotal,

                                                    SUM(Discount) ServicesDiscount,

                                                    SUM(LineTotal) ServicesNet

                                                FROM SessionServices

                                                GROUP BY SessionID

                                            ) S

                                            ON LS.SessionID=S.SessionID

                                            LEFT JOIN
                                            (

                                                SELECT

                                                    SessionID,

                                                    SUM(AmountPaid) TotalPaid

                                                FROM SessionPayments

                                                GROUP BY SessionID

                                            ) PM

                                            ON LS.SessionID=PM.SessionID

                                            WHERE
                                                CAST(LS.SessionDate AS DATE)=@SessionDate

                                            ORDER BY
                                                LS.SessionDate")

            cmd.Parameters.AddWithValue("@SessionDate", dtpSessionDate.Value.Date)

            dgvSessions.DataSource = DatabaseHelper.GetDataTable(cmd)

            FormatSessionsGrid()

            If dgvSessions.Rows.Count > 0 Then

                dgvSessions.ClearSelection()

                dgvSessions.Rows(0).Selected = True

                dgvSessions.CurrentCell = dgvSessions.Rows(0).Cells(0)

            Else

                dgvServices.Rows.Clear()

                CalculateServicesTotal()

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub FormatSessionsGrid()

        With dgvSessions

            .Columns("PatientID").Visible = False

            .Columns("UserID").Visible = False

            .Columns("SessionID").HeaderText = "الكود"

            .Columns("PatientName").HeaderText = "المريض"

            .Columns("DoctorName").HeaderText = "الطبيب"

            .Columns("SessionTime").HeaderText = "الوقت"

            .Columns("ServicesTotal").HeaderText = "الإجمالى"

            .Columns("ServicesDiscount").HeaderText = "الخصم"

            .Columns("ServicesNet").HeaderText = "الصافى"

            .Columns("TotalPaid").HeaderText = "المدفوع"

            .Columns("Remaining").HeaderText = "المتبقى"

            .Columns("ServicesTotal").DefaultCellStyle.Format = "N2"

            .Columns("ServicesDiscount").DefaultCellStyle.Format = "N2"

            .Columns("ServicesNet").DefaultCellStyle.Format = "N2"

            .Columns("TotalPaid").DefaultCellStyle.Format = "N2"

            .Columns("Remaining").DefaultCellStyle.Format = "N2"

        End With

        If dgvSessions.Columns.Contains("colPayments") = False Then

            Dim btn As New DataGridViewButtonColumn

            btn.Name = "colPayments"

            btn.HeaderText = ""

            'المدفوعات
            btn.Text = "مدفوعات 💰"

            btn.UseColumnTextForButtonValue = True

            btn.Width = 40

            dgvSessions.Columns.Add(btn)

        End If

        If dgvSessions.Columns.Contains("colInvoice") = False Then

            Dim btn As New DataGridViewButtonColumn

            btn.Name = "colInvoice"

            btn.HeaderText = ""

            btn.Text = "فاتورة 🧾"

            btn.UseColumnTextForButtonValue = True

            btn.Width = 80

            dgvSessions.Columns.Add(btn)

        End If

        If dgvSessions.Columns.Contains("colPatientSessions") = False Then

            Dim btn As New DataGridViewButtonColumn

            btn.Name = "colPatientSessions"

            btn.HeaderText = ""

            'جلسات المريض
            btn.Text = "جلسات 📅"

            btn.UseColumnTextForButtonValue = True

            btn.Width = 40

            dgvSessions.Columns.Add(btn)

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

            txtServicesTotal.Text = "0.00"
            txtServicesDiscount.Text = "0.00"
            txtServicesNet.Text = "0.00"

            If CurrentSessionId = 0 Then Exit Sub

            Dim cmd As New SqlCommand("SELECT

                                        SS.ServiceID,

                                        S.ServiceName,

                                        SS.Qty,

                                        SS.UnitPrice,

                                        SS.Discount,

                                        SS.LineTotal

                                   FROM SessionServices SS

                                   INNER JOIN Services S

                                        ON SS.ServiceID=S.ServiceID

                                   WHERE SS.SessionID=@SessionID

                                   ORDER BY S.ServiceName")

            cmd.Parameters.AddWithValue("@SessionID", CurrentSessionId)

            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

            For Each dr As DataRow In dt.Rows

                dgvServices.Rows.Add(
                                        dr("ServiceID"),
                                        dr("ServiceName"),
                                        dr("Qty"),
                                        dr("UnitPrice"),
                                        dr("Discount"),
                                        dr("LineTotal")
                                    )

            Next

            CalculateServicesTotal()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub FormatServicesGrid()

        dgvServices.ReadOnly = True

        dgvServices.AllowUserToAddRows = False

        dgvServices.AllowUserToDeleteRows = False

        dgvServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub
    Private Sub dgvSessions_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSessions.SelectionChanged

        If dgvSessions.Rows.Count = 1 Then

            CurrentSessionId = 0

            dgvServices.Rows.Clear()

            CalculateServicesTotal()

            Exit Sub

        End If

        If dgvSessions.CurrentRow.IsNewRow Then

            CurrentSessionId = 0

            Exit Sub
        End If

        CurrentSessionId = CInt(dgvSessions.CurrentRow.Cells("SessionID").Value)

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

    Private Sub dtpSessionDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpSessionDate.ValueChanged

        LoadSessionsByDate()

    End Sub

    Private Sub dgvSessions_CellContentClick(sender As Object,
                                         e As DataGridViewCellEventArgs) _
                                         Handles dgvSessions.CellContentClick

        Try

            If e.RowIndex < 0 Then Exit Sub

            If dgvSessions.Columns(e.ColumnIndex).Name = "colPayments" Then

                Dim frm As New FrmSessionPayments

                frm.SessionID = CInt(dgvSessions.Rows(e.RowIndex).Cells("SessionID").Value)

                frm.PatientID = CInt(dgvSessions.Rows(e.RowIndex).Cells("PatientID").Value)

                frm.ShowDialog()

                LoadSessionsByDate()

            ElseIf dgvSessions.Columns(e.ColumnIndex).Name = "colInvoice" Then

                Dim frm As New FrmInvoicePrint

                frm.SessionID = CInt(dgvSessions.Rows(e.RowIndex).Cells("SessionID").Value)

                frm.ShowDialog()

            ElseIf dgvSessions.Columns(e.ColumnIndex).Name = "colPatientSessions" Then

                Dim frm As New FrmPatientSessions

                frm.PatientID = CInt(dgvSessions.Rows(e.RowIndex).Cells("PatientID").Value)

                frm.PatientName = dgvSessions.Rows(e.RowIndex).Cells("PatientName").Value.ToString()

                frm.ShowDialog()

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

End Class
