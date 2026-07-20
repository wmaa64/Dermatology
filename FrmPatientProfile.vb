Imports System.Data.SqlClient
Imports System.Data

Public Class FrmPatientProfile
    Public PatientID As Integer

    Private CurrentSessionID As Integer = 0

    Private Sub FrmPatientProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadPatientData()

        LoadSessions()

        LoadMedicalHistory()

        LoadDoctorNotes()

        LoadPhotoSessions()
        LoadPatientPhotos()



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



    Private Sub LoadSessions()

        Try

            Dim cmd As New SqlCommand("SELECT
                                            LS.SessionID,
                                            LS.SessionDate AS 'تاريخ الجلسة',
                                            TA.AreaName AS 'المنطقة',
                                            D.DeviceName AS 'الجهاز',
                                            LS.Notes AS 'ملاحظات',
                                            US.UserID,
                                            US.UserName AS 'الطبيب'
                                            

                                        FROM LaserSessions LS

                                        INNER JOIN Users US
                                               ON LS.UserID = US.UserID

                                        LEFT JOIN Devices D
                                               ON LS.DeviceID = D.DeviceID

                                        LEFT JOIN TreatmentAreas TA
                                               ON LS.AreaID = TA.AreaID

                                        WHERE LS.PatientID=@PatientID

                                        ORDER BY LS.SessionDate DESC")

            cmd.Parameters.AddWithValue("@PatientID", PatientID)

            dgvSessions.DataSource = DatabaseHelper.GetDataTable(cmd)

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


    Private Sub LoadSessionDetails()

        Try

            Dim cmd As New SqlCommand("SELECT *  FROM SessionDetails  WHERE SessionID=@SessionID")

            cmd.Parameters.AddWithValue("@SessionID", CurrentSessionID)

            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

            If dt.Rows.Count > 0 Then

                cbLaserType.Text = dt.Rows(0)("LaserType").ToString()

                txtEnergy.Text = dt.Rows(0)("EnergyLevel").ToString()

                txtPulseWidth.Text = dt.Rows(0)("PulseWidth").ToString()

                txtSpotSize.Text = dt.Rows(0)("SpotSize").ToString()

                txtAreaDetails.Text = dt.Rows(0)("AreaDetails").ToString()

                txtSkinReaction.Text = dt.Rows(0)("SkinReaction").ToString()

                txtDoctorNotes.Text = dt.Rows(0)("DoctorNotes").ToString()

                If Not IsDBNull(dt.Rows(0)("NextSessionDate")) Then

                    dtNextSession.Value = Convert.ToDateTime(dt.Rows(0)("NextSessionDate"))

                End If

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub dgvSessions_SelectionChanged(sender As Object, e As EventArgs) _
Handles dgvSessions.SelectionChanged

        Try

            If dgvSessions.CurrentRow Is Nothing Then Exit Sub

            If IsDBNull(dgvSessions.CurrentRow.Cells("SessionID").Value) Then Exit Sub

            CurrentSessionID = CInt(dgvSessions.CurrentRow.Cells("SessionID").Value)

            'تحميل بيانات الجلسة
            LoadSessionDetails()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

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

    Private Sub LoadPhotoSessions()

        Dim cmd As New SqlCommand("SELECT
                                    SessionID,
                                    CONVERT(varchar(10), SessionDate, 111) + ' - ' +
                                    ISNULL(CAST(SessionID AS varchar(20)), '') AS SessionName
                               FROM LaserSessions
                               WHERE PatientID=@PatientID
                               ORDER BY SessionDate DESC")

        cmd.Parameters.AddWithValue("@PatientID", PatientID)

        Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

        cbSessions.DataSource = dt

        cbSessions.DisplayMember = "SessionName"

        cbSessions.ValueMember = "SessionID"

    End Sub

    Private Sub cbSessions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSessions.SelectedIndexChanged

        If cbSessions.SelectedValue Is Nothing Then Exit Sub

        If TypeOf cbSessions.SelectedValue Is DataRowView Then Exit Sub

        CurrentSessionID = CInt(cbSessions.SelectedValue)

        LoadPatientPhotos()

    End Sub

    Private Sub dgvSessions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSessions.CellContentClick

    End Sub

    Private Sub dgvSessions_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSessions.CellMouseDoubleClick

        If e.RowIndex >= 0 Then

            If dgvSessions.Rows(e.RowIndex).Cells("UserID").Value = CurrentUser.UserID Then

                Dim frm As New FrmSessionDetails()

                frm.SessionID = dgvSessions.Rows(e.RowIndex).Cells("SessionID").Value

                frm.ShowDialog()

            Else

                MessageBox.Show("ليس لديك صلاحية إضافة او تعديل تفاصيل الجلسة الخاصة بطبيب آخر.",
                        "صلاحيات",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)

                Exit Sub

            End If

        End If

    End Sub



    Private Sub btnAddPhoto_Click(sender As Object, e As EventArgs) Handles btnAddPhoto.Click
        Try
            If CurrentSessionID = 0 Then

                MessageBox.Show("برجاء اختيار الجلسة أولاً")

                Exit Sub

            End If

            Dim ofd As New OpenFileDialog()

            ofd.Filter = "Images|*.jpg;*.jpeg;*.png"

            If ofd.ShowDialog = DialogResult.OK Then

                ' نوع الصورة
                Dim photoType As String = InputBox("Type: Before / After / Progress")

                If photoType.Trim = "" Then Exit Sub

                ' إنشاء المجلدات
                Dim rootFolder As String = AppSettings.PatientPhotosPath

                If String.IsNullOrWhiteSpace(rootFolder) Then

                    MessageBox.Show("Patient Photos Path is not configured." &
                    vbCrLf &
                    "Please configure it from System Settings.")

                    Exit Sub

                End If

                Dim patientFolder As String = IO.Path.Combine(rootFolder, "Patient_" & PatientID)

                If Not IO.Directory.Exists(patientFolder) Then

                    IO.Directory.CreateDirectory(patientFolder)

                End If

                Dim sessionFolder As String = IO.Path.Combine(patientFolder, "Session_" & CurrentSessionID)

                If Not IO.Directory.Exists(sessionFolder) Then

                    IO.Directory.CreateDirectory(sessionFolder)

                End If

                ' امتداد الملف
                Dim extension As String = IO.Path.GetExtension(ofd.FileName)

                ' اسم الملف
                Dim fileName As String =
                    photoType.ToLower() & "_" & DateTime.Now.ToString("yyyyMMddHHmmss") & extension

                ' Relative Path
                Dim relativePath = IO.Path.Combine("Patient_" & PatientID, "Session_" & CurrentSessionID, fileName)

                ' المسار النهائي
                Dim destination As String = IO.Path.Combine(rootFolder, relativePath)

                ' نسخ الصورة
                IO.File.Copy(ofd.FileName, destination, True)

                ' حفظ في قاعدة البيانات
                Dim cmd As New SqlCommand("INSERT INTO PatientPhotos
                                            (
                                                PatientID,
                                                SessionID,
                                                PhotoPath,
                                                PhotoType
                                            )

                                            VALUES
                                            (
                                                @PatientID,
                                                @SessionID,
                                                @PhotoPath,
                                                @PhotoType
                                            )")

                cmd.Parameters.AddWithValue("@PatientID", PatientID)

                cmd.Parameters.AddWithValue("@SessionID", CurrentSessionID)

                cmd.Parameters.AddWithValue("@PhotoPath", relativePath)

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
            If CurrentSessionID = 0 Then Exit Sub

            flpPhotos.Controls.Clear()

            Dim cmd As New SqlCommand("SELECT *  FROM PatientPhotos  
                                        
                                        WHERE PatientID=@PatientID
                                        
                                        AND SessionID=@SessionID
                                        
                                        ORDER BY PhotoDate DESC")

            cmd.Parameters.AddWithValue("@PatientID", PatientID)

            cmd.Parameters.AddWithValue("@SessionID", CurrentSessionID)

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

                Dim fullPath As String = IO.Path.Combine(AppSettings.PatientPhotosPath, row("PhotoPath").ToString())

                If IO.File.Exists(fullPath) Then

                    pic.Image = Image.FromFile(fullPath)

                Else

                    pic.Image = Nothing

                End If

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

    Private Sub tabTreatmentPlan_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub cbPhotoPlan_SelectedIndexChanged(sender As Object, e As EventArgs)
        LoadPatientPhotos()
    End Sub



End Class