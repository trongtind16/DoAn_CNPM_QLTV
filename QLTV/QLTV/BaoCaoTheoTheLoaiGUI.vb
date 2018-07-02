Imports System.Data.SqlClient
Imports System.Configuration
Imports BUS
Imports DTO
Imports Utility

Public Class BaoCaoTheoTheLoaiGUI
    Private bctlBUS As BaoCaoTheoTheLoaiBUS
    Private Sub BaoCaoTheoTheLoaiGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bctlBUS = New BaoCaoTheoTheLoaiBUS()
        '  cbThang.SelectedIndex = 1
        '    cbNam.SelectedIndex = 1
        cbNam.Text = 1
        cbThang.Text = 1
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
        Dim Month As String
        Dim Year As String
        Month = cbThang.Text
        Year = cbNam.Text
        Dim SQL = "SELECT TenTLS 'Tên Thể Loại' , COUNT(Sach.MaSach) 'Số Lượt Mượn',((COUNT(Sach.MaSach))*1.0 /(SELECT COUNT(MaSach) FROM MuonTraSach WHERE MONTH(NgayMuon) = " + Month + " AND YEAR(NgayMuon) = " + Year + "  ))*100 'Tỉ Lệ' FROM MuonTraSach, Sach, TheLoaiSach WHERE MONTH(NgayMuon) = " + Month + " AND YEAR(NgayMuon) = " + Year + " AND MuonTraSach.MaSach=Sach.MaSach AND Sach.maTLS=TheLoaiSach.MaTLS  GROUP BY Sach.MaTLS, TheLoaiSach.TenTLS"
        Dim Adapter As New SqlClient.SqlDataAdapter(SQL, con)
        Dim DATA As New DataSet
        Adapter.Fill(DATA, "MuonTraSach")
        dgvLoadDS.DataSource = DATA
        dgvLoadDS.DataMember = "MuonTraSach"

        Dim SQL1 = "SELECT COUNT (*) FROM MuonTraSach WHERE MONTH(NgayMuon) = " + Month + " AND YEAR(NgayMuon) = " + Year + " "
        Dim cmd As SqlCommand
        cmd = New SqlCommand(SQL1, con)
        Dim Tong = cmd.ExecuteScalar
        txtTong.Text = Tong
    End Sub
    Public Sub loadListTheLoai()
        Dim listbctl = New List(Of BaoCaoTheoTheLoaiDTO)
        Dim result As Result
        result = bctlBUS.selectAll(listbctl)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách BCTL không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        dgvLoadDS.DataSource = listbctl
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub cbThang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbThang.SelectedIndexChanged
        LoadDanhSach()
    End Sub

    Private Sub cbNam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNam.SelectedIndexChanged
        LoadDanhSach()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        BaoCaoSachTreGUI.Show()
    End Sub
End Class