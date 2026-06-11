Imports System.Data
Imports System.Data.SqlClient
Imports System.Net
Imports System.Reflection
Public Class FrmAddBrand
    Public BrandID As Integer = 0

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim cmd As SqlCommand

            If BrandID = 0 Then

                If txtBrandName.Text = "" Then

                    MessageBox.Show("ادخل اسم البراند")

                    Exit Sub

                End If

                cmd = New SqlCommand("INSERT INTO Brands (BrandName)
                                        VALUES (@BrandName)")

            Else
                cmd = New SqlCommand("UPDATE Brands SET
                                        BrandName=@BrandName
                                     WHERE BrandID=@BrandID")

                cmd.Parameters.AddWithValue("@BrandID", BrandID)

            End If

            cmd.Parameters.AddWithValue("@BrandName", txtBrandName.Text)

            DatabaseHelper.ExecuteNonQuery(cmd)

            MessageBox.Show("تم حفظ البراند بنجاح")

            Me.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub FrmAddBrand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If BrandID > 0 Then

            LoadBrandData()

            btnSave.Text = "تحديث البيانات"

        End If
    End Sub

    Private Sub LoadBrandData()

        Try

            Dim cmd As New SqlCommand("SELECT * FROM Brands WHERE BrandID=@BrandID")

            cmd.Parameters.AddWithValue("@BrandID", BrandID)

            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)


            If dt.Rows.Count = 1 Then

                txtBrandName.Text = dt.Rows(0)("BrandName").ToString()

            End If

            con.Close()

        Catch ex As Exception

            con.Close()

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub txtBrandName_TextChanged(sender As Object, e As EventArgs) Handles txtBrandName.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class