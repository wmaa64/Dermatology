Imports System.Data.SqlClient
Imports System.Data

Public Class UC_Devices

    Private Sub UC_Devices_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadDevices()

    End Sub

    Private Sub btnAddDevice_Click(sender As Object, e As EventArgs) Handles btnAddDevice.Click

        Dim frm As New FrmAddDevice()

        frm.ShowDialog()

        LoadDevices()

    End Sub

    Private Sub LoadDevices()

        Try

            Dim cmd As New SqlCommand("SELECT
                                            DeviceID AS 'الكود',
                                            DeviceName AS 'اسم الجهاز',
                                            Manufacturer AS 'الشركة المصنعة',
                                            DeviceType AS 'النوع',
                                            IsActive AS 'فعال'

                                        FROM Devices

                                        ORDER BY DeviceName")

            dgvDevices.DataSource = DatabaseHelper.GetDataTable(cmd)


            '================ Edit Button =================

            If dgvDevices.Columns("Edit") Is Nothing Then

                Dim btnEdit As New DataGridViewButtonColumn()

                btnEdit.Name = "Edit"

                btnEdit.HeaderText = "تعديل"

                btnEdit.Text = "✏️"

                btnEdit.Width = 60

                btnEdit.UseColumnTextForButtonValue = True

                dgvDevices.Columns.Add(btnEdit)

            End If


            '================ Delete Button =================

            If dgvDevices.Columns("Delete") Is Nothing Then

                Dim btnDelete As New DataGridViewButtonColumn()

                btnDelete.Name = "Delete"

                btnDelete.HeaderText = "حذف"

                btnDelete.Text = "🗑"

                btnDelete.Width = 60

                btnDelete.UseColumnTextForButtonValue = True

                dgvDevices.Columns.Add(btnDelete)

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub SearchDevices()

        Try

            Dim cmd As New SqlCommand("SELECT
                                            DeviceID AS 'الكود',
                                            DeviceName AS 'اسم الجهاز',
                                            Manufacturer AS 'الشركة المصنعة',
                                            DeviceType AS 'النوع',
                                            IsActive AS 'فعال'

                                        FROM Devices

                                        WHERE

                                            DeviceName LIKE @Search
                                            OR Manufacturer LIKE @Search
                                            OR DeviceType LIKE @Search

                                        ORDER BY DeviceName")

            cmd.Parameters.AddWithValue("@Search", "%" & txtSearch.Text & "%")

            dgvDevices.DataSource = DatabaseHelper.GetDataTable(cmd)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        SearchDevices()

    End Sub

    Private Sub dgvDevices_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDevices.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim DeviceID As Integer =
            dgvDevices.Rows(e.RowIndex).Cells("الكود").Value


        '================ Edit =================

        If dgvDevices.Columns(e.ColumnIndex).Name = "Edit" Then

            Dim frm As New FrmAddDevice()

            frm.DeviceID = DeviceID

            frm.ShowDialog()

            LoadDevices()

        End If


        '================ Delete =================

        If dgvDevices.Columns(e.ColumnIndex).Name = "Delete" Then

            Dim result As DialogResult =
                MessageBox.Show("هل تريد حذف الجهاز؟",
                                "تأكيد",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                DeleteDevice(DeviceID)

            End If

        End If

    End Sub

    Private Sub DeleteDevice(DeviceID As Integer)

        Try

            Dim cmd As New SqlCommand("DELETE FROM Devices WHERE DeviceID=@DeviceID")

            cmd.Parameters.AddWithValue("@DeviceID", DeviceID)

            DatabaseHelper.ExecuteNonQuery(cmd)

            MessageBox.Show("تم حذف الجهاز")

            LoadDevices()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

End Class