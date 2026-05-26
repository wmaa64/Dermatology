Imports System.Data.SqlClient
Imports System.Data

Public Class FrmPatientProfile
    Public PatientID As Integer

    Private Sub FrmPatientProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPatientData()
        LoadSessions()
        LoadSessionsCount()
        LoadFinancialSummary()
    End Sub


    Private Sub LoadPatientData()

        Try

            Dim cmd As New SqlCommand("SELECT * FROM Patients WHERE PatientID=@ID", con)

            cmd.Parameters.AddWithValue("@ID", PatientID)

            con.Open()

            Dim dr As SqlDataReader = cmd.ExecuteReader()

            If dr.Read() Then

                lblName.Text = dr("FullName").ToString()

                lblPhone.Text = dr("Phone").ToString()

                lblAge.Text = dr("Age").ToString()

                lblAddress.Text = dr("Address").ToString()

            End If

            con.Close()

        Catch ex As Exception

            con.Close()

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
                                            SessionDate AS 'تاريخ الجلسة',
                                            Area AS 'المنطقة',
                                            Device AS 'الجهاز',
                                            SessionPrice AS 'السعر',
                                            Notes AS 'ملاحظات'
                                       FROM LaserSessions
                                       WHERE PatientID=@PatientID
                                       ORDER BY SessionDate DESC")

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

            con.Close()

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

            con.Close()

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnAddPayment_Click(sender As Object, e As EventArgs) Handles btnAddPayment.Click
        Dim frm As New FrmAddPayment()

        frm.PatientID = PatientID

        frm.ShowDialog()

        LoadFinancialSummary()
    End Sub
End Class