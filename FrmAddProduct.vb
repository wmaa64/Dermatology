Imports System.Data
Imports System.Data.SqlClient
Imports System.Net
Imports System.Reflection


Public Class FrmAddProduct
    Public ProductID As Integer = 0

    Private Sub FrmAddProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadBrands()

        If ProductID > 0 Then

            LoadProduct()

            btnSave.Text = "تحديث البيانات"

        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try

            Dim cmd As SqlCommand

            If ProductID = 0 Then

                cmd = New SqlCommand("INSERT INTO Products
                                        (
                                            ProductCode,
                                            ProductName,
                                            ProductDescription,
                                            BrandID,
                                            IsActive
                                        )
                                        VALUES
                                        (
                                            @ProductCode,
                                            @ProductName,
                                            @ProductDescription,
                                            @BrandID,
                                            @IsActive
                                        )")

            Else

                cmd = New SqlCommand("UPDATE Products
                                        SET

                                        ProductCode=@ProductCode,
                                        ProductName=@ProductName,
                                        ProductDescription=@ProductDescription,
                                        BrandID=@BrandID,
                                        IsActive=@IsActive

                                        WHERE ProductID=@ProductID")

                cmd.Parameters.AddWithValue("@ProductID", ProductID)

            End If

            cmd.Parameters.AddWithValue("@ProductCode", txtProductCode.Text)

            cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text)

            cmd.Parameters.AddWithValue("@ProductDescription", txtProductDescription.Text)

            cmd.Parameters.AddWithValue("@BrandID", cmbBrand.SelectedValue)

            cmd.Parameters.AddWithValue("@IsActive", chkActive.Checked)

            DatabaseHelper.ExecuteNonQuery(cmd)

            MessageBox.Show("تم الحفظ بنجاح")

            Me.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub


    Private Sub LoadProduct()

        Try

            Dim cmd As New SqlCommand("SELECT * FROM Products WHERE ProductID=@ProductID")

            cmd.Parameters.AddWithValue("@ProductID", ProductID)

            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)


            If dt.Rows.Count = 1 Then

                txtProductCode.Text = dt.Rows(0)("ProductCode").ToString()

                txtProductName.Text = dt.Rows(0)("ProductName").ToString()

                txtProductDescription.Text = dt.Rows(0)("ProductDescription").ToString()

                cmbBrand.SelectedValue = dt.Rows(0)("BrandID")

                chkActive.Checked = Convert.ToBoolean(dt.Rows(0)("IsActive"))

            End If

            con.Close()

        Catch ex As Exception

            con.Close()

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub LoadBrands()

        Dim cmd As New SqlCommand("SELECT BrandID, BrandName  FROM Brands  ORDER BY BrandName")

        Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

        cmbBrand.DataSource = dt

        cmbBrand.DisplayMember = "BrandName"

        cmbBrand.ValueMember = "BrandID"

    End Sub

End Class