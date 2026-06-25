Imports System.Data.SqlClient
Imports System.Data

Public Class UC_Units
    Private Sub UC_Units_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUnits()
    End Sub

    Private Sub btnAddUnit_Click(sender As Object, e As EventArgs) Handles btnAddUnit.Click
        Dim frm As New FrmAddUnit()

        frm.ShowDialog()

        LoadUnits()
    End Sub

    Private Sub LoadUnits()

        Try

            Dim cmd As New SqlCommand("SELECT
                                            UnitID AS 'الكود',
                                            UnitName AS 'اسم الوحدة'
                                        FROM Units

                                        ORDER BY UnitName")

            dgvUnits.DataSource = DatabaseHelper.GetDataTable(cmd)


            If dgvUnits.Columns("Edit") Is Nothing Then

                Dim btnEdit As New DataGridViewButtonColumn()

                btnEdit.Name = "Edit"

                btnEdit.HeaderText = "تعديل"

                btnEdit.Text = "✏️"

                btnEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                btnEdit.Width = 60

                btnEdit.UseColumnTextForButtonValue = True

                dgvUnits.Columns.Add(btnEdit)

            End If


            If dgvUnits.Columns("Delete") Is Nothing Then

                Dim btnDelete As New DataGridViewButtonColumn()

                btnDelete.Name = "Delete"

                btnDelete.HeaderText = "حذف"

                btnDelete.Text = "🗑"

                btnDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                btnDelete.Width = 60

                btnDelete.UseColumnTextForButtonValue = True

                dgvUnits.Columns.Add(btnDelete)

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub SearchUnits()

        Try

            Dim cmd As New SqlCommand("SELECT 
                                            UnitID AS 'الكود',
                                            UnitName AS 'اسم الوحدة'
                                        FROM Units

                                       WHERE
                                        UnitName LIKE @Search")

            cmd.Parameters.AddWithValue("@Search", "%" & txtSearch.Text & "%")

            dgvUnits.DataSource = DatabaseHelper.GetDataTable(cmd)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchUnits()
    End Sub

    Private Sub dgvUnits_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUnits.CellDoubleClick

        'Dim frm As New FrmUnitProfile()

        'frm.UnitID = dgvUnits.CurrentRow.Cells("الكود").Value

        'frm.ShowDialog()

    End Sub

    Private Sub dgvUnits_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUnits.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim UnitID As Integer = dgvUnits.Rows(e.RowIndex).Cells("الكود").Value

        ' تعديل

        If dgvUnits.Columns(e.ColumnIndex).Name = "Edit" Then

            Dim frm As New FrmAddUnit()

            frm.UnitID = UnitID

            frm.ShowDialog()

            LoadUnits()

        End If


        ' حذف

        If dgvUnits.Columns(e.ColumnIndex).Name = "Delete" Then

            Dim result As DialogResult = MessageBox.Show("هل تريد حذف الوحدة؟", "تأكيد",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                DeleteUnit(UnitID)
            End If

        End If

    End Sub

    Private Sub DeleteUnit(unitID As Integer)

        Try

            ' التأكد من عدم وجود جلسات

            Dim cmdCheck As New SqlCommand("SELECT COUNT(*) FROM ProductUnits WHERE UnitID=@UnitID")

            cmdCheck.Parameters.AddWithValue("@UnitID", unitID)

            Dim count As Integer = DatabaseHelper.ExecuteScalar(cmdCheck)

            If count > 0 Then

                MessageBox.Show("لا يمكن حذف الوحدة لوجود أصناف مرتبطة به")

                Exit Sub

            End If


            ' حذف المريض

            Dim cmdDelete As New SqlCommand("DELETE FROM Units WHERE UnitID=@UnitID")

            cmdDelete.Parameters.AddWithValue("@UnitID", unitID)

            DatabaseHelper.ExecuteNonQuery(cmdDelete)

            MessageBox.Show("تم حذف الوحدة")

            LoadUnits()

        Catch ex As Exception

            con.Close()

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class

