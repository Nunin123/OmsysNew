<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainScreen2
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
        Me.components = New System.ComponentModel.Container()
        Dim DateAdded_NameLabel As System.Windows.Forms.Label
        Dim Material_NameLabel As System.Windows.Forms.Label
        Dim StockLabel As System.Windows.Forms.Label
        Dim Selling_PriceLabel As System.Windows.Forms.Label
        Dim Unit_PriceLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnAddOrder = New System.Windows.Forms.Button()
        Me.btnDeleteOrder = New System.Windows.Forms.Button()
        Me.btnUpdateOrder = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Material_NameTextBox = New System.Windows.Forms.TextBox()
        Me.OMSysStocksDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMSysOrdersDBDataSet = New OMSys.OMSysOrdersDBDataSet()
        Me.StockTextBox = New System.Windows.Forms.TextBox()
        Me.Selling_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Unit_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateAddedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SellingPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Date_AddedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.OMSys_OrdersDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMSys_OrdersDBTableAdapter = New OMSys.OMSysOrdersDBDataSetTableAdapters.OMSys_OrdersDBTableAdapter()
        Me.TableAdapterManager = New OMSys.OMSysOrdersDBDataSetTableAdapters.TableAdapterManager()
        Me.OMSys_StocksDBTableAdapter = New OMSys.OMSysOrdersDBDataSetTableAdapters.OMSys_StocksDBTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnViewAll = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        DateAdded_NameLabel = New System.Windows.Forms.Label()
        Material_NameLabel = New System.Windows.Forms.Label()
        StockLabel = New System.Windows.Forms.Label()
        Selling_PriceLabel = New System.Windows.Forms.Label()
        Unit_PriceLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.OMSysStocksDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSysOrdersDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSys_OrdersDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateAdded_NameLabel
        '
        DateAdded_NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        DateAdded_NameLabel.AutoSize = True
        DateAdded_NameLabel.Location = New System.Drawing.Point(1084, 140)
        DateAdded_NameLabel.Name = "DateAdded_NameLabel"
        DateAdded_NameLabel.Size = New System.Drawing.Size(99, 19)
        DateAdded_NameLabel.TabIndex = 69
        DateAdded_NameLabel.Text = "Date Added:"
        '
        'Material_NameLabel
        '
        Material_NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Material_NameLabel.AutoSize = True
        Material_NameLabel.Location = New System.Drawing.Point(1084, 169)
        Material_NameLabel.Name = "Material_NameLabel"
        Material_NameLabel.Size = New System.Drawing.Size(116, 19)
        Material_NameLabel.TabIndex = 71
        Material_NameLabel.Text = "Material Name:"
        '
        'StockLabel
        '
        StockLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        StockLabel.AutoSize = True
        StockLabel.Location = New System.Drawing.Point(1084, 198)
        StockLabel.Name = "StockLabel"
        StockLabel.Size = New System.Drawing.Size(50, 19)
        StockLabel.TabIndex = 73
        StockLabel.Text = "Stock:"
        '
        'Selling_PriceLabel
        '
        Selling_PriceLabel.Location = New System.Drawing.Point(0, 0)
        Selling_PriceLabel.Name = "Selling_PriceLabel"
        Selling_PriceLabel.Size = New System.Drawing.Size(100, 23)
        Selling_PriceLabel.TabIndex = 94
        '
        'Unit_PriceLabel
        '
        Unit_PriceLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Unit_PriceLabel.AutoSize = True
        Unit_PriceLabel.Location = New System.Drawing.Point(1084, 256)
        Unit_PriceLabel.Name = "Unit_PriceLabel"
        Unit_PriceLabel.Size = New System.Drawing.Size(76, 19)
        Unit_PriceLabel.TabIndex = 77
        Unit_PriceLabel.Text = "Unit Price:"
        '
        'IDLabel
        '
        IDLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(1084, 111)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(69, 19)
        IDLabel.TabIndex = 90
        IDLabel.Text = "Order ID:"
        '
        'Label4
        '
        Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(1084, 226)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(93, 19)
        Label4.TabIndex = 95
        Label4.Text = "Selling Price:"
        '
        'btnAddOrder
        '
        Me.btnAddOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddOrder.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnAddOrder.ForeColor = System.Drawing.Color.White
        Me.btnAddOrder.Location = New System.Drawing.Point(922, 55)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.Size = New System.Drawing.Size(113, 43)
        Me.btnAddOrder.TabIndex = 3
        Me.btnAddOrder.Text = "New Stock"
        Me.btnAddOrder.UseVisualStyleBackColor = False
        '
        'btnDeleteOrder
        '
        Me.btnDeleteOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDeleteOrder.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnDeleteOrder.ForeColor = System.Drawing.Color.White
        Me.btnDeleteOrder.Location = New System.Drawing.Point(1276, 303)
        Me.btnDeleteOrder.Name = "btnDeleteOrder"
        Me.btnDeleteOrder.Size = New System.Drawing.Size(85, 43)
        Me.btnDeleteOrder.TabIndex = 11
        Me.btnDeleteOrder.Text = "Delete"
        Me.btnDeleteOrder.UseVisualStyleBackColor = False
        '
        'btnUpdateOrder
        '
        Me.btnUpdateOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdateOrder.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnUpdateOrder.ForeColor = System.Drawing.Color.White
        Me.btnUpdateOrder.Location = New System.Drawing.Point(1145, 303)
        Me.btnUpdateOrder.Name = "btnUpdateOrder"
        Me.btnUpdateOrder.Size = New System.Drawing.Size(85, 43)
        Me.btnUpdateOrder.TabIndex = 10
        Me.btnUpdateOrder.Text = "Save"
        Me.btnUpdateOrder.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 58)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Stock List"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1142, 614)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 19)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "ORDER MANAGEMENT SYSTEM"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1093, 512)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(315, 96)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "OMSYS"
        '
        'Material_NameTextBox
        '
        Me.Material_NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Material_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSysStocksDBBindingSource, "Material_Name", True))
        Me.Material_NameTextBox.Location = New System.Drawing.Point(1227, 165)
        Me.Material_NameTextBox.Name = "Material_NameTextBox"
        Me.Material_NameTextBox.Size = New System.Drawing.Size(192, 23)
        Me.Material_NameTextBox.TabIndex = 6
        '
        'OMSysStocksDBBindingSource
        '
        Me.OMSysStocksDBBindingSource.DataMember = "OMSys_StocksDB"
        Me.OMSysStocksDBBindingSource.DataSource = Me.OMSysOrdersDBDataSet
        '
        'OMSysOrdersDBDataSet
        '
        Me.OMSysOrdersDBDataSet.DataSetName = "OMSysOrdersDBDataSet"
        Me.OMSysOrdersDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StockTextBox
        '
        Me.StockTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.StockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSysStocksDBBindingSource, "Stock", True))
        Me.StockTextBox.Location = New System.Drawing.Point(1227, 194)
        Me.StockTextBox.Name = "StockTextBox"
        Me.StockTextBox.Size = New System.Drawing.Size(156, 23)
        Me.StockTextBox.TabIndex = 7
        '
        'Selling_PriceTextBox
        '
        Me.Selling_PriceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Selling_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSysStocksDBBindingSource, "Selling_Price", True))
        Me.Selling_PriceTextBox.Location = New System.Drawing.Point(1227, 223)
        Me.Selling_PriceTextBox.Name = "Selling_PriceTextBox"
        Me.Selling_PriceTextBox.Size = New System.Drawing.Size(156, 23)
        Me.Selling_PriceTextBox.TabIndex = 8
        '
        'Unit_PriceTextBox
        '
        Me.Unit_PriceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Unit_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSysStocksDBBindingSource, "Unit_Price", True))
        Me.Unit_PriceTextBox.Location = New System.Drawing.Point(1227, 252)
        Me.Unit_PriceTextBox.Name = "Unit_PriceTextBox"
        Me.Unit_PriceTextBox.Size = New System.Drawing.Size(156, 23)
        Me.Unit_PriceTextBox.TabIndex = 9
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.ColumnHeadersHeight = 29
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.DateAddedDataGridViewTextBoxColumn, Me.MaterialNameDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn, Me.SellingPriceDataGridViewTextBoxColumn, Me.UnitPriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.OMSysStocksDBBindingSource
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(30, 107)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1005, 536)
        Me.DataGridView1.TabIndex = 85
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 125
        '
        'DateAddedDataGridViewTextBoxColumn
        '
        Me.DateAddedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DateAddedDataGridViewTextBoxColumn.DataPropertyName = "Date_Added"
        Me.DateAddedDataGridViewTextBoxColumn.HeaderText = "Date Added"
        Me.DateAddedDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DateAddedDataGridViewTextBoxColumn.Name = "DateAddedDataGridViewTextBoxColumn"
        Me.DateAddedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MaterialNameDataGridViewTextBoxColumn
        '
        Me.MaterialNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MaterialNameDataGridViewTextBoxColumn.DataPropertyName = "Material_Name"
        Me.MaterialNameDataGridViewTextBoxColumn.HeaderText = "Material Name"
        Me.MaterialNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MaterialNameDataGridViewTextBoxColumn.Name = "MaterialNameDataGridViewTextBoxColumn"
        Me.MaterialNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "Stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        Me.StockDataGridViewTextBoxColumn.ReadOnly = True
        Me.StockDataGridViewTextBoxColumn.Width = 125
        '
        'SellingPriceDataGridViewTextBoxColumn
        '
        Me.SellingPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SellingPriceDataGridViewTextBoxColumn.DataPropertyName = "Selling_Price"
        DataGridViewCellStyle11.Format = "C2"
        Me.SellingPriceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.SellingPriceDataGridViewTextBoxColumn.HeaderText = "Selling Price"
        Me.SellingPriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SellingPriceDataGridViewTextBoxColumn.Name = "SellingPriceDataGridViewTextBoxColumn"
        Me.SellingPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.SellingPriceDataGridViewTextBoxColumn.Width = 116
        '
        'UnitPriceDataGridViewTextBoxColumn
        '
        Me.UnitPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.UnitPriceDataGridViewTextBoxColumn.DataPropertyName = "Unit_Price"
        DataGridViewCellStyle12.Format = "C2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.UnitPriceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle12
        Me.UnitPriceDataGridViewTextBoxColumn.HeaderText = "Unit Price"
        Me.UnitPriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UnitPriceDataGridViewTextBoxColumn.Name = "UnitPriceDataGridViewTextBoxColumn"
        Me.UnitPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.UnitPriceDataGridViewTextBoxColumn.Width = 99
        '
        'IDTextBox
        '
        Me.IDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSysStocksDBBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(1227, 107)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 23)
        Me.IDTextBox.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(1151, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 19)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "*"
        '
        'Date_AddedDateTimePicker
        '
        Me.Date_AddedDateTimePicker.AllowDrop = True
        Me.Date_AddedDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Date_AddedDateTimePicker.CustomFormat = ""
        Me.Date_AddedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMSysStocksDBBindingSource, "Date_Added", True))
        Me.Date_AddedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_AddedDateTimePicker.Location = New System.Drawing.Point(1227, 136)
        Me.Date_AddedDateTimePicker.Name = "Date_AddedDateTimePicker"
        Me.Date_AddedDateTimePicker.ShowCheckBox = True
        Me.Date_AddedDateTimePicker.Size = New System.Drawing.Size(192, 23)
        Me.Date_AddedDateTimePicker.TabIndex = 5
        Me.Date_AddedDateTimePicker.Value = New Date(2021, 1, 1, 0, 0, 0, 0)
        '
        'OMSys_OrdersDBBindingSource
        '
        Me.OMSys_OrdersDBBindingSource.DataMember = "OMSys_OrdersDB"
        Me.OMSys_OrdersDBBindingSource.DataSource = Me.OMSysOrdersDBDataSet
        '
        'OMSys_OrdersDBTableAdapter
        '
        Me.OMSys_OrdersDBTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.OMSys_OrdersDBTableAdapter = Me.OMSys_OrdersDBTableAdapter
        Me.TableAdapterManager.OMSys_OrdersV2DBTableAdapter = Nothing
        Me.TableAdapterManager.OMSys_StocksDBTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = OMSys.OMSysOrdersDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OMSys_StocksDBTableAdapter
        '
        Me.OMSys_StocksDBTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(1177, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 19)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "*"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(1195, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 19)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "*"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(1129, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 19)
        Me.Label8.TabIndex = 98
        Me.Label8.Text = "*"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(1171, 226)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 19)
        Me.Label9.TabIndex = 99
        Me.Label9.Text = "*"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(1155, 251)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 19)
        Me.Label10.TabIndex = 100
        Me.Label10.Text = "*"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(313, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 13)
        Me.Label11.TabIndex = 104
        Me.Label11.Text = "(ID, Material Name)"
        '
        'btnViewAll
        '
        Me.btnViewAll.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnViewAll.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnViewAll.ForeColor = System.Drawing.Color.White
        Me.btnViewAll.Location = New System.Drawing.Point(678, 59)
        Me.btnViewAll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(113, 43)
        Me.btnViewAll.TabIndex = 2
        Me.btnViewAll.Text = "View All"
        Me.btnViewAll.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearch.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(557, 59)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(113, 43)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSearch.Location = New System.Drawing.Point(316, 72)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(234, 23)
        Me.txtSearch.TabIndex = 0
        '
        'frmMainScreen2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1458, 678)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnViewAll)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.Date_AddedDateTimePicker)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(DateAdded_NameLabel)
        Me.Controls.Add(Material_NameLabel)
        Me.Controls.Add(Me.Material_NameTextBox)
        Me.Controls.Add(StockLabel)
        Me.Controls.Add(Me.StockTextBox)
        Me.Controls.Add(Selling_PriceLabel)
        Me.Controls.Add(Me.Selling_PriceTextBox)
        Me.Controls.Add(Unit_PriceLabel)
        Me.Controls.Add(Me.Unit_PriceTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddOrder)
        Me.Controls.Add(Me.btnDeleteOrder)
        Me.Controls.Add(Me.btnUpdateOrder)
        Me.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMainScreen2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OMSys"
        CType(Me.OMSysStocksDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMSysOrdersDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMSys_OrdersDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddOrder As Button
    Friend WithEvents btnDeleteOrder As Button
    Friend WithEvents btnUpdateOrder As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OMSysOrdersDBDataSet As OMSysOrdersDBDataSet
    Friend WithEvents OMSys_OrdersDBBindingSource As BindingSource
    Friend WithEvents OMSys_OrdersDBTableAdapter As OMSysOrdersDBDataSetTableAdapters.OMSys_OrdersDBTableAdapter
    Friend WithEvents TableAdapterManager As OMSysOrdersDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Material_NameTextBox As TextBox
    Friend WithEvents StockTextBox As TextBox
    Friend WithEvents Selling_PriceTextBox As TextBox
    Friend WithEvents Unit_PriceTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents OMSysStocksDBBindingSource As BindingSource
    Friend WithEvents OMSys_StocksDBTableAdapter As OMSysOrdersDBDataSetTableAdapters.OMSys_StocksDBTableAdapter
    Friend WithEvents Date_AddedDateTimePicker As DateTimePicker
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateAddedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SellingPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnViewAll As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
End Class
