<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DocGiaGUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DocGiaGUI))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtpNgayHetHan = New System.Windows.Forms.DateTimePicker()
        Me.cbDoiTuong = New System.Windows.Forms.ComboBox()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btxoa = New System.Windows.Forms.Button()
        Me.btthoat = New System.Windows.Forms.Button()
        Me.btthem = New System.Windows.Forms.Button()
        Me.btsua = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvListDG = New System.Windows.Forms.DataGridView()
        Me.MaDG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenDG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GioiTinh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaySinh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaChi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenLDG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayLapThe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayHetHan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbGioiTinh = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpNgayLapThe = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.dtpNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.txtTenDG = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaDG = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbLoaiDG = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvListDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpNgayHetHan
        '
        Me.dtpNgayHetHan.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgayHetHan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayHetHan.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dtpNgayHetHan.Location = New System.Drawing.Point(830, 127)
        Me.dtpNgayHetHan.Name = "dtpNgayHetHan"
        Me.dtpNgayHetHan.Size = New System.Drawing.Size(207, 23)
        Me.dtpNgayHetHan.TabIndex = 9
        Me.dtpNgayHetHan.Value = New Date(2018, 11, 25, 0, 0, 0, 0)
        '
        'cbDoiTuong
        '
        Me.cbDoiTuong.FormattingEnabled = True
        Me.cbDoiTuong.Items.AddRange(New Object() {"Mã Độc Giả", "Tên Độc Giả"})
        Me.cbDoiTuong.Location = New System.Drawing.Point(362, 321)
        Me.cbDoiTuong.Name = "cbDoiTuong"
        Me.cbDoiTuong.Size = New System.Drawing.Size(121, 21)
        Me.cbDoiTuong.TabIndex = 5
        '
        'btnHuy
        '
        Me.btnHuy.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnHuy.BackgroundImage = CType(resources.GetObject("btnHuy.BackgroundImage"), System.Drawing.Image)
        Me.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHuy.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHuy.ForeColor = System.Drawing.Color.Black
        Me.btnHuy.Location = New System.Drawing.Point(770, 309)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(92, 48)
        Me.btnHuy.TabIndex = 8
        Me.btnHuy.Text = "Hủy"
        Me.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHuy.UseVisualStyleBackColor = False
        '
        'btnTimKiem
        '
        Me.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTimKiem.BackgroundImage = CType(resources.GetObject("btnTimKiem.BackgroundImage"), System.Drawing.Image)
        Me.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTimKiem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimKiem.ForeColor = System.Drawing.Color.Black
        Me.btnTimKiem.Location = New System.Drawing.Point(654, 309)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(110, 48)
        Me.btnTimKiem.TabIndex = 7
        Me.btnTimKiem.Text = "Tìm Kiếm"
        Me.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTimKiem.UseVisualStyleBackColor = False
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimKiem.Location = New System.Drawing.Point(489, 318)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(156, 23)
        Me.txtTimKiem.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btxoa)
        Me.GroupBox2.Controls.Add(Me.btthoat)
        Me.GroupBox2.Controls.Add(Me.btthem)
        Me.GroupBox2.Controls.Add(Me.btsua)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(382, 210)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(463, 92)
        Me.GroupBox2.TabIndex = 57
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
        Me.btxoa.Location = New System.Drawing.Point(226, 39)
        Me.btxoa.Name = "btxoa"
        Me.btxoa.Size = New System.Drawing.Size(103, 48)
        Me.btxoa.TabIndex = 3
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
        Me.btthoat.Location = New System.Drawing.Point(339, 39)
        Me.btthoat.Name = "btthoat"
        Me.btthoat.Size = New System.Drawing.Size(103, 48)
        Me.btthoat.TabIndex = 4
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
        Me.btthem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btthem.Location = New System.Drawing.Point(9, 39)
        Me.btthem.Name = "btthem"
        Me.btthem.Size = New System.Drawing.Size(100, 48)
        Me.btthem.TabIndex = 1
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
        Me.btsua.Location = New System.Drawing.Point(117, 39)
        Me.btsua.Name = "btsua"
        Me.btsua.Size = New System.Drawing.Size(103, 48)
        Me.btsua.TabIndex = 2
        Me.btsua.Text = "Sửa"
        Me.btsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btsua.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(733, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 15)
        Me.Label10.TabIndex = 95
        Me.Label10.Text = "Ngày Hết Hạn  :"
        '
        'dgvListDG
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvListDG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListDG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaDG, Me.TenDG, Me.GioiTinh, Me.NgaySinh, Me.Email, Me.DiaChi, Me.TenLDG, Me.NgayLapThe, Me.NgayHetHan})
        Me.dgvListDG.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvListDG.Location = New System.Drawing.Point(12, 363)
        Me.dgvListDG.Name = "dgvListDG"
        Me.dgvListDG.ReadOnly = True
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvListDG.RowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvListDG.Size = New System.Drawing.Size(1053, 301)
        Me.dgvListDG.TabIndex = 55
        '
        'MaDG
        '
        Me.MaDG.DataPropertyName = "MaDG"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MaDG.DefaultCellStyle = DataGridViewCellStyle2
        Me.MaDG.HeaderText = "Mã Độc Giả"
        Me.MaDG.Name = "MaDG"
        Me.MaDG.ReadOnly = True
        '
        'TenDG
        '
        Me.TenDG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TenDG.DataPropertyName = "TenDG"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TenDG.DefaultCellStyle = DataGridViewCellStyle3
        Me.TenDG.HeaderText = "Tên Độc Giả"
        Me.TenDG.Name = "TenDG"
        Me.TenDG.ReadOnly = True
        '
        'GioiTinh
        '
        Me.GioiTinh.DataPropertyName = "GioiTinh"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GioiTinh.DefaultCellStyle = DataGridViewCellStyle4
        Me.GioiTinh.HeaderText = "Giới Tính"
        Me.GioiTinh.Name = "GioiTinh"
        Me.GioiTinh.ReadOnly = True
        '
        'NgaySinh
        '
        Me.NgaySinh.DataPropertyName = "NgaySinh"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NgaySinh.DefaultCellStyle = DataGridViewCellStyle5
        Me.NgaySinh.HeaderText = "Ngày Sinh"
        Me.NgaySinh.Name = "NgaySinh"
        Me.NgaySinh.ReadOnly = True
        '
        'Email
        '
        Me.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Email.DataPropertyName = "Email"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Email.DefaultCellStyle = DataGridViewCellStyle6
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        '
        'DiaChi
        '
        Me.DiaChi.DataPropertyName = "DiaChi"
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DiaChi.DefaultCellStyle = DataGridViewCellStyle7
        Me.DiaChi.HeaderText = "Địa Chỉ"
        Me.DiaChi.Name = "DiaChi"
        Me.DiaChi.ReadOnly = True
        '
        'TenLDG
        '
        Me.TenLDG.DataPropertyName = "MaLDG"
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TenLDG.DefaultCellStyle = DataGridViewCellStyle8
        Me.TenLDG.HeaderText = "Loại ĐG"
        Me.TenLDG.Name = "TenLDG"
        Me.TenLDG.ReadOnly = True
        '
        'NgayLapThe
        '
        Me.NgayLapThe.DataPropertyName = "NgayLapThe"
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NgayLapThe.DefaultCellStyle = DataGridViewCellStyle9
        Me.NgayLapThe.HeaderText = "Ngày Lập Thẻ"
        Me.NgayLapThe.Name = "NgayLapThe"
        Me.NgayLapThe.ReadOnly = True
        '
        'NgayHetHan
        '
        Me.NgayHetHan.DataPropertyName = "NgayHetHan"
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NgayHetHan.DefaultCellStyle = DataGridViewCellStyle10
        Me.NgayHetHan.HeaderText = "Ngày Hết Hạn"
        Me.NgayHetHan.Name = "NgayHetHan"
        Me.NgayHetHan.ReadOnly = True
        '
        'cbGioiTinh
        '
        Me.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGioiTinh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cbGioiTinh.FormattingEnabled = True
        Me.cbGioiTinh.ItemHeight = 15
        Me.cbGioiTinh.Items.AddRange(New Object() {"NAM", "NỮ", "KHÁC"})
        Me.cbGioiTinh.Location = New System.Drawing.Point(501, 88)
        Me.cbGioiTinh.Name = "cbGioiTinh"
        Me.cbGioiTinh.Size = New System.Drawing.Size(207, 23)
        Me.cbGioiTinh.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpNgayHetHan)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cbGioiTinh)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtpNgayLapThe)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDiaChi)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.dtpNgaySinh)
        Me.GroupBox1.Controls.Add(Me.txtTenDG)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtMaDG)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbLoaiDG)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(14, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1051, 167)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Độc Giả"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(390, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 15)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Giới Tính :"
        '
        'dtpNgayLapThe
        '
        Me.dtpNgayLapThe.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgayLapThe.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayLapThe.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayLapThe.Location = New System.Drawing.Point(830, 88)
        Me.dtpNgayLapThe.Name = "dtpNgayLapThe"
        Me.dtpNgayLapThe.Size = New System.Drawing.Size(207, 23)
        Me.dtpNgayLapThe.TabIndex = 8
        Me.dtpNgayLapThe.Value = New Date(2018, 5, 17, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(733, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 15)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Ngày Lập Thẻ :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(39, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Mã Độc Giả :"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaChi.Location = New System.Drawing.Point(830, 47)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(207, 23)
        Me.txtDiaChi.TabIndex = 7
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(501, 127)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(207, 23)
        Me.txtEmail.TabIndex = 6
        '
        'dtpNgaySinh
        '
        Me.dtpNgaySinh.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgaySinh.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgaySinh.Location = New System.Drawing.Point(162, 128)
        Me.dtpNgaySinh.Name = "dtpNgaySinh"
        Me.dtpNgaySinh.Size = New System.Drawing.Size(207, 22)
        Me.dtpNgaySinh.TabIndex = 3
        Me.dtpNgaySinh.Value = New Date(1999, 1, 1, 0, 0, 0, 0)
        '
        'txtTenDG
        '
        Me.txtTenDG.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenDG.Location = New System.Drawing.Point(162, 88)
        Me.txtTenDG.Name = "txtTenDG"
        Me.txtTenDG.Size = New System.Drawing.Size(207, 23)
        Me.txtTenDG.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(737, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Địa Chỉ :"
        '
        'txtMaDG
        '
        Me.txtMaDG.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaDG.Location = New System.Drawing.Point(162, 46)
        Me.txtMaDG.Name = "txtMaDG"
        Me.txtMaDG.ReadOnly = True
        Me.txtMaDG.Size = New System.Drawing.Size(207, 23)
        Me.txtMaDG.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(390, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 15)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Email :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(39, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 15)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Tên Độc Giả : "
        '
        'cbLoaiDG
        '
        Me.cbLoaiDG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLoaiDG.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLoaiDG.FormattingEnabled = True
        Me.cbLoaiDG.ItemHeight = 15
        Me.cbLoaiDG.Location = New System.Drawing.Point(501, 46)
        Me.cbLoaiDG.Name = "cbLoaiDG"
        Me.cbLoaiDG.Size = New System.Drawing.Size(207, 23)
        Me.cbLoaiDG.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(39, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 15)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Ngày Sinh :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(390, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 15)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Loại Độc Giả :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(459, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 32)
        Me.Label11.TabIndex = 112
        Me.Label11.Text = "Độc Giả"
        '
        'DocGiaGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1068, 676)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbDoiTuong)
        Me.Controls.Add(Me.btnHuy)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.dgvListDG)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DocGiaGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DocGiaGUI"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvListDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpNgayHetHan As DateTimePicker
    Friend WithEvents btnHuy As Button
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents txtTimKiem As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btxoa As Button
    Friend WithEvents btthoat As Button
    Friend WithEvents btthem As Button
    Friend WithEvents btsua As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents dgvListDG As DataGridView
    Friend WithEvents cbGioiTinh As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpNgayLapThe As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents dtpNgaySinh As DateTimePicker
    Friend WithEvents txtTenDG As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaDG As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbLoaiDG As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbDoiTuong As ComboBox
    Friend WithEvents MaDG As DataGridViewTextBoxColumn
    Friend WithEvents TenDG As DataGridViewTextBoxColumn
    Friend WithEvents GioiTinh As DataGridViewTextBoxColumn
    Friend WithEvents NgaySinh As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents DiaChi As DataGridViewTextBoxColumn
    Friend WithEvents TenLDG As DataGridViewTextBoxColumn
    Friend WithEvents NgayLapThe As DataGridViewTextBoxColumn
    Friend WithEvents NgayHetHan As DataGridViewTextBoxColumn
    Friend WithEvents Label11 As Label
End Class
