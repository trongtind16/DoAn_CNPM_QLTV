Imports System.Configuration
Imports System.Data.SqlClient
Imports DTO
Imports Utility
Public Class BaoCaoSachTreDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function selectAll(ByRef listbcst As List(Of BaoCaoSachTreDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaPhieu] As 'Mã Phiếu', [DocGia].[MaDG] As 'Mã Độc Giả', [DocGia].[TenDG] As 'Tên Độc Giả', [Sach].[MaSach] As 'Mã Sách', [Sach].[TenSach] As 'Tên Sách', [NgayMuon] As 'Ngày Mượn', [NgayHenTra] As 'Ngày Hẹn Trả',[NgayTra] As 'Ngày Trả'"
        query &= " FROM [MuonTraSach],[DocGia],[Sach] WHERE [MuonTraSach].[MaDG]=[DocGia].[MaDG] AND [MuonTraSach].[MaSach]=[Sach].[MaSach] AND DATEDIFF(DAY,NgayTra,GETDATE()) > 0 "
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listbcst.Clear()
                        While reader.Read()
                            listbcst.Add(New BaoCaoSachTreDTO(reader("MaPhieu"), reader("MaDG"), reader("TenDG"), reader("TenSach"), reader("NgayMuon"), reader("NgayHenTra"), reader("NgayTra")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
