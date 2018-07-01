Imports BUS
Imports DTO
Imports Utility

Public Class ThemTheLoaiSachGUI
    Private tlsBus As TheLoaiSachBUS

    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click

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