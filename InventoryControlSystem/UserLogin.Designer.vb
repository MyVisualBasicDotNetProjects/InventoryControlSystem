<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserLogin
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOk = New System.Windows.Forms.Button
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.cboUserName = New System.Windows.Forms.ComboBox
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginDataSetWithType = New InventoryControlSystem.LoginDataSetWithType
        Me.LinkChangePassword = New System.Windows.Forms.LinkLabel
        Me.LoginDataSet = New InventoryControlSystem.LoginDataSet
        Me.UsersTableAdapter = New InventoryControlSystem.LoginDataSetTableAdapters.UsersTableAdapter
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter1 = New InventoryControlSystem.LoginDataSetWithTypeTableAdapters.UsersTableAdapter
        Me.lblType = New System.Windows.Forms.Label
        Me.trVisible = New System.Windows.Forms.Timer(Me.components)
        Me.picClose = New System.Windows.Forms.PictureBox
        Me.picMinimize = New System.Windows.Forms.PictureBox
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginDataSetWithType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(590, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(590, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "User Account"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.No
        Me.btnCancel.Location = New System.Drawing.Point(691, 200)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(70, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(599, 201)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(78, 23)
        Me.btnOk.TabIndex = 6
        Me.btnOk.Text = "&OK"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(593, 155)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(170, 20)
        Me.txtPassword.TabIndex = 20
        '
        'cboUserName
        '
        Me.cboUserName.DataSource = Me.LoginBindingSource
        Me.cboUserName.DisplayMember = "UserName"
        Me.cboUserName.FormattingEnabled = True
        Me.cboUserName.Location = New System.Drawing.Point(593, 97)
        Me.cboUserName.Name = "cboUserName"
        Me.cboUserName.Size = New System.Drawing.Size(170, 21)
        Me.cboUserName.TabIndex = 23
        Me.cboUserName.ValueMember = "UserName"
        '
        'LoginBindingSource
        '
        Me.LoginBindingSource.DataMember = "Users"
        Me.LoginBindingSource.DataSource = Me.LoginDataSetWithType
        '
        'LoginDataSetWithType
        '
        Me.LoginDataSetWithType.DataSetName = "LoginDataSetWithType"
        Me.LoginDataSetWithType.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LinkChangePassword
        '
        Me.LinkChangePassword.AutoSize = True
        Me.LinkChangePassword.BackColor = System.Drawing.Color.Transparent
        Me.LinkChangePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkChangePassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LinkChangePassword.Location = New System.Drawing.Point(666, 258)
        Me.LinkChangePassword.Name = "LinkChangePassword"
        Me.LinkChangePassword.Size = New System.Drawing.Size(118, 16)
        Me.LinkChangePassword.TabIndex = 24
        Me.LinkChangePassword.TabStop = True
        Me.LinkChangePassword.Text = "Change Password"
        '
        'LoginDataSet
        '
        Me.LoginDataSet.DataSetName = "LoginDataSet"
        Me.LoginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "login"
        '
        'UsersTableAdapter1
        '
        Me.UsersTableAdapter1.ClearBeforeFill = True
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "TypeOfUser", True))
        Me.lblType.Location = New System.Drawing.Point(494, 228)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(66, 13)
        Me.lblType.TabIndex = 25
        Me.lblType.Text = "Type of user"
        '
        'trVisible
        '
        '
        'picClose
        '
        Me.picClose.Image = Global.InventoryControlSystem.My.Resources.Resources.close
        Me.picClose.Location = New System.Drawing.Point(745, 6)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(22, 19)
        Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picClose.TabIndex = 48
        Me.picClose.TabStop = False
        '
        'picMinimize
        '
        Me.picMinimize.Image = Global.InventoryControlSystem.My.Resources.Resources.minimize
        Me.picMinimize.Location = New System.Drawing.Point(709, 6)
        Me.picMinimize.Name = "picMinimize"
        Me.picMinimize.Size = New System.Drawing.Size(21, 19)
        Me.picMinimize ~dulla^@204~ ~dulla^@204~ Forms.PictureBoxSizeMode.AutoSize
  ~dulla^@204~ inimize.TabIndex = 47
        Me.pic~dulla^@204~ top = False
        '
        'User~dulla^@204~   '
        Me.AutoScaleDimensions =~dulla^@204~ rawing.SizeF(6.0!, 13.0!)
        Me~dulla^@204~ e = System.Windows.Forms.AutoScaleMod~dulla^@204~    Me.BackgroundImage = Global.Invent~dulla^@204~ tem.My.Resources.Resources.bguseracco~dulla^@204~  Me.BackgroundImageLayout = System.Wi~dulla^@204~ mageLayout.None
        Me.ClientSiz~dulla^@204~ m.Drawing.Size(796, 283)
        Me.~dulla^@204~ Me.picClose)
        Me.Controls.Add~dulla^@204~ ze)
        Me.Controls.Add(Me.lblTy~dulla^@204~ Me.Controls.Add(Me.LinkChangePassword~dulla^@204~ .Controls.Add(Me.cboUserName)
      ~dulla^@204~ .Add(Me.txtPassword)
        Me.Cont~dulla^@204~ tnCancel)
        Me.Controls.Add(Me~dulla^@204~     Me.Controls.Add(Me.Label2)
     ~dulla^@204~ s.Add(Me.Label1)
        Me.DoubleBu~dulla^@204~ 
        Me.FormBorderStyle = System~dulla^@204~ s.FormBorderStyle.None
        Me.Na~dulla^@204~ in"
        Me.StartPosition = Syste~dulla^@204~ ms.FormStartPosition.CenterScreen
  ~dulla^@204~  = "User Login"
        CType(Me.Log~dulla^@204~ ce, System.ComponentModel.ISupportIni~dulla^@204~ nit()
        CType(Me.LoginDataSetW~dulla^@204~ em.ComponentModel.ISupportInitialize)~dulla^@204~        CType(Me.LoginDataSet, System.~dulla^@204~ l.ISupportInitialize).EndInit()
    ~dulla^@204~ BindingSource1, System.ComponentModel~dulla^@204~ ialize).EndInit()
        CType(Me.p~dulla^@204~ em.ComponentModel.ISupportInitialize)~dulla^@204~        CType(Me.picMinimize, System.C~dulla^@204~ .ISupportInitialize).EndInit()
     ~dulla^@204~ ayout(False)
        Me.PerformLayou~dulla^@204~ d Sub
    Friend WithEvents Label2 A~dulla^@204~ ows.Forms.Label
    Friend WithEvent~dulla^@204~ ystem.Windows.Forms.Label
    Friend~dulla^@204~ tnCancel As System.Windows.Forms.Butt~dulla^@204~ d WithEvents btnOk As System.Windows.~dulla^@204~ 
    Friend WithEvents txtPassword As~dulla^@204~ ws.Forms.TextBox
    Friend WithEven~dulla^@204~ e As System.Windows.Forms.ComboBox
 ~dulla^@204~ hEvents LinkChangePassword As System.~dulla^@204~ .LinkLabel
    Friend WithEvents Log~dulla^@204~ ce As System.Windows.Forms.BindingSou~dulla^@204~ nd WithEvents LoginDataSetWithType As~dulla^@204~ trolSystem.LoginDataSetWithType
    ~dulla^@204~ ents LoginDataSet As InventoryControl~dulla^@204~ ataSet
    Friend WithEvents UsersTa~dulla^@204~  InventoryControlSystem.LoginDataSetT~dulla^@204~ UsersTableAdapter
    Friend WithEve~dulla^@204~ urce1 As System.Windows.Forms.Binding~dulla^@204~ riend WithEvents UsersTableAdapter1 A~dulla^@204~ ntrolSystem.LoginDataSetWithTypeTable~dulla^@204~ sTableAdapter
    Friend WithEvents ~dulla^@204~ stem.Windows.Forms.Label
    Friend ~dulla^@204~ Visible As System.Windows.Forms.Timer~dulla^@204~ WithEvents picClose As System.Windows~dulla^@204~ eBox
    Friend WithEvents picMinimize As System.Windows.Forms.PictureBox
End Class
