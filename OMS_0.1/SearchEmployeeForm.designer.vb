<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchEmployeeForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchEmployeeForm))
        Me.EmployeeIDTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SEmployeeID = New System.Windows.Forms.Label()
        Me.SearchGroupPanel = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LastNameTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.FirstNameTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LastNameLabel = New DevComponents.DotNetBar.LabelX()
        Me.SFNLabel = New DevComponents.DotNetBar.LabelX()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.ExportButton = New DevComponents.DotNetBar.ButtonX()
        Me.DBDataGridView = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.SuperTooltip1 = New DevComponents.DotNetBar.SuperTooltip()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.RefreshButton = New DevComponents.DotNetBar.ButtonX()
        Me.Export2Button = New DevComponents.DotNetBar.ButtonX()
        Me.EditButton = New DevComponents.DotNetBar.ButtonX()
        Me.CircularProgress1 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.CircularProgress2 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.SearchGroupPanel.SuspendLayout()
        CType(Me.DBDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmployeeIDTextBox
        '
        Me.EmployeeIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EmployeeIDTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeIDTextBox.Location = New System.Drawing.Point(390, 51)
        Me.EmployeeIDTextBox.Multiline = True
        Me.EmployeeIDTextBox.Name = "EmployeeIDTextBox"
        Me.EmployeeIDTextBox.ReadOnly = True
        Me.EmployeeIDTextBox.Size = New System.Drawing.Size(47, 24)
        Me.EmployeeIDTextBox.TabIndex = 999
        '
        'EmployeeNameTextBox
        '
        Me.EmployeeNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EmployeeNameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeNameTextBox.Location = New System.Drawing.Point(390, 82)
        Me.EmployeeNameTextBox.Multiline = True
        Me.EmployeeNameTextBox.Name = "EmployeeNameTextBox"
        Me.EmployeeNameTextBox.ReadOnly = True
        Me.EmployeeNameTextBox.Size = New System.Drawing.Size(186, 24)
        Me.EmployeeNameTextBox.TabIndex = 999
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(274, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Employee Name:"
        '
        'SEmployeeID
        '
        Me.SEmployeeID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SEmployeeID.AutoSize = True
        Me.SEmployeeID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SEmployeeID.Location = New System.Drawing.Point(294, 54)
        Me.SEmployeeID.Name = "SEmployeeID"
        Me.SEmployeeID.Size = New System.Drawing.Size(76, 15)
        Me.SEmployeeID.TabIndex = 7
        Me.SEmployeeID.Text = "Employee ID:"
        '
        'SearchGroupPanel
        '
        Me.SearchGroupPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SearchGroupPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me.SearchGroupPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.SearchGroupPanel.Controls.Add(Me.LabelX1)
        Me.SearchGroupPanel.Controls.Add(Me.LastNameTextBox)
        Me.SearchGroupPanel.Controls.Add(Me.FirstNameTextBox)
        Me.SearchGroupPanel.Controls.Add(Me.LastNameLabel)
        Me.SearchGroupPanel.Controls.Add(Me.SFNLabel)
        Me.SearchGroupPanel.DisabledBackColor = System.Drawing.Color.Empty
        Me.SearchGroupPanel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchGroupPanel.Location = New System.Drawing.Point(14, 10)
        Me.SearchGroupPanel.Name = "SearchGroupPanel"
        Me.SearchGroupPanel.Size = New System.Drawing.Size(240, 125)
        '
        '
        '
        Me.SearchGroupPanel.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.SearchGroupPanel.Style.BackColorGradientAngle = 90
        Me.SearchGroupPanel.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.SearchGroupPanel.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.SearchGroupPanel.Style.BorderBottomWidth = 1
        Me.SearchGroupPanel.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.SearchGroupPanel.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.SearchGroupPanel.Style.BorderLeftWidth = 1
        Me.SearchGroupPanel.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.SearchGroupPanel.Style.BorderRightWidth = 1
        Me.SearchGroupPanel.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.SearchGroupPanel.Style.BorderTopWidth = 1
        Me.SearchGroupPanel.Style.CornerDiameter = 4
        Me.SearchGroupPanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.SearchGroupPanel.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.SearchGroupPanel.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.SearchGroupPanel.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.SearchGroupPanel.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.SearchGroupPanel.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SearchGroupPanel.TabIndex = 8
        Me.SearchGroupPanel.Text = "Search Employee"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Image = Global.OMS.My.Resources.Resources.ic_help_outline_black_18dp_1x
        Me.LabelX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.LabelX1.Location = New System.Drawing.Point(208, 36)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX1.Size = New System.Drawing.Size(21, 21)
        Me.SuperTooltip1.SetSuperTooltip(Me.LabelX1, New DevComponents.DotNetBar.SuperTooltipInfo("Tip", "", "Input employee's first name or last name to start searching.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, True, False, New System.Drawing.Size(0, 0)))
        Me.LabelX1.TabIndex = 100
        '
        'LastNameTextBox
        '
        '
        '
        '
        Me.LastNameTextBox.Border.Class = "TextBoxBorder"
        Me.LastNameTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LastNameTextBox.ButtonCustom.Tooltip = ""
        Me.LastNameTextBox.ButtonCustom2.Tooltip = ""
        Me.LastNameTextBox.Location = New System.Drawing.Point(85, 52)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.PreventEnterBeep = True
        Me.LastNameTextBox.Size = New System.Drawing.Size(117, 23)
        Me.LastNameTextBox.TabIndex = 2
        '
        'FirstNameTextBox
        '
        '
        '
        '
        Me.FirstNameTextBox.Border.Class = "TextBoxBorder"
        Me.FirstNameTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.FirstNameTextBox.ButtonCustom.Tooltip = ""
        Me.FirstNameTextBox.ButtonCustom2.Tooltip = ""
        Me.FirstNameTextBox.Location = New System.Drawing.Point(85, 18)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.PreventEnterBeep = True
        Me.FirstNameTextBox.Size = New System.Drawing.Size(117, 23)
        Me.FirstNameTextBox.TabIndex = 1
        '
        'LastNameLabel
        '
        Me.LastNameLabel.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LastNameLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LastNameLabel.Location = New System.Drawing.Point(2, 48)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(72, 27)
        Me.LastNameLabel.TabIndex = 1
        Me.LastNameLabel.Text = "Last Name:"
        '
        'SFNLabel
        '
        Me.SFNLabel.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.SFNLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SFNLabel.Location = New System.Drawing.Point(3, 15)
        Me.SFNLabel.Name = "SFNLabel"
        Me.SFNLabel.Size = New System.Drawing.Size(71, 27)
        Me.SFNLabel.TabIndex = 0
        Me.SFNLabel.Text = "First Name:"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer)))
        '
        'ExportButton
        '
        Me.ExportButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ExportButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ExportButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ExportButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportButton.Location = New System.Drawing.Point(297, 112)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(75, 23)
        Me.ExportButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.ExportButton, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Export employee table into MS Excel.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, False, False, New System.Drawing.Size(0, 0)))
        Me.ExportButton.TabIndex = 4
        Me.ExportButton.Text = "E&xport to XLS"
        '
        'DBDataGridView
        '
        Me.DBDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DBDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DBDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.DBDataGridView.EnableHeadersVisualStyles = False
        Me.DBDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DBDataGridView.Location = New System.Drawing.Point(14, 147)
        Me.DBDataGridView.Name = "DBDataGridView"
        Me.DBDataGridView.ReadOnly = True
        Me.DBDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DBDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DBDataGridView.Size = New System.Drawing.Size(687, 339)
        Me.DBDataGridView.TabIndex = 9
        '
        'SuperTooltip1
        '
        Me.SuperTooltip1.DefaultTooltipSettings = New DevComponents.DotNetBar.SuperTooltipInfo("", "", "", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray)
        Me.SuperTooltip1.HoverDelayMultiplier = 1
        '
        'LabelX2
        '
        Me.LabelX2.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Image = Global.OMS.My.Resources.Resources.ic_help_outline_black_18dp_1x
        Me.LabelX2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.LabelX2.Location = New System.Drawing.Point(444, 52)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX2.Size = New System.Drawing.Size(21, 21)
        Me.SuperTooltip1.SetSuperTooltip(Me.LabelX2, New DevComponents.DotNetBar.SuperTooltipInfo("Tip", "", "To edit employee information, double click record in the table.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, True, False, New System.Drawing.Size(0, 0)))
        Me.LabelX2.TabIndex = 1000
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
        Me.RefreshButton.Location = New System.Drawing.Point(660, 112)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(29, 29)
        Me.RefreshButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.RefreshButton, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Refresh employee table.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, False, False, New System.Drawing.Size(0, 0)))
        Me.RefreshButton.TabIndex = 6
        '
        'Export2Button
        '
        Me.Export2Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Export2Button.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Export2Button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Export2Button.Location = New System.Drawing.Point(444, 115)
        Me.Export2Button.Name = "Export2Button"
        Me.Export2Button.Size = New System.Drawing.Size(75, 23)
        Me.Export2Button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.Export2Button, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Save employee table as a PDF File.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, False, False, New System.Drawing.Size(0, 0)))
        Me.Export2Button.TabIndex = 5
        Me.Export2Button.Text = "Save as &PDF"
        '
        'EditButton
        '
        Me.EditButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.EditButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EditButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.EditButton.Enabled = False
        Me.EditButton.Location = New System.Drawing.Point(626, 54)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.EditButton, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Edit selected child record." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Clicking this button will open a new window.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, False, False, New System.Drawing.Size(0, 0)))
        Me.EditButton.TabIndex = 3
        Me.EditButton.Text = "&Edit"
        '
        'CircularProgress1
        '
        Me.CircularProgress1.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.CircularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CircularProgress1.Location = New System.Drawing.Point(266, 115)
        Me.CircularProgress1.Name = "CircularProgress1"
        Me.CircularProgress1.Size = New System.Drawing.Size(31, 23)
        Me.CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress1.TabIndex = 1002
        '
        'CircularProgress2
        '
        Me.CircularProgress2.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.CircularProgress2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CircularProgress2.Location = New System.Drawing.Point(412, 114)
        Me.CircularProgress2.Name = "CircularProgress2"
        Me.CircularProgress2.Size = New System.Drawing.Size(31, 23)
        Me.CircularProgress2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress2.TabIndex = 1011
        '
        'SearchEmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 501)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.CircularProgress2)
        Me.Controls.Add(Me.Export2Button)
        Me.Controls.Add(Me.CircularProgress1)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.DBDataGridView)
        Me.Controls.Add(Me.ExportButton)
        Me.Controls.Add(Me.SearchGroupPanel)
        Me.Controls.Add(Me.SEmployeeID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.EmployeeNameTextBox)
        Me.Controls.Add(Me.EmployeeIDTextBox)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(731, 540)
        Me.Name = "SearchEmployeeForm"
        Me.Text = "Employee Information Management"
        Me.SearchGroupPanel.ResumeLayout(False)
        CType(Me.DBDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EmployeeIDTextBox As TextBox
    Friend WithEvents EmployeeNameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents SEmployeeID As Label
    Private WithEvents SearchGroupPanel As DevComponents.DotNetBar.Controls.GroupPanel
    Private WithEvents LastNameTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents FirstNameTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents LastNameLabel As DevComponents.DotNetBar.LabelX
    Private WithEvents SFNLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents ExportButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DBDataGridView As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents SuperTooltip1 As DevComponents.DotNetBar.SuperTooltip
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents RefreshButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents CircularProgress1 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents CircularProgress2 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents Export2Button As DevComponents.DotNetBar.ButtonX
    Friend WithEvents EditButton As DevComponents.DotNetBar.ButtonX
End Class
