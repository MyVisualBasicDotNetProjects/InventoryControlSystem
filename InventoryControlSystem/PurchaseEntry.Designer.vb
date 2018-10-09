<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseEntry
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
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HowToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnSetPrice = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtWebsite = New System.Windows.Forms.TextBox
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtFax = New System.Windows.Forms.TextBox
        Me.txtCountry = New System.Windows.Forms.TextBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.txtPostalAddress = New System.Windows.Forms.TextBox
        Me.txtTel = New System.Windows.Forms.TextBox
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.txtSupplierName = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtGrandTotal = New System.Windows.Forms.TextBox
        Me.txtMiscellaneousCost = New System.Windows.Forms.TextBox
        Me.txtFrieghtCost = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.txtPInvoiceNo = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnAddSupInv = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.grdPurchaseInfo = New System.Windows.Forms.DataGridView
        Me.PurchaseInfoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchaseInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchaseInfoDataSet = New InventoryControlSystem.PurchaseInfoDataSet
        Me.picMinimize = New System.Windows.Forms.PictureBox
        Me.picClose = New System.Windows.Forms.PictureBox
        Me.PurchaseInfoTableAdapter = New InventoryControlSystem.PurchaseInfoDataSetTableAdapters.PurchaseInfoTableAdapter
        Me.btnHome = New System.Windows.Forms.Button
        Me.lblInfo = New System.Windows.Forms.Label
        Me.lblInfo2 = New System.Windows.Forms.Label
        Me.lblStrip = New System.Windows.Forms.Label
        Me.PartNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BrandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OriginDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NetWeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SupplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InvoiceNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdPurchaseInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseInfoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseInfoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem ~dulla^@204~ ~dulla^@204~ })
        Me.EditToolStripMenuItem.~dulla^@204~ oolStripMenuItem"
        Me.EditToo~dulla^@204~ m.Size = New System.Drawing.Size(39, ~dulla^@204~ Me.EditToolStripMenuItem.Text = "Edit~dulla^@204~ 
        'CutToolStripMenuItem
     ~dulla^@204~  Me.CutToolStripMenuItem.Name = "CutT~dulla^@204~ tem"
        Me.CutToolStripMenuItem~dulla^@204~ ystem.Drawing.Size(102, 22)
        ~dulla^@204~ ipMenuItem.Text = "Cut"
        '
 ~dulla^@204~ oolStripMenuItem
        '
        ~dulla^@204~ ripMenuItem.Name = "CopyToolStripMenu~dulla^@204~   Me.CopyToolStripMenuItem.Size = New~dulla^@204~ ng.Size(102, 22)
        Me.CopyTool~dulla^@204~ .Text = "Copy"
        '
        'P~dulla^@204~ MenuItem
        '
        Me.Paste~dulla^@204~ Item.Name = "PasteToolStripMenuItem"~dulla^@204~ asteToolStripMenuItem.Size = New Syst~dulla^@204~ ze(102, 22)
        Me.PasteToolStri~dulla^@204~ t = "Paste"
        '
        'Tool~dulla^@204~ uItem
        '
        Me.ToolsToo~dulla^@204~ m.DropDownItems.AddRange(New System.W~dulla^@204~ ToolStripItem() {Me.OptionsToolStripM~dulla^@204~       Me.ToolsToolStripMenuItem.Name ~dulla^@204~ tripMenuItem"
        Me.ToolsToolSt~dulla^@204~ ize = New System.Drawing.Size(48, 20)~dulla^@204~ ToolsToolStripMenuItem.Text = "Tools"~dulla^@204~         'OptionsToolStripMenuItem
  ~dulla^@204~     Me.OptionsToolStripMenuItem.Name ~dulla^@204~ lStripMenuItem"
        Me.OptionsTo~dulla^@204~ em.Size = New System.Drawing.Size(116~dulla^@204~   Me.OptionsToolStripMenuItem.Text = ~dulla^@204~       '
        'HelpToolStripMenuIt~dulla^@204~ 
        Me.HelpToolStripMenuItem.Dr~dulla^@204~ ddRange(New System.Windows.Forms.Tool~dulla^@204~ Me.HowToToolStripMenuItem, Me.AboutTo~dulla^@204~ em})
        Me.HelpToolStripMenuIte~dulla^@204~ pToolStripMenuItem"
        Me.HelpT~dulla^@204~ tem.Size = New System.Drawing.Size(44~dulla^@204~   Me.HelpToolStripMenuItem.Text = "He~dulla^@204~ '
        'HowToToolStripMenuItem
 ~dulla^@204~      Me.HowToToolStripMenuItem.Name =~dulla^@204~ ripMenuItem"
        Me.HowToToolStr~dulla^@204~ ze = New System.Drawing.Size(125, 22)~dulla^@204~ HowToToolStripMenuItem.Text = "How to~dulla^@204~   '
        'AboutToolStripMenuItem~dulla^@204~        Me.AboutToolStripMenuItem.Name~dulla^@204~ StripMenuItem"
        Me.AboutToolS~dulla^@204~ Size = New System.Drawing.Size(125, 2~dulla^@204~ e.AboutToolStripMenuItem.Text = "Abou~dulla^@204~ 
        'btnSetPrice
        '
  ~dulla^@204~ etPrice.Font = New System.Drawing.Fon~dulla^@204~ Sans Serif", 14.25!, System.Drawing.F~dulla^@204~ , System.Drawing.GraphicsUnit.Point, ~dulla^@204~ ))
        Me.btnSetPrice.Location =~dulla^@204~ rawing.Point(790, 736)
        Me.bt~dulla^@204~ e = "btnSetPrice"
        Me.btnSetP~dulla^@204~ ew System.Drawing.Size(174, 37)
    ~dulla^@204~ Price.TabIndex = 34
        Me.btnSe~dulla^@204~  "Go to Set Price"
        Me.btnSet~dulla^@204~ alStyleBackColor = True
        '
 ~dulla^@204~ Box1
        '
        Me.GroupBox1~dulla^@204~ (Me.Label15)
        Me.GroupBox1.Co~dulla^@204~ .txtWebsite)
        Me.GroupBox1.Co~dulla^@204~ .txtEmail)
        Me.GroupBox1.Cont~dulla^@204~ xtFax)
        Me.GroupBox1.Controls~dulla^@204~ untry)
        Me.GroupBox1.Controls~dulla^@204~ dress)
        Me.GroupBox1.Controls~dulla^@204~ stalAddress)
        Me.GroupBox1.Co~dulla^@204~ .txtTel)
        Me.GroupBox1.Contro~dulla^@204~ City)
        Me.GroupBox1.Controls.~dulla^@204~ plierName)
        Me.GroupBox1.Cont~dulla^@204~ abel14)
        Me.GroupBox1.Control~dulla^@204~ l13)
        Me.GroupBox1.Controls.A~dulla^@204~ )
        Me.GroupBox1.Controls.Add(~dulla^@204~         Me.GroupBox1.Controls.Add(Me.~dulla^@204~      Me.GroupBox1.Controls.Add(Me.Lab~dulla^@204~  Me.GroupBox1.Controls.Add(Me.Label8)~dulla^@204~ GroupBox1.Controls.Add(Me.Label1)
  ~dulla^@204~ pBox1.Location = New System.Drawing.P~dulla^@204~ )
        Me.GroupBox1.Name = "Group~dulla^@204~   Me.GroupBox1.Size = New System.Draw~dulla^@204~  185)
        Me.GroupBox1.TabIndex ~dulla^@204~ Me.GroupBox1.TabStop = False
       ~dulla^@204~ .Text = "Supplier Information"
     ~dulla^@204~  'Label15
        '
        Me.Labe~dulla^@204~ = True
        Me.Label15.Location =~dulla^@204~ rawing.Point(15, 159)
        Me.Lab~dulla^@204~ Label15"
        Me.Label15.Size = N~dulla^@204~ wing.Size(46, 13)
        Me.Label15~dulla^@204~ 7
        Me.Label15.Text = "Website~dulla^@204~ 
        'txtWebsite
        '
    ~dulla^@204~ site.Location = New System.Drawing.Po~dulla^@204~ 
        Me.txtWebsite.Name = "txtWeb~dulla^@204~   Me.txtWebsite.Size = New System.Dra~dulla^@204~ , 20)
        Me.txtWebsite.TabIndex~dulla^@204~  '
        'txtEmail
        '
   ~dulla^@204~ ail.Location = New System.Drawing.Poi~dulla^@204~ 
        Me.txtEmail.Name = "txtEmail~dulla^@204~ .txtEmail.Size = New System.Drawing.S~dulla^@204~ 
        Me.txtEmail.TabIndex = 8
  ~dulla^@204~     'txtFax
        '
        Me.tx~dulla^@204~  = New System.Drawing.Point(392, 92)~dulla^@204~ xtFax.Name = "txtFax"
        Me.txt~dulla^@204~ w System.Drawing.Size(159, 20)
     ~dulla^@204~ TabIndex = 7
        '
        'txt~dulla^@204~     '
        Me.txtCountry.Location~dulla^@204~ .Drawing.Point(392, 60)
        Me.t~dulla^@204~ e = "txtCountry"
        Me.txtCount~dulla^@204~  System.Drawing.Size(159, 20)
      ~dulla^@204~ ry.TabIndex = 6
        '
        '~dulla^@204~        '
        Me.txtAddress.Locat~dulla^@204~ tem.Drawing.Point(392, 24)
        M~dulla^@204~ Name = "txtAddress"
        Me.txtAd~dulla^@204~ New System.Drawing.Size(159, 20)
   ~dulla^@204~ dress.TabIndex = 5
        '
      ~dulla^@204~ ddress
        '
        Me.txtPost~dulla^@204~ ation = New System.Drawing.Point(97, ~dulla^@204~  Me.txtPostalAddress.Name = "txtPosta~dulla^@204~       Me.txtPostalAddress.Size = New ~dulla^@204~ g.Size(188, 20)
        Me.txtPostal~dulla^@204~ dex = 3
        '
        'txtTel
~dulla^@204~       Me.txtTel.Location = New System~dulla^@204~ t(97, 92)
        Me.txtTel.Name = "~dulla^@204~     Me.txtTel.Size = New System.Drawi~dulla^@204~ 20)
        Me.txtTel.TabIndex = 2
~dulla^@204~       'txtCity
        '
        Me~dulla^@204~ tion = New System.Drawing.Point(97, 5~dulla^@204~ e.txtCity.Name = "txtCity"
        M~dulla^@204~ e = New System.Drawing.Size(188, 20)~dulla^@204~ xtCity.TabIndex = 1
        '
     ~dulla^@204~ erName
        '
        Me.txtSupp~dulla^@204~ tion = New System.Drawing.Point(97, 2~dulla^@204~ e.txtSupplierName.Name = "txtSupplier~dulla^@204~   Me.txtSupplierName.Size = New Syste~dulla^@204~ e(188, 20)
        Me.txtSupplierNam~dulla^@204~ 0
        '
        'Label14
     ~dulla^@204~  Me.Label14.AutoSize = True
        ~dulla^@204~ cation = New System.Drawing.Point(341~dulla^@204~    Me.Label14.Name = "Label14"
     ~dulla^@204~ .Size = New System.Drawing.Size(32, 1~dulla^@204~ e.Label14.TabIndex = 7
        Me.La~dulla^@204~ "Email"
        '
        'Label13~dulla^@204~        Me.Label13.AutoSize = True
  ~dulla^@204~ l13.Location = New System.Drawing.Poi~dulla^@204~         Me.Label13.Name = "Label13"
~dulla^@204~ bel13.Size = New System.Drawing.Size(~dulla^@204~     Me.Label13.TabIndex = 6
        ~dulla^@204~ xt = "Postal Address"
        '
   ~dulla^@204~ 
        '
        Me.Label12.AutoS~dulla^@204~        Me.Label12.Location = New Syst~dulla^@204~ int(341, 92)
        Me.Label12.Name~dulla^@204~ 
        Me.Label12.Size = New System~dulla^@204~ (24, 13)
        Me.Label12.TabIndex~dulla^@204~  Me.Label12.Text = "Fax"
        '
~dulla^@204~ l11
        '
        Me.Label11.Au~dulla^@204~ 
        Me.Label11.Location = New S~dulla^@204~ .Point(15, 92)
        Me.Label11.Na~dulla^@204~ "
        Me.Label11.Size = New Syst~dulla^@204~ ze(22, 13)
        Me.Label11.TabInd~dulla^@204~    Me.Label11.Text = "Tel"
        '~dulla^@204~ bel10
        '
        Me.Label10.~dulla^@204~ ue
        Me.Label10.Location = New~dulla^@204~ ng.Point(341, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size~dulla^@204~ .Drawing.Size(43, 13)
        Me.Lab~dulla^@204~  = 3
        Me.Label10.Text = "Coun~dulla^@204~  '
        'Label9
        '
     ~dulla^@204~ AutoSize = True
        Me.Label9.Lo~dulla^@204~ System.Drawing.Point(15, 62)
       ~dulla^@204~ me = "Label9"
        Me.Label9.Size~dulla^@204~ .Drawing.Size(24, 13)
        Me.Lab~dulla^@204~ = 2
        Me.Label9.Text = "City"~dulla^@204~        'Label8
        '
        Me~dulla^@204~ ize = True
        Me.Label8.Locatio~dulla^@204~ m.Drawing.Point(341, 25)
        Me.~dulla^@204~  "Label8"
        Me.Label8.Size = N~dulla^@204~ wing.Size(45, 13)
        Me.Label8.~dulla^@204~ 
        Me.Label8.Text = "Address"
~dulla^@204~       'Label1
        '
        Me.~dulla^@204~ ze = True
        Me.Label1.Location~dulla^@204~ .Drawing.Point(15, 27)
        Me.La~dulla^@204~ Label1"
        Me.Label1.Size = New~dulla^@204~ ng.Size(76, 13)
        Me.Label1.Ta~dulla^@204~        Me.Label1.Text = "Supplier Nam~dulla^@204~ 
        'GroupBox3
        '
    ~dulla^@204~ ox3.Controls.Add(Me.txtGrandTotal)
 ~dulla^@204~ upBox3.Controls.Add(Me.txtMiscellaneo~dulla^@204~     Me.GroupBox3.Controls.Add(Me.txtF~dulla^@204~         Me.GroupBox3.Controls.Add(Me.~dulla^@204~     Me.GroupBox3.Controls.Add(Me.Labe~dulla^@204~ Me.GroupBox3.Controls.Add(Me.Label2)~dulla^@204~ roupBox3.Controls.Add(Me.txtTotal)
 ~dulla^@204~ upBox3.Controls.Add(Me.txtDate)
    ~dulla^@204~ ox3.Controls.Add(Me.txtPInvoiceNo)
 ~dulla^@204~ upBox3.Controls.Add(Me.Label18)
    ~dulla^@204~ ox3.Controls.Add(Me.Label17)
       ~dulla^@204~ .Controls.Add(Me.Label16)
        Me~dulla^@204~ cation = New System.Drawing.Point(740~dulla^@204~    Me.GroupBox3.Name = "GroupBox3"
 ~dulla^@204~ upBox3.Size = New System.Drawing.Size~dulla^@204~        Me.GroupBox3.TabIndex = 6
   ~dulla^@204~ Box3.TabStop = False
        Me.Grou~dulla^@204~ "Invoice Information"
        '
   ~dulla^@204~ dTotal
        '
        Me.txtGran~dulla^@204~ on = New System.Drawing.Point(112, 15~dulla^@204~ e.txtGrandTotal.Name = "txtGrandTotal~dulla^@204~ .txtGrandTotal.Size = New System.Draw~dulla^@204~  20)
        Me.txtGrandTotal.TabInd~dulla^@204~    '
        'txtMiscellaneousCost
~dulla^@204~       Me.txtMiscellaneousCost.Locatio~dulla^@204~ m.Drawing.Point(112, 132)
        Me~dulla^@204~ eousCost.Name = "txtMiscellaneousCost~dulla^@204~ .txtMiscellaneousCost.Size = New Syst~dulla^@204~ ze(191, 20)
        Me.txtMiscellane~dulla^@204~ dex = 4
        '
        'txtFrieg~dulla^@204~    '
        Me.txtFrieghtCost.Locat~dulla^@204~ tem.Drawing.Point(112, 106)
        ~dulla^@204~ Cost.Name = "txtFrieghtCost"
       ~dulla^@204~ tCost.Size = New System.Drawing.Size(~dulla^@204~      Me.txtFrieghtCost.TabIndex = 3
~dulla^@204~       'Label4
        '
        Me.~dulla^@204~ ze = True
        Me.Label4.Location~dulla^@204~ .Drawing.Point(9, 135)
        Me.La~dulla^@204~ Label4"
        Me.Label4.Size = New~dulla^@204~ ng.Size(98, 13)
        Me.Label4.Ta~dulla^@204~        Me.Label4.Text = "Miscellaneou~dulla^@204~     '
        'Label3
        '
  ~dulla^@204~ l3.AutoSize = True
        Me.Label3~dulla^@204~ ew System.Drawing.Point(10, 161)
   ~dulla^@204~ 3.Name = "Label3"
        Me.Label3.~dulla^@204~ stem.Drawing.Size(63, 13)
        Me~dulla^@204~ dex = 7
        Me.Label3.Text = "Gr~dulla^@204~        '
        'Label2
        '~dulla^@204~ abel2.AutoSize = True
        Me.Lab~dulla^@204~ = New System.Drawing.Point(9, 106)
 ~dulla^@204~ el2.Name = "Label2"
        Me.Label~dulla^@204~ System.Drawing.Size(76, 13)
        ~dulla^@204~ Index = 6
        Me.Label2.Text = "~dulla^@204~ e"
        '
        'txtTotal
   ~dulla^@204~    Me.txtTotal.Location = New System.~dulla^@204~ (112, 76)
        Me.txtTotal.Name =~dulla^@204~         Me.txtTotal.Size = New System~dulla^@204~ (191, 20)
        Me.txtTotal.TabInd~dulla^@204~    '
        'txtDate
        '
  ~dulla^@204~ ate.Location = New System.Drawing.Poi~dulla^@204~         Me.txtDate.Name = "txtDate"
~dulla^@204~ tDate.Size = New System.Drawing.Size(~dulla^@204~      Me.txtDate.TabIndex = 1
       ~dulla^@204~ txtPInvoiceNo
        '
        Me.~dulla^@204~ .Location = New System.Drawing.Point(~dulla^@204~      Me.txtPInvoiceNo.Name = "txtPInv~dulla^@204~     Me.txtPInvoiceNo.Size = New Syste~dulla^@204~ e(191, 20)
        Me.txtPInvoiceNo.~dulla^@204~ 
        '
        'Label18
       ~dulla^@204~ e.Label18.AutoSize = True
        Me~dulla^@204~ tion = New System.Drawing.Point(9, 80~dulla^@204~ .Label18.Name = "Label18"
        Me~dulla^@204~  = New System.Drawing.Size(31, 13)
 ~dulla^@204~ el18.TabIndex = 2
        Me.Label18~dulla^@204~ l"
        '
        'Label17
    ~dulla^@204~   Me.Label17.AutoSize = True
       ~dulla^@204~ ocation = New System.Drawing.Point(9,~dulla^@204~  Me.Label17.Name = "Label17"
       ~dulla^@204~ ize = New System.Drawing.Size(30, 13)~dulla^@204~ Label17.TabIndex = 1
        Me.Labe~dulla^@204~ ate"
        '
        'Label16
  ~dulla^@204~     Me.Label16.AutoSize = True
     ~dulla^@204~ .Location = New System.Drawing.Point(~dulla^@204~    Me.Label16.Name = "Label16"
     ~dulla^@204~ .Size = New System.Drawing.Size(59, 1~dulla^@204~ e.Label16.TabIndex = 0
        Me.La~dulla^@204~ "Invoice No"
        '
        'btn~dulla^@204~ '
        Me.btnAdd.Font = New Syste~dulla^@204~ t("Microsoft Sans Serif", 14.25!, Sys~dulla^@204~ ontStyle.Bold, System.Drawing.Graphic~dulla^@204~ CType(0, Byte))
        Me.btnAdd.Lo~dulla^@204~ System.Drawing.Point(544, 736)
     ~dulla^@204~ Name = "btnAdd"
        Me.btnAdd.Si~dulla^@204~ em.Drawing.Size(135, 37)
        Me.~dulla^@204~ ex = 41
        Me.btnAdd.Text = "Ad~dulla^@204~         Me.btnAdd.UseVisualStyleBackC~dulla^@204~         '
        'btnAddSupInv
   ~dulla^@204~    Me.btnAddSupInv.Font = New System.~dulla^@204~ "Microsoft Sans Serif", 12.0!, System~dulla^@204~ Style.Bold, System.Drawing.GraphicsUn~dulla^@204~ pe(0, Byte))
        Me.btnAddSupInv~dulla^@204~ ew System.Drawing.Point(530, 341)
  ~dulla^@204~ ddSupInv.Name = "btnAddSupInv"
     ~dulla^@204~ upInv.Size = New System.Drawing.Size(~dulla^@204~      Me.btnAddSupInv.TabIndex = 0
  ~dulla^@204~ ddSupInv.Text = "Add Supplier && Invo~dulla^@204~       Me.btnAddSupInv.UseVisualStyleB~dulla^@204~ ue
        '
        'PictureBox1
~dulla^@204~       Me.PictureBox1.BackColor = Syst~dulla^@204~ lor.White
        Me.PictureBox1.Loc~dulla^@204~ ystem.Drawing.Point(42, 659)
       ~dulla^@204~ x1.Name = "PictureBox1"
        Me.P~dulla^@204~ ze = New System.Drawing.Size(1194, 71~dulla^@204~ .PictureBox1.TabIndex = 43
        M~dulla^@204~ .TabStop = False
        '
        ~dulla^@204~ nfo
        '
        Me.grdPurchas~dulla^@204~ erateColumns = False
        Me.grdP~dulla^@204~ olumnHeadersHeightSizeMode = System.W~dulla^@204~ DataGridViewColumnHeadersHeightSizeMo~dulla^@204~         Me.grdPurchaseInfo.Columns.Ad~dulla^@204~ stem.Windows.Forms.DataGridViewColumn~dulla^@204~ DataGridViewTextBoxColumn, Me.Descrip~dulla^@204~ iewTextBoxColumn, Me.BrandDataGridVie~dulla^@204~ n, Me.OriginDataGridViewTextBoxColumn~dulla^@204~ tDataGridViewTextBoxColumn, Me.Quanti~dulla^@204~ wTextBoxColumn, Me.PriceDataGridViewT~dulla^@204~  Me.AmountDataGridViewTextBoxColumn, ~dulla^@204~ DataGridViewTextBoxColumn, Me.Invoice~dulla^@204~ wTextBoxColumn})
        Me.grdPurch~dulla^@204~ ource = Me.PurchaseInfoBindingSource1~dulla^@204~ grdPurchaseInfo.Location = New System~dulla^@204~ t(104, 382)
        Me.grdPurchaseIn~dulla^@204~ dPurchaseInfo"
        Me.grdPurchas~dulla^@204~ New System.Drawing.Size(1043, 333)
 ~dulla^@204~ PurchaseInfo.TabIndex = 44
        '~dulla^@204~ rchaseInfoBindingSource1
        '
~dulla^@204~ rchaseInfoBindingSource1.DataMember =~dulla^@204~ o"
        Me.PurchaseInfoBindingSou~dulla^@204~ ce = Me.PurchaseInfoBindingSource
  ~dulla^@204~     'PurchaseInfoBindingSource
     ~dulla^@204~  Me.PurchaseInfoBindingSource.DataSou~dulla^@204~ haseInfoDataSet
        Me.PurchaseInfoBindingSource.Position = 0
        '
~dulla^@204~ haseInfoDataSet
        '
        M~dulla^@204~ oDataSet.DataSetName = "PurchaseInfoD~dulla^@204~     Me.PurchaseInfoDataSet.SchemaSeri~dulla^@204~  = System.Data.SchemaSerializationMod~dulla^@204~ ma
        '
        'picMinimize
~dulla^@204~       Me.picMinimize.Image = Global.I~dulla^@204~ olSystem.My.Resources.Resources.minim~dulla^@204~ Me.picMinimize.Location = New System.~dulla^@204~ (1127, 25)
        Me.picMinimize.Na~dulla^@204~ mize"
        Me.picMinimize.Size = ~dulla^@204~ awing.Size(21, 19)
        Me.picMin~dulla^@204~ e = System.Windows.Forms.PictureBoxSi~dulla^@204~ ze
        Me.picMinimize.TabIndex =~dulla^@204~ Me.picMinimize.TabStop = False
     ~dulla^@204~  'picClose
        '
        Me.pic~dulla^@204~  Global.InventoryControlSystem.My.Res~dulla^@204~ ces.close
        Me.picClose.Locati~dulla^@204~ em.Drawing.Point(1163, 25)
        M~dulla^@204~ me = "picClose"
        Me.picClose.~dulla^@204~ stem.Drawing.Size(22, 19)
        Me~dulla^@204~ eMode = System.Windows.Forms.PictureB~dulla^@204~ toSize
        Me.picClose.TabIndex ~dulla^@204~  Me.picClose.TabStop = False
       ~dulla^@204~ PurchaseInfoTableAdapter
        '
~dulla^@204~ rchaseInfoTableAdapter.ClearBeforeFil~dulla^@204~      '
        'btnHome
        '
~dulla^@204~ nHome.Image = Global.InventoryControl~dulla^@204~ ources.Resources.home
        Me.btn~dulla^@204~  = New System.Drawing.Point(56, 89)
~dulla^@204~ nHome.Name = "btnHome"
        Me.bt~dulla^@204~ New System.Drawing.Size(41, 39)
    ~dulla^@204~ e.TabIndex = 114
        Me.btnHome.~dulla^@204~ eBackColor = True
        '
       ~dulla^@204~       '
        Me.lblInfo.BackColor~dulla^@204~ wing.Color.Yellow
        Me.lblInfo~dulla^@204~ ew System.Drawing.Point(1088, 318)
 ~dulla^@204~ Info.Name = "lblInfo"
        Me.lbl~dulla^@204~ ew System.Drawing.Size(136, 23)
    ~dulla^@204~ o.TabIndex = 115
        Me.lblInfo.~dulla^@204~ se
        '
        'lblInfo2
   ~dulla^@204~    Me.lblInfo2.BackColor = System.Dra~dulla^@204~ llow
        Me.lblInfo2.Location = ~dulla^@204~ awing.Point(1088, 341)
        Me.lb~dulla^@204~  "lblInfo2"
        Me.lblInfo2.Size~dulla^@204~ .Drawing.Size(136, 23)
        Me.lb~dulla^@204~ ex = 116
        Me.lblInfo2.Visible~dulla^@204~      '
        'lblStrip
        '~dulla^@204~ blStrip.Location = New System.Drawing~dulla^@204~ 2)
        Me.lblStrip.Name = "lblSt~dulla^@204~  Me.lblStrip.Size = New System.Drawin~dulla^@204~ 3)
        Me.lblStrip.TabIndex = 11~dulla^@204~ .lblStrip.Text = "Information bar"
 ~dulla^@204~      'PartNoDataGridViewTextBoxColumn~dulla^@204~         Me.PartNoDataGridViewTextBoxC~dulla^@204~ pertyName = "PartNo"
        Me.Part~dulla^@204~ wTextBoxColumn.HeaderText = "PartNo"~dulla^@204~ artNoDataGridViewTextBoxColumn.Name =~dulla^@204~ ridViewTextBoxColumn"
        '
   ~dulla^@204~ tionDataGridViewTextBoxColumn
      ~dulla^@204~ Me.DescriptionDataGridViewTextBoxColu~dulla^@204~ tyName = "Description"
        Me.De~dulla^@204~ GridViewTextBoxColumn.HeaderText = "D~dulla^@204~         Me.DescriptionDataGridViewTex~dulla^@204~ me = "DescriptionDataGridViewTextBoxC~dulla^@204~    '
        'BrandDataGridViewTextB~dulla^@204~      '
        Me.BrandDataGridViewT~dulla^@204~ DataPropertyName = "Brand"
        M~dulla^@204~ idViewTextBoxColumn.HeaderText = "Bra~dulla^@204~ Me.BrandDataGridViewTextBoxColumn.Nam~dulla^@204~ aGridViewTextBoxColumn"
        '
 ~dulla^@204~ nDataGridViewTextBoxColumn
        '~dulla^@204~ OriginDataGridViewTextBoxColumn.DataP~dulla^@204~  "Origin"
        Me.OriginDataGridV~dulla^@204~ umn.HeaderText = "Origin"
        Me~dulla^@204~ idViewTextBoxColumn.Name = "OriginDat~dulla^@204~ BoxColumn"
        '
        'NetWe~dulla^@204~ iewTextBoxColumn
        '
        ~dulla^@204~ ataGridViewTextBoxColumn.DataProperty~dulla^@204~ ight"
        Me.NetWeightDataGridVi~dulla^@204~ mn.HeaderText = "NetWeight"
        ~dulla^@204~ ataGridViewTextBoxColumn.Name = "NetW~dulla^@204~ ViewTextBoxColumn"
        '
      ~dulla^@204~ taGridViewTextBoxColumn
        '
 ~dulla^@204~ ntityDataGridViewTextBoxColumn.DataPr~dulla^@204~ "Quantity"
        Me.QuantityDataGr~dulla^@204~ Column.HeaderText = "Quantity"
     ~dulla^@204~ yDataGridViewTextBoxColumn.Name = "Qu~dulla^@204~ dViewTextBoxColumn"
        '
     ~dulla^@204~ GridViewTextBoxColumn
        '
   ~dulla^@204~ DataGridViewTextBoxColumn.DataPropert~dulla^@204~ e"
        Me.PriceDataGridViewTextB~dulla^@204~ erText = "Price"
        Me.PriceDat~dulla^@204~ BoxColumn.Name = "PriceDataGridViewTe~dulla^@204~ 
        '
        'AmountDataGridVi~dulla^@204~ mn
        '
        Me.AmountDataG~dulla^@204~ xColumn.DataPropertyName = "Amount"
~dulla^@204~ ountDataGridViewTextBoxColumn.HeaderT~dulla^@204~ "
        Me.AmountDataGridViewTextB~dulla^@204~  = "AmountDataGridViewTextBoxColumn"~dulla^@204~        'SupplierIDDataGridViewTextBox~dulla^@204~    '
        Me.SupplierIDDataGridVi~dulla^@204~ mn.DataPropertyName = "SupplierID"
 ~dulla^@204~ plierIDDataGridViewTextBoxColumn.Head~dulla^@204~ plierID"
        Me.SupplierIDDataGr~dulla^@204~ Column.Name = "SupplierIDDataGridView~dulla^@204~ "
        Me.SupplierIDDataGridViewT~dulla^@204~ ReadOnly = True
        Me.SupplierI~dulla^@204~ TextBoxColumn.Resizable = System.Wind~dulla^@204~ aGridViewTriState.[True]
        '
~dulla^@204~ iceNoDataGridViewTextBoxColumn
     ~dulla^@204~  Me.InvoiceNoDataGridViewTextBoxColum~dulla^@204~ yName = "InvoiceNo"
        Me.Invoi~dulla^@204~ iewTextBoxColumn.HeaderText = "Invoic~dulla^@204~  Me.InvoiceNoDataGridViewTextBoxColum~dulla^@204~ oiceNoDataGridViewTextBoxColumn"
   ~dulla^@204~ ceNoDataGridViewTextBoxColumn.ReadOnl~dulla^@204~      '
        'PurchaseEntry
     ~dulla^@204~  Me.AutoScaleMode = System.Windows.Fo~dulla^@204~ Mode.Inherit
        Me.AutoScroll =~dulla^@204~   Me.AutoSize = True
        Me.Auto~dulla^@204~ stem.Windows.Forms.AutoSizeMode.GrowA~dulla^@204~      Me.BackgroundImage = Global.Inve~dulla^@204~ ystem.My.Resources.Resources.window
~dulla^@204~ ckgroundImageLayout = System.Windows.~dulla^@204~ yout.Stretch
        Me.ClientSize =~dulla^@204~ rawing.Size(1173, 793)
        Me.Co~dulla^@204~ .lblStrip)
        Me.Controls.Add(M~dulla^@204~         Me.Controls.Add(Me.lblInfo)
~dulla^@204~ ntrols.Add(Me.btnHome)
        Me.Co~dulla^@204~ .picClose)
        Me.Controls.Add(M~dulla^@204~ )
        Me.Controls.Add(Me.grdPurc~dulla^@204~       Me.Controls.Add(Me.PictureBox1)~dulla^@204~ Controls.Add(Me.btnAddSupInv)
      ~dulla^@204~ .Add(Me.btnAdd)
        Me.Controls.~dulla^@204~ ox3)
        Me.Controls.Add(Me.Grou~dulla^@204~    Me.Controls.Add(Me.btnSetPrice)
 ~dulla^@204~ bleBuffered = True
        Me.FormBo~dulla^@204~ ystem.Windows.Forms.FormBorderStyle.N~dulla^@204~ Me.Name = "PurchaseEntry"
        Me~dulla^@204~ n = System.Windows.Forms.FormStartPos~dulla^@204~ creen
        Me.WindowState = Syste~dulla^@204~ ms.FormWindowState.Maximized
       ~dulla^@204~ .ResumeLayout(False)
        Me.Grou~dulla^@204~ Layout()
        Me.GroupBox3.Resume~dulla^@204~ 
        Me.GroupBox3.PerformLayout(~dulla^@204~ ype(Me.PictureBox1, System.ComponentM~dulla^@204~ Initialize).EndInit()
        CType(~dulla^@204~ eInfo, System.ComponentModel.ISupport~dulla^@204~ ndInit()
        CType(Me.PurchaseIn~dulla^@204~ ce1, System.ComponentModel.ISupportIn~dulla^@204~ Init()
        CType(Me.PurchaseInfo~dulla^@204~ , System.ComponentModel.ISupportIniti~dulla^@204~ t()
        CType(Me.PurchaseInfoDat~dulla^@204~ ComponentModel.ISupportInitialize).En~dulla^@204~     CType(Me.picMinimize, System.Comp~dulla^@204~ upportInitialize).EndInit()
        ~dulla^@204~ lose, System.ComponentModel.ISupportI~dulla^@204~ dInit()
        Me.ResumeLayout(Fals~dulla^@204~ e.PerformLayout()

    End Sub
   ~dulla^@204~ vents FileToolStripMenuItem As System~dulla^@204~ s.ToolStripMenuItem
    Friend WithE~dulla^@204~ StripMenuItem As System.Windows.Forms~dulla^@204~ uItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.Tool~dulla^@204~ 
    Friend WithEvents SaveToolStrip~dulla^@204~ ystem.Windows.Forms.ToolStripMenuItem~dulla^@204~ WithEvents CloseToolStripMenuItem As ~dulla^@204~ s.Forms.ToolStripMenuItem
    Friend~dulla^@204~ ditToolStripMenuItem As System.Window~dulla^@204~ tripMenuItem
    Friend WithEvents C~dulla^@204~ nuItem As System.Windows.Forms.ToolSt~dulla^@204~     Friend WithEvents CopyToolStripMe~dulla^@204~ tem.Windows.Forms.ToolStripMenuItem
~dulla^@204~ thEvents PasteToolStripMenuItem As Sy~dulla^@204~ Forms.ToolStripMenuItem
    Friend W~dulla^@204~ lsToolStripMenuItem As System.Windows~dulla^@204~ ripMenuItem
    Friend WithEvents Op~dulla^@204~ pMenuItem As System.Windows.Forms.Too~dulla^@204~ m
    Friend WithEvents HelpToolStri~dulla^@204~ System.Windows.Forms.ToolStripMenuIte~dulla^@204~  WithEvents HowToToolStripMenuItem As~dulla^@204~ ws.Forms.ToolStripMenuItem
    Frien~dulla^@204~ AboutToolStripMenuItem As System.Wind~dulla^@204~ lStripMenuItem
    Friend WithEvents~dulla^@204~ As System.Windows.Forms.Button
    F~dulla^@204~ nts GroupBox1 As System.Windows.Forms~dulla^@204~   Friend WithEvents Label9 As System.~dulla^@204~ .Label
    Friend WithEvents Label8 ~dulla^@204~ dows.Forms.Label
    Friend WithEven~dulla^@204~ System.Windows.Forms.Label
    Frien~dulla^@204~ Label10 As System.Windows.Forms.Label~dulla^@204~ WithEvents txtEmail As System.Windows~dulla^@204~ x
    Friend WithEvents txtFax As Sy~dulla^@204~ Forms.TextBox
    Friend WithEvents ~dulla^@204~  System.Windows.Forms.TextBox
    Fr~dulla^@204~ ts txtAddress As System.Windows.Forms~dulla^@204~  Friend WithEvents txtPostalAddress A~dulla^@204~ ows.Forms.TextBox
    Friend WithEve~dulla^@204~  System.Windows.Forms.TextBox
    Fr~dulla^@204~ ts txtCity As System.Windows.Forms.Te~dulla^@204~ iend WithEvents txtSupplierName As Sy~dulla^@204~ Forms.TextBox
    Friend WithEvents ~dulla^@204~ stem.Windows.Forms.Label
    Friend ~dulla^@204~ bel13 As System.Windows.Forms.Label
~dulla^@204~ thEvents Label12 As System.Windows.Fo~dulla^@204~   Friend WithEvents Label11 As System~dulla^@204~ s.Label
    Friend WithEvents Label1~dulla^@204~ indows.Forms.Label
    Friend WithEv~dulla^@204~ te As System.Windows.Forms.TextBox
 ~dulla^@204~ hEvents GroupBox3 As System.Windows.F~dulla^@204~ 
    Friend WithEvents Label18 As Sy~dulla^@204~ Forms.Label
    Friend WithEvents La~dulla^@204~ em.Windows.Forms.Label
    Friend Wi~dulla^@204~ l16 As System.Windows.Forms.Label
  ~dulla^@204~ Events txtDate As System.Windows.Form~dulla^@204~   Friend WithEvents txtPInvoiceNo As ~dulla^@204~ s.Forms.TextBox
    Friend WithEvent~dulla^@204~ ost As System.Windows.Forms.TextBox
~dulla^@204~ thEvents Label4 As System.Windows.For~dulla^@204~  Friend WithEvents Label3 As System.W~dulla^@204~ Label
    Friend WithEvents Label2 A~dulla^@204~ ows.Forms.Label
    Friend WithEvent~dulla^@204~  System.Windows.Forms.TextBox
    Fr~dulla^@204~ ts txtGrandTotal As System.Windows.Fo~dulla^@204~     Friend WithEvents txtMiscellaneou~dulla^@204~ em.Windows.Forms.TextBox
    Friend ~dulla^@204~ nAdd As System.Windows.Forms.Button
~dulla^@204~ thEvents btnAddSupInv As System.Windo~dulla^@204~ on
    Friend WithEvents PictureBox1~dulla^@204~ ndows.Forms.PictureBox
    Friend Wi~dulla^@204~ urchaseInfo As System.Windows.Forms.D~dulla^@204~     Friend WithEvents picMinimize As ~dulla^@204~ s.Forms.PictureBox
    Friend WithEv~dulla^@204~  As System.Windows.Forms.PictureBox
~dulla^@204~ thEvents PurchaseInfoBindingSource As~dulla^@204~ ws.Forms.BindingSource
    Friend Wi~dulla^@204~ haseInfoDataSet As InventoryControlSy~dulla^@204~ InfoDataSet
    Friend WithEvents Pu~dulla^@204~ dingSource1 As System.Windows.Forms.B~dulla^@204~ 
    Friend WithEvents PurchaseInfoTa~dulla^@204~  InventoryControlSystem.PurchaseInfoD~dulla^@204~ apters.PurchaseInfoTableAdapter
    ~dulla^@204~ ents btnHome As System.Windows.Forms.~dulla^@204~ riend WithEvents lblInfo As System.Wi~dulla^@204~ abel
    Friend WithEvents lblInfo2 ~dulla^@204~ dows.Forms.Label
    Friend WithEven~dulla^@204~ s System.Windows.Forms.Label
    Fri~dulla^@204~ s PartNoDataGridViewTextBoxColumn As ~dulla^@204~ s.Forms.DataGridViewTextBoxColumn
  ~dulla^@204~ Events DescriptionDataGridViewTextBox~dulla^@204~ tem.Windows.Forms.DataGridViewTextBox~dulla^@204~ riend WithEvents BrandDataGridViewTex~dulla^@204~  System.Windows.Forms.DataGridViewTex~dulla^@204~    Friend WithEvents OriginDataGridVi~dulla^@204~ mn As System.Windows.Forms.DataGridVi~dulla^@204~ mn
    Friend WithEvents NetWeightDa~dulla^@204~ tBoxColumn As System.Windows.Forms.Da~dulla^@204~ tBoxColumn
    Friend WithEvents Qua~dulla^@204~ ViewTextBoxColumn As System.Windows.F~dulla^@204~ ViewTextBoxColumn
    Friend WithEve~dulla^@204~ GridViewTextBoxColumn As System.Windo~dulla^@204~ GridViewTextBoxColumn
    Friend Wit~dulla^@204~ tDataGridViewTextBoxColumn As System.~dulla^@204~ .DataGridViewTextBoxColumn
    Frien~dulla^@204~ SupplierIDDataGridViewTextBoxColumn A~dulla^@204~ ows.Forms.DataGridViewTextBoxColumn
~dulla^@204~ thEvents InvoiceNoDataGridViewTextBox~dulla^@204~ tem.Windows.Forms.DataGridViewTextBoxColumn
End Class
