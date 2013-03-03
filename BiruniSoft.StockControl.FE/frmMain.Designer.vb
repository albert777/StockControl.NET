<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KategoriBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SatuanBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GudangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.KeluarDariProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangMasukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangKeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StatusInventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticallyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontallyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrangeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BantuanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangProgramIniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NaviBar1 = New Guifreaks.NavigationBar.NaviBar(Me.components)
        Me.NaviBand3 = New Guifreaks.NavigationBar.NaviBand(Me.components)
        Me.NaviBand2 = New Guifreaks.NavigationBar.NaviBand(Me.components)
        Me.NaviBand1 = New Guifreaks.NavigationBar.NaviBand(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.NaviBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NaviBar1.SuspendLayout()
        Me.NaviBand3.SuspendLayout()
        Me.NaviBand2.SuspendLayout()
        Me.NaviBand1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 349)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(627, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.WindowToolStripMenuItem, Me.BantuanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.WindowToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(627, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarangToolStripMenuItem, Me.KategoriBarangToolStripMenuItem, Me.SatuanBarangToolStripMenuItem, Me.GudangToolStripMenuItem, Me.ToolStripMenuItem1, Me.KeluarDariProgramToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'BarangToolStripMenuItem
        '
        Me.BarangToolStripMenuItem.Name = "BarangToolStripMenuItem"
        Me.BarangToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.BarangToolStripMenuItem.Text = "&Barang"
        '
        'KategoriBarangToolStripMenuItem
        '
        Me.KategoriBarangToolStripMenuItem.Name = "KategoriBarangToolStripMenuItem"
        Me.KategoriBarangToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.KategoriBarangToolStripMenuItem.Text = "&Kategori Barang"
        '
        'SatuanBarangToolStripMenuItem
        '
        Me.SatuanBarangToolStripMenuItem.Name = "SatuanBarangToolStripMenuItem"
        Me.SatuanBarangToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.SatuanBarangToolStripMenuItem.Text = "&Satuan Barang"
        '
        'GudangToolStripMenuItem
        '
        Me.GudangToolStripMenuItem.Name = "GudangToolStripMenuItem"
        Me.GudangToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.GudangToolStripMenuItem.Text = "&Gudang"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(176, 6)
        '
        'KeluarDariProgramToolStripMenuItem
        '
        Me.KeluarDariProgramToolStripMenuItem.Name = "KeluarDariProgramToolStripMenuItem"
        Me.KeluarDariProgramToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.KeluarDariProgramToolStripMenuItem.Text = "K&eluar dari Program"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarangMasukToolStripMenuItem, Me.BarangKeluarToolStripMenuItem, Me.ToolStripMenuItem2, Me.StatusInventoryToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.TransaksiToolStripMenuItem.Text = "&Transaksi"
        '
        'BarangMasukToolStripMenuItem
        '
        Me.BarangMasukToolStripMenuItem.Name = "BarangMasukToolStripMenuItem"
        Me.BarangMasukToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.BarangMasukToolStripMenuItem.Text = "Barang &Masuk"
        '
        'BarangKeluarToolStripMenuItem
        '
        Me.BarangKeluarToolStripMenuItem.Name = "BarangKeluarToolStripMenuItem"
        Me.BarangKeluarToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.BarangKeluarToolStripMenuItem.Text = "Barang &Keluar"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(156, 6)
        '
        'StatusInventoryToolStripMenuItem
        '
        Me.StatusInventoryToolStripMenuItem.Name = "StatusInventoryToolStripMenuItem"
        Me.StatusInventoryToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.StatusInventoryToolStripMenuItem.Text = "&Status Inventory"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem, Me.TileVerticallyToolStripMenuItem, Me.TileHorizontallyToolStripMenuItem, Me.ArrangeIconsToolStripMenuItem, Me.ToolStripMenuItem3})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.WindowToolStripMenuItem.Text = "&Window"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.CascadeToolStripMenuItem.Text = "&Cascade"
        '
        'TileVerticallyToolStripMenuItem
        '
        Me.TileVerticallyToolStripMenuItem.Name = "TileVerticallyToolStripMenuItem"
        Me.TileVerticallyToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.TileVerticallyToolStripMenuItem.Text = "Tile &Vertically"
        '
        'TileHorizontallyToolStripMenuItem
        '
        Me.TileHorizontallyToolStripMenuItem.Name = "TileHorizontallyToolStripMenuItem"
        Me.TileHorizontallyToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.TileHorizontallyToolStripMenuItem.Text = "Tile &Horizontally"
        '
        'ArrangeIconsToolStripMenuItem
        '
        Me.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        Me.ArrangeIconsToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ArrangeIconsToolStripMenuItem.Text = "&Arrange Icons"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(157, 6)
        '
        'BantuanToolStripMenuItem
        '
        Me.BantuanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TentangProgramIniToolStripMenuItem})
        Me.BantuanToolStripMenuItem.Name = "BantuanToolStripMenuItem"
        Me.BantuanToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.BantuanToolStripMenuItem.Text = "&Bantuan"
        '
        'TentangProgramIniToolStripMenuItem
        '
        Me.TentangProgramIniToolStripMenuItem.Name = "TentangProgramIniToolStripMenuItem"
        Me.TentangProgramIniToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.TentangProgramIniToolStripMenuItem.Text = "&Tentang Program Ini"
        '
        'NaviBar1
        '
        Me.NaviBar1.ActiveBand = Me.NaviBand1
        Me.NaviBar1.Controls.Add(Me.NaviBand1)
        Me.NaviBar1.Controls.Add(Me.NaviBand3)
        Me.NaviBar1.Controls.Add(Me.NaviBand2)
        Me.NaviBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.NaviBar1.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2007Silver
        Me.NaviBar1.Location = New System.Drawing.Point(0, 24)
        Me.NaviBar1.Name = "NaviBar1"
        Me.NaviBar1.Size = New System.Drawing.Size(191, 325)
        Me.NaviBar1.TabIndex = 5
        Me.NaviBar1.Text = "NaviBar1"
        Me.NaviBar1.VisibleLargeButtons = 3
        '
        'NaviBand3
        '
        '
        'NaviBand3.ClientArea
        '
        Me.NaviBand3.ClientArea.Location = New System.Drawing.Point(0, 0)
        Me.NaviBand3.ClientArea.Name = "ClientArea"
        Me.NaviBand3.ClientArea.Size = New System.Drawing.Size(189, 162)
        Me.NaviBand3.ClientArea.TabIndex = 0
        Me.NaviBand3.LargeImage = Global.BiruniSoft.StockControl.FE.My.Resources.Resources.chart
        Me.NaviBand3.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2007Silver
        Me.NaviBand3.Location = New System.Drawing.Point(1, 27)
        Me.NaviBand3.Name = "NaviBand3"
        Me.NaviBand3.Size = New System.Drawing.Size(189, 162)
        Me.NaviBand3.SmallImage = Global.BiruniSoft.StockControl.FE.My.Resources.Resources.chart1
        Me.NaviBand3.TabIndex = 7
        Me.NaviBand3.Text = "Laporan"
        '
        'NaviBand2
        '
        '
        'NaviBand2.ClientArea
        '
        Me.NaviBand2.ClientArea.Location = New System.Drawing.Point(0, 0)
        Me.NaviBand2.ClientArea.Name = "ClientArea"
        Me.NaviBand2.ClientArea.Size = New System.Drawing.Size(189, 162)
        Me.NaviBand2.ClientArea.TabIndex = 0
        Me.NaviBand2.LargeImage = Global.BiruniSoft.StockControl.FE.My.Resources.Resources.books1
        Me.NaviBand2.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2007Silver
        Me.NaviBand2.Location = New System.Drawing.Point(1, 27)
        Me.NaviBand2.Name = "NaviBand2"
        Me.NaviBand2.Size = New System.Drawing.Size(189, 162)
        Me.NaviBand2.SmallImage = Global.BiruniSoft.StockControl.FE.My.Resources.Resources.books2
        Me.NaviBand2.TabIndex = 5
        Me.NaviBand2.Text = "Transaksi"
        '
        'NaviBand1
        '
        '
        'NaviBand1.ClientArea
        '
        Me.NaviBand1.ClientArea.AutoScroll = True
        Me.NaviBand1.ClientArea.Location = New System.Drawing.Point(0, 0)
        Me.NaviBand1.ClientArea.Margin = New System.Windows.Forms.Padding(0)
        Me.NaviBand1.ClientArea.Name = "ClientArea"
        Me.NaviBand1.ClientArea.Size = New System.Drawing.Size(189, 162)
        Me.NaviBand1.ClientArea.TabIndex = 0
        Me.NaviBand1.LargeImage = Global.BiruniSoft.StockControl.FE.My.Resources.Resources.cubes1
        Me.NaviBand1.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2007Silver
        Me.NaviBand1.Location = New System.Drawing.Point(1, 27)
        Me.NaviBand1.Name = "NaviBand1"
        Me.NaviBand1.Size = New System.Drawing.Size(189, 162)
        Me.NaviBand1.SmallImage = Global.BiruniSoft.StockControl.FE.My.Resources.Resources.cubes2
        Me.NaviBand1.TabIndex = 3
        Me.NaviBand1.Text = "Master Data"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BiruniSoft.StockControl.FE.My.Resources.Resources.warehouse
        Me.ClientSize = New System.Drawing.Size(627, 371)
        Me.Controls.Add(Me.NaviBar1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Aplikasi Inventory Sederhana"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.NaviBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NaviBar1.ResumeLayout(False)
        Me.NaviBand3.ResumeLayout(False)
        Me.NaviBand2.ResumeLayout(False)
        Me.NaviBand1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KategoriBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SatuanBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GudangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KeluarDariProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarangMasukToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarangKeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StatusInventoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TentangProgramIniToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticallyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontallyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrangeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NaviBar1 As Guifreaks.NavigationBar.NaviBar
    Friend WithEvents NaviBand1 As Guifreaks.NavigationBar.NaviBand
    Friend WithEvents NaviBand2 As Guifreaks.NavigationBar.NaviBand
    Friend WithEvents NaviBand3 As Guifreaks.NavigationBar.NaviBand

End Class
