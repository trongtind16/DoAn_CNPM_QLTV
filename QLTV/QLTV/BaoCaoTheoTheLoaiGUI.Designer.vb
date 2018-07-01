<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BaoCaoTheoTheLoaiGUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BaoCaoTheoTheLoaiGUI))
        Me.dgvLoadDS = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbNam = New System.Windows.Forms.ComboBox()
        Me.txtTong = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cbThang = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnNhap = New System.Windows.Forms.Button()
        CType(Me.dgvLoadDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLoadDS
        '
        Me.dgvLoadDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLoadDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLoadDS.Location = New System.Drawing.Point(61, 138)
        Me.dgvLoadDS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvLoadDS.Name = "dgvLoadDS"
        Me.dgvLoadDS.Size = New System.Drawing.Size(1015, 352)
        Me.dgvLoadDS.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(208, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(711, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "BÁO CÁO THỐNG KÊ TÌNH HÌNH MƯỢN TRẢ THEO THỂ LOẠI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(466, 92)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 32)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Thông Tin Chi Tiết"
        '
        'cbNam
        '
        Me.cbNam.FormattingEnabled = True
        Me.cbNam.Items.AddRange(New Object() {"1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050"})
        Me.cbNam.Location = New System.Drawing.Point(334, 105)
        Me.cbNam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbNam.Name = "cbNam"
        Me.cbNam.Size = New System.Drawing.Size(91, 24)
        Me.cbNam.TabIndex = 11
        '
        'txtTong
        '
        Me.txtTong.Location = New System.Drawing.Point(944, 102)
        Me.txtTong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTong.Name = "txtTong"
        Me.txtTong.Size = New System.Drawing.Size(132, 22)
        Me.txtTong.TabIndex = 13
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(271, 109)
        Me.BunifuCustomLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(43, 20)
        Me.BunifuCustomLabel2.TabIndex = 12
        Me.BunifuCustomLabel2.Text = "Năm"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(66, 109)
        Me.BunifuCustomLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(53, 20)
        Me.BunifuCustomLabel1.TabIndex = 12
        Me.BunifuCustomLabel1.Text = "Tháng"
        '
        'cbThang
        '
        Me.cbThang.FormattingEnabled = True
        Me.cbThang.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbThang.Location = New System.Drawing.Point(148, 105)
        Me.cbThang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbThang.Name = "cbThang"
        Me.cbThang.Size = New System.Drawing.Size(91, 24)
        Me.cbThang.TabIndex = 11
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(864, 104)
        Me.BunifuCustomLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(45, 20)
        Me.BunifuCustomLabel3.TabIndex = 15
        Me.BunifuCustomLabel3.Text = "Tổng"
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnThoat.BackgroundImage = CType(resources.GetObject("btnThoat.BackgroundImage"), System.Drawing.Image)
        Me.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThoat.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnThoat.ForeColor = System.Drawing.Color.Black
        Me.btnThoat.Location = New System.Drawing.Point(676, 499)
        Me.btnThoat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(190, 59)
        Me.btnThoat.TabIndex = 41
        Me.btnThoat.Text = "Trở Về"
        Me.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'btnNhap
        '
        Me.btnNhap.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNhap.BackgroundImage = CType(resources.GetObject("btnNhap.BackgroundImage"), System.Drawing.Image)
        Me.btnNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnNhap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNhap.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnNhap.ForeColor = System.Drawing.Color.Black
        Me.btnNhap.Location = New System.Drawing.Point(334, 499)
        Me.btnNhap.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNhap.Name = "btnNhap"
        Me.btnNhap.Size = New System.Drawing.Size(190, 59)
        Me.btnNhap.TabIndex = 68
        Me.btnNhap.Text = "Sách Nộp Trễ"
        Me.btnNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNhap.UseVisualStyleBackColor = False
        '
        'BaoCaoTheoTheLoaiGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1141, 571)
        Me.Controls.Add(Me.btnNhap)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.txtTong)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.cbNam)
        Me.Controls.Add(Me.cbThang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvLoadDS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "BaoCaoTheoTheLoaiGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BaoCaoThetheLoaiGUI"
        CType(Me.dgvLoadDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvLoadDS As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbNam As ComboBox
    Friend WithEvents txtTong As TextBox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cbThang As ComboBox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnThoat As Button
    Friend WithEvents btnNhap As Button
End Class
