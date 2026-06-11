Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms.DataVisualization.Charting

Public Class UC_Dashboard

    Private Sub LoadCustomersCount()

        Dim cmd As New SqlCommand("SELECT COUNT(*) FROM Customers")

        lblCustomersCount.Text = DatabaseHelper.ExecuteScalar(cmd)

    End Sub

    Private Sub LoadTodaySessions()

        Dim cmd As New SqlCommand("SELECT COUNT(*)  FROM LaserSessions
                                    WHERE CAST(SessionDate AS DATE)=CAST(GETDATE() AS DATE)", con)

        con.Open()

        lblSessionsToday.Text = cmd.ExecuteScalar().ToString()

        con.Close()

    End Sub

    Private Sub LoadTodayRevenue()

        Dim cmd As New SqlCommand("SELECT ISNULL(SUM(AmountPaid),0) FROM Payments
                                    WHERE CAST(PaymentDate AS DATE)=CAST(GETDATE() AS DATE)", con)

        con.Open()

        lblRevenueToday.Text = cmd.ExecuteScalar().ToString() & " ج"

        con.Close()

    End Sub

    Private Sub LoadRecentSessions()

        Dim cmd As New SqlCommand("SELECT TOP 10
                            P.FullName AS 'المريض',
                            L.Area AS 'المنطقة',
                            L.SessionDate AS 'التاريخ',
                            L.SessionPrice AS 'السعر'
                            FROM LaserSessions L
                            INNER JOIN Patients P  ON L.PatientID=P.PatientID
                            ORDER BY L.SessionDate DESC")

        dgvRecentSessions.DataSource = DatabaseHelper.GetDataTable(cmd)

    End Sub

    Private Sub UC_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'flpCards.BringToFront()
        'pnlCharts.Top = flpCards.Bottom + 10

        'LoadSessionsChart()

        'LoadRevenueChart()

        LoadCustomersCount()

        'LoadTodaySessions()

        'LoadTodayRevenue()

        'LoadRecentSessions()

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
                                        FROM Payments
                                        GROUP BY CAST(PaymentDate AS DATE)
                                        ORDER BY Day", con)

            con.Open()

            Dim dr As SqlDataReader = cmd.ExecuteReader()

            While dr.Read()

                chartRevenue.Series("Revenue").Points.AddXY(Convert.ToDateTime(dr("Day")).ToShortDateString(),
                dr("Total"))

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
                                        FROM LaserSessions
                                        GROUP BY CAST(SessionDate AS DATE)
                                        ORDER BY Day", con)

            con.Open()

            Dim dr As SqlDataReader = cmd.ExecuteReader()

            While dr.Read()

                chartSessions.Series("Sessions").Points.AddXY(Convert.ToDateTime(dr("Day")).ToShortDateString(),
                dr("Total"))

            End While

            con.Close()

        Catch ex As Exception

            con.Close()

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub flpCards_Paint(sender As Object, e As PaintEventArgs) Handles flpCards.Paint

    End Sub
End Class
