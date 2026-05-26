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

                cmd = New SqlCommand("INSERT INTO Patients (FullName, Phone, Age, Address, Notes) VALUES
                                           (@FullName, @Phone, @Age, @Address, @Notes)", con)
            Else
                cmd = New SqlCommand("UPDATE Patients SET
                                        FullName=@FullName,
                                        Phone=@Phone,
                                        Age=@Age,
                                        Address=@Address,
                                        Notes=@Notes
                                     WHERE PatientID=@PatientID", con)

                cmd.Parameters.AddWithValue("@PatientID", PatientID)

            End If

            cmd.Parameters.AddWithValue("@FullName", txtName.Text)
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
            cmd.Parameters.AddWithValue("@Age", txtAge.Text)
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@Notes", txtNotes.Text)

            DatabaseHelper.ExecuteNonQuery(cmd)

            MessageBox.Show("تم حفظ المريض بنجاح")

            Me.Close()

        Catch ex As Exception

            con.Close()

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub FrmAddPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If PatientID > 0 Then

            LoadPatientData()

            btnSave.Text = "تحديث البيانات"

        End If
    End Sub

    Private Sub LoadPatientData()

        Try

            Dim cmd As New SqlCommand("SELECT * FROM Patients WHERE PatientID=@PatientID", con)

            cmd.Parameters.AddWithValue("@PatientID", PatientID)

            con.Open()

            Dim dr As SqlDataReader = cmd.ExecuteReader()

            If dr.Read() Then

                txtName.Text = dr("FullName").ToString()

                txtPhone.Text = dr("Phone").ToString()

                txtAge.Text = dr("Age").ToString()

                txtAddress.Text = dr("Address").ToString()

                txtNotes.Text = dr("Notes").ToString()

            End If

            con.Close()

        Catch ex As Exception

            con.Close()

            MessageBox.Show(ex.Message)

        End Try

    End Sub
End Class