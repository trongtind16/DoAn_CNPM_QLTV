﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuyDinhGUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QuyDinhGUI))
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.xxxx = New System.Windows.Forms.Label()
        Me.txtTuoiToiDa = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHanSuDung = New System.Windows.Forms.TextBox()
        Me.txtTuoiToiThieu = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKCNXB = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSachMuonToiDa = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNgayMuonToiDa = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnThoat.BackgroundImage = CType(resources.GetObject("btnThoat.BackgroundImage"), System.Drawing.Image)
        Me.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThoat.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnThoat.ForeColor = System.Drawing.Color.Black
        Me.btnThoat.Location = New System.Drawing.Point(300, 352)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(118, 44)
        Me.btnThoat.TabIndex = 49
        Me.btnThoat.Text = "Trở Về"
        Me.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'btnCapNhat
        '
        Me.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCapNhat.BackgroundImage = CType(resources.GetObject("btnCapNhat.BackgroundImage"), System.Drawing.Image)
        Me.btnCapNhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCapNhat.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapNhat.ForeColor = System.Drawing.Color.Black
        Me.btnCapNhat.Location = New System.Drawing.Point(148, 352)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(125, 44)
        Me.btnCapNhat.TabIndex = 47
        Me.btnCapNhat.Text = "Cập Nhật"
        Me.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCapNhat.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xxxx)
        Me.GroupBox1.Controls.Add(Me.txtTuoiToiDa)
        Me.GroupBox1.Controls.Add(Me.label)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtHanSuDung)
        Me.GroupBox1.Controls.Add(Me.txtTuoiToiThieu)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(269, 129)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Quy Định 1"
        '
        'xxxx
        '
        Me.xxxx.AutoSize = True
        Me.xxxx.Location = New System.Drawing.Point(18, 56)
        Me.xxxx.Name = "xxxx"
        Me.xxxx.Size = New System.Drawing.Size(75, 17)
        Me.xxxx.TabIndex = 14
        Me.xxxx.Text = "Tuổi tối đa"
        '
        'txtTuoiToiDa
        '
        Me.txtTuoiToiDa.Location = New System.Drawing.Point(121, 56)
        Me.txtTuoiToiDa.Name = "txtTuoiToiDa"
        Me.txtTuoiToiDa.Size = New System.Drawing.Size(131, 25)
        Me.txtTuoiToiDa.TabIndex = 13
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(18, 97)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(88, 17)
        Me.label.TabIndex = 11
        Me.label.Text = "Hạn sử dụng"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Tuổi tối thiểu"
        '
        'txtHanSuDung
        '
        Me.txtHanSuDung.Location = New System.Drawing.Point(121, 94)
        Me.txtHanSuDung.Name = "txtHanSuDung"
        Me.txtHanSuDung.Size = New System.Drawing.Size(131, 25)
        Me.txtHanSuDung.TabIndex = 9
        '
        'txtTuoiToiThieu
        '
        Me.txtTuoiToiThieu.Location = New System.Drawing.Point(121, 21)
        Me.txtTuoiToiThieu.Name = "txtTuoiToiThieu"
        Me.txtTuoiToiThieu.Size = New System.Drawing.Size(131, 25)
        Me.txtTuoiToiThieu.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtKCNXB)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(299, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(269, 130)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Quy Định 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(14, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "KC Năm Xuất Bản :"
        '
        'txtKCNXB
        '
        Me.txtKCNXB.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtKCNXB.Location = New System.Drawing.Point(136, 65)
        Me.txtKCNXB.Name = "txtKCNXB"
        Me.txtKCNXB.Size = New System.Drawing.Size(126, 23)
        Me.txtKCNXB.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtSachMuonToiDa)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtNgayMuonToiDa)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(6, 150)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(562, 71)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Quy Định 3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(316, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Số Sách Mượn TĐ :"
        '
        'txtSachMuonToiDa
        '
        Me.txtSachMuonToiDa.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSachMuonToiDa.Location = New System.Drawing.Point(434, 28)
        Me.txtSachMuonToiDa.Name = "txtSachMuonToiDa"
        Me.txtSachMuonToiDa.Size = New System.Drawing.Size(130, 23)
        Me.txtSachMuonToiDa.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(14, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Số Ngày Mượn :"
        '
        'txtNgayMuonToiDa
        '
        Me.txtNgayMuonToiDa.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNgayMuonToiDa.Location = New System.Drawing.Point(132, 28)
        Me.txtNgayMuonToiDa.Name = "txtNgayMuonToiDa"
        Me.txtNgayMuonToiDa.Size = New System.Drawing.Size(130, 23)
        Me.txtNgayMuonToiDa.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(14, 68)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(586, 240)
        Me.Panel2.TabIndex = 49
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(215, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 32)
        Me.Label12.TabIndex = 114
        Me.Label12.Text = "Quy Định"
        '
        'QuyDinhGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(622, 408)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnCapNhat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "QuyDinhGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QuyDinhGUI"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnThoat As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents xxxx As Label
    Friend WithEvents txtTuoiToiDa As TextBox
    Friend WithEvents label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtHanSuDung As TextBox
    Friend WithEvents txtTuoiToiThieu As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtKCNXB As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSachMuonToiDa As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNgayMuonToiDa As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label12 As Label
End Class
