Imports System.Data
Imports System.Data.SqlClient
Imports System.Net
Imports System.Reflection

Public Class FrmAddUnit
    Public UnitID As Integer = 0

    Private Sub FrmAddUnit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If UnitID > 0 Then

            LoadUnitData()

            btnSave.Text = "تحديث البيانات"

        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim cmd As SqlCommand

            If UnitID = 0 Then

                If txtUnitName.Text = "" Then

                    MessageBox.Show("ادخل اسم الوحدة")

                    Exit Sub

                End If

                cmd = New SqlCommand("INSERT INTO Units (UnitName)
                                        VALUES (@UnitName)")

            Else
                cmd = New SqlCommand("UPDATE Units SET
                                        UnitName=@UnitName
                                     WHERE UnitID=@UnitID")

                cmd.Parameters.AddWithValue("@UnitID", UnitID)

            End If

            cmd.Parameters.AddWithValue("@UnitName", txtUnitName.Text)

            DatabaseHelper.ExecuteNonQuery(cmd)

            MessageBox.Show("تم حفظ الوحدة بنجاح")

            Me.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub


    Private Sub LoadUnitData()

        Try

            Dim cmd As New SqlCommand("SELECT * FROM Units WHERE UnitID=@UnitID")

            cmd.Parameters.AddWithValue("@UnitID", UnitID)

            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)


            If dt.Rows.Count = 1 Then

                txtUnitName.Text = dt.Rows(0)("UnitName").ToString()

            End If

            con.Close()

        Catch ex As Exception

            con.Close()

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub txtUnitName_TextChanged(sender As Object, e As EventArgs) Handles txtUnitName.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class