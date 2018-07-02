<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BaoCaoGUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BaoCaoGUI))
        Me.btthoat = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btthoat
        '
        Me.btthoat.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btthoat.BackgroundImage = CType(resources.GetObject("btthoat.BackgroundImage"), System.Drawing.Image)
        Me.btthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btthoat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btthoat.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btthoat.ForeColor = System.Drawing.Color.Black
        Me.btthoat.Location = New System.Drawing.Point(158, 184)
        Me.btthoat.Name = "btthoat"
        Me.btthoat.Size = New System.Drawing.Size(103, 48)
        Me.btthoat.TabIndex = 3
        Me.btthoat.Text = "Trở Về"
        Me.btthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btthoat.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(267, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 73)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Báo Cáo Thể Loại Sách"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(12, 88)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 73)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Báo Cáo Thống Kê Sách Trả Trễ"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(165, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 32)
        Me.Label12.TabIndex = 114
        Me.Label12.Text = "Báo Cáo"
        '
        'BaoCaoGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(454, 244)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btthoat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BaoCaoGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BaoCaoGUI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btthoat As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label12 As Label
End Class
