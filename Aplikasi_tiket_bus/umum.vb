Module umum
    Public conString As String
    Public ServerName As String
    Public userServer As String
    Public PasServer As String
    Public Proses As New koneksi
    Public sqL As String
    Public Tabel As New DataTable

    Function Aphostrophe(ByVal sval As String) As String
        Dim sRet As String
        sRet = sval.Replace("'", "''")
        sRet = "'" + sRet + "'"
        Return sRet
    End Function
End Module
