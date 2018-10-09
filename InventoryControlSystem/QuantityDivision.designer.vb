<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuantityDivision
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
        Me.btnDistQty = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rdbManually = New System.Windows.Forms.RadioButton
        Me.rdbAutomatically = New System.Windows.Forms.RadioButton
        Me.cboDistnStrategy = New System.Windows.Forms.ComboBox
        Me.lblDistn = New System.Windows.Forms.Label
        Me.grdQtyDivision = New System.Windows.Forms.DataGridView
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.picClose = New System.Windows.Forms.PictureBox
        Me.picMinimize = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboInvoiceNo = New System.Windows.Forms.ComboBox
        Me.PurchaseBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PInvoiceNoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PInvoiceNoDataSet = New InventoryControlSystem.PInvoiceNoDataSet
        Me.Label2 = New System.Windows.Forms.Label
        Me.PurchaseTableAdapter1 = New InventoryControlSystem.PInvoiceNoDataSetTableAdapters.PurchaseTableAdapter
        Me.PurchaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchaseInfoDataSet2 = New InventoryControlSystem.PurchaseInfoDataSet2
        Me.ViewPriceSettingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriceSettingDataSet = New InventoryControlSystem.PriceSettingDataSet
        Me.ViewPriceSettingTableAdapter = New InventoryControlSystem.PriceSettingDataSetTableAdapters.ViewPriceSettingTableAdapter
        Me.PurchaseTableAdapter = New InventoryControlSystem.PurchaseInfoDataSet2TableAdapters.PurchaseTableAdapter
        Me.PurchaseInfoTableAdapter = New InventoryControlSystem.PurchaseInfoDataSet2TableAdapters.PurchaseInfoTableAdapter
        Me.PurchaseBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchaseBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchaseBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchaseBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchaseBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnHome = New System.Windows.Forms.Button
        Me.GroupBox3.SuspendLayout()
        CType(Me.grdQtyDivision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PInvoiceNoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PInvoiceNoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseInfoDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewPriceSettingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceSettingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDistQty
        '
        Me.btnDistQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDistQty.Location = New System.Drawing.Point(182, 505)
        Me.btnDistQty.Name = "btnDistQty"
        Me.btnDistQty.Size = New System.Drawing.Size(116, 32)
        Me.btnDistQty.TabIndex = 49
        Me.btnDistQty.Text = "Distribute"
        Me.btnDistQty.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.rdbManually)
        Me.GroupBox3.Controls.Add(Me.rdbAutomatically)
        Me.GroupBox3.Location = New System.Drawing.Point(91, 321)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(289, 64)
        Me.GroupBox3.TabIndex = 48
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Price Setting Method"
        '
        'rdbManually
        '
        Me.rdbManually.AutoSize = True
        Me.rdbManually.Location = New System.Drawing.Point(187, 28)
        Me.rdbManually.Name = "rdbManually"
        Me.rdbManually.Size = New System.Drawing.Size(67, 17)
        Me.rdbManually.TabIndex = 34
        Me.rdbManually.Text = "Manually"
        Me.rdbManually.UseVisualStyleBackColor = True
        '
        'rdbAutomatically
        '
        Me.rdbAutomatically.AutoSize = True
        Me.rdbAutomatically.Checked = True
        Me.rdbAutomatically.Location = New System.Drawing.Point(27, 28)
        Me.rdbAutomatically.Name = "rdbAutomatically"
        Me.rdbAutomatically.Size = New System.Drawing.Size(87, 17)
        Me.rdbAutomatically.TabIndex = 33
        Me.rdbAutomatically.TabStop = True
        Me.rdbAutomatically.Text = "Automatically"
        Me.rdbAutomatically.UseVisualStyleBackColor = True
        '
        'cboDistnStrategy
        '
        Me.cboDistnStrategy.FormattingEnabled = True
        Me.cboDistnStrategy.Items.AddRange(New Object() {"Strategy 1", "Strategy 2", "Strategy 3"})
        Me.cboDistnStrategy.Location = New System.Drawing.Point(272, 449)
        Me.cboDistnStrategy.Name = "cboDistnStrategy"
        Me.cboDistnStrategy.Size = New System.Drawing.Size(108, 21)
        Me.cboDistnStrategy.TabIndex = 47
        Me.cboDistnStrategy.Text = "Strategy 1"
        '
        'lblDistn
        '
        Me.lblDistn.AutoSize = True
        Me.lblDistn.BackColor = System.Drawing.Color.Transparent
        Me.lblDistn.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistn.Location = New System.Drawing.Point(93, 449)
        Me.lblDistn.Name = "lblDistn"
        Me.lblDistn.Size = New System.Drawing.Size(152, 19)
        Me.lblDistn.TabIndex = 46
        Me.lblDistn.Text = "Distribution Strategy"
        '
        'grdQtyDivision
        '
        Me.grdQtyDivision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdQtyDivision.Location = New System.Drawing.Point(425, 146)
        Me.grdQtyDivision.Name = "grdQtyDivision"
        Me. ~dulla^@204~ ~dulla^@204~ ystem.Drawing.Size(839, 546)
       ~dulla^@204~ ision.TabIndex = 52
        '
     ~dulla^@204~ x1
        '
        Me.PictureBox1~dulla^@204~ al.InventoryControlSystem.My.Resource~dulla^@204~ elpb
        Me.PictureBox1.Location~dulla^@204~ .Drawing.Point(1175, 9)
        Me.P~dulla^@204~ me = "PictureBox1"
        Me.Pictur~dulla^@204~ New System.Drawing.Size(20, 21)
    ~dulla^@204~ eBox1.SizeMode = System.Windows.Forms~dulla^@204~ zeMode.AutoSize
        Me.PictureBo~dulla^@204~  108
        Me.PictureBox1.TabStop ~dulla^@204~     '
        'picClose
        '
~dulla^@204~ cClose.Image = Global.InventoryContro~dulla^@204~ sources.Resources.close
        Me.p~dulla^@204~ ion = New System.Drawing.Point(1209, ~dulla^@204~ e.picClose.Name = "picClose"
       ~dulla^@204~ Size = New System.Drawing.Size(22, 19~dulla^@204~ .picClose.SizeMode = System.Windows.F~dulla^@204~ oxSizeMode.AutoSize
        Me.picCl~dulla^@204~ = 107
        Me.picClose.TabStop = ~dulla^@204~   '
        'picMinimize
        '~dulla^@204~ icMinimize.Image = Global.InventoryCo~dulla^@204~ y.Resources.Resources.minimize
     ~dulla^@204~ mize.Location = New System.Drawing.Po~dulla^@204~ 
        Me.picMinimize.Name = "picM~dulla^@204~      Me.picMinimize.Size = New System~dulla^@204~ (21, 19)
        Me.picMinimize.Size~dulla^@204~ .Windows.Forms.PictureBoxSizeMode.Aut~dulla^@204~   Me.picMinimize.TabIndex = 106
    ~dulla^@204~ imize.TabStop = False
        '
   ~dulla^@204~ 
        '
        Me.Label1.BackCol~dulla^@204~ rawing.Color.Yellow
        Me.Label~dulla^@204~ New System.Drawing.Point(80, 412)
  ~dulla^@204~ l1.Name = "Label1"
        Me.Label1~dulla^@204~ ystem.Drawing.Size(329, 10)
        ~dulla^@204~ Index = 109
        '
        'cboI~dulla^@204~      '
        Me.cboInvoiceNo.DataS~dulla^@204~ rchaseBindingSource3
        Me.cboI~dulla^@204~ layMember = "PurchaseInvoiceNo"
    ~dulla^@204~ oiceNo.FormattingEnabled = True
    ~dulla^@204~ oiceNo.Location = New System.Drawing.~dulla^@204~ 9)
        Me.cboInvoiceNo.Name = "c~dulla^@204~ 
        Me.cboInvoiceNo.Size = New S~dulla^@204~ .Size(108, 21)
        Me.cboInvoice~dulla^@204~  111
        Me.cboInvoiceNo.ValueMe~dulla^@204~ aseInvoiceNo"
        '
        'Pu~dulla^@204~ Source3
        '
        Me.Purcha~dulla^@204~ ce3.DataMember = "Purchase"
        ~dulla^@204~ ndingSource3.DataSource = Me.PInvoice~dulla^@204~ ce
        '
        'PInvoiceNoBin~dulla^@204~        '
        Me.PInvoiceNoBindin~dulla^@204~ ource = Me.PInvoiceNoDataSet
       ~dulla^@204~ oBindingSource.Position = 0
        ~dulla^@204~ InvoiceNoDataSet
        '
        ~dulla^@204~ DataSet.DataSetName = "PInvoiceNoData~dulla^@204~  Me.PInvoiceNoDataSet.SchemaSerializa~dulla^@204~ stem.Data.SchemaSerializationMode.Inc~dulla^@204~        '
        'Label2
        '~dulla^@204~ abel2.AutoSize = True
        Me.Lab~dulla^@204~  = System.Drawing.Color.Transparent
~dulla^@204~ bel2.Font = New System.Drawing.Font("~dulla^@204~ 25!, System.Drawing.FontStyle.Bold, S~dulla^@204~ .GraphicsUnit.Point, CType(0, Byte))~dulla^@204~ abel2.ForeColor = System.Drawing.Colo~dulla^@204~ ype(CType(0, Byte), Integer), CType(C~dulla^@204~ , Integer), CType(CType(192, Byte), I~dulla^@204~      Me.Label2.Location = New System.~dulla^@204~ (126, 269)
        Me.Label2.Name = ~dulla^@204~      Me.Label2.Size = New System.Draw~dulla^@204~ 23)
        Me.Label2.TabIndex = 110~dulla^@204~ Label2.Text = "Invoice No"
        '~dulla^@204~ rchaseTableAdapter1
        '
     ~dulla^@204~ eTableAdapter1.ClearBeforeFill = True~dulla^@204~         'PurchaseBindingSource
     ~dulla^@204~  Me.PurchaseBindingSource.DataMember ~dulla^@204~ 
        Me.PurchaseBindingSource.Dat~dulla^@204~ PurchaseInfoDataSet2
        '
    ~dulla^@204~ InfoDataSet2
        '
        Me.P~dulla^@204~ taSet2.DataSetName = "PurchaseInfoDat~dulla^@204~    Me.PurchaseInfoDataSet2.SchemaSeri~dulla^@204~  = System.Data.SchemaSerializationMod~dulla^@204~ ma
        '
        'ViewPriceSett~dulla^@204~ rce
        '
        Me.ViewPriceS~dulla^@204~ Source.DataMember = "ViewPriceSetting~dulla^@204~ .ViewPriceSettingBindingSource.DataSo~dulla^@204~ ceSettingDataSet
        '
        ~dulla^@204~ DataSet
        '
        Me.PriceS~dulla^@204~ .DataSetName = "PriceSettingDataSet"~dulla^@204~ riceSettingDataSet.SchemaSerializatio~dulla^@204~ m.Data.SchemaSerializationMode.Includ~dulla^@204~     '
        'ViewPriceSettingTable~dulla^@204~     '
        Me.ViewPriceSettingTab~dulla^@204~ arBeforeFill = True
        '
     ~dulla^@204~ ableAdapter
        '
        Me.Pu~dulla^@204~ apter.ClearBeforeFill = True
       ~dulla^@204~ PurchaseInfoTableAdapter
        '
~dulla^@204~ rchaseInfoTableAdapter.ClearBeforeFil~dulla^@204~      '
        'PurchaseBindingSourc~dulla^@204~ 
        Me.PurchaseBindingSource1.D~dulla^@204~ Purchase"
        Me.PurchaseBinding~dulla^@204~ ource = Me.PurchaseInfoDataSet2
    ~dulla^@204~   'PurchaseBindingSource2
        '~dulla^@204~ urchaseBindingSource2.DataMember = "P~dulla^@204~      Me.PurchaseBindingSource2.DataSo~dulla^@204~ chaseInfoDataSet2
        '
       ~dulla^@204~ dingSource4
        '
        Me.Pu~dulla^@204~ Source4.DataMember = "Purchase"
    ~dulla^@204~ seBindingSource4.DataSource = Me.PInv~dulla^@204~ 
        '
        'PurchaseBinding~dulla^@204~     '
        Me.PurchaseBindingSour~dulla^@204~ r = "Purchase"
        Me.PurchaseBi~dulla^@204~ DataSource = Me.PInvoiceNoDataSet
  ~dulla^@204~     'PurchaseBindingSource6
        ~dulla^@204~ .PurchaseBindingSource6.DataMember = ~dulla^@204~        Me.PurchaseBindingSource6.Data~dulla^@204~ InvoiceNoDataSet
        '
        ~dulla^@204~      '
        Me.btnHome.Image = Gl~dulla^@204~ yControlSystem.My.Resources.Resources~dulla^@204~   Me.btnHome.Location = New System.Dr~dulla^@204~ 3, 146)
        Me.btnHome.Name = "b~dulla^@204~     Me.btnHome.Size = New System.Draw~dulla^@204~ 39)
        Me.btnHome.TabIndex = 11~dulla^@204~ .btnHome.UseVisualStyleBackColor = Tr~dulla^@204~ 
        'QuantityDivision
        ~dulla^@204~ .AutoScaleDimensions = New System.Dra~dulla^@204~ 0!, 13.0!)
        Me.AutoScaleMode ~dulla^@204~ ows.Forms.AutoScaleMode.Font
       ~dulla^@204~ dImage = Global.InventoryControlSyste~dulla^@204~ s.Resources.bgQuantityDivision
     ~dulla^@204~ undImageLayout = System.Windows.Forms~dulla^@204~ Stretch
        Me.ClientSize = New ~dulla^@204~ g.Size(1300, 694)
        Me.Control~dulla^@204~ ome)
        Me.Controls.Add(Me.cboI~dulla^@204~       Me.Controls.Add(Me.Label2)
   ~dulla^@204~ ols.Add(Me.Label1)
        Me.Contro~dulla^@204~ tureBox1)
        Me.Controls.Add(Me~dulla^@204~        Me.Controls.Add(Me.picMinimize~dulla^@204~ .Controls.Add(Me.grdQtyDivision)
   ~dulla^@204~ ols.Add(Me.btnDistQty)
        Me.Co~dulla^@204~ .GroupBox3)
        Me.Controls.Add(~dulla^@204~ rategy)
        Me.Controls.Add(Me.l~dulla^@204~      Me.DoubleBuffered = True
      ~dulla^@204~ erStyle = System.Windows.Forms.FormBo~dulla^@204~ e
        Me.Name = "QuantityDivisio~dulla^@204~ e.Text = "SCIS - Quantity Division"
~dulla^@204~ ndowState = System.Windows.Forms.Form~dulla^@204~ aximized
        Me.GroupBox3.Resume~dulla^@204~ 
        Me.GroupBox3.PerformLayout(~dulla^@204~ ype(Me.grdQtyDivision, System.Compone~dulla^@204~ ortInitialize).EndInit()
        CTy~dulla^@204~ Box1, System.ComponentModel.ISupportI~dulla^@204~ dInit()
        CType(Me.picClose, S~dulla^@204~ ntModel.ISupportInitialize).EndInit()~dulla^@204~ pe(Me.picMinimize, System.ComponentMo~dulla^@204~ nitialize).EndInit()
        CType(M~dulla^@204~ dingSource3, System.ComponentModel.IS~dulla^@204~ ize).EndInit()
        CType(Me.PInv~dulla^@204~ Source, System.ComponentModel.ISuppor~dulla^@204~ EndInit()
        CType(Me.PInvoiceN~dulla^@204~ tem.ComponentModel.ISupportInitialize~dulla^@204~         CType(Me.PurchaseBindingSourc~dulla^@204~ ponentModel.ISupportInitialize).EndIn~dulla^@204~  CType(Me.PurchaseInfoDataSet2, System.ComponentModel.ISupportInitialize).EndIn~dulla^@204~  CType(Me.ViewPriceSettingBindingSour~dulla^@204~ mponentModel.ISupportInitialize).EndI~dulla^@204~   CType(Me.PriceSettingDataSet, Syste~dulla^@204~ del.ISupportInitialize).EndInit()
  ~dulla^@204~ e.PurchaseBindingSource1, System.Comp~dulla^@204~ upportInitialize).EndInit()
        ~dulla^@204~ haseBindingSource2, System.ComponentM~dulla^@204~ Initialize).EndInit()
        CType(~dulla^@204~ ndingSource4, System.ComponentModel.I~dulla^@204~ lize).EndInit()
        CType(Me.Pur~dulla^@204~ ource5, System.ComponentModel.ISuppor~dulla^@204~ EndInit()
        CType(Me.PurchaseB~dulla^@204~ , System.ComponentModel.ISupportIniti~dulla^@204~ t()
        Me.ResumeLayout(False)
~dulla^@204~ rformLayout()

    End Sub
    Fri~dulla^@204~ s btnDistQty As System.Windows.Forms.~dulla^@204~ riend WithEvents GroupBox3 As System.~dulla^@204~ .GroupBox
    Friend WithEvents rdbM~dulla^@204~ stem.Windows.Forms.RadioButton
    F~dulla^@204~ nts rdbAutomatically As System.Window~dulla^@204~ Button
    Friend WithEvents cboDist~dulla^@204~ System.Windows.Forms.ComboBox
    Fr~dulla^@204~ ts lblDistn As System.Windows.Forms.L~dulla^@204~ end WithEvents grdQtyDivision As Syst~dulla^@204~ rms.DataGridView
    Friend WithEven~dulla^@204~ 1 As System.Windows.Forms.PictureBox~dulla^@204~ ithEvents picClose As System.Windows.~dulla^@204~ Box
    Friend WithEvents picMinimiz~dulla^@204~ indows.Forms.PictureBox
    Friend W~dulla^@204~ el1 As System.Windows.Forms.Label
  ~dulla^@204~ Events cboInvoiceNo As System.Windows~dulla^@204~ ox
    Friend WithEvents Label2 As S~dulla^@204~ .Forms.Label
    Friend WithEvents P~dulla^@204~ gSource3 As System.Windows.Forms.Bind~dulla^@204~   Friend WithEvents PInvoiceNoBinding~dulla^@204~ tem.Windows.Forms.BindingSource
    ~dulla^@204~ ents PInvoiceNoDataSet As InventoryCo~dulla^@204~ InvoiceNoDataSet
    Friend WithEven~dulla^@204~ bleAdapter1 As InventoryControlSystem~dulla^@204~ taSetTableAdapters.PurchaseTableAdapt~dulla^@204~ d WithEvents PurchaseBindingSource As~dulla^@204~ ws.Forms.BindingSource
    Friend Wi~dulla^@204~ haseInfoDataSet2 As InventoryControlS~dulla^@204~ eInfoDataSet2
    Friend WithEvents ~dulla^@204~ ingBindingSource As System.Windows.Fo~dulla^@204~ urce
    Friend WithEvents PriceSett~dulla^@204~  InventoryControlSystem.PriceSettingD~dulla^@204~ riend WithEvents ViewPriceSettingTabl~dulla^@204~ nventoryControlSystem.PriceSettingDat~dulla^@204~ ters.ViewPriceSettingTableAdapter
  ~dulla^@204~ Events PurchaseTableAdapter As Invent~dulla^@204~ tem.PurchaseInfoDataSet2TableAdapters~dulla^@204~ eAdapter
    Friend WithEvents Purch~dulla^@204~ dapter As InventoryControlSystem.Purc~dulla^@204~ et2TableAdapters.PurchaseInfoTableAda~dulla^@204~ end WithEvents PurchaseBindingSource1~dulla^@204~ ndows.Forms.BindingSource
    Friend~dulla^@204~ urchaseBindingSource2 As System.Windo~dulla^@204~ ingSource
    Friend WithEvents Purc~dulla^@204~ urce4 As System.Windows.Forms.Binding~dulla^@204~ riend WithEvents PurchaseBindingSourc~dulla^@204~ Windows.Forms.BindingSource
    Frie~dulla^@204~  PurchaseBindingSource6 As System.Win~dulla^@204~ ndingSource
    Friend WithEvents btnHome As System.Windows.Forms.Button
End Class
