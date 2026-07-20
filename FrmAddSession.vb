Imports System.Data.SqlClient

Public Class FrmAddSession
    Public PatientID As Integer


    Private Sub FrmAddSession_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadTreatmentPlans()

        LoadTreatmentAreas()

        LoadDevices()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            Dim cmd As New SqlCommand("INSERT INTO LaserSessions
                (   PlanID,
                    PatientID,
                    SessionDate,
                    AreaID,
                    DeviceID,
                    SessionPrice,
                    Notes
                )

                VALUES
                (   @PlanID,
                    @PatientID,
                    @SessionDate,
                    @AreaID,
                    @DeviceID,
                    @SessionPrice,
                    @Notes
                )", con)

            cmd.Parameters.AddWithValue("@PlanID", cbTreatmentPlan.SelectedValue)

            cmd.Parameters.AddWithValue("@PatientID", PatientID)

            cmd.Parameters.AddWithValue("@SessionDate", dtSessionDate.Value)

            cmd.Parameters.AddWithValue("@AreaID", cbArea.SelectedValue)

            cmd.Parameters.AddWithValue("@DeviceID", cbDevice.SelectedValue)

            cmd.Parameters.AddWithValue("@SessionPrice", txtPrice.Text)

            cmd.Parameters.AddWithValue("@Notes", txtNotes.Text)

            DatabaseHelper.ExecuteNonQuery(cmd)

            MessageBox.Show("تم حفظ الجلسة")

            Me.Close()

        Catch ex As Exception

            con.Close()

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub LoadTreatmentPlans()

        Try

            Dim cmd As New SqlCommand("SELECT  PlanID, PlanName 
                                        
                                        FROM TreatmentPlans 

                                        WHERE PatientID=@PatientID

                                        AND Status='Active'

                                        ORDER BY StartDate DESC")

            cmd.Parameters.AddWithValue("@PatientID", PatientID)

            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

            cbTreatmentPlan.DataSource = dt

            cbTreatmentPlan.DisplayMember = "PlanName"

            cbTreatmentPlan.ValueMember = "PlanID"

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