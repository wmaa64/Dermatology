Imports System.Data.SqlClient
Imports System.Data

Public Class UC_Appointments
    Private Sub btnAddAppointment_Click(sender As Object, e As EventArgs) Handles btnAddAppointment.Click
        Dim frm As New FrmAddAppointment()

        frm.ShowDialog()

        LoadAppointments()

        SetupGridButtons()

    End Sub

    Private Sub LoadAppointments()

        Try

            Dim cmd As New SqlCommand("SELECT
                                            A.AppointmentID AS 'الكود',
                                            P.FullName AS 'اسم المريض',
                                            A.AppointmentDate AS 'التاريخ',
                                            A.AppointmentTime AS 'الوقت',
                                            A.Status AS 'الحالة',
                                            A.Notes AS 'ملاحظات'
                                       FROM Appointments A

                                       INNER JOIN Patients P
                                        ON A.PatientID = P.PatientID

                                       ORDER BY
                                            A.AppointmentDate DESC,
                                            A.AppointmentTime DESC")

            dgvAppointments.DataSource = DatabaseHelper.GetDataTable(cmd)


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub SetupGridButtons()

        If dgvAppointments.Columns("Edit") Is Nothing Then

            Dim btnEdit As New DataGridViewButtonColumn()

            btnEdit.Name = "Edit"

            btnEdit.HeaderText = "تعديل"

            btnEdit.Text = "✏️"

            btnEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None

            btnEdit.Width = 60

            btnEdit.UseColumnTextForButtonValue = True

            dgvAppointments.Columns.Add(btnEdit)

        End If


        If dgvAppointments.Columns("Delete") Is Nothing Then

            Dim btnDelete As New DataGridViewButtonColumn()

            btnDelete.Name = "Delete"

            btnDelete.HeaderText = "حذف"

            btnDelete.Text = "🗑"

            btnDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None

            btnDelete.Width = 60

            btnDelete.UseColumnTextForButtonValue = True

            dgvAppointments.Columns.Add(btnDelete)

        End If

    End Sub

    Private Sub UC_Appointments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAppointments()
        SetupGridButtons()
    End Sub

    Private Sub dgvAppointments_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAppointments.CellContentClick

    End Sub

    Private Sub dgvAppointments_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAppointments.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim appointmentID As Integer = dgvAppointments.Rows(e.RowIndex).Cells("الكود").Value

        ' تعديل

        If dgvAppointments.Columns(e.ColumnIndex).Name = "Edit" Then

            Dim frm As New FrmAddAppointment()

            frm.AppointmentID = appointmentID

            frm.ShowDialog()

            LoadAppointments()

            SetupGridButtons()

        End If


        ' حذف

        If dgvAppointments.Columns(e.ColumnIndex).Name = "Delete" Then

            Dim result As DialogResult = MessageBox.Show("هل تريد حذف الموعد؟", "تأكيد",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                DeleteAppointment(appointmentID)
            End If

        End If

    End Sub

    Private Sub DeleteAppointment(appointmentID As Integer)

        Try

            ' حذف الموعد

            Dim cmdDelete As New SqlCommand("DELETE FROM Appointments WHERE AppointmentID=@AppointmentID")

            cmdDelete.Parameters.AddWithValue("@AppointmentID", appointmentID)

            DatabaseHelper.ExecuteNonQuery(cmdDelete)

            MessageBox.Show("تم حذف الموعد")

            LoadAppointments()

            SetupGridButtons()

        Catch ex As Exception

            con.Close()

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchAppointments()
    End Sub

    Private Sub SearchAppointments()

        Try

            Dim cmd As New SqlCommand("SELECT
                                            A.AppointmentID AS 'الكود',
                                            P.FullName AS 'اسم المريض',
                                            A.AppointmentDate AS 'التاريخ',
                                            A.AppointmentTime AS 'الوقت',
                                            A.Status AS 'الحالة',
                                            A.Notes AS 'ملاحظات'
                                        FROM Appointments A

                                        INNER JOIN Patients P
                                        ON A.PatientID = P.PatientID

                                        WHERE
                                            P.FullName LIKE @Search

                                        ORDER BY
                                            A.AppointmentDate DESC,
                                            A.AppointmentTime DESC")

            cmd.Parameters.AddWithValue("@Search", "%" & txtSearch.Text & "%")

            dgvAppointments.DataSource = DatabaseHelper.GetDataTable(cmd)

            SetupGridButtons()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub dgvAppointments_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgvAppointments.RowPrePaint
        Try
            Dim status As String = If(dgvAppointments.Rows(e.RowIndex).Cells("الحالة").Value, "").ToString()

            'Dim status As String = dgvAppointments.Rows(e.RowIndex).Cells("الحالة").Value.ToString()

            Select Case status

                Case "Pending"

                    dgvAppointments.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Orange
                    dgvAppointments.Rows(e.RowIndex).DefaultCellStyle.SelectionBackColor = Color.Orange
                    dgvAppointments.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White

                Case "Confirmed"

                    dgvAppointments.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.DeepSkyBlue
                    dgvAppointments.Rows(e.RowIndex).DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue
                    dgvAppointments.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White

                Case "Done"

                    dgvAppointments.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.MediumSeaGreen
                    dgvAppointments.Rows(e.RowIndex).DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen
                    dgvAppointments.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White

                Case "Cancelled"

                    dgvAppointments.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.IndianRed
                    dgvAppointments.Rows(e.RowIndex).DefaultCellStyle.SelectionBackColor = Color.IndianRed
                    dgvAppointments.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White

            End Select

        Catch ex As Exception

        End Try
    End Sub

    Private Sub FilterAppointments(whereClause As String)

        Try

            Dim query As String = "SELECT

                                        A.AppointmentID AS 'الكود',

                                        P.FullName AS 'اسم المريض',

                                        A.AppointmentDate AS 'التاريخ',

                                        A.AppointmentTime AS 'الوقت',

                                        A.Status AS 'الحالة',

                                        A.Notes AS 'ملاحظات'

                                    FROM Appointments A

                                    INNER JOIN Patients P
                                    ON A.PatientID = P.PatientID "

            If whereClause <> "" Then

                query &= " WHERE " & whereClause

            End If

            query &= " ORDER BY A.AppointmentDate DESC, A.AppointmentTime DESC"

            Dim cmd As New SqlCommand(query)

            dgvAppointments.DataSource = DatabaseHelper.GetDataTable(cmd)

            SetupGridButtons()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnToday_Click(sender As Object, e As EventArgs) Handles btnToday.Click
        FilterAppointments("CAST(A.AppointmentDate AS DATE) = CAST(GETDATE() AS DATE)")
    End Sub

    Private Sub btnTomorrow_Click(sender As Object, e As EventArgs) Handles btnTomorrow.Click
        FilterAppointments("CAST(A.AppointmentDate AS DATE) = CAST(DATEADD(DAY,1,GETDATE()) AS DATE)")
    End Sub

    Private Sub btnPending_Click(sender As Object, e As EventArgs) Handles btnPending.Click
        FilterAppointments("A.Status='Pending'")
    End Sub

    Private Sub btnConfirmed_Click(sender As Object, e As EventArgs) Handles btnConfirmed.Click
        FilterAppointments("A.Status='Confirmed'")
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        FilterAppointments("A.Status='Done'")
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        LoadAppointments()
        SetupGridButtons()
    End Sub

    Private Sub dgvAppointments_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvAppointments.CellMouseDown

        If e.RowIndex >= 0 And e.Button = MouseButtons.Right Then

            dgvAppointments.ClearSelection()

            dgvAppointments.Rows(e.RowIndex).Selected = True

            dgvAppointments.CurrentCell = dgvAppointments.Rows(e.RowIndex).Cells(e.ColumnIndex)

        End If

    End Sub

    Private Sub UpdateAppointmentStatus(newStatus As String)

        Try

            Dim appointmentID As Integer = dgvAppointments.CurrentRow.Cells("الكود").Value

            Dim cmd As New SqlCommand("UPDATE Appointments
                                       SET Status=@Status
                                       WHERE AppointmentID=@AppointmentID")

            cmd.Parameters.AddWithValue("@Status", newStatus)

            cmd.Parameters.AddWithValue("@AppointmentID", appointmentID)

            DatabaseHelper.ExecuteNonQuery(cmd)

            LoadAppointments()
            SetupGridButtons()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub cmsAppointmentStatus_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmsAppointmentStatus.Opening

    End Sub

    Private Sub miConfirm_Click(sender As Object, e As EventArgs) Handles miConfirm.Click
        UpdateAppointmentStatus("Confirmed")
    End Sub

    Private Sub miDone_Click(sender As Object, e As EventArgs) Handles miDone.Click
        UpdateAppointmentStatus("Done")
    End Sub

    Private Sub miCancel_Click(sender As Object, e As EventArgs) Handles miCancel.Click
        UpdateAppointmentStatus("Cancelled")
    End Sub
End Class


