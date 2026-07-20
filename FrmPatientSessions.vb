Imports System.Data.SqlClient

Public Class FrmPatientSessions
    Public PatientID As Integer = 0

    Public PatientName As String = ""

    Private Sub FrmPatientSessions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtPatientName.Text = PatientName

        LoadPatientSessions()

    End Sub

    Private Sub LoadPatientSessions()

        Try

            Dim cmd As New SqlCommand("SELECT

                                                LS.SessionID,
                                                
                                                LS.UserID,

                                                U.FullName AS DoctorName,

                                                CONVERT(varchar(10), LS.SessionDate, 111) AS SessionDate ,

                                                ISNULL(S.ServicesTotal,0) AS ServicesTotal,

                                                ISNULL(S.ServicesDiscount,0) AS ServicesDiscount,

                                                ISNULL(S.ServicesNet,0) AS ServicesNet,

                                                ISNULL(PM.TotalPaid,0) AS TotalPaid,

                                                ISNULL(S.ServicesNet,0)-ISNULL(PM.TotalPaid,0) AS Remaining

                                            FROM LaserSessions LS

                                            INNER JOIN Users U
                                                ON LS.UserID=U.UserID

                                            LEFT JOIN
                                            (

                                                SELECT

                                                    SessionID,

                                                    SUM(Qty*UnitPrice) ServicesTotal,

                                                    SUM(Discount) ServicesDiscount,

                                                    SUM(LineTotal) ServicesNet

                                                FROM SessionServices

                                                GROUP BY SessionID

                                            ) S

                                            ON LS.SessionID=S.SessionID

                                            LEFT JOIN
                                            (

                                                SELECT

                                                    SessionID,

                                                    SUM(AmountPaid) TotalPaid

                                                FROM SessionPayments

                                                GROUP BY SessionID

                                            ) PM

                                            ON LS.SessionID=PM.SessionID

                                            WHERE
                                                LS.PatientID = @PatientID

                                            ORDER BY
                                                LS.SessionDate")

            cmd.Parameters.AddWithValue("@PatientID", PatientID)

            dgvSessions.DataSource = DatabaseHelper.GetDataTable(cmd)

            FormatSessionsGrid()

            If dgvSessions.Rows.Count > 0 Then

                dgvSessions.ClearSelection()

                dgvSessions.Rows(0).Selected = True

                dgvSessions.CurrentCell = dgvSessions.Rows(0).Cells(0)

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub FormatSessionsGrid()

        With dgvSessions

            .Columns("UserID").Visible = False

            .Columns("SessionID").HeaderText = "الكود"

            .Columns("DoctorName").HeaderText = "الطبيب"

            .Columns("SessionDate").HeaderText = "التاريخ"

            .Columns("ServicesTotal").HeaderText = "الإجمالى"

            .Columns("ServicesDiscount").HeaderText = "الخصم"

            .Columns("ServicesNet").HeaderText = "الصافى"

            .Columns("TotalPaid").HeaderText = "المدفوع"

            .Columns("Remaining").HeaderText = "المتبقى"

            .Columns("ServicesTotal").DefaultCellStyle.Format = "N2"

            .Columns("ServicesDiscount").DefaultCellStyle.Format = "N2"

            .Columns("ServicesNet").DefaultCellStyle.Format = "N2"

            .Columns("TotalPaid").DefaultCellStyle.Format = "N2"

            .Columns("Remaining").DefaultCellStyle.Format = "N2"

        End With

    End Sub

    Private Sub dgvSessions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSessions.CellContentClick

    End Sub

    Private Sub dgvSessions_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgvSessions.RowPrePaint
        Try
            Dim RemainAmount As Integer = CInt(dgvSessions.Rows(e.RowIndex).Cells("Remaining").Value)

            If RemainAmount > 0 Then

                dgvSessions.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.IndianRed
                dgvSessions.Rows(e.RowIndex).DefaultCellStyle.SelectionBackColor = Color.IndianRed
                dgvSessions.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White

            End If

        Catch ex As Exception

        End Try

    End Sub
End Class