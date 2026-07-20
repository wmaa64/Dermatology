Imports System.Data.SqlClient

Public Class FrmAddService

    Public ServiceID As Integer = 0

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try

            Dim cmd As SqlCommand

            If txtServiceName.Text.Trim = "" Then

                MessageBox.Show("ادخل اسم الخدمة")

                txtServiceName.Focus()

                Exit Sub

            End If

            If txtDefaultPrice.Text.Trim = "" Then

                MessageBox.Show("ادخل سعر الخدمة")

                txtDefaultPrice.Focus()

                Exit Sub

            End If

            If Not IsNumeric(txtDefaultPrice.Text) Then

                MessageBox.Show("السعر غير صحيح")

                txtDefaultPrice.Focus()

                Exit Sub

            End If

            If ServiceID = 0 Then

                cmd = New SqlCommand("INSERT INTO Services
                                        (
                                            CategoryID,
                                            ServiceName,
                                            DefaultPrice,
                                            IsActive,
                                            Notes
                                        )

                                        VALUES
                                        (
                                            @CategoryID,
                                            @ServiceName,
                                            @DefaultPrice,
                                            @IsActive,
                                            @Notes
                                        )")

            Else

                cmd = New SqlCommand("UPDATE Services
                                      SET
                                            CategoryID=@CategoryID,
                                            ServiceName=@ServiceName,
                                            DefaultPrice=@DefaultPrice,
                                            IsActive=@IsActive,
                                            Notes=@Notes
                                      WHERE ServiceID=@ServiceID")

                cmd.Parameters.AddWithValue("@ServiceID", ServiceID)

            End If

            cmd.Parameters.AddWithValue("@CategoryID", cbCategory.SelectedValue)

            cmd.Parameters.AddWithValue("@ServiceName", txtServiceName.Text.Trim)

            cmd.Parameters.AddWithValue("@DefaultPrice", Convert.ToDecimal(txtDefaultPrice.Text))

            cmd.Parameters.AddWithValue("@IsActive", chkActive.Checked)

            cmd.Parameters.AddWithValue("@Notes", txtNotes.Text.Trim)

            DatabaseHelper.ExecuteNonQuery(cmd)

            MessageBox.Show("تم حفظ الخدمة بنجاح")

            Me.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub FrmAddService_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        chkActive.Checked = True

        LoadCategories()

        If ServiceID > 0 Then

            LoadServiceData()

            btnSave.Text = "تحديث البيانات"

        End If

    End Sub

    Private Sub LoadCategories()

        Dim cmd As New SqlCommand("SELECT CategoryID, CategoryName
                               FROM ServiceCategories
                               WHERE IsActive=1
                               ORDER BY CategoryName")

        Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

        cbCategory.DataSource = dt

        cbCategory.DisplayMember = "CategoryName"

        cbCategory.ValueMember = "CategoryID"

    End Sub
    Private Sub LoadServiceData()

        Try

            Dim cmd As New SqlCommand("SELECT * FROM Services WHERE ServiceID=@ServiceID")

            cmd.Parameters.AddWithValue("@ServiceID", ServiceID)

            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

            If dt.Rows.Count > 0 Then

                cbCategory.SelectedValue = dt.Rows(0)("CategoryID")

                txtServiceName.Text = dt.Rows(0)("ServiceName").ToString()

                txtDefaultPrice.Text = dt.Rows(0)("DefaultPrice").ToString()

                chkActive.Checked = Convert.ToBoolean(dt.Rows(0)("IsActive"))

                txtNotes.Text = dt.Rows(0)("Notes").ToString()

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

End Class