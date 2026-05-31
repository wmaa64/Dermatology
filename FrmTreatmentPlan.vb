Imports System.Data.SqlClient
Imports System.Data

Public Class FrmTreatmentPlan

    Public PatientID As Integer

    Public PlanID As Integer = 0

    Private Sub FrmTreatmentPlan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPlan()
    End Sub

    Private Sub LoadPlan()

        If PlanID = 0 Then Exit Sub

        Try

            Dim cmd As New SqlCommand("SELECT * FROM TreatmentPlans  WHERE PlanID=@PlanID")

            cmd.Parameters.AddWithValue("@PlanID", PlanID)

            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

            If dt.Rows.Count > 0 Then

                txtPlanName.Text =
                    dt.Rows(0)("PlanName").ToString()

                cbTreatmentArea.Text =
                    dt.Rows(0)("TreatmentArea").ToString()

                numSessions.Value =
                    Convert.ToDecimal(
                    dt.Rows(0)("PlannedSessions"))

                numInterval.Value =
                    Convert.ToDecimal(
                    dt.Rows(0)("SessionIntervalWeeks"))

                cbDevice.Text =
                    dt.Rows(0)("Device").ToString()

                cbStatus.Text =
                    dt.Rows(0)("Status").ToString()

                txtPlanNotes.Text =
                    dt.Rows(0)("Notes").ToString()

                dtStartDate.Value =
                    Convert.ToDateTime(
                    dt.Rows(0)("StartDate"))

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try

            Dim query As String

            If PlanID = 0 Then

                query =
                        "INSERT INTO TreatmentPlans
                        (
                            PatientID,
                            PlanName,
                            TreatmentArea,
                            PlannedSessions,
                            SessionIntervalWeeks,
                            Device,
                            StartDate,
                            Status,
                            Notes
                        )

                        VALUES
                        (
                            @PatientID,
                            @PlanName,
                            @TreatmentArea,
                            @PlannedSessions,
                            @SessionIntervalWeeks,
                            @Device,
                            @StartDate,
                            @Status,
                            @Notes
                        )"

            Else

                query =
                        "UPDATE TreatmentPlans

                         SET

                            PlanName=@PlanName,
                            TreatmentArea=@TreatmentArea,
                            PlannedSessions=@PlannedSessions,
                            SessionIntervalWeeks=@SessionIntervalWeeks,
                            Device=@Device,
                            StartDate=@StartDate,
                            Status=@Status,
                            Notes=@Notes

                         WHERE PlanID=@PlanID"

            End If

            Dim cmd As New SqlCommand(query)

            cmd.Parameters.AddWithValue(
            "@PatientID",
            PatientID)

            cmd.Parameters.AddWithValue(
            "@PlanID",
            PlanID)

            cmd.Parameters.AddWithValue(
            "@PlanName",
            txtPlanName.Text)

            cmd.Parameters.AddWithValue(
            "@TreatmentArea",
            cbTreatmentArea.Text)

            cmd.Parameters.AddWithValue(
            "@PlannedSessions",
            numSessions.Value)

            cmd.Parameters.AddWithValue(
            "@SessionIntervalWeeks",
            numInterval.Value)

            cmd.Parameters.AddWithValue(
            "@Device",
            cbDevice.Text)

            cmd.Parameters.AddWithValue(
            "@StartDate",
            dtStartDate.Value.Date)

            cmd.Parameters.AddWithValue(
            "@Status",
            cbStatus.Text)

            cmd.Parameters.AddWithValue(
            "@Notes",
            txtPlanNotes.Text)

            DatabaseHelper.ExecuteNonQuery(cmd)

            DialogResult = DialogResult.OK

            Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

End Class