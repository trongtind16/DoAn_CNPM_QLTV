Imports DTO
Imports DAL
Imports Utility
Public Class BaoCaoSachTreBUS
    Private bcstDAL As BaoCaoSachTreDAL
    Public Sub New()
        bcstDAL = New BaoCaoSachTreDAL()
    End Sub
    Public Sub New(connectionString As String)
        bcstDAL = New BaoCaoSachTreDAL(connectionString)
    End Sub
    Public Function selectAll(ByRef listbcst As List(Of BaoCaoSachTreDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bcstDAL.selectAll(listbcst)
    End Function
End Class
