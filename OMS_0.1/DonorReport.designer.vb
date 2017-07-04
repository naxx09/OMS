<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DonorReport
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DonorDataGridView = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.DeleteButton = New DevComponents.DotNetBar.ButtonX()
        Me.RefreshButton = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.FNTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LNTextBox = New System.Windows.Forms.TextBox()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.SupervisorTextBox = New System.Windows.Forms.TextBox()
        Me.DonorIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.SuperTooltip1 = New DevComponents.DotNetBar.SuperTooltip()
        Me.ExportButton = New DevComponents.DotNetBar.ButtonX()
        Me.Export2Button = New DevComponents.DotNetBar.ButtonX()
        Me.EditButton = New DevComponents.DotNetBar.ButtonX()
        Me.CircularProgress1 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.CircularProgress2 = New DevComponents.DotNetBar.Controls.CircularProgress()
        CType(Me.DonorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DonorDataGridView
        '
        Me.DonorDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DonorDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DonorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DonorDataGridView.DefaultCellStyle = DataGridViewCellStyle5
        Me.DonorDataGridView.EnableHeadersVisualStyles = False
        Me.DonorDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DonorDataGridView.Location = New System.Drawing.Point(12, 151)
        Me.DonorDataGridView.Name = "DonorDataGridView"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DonorDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DonorDataGridView.Size = New System.Drawing.Size(820, 350)
        Me.DonorDataGridView.TabIndex = 25
        '
        'DeleteButton
        '
        Me.DeleteButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DeleteButton.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.DeleteButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(690, 12)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(81, 23)
        Me.DeleteButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.DeleteButton, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Delete selected donor record.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, False, False, New System.Drawing.Size(0, 0)))
        Me.DeleteButton.TabIndex = 0
        Me.DeleteButton.Text = "&Delete record"
        '
        'RefreshButton
        '
        Me.RefreshButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.RefreshButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RefreshButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.RefreshButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshButton.Image = Global.OMS.My.Resources.Resources.ic_refresh_black_24dp_2x
        Me.RefreshButton.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.RefreshButton.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.RefreshButton.Location = New System.Drawing.Point(690, 120)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(25, 25)
        Me.RefreshButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.RefreshButton, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Refresh database", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, False, False, New System.Drawing.Size(0, 0)))
        Me.RefreshButton.TabIndex = 6
        '
        'GroupPanel1
        '
        Me.GroupPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.FNTextBox)
        Me.GroupPanel1.Controls.Add(Me.Label2)
        Me.GroupPanel1.Controls.Add(Me.Label3)
        Me.GroupPanel1.Controls.Add(Me.LNTextBox)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(71, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(239, 104)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 1003
        Me.GroupPanel1.Text = "Search for Donor"
        '
        'FNTextBox
        '
        Me.FNTextBox.Location = New System.Drawing.Point(86, 15)
        Me.FNTextBox.MaxLength = 20
        Me.FNTextBox.Name = "FNTextBox"
        Me.FNTextBox.Size = New System.Drawing.Size(132, 23)
        Me.FNTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(13, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "First Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(15, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "LastName:"
        '
        'LNTextBox
        '
        Me.LNTextBox.Location = New System.Drawing.Point(86, 52)
        Me.LNTextBox.MaxLength = 20
        Me.LNTextBox.Name = "LNTextBox"
        Me.LNTextBox.Size = New System.Drawing.Size(132, 23)
        Me.LNTextBox.TabIndex = 2
        '
        'GroupPanel2
        '
        Me.GroupPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.SupervisorTextBox)
        Me.GroupPanel2.Controls.Add(Me.DonorIDTextBox)
        Me.GroupPanel2.Controls.Add(Me.Label1)
        Me.GroupPanel2.Controls.Add(Me.Label4)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(361, 12)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(233, 104)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 0
        Me.GroupPanel2.Text = "Donor Information"
        '
        'SupervisorTextBox
        '
        Me.SupervisorTextBox.Location = New System.Drawing.Point(93, 15)
        Me.SupervisorTextBox.Name = "SupervisorTextBox"
        Me.SupervisorTextBox.ReadOnly = True
        Me.SupervisorTextBox.Size = New System.Drawing.Size(119, 23)
        Me.SupervisorTextBox.TabIndex = 0
        '
        'DonorIDTextBox
        '
        Me.DonorIDTextBox.Location = New System.Drawing.Point(93, 48)
        Me.DonorIDTextBox.Name = "DonorIDTextBox"
        Me.DonorIDTextBox.ReadOnly = True
        Me.DonorIDTextBox.Size = New System.Drawing.Size(119, 23)
        Me.DonorIDTextBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(8, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 15)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Supervisor ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(30, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Donor ID:"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer)))
        '
        'SuperTooltip1
        '
        Me.SuperTooltip1.DefaultTooltipSettings = New DevComponents.DotNetBar.SuperTooltipInfo("", "", "", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray)
        '
        'ExportButton
        '
        Me.ExportButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ExportButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ExportButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ExportButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportButton.Location = New System.Drawing.Point(375, 122)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(89, 23)
        Me.ExportButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.ExportButton, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Export employee table as a MS Excel file.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, False, False, New System.Drawing.Size(0, 0)))
        Me.ExportButton.TabIndex = 4
        Me.ExportButton.Text = "Export to &XLS"
        '
        'Export2Button
        '
        Me.Export2Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Export2Button.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Export2Button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Export2Button.Location = New System.Drawing.Point(505, 122)
        Me.Export2Button.Name = "Export2Button"
        Me.Export2Button.Size = New System.Drawing.Size(89, 23)
        Me.Export2Button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.Export2Button, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Save donor table as a PDF file.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, False, False, New System.Drawing.Size(0, 0)))
        Me.Export2Button.TabIndex = 5
        Me.Export2Button.Text = "Save as &PDF file"
        '
        'EditButton
        '
        Me.EditButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.EditButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EditButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.EditButton.Location = New System.Drawing.Point(690, 77)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(81, 23)
        Me.EditButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.EditButton, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Edit selected donor record." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Clicking this button will open a new window.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, False, False, New System.Drawing.Size(0, 0)))
        Me.EditButton.TabIndex = 3
        Me.EditButton.Text = "&Edit record"
        '
        'CircularProgress1
        '
        Me.CircularProgress1.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.CircularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CircularProgress1.Location = New System.Drawing.Point(350, 122)
        Me.CircularProgress1.Name = "CircularProgress1"
        Me.CircularProgress1.Size = New System.Drawing.Size(19, 23)
        Me.CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress1.TabIndex = 1005
        '
        'CircularProgress2
        '
        Me.CircularProgress2.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.CircularProgress2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CircularProgress2.Location = New System.Drawing.Point(472, 122)
        Me.CircularProgress2.Name = "CircularProgress2"
        Me.CircularProgress2.Size = New System.Drawing.Size(31, 23)
        Me.CircularProgress2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress2.TabIndex = 1011
        '
        'DonorReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 513)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.CircularProgress2)
        Me.Controls.Add(Me.Export2Button)
        Me.Controls.Add(Me.CircularProgress1)
        Me.Controls.Add(Me.ExportButton)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.DonorDataGridView)
        Me.DoubleBuffered = True
        Me.Name = "DonorReport"
        Me.Text = "Donor Report"
        CType(Me.DonorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DonorDataGridView As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents DeleteButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents RefreshButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents FNTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LNTextBox As TextBox
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents SupervisorTextBox As TextBox
    Friend WithEvents DonorIDTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SuperTooltip1 As DevComponents.DotNetBar.SuperTooltip
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents CircularProgress1 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents ExportButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents CircularProgress2 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents Export2Button As DevComponents.DotNetBar.ButtonX
    Friend WithEvents EditButton As DevComponents.DotNetBar.ButtonX
End Class
