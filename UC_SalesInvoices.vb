Imports System.Data.SqlClient

Public Class UC_SalesInvoices
    Private Sub UC_SalesInvoices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()

        Try

            Dim cmd As New SqlCommand("SELECT
                                            InvoiceID AS 'الكود',
                                            InvoiceNo AS 'رقم الفاتورة',
                                            InvoiceDate AS 'التاريخ',
                                            CustomerName AS 'العميل',
                                            GrandTotal AS 'الإجمالي'

                                        FROM SalesInvoices SI

                                        INNER JOIN Customers C
                                            ON SI.CustomerID = C.CustomerID

                                        ORDER BY InvoiceID DESC")

            dgvSalesInvoices.DataSource = DatabaseHelper.GetDataTable(cmd)

            If dgvSalesInvoices.Columns("Edit") Is Nothing Then

                Dim btnEdit As New DataGridViewButtonColumn()

                btnEdit.Name = "Edit"

                btnEdit.HeaderText = "تعديل"

                btnEdit.Text = "✏️"

                btnEdit.Width = 60

                btnEdit.UseColumnTextForButtonValue = True

                dgvSalesInvoices.Columns.Add(btnEdit)

            End If


            If dgvSalesInvoices.Columns("Delete") Is Nothing Then

                Dim btnDelete As New DataGridViewButtonColumn()

                btnDelete.Name = "Delete"

                btnDelete.HeaderText = "حذف"

                btnDelete.Text = "🗑"

                btnDelete.Width = 60

                btnDelete.UseColumnTextForButtonValue = True

                dgvSalesInvoices.Columns.Add(btnDelete)

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnAddInvoice_Click(sender As Object, e As EventArgs) Handles btnAddInvoice.Click

        Dim frm As New FrmAddSalesInvoice()

        frm.ShowDialog()

        LoadData()

    End Sub


    Private Sub SearchInvoices()

        Try

            Dim cmd As New SqlCommand("SELECT
                                            InvoiceID AS 'الكود',
                                            InvoiceNo AS 'رقم الفاتورة',
                                            InvoiceDate AS 'التاريخ',
                                            CustomerName AS 'العميل',
                                            GrandTotal AS 'الإجمالي'

                                        FROM SalesInvoices SI

                                        INNER JOIN Customers C
                                            ON SI.CustomerID = C.CustomerID

                                        WHERE
                                            InvoiceNo LIKE @Search
                                            OR CustomerName LIKE @Search

                                        ORDER BY InvoiceID DESC")

            cmd.Parameters.AddWithValue("@Search", "%" & txtSearch.Text & "%")

            dgvSalesInvoices.DataSource = DatabaseHelper.GetDataTable(cmd)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchInvoices()
    End Sub


    Private Sub dgvSalesInvoices_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSalesInvoices.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim InvoiceID As Integer = dgvSalesInvoices.Rows(e.RowIndex).Cells("الكود").Value

        ' تعديل

        If dgvSalesInvoices.Columns(e.ColumnIndex).Name = "Edit" Then

            Dim frm As New FrmAddSalesInvoice()

            frm.InvoiceID = InvoiceID

            frm.ShowDialog()

            LoadData()

        End If

        ' حذف

        If dgvSalesInvoices.Columns(e.ColumnIndex).Name = "Delete" Then

            Dim result As DialogResult = MessageBox.Show("هل تريد حذف الفاتورة ؟", "تأكيد",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                'DeleteInvoice(InvoiceID)

            End If

        End If

    End Sub

End Class
