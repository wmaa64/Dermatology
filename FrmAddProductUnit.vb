Imports System.Data
Imports System.Data.SqlClient
Imports System.Net
Imports System.Reflection


Public Class FrmAddProductUnit
    Public ProductUnitID As Integer = 0

    Private Sub FrmAddProductUnit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadProducts()

        LoadUnits()

        If ProductUnitID > 0 Then

            LoadProductUnit()

            btnSave.Text = "تحديث البيانات"

        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try

            Dim cmd As SqlCommand

            If ProductUnitID = 0 Then

                cmd = New SqlCommand("INSERT INTO ProductUnits
                                        (
                                            ProductID,
                                            UnitID,
                                            ConversionFactor,
                                            IsBaseUnit
                                        )
                                        VALUES
                                        (
                                            @ProductID,
                                            @UnitID,
                                            @ConversionFactor,
                                            @IsBaseUnit
                                        )")

            Else

                cmd = New SqlCommand("UPDATE ProductUnits
                                     SET
                                        ProductID=@ProductID,
                                        UnitID=@UnitID,
                                        ConversionFactor=@ConversionFactor,
                                        IsBaseUnit=@IsBaseUnit
                                     WHERE ProductUnitID=@ProductUnitID")

                cmd.Parameters.AddWithValue("@ProductUnitID", ProductUnitID)

            End If

            cmd.Parameters.AddWithValue("@ProductID", cmbProduct.SelectedValue)

            cmd.Parameters.AddWithValue("@UnitID", cmbUnit.SelectedValue)

            cmd.Parameters.AddWithValue("@ConversionFactor", txtFactor.Text)

            cmd.Parameters.AddWithValue("@IsBaseUnit", chkBaseUnit.Checked)

            DatabaseHelper.ExecuteNonQuery(cmd)

            MessageBox.Show("تم الحفظ بنجاح")

            Me.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub


    Private Sub LoadProductUnit()

        Try

            Dim cmd As New SqlCommand("SELECT * FROM ProductUnits WHERE ProductUnitID=@ProductUnitID")

            cmd.Parameters.AddWithValue("@ProductUnitID", ProductUnitID)

            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)


            If dt.Rows.Count = 1 Then

                cmbProduct.SelectedValue = dt.Rows(0)("ProductID")

                cmbUnit.SelectedValue = dt.Rows(0)("UnitID")

                txtFactor.Text = dt.Rows(0)("ConversionFactor").ToString()

                chkBaseUnit.Checked = Convert.ToBoolean(dt.Rows(0)("IsBaseUnit"))

            End If

            con.Close()

        Catch ex As Exception

            con.Close()

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub LoadProducts()

        Dim cmd As New SqlCommand("SELECT ProductID, ProductName FROM Products ORDER BY ProductName")

        Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

        cmbProduct.DataSource = dt

        cmbProduct.DisplayMember = "ProductName"

        cmbProduct.ValueMember = "ProductID"

    End Sub

    Private Sub LoadUnits()

        Dim cmd As New SqlCommand("SELECT UnitID, UnitName  FROM Units  ORDER BY UnitName")

        Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

        cmbUnit.DataSource = dt

        cmbUnit.DisplayMember = "UnitName"

        cmbUnit.ValueMember = "UnitID"

    End Sub

End Class