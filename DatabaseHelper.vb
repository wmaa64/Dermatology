Imports System.Data.SqlClient
Imports System.Data

Public Class DatabaseHelper

    Public Shared ConnectionString As String =
        "Server=.\SQLEXPRESS;Database=FemtotradeDB;Trusted_Connection=True;"

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

End Class