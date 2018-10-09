<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeUserPassword
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
        Me.btnChange = New System.Windows.Forms.Button
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox
        Me.txtNewPassword = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginDataSet = New InventoryControlSystem.LoginDataSet
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.UsersTableAdapter = New InventoryControlSystem.LoginDataSetTableAdapters.UsersTableAdapter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblUserName = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtOldPassword = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.picClose = New System.Windows.Forms.PictureBox
        Me.picMinimize = New System.Windows.Forms.PictureBox
        Me.btnHome = New System.Windows.Forms.Button
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnChange
        '
        Me.btnChange.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChange.Location = New System.Drawing.Point(420, 323)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(111, 33)
        Me.btnChange.TabIndex = 0
        Me.btnChange.Text = "Change"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(138, 122)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(162, 23)
        Me.txtConfirmPassword.TabIndex = 1
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(138, 89)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(162, 23)
        Me.txtNewPassword.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "New Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Confirm Password"
        '
        'LoginBindingSource
        '
        Me.LoginBindingSource.DataMember = "Users"
        Me.LoginBindingSource.DataSource = Me.LoginDataSet
        '
        'LoginDataSet
        '
        Me.LoginDataSet.DataSetName = "LoginDataSet"
        Me.LoginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(22, 23)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(116, 23)
        Me.UsernameLabel.TabIndex = 16
        Me.UsernameLabel.Text = "User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblUserName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtOldPassword)
        Me.GroupBox1.Controls.Add(Me.UsernameLabel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNewPassword)
        Me.GroupBox1.Controls.Add(Me.txtConfirmPassword)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(283, 150)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 165)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Name Information"
        '
        'lblUserName
        '
        Me.lblUserName.BackColor = System.Drawing.SystemColors.Control
        Me.lblUserName.ForeColor = System.Drawing.Color.Black
        Me.lblUserName.Location = New System.Drawing.Point(139, 21)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(161, 23)
        Me.lblUserName.TabIndex = 19
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 15)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Old Password"
        '
        'txtOldPassword
        '
        Me.txtOldPassword.Location = New System.Drawing.Point(138, 55)
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPassword.Size = New System.Drawing.Size(162, 23)
        Me.txtOldPassword.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.InventoryControlSystem.My.Resources.Resources.helpb
        Me.PictureBox1.Location = New System.Drawing.Point(677, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 21)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 111
        Me.PictureBox1.TabStop = False
        '
        'picClose
        '
        Me.picClose.Image = Global.InventoryControlSystem.My.Resources.Resources.close
        Me.picClose.Location = New System.Drawing.Point(711, 12)
        Me.picClose.Name = "picClose"
    ~dulla^@204~ ~dulla^@204~  System.Drawing.Size(22, 19)
       ~dulla^@204~ SizeMode = System.Windows.Forms.Pictu~dulla^@204~ .AutoSize
        Me.picClose.TabInd~dulla^@204~      Me.picClose.TabStop = False
   ~dulla^@204~    'picMinimize
        '
        M~dulla^@204~ .Image = Global.InventoryControlSyste~dulla^@204~ s.Resources.minimize
        Me.picM~dulla^@204~ ion = New System.Drawing.Point(643, 1~dulla^@204~ e.picMinimize.Name = "picMinimize"
 ~dulla^@204~ Minimize.Size = New System.Drawing.Si~dulla^@204~        Me.picMinimize.SizeMode = Syst~dulla^@204~ rms.PictureBoxSizeMode.AutoSize
    ~dulla^@204~ imize.TabIndex = 109
        Me.picM~dulla^@204~ op = False
        '
        'btnHo~dulla^@204~ 
        Me.btnHome.Image = Global.I~dulla^@204~ olSystem.My.Resources.Resources.home~dulla^@204~ tnHome.Location = New System.Drawing.~dulla^@204~ 5)
        Me.btnHome.Name = "btnHom~dulla^@204~ e.btnHome.Size = New System.Drawing.S~dulla^@204~         Me.btnHome.TabIndex = 113
  ~dulla^@204~ ome.UseVisualStyleBackColor = True
 ~dulla^@204~      'ChangeUserPassword
        '
~dulla^@204~ toScaleDimensions = New System.Drawin~dulla^@204~  13.0!)
        Me.AutoScaleMode = S~dulla^@204~ .Forms.AutoScaleMode.Font
        Me~dulla^@204~ age = Global.InventoryControlSystem.M~dulla^@204~ esources.bgChangePassword
        Me~dulla^@204~ ageLayout = System.Windows.Forms.Imag~dulla^@204~ ch
        Me.ClientSize = New Syste~dulla^@204~ e(745, 432)
        Me.Controls.Add(~dulla^@204~         Me.Controls.Add(Me.PictureBox~dulla^@204~ e.Controls.Add(Me.picClose)
        ~dulla^@204~ dd(Me.picMinimize)
        Me.Contro~dulla^@204~ upBox1)
        Me.Controls.Add(Me.b~dulla^@204~       Me.DoubleBuffered = True
     ~dulla^@204~ derStyle = System.Windows.Forms.FormB~dulla^@204~ ne
        Me.Name = "ChangeUserPass~dulla^@204~   Me.StartPosition = System.Windows.F~dulla^@204~ tPosition.CenterScreen
        Me.Te~dulla^@204~ User Password"
        CType(Me.Logi~dulla^@204~ e, System.ComponentModel.ISupportInit~dulla^@204~ it()
        CType(Me.LoginDataSet, ~dulla^@204~ entModel.ISupportInitialize).EndInit(~dulla^@204~ .GroupBox1.ResumeLayout(False)
     ~dulla^@204~ x1.PerformLayout()
        CType(Me.~dulla^@204~ System.ComponentModel.ISupportInitial~dulla^@204~ )
        CType(Me.picClose, System.~dulla^@204~ l.ISupportInitialize).EndInit()
    ~dulla^@204~ picMinimize, System.ComponentModel.IS~dulla^@204~ ize).EndInit()
        Me.ResumeLayo~dulla^@204~       Me.PerformLayout()

    End S~dulla^@204~ d WithEvents btnChange As System.Wind~dulla^@204~ ton
    Friend WithEvents txtConfirm~dulla^@204~ ystem.Windows.Forms.TextBox
    Frie~dulla^@204~  txtNewPassword As System.Windows.For~dulla^@204~    Friend WithEvents Label2 As System~dulla^@204~ s.Label
    Friend WithEvents Label3~dulla^@204~ ndows.Forms.Label
    Friend WithEve~dulla^@204~ abel As System.Windows.Forms.Label
 ~dulla^@204~ hEvents LoginBindingSource As System.~dulla^@204~ .BindingSource
    Friend WithEvents~dulla^@204~  As InventoryControlSystem.LoginDataS~dulla^@204~ d WithEvents UsersTableAdapter As Inv~dulla^@204~ System.LoginDataSetTableAdapters.User~dulla^@204~ 
    Friend WithEvents GroupBox1 As ~dulla^@204~ s.Forms.GroupBox
    Friend WithEven~dulla^@204~ System.Windows.Forms.Label
    Frien~dulla^@204~ txtOldPassword As System.Windows.Form~dulla^@204~   Friend WithEvents PictureBox1 As Sy~dulla^@204~ Forms.PictureBox
    Friend WithEven~dulla^@204~ s System.Windows.Forms.PictureBox
  ~dulla^@204~ Events picMinimize As System.Windows.~dulla^@204~ Box
    Friend WithEvents btnHome As~dulla^@204~ ws.Forms.Button
    Friend WithEvent~dulla^@204~  As System.Windows.Forms.Label
End Class
