Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports Microsoft.ReportingServices.ReportProcessing.ReportObjectModel
Imports System.IO


Public Class FrmRevenueByDoctor
    Private Sub FrmRevenueByDoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDoctors()

        dtpFrom.Value = Date.Today.AddDays(-30)

        dtpTo.Value = Date.Today

        Me.rvRevenue.RefreshReport()


    End Sub


    Private Sub LoadDoctors()

        Try

            Dim cmd As New SqlCommand("SELECT
                                            UserID,
                                            FullName
                                        FROM Users
                                        WHERE IsActive = 1
                                        AND   RoleID = 2
                                        ORDER BY FullName")

            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

            Dim dr As DataRow = dt.NewRow()

            dr("UserID") = 0

            dr("FullName") = "كل الأطباء"

            dt.Rows.InsertAt(dr, 0)

            cbDoctors.DataSource = dt

            cbDoctors.DisplayMember = "FullName"

            cbDoctors.ValueMember = "UserID"

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub LoadReport()

        Try
            ' SQL
            Dim cmd As New SqlCommand("SELECT
                                                U.FullName AS DoctorName,
                                                P.FileNo,
                                                P.FullName AS PatientName,
                                                LS.SessionID,
                                                CAST(LS.SessionDate AS DATE) AS SessionDate,
                                                ISNULL(S.ServicesNet,0) AS ServicesNet,
                                                ISNULL(PM.TotalPaid,0) AS TotalPaid,
                                                ISNULL(S.ServicesNet,0)-ISNULL(PM.TotalPaid,0) AS Remaining

                                            FROM LaserSessions LS

                                            INNER JOIN Users U
                                                ON LS.UserID=U.UserID

                                            INNER JOIN Patients P
                                                ON LS.PatientID=P.PatientID

                                            LEFT JOIN
                                            (   SELECT
                                                    SessionID,
                                                    SUM(LineTotal) AS ServicesNet

                                                FROM SessionServices

                                                GROUP BY SessionID

                                            ) S
                                            ON LS.SessionID=S.SessionID

                                            LEFT JOIN
                                            (   SELECT
                                                    SessionID,
                                                    SUM(AmountPaid) AS TotalPaid

                                                FROM SessionPayments

                                                GROUP BY SessionID

                                            ) PM
                                            ON LS.SessionID=PM.SessionID

                                            WHERE

                                            CAST(LS.SessionDate AS DATE) BETWEEN @FromDate AND @ToDate")


            If CInt(cbDoctors.SelectedValue) > 0 Then

                cmd.CommandText &= " AND LS.UserID=@UserID"

                cmd.Parameters.AddWithValue("@UserID", cbDoctors.SelectedValue)

            End If

            cmd.CommandText &= " ORDER BY  U.FullName, LS.SessionDate, P.FullName"

            'Parameters
            cmd.Parameters.AddWithValue("@FromDate", dtpFrom.Value.Date)

            cmd.Parameters.AddWithValue("@ToDate", dtpTo.Value.Date)

            'GetDataTable
            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)


            rvRevenue.Reset()

            'تحديد ملف التقرير
            rvRevenue.LocalReport.ReportPath =
                    IO.Path.Combine(AppSettings.ReportsPath, "RevenueByDoctor.rdlc")

            ' ReportDataSource
            rvRevenue.LocalReport.DataSources.Clear()

            Dim rds As New ReportDataSource

            rds.Name = "RevenueByDoctor"

            rds.Value = dt

            rvRevenue.LocalReport.DataSources.Add(rds)
            Dim p As ReportParameter() =
                        {
                            New ReportParameter("FromDate",
                                                dtpFrom.Value.ToString("yyyy/MM/dd")),
                            New ReportParameter("ToDate",
                                                dtpTo.Value.ToString("yyyy/MM/dd"))
                        }

            rvRevenue.LocalReport.SetParameters(p)
            'RefreshReport
            rvRevenue.RefreshReport()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click

        LoadReport()

    End Sub


End Class