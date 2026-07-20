Imports System.Data.SqlClient

Public Class FrmAddDevice

    Public DeviceID As Integer = 0

    Private Sub FrmAddDevice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        chkActive.Checked = True

        If DeviceID > 0 Then

            LoadDevice()

            btnSave.Text = "تحديث البيانات"

        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try

            If txtDeviceName.Text.Trim = "" Then

                MessageBox.Show("ادخل اسم الجهاز")

                Exit Sub

            End If

            Dim cmd As SqlCommand

            If DeviceID = 0 Then

                cmd = New SqlCommand("
                        INSERT INTO Devices
                        (
                            DeviceName,
                            Manufacturer,
                            DeviceType,
                            IsActive
                        )

                        VALUES
                        (
                            @DeviceName,
                            @Manufacturer,
                            @DeviceType,
                            @IsActive
                        )")

            Else

                cmd = New SqlCommand("
                        UPDATE Devices

                        SET

                            DeviceName=@DeviceName,

                            Manufacturer=@Manufacturer,

                            DeviceType=@DeviceType,

                            IsActive=@IsActive

                        WHERE DeviceID=@DeviceID")

                cmd.Parameters.AddWithValue("@DeviceID", DeviceID)

            End If


            cmd.Parameters.AddWithValue("@DeviceName", txtDeviceName.Text)

            cmd.Parameters.AddWithValue("@Manufacturer", txtManufacturer.Text)

            cmd.Parameters.AddWithValue("@DeviceType", txtDeviceType.Text)

            cmd.Parameters.AddWithValue("@IsActive", chkActive.Checked)


            DatabaseHelper.ExecuteNonQuery(cmd)

            MessageBox.Show("تم حفظ الجهاز بنجاح")

            Me.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub


    Private Sub LoadDevice()

        Try

            Dim cmd As New SqlCommand("SELECT *
                                       FROM Devices
                                       WHERE DeviceID=@DeviceID")

            cmd.Parameters.AddWithValue("@DeviceID", DeviceID)

            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

            If dt.Rows.Count = 0 Then Exit Sub

            txtDeviceName.Text = dt.Rows(0)("DeviceName").ToString()

            txtManufacturer.Text = dt.Rows(0)("Manufacturer").ToString()

            txtDeviceType.Text = dt.Rows(0)("DeviceType").ToString()

            chkActive.Checked = CBool(dt.Rows(0)("IsActive"))

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

End Class