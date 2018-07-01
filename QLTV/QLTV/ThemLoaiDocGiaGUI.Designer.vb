<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThemLoaiDocGiaGUI
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ThemLoaiDocGiaGUI))
        Me.btnNhap = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtMaLoai = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTenLoai = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'btnNhap
        '
        Me.btnNhap.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNhap.BackgroundImage = CType(resources.GetObject("btnNhap.BackgroundImage"), System.Drawing.Image)
        Me.btnNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnNhap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNhap.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnNhap.ForeColor = System.Drawing.Color.Black
        Me.btnNhap.Location = New System.Drawing.Point(91, 194)
        Me.btnNhap.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNhap.Name = "btnNhap"
        Me.btnNhap.Size = New System.Drawing.Size(124, 48)
        Me.btnNhap.TabIndex = 67
        Me.btnNhap.Text = "Nhập"
        Me.btnNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNhap.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(269, 194)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 48)
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "Trở Về"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtMaLoai
        '
        Me.txtMaLoai.Location = New System.Drawing.Point(147, 71)
        Me.txtMaLoai.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMaLoai.Name = "txtMaLoai"
        Me.txtMaLoai.ReadOnly = True
        Me.txtMaLoai.Size = New System.Drawing.Size(176, 22)
        Me.txtMaLoai.TabIndex = 66
        Me.txtMaLoai.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(36, 73)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Mã Loại:"
        '
        'txtTenLoai
        '
        Me.txtTenLoai.Location = New System.Drawing.Point(147, 129)
        Me.txtTenLoai.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTenLoai.Name = "txtTenLoai"
        Me.txtTenLoai.Size = New System.Drawing.Size(295, 22)
        Me.txtTenLoai.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(36, 132)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Tên Loại:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(15, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(456, 174)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thêm Loại Độc Giả"
        '
        'ThemLoaiDocGiaGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(485, 256)
        Me.Controls.Add(Me.btnNhap)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtMaLoai)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTenLoai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ThemLoaiDocGiaGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ThemLoaiDocGia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNhap As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtMaLoai As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTenLoai As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
