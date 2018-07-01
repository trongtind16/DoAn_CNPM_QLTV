Imports System.Configuration
Imports BUS
Imports DTO
Imports Utility
Public Class LoaiDocGiaGUI

    Private ldgBus As LoaiDocGiaBUS
    Private Sub LoaiDocGiaGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ldgBus = New LoaiDocGiaBUS()
        loadListLoaiDocGia()

    End Sub
    Public Sub loadListLoaiDocGia()
        ' Load LoaiDocGia list
        Dim listLoaiDocGia = New List(Of LoaiDocGiaDTO)
        Dim result As Result
        result = ldgBus.selectAll(listLoaiDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại Đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvDanhSachTLS.AutoGenerateColumns = False
        dgvDanhSachTLS.AllowUserToAddRows = False
        dgvDanhSachTLS.DataSource = listLoaiDocGia
    End Sub
    Private Sub dgvDanhSachLoaiDG_SelectionChanged(sender As Object, e As EventArgs)

        Dim currentRowIndex As Integer = dgvDanhSachTLS.CurrentCellAddress.Y
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachTLS.RowCount) Then
            Try
                Dim ldg = CType(dgvDanhSachTLS.Rows(currentRowIndex).DataBoundItem, LoaiDocGiaDTO)
                txtMaLoai.Text = ldg.MaLDG
                txtTenLoai.Text = ldg.TenLDG
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If

    End Sub
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btsua.Click

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btthoat.Click
        Me.Hide()
    End Sub
End Class