Imports System.Data.SqlClient

Public Class FrmProductSearch
    Public SelectedProductID As Integer = 0

    Public SelectedProductName As String = ""

    Private Sub FrmProductSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub

    Private Sub LoadProducts()

        Try

            Dim cmd As New SqlCommand("SELECT
                                            P.ProductID,
                                            P.ProductCode AS 'Code',
                                            P.ProductName AS 'Product Name',
                                            B.BrandName AS 'Brand'

                                        FROM Products P

                                        LEFT JOIN Brands B
                                            ON P.BrandID=B.BrandID

                                        WHERE P.IsActive = 1

                                        ORDER BY P.ProductName")

            dgvProducts.DataSource =
                DatabaseHelper.GetDataTable(cmd)

            dgvProducts.Columns("ProductID").Visible = False

            dgvProducts.Columns("Code").Width = 100

            dgvProducts.Columns("Brand").Width = 150

            dgvProducts.Columns("Product Name").AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill

            dgvProducts.RowHeadersVisible = False

            dgvProducts.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect

            dgvProducts.ReadOnly = True

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub txtSearch_TextChanged(
    sender As Object,
    e As EventArgs) Handles txtSearch.TextChanged

        Dim cmd As New SqlCommand("SELECT
                                    P.ProductID,
                                    P.ProductCode AS 'Code',
                                    P.ProductName AS 'Product Name',
                                    B.BrandName AS 'Brand'

                                 FROM Products P

                                 LEFT JOIN Brands B
                                    ON P.BrandID=B.BrandID

                                 WHERE

                                    P.ProductName LIKE @Search

                                    OR

                                    P.ProductCode LIKE @Search

                                 ORDER BY P.ProductName")

        cmd.Parameters.AddWithValue("@Search", "%" & txtSearch.Text & "%")

        dgvProducts.DataSource = DatabaseHelper.GetDataTable(cmd)

    End Sub

    Private Sub SelectCurrentProduct()

        If dgvProducts.CurrentRow Is Nothing Then Exit Sub

        SelectedProductID =
            Convert.ToInt32(
                dgvProducts.CurrentRow.Cells("ProductID").Value)

        SelectedProductName =
            dgvProducts.CurrentRow.Cells("Product Name").Value.ToString()

        Me.DialogResult = DialogResult.OK

        Me.Close()

    End Sub

    Private Sub dgvProducts_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellDoubleClick

        If e.RowIndex < 0 Then Exit Sub

        SelectCurrentProduct()

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

        SelectCurrentProduct()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

End Class