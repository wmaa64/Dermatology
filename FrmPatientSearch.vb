Imports System.Data.SqlClient

Public Class FrmPatientSearch
    Public SelectedPatientID As Integer = 0

    Public SelectedProductCode As Integer = 0

    Public SelectedPatientName As String = ""

    Private Sub FrmProductSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPatients()
    End Sub

    Private Sub LoadPatients()

        Try

            Dim cmd As New SqlCommand("SELECT 
                                        PatientID AS 'الكود', 
                                        FileNo AS 'رقم الملف',
                                        FullName AS 'اسم المريض',
                                        Phone AS 'الهاتف',
                                        Age AS 'العمر',
                                        Address AS 'العنوان'            
                                     FROM Patients")

            dgvPatients.DataSource = DatabaseHelper.GetDataTable(cmd)



        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchPatients()
    End Sub

    Private Sub SearchPatients()

        Try

            Dim cmd As New SqlCommand("SELECT 
                                        PatientID AS 'الكود',
                                        FileNo AS 'رقم الملف',
                                        FullName AS 'اسم المريض',
                                        Phone AS 'الهاتف',
                                        Age AS 'العمر',
                                        Address AS 'العنوان'

                                       FROM Patients

                                       WHERE
                                        FileNo LIKE @Search
                                        OR FullName LIKE @Search
                                        OR Phone LIKE @Search")

            cmd.Parameters.AddWithValue("@Search", "%" & txtSearch.Text & "%")

            dgvPatients.DataSource = DatabaseHelper.GetDataTable(cmd)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub SelectCurrentPatient()

        If dgvPatients.CurrentRow Is Nothing Then Exit Sub

        SelectedPatientID = Convert.ToInt32(dgvPatients.CurrentRow.Cells("الكود").Value)

        SelectedPatientName = dgvPatients.CurrentRow.Cells("اسم المريض").Value.ToString()

        Me.DialogResult = DialogResult.OK

        Me.Close()

    End Sub

    Private Sub dgvPatients_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPatients.CellDoubleClick, dgvPatients.CellDoubleClick

        If e.RowIndex < 0 Then Exit Sub

        SelectCurrentPatient()

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

        SelectCurrentPatient()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub dgvPatients_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPatients.CellContentClick

    End Sub
End Class