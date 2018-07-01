Imports DAL
Imports DTO
Imports Utility
Public Class BaoCaoTheoTheLoaiBUS
    Private bctlDAL As BaoCaoTheoTheLoaiDAL
    Public Sub New()
        bctlDAL = New BaoCaoTheoTheLoaiDAL()
    End Sub
    Public Sub New(connectionString As String)
        bctlDAL = New BaoCaoTheoTheLoaiDAL(connectionString)
    End Sub
    Public Function selectAll(ByRef listbctl As List(Of BaoCaoTheoTheLoaiDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bctlDAL.selectAll(listbctl)
    End Function
End Class
