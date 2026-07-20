Imports System.IO

Public Class DatabaseConfig

    Public Shared ConfigFile As String = Path.Combine(Application.StartupPath, "Database.config")

    Public Shared Function GetConnectionString() As String

        If Not File.Exists(ConfigFile) Then

            Throw New Exception("Database.config not found.")

        End If

        Dim server As String = ""
        Dim database As String = ""
        Dim user As String = ""
        Dim password As String = ""
        Dim trust As String = "True"

        For Each line As String In File.ReadAllLines(ConfigFile)

            If String.IsNullOrWhiteSpace(line) Then Continue For

            Dim parts() As String = line.Split({"="c}, 2)

            If parts.Length < 2 Then Continue For

            Select Case parts(0).Trim()

                Case "Server"
                    server = parts(1).Trim()

                Case "Database"
                    database = parts(1).Trim()

                Case "UserID"
                    user = parts(1).Trim()

                Case "Password"
                    password = parts(1).Trim()

                Case "TrustServerCertificate"
                    trust = parts(1).Trim()

            End Select

        Next

        Return $"Server={server};Database={database};User ID={user};Password={password};TrustServerCertificate={trust};"

    End Function

End Class