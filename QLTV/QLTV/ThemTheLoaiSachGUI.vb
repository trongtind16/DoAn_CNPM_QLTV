Imports BUS
Imports DTO
Imports Utility

Public Class ThemTheLoaiSachGUI
    Private tlsBus As TheLoaiSachBUS

    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
        Dim ldg As TheLoaiSachDTO
        ldg = New TheLoaiSachDTO()

        '1. Mapping data from GUI control
        ldg.MaTLS = Convert.ToInt32(txtMaLoai.Text)
        ldg.TenTLS = txtTenLoai.Text

        '2. Business .....
        If (tlsBus.isValidName(ldg) = False) Then
            MessageBox.Show("Tên Loại Thể loại sách không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenLoai.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = tlsBus.insert(ldg)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm thể loại sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTenLoai.Text = String.Empty
            TheLoaiSachGUI.loadListTheLoaiSach()

            ' Get Next ID
            Dim nextID As Integer
            result = tlsBus.getNextID(nextID)
            If (result.FlagResult = True) Then
                txtMaLoai.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của thể loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            MessageBox.Show("Thêm thể loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub TheLoaiSachGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tlsBus = New TheLoaiSachBUS()

        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = tlsBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaLoai.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của Thể loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class