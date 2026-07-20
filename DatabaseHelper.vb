Imports System.Data.SqlClient
Imports System.Data

Public Class DatabaseHelper

    Public Shared ReadOnly Property ConnectionString As String

        Get

            Return DatabaseConfig.GetConnectionString()

        End Get

    End Property

    'Public Shared ConnectionString As String =
    '"Server=192.168.1.10,1433;Database=ClinicDB;User ID=sa;Password=admin;TrustServerCertificate=True;"

    'Public Shared ConnectionString As String =
    '   "Server=192.168.1.10,1433;Database=ClinicDB;Trusted_Connection=True;TrustServerCertificate=True;"
    ' "Server=192.168.1.10:1433\SQLEXPRESS;Database=ClinicDB;Trusted_Connection=True;"

    Public Shared Function GetDataTable(cmd As SqlCommand) As DataTable

        Dim dt As New DataTable()

        Using con As New SqlConnection(ConnectionString)

            cmd.Connection = con

            Using da As New SqlDataAdapter(cmd)

                da.Fill(dt)

            End Using

        End Using

        Return dt

    End Function

    Public Shared Sub ExecuteNonQuery(cmd As SqlCommand)

        Using con As New SqlConnection(ConnectionString)

            cmd.Connection = con

            con.Open()

            cmd.ExecuteNonQuery()

        End Using

    End Sub

    Public Shared Function ExecuteScalar(cmd As SqlCommand) As Object

        Using con As New SqlConnection(ConnectionString)

            cmd.Connection = con

            con.Open()

            Return cmd.ExecuteScalar()

        End Using

    End Function

    Public Shared Function GetConnection() As SqlConnection

        Return New SqlConnection(ConnectionString)

    End Function

    Public Shared Function GeneratePatientFileNo() As String

        Dim year As Integer = Date.Now.Year

        Dim cmd As New SqlCommand("SELECT ISNULL(MAX(CAST(RIGHT(FileNo,6) AS INT)),0)
                                    FROM Patients
                                    WHERE FileNo LIKE @Prefix")

        cmd.Parameters.AddWithValue("@Prefix", "F" & year & "-%")

        Dim lastNo As Integer = Convert.ToInt32(DatabaseHelper.ExecuteScalar(cmd))

        Return "F" & year & "-" & (lastNo + 1).ToString("000000")

    End Function


End Class