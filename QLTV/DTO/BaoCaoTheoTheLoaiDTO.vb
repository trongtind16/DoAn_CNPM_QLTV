Public Class BaoCaoTheoTheLoaiDTO
    Private strTheLoai As String
    Private iSoLuotMuon As Integer
    Private iTiLe As Integer
    Public Sub New()

    End Sub
    Public Sub New(strTheLoai As String, iSoLuotMuon As Integer, iTiLe As Integer)
        Me.strTheLoai = strTheLoai
        Me.iSoLuotMuon = iSoLuotMuon
        Me.iTiLe = iTiLe
    End Sub

    Public Property TheLoai() As String
        Get
            Return strTheLoai
        End Get
        Set(value As String)
            strTheLoai = value
        End Set
    End Property
    Public Property SoLuotMuon() As Integer
        Get
            Return iSoLuotMuon
        End Get
        Set(value As Integer)
            iSoLuotMuon = value
        End Set
    End Property

    Public Property TiLe() As Integer
        Get
            Return iTiLe
        End Get
        Set(value As Integer)
            iTiLe = value
        End Set
    End Property
End Class

