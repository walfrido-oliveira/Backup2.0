Public Class Utils
    Public Shared Function GetLastFolder(ByVal source As String) As String
        Dim folder As String = String.Empty
        If source(source.Length - 1) = "\" Then
            Dim temp As String = source.Substring(0, source.Length - 1)
            folder = temp.Substring(temp.LastIndexOf("\") + 1)
        Else
            folder = source.Substring(source.LastIndexOf("\") + 1)
        End If
        Return folder
    End Function
End Class