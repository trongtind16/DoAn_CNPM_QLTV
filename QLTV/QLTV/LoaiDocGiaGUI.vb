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

        dgvDanhSachLoaiDG.AutoGenerateColumns = False
        dgvDanhSachLoaiDG.AllowUserToAddRows = False
        dgvDanhSachLoaiDG.DataSource = listLoaiDocGia
    End Sub
    Private Sub dgvDanhSachLoaiDG_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachLoaiDG.SelectionChanged

        Dim currentRowIndex As Integer = dgvDanhSachLoaiDG.CurrentCellAddress.Y
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachLoaiDG.RowCount) Then
            Try
                Dim ldg = CType(dgvDanhSachLoaiDG.Rows(currentRowIndex).DataBoundItem, LoaiDocGiaDTO)
                txtMaLoai.Text = ldg.MaLDG
                txtTenLoai.Text = ldg.TenLDG
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If

    End Sub
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btsua.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachLoaiDG.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachLoaiDG.RowCount) Then
            Try
                Dim ldg As LoaiDocGiaDTO
                ldg = New LoaiDocGiaDTO()

                '1. Mapping data from GUI control
                ldg.MaLDG = Convert.ToInt32(txtMaLoai.Text)
                ldg.TenLDG = txtTenLoai.Text

                '2. Business .....
                If (ldgBus.isValidName(ldg) = False) Then
                    MessageBox.Show("Tên Loại Đọc Giả không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtTenLoai.Focus()
                    Return
                End If

                '3. Insert to DB

                Dim result As Result
                result = ldgBus.update(ldg)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    loadListLoaiDocGia()
                    ' Hightlight the row has been updated on table
                    dgvDanhSachLoaiDG.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật Loại Đọc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MessageBox.Show("Cập nhật loại Đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btthoat.Click
        Me.Hide()
    End Sub
End Class