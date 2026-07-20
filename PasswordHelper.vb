Imports System.Security.Cryptography
Imports System.Text

Public Class PasswordHelper

    Public Shared Function HashPassword(password As String) As String

        Using sha As SHA256 = SHA256.Create()

            Dim bytes = Encoding.UTF8.GetBytes(password)

            Dim hash = sha.ComputeHash(bytes)

            Dim sb As New StringBuilder()

            For Each b In hash

                sb.Append(b.ToString("x2"))

            Next

            Return sb.ToString()

        End Using

    End Function

End Class