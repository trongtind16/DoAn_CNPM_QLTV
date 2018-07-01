Imports System.Configuration
Imports System.Data.SqlClient
Imports BUS
Imports DTO
Imports Utility
Public Class BaoCaoSachTreGUI
    Private bcstBUS As BaoCaoSachTreBUS
    Private Sub BaoCaoTheoTheLoaiGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bcstBUS = New BaoCaoSachTreBUS()
        LoadDanhSach()
    End Sub
    Private con As SqlConnection
    Private Sub Connect()
        Dim conn As String = ConfigurationManager.AppSettings("ConnectionString")
        Try
            con = New SqlConnection(conn)
        Catch ex As Exception
            MessageBox.Show("Kết Nối Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub LoadDanhSach()
        Connect()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim SQL = " SELECT [MaPhieu] As 'Mã Phiếu', [DocGia].[MaDG] As 'Mã Độc Giả', [DocGia].[TenDG] As 'Tên Độc Giả', [Sach].[MaSach] As 'Mã Sách', [Sach].[TenSach] As 'Tên Sách', [NgayMuon] As 'Ngày Mượn', [NgayHenTra] As 'Ngày Hẹn Trả',[NgayTra] As 'Ngày Trả', (SELECT DATEDIFF (DAY,NgayMuon,GETDATE())) As 'Số Ngày Trể' FROM [MuonTraSach],[DocGia],[Sach] WHERE [MuonTraSach].[MaDG]=[DocGia].[MaDG] AND [MuonTraSach].[MaSach]=[Sach].[MaSach] AND DATEDIFF(DAY,NgayTra,GETDATE()) > 0 "
        Dim Adapter As New SqlClient.SqlDataAdapter(SQL, con)
        Dim DATA As New DataSet
        Adapter.Fill(DATA, "MuonTraSach")
        dgvLoadDS.DataSource = DATA
        dgvLoadDS.DataMember = "MuonTraSach"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class