Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient
Imports System.IO


Public Class FrmInvoicePrint
    Public Property SessionID As Integer

    Private Sub FrmInvoicePrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInvoice()
    End Sub

    Private Sub LoadInvoice()

        Try

            Dim cmd As New SqlCommand("SELECT
                                        LS.SessionID,
                                        CAST(LS.SessionDate AS DATE) AS SessionDate,
                                        P.FullName AS PatientName,
                                        P.NationalID,
                                        P.FileNo,
                                        U.FullName AS DoctorName,
                                        ISNULL(S.ServicesNet,0) AS ServicesNet,
                                        ISNULL(PM.Cash,0)      AS Cash,
                                        ISNULL(PM.Visa,0)      AS Visa,
                                        ISNULL(PM.BankTransfer,0) AS BankTransfer,
                                        ISNULL(PM.InstaPay,0)  AS InstaPay,
                                        ISNULL(PM.VodafoneCash,0) AS VodafoneCash,
                                        ISNULL(PM.TotalPaid,0) AS TotalPaid,
                                        ISNULL(S.ServicesNet,0)-ISNULL(PM.TotalPaid,0) AS Remaining

                                    FROM LaserSessions LS

                                    INNER JOIN Patients P
                                        ON LS.PatientID=P.PatientID

                                    INNER JOIN Users U
                                        ON LS.UserID=U.UserID

                                    LEFT JOIN
                                    (
                                        SELECT
                                            SessionID,
                                            SUM(LineTotal) AS ServicesNet

                                        FROM SessionServices

                                        GROUP BY SessionID

                                    ) S

                                    ON LS.SessionID=S.SessionID

                                    LEFT JOIN
                                    (
                                      SELECT
                                        SessionID,
                                        SUM(CASE WHEN PaymentMethod='Cash' THEN AmountPaid ELSE 0 END) Cash,
                                        SUM(CASE WHEN PaymentMethod='Visa' THEN AmountPaid ELSE 0 END) Visa,
                                        SUM(CASE WHEN PaymentMethod='Bank Transfer' THEN AmountPaid ELSE 0 END) BankTransfer,
                                        SUM(CASE WHEN PaymentMethod='InstaPay' THEN AmountPaid ELSE 0 END)  InstaPay,
                                        SUM(CASE WHEN PaymentMethod='Vodafone Cash' THEN AmountPaid ELSE 0 END) VodafoneCash,
                                        SUM(AmountPaid) AS TotalPaid

                                      FROM SessionPayments

                                      GROUP BY SessionID

                                    ) PM

                                    ON LS.SessionID=PM.SessionID

                                    WHERE

                                    LS.SessionID=@SessionID")

            cmd.Parameters.AddWithValue("@SessionID", SessionID)

            'ريط التقرير
            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)


            rvInvoice.Reset()

            'تحديد ملف التقرير
            rvInvoice.LocalReport.ReportPath =
                IO.Path.Combine(AppSettings.ReportsPath, "Invoice.rdlc")

            rvInvoice.LocalReport.DataSources.Clear()

            Dim rds As New ReportDataSource

            rds.Name = "Invoice"

            rds.Value = dt

            rvInvoice.LocalReport.DataSources.Add(rds)

            rvInvoice.RefreshReport()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

End Class