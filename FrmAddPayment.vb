Imports System.Data.SqlClient

Public Class FrmAddPayment
    Public PatientID As Integer

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try

            Dim cmd As New SqlCommand("INSERT INTO Payments
                (
                    PatientID,
                    PaymentDate,
                    AmountPaid,
                    Notes
                )

                VALUES
                (
                    @PatientID,
                    GETDATE(),
                    @AmountPaid,
                    @Notes
                )", con)

            cmd.Parameters.AddWithValue("@PatientID", PatientID)
            cmd.Parameters.AddWithValue("@AmountPaid", txtAmount.Text)
            cmd.Parameters.AddWithValue("@Notes", txtNotes.Text)

            DatabaseHelper.ExecuteNonQuery(cmd)

            MessageBox.Show("تم تسجيل الدفعة")

            Me.Close()

        Catch ex As Exception

            con.Close()

            MessageBox.Show(ex.Message)

        End Try

    End Sub


End Class