Imports System.Data.SqlClient

Public Class FrmAddLaserType
    Public LaserTypeID As Integer = 0

    Private Sub FrmAddLaserType_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        chkActive.Checked = True

        If LaserTypeID > 0 Then

            LoadLaserType()

            btnSave.Text = "تحديث البيانات"

        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try

            If txtLaserTypeName.Text.Trim = "" Then

                MessageBox.Show("ادخل اسم نوع الليزر")

                Exit Sub

            End If

            Dim cmd As SqlCommand

            If LaserTypeID = 0 Then

                cmd = New SqlCommand("
                        INSERT INTO LaserTypes
                        (
                            LaserTypeName,
                            SortOrder,
                            IsActive
                        )

                        VALUES
                        (
                            @LaserTypeName,
                            @SortOrder,
                            @IsActive
                        )")

            Else

                cmd = New SqlCommand("
                        UPDATE LaserTypes

                        SET

                            LaserTypeName=@LaserTypeName,

                            SortOrder=@SortOrder,

                            IsActive=@IsActive

                        WHERE LaserTypeID=@LaserTypeID")

                cmd.Parameters.AddWithValue("@LaserTypeID", LaserTypeID)

            End If


            cmd.Parameters.AddWithValue("@LaserTypeName", txtLaserTypeName.Text)

            cmd.Parameters.AddWithValue("@SortOrder", txtSortOrder.Text)

            cmd.Parameters.AddWithValue("@IsActive", chkActive.Checked)


            DatabaseHelper.ExecuteNonQuery(cmd)

            MessageBox.Show("تم حفظ نوع الليزر بنجاح")

            Me.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub


    Private Sub LoadLaserType()

        Try

            Dim cmd As New SqlCommand("SELECT *
                                       FROM LaserTypes
                                       WHERE LaserTypeID=@LaserTypeID")

            cmd.Parameters.AddWithValue("@LaserTypeID", LaserTypeID)

            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

            If dt.Rows.Count = 0 Then Exit Sub

            txtLaserTypeName.Text = dt.Rows(0)("LaserTypeName").ToString()

            txtSortOrder.Text = dt.Rows(0)("sortOrder").ToString()

            chkActive.Checked = CBool(dt.Rows(0)("IsActive"))

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

End Class