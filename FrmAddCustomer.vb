Imports System.Data
Imports System.Data.SqlClient
Imports System.Net
Imports System.Reflection
Public Class FrmAddCustomer
    Public CustomerID As Integer = 0

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim cmd As SqlCommand

            If CustomerID = 0 Then

                If txtCustomerName.Text = "" Then

                    MessageBox.Show("ادخل اسم العميل")

                    Exit Sub

                End If

                cmd = New SqlCommand("INSERT INTO Customers (CustomerName, Address, Mobile, Email, WorkDomain, Notes)
                                        VALUES (@CustomerName, @Address, @Mobile, @Email, @WorkDomain, @Notes)")

            Else
                cmd = New SqlCommand("UPDATE Customers SET
                                        CustomerName=@CustomerName,
                                        Address=@Address,
                                        Mobile=@Mobile,
                                        Email=@Email,
                                        WorkDomain=@WorkDomain,
                                        Notes=@Notes
                                     WHERE CustomerID=@CustomerID")

                cmd.Parameters.AddWithValue("@CustomerID", CustomerID)

            End If

            cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text)
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text)
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@WorkDomain", txtWorkDomain.Text)
            cmd.Parameters.AddWithValue("@Notes", txtNotes.Text)

            DatabaseHelper.ExecuteNonQuery(cmd)

            MessageBox.Show("تم حفظ العميل بنجاح")

            Me.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub FrmAddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CustomerID > 0 Then

            LoadCustomerData()

            btnSave.Text = "تحديث البيانات"

        End If
    End Sub

    Private Sub LoadCustomerData()

        Try

            Dim cmd As New SqlCommand("SELECT * FROM Customers WHERE CustomerID=@CustomerID")

            cmd.Parameters.AddWithValue("@CustomerID", CustomerID)

            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)


            If dt.Rows.Count = 1 Then

                txtCustomerName.Text = dt.Rows(0)("CustomerName").ToString()

                txtAddress.Text = dt.Rows(0)("Address").ToString()

                txtMobile.Text = dt.Rows(0)("Mobile").ToString()

                txtEmail.Text = dt.Rows(0)("Email").ToString()

                txtWorkDomain.Text = dt.Rows(0)("WorkDomain").ToString()

                txtNotes.Text = dt.Rows(0)("Notes").ToString()

            End If

            con.Close()

        Catch ex As Exception

            con.Close()

            MessageBox.Show(ex.Message)

        End Try

    End Sub

End Class