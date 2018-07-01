Imports System.Configuration
Imports System.Data.SqlClient
Imports DTO
Imports Utility
Public Class BaoCaoTheoTheLoaiDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function selectAll(ByRef listbctl As List(Of BaoCaoTheoTheLoaiDTO)) As Result
        Dim query As String = String.Empty
        query &= "SELECT TenTLS As 'Tên Thể Loại' , COUNT(Sach.MaSach) As 'Số Lượt Mượn',((COUNT(Sach.MaSach))*1.0 /(SELECT COUNT(MaSach) FROM MuonTraSach))*100 'Tỉ Lệ' FROM MuonTraSach, Sach, TheLoaiSach WHERE MuonTraSach.MaSach=Sach.MaSach AND Sach.maTLS=TheLoaiSach.MaTLS  GROUP BY Sach.MaTLS, TheLoaiSach.TenTLS"
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
                        listbctl.Clear()
                        While reader.Read()
                            listbctl.Add(New BaoCaoTheoTheLoaiDTO(reader("TheLoai"), reader("SoLuotMuon"), reader("TiLe")))
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
