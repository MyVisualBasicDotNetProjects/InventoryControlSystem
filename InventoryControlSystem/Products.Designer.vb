<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Products
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
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsDataSet = New InventoryControlSystem.ProductsDataSet
        Me.ProductsTableAdapter = New InventoryControlSystem.ProductsDataSetTableAdapters.ProductsTableAdapter
        Me.grdProducts = New System.Windows.Forms.DataGridView
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.picClose = New System.Windows.Forms.PictureBox
        Me.picMinimize = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnGo = New System.Windows.Forms.Button
        Me.btnGoToSales = New System.Windows.Forms.Button
        Me.btnHome = New System.Windows.Forms.Button
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(847, 148)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(238, 20)
        Me.txtSearch.TabIndex = 100
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Products"
        Me.BindingSource1.DataSource = Me.ProductsDataSet
        '
        'ProductsDataSet
        '
        Me.ProductsDataSet.DataSetName = "ProductsDataSet"
        Me.ProductsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'grdProducts
        '
        Me.grdProducts.AllowUserToAddRows = False
        Me.grdProducts.AllowUserToDeleteRows = False
        Me.grdProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdProducts.Location = New System.Drawing.Point(69, 204)
        Me.grdProducts.Name = "grdProducts"
        Me.grdProducts.ReadOnly = True
        Me.grdProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdProducts.Size = New System.Drawing.Size(1143, 531)
        Me.grdProducts.TabIndex = 101
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(140, 148)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(70, 23)
        Me.btnRefresh.TabIndex = 102
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'picClose
        '
        Me.picClose.Image = Global.InventoryControlSystem.My.Resources.Resources.close
        Me.picClose.Location = New System.Drawing.Point(1199, 6)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(22, 19)
        Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picClose.TabIndex = 104
        Me.picClose.TabStop = False
        '
        'picMinimize
        '
        Me.picMinimize.Image = Global.InventoryControlSystem.My.Resources.Resources.minimize
        Me.picMinimize.Location = New System.Drawing.Point(1131, 7)
        Me.picMinimize.Name = "picMinimize"
        Me.picMinimize.Size = New System.Drawing.Size(21, 19)
        Me.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMinimize.TabIndex = 103
        Me.picMinimize.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.InventoryControlSystem.My.Resources.Resources.helpb
        Me.PictureBox1.Location = New System.Drawing.Point(1165, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 21)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 105
        Me.PictureBox1.TabStop = False
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(1101, 144)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(43, 25)
        Me.btnGo.TabIndex = 106
        Me.btnGo.Text = "&Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnGoToSales
        '
        Me.btnGoToSales.Location = New System.Drawing.Point(236, 148)
        Me.btnGoToSales.Name = "btnGoToSales"
        Me.btnGoToSales.Size = New System.Drawing.Size(91, 23)
        Me.btnGoToSales.TabIndex = 107
        Me.btnGoToSales.Text = "&Go to Sales"
        Me.btnGoToSales.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Image = Global.InventoryControlSystem.My.Resources.Resources.home
        Me.btnHome.Location = New System.Drawing.Point(80, 140)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(41, 39)
        Me.btnHome.TabIndex = 114
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.InventoryControlSystem.My.Resources.Resources.bgProducts
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1224, 807)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnGoToSales)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.picMinimize)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.grdProducts)
        Me.Controls.Add(Me.txtSearch)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Products"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SICS - Products Table"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
         ~dulla^@204~ ~dulla^@204~ m.ComponentModel.ISupportInitialize).~dulla^@204~       CType(Me.PictureBox1, System.Co~dulla^@204~ ISupportInitialize).EndInit()
      ~dulla^@204~ yout(False)
        Me.PerformLayout~dulla^@204~  Sub
    Friend WithEvents txtSearch~dulla^@204~ ndows.Forms.TextBox
    Friend WithE~dulla^@204~ Source1 As System.Windows.Forms.Bindi~dulla^@204~  Friend WithEvents ProductsDataSet As~dulla^@204~ trolSystem.ProductsDataSet
    Frien~dulla^@204~ ProductsTableAdapter As InventoryCont~dulla^@204~ ductsDataSetTableAdapters.ProductsTab~dulla^@204~   Friend WithEvents grdProducts As Sy~dulla^@204~ Forms.DataGridView
    Friend WithEv~dulla^@204~ sh As System.Windows.Forms.Button
  ~dulla^@204~ Events picClose As System.Windows.For~dulla^@204~ 
    Friend WithEvents picMinimize A~dulla^@204~ ows.Forms.PictureBox
    Friend With~dulla^@204~ eBox1 As System.Windows.Forms.Picture~dulla^@204~ nd WithEvents btnGo As System.Windows~dulla^@204~ 
    Friend WithEvents btnGoToSales ~dulla^@204~ dows.Forms.Button
    Friend WithEve~dulla^@204~ s System.Windows.Forms.Button

End Class
