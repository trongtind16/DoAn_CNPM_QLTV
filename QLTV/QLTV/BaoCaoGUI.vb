Public Class BaoCaoGUI
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoaiDocGiaGUI.Hide()
        DocGiaGUI.Hide()
        QuyDinhGUI.Hide()
        TheLoaiSachGUI.Hide()
        TinhTrangSachGUI.Hide()
        SachGUI.Hide()
        QuanLyPhieuMuonGUI.Hide()
        BaoCaoSachTreGUI.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoaiDocGiaGUI.Hide()
        DocGiaGUI.Hide()
        QuyDinhGUI.Hide()
        TheLoaiSachGUI.Hide()
        TinhTrangSachGUI.Hide()
        SachGUI.Hide()
        QuanLyPhieuMuonGUI.Hide()
        BaoCaoTheoTheLoaiGUI.Show()
    End Sub

    Private Sub btthoat_Click(sender As Object, e As EventArgs) Handles btthoat.Click
        Me.Hide()
    End Sub
End Class