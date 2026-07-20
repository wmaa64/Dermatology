Imports System.Data.SqlClient
Imports System.Data

Public Class UC_Services
    Private Sub UC_Services_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadServices()
    End Sub

    Private Sub btnAddService_Click(sender As Object, e As EventArgs) Handles btnAddService.Click
        Dim frm As New FrmAddService()

        FrmAddService.ShowDialog()

        LoadServices()
    End Sub

    Private Sub LoadServices()

        Try

            Dim cmd As New SqlCommand("SELECT
                                        S.ServiceID AS 'الكود',
                                        C.CategoryName AS 'التصنيف',
                                        S.ServiceName AS 'اسم الخدمة',
                                        S.DefaultPrice AS 'السعر',

                                        Case
                                        WHEN S.IsActive=1 THEN N'نشط'
                                        Else N'غير نشط'
                                        End As 'الحالة'

                                        From Services S

                                        Left Join ServiceCategories C

                                        On S.CategoryID=C.CategoryID

                                        ORDER BY C.CategoryName, S.ServiceName")

            dgvServices.DataSource = DatabaseHelper.GetDataTable(cmd)


            If dgvServices.Columns("Edit") Is Nothing Then

                Dim btnEdit As New DataGridViewButtonColumn()

                btnEdit.Name = "Edit"

                btnEdit.HeaderText = "تعديل"

                btnEdit.Text = "✏️"

                btnEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                btnEdit.Width = 60

                btnEdit.UseColumnTextForButtonValue = True

                dgvServices.Columns.Add(btnEdit)

            End If


            If dgvServices.Columns("Delete") Is Nothing Then

                Dim btnDelete As New DataGridViewButtonColumn()

                btnDelete.Name = "Delete"

                btnDelete.HeaderText = "حذف"

                btnDelete.Text = "🗑"

                btnDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                btnDelete.Width = 60

                btnDelete.UseColumnTextForButtonValue = True

                dgvServices.Columns.Add(btnDelete)

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub SearchServices()

        Try

            Dim cmd As New SqlCommand("SELECT
                                        S.ServiceID AS 'الكود',
                                        C.CategoryName AS 'التصنيف',
                                        S.ServiceName AS 'اسم الخدمة',
                                        S.DefaultPrice AS 'السعر',

                                        Case
                                            WHEN S.IsActive=1 THEN N'نشط'
                                            Else N'غير نشط'
                                        End As 'الحالة'

                                        From Services S

                                        Left Join ServiceCategories C

                                        On S.CategoryID=C.CategoryID

                                        WHERE ServiceName LIKE @Search
                                   
                                        OR  C.CategoryName LIKE @Search
    
                                        ORDER BY ServiceName")

            cmd.Parameters.AddWithValue("@Search", "%" & txtSearch.Text & "%")

            dgvServices.DataSource = DatabaseHelper.GetDataTable(cmd)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchServices()
    End Sub

    Private Sub dgvServices_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServices.CellContentClick

    End Sub


    Private Sub dgvServices_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServices.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim ServiceID As Integer = dgvServices.Rows(e.RowIndex).Cells("الكود").Value

        ' تعديل

        If dgvServices.Columns(e.ColumnIndex).Name = "Edit" Then

            Dim frm As New FrmAddService()

            frm.ServiceID = ServiceID

            frm.ShowDialog()

            LoadServices()

        End If


        ' حذف

        If dgvServices.Columns(e.ColumnIndex).Name = "Delete" Then

            Dim result As DialogResult = MessageBox.Show("هل تريد حذف المريض؟", "تأكيد",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                DeleteService(ServiceID)
            End If

        End If

    End Sub

    Private Sub DeleteService(ServiceID As Integer)

        Try

            ' التأكد من عدم وجود جلسات

            Dim cmdCheck As New SqlCommand("SELECT COUNT(*) FROM LaserSessions WHERE ServiceID=@ServiceID")

            cmdCheck.Parameters.AddWithValue("@ServiceID", ServiceID)

            Dim count As Integer = DatabaseHelper.ExecuteScalar(cmdCheck)

            If count > 0 Then

                MessageBox.Show("لا يمكن حذف المريض لوجود جلسات مرتبطة به")

                Exit Sub

            End If


            ' حذف المريض

            Dim cmdDelete As New SqlCommand("DELETE FROM Services WHERE ServiceID=@ServiceID")

            cmdDelete.Parameters.AddWithValue("@ServiceID", ServiceID)

            DatabaseHelper.ExecuteNonQuery(cmdDelete)

            MessageBox.Show("تم حذف المريض")

            LoadServices()

        Catch ex As Exception

            con.Close()

            MessageBox.Show(ex.Message)

        End Try

    End Sub

End Class

