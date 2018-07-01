<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PanelAnimator2 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.btnMenu = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.QLDocGia = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton4 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton6 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SideMenu = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton8 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton9 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton7 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton5 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ThemDG = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Header = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Header2 = New System.Windows.Forms.Panel()
        Me.Header3 = New System.Windows.Forms.Panel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.PanelAnimator = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuDragControl3 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SideMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Header2.SuspendLayout()
        Me.Header3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'PanelAnimator2
        '
        Me.PanelAnimator2.AnimationType = BunifuAnimatorNS.AnimationType.Particles
        Me.PanelAnimator2.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 1
        Animation1.Padding = New System.Windows.Forms.Padding(100, 50, 100, 150)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 2.0!
        Animation1.TransparencyCoeff = 0!
        Me.PanelAnimator2.DefaultAnimation = Animation1
        Me.PanelAnimator2.Interval = 30
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.BackColor = System.Drawing.Color.Transparent
        Me.PanelAnimator.SetDecoration(Me.btnMenu, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator2.SetDecoration(Me.btnMenu, BunifuAnimatorNS.DecorationType.None)
        Me.btnMenu.Image = CType(resources.GetObject("btnMenu.Image"), System.Drawing.Image)
        Me.btnMenu.ImageActive = Nothing
        Me.btnMenu.Location = New System.Drawing.Point(220, 6)
        Me.btnMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(35, 34)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMenu.TabIndex = 4
        Me.btnMenu.TabStop = False
        Me.btnMenu.Zoom = 10
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "          Loại Độc Giả"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator2.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = False
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 60.0R
        Me.BunifuFlatButton1.IsTab = True
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(4, 395)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(261, 60)
        Me.BunifuFlatButton1.TabIndex = 4
        Me.BunifuFlatButton1.Text = "          Loại Độc Giả"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'QLDocGia
        '
        Me.QLDocGia.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.QLDocGia.BackColor = System.Drawing.Color.Transparent
        Me.QLDocGia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QLDocGia.BorderRadius = 0
        Me.QLDocGia.ButtonText = "          Độc Giả"
        Me.QLDocGia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.QLDocGia, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator2.SetDecoration(Me.QLDocGia, BunifuAnimatorNS.DecorationType.None)
        Me.QLDocGia.DisabledColor = System.Drawing.Color.Gray
        Me.QLDocGia.Iconcolor = System.Drawing.Color.Transparent
        Me.QLDocGia.Iconimage = CType(resources.GetObject("QLDocGia.Iconimage"), System.Drawing.Image)
        Me.QLDocGia.Iconimage_right = Nothing
        Me.QLDocGia.Iconimage_right_Selected = Nothing
        Me.QLDocGia.Iconimage_Selected = Nothing
        Me.QLDocGia.IconMarginLeft = 0
        Me.QLDocGia.IconMarginRight = 0
        Me.QLDocGia.IconRightVisible = False
        Me.QLDocGia.IconRightZoom = 0R
        Me.QLDocGia.IconVisible = True
        Me.QLDocGia.IconZoom = 60.0R
        Me.QLDocGia.IsTab = True
        Me.QLDocGia.Location = New System.Drawing.Point(4, 57)
        Me.QLDocGia.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.QLDocGia.Name = "QLDocGia"
        Me.QLDocGia.Normalcolor = System.Drawing.Color.Transparent
        Me.QLDocGia.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.QLDocGia.OnHoverTextColor = System.Drawing.Color.Transparent
        Me.QLDocGia.selected = False
        Me.QLDocGia.Size = New System.Drawing.Size(261, 60)
        Me.QLDocGia.TabIndex = 4
        Me.QLDocGia.Text = "          Độc Giả"
        Me.QLDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.QLDocGia.Textcolor = System.Drawing.Color.Silver
        Me.QLDocGia.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 0
        Me.BunifuFlatButton3.ButtonText = "          Quy Định"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.BunifuFlatButton3, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator2.SetDecoration(Me.BunifuFlatButton3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = CType(resources.GetObject("BunifuFlatButton3.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = False
        Me.BunifuFlatButton3.IconRightZoom = 0R
        Me.BunifuFlatButton3.IconVisible = True
        Me.BunifuFlatButton3.IconZoom = 60.0R
        Me.BunifuFlatButton3.IsTab = True
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(4, 598)
        Me.BunifuFlatButton3.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(261, 60)
        Me.BunifuFlatButton3.TabIndex = 4
        Me.BunifuFlatButton3.Text = "          Quy Định"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        '
        'BunifuFlatButton4
        '
        Me.BunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton4.BorderRadius = 0
        Me.BunifuFlatButton4.ButtonText = "          Loại Sách"
        Me.BunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.BunifuFlatButton4, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator2.SetDecoration(Me.BunifuFlatButton4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.Iconimage = CType(resources.GetObject("BunifuFlatButton4.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton4.Iconimage_right = Nothing
        Me.BunifuFlatButton4.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton4.Iconimage_Selected = Nothing
        Me.BunifuFlatButton4.IconMarginLeft = 0
        Me.BunifuFlatButton4.IconMarginRight = 0
        Me.BunifuFlatButton4.IconRightVisible = False
        Me.BunifuFlatButton4.IconRightZoom = 0R
        Me.BunifuFlatButton4.IconVisible = True
        Me.BunifuFlatButton4.IconZoom = 60.0R
        Me.BunifuFlatButton4.IsTab = True
        Me.BunifuFlatButton4.Location = New System.Drawing.Point(4, 463)
        Me.BunifuFlatButton4.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuFlatButton4.Name = "BunifuFlatButton4"
        Me.BunifuFlatButton4.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.selected = False
        Me.BunifuFlatButton4.Size = New System.Drawing.Size(261, 60)
        Me.BunifuFlatButton4.TabIndex = 4
        Me.BunifuFlatButton4.Text = "          Loại Sách"
        Me.BunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton4.Textcolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton4.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        '
        'BunifuFlatButton6
        '
        Me.BunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton6.BorderRadius = 0
        Me.BunifuFlatButton6.ButtonText = "          Sách"
        Me.BunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.BunifuFlatButton6, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator2.SetDecoration(Me.BunifuFlatButton6, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.Iconimage = CType(resources.GetObject("BunifuFlatButton6.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton6.Iconimage_right = Nothing
        Me.BunifuFlatButton6.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton6.Iconimage_Selected = Nothing
        Me.BunifuFlatButton6.IconMarginLeft = 0
        Me.BunifuFlatButton6.IconMarginRight = 0
        Me.BunifuFlatButton6.IconRightVisible = False
        Me.BunifuFlatButton6.IconRightZoom = 0R
        Me.BunifuFlatButton6.IconVisible = True
        Me.BunifuFlatButton6.IconZoom = 60.0R
        Me.BunifuFlatButton6.IsTab = True
        Me.BunifuFlatButton6.Location = New System.Drawing.Point(4, 192)
        Me.BunifuFlatButton6.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuFlatButton6.Name = "BunifuFlatButton6"
        Me.BunifuFlatButton6.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.selected = False
        Me.BunifuFlatButton6.Size = New System.Drawing.Size(261, 60)
        Me.BunifuFlatButton6.TabIndex = 4
        Me.BunifuFlatButton6.Text = "          Sách"
        Me.BunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton6.Textcolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton6.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        '
        'SideMenu
        '
        Me.SideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SideMenu.Controls.Add(Me.BunifuFlatButton8)
        Me.SideMenu.Controls.Add(Me.BunifuFlatButton9)
        Me.SideMenu.Controls.Add(Me.BunifuFlatButton7)
        Me.SideMenu.Controls.Add(Me.BunifuFlatButton5)
        Me.SideMenu.Controls.Add(Me.BunifuFlatButton3)
        Me.SideMenu.Controls.Add(Me.btnMenu)
        Me.SideMenu.Controls.Add(Me.ThemDG)
        Me.SideMenu.Controls.Add(Me.BunifuFlatButton4)
        Me.SideMenu.Controls.Add(Me.BunifuFlatButton6)
        Me.SideMenu.Controls.Add(Me.QLDocGia)
        Me.SideMenu.Controls.Add(Me.BunifuFlatButton1)
        Me.PanelAnimator.SetDecoration(Me.SideMenu, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator2.SetDecoration(Me.SideMenu, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.SideMenu.Location = New System.Drawing.Point(0, 0)
        Me.SideMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SideMenu.Name = "SideMenu"
        Me.SideMenu.Size = New System.Drawing.Size(263, 970)
        Me.SideMenu.TabIndex = 4
        '
        'BunifuFlatButton8
        '
        Me.BunifuFlatButton8.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton8.BorderRadius = 0
        Me.BunifuFlatButton8.ButtonText = "          Báo Cáo"
        Me.BunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.BunifuFlatButton8, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator2.SetDecoration(Me.BunifuFlatButton8, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton8.Iconimage = CType(resources.GetObject("BunifuFlatButton8.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton8.Iconimage_right = Nothing
        Me.BunifuFlatButton8.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton8.Iconimage_Selected = Nothing
        Me.BunifuFlatButton8.IconMarginLeft = 0
        Me.BunifuFlatButton8.IconMarginRight = 0
        Me.BunifuFlatButton8.IconRightVisible = False
        Me.BunifuFlatButton8.IconRightZoom = 0R
        Me.BunifuFlatButton8.IconVisible = True
        Me.BunifuFlatButton8.IconZoom = 60.0R
        Me.BunifuFlatButton8.IsTab = True
        Me.BunifuFlatButton8.Location = New System.Drawing.Point(4, 679)
        Me.BunifuFlatButton8.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuFlatButton8.Name = "BunifuFlatButton8"
        Me.BunifuFlatButton8.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton8.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton8.selected = False
        Me.BunifuFlatButton8.Size = New System.Drawing.Size(261, 60)
        Me.BunifuFlatButton8.TabIndex = 4
        Me.BunifuFlatButton8.Text = "          Báo Cáo"
        Me.BunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton8.Textcolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton8.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        '
        'BunifuFlatButton9
        '
        Me.BunifuFlatButton9.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton9.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton9.BorderRadius = 0
        Me.BunifuFlatButton9.ButtonText = "          Thêm Phiếu Mượn"
        Me.BunifuFlatButton9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.BunifuFlatButton9, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator2.SetDecoration(Me.BunifuFlatButton9, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton9.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton9.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton9.Iconimage = CType(resources.GetObject("BunifuFlatButton9.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton9.Iconimage_right = Nothing
        Me.BunifuFlatButton9.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton9.Iconimage_Selected = Nothing
        Me.BunifuFlatButton9.IconMarginLeft = 0
        Me.BunifuFlatButton9.IconMarginRight = 0
        Me.BunifuFlatButton9.IconRightVisible = False
        Me.BunifuFlatButton9.IconRightZoom = 0R
        Me.BunifuFlatButton9.IconVisible = True
        Me.BunifuFlatButton9.IconZoom = 60.0R
        Me.BunifuFlatButton9.IsTab = True
        Me.BunifuFlatButton9.Location = New System.Drawing.Point(4, 327)
        Me.BunifuFlatButton9.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuFlatButton9.Name = "BunifuFlatButton9"
        Me.BunifuFlatButton9.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton9.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton9.OnHoverTextColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton9.selected = False
        Me.BunifuFlatButton9.Size = New System.Drawing.Size(261, 60)
        Me.BunifuFlatButton9.TabIndex = 4
        Me.BunifuFlatButton9.Text = "          Thêm Phiếu Mượn"
        Me.BunifuFlatButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton9.Textcolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton9.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        '
        'BunifuFlatButton7
        '
        Me.BunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton7.BorderRadius = 0
        Me.BunifuFlatButton7.ButtonText = "          Phiếu Mượn"
        Me.BunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.BunifuFlatButton7, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator2.SetDecoration(Me.BunifuFlatButton7, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.Iconimage = CType(resources.GetObject("BunifuFlatButton7.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton7.Iconimage_right = Nothing
        Me.BunifuFlatButton7.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton7.Iconimage_Selected = Nothing
        Me.BunifuFlatButton7.IconMarginLeft = 0
        Me.BunifuFlatButton7.IconMarginRight = 0
        Me.BunifuFlatButton7.IconRightVisible = False
        Me.BunifuFlatButton7.IconRightZoom = 0R
        Me.BunifuFlatButton7.IconVisible = True
        Me.BunifuFlatButton7.IconZoom = 60.0R
        Me.BunifuFlatButton7.IsTab = True
        Me.BunifuFlatButton7.Location = New System.Drawing.Point(4, 260)
        Me.BunifuFlatButton7.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuFlatButton7.Name = "BunifuFlatButton7"
        Me.BunifuFlatButton7.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.selected = False
        Me.BunifuFlatButton7.Size = New System.Drawing.Size(261, 60)
        Me.BunifuFlatButton7.TabIndex = 4
        Me.BunifuFlatButton7.Text = "          Phiếu Mượn"
        Me.BunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton7.Textcolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton7.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        '
        'BunifuFlatButton5
        '
        Me.BunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton5.BorderRadius = 0
        Me.BunifuFlatButton5.ButtonText = "          Tình Trạng Sách"
        Me.BunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.BunifuFlatButton5, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator2.SetDecoration(Me.BunifuFlatButton5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.Iconimage = CType(resources.GetObject("BunifuFlatButton5.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton5.Iconimage_right = Nothing
        Me.BunifuFlatButton5.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton5.Iconimage_Selected = Nothing
        Me.BunifuFlatButton5.IconMarginLeft = 0
        Me.BunifuFlatButton5.IconMarginRight = 0
        Me.BunifuFlatButton5.IconRightVisible = False
        Me.BunifuFlatButton5.IconRightZoom = 0R
        Me.BunifuFlatButton5.IconVisible = True
        Me.BunifuFlatButton5.IconZoom = 60.0R
        Me.BunifuFlatButton5.IsTab = True
        Me.BunifuFlatButton5.Location = New System.Drawing.Point(4, 530)
        Me.BunifuFlatButton5.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuFlatButton5.Name = "BunifuFlatButton5"
        Me.BunifuFlatButton5.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.selected = False
        Me.BunifuFlatButton5.Size = New System.Drawing.Size(261, 60)
        Me.BunifuFlatButton5.TabIndex = 4
        Me.BunifuFlatButton5.Text = "          Tình Trạng Sách"
        Me.BunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton5.Textcolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton5.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        '
        'ThemDG
        '
        Me.ThemDG.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ThemDG.BackColor = System.Drawing.Color.Transparent
        Me.ThemDG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ThemDG.BorderRadius = 0
        Me.ThemDG.ButtonText = "          Thêm Độc Giả"
        Me.ThemDG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.ThemDG, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator2.SetDecoration(Me.ThemDG, BunifuAnimatorNS.DecorationType.None)
        Me.ThemDG.DisabledColor = System.Drawing.Color.Gray
        Me.ThemDG.Iconcolor = System.Drawing.Color.Transparent
        Me.ThemDG.Iconimage = CType(resources.GetObject("ThemDG.Iconimage"), System.Drawing.Image)
        Me.ThemDG.Iconimage_right = Nothing
        Me.ThemDG.Iconimage_right_Selected = Nothing
        Me.ThemDG.Iconimage_Selected = Nothing
        Me.ThemDG.IconMarginLeft = 0
        Me.ThemDG.IconMarginRight = 0
        Me.ThemDG.IconRightVisible = False
        Me.ThemDG.IconRightZoom = 0R
        Me.ThemDG.IconVisible = True
        Me.ThemDG.IconZoom = 60.0R
        Me.ThemDG.IsTab = True
        Me.ThemDG.Location = New System.Drawing.Point(4, 124)
        Me.ThemDG.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ThemDG.Name = "ThemDG"
        Me.ThemDG.Normalcolor = System.Drawing.Color.Transparent
        Me.ThemDG.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ThemDG.OnHoverTextColor = System.Drawing.Color.Transparent
        Me.ThemDG.selected = False
        Me.ThemDG.Size = New System.Drawing.Size(261, 60)
        Me.ThemDG.TabIndex = 4
        Me.ThemDG.Text = "          Thêm Độc Giả"
        Me.ThemDG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ThemDG.Textcolor = System.Drawing.Color.Silver
        Me.ThemDG.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.PanelAnimator.SetDecoration(Me.Header, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator2.SetDecoration(Me.Header, BunifuAnimatorNS.DecorationType.None)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(263, 0)
        Me.Header.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(1585, 18)
        Me.Header.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PanelAnimator2.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(281, 1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.PanelAnimator2.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(327, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ĐỒ ÁN QUẢN LÝ THƯ VIỆN"
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.PanelAnimator.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator2.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(1533, 4)
        Me.BunifuImageButton2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(40, 39)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 4
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 20
        '
        'Header2
        '
        Me.Header2.Controls.Add(Me.PictureBox1)
        Me.Header2.Controls.Add(Me.Label1)
        Me.PanelAnimator.SetDecoration(Me.Header2, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator2.SetDecoration(Me.Header2, BunifuAnimatorNS.DecorationType.None)
        Me.Header2.Location = New System.Drawing.Point(292, 18)
        Me.Header2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Header2.Name = "Header2"
        Me.Header2.Size = New System.Drawing.Size(1185, 43)
        Me.Header2.TabIndex = 8
        '
        'Header3
        '
        Me.Header3.Controls.Add(Me.BunifuImageButton2)
        Me.PanelAnimator.SetDecoration(Me.Header3, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator2.SetDecoration(Me.Header3, BunifuAnimatorNS.DecorationType.None)
        Me.Header3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header3.Location = New System.Drawing.Point(263, 18)
        Me.Header3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Header3.Name = "Header3"
        Me.Header3.Size = New System.Drawing.Size(1585, 43)
        Me.Header3.TabIndex = 9
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Header
        Me.BunifuDragControl1.Vertical = True
        '
        'PanelAnimator
        '
        Me.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.PanelAnimator.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.PanelAnimator.DefaultAnimation = Animation2
        '
        'BunifuDragControl2
        '
        Me.BunifuDragControl2.Fixed = True
        Me.BunifuDragControl2.Horizontal = True
        Me.BunifuDragControl2.TargetControl = Me.Header2
        Me.BunifuDragControl2.Vertical = True
        '
        'BunifuDragControl3
        '
        Me.BunifuDragControl3.Fixed = True
        Me.BunifuDragControl3.Horizontal = True
        Me.BunifuDragControl3.TargetControl = Me.Header3
        Me.BunifuDragControl3.Vertical = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1848, 970)
        Me.Controls.Add(Me.Header2)
        Me.Controls.Add(Me.Header3)
        Me.Controls.Add(Me.Header)
        Me.Controls.Add(Me.SideMenu)
        Me.PanelAnimator2.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SideMenu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Header2.ResumeLayout(False)
        Me.Header2.PerformLayout()
        Me.Header3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents SideMenu As Panel
    Friend WithEvents BunifuFlatButton6 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PanelAnimator As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents PanelAnimator2 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BunifuFlatButton4 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents QLDocGia As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnMenu As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuFlatButton7 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton5 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Header As Panel
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuDragControl3 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Header2 As Panel
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Header3 As Panel
    Friend WithEvents BunifuFlatButton8 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ThemDG As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton9 As Bunifu.Framework.UI.BunifuFlatButton
End Class
