Imports System.Data.SqlClient
Imports System.Data

Public Class FrmPatientProfile
    Public PatientID As Integer

    Private SelectedPlanID As Integer = 0

    Private Sub FrmPatientProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPatientData()
        LoadTreatmentPlans()
        LoadSessions()
        LoadMedicalHistory()
        LoadDoctorNotes()
        LoadPatientPhotos()
        LoadPhotoPlans()
        LoadSessionsCount()
        LoadFinancialSummary()
    End Sub


    Private Sub LoadPatientData()

        Try

            Dim cmd As New SqlCommand("SELECT * FROM Patients WHERE PatientID=@ID")

            cmd.Parameters.AddWithValue("@ID", PatientID)

            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

            If dt.Rows.Count > 0 Then

                lblName.Text = dt.Rows(0)("FullName").ToString()

                lblPhone.Text = dt.Rows(0)("Phone").ToString()

                lblAge.Text = dt.Rows(0)("Age").ToString()

                lblAddress.Text = dt.Rows(0)("Address").ToString()

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub


    Private Sub btnAddSession_Click(sender As Object, e As EventArgs) Handles btnAddSession.Click
        Dim frm As New FrmAddSession()

        frm.PatientID = PatientID

        frm.ShowDialog()

        LoadSessions()

        LoadSessionsCount()

        LoadFinancialSummary()
    End Sub

    Private Sub LoadSessions()

        Try
            Dim cmd As New SqlCommand("SELECT 
                                            SessionID,
                                            SessionDate AS 'تاريخ الجلسة',
                                            Area AS 'المنطقة',
                                            Device AS 'الجهاز',
                                            SessionPrice AS 'السعر',
                                            Notes AS 'ملاحظات'
                                       FROM LaserSessions
                                       WHERE PatientID=@PatientID
                                       ORDER BY SessionDate DESC")

            cmd.Parameters.AddWithValue("@PatientID", PatientID)

            dgvSessions.DataSource = DatabaseHelper.GetDataTable(cmd)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub LoadSessionsCount()

        Try

            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM LaserSessions WHERE PatientID=@PatientID")

            cmd.Parameters.AddWithValue("@PatientID", PatientID)

            Dim count As Integer = DatabaseHelper.ExecuteScalar(cmd)

            lblSessionsCount.Text = "عدد الجلسات: " & count

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub LoadFinancialSummary()

        Try

            Dim totalSessions As Decimal = 0

            Dim totalPaid As Decimal = 0

            Dim remaining As Decimal = 0

            ' إجمالي أسعار الجلسات

            Dim cmd1 As New SqlCommand("SELECT ISNULL(SUM(SessionPrice),0) FROM LaserSessions
                                        WHERE PatientID=@PatientID")

            cmd1.Parameters.AddWithValue("@PatientID", PatientID)

            totalSessions = DatabaseHelper.ExecuteScalar(cmd1)

            ' إجمالي المدفوع

            Dim cmd2 As New SqlCommand("SELECT ISNULL(SUM(AmountPaid),0) FROM Payments
                                        WHERE PatientID=@PatientID")

            cmd2.Parameters.AddWithValue("@PatientID", PatientID)

            totalPaid = DatabaseHelper.ExecuteScalar(cmd2)

            remaining = totalSessions - totalPaid

            lblTotalSessions.Text = "إجمالي الجلسات: " & totalSessions & " ج"

            lblTotalPaid.Text = "المدفوع: " & totalPaid & " ج"

            lblRemaining.Text = "المتبقي: " & remaining & " ج"

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub LoadMedicalHistory()

        Try

            Dim cmd As New SqlCommand("SELECT * FROM MedicalHistory WHERE PatientID=@PatientID")

            cmd.Parameters.AddWithValue("@PatientID", PatientID)

            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

            If dt.Rows.Count > 0 Then

                txtAllergies.Text = dt.Rows(0)("Allergies").ToString()

                txtConditions.Text = dt.Rows(0)("MedicalConditions").ToString()

                txtMedications.Text = dt.Rows(0)("CurrentMedications").ToString()

                cbSkinType.Text = dt.Rows(0)("SkinType").ToString()

                txtMedicalNotes.Text = dt.Rows(0)("Notes").ToString()

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub


    Private Sub btnAddPayment_Click(sender As Object, e As EventArgs) Handles btnAddPayment.Click
        Dim frm As New FrmAddPayment()

        frm.PatientID = PatientID

        frm.ShowDialog()

        LoadFinancialSummary()
    End Sub


    Private Sub btnSaveMedical_Click(sender As Object, e As EventArgs) Handles btnSaveMedical.Click

        Try

            ' هل يوجد سجل مسبق؟

            Dim checkCmd As New SqlCommand("SELECT COUNT(*) FROM MedicalHistory  WHERE PatientID=@PatientID")

            checkCmd.Parameters.AddWithValue("@PatientID", PatientID)

            Dim exists As Integer = DatabaseHelper.ExecuteScalar(checkCmd)

            Dim query As String = ""

            If exists = 0 Then

                ' INSERT

                query = "INSERT INTO MedicalHistory
                        (
                            PatientID,
                            Allergies,
                            MedicalConditions,
                            CurrentMedications,
                            SkinType,
                            Notes
                        )

                        VALUES
                        (
                            @PatientID,
                            @Allergies,
                            @MedicalConditions,
                            @CurrentMedications,
                            @SkinType,
                            @Notes
                        )"

            ElseIf exists = 1 Then

                ' UPDATE

                query = "UPDATE MedicalHistory

                         SET

                            Allergies=@Allergies,

                            MedicalConditions=@MedicalConditions,

                            CurrentMedications=@CurrentMedications,

                            SkinType=@SkinType,

                            Notes=@Notes

                         WHERE PatientID=@PatientID"
            Else

                MsgBox("error")
                Exit Sub

            End If

            Dim cmd As New SqlCommand(query)

            cmd.Parameters.AddWithValue("@PatientID", PatientID)

            cmd.Parameters.AddWithValue("@Allergies", txtAllergies.Text)

            cmd.Parameters.AddWithValue("@MedicalConditions", txtConditions.Text)

            cmd.Parameters.AddWithValue("@CurrentMedications", txtMedications.Text)

            cmd.Parameters.AddWithValue("@SkinType", cbSkinType.Text)

            cmd.Parameters.AddWithValue("@Notes", txtMedicalNotes.Text)

            DatabaseHelper.ExecuteNonQuery(cmd)

            MessageBox.Show("تم حفظ التاريخ المرضي")

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnAddNote_Click(sender As Object, e As EventArgs) Handles btnAddNote.Click
        Try

            If txtDoctorNote.Text.Trim = "" Then

                MessageBox.Show("اكتب الملاحظة")

                Exit Sub

            End If

            Dim cmd As New SqlCommand("INSERT INTO DoctorNotes
                                        (
                                            PatientID,
                                            NoteText
                                        )

                                        VALUES
                                        (
                                            @PatientID,
                                            @NoteText
                                        )")

            cmd.Parameters.AddWithValue("@PatientID", PatientID)

            cmd.Parameters.AddWithValue("@NoteText", txtDoctorNote.Text)

            DatabaseHelper.ExecuteNonQuery(cmd)

            txtDoctorNote.Clear()

            LoadDoctorNotes()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub LoadDoctorNotes()

        Try

            flpNotes.Controls.Clear()

            Dim cmd As New SqlCommand("SELECT *  FROM DoctorNotes  WHERE PatientID=@PatientID

                                         ORDER BY CreatedAt DESC")

            cmd.Parameters.AddWithValue("@PatientID", PatientID)

            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

            For Each row As DataRow In dt.Rows

                Dim pnl As New Panel()

                pnl.Width = flpNotes.ClientSize.Width - 25

                pnl.Height = 120

                pnl.BackColor = Color.White

                pnl.BorderStyle = BorderStyle.FixedSingle

                pnl.Margin = New Padding(5)

                ' DATE
                Dim lblDate As New Label()

                lblDate.Text = Convert.ToDateTime(row("CreatedAt")).ToString("dd MMM yyyy hh:mm tt")

                lblDate.Font = New Font("Segoe UI", 9, FontStyle.Bold)

                lblDate.ForeColor = Color.Gray

                lblDate.Location = New Point(10, 10)

                lblDate.AutoSize = True

                ' NOTE
                Dim lblNote As New Label()

                lblNote.Text = row("NoteText").ToString()

                lblNote.Font = New Font("Segoe UI", 10)

                lblNote.Location = New Point(10, 40)

                lblNote.MaximumSize = New Size(pnl.Width - 20, 0)

                lblNote.AutoSize = True

                pnl.Controls.Add(lblDate)

                pnl.Controls.Add(lblNote)

                flpNotes.Controls.Add(pnl)

            Next

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub dgvSessions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSessions.CellContentClick

    End Sub

    Private Sub dgvSessions_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSessions.CellMouseDoubleClick

        If e.RowIndex >= 0 Then

            Dim frm As New FrmSessionDetails()

            frm.SessionID = dgvSessions.Rows(e.RowIndex).Cells("SessionID").Value

            frm.ShowDialog()

        End If

    End Sub

    Private Sub btnAddPhoto_Click(sender As Object, e As EventArgs) Handles btnAddPhoto.Click
        Try
            If cbPhotoPlan.SelectedValue Is Nothing Then

                MessageBox.Show("Please select a treatment plan.")

                Exit Sub

            End If

            Dim ofd As New OpenFileDialog()

            ofd.Filter = "Images|*.jpg;*.jpeg;*.png"

            If ofd.ShowDialog = DialogResult.OK Then

                Dim planID As Integer = CInt(cbPhotoPlan.SelectedValue)

                ' نوع الصورة
                Dim photoType As String = InputBox("Type: Before / After / Progress")

                If photoType.Trim = "" Then Exit Sub

                ' إنشاء المجلدات
                Dim rootFolder As String = "F:\PatientPhotos"

                Dim patientFolder As String = IO.Path.Combine(rootFolder, "Patient_" & PatientID)

                Dim planFolder As String = IO.Path.Combine(patientFolder, "Plan_" & planID)

                If Not IO.Directory.Exists(planFolder) Then

                    IO.Directory.CreateDirectory(planFolder)

                End If

                If Not IO.Directory.Exists(planFolder) Then

                    IO.Directory.CreateDirectory(planFolder)

                End If

                ' امتداد الملف
                Dim extension As String = IO.Path.GetExtension(ofd.FileName)

                ' اسم الملف
                Dim fileName As String =
                    photoType.ToLower() & "_" & DateTime.Now.ToString("yyyyMMddHHmmss") & extension

                ' المسار النهائي
                Dim destination As String = IO.Path.Combine(planFolder, fileName)

                ' نسخ الصورة
                IO.File.Copy(ofd.FileName, destination, True)

                ' حفظ في قاعدة البيانات
                Dim cmd As New SqlCommand("INSERT INTO PatientPhotos
                                            (
                                                PatientID,
                                                PlanID,
                                                PhotoPath,
                                                PhotoType
                                            )

                                            VALUES
                                            (
                                                @PatientID,
                                                @PlanID,
                                                @PhotoPath,
                                                @PhotoType
                                            )")

                cmd.Parameters.AddWithValue("@PatientID", PatientID)

                cmd.Parameters.AddWithValue("@PlanID", cbPhotoPlan.SelectedValue)

                cmd.Parameters.AddWithValue("@PhotoPath", destination)

                cmd.Parameters.AddWithValue("@PhotoType", photoType)

                DatabaseHelper.ExecuteNonQuery(cmd)

                LoadPatientPhotos()

                MessageBox.Show("Photo Added Successfully")

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub LoadPatientPhotos()

        Try
            If cbPhotoPlan.SelectedValue Is Nothing Then Exit Sub

            If TypeOf cbPhotoPlan.SelectedValue Is DataRowView Then Exit Sub

            flpPhotos.Controls.Clear()

            Dim cmd As New SqlCommand("SELECT *  FROM PatientPhotos  
                                        WHERE PatientID=@PatientID 
                                         AND PlanID=@PlanID
                                         ORDER BY PhotoDate DESC")

            cmd.Parameters.AddWithValue("@PatientID", PatientID)

            cmd.Parameters.AddWithValue("@PlanID", Convert.ToInt32(cbPhotoPlan.SelectedValue))

            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

            For Each row As DataRow In dt.Rows

                Dim pnl As New Panel()

                pnl.Width = 220

                pnl.Height = 260

                pnl.BorderStyle = BorderStyle.FixedSingle

                pnl.Margin = New Padding(10)

                ' Picture
                Dim pic As New PictureBox()

                pic.Width = 200

                pic.Height = 180

                pic.SizeMode = PictureBoxSizeMode.Zoom

                pic.Image = Image.FromFile(row("PhotoPath").ToString())

                pic.Location = New Point(10, 10)

                ' Type
                Dim lblType As New Label()

                lblType.Text = row("PhotoType").ToString()

                lblType.Font = New Font("Segoe UI", 10, FontStyle.Bold)

                lblType.Location = New Point(10, 200)

                lblType.AutoSize = True

                ' Date
                Dim lblDate As New Label()

                lblDate.Text = Convert.ToDateTime(row("PhotoDate")).ToString("dd MMM yyyy")

                lblDate.Location = New Point(10, 225)

                lblDate.AutoSize = True

                pnl.Controls.Add(pic)

                pnl.Controls.Add(lblType)

                pnl.Controls.Add(lblDate)

                flpPhotos.Controls.Add(pnl)

            Next

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub txtPlanName_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub tabTreatmentPlan_Click(sender As Object, e As EventArgs) Handles tabTreatmentPlan.Click

    End Sub

    Private Sub LoadTreatmentPlans()

        Try

            Dim cmd As New SqlCommand("SELECT

                                        PlanID,

                                        PlanName AS 'الخطة',

                                        TreatmentArea AS 'المنطقة',

                                        PlannedSessions AS 'الجلسات',

                                        Status AS 'الحالة',

                                        StartDate AS 'تاريخ البداية'

                                    FROM TreatmentPlans

                                    WHERE PatientID=@PatientID

                                    ORDER BY StartDate DESC")

            cmd.Parameters.AddWithValue("@PatientID", PatientID)

            dgvTreatmentPlans.DataSource = DatabaseHelper.GetDataTable(cmd)

            If dgvTreatmentPlans.Rows.Count > 0 Then

                dgvTreatmentPlans.Rows(0).Selected = True

                SelectedPlanID = CInt(dgvTreatmentPlans.Rows(0).Cells("PlanID").Value)

                LoadPlanProgress(SelectedPlanID)

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Private Sub LoadPlanProgress(PlanID As Integer)

        Try

            Dim cmd1 As New SqlCommand("SELECT PlannedSessions  FROM TreatmentPlans  WHERE PlanID=@PlanID")

            cmd1.Parameters.AddWithValue("@PlanID", PlanID)

            Dim planned As Integer = DatabaseHelper.ExecuteScalar(cmd1)

            Dim cmd2 As New SqlCommand("SELECT COUNT(*)   FROM LaserSessions  WHERE PlanID=@PlanID")

            cmd2.Parameters.AddWithValue("@PlanID", PlanID)

            Dim completed As Integer = DatabaseHelper.ExecuteScalar(cmd2)

            Dim remaining As Integer = planned - completed

            Dim progress As Decimal = 0

            If planned > 0 Then

                progress = (completed * 100D) / planned

            End If

            lblCompleted.Text = "تم: " & completed

            lblRemainingSessions.Text = "متبقي: " & remaining

            lblProgress.Text = progress.ToString("0") & "%"

            prgTreatment.Value = Math.Min(CInt(progress), 100)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnNewPlan_Click(sender As Object, e As EventArgs) Handles btnNewPlan.Click
        Dim frm As New FrmTreatmentPlan()

        frm.PatientID = PatientID

        If frm.ShowDialog() = DialogResult.OK Then

            LoadTreatmentPlans()

        End If

    End Sub

    Private Sub dgvTreatmentPlans_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTreatmentPlans.CellContentClick

    End Sub

    Private Sub dgvTreatmentPlans_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTreatmentPlans.CellDoubleClick
        If e.RowIndex >= 0 Then

            Dim frm As New FrmTreatmentPlan()

            frm.PlanID = dgvTreatmentPlans.Rows(e.RowIndex).Cells("PlanID").Value

            frm.ShowDialog()

        End If
    End Sub

    Private Sub dgvTreatmentPlans_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTreatmentPlans.CellClick
        If e.RowIndex < 0 Then Exit Sub

        SelectedPlanID = CInt(dgvTreatmentPlans.Rows(e.RowIndex).Cells("PlanID").Value)

        LoadPlanProgress(SelectedPlanID)
    End Sub

    Private Sub LoadPhotoPlans()

        Dim cmd As New SqlCommand("SELECT  PlanID, PlanName  FROM TreatmentPlans  WHERE PatientID=@PatientID

                                     ORDER BY StartDate DESC")

        cmd.Parameters.AddWithValue("@PatientID", PatientID)

        Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

        cbPhotoPlan.DataSource = dt

        cbPhotoPlan.DisplayMember = "PlanName"

        cbPhotoPlan.ValueMember = "PlanID"

    End Sub

    Private Sub cbPhotoPlan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPhotoPlan.SelectedIndexChanged
        LoadPatientPhotos()
    End Sub

End Class