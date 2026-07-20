Imports System.Reflection

Public Class UC_About

    Private Sub UC_About_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim asm As Assembly = Assembly.GetExecutingAssembly()

        Dim asmName As AssemblyName = asm.GetName()

        lblVersion.Text = "Version : " & asmName.Version.ToString()

        lblCompany.Text = Application.CompanyName

        lblCopyright.Text = My.Application.Info.Copyright

        lblDescription.Text = My.Application.Info.Description

    End Sub


End Class
