Imports System.Data.SqlClient

Public Class FrmAddSession
    Public PatientID As Integer


    Private Sub FrmAddSession_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbArea.Items.Add("الوجه")
        cbArea.Items.Add("الذقن")
        cbArea.Items.Add("البكيني")
        cbArea.Items.Add("اليدين")
        cbArea.Items.Add("الجسم كامل")

        cbDevice.Items.Add("Candela")
        cbDevice.Items.Add("GentleLase")
        cbDevice.Items.Add("Soprano")


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            Dim cmd As New SqlCommand("INSERT INTO LaserSessions
                (
                    PatientID,
                    SessionDate,
                    Area,
                    Device,
                    SessionPrice,
                    Notes
                )

                VALUES
                (
                    @PatientID,
                    @SessionDate,
                    @Area,
                    @Device,
                    @SessionPrice,
                    @Notes
                )", con)

            cmd.Parameters.AddWithValue("@PatientID", PatientID)

            cmd.Parameters.AddWithValue("@SessionDate", dtSessionDate.Value)

            cmd.Parameters.AddWithValue("@Area", cbArea.Text)

            cmd.Parameters.AddWithValue("@Device", cbDevice.Text)

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


End Class