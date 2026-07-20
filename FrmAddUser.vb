Imports System.Data
Imports System.Data.SqlClient
Imports System.Net
Imports System.Reflection

Public Class FrmAddUser
    Public UserID As Integer = 0

    Private Sub FrmAddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRoles()

        If UserID > 0 Then

            LoadUserData()

            btnSave.Text = "تحديث البيانات"

        End If

    End Sub

    Private Sub LoadUserData()

        Dim cmd As New SqlCommand("SELECT *
                                    FROM Users
                                    WHERE UserID=@UserID")

        cmd.Parameters.AddWithValue("@UserID", UserID)

        Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

        If dt.Rows.Count = 0 Then Exit Sub

        txtUserName.Text = dt.Rows(0)("UserName").ToString()

        txtFullName.Text = dt.Rows(0)("FullName").ToString()

        cmbRole.SelectedValue = CInt(dt.Rows(0)("RoleID"))

        chkActive.Checked = CBool(dt.Rows(0)("IsActive"))

        txtPassword.Clear()

        txtConfirmPassword.Clear()

    End Sub

    Private Sub LoadRoles()

        Dim cmd As New SqlCommand("SELECT RoleID, RoleName  FROM Roles  ORDER BY RoleName")

        Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

        cmbRole.DataSource = dt

        cmbRole.DisplayMember = "RoleName"

        cmbRole.ValueMember = "RoleID"

        cmbRole.SelectedIndex = -1

    End Sub

    Private Function ValidateData() As Boolean

        If txtUserName.Text.Trim = "" Then

            MessageBox.Show("Enter user name.")

            txtUserName.Focus()

            Return False

        End If

        If txtFullName.Text.Trim = "" Then

            MessageBox.Show("Enter full name.")

            txtFullName.Focus()

            Return False

        End If

        If cmbRole.SelectedIndex = -1 Then

            MessageBox.Show("Select a role.")

            cmbRole.Focus()

            Return False

        End If

        If UserID = 0 Then

            If txtPassword.Text = "" Then

                MessageBox.Show("Enter password.")

                txtPassword.Focus()

                Return False

            End If

        End If

        If txtPassword.Text <> txtConfirmPassword.Text Then

            MessageBox.Show("Passwords do not match.")

            txtConfirmPassword.Focus()

            Return False

        End If

        Return True

    End Function

    Private Function UserNameExists() As Boolean

        Dim cmd As New SqlCommand("SELECT COUNT(*)
                                    FROM Users
                                    WHERE UserName=@UserName
                                      AND UserID<>@UserID")

        cmd.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim)

        cmd.Parameters.AddWithValue("@UserID", UserID)

        Dim Count As Integer =
            Convert.ToInt32(DatabaseHelper.ExecuteScalar(cmd))

        Return Count > 0

    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If Not ValidateData() Then Exit Sub

        If UserNameExists() Then

            MessageBox.Show("User name already exists.")

            txtUserName.Focus()

            Exit Sub

        End If

        Try

            If UserID = 0 Then

                AddUser()

                MessageBox.Show("User added successfully.")

            Else

                UpdateUser()

                MessageBox.Show("User updated successfully.")

            End If

            Me.DialogResult = DialogResult.OK

            Me.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub AddUser()

        Dim cmd As New SqlCommand("INSERT INTO Users
                                    (
                                        UserName,
                                        FullName,
                                        PasswordHash,
                                        RoleID,
                                        IsActive
                                    )
                                    VALUES
                                    (
                                        @UserName,
                                        @FullName,
                                        @PasswordHash,
                                        @RoleID,
                                        @IsActive
                                    )")

        cmd.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim)

        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim)

        cmd.Parameters.AddWithValue("@PasswordHash", PasswordHelper.HashPassword(txtPassword.Text))

        cmd.Parameters.AddWithValue("@RoleID", cmbRole.SelectedValue)

        cmd.Parameters.AddWithValue("@IsActive", chkActive.Checked)

        DatabaseHelper.ExecuteNonQuery(cmd)

    End Sub

    Private Sub UpdateUser()

        Dim SQL As String

        If txtPassword.Text.Trim = "" Then

            SQL = "UPDATE Users
                    SET
                        UserName=@UserName,
                        FullName=@FullName,
                        RoleID=@RoleID,
                        IsActive=@IsActive
                    WHERE UserID=@UserID"

        Else

            SQL = "UPDATE Users
                    SET
                        UserName=@UserName,
                        FullName=@FullName,
                        PasswordHash=@PasswordHash,
                        RoleID=@RoleID,
                        IsActive=@IsActive
                    WHERE UserID=@UserID"

        End If

        Dim cmd As New SqlCommand(SQL)

        cmd.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim)

        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim)

        cmd.Parameters.AddWithValue("@RoleID", cmbRole.SelectedValue)

        cmd.Parameters.AddWithValue("@IsActive", chkActive.Checked)

        cmd.Parameters.AddWithValue("@UserID", UserID)

        If txtPassword.Text.Trim <> "" Then

            cmd.Parameters.AddWithValue("@PasswordHash", PasswordHelper.HashPassword(txtPassword.Text))

        End If

        DatabaseHelper.ExecuteNonQuery(cmd)

    End Sub

End Class