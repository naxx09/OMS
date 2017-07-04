<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeForm
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TitleLabel = New DevComponents.DotNetBar.LabelX()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.EmpNameLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.TitleLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(149, 221)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(339, 44)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Orphanage Management System"
        Me.TitleLabel.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer)))
        '
        'EmpNameLabel
        '
        Me.EmpNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EmpNameLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpNameLabel.Location = New System.Drawing.Point(150, 35)
        Me.EmpNameLabel.Name = "EmpNameLabel"
        Me.EmpNameLabel.Size = New System.Drawing.Size(339, 90)
        Me.EmpNameLabel.TabIndex = 1
        Me.EmpNameLabel.Text = "Welcome" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Employee Name"
        Me.EmpNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = Global.OMS.My.Resources.Resources.icon_150x150_50wt_bg
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(265, 128)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'WelcomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 420)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.EmpNameLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.DoubleBuffered = True
        Me.Name = "WelcomeForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Private WithEvents TitleLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents EmpNameLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
