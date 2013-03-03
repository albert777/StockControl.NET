<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryStatus
    Inherits BiruniSoft.StockControl.Shared.frmList

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DsStock1 = New BiruniSoft.StockControl.[Shared].dsStock()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MeasureIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MeasureCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MeasureNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WarehouseIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WarehouseCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WarehouseNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsStock1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Size = New System.Drawing.Size(730, 67)
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(734, 32)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(145, 19)
        Me.Label1.Text = "Inventory Status"
        '
        'DsStock1
        '
        Me.DsStock1.DataSetName = "dsStock"
        Me.DsStock1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ItemIDDataGridViewTextBoxColumn, Me.ItemCodeDataGridViewTextBoxColumn, Me.ItemNameDataGridViewTextBoxColumn, Me.MeasureIDDataGridViewTextBoxColumn, Me.MeasureCodeDataGridViewTextBoxColumn, Me.MeasureNameDataGridViewTextBoxColumn, Me.WarehouseIDDataGridViewTextBoxColumn, Me.WarehouseCodeDataGridViewTextBoxColumn, Me.WarehouseNameDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn})
        Me.DataGridView1.DataMember = "Inventories"
        Me.DataGridView1.DataSource = Me.DsStock1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 67)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(730, 275)
        Me.DataGridView1.TabIndex = 1
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemIDDataGridViewTextBoxColumn
        '
        Me.ItemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID"
        Me.ItemIDDataGridViewTextBoxColumn.HeaderText = "ItemID"
        Me.ItemIDDataGridViewTextBoxColumn.Name = "ItemIDDataGridViewTextBoxColumn"
        Me.ItemIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemCodeDataGridViewTextBoxColumn
        '
        Me.ItemCodeDataGridViewTextBoxColumn.DataPropertyName = "ItemCode"
        Me.ItemCodeDataGridViewTextBoxColumn.HeaderText = "ItemCode"
        Me.ItemCodeDataGridViewTextBoxColumn.Name = "ItemCodeDataGridViewTextBoxColumn"
        Me.ItemCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemNameDataGridViewTextBoxColumn
        '
        Me.ItemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName"
        Me.ItemNameDataGridViewTextBoxColumn.HeaderText = "ItemName"
        Me.ItemNameDataGridViewTextBoxColumn.Name = "ItemNameDataGridViewTextBoxColumn"
        Me.ItemNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MeasureIDDataGridViewTextBoxColumn
        '
        Me.MeasureIDDataGridViewTextBoxColumn.DataPropertyName = "MeasureID"
        Me.MeasureIDDataGridViewTextBoxColumn.HeaderText = "MeasureID"
        Me.MeasureIDDataGridViewTextBoxColumn.Name = "MeasureIDDataGridViewTextBoxColumn"
        Me.MeasureIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MeasureCodeDataGridViewTextBoxColumn
        '
        Me.MeasureCodeDataGridViewTextBoxColumn.DataPropertyName = "MeasureCode"
        Me.MeasureCodeDataGridViewTextBoxColumn.HeaderText = "MeasureCode"
        Me.MeasureCodeDataGridViewTextBoxColumn.Name = "MeasureCodeDataGridViewTextBoxColumn"
        Me.MeasureCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MeasureNameDataGridViewTextBoxColumn
        '
        Me.MeasureNameDataGridViewTextBoxColumn.DataPropertyName = "MeasureName"
        Me.MeasureNameDataGridViewTextBoxColumn.HeaderText = "MeasureName"
        Me.MeasureNameDataGridViewTextBoxColumn.Name = "MeasureNameDataGridViewTextBoxColumn"
        Me.MeasureNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WarehouseIDDataGridViewTextBoxColumn
        '
        Me.WarehouseIDDataGridViewTextBoxColumn.DataPropertyName = "WarehouseID"
        Me.WarehouseIDDataGridViewTextBoxColumn.HeaderText = "WarehouseID"
        Me.WarehouseIDDataGridViewTextBoxColumn.Name = "WarehouseIDDataGridViewTextBoxColumn"
        Me.WarehouseIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WarehouseCodeDataGridViewTextBoxColumn
        '
        Me.WarehouseCodeDataGridViewTextBoxColumn.DataPropertyName = "WarehouseCode"
        Me.WarehouseCodeDataGridViewTextBoxColumn.HeaderText = "WarehouseCode"
        Me.WarehouseCodeDataGridViewTextBoxColumn.Name = "WarehouseCodeDataGridViewTextBoxColumn"
        Me.WarehouseCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WarehouseNameDataGridViewTextBoxColumn
        '
        Me.WarehouseNameDataGridViewTextBoxColumn.DataPropertyName = "WarehouseName"
        Me.WarehouseNameDataGridViewTextBoxColumn.HeaderText = "WarehouseName"
        Me.WarehouseNameDataGridViewTextBoxColumn.Name = "WarehouseNameDataGridViewTextBoxColumn"
        Me.WarehouseNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmInventoryStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(730, 342)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmInventoryStatus"
        Me.Text = "Inventory Status"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.DataGridView1, 0)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsStock1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DsStock1 As BiruniSoft.StockControl.Shared.dsStock
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MeasureIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MeasureCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MeasureNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WarehouseIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WarehouseCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WarehouseNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
