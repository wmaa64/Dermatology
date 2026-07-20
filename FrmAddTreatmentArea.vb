Imports System.Data.SqlClient

Public Class FrmAddTreatmentArea

    Public AreaID As Integer = 0

    Private Sub FrmAddTreatmentArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        chkActive.Checked = True

        If AreaID > 0 Then

            LoadArea()

            btnSave.Text = "تحديث البيانات"

        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try

            If txtAreaName.Text.Trim = "" Then

                MessageBox.Show("برجاء إدخال اسم المنطقة العلاجية")

                txtAreaName.Focus()

                Exit Sub

            End If

            Dim cmd As SqlCommand

            If AreaID = 0 Then

                cmd = New SqlCommand("INSERT INTO TreatmentAreas
                                      (
                                            AreaName,
                                            IsActive
                                      )

                                      VALUES
                                      (
                                            @AreaName,
                                            @IsActive
                                      )")

            Else

                cmd = New SqlCommand("UPDATE TreatmentAreas

                                      SET

                                            AreaName=@AreaName,

                                            IsActive=@IsActive

                                      WHERE AreaID=@AreaID")

                cmd.Parameters.AddWithValue("@AreaID", AreaID)

            End If

            cmd.Parameters.AddWithValue("@AreaName", txtAreaName.Text.Trim)

            cmd.Parameters.AddWithValue("@IsActive", chkActive.Checked)

            DatabaseHelper.ExecuteNonQuery(cmd)

            MessageBox.Show("تم حفظ المنطقة العلاجية بنجاح")

            Me.DialogResult = DialogResult.OK

            Me.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub LoadArea()

        Try

            Dim cmd As New SqlCommand("SELECT *

                                       FROM TreatmentAreas

                                       WHERE AreaID=@AreaID")

            cmd.Parameters.AddWithValue("@AreaID", AreaID)

            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

            If dt.Rows.Count = 0 Then Exit Sub

            txtAreaName.Text = dt.Rows(0)("AreaName").ToString()

            chkActive.Checked = CBool(dt.Rows(0)("IsActive"))

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

End Class