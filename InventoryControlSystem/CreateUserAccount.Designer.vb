<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateUserAccount
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
        Me.LoginDataSet = New InventoryControlSystem.LoginDataSet
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNewPassword = New System.Windows.Forms.TextBox
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox
        Me.UsersTableAdapter = New InventoryControlSystem.LoginDataSetTableAdapters.UsersTableAdapter
        Me.btnChange = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rdbPurchaser = New System.Windows.Forms.RadioButton
        Me.rdbSalesPerson = New System.Windows.Forms.RadioButton
        Me.rdbManager = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboSelect = New System.Windows.Forms.ComboBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.picClose = New System.Windows.Forms.PictureBox
        Me.picMinimize = New System.Windows.Forms.PictureBox
        Me.btnHome = New System.Windows.Forms.Button
        CType(Me.LoginDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoginDataSet
        '
        Me.LoginDataSet.DataSetName = "LoginDataSet"
        Me.LoginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoginBindingSource
        '
        Me.LoginBindingSource.DataMember = "Users"
        Me.LoginBindingSource.DataSource = Me.LoginDataSet
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.UsernameLabel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNewPassword)
        Me.GroupBox1.Controls.Add(Me.txtConfirmPassword)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox1.Location = New System.Drawing.Point(88, 162)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(365, 172)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Name Information"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(167, 35)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(162, 27)
        Me.txtUserName.TabIndex = 0
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(22, 35)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(116, 23)
        Me.UsernameLabel.TabIndex = 16
        Me.UsernameLabel.Text = "User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Confirm Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(167, 75)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(162, 27)
        Me.txtNewPassword.TabIndex = 1
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(167, 111)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(162, 27)
        Me.txtConfirmPassword.TabIndex = 2
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'btnChange
        '
        Me.btnChange.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChange.Location = New System.Drawing.Point(405, 356)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(90, 30)
        Me.btnChange.TabIndex = 18
        Me.btnChange.Text = "&Create"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.rdbPurchaser)
        Me.GroupBox2.Controls.Add(Me.rdbSalesPerson)
        Me.GroupBox2.Controls.Add(Me.rdbManager)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox2.Location = New System.Drawing.Point(534, 228)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(151, 102)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Task"
        '
        'rdbPurchaser
        '
        Me.rdbPurchaser.AutoSize = True
        Me.rdbPurchaser.Location = New System.Drawing.Point(23, 62)
        Me.rdbPurchaser.Name = "rdbPurchaser"
        Me.rdbPurchaser.Size = New System.Drawing.Size(94, 22)
        Me.rdbPurchaser.TabIndex = 2
        Me.rdbPurchaser.TabStop = True
        Me.rdbPurchaser.Text = "Purchaser"
        Me.rdbPurchaser.UseVisualStyleBackColor = True
        '
        'rdbSalesPerson
        '
        Me.rdbSalesPerson.AutoSize = True
        Me.rdbSalesPerson.Location = New System.Drawing.Point(23, 39)
        Me.rdbSalesPerson.Name = "rdbSalesPerson"
        Me.rdbSalesPerson.Size = New System.Drawing.Size(113, 22)
    ~dulla^@204~ ~dulla^@204~ ndex = 1
        Me.rdbSalesPerson.T~dulla^@204~ 
        Me.rdbSalesPerson.Text = "S~dulla^@204~ 
        Me.rdbSalesPerson.UseVisualS~dulla^@204~  = True
        '
        'rdbManag~dulla^@204~ 
        Me.rdbManager.AutoSize = Tr~dulla^@204~ e.rdbManager.Location = New System.Dr~dulla^@204~ 3, 19)
        Me.rdbManager.Name = ~dulla^@204~ 
        Me.rdbManager.Size = New Sys~dulla^@204~ ize(84, 22)
        Me.rdbManager.Ta~dulla^@204~        Me.rdbManager.TabStop = True
~dulla^@204~ bManager.Text = "Manager"
        Me~dulla^@204~ seVisualStyleBackColor = True
      ~dulla^@204~ 'Label4
        '
        Me.Label4~dulla^@204~ rue
        Me.Label4.BackColor = Sy~dulla^@204~ Color.Transparent
        Me.Label4.~dulla^@204~ stem.Drawing.Font("Microsoft Sans Ser~dulla^@204~ System.Drawing.FontStyle.Regular, Sys~dulla^@204~ raphicsUnit.Point, CType(0, Byte))
 ~dulla^@204~ el4.ForeColor = System.Drawing.Color.~dulla^@204~ e(CType(0, Byte), Integer), CType(CTy~dulla^@204~ Integer), CType(CType(64, Byte), Inte~dulla^@204~   Me.Label4.Location = New System.Dra~dulla^@204~ 1, 162)
        Me.Label4.Name = "La~dulla^@204~   Me.Label4.Size = New System.Drawing~dulla^@204~ )
        Me.Label4.TabIndex = 23
 ~dulla^@204~ el4.Text = "Please select your Locati~dulla^@204~ '
        'cboSelect
        '
   ~dulla^@204~ lect.Font = New System.Drawing.Font("~dulla^@204~ s Serif", 8.25!, System.Drawing.FontS~dulla^@204~  System.Drawing.GraphicsUnit.Point, C~dulla^@204~ )
        Me.cboSelect.ForeColor = S~dulla^@204~ .Color.Black
        Me.cboSelect.Fo~dulla^@204~ ed = True
        Me.cboSelect.Items~dulla^@204~  Object() {"Shop 1 (Nesro Spare Part)~dulla^@204~ ejat Spare Part)", "Store"})
       ~dulla^@204~ .Location = New System.Drawing.Point(~dulla^@204~       Me.cboSelect.Name = "cboSelect"~dulla^@204~ cboSelect.Size = New System.Drawing.S~dulla^@204~ 
        Me.cboSelect.TabIndex = 22
~dulla^@204~ oSelect.Text = "Shop 1 (Nesro Spare P~dulla^@204~   '
        'PictureBox1
        '~dulla^@204~ ictureBox1.Image = Global.InventoryCo~dulla^@204~ y.Resources.Resources.helpb
        ~dulla^@204~ 1.Location = New System.Drawing.Point~dulla^@204~      Me.PictureBox1.Name = "PictureBo~dulla^@204~ Me.PictureBox1.Size = New System.Draw~dulla^@204~ 21)
        Me.PictureBox1.SizeMode ~dulla^@204~ ows.Forms.PictureBoxSizeMode.AutoSize~dulla^@204~ PictureBox1.TabIndex = 108
        M~dulla^@204~ .TabStop = False
        '
        ~dulla^@204~       '
        Me.picClose.Image = ~dulla^@204~ oryControlSystem.My.Resources.Resourc~dulla^@204~      Me.picClose.Location = New Syste~dulla^@204~ nt(749, 7)
        Me.picClose.Name ~dulla^@204~ 
        Me.picClose.Size = New Syste~dulla^@204~ e(22, 19)
        Me.picClose.SizeMo~dulla^@204~ indows.Forms.PictureBoxSizeMode.AutoS~dulla^@204~ Me.picClose.TabIndex = 107
        M~dulla^@204~ bStop = False
        '
        'pi~dulla^@204~       '
        Me.picMinimize.Image~dulla^@204~ entoryControlSystem.My.Resources.Reso~dulla^@204~ e
        Me.picMinimize.Location = ~dulla^@204~ awing.Point(681, 8)
        Me.picMi~dulla^@204~  "picMinimize"
        Me.picMinimiz~dulla^@204~ System.Drawing.Size(21, 19)
        ~dulla^@204~ e.SizeMode = System.Windows.Forms.Pic~dulla^@204~ de.AutoSize
        Me.picMinimize.T~dulla^@204~ 
        Me.picMinimize.TabStop = Fa~dulla^@204~ '
        'btnHome
        '
     ~dulla^@204~ .Image = Global.InventoryControlSyste~dulla^@204~ s.Resources.home
        Me.btnHome.~dulla^@204~ w System.Drawing.Point(681, 347)
   ~dulla^@204~ me.Name = "btnHome"
        Me.btnHo~dulla^@204~  System.Drawing.Size(41, 39)
       ~dulla^@204~ abIndex = 114
        Me.btnHome.Use~dulla^@204~ ckColor = True
        '
        'C~dulla^@204~ unt
        '
        Me.AutoScaleD~dulla^@204~ ew System.Drawing.SizeF(6.0!, 13.0!)~dulla^@204~ utoScaleMode = System.Windows.Forms.A~dulla^@204~ Font
        Me.BackgroundImage = Gl~dulla^@204~ yControlSystem.My.Resources.Resources~dulla^@204~ Account
        Me.BackgroundImageLa~dulla^@204~ .Windows.Forms.ImageLayout.Stretch
 ~dulla^@204~ entSize = New System.Drawing.Size(780~dulla^@204~    Me.Controls.Add(Me.btnHome)
     ~dulla^@204~ s.Add(Me.PictureBox1)
        Me.Con~dulla^@204~ picClose)
        Me.Controls.Add(Me~dulla^@204~ 
        Me.Controls.Add(Me.Label4)~dulla^@204~ ontrols.Add(Me.cboSelect)
        Me~dulla^@204~ (Me.GroupBox2)
        Me.Controls.A~dulla^@204~ x1)
        Me.Controls.Add(Me.btnCh~dulla^@204~   Me.DoubleBuffered = True
        M~dulla^@204~ tyle = System.Windows.Forms.FormBorde~dulla^@204~         Me.Name = "CreateUserAccount"~dulla^@204~ StartPosition = System.Windows.Forms.~dulla^@204~ tion.CenterScreen
        Me.Text = ~dulla^@204~ Account"
        CType(Me.LoginDataS~dulla^@204~ mponentModel.ISupportInitialize).EndI~dulla^@204~   CType(Me.LoginBindingSource, System~dulla^@204~ el.ISupportInitialize).EndInit()
   ~dulla^@204~ Box1.ResumeLayout(False)
        Me.~dulla^@204~ formLayout()
        Me.GroupBox2.Re~dulla^@204~ lse)
        Me.GroupBox2.PerformLay~dulla^@204~   CType(Me.PictureBox1, System.Compon~dulla^@204~ portInitialize).EndInit()
        CT~dulla^@204~ se, System.ComponentModel.ISupportIni~dulla^@204~ nit()
        CType(Me.picMinimize, ~dulla^@204~ entModel.ISupportInitialize).EndInit(~dulla^@204~ .ResumeLayout(False)
        Me.Perf~dulla^@204~ 
    End Sub
    Friend WithEvents ~dulla^@204~ As InventoryControlSystem.LoginDataSe~dulla^@204~  WithEvents LoginBindingSource As Sys~dulla^@204~ orms.BindingSource
    Friend WithEv~dulla^@204~ 1 As System.Windows.Forms.GroupBox
 ~dulla^@204~ hEvents UsernameLabel As System.Windo~dulla^@204~ l
    Friend WithEvents Label3 As Sy~dulla^@204~ Forms.Label
    Friend WithEvents La~dulla^@204~ m.Windows.Forms.Label
    Friend Wit~dulla^@204~ wPassword As System.Windows.Forms.Tex~dulla^@204~ end WithEvents txtConfirmPassword As ~dulla^@204~ s.Forms.TextBox
    Friend WithEvent~dulla^@204~ dapter As InventoryControlSystem.Logi~dulla^@204~ Adapters.UsersTableAdapter
    Frien~dulla^@204~ btnChange As System.Windows.Forms.But~dulla^@204~ nd WithEvents txtUserName As System.W~dulla^@204~ TextBox
    Friend WithEvents GroupB~dulla^@204~ .Windows.Forms.GroupBox
    Friend W~dulla^@204~ Purchaser As System.Windows.Forms.Rad~dulla^@204~  Friend WithEvents rdbSalesPerson As ~dulla^@204~ s.Forms.RadioButton
    Friend WithE~dulla^@204~ ger As System.Windows.Forms.RadioButt~dulla^@204~ d WithEvents Label4 As System.Windows~dulla^@204~ 
    Friend WithEvents cboSelect As S~dulla^@204~ .Forms.ComboBox
    Friend WithEvent~dulla^@204~  As System.Windows.Forms.PictureBox
~dulla^@204~ thEvents picClose As System.Windows.F~dulla^@204~ ox
    Friend WithEvents picMinimize~dulla^@204~ ndows.Forms.PictureBox
    Friend Wi~dulla^@204~ ome As System.Windows.Forms.Button
End Class
