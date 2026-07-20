Imports System.Data.SqlClient

Public Class FrmAddNewSession
    Public SessionID As Integer

    Public PatientID As Integer


    Private Sub FrmAddNewSession_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadTreatmentAreas()

        LoadDevices()


        If SessionID > 0 Then

            LoadSessionData()

            btnSave.Text = "تحديث البيانات"

        End If

    End Sub

    Private Sub LoadSessionData()

        Try

            Dim cmd As New SqlCommand("SELECT * FROM LaserSessions WHERE SessionID=@SessionID")

            cmd.Parameters.AddWithValue("@SessionID", SessionID)

            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

            If dt.Rows.Count <> 0 Then

                cbArea.SelectedValue = dt.Rows(0)("AreaID")

                cbDevice.SelectedValue = dt.Rows(0)("DeviceID")

                txtNotes.Text = dt.Rows(0)("Notes").ToString()

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            Dim cmd As SqlCommand

            If SessionID = 0 Then

                cmd = New SqlCommand("INSERT INTO LaserSessions
                                        (   PatientID,
                                            SessionDate,
                                            AreaID,
                                            DeviceID,
                                            Notes,
                                            UserID
                                        )

                                        VALUES
                                        (   @PatientID,
                                            @SessionDate,
                                            @AreaID,
                                            @DeviceID,
                                            @Notes,
                                            @UserID
                                        )")

            Else
                cmd = New SqlCommand("UPDATE LaserSessions 
                                       SET
                                        AreaID=@AreaID,
                                        DeviceID=@DeviceID,
                                        Notes=@Notes
                                     WHERE SessionID=@SessionID")

                cmd.Parameters.AddWithValue("@SesssionID", SessionID)

            End If

            cmd.Parameters.AddWithValue("@PatientID", PatientID)

            cmd.Parameters.AddWithValue("@SessionDate", Date.Today)

            cmd.Parameters.AddWithValue("@AreaID", cbArea.SelectedValue)

            cmd.Parameters.AddWithValue("@DeviceID", cbDevice.SelectedValue)

            cmd.Parameters.AddWithValue("@Notes", txtNotes.Text)

            cmd.Parameters.AddWithValue("@UserID", CurrentUser.UserID)

            DatabaseHelper.ExecuteNonQuery(cmd)

            MessageBox.Show("تم حفظ الجلسة بنجاح")

            Me.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub LoadTreatmentAreas()

        Try

            Dim cmd As New SqlCommand("SELECT
                                            AreaID,
                                            AreaName

                                        FROM TreatmentAreas

                                        WHERE IsActive = 1

                                        ORDER BY AreaName")

            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

            cbArea.DataSource = dt

            cbArea.DisplayMember = "AreaName"

            cbArea.ValueMember = "AreaID"

            cbArea.SelectedIndex = -1

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub LoadDevices()

        Try

            Dim cmd As New SqlCommand("SELECT
                                            DeviceID,
                                            DeviceName
                                        FROM Devices
                                        WHERE IsActive = 1
                                        ORDER BY DeviceName")

            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

            cbDevice.DataSource = dt

            cbDevice.DisplayMember = "DeviceName"

            cbDevice.ValueMember = "DeviceID"

            cbDevice.SelectedIndex = -1

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

End Class