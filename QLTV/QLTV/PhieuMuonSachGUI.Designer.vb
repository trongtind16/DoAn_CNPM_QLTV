﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PhieuMuonSachGUI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PhieuMuonSachGUI))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbMaDG = New System.Windows.Forms.ComboBox()
        Me.txtMaPhieu = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTenDG = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTenSach = New System.Windows.Forms.TextBox()
        Me.dtpNgayMuon = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpNgayHenTra = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpNgayTra = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpHSD = New System.Windows.Forms.DateTimePicker()
        Me.dgvlistSach = New System.Windows.Forms.DataGridView()
        Me.MaSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaTTS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TriGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaTLS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenTG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamXB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NXB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtMaSach = New System.Windows.Forms.TextBox()
        Me.cbDoiTuong = New System.Windows.Forms.ComboBox()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.txtSachDaMuon = New System.Windows.Forms.TextBox()
        Me.txtTinhTrangSach = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btthoat = New System.Windows.Forms.Button()
        Me.btthem = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.dgvlistSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã Phiếu Mượn"
        '
        'cbMaDG
        '
        Me.cbMaDG.FormattingEnabled = True
        Me.cbMaDG.Location = New System.Drawing.Point(116, 124)
        Me.cbMaDG.Name = "cbMaDG"
        Me.cbMaDG.Size = New System.Drawing.Size(121, 21)
        Me.cbMaDG.TabIndex = 2
        '
        'txtMaPhieu
        '
        Me.txtMaPhieu.Enabled = False
        Me.txtMaPhieu.Location = New System.Drawing.Point(116, 99)
        Me.txtMaPhieu.Name = "txtMaPhieu"
        Me.txtMaPhieu.Size = New System.Drawing.Size(121, 20)
        Me.txtMaPhieu.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Đọc Giả"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tên Độc Giả"
        '
        'txtTenDG
        '
        Me.txtTenDG.Location = New System.Drawing.Point(116, 151)
        Me.txtTenDG.Name = "txtTenDG"
        Me.txtTenDG.Size = New System.Drawing.Size(121, 20)
        Me.txtTenDG.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(633, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Mã Sách"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(628, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Tên Sách"
        '
        'txtTenSach
        '
        Me.txtTenSach.Enabled = False
        Me.txtTenSach.Location = New System.Drawing.Point(742, 124)
        Me.txtTenSach.Name = "txtTenSach"
        Me.txtTenSach.Size = New System.Drawing.Size(121, 20)
        Me.txtTenSach.TabIndex = 3
        '
        'dtpNgayMuon
        '
        Me.dtpNgayMuon.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgayMuon.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayMuon.Location = New System.Drawing.Point(388, 98)
        Me.dtpNgayMuon.Name = "dtpNgayMuon"
        Me.dtpNgayMuon.Size = New System.Drawing.Size(207, 22)
        Me.dtpNgayMuon.TabIndex = 35
        Me.dtpNgayMuon.Value = New Date(1999, 1, 1, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(279, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Ngày Mượn"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(279, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 15)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Ngày Hẹn Trả"
        '
        'dtpNgayHenTra
        '
        Me.dtpNgayHenTra.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgayHenTra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayHenTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayHenTra.Location = New System.Drawing.Point(388, 126)
        Me.dtpNgayHenTra.Name = "dtpNgayHenTra"
        Me.dtpNgayHenTra.Size = New System.Drawing.Size(207, 22)
        Me.dtpNgayHenTra.TabIndex = 35
        Me.dtpNgayHenTra.Value = New Date(1999, 1, 1, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(279, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 15)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Ngày Trả"
        '
        'dtpNgayTra
        '
        Me.dtpNgayTra.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgayTra.Enabled = False
        Me.dtpNgayTra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayTra.Location = New System.Drawing.Point(388, 154)
        Me.dtpNgayTra.Name = "dtpNgayTra"
        Me.dtpNgayTra.Size = New System.Drawing.Size(207, 22)
        Me.dtpNgayTra.TabIndex = 35
        Me.dtpNgayTra.Value = New Date(1999, 1, 1, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(9, 183)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 15)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "HSD Thẻ"
        '
        'dtpHSD
        '
        Me.dtpHSD.CustomFormat = "dd/MM/yyyy"
        Me.dtpHSD.Enabled = False
        Me.dtpHSD.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHSD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHSD.Location = New System.Drawing.Point(116, 176)
        Me.dtpHSD.Name = "dtpHSD"
        Me.dtpHSD.Size = New System.Drawing.Size(137, 22)
        Me.dtpHSD.TabIndex = 35
        Me.dtpHSD.Value = New Date(1999, 1, 1, 0, 0, 0, 0)
        '
        'dgvlistSach
        '
        Me.dgvlistSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvlistSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlistSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaSach, Me.TenSach, Me.MaTTS, Me.TriGia, Me.MaTLS, Me.TenTG, Me.NamXB, Me.NXB})
        Me.dgvlistSach.Location = New System.Drawing.Point(12, 371)
        Me.dgvlistSach.Name = "dgvlistSach"
        Me.dgvlistSach.ReadOnly = True
        Me.dgvlistSach.Size = New System.Drawing.Size(939, 296)
        Me.dgvlistSach.TabIndex = 59
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
        'MaTTS
        '
        Me.MaTTS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.MaTTS.DataPropertyName = "MaTTS"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MaTTS.DefaultCellStyle = DataGridViewCellStyle3
        Me.MaTTS.HeaderText = "Tình Trạng"
        Me.MaTTS.Name = "MaTTS"
        Me.MaTTS.ReadOnly = True
        Me.MaTTS.Width = 75
        '
        'TriGia
        '
        Me.TriGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TriGia.DataPropertyName = "TriGia"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TriGia.DefaultCellStyle = DataGridViewCellStyle4
        Me.TriGia.HeaderText = "Trị Giá"
        Me.TriGia.Name = "TriGia"
        Me.TriGia.ReadOnly = True
        Me.TriGia.Width = 75
        '
        'MaTLS
        '
        Me.MaTLS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.MaTLS.DataPropertyName = "MaTLS"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MaTLS.DefaultCellStyle = DataGridViewCellStyle5
        Me.MaTLS.HeaderText = "Thể Loại"
        Me.MaTLS.Name = "MaTLS"
        Me.MaTLS.ReadOnly = True
        Me.MaTLS.Width = 125
        '
        'TenTG
        '
        Me.TenTG.DataPropertyName = "TenTG"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TenTG.DefaultCellStyle = DataGridViewCellStyle6
        Me.TenTG.HeaderText = "Tác Giả"
        Me.TenTG.Name = "TenTG"
        Me.TenTG.ReadOnly = True
        '
        'NamXB
        '
        Me.NamXB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NamXB.DataPropertyName = "NamXB"
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NamXB.DefaultCellStyle = DataGridViewCellStyle7
        Me.NamXB.HeaderText = "Năm Xuất Bản"
        Me.NamXB.Name = "NamXB"
        Me.NamXB.ReadOnly = True
        Me.NamXB.Width = 95
        '
        'NXB
        '
        Me.NXB.DataPropertyName = "NXB"
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NXB.DefaultCellStyle = DataGridViewCellStyle8
        Me.NXB.HeaderText = "Nhà Xuất Bản"
        Me.NXB.Name = "NXB"
        Me.NXB.ReadOnly = True
        '
        'txtMaSach
        '
        Me.txtMaSach.Enabled = False
        Me.txtMaSach.Location = New System.Drawing.Point(742, 95)
        Me.txtMaSach.Name = "txtMaSach"
        Me.txtMaSach.Size = New System.Drawing.Size(121, 20)
        Me.txtMaSach.TabIndex = 3
        '
        'cbDoiTuong
        '
        Me.cbDoiTuong.FormattingEnabled = True
        Me.cbDoiTuong.ItemHeight = 13
        Me.cbDoiTuong.Items.AddRange(New Object() {"Mã Sách", "Tên Sách", "Tác Giả"})
        Me.cbDoiTuong.Location = New System.Drawing.Point(203, 330)
        Me.cbDoiTuong.Name = "cbDoiTuong"
        Me.cbDoiTuong.Size = New System.Drawing.Size(121, 21)
        Me.cbDoiTuong.TabIndex = 2
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimKiem.Location = New System.Drawing.Point(329, 329)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(156, 23)
        Me.txtTimKiem.TabIndex = 5
        '
        'txtSachDaMuon
        '
        Me.txtSachDaMuon.Enabled = False
        Me.txtSachDaMuon.Location = New System.Drawing.Point(742, 176)
        Me.txtSachDaMuon.Name = "txtSachDaMuon"
        Me.txtSachDaMuon.Size = New System.Drawing.Size(121, 20)
        Me.txtSachDaMuon.TabIndex = 3
        '
        'txtTinhTrangSach
        '
        Me.txtTinhTrangSach.Enabled = False
        Me.txtTinhTrangSach.Location = New System.Drawing.Point(742, 151)
        Me.txtTinhTrangSach.Name = "txtTinhTrangSach"
        Me.txtTinhTrangSach.Size = New System.Drawing.Size(121, 20)
        Me.txtTinhTrangSach.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(621, 316)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 48)
        Me.Button2.TabIndex = 7
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
        Me.Button3.Location = New System.Drawing.Point(502, 316)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 48)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Tìm Kiếm"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btthoat)
        Me.GroupBox2.Controls.Add(Me.btthem)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(342, 219)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(270, 92)
        Me.GroupBox2.TabIndex = 98
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chức Năng"
        '
        'btthoat
        '
        Me.btthoat.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btthoat.BackgroundImage = CType(resources.GetObject("btthoat.BackgroundImage"), System.Drawing.Image)
        Me.btthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btthoat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btthoat.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btthoat.ForeColor = System.Drawing.Color.Black
        Me.btthoat.Location = New System.Drawing.Point(144, 32)
        Me.btthoat.Name = "btthoat"
        Me.btthoat.Size = New System.Drawing.Size(103, 48)
        Me.btthoat.TabIndex = 3
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
        Me.btthem.Location = New System.Drawing.Point(28, 32)
        Me.btthem.Name = "btthem"
        Me.btthem.Size = New System.Drawing.Size(100, 48)
        Me.btthem.TabIndex = 2
        Me.btthem.Text = "Thêm"
        Me.btthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btthem.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(5, 62)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(937, 151)
        Me.GroupBox1.TabIndex = 99
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Phiếu Mượn Sách"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(628, 115)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 15)
        Me.Label11.TabIndex = 101
        Me.Label11.Text = "Số Sách Đã Mượn"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(628, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 15)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "Tình Trạng Sách"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(364, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(209, 32)
        Me.Label12.TabIndex = 113
        Me.Label12.Text = "Phiếu Mượn Sách"
        '
        'PhieuMuonSachGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(966, 679)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.dgvlistSach)
        Me.Controls.Add(Me.dtpHSD)
        Me.Controls.Add(Me.dtpNgayTra)
        Me.Controls.Add(Me.dtpNgayHenTra)
        Me.Controls.Add(Me.dtpNgayMuon)
        Me.Controls.Add(Me.txtMaSach)
        Me.Controls.Add(Me.txtTinhTrangSach)
        Me.Controls.Add(Me.txtSachDaMuon)
        Me.Controls.Add(Me.txtTenSach)
        Me.Controls.Add(Me.txtTenDG)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtMaPhieu)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbDoiTuong)
        Me.Controls.Add(Me.cbMaDG)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PhieuMuonSachGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PhieuMuonSachGUI"
        CType(Me.dgvlistSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents cbMaDG As ComboBox
    Friend WithEvents txtMaPhieu As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTenDG As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTenSach As TextBox
    Friend WithEvents dtpNgayMuon As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpNgayHenTra As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpNgayTra As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpHSD As DateTimePicker
    Friend WithEvents dgvlistSach As DataGridView
    Friend WithEvents MaSach As DataGridViewTextBoxColumn
    Friend WithEvents TenSach As DataGridViewTextBoxColumn
    Friend WithEvents MaTTS As DataGridViewTextBoxColumn
    Friend WithEvents TriGia As DataGridViewTextBoxColumn
    Friend WithEvents MaTLS As DataGridViewTextBoxColumn
    Friend WithEvents TenTG As DataGridViewTextBoxColumn
    Friend WithEvents NamXB As DataGridViewTextBoxColumn
    Friend WithEvents NXB As DataGridViewTextBoxColumn
    Friend WithEvents txtMaSach As TextBox
    Friend WithEvents cbDoiTuong As ComboBox
    Friend WithEvents txtTimKiem As TextBox
    Friend WithEvents txtSachDaMuon As TextBox
    Friend WithEvents txtTinhTrangSach As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btthoat As Button
    Friend WithEvents btthem As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
End Class
