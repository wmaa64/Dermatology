Imports System.Data.SqlClient

Public Class FrmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AppSettings.Load()

        'MessageBox.Show(AppSettings.ClinicName)


    End Sub

    Private Function LoginUser() As Boolean

        Dim cmd = New  SqlCommand ("SELECT 
                                            UserID,
                                            UserName,
                                            FullName,
                                            PasswordHash,
                                            RoleID,
                                            IsActive
                                     FROM Users
                                     WHERE UserName=@UserName")
        
        cmd.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim)

        Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

        If dt.Rows.Count = 0 Then

            MessageBox.Show("Invalid user name.")

            Return False

        End If

        Dim Row As DataRow = dt.Rows(0)

        If Not Convert.ToBoolean(Row("IsActive")) Then

            MessageBox.Show("This user is inactive.")

            Return False

        End If

        Dim EnteredHash As String =
            PasswordHelper.HashPassword(txtPassword.Text)

        If EnteredHash <> Row("PasswordHash").ToString() Then

            MessageBox.Show("Invalid password.")

            Return False

        End If

        CurrentUser.UserID = CInt(Row("UserID"))
        CurrentUser.UserName = Row("UserName").ToString()
        CurrentUser.FullName = Row("FullName").ToString()
        CurrentUser.RoleID = CInt(Row("RoleID"))

        Return True

    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If LoginUser() Then

            Dim frm As New FormMain

            Me.Hide()

            frm.lbFullName.Text = CurrentUser.FullName

            frm.Show()

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub
End Class