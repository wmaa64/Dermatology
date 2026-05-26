Imports System.Data.SqlClient
Imports System.Data

Public Class FrmAddAppointment
    Public AppointmentID As Integer = 0

    Private Sub FrmAddAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPatients()

        cbStatus.Items.Add("Pending")
        cbStatus.Items.Add("Confirmed")
        cbStatus.Items.Add("Done")
        cbStatus.Items.Add("Cancelled")
        cbStatus.SelectedIndex = 0

        If AppointmentID <> 0 Then

            LoadAppointmentData()

        End If

    End Sub

    Private Sub LoadPatients()

        Dim cmd As New SqlCommand("SELECT PatientID, FullName  FROM Patients")

        Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

        cbPatients.DataSource = dt

        cbPatients.DisplayMember = "FullName"

        cbPatients.ValueMember = "PatientID"

    End Sub

    Private Sub LoadAppointmentData()

        Try

            Dim cmd As New SqlCommand("SELECT * FROM Appointments WHERE AppointmentID=@AppointmentID")

            cmd.Parameters.AddWithValue("@AppointmentID", AppointmentID)

            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

            If dt.Rows.Count > 0 Then

                cbPatients.SelectedValue = dt.Rows(0)("PatientID")

                dtDate.Value = Convert.ToDateTime(dt.Rows(0)("AppointmentDate"))

                dtTime.Value = Date.Today.Add(CType(dt.Rows(0)("AppointmentTime"), TimeSpan))

                cbStatus.Text = dt.Rows(0)("Status").ToString()

                txtNotes.Text = dt.Rows(0)("Notes").ToString()

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim query As String = ""

        If AppointmentID = 0 Then

            query =
                    "INSERT INTO Appointments
                    (
                        PatientID,
                        AppointmentDate,
                        AppointmentTime,
                        Status,
                        Notes
                    )

                    VALUES
                    (
                        @PatientID,
                        @AppointmentDate,
                        @AppointmentTime,
                        @Status,
                        @Notes
                    )"

        Else

            query =
                    "UPDATE Appointments

                     SET

                        PatientID=@PatientID,

                        AppointmentDate=@AppointmentDate,

                        AppointmentTime=@AppointmentTime,

                        Status=@Status,

                        Notes=@Notes

                     WHERE AppointmentID=@AppointmentID"

        End If

        Try

            Dim cmd As New SqlCommand(query)

            cmd.Parameters.AddWithValue("@PatientID", cbPatients.SelectedValue)

            cmd.Parameters.AddWithValue("@AppointmentDate", dtDate.Value.Date)

            cmd.Parameters.AddWithValue("@AppointmentTime", dtTime.Value.TimeOfDay)

            cmd.Parameters.AddWithValue("@Status", cbStatus.Text)

            cmd.Parameters.AddWithValue("@Notes", txtNotes.Text)

            If AppointmentID <> 0 Then

                cmd.Parameters.AddWithValue("@AppointmentID", AppointmentID)

            End If

            DatabaseHelper.ExecuteNonQuery(cmd)

            MessageBox.Show("تم حفظ الحجز")

            Me.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

End Class