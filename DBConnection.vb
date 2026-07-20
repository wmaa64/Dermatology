Imports System.Data.SqlClient

Module DBConnection

    Public con As New SqlConnection(DatabaseConfig.GetConnectionString)

    'Public con1 As New SqlConnection(
    '           "Server=192.168.1.10,1433;Database=ClinicDB;User ID=sa;Password=admin;TrustServerCertificate=True;"
    '           )

    ' "Server=192.168.1.10:1433\SQLEXPRESS;Database=ClinicDB;Trusted_Connection=True;"
End Module

