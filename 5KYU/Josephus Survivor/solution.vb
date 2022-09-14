Imports System
Public Module Kata
    Public Function JosephusSurvivor(ByVal n As Integer, ByVal k As Integer) As Integer
        dim r as Integer = 0
        dim i as Integer = 1
        
        while  i <> n+1
            r = (r + k) Mod i
            i = i + 1
        end while
    
        Return r + 1
    End Function
End Module