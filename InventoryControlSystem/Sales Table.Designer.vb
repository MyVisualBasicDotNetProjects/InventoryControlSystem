<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesTable
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryControlSystemDataSet = New InventoryControlSystem.InventoryControlSystemDataSet
        Me.SalesTableAdapter = New InventoryControlSystem.InventoryControlSystemDataSetTableAdapters.SalesTableAdapter
        Me.InvoiceNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grdSales = New System.Windows.Forms.DataGridView
        Me.PartNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Prod4SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Prod4SalesDataSet = New InventoryControlSystem.Prod4SalesDataSet
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SalesInfoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesDataSet = New InventoryControlSystem.SalesDataSet
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsTableDataSet = New InventoryControlSystem.ProductsTableDataSet
        Me.BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsDataSet = New InventoryControlSystem.ProductsDataSet
        Me.btnSale = New System.Windows.Forms.Button
        Me.txtTotalAmt = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtGrandTotal = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtVat = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtGrandTotalInWords = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblInvoiceNo = New System.Windows.Forms.Label
        Me.ProductsTableAdapter = New InventoryControlSystem.ProductsDataSetTableAdapters.ProductsTableAdapter
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.picClose = New System.Windows.Forms.PictureBox
        Me.picMinimize = New System.Windows.Forms.PictureBox
        Me.btnHome = New System.Windows.Forms.Button
        Me.SalesInfoTableAdapter1 = New InventoryControlSystem.SalesInfoDataSetTableAdapters.SalesInfoTableAdapter
        Me.SalesInfoBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesInfoDataSet2 = New InventoryControlSystem.SalesInfoDataSet2
        Me.SalesInfoTableAdapter2 = New InventoryControlSystem.SalesInfoDataSet2TableAdapters.SalesInfoTableAdapter
        Me.SalesInfoDataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesInfoBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblStrip = New System.Windows.Forms.Label
        Me.ProductsTableAdapter1 = New InventoryControlSystem.ProductsTableDataSetTableAdapters.ProductsTableAdapter
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsTableAdapter2 = New InventoryControlSystem.Prod4SalesDataSetTableAdapters.ProductsTableAdapter
        Me.SalesInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesInfoTableAdapter = New InventoryControlSystem.SalesDataSetTableAdapters.SalesInfoTableAdapter
        Me.btnGoToProducts = New System.Windows.Forms.Button
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryControlSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Prod4SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Prod4SalesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesInfoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsTableDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesInfoBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesInfoDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesInfoDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesInfoBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(1004, 141)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(118, 20)
        Me.DateTimePicker1.TabIndex = 22
        Me.DateTimePicker1.Value = New Date(2008, 7, 7, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(928, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Date: "
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Sales"
        Me.BindingSource1.DataSource = Me.InventoryControlSystemDataSet
        '
        'InventoryControlSystemDataSet
        '
        Me.InventoryControlSystemDataSet.DataSetName = "InventoryControlSystemDataSet"
        Me.InventoryControlSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'InvoiceNoDataGridViewTextBoxColumn
        '
        Me.InvoiceNoDataGridViewTextBoxColumn.DataPropertyName = "InvoiceNo"
        Me.I ~dulla^@204~ ~dulla^@204~ Column.HeaderText = "InvoiceNo"
    ~dulla^@204~ eNoDataGridViewTextBoxColumn.Name = "~dulla^@204~ GridViewTextBoxColumn"
        '
  ~dulla^@204~ es
        '
        Me.grdSales.Au~dulla^@204~ umns = False
        Me.grdSales.Col~dulla^@204~ ghtSizeMode = System.Windows.Forms.Da~dulla^@204~ umnHeadersHeightSizeMode.AutoSize
  ~dulla^@204~ ales.Columns.AddRange(New System.Wind~dulla^@204~ aGridViewColumn() {Me.PartNoDataGridV~dulla^@204~ umn, Me.QuantityDataGridViewTextBoxCo~dulla^@204~ Price, Me.AmountDataGridViewTextBoxCo~dulla^@204~    Me.grdSales.DataSource = Me.SalesI~dulla^@204~ rce1
        Me.grdSales.Location = ~dulla^@204~ awing.Point(278, 181)
        Me.grd~dulla^@204~ "grdSales"
        Me.grdSales.Size ~dulla^@204~ Drawing.Size(493, 443)
        Me.gr~dulla^@204~ ex = 28
        '
        'PartNoDa~dulla^@204~ tBoxColumn
        '
        Me.Par~dulla^@204~ ewTextBoxColumn.DataPropertyName = "P~dulla^@204~    Me.PartNoDataGridViewTextBoxColumn~dulla^@204~  Me.Prod4SalesBindingSource
        ~dulla^@204~ GridViewTextBoxColumn.DisplayMember =~dulla^@204~       Me.PartNoDataGridViewTextBoxCol~dulla^@204~ t = "Part No"
        Me.PartNoDataG~dulla^@204~ xColumn.Name = "PartNoDataGridViewTex~dulla^@204~         Me.PartNoDataGridViewTextBoxC~dulla^@204~ le = System.Windows.Forms.DataGridVie~dulla^@204~ ue]
        Me.PartNoDataGridViewTex~dulla^@204~ rtMode = System.Windows.Forms.DataGri~dulla^@204~ rtMode.Automatic
        Me.PartNoDa~dulla^@204~ tBoxColumn.ValueMember = "PartNo"
  ~dulla^@204~ NoDataGridViewTextBoxColumn.Width = 1~dulla^@204~ 
        'Prod4SalesBindingSource
 ~dulla^@204~      Me.Prod4SalesBindingSource.DataM~dulla^@204~ ucts"
        Me.Prod4SalesBindingSo~dulla^@204~ ce = Me.Prod4SalesDataSet
        '~dulla^@204~ d4SalesDataSet
        '
        Me~dulla^@204~ taSet.DataSetName = "Prod4SalesDataSe~dulla^@204~ e.Prod4SalesDataSet.SchemaSerializati~dulla^@204~ em.Data.SchemaSerializationMode.Inclu~dulla^@204~      '
        'QuantityDataGridView~dulla^@204~ 
        '
        Me.QuantityDataG~dulla^@204~ xColumn.DataPropertyName = "Quantity"~dulla^@204~ QuantityDataGridViewTextBoxColumn.Hea~dulla^@204~ antity"
        Me.QuantityDataGridV~dulla^@204~ umn.Name = "QuantityDataGridViewTextB~dulla^@204~       Me.QuantityDataGridViewTextBoxC~dulla^@204~  120
        '
        'UnitPrice
~dulla^@204~       Me.UnitPrice.DataPropertyName =~dulla^@204~ 
        Me.UnitPrice.HeaderText = "~dulla^@204~        Me.UnitPrice.Name = "UnitPrice~dulla^@204~ 
        'AmountDataGridViewTextBoxCo~dulla^@204~  '
        Me.AmountDataGridViewText~dulla^@204~ aPropertyName = "Amount"
        Me.~dulla^@204~ dViewTextBoxColumn.HeaderText = "Amou~dulla^@204~ Me.AmountDataGridViewTextBoxColumn.Na~dulla^@204~ ataGridViewTextBoxColumn"
        Me~dulla^@204~ idViewTextBoxColumn.ReadOnly = True
~dulla^@204~       'SalesInfoBindingSource1
     ~dulla^@204~  Me.SalesInfoBindingSource1.DataMembe~dulla^@204~ o"
        Me.SalesInfoBindingSource~dulla^@204~ = Me.SalesDataSet
        '
       ~dulla^@204~ t
        '
        Me.SalesDataSet~dulla^@204~ = "SalesDataSet"
        Me.SalesDat~dulla^@204~ rializationMode = System.Data.SchemaS~dulla^@204~ ode.IncludeSchema
        '
       ~dulla^@204~ dingSource
        '
        Me.Pro~dulla^@204~ ource.DataMember = "Products"
      ~dulla^@204~ BindingSource.DataSource = Me.Product~dulla^@204~ 
        '
        'ProductsTableDa~dulla^@204~   '
        Me.ProductsTableDataSet.~dulla^@204~  "ProductsTableDataSet"
        Me.P~dulla^@204~ ataSet.SchemaSerializationMode = Syst~dulla^@204~ aSerializationMode.IncludeSchema
   ~dulla^@204~    'BindingSource3
        '
      ~dulla^@204~ ource3.DataMember = "Products"
     ~dulla^@204~ Source3.DataSource = Me.ProductsDataS~dulla^@204~ 
        'ProductsDataSet
        '~dulla^@204~ ProductsDataSet.DataSetName = "Produc~dulla^@204~        Me.ProductsDataSet.SchemaSeria~dulla^@204~ = System.Data.SchemaSerializationMode~dulla^@204~ a
        '
        'btnSale
     ~dulla^@204~  Me.btnSale.Font = New System.Drawing~dulla^@204~ oft Sans Serif", 18.0!, System.Drawin~dulla^@204~ old, System.Drawing.GraphicsUnit.Poin~dulla^@204~ yte))
        Me.btnSale.Location = ~dulla^@204~ awing.Point(573, 750)
        Me.btn~dulla^@204~ btnSale"
        Me.btnSale.Size = N~dulla^@204~ wing.Size(98, 38)
        Me.btnSale~dulla^@204~ 9
        Me.btnSale.Text = "&Sale"~dulla^@204~ tnSale.UseVisualStyleBackColor = True~dulla^@204~         'txtTotalAmt
        '
    ~dulla^@204~ alAmt.Location = New System.Drawing.P~dulla^@204~ 
        Me.txtTotalAmt.Name = "txtTo~dulla^@204~     Me.txtTotalAmt.ReadOnly = True
 ~dulla^@204~ TotalAmt.Size = New System.Drawing.Si~dulla^@204~         Me.txtTotalAmt.TabIndex = 37~dulla^@204~        'Label3
        '
        Me~dulla^@204~ ize = True
        Me.Label3.Locatio~dulla^@204~ m.Drawing.Point(12, 19)
        Me.L~dulla^@204~ "Label3"
        Me.Label3.Size = Ne~dulla^@204~ ing.Size(70, 13)
        Me.Label3.T~dulla^@204~ 
        Me.Label3.Text = "Total Amou~dulla^@204~ '
        'txtGrandTotal
        '~dulla^@204~ xtGrandTotal.Location = New System.Dr~dulla^@204~ 9, 74)
        Me.txtGrandTotal.Name~dulla^@204~ otal"
        Me.txtGrandTotal.ReadO~dulla^@204~        Me.txtGrandTotal.Size = New Sy~dulla^@204~ Size(133, 20)
        Me.txtGrandTot~dulla^@204~  39
        '
        'Label5
    ~dulla^@204~   Me.Label5.AutoSize = True
        ~dulla^@204~ ation = New System.Drawing.Point(13, ~dulla^@204~ Me.Label5.Name = "Label5"
        Me~dulla^@204~ = New System.Drawing.Size(63, 13)
  ~dulla^@204~ l5.TabIndex = 38
        Me.Label5.T~dulla^@204~ Total"
        '
        'txtVat
 ~dulla^@204~      Me.txtVat.Location = New System.~dulla^@204~ (99, 43)
        Me.txtVat.Name = "t~dulla^@204~    Me.txtVat.ReadOnly = True
       ~dulla^@204~ ze = New System.Drawing.Size(133, 20)~dulla^@204~ txtVat.TabIndex = 41
        '
    ~dulla^@204~         '
        Me.Label6.AutoSize~dulla^@204~     Me.Label6.Location = New System.D~dulla^@204~ 13, 47)
        Me.Label6.Name = "La~dulla^@204~   Me.Label6.Size = New System.Drawing~dulla^@204~ 
        Me.Label6.TabIndex = 40
  ~dulla^@204~ l6.Text = "VAT (15%)"
        '
   ~dulla^@204~ dTotalInWords
        '
        Me.~dulla^@204~ InWords.Location = New System.Drawing~dulla^@204~ 6)
        Me.txtGrandTotalInWords.N~dulla^@204~ ndTotalInWords"
        Me.txtGrandT~dulla^@204~ ize = New System.Drawing.Size(367, 20~dulla^@204~ .txtGrandTotalInWords.TabIndex = 43
~dulla^@204~       'Label7
        '
        Me.~dulla^@204~ ze = True
        Me.Label7.BackColo~dulla^@204~ awing.Color.Transparent
        Me.L~dulla^@204~ n = New System.Drawing.Point(89, 656)~dulla^@204~ Label7.Name = "Label7"
        Me.La~dulla^@204~ ew System.Drawing.Size(108, 13)
    ~dulla^@204~ .TabIndex = 42
        Me.Label7.Tex~dulla^@204~ tal in Words"
        '
        'Gr~dulla^@204~     '
        Me.GroupBox1.BackColor~dulla^@204~ wing.Color.Transparent
        Me.Gr~dulla^@204~ ols.Add(Me.txtVat)
        Me.GroupB~dulla^@204~ Add(Me.Label6)
        Me.GroupBox1.~dulla^@204~ Me.txtGrandTotal)
        Me.GroupBo~dulla^@204~ dd(Me.Label5)
        Me.GroupBox1.C~dulla^@204~ e.txtTotalAmt)
        Me.GroupBox1.~dulla^@204~ Me.Label3)
        Me.GroupBox1.Loca~dulla^@204~ stem.Drawing.Point(931, 628)
       ~dulla^@204~ .Name = "GroupBox1"
        Me.Group~dulla^@204~ ew System.Drawing.Size(253, 104)
   ~dulla^@204~ Box1.TabIndex = 44
        Me.GroupB~dulla^@204~  False
        Me.GroupBox1.Text = "~dulla^@204~    '
        'Label8
        '
   ~dulla^@204~ 8.AutoSize = True
        Me.Label8.~dulla^@204~ ystem.Drawing.Color.Transparent
    ~dulla^@204~ .Location = New System.Drawing.Point(~dulla^@204~       Me.Label8.Name = "Label8"
    ~dulla^@204~ .Size = New System.Drawing.Size(59, 1~dulla^@204~ e.Label8.TabIndex = 45
        Me.La~dulla^@204~ Invoice No"
        '
        'lblI~dulla^@204~      '
        Me.lblInvoiceNo.AutoSize = True
        Me.lblInvoiceNo.BackCo~dulla^@204~ Drawing.Color.Transparent
        Me~dulla^@204~ .BorderStyle = System.Windows.Forms.B~dulla^@204~ xedSingle
        Me.lblInvoiceNo.Lo~dulla^@204~ System.Drawing.Point(1004, 181)
    ~dulla^@204~ oiceNo.Name = "lblInvoiceNo"
       ~dulla^@204~ eNo.Size = New System.Drawing.Size(2,~dulla^@204~  Me.lblInvoiceNo.TabIndex = 46
     ~dulla^@204~  'ProductsTableAdapter
        '
  ~dulla^@204~ uctsTableAdapter.ClearBeforeFill = Tr~dulla^@204~ 
        'PictureBox1
        '
  ~dulla^@204~ ureBox1.Image = Global.InventoryContr~dulla^@204~ esources.Resources.helpb
        Me.~dulla^@204~ ocation = New System.Drawing.Point(11~dulla^@204~     Me.PictureBox1.Name = "PictureBox~dulla^@204~ e.PictureBox1.Size = New System.Drawi~dulla^@204~ 1)
        Me.PictureBox1.SizeMode =~dulla^@204~ ws.Forms.PictureBoxSizeMode.AutoSize~dulla^@204~ ictureBox1.TabIndex = 108
        Me~dulla^@204~ TabStop = False
        '
        '~dulla^@204~      '
        Me.picClose.Image = G~dulla^@204~ ryControlSystem.My.Resources.Resource~dulla^@204~     Me.picClose.Location = New System~dulla^@204~ t(1218, 12)
        Me.picClose.Name~dulla^@204~ 
        Me.picClose.Size = New Syst~dulla^@204~ ze(22, 19)
        Me.picClose.SizeM~dulla^@204~ Windows.Forms.PictureBoxSizeMode.Auto~dulla^@204~  Me.picClose.TabIndex = 107
        ~dulla^@204~ abStop = False
        '
        'p~dulla^@204~        '
        Me.picMinimize.Imag~dulla^@204~ ventoryControlSystem.My.Resources.Res~dulla^@204~ ze
        Me.picMinimize.Location =~dulla^@204~ rawing.Point(1150, 13)
        Me.pi~dulla^@204~ e = "picMinimize"
        Me.picMini~dulla^@204~ ew System.Drawing.Size(21, 19)
     ~dulla^@204~ mize.SizeMode = System.Windows.Forms.~dulla^@204~ eMode.AutoSize
        Me.picMinimiz~dulla^@204~ 106
        Me.picMinimize.TabStop =~dulla^@204~    '
        'btnHome
        '
  ~dulla^@204~ ome.Image = Global.InventoryControlSy~dulla^@204~ rces.Resources.home
        Me.btnHo~dulla^@204~  New System.Drawing.Point(68, 134)
 ~dulla^@204~ Home.Name = "btnHome"
        Me.btn~dulla^@204~ ew System.Drawing.Size(41, 39)
     ~dulla^@204~ .TabIndex = 115
        Me.btnHome.U~dulla^@204~ BackColor = True
        '
        ~dulla^@204~ leAdapter1
        '
        Me.Sal~dulla^@204~ apter1.ClearBeforeFill = True
      ~dulla^@204~ 'SalesInfoBindingSource2
        '
~dulla^@204~ lesInfoBindingSource2.DataMember = "S~dulla^@204~       Me.SalesInfoBindingSource2.Data~dulla^@204~ alesInfoDataSet2
        '
        ~dulla^@204~ aSet2
        '
        Me.SalesInf~dulla^@204~ aSetName = "SalesInfoDataSet2"
     ~dulla^@204~ foDataSet2.SchemaSerializationMode = ~dulla^@204~ chemaSerializationMode.IncludeSchema~dulla^@204~        'SalesInfoTableAdapter2
     ~dulla^@204~  Me.SalesInfoTableAdapter2.ClearBefor~dulla^@204~ 
        '
        'SalesInfoDataSet~dulla^@204~ e
        '
        Me.SalesInfoDat~dulla^@204~ ource.DataSource = Me.SalesInfoDataSe~dulla^@204~ e.SalesInfoDataSet2BindingSource.Posi~dulla^@204~      '
        'SalesInfoBindingSour~dulla^@204~ '
        Me.SalesInfoBindingSource3~dulla^@204~  "SalesInfo"
        Me.SalesInfoBin~dulla^@204~ ataSource = Me.SalesInfoDataSet2Bindi~dulla^@204~      '
        'lblStrip
        '~dulla^@204~ blStrip.Location = New System.Drawing~dulla^@204~ )
        Me.lblStrip.Name = "lblStr~dulla^@204~ Me.lblStrip.Size = New System.Drawing~dulla^@204~ )
        Me.lblStrip.TabIndex = 118~dulla^@204~ lblStrip.Text = "Information bar"
  ~dulla^@204~     'ProductsTableAdapter1
        '~dulla^@204~ ProductsTableAdapter1.ClearBeforeFill~dulla^@204~     '
        'ProductsTableAdapter2~dulla^@204~         Me.ProductsTableAdapter2.Clea~dulla^@204~  True
        '
        'SalesInfoB~dulla^@204~ 
        '
        Me.SalesInfoBindi~dulla^@204~ Member = "SalesInfo"
        Me.Sale~dulla^@204~ ource.DataSource = Me.SalesDataSet
 ~dulla^@204~      'SalesInfoTableAdapter
        ~dulla^@204~ .SalesInfoTableAdapter.ClearBeforeFil~dulla^@204~      '
        'btnGoToProducts
   ~dulla^@204~    Me.btnGoToProducts.Location = New ~dulla^@204~ g.Point(136, 141)
        Me.btnGoTo~dulla^@204~  = "btnGoToProducts"
        Me.btnG~dulla^@204~ ize = New System.Drawing.Size(91, 23)~dulla^@204~ btnGoToProducts.TabIndex = 119
     ~dulla^@204~ Products.Text = "&Go to Products"
  ~dulla^@204~ oToProducts.UseVisualStyleBackColor =~dulla^@204~   '
        'SalesTable
        '
~dulla^@204~ toScaleDimensions = New System.Drawin~dulla^@204~  13.0!)
        Me.AutoScaleMode = S~dulla^@204~ .Forms.AutoScaleMode.Font
        Me~dulla^@204~ age = Global.InventoryControlSystem.M~dulla^@204~ esources.bgSales
        Me.Backgrou~dulla^@204~  = System.Windows.Forms.ImageLayout.S~dulla^@204~    Me.ClientSize = New System.Drawing~dulla^@204~ 00)
        Me.Controls.Add(Me.btnGo~dulla^@204~         Me.Controls.Add(Me.lblStrip)~dulla^@204~ ontrols.Add(Me.btnHome)
        Me.C~dulla^@204~ e.PictureBox1)
        Me.Controls.A~dulla^@204~ e)
        Me.Controls.Add(Me.picMin~dulla^@204~    Me.Controls.Add(Me.lblInvoiceNo)
~dulla^@204~ ntrols.Add(Me.Label8)
        Me.Con~dulla^@204~ GroupBox1)
        Me.Controls.Add(M~dulla^@204~ alInWords)
        Me.Controls.Add(M~dulla^@204~       Me.Controls.Add(Me.btnSale)
  ~dulla^@204~ rols.Add(Me.grdSales)
        Me.Con~dulla^@204~ DateTimePicker1)
        Me.Controls~dulla^@204~ 2)
        Me.DoubleBuffered = True~dulla^@204~ ormBorderStyle = System.Windows.Forms~dulla^@204~ yle.None
        Me.Name = "SalesTab~dulla^@204~ Me.Text = "SICS - Sales Table"
     ~dulla^@204~ tate = System.Windows.Forms.FormWindo~dulla^@204~ zed
        CType(Me.BindingSource1,~dulla^@204~ nentModel.ISupportInitialize).EndInit~dulla^@204~ Type(Me.InventoryControlSystemDataSet~dulla^@204~ onentModel.ISupportInitialize).EndIni~dulla^@204~ CType(Me.grdSales, System.ComponentMo~dulla^@204~ nitialize).EndInit()
        CType(M~dulla^@204~ indingSource, System.ComponentModel.I~dulla^@204~ lize).EndInit()
        CType(Me.Pro~dulla^@204~ t, System.ComponentModel.ISupportInit~dulla^@204~ it()
        CType(Me.SalesInfoBindi~dulla^@204~ stem.ComponentModel.ISupportInitializ~dulla^@204~ 
        CType(Me.SalesDataSet, Syste~dulla^@204~ del.ISupportInitialize).EndInit()
  ~dulla^@204~ e.ProductsBindingSource, System.Compo~dulla^@204~ pportInitialize).EndInit()
        C~dulla^@204~ ctsTableDataSet, System.ComponentMode~dulla^@204~ tialize).EndInit()
        CType(Me.~dulla^@204~ 3, System.ComponentModel.ISupportInit~dulla^@204~ it()
        CType(Me.ProductsDataSe~dulla^@204~ ponentModel.ISupportInitialize).EndIn~dulla^@204~  Me.GroupBox1.ResumeLayout(False)
  ~dulla^@204~ pBox1.PerformLayout()
        CType(~dulla^@204~ 1, System.ComponentModel.ISupportInit~dulla^@204~ it()
        CType(Me.picClose, Syst~dulla^@204~ odel.ISupportInitialize).EndInit()
 ~dulla^@204~ Me.picMinimize, System.ComponentModel~dulla^@204~ ialize).EndInit()
        CType(Me.S~dulla^@204~ ngSource2, System.ComponentModel.ISup~dulla^@204~ e).EndInit()
        CType(Me.SalesI~dulla^@204~ System.ComponentModel.ISupportInitial~dulla^@204~ )
        CType(Me.SalesInfoDataSet2~dulla^@204~ , System.ComponentModel.ISupportIniti~dulla^@204~ t()
        CType(Me.SalesInfoBindin~dulla^@204~ tem.ComponentModel.ISupportInitialize~dulla^@204~         CType(Me.BindingSource2, Syst~dulla^@204~ odel.ISupportInitialize).EndInit()
 ~dulla^@204~ Me.SalesInfoBindingSource, System.Com~dulla^@204~ SupportInitialize).EndInit()
       ~dulla^@204~ out(False)
        Me.PerformLayout(~dulla^@204~ Sub
    Friend WithEvents DateTimePi~dulla^@204~ em.Windows.Forms.DateTimePicker
    ~dulla^@204~ ents Label2 As System.Windows.Forms.L~dulla^@204~ end WithEvents BindingSource1 As Syst~dulla^@204~ rms.BindingSource
    Friend WithEve~dulla^@204~ ControlSystemDataSet As InventoryCont~dulla^@204~ entoryControlSystemDataSet
    Frien~dulla^@204~ SalesTableAdapter As InventoryControl~dulla^@204~ oryControlSystemDataSetTableAdapters.~dulla^@204~ pter
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.For~dulla^@204~ ewTextBoxColumn
    Friend WithEvent~dulla^@204~ aGridViewTextBoxColumn As System.Wind~dulla^@204~ aGridViewTextBoxColumn
    Friend Wi~dulla^@204~ mountDataGridViewTextBoxColumn As Sys~dulla^@204~ orms.DataGridViewTextBoxColumn
    F~dulla^@204~ nts ModeOfPaymentDataGridViewTextBoxC~dulla^@204~ em.Windows.Forms.DataGridViewTextBoxC~dulla^@204~ iend WithEvents InvoiceNoDataGridView~dulla^@204~  As System.Windows.Forms.DataGridView~dulla^@204~ 
    Friend WithEvents grdSales As S~dulla^@204~ .Forms.DataGridView
    Friend WithE~dulla^@204~  As System.Windows.Forms.Button
    ~dulla^@204~ ents txtTotalAmt As System.Windows.Fo~dulla^@204~     Friend WithEvents Label3 As Syste~dulla^@204~ ms.Label
    Friend WithEvents txtGr~dulla^@204~ ystem.Windows.Forms.TextBox
    Frie~dulla^@204~  Label5 As System.Windows.Forms.Label~dulla^@204~ WithEvents txtVat As System.Windows.F~dulla^@204~ 
    Friend WithEvents Label6 As Syst~dulla^@204~ rms.Label
    Friend WithEvents txtG~dulla^@204~ rds As System.Windows.Forms.TextBox
~dulla^@204~ thEvents Label7 As System.Windows.For~dulla^@204~  Friend WithEvents GroupBox1 As Syste~dulla^@204~ ms.GroupBox
    Friend WithEvents La~dulla^@204~ m.Windows.Forms.Label
    Friend Wit~dulla^@204~ voiceNo As System.Windows.Forms.Label~dulla^@204~ WithEvents BindingSource3 As System.W~dulla^@204~ BindingSource
    Friend WithEvents ~dulla^@204~ et As InventoryControlSystem.Products~dulla^@204~ Friend WithEvents ProductsTableAdapte~dulla^@204~ yControlSystem.ProductsDataSetTableAd~dulla^@204~ tsTableAdapter
    Friend WithEvents~dulla^@204~  As InventoryControlSystem.SalesDataS~dulla^@204~ d WithEvents SalesInfoBindingSource A~dulla^@204~ ows.Forms.BindingSource
    Friend W~dulla^@204~ esInfoTableAdapter As InventoryContro~dulla^@204~ DataSetTableAdapters.SalesInfoTableAd~dulla^@204~ iend WithEvents SalesInfoBindingSourc~dulla^@204~ Windows.Forms.BindingSource
    Frie~dulla^@204~  PictureBox1 As System.Windows.Forms.~dulla^@204~    Friend WithEvents picClose As Syst~dulla^@204~ rms.PictureBox
    Friend WithEvents~dulla^@204~ As System.Windows.Forms.PictureBox
 ~dulla^@204~ hEvents btnHome As System.Windows.For~dulla^@204~   Friend WithEvents SalesInfoTableAda~dulla^@204~ ntoryControlSystem.SalesInfoDataSetTa~dulla^@204~ alesInfoTableAdapter
    Friend With~dulla^@204~ nfoBindingSource2 As System.Windows.F~dulla^@204~ ource
    Friend WithEvents SalesInf~dulla^@204~ InventoryControlSystem.SalesInfoDataS~dulla^@204~ nd WithEvents SalesInfoTableAdapter2 ~dulla^@204~ ontrolSystem.SalesInfoDataSet2TableAd~dulla^@204~ nfoTableAdapter
    Friend WithEvent~dulla^@204~ ndingSource3 As System.Windows.Forms.~dulla^@204~ 
    Friend WithEvents SalesInfoData~dulla^@204~ urce As System.Windows.Forms.BindingS~dulla^@204~ iend WithEvents lblStrip As System.Wi~dulla^@204~ abel
    Friend WithEvents ProductsT~dulla^@204~ s InventoryControlSystem.ProductsTabl~dulla^@204~  Friend WithEvents ProductsBindingSou~dulla^@204~ .Windows.Forms.BindingSource
    Fri~dulla^@204~ s ProductsTableAdapter1 As InventoryC~dulla^@204~ ProductsTableDataSetTableAdapters.Pro~dulla^@204~ pter
    Friend WithEvents BindingSo~dulla^@204~ em.Windows.Forms.BindingSource
    F~dulla^@204~ nts Prod4SalesBindingSource As System~dulla^@204~ s.BindingSource
    Friend WithEvent~dulla^@204~ ataSet As InventoryControlSystem.Prod~dulla^@204~ 
    Friend WithEvents ProductsTable~dulla^@204~ nventoryControlSystem.Prod4SalesDataS~dulla^@204~ rs.ProductsTableAdapter
    Friend W~dulla^@204~ tPriceDataGridViewTextBoxColumn As Sy~dulla^@204~ Forms.DataGridViewTextBoxColumn
    ~dulla^@204~ ents btnGoToProducts As System.Window~dulla^@204~ n
    Friend WithEvents PartNoDataGr~dulla^@204~ Column As System.Windows.Forms.DataGr~dulla^@204~ xColumn
    Friend WithEvents Quanti~dulla^@204~ wTextBoxColumn As System.Windows.Form~dulla^@204~ wTextBoxColumn
    Friend WithEvents~dulla^@204~  System.Windows.Forms.DataGridViewTex~dulla^@204~    Friend WithEvents AmountDataGridVi~dulla^@204~ mn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
