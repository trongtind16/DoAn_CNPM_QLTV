<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SachGUI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SachGUI))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btxoa = New System.Windows.Forms.Button()
        Me.btthoat = New System.Windows.Forms.Button()
        Me.btthem = New System.Windows.Forms.Button()
        Me.btsua = New System.Windows.Forms.Button()
        Me.cbDoiTuong = New System.Windows.Forms.ComboBox()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvlistSach = New System.Windows.Forms.DataGridView()
        Me.MaSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenTLS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenTG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamXB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NXB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayNhap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TriGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenTTS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNamXuatBan = New System.Windows.Forms.TextBox()
        Me.cbTheLoai = New System.Windows.Forms.ComboBox()
        Me.txtNhaXuatBan = New System.Windows.Forms.TextBox()
        Me.cbTinhTrang = New System.Windows.Forms.ComboBox()
        Me.dtpNgayNhap = New System.Windows.Forms.DateTimePicker()
        Me.txtTriGia = New System.Windows.Forms.TextBox()
        Me.txtTacGia = New System.Windows.Forms.TextBox()
        Me.txtTenSach = New System.Windows.Forms.TextBox()
        Me.txtMaSach = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvlistSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btxoa)
        Me.GroupBox2.Controls.Add(Me.btthoat)
        Me.GroupBox2.Controls.Add(Me.btthem)
        Me.GroupBox2.Controls.Add(Me.btsua)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(429, 213)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(609, 98)
        Me.GroupBox2.TabIndex = 59
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chức Năng"
        '
        'btxoa
        '
        Me.btxoa.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btxoa.BackgroundImage = CType(resources.GetObject("btxoa.BackgroundImage"), System.Drawing.Image)
        Me.btxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btxoa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btxoa.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btxoa.ForeColor = System.Drawing.Color.Black
        Me.btxoa.Location = New System.Drawing.Point(307, 30)
        Me.btxoa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btxoa.Name = "btxoa"
        Me.btxoa.Size = New System.Drawing.Size(131, 54)
        Me.btxoa.TabIndex = 45
        Me.btxoa.Text = "Xóa"
        Me.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btxoa.UseVisualStyleBackColor = False
        '
        'btthoat
        '
        Me.btthoat.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btthoat.BackgroundImage = CType(resources.GetObject("btthoat.BackgroundImage"), System.Drawing.Image)
        Me.btthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btthoat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btthoat.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btthoat.ForeColor = System.Drawing.Color.Black
        Me.btthoat.Location = New System.Drawing.Point(447, 31)
        Me.btthoat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btthoat.Name = "btthoat"
        Me.btthoat.Size = New System.Drawing.Size(131, 54)
        Me.btthoat.TabIndex = 48
        Me.btthoat.Text = "Trở Về"
        Me.btthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btthoat.UseVisualStyleBackColor = False
        '
        'btthem
        '
        Me.btthem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btthem.BackgroundImage = CType(resources.GetObject("btthem.BackgroundImage"), System.Drawing.Image)
        Me.btthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btthem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btthem.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btthem.ForeColor = System.Drawing.Color.Black
        Me.btthem.Location = New System.Drawing.Point(27, 31)
        Me.btthem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btthem.Name = "btthem"
        Me.btthem.Size = New System.Drawing.Size(131, 53)
        Me.btthem.TabIndex = 44
        Me.btthem.Text = "Thêm"
        Me.btthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btthem.UseVisualStyleBackColor = False
        '
        'btsua
        '
        Me.btsua.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btsua.BackgroundImage = CType(resources.GetObject("btsua.BackgroundImage"), System.Drawing.Image)
        Me.btsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btsua.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btsua.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsua.ForeColor = System.Drawing.Color.Black
        Me.btsua.Location = New System.Drawing.Point(167, 30)
        Me.btsua.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btsua.Name = "btsua"
        Me.btsua.Size = New System.Drawing.Size(131, 54)
        Me.btsua.TabIndex = 46
        Me.btsua.Text = "Sửa"
        Me.btsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btsua.UseVisualStyleBackColor = False
        '
        'cbDoiTuong
        '
        Me.cbDoiTuong.FormattingEnabled = True
        Me.cbDoiTuong.Items.AddRange(New Object() {"Mã Sách", "Tên Sách", "Tác Giả"})
        Me.cbDoiTuong.Location = New System.Drawing.Point(405, 326)
        Me.cbDoiTuong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbDoiTuong.Name = "cbDoiTuong"
        Me.cbDoiTuong.Size = New System.Drawing.Size(133, 24)
        Me.cbDoiTuong.TabIndex = 95
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimKiem.Location = New System.Drawing.Point(548, 326)
        Me.txtTimKiem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(207, 27)
        Me.txtTimKiem.TabIndex = 53
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button1.Location = New System.Drawing.Point(1162, 242)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(187, 69)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "Thêm Loại Sách"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dgvlistSach
        '
        Me.dgvlistSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvlistSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlistSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaSach, Me.TenSach, Me.TenTLS, Me.TenTG, Me.NamXB, Me.NXB, Me.NgayNhap, Me.TriGia, Me.TenTTS})
        Me.dgvlistSach.Location = New System.Drawing.Point(13, 381)
        Me.dgvlistSach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvlistSach.Name = "dgvlistSach"
        Me.dgvlistSach.ReadOnly = True
        Me.dgvlistSach.Size = New System.Drawing.Size(1336, 394)
        Me.dgvlistSach.TabIndex = 58
        '
        'MaSach
        '
        Me.MaSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.MaSach.DataPropertyName = "MaSach"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MaSach.DefaultCellStyle = DataGridViewCellStyle1
        Me.MaSach.HeaderText = "Mã Sách"
        Me.MaSach.Name = "MaSach"
        Me.MaSach.ReadOnly = True
        Me.MaSach.Width = 90
        '
        'TenSach
        '
        Me.TenSach.DataPropertyName = "TenSach"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TenSach.DefaultCellStyle = DataGridViewCellStyle2
        Me.TenSach.HeaderText = "Tên Sách"
        Me.TenSach.Name = "TenSach"
        Me.TenSach.ReadOnly = True
        '
        'TenTLS
        '
        Me.TenTLS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TenTLS.DataPropertyName = "MaTLS"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TenTLS.DefaultCellStyle = DataGridViewCellStyle3
        Me.TenTLS.HeaderText = "Thể Loại"
        Me.TenTLS.Name = "TenTLS"
        Me.TenTLS.ReadOnly = True
        Me.TenTLS.Width = 125
        '
        'TenTG
        '
        Me.TenTG.DataPropertyName = "TenTG"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TenTG.DefaultCellStyle = DataGridViewCellStyle4
        Me.TenTG.HeaderText = "Tác Giả"
        Me.TenTG.Name = "TenTG"
        Me.TenTG.ReadOnly = True
        '
        'NamXB
        '
        Me.NamXB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NamXB.DataPropertyName = "NamXB"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NamXB.DefaultCellStyle = DataGridViewCellStyle5
        Me.NamXB.HeaderText = "Năm Xuất Bản"
        Me.NamXB.Name = "NamXB"
        Me.NamXB.ReadOnly = True
        Me.NamXB.Width = 95
        '
        'NXB
        '
        Me.NXB.DataPropertyName = "NXB"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NXB.DefaultCellStyle = DataGridViewCellStyle6
        Me.NXB.HeaderText = "Nhà Xuất Bản"
        Me.NXB.Name = "NXB"
        Me.NXB.ReadOnly = True
        '
        'NgayNhap
        '
        Me.NgayNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NgayNhap.DataPropertyName = "NgayNhap"
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NgayNhap.DefaultCellStyle = DataGridViewCellStyle7
        Me.NgayNhap.HeaderText = "Ngày Nhập"
        Me.NgayNhap.Name = "NgayNhap"
        Me.NgayNhap.ReadOnly = True
        Me.NgayNhap.Width = 90
        '
        'TriGia
        '
        Me.TriGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TriGia.DataPropertyName = "TriGia"
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TriGia.DefaultCellStyle = DataGridViewCellStyle8
        Me.TriGia.HeaderText = "Trị Giá"
        Me.TriGia.Name = "TriGia"
        Me.TriGia.ReadOnly = True
        Me.TriGia.Width = 75
        '
        'TenTTS
        '
        Me.TenTTS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TenTTS.DataPropertyName = "MaTTS"
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TenTTS.DefaultCellStyle = DataGridViewCellStyle9
        Me.TenTTS.HeaderText = "Tình Trạng"
        Me.TenTTS.Name = "TenTTS"
        Me.TenTTS.ReadOnly = True
        Me.TenTTS.Width = 75
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNamXuatBan)
        Me.GroupBox1.Controls.Add(Me.cbTheLoai)
        Me.GroupBox1.Controls.Add(Me.txtNhaXuatBan)
        Me.GroupBox1.Controls.Add(Me.cbTinhTrang)
        Me.GroupBox1.Controls.Add(Me.dtpNgayNhap)
        Me.GroupBox1.Controls.Add(Me.txtTriGia)
        Me.GroupBox1.Controls.Add(Me.txtTacGia)
        Me.GroupBox1.Controls.Add(Me.txtTenSach)
        Me.GroupBox1.Controls.Add(Me.txtMaSach)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(16, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1333, 190)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Sách"
        '
        'txtNamXuatBan
        '
        Me.txtNamXuatBan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamXuatBan.Location = New System.Drawing.Point(622, 96)
        Me.txtNamXuatBan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNamXuatBan.Name = "txtNamXuatBan"
        Me.txtNamXuatBan.Size = New System.Drawing.Size(264, 27)
        Me.txtNamXuatBan.TabIndex = 25
        '
        'cbTheLoai
        '
        Me.cbTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTheLoai.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTheLoai.FormattingEnabled = True
        Me.cbTheLoai.Location = New System.Drawing.Point(143, 143)
        Me.cbTheLoai.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbTheLoai.Name = "cbTheLoai"
        Me.cbTheLoai.Size = New System.Drawing.Size(279, 28)
        Me.cbTheLoai.TabIndex = 21
        '
        'txtNhaXuatBan
        '
        Me.txtNhaXuatBan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNhaXuatBan.Location = New System.Drawing.Point(622, 49)
        Me.txtNhaXuatBan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNhaXuatBan.Name = "txtNhaXuatBan"
        Me.txtNhaXuatBan.Size = New System.Drawing.Size(264, 27)
        Me.txtNhaXuatBan.TabIndex = 20
        '
        'cbTinhTrang
        '
        Me.cbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTinhTrang.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTinhTrang.FormattingEnabled = True
        Me.cbTinhTrang.Location = New System.Drawing.Point(1061, 92)
        Me.cbTinhTrang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbTinhTrang.Name = "cbTinhTrang"
        Me.cbTinhTrang.Size = New System.Drawing.Size(244, 28)
        Me.cbTinhTrang.TabIndex = 19
        '
        'dtpNgayNhap
        '
        Me.dtpNgayNhap.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgayNhap.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayNhap.Location = New System.Drawing.Point(1061, 139)
        Me.dtpNgayNhap.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpNgayNhap.Name = "dtpNgayNhap"
        Me.dtpNgayNhap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpNgayNhap.Size = New System.Drawing.Size(244, 27)
        Me.dtpNgayNhap.TabIndex = 18
        '
        'txtTriGia
        '
        Me.txtTriGia.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTriGia.Location = New System.Drawing.Point(1061, 49)
        Me.txtTriGia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTriGia.Name = "txtTriGia"
        Me.txtTriGia.Size = New System.Drawing.Size(244, 27)
        Me.txtTriGia.TabIndex = 15
        '
        'txtTacGia
        '
        Me.txtTacGia.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTacGia.Location = New System.Drawing.Point(622, 143)
        Me.txtTacGia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTacGia.Name = "txtTacGia"
        Me.txtTacGia.Size = New System.Drawing.Size(264, 27)
        Me.txtTacGia.TabIndex = 14
        '
        'txtTenSach
        '
        Me.txtTenSach.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenSach.Location = New System.Drawing.Point(143, 96)
        Me.txtTenSach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTenSach.Name = "txtTenSach"
        Me.txtTenSach.Size = New System.Drawing.Size(279, 27)
        Me.txtTenSach.TabIndex = 10
        '
        'txtMaSach
        '
        Me.txtMaSach.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaSach.Location = New System.Drawing.Point(143, 49)
        Me.txtMaSach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMaSach.Name = "txtMaSach"
        Me.txtMaSach.ReadOnly = True
        Me.txtMaSach.Size = New System.Drawing.Size(279, 27)
        Me.txtMaSach.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(926, 94)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Tình Trạng :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(926, 49)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Trị Giá :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(926, 146)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Ngày Nhập :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(468, 96)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Năm Xuất Bản :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(468, 49)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nhà Xuất Bản :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(468, 143)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tác Giả :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 143)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Thể Loại :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 96)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Sách :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Sách :"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(915, 314)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 59)
        Me.Button2.TabIndex = 97
        Me.Button2.Text = "Hủy"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(760, 314)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(147, 59)
        Me.Button3.TabIndex = 96
        Me.Button3.Text = "Tìm Kiếm"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'SachGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1358, 788)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.cbDoiTuong)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvlistSach)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "SachGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SachGUI"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvlistSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btxoa As Button
    Friend WithEvents btthoat As Button
    Friend WithEvents btthem As Button
    Friend WithEvents btsua As Button
    Friend WithEvents txtTimKiem As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvlistSach As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNamXuatBan As TextBox
    Friend WithEvents cbTheLoai As ComboBox
    Friend WithEvents txtNhaXuatBan As TextBox
    Friend WithEvents cbTinhTrang As ComboBox
    Friend WithEvents dtpNgayNhap As DateTimePicker
    Friend WithEvents txtTriGia As TextBox
    Friend WithEvents txtTacGia As TextBox
    Friend WithEvents txtTenSach As TextBox
    Friend WithEvents txtMaSach As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbDoiTuong As ComboBox
    Friend WithEvents MaSach As DataGridViewTextBoxColumn
    Friend WithEvents TenSach As DataGridViewTextBoxColumn
    Friend WithEvents TenTLS As DataGridViewTextBoxColumn
    Friend WithEvents TenTG As DataGridViewTextBoxColumn
    Friend WithEvents NamXB As DataGridViewTextBoxColumn
    Friend WithEvents NXB As DataGridViewTextBoxColumn
    Friend WithEvents NgayNhap As DataGridViewTextBoxColumn
    Friend WithEvents TriGia As DataGridViewTextBoxColumn
    Friend WithEvents TenTTS As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
