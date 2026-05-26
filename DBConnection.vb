Imports System.Data.SqlClient

Module DBConnection
    Public con As New SqlConnection(
           "Server=.\SQLEXPRESS;Database=ClinicDB;Trusted_Connection=True;"
       )

End Module
