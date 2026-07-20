Public Module ArabicHelper

    Public Function ArabicDigits(Value As Object) As String

        If Value Is Nothing OrElse IsDBNull(Value) Then Return ""

        Return Value.ToString().
            Replace("0", "٠").
            Replace("1", "١").
            Replace("2", "٢").
            Replace("3", "٣").
            Replace("4", "٤").
            Replace("5", "٥").
            Replace("6", "٦").
            Replace("7", "٧").
            Replace("8", "٨").
            Replace("9", "٩")

    End Function

End Module