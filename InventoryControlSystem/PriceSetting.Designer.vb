<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PriceSetting
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
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboPricingStrategy = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboCustomTax = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboSurTax = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.gbTaxes = New System.Windows.Forms.GroupBox
        Me.gbCosts = New System.Windows.Forms.GroupBox
        Me.lblMiscellaneousCost = New System.Windows.Forms.Label
        Me.PurchaseBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PInvoiceNoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PInvoiceNoDataSet = New InventoryControlSystem.PInvoiceNoDataSet
        Me.lblFrieghtCost = New System.Windows.Forms.Label
        Me.PurchaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchaseInfoDataSet2 = New InventoryControlSystem.PurchaseInfoDataSet2
        Me.gbMethods = New System.Windows.Forms.GroupBox
        Me.rdbManually = New System.Windows.Forms.RadioButton
        Me.rdbAutomatically = New System.Windows.Forms.RadioButton
        Me.btnSetPrice = New System.Windows.Forms.Button
        Me.grdPriceSetting = New System.Windows.Forms.DataGridView
        Me.ViewPriceSettingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriceSettingDataSet = New InventoryControlSystem.PriceSettingDataSet
        Me.ViewPriceSettingTableAdapter = New InventoryControlSystem.PriceSettingDataSetTableAdapters.ViewPriceSettingTableAdapter
        Me.PurchaseTableAdapter = New InventoryControlSystem.PurchaseInfoDataSet2TableAdapters.PurchaseTableAdapter
        Me.PurchaseInfoTableAdapter = New InventoryControlSystem.PurchaseInfoDataSet2TableAdapters.PurchaseInfoTableAdapter
        Me.btnQuantityDivision = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboInvoiceNo = New System.Windows.Forms.ComboBox
        Me.PurchaseBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.picClose = New System.Windows.Forms.PictureBox
        Me.picMinimize = New System.Windows.Forms.PictureBox
        Me.PurchaseBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.PurchaseTableAdapter1 = New InventoryControlSystem.PInvoiceNoDataSetTableAdapters.PurchaseTableAdapter
        Me.PurchaseBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchaseBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchaseBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnHome = New System.Windows.Forms.Button
        Me.gbTaxes.SuspendLayout()
        Me.gbCosts.SuspendLayout()
        CType(Me.PurchaseBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PInvoiceNoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PInvoiceNoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseInfoDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMethods.SuspendLayout()
        CType(Me.grdPriceSetting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewPriceSettingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceSettingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(11, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 13)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Frieght Cost"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Miscellaneous Costs"
        '
        'cboPricingStrategy
        '
        Me.cboPricingStrategy.FormattingEnabled = True
        Me.cboPricingStrategy.Items.AddRange(New Object() {"Strategy 1", "Strategy 2", "Strategy 3"})
        Me.cboPricingStrategy.Location = New System.Drawing.Point(166, 347)
        Me.cboPricingStrategy.Name = "cboPricingStrategy"
        Me.cboPricingStrategy.Size = New System.Drawing.Size(108, 21)
        Me.cboPricingStrategy.TabIndex = 37
        Me.cboPricingStrategy.Text = "Strategy 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(67, 350)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Pricing Strategy"
        '
        'cboCustomTax
        '
        Me.cboCustomTax.FormattingEnabled = True
        Me.cboCustomTax.Items.AddRange(New Object() {"10%", "15%", "20%", "25%"})
        Me.cboCustomTax.Location = New System.Drawing.Point(148, 16)
        Me.cboCustomTax.Name = "cboCustomTax"
        Me.cboCustomTax.Size = New System.Drawing.Size(108, 21)
        Me.cboCustomTax.TabIndex = 39
        Me.cboCustomTax.Text = "10%"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Custom Tax Rate"
        '
        'cboSurTax
        '
        Me.cboSurTax.FormattingEnabled = True
        Me.cboSurTax.Items.AddRange(New Object() {"10%", "15%", "20%", "25%"})
        Me.cboSurTax.Location = ~dulla^@204~ ~dulla^@204~ 48, 46)
        Me.cboSurTax.Name = ~dulla^@204~         Me.cboSurTax.Size = New Syste~dulla^@204~ e(108, 21)
        Me.cboSurTax.TabI~dulla^@204~       Me.cboSurTax.Text = "10%"
    ~dulla^@204~   'Label5
        '
        Me.Labe~dulla^@204~  True
        Me.Label5.Location = N~dulla^@204~ wing.Point(16, 51)
        Me.Label5~dulla^@204~ l5"
        Me.Label5.Size = New Sys~dulla^@204~ ize(70, 13)
        Me.Label5.TabInd~dulla^@204~     Me.Label5.Text = "Sur Tax Rate"
~dulla^@204~       'gbTaxes
        '
        Me~dulla^@204~ Color = System.Drawing.Color.Transpar~dulla^@204~ Me.gbTaxes.Controls.Add(Me.cboSurTax)~dulla^@204~ gbTaxes.Controls.Add(Me.Label5)
    ~dulla^@204~ s.Controls.Add(Me.cboCustomTax)
    ~dulla^@204~ s.Controls.Add(Me.Label4)
        Me~dulla^@204~ tion = New System.Drawing.Point(70, 5~dulla^@204~ Me.gbTaxes.Name = "gbTaxes"
        ~dulla^@204~ ze = New System.Drawing.Size(300, 75)~dulla^@204~ gbTaxes.TabIndex = 42
        Me.gbT~dulla^@204~ = False
        Me.gbTaxes.Text = "T~dulla^@204~   '
        'gbCosts
        '
   ~dulla^@204~ ts.BackColor = System.Drawing.Color.T~dulla^@204~        Me.gbCosts.Controls.Add(Me.lbl~dulla^@204~ Cost)
        Me.gbCosts.Controls.Ad~dulla^@204~ htCost)
        Me.gbCosts.Controls.~dulla^@204~ )
        Me.gbCosts.Controls.Add(Me~dulla^@204~       Me.gbCosts.Location = New Syste~dulla^@204~ nt(70, 409)
        Me.gbCosts.Name ~dulla^@204~         Me.gbCosts.Size = New System.~dulla^@204~ 300, 72)
        Me.gbCosts.TabIndex~dulla^@204~   Me.gbCosts.TabStop = False
       ~dulla^@204~ ext = "Costs"
        '
        'lb~dulla^@204~ sCost
        '
        Me.lblMisce~dulla^@204~ AutoSize = True
        Me.lblMiscel~dulla^@204~ orderStyle = System.Windows.Forms.Bor~dulla^@204~ dSingle
        Me.lblMiscellaneousC~dulla^@204~ ngs.Add(New System.Windows.Forms.Bind~dulla^@204~ e.PurchaseBindingSource3, "Miscellane~dulla^@204~ e))
        Me.lblMiscellaneousCost.~dulla^@204~ w System.Drawing.Point(159, 52)
    ~dulla^@204~ cellaneousCost.Name = "lblMiscellaneo~dulla^@204~     Me.lblMiscellaneousCost.Size = Ne~dulla^@204~ ing.Size(2, 15)
        Me.lblMiscel~dulla^@204~ abIndex = 34
        '
        'Pur~dulla^@204~ ource3
        '
        Me.Purchas~dulla^@204~ e3.DataMember = "Purchase"
        M~dulla^@204~ dingSource3.DataSource = Me.PInvoiceN~dulla^@204~ e
        '
        'PInvoiceNoBind~dulla^@204~       '
        Me.PInvoiceNoBinding~dulla^@204~ urce = Me.PInvoiceNoDataSet
        ~dulla^@204~ BindingSource.Position = 0
        '~dulla^@204~ nvoiceNoDataSet
        '
        M~dulla^@204~ ataSet.DataSetName = "PInvoiceNoDataS~dulla^@204~ Me.PInvoiceNoDataSet.SchemaSerializat~dulla^@204~ tem.Data.SchemaSerializationMode.Incl~dulla^@204~       '
        'lblFrieghtCost
   ~dulla^@204~    Me.lblFrieghtCost.AutoSize = True~dulla^@204~ blFrieghtCost.BorderStyle = System.Wi~dulla^@204~ orderStyle.FixedSingle
        Me.lb~dulla^@204~ DataBindings.Add(New System.Windows.F~dulla^@204~ "Text", Me.PurchaseBindingSource3, "F~dulla^@204~ , True))
        Me.lblFrieghtCost.L~dulla^@204~  System.Drawing.Point(159, 16)
     ~dulla^@204~ ghtCost.Name = "lblFrieghtCost"
    ~dulla^@204~ eghtCost.Size = New System.Drawing.Si~dulla^@204~       Me.lblFrieghtCost.TabIndex = 33~dulla^@204~         'PurchaseBindingSource
     ~dulla^@204~  Me.PurchaseBindingSource.DataMember ~dulla^@204~ 
        Me.PurchaseBindingSource.Dat~dulla^@204~ PurchaseInfoDataSet2
        '
    ~dulla^@204~ InfoDataSet2
        '
        Me.P~dulla^@204~ taSet2.DataSetName = "PurchaseInfoDat~dulla^@204~    Me.PurchaseInfoDataSet2.SchemaSeri~dulla^@204~  = System.Data.SchemaSerializationMod~dulla^@204~ ma
        '
        'gbMethods
  ~dulla^@204~     Me.gbMethods.BackColor = System.D~dulla^@204~ Transparent
        Me.gbMethods.Con~dulla^@204~ rdbManually)
        Me.gbMethods.Co~dulla^@204~ .rdbAutomatically)
        Me.gbMeth~dulla^@204~ = New System.Drawing.Point(70, 258)
~dulla^@204~ Methods.Name = "gbMethods"
        M~dulla^@204~ ize = New System.Drawing.Size(300, 64~dulla^@204~ .gbMethods.TabIndex = 44
        Me.~dulla^@204~ Stop = False
        Me.gbMethods.Te~dulla^@204~ etting Method"
        '
        'r~dulla^@204~        '
        Me.rdbManually.Auto~dulla^@204~         Me.rdbManually.Location = New~dulla^@204~ ng.Point(187, 28)
        Me.rdbManu~dulla^@204~ rdbManually"
        Me.rdbManually.~dulla^@204~ stem.Drawing.Size(67, 17)
        Me~dulla^@204~ TabIndex = 34
        Me.rdbManually~dulla^@204~ ally"
        Me.rdbManually.UseVisu~dulla^@204~ lor = True
        '
        'rdbAu~dulla^@204~         '
        Me.rdbAutomaticall~dulla^@204~ True
        Me.rdbAutomatically.Che~dulla^@204~         Me.rdbAutomatically.Location ~dulla^@204~ Drawing.Point(27, 28)
        Me.rdb~dulla^@204~ .Name = "rdbAutomatically"
        M~dulla^@204~ cally.Size = New System.Drawing.Size(~dulla^@204~     Me.rdbAutomatically.TabIndex = 33~dulla^@204~ rdbAutomatically.TabStop = True
    ~dulla^@204~ omatically.Text = "Automatically"
  ~dulla^@204~ utomatically.UseVisualStyleBackColor ~dulla^@204~    '
        'btnSetPrice
        '~dulla^@204~ btnSetPrice.Font = New System.Drawing~dulla^@204~ oft Sans Serif", 12.0!, System.Drawin~dulla^@204~ old, System.Drawing.GraphicsUnit.Poin~dulla^@204~ yte))
        Me.btnSetPrice.Locatio~dulla^@204~ m.Drawing.Point(406, 317)
        Me~dulla^@204~ Name = "btnSetPrice"
        Me.btnS~dulla^@204~ = New System.Drawing.Size(59, 51)
  ~dulla^@204~ etPrice.TabIndex = 45
        Me.btn~dulla^@204~  = "Set" & Global.Microsoft.VisualBas~dulla^@204~  Global.Microsoft.VisualBasic.ChrW(10~dulla^@204~         Me.btnSetPrice.UseVisualStyle~dulla^@204~ rue
        '
        'grdPriceSett~dulla^@204~ '
        Me.grdPriceSetting.ColumnH~dulla^@204~ izeMode = System.Windows.Forms.DataGr~dulla^@204~ eadersHeightSizeMode.AutoSize
      ~dulla^@204~ Setting.Location = New System.Drawing~dulla^@204~ 71)
        Me.grdPriceSetting.Name ~dulla^@204~ tting"
        Me.grdPriceSetting.Si~dulla^@204~ em.Drawing.Size(722, 482)
        Me~dulla^@204~ ing.TabIndex = 46
        '
       ~dulla^@204~ ttingBindingSource
        '
      ~dulla^@204~ eSettingBindingSource.DataMember = "V~dulla^@204~ ng"
        Me.ViewPriceSettingBindi~dulla^@204~ Source = Me.PriceSettingDataSet
    ~dulla^@204~   'PriceSettingDataSet
        '
  ~dulla^@204~ eSettingDataSet.DataSetName = "PriceS~dulla^@204~ "
        Me.PriceSettingDataSet.Sch~dulla^@204~ ionMode = System.Data.SchemaSerializa~dulla^@204~ udeSchema
        '
        'ViewPr~dulla^@204~ leAdapter
        '
        Me.View~dulla^@204~ ableAdapter.ClearBeforeFill = True
 ~dulla^@204~      'PurchaseTableAdapter
        '~dulla^@204~ PurchaseTableAdapter.ClearBeforeFill ~dulla^@204~    '
        'PurchaseInfoTableAdapt~dulla^@204~ 
        Me.PurchaseInfoTableAdapter~dulla^@204~ ill = True
        '
        'btnQu~dulla^@204~ n
        '
        Me.btnQuantityD~dulla^@204~ = New System.Drawing.Font("Microsoft ~dulla^@204~ 12.0!, System.Drawing.FontStyle.Bold,~dulla^@204~ ng.GraphicsUnit.Point, CType(0, Byte)~dulla^@204~ .btnQuantityDivision.Location = New S~dulla^@204~ .Point(137, 137)
        Me.btnQuant~dulla^@204~ ame = "btnQuantityDivision"
        ~dulla^@204~ yDivision.Size = New System.Drawing.S~dulla^@204~ 
        Me.btnQuantityDivision.TabIn~dulla^@204~      Me.btnQuantityDivision.Text = "G~dulla^@204~  Division"
        Me.btnQuantityDiv~dulla^@204~ alStyleBackColor = True
        '
 ~dulla^@204~ 2
        '
        Me.Label2.AutoS~dulla^@204~        Me.Label2.BackColor = System.D~dulla^@204~ Transparent
        Me.Label2.Font =~dulla^@204~ rawing.Font("Calibri", 14.25!, System~dulla^@204~ Style.Bold, System.Drawing.GraphicsUn~dulla^@204~ pe(0, Byte))
        Me.Label2.ForeC~dulla^@204~ .Drawing.Color.FromArgb(CType(CType(0~dulla^@204~ ger), CType(CType(0, Byte), Integer),~dulla^@204~ 192, Byte), Integer))
        Me.Lab~dulla^@204~ = New System.Drawing.Point(107, 213)
        Me.Label2.Name = "Label2"
      ~dulla^@204~ ize = New System.Drawing.Size(94, 23)~dulla^@204~ Label2.TabIndex = 47
        Me.Labe~dulla^@204~ voice No"
        '
        'cboInv~dulla^@204~    '
        Me.cboInvoiceNo.DataSou~dulla^@204~ haseBindingSource3
        Me.cboInv~dulla^@204~ yMember = "PurchaseInvoiceNo"
      ~dulla^@204~ ceNo.FormattingEnabled = True
      ~dulla^@204~ ceNo.Location = New System.Drawing.Po~dulla^@204~ 
        Me.cboInvoiceNo.Name = "cbo~dulla^@204~        Me.cboInvoiceNo.Size = New Sys~dulla^@204~ ize(108, 21)
        Me.cboInvoiceNo~dulla^@204~ 8
        Me.cboInvoiceNo.ValueMembe~dulla^@204~ InvoiceNo"
        '
        'Purch~dulla^@204~ rce1
        '
        Me.PurchaseB~dulla^@204~ .DataMember = "Purchase"
        Me.~dulla^@204~ ngSource1.DataSource = Me.PurchaseInf~dulla^@204~       '
        'PictureBox1
      ~dulla^@204~ Me.PictureBox1.Image = Global.Invento~dulla^@204~ em.My.Resources.Resources.helpb
    ~dulla^@204~ eBox1.Location = New System.Drawing.P~dulla^@204~ 
        Me.PictureBox1.Name = "Pict~dulla^@204~      Me.PictureBox1.Size = New System~dulla^@204~ (20, 21)
        Me.PictureBox1.Size~dulla^@204~ .Windows.Forms.PictureBoxSizeMode.Aut~dulla^@204~   Me.PictureBox1.TabIndex = 108
    ~dulla^@204~ eBox1.TabStop = False
        '
   ~dulla^@204~ e
        '
        Me.picClose.Ima~dulla^@204~ nventoryControlSystem.My.Resources.Re~dulla^@204~ 
        Me.picClose.Location = New ~dulla^@204~ g.Point(1183, 8)
        Me.picClose~dulla^@204~ lose"
        Me.picClose.Size = New~dulla^@204~ ng.Size(22, 19)
        Me.picClose.~dulla^@204~ stem.Windows.Forms.PictureBoxSizeMode~dulla^@204~       Me.picClose.TabIndex = 107
   ~dulla^@204~ ose.TabStop = False
        '
     ~dulla^@204~ ze
        '
        Me.picMinimize~dulla^@204~ al.InventoryControlSystem.My.Resource~dulla^@204~ inimize
        Me.picMinimize.Locat~dulla^@204~ tem.Drawing.Point(1115, 9)
        M~dulla^@204~ .Name = "picMinimize"
        Me.pic~dulla^@204~  = New System.Drawing.Size(21, 19)
 ~dulla^@204~ Minimize.SizeMode = System.Windows.Fo~dulla^@204~ xSizeMode.AutoSize
        Me.picMin~dulla^@204~ x = 106
        Me.picMinimize.TabSt~dulla^@204~        '
        'PurchaseBindingSou~dulla^@204~  '
        Me.PurchaseBindingSource2~dulla^@204~  "Purchase"
        Me.PurchaseBindi~dulla^@204~ aSource = Me.PurchaseInfoDataSet2
  ~dulla^@204~     'Label6
        '
        Me.La~dulla^@204~ r = System.Drawing.Color.RoyalBlue
 ~dulla^@204~ el6.Location = New System.Drawing.Poi~dulla^@204~         Me.Label6.Name = "Label6"
  ~dulla^@204~ l6.Size = New System.Drawing.Size(347~dulla^@204~   Me.Label6.TabIndex = 109
        '~dulla^@204~ bel7
        '
        Me.Label7.Ba~dulla^@204~ tem.Drawing.Color.RoyalBlue
        ~dulla^@204~ ation = New System.Drawing.Point(53, ~dulla^@204~  Me.Label7.Name = "Label7"
        M~dulla^@204~  = New System.Drawing.Size(347, 10)
~dulla^@204~ bel7.TabIndex = 110
        '
     ~dulla^@204~        '
        Me.Label8.BackColor~dulla^@204~ wing.Color.RoyalBlue
        Me.Labe~dulla^@204~  New System.Drawing.Point(53, 493)
 ~dulla^@204~ el8.Name = "Label8"
        Me.Label~dulla^@204~ System.Drawing.Size(347, 10)
       ~dulla^@204~ bIndex = 111
        '
        'Lab~dulla^@204~ '
        Me.Label9.BackColor = Syst~dulla^@204~ lor.RoyalBlue
        Me.Label9.Loca~dulla^@204~ stem.Drawing.Point(53, 246)
        ~dulla^@204~ e = "Label9"
        Me.Label9.Size ~dulla^@204~ Drawing.Size(347, 10)
        Me.Lab~dulla^@204~ = 112
        '
        'PurchaseTa~dulla^@204~         '
        Me.PurchaseTableAd~dulla^@204~ eforeFill = True
        '
        ~dulla^@204~ ingSource4
        '
        Me.Pur~dulla^@204~ ource4.DataMember = "Purchase"
     ~dulla^@204~ eBindingSource4.DataSource = Me.PInvo~dulla^@204~ 
        '
        'PurchaseBindingS~dulla^@204~    '
        Me.PurchaseBindingSourc~dulla^@204~  = "Purchase"
        Me.PurchaseBin~dulla^@204~ ataSource = Me.PInvoiceNoDataSet
   ~dulla^@204~    'PurchaseBindingSource6
        '~dulla^@204~ PurchaseBindingSource6.DataMember = "~dulla^@204~       Me.PurchaseBindingSource6.DataS~dulla^@204~ nvoiceNoDataSet
        '
        '~dulla^@204~     '
        Me.btnHome.Image = Glo~dulla^@204~ ControlSystem.My.Resources.Resources.~dulla^@204~  Me.btnHome.Location = New System.Dra~dulla^@204~ , 137)
        Me.btnHome.Name = "bt~dulla^@204~    Me.btnHome.Size = New System.Drawi~dulla^@204~ 9)
        Me.btnHome.TabIndex = 114~dulla^@204~ btnHome.UseVisualStyleBackColor = Tru~dulla^@204~ 
        'PriceSetting
        '
  ~dulla^@204~ ScaleDimensions = New System.Drawing.~dulla^@204~ 3.0!)
        Me.AutoScaleMode = Sys~dulla^@204~ orms.AutoScaleMode.Font
        Me.B~dulla^@204~ e = Global.InventoryControlSystem.My.~dulla^@204~ ources.bgPriceSetting
        Me.Bac~dulla^@204~ ayout = System.Windows.Forms.ImageLay~dulla^@204~         Me.ClientSize = New System.Dr~dulla^@204~ 48, 665)
        Me.Controls.Add(Me.~dulla^@204~      Me.Controls.Add(Me.Label9)
    ~dulla^@204~ ls.Add(Me.Label8)
        Me.Control~dulla^@204~ l7)
        Me.Controls.Add(Me.Label~dulla^@204~ e.Controls.Add(Me.PictureBox1)
     ~dulla^@204~ s.Add(Me.picClose)
        Me.Contro~dulla^@204~ Minimize)
        Me.Controls.Add(Me~dulla^@204~ ivision)
        Me.Controls.Add(Me.~dulla^@204~ 
        Me.Controls.Add(Me.Label2)~dulla^@204~ ontrols.Add(Me.grdPriceSetting)
    ~dulla^@204~ ls.Add(Me.btnSetPrice)
        Me.Co~dulla^@204~ .gbMethods)
        Me.Controls.Add(~dulla^@204~         Me.Controls.Add(Me.gbTaxes)
~dulla^@204~ ntrols.Add(Me.cboPricingStrategy)
  ~dulla^@204~ rols.Add(Me.Label3)
        Me.Doubl~dulla^@204~ rue
        Me.FormBorderStyle = Sys~dulla^@204~ orms.FormBorderStyle.None
        Me~dulla^@204~ eSetting"
        Me.Text = "SICS - ~dulla^@204~ "
        Me.WindowState = System.Wi~dulla^@204~ ormWindowState.Maximized
        Me.~dulla^@204~ eLayout(False)
        Me.gbTaxes.Pe~dulla^@204~ 
        Me.gbCosts.ResumeLayout(Fal~dulla^@204~ Me.gbCosts.PerformLayout()
        C~dulla^@204~ aseBindingSource3, System.ComponentMo~dulla^@204~ nitialize).EndInit()
        CType(M~dulla^@204~ indingSource, System.ComponentModel.I~dulla^@204~ lize).EndInit()
        CType(Me.PIn~dulla^@204~ t, System.ComponentModel.ISupportInit~dulla^@204~ it()
        CType(Me.PurchaseBindin~dulla^@204~ em.ComponentModel.ISupportInitialize)~dulla^@204~        CType(Me.PurchaseInfoDataSet2,~dulla^@204~ nentModel.ISupportInitialize).EndInit~dulla^@204~ e.gbMethods.ResumeLayout(False)
    ~dulla^@204~ ods.PerformLayout()
        CType(Me~dulla^@204~ ing, System.ComponentModel.ISupportIn~dulla^@204~ Init()
        CType(Me.ViewPriceSet~dulla^@204~ urce, System.ComponentModel.ISupportI~dulla^@204~ dInit()
        CType(Me.PriceSettin~dulla^@204~ tem.ComponentModel.ISupportInitialize~dulla^@204~         CType(Me.PurchaseBindingSourc~dulla^@204~ mponentModel.ISupportInitialize).EndI~dulla^@204~   CType(Me.PictureBox1, System.Compon~dulla^@204~ portInitialize).EndInit()
        CT~dulla^@204~ se, System.ComponentModel.ISupportIni~dulla^@204~ nit()
        CType(Me.picMinimize, ~dulla^@204~ entModel.ISupportInitialize).EndInit(~dulla^@204~ ype(Me.PurchaseBindingSource2, System~dulla^@204~ el.ISupportInitialize).EndInit()
   ~dulla^@204~ .PurchaseBindingSource4, System.Compo~dulla^@204~ pportInitialize).EndInit()
        C~dulla^@204~ aseBindingSource5, System.ComponentMo~dulla^@204~ nitialize).EndInit()
        CType(M~dulla^@204~ dingSource6, System.ComponentModel.IS~dulla^@204~ ize).EndInit()
        Me.ResumeLayo~dulla^@204~       Me.PerformLayout()

    End S~dulla^@204~ d WithEvents Label16 As System.Window~dulla^@204~ 
    Friend WithEvents Label1 As Sys~dulla^@204~ orms.Label
    Friend WithEvents cbo~dulla^@204~ gy As System.Windows.Forms.ComboBox
~dulla^@204~ thEvents Label3 As System.Windows.For~dulla^@204~  Friend WithEvents cboCustomTax As Sy~dulla^@204~ Forms.ComboBox
    Friend WithEvents~dulla^@204~ stem.Windows.Forms.Label
    Friend WithEvents cboSurTax As System.Windows.For~dulla^@204~     Friend WithEvents Label5 As Syste~dulla^@204~ ms.Label
    Friend WithEvents gbTax~dulla^@204~ Windows.Forms.GroupBox
    Friend Wi~dulla^@204~ sts As System.Windows.Forms.GroupBox~dulla^@204~ ithEvents gbMethods As System.Windows~dulla^@204~ ox
    Friend WithEvents rdbManually~dulla^@204~ ndows.Forms.RadioButton
    Friend W~dulla^@204~ Automatically As System.Windows.Forms~dulla^@204~ 
    Friend WithEvents btnSetPrice As~dulla^@204~ ws.Forms.Button
    Friend WithEvent~dulla^@204~ neousCost As System.Windows.Forms.Lab~dulla^@204~ d WithEvents lblFrieghtCost As System~dulla^@204~ s.Label
    Friend WithEvents grdPri~dulla^@204~ System.Windows.Forms.DataGridView
  ~dulla^@204~ Events PriceSettingDataSet As Invento~dulla^@204~ em.PriceSettingDataSet
    Friend Wi~dulla^@204~ PriceSettingBindingSource As System.W~dulla^@204~ BindingSource
    Friend WithEvents ~dulla^@204~ ingTableAdapter As InventoryControlSy~dulla^@204~ tingDataSetTableAdapters.ViewPriceSet~dulla^@204~ ter
    Friend WithEvents PurchaseIn~dulla^@204~  InventoryControlSystem.PurchaseInfoD~dulla^@204~ Friend WithEvents PurchaseBindingSour~dulla^@204~ Windows.Forms.BindingSource
    Frie~dulla^@204~  PurchaseTableAdapter As InventoryCon~dulla^@204~ rchaseInfoDataSet2TableAdapters.Purch~dulla^@204~ er
    Friend WithEvents PurchaseInf~dulla^@204~  As InventoryControlSystem.PurchaseIn~dulla^@204~ leAdapters.PurchaseInfoTableAdapter
~dulla^@204~ thEvents btnQuantityDivision As Syste~dulla^@204~ ms.Button
    Friend WithEvents Labe~dulla^@204~ Windows.Forms.Label
    Friend WithE~dulla^@204~ iceNo As System.Windows.Forms.ComboBo~dulla^@204~  WithEvents PictureBox1 As System.Win~dulla^@204~ ctureBox
    Friend WithEvents picCl~dulla^@204~ .Windows.Forms.PictureBox
    Friend~dulla^@204~ icMinimize As System.Windows.Forms.Pi~dulla^@204~  Friend WithEvents PurchaseBindingSou~dulla^@204~ m.Windows.Forms.BindingSource
    Fr~dulla^@204~ ts PurchaseBindingSource2 As System.W~dulla^@204~ BindingSource
    Friend WithEvents ~dulla^@204~ tem.Windows.Forms.Label
    Friend W~dulla^@204~ el7 As System.Windows.Forms.Label
  ~dulla^@204~ Events Label8 As System.Windows.Forms~dulla^@204~ riend WithEvents Label9 As System.Win~dulla^@204~ bel
    Friend WithEvents PInvoiceNo~dulla^@204~  As System.Windows.Forms.BindingSourc~dulla^@204~  WithEvents PInvoiceNoDataSet As Inve~dulla^@204~ ystem.PInvoiceNoDataSet
    Friend W~dulla^@204~ chaseBindingSource3 As System.Windows~dulla^@204~ gSource
    Friend WithEvents Purcha~dulla^@204~ r1 As InventoryControlSystem.PInvoice~dulla^@204~ eAdapters.PurchaseTableAdapter
    F~dulla^@204~ nts PurchaseBindingSource5 As System.~dulla^@204~ .BindingSource
    Friend WithEvents~dulla^@204~ ingSource4 As System.Windows.Forms.Bi~dulla^@204~     Friend WithEvents PurchaseBinding~dulla^@204~ stem.Windows.Forms.BindingSource
   ~dulla^@204~ vents btnHome As System.Windows.Forms.Button
End Class
