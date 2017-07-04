<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdopterReport
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
        Me.FullNameTextBox = New System.Windows.Forms.TextBox()
        Me.AdopterTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LastNTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FirstNTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MemberIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.SuperTooltip1 = New DevComponents.DotNetBar.SuperTooltip()
        Me.RefreshButton = New DevComponents.DotNetBar.ButtonX()
        Me.AddButton = New DevComponents.DotNetBar.ButtonX()
        Me.EditButton = New DevComponents.DotNetBar.ButtonX()
        Me.ExportButton = New DevComponents.DotNetBar.ButtonX()
        Me.Export2Button = New DevComponents.DotNetBar.ButtonX()
        Me.DeleteButton = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.AdopterDataGridView = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.CircularProgress1 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.CircularProgress2 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.AdopterDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FullNameTextBox
        '
        Me.FullNameTextBox.Location = New System.Drawing.Point(91, 62)
        Me.FullNameTextBox.Name = "FullNameTextBox"
        Me.FullNameTextBox.Size = New System.Drawing.Size(145, 23)
        Me.FullNameTextBox.TabIndex = 12
        '
        'AdopterTextBox
        '
        Me.AdopterTextBox.Location = New System.Drawing.Point(91, 11)
        Me.AdopterTextBox.Name = "AdopterTextBox"
        Me.AdopterTextBox.Size = New System.Drawing.Size(100, 23)
        Me.AdopterTextBox.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(23, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Full Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(23, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Adopter ID:"
        '
        'LastNTextBox
        '
        Me.LastNTextBox.Location = New System.Drawing.Point(82, 102)
        Me.LastNTextBox.Name = "LastNTextBox"
        Me.LastNTextBox.Size = New System.Drawing.Size(100, 23)
        Me.LastNTextBox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(13, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "LastName:"
        '
        'FirstNTextBox
        '
        Me.FirstNTextBox.Location = New System.Drawing.Point(82, 53)
        Me.FirstNTextBox.Name = "FirstNTextBox"
        Me.FirstNTextBox.Size = New System.Drawing.Size(100, 23)
        Me.FirstNTextBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(13, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "First Name:"
        '
        'MemberIDTextBox
        '
        Me.MemberIDTextBox.Location = New System.Drawing.Point(82, 9)
        Me.MemberIDTextBox.Name = "MemberIDTextBox"
        Me.MemberIDTextBox.Size = New System.Drawing.Size(100, 23)
        Me.MemberIDTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(10, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Adopter ID:"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(38, Byte), Integer)))
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
        Me.RefreshButton.Location = New System.Drawing.Point(695, 174)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(25, 25)
        Me.RefreshButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.RefreshButton, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Refresh Database", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, False, False, New System.Drawing.Size(0, 0)))
        Me.RefreshButton.TabIndex = 1002
        '
        'AddButton
        '
        Me.AddButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.AddButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AddButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.AddButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.Location = New System.Drawing.Point(645, 66)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.AddButton, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Add new adopter." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Clicking this button will open a new window.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, False, False, New System.Drawing.Size(0, 0)))
        Me.AddButton.TabIndex = 13
        Me.AddButton.Text = "&Add"
        '
        'EditButton
        '
        Me.EditButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.EditButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EditButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.EditButton.Enabled = False
        Me.EditButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.Location = New System.Drawing.Point(645, 117)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.EditButton, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Edit selected adopter record." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click this button will open a new window.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, False, False, New System.Drawing.Size(0, 0)))
        Me.EditButton.TabIndex = 0
        Me.EditButton.Text = "&Edit"
        '
        'ExportButton
        '
        Me.ExportButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ExportButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ExportButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ExportButton.Location = New System.Drawing.Point(376, 150)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(91, 23)
        Me.ExportButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.ExportButton, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Save adopter table as MS Excel file", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, False, False, New System.Drawing.Size(0, 0)))
        Me.ExportButton.TabIndex = 1007
        Me.ExportButton.Text = "Export to &XLS"
        '
        'Export2Button
        '
        Me.Export2Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Export2Button.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Export2Button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Export2Button.Location = New System.Drawing.Point(529, 150)
        Me.Export2Button.Name = "Export2Button"
        Me.Export2Button.Size = New System.Drawing.Size(91, 23)
        Me.Export2Button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.Export2Button, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Save adopter table as a PDF file", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, False, False, New System.Drawing.Size(0, 0)))
        Me.Export2Button.TabIndex = 0
        Me.Export2Button.Text = "Save as &PDF file"
        '
        'DeleteButton
        '
        Me.DeleteButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DeleteButton.BackColor = System.Drawing.SystemColors.Window
        Me.DeleteButton.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.DeleteButton.Enabled = False
        Me.DeleteButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(645, 18)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.DeleteButton, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Delete selected adopter record.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, False, False, New System.Drawing.Size(0, 0)))
        Me.DeleteButton.TabIndex = 0
        Me.DeleteButton.Text = "&Delete record"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.LastNTextBox)
        Me.GroupPanel1.Controls.Add(Me.MemberIDTextBox)
        Me.GroupPanel1.Controls.Add(Me.Label3)
        Me.GroupPanel1.Controls.Add(Me.Label1)
        Me.GroupPanel1.Controls.Add(Me.FirstNTextBox)
        Me.GroupPanel1.Controls.Add(Me.Label2)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(117, 18)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(206, 155)
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
        Me.GroupPanel1.TabIndex = 21
        Me.GroupPanel1.Text = "Search for Adopter"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.FullNameTextBox)
        Me.GroupPanel2.Controls.Add(Me.AdopterTextBox)
        Me.GroupPanel2.Controls.Add(Me.Label4)
        Me.GroupPanel2.Controls.Add(Me.Label5)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(347, 18)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(273, 118)
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
        Me.GroupPanel2.TabIndex = 22
        Me.GroupPanel2.Text = "Adopter Information"
        '
        'AdopterDataGridView
        '
        Me.AdopterDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AdopterDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.AdopterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AdopterDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.AdopterDataGridView.EnableHeadersVisualStyles = False
        Me.AdopterDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.AdopterDataGridView.Location = New System.Drawing.Point(12, 205)
        Me.AdopterDataGridView.Name = "AdopterDataGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AdopterDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.AdopterDataGridView.Size = New System.Drawing.Size(841, 297)
        Me.AdopterDataGridView.TabIndex = 0
        '
        'CircularProgress1
        '
        Me.CircularProgress1.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.CircularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CircularProgress1.Location = New System.Drawing.Point(344, 150)
        Me.CircularProgress1.Name = "CircularProgress1"
        Me.CircularProgress1.Size = New System.Drawing.Size(31, 23)
        Me.CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress1.TabIndex = 1008
        '
        'CircularProgress2
        '
        Me.CircularProgress2.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.CircularProgress2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CircularProgress2.Location = New System.Drawing.Point(497, 149)
        Me.CircularProgress2.Name = "CircularProgress2"
        Me.CircularProgress2.Size = New System.Drawing.Size(31, 23)
        Me.CircularProgress2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress2.TabIndex = 1009
        '
        'AdopterReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 514)
        Me.Controls.Add(Me.CircularProgress2)
        Me.Controls.Add(Me.Export2Button)
        Me.Controls.Add(Me.CircularProgress1)
        Me.Controls.Add(Me.ExportButton)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.AdopterDataGridView)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.GroupPanel1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.Name = "AdopterReport"
        Me.Text = "Adopterreport"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        CType(Me.AdopterDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FullNameTextBox As TextBox
    Friend WithEvents AdopterTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LastNTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FirstNTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MemberIDTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents SuperTooltip1 As DevComponents.DotNetBar.SuperTooltip
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents AddButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents EditButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DeleteButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents AdopterDataGridView As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents RefreshButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents CircularProgress1 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents ExportButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Export2Button As DevComponents.DotNetBar.ButtonX
    Friend WithEvents CircularProgress2 As DevComponents.DotNetBar.Controls.CircularProgress
End Class
