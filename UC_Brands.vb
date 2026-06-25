
Imports System.Data.SqlClient
Imports System.Data

Public Class UC_Brands
    Private Sub UC_Brands_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBrands()
    End Sub

    Private Sub btnAddBrand_Click(sender As Object, e As EventArgs) Handles btnAddBrand.Click
        Dim frm As New FrmAddBrand()

        frm.ShowDialog()

        LoadBrands()
    End Sub

    Private Sub LoadBrands()

        Try

            Dim cmd As New SqlCommand("SELECT
                                            BrandID AS 'الكود',
                                            BrandName AS 'اسم العميل'
                                        FROM Brands

                                        ORDER BY BrandName")

            dgvBrands.DataSource = DatabaseHelper.GetDataTable(cmd)


            If dgvBrands.Columns("Edit") Is Nothing Then

                Dim btnEdit As New DataGridViewButtonColumn()

                btnEdit.Name = "Edit"

                btnEdit.HeaderText = "تعديل"

                btnEdit.Text = "✏️"

                btnEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                btnEdit.Width = 60

                btnEdit.UseColumnTextForButtonValue = True

                dgvBrands.Columns.Add(btnEdit)

            End If


            If dgvBrands.Columns("Delete") Is Nothing Then

                Dim btnDelete As New DataGridViewButtonColumn()

                btnDelete.Name = "Delete"

                btnDelete.HeaderText = "حذف"

                btnDelete.Text = "🗑"

                btnDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                btnDelete.Width = 60

                btnDelete.UseColumnTextForButtonValue = True

                dgvBrands.Columns.Add(btnDelete)

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub SearchBrands()

        Try

            Dim cmd As New SqlCommand("SELECT 
                                            BrandID AS 'الكود',
                                            BrandName AS 'اسم العميل'
                                        FROM Brands

                                       WHERE
                                        BrandName LIKE @Search")

            cmd.Parameters.AddWithValue("@Search", "%" & txtSearch.Text & "%")

            dgvBrands.DataSource = DatabaseHelper.GetDataTable(cmd)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchBrands()
    End Sub

    Private Sub dgvBrands_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBrands.CellContentClick

    End Sub

    Private Sub dgvBrands_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBrands.CellDoubleClick

        'Dim frm As New FrmBrandProfile()

        'frm.BrandID = dgvBrands.CurrentRow.Cells("الكود").Value

        'frm.ShowDialog()

    End Sub

    Private Sub dgvBrands_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBrands.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim BrandID As Integer = dgvBrands.Rows(e.RowIndex).Cells("الكود").Value

        ' تعديل

        If dgvBrands.Columns(e.ColumnIndex).Name = "Edit" Then

            Dim frm As New FrmAddBrand()

            frm.BrandID = BrandID

            frm.ShowDialog()

            LoadBrands()

        End If


        ' حذف

        If dgvBrands.Columns(e.ColumnIndex).Name = "Delete" Then

            Dim result As DialogResult = MessageBox.Show("هل تريد حذف البراند؟", "تأكيد",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                DeleteBrand(BrandID)
            End If

        End If

    End Sub

    Private Sub DeleteBrand(brandID As Integer)

        Try

            ' التأكد من عدم وجود جلسات

            Dim cmdCheck As New SqlCommand("SELECT COUNT(*) FROM Products WHERE BrandID=@BrandID")

            cmdCheck.Parameters.AddWithValue("@BrandID", brandID)

            Dim count As Integer = DatabaseHelper.ExecuteScalar(cmdCheck)

            If count > 0 Then

                MessageBox.Show("لا يمكن حذف البراند لوجود أصناف مرتبطة به")

                Exit Sub

            End If


            ' حذف المريض

            Dim cmdDelete As New SqlCommand("DELETE FROM Brands WHERE BrandID=@BrandID")

            cmdDelete.Parameters.AddWithValue("@BrandID", brandID)

            DatabaseHelper.ExecuteNonQuery(cmdDelete)

            MessageBox.Show("تم حذف البراند")

            LoadBrands()

        Catch ex As Exception

            con.Close()

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
