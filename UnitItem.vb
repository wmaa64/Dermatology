Public Class UnitItem

    Public Property ProductUnitID As Integer

    Public Property UnitID As Integer

    Public Property UnitName As String

    Public Property ConversionFactor As Decimal

    Public Overrides Function ToString() As String

        Return UnitName

    End Function

End Class