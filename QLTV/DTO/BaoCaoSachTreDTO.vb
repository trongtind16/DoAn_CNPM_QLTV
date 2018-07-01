Public Class BaoCaoSachTreDTO
    Private strTenSach As String
    Private dtpNgayMuon As DateTime
    Private strMaDG As String
    Private strTenDG As String
    Private strMaPhieu As String
    Private dtpNgayHenTra As DateTime
    Private dtpNgayTra As DateTime
    Public Sub New()
    End Sub
    Public Sub New(strMaPhieu As String, strMaDG As String, strTenDG As String, strTenSach As String, dtpNgayMuon As DateTime, dtpNgayHenTra As DateTime, dtpNgayTra As DateTime)
        Me.strTenSach = strTenSach
        Me.dtpNgayMuon = dtpNgayMuon
        Me.strMaDG = strMaDG
        Me.strTenDG = strTenDG
        Me.strMaPhieu = strMaPhieu
        Me.dtpNgayHenTra = dtpNgayHenTra
        Me.dtpNgayTra = dtpNgayTra
    End Sub
    Public Property MaDG() As String
        Get
            Return strMaDG
        End Get
        Set(value As String)
            strMaDG = value
        End Set
    End Property
    Public Property TenSach() As String
        Get
            Return strTenSach
        End Get
        Set(value As String)
            strTenSach = value
        End Set
    End Property

    Public Property NgayMuon() As Date
        Get
            Return dtpNgayMuon
        End Get
        Set(value As Date)
            dtpNgayMuon = value
        End Set
    End Property

    Public Property TenDG() As String
        Get
            Return strTenDG
        End Get
        Set(value As String)
            strTenDG = value
        End Set
    End Property

    Public Property MaPhieu() As String
        Get
            Return strMaPhieu
        End Get
        Set(value As String)
            strMaPhieu = value
        End Set
    End Property

    Public Property NgayHenTra() As Date
        Get
            Return dtpNgayHenTra
        End Get
        Set(value As Date)
            dtpNgayHenTra = value
        End Set
    End Property

    Public Property NgayTra() As Date
        Get
            Return dtpNgayTra
        End Get
        Set(value As Date)
            dtpNgayTra = value
        End Set
    End Property
End Class
