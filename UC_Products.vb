Imports System.Data.SqlClient
Imports System.Data

Public Class UC_Products
    Private Sub UC_Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Dim frm As New FrmAddProduct()

        frm.ShowDialog()

        LoadProducts()
    End Sub

    Private Sub LoadProducts()

        Try

            Dim cmd As New SqlCommand("SELECT
                                        P.ProductID AS 'الكود',
                                        P.ProductCode AS 'كود المنتج',
                                        P.ProductName AS 'اسم المنتج',
                                        P.ProductDescription AS 'الوصف',
                                        B.BrandName AS 'البراند',

                                        CASE
                                            WHEN P.IsActive = 1
                                            THEN 'نشط'
                                            ELSE 'موقوف'
                                        END AS 'الحالة'

                                        FROM Products P

                                        LEFT JOIN Brands B
                                        ON P.BrandID=B.BrandID")

            dgvProducts.DataSource = DatabaseHelper.GetDataTable(cmd)

            dgvProducts.Columns("الكود").Width = 50

            dgvProducts.Columns("كود المنتج").Width = 50

            dgvProducts.Columns("اسم المنتج").Width = 200

            dgvProducts.Columns("البراند").Width = 60

            dgvProducts.Columns("الحالة").Width = 50

            If dgvProducts.Columns("Edit") Is Nothing Then

                Dim btnEdit As New DataGridViewButtonColumn()

                btnEdit.Name = "Edit"

                btnEdit.HeaderText = "تعديل"

                btnEdit.Text = "✏️"

                btnEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                btnEdit.Width = 60

                btnEdit.UseColumnTextForButtonValue = True

                dgvProducts.Columns.Add(btnEdit)

            End If


            If dgvProducts.Columns("Delete") Is Nothing Then

                Dim btnDelete As New DataGridViewButtonColumn()

                btnDelete.Name = "Delete"

                btnDelete.HeaderText = "حذف"

                btnDelete.Text = "🗑"

                btnDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                btnDelete.Width = 60

                btnDelete.UseColumnTextForButtonValue = True

                dgvProducts.Columns.Add(btnDelete)

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub SearchProducts()

        Try

            Dim cmd As New SqlCommand("SELECT
                                            P.ProductID AS 'الكود',
                                            P.ProductCode AS 'كود المنتج',
                                            P.ProductName AS 'اسم المنتج',
                                            P.ProductDescription AS 'الوصف',
                                            B.BrandName AS 'البراند',

                                            CASE
                                                WHEN P.IsActive = 1
                                                THEN 'نشط'
                                                ELSE 'موقوف'
                                            END AS 'الحالة'

                                            FROM Products P

                                            LEFT JOIN Brands B
                                            ON P.BrandID=B.BrandID
                                        WHERE
                                            P.ProductName LIKE @Search
                                            OR
                                            P.ProductDescription LIKE @Search
                                            OR
                                            P.ProductCode LIKE @Search")

            cmd.Parameters.AddWithValue("@Search", "%" & txtSearch.Text & "%")

            dgvProducts.DataSource = DatabaseHelper.GetDataTable(cmd)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchProducts()
    End Sub

    Private Sub dgvProducts_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellDoubleClick

        'Dim frm As New FrmProductUnitProfile()

        'frm.ProductUnitID = dgvProductUnits.CurrentRow.Cells("الكود").Value

        'frm.ShowDialog()

    End Sub

    Private Sub dgvProducts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim ProductID As Integer = dgvProducts.Rows(e.RowIndex).Cells("الكود").Value

        ' تعديل

        If dgvProducts.Columns(e.ColumnIndex).Name = "Edit" Then

            Dim frm As New FrmAddProduct()

            frm.ProductID = ProductID

            frm.ShowDialog()

            LoadProducts()

        End If


        ' حذف

        If dgvProducts.Columns(e.ColumnIndex).Name = "Delete" Then

            Dim result As DialogResult = MessageBox.Show("هل تريد حذف صنف؟", "تأكيد",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                DeleteProduct(ProductID)
            End If

        End If

    End Sub

    Private Sub DeleteProduct(productID As Integer)

        Try

            ' التأكد من عدم وجود فواتير فيها هذا الصنف

            Dim cmdCheck As New SqlCommand("SELECT COUNT(*) FROM SalesInvoiceDetails WHERE ProductID=@ProductID")

            cmdCheck.Parameters.AddWithValue("@ProductID", productID)

            Dim count As Integer = DatabaseHelper.ExecuteScalar(cmdCheck)

            If count > 0 Then

                MessageBox.Show("لا يمكن حذف صنف لوجود فواتير مرتبطة به")

                Exit Sub

            End If


            ' حذف صنف

            Dim cmdDelete As New SqlCommand("DELETE FROM Products WHERE ProductID=@ProductID")

            cmdDelete.Parameters.AddWithValue("@ProductID", productID)

            DatabaseHelper.ExecuteNonQuery(cmdDelete)

            MessageBox.Show("تم حذف صنف")

            LoadProducts()

        Catch ex As Exception

            con.Close()

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub dgvProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellContentClick

    End Sub
End Class

