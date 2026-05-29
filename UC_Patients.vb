Imports System.Data.SqlClient
Imports System.Data

Public Class UC_Patients
    Private Sub UC_Patients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPatients()
    End Sub

    Private Sub btnAddPatient_Click(sender As Object, e As EventArgs) Handles btnAddPatient.Click
        Dim frm As New FrmAddPatient()

        FrmAddPatient.ShowDialog()

        LoadPatients()
    End Sub

    Private Sub LoadPatients()

        Try

            Dim cmd As New SqlCommand("SELECT 
                                        PatientID AS 'الكود', 
                                        FullName AS 'اسم المريض',
                                        Phone AS 'الهاتف',
                                        Age AS 'العمر',
                                        Address AS 'العنوان'            
                                     FROM Patients")

            dgvPatients.DataSource = DatabaseHelper.GetDataTable(cmd)


            If dgvPatients.Columns("Edit") Is Nothing Then

                Dim btnEdit As New DataGridViewButtonColumn()

                btnEdit.Name = "Edit"

                btnEdit.HeaderText = "تعديل"

                btnEdit.Text = "✏️"

                btnEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                btnEdit.Width = 60

                btnEdit.UseColumnTextForButtonValue = True

                dgvPatients.Columns.Add(btnEdit)

            End If


            If dgvPatients.Columns("Delete") Is Nothing Then

                Dim btnDelete As New DataGridViewButtonColumn()

                btnDelete.Name = "Delete"

                btnDelete.HeaderText = "حذف"

                btnDelete.Text = "🗑"

                btnDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                btnDelete.Width = 60

                btnDelete.UseColumnTextForButtonValue = True

                dgvPatients.Columns.Add(btnDelete)

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub SearchPatients()

        Try

            Dim cmd As New SqlCommand("SELECT 
                                        PatientID AS 'الكود',
                                        FullName AS 'اسم المريض',
                                        Phone AS 'الهاتف',
                                        Age AS 'العمر',
                                        Address AS 'العنوان'

                                       FROM Patients

                                       WHERE
                                        FullName LIKE @Search
                                        OR Phone LIKE @Search")

            cmd.Parameters.AddWithValue("@Search", "%" & txtSearch.Text & "%")

            dgvPatients.DataSource = DatabaseHelper.GetDataTable(cmd)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchPatients()
    End Sub

    Private Sub dgvPatients_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPatients.CellContentClick

    End Sub

    Private Sub dgvPatients_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPatients.CellDoubleClick

        Dim frm As New FrmPatientProfile()

        frm.PatientID = dgvPatients.CurrentRow.Cells("الكود").Value

        frm.ShowDialog()

    End Sub

    Private Sub dgvPatients_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPatients.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim patientID As Integer = dgvPatients.Rows(e.RowIndex).Cells("الكود").Value

        ' تعديل

        If dgvPatients.Columns(e.ColumnIndex).Name = "Edit" Then

            Dim frm As New FrmAddPatient()

            frm.PatientID = patientID

            frm.ShowDialog()

            LoadPatients()

        End If


        ' حذف

        If dgvPatients.Columns(e.ColumnIndex).Name = "Delete" Then

            Dim result As DialogResult = MessageBox.Show("هل تريد حذف المريض؟", "تأكيد",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                DeletePatient(patientID)
            End If

        End If

    End Sub

    Private Sub DeletePatient(patientID As Integer)

        Try

            ' التأكد من عدم وجود جلسات

            Dim cmdCheck As New SqlCommand("SELECT COUNT(*) FROM LaserSessions WHERE PatientID=@PatientID")

            cmdCheck.Parameters.AddWithValue("@PatientID", patientID)

            Dim count As Integer = DatabaseHelper.ExecuteScalar(cmdCheck)

            If count > 0 Then

                MessageBox.Show("لا يمكن حذف المريض لوجود جلسات مرتبطة به")

                Exit Sub

            End If


            ' حذف المريض

            Dim cmdDelete As New SqlCommand("DELETE FROM Patients WHERE PatientID=@PatientID")

            cmdDelete.Parameters.AddWithValue("@PatientID", patientID)

            DatabaseHelper.ExecuteNonQuery(cmdDelete)

            MessageBox.Show("تم حذف المريض")

            LoadPatients()

        Catch ex As Exception

            con.Close()

            MessageBox.Show(ex.Message)

        End Try

    End Sub

End Class
