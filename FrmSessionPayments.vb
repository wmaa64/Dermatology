Imports System.Data.SqlClient

Public Class FrmSessionPayments
    Public SessionID As Integer

    Public PatientID As Integer

    Private ServicesNet As Decimal = 0

    Private CurrentPaymentID As Integer = 0

    Private Sub FrmSessionPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSessionID.Text = SessionID.ToString()

        LoadSessionInfo()

        LoadPayments()
    End Sub

    Private Sub LoadSessionInfo()

        Try

            Dim cmd As New SqlCommand("SELECT

                                            P.FullName,

                                            ISNULL(S.ServicesNet,0) ServicesNet,

                                            ISNULL(PM.TotalPaid,0) TotalPaid

                                        FROM LaserSessions LS

                                        INNER JOIN Patients P

                                        ON LS.PatientID=P.PatientID

                                        LEFT JOIN

                                        (

                                            SELECT

                                                SessionID,

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

                                        LS.SessionID=@SessionID")

            cmd.Parameters.AddWithValue("@SessionID", SessionID)

            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

            If dt.Rows.Count = 0 Then Exit Sub

            txtPatient.Text = dt.Rows(0)("FullName").ToString()

            txtServicesNet.Text = Convert.ToDecimal(dt.Rows(0)("ServicesNet")).ToString("N2")

            txtTotalPaid.Text = Convert.ToDecimal(dt.Rows(0)("TotalPaid")).ToString("N2")

            txtRemaining.Text =
                (
                    Convert.ToDecimal(dt.Rows(0)("ServicesNet")) -
                    Convert.ToDecimal(dt.Rows(0)("TotalPaid"))
                ).ToString("N2")

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub LoadPayments()

        Try

            dgvPayments.Rows.Clear()

            Dim cmd As New SqlCommand("SELECT

                                        SP.SessionPaymentID,

                                        SP.PaymentDate,

                                        SP.AmountPaid,

                                        SP.PaymentMethod,

                                        SP.Notes,

                                        U.FullName AS UserName

                                   FROM SessionPayments SP

                                   INNER JOIN Users U

                                        ON SP.UserID = U.UserID

                                   WHERE SP.SessionID=@SessionID

                                   ORDER BY SP.PaymentDate DESC")

            cmd.Parameters.AddWithValue("@SessionID", SessionID)

            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

            For Each dr As DataRow In dt.Rows

                dgvPayments.Rows.Add(
                                        dr("SessionPaymentID"),
                                        Convert.ToDateTime(dr("PaymentDate")).ToString("yyyy/MM/dd HH:mm"),
                                        dr("AmountPaid"),
                                        dr("PaymentMethod"),
                                        dr("UserName"),
                                        dr("Notes"),
                                        "تعديل",
                                        "حذف"
                                   )

            Next

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try

            If Val(txtAmountPaid.Text) <= 0 Then

                MessageBox.Show("ادخل مبلغ صحيح")

                txtAmountPaid.Focus()

                Exit Sub

            End If

            If CurrentPaymentID = 0 Then

                Dim Remaining As Decimal

                Remaining = Decimal.Parse(txtRemaining.Text)

                Dim Paid As Decimal

                Paid = Decimal.Parse(txtAmountPaid.Text)

                If Paid > Remaining Then

                    MessageBox.Show("المبلغ المدفوع أكبر من المتبقى.")

                    txtAmountPaid.Focus()

                    Exit Sub

                End If

                InsertPayment()

            Else

                UpdatePayment()

            End If

            LoadPayments()

            LoadSessionInfo()

            ClearPayment()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub InsertPayment()

        Dim cmd As New SqlCommand("INSERT INTO SessionPayments
                              (
                                    SessionID,
                                    PatientID,
                                    PaymentDate,
                                    AmountPaid,
                                    PaymentMethod,
                                    Notes,
                                    UserID
                              )
                              VALUES
                              (
                                    @SessionID,
                                    @PatientID,
                                    GETDATE(),
                                    @AmountPaid,
                                    @PaymentMethod,
                                    @Notes,
                                    @UserID
                              )")

        cmd.Parameters.AddWithValue("@SessionID", SessionID)

        cmd.Parameters.AddWithValue("@PatientID", PatientID)

        cmd.Parameters.AddWithValue("@AmountPaid", Val(txtAmountPaid.Text))

        cmd.Parameters.AddWithValue("@PaymentMethod", cbPaymentMethod.Text)

        cmd.Parameters.AddWithValue("@Notes", txtNotes.Text)

        cmd.Parameters.AddWithValue("@UserID", CurrentUser.UserID)

        DatabaseHelper.ExecuteNonQuery(cmd)

    End Sub

    Private Sub UpdatePayment()

        Dim cmd As New SqlCommand("UPDATE SessionPayments
                               SET

                                    AmountPaid=@AmountPaid,

                                    PaymentMethod=@PaymentMethod,

                                    Notes=@Notes

                               WHERE

                                    SessionPaymentID=@SessionPaymentID")

        cmd.Parameters.AddWithValue("@SessionPaymentID", CurrentPaymentID)

        cmd.Parameters.AddWithValue("@AmountPaid", Val(txtAmountPaid.Text))

        cmd.Parameters.AddWithValue("@PaymentMethod", cbPaymentMethod.Text)

        cmd.Parameters.AddWithValue("@Notes", txtNotes.Text)

        DatabaseHelper.ExecuteNonQuery(cmd)

    End Sub

    Private Sub ClearPayment()

        CurrentPaymentID = 0

        txtAmountPaid.Clear()

        txtNotes.Clear()

        cbPaymentMethod.SelectedIndex = -1

        btnSave.Text = "حفظ"

        txtAmountPaid.Focus()

    End Sub

    Private Sub btnNew_Click(sender As Object,
                         e As EventArgs) Handles btnNew.Click

        ClearPayment()

    End Sub

    Private Sub dgvPayments_CellContentClick(sender As Object,
                                         e As DataGridViewCellEventArgs) _
                                         Handles dgvPayments.CellContentClick

        If e.RowIndex < 0 Then Exit Sub

        Select Case dgvPayments.Columns(e.ColumnIndex).Name

            Case "colEdit"

                If CurrentUser.RoleID <> 1 Then

                    MessageBox.Show("ليس لديك صلاحية تعديل المدفوعات.")

                    Exit Sub

                End If

                LoadPaymentForEdit(e.RowIndex)

            Case "colDelete"

                If CurrentUser.RoleID <> 1 Then

                    MessageBox.Show("ليس لديك صلاحية حذف المدفوعات.")

                    Exit Sub

                End If


                DeletePayment(e.RowIndex)

        End Select

    End Sub

    Private Sub LoadPaymentForEdit(RowIndex As Integer)

        CurrentPaymentID =
            CInt(dgvPayments.Rows(RowIndex).Cells("colPaymentID").Value)

        txtAmountPaid.Text =
            dgvPayments.Rows(RowIndex).Cells("colAmountPaid").Value.ToString()

        cbPaymentMethod.Text =
            dgvPayments.Rows(RowIndex).Cells("colPaymentMethod").Value.ToString()

        txtNotes.Text =
            dgvPayments.Rows(RowIndex).Cells("colNotes").Value.ToString()

        txtAmountPaid.Focus()

        btnSave.Text = "تعديل"

    End Sub
    Private Sub DeletePayment(RowIndex As Integer)

        If MessageBox.Show("هل تريد حذف هذه الدفعة؟",
                           "تأكيد",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.No Then Exit Sub

        Dim PaymentID As Integer

        PaymentID =
            CInt(dgvPayments.Rows(RowIndex).Cells("colPaymentID").Value)

        Dim cmd As New SqlCommand("DELETE FROM SessionPayments
                               WHERE SessionPaymentID=@ID")

        cmd.Parameters.AddWithValue("@ID", PaymentID)

        DatabaseHelper.ExecuteNonQuery(cmd)

        LoadPayments()

        LoadSessionInfo()

        ClearPayment()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class