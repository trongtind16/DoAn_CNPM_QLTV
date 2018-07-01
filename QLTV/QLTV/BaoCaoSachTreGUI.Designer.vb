<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BaoCaoSachTreGUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BaoCaoSachTreGUI))
        Me.dgvLoadDS = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvLoadDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLoadDS
        '
        Me.dgvLoadDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLoadDS.Location = New System.Drawing.Point(51, 207)
        Me.dgvLoadDS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvLoadDS.Name = "dgvLoadDS"
        Me.dgvLoadDS.ReadOnly = True
        Me.dgvLoadDS.Size = New System.Drawing.Size(1208, 279)
        Me.dgvLoadDS.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(407, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(473, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "BÁO CÁO THỐNG KÊ SÁCH TRẢ TRỄ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(536, 143)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 32)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Thông Tin Chi Tiết"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(591, 493)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 48)
        Me.Button1.TabIndex = 69
        Me.Button1.Text = "Trở Về"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BaoCaoSachTreGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1309, 554)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvLoadDS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "BaoCaoSachTreGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BaoCaoSachTreGUI"
        CType(Me.dgvLoadDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvLoadDS As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
