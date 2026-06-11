Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Controls

Public Class UC_ProductUnits
    Private Sub UC_ProductUnits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProductUnits()
    End Sub

    Private Sub btnAddProductUnit_Click(sender As Object, e As EventArgs) Handles btnAddProductUnit.Click
        Dim frm As New FrmAddProductUnit()

        frm.ShowDialog()

        LoadProductUnits()
    End Sub

    Private Sub LoadProductUnits()

        Try

            Dim cmd As New SqlCommand("SELECT
                                            PU.ProductUnitID AS 'الكود',
                                            P.ProductName AS 'المنتج',
                                            U.UnitName AS 'الوحدة',
                                            CAST(PU.ConversionFactor AS INT) AS 'المعامل',
                                            CASE
                                                WHEN PU.IsBaseUnit = 1
                                                THEN 'نعم'
                                                ELSE 'لا'
                                            END AS 'الوحدة الأساسية'

                                        FROM ProductUnits PU

                                        INNER JOIN Products P
                                            ON PU.ProductID=P.ProductID

                                        INNER JOIN Units U
                                            ON PU.UnitID=U.UnitID")

            dgvProductUnits.DataSource = DatabaseHelper.GetDataTable(cmd)


            If dgvProductUnits.Columns("Edit") Is Nothing Then

                Dim btnEdit As New DataGridViewButtonColumn()

                btnEdit.Name = "Edit"

                btnEdit.HeaderText = "تعديل"

                btnEdit.Text = "✏️"

                btnEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                btnEdit.Width = 60

                btnEdit.UseColumnTextForButtonValue = True

                dgvProductUnits.Columns.Add(btnEdit)

            End If


            If dgvProductUnits.Columns("Delete") Is Nothing Then

                Dim btnDelete As New DataGridViewButtonColumn()

                btnDelete.Name = "Delete"

                btnDelete.HeaderText = "حذف"

                btnDelete.Text = "🗑"

                btnDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                btnDelete.Width = 60

                btnDelete.UseColumnTextForButtonValue = True

                dgvProductUnits.Columns.Add(btnDelete)

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub SearchProductUnits()

        Try

            Dim cmd As New SqlCommand("SELECT
                                            PU.ProductUnitID AS 'الكود',
                                            P.ProductName AS 'المنتج',
                                            U.UnitName AS 'الوحدة',
                                            PU.ConversionFactor AS 'المعامل'

                                        FROM ProductUnits PU

                                        INNER JOIN Products P
                                            ON PU.ProductID=P.ProductID

                                        INNER JOIN Units U
                                            ON PU.UnitID=U.UnitID

                                        WHERE
                                            P.ProductName LIKE @Search
                                            OR
                                            U.UnitName LIKE @Search")

            cmd.Parameters.AddWithValue("@Search", "%" & txtSearch.Text & "%")

            dgvProductUnits.DataSource = DatabaseHelper.GetDataTable(cmd)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchProductUnits()
    End Sub

    Private Sub dgvProductUnits_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductUnits.CellContentClick

    End Sub

    Private Sub dgvProductUnits_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductUnits.CellDoubleClick

        'Dim frm As New FrmProductUnitProfile()

        'frm.ProductUnitID = dgvProductUnits.CurrentRow.Cells("الكود").Value

        'frm.ShowDialog()

    End Sub

    Private Sub dgvProductUnits_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductUnits.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim ProductUnitID As Integer = dgvProductUnits.Rows(e.RowIndex).Cells("الكود").Value

        ' تعديل

        If dgvProductUnits.Columns(e.ColumnIndex).Name = "Edit" Then

            Dim frm As New FrmAddProductUnit()

            frm.ProductUnitID = ProductUnitID

            frm.ShowDialog()

            LoadProductUnits()

        End If


        ' حذف

        If dgvProductUnits.Columns(e.ColumnIndex).Name = "Delete" Then

            Dim result As DialogResult = MessageBox.Show("هل تريد حذف الوحدة لصنف؟", "تأكيد",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                DeleteProductUnit(ProductUnitID)
            End If

        End If

    End Sub

    Private Sub DeleteProductUnit(productUnitID As Integer)

        Try

            ' التأكد من عدم وجود جلسات

            Dim cmdCheck As New SqlCommand("SELECT COUNT(*) FROM SalesInvoiceDetails WHERE ProductUnitID=@ProductUnitID")

            cmdCheck.Parameters.AddWithValue("@ProductUnitID", productUnitID)

            Dim count As Integer = DatabaseHelper.ExecuteScalar(cmdCheck)

            If count > 0 Then

                MessageBox.Show("لا يمكن حذف وحدة لصنف لوجود فواتير مرتبطة به")

                Exit Sub

            End If


            ' حذف المريض

            Dim cmdDelete As New SqlCommand("DELETE FROM ProductUnits WHERE ProductUnitID=@ProductUnitID")

            cmdDelete.Parameters.AddWithValue("@ProductUnitID", productUnitID)

            DatabaseHelper.ExecuteNonQuery(cmdDelete)

            MessageBox.Show("تم حذف الوحدة لصنف")

            LoadProductUnits()

        Catch ex As Exception

            con.Close()

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class

