Imports System.Data.SqlClient
Imports System.Data


Public Class UC_Users
    Private Sub UC_Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers()
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        Dim frm As New FrmAddUser()

        frm.ShowDialog()

        LoadUsers()
    End Sub

    Private Sub LoadUsers()

        Try

            Dim cmd As New SqlCommand("SELECT
                                            U.UserID AS 'الكود',
                                            U.UserName AS 'اسم المستخدم',
                                            U.FullName AS 'الاسم بالكامل',
                                            R.RoleName AS 'الصلاحية',
                                            U.IsActive AS 'نشط'

                                        FROM Users U
                                        INNER JOIN Roles R
                                            ON U.RoleID = R.RoleID

                                        ORDER BY U.UserName")

            dgvUsers.DataSource = DatabaseHelper.GetDataTable(cmd)

            dgvUsers.Columns("الكود").Visible = False

            If dgvUsers.Columns("Edit") Is Nothing Then

                Dim btnEdit As New DataGridViewButtonColumn()

                btnEdit.Name = "Edit"

                btnEdit.HeaderText = "تعديل"

                btnEdit.Text = "✏️"

                btnEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                btnEdit.Width = 60

                btnEdit.UseColumnTextForButtonValue = True

                dgvUsers.Columns.Add(btnEdit)

            End If


            If dgvUsers.Columns("Delete") Is Nothing Then

                Dim btnDelete As New DataGridViewButtonColumn()

                btnDelete.Name = "Delete"

                btnDelete.HeaderText = "حذف"

                btnDelete.Text = "🗑"

                btnDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                btnDelete.Width = 60

                btnDelete.UseColumnTextForButtonValue = True

                dgvUsers.Columns.Add(btnDelete)

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub SearchUsers()

        Try

            Dim cmd As New SqlCommand("SELECT
                                        U.UserID AS 'الكود',
                                        U.UserName AS 'اسم المستخدم',
                                        U.FullName AS 'الاسم بالكامل',
                                        R.RoleName AS 'الصلاحية',
                                        U.IsActive AS 'نشط'

                                    FROM Users U
                                    INNER JOIN Roles R
                                        ON U.RoleID = R.RoleID

                                    WHERE
                                        U.UserName LIKE @Search
                                        OR U.UserFullName LIKE @Search

                                    ORDER BY U.UserName")

            cmd.Parameters.AddWithValue("@Search", "%" & txtSearch.Text.Trim & "%")

            dgvUsers.DataSource = DatabaseHelper.GetDataTable(cmd)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchUsers()
    End Sub

    Private Sub dgvUsers_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellDoubleClick

        'Dim frm As New FrmUserProfile()

        'frm.UserID = dgvUsers.CurrentRow.Cells("الكود").Value

        'frm.ShowDialog()

    End Sub

    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim UserID As Integer = dgvUsers.Rows(e.RowIndex).Cells("الكود").Value

        ' تعديل

        If dgvUsers.Columns(e.ColumnIndex).Name = "Edit" Then

            Dim frm As New FrmAddUser()

            frm.UserID = UserID

            frm.ShowDialog()

            LoadUsers()

        End If


        ' حذف

        If dgvUsers.Columns(e.ColumnIndex).Name = "Delete" Then

            Dim result As DialogResult = MessageBox.Show("هل تريد حذف المستخدم؟", "تأكيد",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                DeleteUser(UserID)
            End If

        End If

    End Sub

    Private Sub DeleteUser(UserID As Integer)

        Try

            ' التأكد من عدم وجود جلسات

            Dim cmdCheck As New SqlCommand("SELECT COUNT(*) FROM SalesInvoices WHERE UserID=@UserID")

            cmdCheck.Parameters.AddWithValue("@UserID", UserID)

            Dim count As Integer = DatabaseHelper.ExecuteScalar(cmdCheck)

            If count > 0 Then

                MessageBox.Show("لا يمكن حذف العميل لوجود فواتير مرتبطة به")

                Exit Sub

            End If


            ' حذف عميل

            Dim cmdDelete As New SqlCommand("DELETE FROM Users WHERE UserID=@UserID")

            cmdDelete.Parameters.AddWithValue("@UserID", UserID)

            DatabaseHelper.ExecuteNonQuery(cmdDelete)

            MessageBox.Show("تم حذف العميل")

            LoadUsers()

        Catch ex As Exception

            con.Close()

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub dgvUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellContentClick

    End Sub

End Class
