<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmList))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.InheritedDataGridView1 = New BiruniSoft.StockControl.[Shared].InheritedDataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InheritedDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(634, 67)
        Me.Panel1.TabIndex = 0
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.Image = Global.BiruniSoft.StockControl.[Shared].My.Resources.Resources.application_stop
        Me.Button6.Location = New System.Drawing.Point(542, 32)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(80, 27)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "&Tutup"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = Global.BiruniSoft.StockControl.[Shared].My.Resources.Resources.printer
        Me.Button5.Location = New System.Drawing.Point(394, 32)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 27)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "&Cetak"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = Global.BiruniSoft.StockControl.[Shared].My.Resources.Resources.refresh
        Me.Button4.Location = New System.Drawing.Point(313, 32)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 27)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "&Refresh"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.BiruniSoft.StockControl.[Shared].My.Resources.Resources.delete2
        Me.Button3.Location = New System.Drawing.Point(232, 32)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 27)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "&Hapus"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.BiruniSoft.StockControl.[Shared].My.Resources.Resources.edit
        Me.Button2.Location = New System.Drawing.Point(151, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 27)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "&Edit"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(70, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 27)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "T&ambah"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(66, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Programmer VB Indonesia"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BiruniSoft.StockControl.[Shared].My.Resources.Resources.index
        Me.PictureBox1.Location = New System.Drawing.Point(12, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'InheritedDataGridView1
        '
        Me.InheritedDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InheritedDataGridView1.Location = New System.Drawing.Point(0, 67)
        Me.InheritedDataGridView1.Name = "InheritedDataGridView1"
        Me.InheritedDataGridView1.Size = New System.Drawing.Size(634, 275)
        Me.InheritedDataGridView1.TabIndex = 3
        '
        'frmList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 342)
        Me.Controls.Add(Me.InheritedDataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmList"
        Me.ShowInTaskbar = False
        Me.Text = "frmBrowse"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InheritedDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Public WithEvents Button6 As System.Windows.Forms.Button
    Public WithEvents Button5 As System.Windows.Forms.Button
    Public WithEvents Button4 As System.Windows.Forms.Button
    Public WithEvents Button3 As System.Windows.Forms.Button
    Public WithEvents Button2 As System.Windows.Forms.Button
    Public WithEvents Button1 As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents InheritedDataGridView1 As BiruniSoft.StockControl.Shared.InheritedDataGridView
End Class
