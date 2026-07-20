Imports System.Data.SqlClient
Imports System.Data

Public Class UC_LaserTypes
    Private Sub UC_LaserTypes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadLaserTypes()

    End Sub

    Private Sub btnAddLaserType_Click(sender As Object, e As EventArgs) Handles btnAddLaserType.Click

        Dim frm As New FrmAddLaserType()

        frm.ShowDialog()

        LoadLaserTypes()

    End Sub

    Private Sub LoadLaserTypes()

        Try

            Dim cmd As New SqlCommand("SELECT
                                            LaserTypeID AS 'الكود',
                                            LaserTypeName AS 'اسم الليزر',
                                            IsActive AS 'فعال',
                                            SortOrder AS 'الترتيب'

                                        FROM LaserTypes

                                        ORDER BY SortOrder,LaserTypeName")

            dgvLaserTypes.DataSource = DatabaseHelper.GetDataTable(cmd)


            '================ Edit Button =================

            If dgvLaserTypes.Columns("Edit") Is Nothing Then

                Dim btnEdit As New DataGridViewButtonColumn()

                btnEdit.Name = "Edit"

                btnEdit.HeaderText = "تعديل"

                btnEdit.Text = "✏️"

                btnEdit.Width = 60

                btnEdit.UseColumnTextForButtonValue = True

                dgvLaserTypes.Columns.Add(btnEdit)

            End If


            '================ Delete Button =================

            If dgvLaserTypes.Columns("Delete") Is Nothing Then

                Dim btnDelete As New DataGridViewButtonColumn()

                btnDelete.Name = "Delete"

                btnDelete.HeaderText = "حذف"

                btnDelete.Text = "🗑"

                btnDelete.Width = 60

                btnDelete.UseColumnTextForButtonValue = True

                dgvLaserTypes.Columns.Add(btnDelete)

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub SearchLaserTypes()

        Try

            Dim cmd As New SqlCommand("SELECT
                                            LaserTypeID AS 'الكود',
                                            LaserTypeName AS 'اسم الليزر',
                                            IsActive AS 'فعال',
                                            SortOrder AS 'الترتيب'

                                        FROM LaserTypes

                                        WHERE

                                            LaserTypeName LIKE @Search
                                            
                                        ORDER BY LaserTypeName")

            cmd.Parameters.AddWithValue("@Search", "%" & txtSearch.Text & "%")

            dgvLaserTypes.DataSource = DatabaseHelper.GetDataTable(cmd)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        SearchLaserTypes()

    End Sub

    Private Sub dgvLaserTypes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLaserTypes.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim LaserTypeID As Integer =
            dgvLaserTypes.Rows(e.RowIndex).Cells("الكود").Value


        '================ Edit =================

        If dgvLaserTypes.Columns(e.ColumnIndex).Name = "Edit" Then

            Dim frm As New FrmAddLaserType()

            frm.LaserTypeID = LaserTypeID

            frm.ShowDialog()

            LoadLaserTypes()

        End If


        '================ Delete =================

        If dgvLaserTypes.Columns(e.ColumnIndex).Name = "Delete" Then

            Dim result As DialogResult =
                MessageBox.Show("هل تريد حذف نوع الليزر؟",
                                "تأكيد",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                DeleteLaserType(LaserTypeID)

            End If

        End If

    End Sub

    Private Sub DeleteLaserType(LaserTypeID As Integer)

        Try

            Dim cmd As New SqlCommand("DELETE FROM LaserTypes WHERE LaserTypeID=@LaserTypeID")

            cmd.Parameters.AddWithValue("@LaserTypeID", LaserTypeID)

            DatabaseHelper.ExecuteNonQuery(cmd)

            MessageBox.Show("تم حذف نوع الليزر")

            LoadLaserTypes()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

End Class
