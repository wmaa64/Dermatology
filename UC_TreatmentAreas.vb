Imports System.Data.SqlClient

Public Class UC_TreatmentAreas

    Private Sub UC_TreatmentAreas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadAreas()

    End Sub

    Private Sub btnAddArea_Click(sender As Object, e As EventArgs) Handles btnAddArea.Click

        Dim frm As New FrmAddTreatmentArea

        frm.ShowDialog()

        LoadAreas()

    End Sub

    Private Sub LoadAreas()

        Try

            Dim cmd As New SqlCommand("SELECT
                                            AreaID AS 'الكود',
                                            AreaName AS 'المنطقة',
                                            IsActive AS 'فعال'

                                        FROM TreatmentAreas

                                        ORDER BY AreaName")

            dgvTreatmentAreas.DataSource = DatabaseHelper.GetDataTable(cmd)

            If dgvTreatmentAreas.Columns("Edit") Is Nothing Then

                Dim btn As New DataGridViewButtonColumn

                btn.Name = "Edit"

                btn.HeaderText = "تعديل"

                btn.Text = "✏️"

                btn.UseColumnTextForButtonValue = True

                btn.Width = 60

                dgvTreatmentAreas.Columns.Add(btn)

            End If

            If dgvTreatmentAreas.Columns("Delete") Is Nothing Then

                Dim btn As New DataGridViewButtonColumn

                btn.Name = "Delete"

                btn.HeaderText = "حذف"

                btn.Text = "🗑"

                btn.UseColumnTextForButtonValue = True

                btn.Width = 60

                dgvTreatmentAreas.Columns.Add(btn)

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        SearchAreas()

    End Sub

    Private Sub SearchAreas()

        Try

            Dim cmd As New SqlCommand("SELECT
                                            AreaID AS 'الكود',
                                            AreaName AS 'المنطقة',
                                            IsActive AS 'فعال'

                                        FROM TreatmentAreas

                                        WHERE AreaName LIKE @Search

                                        ORDER BY AreaName")

            cmd.Parameters.AddWithValue("@Search", "%" & txtSearch.Text & "%")

            dgvTreatmentAreas.DataSource = DatabaseHelper.GetDataTable(cmd)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub dgvTreatmentAreas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTreatmentAreas.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim AreaID As Integer =
            CInt(dgvTreatmentAreas.Rows(e.RowIndex).Cells("الكود").Value)

        If dgvTreatmentAreas.Columns(e.ColumnIndex).Name = "Edit" Then

            Dim frm As New FrmAddTreatmentArea

            frm.AreaID = AreaID

            frm.ShowDialog()

            LoadAreas()

        End If

        If dgvTreatmentAreas.Columns(e.ColumnIndex).Name = "Delete" Then

            If MessageBox.Show("هل تريد حذف المنطقة؟",
                               "تأكيد",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) = DialogResult.Yes Then

                DeleteArea(AreaID)

            End If

        End If

    End Sub

    Private Sub DeleteArea(AreaID As Integer)

        Try

            Dim cmd As New SqlCommand("DELETE FROM TreatmentAreas WHERE AreaID=@AreaID")

            cmd.Parameters.AddWithValue("@AreaID", AreaID)

            DatabaseHelper.ExecuteNonQuery(cmd)

            MessageBox.Show("تم حذف المنطقة")

            LoadAreas()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

End Class