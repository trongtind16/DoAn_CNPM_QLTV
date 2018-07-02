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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbNam = New System.Windows.Forms.ComboBox()
        Me.txtTong = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cbThang = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvLoadDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLoadDS
        '
        Me.dgvLoadDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLoadDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLoadDS.Location = New System.Drawing.Point(46, 112)
        Me.dgvLoadDS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvLoadDS.Name = "dgvLoadDS"
        Me.dgvLoadDS.Size = New System.Drawing.Size(761, 286)
        Me.dgvLoadDS.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(350, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Thông Tin Chi Tiết"
        '
        'cbNam
        '
        Me.cbNam.FormattingEnabled = True
        Me.cbNam.Items.AddRange(New Object() {"1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050"})
        Me.cbNam.Location = New System.Drawing.Point(250, 85)
        Me.cbNam.Name = "cbNam"
        Me.cbNam.Size = New System.Drawing.Size(69, 21)
        Me.cbNam.TabIndex = 1
        '
        'txtTong
        '
        Me.txtTong.Location = New System.Drawing.Point(685, 85)
        Me.txtTong.Name = "txtTong"
        Me.txtTong.Size = New System.Drawing.Size(100, 20)
        Me.txtTong.TabIndex = 4
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(203, 89)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(33, 15)
        Me.BunifuCustomLabel2.TabIndex = 12
        Me.BunifuCustomLabel2.Text = "Năm"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(50, 89)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(41, 15)
        Me.BunifuCustomLabel1.TabIndex = 12
        Me.BunifuCustomLabel1.Text = "Tháng"
        '
        'cbThang
        '
        Me.cbThang.FormattingEnabled = True
        Me.cbThang.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbThang.Location = New System.Drawing.Point(111, 85)
        Me.cbThang.Name = "cbThang"
        Me.cbThang.Size = New System.Drawing.Size(69, 21)
        Me.cbThang.TabIndex = 1
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(625, 86)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(35, 15)
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
        Me.btnThoat.Location = New System.Drawing.Point(339, 405)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(142, 48)
        Me.btnThoat.TabIndex = 3
        Me.btnThoat.Text = "Trở Về"
        Me.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(75, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(710, 32)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "BÁO CÁO THỐNG KÊ TÌNH HÌNH MƯỢN TRẢ THEO THỂ LOẠI"
        '
        'BaoCaoTheoTheLoaiGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(856, 464)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.txtTong)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.cbNam)
        Me.Controls.Add(Me.cbThang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvLoadDS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BaoCaoTheoTheLoaiGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BaoCaoThetheLoaiGUI"
        CType(Me.dgvLoadDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvLoadDS As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents cbNam As ComboBox
    Friend WithEvents txtTong As TextBox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cbThang As ComboBox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnThoat As Button
    Friend WithEvents Label1 As Label
End Class
