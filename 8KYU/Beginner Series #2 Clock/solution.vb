Public Module Kata
    Public Function Past(ByVal h As Integer, ByVal m As Integer, ByVal s As Integer) As Integer
        Return s * 1000 + m * 60000 + h * 3600000
    End Function
End Module