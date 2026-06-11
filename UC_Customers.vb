Imports System.Data.SqlClient
Imports System.Data

Public Class UC_Customers
    Private Sub UC_Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomers()
    End Sub

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        Dim frm As New FrmAddCustomer()

        frm.ShowDialog()

        LoadCustomers()
    End Sub

    Private Sub LoadCustomers()

        Try

            Dim cmd As New SqlCommand("SELECT
                                            CustomerID AS 'الكود',
                                            CustomerName AS 'اسم العميل',
                                            Mobile AS 'الهاتف',
                                            Email AS 'الايميل',
                                            Address AS 'العنوان',
                                            WorkDomain As 'مجال العمل'

                                        FROM Customers

                                        ORDER BY CustomerName")

            dgvCustomers.DataSource = DatabaseHelper.GetDataTable(cmd)


            If dgvCustomers.Columns("Edit") Is Nothing Then

                Dim btnEdit As New DataGridViewButtonColumn()

                btnEdit.Name = "Edit"

                btnEdit.HeaderText = "تعديل"

                btnEdit.Text = "✏️"

                btnEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                btnEdit.Width = 60

                btnEdit.UseColumnTextForButtonValue = True

                dgvCustomers.Columns.Add(btnEdit)

            End If


            If dgvCustomers.Columns("Delete") Is Nothing Then

                Dim btnDelete As New DataGridViewButtonColumn()

                btnDelete.Name = "Delete"

                btnDelete.HeaderText = "حذف"

                btnDelete.Text = "🗑"

                btnDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                btnDelete.Width = 60

                btnDelete.UseColumnTextForButtonValue = True

                dgvCustomers.Columns.Add(btnDelete)

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub SearchCustomers()

        Try

            Dim cmd As New SqlCommand("SELECT 
                                            CustomerID AS 'الكود',
                                            CustomerName AS 'اسم العميل',
                                            Mobile AS 'الهاتف',
                                            Email AS 'الايميل',
                                            Address AS 'العنوان',
                                            WorkDomain As 'مجال العمل'

                                        FROM Customers

                                       WHERE
                                        CustomerName LIKE @Search
                                        Or WorkDomain LIKE @Search
                                        OR Mobile LIKE @Search")

            cmd.Parameters.AddWithValue("@Search", "%" & txtSearch.Text & "%")

            dgvCustomers.DataSource = DatabaseHelper.GetDataTable(cmd)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchCustomers()
    End Sub

    Private Sub dgvCustomers_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomers.CellDoubleClick

        'Dim frm As New FrmCustomerProfile()

        'frm.CustomerID = dgvCustomers.CurrentRow.Cells("الكود").Value

        'frm.ShowDialog()

    End Sub

    Private Sub dgvCustomers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomers.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim CustomerID As Integer = dgvCustomers.Rows(e.RowIndex).Cells("الكود").Value

        ' تعديل

        If dgvCustomers.Columns(e.ColumnIndex).Name = "Edit" Then

            Dim frm As New FrmAddCustomer()

            frm.CustomerID = CustomerID

            frm.ShowDialog()

            LoadCustomers()

        End If


        ' حذف

        If dgvCustomers.Columns(e.ColumnIndex).Name = "Delete" Then

            Dim result As DialogResult = MessageBox.Show("هل تريد حذف العميل؟", "تأكيد",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                DeleteCustomer(CustomerID)
            End If

        End If

    End Sub

    Private Sub DeleteCustomer(customerID As Integer)

        Try

            ' التأكد من عدم وجود جلسات

            Dim cmdCheck As New SqlCommand("SELECT COUNT(*) FROM SalesInvoices WHERE CustomerID=@CustomerID")

            cmdCheck.Parameters.AddWithValue("@CustomerID", customerID)

            Dim count As Integer = DatabaseHelper.ExecuteScalar(cmdCheck)

            If count > 0 Then

                MessageBox.Show("لا يمكن حذف العميل لوجود فواتير مرتبطة به")

                Exit Sub

            End If


            ' حذف عميل

            Dim cmdDelete As New SqlCommand("DELETE FROM Customers WHERE CustomerID=@CustomerID")

            cmdDelete.Parameters.AddWithValue("@CustomerID", customerID)

            DatabaseHelper.ExecuteNonQuery(cmdDelete)

            MessageBox.Show("تم حذف العميل")

            LoadCustomers()

        Catch ex As Exception

            con.Close()

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub dgvCustomers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomers.CellContentClick

    End Sub
End Class
