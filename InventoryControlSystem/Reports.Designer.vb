<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.picClose = New System.Windows.Forms.PictureBox
        Me.picMinimize = New System.Windows.Forms.PictureBox
        Me.btnRptProducts = New System.Windows.Forms.Button
        Me.btnOrdersReport = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnHome = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.InventoryControlSystem.My.Resources.Resources.helpb
        Me.PictureBox1.Location = New System.Drawing.Point(771, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 21)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 108
        Me.PictureBox1.TabStop = False
        '
        'picClose
        '
        Me.picClose.Image = Global.InventoryControlSystem.My.Resources.Resources.close
        Me.picClose.Location = New System.Drawing.Point(805, 12)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(22, 19)
        Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picClose.TabIndex = 107
        Me.picClose.TabStop = False
        '
        'picMinimize
        '
        Me.picMinimize.Image = Global.InventoryControlSystem.My.Resources.Resources.minimize
        Me.picMinimize.Location = New System.Drawing.Point(737, 13)
        Me.picMinimize.Name = "picMinimize"
        Me.picMinimize.Size = New System.Drawing.Size(21, 19)
        Me.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMinimize.TabIndex = 106
        Me.picMinimize.TabStop = False
        '
        'btnRptProducts
        '
        Me.btnRptProducts.BackColor = System.Drawing.Color.Transparent
        Me.btnRptProducts.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRptProducts.Location = New System.Drawing.Point(308, 168)
        Me.btnRptProducts.Name = "btnRptProducts"
        Me.btnRptProducts.Size = New System.Drawing.Size(237, 38)
        Me.btnRptProducts.TabIndex = 109
        Me.btnRptProducts.Text = "Products Report"
        Me.btnRptProducts.UseVisualStyleBackColor = False
        '
        'btnOrdersReport
        '
        Me.btnOrdersReport.BackColor = System.Drawing.Color.Transparent
        Me.btnOrdersReport.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrdersReport.Location = New System.Drawing.Point(308, 228)
        Me.btnOrdersReport.Name = "btnOrdersReport"
        Me.btnOrdersReport.Size = New System.Drawing.Size(237, 38)
        Me.btnOrdersReport.TabIndex = 110
        Me.btnOrdersReport.Text = "Orders Report"
        Me.btnOrdersReport.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(308, 290)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(237, 38)
        Me.Button1.TabIndex = 111
        Me.Button1.Text = "Stock Card Report"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.Image = Global.InventoryControlSystem.My.Resources.Resources.home
        Me.btnHome.Location = New System.Drawing.Point(628, 388)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(41, 39)
        Me.btnHome.TabIndex = 114
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.InventoryControlSystem.My.Resources.Resources.bgReports
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(839, 535)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnOrdersReport)
        Me.Controls.Add(Me.btnRptProducts)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.picMinimize)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents picClose As System.Windows.Forms.PictureBox
    Friend WithEvents picMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents btnRptProducts As System.Windows.Forms.Button
    Friend WithEvents btnOrdersReport As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
End Class
