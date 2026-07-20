Imports System.Data.SqlClient

Public Class FrmAddPatient
    Public PatientID As Integer = 0

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim cmd As SqlCommand

            If PatientID = 0 Then

                If txtName.Text = "" Then

                    MessageBox.Show("ادخل اسم المريض")

                    Exit Sub

                End If

                cmd = New SqlCommand("INSERT INTO Patients 
                                        ( FileNo, 
                                          FullName,
                                          NationalID,
                                          Phone,
                                          Age, 
                                          Address,
                                          Notes)
                                        
                                        VALUES
                                           (@FileNo,
                                            @FullName,
                                            @NationalID,
                                            @Phone, 
                                            @Age, 
                                            @Address, 
                                            @Notes)")

            Else
                cmd = New SqlCommand("UPDATE Patients 
                                       SET
                                        FullName=@FullName,
                                        NationalID=@NationalID,
                                        Phone=@Phone,
                                        Age=@Age,
                                        Address=@Address,
                                        Notes=@Notes
                                     WHERE PatientID=@PatientID")

                cmd.Parameters.AddWithValue("@PatientID", PatientID)

            End If

            cmd.Parameters.AddWithValue("@FileNo", txtFileNo.Text)
            cmd.Parameters.AddWithValue("@FullName", txtName.Text)
            cmd.Parameters.AddWithValue("@NationalID", txtNationalID.Text)
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
            cmd.Parameters.AddWithValue("@Age", txtAge.Text)
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@Notes", txtNotes.Text)

            DatabaseHelper.ExecuteNonQuery(cmd)

            MessageBox.Show("تم حفظ المريض بنجاح")

            Me.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub FrmAddPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If PatientID = 0 Then

            txtFileNo.Text = DatabaseHelper.GeneratePatientFileNo()

        ElseIf PatientID > 0 Then

            LoadPatientData()

            btnSave.Text = "تحديث البيانات"

        End If
    End Sub

    Private Sub LoadPatientData()

        Try

            Dim cmd As New SqlCommand("SELECT * FROM Patients WHERE PatientID=@PatientID")

            cmd.Parameters.AddWithValue("@PatientID", PatientID)

            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

            If dt.Rows.Count <> 0 Then

                txtFileNo.Text = dt.Rows(0)("FileNo").ToString()

                txtName.Text = dt.Rows(0)("FullName").ToString()

                txtNationalID.Text = dt.Rows(0)("NationalID").ToString()

                txtPhone.Text = dt.Rows(0)("Phone").ToString()

                txtAge.Text = dt.Rows(0)("Age").ToString()

                txtAddress.Text = dt.Rows(0)("Address").ToString()

                txtNotes.Text = dt.Rows(0)("Notes").ToString()

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

End Class