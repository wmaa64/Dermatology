Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms.DataVisualization.Charting

Public Class UC_Dashboard

    Private Sub LoadPatientsCount()

        Dim cmd As New SqlCommand("SELECT COUNT(*) FROM Patients")

        lblPatientsCount.Text = DatabaseHelper.ExecuteScalar(cmd).ToString()

    End Sub

    Private Sub LoadTodaySessions()

        Dim cmd As New SqlCommand("SELECT COUNT(*)  FROM LaserSessions
                                    WHERE CAST(SessionDate AS DATE)=CAST(GETDATE() AS DATE)")

        lblSessionsToday.Text = DatabaseHelper.ExecuteScalar(cmd).ToString()

    End Sub

    Private Sub LoadTodayRevenue()

        Dim cmd As New SqlCommand("SELECT ISNULL(SUM(AmountPaid),0) FROM SessionPayments
                                    WHERE CAST(PaymentDate AS DATE)=CAST(GETDATE() AS DATE)")

        lblRevenueToday.Text = DatabaseHelper.ExecuteScalar(cmd).ToString() & " ج"

    End Sub

    Private Sub LoadTodayAppointments()

        Dim cmd As New SqlCommand("SELECT COUNT(*)  FROM Appointments
                                    WHERE CAST(AppointmentDate AS DATE)=CAST(GETDATE() AS DATE)")

        lblAppointmentsToday.Text = DatabaseHelper.ExecuteScalar(cmd).ToString()

    End Sub


    Private Sub LoadRecentSessions()

        Dim cmd As New SqlCommand("SELECT  TOP 10
                                            LS.SessionID,
                                            P.FullName AS 'المريض',
                                            LS.SessionDate AS 'تاريخ الجلسة',
                                            TA.AreaName AS 'المنطقة',
                                            D.DeviceName AS 'الجهاز',
                                            LS.Notes AS 'ملاحظات',
                                            US.FullName As 'الطبيب'
                                   
                                        FROM LaserSessions LS

                                        INNER JOIN Patients P  
                                        ON LS.PatientID=P.PatientID

                                        LEFT JOIN Devices D
                                               ON LS.DeviceID = D.DeviceID

                                        LEFT JOIN TreatmentAreas TA
                                               ON LS.AreaID = TA.AreaID

                                        LEFT JOIN Users US
                                               ON LS.UserID = US.UserID

                                        ORDER BY LS.SessionDate DESC")

        dgvRecentSessions.DataSource = DatabaseHelper.GetDataTable(cmd)

    End Sub

    Private Sub UC_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadSessionsChart()

        LoadRevenueChart()

        LoadPatientsCount()

        LoadTodaySessions()

        LoadTodayRevenue()

        LoadTodayAppointments()

        LoadRecentSessions()

    End Sub

    Private Sub LoadRevenueChart()

        chartRevenue.Series.Clear()

        chartRevenue.ChartAreas.Clear()

        chartRevenue.ChartAreas.Add(New ChartArea())

        Dim series As New Series()

        series.ChartType = SeriesChartType.Column

        series.Name = "Revenue"

        chartRevenue.Series.Add(series)

        Try

            Dim cmd As New SqlCommand("SELECT  CAST(PaymentDate AS DATE) AS Day, SUM(AmountPaid) AS Total
                                        FROM  SessionPayments
                                        WHERE   CAST(PaymentDate AS DATE)
                                            BETWEEN DATEADD(DAY,-10,CAST(GETDATE() AS DATE))
                                                AND CAST(GETDATE() AS DATE)
                                        GROUP BY CAST(PaymentDate AS DATE)
                                        ORDER BY Day", con)

            con.Open()

            Dim dr As SqlDataReader = cmd.ExecuteReader()


            While dr.Read()

                chartRevenue.Series("Revenue").Points.AddXY(
                    Convert.ToDateTime(dr("Day")).ToShortDateString(),
                                       dr("Total")
                                      )

            End While

            con.Close()

        Catch ex As Exception

            con.Close()

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub LoadSessionsChart()

        chartSessions.Series.Clear()

        chartSessions.ChartAreas.Clear()

        chartSessions.ChartAreas.Add(New ChartArea())

        Dim series As New Series()

        series.ChartType = SeriesChartType.Column

        series.Name = "Sessions"

        chartSessions.Series.Add(series)

        Try

            Dim cmd As New SqlCommand("SELECT CAST(SessionDate AS DATE) AS Day, COUNT(*) AS Total
                                        FROM  LaserSessions
                                        WHERE CAST(SessionDate AS DATE)
                                            BETWEEN DATEADD(DAY,-10,CAST(GETDATE() AS DATE))
                                                AND CAST(GETDATE() AS DATE)
                                        GROUP BY CAST(SessionDate AS DATE)
                                        ORDER BY Day", con)

            con.Open()

            Dim dr As SqlDataReader = cmd.ExecuteReader()

            While dr.Read()

                chartSessions.Series("Sessions").Points.AddXY(
                                    Convert.ToDateTime(dr("Day")).ToShortDateString(),
                                    dr("Total"))

            End While

            con.Close()

        Catch ex As Exception

            con.Close()

            MessageBox.Show(ex.Message)

        End Try

    End Sub
End Class
