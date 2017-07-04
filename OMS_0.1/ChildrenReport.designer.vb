<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChildrenReport
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ChildTextBox = New System.Windows.Forms.TextBox()
        Me.FullNameTextBox = New System.Windows.Forms.TextBox()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.SuperTooltip1 = New DevComponents.DotNetBar.SuperTooltip()
        Me.RefreshButton = New DevComponents.DotNetBar.ButtonX()
        Me.DetailButton = New DevComponents.DotNetBar.ButtonX()
        Me.ExportButton = New DevComponents.DotNetBar.ButtonX()
        Me.Export2Button = New DevComponents.DotNetBar.ButtonX()
        Me.ChildrenDataGridView = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LastNTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FirstNTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuperviorTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.CircularProgress1 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.CircularProgress2 = New DevComponents.DotNetBar.Controls.CircularProgress()
        CType(Me.ChildrenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Children ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(6, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Full Name:"
        '
        'ChildTextBox
        '
        Me.ChildTextBox.Location = New System.Drawing.Point(74, 14)
        Me.ChildTextBox.Name = "ChildTextBox"
        Me.ChildTextBox.Size = New System.Drawing.Size(100, 23)
        Me.ChildTextBox.TabIndex = 11
        '
        'FullNameTextBox
        '
        Me.FullNameTextBox.Location = New System.Drawing.Point(74, 57)
        Me.FullNameTextBox.Name = "FullNameTextBox"
        Me.FullNameTextBox.Size = New System.Drawing.Size(145, 23)
        Me.FullNameTextBox.TabIndex = 12
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
        'RefreshButton
        '
        Me.RefreshButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.RefreshButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RefreshButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.RefreshButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshButton.Image = Global.OMS.My.Resources.Resources.ic_refresh_black_24dp_2x
        Me.RefreshButton.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.RefreshButton.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.RefreshButton.Location = New System.Drawing.Point(673, 166)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(25, 25)
        Me.RefreshButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.RefreshButton, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Refresh Database", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, False, False, New System.Drawing.Size(0, 0)))
        Me.RefreshButton.TabIndex = 1002
        '
        'DetailButton
        '
        Me.DetailButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.DetailButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DetailButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.DetailButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailButton.Location = New System.Drawing.Point(623, 75)
        Me.DetailButton.Name = "DetailButton"
        Me.DetailButton.Size = New System.Drawing.Size(75, 23)
        Me.DetailButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.DetailButton, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Edit selected child record." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Clicking this button will open a new window.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, False, False, New System.Drawing.Size(0, 0)))
        Me.DetailButton.TabIndex = 0
        Me.DetailButton.Text = "&Edit"
        '
        'ExportButton
        '
        Me.ExportButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ExportButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ExportButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ExportButton.Location = New System.Drawing.Point(378, 153)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(75, 23)
        Me.ExportButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.ExportButton, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Save children table as a MS Excel file.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, False, False, New System.Drawing.Size(0, 0)))
        Me.ExportButton.TabIndex = 1005
        Me.ExportButton.Text = "Export to &XLS"
        '
        'Export2Button
        '
        Me.Export2Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Export2Button.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Export2Button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Export2Button.Location = New System.Drawing.Point(505, 153)
        Me.Export2Button.Name = "Export2Button"
        Me.Export2Button.Size = New System.Drawing.Size(75, 23)
        Me.Export2Button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.Export2Button, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Save children table as a PDF file.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, False, False, New System.Drawing.Size(0, 0)))
        Me.Export2Button.TabIndex = 1010
        Me.Export2Button.Text = "Save as &PDF"
        '
        'ChildrenDataGridView
        '
        Me.ChildrenDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ChildrenDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ChildrenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ChildrenDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.ChildrenDataGridView.EnableHeadersVisualStyles = False
        Me.ChildrenDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ChildrenDataGridView.Location = New System.Drawing.Point(12, 197)
        Me.ChildrenDataGridView.Name = "ChildrenDataGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ChildrenDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.ChildrenDataGridView.Size = New System.Drawing.Size(690, 263)
        Me.ChildrenDataGridView.TabIndex = 1003
        '
        'GroupPanel1
        '
        Me.GroupPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.LastNTextBox)
        Me.GroupPanel1.Controls.Add(Me.Label3)
        Me.GroupPanel1.Controls.Add(Me.FirstNTextBox)
        Me.GroupPanel1.Controls.Add(Me.Label2)
        Me.GroupPanel1.Controls.Add(Me.SuperviorTextBox)
        Me.GroupPanel1.Controls.Add(Me.Label1)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(107, 19)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(201, 157)
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
        Me.GroupPanel1.TabIndex = 1004
        Me.GroupPanel1.Text = "Search for Child"
        '
        'LastNTextBox
        '
        Me.LastNTextBox.Location = New System.Drawing.Point(81, 92)
        Me.LastNTextBox.Name = "LastNTextBox"
        Me.LastNTextBox.Size = New System.Drawing.Size(100, 23)
        Me.LastNTextBox.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "LastName:"
        '
        'FirstNTextBox
        '
        Me.FirstNTextBox.Location = New System.Drawing.Point(81, 53)
        Me.FirstNTextBox.Name = "FirstNTextBox"
        Me.FirstNTextBox.Size = New System.Drawing.Size(100, 23)
        Me.FirstNTextBox.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "First Name:"
        '
        'SuperviorTextBox
        '
        Me.SuperviorTextBox.Location = New System.Drawing.Point(81, 14)
        Me.SuperviorTextBox.Name = "SuperviorTextBox"
        Me.SuperviorTextBox.Size = New System.Drawing.Size(100, 23)
        Me.SuperviorTextBox.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(9, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Supervior ID:"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.FullNameTextBox)
        Me.GroupPanel2.Controls.Add(Me.ChildTextBox)
        Me.GroupPanel2.Controls.Add(Me.Label4)
        Me.GroupPanel2.Controls.Add(Me.Label5)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(347, 19)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(233, 115)
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
        Me.GroupPanel2.Text = "Child Information"
        '
        'CircularProgress1
        '
        Me.CircularProgress1.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.CircularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CircularProgress1.Location = New System.Drawing.Point(346, 153)
        Me.CircularProgress1.Name = "CircularProgress1"
        Me.CircularProgress1.Size = New System.Drawing.Size(31, 23)
        Me.CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress1.TabIndex = 1006
        '
        'CircularProgress2
        '
        Me.CircularProgress2.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.CircularProgress2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CircularProgress2.Location = New System.Drawing.Point(473, 152)
        Me.CircularProgress2.Name = "CircularProgress2"
        Me.CircularProgress2.Size = New System.Drawing.Size(31, 23)
        Me.CircularProgress2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress2.TabIndex = 1011
        '
        'ChildrenReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 472)
        Me.Controls.Add(Me.CircularProgress2)
        Me.Controls.Add(Me.Export2Button)
        Me.Controls.Add(Me.CircularProgress1)
        Me.Controls.Add(Me.ExportButton)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.ChildrenDataGridView)
        Me.Controls.Add(Me.DetailButton)
        Me.Controls.Add(Me.RefreshButton)
        Me.DoubleBuffered = True
        Me.Name = "ChildrenReport"
        Me.Text = "Report"
        CType(Me.ChildrenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ChildTextBox As TextBox
    Friend WithEvents FullNameTextBox As TextBox
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents SuperTooltip1 As DevComponents.DotNetBar.SuperTooltip
    Friend WithEvents RefreshButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DetailButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ChildrenDataGridView As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LastNTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FirstNTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents SuperviorTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ExportButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents CircularProgress1 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents CircularProgress2 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents Export2Button As DevComponents.DotNetBar.ButtonX
End Class
