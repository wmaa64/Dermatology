Imports System.Data.SqlClient

Public Class FrmSelectServices
    Public SelectedServices As New DataTable

    Private Sub FrmSelectServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadServices()

        SelectedServices.Columns.Add("ServiceID", GetType(Integer))
        SelectedServices.Columns.Add("ServiceName", GetType(String))
        SelectedServices.Columns.Add("UnitPrice", GetType(Decimal))

    End Sub

    Private Sub LoadServices()

        Try

            Dim cmd As New SqlCommand("SELECT
                                        S.ServiceID,
                                        C.CategoryName,
                                        S.ServiceName,
                                        S.DefaultPrice

                                   FROM Services S

                                   LEFT JOIN ServiceCategories C

                                        ON S.CategoryID=C.CategoryID

                                   WHERE S.IsActive=1

                                   ORDER BY

                                        C.CategoryName, S.ServiceName")

            dgvServices.DataSource = DatabaseHelper.GetDataTable(cmd)

            FormatGrid()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub


    Private Sub FormatGrid()

        With dgvServices

            .Columns("ServiceID").HeaderText = "الكود"

            .Columns("CategoryName").HeaderText = "التصنيف"

            .Columns("ServiceName").HeaderText = "الخدمة"

            .Columns("DefaultPrice").HeaderText = "السعر"

            .Columns("DefaultPrice").DefaultCellStyle.Format = "N2"

        End With

        If dgvServices.Columns.Contains("Select") = False Then

            Dim chk As New DataGridViewCheckBoxColumn

            chk.Name = "Select"

            chk.HeaderText = ""

            chk.Width = 40

            chk.ReadOnly = False

            dgvServices.Columns.Insert(0, chk)

        End If

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        Try

            Dim cmd As New SqlCommand("SELECT
                                        S.ServiceID,
                                        C.CategoryName,
                                        S.ServiceName,
                                        S.DefaultPrice

                                   FROM Services S

                                   LEFT JOIN ServiceCategories C

                                   ON S.CategoryID=C.CategoryID

                                   WHERE

                                        S.IsActive=1

                                        AND

                                        (

                                            S.ServiceName LIKE @Search

                                            OR

                                            C.CategoryName LIKE @Search

                                        )

                                   ORDER BY

                                        C.CategoryName, S.ServiceName")

            cmd.Parameters.AddWithValue("@Search", "%" & txtSearch.Text.Trim & "%")

            dgvServices.DataSource = DatabaseHelper.GetDataTable(cmd)

            FormatGrid()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnAddSelected_Click(sender As Object, e As EventArgs) Handles btnAddSelected.Click

        Try

            SelectedServices.Rows.Clear()

            For Each row As DataGridViewRow In dgvServices.Rows

                If row.Cells("Select").Value IsNot Nothing Then

                    If CBool(row.Cells("Select").Value) = True Then

                        SelectedServices.Rows.Add(
                            Convert.ToInt32(row.Cells("ServiceID").Value),
                            row.Cells("ServiceName").Value.ToString(),
                            Convert.ToDecimal(row.Cells("DefaultPrice").Value)
                    )

                    End If

                End If

            Next

            If SelectedServices.Rows.Count = 0 Then

                MessageBox.Show("برجاء اختيار خدمة واحدة على الأقل.")

                Exit Sub

            End If

            Me.DialogResult = DialogResult.OK

            Me.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnSelectAll_Click(sender As Object, e As EventArgs) Handles btnSelectAll.Click

        For Each row As DataGridViewRow In dgvServices.Rows

            row.Cells("Select").Value = True

        Next

    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click

        For Each row As DataGridViewRow In dgvServices.Rows

            row.Cells("Select").Value = False

        Next

    End Sub

    Private Sub dgvServices_CurrentCellDirtyStateChanged(sender As Object,
                                                     e As EventArgs) Handles dgvServices.CurrentCellDirtyStateChanged

        If dgvServices.IsCurrentCellDirty Then

            dgvServices.CommitEdit(DataGridViewDataErrorContexts.Commit)

        End If

    End Sub

    Private Sub dgvServices_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServices.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        If dgvServices.Columns(e.ColumnIndex).Name = "Select" Then

            If dgvServices.Rows(e.RowIndex).Cells("Select").Value = False Then
                dgvServices.Rows(e.RowIndex).Cells("Select").Value = True
            Else
                dgvServices.Rows(e.RowIndex).Cells("Select").Value = False
            End If

        End If

    End Sub
End Class