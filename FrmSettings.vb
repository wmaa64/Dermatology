Imports System.Data.SqlClient

Public Class FrmSettings
    Private Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSettings()

        cbCurrency.Items.Add("جنيه")
        cbCurrency.Items.Add("USD")

        cbDateFormat.Items.Add("dd/MM/yyyy")
        cbDateFormat.Items.Add("MM/dd/yyyy")
        cbDateFormat.Items.Add("yyyy-MM-dd")
    End Sub

    Private Sub LoadSettings()

        txtClinicName.Text = AppSettings.ClinicName

        txtClinicAddress.Text = AppSettings.ClinicAddress

        txtClinicPhone.Text = AppSettings.ClinicPhone

        txtClinicWhatsApp.Text = AppSettings.ClinicWhatsApp

        txtPatientPhotosPath.Text = AppSettings.PatientPhotosPath

        txtReportsPath.Text = AppSettings.ReportsPath

        txtBackupPath.Text = AppSettings.BackupPath

        cbCurrency.Text = AppSettings.Currency

        cbDateFormat.Text = AppSettings.DateFormat

    End Sub

    Private Sub SaveSetting(key As String, value As String)

        Dim cmd As New SqlCommand("UPDATE Settings
                                    SET SettingValue=@Value
                                    WHERE SettingKey=@Key")

        cmd.Parameters.AddWithValue("@Key", key)

        cmd.Parameters.AddWithValue("@Value", value)

        DatabaseHelper.ExecuteNonQuery(cmd)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            SaveSetting("ClinicName", txtClinicName.Text)

            SaveSetting("ClinicAddress", txtClinicAddress.Text)

            SaveSetting("ClinicPhone", txtClinicPhone.Text)

            SaveSetting("ClinicWhatsApp", txtClinicWhatsApp.Text)

            SaveSetting("PatientPhotosPath", txtPatientPhotosPath.Text)

            SaveSetting("ReportsPath", txtReportsPath.Text)

            SaveSetting("BackupPath", txtBackupPath.Text)

            SaveSetting("Currency", cbCurrency.Text)

            SaveSetting("DateFormat", cbDateFormat.Text)

            AppSettings.Load()

            MessageBox.Show("Settings Saved Successfully.")

            Me.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub btnBrowsePhotos_Click(sender As Object, e As EventArgs) Handles btnBrowsePhotos.Click
        Dim f As New FolderBrowserDialog

        If f.ShowDialog = DialogResult.OK Then

            txtPatientPhotosPath.Text = f.SelectedPath

        End If

    End Sub

    Private Sub btnBrowseReports_Click(sender As Object, e As EventArgs) Handles btnBrowseReports.Click
        Dim f As New FolderBrowserDialog

        If f.ShowDialog = DialogResult.OK Then

            txtReportsPath.Text = f.SelectedPath

        End If

    End Sub

    Private Sub btnBrowseBackup_Click(sender As Object, e As EventArgs) Handles btnBrowseBackup.Click
        Dim f As New FolderBrowserDialog

        If f.ShowDialog = DialogResult.OK Then

            txtBackupPath.Text = f.SelectedPath

        End If

    End Sub


End Class