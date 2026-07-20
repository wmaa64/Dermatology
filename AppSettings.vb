Imports System.Data.SqlClient
Imports System.Data

Public Class AppSettings

    Private Shared Settings As New Dictionary(Of String, String)

    Public Shared Sub Load()

        Try

            Settings.Clear()

            Dim cmd As New SqlCommand("SELECT SettingKey, SettingValue FROM Settings")

            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

            For Each row As DataRow In dt.Rows

                Settings(row("SettingKey").ToString()) =
                    row("SettingValue").ToString()

            Next

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Shared Function GetValue(Key As String) As String

        If Settings.ContainsKey(Key) Then

            Return Settings(Key)

        End If

        Return ""

    End Function

    Public Shared ReadOnly Property ClinicName As String

        Get

            Return GetValue("ClinicName")

        End Get

    End Property

    Public Shared ReadOnly Property ClinicAddress As String

        Get

            Return GetValue("ClinicAddress")

        End Get

    End Property

    Public Shared ReadOnly Property ClinicPhone As String

        Get

            Return GetValue("ClinicPhone")

        End Get

    End Property

    Public Shared ReadOnly Property ClinicWhatsApp As String

        Get

            Return GetValue("ClinicWhatsApp")

        End Get

    End Property

    Public Shared ReadOnly Property PatientPhotosPath As String

        Get

            Return GetValue("PatientPhotosPath")

        End Get

    End Property

    Public Shared ReadOnly Property ReportsPath As String

        Get

            Return GetValue("ReportsPath")

        End Get

    End Property

    Public Shared ReadOnly Property BackupPath As String

        Get

            Return GetValue("BackupPath")

        End Get

    End Property

    Public Shared ReadOnly Property Currency As String

        Get

            Return GetValue("Currency")

        End Get

    End Property

    Public Shared ReadOnly Property DateFormat As String

        Get

            Return GetValue("DateFormat")

        End Get

    End Property

End Class